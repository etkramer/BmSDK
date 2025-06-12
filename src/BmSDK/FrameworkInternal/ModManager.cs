using System.Reflection;

namespace BmSDK.Framework;

internal static class ModManager
{
    static readonly List<GameMod> s_modInstances = [];

    public static IEnumerable<GameMod> Mods => s_modInstances;

    public static void Init()
    {
        // Prepare for assembly loading
        AppDomain.CurrentDomain.AssemblyResolve += (sender, e) =>
        {
            // Try to see if we already have this assembly loaded
            return AppDomain
                .CurrentDomain.GetAssemblies()
                .ToList()
                .FirstOrDefault(asm => asm.GetName().ToString() == e.Name);
        };

        // Find mods (note we're relative to the host asi)
        var modsDir = Path.Combine(Environment.CurrentDirectory, "..", "mods");
        if (Directory.Exists(modsDir))
        {
            foreach (var modDir in Directory.GetDirectories(modsDir))
            {
                // Load mod assembly
                var modName = Path.GetFileName(modDir);
                var modPath = Path.Combine(modDir, $"{modName}.dll");
                if (!File.Exists(modPath))
                {
                    Debug.LogWarning($"Couldn't find assembly {modName}.dll");
                    continue;
                }

                var modAssembly = Assembly.LoadFile(modPath);

                // Locate mod instance type
                var modType = modAssembly
                    .GetTypes()
                    .Where(type => type.IsAssignableTo(typeof(GameMod)))
                    .FirstOrDefault();

                if (modType is null)
                {
                    Debug.Log($"No {nameof(GameMod)} type found in {modName}");
                    continue;
                }
                else
                {
                    // Instantiate mod type
                    var modInstance = Guard.NotNull(
                        Activator.CreateInstance(modType) as GameMod,
                        $"Failed to instantiate mod {modName}"
                    );

                    s_modInstances.Add(modInstance);
                }
            }
        }

        // Report successful load
        Debug.Log($"Loaded {s_modInstances.Count} mod(s)");
    }
}
