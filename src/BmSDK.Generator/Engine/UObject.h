#pragma once

#include "FName.h"

// NOTE: May need to change for 64-bit.
#define PROPERTY_ALIGNMENT 4
#pragma pack(push, PROPERTY_ALIGNMENT)

CLASS(UObject, 76)
class UObject
{
	BYTE UNK0[8];
	BYTE UNK1[8];
	BYTE UNK2[8];
	BYTE UNK3[8];
	BYTE UNK4[8];
	FIELD(INT, Index)
	FIELD(UObject*, Outer)
	FIELD(FName, Name)
	FIELD(UObject*, Class)

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
