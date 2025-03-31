#include "pch.h"
#include "Runtime.h"
#include "Engine\GameOffsets.h"
#include "Engine\UObject.h"

DECLARE_DETOUR(ProcessEvent, void, __fastcall, UObject*, void*, class UFunction*, void*, void*)

static void __fastcall ProcessEventDetour(UObject* pThis, void* unk, class UFunction* Function, void* Parms, void* Result)
{
	static bool isRuntimeReady = false;
	if (!isRuntimeReady)
	{
		Runtime::OnReady();
		isRuntimeReady = true;
	}

	// Call original
	ProcessEvent(pThis, unk, Function, Parms, Result);
}

void Runtime::DetourProcessEvent()
{
	Detours::DetourFunction(Runtime::BaseAddress + GameOffsets::UObject_ProcessEvent, &ProcessEvent, &ProcessEventDetour);
}
