#pragma once

#include "TArray.h"
#include "UField.h"

CLASS(UStruct, 164)
class UStruct : public UField
{
	// BM4 has no PropertiesSize or MinAlignment

	FIELD(UStruct*, SuperStruct)
    FIELD(UField*, Children)
	BYTE UNK1[56];

public:
	STATIC_CLASS("Core.Struct")
};

class UScriptStruct : public UStruct
{
    // TODO

public:
    STATIC_CLASS("Core.ScriptStruct")
};

CHECK_CLASS(UStruct)
