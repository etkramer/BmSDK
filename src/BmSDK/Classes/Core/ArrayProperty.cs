using BmSDK.Framework;

namespace BmSDK;

public partial class ArrayProperty
{
    /// <summary>
    /// Property: Inner
    /// </summary>
    public Property Inner
    {
        get => MarshalUtil.ToManaged<Property>(Ptr + 88);
    }
}
