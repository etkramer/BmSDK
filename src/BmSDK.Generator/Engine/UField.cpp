#include "pch.h"
#include "UStruct.h"
#include "UClass.h"
#include "UEnum.h"

string UField::GetNameManaged() const
{
	if (this->GetPathName() == "Core.Object")
	{
		return "GameObject";
	}
	else if (this->IsA(UScriptStruct::StaticClass()))
	{
		return "F" + GetName();
	}

	return GetName();
}

string UField::GetPathNameManaged() const
{
	if (this->IsA(UClass::StaticClass()))
	{
		return "global::" + GetPackageNameManaged() + "." + GetNameManaged();
	}

	return ((UField*)this->Outer)->GetPathNameManaged() + "." + GetNameManaged();
}
