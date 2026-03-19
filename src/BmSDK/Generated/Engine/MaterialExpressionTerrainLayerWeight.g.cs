#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Class: MaterialExpressionTerrainLayerWeight<br/>
/// (size = 0)
/// (flags = 0)
/// </summary>
public partial class MaterialExpressionTerrainLayerWeight : BmSDK.Engine.MaterialExpression, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Engine.MaterialExpressionTerrainLayerWeight", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal MaterialExpressionTerrainLayerWeight() { }

    /// <summary>
    /// Constructs a new MaterialExpressionTerrainLayerWeight
    /// </summary>
    public MaterialExpressionTerrainLayerWeight(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, MaterialExpressionTerrainLayerWeight Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected MaterialExpressionTerrainLayerWeight(nint ptr) : base(ptr) { }

    /// <summary>
    /// StructProperty: InstanceOverride
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT InstanceOverride
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 172); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 172); }
    }

    /// <summary>
    /// StructProperty: Base
    /// </summary>
    public unsafe BmSDK.Engine.MaterialExpressionTerrainLayerWeight.Layer Base
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.MaterialExpressionTerrainLayerWeight.Layer>(Ptr + 180); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 180); }
    }

    /// <summary>
    /// StructProperty: Layer
    /// </summary>
    public unsafe BmSDK.Engine.MaterialExpression.Desc Layer
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.MaterialExpression.Desc>(Ptr + 232); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 232); }
    }

    /// <summary>
    /// NameProperty: ParameterName
    /// </summary>
    public unsafe BmSDK.FName ParameterName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 284); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 284); }
    }

    /// <summary>
    /// FloatProperty: PreviewWeight
    /// </summary>
    public unsafe float PreviewWeight
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 292); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 292); }
    }

    /// <summary>
    /// StructProperty: ExpressionGUID
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT ExpressionGUID
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 296); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 296); }
    }
}
