#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RTurretBase<br/>
/// (flags = 0)
/// </summary>
public partial class RTurretBase : BmSDK.BmGame.RTrackingSecurityCameraBase, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RTurretBase", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RTurretBase() { }

    /// <summary>
    /// Constructs a new RTurretBase
    /// </summary>
    public RTurretBase(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RTurretBase Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RTurretBase(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="Engine.Actor.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RTurretBase>
        => ((Engine.Actor)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="Engine.Actor.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RTurretBase>, new()
        => (TComponent)((Engine.Actor)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="Engine.Actor.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RTurretBase>
        => ((Engine.Actor)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="Engine.Actor.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RTurretBase>
        => ((Engine.Actor)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="Engine.Actor.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RTurretBase>
        => (TComponent)((Engine.Actor)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="Engine.Actor.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RTurretBase>
        => ((Engine.Actor)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="Engine.Actor.DetachScriptComponent(Type)"/>
    public void DetachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RTurretBase>
        => ((Engine.Actor)this).DetachScriptComponent(typeof(TComponent));

    /// <summary>
    /// ObjectProperty: Vol
    /// </summary>
    public unsafe BmSDK.Engine.TriggerVolume Vol
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.TriggerVolume>(Ptr + 1020); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1020); }
    }

    /// <summary>
    /// ObjectProperty: updater
    /// </summary>
    public unsafe BmSDK.BmGame.RSeqAct_UpdateTurret updater
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSeqAct_UpdateTurret>(Ptr + 1028); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1028); }
    }

    /// <summary>
    /// ObjectProperty: RPC
    /// </summary>
    public unsafe BmSDK.BmGame.RPlayerController RPC
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPlayerController>(Ptr + 1036); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1036); }
    }

    /// <summary>
    /// ObjectProperty: BatmanHitMove
    /// </summary>
    public unsafe BmSDK.BmGame.RSpecialMoveConfig_AdditiveAnim BatmanHitMove
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveConfig_AdditiveAnim>(Ptr + 1044); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1044); }
    }

    /// <summary>
    /// ObjectProperty: XrayMats
    /// </summary>
    public unsafe BmSDK.Engine.MaterialInterface XrayMats_0
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.MaterialInterface>(Ptr + 1052); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1052); }
    }
    /// <summary>
    /// ObjectProperty: XrayMats
    /// </summary>
    public unsafe BmSDK.Engine.MaterialInterface XrayMats_1
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.MaterialInterface>(Ptr + 1060); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1060); }
    }
    /// <summary>
    /// ObjectProperty: XrayMats
    /// </summary>
    public unsafe BmSDK.Engine.MaterialInterface XrayMats_2
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.MaterialInterface>(Ptr + 1068); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1068); }
    }

    /// <summary>
    /// ObjectProperty: LightMat_BracketComp
    /// </summary>
    public unsafe BmSDK.Engine.MaterialInstanceConstant LightMat_BracketComp
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.MaterialInstanceConstant>(Ptr + 1076); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1076); }
    }

    /// <summary>
    /// ObjectProperty: LightMat_JointComp
    /// </summary>
    public unsafe BmSDK.Engine.MaterialInstanceConstant LightMat_JointComp
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.MaterialInstanceConstant>(Ptr + 1084); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1084); }
    }

    /// <summary>
    /// ObjectProperty: BulletBySound
    /// </summary>
    public unsafe BmSDK.Engine.AkEvent BulletBySound
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkEvent>(Ptr + 1092); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1092); }
    }

    /// <summary>
    /// ComponentProperty: ImpactFX
    /// </summary>
    public unsafe BmSDK.Engine.ParticleSystemComponent ImpactFX_0
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleSystemComponent>(Ptr + 1100); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1100); }
    }
    /// <summary>
    /// ComponentProperty: ImpactFX
    /// </summary>
    public unsafe BmSDK.Engine.ParticleSystemComponent ImpactFX_1
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleSystemComponent>(Ptr + 1108); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1108); }
    }
    /// <summary>
    /// ComponentProperty: ImpactFX
    /// </summary>
    public unsafe BmSDK.Engine.ParticleSystemComponent ImpactFX_2
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleSystemComponent>(Ptr + 1116); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1116); }
    }

    /// <summary>
    /// ComponentProperty: BulletTrailFX
    /// </summary>
    public unsafe BmSDK.Engine.ParticleSystemComponent BulletTrailFX_0
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleSystemComponent>(Ptr + 1124); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1124); }
    }
    /// <summary>
    /// ComponentProperty: BulletTrailFX
    /// </summary>
    public unsafe BmSDK.Engine.ParticleSystemComponent BulletTrailFX_1
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleSystemComponent>(Ptr + 1132); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1132); }
    }
    /// <summary>
    /// ComponentProperty: BulletTrailFX
    /// </summary>
    public unsafe BmSDK.Engine.ParticleSystemComponent BulletTrailFX_2
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleSystemComponent>(Ptr + 1140); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1140); }
    }

    /// <summary>
    /// ComponentProperty: MuzzleFlashFx
    /// </summary>
    public unsafe BmSDK.Engine.ParticleSystemComponent MuzzleFlashFx_0
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleSystemComponent>(Ptr + 1148); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1148); }
    }
    /// <summary>
    /// ComponentProperty: MuzzleFlashFx
    /// </summary>
    public unsafe BmSDK.Engine.ParticleSystemComponent MuzzleFlashFx_1
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleSystemComponent>(Ptr + 1156); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1156); }
    }
    /// <summary>
    /// ComponentProperty: MuzzleFlashFx
    /// </summary>
    public unsafe BmSDK.Engine.ParticleSystemComponent MuzzleFlashFx_2
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleSystemComponent>(Ptr + 1164); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1164); }
    }

    /// <summary>
    /// FloatProperty: InstantShootDist
    /// </summary>
    public unsafe float InstantShootDist
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1172); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1172); }
    }

    /// <summary>
    /// FloatProperty: ShootAngleLimit
    /// </summary>
    public unsafe float ShootAngleLimit
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1176); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1176); }
    }

    /// <summary>
    /// BoolProperty: bDrawDebug
    /// </summary>
    public unsafe bool bDrawDebug
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1180) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1180); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1180); }
    }

    /// <summary>
    /// BoolProperty: bDisabled
    /// </summary>
    public unsafe bool bDisabled
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1180) & 2) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1180); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1180); }
    }

    /// <summary>
    /// BoolProperty: bWasTrackingWhileJammed
    /// </summary>
    public unsafe bool bWasTrackingWhileJammed
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1180) & 4) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1180); var newMask = value ? (currentMask | 4) : (currentMask & ~4); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1180); }
    }

    /// <summary>
    /// BoolProperty: bWasSweeping
    /// </summary>
    public unsafe bool bWasSweeping
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1180) & 8) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1180); var newMask = value ? (currentMask | 8) : (currentMask & ~8); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1180); }
    }

    /// <summary>
    /// BoolProperty: bHasSetDisruptTimer
    /// </summary>
    public unsafe bool bHasSetDisruptTimer
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1180) & 16) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1180); var newMask = value ? (currentMask | 16) : (currentMask & ~16); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1180); }
    }

    /// <summary>
    /// BoolProperty: bCanDamagePlayer
    /// </summary>
    public unsafe bool bCanDamagePlayer
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1180) & 32) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1180); var newMask = value ? (currentMask | 32) : (currentMask & ~32); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1180); }
    }

    /// <summary>
    /// BoolProperty: bWasShooting
    /// </summary>
    public unsafe bool bWasShooting
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1180) & 64) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1180); var newMask = value ? (currentMask | 64) : (currentMask & ~64); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1180); }
    }

    /// <summary>
    /// BoolProperty: bIsShooting
    /// </summary>
    public unsafe bool bIsShooting
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1180) & 128) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1180); var newMask = value ? (currentMask | 128) : (currentMask & ~128); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1180); }
    }

    /// <summary>
    /// BoolProperty: bDisruptionTimerPaused
    /// </summary>
    public unsafe bool bDisruptionTimerPaused
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1180) & 256) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1180); var newMask = value ? (currentMask | 256) : (currentMask & ~256); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1180); }
    }

    /// <summary>
    /// BoolProperty: bTrackingOriginNeedsUpdate
    /// </summary>
    public unsafe bool bTrackingOriginNeedsUpdate
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1180) & 512) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1180); var newMask = value ? (currentMask | 512) : (currentMask & ~512); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1180); }
    }

    /// <summary>
    /// BoolProperty: bMuzzleLocNeedsUpdate
    /// </summary>
    public unsafe bool bMuzzleLocNeedsUpdate
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1180) & 1024) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1180); var newMask = value ? (currentMask | 1024) : (currentMask & ~1024); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1180); }
    }

    /// <summary>
    /// BoolProperty: bDefaultTickGroupSet
    /// </summary>
    public unsafe bool bDefaultTickGroupSet
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1180) & 2048) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1180); var newMask = value ? (currentMask | 2048) : (currentMask & ~2048); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1180); }
    }

    /// <summary>
    /// ArrayProperty: TargetList
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.Engine.Actor> TargetList
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.Actor>>(Ptr + 1184); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1184); }
    }

    /// <summary>
    /// FloatProperty: GunDamage
    /// </summary>
    public unsafe float GunDamage
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1200); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1200); }
    }

    /// <summary>
    /// FloatProperty: TimeBetweenShots
    /// </summary>
    public unsafe float TimeBetweenShots
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1204); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1204); }
    }

    /// <summary>
    /// FloatProperty: lastShotTime
    /// </summary>
    public unsafe float lastShotTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1208); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1208); }
    }

    /// <summary>
    /// IntProperty: lastUsedParticleSlot
    /// </summary>
    public unsafe int lastUsedParticleSlot
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1212); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1212); }
    }

    /// <summary>
    /// StructProperty: InitialRot
    /// </summary>
    public unsafe BmSDK.Rotator InitialRot
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Rotator>(Ptr + 1216); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1216); }
    }

    /// <summary>
    /// FloatProperty: jammedSpeed
    /// </summary>
    public unsafe float jammedSpeed
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1228); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1228); }
    }

    /// <summary>
    /// FloatProperty: unjammedSpeedRandomFactor
    /// </summary>
    public unsafe float unjammedSpeedRandomFactor
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1232); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1232); }
    }

    /// <summary>
    /// FloatProperty: unJammedSpeed
    /// </summary>
    public unsafe float unJammedSpeed
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1236); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1236); }
    }

    /// <summary>
    /// FloatProperty: jerkRotMaxYawDeg
    /// </summary>
    public unsafe float jerkRotMaxYawDeg
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1240); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1240); }
    }

    /// <summary>
    /// FloatProperty: jerkPeriod
    /// </summary>
    public unsafe float jerkPeriod
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1244); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1244); }
    }

    /// <summary>
    /// FloatProperty: jerkTime
    /// </summary>
    public unsafe float jerkTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1248); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1248); }
    }

    /// <summary>
    /// StructProperty: jerkRot
    /// </summary>
    public unsafe BmSDK.Rotator jerkRot
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Rotator>(Ptr + 1252); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1252); }
    }

    /// <summary>
    /// FloatProperty: speedMultiplier
    /// </summary>
    public unsafe float speedMultiplier
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1264); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1264); }
    }

    /// <summary>
    /// FloatProperty: timeTillFullSpeed
    /// </summary>
    public unsafe float timeTillFullSpeed
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1268); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1268); }
    }

    /// <summary>
    /// StructProperty: trackingOriginLoc
    /// </summary>
    public unsafe System.Numerics.Vector3 trackingOriginLoc
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 1272); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1272); }
    }

    /// <summary>
    /// StructProperty: MuzzleLoc
    /// </summary>
    public unsafe System.Numerics.Vector3 MuzzleLoc
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 1284); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1284); }
    }

    /// <summary>
    /// StructProperty: MuzzleRot
    /// </summary>
    public unsafe BmSDK.Rotator MuzzleRot
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Rotator>(Ptr + 1296); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1296); }
    }

    /// <summary>
    /// StructProperty: LightSocketLoc
    /// </summary>
    public unsafe System.Numerics.Vector3 LightSocketLoc
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 1308); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1308); }
    }

    /// <summary>
    /// StructProperty: LightSocketRot
    /// </summary>
    public unsafe BmSDK.Rotator LightSocketRot
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Rotator>(Ptr + 1320); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1320); }
    }

    /// <summary>
    /// FloatProperty: shootCriteriaMetSince
    /// </summary>
    public unsafe float shootCriteriaMetSince
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1332); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1332); }
    }

    /// <summary>
    /// FloatProperty: minFiringTime
    /// </summary>
    public unsafe float minFiringTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1336); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1336); }
    }

    /// <summary>
    /// ByteProperty: defaultTickGroup
    /// </summary>
    public unsafe BmSDK.GameObject.ETickingGroup defaultTickGroup
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.GameObject.ETickingGroup>(Ptr + 1340); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1340); }
    }

    /// <summary>
    /// ByteProperty: prevTickGroup
    /// </summary>
    public unsafe BmSDK.GameObject.ETickingGroup prevTickGroup
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.GameObject.ETickingGroup>(Ptr + 1341); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1341); }
    }
}
