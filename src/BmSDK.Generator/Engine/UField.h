#pragma once

#include "UObject.h"
#include "Framework/FieldInfo.h"

CLASS(UField, 56)
class UField : public UObject
{
	// NOTE: Moved to UStruct after 756 (VER_MOVED_SUPERFIELD_TO_USTRUCT)
	FIELD(UField*, SuperField)
	FIELD(UField*, Next)

public:
	FieldInfo* GetInfo();
	string GetNameManaged() { return GetInfo()->managedName; }
	string GetPathNameManaged() { return GetInfo()->managedPathName; }
	STATIC_CLASS("Core.Field")
};

CHECK_CLASS(UField)
