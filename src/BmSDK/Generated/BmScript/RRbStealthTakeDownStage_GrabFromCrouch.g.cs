#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmScript;

/// <summary>
/// Class: RRbStealthTakeDownStage_GrabFromCrouch<br/>
/// (size = 1060)
/// (flags = 8388626)
/// </summary>
public partial class RRbStealthTakeDownStage_GrabFromCrouch : BmSDK.BmGame.RStealthTakeDownStage_GrabFromCrouch2, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmScript.RRbStealthTakeDownStage_GrabFromCrouch", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RRbStealthTakeDownStage_GrabFromCrouch() { }

    /// <summary>
    /// Constructs a new RRbStealthTakeDownStage_GrabFromCrouch
    /// </summary>
    public RRbStealthTakeDownStage_GrabFromCrouch(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RRbStealthTakeDownStage_GrabFromCrouch Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RRbStealthTakeDownStage_GrabFromCrouch(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RRbStealthTakeDownStage_GrabFromCrouch>
        => ((GameObject)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RRbStealthTakeDownStage_GrabFromCrouch>, new()
        => (TComponent)((GameObject)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RRbStealthTakeDownStage_GrabFromCrouch>
        => ((GameObject)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RRbStealthTakeDownStage_GrabFromCrouch>
        => ((GameObject)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RRbStealthTakeDownStage_GrabFromCrouch>
        => (TComponent)((GameObject)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RRbStealthTakeDownStage_GrabFromCrouch>
        => ((GameObject)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.DetachScriptComponent(Type)"/>
    public void DetachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RRbStealthTakeDownStage_GrabFromCrouch>
        => ((GameObject)this).DetachScriptComponent(typeof(TComponent));

}
