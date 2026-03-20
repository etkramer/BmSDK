#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Class: MaterialExpressionMeshEmitterDynamicParameter<br/>
/// (flags = 0)
/// </summary>
public partial class MaterialExpressionMeshEmitterDynamicParameter : BmSDK.Engine.MaterialExpressionDynamicParameter, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Engine.MaterialExpressionMeshEmitterDynamicParameter", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal MaterialExpressionMeshEmitterDynamicParameter() { }

    /// <summary>
    /// Constructs a new MaterialExpressionMeshEmitterDynamicParameter
    /// </summary>
    public MaterialExpressionMeshEmitterDynamicParameter(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, MaterialExpressionMeshEmitterDynamicParameter Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected MaterialExpressionMeshEmitterDynamicParameter(nint ptr) : base(ptr) { }

}
