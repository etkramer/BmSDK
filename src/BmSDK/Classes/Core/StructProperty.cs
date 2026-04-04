using BmSDK.Framework;

namespace BmSDK;

public partial class StructProperty
{
    /// <summary>
    /// Property: Children
    /// </summary>
    public Struct Struct
    {
        get => MarshalUtil.ToManaged<Struct>(Ptr + 88);
    }
}
