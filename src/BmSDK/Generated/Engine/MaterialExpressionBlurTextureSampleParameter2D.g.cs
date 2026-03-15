#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Class: MaterialExpressionBlurTextureSampleParameter2D<br/>
/// (size = 176)
/// (flags = 134226066)
/// </summary>
public partial class MaterialExpressionBlurTextureSampleParameter2D : BmSDK.Engine.MaterialExpressionBlurTextureSampleParameter, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Engine.MaterialExpressionBlurTextureSampleParameter2D", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal MaterialExpressionBlurTextureSampleParameter2D() { }

    /// <summary>
    /// Constructs a new MaterialExpressionBlurTextureSampleParameter2D
    /// </summary>
    public MaterialExpressionBlurTextureSampleParameter2D(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, MaterialExpressionBlurTextureSampleParameter2D Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected MaterialExpressionBlurTextureSampleParameter2D(nint ptr) : base(ptr) { }

}
