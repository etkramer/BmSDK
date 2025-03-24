using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using BmSDK.Generator;
using BmSDK.Generator.Templates;
using BmSDK.Generator.Utils;
using CodegenCS;
using CodegenCS.IO;
using Spectre.Console;
using Spectre.Console.Cli;
using UELib;

var app = new CommandApp<MainCommand>();
return app.Run(args);

sealed class MainCommand : Command<MainCommand.Settings>
{
    public override int Execute([NotNull] CommandContext context, [NotNull] Settings settings)
    {
        var pkgDir = Guard.NotNull(settings.PackageDir);
        var outDir = Guard.NotNull(settings.OutputDir);

        Guard.Require(Directory.Exists(pkgDir), "Package directory does not exist.");
        Guard.Require(Directory.Exists(outDir), "Output directory does not exist.");

        // Load script packages
        var pkgs = new List<UnrealPackage>();
        foreach (
            var path in Directory.GetFiles(pkgDir, "*.u").Concat(Directory.GetFiles(pkgDir, "*.u"))
        )
        {
            var name = Path.GetFileNameWithoutExtension(path);

            // Suppress UELib output
            using (new DisposableBlock(DebugUtils.DisableStdout, DebugUtils.EnableStdout))
            {
                // Load package from file
                var pkg = UnrealLoader.LoadPackage(path, FileAccess.Read);
                pkgs.Add(pkg);
            }
        }

        // Init packages separately
        foreach (var pkg in pkgs)
        {
            AnsiConsole.MarkupLine($"Loading {pkg.PackageName}...");

            // Init package (if not already done as a dependency)
            if (pkg.NeedsInit)
            {
                // Suppress UELib output
                using (new DisposableBlock(DebugUtils.DisableStderr, DebugUtils.EnableStderr))
                {
                    pkg.InitializePackage(UnrealPackage.InitFlags.All);
                }
            }
        }

        // Perform type mapping
        TypeMapper.InitAll(pkgs);

        // Perform code generation
        var ctx = new CodegenContext();
        foreach (var classObj in TypeMapper.Classes)
        {
            // NOTE: Special handling for Core package, which we want to use the 'BmSDK' namespace but be placed in 'BmSDK/Core'.
            var managedPath =
                classObj.Package.PackageName == "Core"
                    ? TypeMapper.GetManagedPathForType(classObj).Replace("BmSDK", "BmSDK.Core")
                    : TypeMapper.GetManagedPathForType(classObj);

            // Perform code generation
            var file = ctx[managedPath.Replace("BmSDK.", "").Replace(".", "/") + ".cs"];
            file.WriteLine(FileTemplate.Render(classObj));
        }

        // Write static init file
        ctx["StaticInit.cs"]
            .WriteLine(StaticInitTemplate.Render(TypeMapper.Classes, TypeMapper.IntrinsicClasses));

        // Create/clear output directory
        var sdkDir = Path.Combine(outDir, "Generated");
        if (!Directory.Exists(sdkDir))
        {
            Directory.CreateDirectory(sdkDir);
        }
        else
        {
            // Delete existing generated files
            Directory.Delete(sdkDir, true);
            Directory.CreateDirectory(sdkDir);
        }

        // Write generated files to disk
        var saveResult = ctx.SaveToFolder(sdkDir);

        // Report results to console
        AnsiConsole.MarkupLine($"Saved [green]{saveResult.SavedFiles.Count}[/] files to disk\n");

        return 0;
    }

    public sealed class Settings : CommandSettings
    {
        [Description("Path containing decompressed script packages.")]
        [CommandArgument(0, "<packageDir>")]
        public string? PackageDir { get; init; }

        [Description("Path where generated code should be placed.")]
        [CommandArgument(1, "<outputDir>")]
        public string? OutputDir { get; init; }
    }
}
