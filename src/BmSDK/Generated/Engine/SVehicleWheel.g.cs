#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Class: SVehicleWheel<br/>
/// (flags = 0)
/// </summary>
public partial class SVehicleWheel : BmSDK.Component, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Engine.SVehicleWheel", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal SVehicleWheel() { }

    /// <summary>
    /// Constructs a new SVehicleWheel
    /// </summary>
    public SVehicleWheel(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, SVehicleWheel Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected SVehicleWheel(nint ptr) : base(ptr) { }

    /// <summary>
    /// Struct: FVehicleRaycastHitData
    /// </summary>
    [StructLayout(LayoutKind.Explicit)]
    public partial record struct FVehicleRaycastHitData
    {
        /// <summary>
        /// BoolProperty: bValid
        /// </summary>
        public unsafe bool bValid
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 0) & 1) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 0); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 0); }; }
        }

        /// <summary>
        /// StructProperty: HitPlane
        /// </summary>
        public unsafe BmSDK.GameObject.FPlane HitPlane
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.GameObject.FPlane>(Ptr + 16); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 16); }; }
        }

        /// <summary>
        /// StructProperty: HitPxActor
        /// </summary>
        public unsafe System.IntPtr HitPxActor
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<System.IntPtr>(Ptr + 32); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 32); }; }
        }

        /// <summary>
        /// StructProperty: HitPxShape
        /// </summary>
        public unsafe System.IntPtr HitPxShape
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<System.IntPtr>(Ptr + 40); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 40); }; }
        }
    }

    /// <summary>
    /// Enum: ETyreType
    /// </summary>
    public enum ETyreType
    {
        ETyreType_ZeroFriction = 0,
        ETyreType_Batmobile = 1,
        ETyreType_BatmobileBattleMode = 2,
        ETyreType_BatmobileHandbrakeFront = 3,
        ETyreType_BatmobileHandbrakeRear = 4,
        ETyreType_BatmobileDriftFront = 5,
        ETyreType_BatmobileDriftRear = 6,
        ETyreType_BatmobileWheelspinFront = 7,
        ETyreType_BatmobileWheelspinRear = 8,
        ETyreType_BatmobileWheelspinBoost = 9,
        ETyreType_BatmobileTwoWheels = 10,
        ETyreType_BatmobileBrakeFront = 11,
        ETyreType_BatmobileBrakeRear = 12,
        ETyreType_Car = 13,
        ETyreType_Tank = 14,
        ETyreType_NpcWheelspin = 15,
        ETyreType_NpcTwoWheels = 16,
        ETyreType_MAX = 17,
    }

    /// <summary>
    /// Enum: EDrivableSurfaceMaterialType
    /// </summary>
    public enum EDrivableSurfaceMaterialType
    {
        DSMT_Default = 0,
        DSMT_Mud = 1,
        DSMT_FearGas = 2,
        DSMT_Wood = 3,
        DSMT_Water = 4,
        DSMT_Pollen = 5,
        DSMT_MAX = 6,
    }

    /// <summary>
    /// FloatProperty: Steer
    /// </summary>
    public unsafe float Steer
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 100); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 100); }
    }

    /// <summary>
    /// FloatProperty: MotorTorque
    /// </summary>
    public unsafe float MotorTorque
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 104); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 104); }
    }

    /// <summary>
    /// FloatProperty: BrakeTorque
    /// </summary>
    public unsafe float BrakeTorque
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 108); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 108); }
    }

    /// <summary>
    /// FloatProperty: ChassisTorque
    /// </summary>
    public unsafe float ChassisTorque
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 112); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 112); }
    }

    /// <summary>
    /// BoolProperty: bPoweredWheel
    /// </summary>
    public unsafe bool bPoweredWheel
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 116) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 116); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 116); }
    }

    /// <summary>
    /// BoolProperty: bHoverWheel
    /// </summary>
    public unsafe bool bHoverWheel
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 116) & 2) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 116); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 116); }
    }

    /// <summary>
    /// BoolProperty: bCollidesVehicles
    /// </summary>
    public unsafe bool bCollidesVehicles
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 116) & 4) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 116); var newMask = value ? (currentMask | 4) : (currentMask & ~4); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 116); }
    }

    /// <summary>
    /// BoolProperty: bCollidesPawns
    /// </summary>
    public unsafe bool bCollidesPawns
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 116) & 8) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 116); var newMask = value ? (currentMask | 8) : (currentMask & ~8); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 116); }
    }

    /// <summary>
    /// BoolProperty: bWheelOnGround
    /// </summary>
    public unsafe bool bWheelOnGround
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 116) & 16) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 116); var newMask = value ? (currentMask | 16) : (currentMask & ~16); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 116); }
    }

    /// <summary>
    /// BoolProperty: WheelBaseFakeRoad
    /// </summary>
    public unsafe bool WheelBaseFakeRoad
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 116) & 32) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 116); var newMask = value ? (currentMask | 32) : (currentMask & ~32); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 116); }
    }

    /// <summary>
    /// BoolProperty: OnCheckpointBlockadeSticky
    /// </summary>
    public unsafe bool OnCheckpointBlockadeSticky
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 116) & 64) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 116); var newMask = value ? (currentMask | 64) : (currentMask & ~64); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 116); }
    }

    /// <summary>
    /// FloatProperty: SteerFactor
    /// </summary>
    public unsafe float SteerFactor
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 120); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 120); }
    }

    /// <summary>
    /// NameProperty: SkelControlName
    /// </summary>
    public unsafe BmSDK.FName SkelControlName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 124); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 124); }
    }

    /// <summary>
    /// ObjectProperty: WheelControl
    /// </summary>
    public unsafe BmSDK.Engine.SkelControlWheel WheelControl
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.SkelControlWheel>(Ptr + 132); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 132); }
    }

    /// <summary>
    /// ObjectProperty: WheelParticleSystem
    /// </summary>
    public unsafe BmSDK.Engine.ParticleSystem WheelParticleSystem_0
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleSystem>(Ptr + 140); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 140); }
    }
    /// <summary>
    /// ObjectProperty: WheelParticleSystem
    /// </summary>
    public unsafe BmSDK.Engine.ParticleSystem WheelParticleSystem_1
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleSystem>(Ptr + 148); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 148); }
    }
    /// <summary>
    /// ObjectProperty: WheelParticleSystem
    /// </summary>
    public unsafe BmSDK.Engine.ParticleSystem WheelParticleSystem_2
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleSystem>(Ptr + 156); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 156); }
    }
    /// <summary>
    /// ObjectProperty: WheelParticleSystem
    /// </summary>
    public unsafe BmSDK.Engine.ParticleSystem WheelParticleSystem_3
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleSystem>(Ptr + 164); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 164); }
    }
    /// <summary>
    /// ObjectProperty: WheelParticleSystem
    /// </summary>
    public unsafe BmSDK.Engine.ParticleSystem WheelParticleSystem_4
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleSystem>(Ptr + 172); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 172); }
    }
    /// <summary>
    /// ObjectProperty: WheelParticleSystem
    /// </summary>
    public unsafe BmSDK.Engine.ParticleSystem WheelParticleSystem_5
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleSystem>(Ptr + 180); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 180); }
    }

    /// <summary>
    /// ObjectProperty: WheelSpinParticleSystem
    /// </summary>
    public unsafe BmSDK.Engine.ParticleSystem WheelSpinParticleSystem_0
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleSystem>(Ptr + 188); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 188); }
    }
    /// <summary>
    /// ObjectProperty: WheelSpinParticleSystem
    /// </summary>
    public unsafe BmSDK.Engine.ParticleSystem WheelSpinParticleSystem_1
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleSystem>(Ptr + 196); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 196); }
    }
    /// <summary>
    /// ObjectProperty: WheelSpinParticleSystem
    /// </summary>
    public unsafe BmSDK.Engine.ParticleSystem WheelSpinParticleSystem_2
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleSystem>(Ptr + 204); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 204); }
    }
    /// <summary>
    /// ObjectProperty: WheelSpinParticleSystem
    /// </summary>
    public unsafe BmSDK.Engine.ParticleSystem WheelSpinParticleSystem_3
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleSystem>(Ptr + 212); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 212); }
    }
    /// <summary>
    /// ObjectProperty: WheelSpinParticleSystem
    /// </summary>
    public unsafe BmSDK.Engine.ParticleSystem WheelSpinParticleSystem_4
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleSystem>(Ptr + 220); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 220); }
    }
    /// <summary>
    /// ObjectProperty: WheelSpinParticleSystem
    /// </summary>
    public unsafe BmSDK.Engine.ParticleSystem WheelSpinParticleSystem_5
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleSystem>(Ptr + 228); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 228); }
    }

    /// <summary>
    /// ObjectProperty: WheelSkidMarkSystem
    /// </summary>
    public unsafe BmSDK.Engine.ParticleSystem WheelSkidMarkSystem_0
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleSystem>(Ptr + 236); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 236); }
    }
    /// <summary>
    /// ObjectProperty: WheelSkidMarkSystem
    /// </summary>
    public unsafe BmSDK.Engine.ParticleSystem WheelSkidMarkSystem_1
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleSystem>(Ptr + 244); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 244); }
    }
    /// <summary>
    /// ObjectProperty: WheelSkidMarkSystem
    /// </summary>
    public unsafe BmSDK.Engine.ParticleSystem WheelSkidMarkSystem_2
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleSystem>(Ptr + 252); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 252); }
    }
    /// <summary>
    /// ObjectProperty: WheelSkidMarkSystem
    /// </summary>
    public unsafe BmSDK.Engine.ParticleSystem WheelSkidMarkSystem_3
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleSystem>(Ptr + 260); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 260); }
    }
    /// <summary>
    /// ObjectProperty: WheelSkidMarkSystem
    /// </summary>
    public unsafe BmSDK.Engine.ParticleSystem WheelSkidMarkSystem_4
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleSystem>(Ptr + 268); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 268); }
    }
    /// <summary>
    /// ObjectProperty: WheelSkidMarkSystem
    /// </summary>
    public unsafe BmSDK.Engine.ParticleSystem WheelSkidMarkSystem_5
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleSystem>(Ptr + 276); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 276); }
    }

    /// <summary>
    /// ObjectProperty: WheelBase
    /// </summary>
    public unsafe BmSDK.Engine.Actor WheelBase
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.Actor>(Ptr + 284); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 284); }
    }

    /// <summary>
    /// ObjectProperty: WheelBaseBI
    /// </summary>
    public unsafe BmSDK.Engine.RB_BodyInstance WheelBaseBI
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RB_BodyInstance>(Ptr + 292); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 292); }
    }

    /// <summary>
    /// ObjectProperty: WetnessParticleSystem
    /// </summary>
    public unsafe BmSDK.Engine.ParticleSystem WetnessParticleSystem_0
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleSystem>(Ptr + 300); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 300); }
    }
    /// <summary>
    /// ObjectProperty: WetnessParticleSystem
    /// </summary>
    public unsafe BmSDK.Engine.ParticleSystem WetnessParticleSystem_1
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleSystem>(Ptr + 308); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 308); }
    }
    /// <summary>
    /// ObjectProperty: WetnessParticleSystem
    /// </summary>
    public unsafe BmSDK.Engine.ParticleSystem WetnessParticleSystem_2
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleSystem>(Ptr + 316); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 316); }
    }
    /// <summary>
    /// ObjectProperty: WetnessParticleSystem
    /// </summary>
    public unsafe BmSDK.Engine.ParticleSystem WetnessParticleSystem_3
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleSystem>(Ptr + 324); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 324); }
    }
    /// <summary>
    /// ObjectProperty: WetnessParticleSystem
    /// </summary>
    public unsafe BmSDK.Engine.ParticleSystem WetnessParticleSystem_4
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleSystem>(Ptr + 332); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 332); }
    }
    /// <summary>
    /// ObjectProperty: WetnessParticleSystem
    /// </summary>
    public unsafe BmSDK.Engine.ParticleSystem WetnessParticleSystem_5
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleSystem>(Ptr + 340); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 340); }
    }

    /// <summary>
    /// ComponentProperty: WetnessParticleComp
    /// </summary>
    public unsafe BmSDK.Engine.ParticleSystemComponent WetnessParticleComp_0
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleSystemComponent>(Ptr + 348); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 348); }
    }
    /// <summary>
    /// ComponentProperty: WetnessParticleComp
    /// </summary>
    public unsafe BmSDK.Engine.ParticleSystemComponent WetnessParticleComp_1
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleSystemComponent>(Ptr + 356); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 356); }
    }
    /// <summary>
    /// ComponentProperty: WetnessParticleComp
    /// </summary>
    public unsafe BmSDK.Engine.ParticleSystemComponent WetnessParticleComp_2
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleSystemComponent>(Ptr + 364); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 364); }
    }
    /// <summary>
    /// ComponentProperty: WetnessParticleComp
    /// </summary>
    public unsafe BmSDK.Engine.ParticleSystemComponent WetnessParticleComp_3
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleSystemComponent>(Ptr + 372); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 372); }
    }
    /// <summary>
    /// ComponentProperty: WetnessParticleComp
    /// </summary>
    public unsafe BmSDK.Engine.ParticleSystemComponent WetnessParticleComp_4
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleSystemComponent>(Ptr + 380); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 380); }
    }
    /// <summary>
    /// ComponentProperty: WetnessParticleComp
    /// </summary>
    public unsafe BmSDK.Engine.ParticleSystemComponent WetnessParticleComp_5
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleSystemComponent>(Ptr + 388); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 388); }
    }

    /// <summary>
    /// ComponentProperty: WheelSkidMarkComp
    /// </summary>
    public unsafe BmSDK.Engine.ParticleSystemComponent WheelSkidMarkComp_0
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleSystemComponent>(Ptr + 396); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 396); }
    }
    /// <summary>
    /// ComponentProperty: WheelSkidMarkComp
    /// </summary>
    public unsafe BmSDK.Engine.ParticleSystemComponent WheelSkidMarkComp_1
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleSystemComponent>(Ptr + 404); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 404); }
    }
    /// <summary>
    /// ComponentProperty: WheelSkidMarkComp
    /// </summary>
    public unsafe BmSDK.Engine.ParticleSystemComponent WheelSkidMarkComp_2
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleSystemComponent>(Ptr + 412); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 412); }
    }
    /// <summary>
    /// ComponentProperty: WheelSkidMarkComp
    /// </summary>
    public unsafe BmSDK.Engine.ParticleSystemComponent WheelSkidMarkComp_3
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleSystemComponent>(Ptr + 420); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 420); }
    }
    /// <summary>
    /// ComponentProperty: WheelSkidMarkComp
    /// </summary>
    public unsafe BmSDK.Engine.ParticleSystemComponent WheelSkidMarkComp_4
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleSystemComponent>(Ptr + 428); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 428); }
    }
    /// <summary>
    /// ComponentProperty: WheelSkidMarkComp
    /// </summary>
    public unsafe BmSDK.Engine.ParticleSystemComponent WheelSkidMarkComp_5
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleSystemComponent>(Ptr + 436); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 436); }
    }

    /// <summary>
    /// ComponentProperty: WheelSpinParticleComp
    /// </summary>
    public unsafe BmSDK.Engine.ParticleSystemComponent WheelSpinParticleComp_0
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleSystemComponent>(Ptr + 444); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 444); }
    }
    /// <summary>
    /// ComponentProperty: WheelSpinParticleComp
    /// </summary>
    public unsafe BmSDK.Engine.ParticleSystemComponent WheelSpinParticleComp_1
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleSystemComponent>(Ptr + 452); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 452); }
    }
    /// <summary>
    /// ComponentProperty: WheelSpinParticleComp
    /// </summary>
    public unsafe BmSDK.Engine.ParticleSystemComponent WheelSpinParticleComp_2
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleSystemComponent>(Ptr + 460); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 460); }
    }
    /// <summary>
    /// ComponentProperty: WheelSpinParticleComp
    /// </summary>
    public unsafe BmSDK.Engine.ParticleSystemComponent WheelSpinParticleComp_3
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleSystemComponent>(Ptr + 468); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 468); }
    }
    /// <summary>
    /// ComponentProperty: WheelSpinParticleComp
    /// </summary>
    public unsafe BmSDK.Engine.ParticleSystemComponent WheelSpinParticleComp_4
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleSystemComponent>(Ptr + 476); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 476); }
    }
    /// <summary>
    /// ComponentProperty: WheelSpinParticleComp
    /// </summary>
    public unsafe BmSDK.Engine.ParticleSystemComponent WheelSpinParticleComp_5
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleSystemComponent>(Ptr + 484); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 484); }
    }

    /// <summary>
    /// ComponentProperty: WheelParticleComp
    /// </summary>
    public unsafe BmSDK.Engine.ParticleSystemComponent WheelParticleComp_0
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleSystemComponent>(Ptr + 492); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 492); }
    }
    /// <summary>
    /// ComponentProperty: WheelParticleComp
    /// </summary>
    public unsafe BmSDK.Engine.ParticleSystemComponent WheelParticleComp_1
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleSystemComponent>(Ptr + 500); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 500); }
    }
    /// <summary>
    /// ComponentProperty: WheelParticleComp
    /// </summary>
    public unsafe BmSDK.Engine.ParticleSystemComponent WheelParticleComp_2
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleSystemComponent>(Ptr + 508); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 508); }
    }
    /// <summary>
    /// ComponentProperty: WheelParticleComp
    /// </summary>
    public unsafe BmSDK.Engine.ParticleSystemComponent WheelParticleComp_3
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleSystemComponent>(Ptr + 516); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 516); }
    }
    /// <summary>
    /// ComponentProperty: WheelParticleComp
    /// </summary>
    public unsafe BmSDK.Engine.ParticleSystemComponent WheelParticleComp_4
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleSystemComponent>(Ptr + 524); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 524); }
    }
    /// <summary>
    /// ComponentProperty: WheelParticleComp
    /// </summary>
    public unsafe BmSDK.Engine.ParticleSystemComponent WheelParticleComp_5
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleSystemComponent>(Ptr + 532); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 532); }
    }

    /// <summary>
    /// ClassProperty: WheelPSCClass
    /// </summary>
    public unsafe BmSDK.Class WheelPSCClass
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Class>(Ptr + 540); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 540); }
    }

    /// <summary>
    /// NameProperty: BoneName
    /// </summary>
    public unsafe BmSDK.FName BoneName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 548); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 548); }
    }

    /// <summary>
    /// StructProperty: BoneOffset
    /// </summary>
    public unsafe System.Numerics.Vector3 BoneOffset
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 556); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 556); }
    }

    /// <summary>
    /// FloatProperty: WheelRadius
    /// </summary>
    public unsafe float WheelRadius
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 568); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 568); }
    }

    /// <summary>
    /// FloatProperty: WheelWidth
    /// </summary>
    public unsafe float WheelWidth
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 572); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 572); }
    }

    /// <summary>
    /// FloatProperty: SuspensionTravelUp
    /// </summary>
    public unsafe float SuspensionTravelUp
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 576); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 576); }
    }

    /// <summary>
    /// FloatProperty: SuspensionTravelDown
    /// </summary>
    public unsafe float SuspensionTravelDown
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 580); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 580); }
    }

    /// <summary>
    /// FloatProperty: SuspensionSpeedUp
    /// </summary>
    public unsafe float SuspensionSpeedUp
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 584); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 584); }
    }

    /// <summary>
    /// FloatProperty: SuspensionSpeedDown
    /// </summary>
    public unsafe float SuspensionSpeedDown
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 588); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 588); }
    }

    /// <summary>
    /// ByteProperty: CurDSMT
    /// </summary>
    public unsafe BmSDK.Engine.SVehicleWheel.EDrivableSurfaceMaterialType CurDSMT
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.SVehicleWheel.EDrivableSurfaceMaterialType>(Ptr + 592); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 592); }
    }

    /// <summary>
    /// ByteProperty: Side
    /// </summary>
    public unsafe BmSDK.Engine.SVehicleWheel.EWheelSide Side
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.SVehicleWheel.EWheelSide>(Ptr + 593); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 593); }
    }

    /// <summary>
    /// ByteProperty: FrontBackPos
    /// </summary>
    public unsafe BmSDK.Engine.SVehicleWheel.EWheelPos FrontBackPos
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.SVehicleWheel.EWheelPos>(Ptr + 594); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 594); }
    }

    /// <summary>
    /// ByteProperty: TyreType
    /// </summary>
    public unsafe BmSDK.Engine.SVehicleWheel.ETyreType TyreType
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.SVehicleWheel.ETyreType>(Ptr + 595); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 595); }
    }

    /// <summary>
    /// ByteProperty: HandbrakeTyreType
    /// </summary>
    public unsafe BmSDK.Engine.SVehicleWheel.ETyreType HandbrakeTyreType
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.SVehicleWheel.ETyreType>(Ptr + 596); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 596); }
    }

    /// <summary>
    /// ByteProperty: WheelspinTyreType
    /// </summary>
    public unsafe BmSDK.Engine.SVehicleWheel.ETyreType WheelspinTyreType
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.SVehicleWheel.ETyreType>(Ptr + 597); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 597); }
    }

    /// <summary>
    /// ByteProperty: DriftTyreType
    /// </summary>
    public unsafe BmSDK.Engine.SVehicleWheel.ETyreType DriftTyreType
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.SVehicleWheel.ETyreType>(Ptr + 598); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 598); }
    }

    /// <summary>
    /// ByteProperty: BrakeTyreType
    /// </summary>
    public unsafe BmSDK.Engine.SVehicleWheel.ETyreType BrakeTyreType
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.SVehicleWheel.ETyreType>(Ptr + 599); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 599); }
    }

    /// <summary>
    /// ByteProperty: WetnessParticleBattleModeOnly
    /// </summary>
    public unsafe byte WetnessParticleBattleModeOnly_0
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 600); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 600); }
    }
    /// <summary>
    /// ByteProperty: WetnessParticleBattleModeOnly
    /// </summary>
    public unsafe byte WetnessParticleBattleModeOnly_1
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 601); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 601); }
    }
    /// <summary>
    /// ByteProperty: WetnessParticleBattleModeOnly
    /// </summary>
    public unsafe byte WetnessParticleBattleModeOnly_2
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 602); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 602); }
    }
    /// <summary>
    /// ByteProperty: WetnessParticleBattleModeOnly
    /// </summary>
    public unsafe byte WetnessParticleBattleModeOnly_3
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 603); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 603); }
    }
    /// <summary>
    /// ByteProperty: WetnessParticleBattleModeOnly
    /// </summary>
    public unsafe byte WetnessParticleBattleModeOnly_4
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 604); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 604); }
    }
    /// <summary>
    /// ByteProperty: WetnessParticleBattleModeOnly
    /// </summary>
    public unsafe byte WetnessParticleBattleModeOnly_5
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 605); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 605); }
    }

    /// <summary>
    /// FloatProperty: MudTrailRemain
    /// </summary>
    public unsafe float MudTrailRemain
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 608); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 608); }
    }

    /// <summary>
    /// FloatProperty: Wobble
    /// </summary>
    public unsafe float Wobble
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 612); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 612); }
    }

    /// <summary>
    /// FloatProperty: WheelParticleSystemAlwaysOnThreshold
    /// </summary>
    public unsafe float WheelParticleSystemAlwaysOnThreshold
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 616); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 616); }
    }

    /// <summary>
    /// FloatProperty: LongSlipFactor
    /// </summary>
    public unsafe float LongSlipFactor
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 620); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 620); }
    }

    /// <summary>
    /// FloatProperty: LatSlipFactor
    /// </summary>
    public unsafe float LatSlipFactor
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 624); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 624); }
    }

    /// <summary>
    /// FloatProperty: HandbrakeLongSlipFactor
    /// </summary>
    public unsafe float HandbrakeLongSlipFactor
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 628); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 628); }
    }

    /// <summary>
    /// FloatProperty: HandbrakeLatSlipFactor
    /// </summary>
    public unsafe float HandbrakeLatSlipFactor
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 632); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 632); }
    }

    /// <summary>
    /// FloatProperty: ParkedSlipFactor
    /// </summary>
    public unsafe float ParkedSlipFactor
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 636); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 636); }
    }

    /// <summary>
    /// IntProperty: PhysxWheelIndex
    /// </summary>
    public unsafe int PhysxWheelIndex
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 640); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 640); }
    }

    /// <summary>
    /// FloatProperty: WheelTorqueFactor
    /// </summary>
    public unsafe float WheelTorqueFactor
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 644); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 644); }
    }

    /// <summary>
    /// StructProperty: WheelPosition
    /// </summary>
    public unsafe System.Numerics.Vector3 WheelPosition
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 648); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 648); }
    }

    /// <summary>
    /// FloatProperty: SpinVel
    /// </summary>
    public unsafe float SpinVel
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 660); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 660); }
    }

    /// <summary>
    /// FloatProperty: LongSlipRatio
    /// </summary>
    public unsafe float LongSlipRatio
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 664); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 664); }
    }

    /// <summary>
    /// FloatProperty: LatSlipAngle
    /// </summary>
    public unsafe float LatSlipAngle
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 668); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 668); }
    }

    /// <summary>
    /// StructProperty: ContactNormal
    /// </summary>
    public unsafe System.Numerics.Vector3 ContactNormal
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 672); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 672); }
    }

    /// <summary>
    /// StructProperty: ContactPoint
    /// </summary>
    public unsafe System.Numerics.Vector3 ContactPoint
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 684); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 684); }
    }

    /// <summary>
    /// StructProperty: LongDirection
    /// </summary>
    public unsafe System.Numerics.Vector3 LongDirection
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 696); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 696); }
    }

    /// <summary>
    /// StructProperty: LatDirection
    /// </summary>
    public unsafe System.Numerics.Vector3 LatDirection
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 708); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 708); }
    }

    /// <summary>
    /// FloatProperty: ContactForce
    /// </summary>
    public unsafe float ContactForce
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 720); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 720); }
    }

    /// <summary>
    /// FloatProperty: LongImpulse
    /// </summary>
    public unsafe float LongImpulse
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 724); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 724); }
    }

    /// <summary>
    /// FloatProperty: LatImpulse
    /// </summary>
    public unsafe float LatImpulse
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 728); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 728); }
    }

    /// <summary>
    /// FloatProperty: DesiredSuspensionPosition
    /// </summary>
    public unsafe float DesiredSuspensionPosition
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 732); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 732); }
    }

    /// <summary>
    /// FloatProperty: SuspensionPosition
    /// </summary>
    public unsafe float SuspensionPosition
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 736); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 736); }
    }

    /// <summary>
    /// FloatProperty: SuspensionDelta
    /// </summary>
    public unsafe float SuspensionDelta
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 740); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 740); }
    }

    /// <summary>
    /// FloatProperty: CurrentRotation
    /// </summary>
    public unsafe float CurrentRotation
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 744); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 744); }
    }

    /// <summary>
    /// StructProperty: WheelShape
    /// </summary>
    public unsafe System.IntPtr WheelShape
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.IntPtr>(Ptr + 748); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 748); }
    }

    /// <summary>
    /// IntProperty: WheelMaterialIndex
    /// </summary>
    public unsafe int WheelMaterialIndex
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 756); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 756); }
    }

    /// <summary>
    /// NameProperty: SlipParticleParamName
    /// </summary>
    public unsafe BmSDK.FName SlipParticleParamName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 760); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 760); }
    }

    /// <summary>
    /// NameProperty: WetnessParticleParamName
    /// </summary>
    public unsafe BmSDK.FName WetnessParticleParamName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 768); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 768); }
    }

    /// <summary>
    /// NameProperty: WetnessVelocityParamName
    /// </summary>
    public unsafe BmSDK.FName WetnessVelocityParamName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 776); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 776); }
    }

    /// <summary>
    /// NameProperty: WetnessSpinVelParamName
    /// </summary>
    public unsafe BmSDK.FName WetnessSpinVelParamName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 784); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 784); }
    }

    /// <summary>
    /// FloatProperty: DryingOffTime
    /// </summary>
    public unsafe float DryingOffTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 792); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 792); }
    }

    /// <summary>
    /// FloatProperty: CurrentWetness
    /// </summary>
    public unsafe float CurrentWetness
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 796); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 796); }
    }

    /// <summary>
    /// FloatProperty: BattleModeSteerBias
    /// </summary>
    public unsafe float BattleModeSteerBias
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 800); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 800); }
    }

    /// <summary>
    /// FloatProperty: PhysicsSteerBias
    /// </summary>
    public unsafe float PhysicsSteerBias
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 804); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 804); }
    }

    /// <summary>
    /// StructProperty: WheelVelocity
    /// </summary>
    public unsafe System.Numerics.Vector3 WheelVelocity
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 808); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 808); }
    }

    /// <summary>
    /// FloatProperty: SlipSpeed
    /// </summary>
    public unsafe float SlipSpeed
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 820); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 820); }
    }

    /// <summary>
    /// StructProperty: LastRaycastData
    /// </summary>
    public unsafe BmSDK.Engine.SVehicleWheel.FVehicleRaycastHitData LastRaycastData
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.SVehicleWheel.FVehicleRaycastHitData>(Ptr + 832); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 832); }
    }

    /// <summary>
    /// Enum: EWheelPos
    /// </summary>
    public enum EWheelPos
    {
        WP_None = 0,
        WP_FrontWheel = 1,
        WP_RearWheel = 2,
        WP_MAX = 3,
    }

    /// <summary>
    /// Enum: EWheelSide
    /// </summary>
    public enum EWheelSide
    {
        SIDE_None = 0,
        SIDE_Left = 1,
        SIDE_Right = 2,
        SIDE_MAX = 3,
    }
}
