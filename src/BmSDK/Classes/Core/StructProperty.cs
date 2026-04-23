using BmSDK.Framework;

namespace BmSDK;

public partial class StructProperty
{
    /// <summary>
    /// The UScriptStruct describing the layout of this struct property's value.
    /// </summary>
    public Struct Struct => MarshalUtil.ToManaged<Struct>(Ptr + 88);
}
