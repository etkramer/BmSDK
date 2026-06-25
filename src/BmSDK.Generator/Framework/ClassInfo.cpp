#include "pch.h"
#include "ClassInfo.h"
#include "Engine/UClass.h"
#include "Engine/UEnum.h"
#include "Engine/UFunction.h"
#include "Engine/UProperty.h"

#include <map>

PropertyInfo::PropertyInfo(UProperty* prop, bool isInStruct)
{
    Name = prop->GetName();
    ManagedName = prop->GetNameManaged();
    TypeName = prop->GetInnerTypeNameManaged();
    ClassName = prop->Class->GetName();
    ArrayDim = prop->ArrayDim;
    Offset = prop->Offset;
    ElementSize = prop->ElementSize;
    Flags = (uint64_t)prop->PropertyFlags;
    IsInStruct = isInStruct;
    IsBool = prop->IsA(UBoolProperty::StaticClass());
    IsParam = Flags & (uint64_t)EPropertyFlags::CPF_Parm;
    IsOptionalParam = Flags & (uint64_t)EPropertyFlags::CPF_OptionalParm;
    IsOutParam = Flags & (uint64_t)EPropertyFlags::CPF_OutParm;
    IsReturnParam = Flags & (uint64_t)EPropertyFlags::CPF_ReturnParm;
    ShouldReturnByRef = prop->ShouldReturnByRef() && !IsInStruct;

    if (IsBool)
    {
        BitMask = ((UBoolProperty*)prop)->BitMask;
    }
}

StructInfo::StructInfo(UStruct* _struct)
{
    ManagedName = _struct->GetNameManaged();
    PropertiesSize = _struct->PropertiesSize;
}

StructInfo::StructInfo(UScriptStruct* _struct) : StructInfo((UStruct*)_struct)
{
    for (auto field = _struct->Children; field; field = field->Next)
    {
        if (field->IsA(UProperty::StaticClass()))
        {
            Members.push_back(new PropertyInfo((UProperty*)field, true));
        }
    }
}

EnumInfo::EnumInfo(UEnum* _enum)
{
    Name = _enum->GetName();
    ManagedName = _enum->GetNameManaged();

    map<string, int> enumNameFreqs;
    for (auto i = 0; i < _enum->Names.Num; i++)
    {
        auto name = _enum->Names.ElementAt(i).ToString();
        enumNameFreqs[name]++;

        if (enumNameFreqs[name] > 1)
        {
            Names.push_back(name + "_" + to_string(enumNameFreqs[name]));
        }
        else
        {
            Names.push_back(name);
        }
    }
}

FunctionInfo::FunctionInfo(UFunction* func)
{
    Name = func->GetName();
    ManagedName = func->GetNameManaged();
    PathName = func->GetPathName();
    PropertiesSize = func->PropertiesSize;
    Flags = (uint32_t)func->FunctionFlags;
    IsStatic = Flags & (uint32_t)EFunctionFlags::FUNC_Static;
    IsNative = Flags & (uint32_t)EFunctionFlags::FUNC_Native;
    IsPrivate = Flags & (uint32_t)EFunctionFlags::FUNC_Private;
    IsOverride = func->SuperStruct && func->SuperStruct->IsA(UFunction::StaticClass());

    for (auto field = func->Children; field; field = field->Next)
    {
        if (!field->IsA(UProperty::StaticClass()))
        {
            continue;
        }

        auto prop = (UProperty*)field;
        auto propInfo = PropertyInfo(prop, false);
        if (propInfo.IsReturnParam)
        {
            ReturnParam = propInfo;
            HasReturnParam = true;
        }
        else if (propInfo.IsParam)
        {
            Params.push_back(propInfo);
        }
    }

    for (auto& param : Params)
    {
        if (param.IsOptionalParam && param.IsOutParam)
        {
            ShouldSuppressOptional = true;
            break;
        }
    }
}

ClassInfo::ClassInfo(UClass* _class) : StructInfo((UStruct*)_class)
{
    Class = _class;
    Name = _class->GetName();
    PathName = _class->GetPathName();
    PackageName = _class->GetPackageName();
    PackageNameManaged = _class->GetPackageNameManaged();
    Flags = (uint32_t)_class->ClassFlags;
    IsAbstract = Flags & (uint32_t)EClassFlags::CLASS_Abstract;
    IsInterface = Flags & (uint32_t)EClassFlags::CLASS_Interface;
    IsIntrinsic = Flags & (uint32_t)EClassFlags::CLASS_Intrinsic;

    for (auto super = _class->SuperStruct; super; super = super->SuperStruct)
    {
        if (super->GetPathName() == "Engine.Actor")
        {
            IsActor = true;
            break;
        }
    }

    for (int i = 0; i < _class->Interfaces.Num; i++)
    {
        Interfaces.push_back(_class->Interfaces.ElementAt(i).Class->GetPathNameManaged());
    }

    for (auto field = _class->Children; field; field = field->Next)
    {
        if (field->IsA(UProperty::StaticClass()))
        {
            Members.push_back(new PropertyInfo((UProperty*)field, false));
        }
        else if (field->IsA(UScriptStruct::StaticClass()))
        {
            Members.push_back(new StructInfo((UScriptStruct*)field));
        }
        else if (field->IsA(UEnum::StaticClass()))
        {
            Members.push_back(new EnumInfo((UEnum*)field));
        }
        else if (field->IsA(UFunction::StaticClass()))
        {
            auto func = (UFunction*)field;
            auto flags = (uint32_t)func->FunctionFlags;
            if (flags & ((uint32_t)EFunctionFlags::FUNC_Operator | (uint32_t)EFunctionFlags::FUNC_Iterator))
            {
                continue;
            }

            Members.push_back(new FunctionInfo(func));
        }
    }
}

void ClassInfo::ResolveSuper(vector<ClassInfo>& classes)
{
    if (!Class->SuperStruct)
    {
        return;
    }

    for (auto& _class : classes)
    {
        if (_class.Class == Class->SuperStruct)
        {
            Super = &_class;
            return;
        }
    }
}
