#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Class: MaterialExpressionDecodeVertexMorph<br/>
/// (flags = 0)
/// </summary>
public partial class MaterialExpressionDecodeVertexMorph : BmSDK.Engine.MaterialExpression, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Engine.MaterialExpressionDecodeVertexMorph", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal MaterialExpressionDecodeVertexMorph() { }

    /// <summary>
    /// Constructs a new MaterialExpressionDecodeVertexMorph
    /// </summary>
    public MaterialExpressionDecodeVertexMorph(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, MaterialExpressionDecodeVertexMorph Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected MaterialExpressionDecodeVertexMorph(nint ptr) : base(ptr) { }

    /// <summary>
    /// Enum: EVertMorphFormat
    /// </summary>
    public enum EVertMorphFormat
    {
        VMF_UV2_UV3 = 0,
        VMF_VertexColor = 1,
        VMF_MAX = 2,
    }

    /// <summary>
    /// StructProperty: Distance
    /// </summary>
    public unsafe BmSDK.Engine.MaterialExpression.FExpressionInput Distance
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.MaterialExpression.FExpressionInput>(Ptr + 172); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 172); }
    }

    /// <summary>
    /// ByteProperty: VertexMorphFormat
    /// </summary>
    public unsafe BmSDK.Engine.MaterialExpressionDecodeVertexMorph.EVertMorphFormat VertexMorphFormat
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.MaterialExpressionDecodeVertexMorph.EVertMorphFormat>(Ptr + 224); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 224); }
    }
}
