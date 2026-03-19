#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RPatrolPointRenderingComponent<br/>
/// (size = 0)
/// (flags = 0)
/// </summary>
public partial class RPatrolPointRenderingComponent : BmSDK.Engine.PrimitiveComponent, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RPatrolPointRenderingComponent", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RPatrolPointRenderingComponent() { }

    /// <summary>
    /// Constructs a new RPatrolPointRenderingComponent
    /// </summary>
    public RPatrolPointRenderingComponent(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RPatrolPointRenderingComponent Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RPatrolPointRenderingComponent(nint ptr) : base(ptr) { }

    /// <summary>
    /// IntProperty: Tag
    /// </summary>
    public unsafe int Tag
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 124); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 124); }
    }

    /// <summary>
    /// StructProperty: Bounds
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT Bounds
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 128); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 128); }
    }

    /// <summary>
    /// StructProperty: SceneInfo
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT SceneInfo
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 156); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 156); }
    }

    /// <summary>
    /// StructProperty: LocalToWorld
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT LocalToWorld
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 176); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 176); }
    }

    /// <summary>
    /// StructProperty: CachedParentToWorld
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT CachedParentToWorld
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 240); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 240); }
    }

    /// <summary>
    /// IntProperty: DetachFence
    /// </summary>
    public unsafe int DetachFence
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 304); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 304); }
    }

    /// <summary>
    /// FloatProperty: LocalToWorldDeterminant
    /// </summary>
    public unsafe float LocalToWorldDeterminant
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 308); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 308); }
    }

    /// <summary>
    /// IntProperty: MotionBlurInfoIndex
    /// </summary>
    public unsafe int MotionBlurInfoIndex
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 312); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 312); }
    }

    /// <summary>
    /// ComponentProperty: ReplacementPrimitive
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT ReplacementPrimitive
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 316); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 316); }
    }

    /// <summary>
    /// ObjectProperty: AutoLODOverride
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT AutoLODOverride
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 324); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 324); }
    }

    /// <summary>
    /// ComponentProperty: FogVolumeComponent
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT FogVolumeComponent
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 332); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 332); }
    }

    /// <summary>
    /// FloatProperty: MassiveLODDistance
    /// </summary>
    public unsafe float MassiveLODDistance
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 340); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 340); }
    }

    /// <summary>
    /// IntProperty: MassiveLODAttachedPrimitives
    /// </summary>
    public unsafe int MassiveLODAttachedPrimitives
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 344); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 344); }
    }

    /// <summary>
    /// FloatProperty: AutoLODImportanceWeighting
    /// </summary>
    public unsafe float AutoLODImportanceWeighting
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 348); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 348); }
    }

    /// <summary>
    /// FloatProperty: MaxDrawDistance
    /// </summary>
    public unsafe float MaxDrawDistance
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 352); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 352); }
    }

    /// <summary>
    /// FloatProperty: CachedMaxDrawDistance
    /// </summary>
    public unsafe float CachedMaxDrawDistance
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 356); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 356); }
    }

    /// <summary>
    /// FloatProperty: MotionBlurInstanceScale
    /// </summary>
    public unsafe float MotionBlurInstanceScale
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 360); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 360); }
    }

    /// <summary>
    /// FloatProperty: PerInstanceRandom
    /// </summary>
    public unsafe float PerInstanceRandom
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 364); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 364); }
    }

    /// <summary>
    /// FloatProperty: PerInstanceRandomOverride
    /// </summary>
    public unsafe float PerInstanceRandomOverride
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 368); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 368); }
    }

    /// <summary>
    /// FloatProperty: CullArea
    /// </summary>
    public unsafe float CullArea
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 372); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 372); }
    }

    /// <summary>
    /// FloatProperty: CullAreaMultiplier
    /// </summary>
    public unsafe float CullAreaMultiplier
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 376); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 376); }
    }

    /// <summary>
    /// ByteProperty: PreviewEnvironmentShadowing
    /// </summary>
    public unsafe byte PreviewEnvironmentShadowing
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 380); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 380); }
    }

    /// <summary>
    /// ObjectProperty: PhysMaterialOverride
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT PhysMaterialOverride
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 384); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 384); }
    }

    /// <summary>
    /// ObjectProperty: BodyInstance
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT BodyInstance
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 392); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 392); }
    }

    /// <summary>
    /// StructProperty: Translation
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT Translation
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 400); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 400); }
    }

    /// <summary>
    /// StructProperty: Rotation
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT Rotation
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 412); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 412); }
    }

    /// <summary>
    /// FloatProperty: Scale
    /// </summary>
    public unsafe float Scale
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 424); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 424); }
    }

    /// <summary>
    /// StructProperty: Scale3D
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT Scale3D
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 428); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 428); }
    }

    /// <summary>
    /// StructProperty: ReflectionShadowPlane
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT ReflectionShadowPlane
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 448); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 448); }
    }

    /// <summary>
    /// FloatProperty: LastRenderTime
    /// </summary>
    public unsafe float LastRenderTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 464); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 464); }
    }

    /// <summary>
    /// FloatProperty: ScriptRigidBodyCollisionThreshold
    /// </summary>
    public unsafe float ScriptRigidBodyCollisionThreshold
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 468); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 468); }
    }

    /// <summary>
    /// ByteProperty: CollisionFilter
    /// </summary>
    public unsafe byte CollisionFilter
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 472); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 472); }
    }

    /// <summary>
    /// ByteProperty: HeightmapOverrideType
    /// </summary>
    public unsafe byte HeightmapOverrideType
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 473); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 473); }
    }

    /// <summary>
    /// BoolProperty: bForceEdCanScale
    /// </summary>
    public unsafe bool bForceEdCanScale
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 476) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 476); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 476); }
    }

    /// <summary>
    /// BoolProperty: bForceEdCanNonUniformScale
    /// </summary>
    public unsafe bool bForceEdCanNonUniformScale
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 476) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 476); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 476); }
    }

    /// <summary>
    /// BoolProperty: bDrawAsGauntletProjectionMesh
    /// </summary>
    public unsafe bool bDrawAsGauntletProjectionMesh
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 476) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 476); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 476); }
    }

    /// <summary>
    /// BoolProperty: bDrawInFrontOfPostProcessWhenInXrayMode
    /// </summary>
    public unsafe bool bDrawInFrontOfPostProcessWhenInXrayMode
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 476) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 476); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 476); }
    }

    /// <summary>
    /// BoolProperty: bDrawInForegroundAndInFrontOfPostProcessWhenInXrayMode
    /// </summary>
    public unsafe bool bDrawInForegroundAndInFrontOfPostProcessWhenInXrayMode
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 476) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 476); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 476); }
    }

    /// <summary>
    /// BoolProperty: bDrawInFrontOfPostProcessWhenInScanMode
    /// </summary>
    public unsafe bool bDrawInFrontOfPostProcessWhenInScanMode
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 476) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 476); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 476); }
    }

    /// <summary>
    /// BoolProperty: bDrawInForegroundAndInFrontOfPostProcessWhenInScanMode
    /// </summary>
    public unsafe bool bDrawInForegroundAndInFrontOfPostProcessWhenInScanMode
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 476) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 476); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 476); }
    }

    /// <summary>
    /// BoolProperty: bDrawInFrontOfPostProcessWhenInThermalMode
    /// </summary>
    public unsafe bool bDrawInFrontOfPostProcessWhenInThermalMode
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 476) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 476); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 476); }
    }

    /// <summary>
    /// BoolProperty: bDrawInForegroundAndInFrontOfPostProcessWhenInThermalMode
    /// </summary>
    public unsafe bool bDrawInForegroundAndInFrontOfPostProcessWhenInThermalMode
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 476) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 476); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 476); }
    }

    /// <summary>
    /// BoolProperty: bDrawInFrontOfPostProcessWhenInBatmobileViewMode
    /// </summary>
    public unsafe bool bDrawInFrontOfPostProcessWhenInBatmobileViewMode
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 476) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 476); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 476); }
    }

    /// <summary>
    /// BoolProperty: bDrawInForegroundAndInFrontOfPostProcessWhenInBatmobileViewMode
    /// </summary>
    public unsafe bool bDrawInForegroundAndInFrontOfPostProcessWhenInBatmobileViewMode
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 476) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 476); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 476); }
    }

    /// <summary>
    /// BoolProperty: bDrawAsDisruptorSniperHighlightMesh
    /// </summary>
    public unsafe bool bDrawAsDisruptorSniperHighlightMesh
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 476) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 476); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 476); }
    }

    /// <summary>
    /// BoolProperty: bDrawInFrontOfPostProcessWhenInDLCViewMode
    /// </summary>
    public unsafe bool bDrawInFrontOfPostProcessWhenInDLCViewMode
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 476) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 476); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 476); }
    }

    /// <summary>
    /// BoolProperty: bDrawInForegroundAndInFrontOfPostProcessWhenInDLCViewMode
    /// </summary>
    public unsafe bool bDrawInForegroundAndInFrontOfPostProcessWhenInDLCViewMode
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 476) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 476); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 476); }
    }

    /// <summary>
    /// BoolProperty: bAllowCullDistanceVolume
    /// </summary>
    public unsafe bool bAllowCullDistanceVolume
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 476) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 476); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 476); }
    }

    /// <summary>
    /// BoolProperty: HiddenGame
    /// </summary>
    public unsafe bool HiddenGame
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 476) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 476); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 476); }
    }

    /// <summary>
    /// BoolProperty: HiddenEditor
    /// </summary>
    public unsafe bool HiddenEditor
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 476) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 476); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 476); }
    }

    /// <summary>
    /// BoolProperty: bOwnerNoSee
    /// </summary>
    public unsafe bool bOwnerNoSee
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 476) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 476); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 476); }
    }

    /// <summary>
    /// BoolProperty: bOnlyOwnerSee
    /// </summary>
    public unsafe bool bOnlyOwnerSee
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 476) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 476); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 476); }
    }

    /// <summary>
    /// BoolProperty: bXrayNoSee
    /// </summary>
    public unsafe bool bXrayNoSee
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 476) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 476); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 476); }
    }

    /// <summary>
    /// BoolProperty: bOnlyXraySee
    /// </summary>
    public unsafe bool bOnlyXraySee
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 476) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 476); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 476); }
    }

    /// <summary>
    /// BoolProperty: bScanModeNoSee
    /// </summary>
    public unsafe bool bScanModeNoSee
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 476) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 476); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 476); }
    }

    /// <summary>
    /// BoolProperty: bOnlyScanModeSee
    /// </summary>
    public unsafe bool bOnlyScanModeSee
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 476) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 476); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 476); }
    }

    /// <summary>
    /// BoolProperty: bThermalNoSee
    /// </summary>
    public unsafe bool bThermalNoSee
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 476) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 476); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 476); }
    }

    /// <summary>
    /// BoolProperty: bOnlyThermalSee
    /// </summary>
    public unsafe bool bOnlyThermalSee
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 476) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 476); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 476); }
    }

    /// <summary>
    /// BoolProperty: bBatmobileViewNoSee
    /// </summary>
    public unsafe bool bBatmobileViewNoSee
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 476) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 476); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 476); }
    }

    /// <summary>
    /// BoolProperty: bOnlyBatmobileViewSee
    /// </summary>
    public unsafe bool bOnlyBatmobileViewSee
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 476) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 476); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 476); }
    }

    /// <summary>
    /// BoolProperty: bOnlyReflectionSee
    /// </summary>
    public unsafe bool bOnlyReflectionSee
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 476) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 476); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 476); }
    }

    /// <summary>
    /// BoolProperty: bReflectionNoSee
    /// </summary>
    public unsafe bool bReflectionNoSee
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 476) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 476); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 476); }
    }

    /// <summary>
    /// BoolProperty: bOnlyReflectionProbeSee
    /// </summary>
    public unsafe bool bOnlyReflectionProbeSee
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 476) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 476); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 476); }
    }

    /// <summary>
    /// BoolProperty: bReflectionProbeNoSee
    /// </summary>
    public unsafe bool bReflectionProbeNoSee
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 476) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 476); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 476); }
    }

    /// <summary>
    /// BoolProperty: bExcludeFromRainVolume
    /// </summary>
    public unsafe bool bExcludeFromRainVolume
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 476) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 476); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 476); }
    }

    /// <summary>
    /// BoolProperty: bOverrideHeightmapObjectOnly
    /// </summary>
    public unsafe bool bOverrideHeightmapObjectOnly
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 480) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 480); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 480); }
    }

    /// <summary>
    /// BoolProperty: DontDrawThisFrame
    /// </summary>
    public unsafe bool DontDrawThisFrame
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 480) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 480); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 480); }
    }

    /// <summary>
    /// BoolProperty: NotCountedInParentMassiveLODAttachedPrimitives
    /// </summary>
    public unsafe bool NotCountedInParentMassiveLODAttachedPrimitives
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 480) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 480); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 480); }
    }

    /// <summary>
    /// BoolProperty: ForceOnBakeIntoBackgroundForAutoLOD
    /// </summary>
    public unsafe bool ForceOnBakeIntoBackgroundForAutoLOD
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 480) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 480); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 480); }
    }

    /// <summary>
    /// BoolProperty: ForceOffBakeIntoBackgroundForAutoLOD
    /// </summary>
    public unsafe bool ForceOffBakeIntoBackgroundForAutoLOD
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 480) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 480); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 480); }
    }

    /// <summary>
    /// BoolProperty: ForceOffAutoLODOverride
    /// </summary>
    public unsafe bool ForceOffAutoLODOverride
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 480) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 480); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 480); }
    }

    /// <summary>
    /// BoolProperty: ForceOffAutoLODMasked
    /// </summary>
    public unsafe bool ForceOffAutoLODMasked
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 480) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 480); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 480); }
    }

    /// <summary>
    /// BoolProperty: ForceOnAutoLODMasked
    /// </summary>
    public unsafe bool ForceOnAutoLODMasked
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 480) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 480); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 480); }
    }

    /// <summary>
    /// BoolProperty: ForceOffTwoSided
    /// </summary>
    public unsafe bool ForceOffTwoSided
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 480) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 480); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 480); }
    }

    /// <summary>
    /// BoolProperty: NeverHideDuringAutoLOD
    /// </summary>
    public unsafe bool NeverHideDuringAutoLOD
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 480) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 480); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 480); }
    }

    /// <summary>
    /// BoolProperty: AlwaysHideDuringAutoLOD
    /// </summary>
    public unsafe bool AlwaysHideDuringAutoLOD
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 480) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 480); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 480); }
    }

    /// <summary>
    /// BoolProperty: bIgnoreOwnerHidden
    /// </summary>
    public unsafe bool bIgnoreOwnerHidden
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 480) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 480); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 480); }
    }

    /// <summary>
    /// BoolProperty: bUseAsOccluder
    /// </summary>
    public unsafe bool bUseAsOccluder
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 480) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 480); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 480); }
    }

    /// <summary>
    /// BoolProperty: bUseAsOccluderAutomatic
    /// </summary>
    public unsafe bool bUseAsOccluderAutomatic
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 480) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 480); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 480); }
    }

    /// <summary>
    /// BoolProperty: bAllowOcclusionTesting
    /// </summary>
    public unsafe bool bAllowOcclusionTesting
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 480) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 480); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 480); }
    }

    /// <summary>
    /// BoolProperty: bAllowApproximateOcclusion
    /// </summary>
    public unsafe bool bAllowApproximateOcclusion
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 480) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 480); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 480); }
    }

    /// <summary>
    /// BoolProperty: bUmbraUseAsOccluder
    /// </summary>
    public unsafe bool bUmbraUseAsOccluder
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 480) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 480); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 480); }
    }

    /// <summary>
    /// BoolProperty: bUmbraDoNotIdCull
    /// </summary>
    public unsafe bool bUmbraDoNotIdCull
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 480) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 480); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 480); }
    }

    /// <summary>
    /// BoolProperty: bFirstFrameOcclusion
    /// </summary>
    public unsafe bool bFirstFrameOcclusion
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 480) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 480); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 480); }
    }

    /// <summary>
    /// BoolProperty: bIgnoreNearPlaneIntersection
    /// </summary>
    public unsafe bool bIgnoreNearPlaneIntersection
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 480) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 480); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 480); }
    }

    /// <summary>
    /// BoolProperty: bSelectable
    /// </summary>
    public unsafe bool bSelectable
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 480) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 480); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 480); }
    }

    /// <summary>
    /// BoolProperty: bForceMipStreaming
    /// </summary>
    public unsafe bool bForceMipStreaming
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 480) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 480); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 480); }
    }

    /// <summary>
    /// BoolProperty: bAcceptsStaticDecals
    /// </summary>
    public unsafe bool bAcceptsStaticDecals
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 480) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 480); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 480); }
    }

    /// <summary>
    /// BoolProperty: bAcceptsDynamicDecals
    /// </summary>
    public unsafe bool bAcceptsDynamicDecals
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 480) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 480); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 480); }
    }

    /// <summary>
    /// BoolProperty: bIsRefreshingDecals
    /// </summary>
    public unsafe bool bIsRefreshingDecals
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 480) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 480); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 480); }
    }

    /// <summary>
    /// BoolProperty: bAllowDecalAutomaticReAttach
    /// </summary>
    public unsafe bool bAllowDecalAutomaticReAttach
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 480) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 480); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 480); }
    }

    /// <summary>
    /// BoolProperty: bUsePerInstanceHitProxies
    /// </summary>
    public unsafe bool bUsePerInstanceHitProxies
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 480) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 480); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 480); }
    }

    /// <summary>
    /// BoolProperty: CastShadow
    /// </summary>
    public unsafe bool CastShadow
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 480) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 480); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 480); }
    }

    /// <summary>
    /// BoolProperty: bForceDirectLightMap
    /// </summary>
    public unsafe bool bForceDirectLightMap
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 480) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 480); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 480); }
    }

    /// <summary>
    /// BoolProperty: bCastDynamicShadow
    /// </summary>
    public unsafe bool bCastDynamicShadow
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 480) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 480); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 480); }
    }

    /// <summary>
    /// BoolProperty: bCastStaticShadow
    /// </summary>
    public unsafe bool bCastStaticShadow
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 480) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 480); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 480); }
    }

    /// <summary>
    /// BoolProperty: bSelfShadowOnly
    /// </summary>
    public unsafe bool bSelfShadowOnly
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 480) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 480); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 480); }
    }

    /// <summary>
    /// BoolProperty: bMeshAddedToScene
    /// </summary>
    public unsafe bool bMeshAddedToScene
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 484) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 484); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 484); }
    }

    /// <summary>
    /// BoolProperty: bAcceptsDynamicDominantLightShadows
    /// </summary>
    public unsafe bool bAcceptsDynamicDominantLightShadows
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 484) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 484); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 484); }
    }

    /// <summary>
    /// BoolProperty: bCastHiddenShadow
    /// </summary>
    public unsafe bool bCastHiddenShadow
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 484) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 484); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 484); }
    }

    /// <summary>
    /// BoolProperty: bCastShadowAsTwoSided
    /// </summary>
    public unsafe bool bCastShadowAsTwoSided
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 484) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 484); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 484); }
    }

    /// <summary>
    /// BoolProperty: bAcceptsLights
    /// </summary>
    public unsafe bool bAcceptsLights
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 484) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 484); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 484); }
    }

    /// <summary>
    /// BoolProperty: bAcceptsDynamicLights
    /// </summary>
    public unsafe bool bAcceptsDynamicLights
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 484) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 484); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 484); }
    }

    /// <summary>
    /// BoolProperty: bUseOnePassLightingOnTranslucency
    /// </summary>
    public unsafe bool bUseOnePassLightingOnTranslucency
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 484) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 484); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 484); }
    }

    /// <summary>
    /// BoolProperty: bUsePrecomputedShadows
    /// </summary>
    public unsafe bool bUsePrecomputedShadows
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 484) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 484); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 484); }
    }

    /// <summary>
    /// BoolProperty: bAgeSorted
    /// </summary>
    public unsafe bool bAgeSorted
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 484) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 484); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 484); }
    }

    /// <summary>
    /// BoolProperty: bAllowAmbientOcclusion
    /// </summary>
    public unsafe bool bAllowAmbientOcclusion
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 484) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 484); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 484); }
    }

    /// <summary>
    /// BoolProperty: CollideActors
    /// </summary>
    public unsafe bool CollideActors
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 484) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 484); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 484); }
    }

    /// <summary>
    /// BoolProperty: BlockActors
    /// </summary>
    public unsafe bool BlockActors
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 484) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 484); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 484); }
    }

    /// <summary>
    /// BoolProperty: BlockZeroExtent
    /// </summary>
    public unsafe bool BlockZeroExtent
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 484) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 484); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 484); }
    }

    /// <summary>
    /// BoolProperty: BlockNonZeroExtent
    /// </summary>
    public unsafe bool BlockNonZeroExtent
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 484) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 484); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 484); }
    }

    /// <summary>
    /// BoolProperty: CanBlockCamera
    /// </summary>
    public unsafe bool CanBlockCamera
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 484) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 484); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 484); }
    }

    /// <summary>
    /// BoolProperty: BlockRigidBody
    /// </summary>
    public unsafe bool BlockRigidBody
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 484) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 484); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 484); }
    }

    /// <summary>
    /// BoolProperty: BlockRigidBodyInitial
    /// </summary>
    public unsafe bool BlockRigidBodyInitial
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 484) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 484); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 484); }
    }

    /// <summary>
    /// BoolProperty: bBlockFootPlacement
    /// </summary>
    public unsafe bool bBlockFootPlacement
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 484) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 484); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 484); }
    }

    /// <summary>
    /// BoolProperty: BlockRigidBodyPhysX
    /// </summary>
    public unsafe bool BlockRigidBodyPhysX
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 484) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 484); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 484); }
    }

    /// <summary>
    /// BoolProperty: OverrideCollisionFilter
    /// </summary>
    public unsafe bool OverrideCollisionFilter
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 484) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 484); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 484); }
    }

    /// <summary>
    /// BoolProperty: BlockTurbulence
    /// </summary>
    public unsafe bool BlockTurbulence
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 484) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 484); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 484); }
    }

    /// <summary>
    /// BoolProperty: bDisableAllRigidBody
    /// </summary>
    public unsafe bool bDisableAllRigidBody
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 484) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 484); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 484); }
    }

    /// <summary>
    /// BoolProperty: bSkipRBGeomCreation
    /// </summary>
    public unsafe bool bSkipRBGeomCreation
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 484) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 484); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 484); }
    }

    /// <summary>
    /// BoolProperty: bNotifyRigidBodyCollision
    /// </summary>
    public unsafe bool bNotifyRigidBodyCollision
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 484) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 484); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 484); }
    }

    /// <summary>
    /// BoolProperty: bNotifyRigidBodyCollisionIgnoredWhenFarAway
    /// </summary>
    public unsafe bool bNotifyRigidBodyCollisionIgnoredWhenFarAway
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 484) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 484); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 484); }
    }

    /// <summary>
    /// BoolProperty: bNotifyRigidBodyCollisionOnSelfCollision
    /// </summary>
    public unsafe bool bNotifyRigidBodyCollisionOnSelfCollision
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 484) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 484); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 484); }
    }

    /// <summary>
    /// BoolProperty: bEnableContactModificationCallback
    /// </summary>
    public unsafe bool bEnableContactModificationCallback
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 484) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 484); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 484); }
    }

    /// <summary>
    /// BoolProperty: bEnableSleepWakeNotifies
    /// </summary>
    public unsafe bool bEnableSleepWakeNotifies
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 484) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 484); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 484); }
    }

    /// <summary>
    /// BoolProperty: bDisableMinCollisionThickness
    /// </summary>
    public unsafe bool bDisableMinCollisionThickness
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 484) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 484); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 484); }
    }

    /// <summary>
    /// BoolProperty: bFluidDrain
    /// </summary>
    public unsafe bool bFluidDrain
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 484) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 484); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 484); }
    }

    /// <summary>
    /// BoolProperty: bFluidTwoWay
    /// </summary>
    public unsafe bool bFluidTwoWay
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 484) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 484); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 484); }
    }

    /// <summary>
    /// BoolProperty: bIgnoreRadialImpulse
    /// </summary>
    public unsafe bool bIgnoreRadialImpulse
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 484) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 484); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 484); }
    }

    /// <summary>
    /// BoolProperty: bIgnoreRadialForce
    /// </summary>
    public unsafe bool bIgnoreRadialForce
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 488) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 488); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 488); }
    }

    /// <summary>
    /// BoolProperty: bIgnoreForceField
    /// </summary>
    public unsafe bool bIgnoreForceField
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 488) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 488); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 488); }
    }

    /// <summary>
    /// BoolProperty: bUseCompartment
    /// </summary>
    public unsafe bool bUseCompartment
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 488) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 488); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 488); }
    }

    /// <summary>
    /// BoolProperty: AlwaysLoadOnClient
    /// </summary>
    public unsafe bool AlwaysLoadOnClient
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 488) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 488); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 488); }
    }

    /// <summary>
    /// BoolProperty: AlwaysLoadOnServer
    /// </summary>
    public unsafe bool AlwaysLoadOnServer
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 488) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 488); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 488); }
    }

    /// <summary>
    /// BoolProperty: bIgnoreHiddenActorsMembership
    /// </summary>
    public unsafe bool bIgnoreHiddenActorsMembership
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 488) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 488); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 488); }
    }

    /// <summary>
    /// BoolProperty: AbsoluteTranslation
    /// </summary>
    public unsafe bool AbsoluteTranslation
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 488) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 488); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 488); }
    }

    /// <summary>
    /// BoolProperty: AbsoluteRotation
    /// </summary>
    public unsafe bool AbsoluteRotation
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 488) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 488); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 488); }
    }

    /// <summary>
    /// BoolProperty: AbsoluteScale
    /// </summary>
    public unsafe bool AbsoluteScale
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 488) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 488); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 488); }
    }

    /// <summary>
    /// BoolProperty: bAllowShadowFade
    /// </summary>
    public unsafe bool bAllowShadowFade
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 488) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 488); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 488); }
    }

    /// <summary>
    /// BoolProperty: bSupportedOnMobile
    /// </summary>
    public unsafe bool bSupportedOnMobile
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 488) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 488); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 488); }
    }

    /// <summary>
    /// BoolProperty: bWasSNFiltered
    /// </summary>
    public unsafe bool bWasSNFiltered
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 488) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 488); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 488); }
    }

    /// <summary>
    /// BoolProperty: bEnableRBFixedFlag
    /// </summary>
    public unsafe bool bEnableRBFixedFlag
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 488) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 488); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 488); }
    }

    /// <summary>
    /// BoolProperty: bAddPxShapesToSceneQueryStructure
    /// </summary>
    public unsafe bool bAddPxShapesToSceneQueryStructure
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 488) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 488); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 488); }
    }

    /// <summary>
    /// IntProperty: QuadTreeEntry
    /// </summary>
    public unsafe int QuadTreeEntry
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 492); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 492); }
    }

    /// <summary>
    /// IntProperty: TranslucencySortPriority
    /// </summary>
    public unsafe int TranslucencySortPriority
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 496); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 496); }
    }

    /// <summary>
    /// IntProperty: VisibilityId
    /// </summary>
    public unsafe int VisibilityId
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 500); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 500); }
    }

    /// <summary>
    /// IntProperty: UmbraId
    /// </summary>
    public unsafe int UmbraId
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 504); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 504); }
    }

    /// <summary>
    /// IntProperty: UmbraIdVersion
    /// </summary>
    public unsafe int UmbraIdVersion
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 508); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 508); }
    }

    /// <summary>
    /// StructProperty: LightingChannels
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT LightingChannels
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 512); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 512); }
    }

    /// <summary>
    /// StructProperty: RBCollideWithChannels
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT RBCollideWithChannels
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 516); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 516); }
    }

    /// <summary>
    /// StructProperty: PhysXShapeFilterFlags
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT PhysXShapeFilterFlags
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 520); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 520); }
    }

    /// <summary>
    /// ByteProperty: RBChannel
    /// </summary>
    public unsafe byte RBChannel
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 524); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 524); }
    }

    /// <summary>
    /// ByteProperty: DepthPriorityGroup
    /// </summary>
    public unsafe byte DepthPriorityGroup
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 525); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 525); }
    }

    /// <summary>
    /// ByteProperty: DetailMode
    /// </summary>
    public unsafe byte DetailMode
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 526); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 526); }
    }

    /// <summary>
    /// ByteProperty: RBDominanceGroup
    /// </summary>
    public unsafe byte RBDominanceGroup
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 527); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 527); }
    }

    /// <summary>
    /// IntProperty: LevelEdgeCollectionIndex
    /// </summary>
    public unsafe int LevelEdgeCollectionIndex
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 528); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 528); }
    }

    /// <summary>
    /// StructProperty: OverrideRBPhysScene
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT OverrideRBPhysScene
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 532); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 532); }
    }

    /// <summary>
    /// Struct: FMaterialViewRelevance
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 0)]
    public partial record struct FMaterialViewRelevance
    {
        /// <summary>
        /// BoolProperty: bOpaque
        /// </summary>
        public unsafe bool bOpaque
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 0) & 0) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 0); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 0); }; }
        }

        /// <summary>
        /// BoolProperty: bMasked
        /// </summary>
        public unsafe bool bMasked
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 0) & 0) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 0); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 0); }; }
        }

        /// <summary>
        /// BoolProperty: bTranslucency
        /// </summary>
        public unsafe bool bTranslucency
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 0) & 0) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 0); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 0); }; }
        }

        /// <summary>
        /// BoolProperty: bDistortion
        /// </summary>
        public unsafe bool bDistortion
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 0) & 0) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 0); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 0); }; }
        }

        /// <summary>
        /// BoolProperty: bOneLayerDistortionRelevance
        /// </summary>
        public unsafe bool bOneLayerDistortionRelevance
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 0) & 0) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 0); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 0); }; }
        }

        /// <summary>
        /// BoolProperty: bInheritDominantShadowsRelevance
        /// </summary>
        public unsafe bool bInheritDominantShadowsRelevance
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 0) & 0) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 0); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 0); }; }
        }

        /// <summary>
        /// BoolProperty: bLit
        /// </summary>
        public unsafe bool bLit
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 0) & 0) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 0); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 0); }; }
        }

        /// <summary>
        /// BoolProperty: bUsesSceneColor
        /// </summary>
        public unsafe bool bUsesSceneColor
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 0) & 0) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 0); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 0); }; }
        }

        /// <summary>
        /// BoolProperty: bSceneTextureRenderBehindTranslucency
        /// </summary>
        public unsafe bool bSceneTextureRenderBehindTranslucency
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 0) & 0) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 0); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 0); }; }
        }

        /// <summary>
        /// BoolProperty: bDynamicLitTranslucencyPrepass
        /// </summary>
        public unsafe bool bDynamicLitTranslucencyPrepass
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 0) & 0) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 0); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 0); }; }
        }

        /// <summary>
        /// BoolProperty: bDynamicLitTranslucencyPostRenderDepthPass
        /// </summary>
        public unsafe bool bDynamicLitTranslucencyPostRenderDepthPass
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 0) & 0) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 0); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 0); }; }
        }

        /// <summary>
        /// BoolProperty: bSoftMasked
        /// </summary>
        public unsafe bool bSoftMasked
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 0) & 0) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 0); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 0); }; }
        }

        /// <summary>
        /// BoolProperty: bTranslucencyDoF
        /// </summary>
        public unsafe bool bTranslucencyDoF
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 0) & 0) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 0); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 0); }; }
        }

        /// <summary>
        /// BoolProperty: bModulated
        /// </summary>
        public unsafe bool bModulated
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 0) & 0) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 0); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 0); }; }
        }

        /// <summary>
        /// BoolProperty: bSSS
        /// </summary>
        public unsafe bool bSSS
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 0) & 0) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 0); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 0); }; }
        }

        /// <summary>
        /// BoolProperty: bScatterDensity
        /// </summary>
        public unsafe bool bScatterDensity
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 0) & 0) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 0); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 0); }; }
        }

        /// <summary>
        /// BoolProperty: bBlurDirection
        /// </summary>
        public unsafe bool bBlurDirection
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 0) & 0) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 0); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 0); }; }
        }

        /// <summary>
        /// BoolProperty: bRenderAsPointCloud
        /// </summary>
        public unsafe bool bRenderAsPointCloud
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 0) & 0) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 0); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 0); }; }
        }

        /// <summary>
        /// BoolProperty: bRenderAsMapPointCloud
        /// </summary>
        public unsafe bool bRenderAsMapPointCloud
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 0) & 0) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 0); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 0); }; }
        }
    }
}
