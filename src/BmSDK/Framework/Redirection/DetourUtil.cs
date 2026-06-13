using Windows.Win32;
using PInvokeDetours = Microsoft.Detours.PInvoke;

namespace BmSDK.Framework;

public static class DetourUtil
{
    private static readonly List<Delegate> s_detourDelegateRefs = [];

    /// <summary>
    /// Creates a new detour to a native function via an offset.
    /// </summary>
    /// <typeparam name="T">The delegate type of the detoured function</typeparam>
    /// <param name="funcOffset">The offset (in bytes) to the function within the game executable.
    /// This should be a relative offset; do not include the base address.</param>
    /// <param name="detourFunc">Delegate to execute instead of the original function</param>
    /// <returns>Delegate of the original function</returns>
    public static unsafe T NewDetour<T>(IntPtr funcOffset, T detourFunc)
        where T : Delegate
    {
        // Keep delegates in memory to avoid GC
        s_detourDelegateRefs.Add(detourFunc);

        // Get necessary pointers for attachment
        var origFuncPtr = MemUtil.GetPointer(funcOffset);
        var detourFuncPtr = Marshal.GetFunctionPointerForDelegate(detourFunc).ToPointer();

        // Attach detour
        Guard.Require(PInvokeDetours.DetourTransactionBegin() == 0);
        Guard.Require(PInvokeDetours.DetourUpdateThread(PInvoke.GetCurrentThread()) == 0);
        Guard.Require(PInvokeDetours.DetourAttach(&origFuncPtr, detourFuncPtr) == 0);
        Guard.Require(PInvokeDetours.DetourTransactionCommit() == 0);

        // Get delegate to original implementation
        return Marshal.GetDelegateForFunctionPointer<T>((IntPtr)origFuncPtr);
    }
}
