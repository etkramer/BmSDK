#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RVehicleBehaviour<br/>
/// (size = 0)
/// (flags = 0)
/// </summary>
public partial class RVehicleBehaviour : BmSDK.Engine.SequenceAction, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RVehicleBehaviour", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RVehicleBehaviour() { }

    /// <summary>
    /// Constructs a new RVehicleBehaviour
    /// </summary>
    public RVehicleBehaviour(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RVehicleBehaviour Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RVehicleBehaviour(nint ptr) : base(ptr) { }

    /// <summary>
    /// ObjectProperty: HostVehicle
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT HostVehicle
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 352); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 352); }
    }

    /// <summary>
    /// ObjectProperty: BehaviourRoute
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT BehaviourRoute
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 360); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 360); }
    }

    /// <summary>
    /// ObjectProperty: PatrolRoute
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT PatrolRoute
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 368); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 368); }
    }

    /// <summary>
    /// ObjectProperty: VehFromPreviousAction
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT VehFromPreviousAction
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 376); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 376); }
    }

    /// <summary>
    /// ObjectProperty: BarkDef
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT BarkDef
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 384); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 384); }
    }

    /// <summary>
    /// ObjectProperty: BarkSetPawn
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT BarkSetPawn
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 392); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 392); }
    }

    /// <summary>
    /// ArrayProperty: BehaviourVolumes
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.Engine.SequenceAction.Targets> BehaviourVolumes
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.SequenceAction.Targets>>(Ptr + 400); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 400); }
    }

    /// <summary>
    /// BoolProperty: bCanBePlacedInKismet
    /// </summary>
    public unsafe bool bCanBePlacedInKismet
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 416) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 416); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 416); }
    }

    /// <summary>
    /// BoolProperty: bShowVehicleTargetRoute
    /// </summary>
    public unsafe bool bShowVehicleTargetRoute
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 416) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 416); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 416); }
    }

    /// <summary>
    /// BoolProperty: bRequiresChaseCamera
    /// </summary>
    public unsafe bool bRequiresChaseCamera
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 416) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 416); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 416); }
    }

    /// <summary>
    /// BoolProperty: UseIndoorVision
    /// </summary>
    public unsafe bool UseIndoorVision
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 416) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 416); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 416); }
    }

    /// <summary>
    /// BoolProperty: CanBeInteruptedByCombat
    /// </summary>
    public unsafe bool CanBeInteruptedByCombat
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 416) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 416); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 416); }
    }

    /// <summary>
    /// BoolProperty: DebugDrawVehicleRoute
    /// </summary>
    public unsafe bool DebugDrawVehicleRoute
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 416) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 416); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 416); }
    }

    /// <summary>
    /// BoolProperty: OldDebugDrawVehicleRoute
    /// </summary>
    public unsafe bool OldDebugDrawVehicleRoute
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 416) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 416); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 416); }
    }

    /// <summary>
    /// BoolProperty: bForceInCombat
    /// </summary>
    public unsafe bool bForceInCombat
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 416) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 416); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 416); }
    }

    /// <summary>
    /// BoolProperty: CantSeePlayer
    /// </summary>
    public unsafe bool CantSeePlayer
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 416) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 416); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 416); }
    }

    /// <summary>
    /// BoolProperty: bRequiresDriver
    /// </summary>
    public unsafe bool bRequiresDriver
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 416) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 416); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 416); }
    }

    /// <summary>
    /// BoolProperty: bAggressiveBehaviour
    /// </summary>
    public unsafe bool bAggressiveBehaviour
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 416) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 416); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 416); }
    }

    /// <summary>
    /// BoolProperty: bRunawayBehaviour
    /// </summary>
    public unsafe bool bRunawayBehaviour
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 416) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 416); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 416); }
    }

    /// <summary>
    /// BoolProperty: bCannotBeInteruptedByKismet
    /// </summary>
    public unsafe bool bCannotBeInteruptedByKismet
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 416) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 416); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 416); }
    }

    /// <summary>
    /// BoolProperty: bImmuneToVehicleTakedown
    /// </summary>
    public unsafe bool bImmuneToVehicleTakedown
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 416) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 416); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 416); }
    }

    /// <summary>
    /// BoolProperty: bIgnoreVisionChecks
    /// </summary>
    public unsafe bool bIgnoreVisionChecks
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 416) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 416); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 416); }
    }

    /// <summary>
    /// BoolProperty: bShowOnHeavyTankRadar
    /// </summary>
    public unsafe bool bShowOnHeavyTankRadar
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 416) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 416); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 416); }
    }

    /// <summary>
    /// BoolProperty: bShouldRegisterNavMeshObstacle
    /// </summary>
    public unsafe bool bShouldRegisterNavMeshObstacle
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 416) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 416); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 416); }
    }

    /// <summary>
    /// BoolProperty: bAllowStasis
    /// </summary>
    public unsafe bool bAllowStasis
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 416) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 416); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 416); }
    }

    /// <summary>
    /// BoolProperty: bAlwaysCheckForDeathSlowMo
    /// </summary>
    public unsafe bool bAlwaysCheckForDeathSlowMo
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 416) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 416); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 416); }
    }

    /// <summary>
    /// BoolProperty: OnlyPlayIdleBarksWhenOnScreen
    /// </summary>
    public unsafe bool OnlyPlayIdleBarksWhenOnScreen
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 416) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 416); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 416); }
    }

    /// <summary>
    /// BoolProperty: TemplateBehaviour
    /// </summary>
    public unsafe bool TemplateBehaviour
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 416) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 416); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 416); }
    }

    /// <summary>
    /// StructProperty: Restrictions
    /// </summary>
    public unsafe BmSDK.Engine.SequenceAction.Targets Restrictions
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.SequenceAction.Targets>(Ptr + 420); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 420); }
    }

    /// <summary>
    /// FloatProperty: RoadLevelSearchBias
    /// </summary>
    public unsafe float RoadLevelSearchBias
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 588); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 588); }
    }

    /// <summary>
    /// FloatProperty: CombatRange
    /// </summary>
    public unsafe float CombatRange
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 592); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 592); }
    }

    /// <summary>
    /// FloatProperty: StasisEvenIfVisibleRange
    /// </summary>
    public unsafe float StasisEvenIfVisibleRange
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 596); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 596); }
    }

    /// <summary>
    /// FloatProperty: MinDelayBetweenIdleBarks
    /// </summary>
    public unsafe float MinDelayBetweenIdleBarks
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 600); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 600); }
    }

    /// <summary>
    /// FloatProperty: MaxDelayBetweenIdleBarks
    /// </summary>
    public unsafe float MaxDelayBetweenIdleBarks
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 604); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 604); }
    }
}
