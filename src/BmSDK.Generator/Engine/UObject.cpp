#include "pch.h"
#include "UObject.h"
#include "GameFunctions.h"
#include "UClass.h"

string UObject::GetPathName() const
{
    string res = this->GetName();
    for (auto outer = this->Outer; outer; outer = outer->Outer)
    {
        res = (outer->GetName() + "." + res);
    }

    return res;
}

string UObject::GetPackageName() const
{
    for (auto outer = this->Outer; outer; outer = outer->Outer)
    {
        if (outer->Class->GetPathName() == "Core.Package")
        {
            return outer->GetName();
        }
    }

    return "";
}

string UObject::GetPackageNameManaged() const
{
    string packageName = this->GetPackageName();
    if (packageName == "Core")
    {
        return "BmSDK";
    }

    return "BmSDK." + packageName;
}

bool UObject::IsA(class UClass* classObj) const
{
    if (classObj)
    {
        for (UClass* superClass = (UClass*)(this->Class); superClass;
            superClass = (UClass*)(superClass->SuperStruct))
        {
            if (superClass == classObj)
            {
                return true;
            }
        }
    }

    return false;
}

UObject* UObject::FindObject(class UClass* classObj, UObject* outer, const string& pathName,
    bool exactClass)
{
    wstring pathNameW(pathName.begin(), pathName.end());
    return GameFunctions::StaticFindObject(classObj, outer, pathNameW.c_str(), exactClass);
}

class UClass* UObject::FindClass(const string& classPath)
{
    return (UClass*)FindObject(nullptr, (UObject*)-1, classPath, false);
}
