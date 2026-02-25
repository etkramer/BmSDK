using System.Runtime.InteropServices;
using Windows.Win32;
using Windows.Win32.Foundation;
using PInvokeDetours = Microsoft.Detours.PInvoke;

namespace BmSDK.Host;

static class DllMain
{
    const uint DLL_PROCESS_ATTACH = 1;

    [UnmanagedCallersOnly(EntryPoint = "DllMain")]
    static bool Main(nint hModule, uint reason, nint reserved)
    {
        if (reason == DLL_PROCESS_ATTACH)
        {
            InitRuntime();
        }

        return true;
    }

    static void InitRuntime()
    {
        Offsets.BaseAddress = (nuint)PInvoke.GetModuleHandle(default(PCWSTR)).Value;
        PInvokeDetours.DetourRestoreAfterWith();
        DetourManager.RegisterEngineLoopPreInitDetour();
    }
}
