#pragma once

#include "UField.h"

enum class EPropertyFlags : QWORD
{
	CPF_OptionalParm = 0x10,
	CPF_Parm = 0x80,
	CPF_ReturnParm = 0x400
};

CLASS(UProperty, 112)
class UProperty : public UField
{
	BYTE UNK1[8];

	FIELD(EPropertyFlags, PropertyFlags)

	BYTE UNK2[12];

	FIELD(INT, Offset)

	BYTE UNK3[24];

public:
	string GetInnerTypeNameManaged() const;
	STATIC_CLASS("Core.Property")
};

CLASS(UStructProperty, 116)
class UStructProperty : public UProperty
{
	FIELD(class UStruct*, Struct)

public:
	STATIC_CLASS("Core.StructProperty")
};

CLASS(UObjectProperty, 116)
class UObjectProperty : public UProperty
{
	FIELD(class UClass*, PropertyClass)

public:
	STATIC_CLASS("Core.ObjectProperty")
};

CLASS(UByteProperty, 116)
class UByteProperty : public UProperty
{
	FIELD(class UEnum*, Enum)

public:
	STATIC_CLASS("Core.ByteProperty")
};

CLASS(UArrayProperty, 116)
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
