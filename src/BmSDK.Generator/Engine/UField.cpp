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
	else if (this->IsA(UClass::StaticClass()) || this->IsA(UEnum::StaticClass()))
	{
		return GetName();
	}

	return "F" + GetName();
}

string UField::GetPathNameManaged() const
{
	if (this->IsA(UClass::StaticClass()))
	{
		return GetPackageNameManaged() + "." + GetNameManaged();
	}

	return ((UField*)this->Outer)->GetPathNameManaged() + "." + GetNameManaged();
}
