#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RBatmobileMissileLauncher<br/>
/// (size = 0)
/// (flags = 0)
/// </summary>
public partial class RBatmobileMissileLauncher : BmSDK.BmGame.RVehicleWeapon, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RBatmobileMissileLauncher", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RBatmobileMissileLauncher() { }

    /// <summary>
    /// Constructs a new RBatmobileMissileLauncher
    /// </summary>
    public RBatmobileMissileLauncher(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RBatmobileMissileLauncher Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RBatmobileMissileLauncher(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="Engine.Actor.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RBatmobileMissileLauncher>
        => ((Engine.Actor)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="Engine.Actor.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RBatmobileMissileLauncher>, new()
        => (TComponent)((Engine.Actor)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="Engine.Actor.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RBatmobileMissileLauncher>
        => ((Engine.Actor)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="Engine.Actor.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RBatmobileMissileLauncher>
        => ((Engine.Actor)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="Engine.Actor.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RBatmobileMissileLauncher>
        => (TComponent)((Engine.Actor)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="Engine.Actor.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RBatmobileMissileLauncher>
        => ((Engine.Actor)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="Engine.Actor.DetachScriptComponent(Type)"/>
    public void DetachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RBatmobileMissileLauncher>
        => ((Engine.Actor)this).DetachScriptComponent(typeof(TComponent));

    /// <summary>
    /// IntProperty: MaxTargets
    /// </summary>
    public unsafe int MaxTargets
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2396); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2396); }
    }

    /// <summary>
    /// ArrayProperty: CurrentTargets
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.FString>>>>>> CurrentTargets
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.FString>>>>>>>(Ptr + 2400); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2400); }
    }

    /// <summary>
    /// ArrayProperty: LastTargets
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.FString>>>>> LastTargets
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.FString>>>>>>(Ptr + 2416); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2416); }
    }

    /// <summary>
    /// FloatProperty: LockOnAngle
    /// </summary>
    public unsafe float LockOnAngle
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2432); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2432); }
    }

    /// <summary>
    /// FloatProperty: LockOnRange
    /// </summary>
    public unsafe float LockOnRange
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2436); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2436); }
    }

    /// <summary>
    /// FloatProperty: InitialFireDelay
    /// </summary>
    public unsafe float InitialFireDelay
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2440); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2440); }
    }

    /// <summary>
    /// FloatProperty: FireInterval
    /// </summary>
    public unsafe float FireInterval
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2444); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2444); }
    }

    /// <summary>
    /// FloatProperty: CooldownDelay
    /// </summary>
    public unsafe float CooldownDelay
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2448); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2448); }
    }

    /// <summary>
    /// ObjectProperty: MissileClass
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT MissileClass
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 2452); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2452); }
    }

    /// <summary>
    /// ObjectProperty: FireFX
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT FireFX
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 2460); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2460); }
    }

    /// <summary>
    /// ObjectProperty: LockOnSound
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT LockOnSound
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 2468); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2468); }
    }

    /// <summary>
    /// ObjectProperty: ConfirmLockOn
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT ConfirmLockOn
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 2476); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2476); }
    }

    /// <summary>
    /// ObjectProperty: LockOffSound
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT LockOffSound
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 2484); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2484); }
    }

    /// <summary>
    /// ObjectProperty: TargetSwitchName
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT TargetSwitchName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 2492); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2492); }
    }

    /// <summary>
    /// ObjectProperty: LastTargetSwitchName
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT LastTargetSwitchName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 2500); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2500); }
    }

    /// <summary>
    /// ObjectProperty: MissileNumberParameter
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT MissileNumberParameter
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 2508); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2508); }
    }

    /// <summary>
    /// ObjectProperty: FinalExplosionSweetener
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT FinalExplosionSweetener
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 2516); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2516); }
    }

    /// <summary>
    /// ObjectProperty: MissileFFWaveForm
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT MissileFFWaveForm
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 2524); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2524); }
    }

    /// <summary>
    /// ObjectProperty: NotEnoughEnergyThought
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT NotEnoughEnergyThought
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 2532); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2532); }
    }

    /// <summary>
    /// ObjectProperty: InvalidHeavyTankAngleThought
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT InvalidHeavyTankAngleThought
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 2540); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2540); }
    }

    /// <summary>
    /// StructProperty: LaunchRotationOffset
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT LaunchRotationOffset
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 2548); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2548); }
    }

    /// <summary>
    /// IntProperty: NthTarget
    /// </summary>
    public unsafe int NthTarget
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2560); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2560); }
    }

    /// <summary>
    /// NameProperty: LastState
    /// </summary>
    public unsafe BmSDK.FName LastState
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 2564); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2564); }
    }

    /// <summary>
    /// ArrayProperty: VolleyDamageMultiplier
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.FString>>>> VolleyDamageMultiplier
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.FString>>>>>(Ptr + 2572); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2572); }
    }

    /// <summary>
    /// IntProperty: CurrentLevel
    /// </summary>
    public unsafe int CurrentLevel
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2588); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2588); }
    }

    /// <summary>
    /// ArrayProperty: MaxTargetsPerLevel
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.FString>>> MaxTargetsPerLevel
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.FString>>>>(Ptr + 2592); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2592); }
    }

    /// <summary>
    /// ArrayProperty: MissileSockets
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.TArray<BmSDK.FString>> MissileSockets
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.TArray<BmSDK.FString>>>(Ptr + 2608); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2608); }
    }

    /// <summary>
    /// IntProperty: CurrentMissileSocket
    /// </summary>
    public unsafe int CurrentMissileSocket
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2624); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2624); }
    }

    /// <summary>
    /// FloatProperty: InfinitMissilesTime
    /// </summary>
    public unsafe float InfinitMissilesTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2628); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2628); }
    }

    /// <summary>
    /// ArrayProperty: FiredProjectiles
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.FString> FiredProjectiles
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.FString>>(Ptr + 2632); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2632); }
    }
}
