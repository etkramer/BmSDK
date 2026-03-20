#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RPawnBossFireflyBase<br/>
/// (flags = 0)
/// </summary>
public partial class RPawnBossFireflyBase : BmSDK.BmGame.RPawnVillain, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RPawnBossFireflyBase", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RPawnBossFireflyBase() { }

    /// <summary>
    /// Constructs a new RPawnBossFireflyBase
    /// </summary>
    public RPawnBossFireflyBase(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RPawnBossFireflyBase Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RPawnBossFireflyBase(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="Engine.Actor.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RPawnBossFireflyBase>
        => ((Engine.Actor)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="Engine.Actor.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RPawnBossFireflyBase>, new()
        => (TComponent)((Engine.Actor)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="Engine.Actor.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RPawnBossFireflyBase>
        => ((Engine.Actor)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="Engine.Actor.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RPawnBossFireflyBase>
        => ((Engine.Actor)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="Engine.Actor.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RPawnBossFireflyBase>
        => (TComponent)((Engine.Actor)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="Engine.Actor.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RPawnBossFireflyBase>
        => ((Engine.Actor)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="Engine.Actor.DetachScriptComponent(Type)"/>
    public void DetachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RPawnBossFireflyBase>
        => ((Engine.Actor)this).DetachScriptComponent(typeof(TComponent));

    /// <summary>
    /// ObjectProperty: BMAnimSet
    /// </summary>
    public unsafe BmSDK.Engine.AnimSet BMAnimSet
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AnimSet>(Ptr + 6664); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6664); }
    }

    /// <summary>
    /// ObjectProperty: FFAnimSet
    /// </summary>
    public unsafe BmSDK.Engine.AnimSet FFAnimSet
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AnimSet>(Ptr + 6672); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6672); }
    }

    /// <summary>
    /// ObjectProperty: CameraAnimSet
    /// </summary>
    public unsafe BmSDK.Engine.AnimSet CameraAnimSet
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AnimSet>(Ptr + 6680); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6680); }
    }

    /// <summary>
    /// ObjectProperty: BatmanPawn
    /// </summary>
    public unsafe BmSDK.BmGame.RPawnPlayer BatmanPawn
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPawnPlayer>(Ptr + 6688); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6688); }
    }

    /// <summary>
    /// ObjectProperty: RPC
    /// </summary>
    public unsafe BmSDK.BmGame.RPlayerController RPC
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPlayerController>(Ptr + 6696); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6696); }
    }

    /// <summary>
    /// ObjectProperty: BeatDownMove
    /// </summary>
    public unsafe BmSDK.BmGame.RSpecialMoveConfig BeatDownMove
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveConfig>(Ptr + 6704); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6704); }
    }

    /// <summary>
    /// ObjectProperty: JetpackSound
    /// </summary>
    public unsafe BmSDK.Engine.AkEvent JetpackSound
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkEvent>(Ptr + 6712); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6712); }
    }

    /// <summary>
    /// ObjectProperty: BossModule
    /// </summary>
    public unsafe BmSDK.BmGame.RHudModuleBoss BossModule
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RHudModuleBoss>(Ptr + 6720); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6720); }
    }

    /// <summary>
    /// ObjectProperty: PunchEmoteContainer
    /// </summary>
    public unsafe BmSDK.Engine.AkDialogueSpeech PunchEmoteContainer
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkDialogueSpeech>(Ptr + 6728); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6728); }
    }

    /// <summary>
    /// ComponentProperty: FlameThrower
    /// </summary>
    public unsafe BmSDK.Engine.SkeletalMeshComponent FlameThrower
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.SkeletalMeshComponent>(Ptr + 6736); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6736); }
    }

    /// <summary>
    /// ClassProperty: GrenadeClass
    /// </summary>
    public unsafe BmSDK.Class GrenadeClass
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Class>(Ptr + 6744); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6744); }
    }

    /// <summary>
    /// ComponentProperty: targetVFX
    /// </summary>
    public unsafe BmSDK.Engine.ParticleSystemComponent targetVFX
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleSystemComponent>(Ptr + 6752); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6752); }
    }

    /// <summary>
    /// ComponentProperty: smokePFX
    /// </summary>
    public unsafe BmSDK.Engine.ParticleSystemComponent smokePFX_0
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleSystemComponent>(Ptr + 6760); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6760); }
    }
    /// <summary>
    /// ComponentProperty: smokePFX
    /// </summary>
    public unsafe BmSDK.Engine.ParticleSystemComponent smokePFX_1
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleSystemComponent>(Ptr + 6768); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6768); }
    }

    /// <summary>
    /// BoolProperty: bDrawDebug
    /// </summary>
    public unsafe bool bDrawDebug
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 6776) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 6776); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 6776); }
    }

    /// <summary>
    /// BoolProperty: bTargetVFXShouldBeActive
    /// </summary>
    public unsafe bool bTargetVFXShouldBeActive
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 6776) & 2) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 6776); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 6776); }
    }

    /// <summary>
    /// BoolProperty: bNoMovement
    /// </summary>
    public unsafe bool bNoMovement
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 6776) & 4) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 6776); var newMask = value ? (currentMask | 4) : (currentMask & ~4); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 6776); }
    }

    /// <summary>
    /// BoolProperty: targetVFXOn
    /// </summary>
    public unsafe bool targetVFXOn
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 6776) & 8) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 6776); var newMask = value ? (currentMask | 8) : (currentMask & ~8); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 6776); }
    }

    /// <summary>
    /// BoolProperty: bDrawDistanceDebug
    /// </summary>
    public unsafe bool bDrawDistanceDebug
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 6776) & 16) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 6776); var newMask = value ? (currentMask | 16) : (currentMask & ~16); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 6776); }
    }

    /// <summary>
    /// BoolProperty: bSmokeTrailRunning
    /// </summary>
    public unsafe bool bSmokeTrailRunning
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 6776) & 32) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 6776); var newMask = value ? (currentMask | 32) : (currentMask & ~32); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 6776); }
    }

    /// <summary>
    /// BoolProperty: bBoostEffectRunning
    /// </summary>
    public unsafe bool bBoostEffectRunning
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 6776) & 64) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 6776); var newMask = value ? (currentMask | 64) : (currentMask & ~64); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 6776); }
    }

    /// <summary>
    /// BoolProperty: bOutOfFuel
    /// </summary>
    public unsafe bool bOutOfFuel
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 6776) & 128) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 6776); var newMask = value ? (currentMask | 128) : (currentMask & ~128); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 6776); }
    }

    /// <summary>
    /// StrProperty: encounterCompleteFlagNames
    /// </summary>
    public unsafe BmSDK.FString encounterCompleteFlagNames_0
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 6780); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6780); }
    }
    /// <summary>
    /// StrProperty: encounterCompleteFlagNames
    /// </summary>
    public unsafe BmSDK.FString encounterCompleteFlagNames_1
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 6796); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6796); }
    }
    /// <summary>
    /// StrProperty: encounterCompleteFlagNames
    /// </summary>
    public unsafe BmSDK.FString encounterCompleteFlagNames_2
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 6812); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6812); }
    }

    /// <summary>
    /// IntProperty: numEncountersComplete
    /// </summary>
    public unsafe int numEncountersComplete
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 6828); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6828); }
    }

    /// <summary>
    /// FloatProperty: healthProportion
    /// </summary>
    public unsafe float healthProportion
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 6832); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6832); }
    }

    /// <summary>
    /// FloatProperty: targetVFXZOffset
    /// </summary>
    public unsafe float targetVFXZOffset
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 6836); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6836); }
    }

    /// <summary>
    /// FloatProperty: targetLinePulseProportion
    /// </summary>
    public unsafe float targetLinePulseProportion
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 6840); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6840); }
    }

    /// <summary>
    /// FloatProperty: targetLinePulseStartDist
    /// </summary>
    public unsafe float targetLinePulseStartDist
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 6844); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6844); }
    }

    /// <summary>
    /// FloatProperty: targetLinePulsePeriod_Max
    /// </summary>
    public unsafe float targetLinePulsePeriod_Max
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 6848); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6848); }
    }

    /// <summary>
    /// FloatProperty: targetLinePulsePeriod_Min
    /// </summary>
    public unsafe float targetLinePulsePeriod_Min
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 6852); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6852); }
    }

    /// <summary>
    /// StructProperty: DirectionalAnimNormal
    /// </summary>
    public unsafe System.Numerics.Vector3 DirectionalAnimNormal
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 6856); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6856); }
    }

    /// <summary>
    /// StructProperty: TiltVector
    /// </summary>
    public unsafe System.Numerics.Vector3 TiltVector
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 6868); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6868); }
    }

    /// <summary>
    /// FloatProperty: HorizontalRubberbandingPeriod
    /// </summary>
    public unsafe float HorizontalRubberbandingPeriod
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 6880); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6880); }
    }

    /// <summary>
    /// FloatProperty: MaxHorizontalAcceleration
    /// </summary>
    public unsafe float MaxHorizontalAcceleration
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 6884); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6884); }
    }

    /// <summary>
    /// FloatProperty: VerticalRubberbandingPeriod
    /// </summary>
    public unsafe float VerticalRubberbandingPeriod
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 6888); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6888); }
    }

    /// <summary>
    /// FloatProperty: MaxVerticalAcceleration
    /// </summary>
    public unsafe float MaxVerticalAcceleration
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 6892); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6892); }
    }

    /// <summary>
    /// StructProperty: currentAcceleration
    /// </summary>
    public unsafe System.Numerics.Vector3 currentAcceleration
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 6896); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6896); }
    }

    /// <summary>
    /// StructProperty: currentFlightVelocity
    /// </summary>
    public unsafe System.Numerics.Vector3 currentFlightVelocity
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 6908); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6908); }
    }

    /// <summary>
    /// FloatProperty: timeWhenEnergyRanOut
    /// </summary>
    public unsafe float timeWhenEnergyRanOut
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 6920); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6920); }
    }

    /// <summary>
    /// FloatProperty: rollRateCurrent
    /// </summary>
    public unsafe float rollRateCurrent
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 6924); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6924); }
    }

    /// <summary>
    /// FloatProperty: rollRateMax
    /// </summary>
    public unsafe float rollRateMax
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 6928); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6928); }
    }

    /// <summary>
    /// FloatProperty: rollRateTimeTillMax
    /// </summary>
    public unsafe float rollRateTimeTillMax
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 6932); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6932); }
    }

    /// <summary>
    /// FloatProperty: turnAnimRateOfChange
    /// </summary>
    public unsafe float turnAnimRateOfChange
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 6936); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6936); }
    }

    /// <summary>
    /// FloatProperty: rollAnimMultiplier
    /// </summary>
    public unsafe float rollAnimMultiplier
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 6940); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6940); }
    }

    /// <summary>
    /// FloatProperty: codeRollMaxDeg
    /// </summary>
    public unsafe float codeRollMaxDeg
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 6944); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6944); }
    }

    /// <summary>
    /// FloatProperty: yawChangeRate
    /// </summary>
    public unsafe float yawChangeRate
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 6948); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6948); }
    }

    /// <summary>
    /// FloatProperty: animForwardMin
    /// </summary>
    public unsafe float animForwardMin
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 6952); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6952); }
    }

    /// <summary>
    /// FloatProperty: animForwardMax
    /// </summary>
    public unsafe float animForwardMax
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 6956); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6956); }
    }

    /// <summary>
    /// ArrayProperty: activeGrenades
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RProjectile_GrenadeBase> activeGrenades
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RProjectile_GrenadeBase>>(Ptr + 6960); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6960); }
    }

    /// <summary>
    /// FloatProperty: rotV2_DYawDegreesRequiredForMaxRoll
    /// </summary>
    public unsafe float rotV2_DYawDegreesRequiredForMaxRoll
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 6976); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6976); }
    }

    /// <summary>
    /// FloatProperty: rotV2_RollAccelTime
    /// </summary>
    public unsafe float rotV2_RollAccelTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 6980); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6980); }
    }

    /// <summary>
    /// FloatProperty: rotV2_RollDrivingYawRate
    /// </summary>
    public unsafe float rotV2_RollDrivingYawRate
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 6984); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6984); }
    }

    /// <summary>
    /// FloatProperty: rotV2_CurrentRollProportion
    /// </summary>
    public unsafe float rotV2_CurrentRollProportion
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 6988); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6988); }
    }

    /// <summary>
    /// FloatProperty: rotV2_TargetRollProportion
    /// </summary>
    public unsafe float rotV2_TargetRollProportion
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 6992); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6992); }
    }

    /// <summary>
    /// FloatProperty: rotV2_CurrentRollRate
    /// </summary>
    public unsafe float rotV2_CurrentRollRate
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 6996); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6996); }
    }

    /// <summary>
    /// StructProperty: prevLoc
    /// </summary>
    public unsafe System.Numerics.Vector3 prevLoc
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 7000); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7000); }
    }

    /// <summary>
    /// FloatProperty: minSmokeSpawnRate
    /// </summary>
    public unsafe float minSmokeSpawnRate
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 7012); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7012); }
    }

    /// <summary>
    /// FloatProperty: maxSmokeRateVelocity
    /// </summary>
    public unsafe float maxSmokeRateVelocity
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 7016); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7016); }
    }

    /// <summary>
    /// FloatProperty: prevFrameVelocity
    /// </summary>
    public unsafe float prevFrameVelocity
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 7020); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7020); }
    }

    /// <summary>
    /// FloatProperty: currentSmokeSpawnRate
    /// </summary>
    public unsafe float currentSmokeSpawnRate
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 7024); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7024); }
    }

    /// <summary>
    /// FloatProperty: lastBoostEffectTriggerTime
    /// </summary>
    public unsafe float lastBoostEffectTriggerTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 7028); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7028); }
    }

    /// <summary>
    /// FloatProperty: boostProportion
    /// </summary>
    public unsafe float boostProportion
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 7032); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7032); }
    }

    /// <summary>
    /// FloatProperty: prevBoostProportion
    /// </summary>
    public unsafe float prevBoostProportion
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 7036); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7036); }
    }

    /// <summary>
    /// FloatProperty: boostParamVal
    /// </summary>
    public unsafe float boostParamVal
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 7040); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7040); }
    }

    /// <summary>
    /// FloatProperty: boostParamMax
    /// </summary>
    public unsafe float boostParamMax
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 7044); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7044); }
    }

    /// <summary>
    /// FloatProperty: boostParamScale
    /// </summary>
    public unsafe float boostParamScale
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 7048); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7048); }
    }

    /// <summary>
    /// FloatProperty: boostEffectThreshold
    /// </summary>
    public unsafe float boostEffectThreshold
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 7052); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7052); }
    }

    /// <summary>
    /// FloatProperty: boostEffectDuration
    /// </summary>
    public unsafe float boostEffectDuration
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 7056); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7056); }
    }

    /// <summary>
    /// FloatProperty: minTimeBetweenBoostEffects
    /// </summary>
    public unsafe float minTimeBetweenBoostEffects
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 7060); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7060); }
    }

    /// <summary>
    /// FloatProperty: energyShrinkPeriod
    /// </summary>
    public unsafe float energyShrinkPeriod
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 7064); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7064); }
    }

    /// <summary>
    /// FloatProperty: energyProportion
    /// </summary>
    public unsafe float energyProportion
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 7068); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7068); }
    }

    /// <summary>
    /// FloatProperty: smokeFuelLevel
    /// </summary>
    public unsafe float smokeFuelLevel
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 7072); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7072); }
    }
}
