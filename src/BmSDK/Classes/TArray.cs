using System;

namespace BmSDK;

public unsafe class TArray<T>(IntPtr ptr)
{
	protected readonly IntPtr Ptr = ptr;

    public void* DataPtr => *(void**)(Ptr + 0).ToPointer();
	public int Num => *(int*)(Ptr + 4).ToPointer();
	public int Max => *(int*)(Ptr + 8).ToPointer();

	public T GetElement(int i) => throw new NotImplementedException();
	public void SetElement(int i, T value) => throw new NotImplementedException();
}
