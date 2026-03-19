#pragma once

CLASS(TArray, 16)
template <typename T> class TArray
{
public:
	FIELD(T*, AllocatorInstance)
	FIELD(INT, Num)
	FIELD(INT, Max)

public:
	T& ElementAt(INT idx) const { return AllocatorInstance[idx]; }
};

CHECK_CLASS(TArray, <BYTE>)

// BM4 stores these inline
class GObjectsArray
{
public:
	class UObject* Data[785000];
    INT Unk;
	INT Num;
	INT Max;

public:
	class UObject* ElementAt(INT idx) const { return Data[idx]; }
};
