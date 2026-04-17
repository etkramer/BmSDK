using System.Runtime.InteropServices;
using Windows.Win32;
using PInvokeDetours = Microsoft.Detours.PInvoke;

namespace BmSDK.DevMode;

internal static class DetourHelper
{
    private static readonly List<Delegate> s_refs = [];

    internal static unsafe T CreateDetour<T>(IntPtr targetAddr, T hookFunc)
        where T : Delegate
    {
        s_refs.Add(hookFunc);
        var target = (void*)targetAddr;
        var hook = Marshal.GetFunctionPointerForDelegate(hookFunc).ToPointer();

        PInvokeDetours.DetourRestoreAfterWith();
        if (PInvokeDetours.DetourTransactionBegin() != 0)
        {
            throw new InvalidOperationException("DetourTransactionBegin failed");
        }
        PInvokeDetours.DetourUpdateThread(PInvoke.GetCurrentThread());
        PInvokeDetours.DetourAttach(&target, hook);
        if (PInvokeDetours.DetourTransactionCommit() != 0)
        {
            throw new InvalidOperationException("DetourTransactionCommit failed");
        }

        return Marshal.GetDelegateForFunctionPointer<T>((IntPtr)target);
    }
}
