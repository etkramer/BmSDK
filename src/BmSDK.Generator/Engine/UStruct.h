#pragma once

#include "TArray.h"
#include "UField.h"

CLASS(UStruct, 164)
class UStruct : public UField
{
	FIELD(UStruct*, SuperStruct)
	BYTE UNK1[12];
	FIELD(WORD, PropertiesSize)
	WORD MinAlignment;

	BYTE UNK3[16];
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
