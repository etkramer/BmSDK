#include "pch.h"
#include "Detours.h"
#include "Runtime.h"
#include "Game/Offsets.h"
#include "Engine\TArray.h"
#include "Engine\UObject.h"

DECLARE_DETOUR(ProcessEvent, void, __fastcall, UObject*, void*, class UFunction*, void*, void*)
DECLARE_DETOUR(WinShowWindow, BOOL, WINAPI, HWND, int nCmdShow)

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

void Detours::DetourProcessEvent()
{
	Detours::DetourFunction(Runtime::BaseAddress + Offsets::UObject_ProcessEvent, &ProcessEvent, &ProcessEventDetour);
}
