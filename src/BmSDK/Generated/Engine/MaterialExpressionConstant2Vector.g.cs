#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Class: MaterialExpressionConstant2Vector<br/>
/// (size = 0)
/// (flags = 0)
/// </summary>
public partial class MaterialExpressionConstant2Vector : BmSDK.Engine.MaterialExpression, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Engine.MaterialExpressionConstant2Vector", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal MaterialExpressionConstant2Vector() { }

    /// <summary>
    /// Constructs a new MaterialExpressionConstant2Vector
    /// </summary>
    public MaterialExpressionConstant2Vector(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, MaterialExpressionConstant2Vector Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected MaterialExpressionConstant2Vector(nint ptr) : base(ptr) { }

    /// <summary>
    /// FloatProperty: R
    /// </summary>
    public unsafe float R
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 172); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 172); }
    }

    /// <summary>
    /// FloatProperty: G
    /// </summary>
    public unsafe float G
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 176); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 176); }
    }
}
