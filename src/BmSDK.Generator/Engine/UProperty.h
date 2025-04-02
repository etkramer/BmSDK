#pragma once

#include "UField.h"

CLASS(UProperty, 112)
class UProperty : public UField
{
	BYTE UNK1[28];

	FIELD(INT, Offset)

	BYTE UNK2[24];

public:
	string GetInnerTypeNameManaged() const;
	STATIC_CLASS("Core.Property")
};

CHECK_CLASS(UProperty)

CLASS(UStructProperty, 120)
class UStructProperty : public UProperty
{
	FIELD(class UStruct*, Struct)

public:
	STATIC_CLASS("Core.StructProperty")
};

CHECK_CLASS(UStructProperty)

CLASS(UObjectProperty, 120)
class UObjectProperty : public UProperty
{
	FIELD(class UClass*, PropertyClass)

public:
	STATIC_CLASS("Core.ObjectProperty")
};

CHECK_CLASS(UObjectProperty)

CLASS(UByteProperty, 120)
class UByteProperty : public UProperty
{
	FIELD(class UEnum*, Enum)

public:
	STATIC_CLASS("Core.ByteProperty")
};

CHECK_CLASS(UByteProperty)
