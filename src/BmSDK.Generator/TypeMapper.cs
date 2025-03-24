using Spectre.Console;
using UELib;
using UELib.Core;

namespace BmSDK.Generator;

public static class TypeMapper
{
    /// <summary>
    /// Collection of all UClass objects found in loaded packages.
    /// </summary>
    public static IEnumerable<UClass> Classes => _classes;
    static List<UClass> _classes = [];
    static List<UStruct> _structs = [];
    static List<UEnum> _enums = [];

    /// <summary>
    /// Collection of all all manually registered intrinsic class paths.
    /// </summary>
    public static IEnumerable<string> IntrinsicClasses => _intrinsicClasses;
    static List<string> _intrinsicClasses = [];

    /// <summary>
    /// Collection of all UClass/UStruct objects found in loaded packages.
    /// </summary>
    public static IEnumerable<UField> StructsAndClassesAndEnums =>
        _structs.Concat(_classes.Cast<UField>()).Concat(_enums.Cast<UField>());

    /// <summary>
    /// Map of UClass/UStruct paths (GetPath() format) to their corresponding managed type names (namespace-qualified)
    /// </summary>
    static readonly Dictionary<string, string> _structNameMap = [];

    /// <inheritdoc cref="GetManagedPathForType(string)" />
    public static string GetManagedPathForType(UField obj, UField ctx) =>
        MakeRelative(GetManagedPathForType(obj.ShortPath), ctx);

    /// <inheritdoc cref="GetManagedPathForType(string)" />
    public static string GetManagedPathForType(UField obj) => GetManagedPathForType(obj.ShortPath);

    /// <summary>
    /// Gets the managed type name (namespace-qualified) for a given class/struct/enum
    /// </summary>
    public static string GetManagedPathForType(string nativePath)
    {
        return _structNameMap.TryGetValue(nativePath, out var managedPath)
            ? managedPath
            : throw new KeyNotFoundException($"No managed name found for {nativePath}");
    }

    /// <summary>
    /// Registers a class/managed type mapping manually
    /// </summary>
    public static void RegisterIntrinsicClass(string classPath, string managedTypePath)
    {
        if (!_structNameMap.ContainsKey(classPath))
        {
            _intrinsicClasses.Add(classPath);
        }

        _structNameMap[classPath] = managedTypePath;
    }

    /// <summary>
    /// Prepass computes all native/managed name mappings
    /// </summary>
    public static void InitAll(List<UnrealPackage> pkgs)
    {
        // Find all classes
        _classes =
        [
            .. pkgs.SelectMany(pkg =>
                    pkg.Exports.Where(obj => obj.Object is UClass).Select(exp => (UClass)exp.Object)
                )
                .Distinct(),
        ];

        // Find all structs
        _structs =
        [
            .. pkgs.SelectMany(pkg =>
                    pkg.Exports.Where(obj => obj.Object is UStruct)
                        .Select(exp => (UStruct)exp.Object)
                )
                .Distinct(),
        ];

        // Find all enums
        _enums =
        [
            .. pkgs.SelectMany(pkg =>
                    pkg.Exports.Where(obj => obj.Object is UEnum).Select(exp => (UEnum)exp.Object)
                )
                .Distinct(),
        ];

        // Compute class/struct layout info (prepass)
        foreach (var structObj in StructsAndClassesAndEnums.OfType<UStruct>())
        {
            structObj.ComputeLayoutInfo();
        }

        // Compute class/struct names
        foreach (var field in StructsAndClassesAndEnums)
        {
            _structNameMap[field.ShortPath] = GetFullManagedName(field);
        }

        // Record hardcoded intrinsic classes
        RegisterIntrinsicClass("Core.Object", "BmSDK.BaseObject");
        RegisterIntrinsicClass("Core.Class", "BmSDK.Class");
        RegisterIntrinsicClass("Core.Function", "BmSDK.Function");

        // Report results to console
        AnsiConsole.MarkupLine(
            $"\nFound [green]{_classes.Count}[/] classes in [green]{pkgs.Count}[/] packages"
        );
    }

