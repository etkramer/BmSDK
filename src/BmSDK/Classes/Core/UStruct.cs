using BmSDK.Framework;

namespace BmSDK;

public partial class UStruct
{
    /// <summary>
    /// Property: PropertiesSize
    /// </summary>
    public int PropertiesSize
    {
        get => MarshalUtil.ToManaged<int>(Ptr + 92 + 4 + 4);
    }
}
