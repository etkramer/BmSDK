#include "pch.h"
#include "UProperty.h"
#include "UClass.h"

string UProperty::GetInnerTypeNameManaged() const
{
	if (Class->GetPathName() == "Core.IntProperty")
	{
		return "int";
	}
	if (Class->GetPathName() == "Core.ByteProperty")
	{
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
			 Class->GetPathName() == "Core.StringProperty" ||
			 Class->GetPathName() == "Core.NameProperty")
	{
		return "string";
	}
	else if (Class->GetPathName() == "Core.StructProperty")
	{
		auto structProp = (UStructProperty*)this;
		return structProp->Struct->GetPathNameManaged();
	}
	else if (Class->GetPathName() == "Core.ObjectProperty" ||
			 Class->GetPathName() == "Core.ClassProperty")
	{
		auto objectProp = (UObjectProperty*)this;
		return objectProp->PropertyClass->GetPathNameManaged() + "?";
	}

	return "UNKNOWN";
}
