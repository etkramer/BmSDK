#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Class: ParticleModuleLocationPrimitiveCylinder<br/>
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
    /// Enum: CylinderHeightAxis
    /// </summary>
    public enum CylinderHeightAxis
    {
        PMLPC_HEIGHTAXIS_X = 0,
        PMLPC_HEIGHTAXIS_Y = 1,
        PMLPC_HEIGHTAXIS_Z = 2,
        PMLPC_HEIGHTAXIS_MAX = 3,
    }

    /// <summary>
    /// BoolProperty: RadialVelocity
    /// </summary>
    public unsafe bool RadialVelocity
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 200) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 200); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 200); }
    }

    /// <summary>
    /// BoolProperty: bAdjustForWorldSpace
    /// </summary>
    public unsafe bool bAdjustForWorldSpace
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 200) & 2) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 200); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 200); }
    }

    /// <summary>
    /// StructProperty: StartRadius
    /// </summary>
    public unsafe BmSDK.DistributionFloat.FRawDistributionFloat StartRadius
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.DistributionFloat.FRawDistributionFloat>(Ptr + 204); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 204); }
    }

    /// <summary>
    /// StructProperty: StartHeight
    /// </summary>
    public unsafe BmSDK.DistributionFloat.FRawDistributionFloat StartHeight
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.DistributionFloat.FRawDistributionFloat>(Ptr + 240); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 240); }
    }

    /// <summary>
    /// ByteProperty: HeightAxis
    /// </summary>
    public unsafe BmSDK.Engine.ParticleModuleLocationPrimitiveCylinder.CylinderHeightAxis HeightAxis
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleModuleLocationPrimitiveCylinder.CylinderHeightAxis>(Ptr + 276); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 276); }
    }
}
