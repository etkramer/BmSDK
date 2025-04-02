#pragma once

#include "UObject.h"

CLASS(UField, 56)
class UField : public UObject
{
	// NOTE: Moved to UStruct after 756 (VER_MOVED_SUPERFIELD_TO_USTRUCT)
	FIELD(UField*, SuperField)
	FIELD(UField*, Next)

public:
	string GetNameManaged() const;
	string GetPathNameManaged() const;
	STATIC_CLASS("Core.Field")
};

CHECK_CLASS(UField)
