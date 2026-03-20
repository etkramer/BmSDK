#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Class: TerrainWeightMapTexture<br/>
/// (flags = 0)
/// </summary>
public partial class TerrainWeightMapTexture : BmSDK.Engine.Texture2D, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Engine.TerrainWeightMapTexture", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal TerrainWeightMapTexture() { }

    /// <summary>
    /// Constructs a new TerrainWeightMapTexture
    /// </summary>
    public TerrainWeightMapTexture(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, TerrainWeightMapTexture Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected TerrainWeightMapTexture(nint ptr) : base(ptr) { }

    /// <summary>
    /// ObjectProperty: ParentTerrain
    /// </summary>
    public unsafe BmSDK.Engine.Terrain ParentTerrain
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.Terrain>(Ptr + 496); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 496); }
    }

    /// <summary>
    /// ArrayProperty: WeightedMaterials
    /// </summary>
    public unsafe BmSDK.TArray<System.IntPtr> WeightedMaterials
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<System.IntPtr>>(Ptr + 504); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 504); }
    }

    /// <summary>
    /// Struct: FTerrainWeightedMaterial
    /// </summary>
    [StructLayout(LayoutKind.Explicit)]
    public partial record struct FTerrainWeightedMaterial
    {
    }
}
