#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Class: MaterialExpressionClamp<br/>
/// (size = 176)
/// (flags = 134217874)
/// </summary>
public partial class MaterialExpressionClamp : BmSDK.Engine.MaterialExpression, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Engine.MaterialExpressionClamp", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    /// <summary>
    /// Gets the class default object as MaterialExpressionClamp.
    /// </summary>
    public static MaterialExpressionClamp DefaultObject => (MaterialExpressionClamp)StaticClass().DefaultObject;

    internal MaterialExpressionClamp() { }

    /// <summary>
    /// Constructs a new MaterialExpressionClamp
    /// </summary>
    public MaterialExpressionClamp(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, MaterialExpressionClamp Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected MaterialExpressionClamp(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<MaterialExpressionClamp>
        => ((GameObject)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<MaterialExpressionClamp>, new()
        => (TComponent)((GameObject)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<MaterialExpressionClamp>
        => ((GameObject)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<MaterialExpressionClamp>
        => ((GameObject)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<MaterialExpressionClamp>
        => (TComponent)((GameObject)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponents(Type)"/>
    public System.Collections.Generic.IReadOnlyList<TComponent> GetScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<MaterialExpressionClamp>
        => ((GameObject)this).GetScriptComponents(typeof(TComponent)).Cast<TComponent>().ToList();

    /// <inheritdoc cref="GameObject.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<MaterialExpressionClamp>
        => ((GameObject)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.DetachScriptComponents(Type)"/>
    public void DetachScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<MaterialExpressionClamp>
        => ((GameObject)this).DetachScriptComponents(typeof(TComponent));

    /// <summary>
    /// StructProperty: Input
    /// </summary>
    public unsafe ref BmSDK.Engine.MaterialExpression.FExpressionInput Input
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.Engine.MaterialExpression.FExpressionInput>(Ptr + 92);

    /// <summary>
    /// StructProperty: Min
    /// </summary>
    public unsafe ref BmSDK.Engine.MaterialExpression.FExpressionInput Min
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.Engine.MaterialExpression.FExpressionInput>(Ptr + 120);

    /// <summary>
    /// StructProperty: Max
    /// </summary>
    public unsafe ref BmSDK.Engine.MaterialExpression.FExpressionInput Max
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.Engine.MaterialExpression.FExpressionInput>(Ptr + 148);
}
