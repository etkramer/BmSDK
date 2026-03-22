#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Class: MaterialExpressionConstant<br/>
/// (size = 96)
/// (flags = 134226066)
/// </summary>
public partial class MaterialExpressionConstant : BmSDK.Engine.MaterialExpression, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Engine.MaterialExpressionConstant", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal MaterialExpressionConstant() { }

    /// <summary>
    /// Constructs a new MaterialExpressionConstant
    /// </summary>
    public MaterialExpressionConstant(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, MaterialExpressionConstant Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected MaterialExpressionConstant(nint ptr) : base(ptr) { }

    /// <summary>
    /// FloatProperty: R
    /// </summary>
    public unsafe float R
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 92); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 92); }
    }
}
