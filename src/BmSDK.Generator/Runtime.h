#pragma once

#include "Engine\TArray.h"

using LoadPackageFn = void* (__cdecl*)(void* InOuter, const wchar_t* Filename, int LoadFlags);

class UObject;
class FNameEntry;

class Runtime
{
private:
	Runtime() = delete;

public:
	static void OnAttach();
	static void LoadClassesIntoMemory();
	static void GenerateSDK();

private:
	static void DetourProcessEvent();

public:
	static uintptr_t BaseAddress;
	static DWORD MainThreadId;

	static TArray<UObject*>* GObjects;
	static TArray<FNameEntry*>* GNames;
	static LoadPackageFn LoadPackage;
};
