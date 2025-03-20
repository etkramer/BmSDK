using System.Reflection;
using BmSDK.Framework.Attributes;
using BmSDK.Generator.Utils;
using UELib.Core;

namespace BmSDK.Generator;

static partial class CodeGenerator
{
    static bool s_needsInit = true;
    static readonly Dictionary<string, Type> s_intrinsicClasses = [];

    public static bool IsIntrinsicClass(UClass classObj)
    {
        TryInitIntrinsicClasses();
        return s_intrinsicClasses.ContainsKey(classObj.GetPath());
    }

    static int GetNativeFieldSize(UProperty prop)
    {
        return prop switch
        {
            UFloatProperty _ => sizeof(float),
            UBoolProperty _ => 0, // TODO
            UIntProperty _ => sizeof(int),
            UByteProperty _ => sizeof(byte),
            UStrProperty _ => 4,
            UNameProperty _ => 4,
            UObjectProperty => 4,
            UArrayProperty => 12,
            UDelegateProperty => 4,
            UStructProperty => 4, // TODO
            _ => throw new NotImplementedException(),
        };
    }

    static string GetNativeTypeName(UProperty prop)
    {
        return prop.GetType().Name;
    }

    static string GetManagedTypeName(UProperty prop)
    {
        // Return enum name if possible
        if (prop is UByteProperty byteProperty)
        {
            var enumObj = byteProperty.Enum;
            if (enumObj is not null)
            {
                return enumObj.Name;
            }
        }

        // Handle UClass before UObject
        if (prop is UClassProperty)
        {
            return "Type";
        }

        // Return object class name if possible
        if (prop is UObjectProperty objectProperty)
        {
            if (objectProperty.Object.Name is null)
            {
                return "UObject";
            }
            else
            {
                return GetFullName((UClass)objectProperty.Object);
            }
        }

        return prop switch
        {
            UFloatProperty => "float",
            UBoolProperty => "bool",
            UIntProperty => "int",
            UByteProperty => "byte",
            UStrProperty => "string",
            UNameProperty => "string",

            // TODO: More specific type
            UDelegateProperty => "Action",
            UArrayProperty => "Array",

            // TODO: Needs correct size too
            UStructProperty => "int",

            _ => throw new NotImplementedException(),
        };
    }

    static string GetFullName(UStruct structObj)
    {
        // See if this is a predefined intrinsic class
        if (s_intrinsicClasses.TryGetValue(structObj.GetPath(), out var type))
        {
            return Guard.NotNull(type.FullName).Replace("BmSDK.", "");
        }

        return $"{structObj.Package.PackageName}.{structObj.Name}";
    }

    static void TryInitIntrinsicClasses()
    {
        if (!s_needsInit)
        {
            return;
        }

        // Find any intrinsic classes
        var frameworkAssembly = Guard.NotNull(Assembly.GetAssembly(typeof(Framework.UObject)));
        foreach (
            var intrinsicClass in frameworkAssembly
                .GetTypes()
                .Where(t => t.GetCustomAttribute<IntrinsicClassAttribute>() is not null)
        )
        {
            // Store it for later use
            var classAttrib = intrinsicClass.GetCustomAttribute<IntrinsicClassAttribute>()!;
            s_intrinsicClasses.Add(classAttrib.ClassPath, intrinsicClass);
        }

        s_needsInit = false;
    }
}
