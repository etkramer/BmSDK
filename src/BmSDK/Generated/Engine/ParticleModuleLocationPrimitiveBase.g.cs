#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Class: ParticleModuleLocationPrimitiveBase<br/>
/// (size = 0)
/// (flags = 0)
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
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 96) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 96); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 96); }
    }

    /// <summary>
    /// BoolProperty: Positive_Y
    /// </summary>
    public unsafe bool Positive_Y
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 96) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 96); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 96); }
    }

    /// <summary>
    /// BoolProperty: Positive_Z
    /// </summary>
    public unsafe bool Positive_Z
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 96) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 96); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 96); }
    }

    /// <summary>
    /// BoolProperty: Negative_X
    /// </summary>
    public unsafe bool Negative_X
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 96) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 96); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 96); }
    }

    /// <summary>
    /// BoolProperty: Negative_Y
    /// </summary>
    public unsafe bool Negative_Y
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 96) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 96); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 96); }
    }

    /// <summary>
    /// BoolProperty: Negative_Z
    /// </summary>
    public unsafe bool Negative_Z
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 96) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 96); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 96); }
    }

    /// <summary>
    /// BoolProperty: SurfaceOnly
    /// </summary>
    public unsafe bool SurfaceOnly
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 96) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 96); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 96); }
    }

    /// <summary>
    /// BoolProperty: Velocity
    /// </summary>
    public unsafe bool Velocity
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 96) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 96); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 96); }
    }

    /// <summary>
    /// StructProperty: VelocityScale
    /// </summary>
    public unsafe BmSDK.Engine.ParticleModuleLocationPrimitiveBase.StartLocation VelocityScale
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleModuleLocationPrimitiveBase.StartLocation>(Ptr + 100); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 100); }
    }

    /// <summary>
    /// StructProperty: StartLocation
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT StartLocation
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 136); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 136); }
    }
}
