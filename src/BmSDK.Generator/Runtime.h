#pragma once

#include "Engine\TArray.h"
#include "Framework\ClassInfo.h"

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

    static GObjectsArray* GObjects;
    static TArray<FNameEntry*>* GNames;
    static vector<ClassInfo> Classes;
};