    /// <inheritdoc cref="GetManagedTypeForProp(UProperty)" />
    public static string GetManagedTypeForProp(UProperty prop, UField ctx) =>
        MakeRelative(GetManagedTypeForProp(prop), ctx);

    /// <summary>
    /// Gets the managed type name for a given property.
    /// </summary>
    public static string GetManagedTypeForProp(UProperty prop)
    {
        // Manual field type overrides
        if (prop.GetPath() == "Object.ObjectFlags")
        {
            return "EObjectFlags";
        }

        // Handle UStructProperty type names
        if (prop is UStructProperty structProp)
        {
            // Manual struct type overrides
            if (structProp.Struct.GetPath() == "Object.Vector")
            {
                return "System.Numerics.Vector3";
            }

            return GetManagedPathForType(structProp.Struct);
        }

        // Handle UObjectProperty type names
        if (prop is UObjectProperty objectProp)
        {
            if (prop is UClassProperty)
            {
                return GetManagedPathForType("Core.Class");
            }

            return objectProp.Object.Class is null
                ? GetManagedPathForType("Core.Object")
                : GetManagedPathForType((UField)objectProp.Object.Class);
        }

        // Handle UInterfaceProperty type names
        if (prop is UInterfaceProperty interfaceProp)
        {
            return interfaceProp.InterfaceClass is null
                ? GetManagedPathForType("Core.Object")
                : GetManagedPathForType(interfaceProp.InterfaceClass);
        }

        // Handle UByteProperty-based enums
        if (prop is UByteProperty byteProp && byteProp.Enum is not null)
        {
            return GetManagedPathForType(byteProp.Enum);
        }

        // Handle UMapProperty generic type names
        if (prop is UMapProperty)
        {
            // TODO: USE CORRECT TYPE ARGS
            return "BmSDK.TMap<object, object>";
        }

        // Handle UArrayProperty generic type names
        if (prop is UArrayProperty arrayProp)
        {
            return $"BmSDK.TArray<{GetManagedTypeForProp(arrayProp.InnerProperty)}>";
        }

        // Handle primitive type names
        return prop switch
        {
            UIntProperty => "int",
            UFloatProperty => "float",
            UByteProperty => "byte",
            UBoolProperty => "bool",
            UStrProperty => "string",
            UNameProperty => "BmSDK.FName",

            // TODO: More specific type
            UDelegateProperty => "System.Delegate",

            _ => throw new NotImplementedException(),
        };
    }

    /// <summary>
    /// Strips unneeded namespace prefixes from a managed type path, valid within the given context.
    /// </summary>
    public static string MakeRelative(string path, UField ctx)
    {
        // Break path into parts
        var parts = path.Split('.');
        var ctxParts = GetManagedPathForType(ctx).Split('.');

        // See if there's a common prefix, else return
        var numParts = Math.Min(parts.Length, ctxParts.Length);
        for (var i = 0; i < numParts; i++)
        {
            if (parts[i] != ctxParts[i])
            {
                return string.Join(".", parts[i..]);
            }
        }

        return (parts.Length == numParts && ctxParts.Length == numParts)
            ? parts.Last()
            : string.Join(".", parts[numParts..]);
    }

    /// <summary>
    /// Get the managed namespace for a given field
    /// </summary>
    public static string GetManagedNamespace(UField field)
    {
        var packageName = field.Package.PackageName;
        if (packageName == "Core")
        {
            return $"BmSDK";
        }
        else
        {
            return $"BmSDK.{packageName}";
        }
    }

    /// <summary>
    /// Get the managed namespace for a given struct/class/enum type
    /// </summary>
    static string GetFullManagedName(UField field)
    {
        if (field is UClass)
        {
            return $"{GetManagedNamespace(field)}.{field.ManagedName}";
        }
        else
        {
            if (field.Outer is null)
            {
                return field.ManagedName;
            }
            else
            {
                return $"{GetFullManagedName((UField)field.Outer)}.{field.ManagedName}";
            }
        }
    }
}
