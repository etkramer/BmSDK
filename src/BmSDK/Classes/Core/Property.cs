using BmSDK.Framework;

namespace BmSDK;

public partial class Property
{
    /// <summary>
    /// Property: ArrayDim
    /// </summary>
    public unsafe int ArrayDim
    {
        get => MarshalUtil.ToManagedSafe<int>(Ptr + 56);
    }

    /// <summary>
    /// Property: ElementSize
    /// </summary>
    public ushort ElementSize
    {
        get => MarshalUtil.ToManagedSafe<ushort>(Ptr + 56 + 4);
    }

    /// <summary>
    /// Property: Offset
    /// </summary>
    public ushort Offset
    {
        get => MarshalUtil.ToManagedSafe<ushort>(Ptr + 56 + 4 + 4 + 8 + 8 + 4);
    }

    /// <summary>
    /// Property: PropertyLinkNext
    /// </summary>
    public GameObject PropertyLinkNext
    {
        get => MarshalUtil.ToManagedSafe<GameObject>(Ptr + 56 + 4 + 4 + 8 + 8 + 4 + 4);
    }
}
