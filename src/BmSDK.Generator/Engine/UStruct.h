#pragma once

#include "TArray.h"
#include "UField.h"

CLASS(UStruct, 164)
class UStruct : public UField
{
	FIELD(UStruct*, SuperStruct)
    FIELD(UField*, Children)
    BYTE UNK1[12];
    FIELD(WORD, PropertiesSize)
    FIELD(WORD, MinAlignment)
    BYTE UNK2[40];

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
