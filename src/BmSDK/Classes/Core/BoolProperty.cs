using BmSDK.Framework;

namespace BmSDK;

public partial class BoolProperty
{
    /// <summary>
    /// The bitmask used to pack this bool into its containing int32.
    /// </summary>
    public int BitMask => MarshalUtil.ToManaged<int>(Ptr + 88);
}
