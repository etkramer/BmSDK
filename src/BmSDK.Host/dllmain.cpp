#include <unknwn.h>
#include <string>
#include <vector>
#include <filesystem>

#include <coreclr_delegates.h>
#include <hostfxr.h>
#include <nethost.h>

#include <cassert>

using namespace std;
using namespace std::filesystem;

// Func aliases for hostfxr
typedef hostfxr_initialize_for_runtime_config_fn HostInitFn;
typedef hostfxr_get_runtime_delegate_fn HostGetDelegateFn;
typedef hostfxr_run_app_fn HostRunAppFn;
typedef hostfxr_close_fn HostCloseFn;
typedef load_assembly_and_get_function_pointer_fn HostLoadAssemblyFn;

// Funcs from hostfxr
HostInitFn hostInitFn = nullptr;
HostGetDelegateFn hostGetDelegateFn = nullptr;
HostCloseFn hostCloseFn = nullptr;
HostLoadAssemblyFn hostLoadAssemblyFn = nullptr;

// Filesystem helpers
wstring GetModulePath()
{
	wstring result(MAX_PATH, L'\0');
	GetModuleFileName(NULL, result.data(), MAX_PATH);
	return result;
}
wstring GetModuleDir() { return path(GetModulePath()).parent_path(); }

// Entry point func
typedef int(__stdcall* ComponentEntryFn)();

bool LoadHostModule()
{
	// Find hostfxr.dll
	wstring hostPath(MAX_PATH, L'\0');
	size_t hostPathLen = hostPath.size();
	assert(!get_hostfxr_path(hostPath.data(), &hostPathLen, nullptr));

	// Load hostfxr.dll
	HMODULE hostModule = LoadLibraryW(hostPath.data());
	hostInitFn = (hostfxr_initialize_for_runtime_config_fn)GetProcAddress(
		hostModule, "hostfxr_initialize_for_runtime_config");
	hostGetDelegateFn =
		(hostfxr_get_runtime_delegate_fn)GetProcAddress(hostModule, "hostfxr_get_runtime_delegate");
	hostCloseFn = (hostfxr_close_fn)GetProcAddress(hostModule, "hostfxr_close");

	return (hostInitFn && hostGetDelegateFn && hostCloseFn);
}

bool LoadAssembly(wstring asmPath)
{
	ComponentEntryFn entryFn = nullptr;

	// Locate assembly paths
	wstring basePath = GetModuleDir();
	wstring configPath = basePath + asmPath + L".runtimeconfig.json";
	wstring dllPath = basePath + asmPath + TEXT(".dll");

	// Launch .NET runtime
	hostfxr_handle ctx = nullptr;
	assert(!hostInitFn(configPath.c_str(), nullptr, &ctx) && ctx);

	// Find 'load assembly' func
	assert(!hostGetDelegateFn(ctx, hdt_load_assembly_and_get_function_pointer,
							  (void**)(void*)(&hostLoadAssemblyFn)) &&
		   hostLoadAssemblyFn);
	hostCloseFn(ctx);

	// Load managed assembly
	wstring entryTypeName = TEXT("BmSDK.Framework.Loader, BmSDK");
	wstring entryMethodName = TEXT("GuardedDllMain");
	wstring entryDelegateName = TEXT("BmSDK.Framework.Loader+DllMainDelegate, BmSDK");
	auto loadAssemblyResult =
		hostLoadAssemblyFn(dllPath.c_str(), entryTypeName.c_str(), entryMethodName.c_str(),
						   entryDelegateName.c_str(), nullptr, (void**)&entryFn);

	// Call loader entry func
	assert(loadAssemblyResult == 0);
	assert(entryFn != nullptr);
	return !entryFn();
}

void OnAttach()
{
	// Load hostfxr.dll
	assert(LoadHostModule());

	// Load BmSDK.Loader.dll
	assert(LoadAssembly(TEXT("/sdk/BmSDK")));
}

BOOL APIENTRY DllMain(HMODULE hModule, DWORD ul_reason_for_call, LPVOID lpReserved)
{
	switch (ul_reason_for_call)
	{
	case DLL_PROCESS_ATTACH:
		OnAttach();
		break;
	case DLL_THREAD_ATTACH:
	case DLL_THREAD_DETACH:
	case DLL_PROCESS_DETACH:
		break;
	}
	return TRUE;
}
