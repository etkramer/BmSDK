#pragma once

#include "UField.h"

class UProperty : public UField
{
	INT ArrayDim;

	BYTE UNK1[24];
	FIELD(SHORT, Offset);
	BYTE UNK2[24];
};