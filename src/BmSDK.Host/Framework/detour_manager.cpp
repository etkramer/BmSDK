#include "detour_manager.h"
#include "offsets.h"
#include "../runtime.h"

DECLARE_DETOUR(EngineLoopPreInit, void*, __fastcall, void*, void*)

static void* __fastcall EngineLoopPreInitDetour(void* a1, void* Source) {
    // Init .NET and BmSDK.dll if not yet done
    static bool isRuntimeReady = false;
    if (!isRuntimeReady) {
        runtime::load_dll();
        isRuntimeReady = true;
    }

    // Call original
    return EngineLoopPreInit(a1, Source);
}

void DetourManager::RegisterEngineLoopPreInitDetour() {
    Attach(
        offsets::BaseAddress + offsets::EngineLoopPreInit,
        &EngineLoopPreInit,
        &EngineLoopPreInitDetour
    );
}
