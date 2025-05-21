#pragma once

#include "UField.h"

enum class EPropertyFlags : DWORD
{
	CPF_OptionalParm = 0x10,
	CPF_Parm = 0x80,
	CPF_ReturnParm = 0x400
};

CLASS(UProperty, 72)
class UProperty : public UField
{
	INT ArrayDim;
	FIELD(EPropertyFlags, PropertyFlags)
	WORD ElementSize;
	FIELD(WORD, Offset)
	UProperty* PropertyLinkNext;
	UProperty* ConstructorLinkNext;
	UProperty* NextRef;

public:
	string GetInnerTypeNameManaged() const;
	STATIC_CLASS("Core.Property")
};

CLASS(UStructProperty, 76)
class UStructProperty : public UProperty
{
	FIELD(class UStruct*, Struct)

public:
	STATIC_CLASS("Core.StructProperty")
};

CLASS(UObjectProperty, 76)
class UObjectProperty : public UProperty
{
	FIELD(class UClass*, PropertyClass)

public:
	STATIC_CLASS("Core.ObjectProperty")
};

CLASS(UByteProperty, 76)
class UByteProperty : public UProperty
{
	FIELD(class UEnum*, Enum)

public:
	STATIC_CLASS("Core.ByteProperty")
};

CLASS(UArrayProperty, 76)
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
