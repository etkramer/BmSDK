#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: ROverworldPopulationVolume<br/>
/// (flags = 0)
/// </summary>
public partial class ROverworldPopulationVolume : BmSDK.Engine.Volume, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.ROverworldPopulationVolume", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal ROverworldPopulationVolume() { }

    /// <summary>
    /// Constructs a new ROverworldPopulationVolume
    /// </summary>
    public ROverworldPopulationVolume(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, ROverworldPopulationVolume Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected ROverworldPopulationVolume(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="Engine.Actor.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<ROverworldPopulationVolume>
        => ((Engine.Actor)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="Engine.Actor.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<ROverworldPopulationVolume>, new()
        => (TComponent)((Engine.Actor)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="Engine.Actor.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<ROverworldPopulationVolume>
        => ((Engine.Actor)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="Engine.Actor.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<ROverworldPopulationVolume>
        => ((Engine.Actor)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="Engine.Actor.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<ROverworldPopulationVolume>
        => (TComponent)((Engine.Actor)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="Engine.Actor.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<ROverworldPopulationVolume>
        => ((Engine.Actor)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="Engine.Actor.DetachScriptComponent(Type)"/>
    public void DetachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<ROverworldPopulationVolume>
        => ((Engine.Actor)this).DetachScriptComponent(typeof(TComponent));

    /// <summary>
    /// ObjectProperty: PopulationManager
    /// </summary>
    public unsafe BmSDK.BmGame.RPopulationManager PopulationManager
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPopulationManager>(Ptr + 740); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 740); }
    }

    /// <summary>
    /// ObjectProperty: DeadBodyAnimset
    /// </summary>
    public unsafe BmSDK.Engine.AnimSet DeadBodyAnimset
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AnimSet>(Ptr + 748); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 748); }
    }

    /// <summary>
    /// ObjectProperty: StoredPOI
    /// </summary>
    public unsafe BmSDK.BmGame.RGangInteractPointBase StoredPOI
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RGangInteractPointBase>(Ptr + 756); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 756); }
    }

    /// <summary>
    /// ObjectProperty: Batman
    /// </summary>
    public unsafe BmSDK.BmGame.RPawnPlayer Batman
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPawnPlayer>(Ptr + 764); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 764); }
    }

    /// <summary>
    /// ObjectProperty: Batmobile
    /// </summary>
    public unsafe BmSDK.BmGame.RVehicleBatmobileBase Batmobile
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RVehicleBatmobileBase>(Ptr + 772); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 772); }
    }

    /// <summary>
    /// ObjectProperty: ThreatActor
    /// </summary>
    public unsafe BmSDK.Engine.Actor ThreatActor
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.Actor>(Ptr + 780); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 780); }
    }

    /// <summary>
    /// ObjectProperty: SpawnParentActor
    /// </summary>
    public unsafe BmSDK.Engine.Actor SpawnParentActor
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.Actor>(Ptr + 788); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 788); }
    }

    /// <summary>
    /// ObjectProperty: ThreatAsset
    /// </summary>
    public unsafe BmSDK.BmGame.RCheckpointAsset ThreatAsset
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RCheckpointAsset>(Ptr + 796); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 796); }
    }

    /// <summary>
    /// ObjectProperty: RiotWallahLoop
    /// </summary>
    public unsafe BmSDK.Engine.AkEvent RiotWallahLoop
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkEvent>(Ptr + 804); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 804); }
    }

    /// <summary>
    /// ObjectProperty: WallahLevelParam
    /// </summary>
    public unsafe BmSDK.Engine.AkParameterName WallahLevelParam
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkParameterName>(Ptr + 812); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 812); }
    }

    /// <summary>
    /// ObjectProperty: SuppressWalla
    /// </summary>
    public unsafe BmSDK.Engine.AkPredicate SuppressWalla
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkPredicate>(Ptr + 820); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 820); }
    }

    /// <summary>
    /// ObjectProperty: BombThugController
    /// </summary>
    public unsafe BmSDK.BmGame.RSeqAct_ActivateBombThugRiots BombThugController
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSeqAct_ActivateBombThugRiots>(Ptr + 828); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 828); }
    }

    /// <summary>
    /// ClassProperty: DefaultIdleBehaviourClass
    /// </summary>
    public unsafe BmSDK.Class DefaultIdleBehaviourClass
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Class>(Ptr + 836); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 836); }
    }

    /// <summary>
    /// ClassProperty: JokerInGasBehaviourClass
    /// </summary>
    public unsafe BmSDK.Class JokerInGasBehaviourClass
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Class>(Ptr + 844); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 844); }
    }

    /// <summary>
    /// ClassProperty: CityVehicleBehaviourClass
    /// </summary>
    public unsafe BmSDK.Class CityVehicleBehaviourClass
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Class>(Ptr + 852); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 852); }
    }

    /// <summary>
    /// ClassProperty: CityIdleBehaviourClass
    /// </summary>
    public unsafe BmSDK.Class CityIdleBehaviourClass
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Class>(Ptr + 860); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 860); }
    }

    /// <summary>
    /// ClassProperty: CityRunAwayBehaviourClass
    /// </summary>
    public unsafe BmSDK.Class CityRunAwayBehaviourClass
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Class>(Ptr + 868); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 868); }
    }

    /// <summary>
    /// ClassProperty: PawnClass
    /// </summary>
    public unsafe BmSDK.Class PawnClass
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Class>(Ptr + 876); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 876); }
    }

    /// <summary>
    /// BoolProperty: bPopulationActive
    /// </summary>
    public unsafe bool bPopulationActive
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 884) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 884); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 884); }
    }

    /// <summary>
    /// BoolProperty: bDebugPaths
    /// </summary>
    public unsafe bool bDebugPaths
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 884) & 2) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 884); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 884); }
    }

    /// <summary>
    /// BoolProperty: bIsGasJoker
    /// </summary>
    public unsafe bool bIsGasJoker
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 884) & 4) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 884); var newMask = value ? (currentMask | 4) : (currentMask & ~4); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 884); }
    }

    /// <summary>
    /// BoolProperty: bFailedToSpawnWeaponPawn
    /// </summary>
    public unsafe bool bFailedToSpawnWeaponPawn
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 884) & 8) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 884); var newMask = value ? (currentMask | 8) : (currentMask & ~8); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 884); }
    }

    /// <summary>
    /// BoolProperty: bDebugDontProcessThreats
    /// </summary>
    public unsafe bool bDebugDontProcessThreats
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 884) & 16) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 884); var newMask = value ? (currentMask | 16) : (currentMask & ~16); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 884); }
    }

    /// <summary>
    /// BoolProperty: bGenerateDeadBodies
    /// </summary>
    public unsafe bool bGenerateDeadBodies
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 884) & 32) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 884); var newMask = value ? (currentMask | 32) : (currentMask & ~32); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 884); }
    }

    /// <summary>
    /// BoolProperty: bAllowDynamicActivation
    /// </summary>
    public unsafe bool bAllowDynamicActivation
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 884) & 64) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 884); var newMask = value ? (currentMask | 64) : (currentMask & ~64); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 884); }
    }

    /// <summary>
    /// BoolProperty: bIsPassiveRiotZone
    /// </summary>
    public unsafe bool bIsPassiveRiotZone
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 884) & 128) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 884); var newMask = value ? (currentMask | 128) : (currentMask & ~128); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 884); }
    }

    /// <summary>
    /// BoolProperty: TestNewOptimisationOption
    /// </summary>
    public unsafe bool TestNewOptimisationOption
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 884) & 256) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 884); var newMask = value ? (currentMask | 256) : (currentMask & ~256); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 884); }
    }

    /// <summary>
    /// BoolProperty: bHasRegisteredFleeing
    /// </summary>
    public unsafe bool bHasRegisteredFleeing
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 884) & 512) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 884); var newMask = value ? (currentMask | 512) : (currentMask & ~512); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 884); }
    }

    /// <summary>
    /// BoolProperty: bThugStasis
    /// </summary>
    public unsafe bool bThugStasis
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 884) & 1024) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 884); var newMask = value ? (currentMask | 1024) : (currentMask & ~1024); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 884); }
    }

    /// <summary>
    /// BoolProperty: bStopSpawnsForFlee
    /// </summary>
    public unsafe bool bStopSpawnsForFlee
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 884) & 2048) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 884); var newMask = value ? (currentMask | 2048) : (currentMask & ~2048); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 884); }
    }

    /// <summary>
    /// BoolProperty: bNeverProcessThreats
    /// </summary>
    public unsafe bool bNeverProcessThreats
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 884) & 4096) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 884); var newMask = value ? (currentMask | 4096) : (currentMask & ~4096); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 884); }
    }

    /// <summary>
    /// BoolProperty: bSpawnASAP
    /// </summary>
    public unsafe bool bSpawnASAP
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 884) & 8192) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 884); var newMask = value ? (currentMask | 8192) : (currentMask & ~8192); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 884); }
    }

    /// <summary>
    /// BoolProperty: bHasTriggeredBreakWarning
    /// </summary>
    public unsafe bool bHasTriggeredBreakWarning
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 884) & 16384) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 884); var newMask = value ? (currentMask | 16384) : (currentMask & ~16384); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 884); }
    }

    /// <summary>
    /// BoolProperty: bHasSetFightingRioters
    /// </summary>
    public unsafe bool bHasSetFightingRioters
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 884) & 32768) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 884); var newMask = value ? (currentMask | 32768) : (currentMask & ~32768); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 884); }
    }

    /// <summary>
    /// BoolProperty: bAllRiotersFlee
    /// </summary>
    public unsafe bool bAllRiotersFlee
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 884) & 65536) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 884); var newMask = value ? (currentMask | 65536) : (currentMask & ~65536); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 884); }
    }

    /// <summary>
    /// BoolProperty: bRiotExhausted
    /// </summary>
    public unsafe bool bRiotExhausted
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 884) & 131072) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 884); var newMask = value ? (currentMask | 131072) : (currentMask & ~131072); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 884); }
    }

    /// <summary>
    /// BoolProperty: bHasFiredDesignWarning
    /// </summary>
    public unsafe bool bHasFiredDesignWarning
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 884) & 262144) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 884); var newMask = value ? (currentMask | 262144) : (currentMask & ~262144); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 884); }
    }

    /// <summary>
    /// BoolProperty: bNoInformants
    /// </summary>
    public unsafe bool bNoInformants
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 884) & 524288) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 884); var newMask = value ? (currentMask | 524288) : (currentMask & ~524288); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 884); }
    }

    /// <summary>
    /// BoolProperty: bIgnoreBatmobileBelowVolume
    /// </summary>
    public unsafe bool bIgnoreBatmobileBelowVolume
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 884) & 1048576) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 884); var newMask = value ? (currentMask | 1048576) : (currentMask & ~1048576); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 884); }
    }

    /// <summary>
    /// BoolProperty: bHasBombThug
    /// </summary>
    public unsafe bool bHasBombThug
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 884) & 2097152) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 884); var newMask = value ? (currentMask | 2097152) : (currentMask & ~2097152); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 884); }
    }

    /// <summary>
    /// BoolProperty: bSetBombThug
    /// </summary>
    public unsafe bool bSetBombThug
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 884) & 4194304) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 884); var newMask = value ? (currentMask | 4194304) : (currentMask & ~4194304); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 884); }
    }

    /// <summary>
    /// ArrayProperty: MultiCharacterDefines
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RCharacterDefine> MultiCharacterDefines
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RCharacterDefine>>(Ptr + 888); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 888); }
    }

    /// <summary>
    /// ArrayProperty: MultiCharacterTypes
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.Class> MultiCharacterTypes
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Class>>(Ptr + 904); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 904); }
    }

    /// <summary>
    /// ArrayProperty: MultiCharacterDefinesForGas
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RCharacterDefine> MultiCharacterDefinesForGas
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RCharacterDefine>>(Ptr + 920); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 920); }
    }

    /// <summary>
    /// ArrayProperty: MultiCharacterTypesForGas
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.Class> MultiCharacterTypesForGas
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Class>>(Ptr + 936); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 936); }
    }

    /// <summary>
    /// StrProperty: GasIsActiveFlag
    /// </summary>
    public unsafe BmSDK.FString GasIsActiveFlag
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 952); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 952); }
    }

    /// <summary>
    /// ArrayProperty: MilitiaCharacterDefines
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RCharacterDefine> MilitiaCharacterDefines
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RCharacterDefine>>(Ptr + 968); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 968); }
    }

    /// <summary>
    /// ArrayProperty: MilitiaCharacterTypes
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.Class> MilitiaCharacterTypes
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Class>>(Ptr + 984); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 984); }
    }

    /// <summary>
    /// IntProperty: NumSpawnedPawns
    /// </summary>
    public unsafe int NumSpawnedPawns
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1000); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1000); }
    }

    /// <summary>
    /// IntProperty: NumSpawnedWeaponPawns
    /// </summary>
    public unsafe int NumSpawnedWeaponPawns
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1004); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1004); }
    }

    /// <summary>
    /// FloatProperty: ChanceOfDeadBodyPerPoint
    /// </summary>
    public unsafe float ChanceOfDeadBodyPerPoint
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1008); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1008); }
    }

    /// <summary>
    /// ArrayProperty: DeadBodyAnimNames
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.FName> DeadBodyAnimNames
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.FName>>(Ptr + 1012); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1012); }
    }

    /// <summary>
    /// FloatProperty: TimeOfLastDeactivateCheck
    /// </summary>
    public unsafe float TimeOfLastDeactivateCheck
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1028); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1028); }
    }

    /// <summary>
    /// FloatProperty: ClearanceDistanceForPawnSpawn
    /// </summary>
    public unsafe float ClearanceDistanceForPawnSpawn
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1032); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1032); }
    }

    /// <summary>
    /// FloatProperty: ClearanceDistanceForWeaponPawnSpawn
    /// </summary>
    public unsafe float ClearanceDistanceForWeaponPawnSpawn
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1036); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1036); }
    }

    /// <summary>
    /// ArrayProperty: PointsInThisVolume
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RGangInteractPointBase> PointsInThisVolume
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RGangInteractPointBase>>(Ptr + 1040); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1040); }
    }

    /// <summary>
    /// ArrayProperty: VehiclePointsInThisVolume
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RGangVehicleInteractPointBase> VehiclePointsInThisVolume
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RGangVehicleInteractPointBase>>(Ptr + 1056); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1056); }
    }

    /// <summary>
    /// ArrayProperty: ValidRunPoints
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.Engine.Actor> ValidRunPoints
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.Actor>>(Ptr + 1072); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1072); }
    }

    /// <summary>
    /// ArrayProperty: SpawnedPawns
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RBMPawnAI> SpawnedPawns
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RBMPawnAI>>(Ptr + 1088); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1088); }
    }

    /// <summary>
    /// ArrayProperty: SpawnedWeaponPawns
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RBMPawnAI> SpawnedWeaponPawns
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RBMPawnAI>>(Ptr + 1104); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1104); }
    }

    /// <summary>
    /// ArrayProperty: JokerIndexs
    /// </summary>
    public unsafe BmSDK.TArray<int> JokerIndexs
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<int>>(Ptr + 1120); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1120); }
    }

    /// <summary>
    /// FloatProperty: TimeToIgnoreProximityCheckOnSpawns
    /// </summary>
    public unsafe float TimeToIgnoreProximityCheckOnSpawns
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1136); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1136); }
    }

    /// <summary>
    /// FloatProperty: ActivationTime
    /// </summary>
    public unsafe float ActivationTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1140); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1140); }
    }

    /// <summary>
    /// IntProperty: CurrSpawnPointTestIndex
    /// </summary>
    public unsafe int CurrSpawnPointTestIndex
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1144); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1144); }
    }

    /// <summary>
    /// ArrayProperty: FleePressPoints
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RGangFleePressPointBase> FleePressPoints
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RGangFleePressPointBase>>(Ptr + 1148); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1148); }
    }

    /// <summary>
    /// IntProperty: NumThugsWantToFightMin
    /// </summary>
    public unsafe int NumThugsWantToFightMin
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1164); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1164); }
    }

    /// <summary>
    /// IntProperty: NumThugsWantToFightMax
    /// </summary>
    public unsafe int NumThugsWantToFightMax
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1168); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1168); }
    }

    /// <summary>
    /// IntProperty: NumWeaponPawns
    /// </summary>
    public unsafe int NumWeaponPawns
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1172); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1172); }
    }

    /// <summary>
    /// ArrayProperty: Weapons
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.Class> Weapons
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Class>>(Ptr + 1176); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1176); }
    }

    /// <summary>
    /// IntProperty: NumWeaponPawnsAllowedByPopMan
    /// </summary>
    public unsafe int NumWeaponPawnsAllowedByPopMan
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1192); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1192); }
    }

    /// <summary>
    /// FloatProperty: RioterDeactivateTime
    /// </summary>
    public unsafe float RioterDeactivateTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1196); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1196); }
    }

    /// <summary>
    /// FloatProperty: TimeOfLastFlare
    /// </summary>
    public unsafe float TimeOfLastFlare
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1200); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1200); }
    }

    /// <summary>
    /// FloatProperty: TimeBetweenFlares
    /// </summary>
    public unsafe float TimeBetweenFlares
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1204); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1204); }
    }

    /// <summary>
    /// ArrayProperty: ObjectivesWhichForceZoneOn
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.FString> ObjectivesWhichForceZoneOn
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.FString>>(Ptr + 1208); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1208); }
    }

    /// <summary>
    /// FloatProperty: PassivePointCheckTimer
    /// </summary>
    public unsafe float PassivePointCheckTimer
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1224); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1224); }
    }

    /// <summary>
    /// FloatProperty: TimeSincePassivePartnerCheck
    /// </summary>
    public unsafe float TimeSincePassivePartnerCheck
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1228); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1228); }
    }

    /// <summary>
    /// FloatProperty: DistanceForPawnDeletion
    /// </summary>
    public unsafe float DistanceForPawnDeletion
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1232); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1232); }
    }

    /// <summary>
    /// FloatProperty: MinDistanceForPawnSpawn
    /// </summary>
    public unsafe float MinDistanceForPawnSpawn
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1236); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1236); }
    }

    /// <summary>
    /// FloatProperty: MaxDistanceForPawnSpawn
    /// </summary>
    public unsafe float MaxDistanceForPawnSpawn
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1240); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1240); }
    }

    /// <summary>
    /// IntProperty: MaxPawns
    /// </summary>
    public unsafe int MaxPawns
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1244); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1244); }
    }

    /// <summary>
    /// IntProperty: MinPawns
    /// </summary>
    public unsafe int MinPawns
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1248); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1248); }
    }

    /// <summary>
    /// IntProperty: RequiredPawnCount
    /// </summary>
    public unsafe int RequiredPawnCount
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1252); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1252); }
    }

    /// <summary>
    /// IntProperty: MaxWanderingGroups
    /// </summary>
    public unsafe int MaxWanderingGroups
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1256); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1256); }
    }

    /// <summary>
    /// IntProperty: MinWanderingGroups
    /// </summary>
    public unsafe int MinWanderingGroups
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1260); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1260); }
    }

    /// <summary>
    /// IntProperty: NumPawnsPerWanderingGroup
    /// </summary>
    public unsafe int NumPawnsPerWanderingGroup
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1264); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1264); }
    }

    /// <summary>
    /// FloatProperty: BatmobileThreatRange
    /// </summary>
    public unsafe float BatmobileThreatRange
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1268); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1268); }
    }

    /// <summary>
    /// FloatProperty: BatmobileDrivenThreatRange
    /// </summary>
    public unsafe float BatmobileDrivenThreatRange
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1272); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1272); }
    }

    /// <summary>
    /// FloatProperty: BatmanCloseToBatmobile
    /// </summary>
    public unsafe float BatmanCloseToBatmobile
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1276); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1276); }
    }

    /// <summary>
    /// FloatProperty: BatmanClose
    /// </summary>
    public unsafe float BatmanClose
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1280); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1280); }
    }

    /// <summary>
    /// FloatProperty: BatmanVeryClose
    /// </summary>
    public unsafe float BatmanVeryClose
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1284); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1284); }
    }

    /// <summary>
    /// FloatProperty: TimeTillUpdate
    /// </summary>
    public unsafe float TimeTillUpdate
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1288); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1288); }
    }

    /// <summary>
    /// FloatProperty: TimeOfLastUpdate
    /// </summary>
    public unsafe float TimeOfLastUpdate
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1292); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1292); }
    }

    /// <summary>
    /// ArrayProperty: QueuedDeletePawns
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.ROverworldPopulationVolume.FDeletePawnStruct> QueuedDeletePawns
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.ROverworldPopulationVolume.FDeletePawnStruct>>(Ptr + 1296); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1296); }
    }

    /// <summary>
    /// IntProperty: NumThugsToFight
    /// </summary>
    public unsafe int NumThugsToFight
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1312); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1312); }
    }

    /// <summary>
    /// ByteProperty: KismetState
    /// </summary>
    public unsafe BmSDK.BmGame.ROverworldPopulationVolume.EKismetState KismetState
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.ROverworldPopulationVolume.EKismetState>(Ptr + 1316); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1316); }
    }

    /// <summary>
    /// ByteProperty: HelicopterPointOfInterestType
    /// </summary>
    public unsafe BmSDK.BmGame.RGameInfo.HelicopterPointOfInterestTypes HelicopterPointOfInterestType
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RGameInfo.HelicopterPointOfInterestTypes>(Ptr + 1317); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1317); }
    }

    /// <summary>
    /// FloatProperty: BatmobileBelowHeight
    /// </summary>
    public unsafe float BatmobileBelowHeight
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1320); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1320); }
    }

    /// <summary>
    /// IntProperty: BombThugIdx
    /// </summary>
    public unsafe int BombThugIdx
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1324); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1324); }
    }

    /// <summary>
    /// IntProperty: ThugsScanned
    /// </summary>
    public unsafe int ThugsScanned
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1328); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1328); }
    }

    /// <summary>
    /// StructProperty: AverageLocOfPawns
    /// </summary>
    public unsafe System.Numerics.Vector3 AverageLocOfPawns
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 1332); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1332); }
    }
}
