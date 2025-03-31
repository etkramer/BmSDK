#pragma once

#include "UField.h"

CLASS(UProperty, 112)
class UProperty : public UField
{
	BYTE UNK1[28];

	FIELD(INT, Offset)

	BYTE UNK2[24];

public:
	string GetInnerTypeNameManaged() const;

public:
	static class UClass* StaticClass()
	{
		static UClass* classObj = nullptr;
		return classObj ? classObj : classObj = UObject::FindClass("Class Core.Property");
	}
};

CHECK_CLASS(UProperty)

CLASS(UStructProperty, 120)
class UStructProperty : public UProperty
{
	FIELD(class UStruct*, Struct)

public:
	static class UClass* StaticClass()
	{
		static UClass* classObj = nullptr;
		return classObj ? classObj : classObj = UObject::FindClass("Class Core.StructProperty");
	}
};

CHECK_CLASS(UStructProperty)

CLASS(UObjectProperty, 120)
class UObjectProperty : public UProperty
{
	FIELD(class UClass*, PropertyClass)

public:
	static class UClass* StaticClass()
	{
		static UClass* classObj = nullptr;
		return classObj ? classObj : classObj = UObject::FindClass("Class Core.StructProperty");
	}
};

CHECK_CLASS(UObjectProperty)
