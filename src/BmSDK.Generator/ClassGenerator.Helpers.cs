using BmSDK.Generator.Utils;
using UELib.Core;

namespace BmSDK.Generator;

partial class ClassGenerator
{
    static bool s_needsInit = true;
    static readonly Dictionary<string, Type> s_intrinsicClasses = [];

    public static bool IsIntrinsicClass(UClass classObj)
    {
        TryInitIntrinsicClasses();
        return s_intrinsicClasses.ContainsKey(classObj.GetPath());
    }

    static string GetNativeTypeName(UProperty prop)
    {
        return prop.GetType().Name;
    }

    string GetManagedTypeName(UProperty prop)
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

        // Return struct name if possible
        if (prop is UStructProperty structProperty)
        {
            return GetFullName(structProperty.Struct);
        }

        // Use array inner type name if possible
        if (prop is UArrayProperty arrayProperty)
        {
            var arrayFullName = Namespace == "Core" ? "TArray" : "Core.TArray";
            return $"{arrayFullName}<{GetManagedTypeName(arrayProperty.InnerProperty)}>";
        }

        return prop switch
        {
            UIntProperty => "int",
            UFloatProperty => "float",
            UByteProperty => "byte",
            UBoolProperty => "bool",
            UStrProperty => "string",
            UNameProperty => "string",

            // TODO: More specific type
            UArrayProperty => "Array",

            _ => throw new NotImplementedException(),
        };
    }

    string GetFullName(UStruct structObj)
    {
        // See if this is a predefined intrinsic class
        if (s_intrinsicClasses.TryGetValue(structObj.GetPath(), out var type))
        {
            return Guard
                .NotNull(type.FullName)
                .Replace("BmSDK.Framework.", "")
                .Replace(Namespace, "");
        }

        // Minimally qualify names
        if (structObj is UClass)
        {
            return Namespace == $"BmSDK.{structObj.Package.PackageName}"
                ? structObj.ManagedName
                : $"{structObj.Package.PackageName}.{structObj.ManagedName}";
        }
        else
        {
            if (Class == structObj.Outer || Class.Extends(structObj.Outer.Name))
            {
                return $"{structObj.ManagedName}";
            }
            else
            {
                return $"{GetFullName((UClass)structObj.Outer)}.{structObj.ManagedName}";
            }
        }
    }

    static void TryInitIntrinsicClasses()
    {
        if (!s_needsInit)
        {
            return;
        }

        // Find any intrinsic classes
        // var frameworkAssembly = Guard.NotNull(Assembly.GetAssembly(typeof(Framework.UObject)));
        // foreach (
        //     var intrinsicClass in frameworkAssembly
        //         .GetTypes()
        //         .Where(t => t.GetCustomAttribute<IntrinsicClassAttribute>() is not null)
        // )
        // {
        //     // Store it for later use
        //     var classAttrib = intrinsicClass.GetCustomAttribute<IntrinsicClassAttribute>()!;
        //     s_intrinsicClasses.Add(classAttrib.ClassPath, intrinsicClass);
        // }

        s_needsInit = false;
    }
}
