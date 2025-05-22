using System.Collections;
using BmSDK.Framework;

#pragma warning disable IDE0044
#pragma warning disable IDE0051
#pragma warning disable CS0169
#pragma warning disable CS0649

namespace BmSDK;

public unsafe struct TArray<TManaged> : IEnumerable<TManaged>, IReadOnlyCollection<TManaged>
{
    public readonly int Count => Num;

    private void* AllocatorInstance;
    private int Num;
    private int Max;

    public readonly TManaged this[int idx]
    {
        get => MarshalUtil.ToManaged<TManaged>(((byte*)AllocatorInstance) + (idx * sizeof(int)));
        set => MarshalUtil.ToUnmanaged(value, ((byte*)AllocatorInstance) + (idx * sizeof(int)));
    }

    public readonly unsafe IEnumerator<TManaged> GetEnumerator()
    {
        for (var i = 0; i < Num; i++)
        {
            yield return this[i];
        }
    }

    readonly IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }
}
