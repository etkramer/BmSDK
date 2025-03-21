using BmSDK.Generator.Utils;
using UELib.Core;

namespace BmSDK.Generator;

partial class ClassGenerator
{
    string? GetManagedTypeName(UProperty prop)
    {
        // Return enum name if possible
        if (prop is UByteProperty byteProperty)
        {
            var enumObj = byteProperty.Enum;
            if (enumObj is not null)
            {
                return GetFullName(enumObj);
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

        // Return interface class name if possible
        if (prop is UInterfaceProperty interfaceProperty)
        {
            if (interfaceProperty.InterfaceClass.Name is null)
            {
                return "UObject";
            }
            else
            {
                return GetFullName(interfaceProperty.InterfaceClass);
            }
        }

        // Return struct name if possible
        if (prop is UStructProperty structProperty)
        {
            return GetFullName(structProperty.Struct);
        }

        // Use array inner type name if possible
        if (prop is UMapProperty)
        {
            return "TMap<object, object>";
        }

        // Use array inner type name if possible
        if (prop is UArrayProperty arrayProperty)
        {
            var arrayFullName = "TArray";
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
            UDelegateProperty => "Delegate",

            _ => throw new NotImplementedException()
        };
    }

    string GetFullName(UField structObj)
    {
        // Minimally qualify names
        if (structObj is UClass)
        {
            return (
                structObj.Package.PackageName == "Core"
                || Namespace.StartsWith($"BmSDK.{structObj.Package.PackageName}")
            )
                ? structObj.ManagedName
                : $"{structObj.Package.PackageName}.{structObj.ManagedName}";
        }
        else
        {
            if (structObj.Outer is null || Class == structObj.Outer || Class.Extends(structObj.Outer.Name))
            {
                return $"{structObj.ManagedName}";
            }
            else
            {
                return $"{GetFullName((UField)structObj.Outer)}.{structObj.ManagedName}";
            }
        }
    }
}
