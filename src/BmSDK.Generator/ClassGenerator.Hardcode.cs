namespace BmSDK.Generator;

partial class ClassGenerator
{
    const string OBJECT_HARDCODES = """
    private readonly IntPtr _nativePtr;

    protected unsafe object GetPropertyValue(IntPtr offset, string propClassName)
    {
        return MarshalToManaged((_nativePtr + offset).ToPointer(), propClassName);
    }

    protected bool GetBoolPropertyValue(IntPtr offset, int bit)
    {
        return ((int)GetPropertyValue(offset, "UIntProperty") & (1 << bit)) != 0;
    }

    protected unsafe void SetPropertyValue(IntPtr offset, string propClassName, object value)
    {
        MarshalToNative(value, propClassName, (_nativePtr + offset).ToPointer());
    }

    protected void SetBoolPropertyValue(IntPtr offset, int bit, bool value)
    {
        int currentValue = (int)GetPropertyValue(offset, "UIntProperty");
        if (value)
        {
            currentValue |= 1 << bit;
        }
        else
        {
            currentValue &= ~(1 << bit);
        }
        SetPropertyValue(offset, "UIntProperty", currentValue);
    }

    private static unsafe object MarshalToManaged(void* data, string propClassName)
    {
        // Marshals unmanaged data to managed, then returns it.
		if (propClassName == "UIntProperty")
        {
            return *(int*)data;
        }
		else if (propClassName == "UFloatProperty")
        {
            return *(float*)data;
        }
        else if (propClassName == "UByteProperty")
        {
            return *(byte*)data;
        }

		// TODO: UStrProperty
		// TODO: UNameProperty
		// TODO: UArrayProperty
		// TODO: UStructProperty
		// TODO: UObjectProperty, UClassProperty, UComponentProperty

        throw new NotImplementedException($"Marshaling not implemented for type {propClassName}");
    }

    private static unsafe void MarshalToNative(object obj, string propClassName, void* data)
    {
        // Marshals a managed object to native, then copies it into an existing buffer.
		if (propClassName == "UIntProperty")
        {
            *(int*)data = (int)obj;
        }
		else if (propClassName == "UFloatProperty")
        {
            *(float*)data = (float)obj;
        }
		else if (propClassName == "UByteProperty")
        {
            *(byte*)data = (byte)obj;
        }

		// TODO: UStrProperty
		// TODO: UNameProperty
		// TODO: UArrayProperty
		// TODO: UStructProperty
		// TODO: UObjectProperty, UClassProperty, UComponentProperty

        throw new NotImplementedException($"Marshaling not implemented for type {propClassName}");
    }
""";

    const string ARRAY_HARDCODES = """
public unsafe class TArray<T>
{
	private readonly IntPtr _nativePtr;

	public void* DataPtr => *(void**)(_nativePtr + 4).ToPointer();
	public int Num => *(int*)(_nativePtr + 4).ToPointer();
	public int Max => *(int*)(_nativePtr + 8).ToPointer();

	public T GetElement(int i) => throw new NotImplementedException();
	public void SetElement(int i, T value) => throw new NotImplementedException();
}
""";
}
