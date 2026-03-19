#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Class: ParticleModuleTypeDataMeshPhysX<br/>
/// (size = 0)
/// (flags = 0)
/// </summary>
public partial class ParticleModuleTypeDataMeshPhysX : BmSDK.Engine.ParticleModuleTypeDataMesh, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Engine.ParticleModuleTypeDataMeshPhysX", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal ParticleModuleTypeDataMeshPhysX() { }

    /// <summary>
    /// Constructs a new ParticleModuleTypeDataMeshPhysX
    /// </summary>
    public ParticleModuleTypeDataMeshPhysX(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, ParticleModuleTypeDataMeshPhysX Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected ParticleModuleTypeDataMeshPhysX(nint ptr) : base(ptr) { }

    /// <summary>
    /// ObjectProperty: PhysXParSys
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT PhysXParSys
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 124); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 124); }
    }

    /// <summary>
    /// ByteProperty: PhysXRotationMethod
    /// </summary>
    public unsafe byte PhysXRotationMethod
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 132); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 132); }
    }

    /// <summary>
    /// FloatProperty: FluidRotationCoefficient
    /// </summary>
    public unsafe float FluidRotationCoefficient
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 136); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 136); }
    }

    /// <summary>
    /// StructProperty: VerticalLod
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT VerticalLod
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 140); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 140); }
    }

    /// <summary>
    /// FloatProperty: ZOffset
    /// </summary>
    public unsafe float ZOffset
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 156); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 156); }
    }
}
