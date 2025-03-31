#pragma once

// Windows API
#define WIN32_LEAN_AND_MEAN
#include <windows.h>
typedef unsigned __int64 QWORD;

// Standard library
#include <cstdint>
#include <cstdlib>
#include <format>
#include <iostream>
#include <string>
using namespace std;

// FIELD() macro. Used to declare a field with a specific offset.
#define FIELD(TYPE, NAME) \
public:                   \
	TYPE NAME;            \
                          \
private:

// CLASS() macro. Used to declare a class with a specific size.
#define CLASS(NAME, SIZE) \
	static constexpr int SIZE_##NAME = SIZE;

// CHECK_CLASS() macro. Used to enforce a class matches its expected size.
#define CHECK_CLASS(TYPE, ...) \
	static_assert(sizeof(TYPE##__VA_ARGS__) == SIZE_##TYPE, #TYPE " doesn't match declared size");

// Debug macros
#define ASSERT(x)                                                                                              \
	if (!(x))                                                                                                  \
	{                                                                                                          \
		std::cerr << "Assertion failed: " << #x << " in " << __FILE__ << " at line " << __LINE__ << std::endl; \
		std::abort();                                                                                          \
	}
#define TRACE(x, ...) OutputDebugStringA((std::format(x, __VA_ARGS__) + "\n").c_str())

#undef ERROR
#define ERROR(x, ...)      \
	TRACE(x, __VA_ARGS__); \
	abort();
