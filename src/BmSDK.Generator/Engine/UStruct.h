#pragma once

#include "TArray.h"
#include "UField.h"

CLASS(UStruct, 92)
class UStruct : public UField
{
	FIELD(UStruct*, SuperStruct)
	FIELD(UField*, Children)
	FIELD(WORD, PropertiesSize)
	WORD MinAlignment;

	BYTE UNK[32];

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
