#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmScript;

/// <summary>
/// Class: RBMBehaviour_AbandonedVehicleAnimationPoint<br/>
/// (flags = 0)
/// </summary>
public partial class RBMBehaviour_AbandonedVehicleAnimationPoint : BmSDK.BmScript.RBMBehaviour_GangMovementBase, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmScript.RBMBehaviour_AbandonedVehicleAnimationPoint", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RBMBehaviour_AbandonedVehicleAnimationPoint() { }

    /// <summary>
    /// Constructs a new RBMBehaviour_AbandonedVehicleAnimationPoint
    /// </summary>
    public RBMBehaviour_AbandonedVehicleAnimationPoint(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RBMBehaviour_AbandonedVehicleAnimationPoint Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RBMBehaviour_AbandonedVehicleAnimationPoint(nint ptr) : base(ptr) { }

    /// <summary>
    /// BoolProperty: bInTransOut
    /// </summary>
    public unsafe bool bInTransOut
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 924) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 924); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 924); }
    }

    /// <summary>
    /// BoolProperty: bStartedPaired
    /// </summary>
    public unsafe bool bStartedPaired
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 924) & 2) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 924); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 924); }
    }

    /// <summary>
    /// IntProperty: EventIndex
    /// </summary>
    public unsafe int EventIndex
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 928); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 928); }
    }

    /// <summary>
    /// IntProperty: NumEventsLeft
    /// </summary>
    public unsafe int NumEventsLeft
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 932); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 932); }
    }

    /// <summary>
    /// ObjectProperty: Car
    /// </summary>
    public unsafe BmSDK.BmGame.RAbandonedVehicle Car
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RAbandonedVehicle>(Ptr + 936); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 936); }
    }

    /// <summary>
    /// ObjectProperty: DestinationCarActor
    /// </summary>
    public unsafe BmSDK.BmScript.RGangInteractPointAbandonedVehicle DestinationCarActor
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmScript.RGangInteractPointAbandonedVehicle>(Ptr + 944); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 944); }
    }

    /// <summary>
    /// IntProperty: CurrentBuddies
    /// </summary>
    public unsafe int CurrentBuddies
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 952); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 952); }
    }

    /// <summary>
    /// FloatProperty: IdleTime
    /// </summary>
    public unsafe float IdleTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 956); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 956); }
    }

    /// <summary>
    /// StructProperty: WaitingTransId
    /// </summary>
    public unsafe BmSDK.BmGame.RAnimUtil_PosePlayer.FTransitionId WaitingTransId
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RAnimUtil_PosePlayer.FTransitionId>(Ptr + 960); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 960); }
    }

    /// <summary>
    /// StructProperty: CarAnimDetail
    /// </summary>
    public unsafe BmSDK.BmGame.RGangInteractPointAbandonedVehicleBase.FCarAnimationDetails CarAnimDetail
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RGangInteractPointAbandonedVehicleBase.FCarAnimationDetails>(Ptr + 964); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 964); }
    }

    /// <summary>
    /// StructProperty: CarMultiStageInfo
    /// </summary>
    public unsafe BmSDK.BmGame.RGangInteractPointAbandonedVehicleBase.FMultiStageAnim CarMultiStageInfo
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RGangInteractPointAbandonedVehicleBase.FMultiStageAnim>(Ptr + 1024); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1024); }
    }
}
