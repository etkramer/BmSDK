using System;

namespace BmSDK;

public unsafe class TArray<T>
{
	private readonly IntPtr _nativePtr;

	public void* DataPtr => *(void**)(_nativePtr + 0).ToPointer();
	public int Num => *(int*)(_nativePtr + 4).ToPointer();
	public int Max => *(int*)(_nativePtr + 8).ToPointer();

	public T GetElement(int i) => throw new NotImplementedException();
	public void SetElement(int i, T value) => throw new NotImplementedException();
}
