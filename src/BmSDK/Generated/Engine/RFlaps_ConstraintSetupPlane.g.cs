#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Class: RFlaps_ConstraintSetupPlane<br/>
/// (size = 0)
/// (flags = 0)
/// </summary>
public partial class RFlaps_ConstraintSetupPlane : BmSDK.Engine.RFlaps_ConstraintSetup, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Engine.RFlaps_ConstraintSetupPlane", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RFlaps_ConstraintSetupPlane() { }

    /// <summary>
    /// Constructs a new RFlaps_ConstraintSetupPlane
    /// </summary>
    public RFlaps_ConstraintSetupPlane(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RFlaps_ConstraintSetupPlane Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RFlaps_ConstraintSetupPlane(nint ptr) : base(ptr) { }

    /// <summary>
    /// StructProperty: ConstrainedParticles
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT ConstrainedParticles_0
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 112); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 112); }
    }
    /// <summary>
    /// StructProperty: ConstrainedParticles
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT ConstrainedParticles_1
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 128); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 128); }
    }
    /// <summary>
    /// StructProperty: ConstrainedParticles
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT ConstrainedParticles_2
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 144); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 144); }
    }
    /// <summary>
    /// StructProperty: ConstrainedParticles
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT ConstrainedParticles_3
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 160); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 160); }
    }
    /// <summary>
    /// StructProperty: ConstrainedParticles
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT ConstrainedParticles_4
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 176); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 176); }
    }

    /// <summary>
    /// StructProperty: InPlaneParticle
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT InPlaneParticle
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 192); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 192); }
    }

    /// <summary>
    /// StructProperty: PlaneNormalDirParticle
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT PlaneNormalDirParticle
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 208); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 208); }
    }

    /// <summary>
    /// FloatProperty: Restitution
    /// </summary>
    public unsafe float Restitution
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 224); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 224); }
    }

}
