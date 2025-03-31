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
	UObject* Outer;

	FIELD(FName, Name, 32)
	FIELD(UObject*, Class, 40)

	UObject* ObjectArchetype;

public:
	string GetName() const;
	string GetPathName() const;
	string GetFullName() const;

	bool IsA(class UClass* classObj) const;

public:
	static class UClass* FindClass(const string& classPath);
};

CHECK_CLASS(UObject)
CHECK_FIELD(UObject, Name)
CHECK_FIELD(UObject, Class)
