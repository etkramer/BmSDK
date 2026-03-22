#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Class: MaterialExpressionLensFlareIntensity<br/>
/// (size = 92)
/// (flags = 134217874)
/// </summary>
public partial class MaterialExpressionLensFlareIntensity : BmSDK.Engine.MaterialExpression, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Engine.MaterialExpressionLensFlareIntensity", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal MaterialExpressionLensFlareIntensity() { }

    /// <summary>
    /// Constructs a new MaterialExpressionLensFlareIntensity
    /// </summary>
    public MaterialExpressionLensFlareIntensity(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, MaterialExpressionLensFlareIntensity Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected MaterialExpressionLensFlareIntensity(nint ptr) : base(ptr) { }

}
