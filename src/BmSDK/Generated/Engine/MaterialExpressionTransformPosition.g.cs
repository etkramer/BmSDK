#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Class: MaterialExpressionTransformPosition<br/>
/// (size = 0)
/// (flags = 0)
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
    /// StructProperty: Input
    /// </summary>
    public unsafe BmSDK.Engine.MaterialExpression.Desc Input
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.MaterialExpression.Desc>(Ptr + 172); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 172); }
    }

    /// <summary>
    /// ByteProperty: TransformSourceType
    /// </summary>
    public unsafe byte TransformSourceType
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 224); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 224); }
    }

    /// <summary>
    /// ByteProperty: TransformType
    /// </summary>
    public unsafe byte TransformType
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 225); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 225); }
    }
}
