using System.Diagnostics;

#pragma warning disable CS8500

namespace BmSDK.Framework;

public static class MemUtil
{
    static IntPtr s_baseAddress = 0;

    public static IntPtr GetBaseAddress()
    {
        if (s_baseAddress == 0)
        {
            var proc = Process.GetCurrentProcess();
            s_baseAddress = Guard.NotNull(proc.MainModule?.BaseAddress);
        }

        return s_baseAddress;
    }

    public static unsafe IntPtr GetIntPointer(IntPtr offset) => (IntPtr)GetPointer(offset);

    public static unsafe void* GetPointer(IntPtr offset) => GetPointer<byte>(offset);

    public static unsafe T* GetPointer<T>(IntPtr offset)
        where T : unmanaged
    {
        // Converts an offset to a pointer
        return (T*)(GetBaseAddress() + offset).ToPointer();
    }

    public static unsafe void Blit<TSrc>(TSrc src, void* destPtr) =>
        *(TSrc*)destPtr = Blit<TSrc>(&src);

    public static unsafe TDest Blit<TDest>(void* srcPtr)
    {
        var dest = default(TDest)!;
        Blit(*(TDest*)srcPtr, ref dest);

        return dest;
    }

    public static unsafe void Blit<TSrc, TDest>(TSrc src, ref TDest dest)
    {
        Guard.Require(
            typeof(TSrc).IsValueType && typeof(TDest).IsValueType,
            "Can't blit managed reference types!"
        );
        Guard.Require(sizeof(TSrc) == sizeof(TDest), "Can't blit types with mismatched sizes!");

        fixed (TDest* destPtr = &dest)
        {
            Buffer.MemoryCopy(&src, destPtr, sizeof(TDest), sizeof(TSrc));
        }
    }
}
