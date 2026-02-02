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
    // Manually rename some classes to avoid conflicts with the System namespace
    if (field->GetPathName() == "Core.Object")
    {
        return "GameObject";
    }
    else if (field->GetPathName() == "Core.System")
    {
        return "_System";
    }
    else if (field->GetPathName() == "Engine.Console")
    {
        return "_Console";
    }

    if (field->IsA(UScriptStruct::StaticClass()))
    {
        return "F" + field->GetName();
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
