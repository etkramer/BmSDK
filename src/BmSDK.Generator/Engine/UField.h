#pragma once

#include "UObject.h"
#include "Framework/FieldInfo.h"

CLASS(UField, 92)
class UField : public UObject
{
	BYTE UNK0[8];
	FIELD(UField*, Next)

public:
    FieldInfo* GetInfo();
    string GetNameManaged() { return GetInfo()->managedName; }
    string GetPathNameManaged() { return GetInfo()->managedPathName; }
    STATIC_CLASS("Core.Field")
};

CHECK_CLASS(UField)
