using BmSDK.Framework;

namespace BmSDK;

public partial class ByteProperty
{
    /// <summary>
    /// The UEnum backing this byte property, or null if the property is a plain byte.
    /// </summary>
    public BmSDK.Enum Enum => MarshalUtil.ToManaged<BmSDK.Enum>(Ptr + 88);
}
