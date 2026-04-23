using System.Globalization;
using System.Numerics;
using BmSDK.Engine;

namespace BmSDK.Framework.T3D;

internal static unsafe class T3DContentManager
{
    private const int SpecializedPropertyFieldOffset = 88;
    private const int DebounceMillis = 500;

    private static readonly Dictionary<string, List<T3DActorDefinition>> s_contentByMod = [];
    private static readonly Lock s_lockObj = new();
    private static readonly Dictionary<string, Timer> s_debounceTimers = [];
    private static FileSystemWatcher? s_contentWatcher;

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
            ApplyProperties(existing, definition);
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

    private static void SpawnFromDefinition(T3DActorDefinition definition, Level level)
    {
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

        ApplyProperties(actor, definition);
        actor.ForceUpdateComponents(true);

        Debug.Log($"T3D: Spawned {definition.ClassName} at {definition.ObjectPath}");
    }

    // --- Property application ---

    private static void ApplyProperties(GameObject target, T3DActorDefinition definition)
    {
        ApplyPropertyList(target.Ptr, BuildPropertyMap(target.Class), definition.Properties);

        foreach (var subObject in definition.SubObjects)
        {
            ApplySubObject(target, subObject);
        }
    }

    private static void ApplySubObject(GameObject target, T3DSubObject subObject)
    {
        var component = FindSubObject(target, subObject.ObjectName);
        if (component is null)
        {
            Debug.LogWarning(
                $"T3D: SubObject '{subObject.ObjectName}' not found on {target.GetPathName()}"
            );
            return;
        }

        ApplyPropertyList(component.Ptr, BuildPropertyMap(component.Class), subObject.Properties);
    }

    private static GameObject? FindSubObject(GameObject target, string subObjectName)
    {
        if (target is not Actor actor)
        {
            return null;
        }

        // T3D refers to the archetype/template name from the CDO. Spawned component
        // instances carry that template as ObjectArchetype but may have a uniquified
        // instance name, so match on archetype name first and fall back to the
        // instance name for hand-written T3Ds that reference a live component directly.
        GameObject? byName = null;
        foreach (var component in actor.AllComponents)
        {
            if (!component.IsValid)
            {
                continue;
            }

            var archetype = component.ObjectArchetype;
            if (archetype is not null && archetype.IsValid
                && archetype.Name.ToString().Equals(subObjectName, StringComparison.OrdinalIgnoreCase))
            {
                return component;
            }

            if (byName is null
                && component.Name.ToString().Equals(subObjectName, StringComparison.OrdinalIgnoreCase))
            {
                byName = component;
            }
        }

        if (byName is not null)
        {
            return byName;
        }

        // Fallback: some actors keep components outside AllComponents (e.g.
        // StaticLightCollectionActor.LightComponents). Resolve directly by path.
        return Game.FindObject<GameObject>($"{actor.GetPathName()}.{subObjectName}");
    }

    private static void ApplyPropertyList(
        IntPtr basePtr,
        Dictionary<string, Property> propertyMap,
        List<T3DProperty> properties
    )
    {
        foreach (var t3dProp in properties)
        {
            if (!propertyMap.TryGetValue(t3dProp.Name, out var prop))
            {
                Debug.LogWarning($"T3D: Property '{t3dProp.Name}' not found");
                continue;
            }

            try
            {
                ApplyValue(basePtr, prop, t3dProp.Value);
            }
            catch (Exception ex)
            {
                Debug.LogWarning(
                    $"T3D: Failed to apply '{t3dProp.Name}={t3dProp.Value}': {ex.Message}"
                );
            }
        }
    }

    private static void ApplyValue(IntPtr basePtr, Property prop, string value)
    {
        var dest = basePtr + prop.Offset;

        switch (prop)
        {
            case FloatProperty:
                MarshalUtil.ToUnmanaged(float.Parse(value, CultureInfo.InvariantCulture), dest);
                break;

            case IntProperty:
                MarshalUtil.ToUnmanaged(int.Parse(value, CultureInfo.InvariantCulture), dest);
                break;

            case BoolProperty boolProp:
                ApplyBoolValue(basePtr, boolProp, ParseBool(value));
                break;

            case ByteProperty byteProp:
                ApplyByteValue(dest, byteProp, value);
                break;

            case NameProperty:
                MarshalUtil.ToUnmanaged(new FName(value), dest);
                break;

            case StrProperty:
                MarshalUtil.ToUnmanaged(new FString(StripQuotes(value)), dest);
                break;

            case ObjectProperty:
                ApplyObjectValue(dest, value);
                break;

            case StructProperty structProp:
                ApplyStructValue(basePtr, structProp, value);
                break;

            default:
                Debug.LogWarning($"T3D: Unsupported property type '{prop.Class.Name}'");
                break;
        }
    }

