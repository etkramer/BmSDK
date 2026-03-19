#include "pch.h"
#include "UProperty.h"
#include "UClass.h"
#include "UEnum.h"

string UProperty::GetInnerTypeNameManaged() const
{
    if (GetPathName() == "Core.Object.ObjectFlags")
    {
        return "BmSDK.GameObject.EObjectFlags";
    }
    else if (Class->GetPathName() == "Core.IntProperty")
    {
        return "int";
    }
    else if (Class->GetPathName() == "Core.ByteProperty")
    {
        // Try to use proper type for enums
        auto byteProp = (UByteProperty*)this;
        if (byteProp->Enum)
        {
            return byteProp->Enum->GetPathNameManaged();
        }

        return "byte";
    }
    else if (Class->GetPathName() == "Core.FloatProperty")
    {
        return "float";
    }
    else if (Class->GetPathName() == "Core.BoolProperty")
    {
        return "bool";
    }
    else if (Class->GetPathName() == "Core.StrProperty" ||
        Class->GetPathName() == "Core.StringProperty")
    {
        return "BmSDK.FString";
    }
    else if (Class->GetPathName() == "Core.NameProperty")
    {
        return "BmSDK.FName";
    }
    else if (Class->GetPathName() == "Core.StructProperty")
    {
        auto structProp = (UStructProperty*)this;
        auto _struct = structProp->Struct;

        if (_struct == NULL)
        {
            // BM4: Fix property layout
            return "NEED_UPDATE_STRUCTPROPERTY_LAYOUT";
        }

        // Manually swap out some structs
        if (_struct->GetName() == "Pointer")
        {
            return "System.IntPtr";
        }
        else if (_struct->GetName() == "Double")
        {
            return "double";
        }
        else if (_struct->GetName() == "QWord")
        {
            return "ulong";
        }
        else if (_struct->GetName() == "Vector")
        {
            return "System.Numerics.Vector3";
        }
        else if (_struct->GetName() == "Vector4")
        {
            return "System.Numerics.Vector4";
        }
        else if (_struct->GetName() == "Vector2D")
        {
            return "System.Numerics.Vector2";
        }
        else if (_struct->GetName() == "Rotator")
        {
            return "BmSDK.Rotator";
        }

        return _struct->GetPathNameManaged();
    }
    else if (Class->GetPathName() == "Core.ObjectProperty" ||
        Class->GetPathName() == "Core.ComponentProperty" ||
        Class->GetPathName() == "Core.ClassProperty" ||
        Class->GetPathName() == "Core.InterfaceProperty")
    {
        auto objectProp = (UObjectProperty*)this;

        if (objectProp->PropertyClass == NULL)
        {
            // BM4: Fix property layout
            return "NEED_UPDATE_OBJECTPROPERTY_LAYOUT";
        }

        return objectProp->PropertyClass->GetPathNameManaged();
    }
    else if (Class->GetPathName() == "Core.ArrayProperty")
    {
        auto arrayProp = (UArrayProperty*)this;

        if (arrayProp->Inner == NULL)
        {
            // BM4: Fix property layout
            return "NEED_UPDATE_ARRAYPROPERTY_LAYOUT";
        }

        auto innerName = arrayProp->Inner->GetInnerTypeNameManaged();

        return "BmSDK.TArray<" + innerName + ">";
    }
    else if (Class->GetPathName() == "Core.MapProperty")
    {
        return "BmSDK.TMap<object, object> /* TODO */";
    }
    else if (Class->GetPathName() == "Core.DelegateProperty")
    {
        return "System.IntPtr";
    }

    return "UNKNOWN";
}
