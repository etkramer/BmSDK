#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Class: ParticleModuleTypeDataMesh<br/>
/// (size = 0)
/// (flags = 0)
/// </summary>
public partial class ParticleModuleTypeDataMesh : BmSDK.Engine.ParticleModuleTypeDataBase, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Engine.ParticleModuleTypeDataMesh", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal ParticleModuleTypeDataMesh() { }

    /// <summary>
    /// Constructs a new ParticleModuleTypeDataMesh
    /// </summary>
    public ParticleModuleTypeDataMesh(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, ParticleModuleTypeDataMesh Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected ParticleModuleTypeDataMesh(nint ptr) : base(ptr) { }

    /// <summary>
    /// ObjectProperty: Mesh
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT Mesh
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 96); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 96); }
    }

    /// <summary>
    /// BoolProperty: CastShadows
    /// </summary>
    public unsafe bool CastShadows
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 104) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 104); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 104); }
    }

    /// <summary>
    /// BoolProperty: DoCollisions
    /// </summary>
    public unsafe bool DoCollisions
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 104) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 104); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 104); }
    }

    /// <summary>
    /// BoolProperty: bAllowMotionBlur
    /// </summary>
    public unsafe bool bAllowMotionBlur
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 104) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 104); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 104); }
    }

    /// <summary>
    /// BoolProperty: bOverrideMaterial
    /// </summary>
    public unsafe bool bOverrideMaterial
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 104) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 104); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 104); }
    }

    /// <summary>
    /// BoolProperty: bCameraFacing
    /// </summary>
    public unsafe bool bCameraFacing
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 104) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 104); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 104); }
    }

    /// <summary>
    /// BoolProperty: bApplyParticleRotationAsSpin
    /// </summary>
    public unsafe bool bApplyParticleRotationAsSpin
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 104) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 104); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 104); }
    }

    /// <summary>
    /// ByteProperty: MeshAlignment
    /// </summary>
    public unsafe byte MeshAlignment
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 108); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 108); }
    }

    /// <summary>
    /// ByteProperty: AxisLockOption
    /// </summary>
    public unsafe byte AxisLockOption
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 109); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 109); }
    }

    /// <summary>
    /// ByteProperty: CameraFacingUpAxisOption
    /// </summary>
    public unsafe byte CameraFacingUpAxisOption
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 110); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 110); }
    }

    /// <summary>
    /// ByteProperty: CameraFacingOption
    /// </summary>
    public unsafe byte CameraFacingOption
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 111); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 111); }
    }

    /// <summary>
    /// FloatProperty: Pitch
    /// </summary>
    public unsafe float Pitch
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 112); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 112); }
    }

    /// <summary>
    /// FloatProperty: Roll
    /// </summary>
    public unsafe float Roll
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 116); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 116); }
    }

    /// <summary>
    /// FloatProperty: Yaw
    /// </summary>
    public unsafe float Yaw
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 120); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 120); }
    }
}
