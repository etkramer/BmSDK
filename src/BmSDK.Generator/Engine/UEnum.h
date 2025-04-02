#pragma once

#include "UField.h"

CLASS(UEnum, 68)
class UEnum : public UField
{
	// TODO
	FIELD(TArray<FName>, Names)

public:
	STATIC_CLASS("Core.Enum")
};

CHECK_CLASS(UEnum)
