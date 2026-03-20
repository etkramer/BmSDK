#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RBMAIController<br/>
/// (flags = 0)
/// </summary>
public partial class RBMAIController : BmSDK.Engine.AIController, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RBMAIController", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RBMAIController() { }

    /// <summary>
    /// Constructs a new RBMAIController
    /// </summary>
    public RBMAIController(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RBMAIController Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RBMAIController(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="Engine.Actor.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RBMAIController>
        => ((Engine.Actor)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="Engine.Actor.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RBMAIController>, new()
        => (TComponent)((Engine.Actor)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="Engine.Actor.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RBMAIController>
        => ((Engine.Actor)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="Engine.Actor.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RBMAIController>
        => ((Engine.Actor)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="Engine.Actor.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RBMAIController>
        => (TComponent)((Engine.Actor)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="Engine.Actor.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RBMAIController>
        => ((Engine.Actor)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="Engine.Actor.DetachScriptComponent(Type)"/>
    public void DetachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RBMAIController>
        => ((Engine.Actor)this).DetachScriptComponent(typeof(TComponent));

    /// <summary>
    /// ObjectProperty: PawnAI
    /// </summary>
    public unsafe BmSDK.BmGame.RBMPawnAI PawnAI
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RBMPawnAI>(Ptr + 1144); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1144); }
    }

    /// <summary>
    /// ObjectProperty: PawnVillain
    /// </summary>
    public unsafe BmSDK.BmGame.RPawnVillain PawnVillain
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPawnVillain>(Ptr + 1152); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1152); }
    }

    /// <summary>
    /// ObjectProperty: CombatBehaviour
    /// </summary>
    public unsafe BmSDK.BmGame.RBMBehaviour_Combat CombatBehaviour
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RBMBehaviour_Combat>(Ptr + 1160); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1160); }
    }

    /// <summary>
    /// ObjectProperty: StoredIdleConfig
    /// </summary>
    public unsafe BmSDK.BmGame.RBMBehaviour StoredIdleConfig
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RBMBehaviour>(Ptr + 1168); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1168); }
    }

    /// <summary>
    /// ObjectProperty: InterruptingBehaviour
    /// </summary>
    public unsafe BmSDK.BmGame.RBMBehaviour InterruptingBehaviour
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RBMBehaviour>(Ptr + 1176); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1176); }
    }

    /// <summary>
    /// ObjectProperty: RiotBrain
    /// </summary>
    public unsafe BmSDK.BmGame.RRiotBrain RiotBrain
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RRiotBrain>(Ptr + 1184); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1184); }
    }

    /// <summary>
    /// ObjectProperty: RiotVolume
    /// </summary>
    public unsafe BmSDK.BmGame.ROverworldPopulationVolume RiotVolume
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.ROverworldPopulationVolume>(Ptr + 1192); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1192); }
    }

    /// <summary>
    /// ObjectProperty: SpecialWatchVPoint
    /// </summary>
    public unsafe BmSDK.BmGame.RHidePoint SpecialWatchVPoint
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RHidePoint>(Ptr + 1200); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1200); }
    }

    /// <summary>
    /// ObjectProperty: PredQueue
    /// </summary>
    public unsafe BmSDK.BmGame.RBMBehaviour_ActionQueue PredQueue
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RBMBehaviour_ActionQueue>(Ptr + 1208); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1208); }
    }

    /// <summary>
    /// ObjectProperty: CurrentEvent
    /// </summary>
    public unsafe BmSDK.BmGame.RAlertEventCoordinatorSolo CurrentEvent
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RAlertEventCoordinatorSolo>(Ptr + 1216); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1216); }
    }

    /// <summary>
    /// ObjectProperty: AIManager
    /// </summary>
    public unsafe BmSDK.BmGame.RBMAIManager AIManager
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RBMAIManager>(Ptr + 1224); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1224); }
    }

    /// <summary>
    /// ObjectProperty: Brain
    /// </summary>
    public unsafe BmSDK.BmGame.RAIBrain Brain
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RAIBrain>(Ptr + 1232); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1232); }
    }

    /// <summary>
    /// ObjectProperty: objectSuppressingReceiveSoftPawnCollision
    /// </summary>
    public unsafe BmSDK.GameObject objectSuppressingReceiveSoftPawnCollision
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.GameObject>(Ptr + 1240); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1240); }
    }

    /// <summary>
    /// ClassProperty: DefaultFleeBehaviourClass
    /// </summary>
    public unsafe BmSDK.Class DefaultFleeBehaviourClass
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Class>(Ptr + 1248); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1248); }
    }

    /// <summary>
    /// ClassProperty: DefaultBehaviourClass
    /// </summary>
    public unsafe BmSDK.Class DefaultBehaviourClass
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Class>(Ptr + 1256); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1256); }
    }

    /// <summary>
    /// ArrayProperty: BehaviourList
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RBMBehaviour> BehaviourList
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RBMBehaviour>>(Ptr + 1264); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1264); }
    }

    /// <summary>
    /// ArrayProperty: ExitConditionList
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RBMExitCondition> ExitConditionList
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RBMExitCondition>>(Ptr + 1280); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1280); }
    }

    /// <summary>
    /// BoolProperty: bDeactivatingBehaviour
    /// </summary>
    public unsafe bool bDeactivatingBehaviour
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1296) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1296); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1296); }
    }

    /// <summary>
    /// BoolProperty: bRegistered
    /// </summary>
    public unsafe bool bRegistered
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1296) & 2) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1296); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1296); }
    }

    /// <summary>
    /// BoolProperty: bHasHadBehaviour
    /// </summary>
    public unsafe bool bHasHadBehaviour
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1296) & 4) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1296); var newMask = value ? (currentMask | 4) : (currentMask & ~4); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1296); }
    }

    /// <summary>
    /// BoolProperty: bInCombat
    /// </summary>
    public unsafe bool bInCombat
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1296) & 8) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1296); var newMask = value ? (currentMask | 8) : (currentMask & ~8); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1296); }
    }

    /// <summary>
    /// BoolProperty: bWeaponChanged
    /// </summary>
    public unsafe bool bWeaponChanged
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1296) & 16) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1296); var newMask = value ? (currentMask | 16) : (currentMask & ~16); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1296); }
    }

    /// <summary>
    /// BoolProperty: bHadCombatBehaviour
    /// </summary>
    public unsafe bool bHadCombatBehaviour
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1296) & 32) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1296); var newMask = value ? (currentMask | 32) : (currentMask & ~32); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1296); }
    }

    /// <summary>
    /// BoolProperty: bEverBeenInCombat
    /// </summary>
    public unsafe bool bEverBeenInCombat
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1296) & 64) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1296); var newMask = value ? (currentMask | 64) : (currentMask & ~64); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1296); }
    }

    /// <summary>
    /// BoolProperty: bUseCombatAreas
    /// </summary>
    public unsafe bool bUseCombatAreas
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1296) & 128) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1296); var newMask = value ? (currentMask | 128) : (currentMask & ~128); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1296); }
    }

    /// <summary>
    /// BoolProperty: bStoreIdleConfig
    /// </summary>
    public unsafe bool bStoreIdleConfig
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1296) & 256) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1296); var newMask = value ? (currentMask | 256) : (currentMask & ~256); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1296); }
    }

    /// <summary>
    /// BoolProperty: bCachedSeenSeqEvents
    /// </summary>
    public unsafe bool bCachedSeenSeqEvents
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1296) & 512) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1296); var newMask = value ? (currentMask | 512) : (currentMask & ~512); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1296); }
    }

    /// <summary>
    /// BoolProperty: bCachedDualPlayPawnSeenSeqEvents
    /// </summary>
    public unsafe bool bCachedDualPlayPawnSeenSeqEvents
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1296) & 1024) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1296); var newMask = value ? (currentMask | 1024) : (currentMask & ~1024); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1296); }
    }

    /// <summary>
    /// BoolProperty: bPlayedEnterCombatSound
    /// </summary>
    public unsafe bool bPlayedEnterCombatSound
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1296) & 2048) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1296); var newMask = value ? (currentMask | 2048) : (currentMask & ~2048); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1296); }
    }

    /// <summary>
    /// BoolProperty: bBehaviourControlledTick
    /// </summary>
    public unsafe bool bBehaviourControlledTick
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1296) & 4096) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1296); var newMask = value ? (currentMask | 4096) : (currentMask & ~4096); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1296); }
    }

    /// <summary>
    /// BoolProperty: bCachedIsStunned
    /// </summary>
    public unsafe bool bCachedIsStunned
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1296) & 8192) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1296); var newMask = value ? (currentMask | 8192) : (currentMask & ~8192); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1296); }
    }

    /// <summary>
    /// BoolProperty: bInShouldAvoidCombat
    /// </summary>
    public unsafe bool bInShouldAvoidCombat
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1296) & 16384) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1296); var newMask = value ? (currentMask | 16384) : (currentMask & ~16384); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1296); }
    }

    /// <summary>
    /// BoolProperty: bVisionIsBlocked
    /// </summary>
    public unsafe bool bVisionIsBlocked
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1296) & 32768) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1296); var newMask = value ? (currentMask | 32768) : (currentMask & ~32768); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1296); }
    }

    /// <summary>
    /// BoolProperty: bStunnedRagdoll
    /// </summary>
    public unsafe bool bStunnedRagdoll
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1296) & 65536) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1296); var newMask = value ? (currentMask | 65536) : (currentMask & ~65536); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1296); }
    }

    /// <summary>
    /// BoolProperty: bLookedAtPlayer
    /// </summary>
    public unsafe bool bLookedAtPlayer
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1296) & 131072) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1296); var newMask = value ? (currentMask | 131072) : (currentMask & ~131072); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1296); }
    }

    /// <summary>
    /// BoolProperty: bUseHeadBoneAsViewDir
    /// </summary>
    public unsafe bool bUseHeadBoneAsViewDir
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1296) & 262144) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1296); var newMask = value ? (currentMask | 262144) : (currentMask & ~262144); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1296); }
    }

    /// <summary>
    /// BoolProperty: bForceShortenPathCheck
    /// </summary>
    public unsafe bool bForceShortenPathCheck
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1296) & 524288) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1296); var newMask = value ? (currentMask | 524288) : (currentMask & ~524288); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1296); }
    }

    /// <summary>
    /// BoolProperty: bHasSeenBMDuringAlert
    /// </summary>
    public unsafe bool bHasSeenBMDuringAlert
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1296) & 1048576) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1296); var newMask = value ? (currentMask | 1048576) : (currentMask & ~1048576); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1296); }
    }

    /// <summary>
    /// BoolProperty: bBehaviourCustomEyeLocation
    /// </summary>
    public unsafe bool bBehaviourCustomEyeLocation
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1296) & 2097152) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1296); var newMask = value ? (currentMask | 2097152) : (currentMask & ~2097152); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1296); }
    }

    /// <summary>
    /// BoolProperty: bBumpedLastPawnMoveTick
    /// </summary>
    public unsafe bool bBumpedLastPawnMoveTick
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1296) & 4194304) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1296); var newMask = value ? (currentMask | 4194304) : (currentMask & ~4194304); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1296); }
    }

    /// <summary>
    /// BoolProperty: bHaveCachedAnimatedAimDir
    /// </summary>
    public unsafe bool bHaveCachedAnimatedAimDir
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1296) & 8388608) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1296); var newMask = value ? (currentMask | 8388608) : (currentMask & ~8388608); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1296); }
    }

    /// <summary>
    /// BoolProperty: bBehaviourIsRunningAEC
    /// </summary>
    public unsafe bool bBehaviourIsRunningAEC
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1296) & 16777216) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1296); var newMask = value ? (currentMask | 16777216) : (currentMask & ~16777216); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1296); }
    }

    /// <summary>
    /// BoolProperty: bIsInsideApplyGlance
    /// </summary>
    public unsafe bool bIsInsideApplyGlance
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1296) & 33554432) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1296); var newMask = value ? (currentMask | 33554432) : (currentMask & ~33554432); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1296); }
    }

    /// <summary>
    /// IntProperty: TriggerActivationEventFrames
    /// </summary>
    public unsafe int TriggerActivationEventFrames
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1300); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1300); }
    }

    /// <summary>
    /// ArrayProperty: SeenSeqEvents
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.Engine.SequenceObject> SeenSeqEvents
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.SequenceObject>>(Ptr + 1304); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1304); }
    }

    /// <summary>
    /// FloatProperty: TimeSinceActivatedSeenEvents
    /// </summary>
    public unsafe float TimeSinceActivatedSeenEvents
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1320); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1320); }
    }

    /// <summary>
    /// ArrayProperty: DualPlayPawnSeenSeqEvents
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.Engine.SequenceObject> DualPlayPawnSeenSeqEvents
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.SequenceObject>>(Ptr + 1324); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1324); }
    }

    /// <summary>
    /// FloatProperty: TimeSinceActivatedDualPlayPawnSeenEvents
    /// </summary>
    public unsafe float TimeSinceActivatedDualPlayPawnSeenEvents
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1340); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1340); }
    }

    /// <summary>
    /// FloatProperty: SuspectLimit
    /// </summary>
    public unsafe float SuspectLimit
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1344); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1344); }
    }

    /// <summary>
    /// FloatProperty: SpottedLimit
    /// </summary>
    public unsafe float SpottedLimit
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1348); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1348); }
    }

    /// <summary>
    /// FloatProperty: MinCanSeePercent
    /// </summary>
    public unsafe float MinCanSeePercent
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1352); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1352); }
    }

    /// <summary>
    /// FloatProperty: SimpleFOVCheckRange
    /// </summary>
    public unsafe float SimpleFOVCheckRange
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1356); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1356); }
    }

    /// <summary>
    /// FloatProperty: Attack360AwarenessRange
    /// </summary>
    public unsafe float Attack360AwarenessRange
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1360); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1360); }
    }

    /// <summary>
    /// ArrayProperty: CurrentAlert
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.AlertInstance> CurrentAlert
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.AlertInstance>>(Ptr + 1364); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1364); }
    }

    /// <summary>
    /// ArrayProperty: NeighbourList
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RBMAIController> NeighbourList
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RBMAIController>>(Ptr + 1380); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1380); }
    }

    /// <summary>
    /// FloatProperty: LookAtPlayerTime
    /// </summary>
    public unsafe float LookAtPlayerTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1396); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1396); }
    }

    /// <summary>
    /// FloatProperty: LookAtPlayerDistance
    /// </summary>
    public unsafe float LookAtPlayerDistance
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1400); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1400); }
    }

    /// <summary>
    /// FloatProperty: LastSearchInvestigateMoveTime
    /// </summary>
    public unsafe float LastSearchInvestigateMoveTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1404); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1404); }
    }

    /// <summary>
    /// NameProperty: HeadBone
    /// </summary>
    public unsafe BmSDK.FName HeadBone
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 1408); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1408); }
    }

    /// <summary>
    /// NameProperty: NervousIdleVariantName
    /// </summary>
    public unsafe BmSDK.FName NervousIdleVariantName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 1416); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1416); }
    }

    /// <summary>
    /// NameProperty: NoStateName
    /// </summary>
    public unsafe BmSDK.FName NoStateName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 1424); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1424); }
    }

    /// <summary>
    /// FloatProperty: BumpedTimer
    /// </summary>
    public unsafe float BumpedTimer
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1432); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1432); }
    }

    /// <summary>
    /// StructProperty: CachedAnimatedAimDir
    /// </summary>
    public unsafe System.Numerics.Vector3 CachedAnimatedAimDir
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 1436); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1436); }
    }

    /// <summary>
    /// FloatProperty: LastCheckUnconsciousThugTime
    /// </summary>
    public unsafe float LastCheckUnconsciousThugTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1448); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1448); }
    }

    /// <summary>
    /// StrProperty: sUniqueAIIdentifier
    /// </summary>
    public unsafe BmSDK.FString sUniqueAIIdentifier
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 1452); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1452); }
    }

    /// <summary>
    /// ArrayProperty: ForceTickObjects
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.GameObject> ForceTickObjects
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.GameObject>>(Ptr + 1468); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1468); }
    }

    /// <summary>
    /// ArrayProperty: ForceTickIfCloseObjects
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.GameObject> ForceTickIfCloseObjects
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.GameObject>>(Ptr + 1484); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1484); }
    }

    /// <summary>
    /// NameProperty: PawnName
    /// </summary>
    public unsafe BmSDK.FName PawnName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 1500); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1500); }
    }
}
