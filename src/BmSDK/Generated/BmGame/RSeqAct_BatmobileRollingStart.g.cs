#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RSeqAct_BatmobileRollingStart<br/>
/// (size = 0)
/// (flags = 0)
/// </summary>
public partial class RSeqAct_BatmobileRollingStart : BmSDK.Engine.SeqAct_Latent, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RSeqAct_BatmobileRollingStart", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RSeqAct_BatmobileRollingStart() { }

    /// <summary>
    /// Constructs a new RSeqAct_BatmobileRollingStart
    /// </summary>
    public RSeqAct_BatmobileRollingStart(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RSeqAct_BatmobileRollingStart Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RSeqAct_BatmobileRollingStart(nint ptr) : base(ptr) { }

    /// <summary>
    /// ObjectProperty: Batmobile
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT Batmobile
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 376); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 376); }
    }

    /// <summary>
    /// ObjectProperty: TeleportTo
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT TeleportTo
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 384); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 384); }
    }

    /// <summary>
    /// ObjectProperty: HeadTowards
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT HeadTowards
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 392); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 392); }
    }

    /// <summary>
    /// FloatProperty: Duration
    /// </summary>
    public unsafe float Duration
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 400); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 400); }
    }

    /// <summary>
    /// FloatProperty: CurTime
    /// </summary>
    public unsafe float CurTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 404); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 404); }
    }

    /// <summary>
    /// BoolProperty: HeadAwayFrom
    /// </summary>
    public unsafe bool HeadAwayFrom
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 408) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 408); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 408); }
    }

    /// <summary>
    /// FloatProperty: Throttle
    /// </summary>
    public unsafe float Throttle
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 412); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 412); }
    }
}
