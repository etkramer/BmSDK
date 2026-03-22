#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Class: MaterialExpressionTransformPosition<br/>
/// (size = 121)
/// (flags = 134226066)
/// </summary>
public partial class MaterialExpressionTransformPosition : BmSDK.Engine.MaterialExpression, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Engine.MaterialExpressionTransformPosition", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal MaterialExpressionTransformPosition() { }

    /// <summary>
    /// Constructs a new MaterialExpressionTransformPosition
    /// </summary>
    public MaterialExpressionTransformPosition(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, MaterialExpressionTransformPosition Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected MaterialExpressionTransformPosition(nint ptr) : base(ptr) { }

    /// <summary>
    /// Enum: EMaterialPositionTransform
    /// </summary>
    public enum EMaterialPositionTransform
    {
        TRANSFORMPOS_World = 0,
        TRANSFORMPOS_MAX = 1,
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
    /// ByteProperty: TransformType
    /// </summary>
    public unsafe BmSDK.Engine.MaterialExpressionTransformPosition.EMaterialPositionTransform TransformType
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.MaterialExpressionTransformPosition.EMaterialPositionTransform>(Ptr + 120); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 120); }
    }
}
