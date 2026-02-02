#include <iostream>
#include <filesystem>

#include <Windows.h>
#include <cassert>

#include <coreclr_delegates.h>
#include <hostfxr.h>
#include <nethost.h>

#include "runtime.h"

using namespace std;
using namespace std::filesystem;

namespace runtime {
    // Func aliases for hostfxr
    using HostInitFn = hostfxr_initialize_for_runtime_config_fn;
    using HostGetDelegateFn = hostfxr_get_runtime_delegate_fn;
    using HostCloseFn = hostfxr_close_fn;
    using HostLoadAssemblyFn = load_assembly_and_get_function_pointer_fn;
    // Entry point func type alias
    typedef void(CORECLR_DELEGATE_CALLTYPE* ComponentEntryFn)();

    // Funcs from hostfxr
    static HostInitFn hostInitFn = nullptr;
    static HostGetDelegateFn hostGetDelegateFn = nullptr;
    static HostCloseFn hostCloseFn = nullptr;
    static HostLoadAssemblyFn hostLoadAssemblyFn = nullptr;

    // Filesystem helpers
    static path get_plugin_path() {
        wstring result(MAX_PATH, L'\0');
        GetModuleFileName(NULL, result.data(), MAX_PATH);
        return path(result);
    }

    static path get_game_dir() { return get_plugin_path().parent_path(); }

    static void* load_library(const char_t* path) {
        HMODULE h = LoadLibraryW(path);
        assert(h != nullptr);
        return (void*)h;
    }

    static void* get_export(void* h, const char* name) {
        void* f = GetProcAddress((HMODULE)h, name);
        assert(f != nullptr);
        return f;
    }

    // Using the nethost library, discover the location of hostfxr and get exports
    static bool load_hostfxr() {
        // Pre-allocate a large buffer for the path to hostfxr
        char_t buffer[MAX_PATH];
        size_t buffer_size = sizeof(buffer) / sizeof(char_t);
        int rc = get_hostfxr_path(buffer, &buffer_size, nullptr);
        if (rc != 0)
            return false;

        // Load hostfxr and get desired exports
        void* lib = load_library(buffer);
        hostInitFn = (HostInitFn)get_export(lib, "hostfxr_initialize_for_runtime_config");
        hostGetDelegateFn = (HostGetDelegateFn)get_export(lib, "hostfxr_get_runtime_delegate");
        hostCloseFn = (HostCloseFn)get_export(lib, "hostfxr_close");

        return (hostInitFn && hostGetDelegateFn && hostCloseFn);
    }

    // Load and initialize .NET Core and get desired function pointer for scenario
    static HostLoadAssemblyFn get_dotnet_load_assembly(const char_t* config_path) {
        // Load .NET Core
        void* hostLoadAssemblyFn = nullptr;
        hostfxr_handle cxt = nullptr;
        int rc = hostInitFn(config_path, nullptr, &cxt);
        if (rc != 0 || cxt == nullptr) {
            std::cerr << "Init failed: " << std::hex << std::showbase << rc << std::endl;
            hostCloseFn(cxt);
            return nullptr;
        }

        // Get the load assembly function pointer
        rc = hostGetDelegateFn(
            cxt,
            hdt_load_assembly_and_get_function_pointer,
            &hostLoadAssemblyFn);
        if (rc != 0 || hostLoadAssemblyFn == nullptr)
            std::cerr << "Get delegate failed: " << std::hex << std::showbase << rc << std::endl;

        hostCloseFn(cxt);
        return (HostLoadAssemblyFn)hostLoadAssemblyFn;
    }

    void load_dll() {
        // Load HostFxr and get exported hosting functions
        if (!load_hostfxr()) {
            assert(false && "Failure: load_hostfxr()");
            return;
        }

        // Initialize and start the .NET Core runtime
        const wstring basePath = get_game_dir();
        const wstring asmPath = L"\\sdk\\BmSDK";
        const wstring configPath = basePath + asmPath + L".runtimeconfig.json";
        hostLoadAssemblyFn = get_dotnet_load_assembly(configPath.c_str());
        assert(hostLoadAssemblyFn != nullptr && "Failure: get_dotnet_load_assembly()");

        // Load managed assembly and get function pointer to a managed method
        const wstring dotnetDllPath = basePath + asmPath + L".dll";
        const wstring dotnetType = L"BmSDK.Framework.Loader, BmSDK";
        const wstring dotnetMethod = L"GuardedDllMain";

        // Function pointer to managed delegate
        ComponentEntryFn GuardedDllMain = nullptr;
        int rc = hostLoadAssemblyFn(
            dotnetDllPath.c_str(),
            dotnetType.c_str(),
            dotnetMethod.c_str(),
            UNMANAGEDCALLERSONLY_METHOD,
            nullptr,
            (void**)&GuardedDllMain);

        if (rc != 0 || GuardedDllMain == nullptr) {
            assert(false && "Failure: hostLoadAssemblyFn()");
            return;
        }

        GuardedDllMain();
    }
}
