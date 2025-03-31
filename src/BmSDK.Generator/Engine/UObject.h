#pragma once

#include "FName.h"

CLASS(UObject, 48)
class UObject
{
	INT Index;
	QWORD ObjectFlags;
	UObject* HashNext;
	UObject* HashOuterNext;
	class FStateFrame* StateFrame;

	FIELD(UObject*, Outer)
	FIELD(FName, Name)
	FIELD(UObject*, Class)

	UObject* ObjectArchetype;

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
};

CHECK_CLASS(UObject)
