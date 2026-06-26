#pragma once
#include "TArray.h"
#include "../Runtime.h"

// NOTE: Not fixed-size. Engine intentionally avoids allocating
// complete FNameEntry instances, basing the actual size on the name length.
class FNameEntry
{
	INT Index;
	INT HashNext;

	SHORT NameLen;
    SHORT Pad;

	union
	{
		char AnsiName[128];
		wchar_t UniName[128];
	};

public:
	string ToString() const
	{
        // Mirrored in FName.cs

		// BM4: Names are sometimes stored as pointers instead of inline text.
		if ((Index & 0x2) != 0)
		{
			return string(*(char**)&AnsiName);
		}

		return string(AnsiName);
	}
};

CLASS(FName, 8)
class FName
{
	FIELD(INT, Index)
	FIELD(INT, Number)

public:
	string ToString() const
	{
		auto str = GetNameEntry()->ToString();
		return Number == 0 ? str : std::format("{}_{}", str, Number - 1);
	}

	const FNameEntry* GetNameEntry() const { return Runtime::GNames->ElementAt(Index); }
};

CHECK_CLASS(FName)
