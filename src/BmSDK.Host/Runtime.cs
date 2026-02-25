using System.Runtime.InteropServices;
using Windows.Win32;
using Windows.Win32.Foundation;
using static BmSDK.Host.HostfxrNative;

namespace BmSDK.Host;

static class Runtime
{
    static unsafe string GetGameDir()
    {
        Span<char> buffer = stackalloc char[260]; // MAX_PATH
        fixed (char* bufPtr = buffer)
        {
            PInvoke.GetModuleFileName(HMODULE.Null, bufPtr, (uint)buffer.Length);
        }

        return Path.GetDirectoryName(buffer.TrimEnd('\0').ToString())!;
    }

    static bool LoadHostfxr()
    {
        // Use nethost to discover hostfxr location
        Span<char> buffer = stackalloc char[260];
        int bufferSize = buffer.Length;
        int rc = get_hostfxr_path(buffer, ref bufferSize, 0);
        if (rc != 0)
            return false;

        // Load the hostfxr library so P/Invoke can resolve it
        string hostfxrPath = buffer[..bufferSize].TrimEnd('\0').ToString();
        PInvoke.LoadLibrary(hostfxrPath);

        return true;
    }

    static LoadAssemblyAndGetFunctionPointerFn? GetDotnetLoadAssembly(string configPath)
    {
        int rc = hostfxr_initialize_for_runtime_config(configPath, 0, out nint cxt);
        if (rc != 0 || cxt == 0)
        {
            Console.Error.WriteLine($"Init failed: 0x{rc:X}");
            if (cxt != 0) hostfxr_close(cxt);
            return null;
        }

        rc = hostfxr_get_runtime_delegate(
            cxt,
            HostfxrDelegateType.hdt_load_assembly_and_get_function_pointer,
            out nint loadAssemblyPtr);

        hostfxr_close(cxt);

        if (rc != 0 || loadAssemblyPtr == 0)
        {
            Console.Error.WriteLine($"Get delegate failed: 0x{rc:X}");
            return null;
        }

        return Marshal.GetDelegateForFunctionPointer<LoadAssemblyAndGetFunctionPointerFn>(loadAssemblyPtr);
    }

    public static void LoadDll()
    {
        // Load hostfxr
        if (!LoadHostfxr())
        {
            Console.Error.WriteLine("Failure: LoadHostfxr()");
            return;
        }

        // Initialize .NET Core runtime
        string gameDir = GetGameDir();
        string configPath = Path.Combine(gameDir, "sdk", "BmSDK.runtimeconfig.json");
        var loadAssembly = GetDotnetLoadAssembly(configPath);
        if (loadAssembly is null)
        {
            Console.Error.WriteLine("Failure: GetDotnetLoadAssembly()");
            return;
        }

        // Load managed assembly and get entry point
        string dllPath = Path.Combine(gameDir, "sdk", "BmSDK.dll");
        int rc = loadAssembly(
            dllPath,
            "BmSDK.Framework.Loader, BmSDK",
            "GuardedDllMain",
            UNMANAGEDCALLERSONLY_METHOD,
            0,
            out nint entryPoint);

        if (rc != 0 || entryPoint == 0)
        {
            Console.Error.WriteLine($"Failure: LoadAssemblyAndGetFunctionPointer() 0x{rc:X}");
            return;
        }

        // Call GuardedDllMain
        var guardedDllMain = Marshal.GetDelegateForFunctionPointer<Action>(entryPoint);
        guardedDllMain();
    }
}
