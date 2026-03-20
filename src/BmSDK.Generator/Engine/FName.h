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

	static bool IsNameChar(unsigned char c)
	{
		return (c >= 'A' && c <= 'Z') || (c >= 'a' && c <= 'z') || (c >= '0' && c <= '9') ||
			   c == '_';
	}

public:
	string ToString() const
	{
        // Mirrored in FName.cs

		// Sometimes this struct stores a pointer to a string, instead of having it inline.
		// It's not clear how to check this properly yet, so we implement a heuristic
		// to try and detect pointers.

		// Short inline names (e.g. "HUD\0") can look like valid pointers when
		// read as 8 bytes. Check for valid name chars followed by a null first.
		bool shortInline = false;
		for (int i = 0; i < 8; i++)
		{
			if (AnsiName[i] == '\0')
			{
				shortInline = (i > 0);
				break;
			}

			if (!IsNameChar(AnsiName[i]))
			{
				break;
			}
		}

		if (!shortInline)
		{
			uintptr_t nameAsPtr = *(uintptr_t*)&AnsiName;
			if ((nameAsPtr > 0x10000) && ((nameAsPtr >> 48) == 0))
			{
				return string((char*)nameAsPtr);
			}
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
	string ToString() const { return GetNameEntry()->ToString(); }

	const FNameEntry* GetNameEntry() const { return Runtime::GNames->ElementAt(Index); }
};

CHECK_CLASS(FName)
