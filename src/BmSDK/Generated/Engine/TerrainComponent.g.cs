#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Class: TerrainComponent<br/>
/// (flags = 0)
/// </summary>
public partial class TerrainComponent : BmSDK.Engine.PrimitiveComponent, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Engine.TerrainComponent", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal TerrainComponent() { }

    /// <summary>
    /// Constructs a new TerrainComponent
    /// </summary>
    public TerrainComponent(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, TerrainComponent Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected TerrainComponent(nint ptr) : base(ptr) { }

    /// <summary>
    /// ArrayProperty: ShadowMaps
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.Engine.ShadowMap2D> ShadowMaps
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.ShadowMap2D>>(Ptr + 540); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 540); }
    }

    /// <summary>
    /// ArrayProperty: IrrelevantLights
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.GameObject.FGuid> IrrelevantLights
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.GameObject.FGuid>>(Ptr + 556); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 556); }
    }

    /// <summary>
    /// StructProperty: TerrainObject
    /// </summary>
    public unsafe System.IntPtr TerrainObject
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.IntPtr>(Ptr + 572); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 572); }
    }

    /// <summary>
    /// IntProperty: SectionBaseX
    /// </summary>
    public unsafe int SectionBaseX
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 580); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 580); }
    }

    /// <summary>
    /// IntProperty: SectionBaseY
    /// </summary>
    public unsafe int SectionBaseY
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 584); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 584); }
    }

    /// <summary>
    /// IntProperty: SectionSizeX
    /// </summary>
    public unsafe int SectionSizeX
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 588); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 588); }
    }

    /// <summary>
    /// IntProperty: SectionSizeY
    /// </summary>
    public unsafe int SectionSizeY
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 592); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 592); }
    }

    /// <summary>
    /// IntProperty: TrueSectionSizeX
    /// </summary>
    public unsafe int TrueSectionSizeX
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 596); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 596); }
    }

    /// <summary>
    /// IntProperty: TrueSectionSizeY
    /// </summary>
    public unsafe int TrueSectionSizeY
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 600); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 600); }
    }

    /// <summary>
    /// StructProperty: LightMap
    /// </summary>
    public unsafe BmSDK.Engine.EngineTypes.FLightMapRef LightMap
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.EngineTypes.FLightMapRef>(Ptr + 604); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 604); }
    }

    /// <summary>
    /// ArrayProperty: PatchBounds
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.Engine.TerrainComponent.FTerrainPatchBounds> PatchBounds
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.TerrainComponent.FTerrainPatchBounds>>(Ptr + 612); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 612); }
    }

    /// <summary>
    /// ArrayProperty: BatchMaterials
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.Engine.TerrainComponent.FTerrainMaterialMask> BatchMaterials
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.TerrainComponent.FTerrainMaterialMask>>(Ptr + 628); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 628); }
    }

    /// <summary>
    /// IntProperty: FullBatch
    /// </summary>
    public unsafe int FullBatch
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 644); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 644); }
    }

    /// <summary>
    /// StructProperty: BVTree
    /// </summary>
    public unsafe BmSDK.Engine.TerrainComponent.FTerrainBVTree BVTree
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.TerrainComponent.FTerrainBVTree>(Ptr + 648); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 648); }
    }

    /// <summary>
    /// ArrayProperty: CollisionVertices
    /// </summary>
    public unsafe BmSDK.TArray<System.Numerics.Vector3> CollisionVertices
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<System.Numerics.Vector3>>(Ptr + 664); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 664); }
    }

    /// <summary>
    /// StructProperty: RBHeightfield
    /// </summary>
    public unsafe System.IntPtr RBHeightfield
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.IntPtr>(Ptr + 680); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 680); }
    }

    /// <summary>
    /// BoolProperty: bDisplayCollisionLevel
    /// </summary>
    public unsafe bool bDisplayCollisionLevel
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 688) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 688); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 688); }
    }
}
