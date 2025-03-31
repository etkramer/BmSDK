#pragma once

#include "UField.h"

CLASS(UProperty, 112)
class UProperty : public UField
{
	BYTE UNK1[28];

	FIELD(INT, Offset, 84);

	BYTE UNK2[24];

public:
	static class UClass* StaticClass()
	{
		static UClass* classObj = nullptr;
		return classObj ? classObj : classObj = UObject::FindClass("Class Core.Property");
	}
};

CHECK_CLASS(UProperty)
CHECK_FIELD(UProperty, Offset)
