#pragma once

#include "UStruct.h"

class UClass : public UStruct
{
	// TODO

public:
	static class UClass* StaticClass()
	{
		static UClass* classObj = nullptr;
		return classObj ? classObj : classObj = UObject::FindClass("Class Core.Class");
	}
};

// CHECK_SIZE(UClass, TODO);
