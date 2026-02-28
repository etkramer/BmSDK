#include "pch.h"
#include "Runtime.h"
#include "Engine\UClass.h"
#include "Engine\UProperty.h"
#include "Engine\GameOffsets.h"
#include "Framework\ClassGraph.h"
#include "Printer\Printer.h"

#include <cstdint>
#include <fstream>
#include <thread>
#include <atomic>
#include <regex>

uintptr_t Runtime::BaseAddress = 0;
DWORD Runtime::MainThreadId = 0;

TArray<UObject*>* Runtime::GObjects = 0;
TArray<FNameEntry*>* Runtime::GNames = 0;
LoadPackageFn Runtime::LoadPackage = 0;

void Runtime::OnAttach()
{
    // Setup debug console
    Debug::Init();

    // Find base address
    Runtime::BaseAddress = (uintptr_t)(GetModuleHandle(NULL));

    // Get the main thread Id
    Runtime::MainThreadId = GetCurrentThreadId();

    // Set global pointers
    Runtime::GObjects = (TArray<UObject*>*) (Runtime::BaseAddress + GameOffsets::GObjects);
    Runtime::GNames = (TArray<FNameEntry*>*) (Runtime::BaseAddress + GameOffsets::GNames);
    Runtime::LoadPackage = (LoadPackageFn)(Runtime::BaseAddress + GameOffsets::LoadPackage);

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

                    HANDLE mainThread = OpenThread(THREAD_SUSPEND_RESUME, FALSE, Runtime::MainThreadId);
                    if (mainThread) SuspendThread(mainThread);

                    Runtime::GenerateSDK();

                    if (mainThread) {
                        ResumeThread(mainThread);
                        CloseHandle(mainThread);
                    }
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
        L"(?:^Core$|^Engine$|^BmGame$|^OnlineSubsystem|"
        // match if Playable_ is NOT present, but _SF is
        // SeekFree packages don't contain classes
        L"^(?!Playable_).*_SF$|"
        // match if these are present anywhere
        L"_Static|_FX|_Lights|_CLights|_Audio|_LOD|_Px|ShaderCache|"
        // match if these are at the start
        L"^Anim_|^Bio_|^CS_|^CV_|^Dlg-|^LH-|^WwSpch-|^Tape|^Synopsis|^Gallery)",
        regex_constants::icase);

    const auto upkDir = fs::path{ "." } / ".." / ".." / "BmGame" / "CookedPCConsole";
    for (const auto& entry : fs::directory_iterator(upkDir)) {
        if (!entry.is_regular_file()) continue;	// filter files
        if (entry.path().extension() != ".upk") continue;	// filter UPKs
        auto name = entry.path().stem().wstring();

        // Filter packages that are only for assets
        if (regex_search(name, packageFilter)) continue;

        LoadPackage(0, name.c_str(), 0);
    }
    TRACE("Done loading packages");
}

void Runtime::GenerateSDK()
{
    TRACE("Preparing SDK generation");

    LoadClassesIntoMemory();

    // Build class graph upfront (single pass over GObjects)
    TRACE("Building class graph from {} objects", Runtime::GObjects->Num);
    auto graph = ClassGraph::Build();

    const auto& classNodes = graph->GetAllClasses();
    TRACE("Found {} classes, preparing to print", classNodes.size());

    // Clear output directory
    // TODO: Un-hardcode this
    fs::path outDir = "..\\..\\..\\src\\BmSDK\\Generated\\";
    fs::remove_all(outDir);
    fs::create_directory(outDir);

    // Print classes using graph nodes
    for (auto classNode : classNodes)
    {
        auto classFilePath =
            outDir / classNode->packageName / (classNode->managedName + ".g.cs");

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

        Printer::PrintFile(classNode, classFileStream, graph);
    }

    // Print StaticInit file
    ofstream staticInitFileStream(outDir / "StaticInit.g.cs", ios::trunc);
    Printer::PrintStaticInit(classNodes, staticInitFileStream, graph);

    TRACE("Done writing {} classes to disk", classNodes.size());

    // Cleanup
    delete graph;

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
