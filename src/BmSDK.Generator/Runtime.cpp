#include "pch.h"
#include "Runtime.h"
#include "Engine\UClass.h"
#include "Engine\UProperty.h"
#include "Engine\GameOffsets.h"
#include "Printer\Printer.h"

#include <vector>
#include <fstream>

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

	TRACE("\nGObjects: Num = {}, Max = {}", Runtime::GObjects->Num, Runtime::GObjects->Max);
	TRACE("GNames: Num = {}, Max = {}\n", Runtime::GNames->Num, Runtime::GNames->Max);

	// Clear output directory
	TRACE("Clearing output directory");
	fs::path outDir = "I:\\BmSDK\\src\\BmSDK\\Generated\\";
	fs::remove_all(outDir);
	fs::create_directory(outDir);

	// Enumerate objects
	vector<UClass*> classObjects;
	for (INT i = 0; i < Runtime::GObjects->Num; i++)
	{
		auto obj = Runtime::GObjects->ElementAt(i);

		// Collect class objects (but not the CDO)
		if (obj->IsA(UClass::StaticClass()) && obj->GetName() != "Default__Class")
		{
			classObjects.push_back((UClass*)obj);
		}
	}

	TRACE("Found {} loaded classes", classObjects.size());

	// Print some classes
	for (auto i = 0u; i < classObjects.size(); i++)
	{
		auto classObj = classObjects.at(i);
		auto classFilePath =
			outDir / classObj->GetPackageName() / (classObj->GetNameManaged() + ".g.cs");

		if (!fs::exists(classFilePath.parent_path()) &&
			fs::exists(classFilePath.parent_path().parent_path()))
		{
			TRACE("Creating output subdir {}", classFilePath.parent_path().filename().string());
			fs::create_directories(classFilePath.parent_path());
		}

		ofstream classFileStream(classFilePath, ios::trunc);
		if (!classFileStream.is_open())
		{
			TRACE("Couldn't open file {}", classFilePath.string());
			continue;
		}

		// TRACE("Printing {}", classObj->GetPathName());
		Printer::PrintFile(classObj, classFileStream);
	}

	// Print StaticInit file
	ofstream staticInitFileStream(outDir / "StaticInit.g.cs", ios::trunc);
	Printer::PrintStaticInit(classObjects, staticInitFileStream);

	TRACE("Done writing {} classes to disk", classObjects.size());

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
