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

        // Load script packages
        var pkgs = new List<UnrealPackage>();
        foreach (var path in Directory.GetFiles(pkgDir, "*.u"))
        {
            var name = Path.GetFileNameWithoutExtension(path);
            Console.WriteLine($"Loading {name}...");

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
            // Init package
            pkg.InitializePackage(UnrealPackage.InitFlags.All);
        }

        // Find all classes
        var classes = pkgs.SelectMany(pkg =>
                pkg.Exports.Where(obj => obj.Object is UClass).Select(exp => (UClass)exp.Object)
            )
            .ToList();

        // Deserialize classes
        Console.WriteLine($"\nFound {classes.Count} classes in {pkgs.Count} packages\n");

        // Try decompiling a class
        var classPkg = pkgs.First(pkg => pkg.PackageName == "BmGame");
        var classObject = classPkg.FindObject<UClass>("RPlayerController");

        // Print class info
        Console.WriteLine($"{classObject.Name}: {classObject.EnumerateFields().Count()} fields");
        foreach (var super in classObject.EnumerateSuper())
        {
            Console.WriteLine($"{super.Name}: {super.EnumerateFields().Count()} fields");
        }
    }
}
