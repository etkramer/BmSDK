#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmScript;

/// <summary>
/// Class: RPredatorDroneMini<br/>
/// (size = 0)
/// (flags = 0)
/// </summary>
public partial class RPredatorDroneMini : BmSDK.BmScript.RHelicopterIntermediate, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmScript.RPredatorDroneMini", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RPredatorDroneMini() { }

    /// <summary>
    /// Constructs a new RPredatorDroneMini
    /// </summary>
    public RPredatorDroneMini(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RPredatorDroneMini Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RPredatorDroneMini(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="Engine.Actor.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RPredatorDroneMini>
        => ((Engine.Actor)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="Engine.Actor.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RPredatorDroneMini>, new()
        => (TComponent)((Engine.Actor)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="Engine.Actor.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RPredatorDroneMini>
        => ((Engine.Actor)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="Engine.Actor.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RPredatorDroneMini>
        => ((Engine.Actor)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="Engine.Actor.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RPredatorDroneMini>
        => (TComponent)((Engine.Actor)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="Engine.Actor.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RPredatorDroneMini>
        => ((Engine.Actor)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="Engine.Actor.DetachScriptComponent(Type)"/>
    public void DetachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RPredatorDroneMini>
        => ((Engine.Actor)this).DetachScriptComponent(typeof(TComponent));

    /// <summary>
    /// ObjectProperty: m_hSpawner
    /// </summary>
    public unsafe BmSDK.BmScript.RSeqAct_SpawnDrone m_hSpawner
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmScript.RSeqAct_SpawnDrone>(Ptr + 3148); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3148); }
    }

    /// <summary>
    /// ObjectProperty: m_hController
    /// </summary>
    public unsafe BmSDK.BmScript.RPawnVillainGunMiniDroneController m_hController
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmScript.RPawnVillainGunMiniDroneController>(Ptr + 3156); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3156); }
    }

    /// <summary>
    /// ObjectProperty: m_hArkhamKnightController
    /// </summary>
    public unsafe BmSDK.BmGame.RPawnVillainGunPredBase m_hArkhamKnightController
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPawnVillainGunPredBase>(Ptr + 3164); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3164); }
    }

    /// <summary>
    /// ObjectProperty: m_hBehaviorMeanderPatrolPoint
    /// </summary>
    public unsafe BmSDK.BmGame.RPatrolPoint m_hBehaviorMeanderPatrolPoint
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPatrolPoint>(Ptr + 3172); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3172); }
    }

    /// <summary>
    /// ObjectProperty: m_hBehaviorInvestigateTarget
    /// </summary>
    public unsafe BmSDK.Engine.Actor m_hBehaviorInvestigateTarget
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.Actor>(Ptr + 3180); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3180); }
    }

    /// <summary>
    /// ObjectProperty: m_XrayMIC_Normal
    /// </summary>
    public unsafe BmSDK.Engine.MaterialInstanceConstant m_XrayMIC_Normal
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.MaterialInstanceConstant>(Ptr + 3188); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3188); }
    }

    /// <summary>
    /// ObjectProperty: m_XrayMIC_Disrupted
    /// </summary>
    public unsafe BmSDK.Engine.MaterialInstanceConstant m_XrayMIC_Disrupted
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.MaterialInstanceConstant>(Ptr + 3196); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3196); }
    }

    /// <summary>
    /// ObjectProperty: m_XrayMIC_Blinded
    /// </summary>
    public unsafe BmSDK.Engine.MaterialInstanceConstant m_XrayMIC_Blinded
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.MaterialInstanceConstant>(Ptr + 3204); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3204); }
    }

    /// <summary>
    /// ObjectProperty: m_hCodesHaventBeenDownloadedYetThought
    /// </summary>
    public unsafe BmSDK.Engine.AkDialogueSpeech m_hCodesHaventBeenDownloadedYetThought
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkDialogueSpeech>(Ptr + 3212); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3212); }
    }

    /// <summary>
    /// ObjectProperty: m_hSearchLightSpecifiedTarget
    /// </summary>
    public unsafe BmSDK.Engine.Actor m_hSearchLightSpecifiedTarget
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.Actor>(Ptr + 3220); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3220); }
    }

    /// <summary>
    /// ObjectProperty: m_ExplosionCachedTargetClass
    /// </summary>
    public unsafe BmSDK.Engine.RInteractionClass m_ExplosionCachedTargetClass
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RInteractionClass>(Ptr + 3228); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3228); }
    }

    /// <summary>
    /// ObjectProperty: AudioMovementLoopingEvent
    /// </summary>
    public unsafe BmSDK.Engine.AkEvent AudioMovementLoopingEvent
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkEvent>(Ptr + 3236); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3236); }
    }

    /// <summary>
    /// ObjectProperty: AudioDestroyEvent
    /// </summary>
    public unsafe BmSDK.Engine.AkEvent AudioDestroyEvent
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkEvent>(Ptr + 3244); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3244); }
    }

    /// <summary>
    /// ObjectProperty: AudioElectrocuteLoopingEvent
    /// </summary>
    public unsafe BmSDK.Engine.AkEvent AudioElectrocuteLoopingEvent
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkEvent>(Ptr + 3252); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3252); }
    }

    /// <summary>
    /// ObjectProperty: AudioAlarm
    /// </summary>
    public unsafe BmSDK.Engine.AkEvent AudioAlarm
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkEvent>(Ptr + 3260); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3260); }
    }

    /// <summary>
    /// ObjectProperty: ZapClosePlayerSound
    /// </summary>
    public unsafe BmSDK.Engine.AkEvent ZapClosePlayerSound
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkEvent>(Ptr + 3268); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3268); }
    }

    /// <summary>
    /// ComponentProperty: m_MiniDroneToControllerLinePSC
    /// </summary>
    public unsafe BmSDK.Engine.ParticleSystemComponent m_MiniDroneToControllerLinePSC
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleSystemComponent>(Ptr + 3276); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3276); }
    }

    /// <summary>
    /// ComponentProperty: RHDInteractions
    /// </summary>
    public unsafe BmSDK.Engine.RInteractionComponent RHDInteractions
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RInteractionComponent>(Ptr + 3284); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3284); }
    }

    /// <summary>
    /// ComponentProperty: m_hElectricShield
    /// </summary>
    public unsafe BmSDK.Engine.ParticleSystemComponent m_hElectricShield
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleSystemComponent>(Ptr + 3292); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3292); }
    }

    /// <summary>
    /// ComponentProperty: m_hWeaponFlareEffect
    /// </summary>
    public unsafe BmSDK.Engine.ParticleSystemComponent m_hWeaponFlareEffect
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleSystemComponent>(Ptr + 3300); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3300); }
    }

    /// <summary>
    /// ComponentProperty: m_hWeaponPowerUpEffect
    /// </summary>
    public unsafe BmSDK.Engine.ParticleSystemComponent m_hWeaponPowerUpEffect
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleSystemComponent>(Ptr + 3308); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3308); }
    }

    /// <summary>
    /// BoolProperty: m_bBehaviorMeanderReturnToPath
    /// </summary>
    public unsafe bool m_bBehaviorMeanderReturnToPath
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3316) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3316); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3316); }
    }

    /// <summary>
    /// BoolProperty: m_bBehaviorPursueAllowFreeForm
    /// </summary>
    public unsafe bool m_bBehaviorPursueAllowFreeForm
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3316) & 2) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3316); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3316); }
    }

    /// <summary>
    /// BoolProperty: m_bBehaviorPursueTargetsAlertPlayerToRoom
    /// </summary>
    public unsafe bool m_bBehaviorPursueTargetsAlertPlayerToRoom
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3316) & 4) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3316); var newMask = value ? (currentMask | 4) : (currentMask & ~4); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3316); }
    }

    /// <summary>
    /// BoolProperty: m_bBehaviorPursueTargetsAlertSoundPlayed
    /// </summary>
    public unsafe bool m_bBehaviorPursueTargetsAlertSoundPlayed
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3316) & 8) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3316); var newMask = value ? (currentMask | 8) : (currentMask & ~8); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3316); }
    }

    /// <summary>
    /// BoolProperty: m_bBehaviorAttackAllTargets
    /// </summary>
    public unsafe bool m_bBehaviorAttackAllTargets
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3316) & 16) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3316); var newMask = value ? (currentMask | 16) : (currentMask & ~16); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3316); }
    }

    /// <summary>
    /// BoolProperty: m_bBehaviorAttackThenSelfDestruct
    /// </summary>
    public unsafe bool m_bBehaviorAttackThenSelfDestruct
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3316) & 32) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3316); var newMask = value ? (currentMask | 32) : (currentMask & ~32); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3316); }
    }

    /// <summary>
    /// BoolProperty: m_bBehaviorAttackPoweredUp
    /// </summary>
    public unsafe bool m_bBehaviorAttackPoweredUp
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3316) & 64) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3316); var newMask = value ? (currentMask | 64) : (currentMask & ~64); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3316); }
    }

    /// <summary>
    /// BoolProperty: m_bBehaviorAttackRoomNotified
    /// </summary>
    public unsafe bool m_bBehaviorAttackRoomNotified
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3316) & 128) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3316); var newMask = value ? (currentMask | 128) : (currentMask & ~128); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3316); }
    }

    /// <summary>
    /// BoolProperty: m_bBehaviorMeanderKeepAllTargets
    /// </summary>
    public unsafe bool m_bBehaviorMeanderKeepAllTargets
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3316) & 256) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3316); var newMask = value ? (currentMask | 256) : (currentMask & ~256); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3316); }
    }

    /// <summary>
    /// BoolProperty: m_bBehaviorArrivedAtInvestigateLocation
    /// </summary>
    public unsafe bool m_bBehaviorArrivedAtInvestigateLocation
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3316) & 512) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3316); var newMask = value ? (currentMask | 512) : (currentMask & ~512); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3316); }
    }

    /// <summary>
    /// BoolProperty: m_bMovementPursueFreeForm
    /// </summary>
    public unsafe bool m_bMovementPursueFreeForm
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3316) & 1024) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3316); var newMask = value ? (currentMask | 1024) : (currentMask & ~1024); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3316); }
    }

    /// <summary>
    /// BoolProperty: m_bMovementMalfunctionVibrateCycle
    /// </summary>
    public unsafe bool m_bMovementMalfunctionVibrateCycle
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3316) & 2048) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3316); var newMask = value ? (currentMask | 2048) : (currentMask & ~2048); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3316); }
    }

    /// <summary>
    /// BoolProperty: m_bCodesDownloaded
    /// </summary>
    public unsafe bool m_bCodesDownloaded
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3316) & 4096) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3316); var newMask = value ? (currentMask | 4096) : (currentMask & ~4096); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3316); }
    }

    /// <summary>
    /// BoolProperty: m_bCanSelfDestruct
    /// </summary>
    public unsafe bool m_bCanSelfDestruct
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3316) & 8192) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3316); var newMask = value ? (currentMask | 8192) : (currentMask & ~8192); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3316); }
    }

    /// <summary>
    /// BoolProperty: m_bNeverTargetPlayer
    /// </summary>
    public unsafe bool m_bNeverTargetPlayer
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3316) & 16384) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3316); var newMask = value ? (currentMask | 16384) : (currentMask & ~16384); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3316); }
    }

    /// <summary>
    /// BoolProperty: bDeliberatelyAbandoned
    /// </summary>
    public unsafe bool bDeliberatelyAbandoned
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3316) & 32768) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3316); var newMask = value ? (currentMask | 32768) : (currentMask & ~32768); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3316); }
    }

    /// <summary>
    /// BoolProperty: m_bInDetectiveMode
    /// </summary>
    public unsafe bool m_bInDetectiveMode
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3316) & 65536) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3316); var newMask = value ? (currentMask | 65536) : (currentMask & ~65536); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3316); }
    }

    /// <summary>
    /// BoolProperty: m_bRHDTarget
    /// </summary>
    public unsafe bool m_bRHDTarget
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3316) & 131072) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3316); var newMask = value ? (currentMask | 131072) : (currentMask & ~131072); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3316); }
    }

    /// <summary>
    /// BoolProperty: m_bMiniDroneToControllerLineActive
    /// </summary>
    public unsafe bool m_bMiniDroneToControllerLineActive
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3316) & 262144) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3316); var newMask = value ? (currentMask | 262144) : (currentMask & ~262144); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3316); }
    }

    /// <summary>
    /// BoolProperty: m_bMiniDroneToControllerLineInDetectiveMode
    /// </summary>
    public unsafe bool m_bMiniDroneToControllerLineInDetectiveMode
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3316) & 524288) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3316); var newMask = value ? (currentMask | 524288) : (currentMask & ~524288); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3316); }
    }

    /// <summary>
    /// BoolProperty: m_bSpecialTutorialMiniDrone
    /// </summary>
    public unsafe bool m_bSpecialTutorialMiniDrone
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3316) & 1048576) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3316); var newMask = value ? (currentMask | 1048576) : (currentMask & ~1048576); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3316); }
    }

    /// <summary>
    /// ByteProperty: m_eBehaviorStunnedSource
    /// </summary>
    public unsafe BmSDK.BmScript.RPredatorDroneMini.MalfunctionSource m_eBehaviorStunnedSource
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmScript.RPredatorDroneMini.MalfunctionSource>(Ptr + 3320); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3320); }
    }

    /// <summary>
    /// ByteProperty: m_eSearchLightTargetMode
    /// </summary>
    public unsafe BmSDK.BmScript.RPredatorDroneMini.SearchLightTargetMode m_eSearchLightTargetMode
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmScript.RPredatorDroneMini.SearchLightTargetMode>(Ptr + 3321); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3321); }
    }

    /// <summary>
    /// FloatProperty: m_fBehaviorPursueTargetsAttackDelay
    /// </summary>
    public unsafe float m_fBehaviorPursueTargetsAttackDelay
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 3324); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3324); }
    }

    /// <summary>
    /// FloatProperty: m_fBehaviorAttackPowerUpTime
    /// </summary>
    public unsafe float m_fBehaviorAttackPowerUpTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 3328); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3328); }
    }

    /// <summary>
    /// FloatProperty: m_fBehaviorAttackWeaponTime
    /// </summary>
    public unsafe float m_fBehaviorAttackWeaponTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 3332); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3332); }
    }

    /// <summary>
    /// FloatProperty: m_fBehaviorInvestigateLocationTime
    /// </summary>
    public unsafe float m_fBehaviorInvestigateLocationTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 3336); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3336); }
    }

    /// <summary>
    /// StructProperty: m_vMovementMeanderSourcePosition
    /// </summary>
    public unsafe System.Numerics.Vector3 m_vMovementMeanderSourcePosition
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 3340); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3340); }
    }

    /// <summary>
    /// StructProperty: m_vMovementMeanderOffsetPosition
    /// </summary>
    public unsafe System.Numerics.Vector3 m_vMovementMeanderOffsetPosition
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 3352); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3352); }
    }

    /// <summary>
    /// StructProperty: m_vMovementMeanderFacingDirection
    /// </summary>
    public unsafe System.Numerics.Vector3 m_vMovementMeanderFacingDirection
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 3364); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3364); }
    }

    /// <summary>
    /// FloatProperty: m_fMovementMeanderFacingTime
    /// </summary>
    public unsafe float m_fMovementMeanderFacingTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 3376); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3376); }
    }

    /// <summary>
    /// FloatProperty: m_fMovementMeanderDuration
    /// </summary>
    public unsafe float m_fMovementMeanderDuration
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 3380); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3380); }
    }

    /// <summary>
    /// StructProperty: m_vMovementPursueVantagePoint
    /// </summary>
    public unsafe System.Numerics.Vector3 m_vMovementPursueVantagePoint
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 3384); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3384); }
    }

    /// <summary>
    /// StructProperty: m_vMovementPursueVantageTarget
    /// </summary>
    public unsafe System.Numerics.Vector3 m_vMovementPursueVantageTarget
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 3396); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3396); }
    }

    /// <summary>
    /// StructProperty: m_vMovementPursueFacingDirection
    /// </summary>
    public unsafe System.Numerics.Vector3 m_vMovementPursueFacingDirection
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 3408); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3408); }
    }

    /// <summary>
    /// FloatProperty: m_fMovementPursueRePathTime
    /// </summary>
    public unsafe float m_fMovementPursueRePathTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 3420); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3420); }
    }

    /// <summary>
    /// StructProperty: m_vMovementUncontrolledStrayDirection
    /// </summary>
    public unsafe System.Numerics.Vector3 m_vMovementUncontrolledStrayDirection
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 3424); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3424); }
    }

    /// <summary>
    /// FloatProperty: m_fMovementUncontrolledStraySwagger
    /// </summary>
    public unsafe float m_fMovementUncontrolledStraySwagger
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 3436); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3436); }
    }

    /// <summary>
    /// FloatProperty: m_fMovementUncontrolledTime
    /// </summary>
    public unsafe float m_fMovementUncontrolledTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 3440); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3440); }
    }

    /// <summary>
    /// FloatProperty: m_fMovementUncontrolledVelocity
    /// </summary>
    public unsafe float m_fMovementUncontrolledVelocity
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 3444); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3444); }
    }

    /// <summary>
    /// FloatProperty: m_fMovementUncontrolledSwagger
    /// </summary>
    public unsafe float m_fMovementUncontrolledSwagger
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 3448); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3448); }
    }

    /// <summary>
    /// IntProperty: m_nMovementUncontrolledSpin
    /// </summary>
    public unsafe int m_nMovementUncontrolledSpin
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3452); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3452); }
    }

    /// <summary>
    /// StructProperty: m_vMovementMalfunctionOriginPosition
    /// </summary>
    public unsafe System.Numerics.Vector3 m_vMovementMalfunctionOriginPosition
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 3456); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3456); }
    }

    /// <summary>
    /// StructProperty: m_vMovementMalfunctionShiftPosition
    /// </summary>
    public unsafe System.Numerics.Vector3 m_vMovementMalfunctionShiftPosition
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 3468); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3468); }
    }

    /// <summary>
    /// FloatProperty: m_fMovementMalfunctionShiftAmount
    /// </summary>
    public unsafe float m_fMovementMalfunctionShiftAmount
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 3480); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3480); }
    }

    /// <summary>
    /// FloatProperty: m_fMovementMalfunctionShiftDelay
    /// </summary>
    public unsafe float m_fMovementMalfunctionShiftDelay
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 3484); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3484); }
    }

    /// <summary>
    /// FloatProperty: m_fMovementMalfunctionVibrateDelay
    /// </summary>
    public unsafe float m_fMovementMalfunctionVibrateDelay
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 3488); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3488); }
    }

    /// <summary>
    /// FloatProperty: m_fMovementMalfunctionVibrateAmount
    /// </summary>
    public unsafe float m_fMovementMalfunctionVibrateAmount
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 3492); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3492); }
    }

    /// <summary>
    /// FloatProperty: m_fMovementMalfunctionVibrateDelta
    /// </summary>
    public unsafe float m_fMovementMalfunctionVibrateDelta
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 3496); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3496); }
    }

    /// <summary>
    /// FloatProperty: m_fMovementMalfunctionDuration
    /// </summary>
    public unsafe float m_fMovementMalfunctionDuration
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 3500); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3500); }
    }

    /// <summary>
    /// FloatProperty: m_fCodesDownloadTime
    /// </summary>
    public unsafe float m_fCodesDownloadTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 3504); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3504); }
    }

    /// <summary>
    /// FloatProperty: m_fMaximumMiniDroneControllerInteractionDistance
    /// </summary>
    public unsafe float m_fMaximumMiniDroneControllerInteractionDistance
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 3508); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3508); }
    }

    /// <summary>
    /// ArrayProperty: m_aSearchLights
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RHelicopterIntermediateBase.FSearchLightData> m_aSearchLights
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RHelicopterIntermediateBase.FSearchLightData>>(Ptr + 3512); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3512); }
    }

    /// <summary>
    /// IntProperty: m_nSearchLightTargets
    /// </summary>
    public unsafe int m_nSearchLightTargets
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3528); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3528); }
    }

    /// <summary>
    /// StructProperty: m_vSearchLightSourcePosition
    /// </summary>
    public unsafe System.Numerics.Vector3 m_vSearchLightSourcePosition
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 3532); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3532); }
    }

    /// <summary>
    /// StructProperty: m_rSearchLightSourceRotation
    /// </summary>
    public unsafe BmSDK.Rotator m_rSearchLightSourceRotation
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Rotator>(Ptr + 3544); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3544); }
    }

    /// <summary>
    /// StructProperty: m_rSearchLightSourceDirection
    /// </summary>
    public unsafe BmSDK.Rotator m_rSearchLightSourceDirection
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Rotator>(Ptr + 3556); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3556); }
    }

    /// <summary>
    /// FloatProperty: m_fSearchLightMoveInterpolationSpeed
    /// </summary>
    public unsafe float m_fSearchLightMoveInterpolationSpeed
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 3568); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3568); }
    }

    /// <summary>
    /// FloatProperty: m_fSearchLightScanTiltDesired
    /// </summary>
    public unsafe float m_fSearchLightScanTiltDesired
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 3572); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3572); }
    }

    /// <summary>
    /// FloatProperty: m_fSearchLightScanTiltCurrent
    /// </summary>
    public unsafe float m_fSearchLightScanTiltCurrent
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 3576); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3576); }
    }

    /// <summary>
    /// FloatProperty: m_fSearchLightScanBaseAngle
    /// </summary>
    public unsafe float m_fSearchLightScanBaseAngle
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 3580); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3580); }
    }

    /// <summary>
    /// FloatProperty: m_fSearchLightScanOffsetAngle
    /// </summary>
    public unsafe float m_fSearchLightScanOffsetAngle
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 3584); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3584); }
    }

    /// <summary>
    /// FloatProperty: m_fSearchLightScanRotateSpeedDesired
    /// </summary>
    public unsafe float m_fSearchLightScanRotateSpeedDesired
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 3588); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3588); }
    }

    /// <summary>
    /// FloatProperty: m_fSearchLightScanRotateSpeedCurrent
    /// </summary>
    public unsafe float m_fSearchLightScanRotateSpeedCurrent
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 3592); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3592); }
    }

    /// <summary>
    /// FloatProperty: m_fSearchLightScanSpreadDesired
    /// </summary>
    public unsafe float m_fSearchLightScanSpreadDesired
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 3596); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3596); }
    }

    /// <summary>
    /// FloatProperty: m_fSearchLightScanSpreadCurrent
    /// </summary>
    public unsafe float m_fSearchLightScanSpreadCurrent
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 3600); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3600); }
    }

    /// <summary>
    /// FloatProperty: m_fSearchLightBlindDelay
    /// </summary>
    public unsafe float m_fSearchLightBlindDelay
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 3604); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3604); }
    }

    /// <summary>
    /// ArrayProperty: m_aTargetList
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RHelicopterIntermediateBase.FTargetData> m_aTargetList
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RHelicopterIntermediateBase.FTargetData>>(Ptr + 3608); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3608); }
    }

    /// <summary>
    /// ArrayProperty: m_aTargetIgnoreList
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.Engine.Actor> m_aTargetIgnoreList
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.Actor>>(Ptr + 3624); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3624); }
    }

    /// <summary>
    /// FloatProperty: m_fTargetRefreshDelay
    /// </summary>
    public unsafe float m_fTargetRefreshDelay
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 3640); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3640); }
    }

    /// <summary>
    /// StructProperty: m_vTargetSourcePosition
    /// </summary>
    public unsafe System.Numerics.Vector3 m_vTargetSourcePosition
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 3644); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3644); }
    }

    /// <summary>
    /// StructProperty: m_vTargetSourceRotation
    /// </summary>
    public unsafe BmSDK.Rotator m_vTargetSourceRotation
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Rotator>(Ptr + 3656); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3656); }
    }

    /// <summary>
    /// NameProperty: m_ExplosionTargetClass
    /// </summary>
    public unsafe BmSDK.FName m_ExplosionTargetClass
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 3668); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3668); }
    }

    /// <summary>
    /// NameProperty: m_ExplosionCachedTargetClassName
    /// </summary>
    public unsafe BmSDK.FName m_ExplosionCachedTargetClassName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 3676); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3676); }
    }

    /// <summary>
    /// FloatProperty: m_fExplosionKillRange
    /// </summary>
    public unsafe float m_fExplosionKillRange
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 3684); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3684); }
    }

    /// <summary>
    /// Enum: MalfunctionSource
    /// </summary>
    public enum MalfunctionSource
    {
        MALS_Generic = 0,
        MALS_ControllerDisrupted = 1,
        MALS_ElectronicPulse = 2,
        MALS_MAX = 3,
    }

    /// <summary>
    /// Enum: LightColorState
    /// </summary>
    public enum LightColorState
    {
        LCS_Off = 0,
        LCS_Standard = 1,
        LCS_Investigate = 2,
        LCS_Attack = 3,
        LCS_Malfunction = 4,
        LCS_MAX = 5,
    }

    /// <summary>
    /// Enum: SearchLightTargetMode
    /// </summary>
    public enum SearchLightTargetMode
    {
        SLTM_Nothing = 0,
        SLTM_Standard = 1,
        SLTM_AllOrNothing = 2,
        SLTM_Specified = 3,
        SLTM_MAX = 4,
    }
}
