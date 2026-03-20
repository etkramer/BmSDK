#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Class: MaterialExpressionTerrainLayerCoords<br/>
/// (size = 192)
/// (flags = 0)
/// </summary>
public partial class MaterialExpressionTerrainLayerCoords : BmSDK.Engine.MaterialExpression, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Engine.MaterialExpressionTerrainLayerCoords", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal MaterialExpressionTerrainLayerCoords() { }

    /// <summary>
    /// Constructs a new MaterialExpressionTerrainLayerCoords
    /// </summary>
    public MaterialExpressionTerrainLayerCoords(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, MaterialExpressionTerrainLayerCoords Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected MaterialExpressionTerrainLayerCoords(nint ptr) : base(ptr) { }

    /// <summary>
    /// ByteProperty: MappingType
    /// </summary>
    public unsafe BmSDK.Engine.MaterialExpressionTerrainLayerCoords.ETerrainCoordMappingType MappingType
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.MaterialExpressionTerrainLayerCoords.ETerrainCoordMappingType>(Ptr + 172); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 172); }
    }

    /// <summary>
    /// FloatProperty: MappingScale
    /// </summary>
    public unsafe float MappingScale
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 176); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 176); }
    }

    /// <summary>
    /// FloatProperty: MappingRotation
    /// </summary>
    public unsafe float MappingRotation
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 180); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 180); }
    }

    /// <summary>
    /// FloatProperty: MappingPanU
    /// </summary>
    public unsafe float MappingPanU
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 184); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 184); }
    }

    /// <summary>
    /// FloatProperty: MappingPanV
    /// </summary>
    public unsafe float MappingPanV
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 188); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 188); }
    }

    /// <summary>
    /// Enum: ETerrainCoordMappingType
    /// </summary>
    public enum ETerrainCoordMappingType
    {
        TCMT_Auto = 0,
        TCMT_XY = 1,
        TCMT_XZ = 2,
        TCMT_YZ = 3,
        TCMT_MAX = 4,
    }
}
