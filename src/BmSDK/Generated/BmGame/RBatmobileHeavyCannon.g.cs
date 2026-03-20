#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RBatmobileHeavyCannon<br/>
/// (flags = 0)
/// </summary>
public partial class RBatmobileHeavyCannon : BmSDK.BmGame.RVehicleWeapon, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RBatmobileHeavyCannon", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RBatmobileHeavyCannon() { }

    /// <summary>
    /// Constructs a new RBatmobileHeavyCannon
    /// </summary>
    public RBatmobileHeavyCannon(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RBatmobileHeavyCannon Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RBatmobileHeavyCannon(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="Engine.Actor.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RBatmobileHeavyCannon>
        => ((Engine.Actor)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="Engine.Actor.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RBatmobileHeavyCannon>, new()
        => (TComponent)((Engine.Actor)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="Engine.Actor.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RBatmobileHeavyCannon>
        => ((Engine.Actor)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="Engine.Actor.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RBatmobileHeavyCannon>
        => ((Engine.Actor)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="Engine.Actor.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RBatmobileHeavyCannon>
        => (TComponent)((Engine.Actor)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="Engine.Actor.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RBatmobileHeavyCannon>
        => ((Engine.Actor)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="Engine.Actor.DetachScriptComponent(Type)"/>
    public void DetachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RBatmobileHeavyCannon>
        => ((Engine.Actor)this).DetachScriptComponent(typeof(TComponent));

    /// <summary>
    /// ObjectProperty: ProjectileArchetype
    /// </summary>
    public unsafe BmSDK.BmGame.RProjectile ProjectileArchetype
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RProjectile>(Ptr + 2396); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2396); }
    }

    /// <summary>
    /// ObjectProperty: UpgradedBodyShotProjectileArchetype
    /// </summary>
    public unsafe BmSDK.BmGame.RProjectile UpgradedBodyShotProjectileArchetype
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RProjectile>(Ptr + 2404); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2404); }
    }

    /// <summary>
    /// ObjectProperty: UpgradedHeadShotProjectileArchetype
    /// </summary>
    public unsafe BmSDK.BmGame.RProjectile UpgradedHeadShotProjectileArchetype
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RProjectile>(Ptr + 2412); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2412); }
    }

    /// <summary>
    /// ObjectProperty: BothUpgradesProjectileArchetype
    /// </summary>
    public unsafe BmSDK.BmGame.RProjectile BothUpgradesProjectileArchetype
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RProjectile>(Ptr + 2420); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2420); }
    }

    /// <summary>
    /// ObjectProperty: FireFX
    /// </summary>
    public unsafe BmSDK.Engine.ParticleSystem FireFX
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleSystem>(Ptr + 2428); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2428); }
    }

    /// <summary>
    /// ObjectProperty: FireSound
    /// </summary>
    public unsafe BmSDK.Engine.AkEvent FireSound
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkEvent>(Ptr + 2436); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2436); }
    }

    /// <summary>
    /// ObjectProperty: CurrentLockOnTarget
    /// </summary>
    public unsafe BmSDK.Engine.Actor CurrentLockOnTarget
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.Actor>(Ptr + 2444); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2444); }
    }

    /// <summary>
    /// ObjectProperty: HeavyCannonFFWaveForm
    /// </summary>
    public unsafe BmSDK.Engine.ForceFeedbackWaveform HeavyCannonFFWaveForm
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ForceFeedbackWaveform>(Ptr + 2452); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2452); }
    }

    /// <summary>
    /// FloatProperty: RecoilImpulse
    /// </summary>
    public unsafe float RecoilImpulse
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2460); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2460); }
    }

    /// <summary>
    /// FloatProperty: RecoilImpulsePitch
    /// </summary>
    public unsafe float RecoilImpulsePitch
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2464); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2464); }
    }

    /// <summary>
    /// IntProperty: FirePitchOffset
    /// </summary>
    public unsafe int FirePitchOffset
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2468); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2468); }
    }

    /// <summary>
    /// IntProperty: ChargeShakeId
    /// </summary>
    public unsafe int ChargeShakeId
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2472); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2472); }
    }

    /// <summary>
    /// FloatProperty: LockOnRange
    /// </summary>
    public unsafe float LockOnRange
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2476); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2476); }
    }

    /// <summary>
    /// FloatProperty: LockOnAngle
    /// </summary>
    public unsafe float LockOnAngle
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2480); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2480); }
    }

    /// <summary>
    /// BoolProperty: AllowChargedShot
    /// </summary>
    public unsafe bool AllowChargedShot
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2484) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2484); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2484); }
    }

    /// <summary>
    /// BoolProperty: bCanHurtThugs
    /// </summary>
    public unsafe bool bCanHurtThugs
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2484) & 2) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2484); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2484); }
    }

    /// <summary>
    /// BoolProperty: ChargingShot
    /// </summary>
    public unsafe bool ChargingShot
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2484) & 4) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2484); var newMask = value ? (currentMask | 4) : (currentMask & ~4); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2484); }
    }

    /// <summary>
    /// BoolProperty: bWeaponHit
    /// </summary>
    public unsafe bool bWeaponHit
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2484) & 8) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2484); var newMask = value ? (currentMask | 8) : (currentMask & ~8); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2484); }
    }

    /// <summary>
    /// BoolProperty: bHeavyCannonLure
    /// </summary>
    public unsafe bool bHeavyCannonLure
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2484) & 16) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2484); var newMask = value ? (currentMask | 16) : (currentMask & ~16); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2484); }
    }

    /// <summary>
    /// FloatProperty: LockOnTimeMin
    /// </summary>
    public unsafe float LockOnTimeMin
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2488); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2488); }
    }

    /// <summary>
    /// FloatProperty: LockOnTimeMax
    /// </summary>
    public unsafe float LockOnTimeMax
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2492); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2492); }
    }

    /// <summary>
    /// FloatProperty: CurrentLockOn
    /// </summary>
    public unsafe float CurrentLockOn
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2496); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2496); }
    }

    /// <summary>
    /// StructProperty: FireScreenShake
    /// </summary>
    public unsafe BmSDK.BmGame.RBMScreenShakeModifier.FBMScreenShakeStruct FireScreenShake
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RBMScreenShakeModifier.FBMScreenShakeStruct>(Ptr + 2500); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2500); }
    }

    /// <summary>
    /// StructProperty: ChargingScreenShake
    /// </summary>
    public unsafe BmSDK.BmGame.RBMScreenShakeModifier.FBMScreenShakeStruct ChargingScreenShake
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RBMScreenShakeModifier.FBMScreenShakeStruct>(Ptr + 2656); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2656); }
    }

    /// <summary>
    /// FloatProperty: ChargingDelay
    /// </summary>
    public unsafe float ChargingDelay
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2812); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2812); }
    }

    /// <summary>
    /// FloatProperty: ChargeUpTime
    /// </summary>
    public unsafe float ChargeUpTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2816); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2816); }
    }

    /// <summary>
    /// FloatProperty: ChargeMaxDamageRadius
    /// </summary>
    public unsafe float ChargeMaxDamageRadius
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2820); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2820); }
    }

    /// <summary>
    /// FloatProperty: ChargeMaxDamageMultiplier
    /// </summary>
    public unsafe float ChargeMaxDamageMultiplier
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2824); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2824); }
    }

    /// <summary>
    /// StructProperty: ChaingunAimOffset
    /// </summary>
    public unsafe System.Numerics.Vector3 ChaingunAimOffset
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 2828); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2828); }
    }

    /// <summary>
    /// FloatProperty: ChargeTime
    /// </summary>
    public unsafe float ChargeTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2840); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2840); }
    }

    /// <summary>
    /// FloatProperty: ChargeProp
    /// </summary>
    public unsafe float ChargeProp
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2844); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2844); }
    }

    /// <summary>
    /// ArrayProperty: UpgradedReloadTime
    /// </summary>
    public unsafe BmSDK.TArray<float> UpgradedReloadTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<float>>(Ptr + 2848); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2848); }
    }

    /// <summary>
    /// ByteProperty: CoolDownAnim
    /// </summary>
    public unsafe byte CoolDownAnim
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 2864); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2864); }
    }
}
