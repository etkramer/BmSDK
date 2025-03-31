#pragma once
#include "TArray.h"
#include "../Runtime.h"

constexpr INT NAME_UNICODE_MASK = 0x1;
constexpr INT NAME_INDEX_SHIFT = 1;

class FNameEntry
{
	FIELD(QWORD, Flags)
	FIELD(INT, Index)
	FNameEntry* HashNext;

	union
	{
		FIELD(char, AnsiName[128])
		FIELD(wchar_t, UniName[128])
	};

public:
	string ToString() const
	{
		if (IsUnicode())
		{
			wstring wstr = wstring(UniName);
			return string(wstr.begin(), wstr.end());
		}
		else
		{
			return string(AnsiName);
		}
	}

	INT GetIndex() const
	{
		return Index >> NAME_INDEX_SHIFT;
	}

	BOOL IsUnicode() const
	{
		return (Index & NAME_UNICODE_MASK);
	}
};

class FName
{
	FIELD(INT, Index)
	INT Number;

public:
	string ToString() const
	{
		return GetNameEntry().ToString();
	}

	const FNameEntry GetNameEntry() const
	{
		return *Runtime::GNames->ElementAt(Index);
	}
};