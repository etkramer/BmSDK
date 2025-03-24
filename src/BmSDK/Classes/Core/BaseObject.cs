global using System;
global using System.Runtime.InteropServices;
using System.Diagnostics.CodeAnalysis;
using BmSDK.Framework;

[assembly: SuppressMessage("Usage", "IDE1006:Naming rule violation")]
[assembly: SuppressMessage("Usage", "IDE0130:Namespace does not match folder structure")]

namespace BmSDK;

public partial class BaseObject
{
    public IntPtr Ptr { get; internal set; } = IntPtr.Zero;

    /// <summary>
    /// Gets a property value from a <see cref="BaseObject"/> instance
    /// </summary>
    public static unsafe TValue GetPropertyValue<TValue>(BaseObject obj, IntPtr offset) =>
        MarshalUtil.MarshalToManaged<TValue>((obj.Ptr + offset).ToPointer());

    /// <summary>
    /// Gets a property value from a struct instance
    /// </summary>
    public static unsafe TValue GetPropertyValue<TValue, TStruct>(ref TStruct obj, IntPtr offset)
        where TStruct : unmanaged
    {
        fixed (TStruct* ptr = &obj)
        {
            return MarshalUtil.MarshalToManaged<TValue>(((IntPtr)ptr + offset).ToPointer());
        }
    }

    /// <summary>
    /// Sets a property value for a <see cref="BaseObject"/> instance
    /// </summary>
    public static unsafe void SetPropertyValue<TValue>(
        BaseObject obj,
        IntPtr offset,
        TValue value
    ) => MarshalUtil.MarshalToNative(value, (obj.Ptr + offset).ToPointer());

    /// <summary>
    /// Sets a property value for a struct instance
    /// </summary>
    public static unsafe void SetPropertyValue<TValue, TStruct>(
        ref TStruct obj,
        IntPtr offset,
        TValue value
    )
        where TStruct : unmanaged
    {
        fixed (TStruct* ptr = &obj)
        {
            MarshalUtil.MarshalToNative(value, ((IntPtr)ptr + offset).ToPointer());
        }
    }
}
