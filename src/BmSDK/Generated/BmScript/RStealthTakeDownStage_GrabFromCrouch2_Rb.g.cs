#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmScript;

/// <summary>
/// Class: RStealthTakeDownStage_GrabFromCrouch2_Rb<br/>
/// (size = 1724)
/// (flags = 10485778)
/// </summary>
public partial class RStealthTakeDownStage_GrabFromCrouch2_Rb : BmSDK.BmGame.RStealthTakeDownStage_GrabFromCrouch2, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmScript.RStealthTakeDownStage_GrabFromCrouch2_Rb", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RStealthTakeDownStage_GrabFromCrouch2_Rb() { }

    /// <summary>
    /// Constructs a new RStealthTakeDownStage_GrabFromCrouch2_Rb
    /// </summary>
    public RStealthTakeDownStage_GrabFromCrouch2_Rb(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RStealthTakeDownStage_GrabFromCrouch2_Rb Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RStealthTakeDownStage_GrabFromCrouch2_Rb(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="Engine.Actor.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RStealthTakeDownStage_GrabFromCrouch2_Rb>
        => ((Engine.Actor)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="Engine.Actor.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RStealthTakeDownStage_GrabFromCrouch2_Rb>, new()
        => (TComponent)((Engine.Actor)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="Engine.Actor.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RStealthTakeDownStage_GrabFromCrouch2_Rb>
        => ((Engine.Actor)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="Engine.Actor.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RStealthTakeDownStage_GrabFromCrouch2_Rb>
        => ((Engine.Actor)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="Engine.Actor.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RStealthTakeDownStage_GrabFromCrouch2_Rb>
        => (TComponent)((Engine.Actor)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="Engine.Actor.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RStealthTakeDownStage_GrabFromCrouch2_Rb>
        => ((Engine.Actor)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="Engine.Actor.DetachScriptComponent(Type)"/>
    public void DetachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RStealthTakeDownStage_GrabFromCrouch2_Rb>
        => ((Engine.Actor)this).DetachScriptComponent(typeof(TComponent));

}
