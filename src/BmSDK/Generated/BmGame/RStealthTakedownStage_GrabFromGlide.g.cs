#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RStealthTakedownStage_GrabFromGlide<br/>
/// (size = 0)
/// (flags = 0)
/// </summary>
public partial class RStealthTakedownStage_GrabFromGlide : BmSDK.BmGame.RStealthTakedownStageQuickBase, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RStealthTakedownStage_GrabFromGlide", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RStealthTakedownStage_GrabFromGlide() { }

    /// <summary>
    /// Constructs a new RStealthTakedownStage_GrabFromGlide
    /// </summary>
    public RStealthTakedownStage_GrabFromGlide(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RStealthTakedownStage_GrabFromGlide Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RStealthTakedownStage_GrabFromGlide(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="Engine.Actor.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RStealthTakedownStage_GrabFromGlide>
        => ((Engine.Actor)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="Engine.Actor.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RStealthTakedownStage_GrabFromGlide>, new()
        => (TComponent)((Engine.Actor)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="Engine.Actor.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RStealthTakedownStage_GrabFromGlide>
        => ((Engine.Actor)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="Engine.Actor.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RStealthTakedownStage_GrabFromGlide>
        => ((Engine.Actor)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="Engine.Actor.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RStealthTakedownStage_GrabFromGlide>
        => (TComponent)((Engine.Actor)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="Engine.Actor.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RStealthTakedownStage_GrabFromGlide>
        => ((Engine.Actor)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="Engine.Actor.DetachScriptComponent(Type)"/>
    public void DetachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RStealthTakedownStage_GrabFromGlide>
        => ((Engine.Actor)this).DetachScriptComponent(typeof(TComponent));

    /// <summary>
    /// BoolProperty: bStartedStraining
    /// </summary>
    public unsafe bool bStartedStraining
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1664) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1664); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1664); }
    }

    /// <summary>
    /// BoolProperty: bChanceToSucceed
    /// </summary>
    public unsafe bool bChanceToSucceed
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1664) & 2) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1664); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1664); }
    }

    /// <summary>
    /// BoolProperty: bCanCancelTakedown
    /// </summary>
    public unsafe bool bCanCancelTakedown
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1664) & 4) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1664); var newMask = value ? (currentMask | 4) : (currentMask & ~4); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1664); }
    }

    /// <summary>
    /// BoolProperty: TryingToDoQuickTakedown
    /// </summary>
    public unsafe bool TryingToDoQuickTakedown
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1664) & 8) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1664); var newMask = value ? (currentMask | 8) : (currentMask & ~8); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1664); }
    }

    /// <summary>
    /// BoolProperty: bAutoTriggerQuickTakedown
    /// </summary>
    public unsafe bool bAutoTriggerQuickTakedown
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1664) & 16) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1664); var newMask = value ? (currentMask | 16) : (currentMask & ~16); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1664); }
    }

    /// <summary>
    /// BoolProperty: bCanTriggerQuickFinish
    /// </summary>
    public unsafe bool bCanTriggerQuickFinish
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1664) & 32) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1664); var newMask = value ? (currentMask | 32) : (currentMask & ~32); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1664); }
    }

    /// <summary>
    /// BoolProperty: bUseQuickFinishAnimationNotify
    /// </summary>
    public unsafe bool bUseQuickFinishAnimationNotify
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1664) & 64) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1664); var newMask = value ? (currentMask | 64) : (currentMask & ~64); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1664); }
    }

    /// <summary>
    /// BoolProperty: bFinalVictim
    /// </summary>
    public unsafe bool bFinalVictim
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1664) & 128) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1664); var newMask = value ? (currentMask | 128) : (currentMask & ~128); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1664); }
    }

    /// <summary>
    /// BoolProperty: BombDefuse
    /// </summary>
    public unsafe bool BombDefuse
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1664) & 256) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1664); var newMask = value ? (currentMask | 256) : (currentMask & ~256); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1664); }
    }

    /// <summary>
    /// BoolProperty: bPressingStrikeButtonWillPerformFearTakedown
    /// </summary>
    public unsafe bool bPressingStrikeButtonWillPerformFearTakedown
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1664) & 512) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1664); var newMask = value ? (currentMask | 512) : (currentMask & ~512); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1664); }
    }

    /// <summary>
    /// BoolProperty: bPerformFearTakedownCheckFromBatmansPosition
    /// </summary>
    public unsafe bool bPerformFearTakedownCheckFromBatmansPosition
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1664) & 1024) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1664); var newMask = value ? (currentMask | 1024) : (currentMask & ~1024); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1664); }
    }

    /// <summary>
    /// ByteProperty: SuccessTakedownClass
    /// </summary>
    public unsafe BmSDK.BmGame.RGameInfo.EStealthTakeDownStages SuccessTakedownClass
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RGameInfo.EStealthTakeDownStages>(Ptr + 1668); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1668); }
    }

    /// <summary>
    /// ByteProperty: SpecialGrateFinish
    /// </summary>
    public unsafe BmSDK.BmGame.RGameInfo.EStealthTakeDownStages SpecialGrateFinish
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RGameInfo.EStealthTakeDownStages>(Ptr + 1669); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1669); }
    }

    /// <summary>
    /// ByteProperty: SpecialLedgeFinish
    /// </summary>
    public unsafe BmSDK.BmGame.RGameInfo.EStealthTakeDownStages SpecialLedgeFinish
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RGameInfo.EStealthTakeDownStages>(Ptr + 1670); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1670); }
    }

    /// <summary>
    /// ByteProperty: SpecialGrappleFinish
    /// </summary>
    public unsafe BmSDK.BmGame.RGameInfo.EStealthTakeDownStages SpecialGrappleFinish
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RGameInfo.EStealthTakeDownStages>(Ptr + 1671); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1671); }
    }

    /// <summary>
    /// ByteProperty: CurrentButton
    /// </summary>
    public unsafe BmSDK.BmGame.RInteractInterface.EInteractableItemFaceButton CurrentButton
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RInteractInterface.EInteractableItemFaceButton>(Ptr + 1672); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1672); }
    }

    /// <summary>
    /// ClassProperty: AbortTakedownClass
    /// </summary>
    public unsafe BmSDK.Class AbortTakedownClass
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Class>(Ptr + 1676); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1676); }
    }

    /// <summary>
    /// ObjectProperty: QuickTakedownHintRumble
    /// </summary>
    public unsafe BmSDK.Engine.ForceFeedbackWaveform QuickTakedownHintRumble
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ForceFeedbackWaveform>(Ptr + 1684); }
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
