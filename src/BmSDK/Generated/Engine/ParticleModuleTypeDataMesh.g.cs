#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Class: ParticleModuleTypeDataMesh<br/>
/// (size = 124)
/// (flags = 134221970)
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
    /// Enum: EMeshCameraFacingOptions
    /// </summary>
    public enum EMeshCameraFacingOptions
    {
        XAxisFacing_NoUp = 0,
        XAxisFacing_ZUp = 1,
        XAxisFacing_NegativeZUp = 2,
        XAxisFacing_YUp = 3,
        XAxisFacing_NegativeYUp = 4,
        LockedAxis_ZAxisFacing = 5,
        LockedAxis_NegativeZAxisFacing = 6,
        LockedAxis_YAxisFacing = 7,
        LockedAxis_NegativeYAxisFacing = 8,
        VelocityAligned_ZAxisFacing = 9,
        VelocityAligned_NegativeZAxisFacing = 10,
        VelocityAligned_YAxisFacing = 11,
        VelocityAligned_NegativeYAxisFacing = 12,
        EMeshCameraFacingOptions_MAX = 13,
    }

    /// <summary>
    /// Enum: EMeshCameraFacingUpAxis
    /// </summary>
    public enum EMeshCameraFacingUpAxis
    {
        CameraFacing_NoneUP = 0,
        CameraFacing_ZUp = 1,
        CameraFacing_NegativeZUp = 2,
        CameraFacing_YUp = 3,
        CameraFacing_NegativeYUp = 4,
        CameraFacing_MAX = 5,
    }

    /// <summary>
    /// Enum: EMeshScreenAlignment
    /// </summary>
    public enum EMeshScreenAlignment
    {
        PSMA_MeshFaceCameraWithRoll = 0,
        PSMA_MeshFaceCameraWithSpin = 1,
        PSMA_MeshFaceCameraWithLockedAxis = 2,
        PSMA_MAX = 3,
    }

    /// <summary>
    /// ObjectProperty: Mesh
    /// </summary>
    public unsafe BmSDK.Engine.StaticMesh Mesh
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.StaticMesh>(Ptr + 96); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 96); }
    }

    /// <summary>
    /// BoolProperty: CastShadows
    /// </summary>
    public unsafe bool CastShadows
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 104) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 104); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 104); }
    }

    /// <summary>
    /// BoolProperty: DoCollisions
    /// </summary>
    public unsafe bool DoCollisions
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 104) & 2) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 104); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 104); }
    }

    /// <summary>
    /// BoolProperty: bAllowMotionBlur
    /// </summary>
    public unsafe bool bAllowMotionBlur
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 104) & 4) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 104); var newMask = value ? (currentMask | 4) : (currentMask & ~4); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 104); }
    }

    /// <summary>
    /// BoolProperty: bOverrideMaterial
    /// </summary>
    public unsafe bool bOverrideMaterial
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 104) & 8) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 104); var newMask = value ? (currentMask | 8) : (currentMask & ~8); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 104); }
    }

    /// <summary>
    /// BoolProperty: bCameraFacing
    /// </summary>
    public unsafe bool bCameraFacing
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 104) & 16) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 104); var newMask = value ? (currentMask | 16) : (currentMask & ~16); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 104); }
    }

    /// <summary>
    /// BoolProperty: bApplyParticleRotationAsSpin
    /// </summary>
    public unsafe bool bApplyParticleRotationAsSpin
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 104) & 32) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 104); var newMask = value ? (currentMask | 32) : (currentMask & ~32); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 104); }
    }

    /// <summary>
    /// ByteProperty: MeshAlignment
    /// </summary>
    public unsafe BmSDK.Engine.ParticleModuleTypeDataMesh.EMeshScreenAlignment MeshAlignment
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleModuleTypeDataMesh.EMeshScreenAlignment>(Ptr + 108); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 108); }
    }

    /// <summary>
    /// ByteProperty: AxisLockOption
    /// </summary>
    public unsafe BmSDK.Engine.ParticleModuleOrientationAxisLock.EParticleAxisLock AxisLockOption
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleModuleOrientationAxisLock.EParticleAxisLock>(Ptr + 109); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 109); }
    }

    /// <summary>
    /// ByteProperty: CameraFacingUpAxisOption
    /// </summary>
    public unsafe BmSDK.Engine.ParticleModuleTypeDataMesh.EMeshCameraFacingUpAxis CameraFacingUpAxisOption
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleModuleTypeDataMesh.EMeshCameraFacingUpAxis>(Ptr + 110); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 110); }
    }

    /// <summary>
    /// ByteProperty: CameraFacingOption
    /// </summary>
    public unsafe BmSDK.Engine.ParticleModuleTypeDataMesh.EMeshCameraFacingOptions CameraFacingOption
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleModuleTypeDataMesh.EMeshCameraFacingOptions>(Ptr + 111); }
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
