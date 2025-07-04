using System.Diagnostics;
using System.Reflection;
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
    static Assembly? s_scriptsAssembly = null;
    static readonly List<Script> s_scriptInstances = [];

    public static IEnumerable<Script> Scripts => s_scriptInstances;

    public static bool LoadScripts()
    {
        // Find directories (note we're relative to the host asi)
        var baseDir = FileUtils.GetBasePath();
        var scriptDir = Path.Combine(baseDir, "BmGame\\Scripts\\");

        // Read C# source files from disk
        var sourceFiles = Directory
            .EnumerateFiles(scriptDir, "*.cs", SearchOption.AllDirectories)
            .Where(file => !file.Replace("\\", "/").Contains("/obj/"))
            .ToList();

        // If no scripts found, return false
        if (sourceFiles.Count == 0)
        {
            Debug.LogWarning(
                $"No script files found in .\\{Path.GetRelativePath(baseDir, scriptDir)}"
            );

            return false;
        }

        // Parse C# sources with Roslyn
        var parseOptions = CSharpParseOptions.Default.WithLanguageVersion(LanguageVersion.CSharp12);
        var syntaxTrees = sourceFiles
            .Select(file => CSharpSyntaxTree.ParseText(File.ReadAllText(file), parseOptions, file))
            .ToList();

        // Parse generated sources (for global usings, etc.)
        {
            syntaxTrees.Insert(
                0,
                CSharpSyntaxTree.ParseText(
                    """
                    global using global::System;
                    global using global::System.Collections.Generic;
                    global using global::System.IO;
                    global using global::System.Linq;
                    global using global::System.Net.Http;
                    global using global::System.Threading;
                    global using global::System.Threading.Tasks;

                    global using global::BmSDK.Framework;
                    """,
                    parseOptions,
                    "Scripts.GlobalUsings.g.cs"
                )
            );
        }

        // Gather assembly/metadata references
        List<MetadataReference> metadataReferences =
        [
            // Basic .NET 8 assemblies
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
        var watch = Stopwatch.StartNew();
        Debug.Log(
            $"Compiling {sourceFiles.Count} {CommonUtils.FormatPlural(sourceFiles.Count, "script")}"
        );
        Debug.Log("(...)");
        {
            // Create compilation from parsed source.
            var compilation = CSharpCompilation
                .Create("Scripts.dll")
                .WithOptions(
                    new CSharpCompilationOptions(
                        OutputKind.DynamicallyLinkedLibrary,
                        platform: Platform.X86,
                        allowUnsafe: true,
                        // TODO: Not clear why this needs to be false.
                        concurrentBuild: false,
                        optimizationLevel: OptimizationLevel.Debug
                    )
                )
                .AddReferences(metadataReferences)
                .AddSyntaxTrees(syntaxTrees);

            // Emit assembly in-memory.
            var emitStream = new MemoryStream();
            var emitResult = compilation.Emit(emitStream);

            // Did we succeed?
            if (!emitResult.Success)
            {
                // Retrieve errors from the emit result.
                var errors = GetErrors(emitResult);
                var errorsByFilePath = errors
                    .GroupBy(error => error.Location.SourceTree?.FilePath ?? "(no file)")
                    .ToDictionary(group => group.Key, group => group.ToArray());

                // Print compilation errors by file.
                foreach (var filePath in errorsByFilePath.Keys)
                {
                    var shortPath = Path.GetRelativePath(scriptDir, filePath);
                    Debug.LogError(
                        $"{shortPath}: {errorsByFilePath[filePath].Length} errors:",
                        true
                    );

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
                        Debug.LogError($"  {locationText}{error.Id}: {error.GetMessage()}", true);
                    }
                }

                // Print failed message.
                Debug.LogError($"Compilation failed!");
                return false;
            }

            // Load into Assembly object.
            emitStream.Position = 0;
            s_scriptsAssembly = Assembly.Load(emitStream.ToArray());
        }

        // Report compilation duration.
        watch.Stop();
        Debug.Log(
            $"Success! {sourceFiles.Count} {CommonUtils.FormatPlural(sourceFiles.Count, "script")} compiled in {watch.Elapsed.FormatDuration()}"
        );

        // Instantiate script types.
        var scripts = GetScripts(s_scriptsAssembly);
        s_scriptInstances.AddRange(scripts);

        return true;
    }

    static Script[] GetScripts(Assembly asm)
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
                    true
                );

                continue;
            }
        }

        return scripts.ToArray();
    }

    static Diagnostic[] GetErrors(EmitResult emitResult)
    {
        var diags = emitResult.Diagnostics;
        return diags
            .Where(diag => diag.IsWarningAsError || diag.Severity == DiagnosticSeverity.Error)
            .ToArray();
    }
}
