#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RSeqAct_IsBatmobileDrifting<br/>
/// (size = 0)
/// (flags = 0)
/// </summary>
public partial class RSeqAct_IsBatmobileDrifting : BmSDK.Engine.SeqAct_Latent, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RSeqAct_IsBatmobileDrifting", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RSeqAct_IsBatmobileDrifting() { }

    /// <summary>
    /// Constructs a new RSeqAct_IsBatmobileDrifting
    /// </summary>
    public RSeqAct_IsBatmobileDrifting(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RSeqAct_IsBatmobileDrifting Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RSeqAct_IsBatmobileDrifting(nint ptr) : base(ptr) { }

    /// <summary>
    /// ObjectProperty: Batmobile
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT Batmobile
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 376); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 376); }
    }

    /// <summary>
    /// BoolProperty: bDrifting
    /// </summary>
    public unsafe bool bDrifting
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 384) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 384); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 384); }
    }

    /// <summary>
    /// Enum: SATT_OUT_Links
    /// </summary>
    public enum SATT_OUT_Links
    {
        SAIBD_OUT_Out = 0,
        SAIBD_OUT_StartedDrifting = 1,
        SAIBD_OUT_StoppedDrifting = 2,
        SAIBD_OUT_MAX = 3,
    }

    /// <summary>
    /// Enum: SAIBD_IN_Links
    /// </summary>
    public enum SAIBD_IN_Links
    {
        SAIBD_IN_StartChecking = 0,
        SAIBD_IN_StopChecking = 1,
        SAIBD_IN_MAX = 2,
    }
}
