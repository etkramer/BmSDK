#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Class: RParticleModuleLocationSphereSection<br/>
/// (size = 0)
/// (flags = 0)
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
    public unsafe BmSDK.Engine.RParticleModuleLocationSphereSection.RadiusMax RadiusMin
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RParticleModuleLocationSphereSection.RadiusMax>(Ptr + 96); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 96); }
    }

    /// <summary>
    /// StructProperty: RadiusMax
    /// </summary>
    public unsafe BmSDK.Engine.RParticleModuleLocationSphereSection.ThetaMin RadiusMax
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RParticleModuleLocationSphereSection.ThetaMin>(Ptr + 132); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 132); }
    }

    /// <summary>
    /// StructProperty: ThetaMin
    /// </summary>
    public unsafe BmSDK.Engine.RParticleModuleLocationSphereSection.ThetaMax ThetaMin
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RParticleModuleLocationSphereSection.ThetaMax>(Ptr + 168); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 168); }
    }

    /// <summary>
    /// StructProperty: ThetaMax
    /// </summary>
    public unsafe BmSDK.Engine.RParticleModuleLocationSphereSection.PhiMin ThetaMax
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RParticleModuleLocationSphereSection.PhiMin>(Ptr + 204); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 204); }
    }

    /// <summary>
    /// StructProperty: PhiMin
    /// </summary>
    public unsafe BmSDK.Engine.RParticleModuleLocationSphereSection.PhiMax PhiMin
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RParticleModuleLocationSphereSection.PhiMax>(Ptr + 240); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 240); }
    }

    /// <summary>
    /// StructProperty: PhiMax
    /// </summary>
    public unsafe BmSDK.Engine.RParticleModuleLocationSphereSection.VelocityScale PhiMax
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RParticleModuleLocationSphereSection.VelocityScale>(Ptr + 276); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 276); }
    }

    /// <summary>
    /// BoolProperty: Velocity
    /// </summary>
    public unsafe bool Velocity
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 312) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 312); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 312); }
    }

    /// <summary>
    /// StructProperty: VelocityScale
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT VelocityScale
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 316); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 316); }
    }
}
