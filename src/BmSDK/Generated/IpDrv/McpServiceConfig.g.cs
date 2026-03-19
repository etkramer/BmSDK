#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.IpDrv;

/// <summary>
/// Class: McpServiceConfig<br/>
/// (size = 0)
/// (flags = 0)
/// </summary>
public partial class McpServiceConfig : BmSDK.GameObject, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "IpDrv.McpServiceConfig", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal McpServiceConfig() { }

    /// <summary>
    /// Constructs a new McpServiceConfig
    /// </summary>
    public McpServiceConfig(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, McpServiceConfig Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected McpServiceConfig(nint ptr) : base(ptr) { }

    /// <summary>
    /// StrProperty: Protocol
    /// </summary>
    public unsafe BmSDK.FString Protocol
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 84); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 84); }
    }

    /// <summary>
    /// StrProperty: Domain
    /// </summary>
    public unsafe BmSDK.FString Domain
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 100); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 100); }
    }

    /// <summary>
    /// StrProperty: TitleId
    /// </summary>
    public unsafe BmSDK.FString TitleId
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 116); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 116); }
    }

    /// <summary>
    /// StrProperty: AppKey
    /// </summary>
    public unsafe BmSDK.FString AppKey
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 132); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 132); }
    }

    /// <summary>
    /// StrProperty: AppSecret
    /// </summary>
    public unsafe BmSDK.FString AppSecret
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 148); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 148); }
    }
}
