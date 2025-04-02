#pragma once

#include "UState.h"

enum class EClassFlags : DWORD
{
	CLASS_Intrinsic = 0x10000000,
};

class UClass : public UState
{
	// TODO
	FIELD(EClassFlags, ClassFlags)

public:
	STATIC_CLASS("Core.Class")
};
