using BmSDK.Framework;

namespace BmSDK;

public partial class UStruct
{
    /// <summary>
    /// Property: PropertiesSize
    /// </summary>
    public UField Children
    {
        get => MarshalUtil.ToManaged<UField>(Ptr + 60);
    }

    /// <summary>
    /// Property: PropertiesSize
    /// </summary>
    public short PropertiesSize
    {
        get => MarshalUtil.ToManaged<short>(Ptr + 64);
    }
}
