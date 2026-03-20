#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Class: MaterialExpressionLensFlareSourceDistance<br/>
/// (size = 172)
/// (flags = 0)
/// </summary>
public partial class MaterialExpressionLensFlareSourceDistance : BmSDK.Engine.MaterialExpression, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Engine.MaterialExpressionLensFlareSourceDistance", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal MaterialExpressionLensFlareSourceDistance() { }

    /// <summary>
    /// Constructs a new MaterialExpressionLensFlareSourceDistance
    /// </summary>
    public MaterialExpressionLensFlareSourceDistance(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, MaterialExpressionLensFlareSourceDistance Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected MaterialExpressionLensFlareSourceDistance(nint ptr) : base(ptr) { }

}
