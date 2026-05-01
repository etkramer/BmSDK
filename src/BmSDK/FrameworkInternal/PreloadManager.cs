using Tomlyn.Model;

namespace BmSDK.Framework;

/// <summary>
/// Handles mod [preload] sections: loads declared packages, roots declared objects,
/// and purges any side-effect objects (e.g. stray Levels) via a final GC pass.
/// </summary>
internal static class PreloadManager
{
    public static void Run()
    {
        foreach (var mod in ScriptManager.Mods)
        {
            PreloadMod(mod);
        }

        // Clean up anything we didn't need
        GameFunctions.CollectGarbage(0, bPerformFullPurge: 1);
    }

    private static void PreloadMod(Mod mod)
    {
        if (!mod.Config.TryGetValue("preload", out var preloadObj)
            || preloadObj is not TomlTable preload)
        {
            return;
        }

        if (preload.TryGetValue("packages", out var pkgsObj) && pkgsObj is TomlArray pkgs)
        {
            foreach (var entry in pkgs)
            {
                if (entry is not string pkgName)
                {
                    continue;
                }

                var loaded = Game.LoadPackage(pkgName);
                if (loaded is null || !loaded.IsValid)
                {
                    Debug.LogWarning($"[{mod.Name}] Preload: failed to load package '{pkgName}'");
                }
            }
        }

        if (preload.TryGetValue("keep_alive", out var keepObj) && keepObj is TomlArray keepAlives)
        {
            foreach (var entry in keepAlives)
            {
                if (entry is not string path)
                {
                    continue;
                }

                var obj = Game.FindObject<GameObject>(path);
                if (obj is null || !obj.IsValid)
                {
                    Debug.LogWarning(
                        $"[{mod.Name}] Preload: keep_alive object '{path}' not found"
                    );
                    continue;
                }

                obj.AddToRoot();
            }
        }
    }
}
