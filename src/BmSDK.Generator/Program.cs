using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using BmSDK.Generator;
using BmSDK.Generator.Utils;
using Spectre.Console;
using Spectre.Console.Cli;
using UELib;
using UELib.Core;

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

        // Create output directory if it doesn't exist
        var sdkDir = Path.Combine(outDir, "SDK/");
        if (!Directory.Exists(sdkDir))
        {
            Directory.CreateDirectory(sdkDir);
        }

        // Load script packages
        var pkgs = new List<UnrealPackage>();
        foreach (var path in Directory.GetFiles(pkgDir, "*.u"))
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

        // Find all classes
        var classes = pkgs.SelectMany(pkg =>
                pkg.Exports.Where(obj => obj.Object is UClass).Select(exp => (UClass)exp.Object)
            )
            .ToList();

        // Deserialize classes
        AnsiConsole.MarkupLine(
            $"\nFound [green]{classes.Count}[/] classes in [green]{pkgs.Count}[/] packages\n"
        );

        // Try decompiling a class
        var classPkg = pkgs.First(pkg => pkg.PackageName == "BmGame");
        var classObject = classPkg.FindObject<UClass>("RCapeConfig");

        // Write classes to output
        foreach (var classObj in classes)
        {
            // Don't generate code for intrinsic classes
            if (CodeGenerator.IsIntrinsicClass(classObj))
            {
                continue;
            }

            // Skip most classes (for now)
            if (
                classObj.Name is not "Actor"
                && classObj.Name is not "Component"
                && classObj.Name is not "ActorComponent"
                && classObj.Name is not "Pawn"
                && classObj.Name is not "RPawn"
                && classObj.Name is not "RCapeConfig"
            )
            {
                continue;
            }

            // Create file
            var path = Path.Combine(sdkDir, $"{classObj.Name}.cs");
            using var stream = File.Create(path);
            using var writer = new StreamWriter(stream);

            // Perform code generation
            CodeGenerator.GenerateClassFile(writer, classObj);
        }

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
