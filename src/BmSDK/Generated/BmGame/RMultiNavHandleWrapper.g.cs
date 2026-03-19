#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RMultiNavHandleWrapper<br/>
/// (size = 0)
/// (flags = 0)
/// </summary>
public partial class RMultiNavHandleWrapper : BmSDK.GameObject, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RMultiNavHandleWrapper", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RMultiNavHandleWrapper() { }

    /// <summary>
    /// Constructs a new RMultiNavHandleWrapper
    /// </summary>
    public RMultiNavHandleWrapper(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RMultiNavHandleWrapper Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RMultiNavHandleWrapper(nint ptr) : base(ptr) { }

    /// <summary>
    /// StructProperty: OverrideStartLocation
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT OverrideStartLocation
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 84); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 84); }
    }

    /// <summary>
    /// ObjectProperty: Thug
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT Thug
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 96); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 96); }
    }

    /// <summary>
    /// ArrayProperty: Path
    /// </summary>
    public unsafe NEED_UPDATE_ARRAYPROPERTY_LAYOUT Path
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_ARRAYPROPERTY_LAYOUT>(Ptr + 104); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 104); }
    }

    /// <summary>
    /// BoolProperty: bAvoidPlayers
    /// </summary>
    public unsafe bool bAvoidPlayers
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 120) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 120); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 120); }
    }

    /// <summary>
    /// BoolProperty: bIgnoreGuardVolumeConstraints
    /// </summary>
    public unsafe bool bIgnoreGuardVolumeConstraints
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 120) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 120); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 120); }
    }

    /// <summary>
    /// NameProperty: ClaimName
    /// </summary>
    public unsafe BmSDK.FName ClaimName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 124); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 124); }
    }
}
