#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Class: MaterialExpressionTextureSampleParameterCube<br/>
/// (size = 136)
/// (flags = 134226066)
/// </summary>
public partial class MaterialExpressionTextureSampleParameterCube : BmSDK.Engine.MaterialExpressionTextureSampleParameter, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Engine.MaterialExpressionTextureSampleParameterCube", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal MaterialExpressionTextureSampleParameterCube() { }

    /// <summary>
    /// Constructs a new MaterialExpressionTextureSampleParameterCube
    /// </summary>
    public MaterialExpressionTextureSampleParameterCube(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, MaterialExpressionTextureSampleParameterCube Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected MaterialExpressionTextureSampleParameterCube(nint ptr) : base(ptr) { }

}
