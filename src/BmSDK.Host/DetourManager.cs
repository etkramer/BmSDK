using System.Runtime.InteropServices;
using Windows.Win32;
using PInvokeDetours = Microsoft.Detours.PInvoke;

namespace BmSDK.Host;

static class DetourManager
{
    [UnmanagedFunctionPointer(CallingConvention.FastCall)]
    delegate int EngineLoopPreInitFunc(nint a1, nint a2, nint source);

    static EngineLoopPreInitFunc? s_originalEngineLoopPreInit;
    static EngineLoopPreInitFunc? s_detourDelegate;
    static bool s_isRuntimeReady;

    public static unsafe void RegisterEngineLoopPreInitDetour()
    {
        void* origFuncPtr = (void*)(Offsets.BaseAddress + Offsets.EngineLoopPreInit);

        s_detourDelegate = EngineLoopPreInitDetour;
        void* detourPtr = Marshal.GetFunctionPointerForDelegate(s_detourDelegate).ToPointer();

        PInvokeDetours.DetourTransactionBegin();
        PInvokeDetours.DetourUpdateThread(PInvoke.GetCurrentThread());
        PInvokeDetours.DetourAttach(&origFuncPtr, detourPtr);
        PInvokeDetours.DetourTransactionCommit();

        s_originalEngineLoopPreInit = Marshal.GetDelegateForFunctionPointer<EngineLoopPreInitFunc>((nint)origFuncPtr);
    }

    static int EngineLoopPreInitDetour(nint a1, nint a2, nint source)
    {
        if (!s_isRuntimeReady)
        {
            Runtime.LoadDll();
            s_isRuntimeReady = true;
        }

        return s_originalEngineLoopPreInit!(a1, a2, source);
    }
}
