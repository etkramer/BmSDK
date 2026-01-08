#pragma once

#include "Engine\TArray.h"

class UObject;
class FNameEntry;

class Runtime
{
private:
	Runtime() = delete;

public:
	static void OnAttach();
	static void GenerateSDK();

private:
	static void DetourProcessEvent();

public:
	static uintptr_t BaseAddress;

	static TArray<UObject*>* GObjects;
	static TArray<FNameEntry*>* GNames;

	static DWORD MainThreadId;
};
