#include "pch.h"
#include "UObject.h"
#include "Runtime.h"
#include "UClass.h"

#include <map>

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

class UClass* UObject::FindClass(const string& classFullName)
{
    static map<string, UClass*> classCache;

    if (classCache.empty())
    {
        for (INT i = 0; i < (Runtime::GObjects->Num); i++)
        {
            UObject* obj = Runtime::GObjects->ElementAt(i);

            if (obj)
            {
                string objFullName = obj->GetFullName();
                if (objFullName.find("Class") == 0)
                {
                    classCache[objFullName] = reinterpret_cast<UClass*>(obj);
                }
            }
        }
    }

    if (classCache.contains(classFullName))
    {
        return classCache[classFullName];
    }

    return nullptr;
}