    private static void ApplyByteValue(IntPtr dest, ByteProperty prop, string value)
    {
        if (byte.TryParse(value, NumberStyles.Integer, CultureInfo.InvariantCulture, out var num))
        {
            MarshalUtil.ToUnmanaged(num, dest);
            return;
        }

        // UE3 T3D writes enum-backed bytes as the enum member name. Resolve it
        // by looking up the name in the UEnum's Names array (offset 48, right
        // after UField).
        var enumPtr = MarshalUtil.ToManaged<IntPtr>(prop.Ptr + SpecializedPropertyFieldOffset);
        if (enumPtr == IntPtr.Zero)
        {
            throw new FormatException($"'{value}' is not a valid byte");
        }

        var names = new TArray<FName>(enumPtr + 48);
        for (var i = 0; i < names.Count; i++)
        {
            if (names[i].ToString().Equals(value, StringComparison.OrdinalIgnoreCase))
            {
                MarshalUtil.ToUnmanaged((byte)i, dest);
                return;
            }
        }

        throw new FormatException($"Enum value '{value}' not found");
    }

    private static void ApplyBoolValue(IntPtr basePtr, BoolProperty prop, bool value)
    {
        var bitMask = MarshalUtil.ToManaged<int>(prop.Ptr + SpecializedPropertyFieldOffset);
        var packed = (int*)(basePtr + prop.Offset);
        *packed = value ? (*packed | bitMask) : (*packed & ~bitMask);
    }

    private static void ApplyObjectValue(IntPtr dest, string value)
    {
        if (value.Equals("None", StringComparison.OrdinalIgnoreCase))
        {
            MarshalUtil.ToUnmanaged(IntPtr.Zero, dest);
            return;
        }

        // Handle Class'Path' references (e.g. PointLightComponent'Package.Outer.Name')
        var path = value;
        var quoteStart = value.IndexOf('\'');
        if (quoteStart >= 0)
        {
            var quoteEnd = value.LastIndexOf('\'');
            if (quoteEnd > quoteStart)
            {
                path = value[(quoteStart + 1)..quoteEnd];
            }
        }

        var referenced = Game.FindObject<GameObject>(path);
        if (referenced is not null && referenced.IsValid)
        {
            MarshalUtil.ToUnmanaged(referenced.Ptr, dest);
        }
        else
        {
            Debug.LogWarning($"T3D: Referenced object '{path}' not found");
        }
    }

    private static void ApplyStructValue(IntPtr basePtr, StructProperty structProp, string value)
    {
        var structTypePtr = MarshalUtil.ToManaged<IntPtr>(
            structProp.Ptr + SpecializedPropertyFieldOffset
        );
        if (structTypePtr == IntPtr.Zero)
        {
            Debug.LogWarning($"T3D: StructProperty '{structProp.Name}' has no struct type");
            return;
        }

        var structType = MarshalUtil.ToManaged<Struct>(&structTypePtr);
        var structBase = basePtr + structProp.Offset;

        var fields = T3DParser.ParseStructLiteral(value);
        var subPropertyMap = BuildPropertyMap(structType);

        foreach (var (fieldName, fieldValue) in fields)
        {
            if (!subPropertyMap.TryGetValue(fieldName, out var subProp))
            {
                Debug.LogWarning(
                    $"T3D: Struct field '{fieldName}' not found in '{structProp.Name}'"
                );
                continue;
            }

            try
            {
                ApplyValue(structBase, subProp, fieldValue);
            }
            catch (Exception ex)
            {
                Debug.LogWarning(
                    $"T3D: Failed to apply struct field '{fieldName}={fieldValue}': {ex.Message}"
                );
            }
        }
    }

    private static Dictionary<string, Property> BuildPropertyMap(Struct structType)
    {
        var map = new Dictionary<string, Property>(StringComparer.OrdinalIgnoreCase);
        foreach (var structDef in structType.EnumerateSupersAndSelf())
        {
            foreach (var field in structDef.EnumerateFields())
            {
                if (field is Property prop)
                {
                    map.TryAdd(prop.Name.ToString(), prop);
                }
            }
        }

        return map;
    }

    private static bool ParseBool(string value) =>
        value.Equals("True", StringComparison.OrdinalIgnoreCase) || value == "1";

    private static string StripQuotes(string value) =>
        value.Length >= 2 && value[0] == '"' && value[^1] == '"' ? value[1..^1] : value;

    // --- Helpers ---

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
                                    ApplyProperties(existing, definition);
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
