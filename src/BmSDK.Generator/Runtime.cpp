#include "pch.h"
#include "Runtime.h"
#include "Engine\UClass.h"
#include "Engine\UProperty.h"
#include "Engine\GameOffsets.h"
#include "Printer\Printer.h"

#include <vector>

uintptr_t Runtime::BaseAddress = 0;

TArray<UObject*>* Runtime::GObjects = 0;
TArray<FNameEntry*>* Runtime::GNames = 0;

void Runtime::OnAttach()
{
	// Setup debug console
	Debug::Init();

	TRACE("Attached, waiting for engine ready");

	// Find base address
	Runtime::BaseAddress = (uintptr_t)(GetModuleHandle(NULL));

	// Set global pointers
	Runtime::GObjects = (TArray<UObject*>*)(void*)(Runtime::BaseAddress + GameOffsets::GObjects);
	Runtime::GNames = (TArray<FNameEntry*>*)(void*)(Runtime::BaseAddress + GameOffsets::GNames);

	// Don't do anything else until engine is ready
	Runtime::DetourProcessEvent();
}

void Runtime::OnReady()
{
	TRACE("\nReady, preparing SDK generation");

	TRACE("GObjects: Num = {}, Max = {}", Runtime::GObjects->Num, Runtime::GObjects->Max);
	TRACE("GNames: Num = {}, Max = {}", Runtime::GNames->Num, Runtime::GNames->Max);

	// Enumerate objects
	vector<UClass*> classObjects;
	for (INT i = 0; i < Runtime::GObjects->Num; i++)
	{
		auto obj = Runtime::GObjects->ElementAt(i);

		if (obj->IsA(UClass::StaticClass()))
		{
			classObjects.push_back((UClass*)obj);
		}
	}

	TRACE("Found {} classes", classObjects.size());

	classObjects.clear();
	classObjects.push_back(UObject::FindClass("Class Core.Object"));
	classObjects.push_back(UObject::FindClass("Class Core.Component"));
	classObjects.push_back(UObject::FindClass("Class Engine.ActorComponent"));

	// Print some classes
	for (auto i = 0u; i < classObjects.size(); i++)
	{
		auto classObj = classObjects.at(i);

		cout << "\n" << classObj->GetName() << ".g.cs:\n";
		Printer::PrintFile(classObj, cout);
	}

	// Exit game early
	exit(0);
	return;
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
