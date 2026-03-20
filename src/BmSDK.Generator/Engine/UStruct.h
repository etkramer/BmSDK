#pragma once

#include "TArray.h"
#include "UField.h"

CLASS(UStruct, 164)
class UStruct : public UField
{
	// BM4 has no PropertiesSize or MinAlignment

	FIELD(UStruct*, SuperStruct)
	BYTE UNK1[32];
	FIELD(UField*, Children)

	BYTE UNK5[24];

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
