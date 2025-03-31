#pragma once

CLASS(TArray, 12)
template <typename T>
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

CHECK_CLASS(TArray, <BYTE>)
