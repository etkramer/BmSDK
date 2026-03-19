#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RHidePoint<br/>
/// (size = 0)
/// (flags = 0)
/// </summary>
public partial class RHidePoint : BmSDK.Engine.Actor, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RHidePoint", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RHidePoint() { }

    /// <summary>
    /// Constructs a new RHidePoint
    /// </summary>
    public RHidePoint(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RHidePoint Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RHidePoint(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="Engine.Actor.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RHidePoint>
        => ((Engine.Actor)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="Engine.Actor.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RHidePoint>, new()
        => (TComponent)((Engine.Actor)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="Engine.Actor.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RHidePoint>
        => ((Engine.Actor)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="Engine.Actor.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RHidePoint>
        => ((Engine.Actor)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="Engine.Actor.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RHidePoint>
        => (TComponent)((Engine.Actor)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="Engine.Actor.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RHidePoint>
        => ((Engine.Actor)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="Engine.Actor.DetachScriptComponent(Type)"/>
    public void DetachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RHidePoint>
        => ((Engine.Actor)this).DetachScriptComponent(typeof(TComponent));

    /// <summary>
    /// BoolProperty: bForceCeilingGrateNoisyTakedown
    /// </summary>
    public unsafe bool bForceCeilingGrateNoisyTakedown
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 668) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 668); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 668); }
    }

    /// <summary>
    /// BoolProperty: bForceCeilingGrateFearTakedown
    /// </summary>
    public unsafe bool bForceCeilingGrateFearTakedown
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 668) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 668); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 668); }
    }

    /// <summary>
    /// BoolProperty: bPerfectConcealment
    /// </summary>
    public unsafe bool bPerfectConcealment
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 668) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 668); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 668); }
    }

    /// <summary>
    /// BoolProperty: bPlayerOnVantage
    /// </summary>
    public unsafe bool bPlayerOnVantage
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 668) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 668); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 668); }
    }

    /// <summary>
    /// BoolProperty: bGrappleVantagePoint
    /// </summary>
    public unsafe bool bGrappleVantagePoint
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 668) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 668); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 668); }
    }

    /// <summary>
    /// BoolProperty: bSwingHidePoint
    /// </summary>
    public unsafe bool bSwingHidePoint
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 668) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 668); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 668); }
    }

    /// <summary>
    /// BoolProperty: bNoGrappleBoost
    /// </summary>
    public unsafe bool bNoGrappleBoost
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 668) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 668); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 668); }
    }

    /// <summary>
    /// BoolProperty: bCanHang
    /// </summary>
    public unsafe bool bCanHang
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 668) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 668); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 668); }
    }

    /// <summary>
    /// BoolProperty: bCanSwing
    /// </summary>
    public unsafe bool bCanSwing
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 668) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 668); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 668); }
    }

    /// <summary>
    /// BoolProperty: bDisplayAutomaticHelp
    /// </summary>
    public unsafe bool bDisplayAutomaticHelp
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 668) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 668); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 668); }
    }

    /// <summary>
    /// BoolProperty: BatmanCanJumpOff
    /// </summary>
    public unsafe bool BatmanCanJumpOff
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 668) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 668); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 668); }
    }

    /// <summary>
    /// BoolProperty: DestroyedByBomb
    /// </summary>
    public unsafe bool DestroyedByBomb
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 668) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 668); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 668); }
    }

    /// <summary>
    /// BoolProperty: bDestroyedByGunfire
    /// </summary>
    public unsafe bool bDestroyedByGunfire
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 668) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 668); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 668); }
    }

    /// <summary>
    /// BoolProperty: CanGrappleFromOtherLevels
    /// </summary>
    public unsafe bool CanGrappleFromOtherLevels
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 668) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 668); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 668); }
    }

    /// <summary>
    /// BoolProperty: bCacheDestroyVantagePointsDone
    /// </summary>
    public unsafe bool bCacheDestroyVantagePointsDone
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 668) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 668); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 668); }
    }

    /// <summary>
    /// BoolProperty: bFailedToFindThermalStandPoint
    /// </summary>
    public unsafe bool bFailedToFindThermalStandPoint
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 668) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 668); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 668); }
    }

    /// <summary>
    /// BoolProperty: ValidHidePoint
    /// </summary>
    public unsafe bool ValidHidePoint
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 668) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 668); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 668); }
    }

    /// <summary>
    /// BoolProperty: bUnusableHidePoint
    /// </summary>
    public unsafe bool bUnusableHidePoint
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 668) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 668); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 668); }
    }

    /// <summary>
    /// BoolProperty: bSuppressUnusableGrappleEvent
    /// </summary>
    public unsafe bool bSuppressUnusableGrappleEvent
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 668) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 668); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 668); }
    }

    /// <summary>
    /// BoolProperty: bLowPriorityHidePoint
    /// </summary>
    public unsafe bool bLowPriorityHidePoint
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 668) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 668); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 668); }
    }

    /// <summary>
    /// BoolProperty: bRegisteredWithPoly
    /// </summary>
    public unsafe bool bRegisteredWithPoly
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 668) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 668); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 668); }
    }

    /// <summary>
    /// BoolProperty: bCanGrappleBoost
    /// </summary>
    public unsafe bool bCanGrappleBoost
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 668) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 668); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 668); }
    }

    /// <summary>
    /// BoolProperty: AutoAdjustOnPathBuild
    /// </summary>
    public unsafe bool AutoAdjustOnPathBuild
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 668) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 668); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 668); }
    }

    /// <summary>
    /// BoolProperty: OnlyForGlideSwinging
    /// </summary>
    public unsafe bool OnlyForGlideSwinging
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 668) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 668); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 668); }
    }

    /// <summary>
    /// BoolProperty: bDisallowVantageMines
    /// </summary>
    public unsafe bool bDisallowVantageMines
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 668) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 668); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 668); }
    }

    /// <summary>
    /// BoolProperty: bIgnoreDirectPounceCollision
    /// </summary>
    public unsafe bool bIgnoreDirectPounceCollision
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 668) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 668); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 668); }
    }

    /// <summary>
    /// BoolProperty: bSwingOnly
    /// </summary>
    public unsafe bool bSwingOnly
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 668) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 668); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 668); }
    }

    /// <summary>
    /// BoolProperty: bRobinHidePoint
    /// </summary>
    public unsafe bool bRobinHidePoint
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 668) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 668); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 668); }
    }

    /// <summary>
    /// BoolProperty: bControllable
    /// </summary>
    public unsafe bool bControllable
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 668) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 668); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 668); }
    }

    /// <summary>
    /// BoolProperty: bOwnedByPlayer
    /// </summary>
    public unsafe bool bOwnedByPlayer
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 668) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 668); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 668); }
    }

    /// <summary>
    /// BoolProperty: bMarkedForHangingTakedownExploitPreventionMine
    /// </summary>
    public unsafe bool bMarkedForHangingTakedownExploitPreventionMine
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 668) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 668); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 668); }
    }

    /// <summary>
    /// ArrayProperty: AdditionalVantageRotation
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.Engine.Actor.Timers>>>>>>>>>>> AdditionalVantageRotation
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.Engine.Actor.Timers>>>>>>>>>>>>(Ptr + 672); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 672); }
    }

    /// <summary>
    /// ArrayProperty: AdditionalVantagePointYaw
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.Engine.Actor.Timers>>>>>>>>>> AdditionalVantagePointYaw
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.Engine.Actor.Timers>>>>>>>>>>>(Ptr + 688); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 688); }
    }

    /// <summary>
    /// ArrayProperty: AdditionalArrowComponent
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.Engine.Actor.Timers>>>>>>>>> AdditionalArrowComponent
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.Engine.Actor.Timers>>>>>>>>>>(Ptr + 704); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 704); }
    }

    /// <summary>
    /// ComponentProperty: GargoyleMesh
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT GargoyleMesh
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 720); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 720); }
    }

    /// <summary>
    /// StructProperty: HangOffset
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT HangOffset
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 728); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 728); }
    }

    /// <summary>
    /// StructProperty: GrappleIconOffset
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT GrappleIconOffset
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 740); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 740); }
    }

    /// <summary>
    /// FloatProperty: VantagePointRange
    /// </summary>
    public unsafe float VantagePointRange
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 752); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 752); }
    }

    /// <summary>
    /// ObjectProperty: HangMove
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT HangMove
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 756); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 756); }
    }

    /// <summary>
    /// ObjectProperty: RecoverMove
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT RecoverMove
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 764); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 764); }
    }

    /// <summary>
    /// ObjectProperty: RecoverMoveAfterGrab
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT RecoverMoveAfterGrab
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 772); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 772); }
    }

    /// <summary>
    /// ObjectProperty: SwingMove
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT SwingMove
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 780); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 780); }
    }

    /// <summary>
    /// ObjectProperty: GrappleEndGargoyleMoveLeft
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT GrappleEndGargoyleMoveLeft
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 788); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 788); }
    }

    /// <summary>
    /// ObjectProperty: GrappleEndGargoyleMoveRight
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT GrappleEndGargoyleMoveRight
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 796); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 796); }
    }

    /// <summary>
    /// ObjectProperty: AerialMountMove
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT AerialMountMove
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 804); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 804); }
    }

    /// <summary>
    /// ObjectProperty: DropOffVantagePointMove
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT DropOffVantagePointMove
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 812); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 812); }
    }

    /// <summary>
    /// ObjectProperty: DropOffFrontVantagePointMove
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT DropOffFrontVantagePointMove
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 820); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 820); }
    }

    /// <summary>
    /// ObjectProperty: VillainOnVantage
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT VillainOnVantage
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 828); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 828); }
    }

    /// <summary>
    /// ObjectProperty: LinkedHidePointsCrossLevel1
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT LinkedHidePointsCrossLevel1
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 836); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 836); }
    }

    /// <summary>
    /// ObjectProperty: LinkedHidePointsCrossLevel2
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT LinkedHidePointsCrossLevel2
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 844); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 844); }
    }

    /// <summary>
    /// ObjectProperty: LinkedHidePointsCrossLevel3
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT LinkedHidePointsCrossLevel3
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 852); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 852); }
    }

    /// <summary>
    /// ObjectProperty: LinkedHidePointsCrossLevel4
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT LinkedHidePointsCrossLevel4
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 860); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 860); }
    }

    /// <summary>
    /// ObjectProperty: LinkedHidePointsCrossLevel5
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT LinkedHidePointsCrossLevel5
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 868); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 868); }
    }

    /// <summary>
    /// ObjectProperty: LinkedHidePointsCrossLevel6
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT LinkedHidePointsCrossLevel6
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 876); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 876); }
    }

    /// <summary>
    /// ObjectProperty: LinkedHidePointsCrossLevel7
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT LinkedHidePointsCrossLevel7
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 884); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 884); }
    }

    /// <summary>
    /// ObjectProperty: LinkedHidePointsCrossLevel8
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT LinkedHidePointsCrossLevel8
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 892); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 892); }
    }

    /// <summary>
    /// ObjectProperty: LinkedHidePointsSameLevel
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT LinkedHidePointsSameLevel_0
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 900); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 900); }
    }
    /// <summary>
    /// ObjectProperty: LinkedHidePointsSameLevel
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT LinkedHidePointsSameLevel_1
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 908); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 908); }
    }
    /// <summary>
    /// ObjectProperty: LinkedHidePointsSameLevel
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT LinkedHidePointsSameLevel_2
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 916); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 916); }
    }
    /// <summary>
    /// ObjectProperty: LinkedHidePointsSameLevel
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT LinkedHidePointsSameLevel_3
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 924); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 924); }
    }
    /// <summary>
    /// ObjectProperty: LinkedHidePointsSameLevel
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT LinkedHidePointsSameLevel_4
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 932); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 932); }
    }
    /// <summary>
    /// ObjectProperty: LinkedHidePointsSameLevel
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT LinkedHidePointsSameLevel_5
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 940); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 940); }
    }
    /// <summary>
    /// ObjectProperty: LinkedHidePointsSameLevel
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT LinkedHidePointsSameLevel_6
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 948); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 948); }
    }
    /// <summary>
    /// ObjectProperty: LinkedHidePointsSameLevel
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT LinkedHidePointsSameLevel_7
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 956); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 956); }
    }

    /// <summary>
    /// ObjectProperty: Bomb
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT Bomb
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 964); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 964); }
    }

    /// <summary>
    /// ObjectProperty: GrappleImpactSound
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT GrappleImpactSound
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 972); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 972); }
    }

    /// <summary>
    /// ObjectProperty: ThermalStandPoint
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT ThermalStandPoint
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 980); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 980); }
    }

    /// <summary>
    /// ObjectProperty: ClimbLocators
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT ClimbLocators
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 988); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 988); }
    }

    /// <summary>
    /// ObjectProperty: SpawnedPoint
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT SpawnedPoint
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 996); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 996); }
    }

    /// <summary>
    /// ObjectProperty: Mine
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT Mine
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 1004); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1004); }
    }

    /// <summary>
    /// ComponentProperty: BadSprite
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT BadSprite
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 1012); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1012); }
    }

    /// <summary>
    /// ComponentProperty: GoodSprite
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT GoodSprite
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 1020); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1020); }
    }

    /// <summary>
    /// StructProperty: RopeAttachPoint
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT RopeAttachPoint
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 1028); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1028); }
    }

    /// <summary>
    /// FloatProperty: StoredRopeLengthForFear
    /// </summary>
    public unsafe float StoredRopeLengthForFear
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1040); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1040); }
    }

    /// <summary>
    /// FloatProperty: ConstrainRagdollBoxRadius
    /// </summary>
    public unsafe float ConstrainRagdollBoxRadius
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1044); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1044); }
    }

    /// <summary>
    /// ArrayProperty: HidePoints
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.Engine.Actor.Timers>>>>>>>> HidePoints
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.Engine.Actor.Timers>>>>>>>>>(Ptr + 1048); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1048); }
    }

    /// <summary>
    /// ByteProperty: HidePointCrossLevel
    /// </summary>
    public unsafe byte HidePointCrossLevel_0
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 1064); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1064); }
    }
    /// <summary>
    /// ByteProperty: HidePointCrossLevel
    /// </summary>
    public unsafe byte HidePointCrossLevel_1
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 1065); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1065); }
    }
    /// <summary>
    /// ByteProperty: HidePointCrossLevel
    /// </summary>
    public unsafe byte HidePointCrossLevel_2
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 1066); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1066); }
    }
    /// <summary>
    /// ByteProperty: HidePointCrossLevel
    /// </summary>
    public unsafe byte HidePointCrossLevel_3
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 1067); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1067); }
    }
    /// <summary>
    /// ByteProperty: HidePointCrossLevel
    /// </summary>
    public unsafe byte HidePointCrossLevel_4
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 1068); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1068); }
    }
    /// <summary>
    /// ByteProperty: HidePointCrossLevel
    /// </summary>
    public unsafe byte HidePointCrossLevel_5
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 1069); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1069); }
    }
    /// <summary>
    /// ByteProperty: HidePointCrossLevel
    /// </summary>
    public unsafe byte HidePointCrossLevel_6
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 1070); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1070); }
    }
    /// <summary>
    /// ByteProperty: HidePointCrossLevel
    /// </summary>
    public unsafe byte HidePointCrossLevel_7
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 1071); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1071); }
    }

    /// <summary>
    /// ByteProperty: WallInfo
    /// </summary>
    public unsafe byte WallInfo
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 1072); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1072); }
    }

    /// <summary>
    /// ByteProperty: VillainOnVantageCameraSide
    /// </summary>
    public unsafe byte VillainOnVantageCameraSide
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 1073); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1073); }
    }

    /// <summary>
    /// ArrayProperty: CachedDestroyVantagePoints
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.Engine.Actor.Timers>>>>>>> CachedDestroyVantagePoints
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.Engine.Actor.Timers>>>>>>>>(Ptr + 1076); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1076); }
    }

    /// <summary>
    /// ArrayProperty: CantJumpOff
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.Engine.Actor.Timers>>>>>> CantJumpOff
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.Engine.Actor.Timers>>>>>>>(Ptr + 1092); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1092); }
    }

    /// <summary>
    /// FloatProperty: GunDamage
    /// </summary>
    public unsafe float GunDamage
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1108); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1108); }
    }

    /// <summary>
    /// FloatProperty: GunDamageMax
    /// </summary>
    public unsafe float GunDamageMax
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1112); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1112); }
    }

    /// <summary>
    /// FloatProperty: RopeHealth
    /// </summary>
    public unsafe float RopeHealth
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1116); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1116); }
    }

    /// <summary>
    /// FloatProperty: RopeDmgFromRifle
    /// </summary>
    public unsafe float RopeDmgFromRifle
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1120); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1120); }
    }

    /// <summary>
    /// FloatProperty: RopeDmgFromShotgun
    /// </summary>
    public unsafe float RopeDmgFromShotgun
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1124); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1124); }
    }

    /// <summary>
    /// ArrayProperty: AttachedRopes
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.Engine.Actor.Timers>>>>> AttachedRopes
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.Engine.Actor.Timers>>>>>>(Ptr + 1128); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1128); }
    }

    /// <summary>
    /// StructProperty: OctTreeObject
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT OctTreeObject
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 1144); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1144); }
    }

    /// <summary>
    /// StructProperty: RegisteredWithPolyPos
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT RegisteredWithPolyPos
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 1212); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1212); }
    }

    /// <summary>
    /// StructProperty: CatwomanPerchOffset
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT CatwomanPerchOffset
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 1224); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1224); }
    }

    /// <summary>
    /// ArrayProperty: BlockedHidePoints
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.Engine.Actor.Timers>>>> BlockedHidePoints
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.Engine.Actor.Timers>>>>>(Ptr + 1236); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1236); }
    }

    /// <summary>
    /// FloatProperty: ExtraRCBatarangHeight
    /// </summary>
    public unsafe float ExtraRCBatarangHeight
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1252); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1252); }
    }

    /// <summary>
    /// ArrayProperty: MineAttachSocketList
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.Engine.Actor.Timers>>> MineAttachSocketList
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.Engine.Actor.Timers>>>>(Ptr + 1256); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1256); }
    }

    /// <summary>
    /// StructProperty: ExtraSpaceCheckOffset
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT ExtraSpaceCheckOffset
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 1272); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1272); }
    }

    /// <summary>
    /// FloatProperty: GrappleScoreMod
    /// </summary>
    public unsafe float GrappleScoreMod
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1284); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1284); }
    }
}
