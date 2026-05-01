using System.Text.Json;
using BmSDK.Engine;

namespace BmSDK.Framework.Content;

internal static unsafe class ContentManager
{
    private static readonly JsonDocumentOptions s_jsonOptions = new()
    {
        AllowTrailingCommas = true,
        CommentHandling = JsonCommentHandling.Skip,
    };

    private static readonly Dictionary<string, List<ContentFile>> s_filesByMod = [];

    private sealed record ContentFile(string ObjectPath, string FilePath);

    public static void DiscoverContent(Mod mod)
    {
        var contentDir = Path.Combine(mod.DirectoryPath, "content");
        if (!Directory.Exists(contentDir))
        {
            return;
        }

        var files = Directory
            .EnumerateFiles(contentDir, "*.json", SearchOption.AllDirectories)
            .Select(filePath => new ContentFile(FilePathToObjectPath(contentDir, filePath), filePath))
            .ToList();

        if (files.Count == 0)
        {
            return;
        }

        s_filesByMod[mod.DirectoryPath] = files;

        Debug.Log(
            $"[{mod.Name}] Content: Discovered {files.Count} {CommonUtils.FormatPlural(files.Count, "file")}"
        );
    }

    public static void ApplyContentForLevel(Level level)
    {
        var levelPath = level.GetPathName();
        var normalizedLevelPath = NormalizePath(levelPath);

        var matching = s_filesByMod.Values
            .SelectMany(list => list)
            .Where(f => NormalizePath(f.ObjectPath)
                .StartsWith(normalizedLevelPath + ".", StringComparison.OrdinalIgnoreCase));

        foreach (var file in matching)
        {
            try
            {
                ApplyContentFile(file, level);
            }
            catch (Exception ex)
            {
                Debug.LogError($"Content: Failed to apply {file.ObjectPath}: {ex.Message}");
            }
        }
    }

    private static void ApplyContentFile(ContentFile file, Level level)
    {
        using var doc = JsonDocument.Parse(File.ReadAllText(file.FilePath), s_jsonOptions);
        var root = doc.RootElement;
        if (root.ValueKind != JsonValueKind.Object)
        {
            throw new FormatException("Root element must be a JSON object");
        }

        var levelPath = level.GetPathName();
        var normalizedObj = NormalizePath(file.ObjectPath);
        var normalizedLevel = NormalizePath(levelPath);
        var resolvedPath = levelPath + normalizedObj[normalizedLevel.Length..];

        var existing = Game.FindObject<Actor>(resolvedPath);
        if (existing is not null && existing.IsValid)
        {
            MergeActor(existing, root);
            existing.ForceUpdateComponents(true);
            Debug.Log($"Content: Merged {file.ObjectPath}");
        }
        else
        {
            CreateActor(root, file.ObjectPath, level);
        }
    }

    private static void CreateActor(JsonElement root, string objectPath, Level level)
    {
        if (!root.TryGetProperty("Class", out var classEl) || classEl.ValueKind != JsonValueKind.String)
        {
            Debug.LogError($"Content: Cannot spawn {objectPath} — missing 'Class' field");
            return;
        }

        var className = classEl.GetString()!;
        var actorClass = Game.FindObject<Class>(className);
        if (actorClass is null || !actorClass.IsValid)
        {
            Debug.LogError($"Content: Class '{className}' not found, cannot spawn {objectPath}");
            return;
        }

        var name = root.TryGetProperty("Name", out var nameEl) && nameEl.ValueKind == JsonValueKind.String
            ? nameEl.GetString()!
            : Path.GetFileNameWithoutExtension(objectPath);

        var actor = Game.SpawnActor(actorClass, Level: level, Name: name);
        if (actor is null || !actor.IsValid)
        {
            Debug.LogError($"Content: Failed to spawn actor for {objectPath}");
            return;
        }

        MergeActor(actor, root);
        actor.ForceUpdateComponents(true);
        Debug.Log($"Content: Spawned {className} at {objectPath}");
    }

    private static void MergeActor(GameObject target, JsonElement obj)
    {
        var propertyMap = BuildPropertyMap(target.Class);

        foreach (var prop in obj.EnumerateObject())
        {
            if (propertyMap.TryGetValue(prop.Name, out var p))
            {
                try
                {
                    ApplyValue(target.Ptr, p, prop.Value);
                }
                catch (Exception ex)
                {
                    Debug.LogWarning($"Content: Failed to apply '{prop.Name}': {ex.Message}");
                }
            }
            else if (prop.Value.ValueKind == JsonValueKind.Object)
            {
                var sub = FindSubObject(target, prop.Name);
                if (sub is not null && sub.IsValid)
                {
                    MergeActor(sub, prop.Value);
                }
                else
                {
                    Debug.LogWarning(
                        $"Content: Sub-object '{prop.Name}' not found on {target.GetPathName()}"
                    );
                }
            }
            else
            {
                Debug.LogWarning(
                    $"Content: Property '{prop.Name}' not found on {target.Class.Name}"
                );
            }
        }
    }

