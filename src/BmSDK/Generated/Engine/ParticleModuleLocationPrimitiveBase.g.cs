#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Class: ParticleModuleLocationPrimitiveBase<br/>
/// (size = 116)
/// (flags = 142610578)
/// </summary>
public partial class ParticleModuleLocationPrimitiveBase : BmSDK.Engine.ParticleModuleLocationBase, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Engine.ParticleModuleLocationPrimitiveBase", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal ParticleModuleLocationPrimitiveBase() { }

    /// <summary>
    /// Constructs a new ParticleModuleLocationPrimitiveBase
    /// </summary>
    public ParticleModuleLocationPrimitiveBase(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, ParticleModuleLocationPrimitiveBase Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected ParticleModuleLocationPrimitiveBase(nint ptr) : base(ptr) { }

    /// <summary>
    /// BoolProperty: Positive_X
    /// </summary>
    public unsafe bool Positive_X
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 56) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 56); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 56); }
    }

    /// <summary>
    /// BoolProperty: Positive_Y
    /// </summary>
    public unsafe bool Positive_Y
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 56) & 2) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 56); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 56); }
    }

    /// <summary>
    /// BoolProperty: Positive_Z
    /// </summary>
    public unsafe bool Positive_Z
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 56) & 4) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 56); var newMask = value ? (currentMask | 4) : (currentMask & ~4); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 56); }
    }

    /// <summary>
    /// BoolProperty: Negative_X
    /// </summary>
    public unsafe bool Negative_X
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 56) & 8) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 56); var newMask = value ? (currentMask | 8) : (currentMask & ~8); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 56); }
    }

    /// <summary>
    /// BoolProperty: Negative_Y
    /// </summary>
    public unsafe bool Negative_Y
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 56) & 16) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 56); var newMask = value ? (currentMask | 16) : (currentMask & ~16); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 56); }
    }

    /// <summary>
    /// BoolProperty: Negative_Z
    /// </summary>
    public unsafe bool Negative_Z
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 56) & 32) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 56); var newMask = value ? (currentMask | 32) : (currentMask & ~32); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 56); }
    }

    /// <summary>
    /// BoolProperty: SurfaceOnly
    /// </summary>
    public unsafe bool SurfaceOnly
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 56) & 64) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 56); var newMask = value ? (currentMask | 64) : (currentMask & ~64); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 56); }
    }

    /// <summary>
    /// BoolProperty: Velocity
    /// </summary>
    public unsafe bool Velocity
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 56) & 128) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 56); var newMask = value ? (currentMask | 128) : (currentMask & ~128); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 56); }
    }

    /// <summary>
    /// StructProperty: VelocityScale
    /// </summary>
    public unsafe BmSDK.DistributionFloat.FRawDistributionFloat VelocityScale
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.DistributionFloat.FRawDistributionFloat>(Ptr + 60); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 60); }
    }

    /// <summary>
    /// StructProperty: StartLocation
    /// </summary>
    public unsafe BmSDK.DistributionVector.FRawDistributionVector StartLocation
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.DistributionVector.FRawDistributionVector>(Ptr + 88); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 88); }
    }
}
