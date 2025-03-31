#pragma once

#include "TArray.h"
#include "UField.h"

class UStruct : public UField
{
	BYTE UNK1[8];
	FIELD(UField*, Children);
	FIELD(INT, PropertiesSize);

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