#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Class: MaterialInterface<br/>
/// (flags = 0)
/// </summary>
public partial class MaterialInterface : BmSDK.Engine.Surface, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Engine.MaterialInterface", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal MaterialInterface() { }

    /// <summary>
    /// Constructs a new MaterialInterface
    /// </summary>
    public MaterialInterface(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, MaterialInterface Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected MaterialInterface(nint ptr) : base(ptr) { }

    /// <summary>
    /// StructProperty: ParentRefFence
    /// </summary>
    public unsafe BmSDK.GameObject.FRenderCommandFence_Mirror ParentRefFence
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.GameObject.FRenderCommandFence_Mirror>(Ptr + 84); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 84); }
    }

    /// <summary>
    /// ObjectProperty: PhysMaterial
    /// </summary>
    public unsafe BmSDK.Engine.PhysicalMaterial PhysMaterial
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.PhysicalMaterial>(Ptr + 88); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 88); }
    }

    /// <summary>
    /// StrProperty: PreviewMesh
    /// </summary>
    public unsafe BmSDK.FString PreviewMesh
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 96); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 96); }
    }

    /// <summary>
    /// StructProperty: LightingGuid
    /// </summary>
    public unsafe BmSDK.GameObject.FGuid LightingGuid
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.GameObject.FGuid>(Ptr + 112); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 112); }
    }

    /// <summary>
    /// BoolProperty: bHasQualitySwitch
    /// </summary>
    public unsafe bool bHasQualitySwitch
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 128) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 128); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 128); }
    }

    /// <summary>
    /// BoolProperty: bEnableDecalCollision
    /// </summary>
    public unsafe bool bEnableDecalCollision
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 128) & 2) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 128); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 128); }
    }

    /// <summary>
    /// Enum: EMaterialUsage
    /// </summary>
    public enum EMaterialUsage
    {
        MATUSAGE_SkeletalMesh = 0,
        MATUSAGE_FracturedMeshes = 1,
        MATUSAGE_ParticleSprites = 2,
        MATUSAGE_BeamTrails = 3,
        MATUSAGE_ParticleSubUV = 4,
        MATUSAGE_SpeedTree = 5,
        MATUSAGE_StaticLighting = 6,
        MATUSAGE_GammaCorrection = 7,
        MATUSAGE_LensFlare = 8,
        MATUSAGE_InstancedMeshParticles = 9,
        MATUSAGE_FluidSurface = 10,
        MATUSAGE_RockDecals = 11,
        MATUSAGE_Decals = 12,
        MATUSAGE_MaterialEffect = 13,
        MATUSAGE_MorphTargets = 14,
        MATUSAGE_FogVolumes = 15,
        MATUSAGE_StaticModulatedShadows = 16,
        MATUSAGE_PerVertexRockAtmosFog = 17,
        MATUSAGE_LightEnvironments = 18,
        MATUSAGE_StaticMesh = 19,
        MATUSAGE_RadialBlur = 20,
        MATUSAGE_InstancedMeshes = 21,
        MATUSAGE_SplineMesh = 22,
        MATUSAGE_ScreenDoorFade = 23,
        MATUSAGE_APEXMesh = 24,
        MATUSAGE_APEXClothing = 25,
        MATUSAGE_Terrain = 26,
        MATUSAGE_Landscape = 27,
        MATUSAGE_VTF = 28,
        MATUSAGE_DirectionalLights = 29,
        MATUSAGE_SpotLights = 30,
        MATUSAGE_PointLights = 31,
        MATUSAGE_HitMasks = 32,
        MATUSAGE_ParticleGPU = 33,
        MATUSAGE_OpacityShadows = 34,
        MATUSAGE_MAX = 35,
    }
}
