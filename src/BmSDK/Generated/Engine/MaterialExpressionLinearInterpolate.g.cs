#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Class: MaterialExpressionLinearInterpolate<br/>
/// (size = 0)
/// (flags = 0)
/// </summary>
public partial class MaterialExpressionLinearInterpolate : BmSDK.Engine.MaterialExpression, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Engine.MaterialExpressionLinearInterpolate", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal MaterialExpressionLinearInterpolate() { }

    /// <summary>
    /// Constructs a new MaterialExpressionLinearInterpolate
    /// </summary>
    public MaterialExpressionLinearInterpolate(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, MaterialExpressionLinearInterpolate Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected MaterialExpressionLinearInterpolate(nint ptr) : base(ptr) { }

    /// <summary>
    /// StructProperty: A
    /// </summary>
    public unsafe BmSDK.Engine.MaterialExpressionLinearInterpolate.B A
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.MaterialExpressionLinearInterpolate.B>(Ptr + 172); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 172); }
    }

    /// <summary>
    /// StructProperty: B
    /// </summary>
    public unsafe BmSDK.Engine.MaterialExpressionLinearInterpolate.Alpha B
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.MaterialExpressionLinearInterpolate.Alpha>(Ptr + 224); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 224); }
    }

    /// <summary>
    /// StructProperty: Alpha
    /// </summary>
    public unsafe BmSDK.Engine.MaterialExpression.Desc Alpha
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.MaterialExpression.Desc>(Ptr + 276); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 276); }
    }
}
