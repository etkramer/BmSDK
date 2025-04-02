#pragma once

#include "TArray.h"
#include "UField.h"

CLASS(UStruct, 132)
class UStruct : public UField
{
	BYTE UNK1[8];

	FIELD(UField*, Children)
	FIELD(INT, PropertiesSize)

	BYTE UNK2[58];

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
