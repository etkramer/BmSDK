using System.Diagnostics;
using BmSDK.Framework;

namespace BmSDK.Loader;

public static class MemUtil
{
    static IntPtr _baseAddress = 0;

    public static IntPtr GetBaseAddress()
    {
        if (_baseAddress == 0)
        {
            var proc = Process.GetCurrentProcess();
            _baseAddress = Guard.NotNull(proc.MainModule?.BaseAddress);
        }

        return _baseAddress;
    }

    public static unsafe IntPtr GetIntPointer(IntPtr offset) => (IntPtr)GetPointer(offset);
    public static unsafe void* GetPointer(IntPtr offset) => GetPointer<byte>(offset);
    public static unsafe T* GetPointer<T>(IntPtr offset) where T : unmanaged
    {
        // Converts an offset to a pointer
        return (T*)(GetBaseAddress() + offset).ToPointer();
    }

    public static unsafe T StructCast<T, R>(R input) where T : unmanaged where R : unmanaged
    {
        return *(T*)&input;
    }
}
