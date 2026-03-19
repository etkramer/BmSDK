#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RLevelTransitionDoorBunkerNativeBase<br/>
/// (size = 0)
/// (flags = 0)
/// </summary>
public partial class RLevelTransitionDoorBunkerNativeBase : BmSDK.BmGame.RLevelTransition, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RLevelTransitionDoorBunkerNativeBase", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RLevelTransitionDoorBunkerNativeBase() { }

    /// <summary>
    /// Constructs a new RLevelTransitionDoorBunkerNativeBase
    /// </summary>
    public RLevelTransitionDoorBunkerNativeBase(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RLevelTransitionDoorBunkerNativeBase Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RLevelTransitionDoorBunkerNativeBase(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="Engine.Actor.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RLevelTransitionDoorBunkerNativeBase>
        => ((Engine.Actor)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="Engine.Actor.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RLevelTransitionDoorBunkerNativeBase>, new()
        => (TComponent)((Engine.Actor)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="Engine.Actor.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RLevelTransitionDoorBunkerNativeBase>
        => ((Engine.Actor)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="Engine.Actor.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RLevelTransitionDoorBunkerNativeBase>
        => ((Engine.Actor)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="Engine.Actor.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RLevelTransitionDoorBunkerNativeBase>
        => (TComponent)((Engine.Actor)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="Engine.Actor.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RLevelTransitionDoorBunkerNativeBase>
        => ((Engine.Actor)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="Engine.Actor.DetachScriptComponent(Type)"/>
    public void DetachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RLevelTransitionDoorBunkerNativeBase>
        => ((Engine.Actor)this).DetachScriptComponent(typeof(TComponent));

    /// <summary>
    /// ComponentProperty: Mesh
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT Mesh
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 760); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 760); }
    }

    /// <summary>
    /// BoolProperty: DoorLocked
    /// </summary>
    public unsafe bool DoorLocked
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 768) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 768); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 768); }
    }

    /// <summary>
    /// BoolProperty: bLockWhenSideStoriesDisabled
    /// </summary>
    public unsafe bool bLockWhenSideStoriesDisabled
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 768) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 768); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 768); }
    }

    /// <summary>
    /// BoolProperty: StartedOtherLevel
    /// </summary>
    public unsafe bool StartedOtherLevel
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 768) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 768); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 768); }
    }

    /// <summary>
    /// BoolProperty: OtherLevelVisible
    /// </summary>
    public unsafe bool OtherLevelVisible
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 768) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 768); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 768); }
    }

    /// <summary>
    /// BoolProperty: StartedLevelHere
    /// </summary>
    public unsafe bool StartedLevelHere
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 768) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 768); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 768); }
    }

    /// <summary>
    /// BoolProperty: ForceOpen
    /// </summary>
    public unsafe bool ForceOpen
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 768) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 768); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 768); }
    }

    /// <summary>
    /// BoolProperty: ForceUnloadWhenClosed
    /// </summary>
    public unsafe bool ForceUnloadWhenClosed
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 768) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 768); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 768); }
    }

    /// <summary>
    /// BoolProperty: bUnlockAutomatedLevelStreaming
    /// </summary>
    public unsafe bool bUnlockAutomatedLevelStreaming
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 768) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 768); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 768); }
    }

    /// <summary>
    /// BoolProperty: bInTriggerArea
    /// </summary>
    public unsafe bool bInTriggerArea
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 768) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 768); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 768); }
    }

    /// <summary>
    /// BoolProperty: bTriggeredCombatLockedEvent
    /// </summary>
    public unsafe bool bTriggeredCombatLockedEvent
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 768) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 768); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 768); }
    }

    /// <summary>
    /// BoolProperty: bClosing
    /// </summary>
    public unsafe bool bClosing
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 768) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 768); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 768); }
    }

    /// <summary>
    /// BoolProperty: bTriggeredUsedWhenLocked
    /// </summary>
    public unsafe bool bTriggeredUsedWhenLocked
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 768) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 768); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 768); }
    }

    /// <summary>
    /// FloatProperty: PlayerOpenRange
    /// </summary>
    public unsafe float PlayerOpenRange
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 772); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 772); }
    }

    /// <summary>
    /// FloatProperty: PlayerOpenHeight
    /// </summary>
    public unsafe float PlayerOpenHeight
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 776); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 776); }
    }

    /// <summary>
    /// ObjectProperty: VillainBlocker
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT VillainBlocker
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 780); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 780); }
    }

    /// <summary>
    /// ComponentProperty: PlayerBlocker
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT PlayerBlocker
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 788); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 788); }
    }
}
