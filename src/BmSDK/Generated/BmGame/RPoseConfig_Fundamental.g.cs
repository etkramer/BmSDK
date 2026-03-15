#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// ABSTRACT Class: RPoseConfig_Fundamental<br/>
/// (size = 52)
/// (flags = 19)
/// </summary>
public partial class RPoseConfig_Fundamental : BmSDK.GameObject, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RPoseConfig_Fundamental", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RPoseConfig_Fundamental() { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RPoseConfig_Fundamental(nint ptr) : base(ptr) { }

    /// <summary>
    /// ObjectProperty: FundamentalPoseConfig
    /// </summary>
    public unsafe BmSDK.BmGame.RPoseConfig FundamentalPoseConfig
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPoseConfig>(Ptr + 44); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 44); }
    }

    /// <summary>
    /// ObjectProperty: BasicPoseConfig
    /// </summary>
    public unsafe BmSDK.BmGame.RPoseConfig BasicPoseConfig
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPoseConfig>(Ptr + 48); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 48); }
    }
}
