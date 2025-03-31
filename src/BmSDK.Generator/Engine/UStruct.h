#pragma once

#include "TArray.h"
#include "UField.h"

CLASS(UStruct, 136)
class UStruct : public UField
{
	BYTE UNK1[8];

	FIELD(UField*, Children, 64);
	FIELD(INT, PropertiesSize, 68);

	TArray<BYTE> Script;
	INT TextPos;
	INT Line;
	INT MinAlignment;

	class UProperty* RefLink;
	class UProperty* PropertyLink;
	class UProperty* ConfigLink;
	class UProperty* ConstructorLink;
	class UProperty* ComponentPropertyLink;
	class UProperty* TransientPropertyLink;

	TArray<UObject*> ScriptObjectReferences;
};

CHECK_CLASS(UStruct)
CHECK_FIELD(UStruct, Children)
CHECK_FIELD(UStruct, PropertiesSize)
