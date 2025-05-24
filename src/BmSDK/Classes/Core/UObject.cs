global using System.Runtime.InteropServices;
using System.Diagnostics.CodeAnalysis;
using BmSDK.Framework;

[assembly: SuppressMessage("Usage", "IDE1006:Naming rule violation")]
[assembly: SuppressMessage("Usage", "IDE0130:Namespace does not match folder structure")]

namespace BmSDK;

public interface IStaticObject
{
    public static abstract UClass StaticClass();
}

public partial class UObject
{
    public IntPtr Ptr { get; internal set; } = IntPtr.Zero;

    /// <summary>
    /// Sets a property value for a <see cref="UObject"/> instance
    /// </summary>
    public static unsafe void SetPropertyValue<TValue>(UObject obj, IntPtr offset, TValue value) =>
        MarshalUtil.ToUnmanaged(value, (obj.Ptr + offset).ToPointer());

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
