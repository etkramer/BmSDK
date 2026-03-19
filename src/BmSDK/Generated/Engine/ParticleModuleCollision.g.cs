#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Class: ParticleModuleCollision<br/>
/// (size = 0)
/// (flags = 0)
/// </summary>
public partial class ParticleModuleCollision : BmSDK.Engine.ParticleModuleCollisionBase, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Engine.ParticleModuleCollision", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal ParticleModuleCollision() { }

    /// <summary>
    /// Constructs a new ParticleModuleCollision
    /// </summary>
    public ParticleModuleCollision(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, ParticleModuleCollision Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected ParticleModuleCollision(nint ptr) : base(ptr) { }

    /// <summary>
    /// StructProperty: DampingFactor
    /// </summary>
    public unsafe BmSDK.Engine.ParticleModuleCollision.DampingFactorRotation DampingFactor
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleModuleCollision.DampingFactorRotation>(Ptr + 96); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 96); }
    }

    /// <summary>
    /// StructProperty: DampingFactorRotation
    /// </summary>
    public unsafe BmSDK.Engine.ParticleModuleCollision.MaxCollisions DampingFactorRotation
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleModuleCollision.MaxCollisions>(Ptr + 160); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 160); }
    }

    /// <summary>
    /// StructProperty: MaxCollisions
    /// </summary>
    public unsafe BmSDK.Engine.ParticleModuleCollision.ParticleMass MaxCollisions
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleModuleCollision.ParticleMass>(Ptr + 224); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 224); }
    }

    /// <summary>
    /// ByteProperty: CollisionCompletionOption
    /// </summary>
    public unsafe byte CollisionCompletionOption
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 260); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 260); }
    }

    /// <summary>
    /// BoolProperty: bApplyPhysics
    /// </summary>
    public unsafe bool bApplyPhysics
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 264) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 264); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 264); }
    }

    /// <summary>
    /// BoolProperty: bForceCollideZeroExtent
    /// </summary>
    public unsafe bool bForceCollideZeroExtent
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 264) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 264); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 264); }
    }

    /// <summary>
    /// BoolProperty: bPawnsDoNotDecrementCount
    /// </summary>
    public unsafe bool bPawnsDoNotDecrementCount
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 264) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 264); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 264); }
    }

    /// <summary>
    /// BoolProperty: bOnlyVerticalNormalsDecrementCount
    /// </summary>
    public unsafe bool bOnlyVerticalNormalsDecrementCount
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 264) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 264); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 264); }
    }

    /// <summary>
    /// BoolProperty: bDropDetail
    /// </summary>
    public unsafe bool bDropDetail
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 264) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 264); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 264); }
    }

    /// <summary>
    /// BoolProperty: bCollideOnlyIfVisible
    /// </summary>
    public unsafe bool bCollideOnlyIfVisible
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 264) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 264); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 264); }
    }

    /// <summary>
    /// BoolProperty: bCollideWithWorld
    /// </summary>
    public unsafe bool bCollideWithWorld
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 264) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 264); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 264); }
    }

    /// <summary>
    /// BoolProperty: bCollideWithWorldAttractors
    /// </summary>
    public unsafe bool bCollideWithWorldAttractors
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 264) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 264); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 264); }
    }

    /// <summary>
    /// ObjectProperty: SoundOnCollision
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT SoundOnCollision
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 268); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 268); }
    }

    /// <summary>
    /// StructProperty: ParticleMass
    /// </summary>
    public unsafe BmSDK.Engine.ParticleModuleCollision.DelayAmount ParticleMass
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleModuleCollision.DelayAmount>(Ptr + 276); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 276); }
    }

    /// <summary>
    /// FloatProperty: DirScalar
    /// </summary>
    public unsafe float DirScalar
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 312); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 312); }
    }

    /// <summary>
    /// FloatProperty: VerticalFudgeFactor
    /// </summary>
    public unsafe float VerticalFudgeFactor
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 316); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 316); }
    }

    /// <summary>
    /// StructProperty: DelayAmount
    /// </summary>
    public unsafe BmSDK.Engine.ParticleModuleCollision.ParticleAttractorCollisionActions DelayAmount
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleModuleCollision.ParticleAttractorCollisionActions>(Ptr + 320); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 320); }
    }

    /// <summary>
    /// FloatProperty: MaxCollisionDistance
    /// </summary>
    public unsafe float MaxCollisionDistance
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 356); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 356); }
    }

    /// <summary>
    /// ArrayProperty: ParticleAttractorCollisionActions
    /// </summary>
    public unsafe NEED_UPDATE_ARRAYPROPERTY_LAYOUT ParticleAttractorCollisionActions
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_ARRAYPROPERTY_LAYOUT>(Ptr + 360); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 360); }
    }
}
