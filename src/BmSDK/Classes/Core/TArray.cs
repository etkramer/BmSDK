using System.Collections;
using BmSDK.Framework;

#pragma warning disable IDE0044
#pragma warning disable CS0169
#pragma warning disable CS0649

namespace BmSDK;

public unsafe struct TArray<TManaged> : IReadOnlyList<TManaged>
{
    public readonly int Count => Num;
    public readonly int Stride => MarshalUtil.GetSizeUnmanaged<TManaged>();

    private IntPtr AllocatorInstance;
    private int Num;
    private int Max;

    public readonly TManaged this[int idx]
    {
        get => MarshalUtil.ToManaged<TManaged>(AllocatorInstance + (idx * Stride));
        set => MarshalUtil.ToUnmanaged(value, AllocatorInstance + (idx * Stride));
    }

    public readonly unsafe IEnumerator<TManaged> GetEnumerator()
    {
        for (var i = 0; i < Num; i++)
        {
            yield return this[i];
        }
    }

    readonly IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();

    public readonly IntPtr GetDataPointer() => AllocatorInstance;
}
