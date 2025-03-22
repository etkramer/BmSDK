using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.InteropServices;
using BmSDK.Framework;

[assembly: SuppressMessage("Usage", "IDE1006:Naming rule violation")]
[assembly: SuppressMessage("Usage", "IDE0130:Namespace does not match folder structure")]

namespace BmSDK;

public partial class UObject
{
    public IntPtr Ptr { get; internal set; } = IntPtr.Zero;

    // Generic accessors for script props
    public unsafe T GetPropertyValue<T>(IntPtr offset) => MarshalUtil.MarshalToManaged<T>((Ptr + offset).ToPointer());
    public unsafe void SetPropertyValue<T>(IntPtr offset, T value) => MarshalUtil.MarshalToNative(value, (Ptr + offset).ToPointer());

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
}