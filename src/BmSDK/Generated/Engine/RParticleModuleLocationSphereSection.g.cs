#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Class: RParticleModuleLocationSphereSection<br/>
/// (size = 256)
/// (flags = 142618770)
/// </summary>
public partial class RParticleModuleLocationSphereSection : BmSDK.Engine.ParticleModuleLocationBase, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Engine.RParticleModuleLocationSphereSection", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RParticleModuleLocationSphereSection() { }

    /// <summary>
    /// Constructs a new RParticleModuleLocationSphereSection
    /// </summary>
    public RParticleModuleLocationSphereSection(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RParticleModuleLocationSphereSection Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RParticleModuleLocationSphereSection(nint ptr) : base(ptr) { }

    /// <summary>
    /// StructProperty: RadiusMin
    /// </summary>
    public unsafe BmSDK.DistributionFloat.FRawDistributionFloat RadiusMin
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.DistributionFloat.FRawDistributionFloat>(Ptr + 56); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 56); }
    }

    /// <summary>
    /// StructProperty: RadiusMax
    /// </summary>
    public unsafe BmSDK.DistributionFloat.FRawDistributionFloat RadiusMax
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.DistributionFloat.FRawDistributionFloat>(Ptr + 84); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 84); }
    }

    /// <summary>
    /// StructProperty: ThetaMin
    /// </summary>
    public unsafe BmSDK.DistributionFloat.FRawDistributionFloat ThetaMin
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.DistributionFloat.FRawDistributionFloat>(Ptr + 112); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 112); }
    }

    /// <summary>
    /// StructProperty: ThetaMax
    /// </summary>
    public unsafe BmSDK.DistributionFloat.FRawDistributionFloat ThetaMax
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.DistributionFloat.FRawDistributionFloat>(Ptr + 140); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 140); }
    }

    /// <summary>
    /// StructProperty: PhiMin
    /// </summary>
    public unsafe BmSDK.DistributionFloat.FRawDistributionFloat PhiMin
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.DistributionFloat.FRawDistributionFloat>(Ptr + 168); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 168); }
    }

    /// <summary>
    /// StructProperty: PhiMax
    /// </summary>
    public unsafe BmSDK.DistributionFloat.FRawDistributionFloat PhiMax
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.DistributionFloat.FRawDistributionFloat>(Ptr + 196); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 196); }
    }

    /// <summary>
    /// BoolProperty: Velocity
    /// </summary>
    public unsafe bool Velocity
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 224) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 224); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 224); }
    }

    /// <summary>
    /// StructProperty: VelocityScale
    /// </summary>
    public unsafe BmSDK.DistributionFloat.FRawDistributionFloat VelocityScale
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.DistributionFloat.FRawDistributionFloat>(Ptr + 228); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 228); }
    }
}
