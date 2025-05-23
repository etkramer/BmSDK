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
#include <vector>
using namespace std;

#include <filesystem>
namespace fs = std::filesystem;

// FIELD() macro. Used to declare a field with a specific offset.
#define FIELD(TYPE, NAME)                                                                          \
public:                                                                                            \
	TYPE NAME;                                                                                     \
                                                                                                   \
private:

// CLASS() macro. Used to declare a class with a specific size.
#define CLASS(NAME, SIZE) static constexpr int SIZE_##NAME = SIZE;

// CHECK_CLASS() macro. Used to enforce a class matches its expected size.
#define CHECK_CLASS(TYPE, ...)                                                                     \
	static_assert(sizeof(TYPE##__VA_ARGS__) == SIZE_##TYPE, #TYPE " doesn't match declared size");

// STATIC_CLASS() macro. Used declare a StaticClass() helper.
#define STATIC_CLASS(PATH, ...)                                                                    \
	static class UClass* StaticClass()                                                             \
	{                                                                                              \
		static UClass* classObj = nullptr;                                                         \
		return classObj ? classObj : classObj = UObject::FindClass("Class "##PATH);                \
	}

// Framework
#include "Framework/Debug.h"
#include "Framework/Detours.h"
