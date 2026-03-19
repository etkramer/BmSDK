#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RTurret_WatchtowerBase<br/>
/// (size = 0)
/// (flags = 0)
/// </summary>
public partial class RTurret_WatchtowerBase : BmSDK.BmGame.RTurretBase, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RTurret_WatchtowerBase", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RTurret_WatchtowerBase() { }

    /// <summary>
    /// Constructs a new RTurret_WatchtowerBase
    /// </summary>
    public RTurret_WatchtowerBase(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RTurret_WatchtowerBase Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RTurret_WatchtowerBase(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="Engine.Actor.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RTurret_WatchtowerBase>
        => ((Engine.Actor)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="Engine.Actor.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RTurret_WatchtowerBase>, new()
        => (TComponent)((Engine.Actor)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="Engine.Actor.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RTurret_WatchtowerBase>
        => ((Engine.Actor)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="Engine.Actor.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RTurret_WatchtowerBase>
        => ((Engine.Actor)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="Engine.Actor.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RTurret_WatchtowerBase>
        => (TComponent)((Engine.Actor)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="Engine.Actor.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RTurret_WatchtowerBase>
        => ((Engine.Actor)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="Engine.Actor.DetachScriptComponent(Type)"/>
    public void DetachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RTurret_WatchtowerBase>
        => ((Engine.Actor)this).DetachScriptComponent(typeof(TComponent));

    /// <summary>
    /// ComponentProperty: unifiedGunMesh
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT unifiedGunMesh
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 1344); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1344); }
    }

    /// <summary>
    /// FloatProperty: BMDetectionAngleDegrees
    /// </summary>
    public unsafe float BMDetectionAngleDegrees
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1352); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1352); }
    }

    /// <summary>
    /// ObjectProperty: BM
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT BM
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 1356); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1356); }
    }

    /// <summary>
    /// ObjectProperty: lightsArchetype
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT lightsArchetype
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 1364); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1364); }
    }

    /// <summary>
    /// ObjectProperty: lightsInstance
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT lightsInstance
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 1372); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1372); }
    }

    /// <summary>
    /// ObjectProperty: OriginalXrayMaterial
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT OriginalXrayMaterial
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 1380); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1380); }
    }

    /// <summary>
    /// ObjectProperty: BlindedXrayMaterial
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT BlindedXrayMaterial
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 1388); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1388); }
    }

    /// <summary>
    /// ObjectProperty: ShieldImpactMat
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT ShieldImpactMat
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 1396); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1396); }
    }

    /// <summary>
    /// ObjectProperty: explosionPFX
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT explosionPFX
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 1404); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1404); }
    }

    /// <summary>
    /// ObjectProperty: FiringSFX_Loop
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT FiringSFX_Loop
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 1412); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1412); }
    }

    /// <summary>
    /// ObjectProperty: warningSFX
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT warningSFX
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 1420); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1420); }
    }

    /// <summary>
    /// ObjectProperty: destroyedSFX
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT destroyedSFX
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 1428); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1428); }
    }

    /// <summary>
    /// ObjectProperty: destroyedSFXLoop
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT destroyedSFXLoop
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 1436); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1436); }
    }

    /// <summary>
    /// ObjectProperty: IdleSFX
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT IdleSFX
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 1444); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1444); }
    }

    /// <summary>
    /// ObjectProperty: SearchingSFX
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT SearchingSFX
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 1452); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1452); }
    }

    /// <summary>
    /// ObjectProperty: SFXSearchSpeedParam
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT SFXSearchSpeedParam
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 1460); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1460); }
    }

    /// <summary>
    /// ComponentProperty: LaserSight
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT LaserSight
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 1468); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1468); }
    }

    /// <summary>
    /// ComponentProperty: LensFlareFX
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT LensFlareFX
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 1476); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1476); }
    }

    /// <summary>
    /// ComponentProperty: damagedPFX
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT damagedPFX
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 1484); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1484); }
    }

    /// <summary>
    /// ComponentProperty: ShieldImpactComp
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT ShieldImpactComp
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 1492); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1492); }
    }

    /// <summary>
    /// ComponentProperty: Shield
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT Shield
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 1500); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1500); }
    }

    /// <summary>
    /// FloatProperty: lightBaseEndRadius
    /// </summary>
    public unsafe float lightBaseEndRadius
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1508); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1508); }
    }

    /// <summary>
    /// FloatProperty: lightParticleSystemBaseLength
    /// </summary>
    public unsafe float lightParticleSystemBaseLength
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1512); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1512); }
    }

    /// <summary>
    /// FloatProperty: lightParticleSystemBaseEndRadius
    /// </summary>
    public unsafe float lightParticleSystemBaseEndRadius
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1516); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1516); }
    }

    /// <summary>
    /// StrProperty: destroyedFlagString
    /// </summary>
    public unsafe BmSDK.FString destroyedFlagString
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 1520); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1520); }
    }

    /// <summary>
    /// FloatProperty: lastCanShootTime
    /// </summary>
    public unsafe float lastCanShootTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1536); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1536); }
    }

    /// <summary>
    /// FloatProperty: lastCanNotShootTime
    /// </summary>
    public unsafe float lastCanNotShootTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1540); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1540); }
    }

    /// <summary>
    /// FloatProperty: pauseDurationBeforeShootingPlayer
    /// </summary>
    public unsafe float pauseDurationBeforeShootingPlayer
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1544); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1544); }
    }

    /// <summary>
    /// FloatProperty: pauseDurationAfterLosingPlayer
    /// </summary>
    public unsafe float pauseDurationAfterLosingPlayer
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1548); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1548); }
    }

    /// <summary>
    /// FloatProperty: lastJammedTime
    /// </summary>
    public unsafe float lastJammedTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1552); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1552); }
    }

    /// <summary>
    /// FloatProperty: visibleJammednessProportion
    /// </summary>
    public unsafe float visibleJammednessProportion
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1556); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1556); }
    }

    /// <summary>
    /// BoolProperty: bLightRadiusChanged
    /// </summary>
    public unsafe bool bLightRadiusChanged
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1560) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1560); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1560); }
    }

    /// <summary>
    /// BoolProperty: bDrawDebugCone
    /// </summary>
    public unsafe bool bDrawDebugCone
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1560) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1560); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1560); }
    }

    /// <summary>
    /// BoolProperty: bDrawDebugLightRange
    /// </summary>
    public unsafe bool bDrawDebugLightRange
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1560) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1560); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1560); }
    }

    /// <summary>
    /// BoolProperty: bFiringSoundPlaying
    /// </summary>
    public unsafe bool bFiringSoundPlaying
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1560) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1560); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1560); }
    }

    /// <summary>
    /// BoolProperty: bDbgForceLightConeScale
    /// </summary>
    public unsafe bool bDbgForceLightConeScale
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1560) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1560); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1560); }
    }

    /// <summary>
    /// BoolProperty: bDrawLightConeDbg
    /// </summary>
    public unsafe bool bDrawLightConeDbg
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1560) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1560); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1560); }
    }

    /// <summary>
    /// BoolProperty: bDoneFirstRangeUpdate
    /// </summary>
    public unsafe bool bDoneFirstRangeUpdate
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1560) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1560); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1560); }
    }

    /// <summary>
    /// BoolProperty: bPlayedWarningSoundSinceSpottingPlayer
    /// </summary>
    public unsafe bool bPlayedWarningSoundSinceSpottingPlayer
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1560) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1560); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1560); }
    }

    /// <summary>
    /// BoolProperty: bDbgForceMissPlayer
    /// </summary>
    public unsafe bool bDbgForceMissPlayer
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1560) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1560); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1560); }
    }

    /// <summary>
    /// BoolProperty: bShowVisibleLaserSight
    /// </summary>
    public unsafe bool bShowVisibleLaserSight
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1560) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1560); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1560); }
    }

    /// <summary>
    /// BoolProperty: bDoRaycastForLightRadius
    /// </summary>
    public unsafe bool bDoRaycastForLightRadius
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1560) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1560); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1560); }
    }

    /// <summary>
    /// BoolProperty: bPlayerVisibleThisFrame
    /// </summary>
    public unsafe bool bPlayerVisibleThisFrame
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1560) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1560); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1560); }
    }

    /// <summary>
    /// BoolProperty: bPlayerVisibleLastFrame
    /// </summary>
    public unsafe bool bPlayerVisibleLastFrame
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1560) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1560); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1560); }
    }

    /// <summary>
    /// FloatProperty: lightAngleProportion
    /// </summary>
    public unsafe float lightAngleProportion
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1564); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1564); }
    }

    /// <summary>
    /// FloatProperty: minLightAngleProportion
    /// </summary>
    public unsafe float minLightAngleProportion
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1568); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1568); }
    }

    /// <summary>
    /// FloatProperty: jamStartTransitionDuration
    /// </summary>
    public unsafe float jamStartTransitionDuration
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1572); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1572); }
    }

    /// <summary>
    /// FloatProperty: jamEndTransitionDuration
    /// </summary>
    public unsafe float jamEndTransitionDuration
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1576); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1576); }
    }

    /// <summary>
    /// FloatProperty: jamDuration
    /// </summary>
    public unsafe float jamDuration
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1580); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1580); }
    }

    /// <summary>
    /// StructProperty: lastLightRangeUpdateRot
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT lastLightRangeUpdateRot
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 1584); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1584); }
    }

    /// <summary>
    /// FloatProperty: lightRange
    /// </summary>
    public unsafe float lightRange
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1596); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1596); }
    }

    /// <summary>
    /// ByteProperty: prevLightMode
    /// </summary>
    public unsafe byte prevLightMode
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 1600); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1600); }
    }

    /// <summary>
    /// FloatProperty: timeSinceJammed
    /// </summary>
    public unsafe float timeSinceJammed
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1604); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1604); }
    }

    /// <summary>
    /// StructProperty: dbgForceLightConeScale
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT dbgForceLightConeScale
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 1608); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1608); }
    }

    /// <summary>
    /// FloatProperty: pulsePeriod
    /// </summary>
    public unsafe float pulsePeriod
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1620); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1620); }
    }

    /// <summary>
    /// FloatProperty: currentPulseCycleProportion
    /// </summary>
    public unsafe float currentPulseCycleProportion
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1624); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1624); }
    }

    /// <summary>
    /// FloatProperty: prevPulseCycleProportion
    /// </summary>
    public unsafe float prevPulseCycleProportion
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1628); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1628); }
    }

    /// <summary>
    /// StructProperty: coneColour
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT coneColour
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 1632); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1632); }
    }

    /// <summary>
    /// FloatProperty: initialRangeP
    /// </summary>
    public unsafe float initialRangeP
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1636); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1636); }
    }

    /// <summary>
    /// FloatProperty: initialRangeY
    /// </summary>
    public unsafe float initialRangeY
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1640); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1640); }
    }

    /// <summary>
    /// FloatProperty: prevLightMeshAngle
    /// </summary>
    public unsafe float prevLightMeshAngle
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1644); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1644); }
    }

    /// <summary>
    /// FloatProperty: absYawDistToBM
    /// </summary>
    public unsafe float absYawDistToBM
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1648); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1648); }
    }

    /// <summary>
    /// FloatProperty: absPitchDistToBM
    /// </summary>
    public unsafe float absPitchDistToBM
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1652); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1652); }
    }

    /// <summary>
    /// FloatProperty: LightRangeMod
    /// </summary>
    public unsafe float LightRangeMod
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1656); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1656); }
    }

    /// <summary>
    /// FloatProperty: currentLightRange
    /// </summary>
    public unsafe float currentLightRange
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1660); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1660); }
    }

    /// <summary>
    /// FloatProperty: timeSpentTicking
    /// </summary>
    public unsafe float timeSpentTicking
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1664); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1664); }
    }

    /// <summary>
    /// FloatProperty: lastPlayerVisibleTime
    /// </summary>
    public unsafe float lastPlayerVisibleTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1668); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1668); }
    }

    /// <summary>
    /// StructProperty: lastKnownPlayerLocation
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT lastKnownPlayerLocation
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 1672); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1672); }
    }

    /// <summary>
    /// FloatProperty: PPSpeed
    /// </summary>
    public unsafe float PPSpeed
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1684); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1684); }
    }

    /// <summary>
    /// FloatProperty: PPMax
    /// </summary>
    public unsafe float PPMax
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1688); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1688); }
    }
}
