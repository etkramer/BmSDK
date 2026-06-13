#pragma once

#include <Windows.h>
#include <detours/detours.h>

#include "offsets.h"

#define DECLARE_DETOUR(NAME, RETURN, CONV, ...) \
    using NAME##Fn = RETURN (CONV*)(__VA_ARGS__); \
    NAME##Fn NAME = nullptr;

class DetourManager {
public:
    static void RegisterDetours();

private:
    DetourManager() = delete;
    template <typename TFunc>
    inline static bool Attach(uintptr_t pOrigAddr, TFunc* pOrigFunc, TFunc pDetourFunc) {
        // Set original function reference
        *pOrigFunc = (TFunc)(Offsets::BaseAddress + pOrigAddr);

        // Register detour
        return DetourAttach(&(PVOID&)*pOrigFunc, pDetourFunc) == NO_ERROR;
    }
};
