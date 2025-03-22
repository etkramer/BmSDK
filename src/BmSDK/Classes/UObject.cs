using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

[assembly: SuppressMessage("Usage", "IDE1006:Naming rule violation")]
[assembly: SuppressMessage("Usage", "IDE0130:Namespace does not match folder structure")]

namespace BmSDK;

public partial class UObject
{
    public IntPtr Ptr { get; protected init; } = IntPtr.Zero;

    // Generic accessors for script props
    public unsafe T GetPropertyValue<T>(IntPtr offset) => MarshalToManaged<T>((Ptr + offset).ToPointer());
    public unsafe void SetPropertyValue<T>(IntPtr offset, T value) => MarshalToNative(value, (Ptr + offset).ToPointer());

    // Special handling for bool props (bitfields)
    protected bool GetBoolPropertyValue(IntPtr offset, int bit) => (GetPropertyValue<int>(offset) & (1 << bit)) != 0;
    protected void SetBoolPropertyValue(IntPtr offset, int bit, bool value)
    {
        var currentValue = GetPropertyValue<int>(offset);
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

    // Marshals unmanaged data to managed, then returns it.
    private static unsafe TNative MarshalToManaged<TNative>(void* data)
    {
        // TODO: UStrProperty
        // TODO: UNameProperty
        // TODO: UArrayProperty
        // TODO: UObjectProperty, UClassProperty, UComponentProperty

        // Try to copy memory directly (for struct, primitive types)
        //if (typeof(TNative).IsValueType)
        //{
        //    return (TNative)Marshal.PtrToStructure((IntPtr)data, typeof(TNative))!;
        //}
        if (typeof(TNative).IsValueType)
        {
            return Unsafe.As<byte, TNative>(ref ((byte*)data)[0]);
        }
        else if (typeof(TNative).IsAssignableTo(typeof(UObject)))
        {
            // TODO: Should check if we already have a managed class associated with
            // this object pointer, then either return it or create a new one.
        }

        throw new NotImplementedException($"Marshaling not implemented for type {typeof(TNative).Name}");
    }

    // Marshals a managed object to native, then copies it into an existing buffer.
    private static unsafe void MarshalToNative<T>(T value, void* data)
    {
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
            MarshalToNative(((UObject)(object)value!).Ptr, data);
            return;
        }

        throw new NotImplementedException($"Marshaling not implemented for type {typeof(T).Name}");
    }
}
