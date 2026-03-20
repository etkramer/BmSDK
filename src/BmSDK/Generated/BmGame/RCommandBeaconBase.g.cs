#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RCommandBeaconBase<br/>
/// (flags = 0)
/// </summary>
public partial class RCommandBeaconBase : BmSDK.BmGame.RSpecialMoveEnvironmentObject, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RCommandBeaconBase", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RCommandBeaconBase() { }

    /// <summary>
    /// Constructs a new RCommandBeaconBase
    /// </summary>
    public RCommandBeaconBase(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RCommandBeaconBase Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RCommandBeaconBase(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="Engine.Actor.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RCommandBeaconBase>
        => ((Engine.Actor)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="Engine.Actor.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RCommandBeaconBase>, new()
        => (TComponent)((Engine.Actor)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="Engine.Actor.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RCommandBeaconBase>
        => ((Engine.Actor)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="Engine.Actor.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RCommandBeaconBase>
        => ((Engine.Actor)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="Engine.Actor.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RCommandBeaconBase>
        => (TComponent)((Engine.Actor)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="Engine.Actor.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RCommandBeaconBase>
        => ((Engine.Actor)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="Engine.Actor.DetachScriptComponent(Type)"/>
    public void DetachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RCommandBeaconBase>
        => ((Engine.Actor)this).DetachScriptComponent(typeof(TComponent));

    /// <summary>
    /// ComponentProperty: Mesh
    /// </summary>
    public unsafe BmSDK.Engine.SkeletalMeshComponent Mesh
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.SkeletalMeshComponent>(Ptr + 696); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 696); }
    }

    /// <summary>
    /// ObjectProperty: SeqAct
    /// </summary>
    public unsafe BmSDK.BmGame.RSeqAct_CommandBeacon SeqAct
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSeqAct_CommandBeacon>(Ptr + 704); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 704); }
    }

    /// <summary>
    /// ObjectProperty: AudioDestroySound
    /// </summary>
    public unsafe BmSDK.Engine.AkEvent AudioDestroySound
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkEvent>(Ptr + 712); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 712); }
    }

    /// <summary>
    /// ObjectProperty: AudioLightBrightnessParam
    /// </summary>
    public unsafe BmSDK.Engine.AkParameterName AudioLightBrightnessParam
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkParameterName>(Ptr + 720); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 720); }
    }

    /// <summary>
    /// ObjectProperty: InteractMove
    /// </summary>
    public unsafe BmSDK.BmGame.RSpecialMoveConfig InteractMove
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveConfig>(Ptr + 728); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 728); }
    }

    /// <summary>
    /// ObjectProperty: BeaconAsset
    /// </summary>
    public unsafe BmSDK.BmGame.RBeaconAsset BeaconAsset
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RBeaconAsset>(Ptr + 736); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 736); }
    }

    /// <summary>
    /// ObjectProperty: combatAreaCentreActor
    /// </summary>
    public unsafe BmSDK.Engine.Actor combatAreaCentreActor
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.Actor>(Ptr + 744); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 744); }
    }

    /// <summary>
    /// ObjectProperty: DialogueTriggerEvent
    /// </summary>
    public unsafe BmSDK.BmGame.RSeqEvent_CommandBeaconDialogueTrigger DialogueTriggerEvent
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSeqEvent_CommandBeaconDialogueTrigger>(Ptr + 752); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 752); }
    }

    /// <summary>
    /// ObjectProperty: RPC
    /// </summary>
    public unsafe BmSDK.BmGame.RPlayerController RPC
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPlayerController>(Ptr + 760); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 760); }
    }

    /// <summary>
    /// ObjectProperty: XrayMat
    /// </summary>
    public unsafe BmSDK.Engine.MaterialInterface XrayMat
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.MaterialInterface>(Ptr + 768); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 768); }
    }

    /// <summary>
    /// ObjectProperty: virusUploadStartSound
    /// </summary>
    public unsafe BmSDK.Engine.AkEvent virusUploadStartSound
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkEvent>(Ptr + 776); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 776); }
    }

    /// <summary>
    /// ObjectProperty: virusUploadFailSound
    /// </summary>
    public unsafe BmSDK.Engine.AkEvent virusUploadFailSound
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkEvent>(Ptr + 784); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 784); }
    }

    /// <summary>
    /// ObjectProperty: virusUploadSuccessSound
    /// </summary>
    public unsafe BmSDK.Engine.AkEvent virusUploadSuccessSound
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkEvent>(Ptr + 792); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 792); }
    }

    /// <summary>
    /// ObjectProperty: timerBeep
    /// </summary>
    public unsafe BmSDK.Engine.AkEvent timerBeep
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkEvent>(Ptr + 800); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 800); }
    }

    /// <summary>
    /// ObjectProperty: GaugesActor
    /// </summary>
    public unsafe BmSDK.Engine.SkeletalMeshActor GaugesActor
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.SkeletalMeshActor>(Ptr + 808); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 808); }
    }

    /// <summary>
    /// ObjectProperty: PowerStartEvent
    /// </summary>
    public unsafe BmSDK.Engine.AkEvent PowerStartEvent
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkEvent>(Ptr + 816); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 816); }
    }

    /// <summary>
    /// ObjectProperty: VehiclePowerStartEvent
    /// </summary>
    public unsafe BmSDK.Engine.AkEvent VehiclePowerStartEvent
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkEvent>(Ptr + 824); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 824); }
    }

    /// <summary>
    /// ObjectProperty: PowerRevsParamName
    /// </summary>
    public unsafe BmSDK.Engine.AkParameterName PowerRevsParamName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkParameterName>(Ptr + 832); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 832); }
    }

    /// <summary>
    /// ObjectProperty: RevsController
    /// </summary>
    public unsafe BmSDK.BmGame.RPlayerController RevsController
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPlayerController>(Ptr + 840); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 840); }
    }

    /// <summary>
    /// ObjectProperty: GuagesMat
    /// </summary>
    public unsafe BmSDK.Engine.MaterialInstanceConstant GuagesMat
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.MaterialInstanceConstant>(Ptr + 848); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 848); }
    }

    /// <summary>
    /// ObjectProperty: AttachedToWinch
    /// </summary>
    public unsafe BmSDK.BmGame.RBatmobileWinch AttachedToWinch
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RBatmobileWinch>(Ptr + 856); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 856); }
    }

    /// <summary>
    /// ObjectProperty: AnimNode
    /// </summary>
    public unsafe BmSDK.Engine.AnimNodeSequence AnimNode
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AnimNodeSequence>(Ptr + 864); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 864); }
    }

    /// <summary>
    /// ObjectProperty: AttackParticleSystem
    /// </summary>
    public unsafe BmSDK.Engine.ParticleSystem AttackParticleSystem
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleSystem>(Ptr + 872); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 872); }
    }

    /// <summary>
    /// ObjectProperty: AttackSound
    /// </summary>
    public unsafe BmSDK.Engine.AkEvent AttackSound
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkEvent>(Ptr + 880); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 880); }
    }

    /// <summary>
    /// ObjectProperty: lightsArchetype
    /// </summary>
    public unsafe BmSDK.BmGame.RCommandBeaconLightsBase lightsArchetype
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RCommandBeaconLightsBase>(Ptr + 888); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 888); }
    }

    /// <summary>
    /// ObjectProperty: lightsInstance
    /// </summary>
    public unsafe BmSDK.BmGame.RCommandBeaconLightsBase lightsInstance
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RCommandBeaconLightsBase>(Ptr + 896); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 896); }
    }

    /// <summary>
    /// ObjectProperty: ExplodeRumble
    /// </summary>
    public unsafe BmSDK.Engine.ForceFeedbackWaveform ExplodeRumble
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ForceFeedbackWaveform>(Ptr + 904); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 904); }
    }

    /// <summary>
    /// ComponentProperty: AttackParticleSystem_Mine
    /// </summary>
    public unsafe BmSDK.Engine.ParticleSystemComponent AttackParticleSystem_Mine
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleSystemComponent>(Ptr + 912); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 912); }
    }

    /// <summary>
    /// ComponentProperty: ElectricityEffectComp
    /// </summary>
    public unsafe BmSDK.Engine.ParticleSystemComponent ElectricityEffectComp
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleSystemComponent>(Ptr + 920); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 920); }
    }

    /// <summary>
    /// ComponentProperty: FailExplosionVFX_x
    /// </summary>
    public unsafe BmSDK.Engine.ParticleSystemComponent FailExplosionVFX_x
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleSystemComponent>(Ptr + 928); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 928); }
    }

    /// <summary>
    /// ComponentProperty: ControlledExplosionVFX_x
    /// </summary>
    public unsafe BmSDK.Engine.ParticleSystemComponent ControlledExplosionVFX_x
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleSystemComponent>(Ptr + 936); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 936); }
    }

    /// <summary>
    /// ComponentProperty: smokeVFX
    /// </summary>
    public unsafe BmSDK.Engine.ParticleSystemComponent smokeVFX
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleSystemComponent>(Ptr + 944); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 944); }
    }

    /// <summary>
    /// ComponentProperty: radiusVFX
    /// </summary>
    public unsafe BmSDK.Engine.ParticleSystemComponent radiusVFX
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleSystemComponent>(Ptr + 952); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 952); }
    }

    /// <summary>
    /// FloatProperty: overrideFailDist
    /// </summary>
    public unsafe float overrideFailDist
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 960); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 960); }
    }

    /// <summary>
    /// FloatProperty: abandonTime
    /// </summary>
    public unsafe float abandonTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 964); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 964); }
    }

    /// <summary>
    /// FloatProperty: abandonTimeRemaining
    /// </summary>
    public unsafe float abandonTimeRemaining
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 968); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 968); }
    }

    /// <summary>
    /// FloatProperty: MinPeriodBetweenDialogue
    /// </summary>
    public unsafe float MinPeriodBetweenDialogue
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 972); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 972); }
    }

    /// <summary>
    /// BoolProperty: bSkipSpecialMove
    /// </summary>
    public unsafe bool bSkipSpecialMove
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 976) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 976); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 976); }
    }

    /// <summary>
    /// BoolProperty: bDrawDebug
    /// </summary>
    public unsafe bool bDrawDebug
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 976) & 2) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 976); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 976); }
    }

    /// <summary>
    /// BoolProperty: SideStory
    /// </summary>
    public unsafe bool SideStory
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 976) & 4) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 976); var newMask = value ? (currentMask | 4) : (currentMask & ~4); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 976); }
    }

    /// <summary>
    /// BoolProperty: bCanTriggerReinforcements
    /// </summary>
    public unsafe bool bCanTriggerReinforcements
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 976) & 8) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 976); var newMask = value ? (currentMask | 8) : (currentMask & ~8); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 976); }
    }

    /// <summary>
    /// BoolProperty: bInteractedWaitingForVirus
    /// </summary>
    public unsafe bool bInteractedWaitingForVirus
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 976) & 16) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 976); var newMask = value ? (currentMask | 16) : (currentMask & ~16); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 976); }
    }

    /// <summary>
    /// BoolProperty: bCanDetectPlayer
    /// </summary>
    public unsafe bool bCanDetectPlayer
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 976) & 32) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 976); var newMask = value ? (currentMask | 32) : (currentMask & ~32); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 976); }
    }

    /// <summary>
    /// BoolProperty: bNoPriorInteraction
    /// </summary>
    public unsafe bool bNoPriorInteraction
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 976) & 64) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 976); var newMask = value ? (currentMask | 64) : (currentMask & ~64); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 976); }
    }

    /// <summary>
    /// BoolProperty: bInteractDisabledByKismet
    /// </summary>
    public unsafe bool bInteractDisabledByKismet
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 976) & 128) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 976); var newMask = value ? (currentMask | 128) : (currentMask & ~128); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 976); }
    }

    /// <summary>
    /// BoolProperty: bLightBrightnessIncreasing
    /// </summary>
    public unsafe bool bLightBrightnessIncreasing
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 976) & 256) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 976); var newMask = value ? (currentMask | 256) : (currentMask & ~256); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 976); }
    }

    /// <summary>
    /// BoolProperty: bNeedToSetVirusHUDActive
    /// </summary>
    public unsafe bool bNeedToSetVirusHUDActive
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 976) & 512) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 976); var newMask = value ? (currentMask | 512) : (currentMask & ~512); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 976); }
    }

    /// <summary>
    /// BoolProperty: bNeedToSetVirusHUDComplete
    /// </summary>
    public unsafe bool bNeedToSetVirusHUDComplete
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 976) & 1024) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 976); var newMask = value ? (currentMask | 1024) : (currentMask & ~1024); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 976); }
    }

    /// <summary>
    /// BoolProperty: PoweredUp
    /// </summary>
    public unsafe bool PoweredUp
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 976) & 2048) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 976); var newMask = value ? (currentMask | 2048) : (currentMask & ~2048); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 976); }
    }

    /// <summary>
    /// BoolProperty: PowerRevsGlobal
    /// </summary>
    public unsafe bool PowerRevsGlobal
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 976) & 4096) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 976); var newMask = value ? (currentMask | 4096) : (currentMask & ~4096); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 976); }
    }

    /// <summary>
    /// BoolProperty: bWinchCustomButtonPressed
    /// </summary>
    public unsafe bool bWinchCustomButtonPressed
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 976) & 8192) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 976); var newMask = value ? (currentMask | 8192) : (currentMask & ~8192); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 976); }
    }

    /// <summary>
    /// BoolProperty: bNeedsToPowerDownIfBMBLNearby
    /// </summary>
    public unsafe bool bNeedsToPowerDownIfBMBLNearby
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 976) & 16384) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 976); var newMask = value ? (currentMask | 16384) : (currentMask & ~16384); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 976); }
    }

    /// <summary>
    /// BoolProperty: bmblWasInRange
    /// </summary>
    public unsafe bool bmblWasInRange
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 976) & 32768) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 976); var newMask = value ? (currentMask | 32768) : (currentMask & ~32768); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 976); }
    }

    /// <summary>
    /// BoolProperty: winchInteractionsAttached
    /// </summary>
    public unsafe bool winchInteractionsAttached
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 976) & 65536) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 976); var newMask = value ? (currentMask | 65536) : (currentMask & ~65536); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 976); }
    }

    /// <summary>
    /// BoolProperty: winchingAllowedByBeacon
    /// </summary>
    public unsafe bool winchingAllowedByBeacon
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 976) & 131072) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 976); var newMask = value ? (currentMask | 131072) : (currentMask & ~131072); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 976); }
    }

    /// <summary>
    /// BoolProperty: bHasStartedBlockingBMBLMovement
    /// </summary>
    public unsafe bool bHasStartedBlockingBMBLMovement
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 976) & 262144) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 976); var newMask = value ? (currentMask | 262144) : (currentMask & ~262144); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 976); }
    }

    /// <summary>
    /// BoolProperty: bKismetStoppedBlockingBMBLMovement
    /// </summary>
    public unsafe bool bKismetStoppedBlockingBMBLMovement
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 976) & 524288) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 976); var newMask = value ? (currentMask | 524288) : (currentMask & ~524288); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 976); }
    }

    /// <summary>
    /// StrProperty: DifficultyString
    /// </summary>
    public unsafe BmSDK.FString DifficultyString
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 980); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 980); }
    }

    /// <summary>
    /// FloatProperty: HUDElementVisRange
    /// </summary>
    public unsafe float HUDElementVisRange
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 996); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 996); }
    }

    /// <summary>
    /// IntProperty: Difficulty_One_To_Five
    /// </summary>
    public unsafe int Difficulty_One_To_Five
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1000); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1000); }
    }

    /// <summary>
    /// FloatProperty: BMBLOutOfBoundsDistance
    /// </summary>
    public unsafe float BMBLOutOfBoundsDistance
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1004); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1004); }
    }

    /// <summary>
    /// ByteProperty: beaconState
    /// </summary>
    public unsafe BmSDK.BmGame.RCommandBeaconBase.eCommandBeaconState beaconState
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RCommandBeaconBase.eCommandBeaconState>(Ptr + 1008); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1008); }
    }

    /// <summary>
    /// ByteProperty: previousBeaconState
    /// </summary>
    public unsafe BmSDK.BmGame.RCommandBeaconBase.eCommandBeaconState previousBeaconState
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RCommandBeaconBase.eCommandBeaconState>(Ptr + 1009); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1009); }
    }

    /// <summary>
    /// ByteProperty: MostRecentDialogueEnum
    /// </summary>
    public unsafe BmSDK.BmGame.RSeqEvent_CommandBeaconDialogueTrigger.CommandBeaconDialogue MostRecentDialogueEnum
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSeqEvent_CommandBeaconDialogueTrigger.CommandBeaconDialogue>(Ptr + 1010); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1010); }
    }

    /// <summary>
    /// FloatProperty: BMBLDist
    /// </summary>
    public unsafe float BMBLDist
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1012); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1012); }
    }

    /// <summary>
    /// FloatProperty: prevBMBLDist
    /// </summary>
    public unsafe float prevBMBLDist
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1016); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1016); }
    }

    /// <summary>
    /// FloatProperty: LastDialogueTime
    /// </summary>
    public unsafe float LastDialogueTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1020); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1020); }
    }

    /// <summary>
    /// FloatProperty: bLightPulsePeriod_idle
    /// </summary>
    public unsafe float bLightPulsePeriod_idle
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1024); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1024); }
    }

    /// <summary>
    /// FloatProperty: bLightPulsePeriod_active
    /// </summary>
    public unsafe float bLightPulsePeriod_active
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1028); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1028); }
    }

    /// <summary>
    /// FloatProperty: LightBrightness
    /// </summary>
    public unsafe float LightBrightness
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1032); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1032); }
    }

    /// <summary>
    /// FloatProperty: radiusVFXInitialSize
    /// </summary>
    public unsafe float radiusVFXInitialSize
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1036); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1036); }
    }

    /// <summary>
    /// FloatProperty: LastHUDTimerDrawTime
    /// </summary>
    public unsafe float LastHUDTimerDrawTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1040); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1040); }
    }

    /// <summary>
    /// StrProperty: everInteractedFlag
    /// </summary>
    public unsafe BmSDK.FString everInteractedFlag
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 1044); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1044); }
    }

    /// <summary>
    /// IntProperty: prevRemainingTime
    /// </summary>
    public unsafe int prevRemainingTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1060); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1060); }
    }

    /// <summary>
    /// IntProperty: GaugeMaterialIndex
    /// </summary>
    public unsafe int GaugeMaterialIndex
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1064); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1064); }
    }

    /// <summary>
    /// NameProperty: GaugePowerInputName
    /// </summary>
    public unsafe BmSDK.FName GaugePowerInputName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 1068); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1068); }
    }

    /// <summary>
    /// NameProperty: GaugePowerOutputName
    /// </summary>
    public unsafe BmSDK.FName GaugePowerOutputName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 1076); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1076); }
    }

    /// <summary>
    /// FloatProperty: RevsMultiplier
    /// </summary>
    public unsafe float RevsMultiplier
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1084); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1084); }
    }

    /// <summary>
    /// FloatProperty: MaxRevs
    /// </summary>
    public unsafe float MaxRevs
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1088); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1088); }
    }

    /// <summary>
    /// FloatProperty: MaxRevsHoldTime
    /// </summary>
    public unsafe float MaxRevsHoldTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1092); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1092); }
    }

    /// <summary>
    /// FloatProperty: RevsDeltaLimit
    /// </summary>
    public unsafe float RevsDeltaLimit
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1096); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1096); }
    }

    /// <summary>
    /// FloatProperty: RevsVelLimit
    /// </summary>
    public unsafe float RevsVelLimit
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1100); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1100); }
    }

    /// <summary>
    /// FloatProperty: CurrentRevs
    /// </summary>
    public unsafe float CurrentRevs
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1104); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1104); }
    }

    /// <summary>
    /// FloatProperty: CurrentRevsVel
    /// </summary>
    public unsafe float CurrentRevsVel
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1108); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1108); }
    }

    /// <summary>
    /// FloatProperty: CurrentMaxRevsTime
    /// </summary>
    public unsafe float CurrentMaxRevsTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1112); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1112); }
    }

    /// <summary>
    /// FloatProperty: InputRevs
    /// </summary>
    public unsafe float InputRevs
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1116); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1116); }
    }

    /// <summary>
    /// StructProperty: WinchAttachLoc
    /// </summary>
    public unsafe System.Numerics.Vector3 WinchAttachLoc
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 1120); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1120); }
    }

    /// <summary>
    /// FloatProperty: winchInitiationDuration
    /// </summary>
    public unsafe float winchInitiationDuration
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1132); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1132); }
    }

    /// <summary>
    /// FloatProperty: winchCustomButtonPressTime
    /// </summary>
    public unsafe float winchCustomButtonPressTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1136); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1136); }
    }

    /// <summary>
    /// StrProperty: focusDetailString
    /// </summary>
    public unsafe BmSDK.FString focusDetailString
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 1140); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1140); }
    }

    /// <summary>
    /// NameProperty: coreExposeAnimName
    /// </summary>
    public unsafe BmSDK.FName coreExposeAnimName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 1156); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1156); }
    }

    /// <summary>
    /// FloatProperty: timeTillCanAttack
    /// </summary>
    public unsafe float timeTillCanAttack
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1164); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1164); }
    }

    /// <summary>
    /// FloatProperty: MineRange
    /// </summary>
    public unsafe float MineRange
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1168); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1168); }
    }

    /// <summary>
    /// FloatProperty: MineDamage
    /// </summary>
    public unsafe float MineDamage
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1172); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1172); }
    }

    /// <summary>
    /// FloatProperty: MineImpulse
    /// </summary>
    public unsafe float MineImpulse
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1176); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1176); }
    }

    /// <summary>
    /// FloatProperty: TimeBetweenMineAttacks
    /// </summary>
    public unsafe float TimeBetweenMineAttacks
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1180); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1180); }
    }

    /// <summary>
    /// FloatProperty: friendlyRangeExtra
    /// </summary>
    public unsafe float friendlyRangeExtra
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1184); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1184); }
    }

    /// <summary>
    /// IntProperty: numForcedTicksNeeded
    /// </summary>
    public unsafe int numForcedTicksNeeded
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1188); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1188); }
    }
}
