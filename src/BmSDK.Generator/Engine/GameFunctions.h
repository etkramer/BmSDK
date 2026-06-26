#pragma once

class UObject;
class UClass;

using LoadPackageFn = void* (__cdecl*)(void* InOuter, const wchar_t* Filename, int LoadFlags);
using BeginLoadFn = void (__cdecl*)();
using EndLoadFn = void (__cdecl*)();
using CollectGarbageFn = void (__cdecl*)(QWORD KeepFlags, int bPerformFullPurge);
using StaticFindObjectFn = UObject* (__cdecl*)(
    UClass* Class,
    UObject* InOuter,
    const wchar_t* OrigInName,
    int ExactClass);

class GameFunctions
{
private:
    GameFunctions() = delete;

public:
    static void Init(uintptr_t baseAddress);

    static LoadPackageFn LoadPackage;
    static BeginLoadFn BeginLoad;
    static EndLoadFn EndLoad;
    static CollectGarbageFn CollectGarbage;
    static StaticFindObjectFn StaticFindObject;
};
