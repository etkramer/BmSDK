#pragma once

#include "TArray.h"
#include "UField.h"

CLASS(UStruct, 108)
class UStruct : public UField
{
    BYTE UNK1[8];
    FIELD(UStruct*, SuperStruct)
        FIELD(UField*, Children)
        FIELD(WORD, PropertiesSize)
        WORD MinAlignment;

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
