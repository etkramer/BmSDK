#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmScript;

/// <summary>
/// Class: RNwStealthTakeDownStage_GrabFromCrouch<br/>
/// (size = 1060)
/// (flags = 8388626)
/// </summary>
public partial class RNwStealthTakeDownStage_GrabFromCrouch : BmSDK.BmGame.RStealthTakeDownStage_GrabFromCrouch2, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmScript.RNwStealthTakeDownStage_GrabFromCrouch", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    /// <summary>
    /// Gets the class default object as RNwStealthTakeDownStage_GrabFromCrouch.
    /// </summary>
    public static RNwStealthTakeDownStage_GrabFromCrouch DefaultObject => (RNwStealthTakeDownStage_GrabFromCrouch)StaticClass().DefaultObject;

    internal RNwStealthTakeDownStage_GrabFromCrouch() { }

    /// <summary>
    /// Constructs a new RNwStealthTakeDownStage_GrabFromCrouch
    /// </summary>
    public RNwStealthTakeDownStage_GrabFromCrouch(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RNwStealthTakeDownStage_GrabFromCrouch Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RNwStealthTakeDownStage_GrabFromCrouch(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RNwStealthTakeDownStage_GrabFromCrouch>
        => ((GameObject)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RNwStealthTakeDownStage_GrabFromCrouch>, new()
        => (TComponent)((GameObject)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RNwStealthTakeDownStage_GrabFromCrouch>
        => ((GameObject)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RNwStealthTakeDownStage_GrabFromCrouch>
        => ((GameObject)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RNwStealthTakeDownStage_GrabFromCrouch>
        => (TComponent)((GameObject)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponents(Type)"/>
    public System.Collections.Generic.IReadOnlyList<TComponent> GetScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RNwStealthTakeDownStage_GrabFromCrouch>
        => ((GameObject)this).GetScriptComponents(typeof(TComponent)).Cast<TComponent>().ToList();

    /// <inheritdoc cref="GameObject.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RNwStealthTakeDownStage_GrabFromCrouch>
        => ((GameObject)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.DetachScriptComponents(Type)"/>
    public void DetachScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RNwStealthTakeDownStage_GrabFromCrouch>
        => ((GameObject)this).DetachScriptComponents(typeof(TComponent));

}
