#pragma once

#include "FName.h"

typedef QWORD EObjectFlags;

class UObject
{
	FIELD(INT, Index)
	FIELD(EObjectFlags, ObjectFlags)
	UObject* HashNext;
	UObject* HashOuterNext;
	class FStateFrame* StateFrame;
	FIELD(UObject*, Outer)
	FIELD(FName, Name)
	FIELD(UObject*, Class)
	UObject* ObjectArchetype;

public:
	string GetName() const;
	string GetPathName() const;
	string GetFullName() const;

	bool IsA(class UClass* classObj) const;

public:
	static class UClass* StaticClass()
	{
		return UObject::FindClass("Class Core.Object");
	}

	static class UClass* FindClass(const string& classPath);
};