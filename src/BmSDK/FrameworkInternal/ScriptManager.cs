using BmSDK.Engine;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.Emit;
using System.Collections.Immutable;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.Loader;
using ReferenceAssemblies = Basic.Reference.Assemblies;

namespace BmSDK.Framework;

/// <summary>
/// Provides the plugin loading system--compilation and instantiation of user scripts.
/// </summary>
/// <remarks>The ScriptManager class is responsible for discovering user script files, compiling them into an
/// in-memory assembly, and managing their lifecycle through dynamic loading and unloading. It maintains a collection of
/// loaded scripts and exposes options and configuration relevant to script compilation. This class is intended for
/// internal use and is not thread-safe. Scripts are loaded into a collectible AssemblyLoadContext, allowing for
/// complete unloading and reloading of scripts without restarting the application.</remarks>
internal static class ScriptManager
{
    public const LanguageVersion LangVer = LanguageVersion.CSharp12;
    public static readonly CSharpParseOptions ParseOptions = CSharpParseOptions.Default.WithLanguageVersion(LangVer);
    public static readonly ImmutableArray<PortableExecutableReference> DotNetAssemblies = ReferenceAssemblies.Net80.References.All;
    public static readonly ImmutableList<MetadataReference> MetadataReferences =
        [
            .. DotNetAssemblies,
            // BmSDK.dll
            MetadataReference.CreateFromFile(typeof(GameObject).Assembly.Location),
        ];
    public const string GlobalUsings = """
                global using global::System;
                global using global::System.Collections.Generic;
                global using global::System.IO;
                global using global::System.Linq;
                global using global::System.Net.Http;
                global using global::System.Threading;
                global using global::System.Threading.Tasks;

                global using global::BmSDK.Framework;
                """;
    public const string GlobalUsingsPath = "Scripts.GlobalUsings.g.cs";
    public static readonly SyntaxTree GlobalUsingsTree = CSharpSyntaxTree.ParseText(GlobalUsings, ParseOptions, GlobalUsingsPath);
    public static readonly CSharpCompilationOptions CompilerOptions = new(
        OutputKind.DynamicallyLinkedLibrary,
        platform: Platform.X86,
        allowUnsafe: true);
    public const string TargetName = "Scripts.dll";

    private static readonly FileSystemWatcher _watcher = new(FileUtils.GetScriptsPath())
    {
        Filter = "*.cs",
        IncludeSubdirectories = true,
        NotifyFilter = NotifyFilters.LastWrite
                                 | NotifyFilters.FileName
                                 | NotifyFilters.DirectoryName
    };
    private const int DebounceMillis = 500;
    private static readonly Timer _debounceTimer = new(ApplyScriptChangesCallback);
    private static readonly object _lockObj = new();

    private static AssemblyLoadContext? _scriptsAlc;
    private static readonly List<Script> _scripts = [];
    public static IEnumerable<Script> Scripts => _scripts;

    private static bool s_isInitialized = false;

    /// <summary>
    /// Initializes the script system and begins monitoring for script changes.
    /// </summary>
    /// <remarks>This method is only be called once during application startup.</remarks>
    public static void Init()
    {
        if (s_isInitialized) return;
        PrepareCompilation();
        LoadScripts();
        WatchForScriptChanges();
        s_isInitialized = true;
    }

    private static void PrepareCompilation()
    {
        // Set custom AssemblyResolve so we don't try to load things we already have loaded.
        // TODO: Move to custom AssemblyDependencyResolver for _scriptsAlc
        AppDomain.CurrentDomain.AssemblyResolve += (sender, e) =>
            AppDomain
                .CurrentDomain.GetAssemblies()
                .ToList()
                .FirstOrDefault(asm => asm.GetName().ToString() == e.Name);
    }

    /// <summary>
    /// Loads and initializes all available script assemblies for the current context.
    /// </summary>
    /// <remarks>This method compiles user scripts, loads them into a new assembly load context, and instantiates
    /// script types. Previously loaded scripts are removed before new scripts are loaded. If script compilation fails,
    /// no scripts are loaded and the method returns false.</remarks>
    /// <returns>true if the scripts were successfully compiled and loaded; otherwise, false.</returns>
    private static bool LoadScripts()
    {
        // Compile new scripts
        var emitStream = CompileScripts();
        if (emitStream == null) return false;

        // Load in new mods and instantiate script types
        var scriptsAlc = new AssemblyLoadContext(TargetName, isCollectible: true);
        var asm = scriptsAlc.LoadFromStream(emitStream);

        // Register scripts on main thread
        EngineSynchronizationContext.Instance.Post(_ =>
        {
            RemoveOldScripts();
            _scriptsAlc = scriptsAlc;
            _scripts.AddRange(CreateScriptInstances(asm));
            if (s_isInitialized)
                _scripts.ForEach(script => script.OnLoad());
        },
        state: null);
        
        return true;
    }

