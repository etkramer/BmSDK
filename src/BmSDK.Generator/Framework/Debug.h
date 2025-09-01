#pragma once

#include <iostream>
#include <debugapi.h>

// ASSERT() macro.
#define ASSERT(x)                                                                                  \
	if (!(x))                                                                                      \
	{                                                                                              \
		std::cerr << "Assertion failed: " << #x << " in " << __FILE__ << " at line " << __LINE__   \
				  << std::endl;                                                                    \
		std::abort();                                                                              \
	}

// TRACE() macro. Used to write output to the debug console.
#define TRACE(x, ...) std::cout << (std::format("Generator: "##x, __VA_ARGS__) + "\n")

#undef ERROR
#define ERROR(x, ...)                                                                              \
	TRACE(x, __VA_ARGS__);                                                                         \
	abort();

namespace Debug
{
	void Init();

	class DebugStream : public std::streambuf
	{
		virtual int overflow(int c) override
		{
			if (c != EOF)
			{
				char ch = static_cast<char>(c);
				OutputDebugStringA(std::string(1, ch).c_str());
			}
			return c;
		}
	};
}
