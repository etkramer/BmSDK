#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmScript;

/// <summary>
/// Class: RRbStealthTakeDownStage_LedgeAttack_Harley<br/>
/// (size = 1032)
/// (flags = 8388626)
/// </summary>
public partial class RRbStealthTakeDownStage_LedgeAttack_Harley : BmSDK.BmScript.RRbStealthTakeDownStage_RailingAttack_Harley, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmScript.RRbStealthTakeDownStage_LedgeAttack_Harley", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RRbStealthTakeDownStage_LedgeAttack_Harley() { }

    /// <summary>
    /// Constructs a new RRbStealthTakeDownStage_LedgeAttack_Harley
    /// </summary>
    public RRbStealthTakeDownStage_LedgeAttack_Harley(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RRbStealthTakeDownStage_LedgeAttack_Harley Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RRbStealthTakeDownStage_LedgeAttack_Harley(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="Engine.Actor.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RRbStealthTakeDownStage_LedgeAttack_Harley>
        => ((Engine.Actor)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="Engine.Actor.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RRbStealthTakeDownStage_LedgeAttack_Harley>, new()
        => (TComponent)((Engine.Actor)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="Engine.Actor.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RRbStealthTakeDownStage_LedgeAttack_Harley>
        => ((Engine.Actor)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="Engine.Actor.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RRbStealthTakeDownStage_LedgeAttack_Harley>
        => ((Engine.Actor)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="Engine.Actor.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RRbStealthTakeDownStage_LedgeAttack_Harley>
        => (TComponent)((Engine.Actor)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="Engine.Actor.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RRbStealthTakeDownStage_LedgeAttack_Harley>
        => ((Engine.Actor)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="Engine.Actor.DetachScriptComponent(Type)"/>
    public void DetachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RRbStealthTakeDownStage_LedgeAttack_Harley>
        => ((Engine.Actor)this).DetachScriptComponent(typeof(TComponent));

}
