#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RSeqAct_BossHudBase<br/>
/// (size = 0)
/// (flags = 0)
/// </summary>
public partial class RSeqAct_BossHudBase : BmSDK.Engine.SequenceAction, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RSeqAct_BossHudBase", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RSeqAct_BossHudBase() { }

    /// <summary>
    /// Constructs a new RSeqAct_BossHudBase
    /// </summary>
    public RSeqAct_BossHudBase(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RSeqAct_BossHudBase Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RSeqAct_BossHudBase(nint ptr) : base(ptr) { }

    /// <summary>
    /// ObjectProperty: TheMovieInstance
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT TheMovieInstance
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 352); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 352); }
    }

    /// <summary>
    /// ObjectProperty: RPC
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT RPC
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 360); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 360); }
    }

    /// <summary>
    /// ObjectProperty: BossModule
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT BossModule
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 368); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 368); }
    }

    /// <summary>
    /// StrProperty: BossName
    /// </summary>
    public unsafe BmSDK.FString BossName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 376); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 376); }
    }

    /// <summary>
    /// BoolProperty: SuppressSurveillance
    /// </summary>
    public unsafe bool SuppressSurveillance
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 392) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 392); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 392); }
    }

    /// <summary>
    /// BoolProperty: SurveillanceCurrentlySuppressed
    /// </summary>
    public unsafe bool SurveillanceCurrentlySuppressed
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 392) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 392); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 392); }
    }
}