    private static void ApplyValue(IntPtr basePtr, Property prop, JsonElement value)
    {
        var dest = basePtr + prop.Offset;

        switch (prop)
        {
            case FloatProperty:
                MarshalUtil.ToUnmanaged(value.GetSingle(), dest);
                break;

            case IntProperty:
                MarshalUtil.ToUnmanaged(value.GetInt32(), dest);
                break;

            case BoolProperty boolProp:
            {
                ref var packed = ref MarshalUtil.AsRef<int>(dest);
                packed = value.GetBoolean()
                    ? (packed | boolProp.BitMask)
                    : (packed & ~boolProp.BitMask);
                break;
            }

            case ByteProperty byteProp:
                if (value.ValueKind == JsonValueKind.Number)
                {
                    MarshalUtil.ToUnmanaged((byte)value.GetInt32(), dest);
                }
                else
                {
                    var enumName = value.GetString()
                        ?? throw new FormatException("Byte value must be a number or enum-member string");
                    var enumType = byteProp.Enum;
                    if (enumType is null || !enumType.IsValid)
                    {
                        throw new FormatException(
                            $"'{enumName}' is not numeric and property has no enum type"
                        );
                    }

                    var names = enumType.Names;
                    var matched = false;
                    for (var i = 0; i < names.Count; i++)
                    {
                        if (names[i].ToString().Equals(enumName, StringComparison.OrdinalIgnoreCase))
                        {
                            MarshalUtil.ToUnmanaged((byte)i, dest);
                            matched = true;
                            break;
                        }
                    }

                    if (!matched)
                    {
                        throw new FormatException($"Enum value '{enumName}' not found");
                    }
                }

                break;

            case NameProperty:
                MarshalUtil.ToUnmanaged(new FName(value.GetString()!), dest);
                break;

            case StrProperty:
                MarshalUtil.ToUnmanaged(new FString(value.GetString()!), dest);
                break;

            case ObjectProperty:
                if (value.ValueKind == JsonValueKind.Null)
                {
                    MarshalUtil.ToUnmanaged(IntPtr.Zero, dest);
                }
                else
                {
                    var path = value.GetString();
                    if (string.IsNullOrEmpty(path))
                    {
                        MarshalUtil.ToUnmanaged(IntPtr.Zero, dest);
                    }
                    else
                    {
                        var referenced = Game.FindObject<GameObject>(path);
                        if (referenced is not null && referenced.IsValid)
                        {
                            MarshalUtil.ToUnmanaged(referenced.Ptr, dest);
                        }
                        else
                        {
                            Debug.LogWarning($"Content: Referenced object '{path}' not found");
                        }
                    }
                }

                break;

            case StructProperty structProp:
            {
                var structType = structProp.Struct;
                if (structType is null || !structType.IsValid)
                {
                    Debug.LogWarning($"Content: StructProperty '{structProp.Name}' has no struct type");
                    break;
                }

                var subPropertyMap = BuildPropertyMap(structType);
                foreach (var field in value.EnumerateObject())
                {
                    if (!subPropertyMap.TryGetValue(field.Name, out var subProp))
                    {
                        Debug.LogWarning(
                            $"Content: Struct field '{field.Name}' not found in '{structProp.Name}'"
                        );
                        continue;
                    }

                    try
                    {
                        ApplyValue(dest, subProp, field.Value);
                    }
                    catch (Exception ex)
                    {
                        Debug.LogWarning(
                            $"Content: Failed to apply struct field '{field.Name}': {ex.Message}"
                        );
                    }
                }

                break;
            }

            default:
                Debug.LogWarning($"Content: Unsupported property type '{prop.Class.Name}'");
                break;
        }
    }

    private static GameObject? FindSubObject(GameObject target, string subObjectName)
    {
        if (target is not Actor actor)
        {
            return null;
        }

        // Sub-object keys refer to the archetype/template name from the CDO. Spawned
        // component instances carry that template as ObjectArchetype but may have a
        // uniquified instance name, so match on archetype name first and fall back to
        // the instance name. Walk both Components (populated immediately from the CDO
        // template) and AllComponents (populated after UpdateComponents) — freshly
        // spawned actors may not have AllComponents built yet.
        GameObject? byName = null;
        foreach (var component in actor.Components.Concat(actor.AllComponents))
        {
            if (component is null || !component.IsValid)
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

    private static Dictionary<string, Property> BuildPropertyMap(Struct structType)
    {
        // Needed for fast property loopup
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

    private static string NormalizePath(string path) => path.Replace(':', '.');

    private static string FilePathToObjectPath(string contentDir, string filePath)
    {
        var relative = Path.GetRelativePath(contentDir, filePath);
        var withoutExtension = Path.ChangeExtension(relative, null);
        return withoutExtension
            .Replace(Path.DirectorySeparatorChar, '.')
            .Replace(Path.AltDirectorySeparatorChar, '.');
    }
}
