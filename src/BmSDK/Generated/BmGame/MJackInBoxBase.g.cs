#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: MJackInBoxBase<br/>
/// (size = 0)
/// (flags = 0)
/// </summary>
public partial class MJackInBoxBase : BmSDK.BmGame.RInventoryGadget, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.MJackInBoxBase", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal MJackInBoxBase() { }

    /// <summary>
    /// Constructs a new MJackInBoxBase
    /// </summary>
    public MJackInBoxBase(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, MJackInBoxBase Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected MJackInBoxBase(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="Engine.Actor.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<MJackInBoxBase>
        => ((Engine.Actor)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="Engine.Actor.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<MJackInBoxBase>, new()
        => (TComponent)((Engine.Actor)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="Engine.Actor.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<MJackInBoxBase>
        => ((Engine.Actor)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="Engine.Actor.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<MJackInBoxBase>
        => ((Engine.Actor)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="Engine.Actor.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<MJackInBoxBase>
        => (TComponent)((Engine.Actor)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="Engine.Actor.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<MJackInBoxBase>
        => ((Engine.Actor)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="Engine.Actor.DetachScriptComponent(Type)"/>
    public void DetachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<MJackInBoxBase>
        => ((Engine.Actor)this).DetachScriptComponent(typeof(TComponent));

    /// <summary>
    /// ObjectProperty: PlaceOnFloorMove
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT PlaceOnFloorMove
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 2068); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2068); }
    }

    /// <summary>
    /// ObjectProperty: PlaceOnFloorInCombatMove
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT PlaceOnFloorInCombatMove
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 2076); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2076); }
    }

    /// <summary>
    /// ObjectProperty: ReactToExplosionMove
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT ReactToExplosionMove
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 2084); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2084); }
    }

    /// <summary>
    /// ObjectProperty: ReactToExplosionMoveL
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT ReactToExplosionMoveL
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 2092); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2092); }
    }

    /// <summary>
    /// ObjectProperty: ReactToExplosionMoveR
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT ReactToExplosionMoveR
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 2100); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2100); }
    }

    /// <summary>
    /// ObjectProperty: ReactToExplosionMoveB
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT ReactToExplosionMoveB
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 2108); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2108); }
    }

    /// <summary>
    /// ObjectProperty: PlacedJackInBox
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT PlacedJackInBox
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 2116); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2116); }
    }

    /// <summary>
    /// ObjectProperty: ThugReactionAnimSet
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT ThugReactionAnimSet
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 2124); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2124); }
    }

    /// <summary>
    /// ObjectProperty: PlaceJackInBoxConversation
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT PlaceJackInBoxConversation
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 2132); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2132); }
    }

    /// <summary>
    /// ObjectProperty: PlaceJackInBoxWallConversation
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT PlaceJackInBoxWallConversation
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 2140); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2140); }
    }

    /// <summary>
    /// ObjectProperty: ExplodeJackInBoxConversation
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT ExplodeJackInBoxConversation
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 2148); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2148); }
    }

    /// <summary>
    /// ObjectProperty: CurrentDetonateTarget
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT CurrentDetonateTarget
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 2156); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2156); }
    }

    /// <summary>
    /// BoolProperty: bIsJITBTutorial
    /// </summary>
    public unsafe bool bIsJITBTutorial
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2164) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2164); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2164); }
    }

    /// <summary>
    /// BoolProperty: bIdleUseJITB
    /// </summary>
    public unsafe bool bIdleUseJITB
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2164) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2164); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2164); }
    }

    /// <summary>
    /// BoolProperty: bIgnoreUnequip
    /// </summary>
    public unsafe bool bIgnoreUnequip
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2164) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2164); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2164); }
    }

    /// <summary>
    /// StructProperty: DetonatorTransition
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT DetonatorTransition
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 2168); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2168); }
    }
}
