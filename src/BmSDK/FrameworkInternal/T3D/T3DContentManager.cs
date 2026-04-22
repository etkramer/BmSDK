using System.Globalization;
using System.Numerics;
using BmSDK.Engine;

namespace BmSDK.Framework.T3D;

internal static class T3DContentManager
{
    private static readonly Dictionary<string, List<T3DActorDefinition>> s_contentByMod = [];
    private static readonly Lock s_lockObj = new();
    private static readonly Dictionary<string, Timer> s_debounceTimers = [];
    private static FileSystemWatcher? s_contentWatcher;

    private const int DebounceMillis = 500;

    public static void Init()
    {
        WatchForContentChanges();
    }

    public static void DiscoverContent(Mod mod)
    {
        var contentDir = Path.Combine(mod.DirectoryPath, "content");
        if (!Directory.Exists(contentDir))
        {
            return;
        }

        var definitions = new List<T3DActorDefinition>();
        var t3dFiles = Directory.EnumerateFiles(contentDir, "*.t3d", SearchOption.AllDirectories);

        foreach (var filePath in t3dFiles)
        {
            try
            {
                var objectPath = FilePathToObjectPath(contentDir, filePath);
                var definition = T3DParser.ParseFile(filePath, objectPath);
                definitions.Add(definition);
            }
            catch (Exception ex)
            {
                Debug.LogError($"[{mod.Name}] T3D: Failed to parse {Path.GetFileName(filePath)}: {ex.Message}");
            }
        }

        if (definitions.Count > 0)
        {
            lock (s_lockObj)
            {
                s_contentByMod[mod.DirectoryPath] = definitions;
            }
            Debug.Log($"[{mod.Name}] T3D: Discovered {definitions.Count} content {CommonUtils.FormatPlural(definitions.Count, "file")}");
        }
    }

    public static void UnloadContent(Mod mod)
    {
        lock (s_lockObj)
        {
            s_contentByMod.Remove(mod.DirectoryPath);
        }
    }

    public static void ApplyContentForLevel(Level level)
    {
        var levelPath = level.GetPathName();
        var normalizedLevelPath = NormalizePath(levelPath);

        List<T3DActorDefinition> definitions;
        lock (s_lockObj)
        {
            definitions = s_contentByMod.Values
                .SelectMany(list => list)
                .Where(d => NormalizePath(d.ObjectPath)
                    .StartsWith(normalizedLevelPath + ".", StringComparison.OrdinalIgnoreCase))
                .ToList();
        }

        if (definitions.Count == 0)
        {
            return;
        }

        foreach (var definition in definitions)
        {
            try
            {
                ApplyDefinition(definition, level);
            }
            catch (Exception ex)
            {
                Debug.LogError($"T3D: Failed to apply {definition.ObjectPath}: {ex.Message}");
            }
        }
    }

    private static void ApplyDefinition(T3DActorDefinition definition, Level level)
    {
        // Build the real UE3 path using the level's actual path (which has correct : separators)
        var levelPath = level.GetPathName();
        var normalizedObjPath = NormalizePath(definition.ObjectPath);
        var normalizedLevelPath = NormalizePath(levelPath);
        var suffix = normalizedObjPath[normalizedLevelPath.Length..];
        var resolvedPath = levelPath + suffix;

        var existing = Game.FindObject<Actor>(resolvedPath);

        if (existing is not null && existing.IsValid)
        {
            T3DPropertyApplicator.ApplyProperties(existing, definition);
            Debug.Log(
                $"T3D: Applied {definition.Properties.Count + definition.SubObjects.Sum(s => s.Properties.Count)} "
                + $"properties to {definition.ObjectPath}"
            );
        }
        else
        {
            SpawnFromDefinition(definition, level);
        }
    }

    private static unsafe void SpawnFromDefinition(T3DActorDefinition definition, Level level)
    {
        // Resolve class by short name
        var actorClass = FindClassByName(definition.ClassName);
        if (actorClass is null)
        {
            Debug.LogError($"T3D: Class '{definition.ClassName}' not found, cannot spawn {definition.ObjectPath}");
            return;
        }

        // Extract location/rotation from properties before spawning
        var location = ExtractVector(definition.Properties, "Location");
        var rotation = ExtractRotator(definition.Properties, "Rotation");

        var actor = Game.SpawnActor(actorClass, location, rotation);
        if (actor is null || !actor.IsValid)
        {
            Debug.LogError($"T3D: Failed to spawn actor for {definition.ObjectPath}");
            return;
        }

        T3DPropertyApplicator.ApplyProperties(actor, definition);
        actor.ForceUpdateComponents(true);

        Debug.Log($"T3D: Spawned {definition.ClassName} at {definition.ObjectPath}");
    }

