#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: MStickyConcussionGrenade<br/>
/// (size = 0)
/// (flags = 0)
/// </summary>
public partial class MStickyConcussionGrenade : BmSDK.BmGame.RProjectileGadgetBase, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.MStickyConcussionGrenade", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal MStickyConcussionGrenade() { }

    /// <summary>
    /// Constructs a new MStickyConcussionGrenade
    /// </summary>
    public MStickyConcussionGrenade(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, MStickyConcussionGrenade Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected MStickyConcussionGrenade(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="Engine.Actor.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<MStickyConcussionGrenade>
        => ((Engine.Actor)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="Engine.Actor.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<MStickyConcussionGrenade>, new()
        => (TComponent)((Engine.Actor)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="Engine.Actor.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<MStickyConcussionGrenade>
        => ((Engine.Actor)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="Engine.Actor.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<MStickyConcussionGrenade>
        => ((Engine.Actor)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="Engine.Actor.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<MStickyConcussionGrenade>
        => (TComponent)((Engine.Actor)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="Engine.Actor.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<MStickyConcussionGrenade>
        => ((Engine.Actor)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="Engine.Actor.DetachScriptComponent(Type)"/>
    public void DetachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<MStickyConcussionGrenade>
        => ((Engine.Actor)this).DetachScriptComponent(typeof(TComponent));

    /// <summary>
    /// ArrayProperty: CurrentGroupOfVillainsCaughtInBlast
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.TArray<BmSDK.BmGame.RInventoryGadget.TutorialText>> CurrentGroupOfVillainsCaughtInBlast
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.TArray<BmSDK.BmGame.RInventoryGadget.TutorialText>>>(Ptr + 2592); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2592); }
    }

    /// <summary>
    /// ArrayProperty: DeployedGrenade
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RInventoryGadget.TutorialText> DeployedGrenade
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RInventoryGadget.TutorialText>>(Ptr + 2608); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2608); }
    }

    /// <summary>
    /// IntProperty: NewestGrenadeIdx
    /// </summary>
    public unsafe int NewestGrenadeIdx
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2624); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2624); }
    }

    /// <summary>
    /// IntProperty: MaxDeployedGrenade
    /// </summary>
    public unsafe int MaxDeployedGrenade
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2628); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2628); }
    }
}
