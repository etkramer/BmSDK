#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Class: ParticleModuleTypeDataRibbon<br/>
/// (size = 96)
/// (flags = 134221970)
/// </summary>
public partial class ParticleModuleTypeDataRibbon : BmSDK.Engine.ParticleModuleTypeDataBase, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Engine.ParticleModuleTypeDataRibbon", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal ParticleModuleTypeDataRibbon() { }

    /// <summary>
    /// Constructs a new ParticleModuleTypeDataRibbon
    /// </summary>
    public ParticleModuleTypeDataRibbon(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, ParticleModuleTypeDataRibbon Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected ParticleModuleTypeDataRibbon(nint ptr) : base(ptr) { }

    /// <summary>
    /// Enum: ETrailsRenderAxisOption
    /// </summary>
    public enum ETrailsRenderAxisOption
    {
        Trails_CameraUp = 0,
        Trails_SourceUp = 1,
        Trails_WorldUp = 2,
        Trails_MAX = 3,
    }

    /// <summary>
    /// IntProperty: MaxTessellationBetweenParticles
    /// </summary>
    public unsafe int MaxTessellationBetweenParticles
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 56); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 56); }
    }

    /// <summary>
    /// IntProperty: SheetsPerTrail
    /// </summary>
    public unsafe int SheetsPerTrail
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 60); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 60); }
    }

    /// <summary>
    /// IntProperty: MaxTrailCount
    /// </summary>
    public unsafe int MaxTrailCount
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 64); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 64); }
    }

    /// <summary>
    /// IntProperty: MaxParticleInTrailCount
    /// </summary>
    public unsafe int MaxParticleInTrailCount
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 68); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 68); }
    }

    /// <summary>
    /// BoolProperty: bDeadTrailsOnDeactivate
    /// </summary>
    public unsafe bool bDeadTrailsOnDeactivate
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 72) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 72); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 72); }
    }

    /// <summary>
    /// BoolProperty: bDeadTrailsOnSourceLoss
    /// </summary>
    public unsafe bool bDeadTrailsOnSourceLoss
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 72) & 2) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 72); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 72); }
    }

    /// <summary>
    /// BoolProperty: bClipSourceSegement
    /// </summary>
    public unsafe bool bClipSourceSegement
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 72) & 4) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 72); var newMask = value ? (currentMask | 4) : (currentMask & ~4); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 72); }
    }

    /// <summary>
    /// BoolProperty: bEnablePreviousTangentRecalculation
    /// </summary>
    public unsafe bool bEnablePreviousTangentRecalculation
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 72) & 8) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 72); var newMask = value ? (currentMask | 8) : (currentMask & ~8); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 72); }
    }

    /// <summary>
    /// BoolProperty: bTangentRecalculationEveryFrame
    /// </summary>
    public unsafe bool bTangentRecalculationEveryFrame
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 72) & 16) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 72); var newMask = value ? (currentMask | 16) : (currentMask & ~16); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 72); }
    }

    /// <summary>
    /// BoolProperty: bRenderGeometry
    /// </summary>
    public unsafe bool bRenderGeometry
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 72) & 32) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 72); var newMask = value ? (currentMask | 32) : (currentMask & ~32); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 72); }
    }

    /// <summary>
    /// BoolProperty: bRenderSpawnPoints
    /// </summary>
    public unsafe bool bRenderSpawnPoints
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 72) & 64) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 72); var newMask = value ? (currentMask | 64) : (currentMask & ~64); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 72); }
    }

    /// <summary>
    /// BoolProperty: bRenderTangents
    /// </summary>
    public unsafe bool bRenderTangents
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 72) & 128) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 72); var newMask = value ? (currentMask | 128) : (currentMask & ~128); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 72); }
    }

    /// <summary>
    /// BoolProperty: bRenderTessellation
    /// </summary>
    public unsafe bool bRenderTessellation
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 72) & 256) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 72); var newMask = value ? (currentMask | 256) : (currentMask & ~256); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 72); }
    }

    /// <summary>
    /// ByteProperty: RenderAxis
    /// </summary>
    public unsafe BmSDK.Engine.ParticleModuleTypeDataRibbon.ETrailsRenderAxisOption RenderAxis
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleModuleTypeDataRibbon.ETrailsRenderAxisOption>(Ptr + 76); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 76); }
    }

    /// <summary>
    /// FloatProperty: TangentSpawningScalar
    /// </summary>
    public unsafe float TangentSpawningScalar
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 80); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 80); }
    }

    /// <summary>
    /// FloatProperty: TilingDistance
    /// </summary>
    public unsafe float TilingDistance
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 84); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 84); }
    }

    /// <summary>
    /// FloatProperty: DistanceTessellationStepSize
    /// </summary>
    public unsafe float DistanceTessellationStepSize
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 88); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 88); }
    }

    /// <summary>
    /// FloatProperty: TangentTessellationScalar
    /// </summary>
    public unsafe float TangentTessellationScalar
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 92); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 92); }
    }
}