    /// <summary>
    /// Unloads the current script assembly context and clears all registered script components and mods.
    /// </summary>
    /// <remarks>This method should be called when scripts need to be fully unloaded and detached from in-game
    /// actors, such as during a reload operation. After execution, the script assembly context is released
    /// and cannot be reused until reinitialized using <see cref="LoadScripts"/>.</remarks>
    private static void RemoveOldScripts()
    {
        if (_scriptsAlc == null) return;

        // TODO: Kill threads by mods when async support is added

        // Clear scripts attached to in-game actors
        Actor.DetachAllScriptComponents();

        // Clear mods
        UnloadScripts();

        // Clear function redirects of scripts
        RedirectManager.UnregisterAllRedirectors();

        // Initiaite closure of AssemblyLoadContext
        _scriptsAlc.Unload();
        _scriptsAlc = null;
        GC.Collect();
        GC.WaitForPendingFinalizers();
    }

    private static void UnloadScripts()
    {
        _scripts.ForEach(script => script.OnUnload());
        _scripts.Clear();
    }

    /// <summary>
    /// Compiles all C# script files found in the scripts directory into an in-memory assembly stream.
    /// </summary>
    /// <remarks>The returned stream is positioned at the beginning and contains the compiled assembly in
    /// memory. The method logs warnings if no scripts are found and outputs compilation errors to the log if
    /// compilation fails. This method is intended for internal use and does not perform compilation on a separate
    /// thread (yet).</remarks>
    /// <returns>A <see cref="MemoryStream"/> containing the compiled assembly if compilation succeeds; otherwise, <see
    /// langword="null"/> if no scripts are found or compilation fails.</returns>
    private static MemoryStream? CompileScripts()
    {
        // Find directories (note we're relative to the host asi)
        var baseDir = FileUtils.GetBasePath();
        var scriptDir = FileUtils.GetScriptsPath();

        // Read C# source files from disk
        var sourceFilePaths = Directory
            .EnumerateFiles(scriptDir, "*.cs", SearchOption.AllDirectories)
            .Where(filePath => !filePath.Replace("\\", "/").Contains("/obj/"))
            .ToList();

        // If no scripts found, return false
        if (sourceFilePaths.Count == 0)
        {
            Debug.LogWarning($"No script files found in .\\{Path.GetRelativePath(baseDir, scriptDir)}");
            return null;
        }

        // Parse C# sources with Roslyn
        var syntaxTrees = sourceFilePaths
            .Select(filePath => CSharpSyntaxTree.ParseText(File.ReadAllText(filePath), ParseOptions, filePath))
            .ToList();

        // Parse generated sources (for global usings, etc.)
        syntaxTrees.Insert(
            index: 0,
            GlobalUsingsTree
        );

        Debug.Log(
            $"Compiling {sourceFilePaths.Count} {CommonUtils.FormatPlural(sourceFilePaths.Count, "script")}"
        );
        Debug.Log("(...)");

        var watch = Stopwatch.StartNew();

        // Create compilation from parsed source.
        var compilation = CSharpCompilation
            .Create(TargetName)
            .WithOptions(CompilerOptions)
            .AddReferences(MetadataReferences)
            .AddSyntaxTrees(syntaxTrees);

        // Emit assembly in-memory.
        var emitStream = new MemoryStream();
        var emitResult = compilation.Emit(emitStream);

        // Did we succeed?
        if (!emitResult.Success)
        {
            PrintErrors(emitResult, scriptDir);
            return null;
        }        

        // Report compilation duration.
        watch.Stop();
        Debug.Log(
            $"Success! {sourceFilePaths.Count} {CommonUtils.FormatPlural(sourceFilePaths.Count, "script")} compiled in {watch.Elapsed.FormatDuration()}"
        );

        emitStream.Position = 0;
        return emitStream;
    }

