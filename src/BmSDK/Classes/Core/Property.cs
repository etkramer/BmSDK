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
    public unsafe ref int ArrayDim => ref MarshalUtil.AsRef<int>(Ptr + 48);

    /// <summary>
    /// Property: PropertyFlags
    /// </summary>
    public unsafe ref EPropertyFlags PropertyFlags => ref MarshalUtil.AsRef<EPropertyFlags>(Ptr + 52);

    /// <summary>
    /// Property: ElementSize
    /// </summary>
    public unsafe ref ushort ElementSize => ref MarshalUtil.AsRef<ushort>(Ptr + 52 + 4 + 4);

    /// <summary>
    /// Property: Offset
    /// </summary>
    public unsafe ref ushort Offset => ref MarshalUtil.AsRef<ushort>(Ptr + 52 + 4 + 4 + 2);
}
