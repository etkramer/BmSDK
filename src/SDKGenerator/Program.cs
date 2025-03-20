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
            if (name is not "Core" && name is not "Engine" && name is not "BmGame")
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
                pkg.InitializePackage(UnrealPackage.InitFlags.All);
            }
        }

        // Find all classes
        var classes = pkgs.SelectMany(pkg =>
                pkg.Exports.Select(exp => exp.Object).Where(obj => obj.IsClassType("Class"))
            )
            .ToList();

        // Deserialize classes
        Console.WriteLine($"Found {classes.Count} classes");
        foreach (UClass classObj in classes)
        {
            classObj
                .EnumerateSuper()
                .Reverse()
                .ToList()
                .ForEach(super => super.BeginDeserializing());
            classObj.BeginDeserializing();
        }

        // Test decompile Pawn CDO
        var enginePkg = pkgs.First(pkg => pkg.PackageName == "BmGame");
        var pawnClass = enginePkg.FindObject<UClass>("RPlayerController");

        // Console.WriteLine(pawnClass.ExportTable.ClassIndex);
        pawnClass.BeginDeserializing();
        foreach (var prop in pawnClass.EnumerateFields())
        {
            Console.WriteLine($"{prop.Name} ({prop.GetType().Name})");
        }

        pawnClass.Super.BeginDeserializing();
        Console.WriteLine(pawnClass.Super.EnumerateFields().Count());
    }
}
