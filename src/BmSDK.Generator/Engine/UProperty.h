#pragma once

#include "UField.h"

enum class EPropertyFlags : DWORD
{
	CPF_Parm = 0x8,
	CPF_OptionalParm = 0x10,
	CPF_ReturnParm = 0x80
};

CLASS(UProperty, 88)
class UProperty : public UField
{
	INT ArrayDim;
	FIELD(EPropertyFlags, PropertyFlags)
	BYTE UNK1[4];
	WORD ElementSize;
	FIELD(WORD, Offset)
	BYTE UNK2[24];

public:
	string GetInnerTypeNameManaged() const;
	STATIC_CLASS("Core.Property")
};

CLASS(UStructProperty, 92)
class UStructProperty : public UProperty
{
	FIELD(class UScriptStruct*, Struct)

public:
	STATIC_CLASS("Core.StructProperty")
};

CLASS(UObjectProperty, 92)
class UObjectProperty : public UProperty
{
	FIELD(class UClass*, PropertyClass)

public:
	STATIC_CLASS("Core.ObjectProperty")
};

CLASS(UByteProperty, 92)
class UByteProperty : public UProperty
{
	FIELD(class UEnum*, Enum)

public:
	STATIC_CLASS("Core.ByteProperty")
};

CLASS(UArrayProperty, 92)
class UArrayProperty : public UProperty
{
	FIELD(class UProperty*, Inner)

public:
	STATIC_CLASS("Core.ArrayProperty")
};

CHECK_CLASS(UProperty)
CHECK_CLASS(UStructProperty)
CHECK_CLASS(UObjectProperty)
CHECK_CLASS(UByteProperty)
CHECK_CLASS(UArrayProperty)