    private static Class? FindClassByName(string className)
    {
        try
        {
            return GameObject.StaticFindObjectChecked<Class>(null, null, className, false);
        }
        catch
        {
            return null;
        }
    }

    private static Vector3 ExtractVector(List<T3DProperty> properties, string name)
    {
        var prop = properties.FirstOrDefault(p =>
            p.Name.Equals(name, StringComparison.OrdinalIgnoreCase)
        );

        if (prop is null)
        {
            return default;
        }

        var fields = T3DParser.ParseStructLiteral(prop.Value);
        return new Vector3(
            fields.TryGetValue("X", out var x) ? float.Parse(x, CultureInfo.InvariantCulture) : 0,
            fields.TryGetValue("Y", out var y) ? float.Parse(y, CultureInfo.InvariantCulture) : 0,
            fields.TryGetValue("Z", out var z) ? float.Parse(z, CultureInfo.InvariantCulture) : 0
        );
    }

    private static Rotator ExtractRotator(List<T3DProperty> properties, string name)
    {
        var prop = properties.FirstOrDefault(p =>
            p.Name.Equals(name, StringComparison.OrdinalIgnoreCase)
        );

        if (prop is null)
        {
            return default;
        }

        var fields = T3DParser.ParseStructLiteral(prop.Value);
        return Rotator.FromRuu(
            fields.TryGetValue("Pitch", out var p) ? int.Parse(p, CultureInfo.InvariantCulture) : 0,
            fields.TryGetValue("Yaw", out var y) ? int.Parse(y, CultureInfo.InvariantCulture) : 0,
            fields.TryGetValue("Roll", out var r) ? int.Parse(r, CultureInfo.InvariantCulture) : 0
        );
    }

    private static string NormalizePath(string path) => path.Replace(':', '.');

    private static string FilePathToObjectPath(string contentDir, string filePath)
    {
        var relative = Path.GetRelativePath(contentDir, filePath);
        var withoutExtension = Path.ChangeExtension(relative, null);
        return withoutExtension
            .Replace(Path.DirectorySeparatorChar, '.')
            .Replace(Path.AltDirectorySeparatorChar, '.');
    }

    // --- Hot-reload ---

    public static void ReloadContentFile(string filePath)
    {
        lock (s_lockObj)
        {
            foreach (var (modDir, definitions) in s_contentByMod)
            {
                var contentDir = Path.Combine(modDir, "content");
                if (!filePath.StartsWith(contentDir, StringComparison.OrdinalIgnoreCase))
                {
                    continue;
                }

                var objectPath = FilePathToObjectPath(contentDir, filePath);

                // Remove old definition
                definitions.RemoveAll(d =>
                    d.ObjectPath.Equals(objectPath, StringComparison.OrdinalIgnoreCase)
                );

                // Parse and add new definition
                if (File.Exists(filePath))
                {
                    try
                    {
                        var definition = T3DParser.ParseFile(filePath, objectPath);
                        definitions.Add(definition);

                        // Re-apply to existing object on the game thread
                        EngineSynchronizationContext.Instance.Post(
                            _ =>
                            {
                                var existing = Game.FindObject<Actor>(objectPath);
                                if (existing is not null && existing.IsValid)
                                {
                                    T3DPropertyApplicator.ApplyProperties(existing, definition);
                                    existing.ForceUpdateComponents(true);
                                    Debug.Log($"T3D: Hot-reloaded {objectPath}");
                                }
                            },
                            state: null
                        );
                    }
                    catch (Exception ex)
                    {
                        Debug.LogError($"T3D: Failed to hot-reload {Path.GetFileName(filePath)}: {ex.Message}");
                    }
                }

                break;
            }
        }
    }

    private static void WatchForContentChanges()
    {
        var modsDir = FileUtils.GetModsPath();
        if (!Directory.Exists(modsDir))
        {
            return;
        }

        s_contentWatcher = new FileSystemWatcher(modsDir)
        {
            Filter = "*.t3d",
            IncludeSubdirectories = true,
            NotifyFilter = NotifyFilters.LastWrite | NotifyFilters.FileName,
        };

        s_contentWatcher.Changed += OnContentFileChanged;
        s_contentWatcher.Created += OnContentFileChanged;
        s_contentWatcher.Deleted += OnContentFileChanged;
        s_contentWatcher.EnableRaisingEvents = true;
    }

    private static void OnContentFileChanged(object sender, FileSystemEventArgs e)
    {
        if (!s_debounceTimers.TryGetValue(e.FullPath, out var timer))
        {
            timer = new Timer(_ => ReloadContentFile(e.FullPath));
            s_debounceTimers[e.FullPath] = timer;
        }

        timer.Change(DebounceMillis, Timeout.Infinite);
    }
}
