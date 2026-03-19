#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RSpecialMoveInstance_HarpoonThug<br/>
/// (size = 0)
/// (flags = 0)
/// </summary>
public partial class RSpecialMoveInstance_HarpoonThug : BmSDK.BmGame.RSpecialMoveInstance_HarpoonBase, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RSpecialMoveInstance_HarpoonThug", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RSpecialMoveInstance_HarpoonThug() { }

    /// <summary>
    /// Constructs a new RSpecialMoveInstance_HarpoonThug
    /// </summary>
    public RSpecialMoveInstance_HarpoonThug(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RSpecialMoveInstance_HarpoonThug Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RSpecialMoveInstance_HarpoonThug(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="Engine.Actor.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RSpecialMoveInstance_HarpoonThug>
        => ((Engine.Actor)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="Engine.Actor.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RSpecialMoveInstance_HarpoonThug>, new()
        => (TComponent)((Engine.Actor)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="Engine.Actor.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RSpecialMoveInstance_HarpoonThug>
        => ((Engine.Actor)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="Engine.Actor.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RSpecialMoveInstance_HarpoonThug>
        => ((Engine.Actor)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="Engine.Actor.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RSpecialMoveInstance_HarpoonThug>
        => (TComponent)((Engine.Actor)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="Engine.Actor.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RSpecialMoveInstance_HarpoonThug>
        => ((Engine.Actor)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="Engine.Actor.DetachScriptComponent(Type)"/>
    public void DetachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RSpecialMoveInstance_HarpoonThug>
        => ((Engine.Actor)this).DetachScriptComponent(typeof(TComponent));

    /// <summary>
    /// StructProperty: FireTransition
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT FireTransition
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 916); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 916); }
    }

    /// <summary>
    /// BoolProperty: bDisarm
    /// </summary>
    public unsafe bool bDisarm
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 920) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 920); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 920); }
    }

    /// <summary>
    /// BoolProperty: bFrozenTarget
    /// </summary>
    public unsafe bool bFrozenTarget
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 920) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 920); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 920); }
    }

    /// <summary>
    /// BoolProperty: bTargetWasChargedUp
    /// </summary>
    public unsafe bool bTargetWasChargedUp
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 920) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 920); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 920); }
    }

    /// <summary>
    /// BoolProperty: bClearComboOnCancel
    /// </summary>
    public unsafe bool bClearComboOnCancel
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 920) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 920); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 920); }
    }

    /// <summary>
    /// StructProperty: ReleaseClawImpulse
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT ReleaseClawImpulse
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 924); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 924); }
    }

    /// <summary>
    /// IntProperty: bTugNextFrame
    /// </summary>
    public unsafe int bTugNextFrame
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 936); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 936); }
    }

    /// <summary>
    /// ObjectProperty: ChargeEmitter
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT ChargeEmitter
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 940); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 940); }
    }
}
