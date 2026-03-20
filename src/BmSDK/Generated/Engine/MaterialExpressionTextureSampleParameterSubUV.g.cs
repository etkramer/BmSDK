#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Class: MaterialExpressionTextureSampleParameterSubUV<br/>
/// (flags = 0)
/// </summary>
public partial class MaterialExpressionTextureSampleParameterSubUV : BmSDK.Engine.MaterialExpressionTextureSampleParameter2D, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Engine.MaterialExpressionTextureSampleParameterSubUV", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal MaterialExpressionTextureSampleParameterSubUV() { }

    /// <summary>
    /// Constructs a new MaterialExpressionTextureSampleParameterSubUV
    /// </summary>
    public MaterialExpressionTextureSampleParameterSubUV(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, MaterialExpressionTextureSampleParameterSubUV Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected MaterialExpressionTextureSampleParameterSubUV(nint ptr) : base(ptr) { }

}
