using BmSDK.Framework;

namespace BmSDK;

public partial class Enum
{
    /// <summary>
    /// The ordered list of enum member names. Index in this array equals the enum's numeric value.
    /// </summary>
    public TArray<FName> Names => MarshalUtil.ToManaged<TArray<FName>>(Ptr + 48);
}
