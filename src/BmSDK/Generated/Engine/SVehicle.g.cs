#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Class: SVehicle<br/>
/// (size = 0)
/// (flags = 0)
/// </summary>
public partial class SVehicle : BmSDK.Engine.Vehicle, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Engine.SVehicle", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal SVehicle() { }

    /// <summary>
    /// Constructs a new SVehicle
    /// </summary>
    public SVehicle(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, SVehicle Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected SVehicle(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="Engine.Actor.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<SVehicle>
        => ((Engine.Actor)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="Engine.Actor.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<SVehicle>, new()
        => (TComponent)((Engine.Actor)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="Engine.Actor.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<SVehicle>
        => ((Engine.Actor)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="Engine.Actor.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<SVehicle>
        => ((Engine.Actor)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="Engine.Actor.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<SVehicle>
        => (TComponent)((Engine.Actor)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="Engine.Actor.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<SVehicle>
        => ((Engine.Actor)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="Engine.Actor.DetachScriptComponent(Type)"/>
    public void DetachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<SVehicle>
        => ((Engine.Actor)this).DetachScriptComponent(typeof(TComponent));

    /// <summary>
    /// StructProperty: PVehicle
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT PVehicle
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 1608); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1608); }
    }

    /// <summary>
    /// StructProperty: PWheels
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT PWheels
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 1616); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1616); }
    }

    /// <summary>
    /// StructProperty: PSuspensionRaycastResults
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT PSuspensionRaycastResults
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 1624); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1624); }
    }

    /// <summary>
    /// IntProperty: NumSuspensionRaycastResults
    /// </summary>
    public unsafe int NumSuspensionRaycastResults
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1632); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1632); }
    }

    /// <summary>
    /// StructProperty: MyVehicleManager
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT MyVehicleManager
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 1636); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1636); }
    }

    /// <summary>
    /// ArrayProperty: WheelSpeedMap
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.TArray<BmSDK.Engine.SVehicle.StayUprightConstraintInstance>> WheelSpeedMap
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.TArray<BmSDK.Engine.SVehicle.StayUprightConstraintInstance>>>(Ptr + 1644); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1644); }
    }

    /// <summary>
    /// IntProperty: CurrentWheelRaycastIndex
    /// </summary>
    public unsafe int CurrentWheelRaycastIndex
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1660); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1660); }
    }

    /// <summary>
    /// StructProperty: ShapeDeletionListener
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT ShapeDeletionListener
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 1664); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1664); }
    }

    /// <summary>
    /// ByteProperty: VehicleUniqueIndex
    /// </summary>
    public unsafe byte VehicleUniqueIndex
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 1672); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1672); }
    }

    /// <summary>
    /// BoolProperty: EasyToPush
    /// </summary>
    public unsafe bool EasyToPush
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1676) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1676); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1676); }
    }

    /// <summary>
    /// BoolProperty: bIsTank
    /// </summary>
    public unsafe bool bIsTank
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1676) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1676); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1676); }
    }

    /// <summary>
    /// BoolProperty: bEnableDebugRendering
    /// </summary>
    public unsafe bool bEnableDebugRendering
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1676) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1676); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1676); }
    }

    /// <summary>
    /// BoolProperty: bInReverseMode
    /// </summary>
    public unsafe bool bInReverseMode
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1676) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1676); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1676); }
    }

    /// <summary>
    /// BoolProperty: bStayUpright
    /// </summary>
    public unsafe bool bStayUpright
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1676) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1676); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1676); }
    }

    /// <summary>
    /// BoolProperty: bUseSuspensionAxis
    /// </summary>
    public unsafe bool bUseSuspensionAxis
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1676) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1676); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1676); }
    }

    /// <summary>
    /// BoolProperty: bUpdateWheelShapes
    /// </summary>
    public unsafe bool bUpdateWheelShapes
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1676) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1676); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1676); }
    }

    /// <summary>
    /// BoolProperty: bVehicleOnGround
    /// </summary>
    public unsafe bool bVehicleOnGround
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1676) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1676); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1676); }
    }

    /// <summary>
    /// BoolProperty: bVehicleOnWater
    /// </summary>
    public unsafe bool bVehicleOnWater
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1676) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1676); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1676); }
    }

    /// <summary>
    /// BoolProperty: bIsInverted
    /// </summary>
    public unsafe bool bIsInverted
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1676) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1676); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1676); }
    }

    /// <summary>
    /// BoolProperty: bChassisTouchingGround
    /// </summary>
    public unsafe bool bChassisTouchingGround
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1676) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1676); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1676); }
    }

    /// <summary>
    /// BoolProperty: bWasChassisTouchingGroundLastTick
    /// </summary>
    public unsafe bool bWasChassisTouchingGroundLastTick
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1676) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1676); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1676); }
    }

    /// <summary>
    /// BoolProperty: bCanFlip
    /// </summary>
    public unsafe bool bCanFlip
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1676) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1676); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1676); }
    }

    /// <summary>
    /// BoolProperty: bFlipRight
    /// </summary>
    public unsafe bool bFlipRight
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1676) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1676); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1676); }
    }

    /// <summary>
    /// BoolProperty: bIsUprighting
    /// </summary>
    public unsafe bool bIsUprighting
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1676) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1676); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1676); }
    }

    /// <summary>
    /// BoolProperty: bOutputHandbrake
    /// </summary>
    public unsafe bool bOutputHandbrake
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1676) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1676); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1676); }
    }

    /// <summary>
    /// BoolProperty: bHoldingDownHandbrake
    /// </summary>
    public unsafe bool bHoldingDownHandbrake
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1676) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1676); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1676); }
    }

    /// <summary>
    /// BoolProperty: bAutoStopThresholdBrake
    /// </summary>
    public unsafe bool bAutoStopThresholdBrake
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1676) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1676); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1676); }
    }

    /// <summary>
    /// BoolProperty: IsVehicleAsleep
    /// </summary>
    public unsafe bool IsVehicleAsleep
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1676) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1676); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1676); }
    }

    /// <summary>
    /// BoolProperty: NoVisualSteeringFront
    /// </summary>
    public unsafe bool NoVisualSteeringFront
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1676) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1676); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1676); }
    }

    /// <summary>
    /// BoolProperty: NoVisualSteeringRear
    /// </summary>
    public unsafe bool NoVisualSteeringRear
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1676) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1676); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1676); }
    }

    /// <summary>
    /// BoolProperty: bForceWheelspin
    /// </summary>
    public unsafe bool bForceWheelspin
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1676) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1676); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1676); }
    }

    /// <summary>
    /// BoolProperty: bForceWheelspinSmoke
    /// </summary>
    public unsafe bool bForceWheelspinSmoke
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1676) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1676); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1676); }
    }

    /// <summary>
    /// BoolProperty: bDrifting
    /// </summary>
    public unsafe bool bDrifting
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1676) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1676); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1676); }
    }

    /// <summary>
    /// BoolProperty: bDriftingRequested
    /// </summary>
    public unsafe bool bDriftingRequested
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1676) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1676); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1676); }
    }

    /// <summary>
    /// BoolProperty: bManualWheelSpin
    /// </summary>
    public unsafe bool bManualWheelSpin
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1676) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1676); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1676); }
    }

    /// <summary>
    /// BoolProperty: bIsBatmobile
    /// </summary>
    public unsafe bool bIsBatmobile
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1676) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1676); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1676); }
    }

    /// <summary>
    /// BoolProperty: bDisableWheelParticles
    /// </summary>
    public unsafe bool bDisableWheelParticles
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1676) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1676); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1676); }
    }

    /// <summary>
    /// NameProperty: ChassisName
    /// </summary>
    public unsafe BmSDK.FName ChassisName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 1680); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1680); }
    }

    /// <summary>
    /// FloatProperty: ChassisMass
    /// </summary>
    public unsafe float ChassisMass
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1688); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1688); }
    }

    /// <summary>
    /// IntProperty: DebugRenderActiveGraphChannelWheel
    /// </summary>
    public unsafe int DebugRenderActiveGraphChannelWheel
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1692); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1692); }
    }

    /// <summary>
    /// IntProperty: DebugRenderActiveGraphChannelEngine
    /// </summary>
    public unsafe int DebugRenderActiveGraphChannelEngine
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1696); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1696); }
    }

    /// <summary>
    /// ComponentProperty: SimObj
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT SimObj
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 1700); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1700); }
    }

    /// <summary>
    /// ArrayProperty: Wheels
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.Engine.SVehicle.StayUprightConstraintInstance> Wheels
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.SVehicle.StayUprightConstraintInstance>>(Ptr + 1708); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1708); }
    }

    /// <summary>
    /// StructProperty: COMOffset
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT COMOffset
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 1724); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1724); }
    }

    /// <summary>
    /// StructProperty: InertiaTensorMultiplier
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT InertiaTensorMultiplier
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 1736); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1736); }
    }

    /// <summary>
    /// FloatProperty: StayUprightRollResistAngle
    /// </summary>
    public unsafe float StayUprightRollResistAngle
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1748); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1748); }
    }

    /// <summary>
    /// FloatProperty: StayUprightPitchResistAngle
    /// </summary>
    public unsafe float StayUprightPitchResistAngle
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1752); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1752); }
    }

    /// <summary>
    /// FloatProperty: StayUprightStiffness
    /// </summary>
    public unsafe float StayUprightStiffness
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1756); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1756); }
    }

    /// <summary>
    /// FloatProperty: StayUprightDamping
    /// </summary>
    public unsafe float StayUprightDamping
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1760); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1760); }
    }

    /// <summary>
    /// ObjectProperty: StayUprightConstraintSetup
    /// </summary>
    public unsafe BmSDK.Engine.SVehicle.StayUprightConstraintInstance StayUprightConstraintSetup
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.SVehicle.StayUprightConstraintInstance>(Ptr + 1764); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1764); }
    }

    /// <summary>
    /// ObjectProperty: StayUprightConstraintInstance
    /// </summary>
    public unsafe BmSDK.Engine.Vehicle.ExitPositions StayUprightConstraintInstance
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.Vehicle.ExitPositions>(Ptr + 1772); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1772); }
    }

    /// <summary>
    /// ObjectProperty: CollisionSound
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT CollisionSound
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 1780); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1780); }
    }

    /// <summary>
    /// ObjectProperty: EnterVehicleSound
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT EnterVehicleSound
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 1788); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1788); }
    }

    /// <summary>
    /// ObjectProperty: ExitVehicleSound
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT ExitVehicleSound
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 1796); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1796); }
    }

    /// <summary>
    /// FloatProperty: HeavySuspensionShiftPercent
    /// </summary>
    public unsafe float HeavySuspensionShiftPercent
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1804); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1804); }
    }

    /// <summary>
    /// FloatProperty: MaxSpeed
    /// </summary>
    public unsafe float MaxSpeed
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1808); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1808); }
    }

    /// <summary>
    /// FloatProperty: MaxAngularVelocity
    /// </summary>
    public unsafe float MaxAngularVelocity
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1812); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1812); }
    }

    /// <summary>
    /// FloatProperty: TimeOffGround
    /// </summary>
    public unsafe float TimeOffGround
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1816); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1816); }
    }

    /// <summary>
    /// FloatProperty: UprightLiftStrength
    /// </summary>
    public unsafe float UprightLiftStrength
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1820); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1820); }
    }

    /// <summary>
    /// FloatProperty: UprightTorqueStrength
    /// </summary>
    public unsafe float UprightTorqueStrength
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1824); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1824); }
    }

    /// <summary>
    /// FloatProperty: UprightTime
    /// </summary>
    public unsafe float UprightTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1828); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1828); }
    }

    /// <summary>
    /// FloatProperty: UprightStartTime
    /// </summary>
    public unsafe float UprightStartTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1832); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1832); }
    }

    /// <summary>
    /// FloatProperty: CollisionIntervalSecs
    /// </summary>
    public unsafe float CollisionIntervalSecs
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1836); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1836); }
    }

    /// <summary>
    /// FloatProperty: EngineRPM
    /// </summary>
    public unsafe float EngineRPM
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1840); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1840); }
    }

    /// <summary>
    /// FloatProperty: EngineGear
    /// </summary>
    public unsafe float EngineGear
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1844); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1844); }
    }

    /// <summary>
    /// FloatProperty: WheelspinSmokeMomentum
    /// </summary>
    public unsafe float WheelspinSmokeMomentum
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1848); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1848); }
    }

    /// <summary>
    /// FloatProperty: InFearGasDensity
    /// </summary>
    public unsafe float InFearGasDensity
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1852); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1852); }
    }

    /// <summary>
    /// FloatProperty: InPollenDensity
    /// </summary>
    public unsafe float InPollenDensity
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1856); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1856); }
    }

    /// <summary>
    /// FloatProperty: SquealThreshold
    /// </summary>
    public unsafe float SquealThreshold
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1860); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1860); }
    }

    /// <summary>
    /// FloatProperty: SquealLatThreshold
    /// </summary>
    public unsafe float SquealLatThreshold
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1864); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1864); }
    }

    /// <summary>
    /// FloatProperty: LatAngleVolumeMult
    /// </summary>
    public unsafe float LatAngleVolumeMult
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1868); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1868); }
    }

    /// <summary>
    /// FloatProperty: EngineStartOffsetSecs
    /// </summary>
    public unsafe float EngineStartOffsetSecs
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1872); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1872); }
    }

    /// <summary>
    /// FloatProperty: EngineStopOffsetSecs
    /// </summary>
    public unsafe float EngineStopOffsetSecs
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1876); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1876); }
    }

    /// <summary>
    /// FloatProperty: LastCollisionSoundTime
    /// </summary>
    public unsafe float LastCollisionSoundTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1880); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1880); }
    }

    /// <summary>
    /// FloatProperty: OutputBrake
    /// </summary>
    public unsafe float OutputBrake
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1884); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1884); }
    }

    /// <summary>
    /// FloatProperty: OutputGas
    /// </summary>
    public unsafe float OutputGas
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1888); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1888); }
    }

    /// <summary>
    /// FloatProperty: OutputSteering
    /// </summary>
    public unsafe float OutputSteering
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1892); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1892); }
    }

    /// <summary>
    /// FloatProperty: OutputRise
    /// </summary>
    public unsafe float OutputRise
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1896); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1896); }
    }

    /// <summary>
    /// FloatProperty: ForwardVel
    /// </summary>
    public unsafe float ForwardVel
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1900); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1900); }
    }

    /// <summary>
    /// FloatProperty: ForwardAcc
    /// </summary>
    public unsafe float ForwardAcc
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1904); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1904); }
    }

    /// <summary>
    /// IntProperty: NumPoweredWheels
    /// </summary>
    public unsafe int NumPoweredWheels
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1908); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1908); }
    }

    /// <summary>
    /// StructProperty: BaseOffset
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT BaseOffset
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 1912); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1912); }
    }

    /// <summary>
    /// FloatProperty: CamDist
    /// </summary>
    public unsafe float CamDist
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1924); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1924); }
    }

    /// <summary>
    /// IntProperty: DriverViewPitch
    /// </summary>
    public unsafe int DriverViewPitch
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1928); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1928); }
    }

    /// <summary>
    /// IntProperty: DriverViewYaw
    /// </summary>
    public unsafe int DriverViewYaw
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1932); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1932); }
    }

    /// <summary>
    /// StructProperty: VState
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT VState
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 1936); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1936); }
    }

    /// <summary>
    /// FloatProperty: AngErrorAccumulator
    /// </summary>
    public unsafe float AngErrorAccumulator
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2016); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2016); }
    }

    /// <summary>
    /// FloatProperty: RadialImpulseScaling
    /// </summary>
    public unsafe float RadialImpulseScaling
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2020); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2020); }
    }

    /// <summary>
    /// FloatProperty: TyreSmokeWheelSpinThreshold
    /// </summary>
    public unsafe float TyreSmokeWheelSpinThreshold
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2024); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2024); }
    }

    /// <summary>
    /// FloatProperty: TyreSmokeSkidThreshold
    /// </summary>
    public unsafe float TyreSmokeSkidThreshold
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2028); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2028); }
    }

    /// <summary>
    /// StructProperty: RoadPhysxActor
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT RoadPhysxActor
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 2032); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2032); }
    }

    /// <summary>
    /// StructProperty: RoadPhysxShape
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT RoadPhysxShape
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 2040); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2040); }
    }

    /// <summary>
    /// StructProperty: FakeRoadCollisionPlane
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT FakeRoadCollisionPlane
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 2048); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2048); }
    }

    /// <summary>
    /// FloatProperty: DefaultTyreUpdates
    /// </summary>
    public unsafe float DefaultTyreUpdates
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2064); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2064); }
    }

    /// <summary>
    /// FloatProperty: MassScale
    /// </summary>
    public unsafe float MassScale
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2068); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2068); }
    }
}
