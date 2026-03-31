#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmScript;

/// <summary>
/// Class: RCwStealthTakeDownStage_GrabFromCrouchSuccess<br/>
/// (size = 1184)
/// (flags = 8388626)
/// </summary>
public partial class RCwStealthTakeDownStage_GrabFromCrouchSuccess : BmSDK.BmGame.RStealthTakeDownStage_GrabFromCrouchSuccess, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmScript.RCwStealthTakeDownStage_GrabFromCrouchSuccess", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    /// <summary>
    /// Gets the class default object as RCwStealthTakeDownStage_GrabFromCrouchSuccess.
    /// </summary>
    public static RCwStealthTakeDownStage_GrabFromCrouchSuccess DefaultObject => (RCwStealthTakeDownStage_GrabFromCrouchSuccess)StaticClass().DefaultObject;

    internal RCwStealthTakeDownStage_GrabFromCrouchSuccess() { }

    /// <summary>
    /// Constructs a new RCwStealthTakeDownStage_GrabFromCrouchSuccess
    /// </summary>
    public RCwStealthTakeDownStage_GrabFromCrouchSuccess(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RCwStealthTakeDownStage_GrabFromCrouchSuccess Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RCwStealthTakeDownStage_GrabFromCrouchSuccess(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RCwStealthTakeDownStage_GrabFromCrouchSuccess>
        => ((GameObject)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RCwStealthTakeDownStage_GrabFromCrouchSuccess>, new()
        => (TComponent)((GameObject)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RCwStealthTakeDownStage_GrabFromCrouchSuccess>
        => ((GameObject)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RCwStealthTakeDownStage_GrabFromCrouchSuccess>
        => ((GameObject)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RCwStealthTakeDownStage_GrabFromCrouchSuccess>
        => (TComponent)((GameObject)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponents(Type)"/>
    public System.Collections.Generic.IReadOnlyList<TComponent> GetScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RCwStealthTakeDownStage_GrabFromCrouchSuccess>
        => ((GameObject)this).GetScriptComponents(typeof(TComponent)).Cast<TComponent>().ToList();

    /// <inheritdoc cref="GameObject.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RCwStealthTakeDownStage_GrabFromCrouchSuccess>
        => ((GameObject)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.DetachScriptComponents(Type)"/>
    public void DetachScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RCwStealthTakeDownStage_GrabFromCrouchSuccess>
        => ((GameObject)this).DetachScriptComponents(typeof(TComponent));

}
