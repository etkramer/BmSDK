#pragma once

#include "../pch.h"

template<typename T>
class TArray
{
public:
	FIELD(T*, AllocatorInstance)
	FIELD(INT, Num)
	FIELD(INT, Max)

public:
	T& ElementAt(INT idx) const
	{
		return AllocatorInstance[idx];
	}
};