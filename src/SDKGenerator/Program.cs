using SDKGenerator.Utils;
using UELib;
using UELib.Core;

namespace SDKGenerator;

public static class Program
{
    public static void Main()
    {
        var pkgDir =
            "/Users/elikramer/Desktop/depots/Batman Arkham Asylum GOTY/BmGame/CookedPC/unpacked";

        // Enumerate/load script packages
        var pkgs = new List<UnrealPackage>();
        foreach (var path in Directory.GetFiles(pkgDir, "*.u"))
        {
            var name = Path.GetFileNameWithoutExtension(path);

            // Skip most packages (for now)
            if (name is not "Core" && name is not "Engine")
            {
                continue;
            }

            Console.WriteLine($"Loading {name}...");

            // Suppress UELib output
            using (new DisposableBlock(DebugUtils.DisableStdout, DebugUtils.EnableStdout))
            {
                // Load package from file
                var pkg = UnrealLoader.LoadPackage(path, FileAccess.Read);
                pkgs.Add(pkg);

                // Init package
                pkg.InitializePackage(
                    UnrealPackage.InitFlags.RegisterClasses
                        | UnrealPackage.InitFlags.Construct
                        | UnrealPackage.InitFlags.Deserialize
                );

                pkgs.Add(pkg);
            }
        }

        // Find all classes
        var classes = pkgs.SelectMany(pkg =>
                pkg.Exports.Select(exp => exp.Object).Where(obj => obj.IsClassType("Class"))
            )
            .ToList();

        Console.WriteLine($"Found {classes.Count} classes");

        // Test decompile pawn
        var pawnClass = classes.First(c => c.Name == "Pawn");
        pawnClass.BeginDeserializing();

        var src = pawnClass.Decompile();
        Console.WriteLine($"\n{src}");
    }
}
