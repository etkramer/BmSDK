#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RVehicleWeapon<br/>
/// (size = 0)
/// (flags = 0)
/// </summary>
public partial class RVehicleWeapon : BmSDK.BmGame.RInventoryGadget, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RVehicleWeapon", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RVehicleWeapon() { }

    /// <summary>
    /// Constructs a new RVehicleWeapon
    /// </summary>
    public RVehicleWeapon(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RVehicleWeapon Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RVehicleWeapon(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="Engine.Actor.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RVehicleWeapon>
        => ((Engine.Actor)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="Engine.Actor.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RVehicleWeapon>, new()
        => (TComponent)((Engine.Actor)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="Engine.Actor.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RVehicleWeapon>
        => ((Engine.Actor)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="Engine.Actor.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RVehicleWeapon>
        => ((Engine.Actor)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="Engine.Actor.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RVehicleWeapon>
        => (TComponent)((Engine.Actor)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="Engine.Actor.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RVehicleWeapon>
        => ((Engine.Actor)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="Engine.Actor.DetachScriptComponent(Type)"/>
    public void DetachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RVehicleWeapon>
        => ((Engine.Actor)this).DetachScriptComponent(typeof(TComponent));

    /// <summary>
    /// StrProperty: TempName
    /// </summary>
    public unsafe BmSDK.FString TempName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 2068); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2068); }
    }

    /// <summary>
    /// BoolProperty: ContinuousFire
    /// </summary>
    public unsafe bool ContinuousFire
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2084) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2084); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2084); }
    }

    /// <summary>
    /// BoolProperty: bFiring
    /// </summary>
    public unsafe bool bFiring
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2084) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2084); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2084); }
    }

    /// <summary>
    /// BoolProperty: bAimedWeapon
    /// </summary>
    public unsafe bool bAimedWeapon
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2084) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2084); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2084); }
    }

    /// <summary>
    /// BoolProperty: bOnlySteerOnAimExtremes
    /// </summary>
    public unsafe bool bOnlySteerOnAimExtremes
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2084) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2084); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2084); }
    }

    /// <summary>
    /// BoolProperty: bRelativeAiming
    /// </summary>
    public unsafe bool bRelativeAiming
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2084) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2084); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2084); }
    }

    /// <summary>
    /// BoolProperty: DrawWorldAim
    /// </summary>
    public unsafe bool DrawWorldAim
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2084) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2084); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2084); }
    }

    /// <summary>
    /// BoolProperty: bFPSControls
    /// </summary>
    public unsafe bool bFPSControls
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2084) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2084); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2084); }
    }

    /// <summary>
    /// BoolProperty: bSecondaryWeapon
    /// </summary>
    public unsafe bool bSecondaryWeapon
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2084) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2084); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2084); }
    }

    /// <summary>
    /// BoolProperty: bFailedWeaponFlag
    /// </summary>
    public unsafe bool bFailedWeaponFlag
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2084) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2084); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2084); }
    }

    /// <summary>
    /// BoolProperty: bBatmanProhibited
    /// </summary>
    public unsafe bool bBatmanProhibited
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2084) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2084); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2084); }
    }

    /// <summary>
    /// FloatProperty: FiringInterval
    /// </summary>
    public unsafe float FiringInterval
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2088); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2088); }
    }

    /// <summary>
    /// FloatProperty: CoolDown
    /// </summary>
    public unsafe float CoolDown
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2092); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2092); }
    }

    /// <summary>
    /// FloatProperty: WeaponCoolDown
    /// </summary>
    public unsafe float WeaponCoolDown
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2096); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2096); }
    }

    /// <summary>
    /// StructProperty: AimPosition
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT AimPosition
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 2100); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2100); }
    }

    /// <summary>
    /// StructProperty: AimVelocity
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT AimVelocity
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 2112); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2112); }
    }

    /// <summary>
    /// StructProperty: WorldAimPosition
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT WorldAimPosition
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 2124); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2124); }
    }

    /// <summary>
    /// FloatProperty: CursorSpeed
    /// </summary>
    public unsafe float CursorSpeed
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2136); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2136); }
    }

    /// <summary>
    /// FloatProperty: CursorAccel
    /// </summary>
    public unsafe float CursorAccel
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2140); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2140); }
    }

    /// <summary>
    /// FloatProperty: CursorDecel
    /// </summary>
    public unsafe float CursorDecel
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2144); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2144); }
    }

    /// <summary>
    /// FloatProperty: CursorReturnFactor
    /// </summary>
    public unsafe float CursorReturnFactor
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2148); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2148); }
    }

    /// <summary>
    /// FloatProperty: CursorReturnDelay
    /// </summary>
    public unsafe float CursorReturnDelay
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2152); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2152); }
    }

    /// <summary>
    /// FloatProperty: MaxAimX
    /// </summary>
    public unsafe float MaxAimX
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2156); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2156); }
    }

    /// <summary>
    /// FloatProperty: MaxAimY
    /// </summary>
    public unsafe float MaxAimY
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2160); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2160); }
    }

    /// <summary>
    /// FloatProperty: RelativeAimingCurvePower
    /// </summary>
    public unsafe float RelativeAimingCurvePower
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2164); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2164); }
    }

    /// <summary>
    /// ObjectProperty: AimTarget
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT AimTarget
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 2168); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2168); }
    }

    /// <summary>
    /// ObjectProperty: FireStartEvent
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT FireStartEvent
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 2176); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2176); }
    }

    /// <summary>
    /// ObjectProperty: FireStopEvent
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT FireStopEvent
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 2184); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2184); }
    }

    /// <summary>
    /// ObjectProperty: FireLoopingEvent
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT FireLoopingEvent
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 2192); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2192); }
    }

    /// <summary>
    /// ObjectProperty: IndividualFireEvent
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT IndividualFireEvent
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 2200); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2200); }
    }

    /// <summary>
    /// ObjectProperty: ReloadSound
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT ReloadSound
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 2208); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2208); }
    }

    /// <summary>
    /// ObjectProperty: WeaponHitEvent
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT WeaponHitEvent
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 2216); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2216); }
    }

    /// <summary>
    /// ObjectProperty: FireWeaponAnimNode
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT FireWeaponAnimNode
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 2224); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2224); }
    }

    /// <summary>
    /// ObjectProperty: MaterialToUpdateWhenPresent
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT MaterialToUpdateWhenPresent
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 2232); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2232); }
    }

    /// <summary>
    /// ObjectProperty: MaterialOriginalToUpdateWhenPresent
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT MaterialOriginalToUpdateWhenPresent
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 2240); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2240); }
    }

    /// <summary>
    /// ObjectProperty: LockOnBeepSound
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT LockOnBeepSound
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 2248); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2248); }
    }

    /// <summary>
    /// ObjectProperty: LockOnBeepProportionParam
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT LockOnBeepProportionParam
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 2256); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2256); }
    }

    /// <summary>
    /// ObjectProperty: LockedOnSound
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT LockedOnSound
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 2264); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2264); }
    }

    /// <summary>
    /// ObjectProperty: LockedOnSoundOff
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT LockedOnSoundOff
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 2272); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2272); }
    }

    /// <summary>
    /// ObjectProperty: LockOnBeepSoundOff
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT LockOnBeepSoundOff
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 2280); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2280); }
    }

    /// <summary>
    /// FloatProperty: ReloadSoundDuration
    /// </summary>
    public unsafe float ReloadSoundDuration
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2288); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2288); }
    }

    /// <summary>
    /// StructProperty: CrosshairOrigin
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT CrosshairOrigin
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 2292); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2292); }
    }

    /// <summary>
    /// FloatProperty: LethalRadius
    /// </summary>
    public unsafe float LethalRadius
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2300); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2300); }
    }

    /// <summary>
    /// FloatProperty: LethalRange
    /// </summary>
    public unsafe float LethalRange
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2304); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2304); }
    }

    /// <summary>
    /// NameProperty: FireAnimNodeName
    /// </summary>
    public unsafe BmSDK.FName FireAnimNodeName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 2308); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2308); }
    }

    /// <summary>
    /// NameProperty: CustomFireAnimName
    /// </summary>
    public unsafe BmSDK.FName CustomFireAnimName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 2316); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2316); }
    }

    /// <summary>
    /// ArrayProperty: BonesToHideWhenNotPresent
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.FString> BonesToHideWhenNotPresent
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.FString>>(Ptr + 2324); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2324); }
    }

    /// <summary>
    /// NameProperty: BlendNodeToZeroWhenNotPresent
    /// </summary>
    public unsafe BmSDK.FName BlendNodeToZeroWhenNotPresent
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 2340); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2340); }
    }

    /// <summary>
    /// IntProperty: MaterialIndexToUpdateWhenPresent
    /// </summary>
    public unsafe int MaterialIndexToUpdateWhenPresent
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2348); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2348); }
    }

    /// <summary>
    /// NameProperty: OverrideCamera
    /// </summary>
    public unsafe BmSDK.FName OverrideCamera
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 2352); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2352); }
    }

    /// <summary>
    /// FloatProperty: PowerConsumption
    /// </summary>
    public unsafe float PowerConsumption
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2360); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2360); }
    }

    /// <summary>
    /// FloatProperty: SoundRadiusOrigin
    /// </summary>
    public unsafe float SoundRadiusOrigin
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2364); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2364); }
    }

    /// <summary>
    /// FloatProperty: SoundRadiusImpact
    /// </summary>
    public unsafe float SoundRadiusImpact
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2368); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2368); }
    }

    /// <summary>
    /// FloatProperty: SoundRadiusTrail
    /// </summary>
    public unsafe float SoundRadiusTrail
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2372); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2372); }
    }

    /// <summary>
    /// ByteProperty: CurrentLockOnSound
    /// </summary>
    public unsafe byte CurrentLockOnSound
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 2376); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2376); }
    }

    /// <summary>
    /// ByteProperty: CurrentHudDisplayLevel
    /// </summary>
    public unsafe byte CurrentHudDisplayLevel
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 2377); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2377); }
    }

    /// <summary>
    /// StrProperty: HeavyWeaponName
    /// </summary>
    public unsafe BmSDK.FString HeavyWeaponName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 2380); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2380); }
    }
}
