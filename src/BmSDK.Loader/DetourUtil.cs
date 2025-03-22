using System.Diagnostics;
using System.Runtime.InteropServices;
using BmSDK.Framework;
using Windows.Win32;
using Windows.Win32.Foundation;

using PInvokeDetours = Microsoft.Detours.PInvoke;

namespace BmSDK.Loader;

public static class DetourUtil
{
    // Keep delegates in memory to avoid GC
    static readonly List<Delegate> _detourDelegateRefs = [];

    public static T NewDetour<T>(IntPtr funcOffset, T detourFunc) where T : Delegate
    {
        // Creates a detour and returns the original function

        Debug.WriteLine($"Detouring 0x{MemUtil.GetIntPointer(funcOffset):X} (0x{funcOffset:X})");

        unsafe
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
}
