#include <unknwn.h>
#include <string>
#include <vector>
#include <filesystem>

#include <coreclr_delegates.h>
#include <hostfxr.h>
#include <nethost.h>

#include <cassert>
#include <iostream>

using namespace std;
using namespace std::filesystem;

// Func aliases for hostfxr
using HostInitFn = hostfxr_initialize_for_runtime_config_fn;
using HostGetDelegateFn = hostfxr_get_runtime_delegate_fn;
using HostCloseFn = hostfxr_close_fn;
using HostLoadAssemblyFn = load_assembly_and_get_function_pointer_fn;
// Entry point func type alias
typedef void(CORECLR_DELEGATE_CALLTYPE* ComponentEntryFn)();

// Funcs from hostfxr
HostInitFn hostInitFn = nullptr;
HostGetDelegateFn hostGetDelegateFn = nullptr;
HostCloseFn hostCloseFn = nullptr;
HostLoadAssemblyFn hostLoadAssemblyFn = nullptr;

hostfxr_handle cxt = nullptr;

// Filesystem helpers
static path get_plugin_path()
{
	wstring result(MAX_PATH, L'\0');
	GetModuleFileName(NULL, result.data(), MAX_PATH);
	return path(result);
}

static path get_game_dir() { return get_plugin_path().parent_path(); }

static void* load_library(const char_t* path)
{
	HMODULE h = LoadLibraryW(path);
	assert(h != nullptr);
	return (void*)h;
}
static void* get_export(void* h, const char* name)
{
	void* f = GetProcAddress((HMODULE)h, name);
	assert(f != nullptr);
	return f;
}

// Using the nethost library, discover the location of hostfxr and get exports
static bool load_hostfxr(const char_t* assembly_path)
{
	get_hostfxr_parameters params{
		sizeof(get_hostfxr_parameters),
		assembly_path,
		nullptr
	};

	// Pre-allocate a large buffer for the path to hostfxr
	char_t buffer[MAX_PATH];
	size_t buffer_size = sizeof(buffer) / sizeof(char_t);
	int rc = get_hostfxr_path(buffer, &buffer_size, &params);
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
static HostLoadAssemblyFn get_dotnet_load_assembly(const char_t* config_path)
{
	// Load .NET Core
	void* hostLoadAssemblyFn = nullptr;
	int rc = hostInitFn(config_path, nullptr, &cxt);
	if (rc != 0 || cxt == nullptr)
	{
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

	return (HostLoadAssemblyFn)hostLoadAssemblyFn;
}

static void load_dll() {
	const wstring basePath = get_game_dir();
	const wstring asmPath = L"\\sdk\\BmSDK";
	const wstring dotnetDllPath = basePath + asmPath + L".dll";

	// Load HostFxr and get exported hosting functions
	if (!load_hostfxr(dotnetDllPath.c_str())) {
		assert(false && "Failure: load_hostfxr()");
		return;
	}

	// Initialize and start the .NET Core runtime
	const wstring configPath = basePath + asmPath + L".runtimeconfig.json";
	hostLoadAssemblyFn = get_dotnet_load_assembly(configPath.c_str());
	assert(hostLoadAssemblyFn != nullptr && "Failure: get_dotnet_load_assembly()");

	// Load managed assembly and get function pointer to a managed method
	const wstring dotnetType = L"BmSDK.Framework.Loader, BmSDK";
	const wstring dotnetMethod = L"GuardedDllMain";
	const wstring dotnetMethodDelegate = L"BmSDK.Framework.Loader+DllMainDelegate, BmSDK";

	// Function pointer to managed delegate
	ComponentEntryFn GuardedDllMain = nullptr;
	int rc = hostLoadAssemblyFn(
		dotnetDllPath.c_str(),
		dotnetType.c_str(),
		dotnetMethod.c_str(),
		dotnetMethodDelegate.c_str(),
		nullptr,
		(void**)&GuardedDllMain);

	GuardedDllMain();
}

BOOL APIENTRY DllMain(HMODULE hModule, DWORD ul_reason_for_call, LPVOID lpReserved)
{
	switch (ul_reason_for_call)
	{
	case DLL_PROCESS_ATTACH:
		load_dll();
		break;
	case DLL_THREAD_ATTACH:
		break;
	case DLL_THREAD_DETACH:
		break;
	case DLL_PROCESS_DETACH:
		hostCloseFn(cxt);
		break;
	}
	return TRUE;
}
