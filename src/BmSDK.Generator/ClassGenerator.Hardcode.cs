namespace BmSDK.Generator;

partial class ClassGenerator
{
    const string OBJECT_HARDCODES = """
    private readonly IntPtr _nativePtr;

    protected unsafe T GetPropertyValue<T>(IntPtr offset)
    {
        return MarshalToManaged<T>((_nativePtr + offset).ToPointer());
    }

    protected bool GetBoolPropertyValue(IntPtr offset, int bit)
    {
        return (GetPropertyValue<int>(offset) & (1 << bit)) != 0;
    }

    protected unsafe void SetPropertyValue<T>(IntPtr offset, T value)
    {
        MarshalToNative(value, (_nativePtr + offset).ToPointer());
    }

    protected void SetBoolPropertyValue(IntPtr offset, int bit, bool value)
    {
        int currentValue = GetPropertyValue<int>(offset);
        if (value)
        {
            currentValue |= 1 << bit;
        }
        else
        {
            currentValue &= ~(1 << bit);
        }
        SetPropertyValue(offset, currentValue);
    }

	private static unsafe T MarshalToManaged<T>(void* data)
    {
		// Marshals unmanaged data to managed, then returns it.

		// TODO: UStrProperty
		// TODO: UNameProperty
		// TODO: UArrayProperty
		// TODO: UObjectProperty, UClassProperty, UComponentProperty
		
		// Try to copy memory directly (for struct, primitive types)
		if (typeof(T).IsValueType)
		{
			return (T)Marshal.PtrToStructure((IntPtr)data, typeof(T))!;
		}
		else if (typeof(T).IsAssignableTo(typeof(UObject)))
		{
			// TODO
		}

        throw new NotImplementedException($"Marshaling not implemented for type {typeof(T).Name}");
    }

    private static unsafe void MarshalToNative<T>(T value, void* data)
    {
		// Marshals a managed object to native, then copies it into an existing buffer.

		// TODO: UStrProperty
		// TODO: UNameProperty
		// TODO: UArrayProperty
		// TODO: UObjectProperty, UClassProperty, UComponentProperty

		// Try to copy memory directly (for struct, primitive types)
		if (typeof(T).IsValueType)
		{
			Marshal.StructureToPtr(value!, (IntPtr)data, false);
			return;
		}
		else if (typeof(T).IsAssignableTo(typeof(UObject)))
		{
			// TODO
		}

        throw new NotImplementedException($"Marshaling not implemented for type {typeof(T).Name}");
    }
""";

    const string ARRAY_HARDCODES = """
public unsafe class TArray<T>
{
	private readonly IntPtr _nativePtr;

	public void* DataPtr => *(void**)(_nativePtr + 0).ToPointer();
	public int Num => *(int*)(_nativePtr + 4).ToPointer();
	public int Max => *(int*)(_nativePtr + 8).ToPointer();

	public T GetElement(int i) => throw new NotImplementedException();
	public void SetElement(int i, T value) => throw new NotImplementedException();
}
""";

    const string ASSEMBLY_HARDCODES = """
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Usage", "IDE1006:Naming rule violation")]
""";
}
