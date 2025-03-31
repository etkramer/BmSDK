#pragma once

// Windows API
#define WIN32_LEAN_AND_MEAN
#include <windows.h>
typedef unsigned __int64 QWORD;

// Standard library
#include <cstdlib>
#include <cstdint>
#include <iostream>
#include <format>
#include <string>
using namespace std;

// Helpers
#define FIELD(FieldType, FieldName) \
	public: FieldType FieldName; \
	private:

// Macros
#define ASSERT(x) if (!(x)) { std::cerr << "Assertion failed: " << #x << " in " << __FILE__  << " at line " << __LINE__ << std::endl; std::abort(); }
#define TRACE(x, ...) OutputDebugStringA((std::format(x, __VA_ARGS__) + "\n").c_str())

#undef ERROR
#define ERROR(x, ...) TRACE(x, __VA_ARGS__); abort();