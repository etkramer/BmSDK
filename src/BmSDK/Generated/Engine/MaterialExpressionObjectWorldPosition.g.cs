#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Class: MaterialExpressionObjectWorldPosition<br/>
/// (flags = 0)
/// </summary>
public partial class MaterialExpressionObjectWorldPosition : BmSDK.Engine.MaterialExpression, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Engine.MaterialExpressionObjectWorldPosition", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal MaterialExpressionObjectWorldPosition() { }

    /// <summary>
    /// Constructs a new MaterialExpressionObjectWorldPosition
    /// </summary>
    public MaterialExpressionObjectWorldPosition(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, MaterialExpressionObjectWorldPosition Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected MaterialExpressionObjectWorldPosition(nint ptr) : base(ptr) { }

}
