#include "pch.h"
#include "UStruct.h"
#include "UClass.h"
#include "UEnum.h"
#include "UProperty.h"
#include "UFunction.h"
#include <map>

static map<UField*, FieldInfo*> fieldInfoMap = {};

FieldInfo* UField::GetInfo()
{
	if (fieldInfoMap.find(this) == fieldInfoMap.end())
	{
		fieldInfoMap[this] = new FieldInfo(this);
	}

	return fieldInfoMap[this];
}
