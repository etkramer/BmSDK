#include "pch.h"
#include "FieldInfo.h"
#include "Engine/UStruct.h"
#include "Engine/UClass.h"
#include "Engine/UEnum.h"
#include "Engine/UProperty.h"
#include "Engine/UFunction.h"

FieldInfo::FieldInfo(UField* field)
{
	this->field = field;
	this->managedName = GetNameManaged();
	this->managedPathName = GetPathNameManaged();
}

string FieldInfo::GetNameManaged()
{
	if (field->IsA(UScriptStruct::StaticClass()))
	{
		return "F" + field->GetName();
	}
	else if (field->IsA(UClass::StaticClass()))
	{
		bool isActorClass = false;
		UStruct* classSuper = (UClass*)field;
		while (classSuper)
		{
			if (classSuper->GetPathName() == "Engine.Actor")
			{
				isActorClass = true;
				break;
			}

			classSuper = classSuper->SuperStruct;
		}

		if (isActorClass)
		{
			return "A" + field->GetName();
		}
		else
		{
			return "U" + field->GetName();
		}
	}

	// Workaround fields with same name as their outer
	if (field->GetName() == field->Outer->GetName())
	{
		return "_" + field->GetName();
	}

	// De-duplicate prop names for structs and functions
	if (field->IsA(UProperty::StaticClass()) && (field->Outer->IsA(UFunction::StaticClass()) ||
												 field->Outer->IsA(UScriptStruct::StaticClass())))
	{
		int numDuplicates = 0;
		auto propLink = ((UStruct*)field->Outer)->Children;
		while (propLink && propLink != field)
		{
			if (propLink == field)
			{
				break;
			}
			else if (propLink->GetName() == field->GetName())
			{
				numDuplicates++;
			}

			propLink = propLink->Next;
		}

		if (numDuplicates > 0)
		{
			return field->GetName() + "_" + to_string(numDuplicates);
		}
	}

	return field->GetName();
}

string FieldInfo::GetPathNameManaged()
{
	if (field->IsA(UClass::StaticClass()))
	{
		return field->GetPackageNameManaged() + "." + managedName;
	}

	return ((UField*)field->Outer)->GetPathNameManaged() + "." + managedName;
}
