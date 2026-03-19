#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RBatarang<br/>
/// (size = 0)
/// (flags = 0)
/// </summary>
public partial class RBatarang : BmSDK.BmGame.RInventoryGadget, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RBatarang", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RBatarang() { }

    /// <summary>
    /// Constructs a new RBatarang
    /// </summary>
    public RBatarang(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RBatarang Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RBatarang(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="Engine.Actor.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RBatarang>
        => ((Engine.Actor)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="Engine.Actor.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RBatarang>, new()
        => (TComponent)((Engine.Actor)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="Engine.Actor.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RBatarang>
        => ((Engine.Actor)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="Engine.Actor.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RBatarang>
        => ((Engine.Actor)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="Engine.Actor.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RBatarang>
        => (TComponent)((Engine.Actor)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="Engine.Actor.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RBatarang>
        => ((Engine.Actor)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="Engine.Actor.DetachScriptComponent(Type)"/>
    public void DetachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RBatarang>
        => ((Engine.Actor)this).DetachScriptComponent(typeof(TComponent));

    /// <summary>
    /// StructProperty: TargetPosition
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT TargetPosition
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 2068); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2068); }
    }

    /// <summary>
    /// ObjectProperty: CurrentBatarangTarget
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT CurrentBatarangTarget
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 2080); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2080); }
    }

    /// <summary>
    /// ObjectProperty: BatarangRumble
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT BatarangRumble
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 2088); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2088); }
    }

    /// <summary>
    /// ObjectProperty: LastProjectile
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT LastProjectile
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 2096); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2096); }
    }

    /// <summary>
    /// ObjectProperty: ThrowSound
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT ThrowSound
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 2104); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2104); }
    }

    /// <summary>
    /// ObjectProperty: AimedThrowSound
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT AimedThrowSound
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 2112); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2112); }
    }

    /// <summary>
    /// ObjectProperty: QuickThrowSound
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT QuickThrowSound
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 2120); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2120); }
    }

    /// <summary>
    /// ObjectProperty: NoisyTargets
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT NoisyTargets_0
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 2128); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2128); }
    }
    /// <summary>
    /// ObjectProperty: NoisyTargets
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT NoisyTargets_1
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 2136); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2136); }
    }
    /// <summary>
    /// ObjectProperty: NoisyTargets
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT NoisyTargets_2
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 2144); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2144); }
    }
    /// <summary>
    /// ObjectProperty: NoisyTargets
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT NoisyTargets_3
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 2152); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2152); }
    }
    /// <summary>
    /// ObjectProperty: NoisyTargets
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT NoisyTargets_4
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 2160); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2160); }
    }
    /// <summary>
    /// ObjectProperty: NoisyTargets
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT NoisyTargets_5
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 2168); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2168); }
    }
    /// <summary>
    /// ObjectProperty: NoisyTargets
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT NoisyTargets_6
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 2176); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2176); }
    }
    /// <summary>
    /// ObjectProperty: NoisyTargets
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT NoisyTargets_7
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 2184); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2184); }
    }

    /// <summary>
    /// ComponentProperty: AudibleTargetMarker
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT AudibleTargetMarker
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 2192); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2192); }
    }

    /// <summary>
    /// ClassProperty: BatarangProjectileClass
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT BatarangProjectileClass
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 2200); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2200); }
    }

    /// <summary>
    /// ClassProperty: BatarangCameraClass
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT BatarangCameraClass
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 2208); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2208); }
    }

    /// <summary>
    /// StructProperty: BatarangOverlay
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT BatarangOverlay
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 2216); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2216); }
    }

    /// <summary>
    /// BoolProperty: bThrownAtMaxRange
    /// </summary>
    public unsafe bool bThrownAtMaxRange
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2224) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2224); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2224); }
    }

    /// <summary>
    /// BoolProperty: bCanTargetWindows
    /// </summary>
    public unsafe bool bCanTargetWindows
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2224) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2224); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2224); }
    }

    /// <summary>
    /// BoolProperty: bBatarangReturns
    /// </summary>
    public unsafe bool bBatarangReturns
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2224) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2224); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2224); }
    }

    /// <summary>
    /// BoolProperty: bExplainBatarangRules
    /// </summary>
    public unsafe bool bExplainBatarangRules
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2224) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2224); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2224); }
    }

    /// <summary>
    /// BoolProperty: bLockingTargets
    /// </summary>
    public unsafe bool bLockingTargets
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2224) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2224); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2224); }
    }

    /// <summary>
    /// BoolProperty: bDrawDebug
    /// </summary>
    public unsafe bool bDrawDebug
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2224) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2224); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2224); }
    }

    /// <summary>
    /// BoolProperty: bPressedGadgetButton
    /// </summary>
    public unsafe bool bPressedGadgetButton
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2224) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2224); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2224); }
    }

    /// <summary>
    /// BoolProperty: bCombatThrow
    /// </summary>
    public unsafe bool bCombatThrow
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2224) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2224); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2224); }
    }

    /// <summary>
    /// BoolProperty: BatarangTargets
    /// </summary>
    public unsafe bool BatarangTargets
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2224) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2224); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2224); }
    }

    /// <summary>
    /// BoolProperty: bLastBatarangHit
    /// </summary>
    public unsafe bool bLastBatarangHit
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2224) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2224); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2224); }
    }

    /// <summary>
    /// BoolProperty: bExittingThrowingState
    /// </summary>
    public unsafe bool bExittingThrowingState
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2224) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2224); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2224); }
    }

    /// <summary>
    /// BoolProperty: bTriggerBatarangCamera
    /// </summary>
    public unsafe bool bTriggerBatarangCamera
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2224) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2224); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2224); }
    }

    /// <summary>
    /// BoolProperty: bDebugFlightPath
    /// </summary>
    public unsafe bool bDebugFlightPath
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2224) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2224); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2224); }
    }

    /// <summary>
    /// BoolProperty: bCanComboThrow
    /// </summary>
    public unsafe bool bCanComboThrow
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2224) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2224); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2224); }
    }

    /// <summary>
    /// BoolProperty: bDebugBatarangLimits
    /// </summary>
    public unsafe bool bDebugBatarangLimits
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2224) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2224); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2224); }
    }

    /// <summary>
    /// BoolProperty: bAutoTargetChecksLevelLimits
    /// </summary>
    public unsafe bool bAutoTargetChecksLevelLimits
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2224) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2224); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2224); }
    }

    /// <summary>
    /// BoolProperty: bSecondaryMode
    /// </summary>
    public unsafe bool bSecondaryMode
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2224) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2224); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2224); }
    }

    /// <summary>
    /// BoolProperty: OnlyTargetPawns
    /// </summary>
    public unsafe bool OnlyTargetPawns
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2224) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2224); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2224); }
    }

    /// <summary>
    /// BoolProperty: bCausesNoiseRadius
    /// </summary>
    public unsafe bool bCausesNoiseRadius
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2224) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2224); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2224); }
    }

    /// <summary>
    /// BoolProperty: bSuperComboThrow
    /// </summary>
    public unsafe bool bSuperComboThrow
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2224) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2224); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2224); }
    }

    /// <summary>
    /// BoolProperty: bGlidingThrow
    /// </summary>
    public unsafe bool bGlidingThrow
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2224) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2224); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2224); }
    }

    /// <summary>
    /// BoolProperty: bReactionBatarangThrow
    /// </summary>
    public unsafe bool bReactionBatarangThrow
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2224) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2224); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2224); }
    }

    /// <summary>
    /// IntProperty: QueuedBatarangs
    /// </summary>
    public unsafe int QueuedBatarangs
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2228); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2228); }
    }

    /// <summary>
    /// IntProperty: ThrownBatarangs
    /// </summary>
    public unsafe int ThrownBatarangs
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2232); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2232); }
    }

    /// <summary>
    /// NameProperty: TargetBoneName
    /// </summary>
    public unsafe BmSDK.FName TargetBoneName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 2236); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2236); }
    }

    /// <summary>
    /// FloatProperty: TargetRopePosition
    /// </summary>
    public unsafe float TargetRopePosition
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2244); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2244); }
    }

    /// <summary>
    /// IntProperty: MaxNumTargets
    /// </summary>
    public unsafe int MaxNumTargets
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2248); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2248); }
    }

    /// <summary>
    /// FloatProperty: BatarangRange
    /// </summary>
    public unsafe float BatarangRange
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2252); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2252); }
    }

    /// <summary>
    /// FloatProperty: AutoTargetRange
    /// </summary>
    public unsafe float AutoTargetRange
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2256); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2256); }
    }

    /// <summary>
    /// FloatProperty: AutoTargetAngle
    /// </summary>
    public unsafe float AutoTargetAngle
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2260); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2260); }
    }

    /// <summary>
    /// FloatProperty: NormalTargetAngle
    /// </summary>
    public unsafe float NormalTargetAngle
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2264); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2264); }
    }

    /// <summary>
    /// IntProperty: MaxQueuedBatarangs
    /// </summary>
    public unsafe int MaxQueuedBatarangs
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2268); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2268); }
    }

    /// <summary>
    /// IntProperty: PowerUpgradeLevel
    /// </summary>
    public unsafe int PowerUpgradeLevel
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2272); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2272); }
    }

    /// <summary>
    /// ArrayProperty: BodyPartsTargetted
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.TArray<BmSDK.BmGame.RInventoryGadget.TutorialText>> BodyPartsTargetted
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.TArray<BmSDK.BmGame.RInventoryGadget.TutorialText>>>(Ptr + 2276); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2276); }
    }

    /// <summary>
    /// StructProperty: AimLocation
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT AimLocation
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 2292); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2292); }
    }

    /// <summary>
    /// StructProperty: AimDirection
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT AimDirection
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 2304); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2304); }
    }

    /// <summary>
    /// FloatProperty: StunModifier
    /// </summary>
    public unsafe float StunModifier
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2316); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2316); }
    }

    /// <summary>
    /// FloatProperty: ImpactModifier
    /// </summary>
    public unsafe float ImpactModifier
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2320); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2320); }
    }

    /// <summary>
    /// FloatProperty: IdealThrowYaw
    /// </summary>
    public unsafe float IdealThrowYaw
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2324); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2324); }
    }

    /// <summary>
    /// FloatProperty: IdealImpactYaw
    /// </summary>
    public unsafe float IdealImpactYaw
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2328); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2328); }
    }

    /// <summary>
    /// FloatProperty: IdealThrowLength
    /// </summary>
    public unsafe float IdealThrowLength
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2332); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2332); }
    }

    /// <summary>
    /// FloatProperty: IdealThrowPitch
    /// </summary>
    public unsafe float IdealThrowPitch
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2336); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2336); }
    }

    /// <summary>
    /// FloatProperty: IdealImpactPitch
    /// </summary>
    public unsafe float IdealImpactPitch
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2340); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2340); }
    }

    /// <summary>
    /// FloatProperty: ThrowSpeed
    /// </summary>
    public unsafe float ThrowSpeed
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2344); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2344); }
    }

    /// <summary>
    /// FloatProperty: IdealFlightTime
    /// </summary>
    public unsafe float IdealFlightTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2348); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2348); }
    }

    /// <summary>
    /// FloatProperty: MinimumFlightTime
    /// </summary>
    public unsafe float MinimumFlightTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2352); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2352); }
    }

    /// <summary>
    /// FloatProperty: RCStunModifier
    /// </summary>
    public unsafe float RCStunModifier
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2356); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2356); }
    }

    /// <summary>
    /// FloatProperty: RCImpactModifier
    /// </summary>
    public unsafe float RCImpactModifier
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2360); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2360); }
    }

    /// <summary>
    /// FloatProperty: RCIdealThrowYaw
    /// </summary>
    public unsafe float RCIdealThrowYaw
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2364); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2364); }
    }

    /// <summary>
    /// FloatProperty: RCIdealImpactYaw
    /// </summary>
    public unsafe float RCIdealImpactYaw
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2368); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2368); }
    }

    /// <summary>
    /// FloatProperty: RCIdealThrowLength
    /// </summary>
    public unsafe float RCIdealThrowLength
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2372); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2372); }
    }

    /// <summary>
    /// FloatProperty: RCIdealThrowPitch
    /// </summary>
    public unsafe float RCIdealThrowPitch
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2376); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2376); }
    }

    /// <summary>
    /// FloatProperty: RCIdealImpactPitch
    /// </summary>
    public unsafe float RCIdealImpactPitch
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2380); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2380); }
    }

    /// <summary>
    /// FloatProperty: RCIdealFlightTime
    /// </summary>
    public unsafe float RCIdealFlightTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2384); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2384); }
    }

    /// <summary>
    /// FloatProperty: RCMinimumFlightTime
    /// </summary>
    public unsafe float RCMinimumFlightTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2388); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2388); }
    }

    /// <summary>
    /// IntProperty: MaxNumQuickBatarangs
    /// </summary>
    public unsafe int MaxNumQuickBatarangs
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2392); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2392); }
    }

    /// <summary>
    /// ArrayProperty: QuickBatarangTargets
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RInventoryGadget.TutorialText> QuickBatarangTargets
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RInventoryGadget.TutorialText>>(Ptr + 2396); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2396); }
    }

    /// <summary>
    /// ByteProperty: LastFootPoint
    /// </summary>
    public unsafe byte LastFootPoint
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 2412); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2412); }
    }

    /// <summary>
    /// ByteProperty: LastMirrorChoice
    /// </summary>
    public unsafe byte LastMirrorChoice
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 2413); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2413); }
    }

    /// <summary>
    /// ByteProperty: OldThrowType
    /// </summary>
    public unsafe byte OldThrowType
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 2414); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2414); }
    }

    /// <summary>
    /// ByteProperty: ComboMoveType
    /// </summary>
    public unsafe byte ComboMoveType
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 2415); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2415); }
    }

    /// <summary>
    /// IntProperty: MaxNumEnemiesHit
    /// </summary>
    public unsafe int MaxNumEnemiesHit
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2416); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2416); }
    }

    /// <summary>
    /// StructProperty: ThrowDirectionTypes
    /// </summary>
    public unsafe BmSDK.BmGame.RInventoryGadget.TutorialText ThrowDirectionTypes_0
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RInventoryGadget.TutorialText>(Ptr + 2420); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2420); }
    }
    /// <summary>
    /// StructProperty: ThrowDirectionTypes
    /// </summary>
    public unsafe BmSDK.BmGame.RInventoryGadget.TutorialText ThrowDirectionTypes_1
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RInventoryGadget.TutorialText>(Ptr + 2436); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2436); }
    }
    /// <summary>
    /// StructProperty: ThrowDirectionTypes
    /// </summary>
    public unsafe BmSDK.BmGame.RInventoryGadget.TutorialText ThrowDirectionTypes_2
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RInventoryGadget.TutorialText>(Ptr + 2452); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2452); }
    }
    /// <summary>
    /// StructProperty: ThrowDirectionTypes
    /// </summary>
    public unsafe BmSDK.BmGame.RInventoryGadget.TutorialText ThrowDirectionTypes_3
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RInventoryGadget.TutorialText>(Ptr + 2468); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2468); }
    }
    /// <summary>
    /// StructProperty: ThrowDirectionTypes
    /// </summary>
    public unsafe BmSDK.BmGame.RInventoryGadget.TutorialText ThrowDirectionTypes_4
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RInventoryGadget.TutorialText>(Ptr + 2484); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2484); }
    }
    /// <summary>
    /// StructProperty: ThrowDirectionTypes
    /// </summary>
    public unsafe BmSDK.BmGame.RInventoryGadget.TutorialText ThrowDirectionTypes_5
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RInventoryGadget.TutorialText>(Ptr + 2500); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2500); }
    }
    /// <summary>
    /// StructProperty: ThrowDirectionTypes
    /// </summary>
    public unsafe BmSDK.BmGame.RInventoryGadget.TutorialText ThrowDirectionTypes_6
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RInventoryGadget.TutorialText>(Ptr + 2516); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2516); }
    }
    /// <summary>
    /// StructProperty: ThrowDirectionTypes
    /// </summary>
    public unsafe BmSDK.BmGame.RInventoryGadget.TutorialText ThrowDirectionTypes_7
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RInventoryGadget.TutorialText>(Ptr + 2532); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2532); }
    }
    /// <summary>
    /// StructProperty: ThrowDirectionTypes
    /// </summary>
    public unsafe BmSDK.BmGame.RInventoryGadget.TutorialText ThrowDirectionTypes_8
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RInventoryGadget.TutorialText>(Ptr + 2548); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2548); }
    }
    /// <summary>
    /// StructProperty: ThrowDirectionTypes
    /// </summary>
    public unsafe BmSDK.BmGame.RInventoryGadget.TutorialText ThrowDirectionTypes_9
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RInventoryGadget.TutorialText>(Ptr + 2564); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2564); }
    }
    /// <summary>
    /// StructProperty: ThrowDirectionTypes
    /// </summary>
    public unsafe BmSDK.BmGame.RInventoryGadget.TutorialText ThrowDirectionTypes_10
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RInventoryGadget.TutorialText>(Ptr + 2580); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2580); }
    }
    /// <summary>
    /// StructProperty: ThrowDirectionTypes
    /// </summary>
    public unsafe BmSDK.BmGame.RInventoryGadget.TutorialText ThrowDirectionTypes_11
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RInventoryGadget.TutorialText>(Ptr + 2596); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2596); }
    }
    /// <summary>
    /// StructProperty: ThrowDirectionTypes
    /// </summary>
    public unsafe BmSDK.BmGame.RInventoryGadget.TutorialText ThrowDirectionTypes_12
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RInventoryGadget.TutorialText>(Ptr + 2612); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2612); }
    }

    /// <summary>
    /// FloatProperty: BatarangCameraDelay
    /// </summary>
    public unsafe float BatarangCameraDelay
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2628); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2628); }
    }

    /// <summary>
    /// FloatProperty: RCReboundTime
    /// </summary>
    public unsafe float RCReboundTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2632); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2632); }
    }

    /// <summary>
    /// FloatProperty: NoisyRadius
    /// </summary>
    public unsafe float NoisyRadius
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2636); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2636); }
    }
}
