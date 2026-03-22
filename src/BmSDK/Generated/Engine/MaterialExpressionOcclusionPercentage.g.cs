#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Class: MaterialExpressionOcclusionPercentage<br/>
/// (size = 92)
/// (flags = 134217874)
/// </summary>
public partial class MaterialExpressionOcclusionPercentage : BmSDK.Engine.MaterialExpression, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Engine.MaterialExpressionOcclusionPercentage", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal MaterialExpressionOcclusionPercentage() { }

    /// <summary>
    /// Constructs a new MaterialExpressionOcclusionPercentage
    /// </summary>
    public MaterialExpressionOcclusionPercentage(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, MaterialExpressionOcclusionPercentage Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected MaterialExpressionOcclusionPercentage(nint ptr) : base(ptr) { }

}