    /// <summary>
    /// Prints compilation errors grouped by source file to the debug log.
    /// </summary>
    /// <remarks>Each error is displayed with its file location, error code, and message. Errors are grouped
    /// by file, and file paths are shown relative to the specified scripts directory to improve readability.</remarks>
    /// <param name="emitResult">The result of the compilation process containing diagnostics to be reported.</param>
    /// <param name="scriptsDir">The root directory used to display relative file paths for error reporting.</param>
    private static void PrintErrors(EmitResult emitResult, string scriptsDir)
    {
        // Retrieve errors from the emit result.
        var errors = GetErrors(emitResult);
        var errorsByFilePath = errors
            .GroupBy(error => error.Location.SourceTree?.FilePath ?? "(no file)")
            .ToDictionary(group => group.Key, group => group.ToArray());

        // Print compilation errors by file.
        foreach (var filePath in errorsByFilePath.Keys)
        {
            var shortPath = Path.GetRelativePath(scriptsDir, filePath);
            Debug.LogError(
                $"{shortPath}: {errorsByFilePath[filePath].Length} errors:",
                skipSender: true);

            foreach (var error in errorsByFilePath[filePath])
            {
                // Grab error location for printing.
                var lineSpan = error.Location.GetLineSpan();
                var mappedLineSpan = error.Location.GetMappedLineSpan();
                if (mappedLineSpan.HasMappedPath)
                {
                    lineSpan = mappedLineSpan;
                }

                // Print error location.
                var locationText = "";
                if (lineSpan.IsValid)
                {
                    var pos = lineSpan.StartLinePosition;
                    locationText = $"({pos.Line + 1}) ";
                }

                // Print error.
                Debug.LogError(
                    $"  {locationText}{error.Id}: {error.GetMessage()}",
                    skipSender: true);
            }
        }

        // Print failed message.
        Debug.LogError($"Compilation failed!");
    }

    /// <summary>
    /// Retrieves all diagnostics from the specified emit result that represent errors or warnings treated as errors.
    /// </summary>
    private static Diagnostic[] GetErrors(EmitResult emitResult)
    {
        var diags = emitResult.Diagnostics;
        return diags
            .Where(diag => diag.IsWarningAsError || diag.Severity == DiagnosticSeverity.Error)
            .ToArray();
    }

    /// <summary>
    /// Instatiates all Scripts in the specified assembly.
    /// </summary>
    /// <param name="asm">The assembly to search for script types. Only types that inherit from Script and are decorated with
    /// ScriptAttribute are considered.</param>
    /// <returns>A list of Script instances created from the eligible types found in the assembly. The list will be empty if no
    /// matching types are found.</returns>
    private static List<Script> CreateScriptInstances(Assembly asm)
    {
        // Scripts must both extend Script and be marked with [Script].
        var scriptTypes = asm.GetTypes()
            .Where(type => type.GetCustomAttribute<ScriptAttribute>() is not null)
            .Where(type => type.IsAssignableTo(typeof(Script)));

        var scripts = new List<Script>();
        foreach (var scriptType in scriptTypes)
        {
            var scriptAttribute = scriptType.GetCustomAttribute<ScriptAttribute>()!;
            var scriptName = scriptAttribute.Name ?? scriptType.Name;

            try
            {
                var script = (Script)Guard.NotNull(Activator.CreateInstance(scriptType));
                script.Name = scriptName;
                scripts.Add(script);
            }
            catch (Exception e)
            {
                Debug.LogError(
                    $"Failed to create instance of script {scriptName}: {e.Message}",
                    skipSender: true
                );

                continue;
            }
        }

        return scripts;
    }

    private static void WatchForScriptChanges()
    {
        _watcher.Changed += OnScriptChangedDebounced;
        _watcher.Created += OnScriptChangedDebounced;
        _watcher.Deleted += OnScriptChangedDebounced;
        _watcher.Renamed += OnScriptChangedDebounced;

        _watcher.EnableRaisingEvents = true;
    }

    private static void OnScriptChangedDebounced(object sender, FileSystemEventArgs e)
        => _debounceTimer.Change(DebounceMillis, Timeout.Infinite);

    private static void ApplyScriptChangesCallback(object? state)
    {
        lock (_lockObj) LoadScripts();
    }
}
