using BmSDK.Framework;

namespace BmSDK;

public partial class Field
{
    /// <summary>
    /// Property: Next
    /// </summary>
    public unsafe Field Next
    {
        get => MarshalUtil.ToManaged<Field>(Ptr + 44);
    }
}
