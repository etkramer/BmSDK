#include <cassert>
#include <filesystem>
#include <iostream>

#include <coreclr_delegates.h>
#include <hostfxr.h>
#include <nethost.h>
#include <Windows.h>

#include "runtime.h"

using namespace std;
using namespace std::filesystem;

namespace Runtime {
    // Func aliases for hostfxr
    using HostInitFn = hostfxr_initialize_for_runtime_config_fn;
    using HostGetDelegateFn = hostfxr_get_runtime_delegate_fn;
    using HostCloseFn = hostfxr_close_fn;
    using HostLoadAssemblyFn = load_assembly_and_get_function_pointer_fn;
    // Entry point func type alias
    typedef void(CORECLR_DELEGATE_CALLTYPE* ComponentEntryFn)();

    // Funcs from hostfxr
    static HostInitFn hostInit = nullptr;
    static HostGetDelegateFn hostGetDelegate = nullptr;
    static HostCloseFn hostClose = nullptr;
    static HostLoadAssemblyFn hostLoadAssembly = nullptr;

    // Filesystem helpers
    static path GetPluginPath() {
        wstring result(MAX_PATH, L'\0');
        GetModuleFileName(NULL, result.data(), MAX_PATH);
        return path(result);
    }

    static path GetGameDir() { return GetPluginPath().parent_path(); }

    static void* LoadLibFromPath(const char_t* path) {
        HMODULE h = LoadLibrary(path);
        assert(h != nullptr);
        return (void*)h;
    }

    static void* GetExport(void* h, const char* name) {
        void* f = GetProcAddress((HMODULE)h, name);
        assert(f != nullptr);
        return f;
    }

    // Using the nethost library, discover the location of hostfxr and get exports
    static bool LoadHostFxr() {
        // Pre-allocate a large buffer for the path to hostfxr
        char_t buffer[MAX_PATH];
        size_t bufferSize = sizeof(buffer) / sizeof(char_t);
        int rc = get_hostfxr_path(buffer, &bufferSize, nullptr);
        if (rc != 0)
            return false;

        // Load hostfxr and get desired exports
        void* lib = LoadLibFromPath(buffer);
        hostInit = (HostInitFn)GetExport(lib, "hostfxr_initialize_for_runtime_config");
        hostGetDelegate = (HostGetDelegateFn)GetExport(lib, "hostfxr_get_runtime_delegate");
        hostClose = (HostCloseFn)GetExport(lib, "hostfxr_close");

        return (hostInit && hostGetDelegate && hostClose);
    }

    // Load and initialize .NET Core and get desired function pointer for scenario
    static HostLoadAssemblyFn GetDotnetLoadAssembly(const char_t* config_path) {
        // Load .NET Core
        void* hostLoadAssembly = nullptr;
        hostfxr_handle cxt = nullptr;
        int rc = hostInit(config_path, nullptr, &cxt);
        if (rc != 0 || cxt == nullptr) {
            std::cerr << "Init failed: " << std::hex << std::showbase << rc << std::endl;
            hostClose(cxt);
            return nullptr;
        }

        // Get the load assembly function pointer
        rc = hostGetDelegate(
            cxt,
            hdt_load_assembly_and_get_function_pointer,
            &hostLoadAssembly);
        if (rc != 0 || hostLoadAssembly == nullptr)
            std::cerr << "Get delegate failed: " << std::hex << std::showbase << rc << std::endl;

        hostClose(cxt);
        return (HostLoadAssemblyFn)hostLoadAssembly;
    }

    void LoadDll() {
        // Load HostFxr and get exported hosting functions
        if (!LoadHostFxr()) {
            assert(false && "Failure: LoadHostFxr()");
            return;
        }

        // Initialize and start the .NET Core runtime
        const wstring basePath = GetGameDir();
        const wstring asmPath = L"\\sdk\\BmSDK";
        const wstring configPath = basePath + asmPath + L".runtimeconfig.json";
        hostLoadAssembly = GetDotnetLoadAssembly(configPath.c_str());
        assert(hostLoadAssembly != nullptr && "Failure: GetDotnetLoadAssembly()");

        // Load managed assembly and get function pointer to a managed method
        const wstring dotnetDllPath = basePath + asmPath + L".dll";
        const wstring dotnetType = L"BmSDK.Framework.Loader, BmSDK";
        const wstring dotnetMethod = L"GuardedDllMain";

        // Function pointer to managed delegate
        ComponentEntryFn GuardedDllMain = nullptr;
        int rc = hostLoadAssembly(
            dotnetDllPath.c_str(),
            dotnetType.c_str(),
            dotnetMethod.c_str(),
            UNMANAGEDCALLERSONLY_METHOD,
            nullptr,
            (void**)&GuardedDllMain);

        if (rc != 0 || GuardedDllMain == nullptr) {
            assert(false && "Failure: hostLoadAssembly()");
            return;
        }

        GuardedDllMain();
    }
}
