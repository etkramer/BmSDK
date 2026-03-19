#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Class: ParticleModuleLocationPrimitiveCylinder<br/>
/// (size = 0)
/// (flags = 0)
/// </summary>
public partial class ParticleModuleLocationPrimitiveCylinder : BmSDK.Engine.ParticleModuleLocationPrimitiveBase, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Engine.ParticleModuleLocationPrimitiveCylinder", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal ParticleModuleLocationPrimitiveCylinder() { }

    /// <summary>
    /// Constructs a new ParticleModuleLocationPrimitiveCylinder
    /// </summary>
    public ParticleModuleLocationPrimitiveCylinder(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, ParticleModuleLocationPrimitiveCylinder Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected ParticleModuleLocationPrimitiveCylinder(nint ptr) : base(ptr) { }

    /// <summary>
    /// BoolProperty: RadialVelocity
    /// </summary>
    public unsafe bool RadialVelocity
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 200) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 200); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 200); }
    }

    /// <summary>
    /// BoolProperty: bAdjustForWorldSpace
    /// </summary>
    public unsafe bool bAdjustForWorldSpace
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 200) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 200); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 200); }
    }

    /// <summary>
    /// StructProperty: StartRadius
    /// </summary>
    public unsafe BmSDK.Engine.ParticleModuleLocationPrimitiveCylinder.StartHeight StartRadius
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleModuleLocationPrimitiveCylinder.StartHeight>(Ptr + 204); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 204); }
    }

    /// <summary>
    /// StructProperty: StartHeight
    /// </summary>
    public unsafe BmSDK.Engine.ParticleModuleLocationPrimitiveBase.VelocityScale StartHeight
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleModuleLocationPrimitiveBase.VelocityScale>(Ptr + 240); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 240); }
    }

    /// <summary>
    /// ByteProperty: HeightAxis
    /// </summary>
    public unsafe byte HeightAxis
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 276); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 276); }
    }
}
