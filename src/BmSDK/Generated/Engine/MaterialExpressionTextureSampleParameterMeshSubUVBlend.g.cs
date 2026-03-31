#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Class: MaterialExpressionTextureSampleParameterMeshSubUVBlend<br/>
/// (size = 136)
/// (flags = 134226066)
/// </summary>
public partial class MaterialExpressionTextureSampleParameterMeshSubUVBlend : BmSDK.Engine.MaterialExpressionTextureSampleParameterMeshSubUV, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Engine.MaterialExpressionTextureSampleParameterMeshSubUVBlend", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    /// <summary>
    /// Gets the class default object as MaterialExpressionTextureSampleParameterMeshSubUVBlend.
    /// </summary>
    public static MaterialExpressionTextureSampleParameterMeshSubUVBlend DefaultObject => (MaterialExpressionTextureSampleParameterMeshSubUVBlend)StaticClass().DefaultObject;

    internal MaterialExpressionTextureSampleParameterMeshSubUVBlend() { }

    /// <summary>
    /// Constructs a new MaterialExpressionTextureSampleParameterMeshSubUVBlend
    /// </summary>
    public MaterialExpressionTextureSampleParameterMeshSubUVBlend(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, MaterialExpressionTextureSampleParameterMeshSubUVBlend Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected MaterialExpressionTextureSampleParameterMeshSubUVBlend(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<MaterialExpressionTextureSampleParameterMeshSubUVBlend>
        => ((GameObject)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<MaterialExpressionTextureSampleParameterMeshSubUVBlend>, new()
        => (TComponent)((GameObject)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<MaterialExpressionTextureSampleParameterMeshSubUVBlend>
        => ((GameObject)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<MaterialExpressionTextureSampleParameterMeshSubUVBlend>
        => ((GameObject)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<MaterialExpressionTextureSampleParameterMeshSubUVBlend>
        => (TComponent)((GameObject)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponents(Type)"/>
    public System.Collections.Generic.IReadOnlyList<TComponent> GetScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<MaterialExpressionTextureSampleParameterMeshSubUVBlend>
        => ((GameObject)this).GetScriptComponents(typeof(TComponent)).Cast<TComponent>().ToList();

    /// <inheritdoc cref="GameObject.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<MaterialExpressionTextureSampleParameterMeshSubUVBlend>
        => ((GameObject)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.DetachScriptComponents(Type)"/>
    public void DetachScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<MaterialExpressionTextureSampleParameterMeshSubUVBlend>
        => ((GameObject)this).DetachScriptComponents(typeof(TComponent));

}
