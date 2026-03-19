#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RBMAIAction_GestureAtCasualty<br/>
/// (size = 0)
/// (flags = 0)
/// </summary>
public partial class RBMAIAction_GestureAtCasualty : BmSDK.BmGame.RBMAIAction, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RBMAIAction_GestureAtCasualty", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RBMAIAction_GestureAtCasualty() { }

    /// <summary>
    /// Constructs a new RBMAIAction_GestureAtCasualty
    /// </summary>
    public RBMAIAction_GestureAtCasualty(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RBMAIAction_GestureAtCasualty Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RBMAIAction_GestureAtCasualty(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="Engine.Actor.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RBMAIAction_GestureAtCasualty>
        => ((Engine.Actor)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="Engine.Actor.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RBMAIAction_GestureAtCasualty>, new()
        => (TComponent)((Engine.Actor)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="Engine.Actor.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RBMAIAction_GestureAtCasualty>
        => ((Engine.Actor)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="Engine.Actor.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RBMAIAction_GestureAtCasualty>
        => ((Engine.Actor)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="Engine.Actor.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RBMAIAction_GestureAtCasualty>
        => (TComponent)((Engine.Actor)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="Engine.Actor.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RBMAIAction_GestureAtCasualty>
        => ((Engine.Actor)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="Engine.Actor.DetachScriptComponent(Type)"/>
    public void DetachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RBMAIAction_GestureAtCasualty>
        => ((Engine.Actor)this).DetachScriptComponent(typeof(TComponent));

    /// <summary>
    /// FloatProperty: CasDist
    /// </summary>
    public unsafe float CasDist
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 864); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 864); }
    }

    /// <summary>
    /// BoolProperty: bFar
    /// </summary>
    public unsafe bool bFar
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 868) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 868); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 868); }
    }

    /// <summary>
    /// BoolProperty: bRunning
    /// </summary>
    public unsafe bool bRunning
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 868) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 868); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 868); }
    }

    /// <summary>
    /// BoolProperty: bCocky
    /// </summary>
    public unsafe bool bCocky
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 868) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 868); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 868); }
    }

    /// <summary>
    /// BoolProperty: bForceFar
    /// </summary>
    public unsafe bool bForceFar
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 868) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 868); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 868); }
    }

    /// <summary>
    /// BoolProperty: bAnimEndsInCrouch
    /// </summary>
    public unsafe bool bAnimEndsInCrouch
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 868) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 868); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 868); }
    }

    /// <summary>
    /// StructProperty: GestureAnimID
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT GestureAnimID
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 872); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 872); }
    }

    /// <summary>
    /// ObjectProperty: Casualty
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT Casualty
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 876); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 876); }
    }
}
