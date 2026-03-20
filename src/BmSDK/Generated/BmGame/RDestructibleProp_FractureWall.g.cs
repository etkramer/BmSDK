#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RDestructibleProp_FractureWall<br/>
/// (flags = 0)
/// </summary>
public partial class RDestructibleProp_FractureWall : BmSDK.BmGame.RDestructibleProp, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RDestructibleProp_FractureWall", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RDestructibleProp_FractureWall() { }

    /// <summary>
    /// Constructs a new RDestructibleProp_FractureWall
    /// </summary>
    public RDestructibleProp_FractureWall(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RDestructibleProp_FractureWall Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RDestructibleProp_FractureWall(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="Engine.Actor.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RDestructibleProp_FractureWall>
        => ((Engine.Actor)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="Engine.Actor.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RDestructibleProp_FractureWall>, new()
        => (TComponent)((Engine.Actor)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="Engine.Actor.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RDestructibleProp_FractureWall>
        => ((Engine.Actor)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="Engine.Actor.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RDestructibleProp_FractureWall>
        => ((Engine.Actor)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="Engine.Actor.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RDestructibleProp_FractureWall>
        => (TComponent)((Engine.Actor)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="Engine.Actor.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RDestructibleProp_FractureWall>
        => ((Engine.Actor)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="Engine.Actor.DetachScriptComponent(Type)"/>
    public void DetachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RDestructibleProp_FractureWall>
        => ((Engine.Actor)this).DetachScriptComponent(typeof(TComponent));

    /// <summary>
    /// ComponentProperty: InvestigationMesh1
    /// </summary>
    public unsafe BmSDK.Engine.StaticMeshComponent InvestigationMesh1
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.StaticMeshComponent>(Ptr + 1724); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1724); }
    }

    /// <summary>
    /// ComponentProperty: InvestigationMesh2
    /// </summary>
    public unsafe BmSDK.Engine.StaticMeshComponent InvestigationMesh2
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.StaticMeshComponent>(Ptr + 1732); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1732); }
    }

    /// <summary>
    /// ComponentProperty: GadgetInteraction
    /// </summary>
    public unsafe BmSDK.Engine.RInteractionComponent GadgetInteraction
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RInteractionComponent>(Ptr + 1740); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1740); }
    }

    /// <summary>
    /// ComponentProperty: VoiceSynthesiserHighlightStaticMesh
    /// </summary>
    public unsafe BmSDK.Engine.StaticMeshComponent VoiceSynthesiserHighlightStaticMesh
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.StaticMeshComponent>(Ptr + 1748); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1748); }
    }

    /// <summary>
    /// BoolProperty: bValidVoiceSynthesiserTarget
    /// </summary>
    public unsafe bool bValidVoiceSynthesiserTarget
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1756) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1756); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1756); }
    }

    /// <summary>
    /// BoolProperty: bIsForceFullDestroyOnDamage
    /// </summary>
    public unsafe bool bIsForceFullDestroyOnDamage
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1756) & 2) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1756); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1756); }
    }

    /// <summary>
    /// BoolProperty: IsImmuneToExplosiveGoo
    /// </summary>
    public unsafe bool IsImmuneToExplosiveGoo
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1756) & 4) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1756); var newMask = value ? (currentMask | 4) : (currentMask & ~4); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1756); }
    }

    /// <summary>
    /// BoolProperty: IsGlass
    /// </summary>
    public unsafe bool IsGlass
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1756) & 8) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1756); var newMask = value ? (currentMask | 8) : (currentMask & ~8); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1756); }
    }

    /// <summary>
    /// BoolProperty: bBlockTakedownOnGlassWall
    /// </summary>
    public unsafe bool bBlockTakedownOnGlassWall
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1756) & 16) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1756); var newMask = value ? (currentMask | 16) : (currentMask & ~16); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1756); }
    }

    /// <summary>
    /// BoolProperty: IsReinforcedGlass
    /// </summary>
    public unsafe bool IsReinforcedGlass
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1756) & 32) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1756); var newMask = value ? (currentMask | 32) : (currentMask & ~32); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1756); }
    }

    /// <summary>
    /// BoolProperty: IsTakedownWall
    /// </summary>
    public unsafe bool IsTakedownWall
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1756) & 64) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1756); var newMask = value ? (currentMask | 64) : (currentMask & ~64); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1756); }
    }

    /// <summary>
    /// BoolProperty: CantPunch
    /// </summary>
    public unsafe bool CantPunch
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1756) & 128) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1756); var newMask = value ? (currentMask | 128) : (currentMask & ~128); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1756); }
    }

    /// <summary>
    /// BoolProperty: IsFragile
    /// </summary>
    public unsafe bool IsFragile
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1756) & 256) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1756); var newMask = value ? (currentMask | 256) : (currentMask & ~256); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1756); }
    }

    /// <summary>
    /// BoolProperty: CanInteract
    /// </summary>
    public unsafe bool CanInteract
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1756) & 512) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1756); var newMask = value ? (currentMask | 512) : (currentMask & ~512); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1756); }
    }

    /// <summary>
    /// BoolProperty: CouldInteractAtPostBeginPlayTime
    /// </summary>
    public unsafe bool CouldInteractAtPostBeginPlayTime
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1756) & 1024) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1756); var newMask = value ? (currentMask | 1024) : (currentMask & ~1024); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1756); }
    }

    /// <summary>
    /// BoolProperty: ShowIconInNonXray
    /// </summary>
    public unsafe bool ShowIconInNonXray
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1756) & 2048) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1756); var newMask = value ? (currentMask | 2048) : (currentMask & ~2048); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1756); }
    }

    /// <summary>
    /// BoolProperty: bSuppressFullAIEvent
    /// </summary>
    public unsafe bool bSuppressFullAIEvent
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1756) & 4096) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1756); var newMask = value ? (currentMask | 4096) : (currentMask & ~4096); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1756); }
    }

    /// <summary>
    /// BoolProperty: bDoNotAffectNavMesh
    /// </summary>
    public unsafe bool bDoNotAffectNavMesh
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1756) & 8192) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1756); var newMask = value ? (currentMask | 8192) : (currentMask & ~8192); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1756); }
    }

    /// <summary>
    /// BoolProperty: bLeaveNavMeshBlockedWhenDestroyed
    /// </summary>
    public unsafe bool bLeaveNavMeshBlockedWhenDestroyed
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1756) & 16384) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1756); var newMask = value ? (currentMask | 16384) : (currentMask & ~16384); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1756); }
    }

    /// <summary>
    /// BoolProperty: bTriggerCombatEvent
    /// </summary>
    public unsafe bool bTriggerCombatEvent
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1756) & 32768) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1756); var newMask = value ? (currentMask | 32768) : (currentMask & ~32768); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1756); }
    }

    /// <summary>
    /// BoolProperty: bDisableNearbyTempGuardPointsWhenDestroyed
    /// </summary>
    public unsafe bool bDisableNearbyTempGuardPointsWhenDestroyed
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1756) & 65536) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1756); var newMask = value ? (currentMask | 65536) : (currentMask & ~65536); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1756); }
    }

    /// <summary>
    /// BoolProperty: bFloor
    /// </summary>
    public unsafe bool bFloor
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1756) & 131072) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1756); var newMask = value ? (currentMask | 131072) : (currentMask & ~131072); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1756); }
    }

    /// <summary>
    /// BoolProperty: bRestoreFracturedEvents
    /// </summary>
    public unsafe bool bRestoreFracturedEvents
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1756) & 262144) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1756); var newMask = value ? (currentMask | 262144) : (currentMask & ~262144); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1756); }
    }

    /// <summary>
    /// BoolProperty: bTookOutThugs
    /// </summary>
    public unsafe bool bTookOutThugs
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1756) & 524288) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1756); var newMask = value ? (currentMask | 524288) : (currentMask & ~524288); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1756); }
    }

    /// <summary>
    /// BoolProperty: bSpawnGlassVolume
    /// </summary>
    public unsafe bool bSpawnGlassVolume
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1756) & 1048576) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1756); var newMask = value ? (currentMask | 1048576) : (currentMask & ~1048576); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1756); }
    }

    /// <summary>
    /// BoolProperty: NoGlideKick
    /// </summary>
    public unsafe bool NoGlideKick
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1756) & 2097152) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1756); var newMask = value ? (currentMask | 2097152) : (currentMask & ~2097152); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1756); }
    }

    /// <summary>
    /// BoolProperty: DontAllowDetonateWithoutValidTarget
    /// </summary>
    public unsafe bool DontAllowDetonateWithoutValidTarget
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1756) & 4194304) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1756); var newMask = value ? (currentMask | 4194304) : (currentMask & ~4194304); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1756); }
    }

    /// <summary>
    /// BoolProperty: bCallOnDamagedForTheFirstTimeEventNextTick
    /// </summary>
    public unsafe bool bCallOnDamagedForTheFirstTimeEventNextTick
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1756) & 8388608) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1756); var newMask = value ? (currentMask | 8388608) : (currentMask & ~8388608); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1756); }
    }

    /// <summary>
    /// BoolProperty: bCallOnDamagedEventNextTick
    /// </summary>
    public unsafe bool bCallOnDamagedEventNextTick
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1756) & 16777216) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1756); var newMask = value ? (currentMask | 16777216) : (currentMask & ~16777216); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1756); }
    }

    /// <summary>
    /// IntProperty: SimultaneousMinesRequiredToDestroy
    /// </summary>
    public unsafe int SimultaneousMinesRequiredToDestroy
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1760); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1760); }
    }

    /// <summary>
    /// IntProperty: GlassSmashReactionID
    /// </summary>
    public unsafe int GlassSmashReactionID
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1764); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1764); }
    }

    /// <summary>
    /// ComponentProperty: RoomState
    /// </summary>
    public unsafe BmSDK.BmGame.RBMRoomAIState RoomState
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RBMRoomAIState>(Ptr + 1768); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1768); }
    }

    /// <summary>
    /// ObjectProperty: EventCoordinator
    /// </summary>
    public unsafe BmSDK.BmGame.RAEC_ExplodedWall EventCoordinator
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RAEC_ExplodedWall>(Ptr + 1776); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1776); }
    }

    /// <summary>
    /// ObjectProperty: ExplodeCamera
    /// </summary>
    public unsafe BmSDK.BmGame.RCameraActor ExplodeCamera
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RCameraActor>(Ptr + 1784); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1784); }
    }

    /// <summary>
    /// ObjectProperty: PelletExplosionFX
    /// </summary>
    public unsafe BmSDK.Engine.ParticleSystem PelletExplosionFX
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleSystem>(Ptr + 1792); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1792); }
    }

    /// <summary>
    /// ObjectProperty: LastBreakInstigator
    /// </summary>
    public unsafe BmSDK.Engine.Actor LastBreakInstigator
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.Actor>(Ptr + 1800); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1800); }
    }

    /// <summary>
    /// ObjectProperty: GlassVolume
    /// </summary>
    public unsafe BmSDK.BmGame.RAudioGlassVolume GlassVolume
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RAudioGlassVolume>(Ptr + 1808); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1808); }
    }

    /// <summary>
    /// ObjectProperty: TouchingPlayer
    /// </summary>
    public unsafe BmSDK.BmGame.RPawnPlayer TouchingPlayer
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPawnPlayer>(Ptr + 1816); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1816); }
    }

    /// <summary>
    /// ObjectProperty: LockInVol
    /// </summary>
    public unsafe BmSDK.BmGame.RLockinVolume LockInVol
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RLockinVolume>(Ptr + 1824); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1824); }
    }

    /// <summary>
    /// ObjectProperty: GlideKickSmashSound
    /// </summary>
    public unsafe BmSDK.Engine.AkEvent GlideKickSmashSound
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkEvent>(Ptr + 1832); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1832); }
    }

    /// <summary>
    /// ObjectProperty: lockingPawn
    /// </summary>
    public unsafe BmSDK.BmGame.RBMPawnAI lockingPawn
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RBMPawnAI>(Ptr + 1840); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1840); }
    }

    /// <summary>
    /// ComponentProperty: XrayLight
    /// </summary>
    public unsafe BmSDK.Engine.PointLightComponent XrayLight
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.PointLightComponent>(Ptr + 1848); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1848); }
    }

    /// <summary>
    /// StructProperty: LastExplosionCentre
    /// </summary>
    public unsafe System.Numerics.Vector3 LastExplosionCentre
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 1856); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1856); }
    }

    /// <summary>
    /// FloatProperty: GelKillRadius
    /// </summary>
    public unsafe float GelKillRadius
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1868); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1868); }
    }

    /// <summary>
    /// StructProperty: TouchingPlayerPrevPos
    /// </summary>
    public unsafe System.Numerics.Vector3 TouchingPlayerPrevPos
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 1872); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1872); }
    }

    /// <summary>
    /// ArrayProperty: LinkedGrapplePoints
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RGrapplePoint> LinkedGrapplePoints
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RGrapplePoint>>(Ptr + 1884); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1884); }
    }

    /// <summary>
    /// ArrayProperty: LinkedCornerPoints
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RCornerPointBase> LinkedCornerPoints
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RCornerPointBase>>(Ptr + 1900); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1900); }
    }

    /// <summary>
    /// Enum: EDestructibleWallSide
    /// </summary>
    public enum EDestructibleWallSide
    {
        EDESTRUCTIBLEWALLSIDE_Front = 0,
        EDESTRUCTIBLEWALLSIDE_Back = 1,
        EDESTRUCTIBLEWALLSIDE_MAX = 2,
    }
}
