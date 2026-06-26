#pragma once

#include "FName.h"

// NOTE: May need to change for 64-bit.
#define PROPERTY_ALIGNMENT 4
#pragma pack(push, PROPERTY_ALIGNMENT)

enum class EObjectFlags : INT
{
    RF_ClassDefaultObject = 0x80
};

CLASS(UObject, 84)
class UObject
{
    FIELD(INT, ObjectFlags)
    INT EditorObjectFlags;
    INT HashIndexPrev;
    INT HashIndexNext;
    INT HashOuterIndexPrev;
    INT HashOuterIndexNext;
    UObject* Linker;
    void* LinkerIndex;
    FIELD(INT, Index)
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

    static UObject* FindObject(class UClass* classObj, UObject* outer, const string& pathName, bool exactClass);
    static class UClass* FindClass(const string& classPath);

public:
    STATIC_CLASS("Core.Object")
};

CHECK_CLASS(UObject)
