#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.IpDrv;

/// <summary>
/// Class: McpServiceBase<br/>
/// (flags = 0)
/// </summary>
public partial class McpServiceBase : BmSDK.GameObject, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "IpDrv.McpServiceBase", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal McpServiceBase() { }

    /// <summary>
    /// Constructs a new McpServiceBase
    /// </summary>
    public McpServiceBase(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, McpServiceBase Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected McpServiceBase(nint ptr) : base(ptr) { }

    /// <summary>
    /// StrProperty: McpConfigClassName
    /// </summary>
    public unsafe BmSDK.FString McpConfigClassName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 84); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 84); }
    }

    /// <summary>
    /// ObjectProperty: McpConfig
    /// </summary>
    public unsafe BmSDK.IpDrv.McpServiceConfig McpConfig
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.IpDrv.McpServiceConfig>(Ptr + 100); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 100); }
    }
}
