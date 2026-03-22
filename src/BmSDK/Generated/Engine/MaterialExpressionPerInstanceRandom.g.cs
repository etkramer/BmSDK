#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Class: MaterialExpressionPerInstanceRandom<br/>
/// (size = 92)
/// (flags = 134226066)
/// </summary>
public partial class MaterialExpressionPerInstanceRandom : BmSDK.Engine.MaterialExpression, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Engine.MaterialExpressionPerInstanceRandom", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal MaterialExpressionPerInstanceRandom() { }

    /// <summary>
    /// Constructs a new MaterialExpressionPerInstanceRandom
    /// </summary>
    public MaterialExpressionPerInstanceRandom(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, MaterialExpressionPerInstanceRandom Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected MaterialExpressionPerInstanceRandom(nint ptr) : base(ptr) { }

}
