#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RSeqAct_ToggleRobinLieutenantAssist<br/>
/// (size = 0)
/// (flags = 0)
/// </summary>
public partial class RSeqAct_ToggleRobinLieutenantAssist : BmSDK.Engine.SequenceAction, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RSeqAct_ToggleRobinLieutenantAssist", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RSeqAct_ToggleRobinLieutenantAssist() { }

    /// <summary>
    /// Constructs a new RSeqAct_ToggleRobinLieutenantAssist
    /// </summary>
    public RSeqAct_ToggleRobinLieutenantAssist(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RSeqAct_ToggleRobinLieutenantAssist Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RSeqAct_ToggleRobinLieutenantAssist(nint ptr) : base(ptr) { }

    /// <summary>
    /// ObjectProperty: TargetVantagePoint
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT TargetVantagePoint
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 352); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 352); }
    }

    /// <summary>
    /// ObjectProperty: teleportLocation
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT teleportLocation
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 360); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 360); }
    }

    /// <summary>
    /// BoolProperty: bGrappleIfAlreadyOnVantagePoint
    /// </summary>
    public unsafe bool bGrappleIfAlreadyOnVantagePoint
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 368) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 368); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 368); }
    }

    /// <summary>
    /// BoolProperty: bUseCamera
    /// </summary>
    public unsafe bool bUseCamera
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 368) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 368); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 368); }
    }
}
