#pragma once

#include "UObject.h"

CLASS(UField, 56)
class UField : public UObject
{
	// NOTE: Moved to UStruct after 756 (VER_MOVED_SUPERFIELD_TO_USTRUCT)
	FIELD(UField*, SuperField, 48);
	FIELD(UField*, Next, 52);
};

CHECK_CLASS(UField)
CHECK_FIELD(UField, SuperField)
CHECK_FIELD(UField, Next)
