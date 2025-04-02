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

CLASS(UStructProperty, 120)
class UStructProperty : public UProperty
{
	FIELD(class UStruct*, Struct)

public:
	STATIC_CLASS("Core.StructProperty")
};

CLASS(UObjectProperty, 120)
class UObjectProperty : public UProperty
{
	FIELD(class UClass*, PropertyClass)

public:
	STATIC_CLASS("Core.ObjectProperty")
};

CLASS(UByteProperty, 120)
class UByteProperty : public UProperty
{
	FIELD(class UEnum*, Enum)

public:
	STATIC_CLASS("Core.ByteProperty")
};

CLASS(UArrayProperty, 120)
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
