#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Class: RFlaps_ConstraintSetupCone<br/>
/// (flags = 0)
/// </summary>
public partial class RFlaps_ConstraintSetupCone : BmSDK.Engine.RFlaps_ConstraintSetup, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Engine.RFlaps_ConstraintSetupCone", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RFlaps_ConstraintSetupCone() { }

    /// <summary>
    /// Constructs a new RFlaps_ConstraintSetupCone
    /// </summary>
    public RFlaps_ConstraintSetupCone(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RFlaps_ConstraintSetupCone Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RFlaps_ConstraintSetupCone(nint ptr) : base(ptr) { }

    /// <summary>
    /// StructProperty: ConstrainedParticles
    /// </summary>
    public unsafe BmSDK.Engine.RFlaps_ConstraintSetup.FRFlapsParticleReference ConstrainedParticles_0
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RFlaps_ConstraintSetup.FRFlapsParticleReference>(Ptr + 112); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 112); }
    }
    /// <summary>
    /// StructProperty: ConstrainedParticles
    /// </summary>
    public unsafe BmSDK.Engine.RFlaps_ConstraintSetup.FRFlapsParticleReference ConstrainedParticles_1
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RFlaps_ConstraintSetup.FRFlapsParticleReference>(Ptr + 128); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 128); }
    }
    /// <summary>
    /// StructProperty: ConstrainedParticles
    /// </summary>
    public unsafe BmSDK.Engine.RFlaps_ConstraintSetup.FRFlapsParticleReference ConstrainedParticles_2
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RFlaps_ConstraintSetup.FRFlapsParticleReference>(Ptr + 144); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 144); }
    }
    /// <summary>
    /// StructProperty: ConstrainedParticles
    /// </summary>
    public unsafe BmSDK.Engine.RFlaps_ConstraintSetup.FRFlapsParticleReference ConstrainedParticles_3
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RFlaps_ConstraintSetup.FRFlapsParticleReference>(Ptr + 160); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 160); }
    }
    /// <summary>
    /// StructProperty: ConstrainedParticles
    /// </summary>
    public unsafe BmSDK.Engine.RFlaps_ConstraintSetup.FRFlapsParticleReference ConstrainedParticles_4
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RFlaps_ConstraintSetup.FRFlapsParticleReference>(Ptr + 176); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 176); }
    }

    /// <summary>
    /// StructProperty: BaseParticle
    /// </summary>
    public unsafe BmSDK.Engine.RFlaps_ConstraintSetup.FRFlapsParticleReference BaseParticle
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RFlaps_ConstraintSetup.FRFlapsParticleReference>(Ptr + 192); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 192); }
    }

    /// <summary>
    /// StructProperty: NormalDirParticle
    /// </summary>
    public unsafe BmSDK.Engine.RFlaps_ConstraintSetup.FRFlapsParticleReference NormalDirParticle
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RFlaps_ConstraintSetup.FRFlapsParticleReference>(Ptr + 208); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 208); }
    }

    /// <summary>
    /// StructProperty: PerpDirParticle
    /// </summary>
    public unsafe BmSDK.Engine.RFlaps_ConstraintSetup.FRFlapsParticleReference PerpDirParticle
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RFlaps_ConstraintSetup.FRFlapsParticleReference>(Ptr + 224); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 224); }
    }

    /// <summary>
    /// FloatProperty: ConeAngle
    /// </summary>
    public unsafe float ConeAngle
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 240); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 240); }
    }

    /// <summary>
    /// FloatProperty: ConePerpAngle
    /// </summary>
    public unsafe float ConePerpAngle
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 244); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 244); }
    }

    /// <summary>
    /// FloatProperty: ConeLimitSpring
    /// </summary>
    public unsafe float ConeLimitSpring
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 248); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 248); }
    }

    /// <summary>
    /// FloatProperty: ConeLimitDamping
    /// </summary>
    public unsafe float ConeLimitDamping
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 252); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 252); }
    }

}
