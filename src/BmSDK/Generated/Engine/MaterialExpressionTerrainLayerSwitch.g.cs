#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Class: MaterialExpressionTerrainLayerSwitch<br/>
/// (size = 0)
/// (flags = 0)
/// </summary>
public partial class MaterialExpressionTerrainLayerSwitch : BmSDK.Engine.MaterialExpression, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Engine.MaterialExpressionTerrainLayerSwitch", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal MaterialExpressionTerrainLayerSwitch() { }

    /// <summary>
    /// Constructs a new MaterialExpressionTerrainLayerSwitch
    /// </summary>
    public MaterialExpressionTerrainLayerSwitch(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, MaterialExpressionTerrainLayerSwitch Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected MaterialExpressionTerrainLayerSwitch(nint ptr) : base(ptr) { }

    /// <summary>
    /// StructProperty: InstanceOverride
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT InstanceOverride
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 172); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 172); }
    }

    /// <summary>
    /// StructProperty: LayerUsed
    /// </summary>
    public unsafe BmSDK.Engine.MaterialExpressionTerrainLayerSwitch.LayerNotUsed LayerUsed
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.MaterialExpressionTerrainLayerSwitch.LayerNotUsed>(Ptr + 180); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 180); }
    }

    /// <summary>
    /// StructProperty: LayerNotUsed
    /// </summary>
    public unsafe BmSDK.Engine.MaterialExpression.Desc LayerNotUsed
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
    /// BoolProperty: PreviewUsed
    /// </summary>
    public unsafe bool PreviewUsed
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 292) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 292); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 292); }
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
