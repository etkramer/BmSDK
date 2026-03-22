#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Class: MaterialExpressionTransform<br/>
/// (size = 122)
/// (flags = 134226066)
/// </summary>
public partial class MaterialExpressionTransform : BmSDK.Engine.MaterialExpression, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Engine.MaterialExpressionTransform", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal MaterialExpressionTransform() { }

    /// <summary>
    /// Constructs a new MaterialExpressionTransform
    /// </summary>
    public MaterialExpressionTransform(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, MaterialExpressionTransform Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected MaterialExpressionTransform(nint ptr) : base(ptr) { }

    /// <summary>
    /// Enum: EMaterialVectorCoordTransform
    /// </summary>
    public enum EMaterialVectorCoordTransform
    {
        TRANSFORM_World = 0,
        TRANSFORM_View = 1,
        TRANSFORM_Local = 2,
        TRANSFORM_Tangent = 3,
        TRANSFORM_MAX = 4,
    }

    /// <summary>
    /// Enum: EMaterialVectorCoordTransformSource
    /// </summary>
    public enum EMaterialVectorCoordTransformSource
    {
        TRANSFORMSOURCE_World = 0,
        TRANSFORMSOURCE_Local = 1,
        TRANSFORMSOURCE_Tangent = 2,
        TRANSFORMSOURCE_MAX = 3,
    }

    /// <summary>
    /// StructProperty: Input
    /// </summary>
    public unsafe BmSDK.Engine.MaterialExpression.FExpressionInput Input
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.MaterialExpression.FExpressionInput>(Ptr + 92); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 92); }
    }

    /// <summary>
    /// ByteProperty: TransformSourceType
    /// </summary>
    public unsafe BmSDK.Engine.MaterialExpressionTransform.EMaterialVectorCoordTransformSource TransformSourceType
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.MaterialExpressionTransform.EMaterialVectorCoordTransformSource>(Ptr + 120); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 120); }
    }

    /// <summary>
    /// ByteProperty: TransformType
    /// </summary>
    public unsafe BmSDK.Engine.MaterialExpressionTransform.EMaterialVectorCoordTransform TransformType
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.MaterialExpressionTransform.EMaterialVectorCoordTransform>(Ptr + 121); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 121); }
    }
}
