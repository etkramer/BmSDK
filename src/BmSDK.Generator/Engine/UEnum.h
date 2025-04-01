#pragma once

#include "UField.h"

CLASS(UEnum, 72)
class UEnum : public UField
{
	// TODO
	FIELD(TArray<FName>, Names)

public:
	static class UClass* StaticClass()
	{
		static UClass* classObj = nullptr;
		return classObj ? classObj : classObj = UObject::FindClass("Class Core.Enum");
	}
};

CHECK_CLASS(UEnum)
