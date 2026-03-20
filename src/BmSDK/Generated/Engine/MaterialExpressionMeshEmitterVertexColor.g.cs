#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Class: MaterialExpressionMeshEmitterVertexColor<br/>
/// (size = 172)
/// (flags = 0)
/// </summary>
public partial class MaterialExpressionMeshEmitterVertexColor : BmSDK.Engine.MaterialExpression, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Engine.MaterialExpressionMeshEmitterVertexColor", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal MaterialExpressionMeshEmitterVertexColor() { }

    /// <summary>
    /// Constructs a new MaterialExpressionMeshEmitterVertexColor
    /// </summary>
    public MaterialExpressionMeshEmitterVertexColor(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, MaterialExpressionMeshEmitterVertexColor Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected MaterialExpressionMeshEmitterVertexColor(nint ptr) : base(ptr) { }

}
