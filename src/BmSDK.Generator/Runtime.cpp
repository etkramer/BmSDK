#include "pch.h"
#include "Runtime.h"
#include "Engine\UClass.h"
#include "Engine\UProperty.h"
#include "Engine\GameOffsets.h"

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

		// Print namespace declaration
		cout << "namespace " << classObj->GetPackageNameManaged() << ";" << endl;
		cout << "\n";

		// Print class comment
		cout << "/// <summary>" << endl;
		cout << "/// Class: " << classObj->GetNameManaged() << "<br/>" << endl;
		cout << "/// (size = " << classObj->PropertiesSize << ")" << endl;
		cout << "/// </summary>" << endl;

		// Print class declaration
		cout << "public class " << classObj->GetNameManaged();
		if (classObj->SuperField)
		{
			cout << " : " << classObj->SuperField->GetPathNameManaged();
		}
		cout << endl;

		// Print class body
		cout << "{" << endl;
		{
			UField* fieldLink = classObj->Children;
			while (fieldLink)
			{
				if (!fieldLink->IsA(UProperty::StaticClass()))
				{
					fieldLink = fieldLink->Next;
					continue;
				}

				auto prop = (UProperty*)fieldLink;

				// Print prop comment
				cout << "    /// <summary>" << endl;
				cout << "    /// Property: " << prop->GetName() << endl;
				cout << "    /// </summary>" << endl;

				// Print prop declaration
				cout << "    public " << prop->GetInnerTypeNameManaged() << " " << prop->GetName()
					 << endl;

				// Print prop body
				cout << "    {" << endl;
				cout << "        get => throw new System.NotImplementedException();" << endl;
				cout << "        set => throw new System.NotImplementedException();" << endl;
				cout << "    }" << endl;

				if (prop->Next && prop->Next->IsA(UProperty::StaticClass()))
				{
					cout << endl;
				}

				fieldLink = fieldLink->Next;
			}
		}
		cout << "}" << endl;
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
