#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Class: MaterialExpressionTextureSampleParameterMeshSubUV<br/>
/// (flags = 0)
/// </summary>
public partial class MaterialExpressionTextureSampleParameterMeshSubUV : BmSDK.Engine.MaterialExpressionTextureSampleParameter2D, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Engine.MaterialExpressionTextureSampleParameterMeshSubUV", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal MaterialExpressionTextureSampleParameterMeshSubUV() { }

    /// <summary>
    /// Constructs a new MaterialExpressionTextureSampleParameterMeshSubUV
    /// </summary>
    public MaterialExpressionTextureSampleParameterMeshSubUV(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, MaterialExpressionTextureSampleParameterMeshSubUV Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected MaterialExpressionTextureSampleParameterMeshSubUV(nint ptr) : base(ptr) { }

}
