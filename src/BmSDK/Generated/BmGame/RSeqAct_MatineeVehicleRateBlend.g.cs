#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RSeqAct_MatineeVehicleRateBlend<br/>
/// (size = 0)
/// (flags = 0)
/// </summary>
public partial class RSeqAct_MatineeVehicleRateBlend : BmSDK.Engine.SeqAct_Latent, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RSeqAct_MatineeVehicleRateBlend", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RSeqAct_MatineeVehicleRateBlend() { }

    /// <summary>
    /// Constructs a new RSeqAct_MatineeVehicleRateBlend
    /// </summary>
    public RSeqAct_MatineeVehicleRateBlend(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RSeqAct_MatineeVehicleRateBlend Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RSeqAct_MatineeVehicleRateBlend(nint ptr) : base(ptr) { }

    /// <summary>
    /// ObjectProperty: Matinee
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT Matinee
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 376); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 376); }
    }

    /// <summary>
    /// ObjectProperty: Vehicle
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT Vehicle
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 384); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 384); }
    }

    /// <summary>
    /// FloatProperty: ReferenceVehicleSpeed
    /// </summary>
    public unsafe float ReferenceVehicleSpeed
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 392); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 392); }
    }

    /// <summary>
    /// FloatProperty: BlendDuration
    /// </summary>
    public unsafe float BlendDuration
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 396); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 396); }
    }

    /// <summary>
    /// FloatProperty: InitialVehicleSpeed
    /// </summary>
    public unsafe float InitialVehicleSpeed
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
    /// FloatProperty: MatineeDefaultPlayRate
    /// </summary>
    public unsafe float MatineeDefaultPlayRate
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 408); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 408); }
    }
}
