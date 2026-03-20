#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RPopulationManager<br/>
/// (flags = 0)
/// </summary>
public partial class RPopulationManager : BmSDK.Engine.Actor, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RPopulationManager", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RPopulationManager() { }

    /// <summary>
    /// Constructs a new RPopulationManager
    /// </summary>
    public RPopulationManager(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RPopulationManager Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RPopulationManager(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="Engine.Actor.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RPopulationManager>
        => ((Engine.Actor)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="Engine.Actor.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RPopulationManager>, new()
        => (TComponent)((Engine.Actor)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="Engine.Actor.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RPopulationManager>
        => ((Engine.Actor)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="Engine.Actor.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RPopulationManager>
        => ((Engine.Actor)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="Engine.Actor.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RPopulationManager>
        => (TComponent)((Engine.Actor)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="Engine.Actor.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RPopulationManager>
        => ((Engine.Actor)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="Engine.Actor.DetachScriptComponent(Type)"/>
    public void DetachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RPopulationManager>
        => ((Engine.Actor)this).DetachScriptComponent(typeof(TComponent));

    /// <summary>
    /// ArrayProperty: DistrictVolumes
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RPopulationDistrictVolume> DistrictVolumes
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RPopulationDistrictVolume>>(Ptr + 668); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 668); }
    }

    /// <summary>
    /// IntProperty: MaxRiotPawns
    /// </summary>
    public unsafe int MaxRiotPawns
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 684); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 684); }
    }

    /// <summary>
    /// FloatProperty: PopulationMinActivateDist
    /// </summary>
    public unsafe float PopulationMinActivateDist
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 688); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 688); }
    }

    /// <summary>
    /// FloatProperty: PopulationMinDeactivateDist
    /// </summary>
    public unsafe float PopulationMinDeactivateDist
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 692); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 692); }
    }

    /// <summary>
    /// FloatProperty: PopulationMinBackwardsDeactivateDist
    /// </summary>
    public unsafe float PopulationMinBackwardsDeactivateDist
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 696); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 696); }
    }

    /// <summary>
    /// FloatProperty: PopulationMaxCosAngle
    /// </summary>
    public unsafe float PopulationMaxCosAngle
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 700); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 700); }
    }

    /// <summary>
    /// ArrayProperty: PopulationVolumes
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.ROverworldPopulationVolume> PopulationVolumes
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.ROverworldPopulationVolume>>(Ptr + 704); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 704); }
    }

    /// <summary>
    /// ArrayProperty: ActivePopulationVolumes
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.ROverworldPopulationVolume> ActivePopulationVolumes
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.ROverworldPopulationVolume>>(Ptr + 720); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 720); }
    }

    /// <summary>
    /// IntProperty: OwVolumeToUpdateIndex
    /// </summary>
    public unsafe int OwVolumeToUpdateIndex
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 736); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 736); }
    }

    /// <summary>
    /// FloatProperty: TimeSinceDistrictUpdate
    /// </summary>
    public unsafe float TimeSinceDistrictUpdate
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 740); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 740); }
    }

    /// <summary>
    /// FloatProperty: MinDistBetweenMilitiaCheckpointsAndRiotZones
    /// </summary>
    public unsafe float MinDistBetweenMilitiaCheckpointsAndRiotZones
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 744); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 744); }
    }

    /// <summary>
    /// FloatProperty: LastBatmobileMobTime
    /// </summary>
    public unsafe float LastBatmobileMobTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 748); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 748); }
    }

    /// <summary>
    /// FloatProperty: MinTimeBetweenBatmobileMobs
    /// </summary>
    public unsafe float MinTimeBetweenBatmobileMobs
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 752); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 752); }
    }

    /// <summary>
    /// FloatProperty: TimeSinceWanderingVehicleChatter
    /// </summary>
    public unsafe float TimeSinceWanderingVehicleChatter
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 756); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 756); }
    }

    /// <summary>
    /// ArrayProperty: CurrentBatmobileMobThugs
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RBMPawnAI> CurrentBatmobileMobThugs
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RBMPawnAI>>(Ptr + 760); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 760); }
    }

    /// <summary>
    /// ArrayProperty: TemporaryDeactivatedPopulationVolumes
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RPopulationManager.FTempDeactivatedPopVolumes> TemporaryDeactivatedPopulationVolumes
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RPopulationManager.FTempDeactivatedPopVolumes>>(Ptr + 776); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 776); }
    }

    /// <summary>
    /// StructProperty: PreviousPlayerDirection
    /// </summary>
    public unsafe System.Numerics.Vector3 PreviousPlayerDirection
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 792); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 792); }
    }

    /// <summary>
    /// FloatProperty: ConsecutivePlayerDirectionTime
    /// </summary>
    public unsafe float ConsecutivePlayerDirectionTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 804); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 804); }
    }

    /// <summary>
    /// BoolProperty: bDebugActivateLocalPopulationVolume
    /// </summary>
    public unsafe bool bDebugActivateLocalPopulationVolume
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 808) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 808); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 808); }
    }

    /// <summary>
    /// BoolProperty: bDebugWorstCaseRiotSize
    /// </summary>
    public unsafe bool bDebugWorstCaseRiotSize
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 808) & 2) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 808); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 808); }
    }

    /// <summary>
    /// BoolProperty: bDebugThugStasis
    /// </summary>
    public unsafe bool bDebugThugStasis
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 808) & 4) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 808); var newMask = value ? (currentMask | 4) : (currentMask & ~4); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 808); }
    }

    /// <summary>
    /// BoolProperty: bUseUmbraForRioterSpawning
    /// </summary>
    public unsafe bool bUseUmbraForRioterSpawning
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 808) & 8) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 808); var newMask = value ? (currentMask | 8) : (currentMask & ~8); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 808); }
    }

    /// <summary>
    /// BoolProperty: bDebugRiotZoneVisualisation
    /// </summary>
    public unsafe bool bDebugRiotZoneVisualisation
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 808) & 16) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 808); var newMask = value ? (currentMask | 16) : (currentMask & ~16); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 808); }
    }

    /// <summary>
    /// BoolProperty: bDebugRiotZoneVisualisation_Thugs
    /// </summary>
    public unsafe bool bDebugRiotZoneVisualisation_Thugs
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 808) & 32) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 808); var newMask = value ? (currentMask | 32) : (currentMask & ~32); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 808); }
    }

    /// <summary>
    /// BoolProperty: bDebugRiotZoneVisualisation_RiotPoints
    /// </summary>
    public unsafe bool bDebugRiotZoneVisualisation_RiotPoints
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 808) & 64) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 808); var newMask = value ? (currentMask | 64) : (currentMask & ~64); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 808); }
    }

    /// <summary>
    /// BoolProperty: bDebugUmbraVisibility
    /// </summary>
    public unsafe bool bDebugUmbraVisibility
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 808) & 128) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 808); var newMask = value ? (currentMask | 128) : (currentMask & ~128); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 808); }
    }

    /// <summary>
    /// BoolProperty: bClearUmbraVisibilityDebugNextFrame
    /// </summary>
    public unsafe bool bClearUmbraVisibilityDebugNextFrame
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 808) & 256) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 808); var newMask = value ? (currentMask | 256) : (currentMask & ~256); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 808); }
    }

    /// <summary>
    /// BoolProperty: bRiotingDisabledByMostWanted
    /// </summary>
    public unsafe bool bRiotingDisabledByMostWanted
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 808) & 512) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 808); var newMask = value ? (currentMask | 512) : (currentMask & ~512); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 808); }
    }

    /// <summary>
    /// BoolProperty: bForceDisable
    /// </summary>
    public unsafe bool bForceDisable
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 808) & 1024) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 808); var newMask = value ? (currentMask | 1024) : (currentMask & ~1024); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 808); }
    }

    /// <summary>
    /// BoolProperty: bInChallenge
    /// </summary>
    public unsafe bool bInChallenge
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 808) & 2048) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 808); var newMask = value ? (currentMask | 2048) : (currentMask & ~2048); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 808); }
    }

    /// <summary>
    /// BoolProperty: bKismetPausePopulation
    /// </summary>
    public unsafe bool bKismetPausePopulation
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 808) & 4096) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 808); var newMask = value ? (currentMask | 4096) : (currentMask & ~4096); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 808); }
    }

    /// <summary>
    /// BoolProperty: bRemovePopulationOnNextTick
    /// </summary>
    public unsafe bool bRemovePopulationOnNextTick
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 808) & 8192) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 808); var newMask = value ? (currentMask | 8192) : (currentMask & ~8192); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 808); }
    }

    /// <summary>
    /// BoolProperty: bLocalPopulationControlActive
    /// </summary>
    public unsafe bool bLocalPopulationControlActive
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 808) & 16384) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 808); var newMask = value ? (currentMask | 16384) : (currentMask & ~16384); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 808); }
    }

    /// <summary>
    /// BoolProperty: bShowAPCPopulationDebug
    /// </summary>
    public unsafe bool bShowAPCPopulationDebug
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 808) & 32768) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 808); var newMask = value ? (currentMask | 32768) : (currentMask & ~32768); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 808); }
    }

    /// <summary>
    /// BoolProperty: bGasActiveInOverworld
    /// </summary>
    public unsafe bool bGasActiveInOverworld
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 808) & 65536) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 808); var newMask = value ? (currentMask | 65536) : (currentMask & ~65536); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 808); }
    }

    /// <summary>
    /// BoolProperty: bForceRiots
    /// </summary>
    public unsafe bool bForceRiots
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 808) & 131072) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 808); var newMask = value ? (currentMask | 131072) : (currentMask & ~131072); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 808); }
    }

    /// <summary>
    /// BoolProperty: bJokerSpawned
    /// </summary>
    public unsafe bool bJokerSpawned
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 808) & 262144) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 808); var newMask = value ? (currentMask | 262144) : (currentMask & ~262144); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 808); }
    }

    /// <summary>
    /// BoolProperty: bJokerWasSeen
    /// </summary>
    public unsafe bool bJokerWasSeen
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 808) & 524288) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 808); var newMask = value ? (currentMask | 524288) : (currentMask & ~524288); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 808); }
    }

    /// <summary>
    /// BoolProperty: bDebugForceMilitaWanderers
    /// </summary>
    public unsafe bool bDebugForceMilitaWanderers
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 808) & 1048576) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 808); var newMask = value ? (currentMask | 1048576) : (currentMask & ~1048576); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 808); }
    }

    /// <summary>
    /// BoolProperty: bNeedToSetNextRiddlerInformantType
    /// </summary>
    public unsafe bool bNeedToSetNextRiddlerInformantType
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 808) & 2097152) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 808); var newMask = value ? (currentMask | 2097152) : (currentMask & ~2097152); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 808); }
    }

    /// <summary>
    /// BoolProperty: bRiotZoneInCombat
    /// </summary>
    public unsafe bool bRiotZoneInCombat
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 808) & 4194304) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 808); var newMask = value ? (currentMask | 4194304) : (currentMask & ~4194304); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 808); }
    }

    /// <summary>
    /// BoolProperty: bUsePawnPooling
    /// </summary>
    public unsafe bool bUsePawnPooling
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 808) & 8388608) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 808); var newMask = value ? (currentMask | 8388608) : (currentMask & ~8388608); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 808); }
    }

    /// <summary>
    /// BoolProperty: bFillPawnPoolOnNextTick
    /// </summary>
    public unsafe bool bFillPawnPoolOnNextTick
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 808) & 16777216) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 808); var newMask = value ? (currentMask | 16777216) : (currentMask & ~16777216); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 808); }
    }

    /// <summary>
    /// BoolProperty: bUseWeaponPooling
    /// </summary>
    public unsafe bool bUseWeaponPooling
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 808) & 33554432) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 808); var newMask = value ? (currentMask | 33554432) : (currentMask & ~33554432); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 808); }
    }

    /// <summary>
    /// BoolProperty: bFillWeaponPoolOnNextTick
    /// </summary>
    public unsafe bool bFillWeaponPoolOnNextTick
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 808) & 67108864) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 808); var newMask = value ? (currentMask | 67108864) : (currentMask & ~67108864); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 808); }
    }

    /// <summary>
    /// BoolProperty: bUseWeaponConfigPool
    /// </summary>
    public unsafe bool bUseWeaponConfigPool
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 808) & 134217728) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 808); var newMask = value ? (currentMask | 134217728) : (currentMask & ~134217728); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 808); }
    }

    /// <summary>
    /// BoolProperty: bDebugPawnPoolCounts
    /// </summary>
    public unsafe bool bDebugPawnPoolCounts
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 808) & 268435456) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 808); var newMask = value ? (currentMask | 268435456) : (currentMask & ~268435456); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 808); }
    }

    /// <summary>
    /// BoolProperty: bHasLoadedSaveGame
    /// </summary>
    public unsafe bool bHasLoadedSaveGame
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 808) & 536870912) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 808); var newMask = value ? (currentMask | 536870912) : (currentMask & ~536870912); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 808); }
    }

    /// <summary>
    /// BoolProperty: bAllowCarsInAPCChases
    /// </summary>
    public unsafe bool bAllowCarsInAPCChases
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 808) & 1073741824) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 808); var newMask = value ? (currentMask | 1073741824) : (currentMask & ~1073741824); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 808); }
    }

    /// <summary>
    /// BoolProperty: bInRiotFightCheck
    /// </summary>
    public unsafe bool bInRiotFightCheck
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 808) & -2147483648) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 808); var newMask = value ? (currentMask | -2147483648) : (currentMask & ~-2147483648); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 808); }
    }

    /// <summary>
    /// IntProperty: MaxStasisPawnsToDisplay
    /// </summary>
    public unsafe int MaxStasisPawnsToDisplay
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 812); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 812); }
    }

    /// <summary>
    /// ClassProperty: RunAwayBehaviourClass
    /// </summary>
    public unsafe BmSDK.Class RunAwayBehaviourClass
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Class>(Ptr + 816); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 816); }
    }

    /// <summary>
    /// FloatProperty: OverrideWallCheckDistance
    /// </summary>
    public unsafe float OverrideWallCheckDistance
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 824); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 824); }
    }

    /// <summary>
    /// FloatProperty: OverrideWallCheckForce
    /// </summary>
    public unsafe float OverrideWallCheckForce
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 828); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 828); }
    }

    /// <summary>
    /// FloatProperty: OverrideGiveUpTime
    /// </summary>
    public unsafe float OverrideGiveUpTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 832); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 832); }
    }

    /// <summary>
    /// FloatProperty: DebugRiotZoneVisualisationScale
    /// </summary>
    public unsafe float DebugRiotZoneVisualisationScale
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 836); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 836); }
    }

    /// <summary>
    /// FloatProperty: BatmobilePawnCountMultiplier
    /// </summary>
    public unsafe float BatmobilePawnCountMultiplier
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 840); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 840); }
    }

    /// <summary>
    /// FloatProperty: NonBatmobilePawnCountMultiplier
    /// </summary>
    public unsafe float NonBatmobilePawnCountMultiplier
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 844); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 844); }
    }

    /// <summary>
    /// IntProperty: VehicleCountReduction
    /// </summary>
    public unsafe int VehicleCountReduction
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 848); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 848); }
    }

    /// <summary>
    /// ArrayProperty: FireflyRemoveVehicles
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RVehicle> FireflyRemoveVehicles
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RVehicle>>(Ptr + 852); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 852); }
    }

    /// <summary>
    /// ArrayProperty: VehiclePopulation
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RPopulationManager.FSpawnedScenario> VehiclePopulation
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RPopulationManager.FSpawnedScenario>>(Ptr + 868); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 868); }
    }

    /// <summary>
    /// ArrayProperty: ScenarioUsageInfo
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RPopulationManager.FScenarioUsageInformation> ScenarioUsageInfo
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RPopulationManager.FScenarioUsageInformation>>(Ptr + 884); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 884); }
    }

    /// <summary>
    /// FloatProperty: VehicleActiveTimer
    /// </summary>
    public unsafe float VehicleActiveTimer
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 900); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 900); }
    }

    /// <summary>
    /// FloatProperty: VehicleSpawnTimer
    /// </summary>
    public unsafe float VehicleSpawnTimer
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 904); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 904); }
    }

    /// <summary>
    /// FloatProperty: VehicleScenarios_TimeBetweenSpawns
    /// </summary>
    public unsafe float VehicleScenarios_TimeBetweenSpawns
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 908); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 908); }
    }

    /// <summary>
    /// FloatProperty: VehicleScenarios_MinLifeTime
    /// </summary>
    public unsafe float VehicleScenarios_MinLifeTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 912); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 912); }
    }

    /// <summary>
    /// FloatProperty: VehicleScenarios_SpawnChance
    /// </summary>
    public unsafe float VehicleScenarios_SpawnChance
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 916); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 916); }
    }

    /// <summary>
    /// FloatProperty: VehicleScenarios_RiotSpawnTimout
    /// </summary>
    public unsafe float VehicleScenarios_RiotSpawnTimout
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 920); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 920); }
    }

    /// <summary>
    /// IntProperty: VehicleScenarios_MaxScenarios
    /// </summary>
    public unsafe int VehicleScenarios_MaxScenarios
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 924); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 924); }
    }

    /// <summary>
    /// IntProperty: VehicleScenarios_MaxDroneScenarios
    /// </summary>
    public unsafe int VehicleScenarios_MaxDroneScenarios
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 928); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 928); }
    }

    /// <summary>
    /// IntProperty: VehicleScenarios_MaxHumveeScenarios
    /// </summary>
    public unsafe int VehicleScenarios_MaxHumveeScenarios
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 932); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 932); }
    }

    /// <summary>
    /// IntProperty: VehicleScenarios_VehicleRadius
    /// </summary>
    public unsafe int VehicleScenarios_VehicleRadius
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 936); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 936); }
    }

    /// <summary>
    /// IntProperty: VehicleScenarios_VehicleSpawnRadius
    /// </summary>
    public unsafe int VehicleScenarios_VehicleSpawnRadius
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 940); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 940); }
    }

    /// <summary>
    /// IntProperty: VehicleScenarios_VehicleSpawnAvoidRadius
    /// </summary>
    public unsafe int VehicleScenarios_VehicleSpawnAvoidRadius
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 944); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 944); }
    }

    /// <summary>
    /// FloatProperty: VehicleScenarios_RespawnAfterDeathTime
    /// </summary>
    public unsafe float VehicleScenarios_RespawnAfterDeathTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 948); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 948); }
    }

    /// <summary>
    /// IntProperty: VehicleScenarios_EnterFightThugsLimit
    /// </summary>
    public unsafe int VehicleScenarios_EnterFightThugsLimit
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 952); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 952); }
    }

    /// <summary>
    /// IntProperty: VehicleScenarios_EnterFightVehiclesLimit
    /// </summary>
    public unsafe int VehicleScenarios_EnterFightVehiclesLimit
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 956); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 956); }
    }

    /// <summary>
    /// ObjectProperty: ActivelyTailedAPC
    /// </summary>
    public unsafe BmSDK.BmGame.RVehicleNPC ActivelyTailedAPC
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RVehicleNPC>(Ptr + 960); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 960); }
    }

    /// <summary>
    /// ObjectProperty: CustomRiotingThreatActor
    /// </summary>
    public unsafe BmSDK.Engine.Actor CustomRiotingThreatActor
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.Actor>(Ptr + 968); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 968); }
    }

    /// <summary>
    /// ObjectProperty: JokerPopulationVolume
    /// </summary>
    public unsafe BmSDK.BmGame.ROverworldPopulationVolume JokerPopulationVolume
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.ROverworldPopulationVolume>(Ptr + 976); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 976); }
    }

    /// <summary>
    /// ObjectProperty: DynamicVehicleExclusionVolume
    /// </summary>
    public unsafe BmSDK.BmGame.RVehicleExclusionVolume DynamicVehicleExclusionVolume
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RVehicleExclusionVolume>(Ptr + 984); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 984); }
    }

    /// <summary>
    /// ObjectProperty: PassengersEnteredCombatVehicle
    /// </summary>
    public unsafe BmSDK.BmGame.RVehicleNPC PassengersEnteredCombatVehicle
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RVehicleNPC>(Ptr + 992); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 992); }
    }

    /// <summary>
    /// ObjectProperty: ThugPool
    /// </summary>
    public unsafe BmSDK.BmGame.RPawnPool ThugPool
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPawnPool>(Ptr + 1000); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1000); }
    }

    /// <summary>
    /// ObjectProperty: MilitiaPool
    /// </summary>
    public unsafe BmSDK.BmGame.RPawnPool MilitiaPool
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPawnPool>(Ptr + 1008); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1008); }
    }

    /// <summary>
    /// ObjectProperty: CustomThugPool
    /// </summary>
    public unsafe BmSDK.BmGame.RPawnPool CustomThugPool
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPawnPool>(Ptr + 1016); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1016); }
    }

    /// <summary>
    /// IntProperty: LocalPopulationDeaths
    /// </summary>
    public unsafe int LocalPopulationDeaths
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1024); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1024); }
    }

    /// <summary>
    /// StructProperty: LocalPopulationCenter
    /// </summary>
    public unsafe System.Numerics.Vector3 LocalPopulationCenter
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 1028); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1028); }
    }

    /// <summary>
    /// FloatProperty: LocalPopulationRadius
    /// </summary>
    public unsafe float LocalPopulationRadius
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1040); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1040); }
    }

    /// <summary>
    /// StructProperty: StoredScenarioID
    /// </summary>
    public unsafe BmSDK.BmGame.RPopulationManager.FScenarioID StoredScenarioID
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPopulationManager.FScenarioID>(Ptr + 1044); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1044); }
    }

    /// <summary>
    /// IntProperty: StoredDistrictID
    /// </summary>
    public unsafe int StoredDistrictID
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1052); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1052); }
    }

    /// <summary>
    /// IntProperty: StoredScenarioChecks
    /// </summary>
    public unsafe int StoredScenarioChecks
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1056); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1056); }
    }

    /// <summary>
    /// FloatProperty: DronePopulationFallOffStart
    /// </summary>
    public unsafe float DronePopulationFallOffStart
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1060); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1060); }
    }

    /// <summary>
    /// FloatProperty: DronePopulationFallOffMax
    /// </summary>
    public unsafe float DronePopulationFallOffMax
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1064); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1064); }
    }

    /// <summary>
    /// FloatProperty: HumveePopulationFallOffStart
    /// </summary>
    public unsafe float HumveePopulationFallOffStart
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1068); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1068); }
    }

    /// <summary>
    /// FloatProperty: HumveePopulationFallOffMax
    /// </summary>
    public unsafe float HumveePopulationFallOffMax
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1072); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1072); }
    }

    /// <summary>
    /// FloatProperty: TimeUntilHumvee
    /// </summary>
    public unsafe float TimeUntilHumvee
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1076); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1076); }
    }

    /// <summary>
    /// IntProperty: CurrentDistrictId
    /// </summary>
    public unsafe int CurrentDistrictId
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1080); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1080); }
    }

    /// <summary>
    /// ArrayProperty: DistrictRandomPopulation
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RPersistentData.FRandomPopulationDefine> DistrictRandomPopulation
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RPersistentData.FRandomPopulationDefine>>(Ptr + 1084); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1084); }
    }

    /// <summary>
    /// ArrayProperty: StoredDistrictRandomPopulation
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RPersistentData.FRandomPopulationDefine> StoredDistrictRandomPopulation
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RPersistentData.FRandomPopulationDefine>>(Ptr + 1100); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1100); }
    }

    /// <summary>
    /// ArrayProperty: APCInfos
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RPersistentData.FAPCSideStoryInfo> APCInfos
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RPersistentData.FAPCSideStoryInfo>>(Ptr + 1116); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1116); }
    }

    /// <summary>
    /// ArrayProperty: ExtraCarScenarios
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RVehicleScenario> ExtraCarScenarios
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RVehicleScenario>>(Ptr + 1132); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1132); }
    }

    /// <summary>
    /// FloatProperty: ExtraCarScenarioMinTimeBetween
    /// </summary>
    public unsafe float ExtraCarScenarioMinTimeBetween
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1148); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1148); }
    }

    /// <summary>
    /// FloatProperty: ExtraCarScenarioMaxTimeBetween
    /// </summary>
    public unsafe float ExtraCarScenarioMaxTimeBetween
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1152); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1152); }
    }

    /// <summary>
    /// FloatProperty: ExtraCarScenarioNextSpawnTime
    /// </summary>
    public unsafe float ExtraCarScenarioNextSpawnTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1156); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1156); }
    }

    /// <summary>
    /// ArrayProperty: APCDistrictSpawnPoints
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RPopulationManager.FAPCSpawnPointsList> APCDistrictSpawnPoints
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RPopulationManager.FAPCSpawnPointsList>>(Ptr + 1160); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1160); }
    }

    /// <summary>
    /// FloatProperty: LastRocketTime
    /// </summary>
    public unsafe float LastRocketTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1176); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1176); }
    }

    /// <summary>
    /// ArrayProperty: ThugsPreventingRocketFire
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RPawnVillain> ThugsPreventingRocketFire
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RPawnVillain>>(Ptr + 1180); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1180); }
    }

    /// <summary>
    /// ArrayProperty: SpawnedWanderers
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RPopulationManager.FWanderingGroup> SpawnedWanderers
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RPopulationManager.FWanderingGroup>>(Ptr + 1196); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1196); }
    }

    /// <summary>
    /// IntProperty: ActiveWanderers
    /// </summary>
    public unsafe int ActiveWanderers
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1212); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1212); }
    }

    /// <summary>
    /// ArrayProperty: RecentWanderSpawns
    /// </summary>
    public unsafe BmSDK.TArray<System.Numerics.Vector3> RecentWanderSpawns
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<System.Numerics.Vector3>>(Ptr + 1216); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1216); }
    }

    /// <summary>
    /// FloatProperty: WandererSpawnDist
    /// </summary>
    public unsafe float WandererSpawnDist
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1232); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1232); }
    }

    /// <summary>
    /// FloatProperty: WandererDeleteDist
    /// </summary>
    public unsafe float WandererDeleteDist
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1236); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1236); }
    }

    /// <summary>
    /// IntProperty: MaxJokersAllowedInRiots
    /// </summary>
    public unsafe int MaxJokersAllowedInRiots
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1240); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1240); }
    }

    /// <summary>
    /// IntProperty: JokerTimeBetweenRiotAppearance
    /// </summary>
    public unsafe int JokerTimeBetweenRiotAppearance
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1244); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1244); }
    }

    /// <summary>
    /// IntProperty: JokerTimeBetweenRiotChances
    /// </summary>
    public unsafe int JokerTimeBetweenRiotChances
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1248); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1248); }
    }

    /// <summary>
    /// FloatProperty: JokerInRiotPercChance
    /// </summary>
    public unsafe float JokerInRiotPercChance
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1252); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1252); }
    }

    /// <summary>
    /// ArrayProperty: SpawnedJokerPawns
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RBMPawnAI> SpawnedJokerPawns
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RBMPawnAI>>(Ptr + 1256); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1256); }
    }

    /// <summary>
    /// FloatProperty: TimeTillNextJokerInRiotCheck
    /// </summary>
    public unsafe float TimeTillNextJokerInRiotCheck
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1272); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1272); }
    }

    /// <summary>
    /// FloatProperty: MinDistForJoker
    /// </summary>
    public unsafe float MinDistForJoker
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1276); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1276); }
    }

    /// <summary>
    /// FloatProperty: MaxDistForJoker
    /// </summary>
    public unsafe float MaxDistForJoker
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1280); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1280); }
    }

    /// <summary>
    /// FloatProperty: RiddlerInformantTimeMin
    /// </summary>
    public unsafe float RiddlerInformantTimeMin
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1284); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1284); }
    }

    /// <summary>
    /// FloatProperty: RiddlerInformantTimeMax
    /// </summary>
    public unsafe float RiddlerInformantTimeMax
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1288); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1288); }
    }

    /// <summary>
    /// FloatProperty: RiddlerInformantTimer
    /// </summary>
    public unsafe float RiddlerInformantTimer
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1292); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1292); }
    }

    /// <summary>
    /// ByteProperty: RiddlerInformantNextType
    /// </summary>
    public unsafe BmSDK.BmGame.RPopulationManager.InformantType RiddlerInformantNextType
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPopulationManager.InformantType>(Ptr + 1296); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1296); }
    }

    /// <summary>
    /// ArrayProperty: ActiveRiddlerInformants
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RPawnVillain> ActiveRiddlerInformants
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RPawnVillain>>(Ptr + 1300); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1300); }
    }

    /// <summary>
    /// FloatProperty: TimeTillNextJoker
    /// </summary>
    public unsafe float TimeTillNextJoker
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1316); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1316); }
    }

    /// <summary>
    /// FloatProperty: ThreatWarningAmount
    /// </summary>
    public unsafe float ThreatWarningAmount
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1320); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1320); }
    }

    /// <summary>
    /// ArrayProperty: CachedThreatLevels
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RPopulationManager.FThreatLevelCache> CachedThreatLevels
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RPopulationManager.FThreatLevelCache>>(Ptr + 1324); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1324); }
    }

    /// <summary>
    /// ArrayProperty: ThreatLevelChangedEvents
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RSeqEvent_ThreatLevelChanged> ThreatLevelChangedEvents
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RSeqEvent_ThreatLevelChanged>>(Ptr + 1340); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1340); }
    }

    /// <summary>
    /// ArrayProperty: ThreatAssetContainers
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RCityBlockThreatAsset> ThreatAssetContainers
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RCityBlockThreatAsset>>(Ptr + 1356); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1356); }
    }

    /// <summary>
    /// NameProperty: DynamicVehicleExclusionName
    /// </summary>
    public unsafe BmSDK.FName DynamicVehicleExclusionName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 1372); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1372); }
    }

    /// <summary>
    /// ArrayProperty: ActorsPreventingSpawning
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.Engine.Actor> ActorsPreventingSpawning
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.Actor>>(Ptr + 1380); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1380); }
    }

    /// <summary>
    /// FloatProperty: TimeUntilInformantInCar
    /// </summary>
    public unsafe float TimeUntilInformantInCar
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1396); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1396); }
    }

    /// <summary>
    /// IntProperty: NumNonRiotThugsInCombat
    /// </summary>
    public unsafe int NumNonRiotThugsInCombat
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1400); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1400); }
    }

    /// <summary>
    /// ArrayProperty: ThugCharacterDefines
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RCharacterDefine> ThugCharacterDefines
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RCharacterDefine>>(Ptr + 1404); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1404); }
    }

    /// <summary>
    /// IntProperty: ThugPoolSize
    /// </summary>
    public unsafe int ThugPoolSize
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1420); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1420); }
    }

    /// <summary>
    /// ArrayProperty: MilitiaCharacterDefines
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RCharacterDefine> MilitiaCharacterDefines
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RCharacterDefine>>(Ptr + 1424); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1424); }
    }

    /// <summary>
    /// IntProperty: MilitiaPoolSize
    /// </summary>
    public unsafe int MilitiaPoolSize
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1440); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1440); }
    }

    /// <summary>
    /// ArrayProperty: WeaponPools
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RWeaponPool> WeaponPools
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RWeaponPool>>(Ptr + 1444); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1444); }
    }

    /// <summary>
    /// IntProperty: WeaponPoolSize
    /// </summary>
    public unsafe int WeaponPoolSize
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1460); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1460); }
    }

    /// <summary>
    /// ArrayProperty: WeaponPoolTypes
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.Class> WeaponPoolTypes
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Class>>(Ptr + 1464); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1464); }
    }

    /// <summary>
    /// ArrayProperty: WeaponConfigPool
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RPopulationManager.FWeaponConfigInfo> WeaponConfigPool
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RPopulationManager.FWeaponConfigInfo>>(Ptr + 1480); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1480); }
    }

    /// <summary>
    /// ArrayProperty: PawnsToDestroy
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RPopulationManager.FDestroyPawnInfo> PawnsToDestroy
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RPopulationManager.FDestroyPawnInfo>>(Ptr + 1496); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1496); }
    }

    /// <summary>
    /// ArrayProperty: PawnsToInformOfThreat
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RBMPawnAI> PawnsToInformOfThreat
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RBMPawnAI>>(Ptr + 1512); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1512); }
    }

    /// <summary>
    /// FloatProperty: RiddlerInformantPostInterrogateTimer
    /// </summary>
    public unsafe float RiddlerInformantPostInterrogateTimer
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1528); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1528); }
    }

    /// <summary>
    /// ObjectProperty: CurrentInterrogationBehaviour
    /// </summary>
    public unsafe BmSDK.BmGame.RBMBehaviour CurrentInterrogationBehaviour
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RBMBehaviour>(Ptr + 1532); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1532); }
    }

    /// <summary>
    /// FloatProperty: RiddlerInformantSeenTimer
    /// </summary>
    public unsafe float RiddlerInformantSeenTimer
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1540); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1540); }
    }

    /// <summary>
    /// ObjectProperty: KilledAPC
    /// </summary>
    public unsafe BmSDK.BmGame.RVehicleNPC KilledAPC
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RVehicleNPC>(Ptr + 1544); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1544); }
    }
}
