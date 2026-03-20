#pragma once

#include "UField.h"

CLASS(UEnum, 108)
class UEnum : public UField
{
	FIELD(TArray<FName>, Names)

public:
	STATIC_CLASS("Core.Enum")
};

CHECK_CLASS(UEnum)
