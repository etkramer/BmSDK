using BmSDK.Framework;

namespace BmSDK;

public partial class UField
{
    /// <summary>
    /// Property: Next
    /// </summary>
    public unsafe UField Next
    {
        get => MarshalUtil.ToManaged<UField>(Ptr + 44);
    }
}
