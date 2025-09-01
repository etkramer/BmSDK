#pragma once

#include "UStruct.h"

CLASS(UState, 180)
class UState : public UStruct
{
	// TODO
	BYTE UNK1[72];

public:
	STATIC_CLASS("Core.State")
};

CHECK_CLASS(UState);
