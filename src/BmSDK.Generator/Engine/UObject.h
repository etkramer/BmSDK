#pragma once

#include "FName.h"

// NOTE: May need to change for 64-bit.
#define PROPERTY_ALIGNMENT 4
#pragma pack(push, PROPERTY_ALIGNMENT)

CLASS(UObject, 44)
class UObject
{
    FIELD(INT, Index)
        QWORD ObjectFlags;
    UObject* HashNext;
    UObject* HashOuterNext;
    FIELD(UObject*, Outer)
        FIELD(FName, Name)
        FIELD(UObject*, Class)

        UObject* ObjectArchetype;

private:
    // Dummy function so a vtable will be created.
    virtual void VirtualDummy() {}

public:
    FORCEINLINE string GetName() const { return this->Name.ToString(); };
    FORCEINLINE string GetFullName() const
    {
        return this->Class->GetName() + " " + this->GetPathName();
    };
    string GetPathName() const;
    string GetPackageName() const;
    string GetPackageNameManaged() const;

    bool IsA(class UClass* classObj) const;

    static class UClass* FindClass(const string& classPath);

public:
    STATIC_CLASS("Core.Object")
};

CHECK_CLASS(UObject)
