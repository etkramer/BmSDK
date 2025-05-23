using System.Collections;
using BmSDK.Framework;

#pragma warning disable IDE0044
#pragma warning disable IDE0051
#pragma warning disable CS0169
#pragma warning disable CS0649

namespace BmSDK;

public unsafe struct TArray<TManaged> : IReadOnlyList<TManaged>
{
    public readonly int Count => Num;

    private IntPtr AllocatorInstance;
    private int Num;
    private int Max;

    // Could we be wrongly assuming that elements of AllocatorInstance are always pointers?
    // We're used to seeing it where the element type is UObject* (4-byte pointer/sizeof(int)) - what if it's just tightly-packed in general?
    // In that case we'd want sizeof(FSplitScreenData), not sizeof(int). So we need to store and multiply by some Stride.
    public readonly TManaged this[int idx]
    {
        get => MarshalUtil.ToManaged<TManaged>(AllocatorInstance + (idx * sizeof(int)));
        set => MarshalUtil.ToUnmanaged(value, AllocatorInstance + (idx * sizeof(int)));
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
