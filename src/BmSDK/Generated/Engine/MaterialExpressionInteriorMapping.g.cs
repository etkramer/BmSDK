#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Class: MaterialExpressionInteriorMapping<br/>
/// (size = 0)
/// (flags = 0)
/// </summary>
public partial class MaterialExpressionInteriorMapping : BmSDK.Engine.MaterialExpression, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Engine.MaterialExpressionInteriorMapping", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal MaterialExpressionInteriorMapping() { }

    /// <summary>
    /// Constructs a new MaterialExpressionInteriorMapping
    /// </summary>
    public MaterialExpressionInteriorMapping(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, MaterialExpressionInteriorMapping Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected MaterialExpressionInteriorMapping(nint ptr) : base(ptr) { }

    /// <summary>
    /// StructProperty: WSPosition
    /// </summary>
    public unsafe BmSDK.Engine.MaterialExpressionInteriorMapping.WSOffset WSPosition
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.MaterialExpressionInteriorMapping.WSOffset>(Ptr + 172); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 172); }
    }

    /// <summary>
    /// StructProperty: WSOffset
    /// </summary>
    public unsafe BmSDK.Engine.MaterialExpressionInteriorMapping.Depth WSOffset
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.MaterialExpressionInteriorMapping.Depth>(Ptr + 224); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 224); }
    }

    /// <summary>
    /// StructProperty: Depth
    /// </summary>
    public unsafe BmSDK.Engine.MaterialExpressionInteriorMapping.SampleRadius Depth
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.MaterialExpressionInteriorMapping.SampleRadius>(Ptr + 276); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 276); }
    }

    /// <summary>
    /// StructProperty: SampleRadius
    /// </summary>
    public unsafe BmSDK.Engine.MaterialExpression.Desc SampleRadius
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.MaterialExpression.Desc>(Ptr + 328); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 328); }
    }

    /// <summary>
    /// ObjectProperty: AtlasTexture
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT AtlasTexture
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 380); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 380); }
    }

    /// <summary>
    /// FloatProperty: CavityDepthMultiplier
    /// </summary>
    public unsafe float CavityDepthMultiplier
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 388); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 388); }
    }

    /// <summary>
    /// BoolProperty: bWorldSpace
    /// </summary>
    public unsafe bool bWorldSpace
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 392) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 392); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 392); }
    }
}
