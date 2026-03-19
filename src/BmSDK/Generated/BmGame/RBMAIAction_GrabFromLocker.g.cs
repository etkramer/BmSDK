#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RBMAIAction_GrabFromLocker<br/>
/// (size = 0)
/// (flags = 0)
/// </summary>
public partial class RBMAIAction_GrabFromLocker : BmSDK.BmGame.RBMAIAction_WeaponSwitch, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RBMAIAction_GrabFromLocker", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RBMAIAction_GrabFromLocker() { }

    /// <summary>
    /// Constructs a new RBMAIAction_GrabFromLocker
    /// </summary>
    public RBMAIAction_GrabFromLocker(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RBMAIAction_GrabFromLocker Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RBMAIAction_GrabFromLocker(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="Engine.Actor.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RBMAIAction_GrabFromLocker>
        => ((Engine.Actor)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="Engine.Actor.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RBMAIAction_GrabFromLocker>, new()
        => (TComponent)((Engine.Actor)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="Engine.Actor.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RBMAIAction_GrabFromLocker>
        => ((Engine.Actor)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="Engine.Actor.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RBMAIAction_GrabFromLocker>
        => ((Engine.Actor)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="Engine.Actor.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RBMAIAction_GrabFromLocker>
        => (TComponent)((Engine.Actor)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="Engine.Actor.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RBMAIAction_GrabFromLocker>
        => ((Engine.Actor)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="Engine.Actor.DetachScriptComponent(Type)"/>
    public void DetachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RBMAIAction_GrabFromLocker>
        => ((Engine.Actor)this).DetachScriptComponent(typeof(TComponent));

    /// <summary>
    /// ObjectProperty: TargetLocker
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT TargetLocker
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 864); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 864); }
    }

    /// <summary>
    /// ObjectProperty: SpawnedWeapon
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT SpawnedWeapon
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 872); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 872); }
    }

    /// <summary>
    /// StructProperty: PickupAnimID
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT PickupAnimID
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 880); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 880); }
    }

    /// <summary>
    /// BoolProperty: bSwitchHandled
    /// </summary>
    public unsafe bool bSwitchHandled
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 884) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 884); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 884); }
    }

    /// <summary>
    /// BoolProperty: bInterrupted
    /// </summary>
    public unsafe bool bInterrupted
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 884) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 884); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 884); }
    }

    /// <summary>
    /// BoolProperty: bJammedExplosionTriggered
    /// </summary>
    public unsafe bool bJammedExplosionTriggered
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 884) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 884); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 884); }
    }
}
