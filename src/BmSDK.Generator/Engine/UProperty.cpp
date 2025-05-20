#include "pch.h"
#include "UProperty.h"
#include "UClass.h"
#include "UEnum.h"

string UProperty::GetInnerTypeNameManaged() const
{
	if (Class->GetPathName() == "Core.IntProperty")
	{
		return "int";
	}
	if (Class->GetPathName() == "Core.ByteProperty")
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
		return "string";
	}
	else if (Class->GetPathName() == "Core.NameProperty")
	{
		return "global::BmSDK.FName";
	}
	else if (Class->GetPathName() == "Core.StructProperty")
	{
		auto structProp = (UStructProperty*)this;
		auto _struct = structProp->Struct;

		// Manually swap out some structs
		if (structProp->GetPathName() == "Core.Object.ObjectFlags")
		{
			return "global::BmSDK.EObjectFlags";
		}
		else if (_struct->GetName() == "Pointer")
		{
			return "global::System.IntPtr";
		}
		else if (_struct->GetName() == "Double")
		{
			return "double";
		}
		else if (_struct->GetName() == "QWord")
		{
			return "ulong";
		}

		return _struct->GetPathNameManaged();
	}
	else if (Class->GetPathName() == "Core.ObjectProperty" ||
			 Class->GetPathName() == "Core.ComponentProperty" ||
			 Class->GetPathName() == "Core.ClassProperty" ||
			 Class->GetPathName() == "Core.InterfaceProperty")
	{
		auto objectProp = (UObjectProperty*)this;
		return objectProp->PropertyClass->GetPathNameManaged() + "?";
	}
	else if (Class->GetPathName() == "Core.ArrayProperty")
	{
		auto arrayProp = (UArrayProperty*)this;
		auto innerName = arrayProp->Inner->GetInnerTypeNameManaged();

		return "global::BmSDK.TArray<" + innerName + ">";
	}
	else if (Class->GetPathName() == "Core.MapProperty")
	{
		return "global::BmSDK.TMap<object, object> /* TODO */";
	}
	else if (Class->GetPathName() == "Core.DelegateProperty")
	{
		return "global::System.IntPtr";
	}

	return "UNKNOWN";
}
