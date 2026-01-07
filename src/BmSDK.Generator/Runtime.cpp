#include "pch.h"
#include "Runtime.h"
#include "Engine\UClass.h"
#include "Engine\UProperty.h"
#include "Engine\GameOffsets.h"
#include "Printer\Printer.h"

#include <cstdint>
#include <fstream>
#include <thread>
#include <atomic>
#include <regex>

uintptr_t Runtime::BaseAddress = 0;

TArray<UObject*>* Runtime::GObjects = 0;
TArray<FNameEntry*>* Runtime::GNames = 0;
LoadPackageFn Runtime::LoadPackage = 0;

void Runtime::OnAttach()
{
	// Setup debug console
	Debug::Init();

	// Find base address
	Runtime::BaseAddress = (uintptr_t)(GetModuleHandle(NULL));

	// Set global pointers
	Runtime::GObjects = (TArray<UObject*>*)(void*)(Runtime::BaseAddress + GameOffsets::GObjects);
	Runtime::GNames = (TArray<FNameEntry*>*)(void*)(Runtime::BaseAddress + GameOffsets::GNames);
	Runtime::LoadPackage =
		reinterpret_cast<LoadPackageFn>(
			(void*)(Runtime::BaseAddress + GameOffsets::LoadPackage)
		);

	// Wait for keypress in another thread
	std::thread(
		[]()
		{
			TRACE("Press 'P' to start SDK generation");
			while (true)
			{
				if ((GetAsyncKeyState('P') & 0x8000))
				{
					DWORD foregroundPID = 0;
					GetWindowThreadProcessId(GetForegroundWindow(), &foregroundPID);

					// Don't generate if the game window isn't focused.
					if (foregroundPID != GetCurrentProcessId())
					{
						continue;
					}

					// Perform SDK generation
					Runtime::GenerateSDK();
					break;
				}
				this_thread::sleep_for(chrono::milliseconds(100));
			}
		})
		.detach();
}

void Runtime::LoadClassesIntoMemory() {
	TRACE("Loading all UPKs into memory");

	const wregex packageFilter(
		// exact match these names
		// these packages are always loaded
		L"(?:^Core$|^Engine$|^BmGame$|^OnlineSubsystem$|"
		// match if Playable_ is NOT present, but _SF is
		// SeekFree packages don't contain classes
		L"^(?!Playable_).*_SF$|"
		// match if these affixes are present anywhere
		L"_Static|_FX|_Lights|_CLights|_Audio|_LOD|_Px|Anim_|Bio_|CS_|CV_|"
		L"Dlg-|LH-|WwSpch-|"
		L"ShaderCache|Tape|Synopsis|Gallery)",
		regex_constants::icase);

	const auto upkDir = fs::path{ "." } / ".." / ".." / "BmGame" / "CookedPCConsole";
	for (const auto& entry : fs::directory_iterator(upkDir)) {
		if (!entry.is_regular_file()) continue;	// filter files
		if (entry.path().extension() != ".upk") continue;	// filter UPKs
		//auto stem = entry.path().stem();
		auto name = entry.path().stem().wstring();

		// Filter packages that are only for assets
		if (regex_search(name, packageFilter)) continue;

		//TRACE("Loading in: {}", stem.string());
		LoadPackage(0, name.c_str(), 0);
	}
	TRACE("Done loading packages");
}

void Runtime::GenerateSDK()
{
	TRACE("Preparing SDK generation");

	LoadClassesIntoMemory();

	TRACE("Scanning {} objects for classes", Runtime::GObjects->Num);

	// Enumerate objects
	vector<UClass*> classObjects;
	for (INT i = 0; i < Runtime::GObjects->Num; i++)
	{
		auto obj = Runtime::GObjects->ElementAt(i);

		bool isValid = obj != nullptr && (Runtime::GObjects->ElementAt(obj->Index) == obj);
		if (!isValid)
		{
			TRACE("Skipping invalid object {} ({})", obj->GetName(), obj->Index);
			continue;
		}

		// Collect class objects (but not the CDO)
		if (obj->IsA(UClass::StaticClass()) && obj->GetName() != "Default__Class")
		{
			classObjects.push_back((UClass*)obj);
		}
	}

	// Clear output directory
	// TODO: Un-hardcode this
	TRACE("Found {} classes, preparing to print", classObjects.size());
	fs::path outDir = "..\\..\\..\\src\\BmSDK\\Generated\\";
	fs::remove_all(outDir);
	fs::create_directory(outDir);

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
