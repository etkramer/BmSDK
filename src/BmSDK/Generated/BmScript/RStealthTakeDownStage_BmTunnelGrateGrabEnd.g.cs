#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmScript;

/// <summary>
/// Class: RStealthTakeDownStage_BmTunnelGrateGrabEnd<br/>
/// (size = 0)
/// (flags = 0)
/// </summary>
public partial class RStealthTakeDownStage_BmTunnelGrateGrabEnd : BmSDK.BmGame.RStealthTakedownStageQuickBase, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmScript.RStealthTakeDownStage_BmTunnelGrateGrabEnd", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RStealthTakeDownStage_BmTunnelGrateGrabEnd() { }

    /// <summary>
    /// Constructs a new RStealthTakeDownStage_BmTunnelGrateGrabEnd
    /// </summary>
    public RStealthTakeDownStage_BmTunnelGrateGrabEnd(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RStealthTakeDownStage_BmTunnelGrateGrabEnd Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RStealthTakeDownStage_BmTunnelGrateGrabEnd(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="Engine.Actor.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RStealthTakeDownStage_BmTunnelGrateGrabEnd>
        => ((Engine.Actor)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="Engine.Actor.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RStealthTakeDownStage_BmTunnelGrateGrabEnd>, new()
        => (TComponent)((Engine.Actor)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="Engine.Actor.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RStealthTakeDownStage_BmTunnelGrateGrabEnd>
        => ((Engine.Actor)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="Engine.Actor.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RStealthTakeDownStage_BmTunnelGrateGrabEnd>
        => ((Engine.Actor)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="Engine.Actor.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RStealthTakeDownStage_BmTunnelGrateGrabEnd>
        => (TComponent)((Engine.Actor)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="Engine.Actor.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RStealthTakeDownStage_BmTunnelGrateGrabEnd>
        => ((Engine.Actor)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="Engine.Actor.DetachScriptComponent(Type)"/>
    public void DetachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RStealthTakeDownStage_BmTunnelGrateGrabEnd>
        => ((Engine.Actor)this).DetachScriptComponent(typeof(TComponent));

    /// <summary>
    /// BoolProperty: bStartedStraining
    /// </summary>
    public unsafe bool bStartedStraining
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1664) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1664); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1664); }
    }

    /// <summary>
    /// BoolProperty: bChanceToSucceed
    /// </summary>
    public unsafe bool bChanceToSucceed
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1664) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1664); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1664); }
    }

    /// <summary>
    /// BoolProperty: bCanCancelTakedown
    /// </summary>
    public unsafe bool bCanCancelTakedown
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1664) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1664); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1664); }
    }

    /// <summary>
    /// BoolProperty: TryingToDoQuickTakedown
    /// </summary>
    public unsafe bool TryingToDoQuickTakedown
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1664) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1664); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1664); }
    }

    /// <summary>
    /// BoolProperty: bAutoTriggerQuickTakedown
    /// </summary>
    public unsafe bool bAutoTriggerQuickTakedown
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1664) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1664); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1664); }
    }

    /// <summary>
    /// BoolProperty: bCanTriggerQuickFinish
    /// </summary>
    public unsafe bool bCanTriggerQuickFinish
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1664) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1664); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1664); }
    }

    /// <summary>
    /// BoolProperty: bUseQuickFinishAnimationNotify
    /// </summary>
    public unsafe bool bUseQuickFinishAnimationNotify
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1664) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1664); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1664); }
    }

    /// <summary>
    /// BoolProperty: bFinalVictim
    /// </summary>
    public unsafe bool bFinalVictim
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1664) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1664); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1664); }
    }

    /// <summary>
    /// BoolProperty: BombDefuse
    /// </summary>
    public unsafe bool BombDefuse
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1664) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1664); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1664); }
    }

    /// <summary>
    /// BoolProperty: bPressingStrikeButtonWillPerformFearTakedown
    /// </summary>
    public unsafe bool bPressingStrikeButtonWillPerformFearTakedown
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1664) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1664); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1664); }
    }

    /// <summary>
    /// BoolProperty: bPerformFearTakedownCheckFromBatmansPosition
    /// </summary>
    public unsafe bool bPerformFearTakedownCheckFromBatmansPosition
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1664) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1664); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1664); }
    }

    /// <summary>
    /// ByteProperty: SuccessTakedownClass
    /// </summary>
    public unsafe byte SuccessTakedownClass
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 1668); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1668); }
    }

    /// <summary>
    /// ByteProperty: SpecialGrateFinish
    /// </summary>
    public unsafe byte SpecialGrateFinish
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 1669); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1669); }
    }

    /// <summary>
    /// ByteProperty: SpecialLedgeFinish
    /// </summary>
    public unsafe byte SpecialLedgeFinish
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 1670); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1670); }
    }

    /// <summary>
    /// ByteProperty: SpecialGrappleFinish
    /// </summary>
    public unsafe byte SpecialGrappleFinish
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 1671); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1671); }
    }

    /// <summary>
    /// ByteProperty: CurrentButton
    /// </summary>
    public unsafe byte CurrentButton
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 1672); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1672); }
    }

    /// <summary>
    /// ClassProperty: AbortTakedownClass
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT AbortTakedownClass
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 1676); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1676); }
    }

    /// <summary>
    /// ObjectProperty: QuickTakedownHintRumble
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT QuickTakedownHintRumble
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 1684); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1684); }
    }

    /// <summary>
    /// FloatProperty: QuickTakedownDelay
    /// </summary>
    public unsafe float QuickTakedownDelay
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1692); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1692); }
    }

    /// <summary>
    /// IntProperty: BombStage
    /// </summary>
    public unsafe int BombStage
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1696); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1696); }
    }
}
