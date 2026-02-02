#pragma once

#include "UStruct.h"

enum class EFunctionFlags : DWORD
{
	FUNC_Iterator = 0x4,
	FUNC_Native = 0x400,
	FUNC_Event = 0x800,
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
