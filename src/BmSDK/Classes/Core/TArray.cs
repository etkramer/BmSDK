using System.Collections;
using System.Collections.Generic;
using BmSDK.Framework;

namespace BmSDK;

public unsafe struct TArray<TManaged> : IEnumerable<TManaged>
{
    public void* AllocatorInstance;
    public int Num;
    public int Max;

    public readonly TManaged this[int idx]
    {
        get =>
            MarshalUtil.MarshalToManaged<TManaged>(
                ((byte*)AllocatorInstance) + (idx * sizeof(int))
            );
        set => MarshalUtil.MarshalToNative(value, ((byte*)AllocatorInstance) + (idx * sizeof(int)));
    }

    public readonly unsafe IEnumerator<TManaged> GetEnumerator()
    {
        for (var i = 0; i < Num; i++)
        {
            yield return this[i];
        }
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }
}
