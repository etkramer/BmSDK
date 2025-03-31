#pragma once

CLASS(TArray, 12)
template <typename T>
class TArray
{
public:
	FIELD(T*, AllocatorInstance, 0)
	FIELD(INT, Num, 4)
	FIELD(INT, Max, 8)

public:
	T& ElementAt(INT idx) const
	{
		return AllocatorInstance[idx];
	}
};

CHECK_CLASS(TArray, <BYTE>)
CHECK_FIELD(TArray<BYTE>, AllocatorInstance)
CHECK_FIELD(TArray<BYTE>, Num)
CHECK_FIELD(TArray<BYTE>, Max)
