#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Class: MaterialExpressionTransform<br/>
/// (size = 0)
/// (flags = 0)
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
