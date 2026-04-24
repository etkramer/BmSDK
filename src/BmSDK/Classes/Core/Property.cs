using BmSDK.Framework;

namespace BmSDK;

public partial class Property
{
    [Flags]
    public enum EPropertyFlags
    {
        CPF_Parm = 0x8,
        CPF_OptionalParm = 0x10,
        CPF_OutParm = 0x20,
        CPF_ReturnParm = 0x80,
    }

    /// <summary>
    /// Property: ArrayDim
    /// </summary>
    public unsafe int ArrayDim
    {
        get => MarshalUtil.ToManaged<int>(Ptr + 48);
    }

    /// <summary>
    /// Property: PropertyFlags
    /// </summary>
    public unsafe EPropertyFlags PropertyFlags
    {
        get => MarshalUtil.ToManaged<EPropertyFlags>(Ptr + 52);
    }

    /// <summary>
    /// Property: ElementSize
    /// </summary>
    public ushort ElementSize
    {
        get => MarshalUtil.ToManaged<ushort>(Ptr + 52 + 4 + 4);
    }

    /// <summary>
    /// Property: Offset
    /// </summary>
    public ushort Offset
    {
        get => MarshalUtil.ToManaged<ushort>(Ptr + 52 + 4 + 4 + 2);
    }

    /// <summary>
    /// Returns a ref to this property's value on <paramref name="obj"/>.
    /// Use for any unmanaged value type (float, int, Vector3, Rotator, FName, FString, FColor, ...).
    /// Not valid for <see cref="BoolProperty"/> (bitfield-packed) or <see cref="ObjectProperty"/> — use their typed accessors instead.
    /// </summary>
    public ref T AsRef<T>(GameObject obj)
        where T : unmanaged => ref MarshalUtil.AsRef<T>(obj.Ptr + Offset);
}
