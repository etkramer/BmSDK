#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RBatmobileSonar<br/>
/// (flags = 0)
/// </summary>
public partial class RBatmobileSonar : BmSDK.BmGame.RVehicleWeapon, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RBatmobileSonar", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RBatmobileSonar() { }

    /// <summary>
    /// Constructs a new RBatmobileSonar
    /// </summary>
    public RBatmobileSonar(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RBatmobileSonar Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RBatmobileSonar(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="Engine.Actor.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RBatmobileSonar>
        => ((Engine.Actor)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="Engine.Actor.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RBatmobileSonar>, new()
        => (TComponent)((Engine.Actor)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="Engine.Actor.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RBatmobileSonar>
        => ((Engine.Actor)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="Engine.Actor.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RBatmobileSonar>
        => ((Engine.Actor)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="Engine.Actor.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RBatmobileSonar>
        => (TComponent)((Engine.Actor)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="Engine.Actor.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RBatmobileSonar>
        => ((Engine.Actor)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="Engine.Actor.DetachScriptComponent(Type)"/>
    public void DetachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RBatmobileSonar>
        => ((Engine.Actor)this).DetachScriptComponent(typeof(TComponent));

    /// <summary>
    /// FloatProperty: CoolDownTime
    /// </summary>
    public unsafe float CoolDownTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2396); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2396); }
    }

    /// <summary>
    /// FloatProperty: ChargeUpDelay
    /// </summary>
    public unsafe float ChargeUpDelay
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2400); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2400); }
    }

    /// <summary>
    /// FloatProperty: ChargeUpTime
    /// </summary>
    public unsafe float ChargeUpTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2404); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2404); }
    }

    /// <summary>
    /// StructProperty: ChargingScreenShake
    /// </summary>
    public unsafe BmSDK.BmGame.RBMScreenShakeModifier.FBMScreenShakeStruct ChargingScreenShake
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RBMScreenShakeModifier.FBMScreenShakeStruct>(Ptr + 2408); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2408); }
    }

    /// <summary>
    /// BoolProperty: ChargingShot
    /// </summary>
    public unsafe bool ChargingShot
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2564) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2564); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2564); }
    }

    /// <summary>
    /// BoolProperty: BatmobileMovementStopped
    /// </summary>
    public unsafe bool BatmobileMovementStopped
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2564) & 2) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2564); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2564); }
    }

    /// <summary>
    /// BoolProperty: FireButtonHeld
    /// </summary>
    public unsafe bool FireButtonHeld
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2564) & 4) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2564); var newMask = value ? (currentMask | 4) : (currentMask & ~4); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2564); }
    }

    /// <summary>
    /// BoolProperty: bScannerActive
    /// </summary>
    public unsafe bool bScannerActive
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2564) & 8) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2564); var newMask = value ? (currentMask | 8) : (currentMask & ~8); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2564); }
    }

    /// <summary>
    /// BoolProperty: bSonarGadget
    /// </summary>
    public unsafe bool bSonarGadget
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2564) & 16) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2564); var newMask = value ? (currentMask | 16) : (currentMask & ~16); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2564); }
    }

    /// <summary>
    /// BoolProperty: bFirstPulse
    /// </summary>
    public unsafe bool bFirstPulse
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2564) & 32) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2564); var newMask = value ? (currentMask | 32) : (currentMask & ~32); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2564); }
    }

    /// <summary>
    /// FloatProperty: ChargeTime
    /// </summary>
    public unsafe float ChargeTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2568); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2568); }
    }

    /// <summary>
    /// IntProperty: ChargeShakeId
    /// </summary>
    public unsafe int ChargeShakeId
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2572); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2572); }
    }

    /// <summary>
    /// ObjectProperty: ScanParticle
    /// </summary>
    public unsafe BmSDK.Engine.ParticleSystem ScanParticle
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleSystem>(Ptr + 2576); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2576); }
    }

    /// <summary>
    /// ObjectProperty: ScanSound
    /// </summary>
    public unsafe BmSDK.Engine.AkEvent ScanSound
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkEvent>(Ptr + 2584); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2584); }
    }

    /// <summary>
    /// ObjectProperty: ScanFFWaveForm
    /// </summary>
    public unsafe BmSDK.Engine.ForceFeedbackWaveform ScanFFWaveForm
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ForceFeedbackWaveform>(Ptr + 2592); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2592); }
    }

    /// <summary>
    /// ObjectProperty: ChargeStartSound
    /// </summary>
    public unsafe BmSDK.Engine.AkEvent ChargeStartSound
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkEvent>(Ptr + 2600); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2600); }
    }

    /// <summary>
    /// ObjectProperty: ChargeStopSound
    /// </summary>
    public unsafe BmSDK.Engine.AkEvent ChargeStopSound
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkEvent>(Ptr + 2608); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2608); }
    }

    /// <summary>
    /// ObjectProperty: BlastParticle
    /// </summary>
    public unsafe BmSDK.Engine.ParticleSystem BlastParticle
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleSystem>(Ptr + 2616); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2616); }
    }

    /// <summary>
    /// ObjectProperty: BlastSound
    /// </summary>
    public unsafe BmSDK.Engine.AkEvent BlastSound
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkEvent>(Ptr + 2624); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2624); }
    }

    /// <summary>
    /// ObjectProperty: BasicScanEffect
    /// </summary>
    public unsafe BmSDK.Engine.ParticleSystem BasicScanEffect
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleSystem>(Ptr + 2632); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2632); }
    }

    /// <summary>
    /// ObjectProperty: BasicScanSound
    /// </summary>
    public unsafe BmSDK.Engine.AkEvent BasicScanSound
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkEvent>(Ptr + 2640); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2640); }
    }

    /// <summary>
    /// ObjectProperty: ScanningTank
    /// </summary>
    public unsafe BmSDK.BmGame.RVehicleHeavyTank ScanningTank
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RVehicleHeavyTank>(Ptr + 2648); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2648); }
    }

    /// <summary>
    /// ObjectProperty: VehicleScannerMaterial
    /// </summary>
    public unsafe BmSDK.Engine.MaterialInterface VehicleScannerMaterial
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.MaterialInterface>(Ptr + 2656); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2656); }
    }

    /// <summary>
    /// ObjectProperty: ObjectScannerMaterial
    /// </summary>
    public unsafe BmSDK.Engine.MaterialInterface ObjectScannerMaterial
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.MaterialInterface>(Ptr + 2664); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2664); }
    }

    /// <summary>
    /// ObjectProperty: ScannerOnSound
    /// </summary>
    public unsafe BmSDK.Engine.AkEvent ScannerOnSound
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkEvent>(Ptr + 2672); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2672); }
    }

    /// <summary>
    /// ObjectProperty: ScannerOffSound
    /// </summary>
    public unsafe BmSDK.Engine.AkEvent ScannerOffSound
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkEvent>(Ptr + 2680); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2680); }
    }

    /// <summary>
    /// StructProperty: ScanScreenShake
    /// </summary>
    public unsafe BmSDK.BmGame.RBMScreenShakeModifier.FBMScreenShakeStruct ScanScreenShake
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RBMScreenShakeModifier.FBMScreenShakeStruct>(Ptr + 2688); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2688); }
    }

    /// <summary>
    /// StructProperty: BlastScreenShake
    /// </summary>
    public unsafe BmSDK.BmGame.RBMScreenShakeModifier.FBMScreenShakeStruct BlastScreenShake
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RBMScreenShakeModifier.FBMScreenShakeStruct>(Ptr + 2844); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2844); }
    }

    /// <summary>
    /// FloatProperty: KnockDownThugsRange
    /// </summary>
    public unsafe float KnockDownThugsRange
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 3000); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3000); }
    }

    /// <summary>
    /// FloatProperty: StunThugsRange
    /// </summary>
    public unsafe float StunThugsRange
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 3004); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3004); }
    }

    /// <summary>
    /// FloatProperty: AlertVehiclesRange
    /// </summary>
    public unsafe float AlertVehiclesRange
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 3008); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3008); }
    }

    /// <summary>
    /// FloatProperty: VehicleScanRange
    /// </summary>
    public unsafe float VehicleScanRange
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 3012); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3012); }
    }

    /// <summary>
    /// FloatProperty: VehicleScanAngle
    /// </summary>
    public unsafe float VehicleScanAngle
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 3016); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3016); }
    }

    /// <summary>
    /// FloatProperty: ScanPct
    /// </summary>
    public unsafe float ScanPct
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 3020); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3020); }
    }

    /// <summary>
    /// FloatProperty: ScannerSpeed
    /// </summary>
    public unsafe float ScannerSpeed
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 3024); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3024); }
    }

    /// <summary>
    /// FloatProperty: ScanDuration
    /// </summary>
    public unsafe float ScanDuration
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 3028); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3028); }
    }

    /// <summary>
    /// ArrayProperty: MaterialPool
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.Engine.MaterialInstanceConstant> MaterialPool
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.MaterialInstanceConstant>>(Ptr + 3032); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3032); }
    }

    /// <summary>
    /// ArrayProperty: MeshPool
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.Engine.SkeletalMeshComponent> MeshPool
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.SkeletalMeshComponent>>(Ptr + 3048); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3048); }
    }

    /// <summary>
    /// IntProperty: MaxScannedVehicles
    /// </summary>
    public unsafe int MaxScannedVehicles
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3064); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3064); }
    }

    /// <summary>
    /// ArrayProperty: ScannedMeshes
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RBatmobileSonar.FScannedVehicleMesh> ScannedMeshes
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RBatmobileSonar.FScannedVehicleMesh>>(Ptr + 3068); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3068); }
    }
}
