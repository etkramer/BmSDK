#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Class: PhysXParticleSystem<br/>
/// (size = 0)
/// (flags = 0)
/// </summary>
public partial class PhysXParticleSystem : BmSDK.GameObject, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Engine.PhysXParticleSystem", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal PhysXParticleSystem() { }

    /// <summary>
    /// Constructs a new PhysXParticleSystem
    /// </summary>
    public PhysXParticleSystem(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, PhysXParticleSystem Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected PhysXParticleSystem(nint ptr) : base(ptr) { }

    /// <summary>
    /// IntProperty: MaxParticles
    /// </summary>
    public unsafe int MaxParticles
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 84); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 84); }
    }

    /// <summary>
    /// IntProperty: ParticleSpawnReserve
    /// </summary>
    public unsafe int ParticleSpawnReserve
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 88); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 88); }
    }

    /// <summary>
    /// ByteProperty: RBChannel
    /// </summary>
    public unsafe byte RBChannel
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 92); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 92); }
    }

    /// <summary>
    /// ByteProperty: SimulationMethod
    /// </summary>
    public unsafe byte SimulationMethod
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 93); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 93); }
    }

    /// <summary>
    /// ByteProperty: PacketSizeMultiplier
    /// </summary>
    public unsafe byte PacketSizeMultiplier
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 94); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 94); }
    }

    /// <summary>
    /// StructProperty: RBCollideWithChannels
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT RBCollideWithChannels
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 96); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 96); }
    }

    /// <summary>
    /// FloatProperty: CollisionDistance
    /// </summary>
    public unsafe float CollisionDistance
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 100); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 100); }
    }

    /// <summary>
    /// FloatProperty: RestitutionWithStaticShapes
    /// </summary>
    public unsafe float RestitutionWithStaticShapes
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 104); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 104); }
    }

    /// <summary>
    /// FloatProperty: RestitutionWithDynamicShapes
    /// </summary>
    public unsafe float RestitutionWithDynamicShapes
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 108); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 108); }
    }

    /// <summary>
    /// FloatProperty: FrictionWithStaticShapes
    /// </summary>
    public unsafe float FrictionWithStaticShapes
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 112); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 112); }
    }

    /// <summary>
    /// FloatProperty: FrictionWithDynamicShapes
    /// </summary>
    public unsafe float FrictionWithDynamicShapes
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 116); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 116); }
    }

    /// <summary>
    /// FloatProperty: StaticFrictionWithStaticShapes
    /// </summary>
    public unsafe float StaticFrictionWithStaticShapes
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 120); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 120); }
    }

    /// <summary>
    /// FloatProperty: StaticFrictionWithDynamicShapes
    /// </summary>
    public unsafe float StaticFrictionWithDynamicShapes
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 124); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 124); }
    }

    /// <summary>
    /// BoolProperty: bDynamicCollision
    /// </summary>
    public unsafe bool bDynamicCollision
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 128) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 128); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 128); }
    }

    /// <summary>
    /// BoolProperty: bDisableGravity
    /// </summary>
    public unsafe bool bDisableGravity
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 128) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 128); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 128); }
    }

    /// <summary>
    /// BoolProperty: bStaticCollision
    /// </summary>
    public unsafe bool bStaticCollision
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 128) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 128); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 128); }
    }

    /// <summary>
    /// BoolProperty: bTwoWayCollision
    /// </summary>
    public unsafe bool bTwoWayCollision
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 128) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 128); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 128); }
    }

    /// <summary>
    /// BoolProperty: bDestroy
    /// </summary>
    public unsafe bool bDestroy
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 128) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 128); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 128); }
    }

    /// <summary>
    /// BoolProperty: bSyncFailed
    /// </summary>
    public unsafe bool bSyncFailed
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 128) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 128); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 128); }
    }

    /// <summary>
    /// BoolProperty: bIsInGame
    /// </summary>
    public unsafe bool bIsInGame
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 128) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 128); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 128); }
    }

    /// <summary>
    /// FloatProperty: MaxMotionDistance
    /// </summary>
    public unsafe float MaxMotionDistance
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 132); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 132); }
    }

    /// <summary>
    /// FloatProperty: Damping
    /// </summary>
    public unsafe float Damping
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 136); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 136); }
    }

    /// <summary>
    /// StructProperty: ExternalAcceleration
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT ExternalAcceleration
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 140); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 140); }
    }

    /// <summary>
    /// FloatProperty: RestParticleDistance
    /// </summary>
    public unsafe float RestParticleDistance
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 152); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 152); }
    }

    /// <summary>
    /// FloatProperty: RestDensity
    /// </summary>
    public unsafe float RestDensity
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 156); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 156); }
    }

    /// <summary>
    /// FloatProperty: KernelRadiusMultiplier
    /// </summary>
    public unsafe float KernelRadiusMultiplier
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 160); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 160); }
    }

    /// <summary>
    /// FloatProperty: Stiffness
    /// </summary>
    public unsafe float Stiffness
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 164); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 164); }
    }

    /// <summary>
    /// FloatProperty: Viscosity
    /// </summary>
    public unsafe float Viscosity
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 168); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 168); }
    }

    /// <summary>
    /// FloatProperty: CollisionResponseCoefficient
    /// </summary>
    public unsafe float CollisionResponseCoefficient
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 172); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 172); }
    }

    /// <summary>
    /// IntProperty: ParticleReserve
    /// </summary>
    public unsafe int ParticleReserve
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 176); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 176); }
    }

    /// <summary>
    /// StructProperty: CascadeScene
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT CascadeScene
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 180); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 180); }
    }

    /// <summary>
    /// StructProperty: PSys
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT PSys
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 188); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 188); }
    }

    /// <summary>
    /// Enum: EPacketSizeMultiplier
    /// </summary>
    public enum EPacketSizeMultiplier
    {
        EPSM = 0,
        EPSM_2 = 1,
        EPSM_3 = 2,
        EPSM_4 = 3,
        EPSM_5 = 4,
        EPSM_6 = 5,
        EPSM_MAX = 6,
    }

    /// <summary>
    /// Enum: ESimulationMethod
    /// </summary>
    public enum ESimulationMethod
    {
        ESM_SPH = 0,
        ESM_NO_PARTICLE_INTERACTION = 1,
        ESM_MIXED_MODE = 2,
        ESM_MAX = 3,
    }
}
