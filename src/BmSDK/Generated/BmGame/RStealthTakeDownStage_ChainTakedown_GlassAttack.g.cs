#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RStealthTakeDownStage_ChainTakedown_GlassAttack<br/>
/// (size = 0)
/// (flags = 0)
/// </summary>
public partial class RStealthTakeDownStage_ChainTakedown_GlassAttack : BmSDK.BmGame.RStealthTakeDownStage_GlassAttack, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RStealthTakeDownStage_ChainTakedown_GlassAttack", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RStealthTakeDownStage_ChainTakedown_GlassAttack() { }

    /// <summary>
    /// Constructs a new RStealthTakeDownStage_ChainTakedown_GlassAttack
    /// </summary>
    public RStealthTakeDownStage_ChainTakedown_GlassAttack(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RStealthTakeDownStage_ChainTakedown_GlassAttack Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RStealthTakeDownStage_ChainTakedown_GlassAttack(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="Engine.Actor.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RStealthTakeDownStage_ChainTakedown_GlassAttack>
        => ((Engine.Actor)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="Engine.Actor.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RStealthTakeDownStage_ChainTakedown_GlassAttack>, new()
        => (TComponent)((Engine.Actor)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="Engine.Actor.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RStealthTakeDownStage_ChainTakedown_GlassAttack>
        => ((Engine.Actor)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="Engine.Actor.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RStealthTakeDownStage_ChainTakedown_GlassAttack>
        => ((Engine.Actor)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="Engine.Actor.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RStealthTakeDownStage_ChainTakedown_GlassAttack>
        => (TComponent)((Engine.Actor)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="Engine.Actor.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RStealthTakeDownStage_ChainTakedown_GlassAttack>
        => ((Engine.Actor)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="Engine.Actor.DetachScriptComponent(Type)"/>
    public void DetachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RStealthTakeDownStage_ChainTakedown_GlassAttack>
        => ((Engine.Actor)this).DetachScriptComponent(typeof(TComponent));

    /// <summary>
    /// ObjectProperty: GlassBase
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT GlassBase
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 1664); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1664); }
    }

    /// <summary>
    /// ObjectProperty: DestructibleBase
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT DestructibleBase
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 1672); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1672); }
    }
}
