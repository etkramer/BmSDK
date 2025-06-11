using BmSDK.Framework;

namespace BmSDK;

public partial class UProperty
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
        get => MarshalUtil.ToManaged<ushort>(Ptr + 48 + 4 + 4);
    }

    /// <summary>
    /// Property: Offset
    /// </summary>
    public ushort Offset
    {
        get => MarshalUtil.ToManaged<ushort>(Ptr + 48 + 4 + 4 + 2);
    }
}
