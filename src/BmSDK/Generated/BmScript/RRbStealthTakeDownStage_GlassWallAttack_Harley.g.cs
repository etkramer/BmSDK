#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmScript;

/// <summary>
/// Class: RRbStealthTakeDownStage_GlassWallAttack_Harley<br/>
/// (size = 1224)
/// (flags = 8388626)
/// </summary>
public partial class RRbStealthTakeDownStage_GlassWallAttack_Harley : BmSDK.BmGame.RStealthTakeDownStage_GlassWallAttack, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmScript.RRbStealthTakeDownStage_GlassWallAttack_Harley", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RRbStealthTakeDownStage_GlassWallAttack_Harley() { }

    /// <summary>
    /// Constructs a new RRbStealthTakeDownStage_GlassWallAttack_Harley
    /// </summary>
    public RRbStealthTakeDownStage_GlassWallAttack_Harley(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RRbStealthTakeDownStage_GlassWallAttack_Harley Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RRbStealthTakeDownStage_GlassWallAttack_Harley(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RRbStealthTakeDownStage_GlassWallAttack_Harley>
        => ((GameObject)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RRbStealthTakeDownStage_GlassWallAttack_Harley>, new()
        => (TComponent)((GameObject)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RRbStealthTakeDownStage_GlassWallAttack_Harley>
        => ((GameObject)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RRbStealthTakeDownStage_GlassWallAttack_Harley>
        => ((GameObject)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RRbStealthTakeDownStage_GlassWallAttack_Harley>
        => (TComponent)((GameObject)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RRbStealthTakeDownStage_GlassWallAttack_Harley>
        => ((GameObject)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.DetachScriptComponent(Type)"/>
    public void DetachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RRbStealthTakeDownStage_GlassWallAttack_Harley>
        => ((GameObject)this).DetachScriptComponent(typeof(TComponent));

}
