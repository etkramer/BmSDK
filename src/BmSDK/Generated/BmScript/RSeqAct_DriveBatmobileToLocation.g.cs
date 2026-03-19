#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmScript;

/// <summary>
/// Class: RSeqAct_DriveBatmobileToLocation<br/>
/// (size = 0)
/// (flags = 0)
/// </summary>
public partial class RSeqAct_DriveBatmobileToLocation : BmSDK.Engine.SeqAct_Latent, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmScript.RSeqAct_DriveBatmobileToLocation", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RSeqAct_DriveBatmobileToLocation() { }

    /// <summary>
    /// Constructs a new RSeqAct_DriveBatmobileToLocation
    /// </summary>
    public RSeqAct_DriveBatmobileToLocation(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RSeqAct_DriveBatmobileToLocation Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RSeqAct_DriveBatmobileToLocation(nint ptr) : base(ptr) { }

    /// <summary>
    /// ObjectProperty: Batmobile
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT Batmobile
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 376); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 376); }
    }

    /// <summary>
    /// ObjectProperty: destActor
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT destActor
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 384); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 384); }
    }

    /// <summary>
    /// ObjectProperty: DestActor2
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT DestActor2
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 392); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 392); }
    }

    /// <summary>
    /// ObjectProperty: CurDestActor
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT CurDestActor
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 400); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 400); }
    }

    /// <summary>
    /// StructProperty: WantDir
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT WantDir
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 408); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 408); }
    }

    /// <summary>
    /// BoolProperty: UsePursuitMode
    /// </summary>
    public unsafe bool UsePursuitMode
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 420) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 420); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 420); }
    }

    /// <summary>
    /// BoolProperty: EndInPursuitMode
    /// </summary>
    public unsafe bool EndInPursuitMode
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 420) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 420); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 420); }
    }

    /// <summary>
    /// BoolProperty: DontRotate
    /// </summary>
    public unsafe bool DontRotate
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 420) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 420); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 420); }
    }

    /// <summary>
    /// BoolProperty: DontPickUpBatman
    /// </summary>
    public unsafe bool DontPickUpBatman
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 420) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 420); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 420); }
    }

    /// <summary>
    /// BoolProperty: AbortMe
    /// </summary>
    public unsafe bool AbortMe
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 420) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 420); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 420); }
    }

    /// <summary>
    /// FloatProperty: AtLocationTolerance
    /// </summary>
    public unsafe float AtLocationTolerance
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 424); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 424); }
    }

    /// <summary>
    /// FloatProperty: UsePursuitModeMaxAngle
    /// </summary>
    public unsafe float UsePursuitModeMaxAngle
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 428); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 428); }
    }

    /// <summary>
    /// FloatProperty: RotationDamping
    /// </summary>
    public unsafe float RotationDamping
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 432); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 432); }
    }

    /// <summary>
    /// FloatProperty: StuckTime
    /// </summary>
    public unsafe float StuckTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 436); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 436); }
    }
}
