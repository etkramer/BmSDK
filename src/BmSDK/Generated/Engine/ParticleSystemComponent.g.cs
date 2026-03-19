#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Class: ParticleSystemComponent<br/>
/// (size = 0)
/// (flags = 0)
/// </summary>
public partial class ParticleSystemComponent : BmSDK.Engine.PrimitiveComponent, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Engine.ParticleSystemComponent", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal ParticleSystemComponent() { }

    /// <summary>
    /// Constructs a new ParticleSystemComponent
    /// </summary>
    public ParticleSystemComponent(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, ParticleSystemComponent Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected ParticleSystemComponent(nint ptr) : base(ptr) { }

    /// <summary>
    /// ObjectProperty: Template
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT Template
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 540); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 540); }
    }

    /// <summary>
    /// ObjectProperty: LightEnvironmentSharedInstigator
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT LightEnvironmentSharedInstigator
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 548); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 548); }
    }

    /// <summary>
    /// ObjectProperty: OpacityShadowsLightSource
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT OpacityShadowsLightSource
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 556); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 556); }
    }

    /// <summary>
    /// ObjectProperty: EconomicalReplayClip
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT EconomicalReplayClip
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 564); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 564); }
    }

    /// <summary>
    /// ObjectProperty: CollisionCallBackActor
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT CollisionCallBackActor
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 572); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 572); }
    }

    /// <summary>
    /// IntProperty: MaxLightEnvironmentPooledReuses
    /// </summary>
    public unsafe int MaxLightEnvironmentPooledReuses
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 580); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 580); }
    }

    /// <summary>
    /// ArrayProperty: EmitterInstances
    /// </summary>
    public unsafe NEED_UPDATE_ARRAYPROPERTY_LAYOUT EmitterInstances
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_ARRAYPROPERTY_LAYOUT>(Ptr + 584); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 584); }
    }

    /// <summary>
    /// ArrayProperty: SMComponents
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<System.IntPtr>>>>>>>>>>> SMComponents
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<System.IntPtr>>>>>>>>>>>>(Ptr + 600); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 600); }
    }

    /// <summary>
    /// ArrayProperty: SMMaterialInterfaces
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<System.IntPtr>>>>>>>>>> SMMaterialInterfaces
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<System.IntPtr>>>>>>>>>>>(Ptr + 616); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 616); }
    }

    /// <summary>
    /// ArrayProperty: SkelMeshComponents
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<System.IntPtr>>>>>>>>> SkelMeshComponents
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<System.IntPtr>>>>>>>>>>(Ptr + 632); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 632); }
    }

    /// <summary>
    /// ArrayProperty: ViewMBInfoArray
    /// </summary>
    public unsafe NEED_UPDATE_ARRAYPROPERTY_LAYOUT ViewMBInfoArray
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_ARRAYPROPERTY_LAYOUT>(Ptr + 648); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 648); }
    }

    /// <summary>
    /// BoolProperty: bAutoActivate
    /// </summary>
    public unsafe bool bAutoActivate
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 664) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 664); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 664); }
    }

    /// <summary>
    /// BoolProperty: bWasCompleted
    /// </summary>
    public unsafe bool bWasCompleted
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 664) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 664); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 664); }
    }

    /// <summary>
    /// BoolProperty: bSuppressSpawning
    /// </summary>
    public unsafe bool bSuppressSpawning
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 664) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 664); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 664); }
    }

    /// <summary>
    /// BoolProperty: bWasDeactivated
    /// </summary>
    public unsafe bool bWasDeactivated
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 664) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 664); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 664); }
    }

    /// <summary>
    /// BoolProperty: bResetOnDetach
    /// </summary>
    public unsafe bool bResetOnDetach
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 664) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 664); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 664); }
    }

    /// <summary>
    /// BoolProperty: bUpdateOnDedicatedServer
    /// </summary>
    public unsafe bool bUpdateOnDedicatedServer
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 664) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 664); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 664); }
    }

    /// <summary>
    /// BoolProperty: bJustAttached
    /// </summary>
    public unsafe bool bJustAttached
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 664) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 664); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 664); }
    }

    /// <summary>
    /// BoolProperty: bLoopsPermitted
    /// </summary>
    public unsafe bool bLoopsPermitted
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 664) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 664); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 664); }
    }

    /// <summary>
    /// BoolProperty: bIsActive
    /// </summary>
    public unsafe bool bIsActive
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 664) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 664); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 664); }
    }

    /// <summary>
    /// BoolProperty: bIsPaused
    /// </summary>
    public unsafe bool bIsPaused
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 664) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 664); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 664); }
    }

    /// <summary>
    /// BoolProperty: bHasBeenActivated
    /// </summary>
    public unsafe bool bHasBeenActivated
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 664) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 664); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 664); }
    }

    /// <summary>
    /// BoolProperty: bIsAvailableForPoolReuse
    /// </summary>
    public unsafe bool bIsAvailableForPoolReuse
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 664) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 664); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 664); }
    }

    /// <summary>
    /// BoolProperty: bWarmingUp
    /// </summary>
    public unsafe bool bWarmingUp
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 664) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 664); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 664); }
    }

    /// <summary>
    /// BoolProperty: bIsCachedInPool
    /// </summary>
    public unsafe bool bIsCachedInPool
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 664) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 664); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 664); }
    }

    /// <summary>
    /// BoolProperty: bOverrideLODMethod
    /// </summary>
    public unsafe bool bOverrideLODMethod
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 664) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 664); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 664); }
    }

    /// <summary>
    /// BoolProperty: bSkipUpdateDynamicDataDuringTick
    /// </summary>
    public unsafe bool bSkipUpdateDynamicDataDuringTick
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 664) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 664); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 664); }
    }

    /// <summary>
    /// BoolProperty: bSkipBoundsUpdate
    /// </summary>
    public unsafe bool bSkipBoundsUpdate
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 664) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 664); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 664); }
    }

    /// <summary>
    /// BoolProperty: bUpdateComponentInTick
    /// </summary>
    public unsafe bool bUpdateComponentInTick
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 664) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 664); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 664); }
    }

    /// <summary>
    /// BoolProperty: bDeferredBeamUpdate
    /// </summary>
    public unsafe bool bDeferredBeamUpdate
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 664) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 664); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 664); }
    }

    /// <summary>
    /// BoolProperty: bForcedInActive
    /// </summary>
    public unsafe bool bForcedInActive
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 664) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 664); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 664); }
    }

    /// <summary>
    /// BoolProperty: bIsWarmingUp
    /// </summary>
    public unsafe bool bIsWarmingUp
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 664) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 664); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 664); }
    }

    /// <summary>
    /// BoolProperty: bIsViewRelevanceDirty
    /// </summary>
    public unsafe bool bIsViewRelevanceDirty
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 664) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 664); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 664); }
    }

    /// <summary>
    /// BoolProperty: bRecacheViewRelevance
    /// </summary>
    public unsafe bool bRecacheViewRelevance
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 664) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 664); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 664); }
    }

    /// <summary>
    /// BoolProperty: bCastOpacityShadows
    /// </summary>
    public unsafe bool bCastOpacityShadows
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 664) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 664); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 664); }
    }

    /// <summary>
    /// BoolProperty: bCreateEconomicalParticleSnapshotOnNextUpdate
    /// </summary>
    public unsafe bool bCreateEconomicalParticleSnapshotOnNextUpdate
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 664) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 664); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 664); }
    }

    /// <summary>
    /// BoolProperty: bLODUpdatePending
    /// </summary>
    public unsafe bool bLODUpdatePending
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 664) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 664); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 664); }
    }

    /// <summary>
    /// BoolProperty: bSkipSpawnCountCheck
    /// </summary>
    public unsafe bool bSkipSpawnCountCheck
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 664) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 664); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 664); }
    }

    /// <summary>
    /// BoolProperty: bHasSharedInstanceEmitters
    /// </summary>
    public unsafe bool bHasSharedInstanceEmitters
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 664) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 664); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 664); }
    }

    /// <summary>
    /// BoolProperty: bIsThreadSafe
    /// </summary>
    public unsafe bool bIsThreadSafe
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 664) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 664); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 664); }
    }

    /// <summary>
    /// BoolProperty: SoftThreadLock
    /// </summary>
    public unsafe bool SoftThreadLock
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 664) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 664); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 664); }
    }

    /// <summary>
    /// FloatProperty: AudioMaxRadius
    /// </summary>
    public unsafe float AudioMaxRadius
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 668); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 668); }
    }

    /// <summary>
    /// FloatProperty: AudioLastDistance
    /// </summary>
    public unsafe float AudioLastDistance
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 672); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 672); }
    }

    /// <summary>
    /// StructProperty: DynamicLocalSpawnLocation
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT DynamicLocalSpawnLocation
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 676); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 676); }
    }

    /// <summary>
    /// ArrayProperty: InstanceParameters
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<System.IntPtr>>>>>>>> InstanceParameters
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<System.IntPtr>>>>>>>>>(Ptr + 688); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 688); }
    }

    /// <summary>
    /// StructProperty: OldPosition
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT OldPosition
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 704); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 704); }
    }

    /// <summary>
    /// StructProperty: PartSysVelocity
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT PartSysVelocity
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 716); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 716); }
    }

    /// <summary>
    /// FloatProperty: WarmupTime
    /// </summary>
    public unsafe float WarmupTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 728); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 728); }
    }

    /// <summary>
    /// FloatProperty: WarmupTickRate
    /// </summary>
    public unsafe float WarmupTickRate
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 732); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 732); }
    }

    /// <summary>
    /// IntProperty: LODLevel
    /// </summary>
    public unsafe int LODLevel
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 736); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 736); }
    }

    /// <summary>
    /// FloatProperty: SecondsBeforeInactive
    /// </summary>
    public unsafe float SecondsBeforeInactive
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 740); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 740); }
    }

    /// <summary>
    /// FloatProperty: TimeSinceLastForceUpdateTransform
    /// </summary>
    public unsafe float TimeSinceLastForceUpdateTransform
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 744); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 744); }
    }

    /// <summary>
    /// FloatProperty: MaxTimeBeforeForceUpdateTransform
    /// </summary>
    public unsafe float MaxTimeBeforeForceUpdateTransform
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 748); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 748); }
    }

    /// <summary>
    /// IntProperty: EditorLODLevel
    /// </summary>
    public unsafe int EditorLODLevel
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 752); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 752); }
    }

    /// <summary>
    /// IntProperty: EditorDetailMode
    /// </summary>
    public unsafe int EditorDetailMode
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 756); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 756); }
    }

    /// <summary>
    /// FloatProperty: AccumTickTime
    /// </summary>
    public unsafe float AccumTickTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 760); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 760); }
    }

    /// <summary>
    /// ByteProperty: LODMethod
    /// </summary>
    public unsafe byte LODMethod
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 764); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 764); }
    }

    /// <summary>
    /// ByteProperty: ReplayState
    /// </summary>
    public unsafe byte ReplayState
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 765); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 765); }
    }

    /// <summary>
    /// NameProperty: BeamOverrideSourceName
    /// </summary>
    public unsafe BmSDK.FName BeamOverrideSourceName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 768); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 768); }
    }

    /// <summary>
    /// FloatProperty: BeamOverrideCustomBoneBlend
    /// </summary>
    public unsafe float BeamOverrideCustomBoneBlend
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 776); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 776); }
    }

    /// <summary>
    /// ArrayProperty: CachedViewRelevanceFlags
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<System.IntPtr>>>>>>> CachedViewRelevanceFlags
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<System.IntPtr>>>>>>>>(Ptr + 780); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 780); }
    }

    /// <summary>
    /// StructProperty: IncomingLight
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT IncomingLight
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 796); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 796); }
    }

    /// <summary>
    /// StructProperty: OpacityShadowsExtAmbient
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT OpacityShadowsExtAmbient
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 812); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 812); }
    }

    /// <summary>
    /// StructProperty: OpacityShadowsSelfAmbient
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT OpacityShadowsSelfAmbient
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 816); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 816); }
    }

    /// <summary>
    /// FloatProperty: OpacityShadowsOpacityMultiplier
    /// </summary>
    public unsafe float OpacityShadowsOpacityMultiplier
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 820); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 820); }
    }

    /// <summary>
    /// FloatProperty: OpacityShadowsTransitionSize
    /// </summary>
    public unsafe float OpacityShadowsTransitionSize
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 824); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 824); }
    }

    /// <summary>
    /// ArrayProperty: ReplayClips
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<System.IntPtr>>>>>> ReplayClips
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<System.IntPtr>>>>>>>(Ptr + 828); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 828); }
    }

    /// <summary>
    /// IntProperty: ReplayClipIDNumber
    /// </summary>
    public unsafe int ReplayClipIDNumber
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 844); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 844); }
    }

    /// <summary>
    /// FloatProperty: ReplayTime
    /// </summary>
    public unsafe float ReplayTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 848); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 848); }
    }

    /// <summary>
    /// IntProperty: ReplayFrameIndex
    /// </summary>
    public unsafe int ReplayFrameIndex
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 852); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 852); }
    }

    /// <summary>
    /// FloatProperty: AccumLODDistanceCheckTime
    /// </summary>
    public unsafe float AccumLODDistanceCheckTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 856); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 856); }
    }

    /// <summary>
    /// ArrayProperty: SpawnEvents
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<System.IntPtr>>>>> SpawnEvents
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<System.IntPtr>>>>>>(Ptr + 860); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 860); }
    }

    /// <summary>
    /// ArrayProperty: DeathEvents
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<System.IntPtr>>>> DeathEvents
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<System.IntPtr>>>>>(Ptr + 876); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 876); }
    }

    /// <summary>
    /// ArrayProperty: CollisionEvents
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<System.IntPtr>>> CollisionEvents
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<System.IntPtr>>>>(Ptr + 892); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 892); }
    }

    /// <summary>
    /// ArrayProperty: KismetEvents
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.TArray<System.IntPtr>> KismetEvents
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.TArray<System.IntPtr>>>(Ptr + 908); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 908); }
    }

    /// <summary>
    /// ArrayProperty: AttractorCollisionEvents
    /// </summary>
    public unsafe BmSDK.TArray<System.IntPtr> AttractorCollisionEvents
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<System.IntPtr>>(Ptr + 924); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 924); }
    }

    /// <summary>
    /// StructProperty: ReleaseResourcesFence
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT ReleaseResourcesFence
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 940); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 940); }
    }

    /// <summary>
    /// FloatProperty: CustomTimeDilation
    /// </summary>
    public unsafe float CustomTimeDilation
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 948); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 948); }
    }

    /// <summary>
    /// FloatProperty: EmitterDelay
    /// </summary>
    public unsafe float EmitterDelay
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 952); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 952); }
    }

    /// <summary>
    /// DelegateProperty: __OnSystemFinished__Delegate
    /// </summary>
    public unsafe System.IntPtr __OnSystemFinished__Delegate
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.IntPtr>(Ptr + 956); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 956); }
    }
}
