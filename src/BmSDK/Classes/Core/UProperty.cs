using BmSDK.Framework;

namespace BmSDK;

public partial class UProperty
{
    /// <summary>
    /// Property: ArrayDim
    /// </summary>
    public unsafe int ArrayDim
    {
        get => MarshalUtil.ToManaged<int>(Ptr + 48);
    }

    /// <summary>
    /// Property: ElementSize
    /// </summary>
    public ushort ElementSize
    {
        get => MarshalUtil.ToManaged<ushort>(Ptr + 48 + 4 + 4);
    }
}
