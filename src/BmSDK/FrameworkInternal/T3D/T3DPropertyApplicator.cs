using System.Globalization;

namespace BmSDK.Framework.T3D;

internal static unsafe class T3DPropertyApplicator
{
    private const int SpecializedPropertyFieldOffset = 88;

    public static void ApplyProperties(GameObject target, T3DActorDefinition definition)
    {
        var propertyMap = BuildPropertyMap(target);

        ApplyPropertyList(target.Ptr, propertyMap, definition.Properties);

        foreach (var subObject in definition.SubObjects)
        {
            ApplySubObject(target, subObject);
        }
    }

    private static void ApplySubObject(GameObject actor, T3DSubObject subObject)
    {
        // Find existing component by name on the actor
        var componentPath = $"{actor.GetPathName()}.{subObject.ObjectName}";
        var component = Game.FindObject<GameObject>(componentPath);

        if (component is null || !component.IsValid)
        {
            Debug.LogWarning(
                $"T3D: SubObject '{subObject.ObjectName}' not found on {actor.GetPathName()}"
            );
            return;
        }

        var propertyMap = BuildPropertyMap(component);
        ApplyPropertyList(component.Ptr, propertyMap, subObject.Properties);
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
                MarshalUtil.ToUnmanaged(
                    float.Parse(value, CultureInfo.InvariantCulture),
                    dest
                );
                break;

            case IntProperty:
                MarshalUtil.ToUnmanaged(
                    int.Parse(value, CultureInfo.InvariantCulture),
                    dest
                );
                break;

            case BoolProperty boolProp:
                ApplyBoolValue(basePtr, boolProp, ParseBool(value));
                break;

            case ByteProperty:
                MarshalUtil.ToUnmanaged(
                    byte.Parse(value, CultureInfo.InvariantCulture),
                    dest
                );
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
        var subPropertyMap = BuildPropertyMapFromStruct(structType);

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

    private static Dictionary<string, Property> BuildPropertyMap(GameObject obj)
    {
        var map = new Dictionary<string, Property>(StringComparer.OrdinalIgnoreCase);
        foreach (var structDef in obj.Class.EnumerateSupersAndSelf())
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

    private static Dictionary<string, Property> BuildPropertyMapFromStruct(Struct structType)
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

    private static bool ParseBool(string value)
    {
        return value.Equals("True", StringComparison.OrdinalIgnoreCase)
            || value == "1";
    }

    private static string StripQuotes(string value)
    {
        if (value.Length >= 2 && value[0] == '"' && value[^1] == '"')
        {
            return value[1..^1];
        }
        return value;
    }
}
