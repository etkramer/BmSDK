#pragma once

#include <Windows.h>

#include <detours/detours.h>

#define DECLARE_DETOUR(NAME, RETURN, CONV, ...) \
    using NAME##Func = RETURN (CONV*)(__VA_ARGS__); \
    NAME##Func NAME = nullptr;

class DetourManager {
private:
    DetourManager() = delete;

public:
    template <typename TFunc>
    inline static bool Attach(TFunc* ppOriginalFunc, TFunc pDetourFunc) {
        DetourTransactionBegin();
        DetourUpdateThread(GetCurrentThread());
        DetourAttach(&(PVOID&)*ppOriginalFunc, pDetourFunc);
        return DetourTransactionCommit() == NO_ERROR;
    }

    static void RegisterEngineLoopPreInitDetour();
};
