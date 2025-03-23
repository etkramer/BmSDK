using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.CompilerServices;
using BmSDK.Framework;
namespace BmSDK;

public unsafe class TArray<TManaged>(IntPtr ptr) : IEnumerable<TManaged>
{
	public readonly IntPtr Ptr = ptr;

    public void* AllocatorInstance => *(void**)(Ptr + 0).ToPointer();
	public int Num => *(int*)(Ptr + 4).ToPointer();
	public int Max => *(int*)(Ptr + 8).ToPointer();

    public TManaged this[int idx]
    {
        get => MarshalUtil.MarshalToManaged<TManaged>(((byte*)AllocatorInstance) + (idx * sizeof(int)));
        set => MarshalUtil.MarshalToNative(value, ((byte*)AllocatorInstance) + (idx * sizeof(int)));
    }

    public unsafe IEnumerator<TManaged> GetEnumerator()
    {
        for (var i = 0; i < Num; i++)
        {
            yield return this[i];
        }
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return this.GetEnumerator();
    }
}
