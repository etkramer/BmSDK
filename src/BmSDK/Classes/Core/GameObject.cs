global using System;
global using System.Runtime.InteropServices;
using System.Diagnostics.CodeAnalysis;
using BmSDK.Framework;

[assembly: SuppressMessage("Usage", "IDE1006:Naming rule violation")]
[assembly: SuppressMessage("Usage", "IDE0130:Namespace does not match folder structure")]

namespace BmSDK;

public interface IStaticObject
{
    public static abstract Class StaticClass();
}

public partial class GameObject
{
    public IntPtr Ptr { get; internal set; } = IntPtr.Zero;

    /// <summary>
    /// Gets a property value from a <see cref="GameObject"/> instance
    /// </summary>
    public static unsafe TValue GetPropertyValue<TValue>(GameObject obj, IntPtr offset) =>
        MarshalUtil.ToManaged<TValue>((obj.Ptr + offset).ToPointer());

    /// <summary>
    /// Gets a property value from a struct instance
    /// </summary>
    public static unsafe TValue GetPropertyValue<TValue, TStruct>(ref TStruct obj, IntPtr offset)
        where TStruct : unmanaged
    {
        fixed (TStruct* ptr = &obj)
        {
            return MarshalUtil.ToManaged<TValue>(((IntPtr)ptr + offset).ToPointer());
        }
    }

    /// <summary>
    /// Sets a property value for a <see cref="GameObject"/> instance
    /// </summary>
    public static unsafe void SetPropertyValue<TValue>(
        GameObject obj,
        IntPtr offset,
        TValue value
    ) => MarshalUtil.ToUnmanaged(value, (obj.Ptr + offset).ToPointer());

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
            MarshalUtil.ToUnmanaged(value, ((IntPtr)ptr + offset).ToPointer());
        }
    }
}
