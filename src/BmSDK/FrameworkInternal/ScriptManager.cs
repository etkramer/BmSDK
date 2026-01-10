using System.Diagnostics;
using System.Reflection;
using System.Runtime.Loader;
using BmSDK.Engine;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.Emit;
using ReferenceAssemblies = Basic.Reference.Assemblies;

namespace BmSDK.Framework;

// TODO: Support hot reload. This can be done using a combination of Compilation.EmitDifference() and MetadataUpdater.ApplyUpdate().
// See https://blog.jetbrains.com/dotnet/2021/12/02/how-rider-hot-reload-works-under-the-hood/
// and https://learn.microsoft.com/en-us/dotnet/api/system.reflection.metadata.metadataupdater.applyupdate

internal static class ScriptManager
{
    public const LanguageVersion LangVer = LanguageVersion.CSharp12;
    public static readonly CSharpParseOptions ParseOptions = CSharpParseOptions.Default.WithLanguageVersion(LangVer);
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
    public static readonly CSharpCompilationOptions CompilerOptions = new(
        OutputKind.DynamicallyLinkedLibrary,
        platform: Platform.X86,
        allowUnsafe: true,
        // TODO: Not clear why this needs to be false.
        concurrentBuild: false,
        optimizationLevel: OptimizationLevel.Debug);
    public const string TargetName = "Scripts.dll";

    private static AssemblyLoadContext? _scriptsAlc = null;
    private static List<Script> _scripts = [];

    public static IEnumerable<Script> Scripts => _scripts;

    public static bool LoadScripts()
    {
        var emitStream = CompileScripts();
        if (emitStream == null) return false;

        // Load in new mods
        RemoveOldScripts();
        _scriptsAlc = new AssemblyLoadContext(TargetName, isCollectible: true);
        var asm = _scriptsAlc.LoadFromStream(emitStream);

        // Instantiate script types.
        var scripts = CreateScriptIntsances(asm);
        _scripts.AddRange(scripts);
        return true;
    }

    private static void RemoveOldScripts()
    {
        if (_scriptsAlc == null) return;

        // Clear function redirects of scripts
        RedirectManager.s_redirectorDict.Clear();

        // Clear scripts attached to in-game actors
        Actor.s_scriptComponents.ForEach(component =>
        {
            component.Owner._scriptComponents.Clear();
        });
        Actor.s_scriptComponents.Clear();

        // Clear mods
        _scripts.Clear();

        // Initiaite closure of AssemblyLoadContext
        _scriptsAlc.Unload();
        _scriptsAlc = null;
    }

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
            CSharpSyntaxTree.ParseText(GlobalUsings, ParseOptions, GlobalUsingsPath)
        );

        // Gather assembly/metadata references
        List<MetadataReference> metadataReferences =
        [
            // Basic .NET 8 assemblies
            // Note: Putting this is in a constant freezes the game if a debugger is attached
            .. ReferenceAssemblies.Net80.References.All,
            // BmSDK.dll
            MetadataReference.CreateFromFile(typeof(GameObject).Assembly.Location),
        ];

        // Set custom AssemblyResolve so we don't try to load things we already have loaded.
        AppDomain.CurrentDomain.AssemblyResolve += (sender, e) =>
            AppDomain
                .CurrentDomain.GetAssemblies()
                .ToList()
                .FirstOrDefault(asm => asm.GetName().ToString() == e.Name);

        // TODO: Perform compilation in another thread.
        Debug.Log(
            $"Compiling {sourceFilePaths.Count} {CommonUtils.FormatPlural(sourceFilePaths.Count, "script")}"
        );
        Debug.Log("(...)");

        var watch = Stopwatch.StartNew();

        // Create compilation from parsed source.
        var compilation = CSharpCompilation
            .Create(TargetName)
            .WithOptions(CompilerOptions)
            .AddReferences(metadataReferences)
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
    private static Diagnostic[] GetErrors(EmitResult emitResult)
    {
        var diags = emitResult.Diagnostics;
        return diags
            .Where(diag => diag.IsWarningAsError || diag.Severity == DiagnosticSeverity.Error)
            .ToArray();
    }

    private static List<Script> CreateScriptIntsances(Assembly asm)
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
}
