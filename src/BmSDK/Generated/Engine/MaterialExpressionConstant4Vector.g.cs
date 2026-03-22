#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Class: MaterialExpressionConstant4Vector<br/>
/// (size = 108)
/// (flags = 134226066)
/// </summary>
public partial class MaterialExpressionConstant4Vector : BmSDK.Engine.MaterialExpression, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Engine.MaterialExpressionConstant4Vector", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal MaterialExpressionConstant4Vector() { }

    /// <summary>
    /// Constructs a new MaterialExpressionConstant4Vector
    /// </summary>
    public MaterialExpressionConstant4Vector(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, MaterialExpressionConstant4Vector Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected MaterialExpressionConstant4Vector(nint ptr) : base(ptr) { }

    /// <summary>
    /// FloatProperty: R
    /// </summary>
    public unsafe float R
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 92); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 92); }
    }

    /// <summary>
    /// FloatProperty: G
    /// </summary>
    public unsafe float G
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 96); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 96); }
    }

    /// <summary>
    /// FloatProperty: B
    /// </summary>
    public unsafe float B
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 100); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 100); }
    }

    /// <summary>
    /// FloatProperty: A
    /// </summary>
    public unsafe float A
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 104); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 104); }
    }
}
