#include "pch.h"
#include "Engine\TArray.h"
#include "Engine\UObject.h"
#include "Engine\UClass.h"
#include "Engine\UProperty.h"
#include "Runtime.h"
#include "Game/Offsets.h"
#include "Detours.h"

#include <detours/detours.h>

uintptr_t Runtime::BaseAddress = 0;

TArray<UObject*>* Runtime::GObjects = 0;
TArray<FNameEntry*>* Runtime::GNames = 0;

void Runtime::OnAttach()
{
	TRACE("Attached, waiting for engine ready");

	// Find base address
	Runtime::BaseAddress = (uintptr_t)(GetModuleHandle(NULL));

	// Set global pointers
	Runtime::GObjects = (TArray<UObject*>*)(void*)(Runtime::BaseAddress + 0x2231BE4);
	Runtime::GNames = (TArray<FNameEntry*>*)(void*)(Runtime::BaseAddress + 0x2231BB4);

	// Don't do anything else until engine is ready
	Detours::DetourProcessEvent();
}

void Runtime::OnReady()
{
	TRACE("\nReady, preparing SDK generation");
	TRACE("GObjects: Num={}, Max={}", Runtime::GObjects->Num, Runtime::GObjects->Max);

	// Grab class objects
	auto propClass = UObject::FindClass("Class Core.Property");
	auto someClass = UObject::FindClass("Class Engine.SkeletalMeshComponent");
	TRACE("Class {} (size {}):", someClass->GetName(), someClass->PropertiesSize);

	// Enumerate class members
	auto propLink = someClass->Children;
	while (propLink != NULL)
	{
		if (propLink->IsA(propClass))
		{
			TRACE("  {}: {} {}", ((UProperty*)propLink)->Offset, propLink->Class->GetName(), propLink->GetName());
		}
		else
		{
			TRACE("  {} {}", propLink->Class->GetName(), propLink->GetName());
		}
		propLink = propLink->Next;
	}
}

BOOL APIENTRY DllMain(HMODULE hModule, DWORD ul_reason_for_call, LPVOID lpReserved)
{
	switch (ul_reason_for_call)
	{
	case DLL_PROCESS_ATTACH:
		Runtime::OnAttach();
		break;
	case DLL_THREAD_ATTACH:
	case DLL_THREAD_DETACH:
	case DLL_PROCESS_DETACH:
		break;
	}
	return TRUE;
}