#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Class: MaterialExpressionLensFlareRayDistance<br/>
/// (size = 92)
/// (flags = 134217874)
/// </summary>
public partial class MaterialExpressionLensFlareRayDistance : BmSDK.Engine.MaterialExpression, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Engine.MaterialExpressionLensFlareRayDistance", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal MaterialExpressionLensFlareRayDistance() { }

    /// <summary>
    /// Constructs a new MaterialExpressionLensFlareRayDistance
    /// </summary>
    public MaterialExpressionLensFlareRayDistance(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, MaterialExpressionLensFlareRayDistance Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected MaterialExpressionLensFlareRayDistance(nint ptr) : base(ptr) { }

}
