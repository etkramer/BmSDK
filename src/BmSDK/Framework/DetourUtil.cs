using Windows.Win32;
using PInvokeDetours = Microsoft.Detours.PInvoke;

namespace BmSDK.Framework;

public static class DetourUtil
{
    // Keep delegates in memory to avoid GC
    static readonly List<Delegate> _detourDelegateRefs = [];

    // Creates a detour and returns the original function
    public static unsafe T NewDetour<T>(IntPtr funcOffset, T detourFunc)
        where T : Delegate
    {
        void* origFuncPtr = MemUtil.GetPointer(funcOffset);

        // Get a pointer to the managed detour method
        _detourDelegateRefs.Add(detourFunc);
        void* managedDetourFuncPtr = Marshal.GetFunctionPointerForDelegate(detourFunc).ToPointer();

        PInvokeDetours.DetourRestoreAfterWith();

        Guard.Require(PInvokeDetours.DetourTransactionBegin() == 0);
        Guard.Require(PInvokeDetours.DetourUpdateThread(PInvoke.GetCurrentThread()) == 0);
        Guard.Require(PInvokeDetours.DetourAttach(&origFuncPtr, managedDetourFuncPtr) == 0);
        Guard.Require(PInvokeDetours.DetourTransactionCommit() == 0);

        return Marshal.GetDelegateForFunctionPointer<T>((IntPtr)origFuncPtr);
    }
}
