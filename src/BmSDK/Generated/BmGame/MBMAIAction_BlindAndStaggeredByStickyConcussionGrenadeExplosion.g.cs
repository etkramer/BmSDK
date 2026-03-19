#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: MBMAIAction_BlindAndStaggeredByStickyConcussionGrenadeExplosion<br/>
/// (size = 0)
/// (flags = 0)
/// </summary>
public partial class MBMAIAction_BlindAndStaggeredByStickyConcussionGrenadeExplosion : BmSDK.BmGame.RBMAIAction, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.MBMAIAction_BlindAndStaggeredByStickyConcussionGrenadeExplosion", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal MBMAIAction_BlindAndStaggeredByStickyConcussionGrenadeExplosion() { }

    /// <summary>
    /// Constructs a new MBMAIAction_BlindAndStaggeredByStickyConcussionGrenadeExplosion
    /// </summary>
    public MBMAIAction_BlindAndStaggeredByStickyConcussionGrenadeExplosion(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, MBMAIAction_BlindAndStaggeredByStickyConcussionGrenadeExplosion Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected MBMAIAction_BlindAndStaggeredByStickyConcussionGrenadeExplosion(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="Engine.Actor.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<MBMAIAction_BlindAndStaggeredByStickyConcussionGrenadeExplosion>
        => ((Engine.Actor)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="Engine.Actor.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<MBMAIAction_BlindAndStaggeredByStickyConcussionGrenadeExplosion>, new()
        => (TComponent)((Engine.Actor)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="Engine.Actor.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<MBMAIAction_BlindAndStaggeredByStickyConcussionGrenadeExplosion>
        => ((Engine.Actor)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="Engine.Actor.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<MBMAIAction_BlindAndStaggeredByStickyConcussionGrenadeExplosion>
        => ((Engine.Actor)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="Engine.Actor.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<MBMAIAction_BlindAndStaggeredByStickyConcussionGrenadeExplosion>
        => (TComponent)((Engine.Actor)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="Engine.Actor.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<MBMAIAction_BlindAndStaggeredByStickyConcussionGrenadeExplosion>
        => ((Engine.Actor)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="Engine.Actor.DetachScriptComponent(Type)"/>
    public void DetachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<MBMAIAction_BlindAndStaggeredByStickyConcussionGrenadeExplosion>
        => ((Engine.Actor)this).DetachScriptComponent(typeof(TComponent));

    /// <summary>
    /// FloatProperty: MaxBlindTime
    /// </summary>
    public unsafe float MaxBlindTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 864); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 864); }
    }
}
