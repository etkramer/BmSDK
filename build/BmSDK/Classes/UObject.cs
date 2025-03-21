using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.InteropServices;

[assembly: SuppressMessage("Usage", "IDE1006:Naming rule violation")]
[assembly: SuppressMessage("Usage", "IDE0130:Namespace does not match folder structure")]

namespace BmSDK;

public partial class UObject
{
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
            // TODO: Should check if we already have a managed class associated with
            // this object pointer, then either return it or create a new one.
        }

        throw new NotImplementedException($"Marshaling not implemented for type {typeof(T).Name}");
    }

    private static unsafe void MarshalToNative<T>(T value, void* data)
    {
        // Marshals a managed object to native, then copies it into an existing buffer.

        // TODO: UStrProperty
        // TODO: UNameProperty
        // TODO: UArrayProperty
        // TODO: UClassProperty

        // Try to copy memory directly (for struct, primitive types)
        if (typeof(T).IsValueType)
        {
            Marshal.StructureToPtr(value!, (IntPtr)data, false);
            return;
        }
        else if (typeof(T).IsAssignableTo(typeof(UObject)))
        {
            // We already have a pointer to this object's native instance, so just assign it.
            MarshalToNative(((UObject)(object)value!)._nativePtr, data);
            return;
        }

        throw new NotImplementedException($"Marshaling not implemented for type {typeof(T).Name}");
    }
}
