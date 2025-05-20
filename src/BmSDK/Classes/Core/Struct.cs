using BmSDK.Framework;

namespace BmSDK;

public partial class Struct
{
    /// <summary>
    /// Property: PropertiesSize
    /// </summary>
    public int PropertiesSize
    {
        get => MarshalUtil.ToManaged<int>(Ptr + 56 + 4 + 4 + 4);
    }
}
