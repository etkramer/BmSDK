#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RBatarangProjectile_Controllable<br/>
/// (size = 0)
/// (flags = 0)
/// </summary>
public partial class RBatarangProjectile_Controllable : BmSDK.BmGame.RBatarangProjectile, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RBatarangProjectile_Controllable", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RBatarangProjectile_Controllable() { }

    /// <summary>
    /// Constructs a new RBatarangProjectile_Controllable
    /// </summary>
    public RBatarangProjectile_Controllable(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RBatarangProjectile_Controllable Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RBatarangProjectile_Controllable(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="Engine.Actor.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RBatarangProjectile_Controllable>
        => ((Engine.Actor)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="Engine.Actor.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RBatarangProjectile_Controllable>, new()
        => (TComponent)((Engine.Actor)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="Engine.Actor.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RBatarangProjectile_Controllable>
        => ((Engine.Actor)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="Engine.Actor.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RBatarangProjectile_Controllable>
        => ((Engine.Actor)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="Engine.Actor.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RBatarangProjectile_Controllable>
        => (TComponent)((Engine.Actor)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="Engine.Actor.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RBatarangProjectile_Controllable>
        => ((Engine.Actor)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="Engine.Actor.DetachScriptComponent(Type)"/>
    public void DetachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RBatarangProjectile_Controllable>
        => ((Engine.Actor)this).DetachScriptComponent(typeof(TComponent));

    /// <summary>
    /// ObjectProperty: Input
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT Input
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 1260); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1260); }
    }

    /// <summary>
    /// ObjectProperty: LastVillainHit
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT LastVillainHit
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 1268); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1268); }
    }

    /// <summary>
    /// ObjectProperty: DodgeTargets
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT DodgeTargets
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 1276); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1276); }
    }

    /// <summary>
    /// ObjectProperty: FlipAnimSet
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT FlipAnimSet
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 1284); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1284); }
    }

    /// <summary>
    /// ObjectProperty: BoostSound
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT BoostSound
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 1292); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1292); }
    }

    /// <summary>
    /// ObjectProperty: BrakeSound
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT BrakeSound
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 1300); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1300); }
    }

    /// <summary>
    /// ObjectProperty: FlipSound
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT FlipSound
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 1308); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1308); }
    }

    /// <summary>
    /// ObjectProperty: ScanPositive
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT ScanPositive
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 1316); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1316); }
    }

    /// <summary>
    /// ObjectProperty: ScanNegative
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT ScanNegative
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 1324); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1324); }
    }

    /// <summary>
    /// ObjectProperty: NPCCatchActor
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT NPCCatchActor
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 1332); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1332); }
    }

    /// <summary>
    /// ObjectProperty: LightMaterial
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT LightMaterial
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 1340); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1340); }
    }

    /// <summary>
    /// ObjectProperty: DumbFireLookAtTarget
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT DumbFireLookAtTarget
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 1348); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1348); }
    }

    /// <summary>
    /// ObjectProperty: TurnParameter
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT TurnParameter
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 1356); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1356); }
    }

    /// <summary>
    /// ObjectProperty: SpeedParameter
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT SpeedParameter
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 1364); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1364); }
    }

    /// <summary>
    /// ComponentProperty: LaserSightSystem
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT LaserSightSystem
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 1372); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1372); }
    }

    /// <summary>
    /// FloatProperty: YawVel
    /// </summary>
    public unsafe float YawVel
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1380); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1380); }
    }

    /// <summary>
    /// FloatProperty: PitchVel
    /// </summary>
    public unsafe float PitchVel
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1384); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1384); }
    }

    /// <summary>
    /// FloatProperty: MaxPitchVel
    /// </summary>
    public unsafe float MaxPitchVel
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1388); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1388); }
    }

    /// <summary>
    /// FloatProperty: MaxYawVel
    /// </summary>
    public unsafe float MaxYawVel
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1392); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1392); }
    }

    /// <summary>
    /// FloatProperty: PitchAccel
    /// </summary>
    public unsafe float PitchAccel
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1396); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1396); }
    }

    /// <summary>
    /// FloatProperty: YawAccel
    /// </summary>
    public unsafe float YawAccel
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1400); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1400); }
    }

    /// <summary>
    /// FloatProperty: ControlledTime
    /// </summary>
    public unsafe float ControlledTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1404); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1404); }
    }

    /// <summary>
    /// IntProperty: NumVillainsHit
    /// </summary>
    public unsafe int NumVillainsHit
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1408); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1408); }
    }

    /// <summary>
    /// StructProperty: LastPosition
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT LastPosition
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 1412); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1412); }
    }

    /// <summary>
    /// BoolProperty: Braking
    /// </summary>
    public unsafe bool Braking
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1424) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1424); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1424); }
    }

    /// <summary>
    /// BoolProperty: ReleasedBoostTrigger
    /// </summary>
    public unsafe bool ReleasedBoostTrigger
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1424) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1424); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1424); }
    }

    /// <summary>
    /// BoolProperty: ReleasedBrakeTrigger
    /// </summary>
    public unsafe bool ReleasedBrakeTrigger
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1424) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1424); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1424); }
    }

    /// <summary>
    /// BoolProperty: bFlipBatarang
    /// </summary>
    public unsafe bool bFlipBatarang
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1424) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1424); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1424); }
    }

    /// <summary>
    /// BoolProperty: bAutoLevel
    /// </summary>
    public unsafe bool bAutoLevel
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1424) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1424); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1424); }
    }

    /// <summary>
    /// BoolProperty: bDisableUserControl
    /// </summary>
    public unsafe bool bDisableUserControl
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1424) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1424); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1424); }
    }

    /// <summary>
    /// BoolProperty: CanBoost
    /// </summary>
    public unsafe bool CanBoost
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1424) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1424); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1424); }
    }

    /// <summary>
    /// BoolProperty: bAvoidedTarget
    /// </summary>
    public unsafe bool bAvoidedTarget
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1424) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1424); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1424); }
    }

    /// <summary>
    /// BoolProperty: bLastLevelBorderResult
    /// </summary>
    public unsafe bool bLastLevelBorderResult
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1424) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1424); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1424); }
    }

    /// <summary>
    /// BoolProperty: bLastBrakeInput
    /// </summary>
    public unsafe bool bLastBrakeInput
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1424) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1424); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1424); }
    }

    /// <summary>
    /// BoolProperty: bLastBoostInput
    /// </summary>
    public unsafe bool bLastBoostInput
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1424) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1424); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1424); }
    }

    /// <summary>
    /// BoolProperty: BouncedThisFrame
    /// </summary>
    public unsafe bool BouncedThisFrame
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1424) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1424); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1424); }
    }

    /// <summary>
    /// FloatProperty: CurrentSpeedFactor
    /// </summary>
    public unsafe float CurrentSpeedFactor
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1428); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1428); }
    }

    /// <summary>
    /// FloatProperty: ReboundTimer
    /// </summary>
    public unsafe float ReboundTimer
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1432); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1432); }
    }

    /// <summary>
    /// FloatProperty: InitialReboundSpeed
    /// </summary>
    public unsafe float InitialReboundSpeed
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1436); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1436); }
    }

    /// <summary>
    /// IntProperty: SpinYaw
    /// </summary>
    public unsafe int SpinYaw
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1440); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1440); }
    }

    /// <summary>
    /// FloatProperty: FlipBatarangTimer
    /// </summary>
    public unsafe float FlipBatarangTimer
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1444); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1444); }
    }

    /// <summary>
    /// StructProperty: FlipOldPosition
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT FlipOldPosition
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 1448); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1448); }
    }

    /// <summary>
    /// StructProperty: FlipOldRotation
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT FlipOldRotation
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 1460); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1460); }
    }

    /// <summary>
    /// StructProperty: FlipTargetRotation
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT FlipTargetRotation
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 1472); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1472); }
    }

    /// <summary>
    /// FloatProperty: AutoLevelSpeed
    /// </summary>
    public unsafe float AutoLevelSpeed
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1484); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1484); }
    }

    /// <summary>
    /// FloatProperty: CurrentAutoLevelSpeed
    /// </summary>
    public unsafe float CurrentAutoLevelSpeed
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1488); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1488); }
    }

    /// <summary>
    /// FloatProperty: FlipTime
    /// </summary>
    public unsafe float FlipTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1492); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1492); }
    }

    /// <summary>
    /// NameProperty: FlipAnimName
    /// </summary>
    public unsafe BmSDK.FName FlipAnimName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 1496); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1496); }
    }

    /// <summary>
    /// FloatProperty: LastPlayerControlTime
    /// </summary>
    public unsafe float LastPlayerControlTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1504); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1504); }
    }

    /// <summary>
    /// StructProperty: InitialFlipAnimTransform
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT InitialFlipAnimTransform
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 1508); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1508); }
    }

    /// <summary>
    /// StructProperty: InvInitialFlipAnimRotation
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT InvInitialFlipAnimRotation
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 1520); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1520); }
    }

    /// <summary>
    /// FloatProperty: LightMaterialStrength
    /// </summary>
    public unsafe float LightMaterialStrength
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1584); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1584); }
    }

    /// <summary>
    /// FloatProperty: LightMaterialChangeTime
    /// </summary>
    public unsafe float LightMaterialChangeTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1588); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1588); }
    }

    /// <summary>
    /// FloatProperty: fLastLevelBorderCheckFrame
    /// </summary>
    public unsafe float fLastLevelBorderCheckFrame
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1592); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1592); }
    }

    /// <summary>
    /// FloatProperty: fLastLevelBorderDistance
    /// </summary>
    public unsafe float fLastLevelBorderDistance
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1596); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1596); }
    }

    /// <summary>
    /// FloatProperty: fLastHeightLimit
    /// </summary>
    public unsafe float fLastHeightLimit
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1600); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1600); }
    }

    /// <summary>
    /// FloatProperty: LastBrakeTime
    /// </summary>
    public unsafe float LastBrakeTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1604); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1604); }
    }

    /// <summary>
    /// FloatProperty: LastBoostTime
    /// </summary>
    public unsafe float LastBoostTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1608); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1608); }
    }

    /// <summary>
    /// IntProperty: WallHitCount
    /// </summary>
    public unsafe int WallHitCount
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1612); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1612); }
    }

    /// <summary>
    /// IntProperty: MaxWallHits
    /// </summary>
    public unsafe int MaxWallHits
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1616); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1616); }
    }

    /// <summary>
    /// FloatProperty: ReboundFrame
    /// </summary>
    public unsafe float ReboundFrame
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1620); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1620); }
    }

    /// <summary>
    /// FloatProperty: fThrowStartTime
    /// </summary>
    public unsafe float fThrowStartTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1624); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1624); }
    }

    /// <summary>
    /// FloatProperty: fAmountOfTimeToDisallowReboundsAfterThrow
    /// </summary>
    public unsafe float fAmountOfTimeToDisallowReboundsAfterThrow
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1628); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1628); }
    }
}
