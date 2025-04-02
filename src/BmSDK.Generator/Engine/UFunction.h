#pragma once

#include "UStruct.h"

enum class EFunctionFlags : DWORD
{
	FUNC_Operator = 0x1000,
	FUNC_Static = 0x2000,
};

class UFunction : public UStruct
{
	// TODO
	FIELD(EFunctionFlags, FunctionFlags)

public:
	STATIC_CLASS("Core.Function")
};
