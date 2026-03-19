#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RCombatMove_VillainPushThug<br/>
/// (size = 0)
/// (flags = 0)
/// </summary>
public partial class RCombatMove_VillainPushThug : BmSDK.BmGame.RCombatMove, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RCombatMove_VillainPushThug", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RCombatMove_VillainPushThug() { }

    /// <summary>
    /// Constructs a new RCombatMove_VillainPushThug
    /// </summary>
    public RCombatMove_VillainPushThug(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RCombatMove_VillainPushThug Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RCombatMove_VillainPushThug(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="Engine.Actor.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RCombatMove_VillainPushThug>
        => ((Engine.Actor)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="Engine.Actor.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RCombatMove_VillainPushThug>, new()
        => (TComponent)((Engine.Actor)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="Engine.Actor.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RCombatMove_VillainPushThug>
        => ((Engine.Actor)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="Engine.Actor.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RCombatMove_VillainPushThug>
        => ((Engine.Actor)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="Engine.Actor.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RCombatMove_VillainPushThug>
        => (TComponent)((Engine.Actor)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="Engine.Actor.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RCombatMove_VillainPushThug>
        => ((Engine.Actor)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="Engine.Actor.DetachScriptComponent(Type)"/>
    public void DetachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RCombatMove_VillainPushThug>
        => ((Engine.Actor)this).DetachScriptComponent(typeof(TComponent));

    /// <summary>
    /// BoolProperty: bDestroyOnExit
    /// </summary>
    public unsafe bool bDestroyOnExit
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 668) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 668); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 668); }
    }

    /// <summary>
    /// BoolProperty: bIsUsingCombatPoint
    /// </summary>
    public unsafe bool bIsUsingCombatPoint
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 668) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 668); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 668); }
    }

    /// <summary>
    /// BoolProperty: bUpdatePlayerMoveTo
    /// </summary>
    public unsafe bool bUpdatePlayerMoveTo
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 668) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 668); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 668); }
    }

    /// <summary>
    /// BoolProperty: bCanBeHitByElectricity
    /// </summary>
    public unsafe bool bCanBeHitByElectricity
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 668) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 668); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 668); }
    }

    /// <summary>
    /// BoolProperty: bForceCombatCam
    /// </summary>
    public unsafe bool bForceCombatCam
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 668) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 668); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 668); }
    }

    /// <summary>
    /// BoolProperty: bCanBeClearedByBehaviour
    /// </summary>
    public unsafe bool bCanBeClearedByBehaviour
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 668) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 668); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 668); }
    }

    /// <summary>
    /// BoolProperty: bAllowPlayerToFallOffLedgeIfOnRailing
    /// </summary>
    public unsafe bool bAllowPlayerToFallOffLedgeIfOnRailing
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 668) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 668); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 668); }
    }

    /// <summary>
    /// BoolProperty: bShowCriticalStrikeTutorial
    /// </summary>
    public unsafe bool bShowCriticalStrikeTutorial
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 668) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 668); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 668); }
    }

    /// <summary>
    /// BoolProperty: bCheckForSuperStrike
    /// </summary>
    public unsafe bool bCheckForSuperStrike
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 668) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 668); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 668); }
    }

    /// <summary>
    /// BoolProperty: bCallEnterCombatIfInCombat
    /// </summary>
    public unsafe bool bCallEnterCombatIfInCombat
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 668) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 668); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 668); }
    }

    /// <summary>
    /// BoolProperty: bPlayerIgnoreBlockingByCombatPawns
    /// </summary>
    public unsafe bool bPlayerIgnoreBlockingByCombatPawns
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 668) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 668); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 668); }
    }

    /// <summary>
    /// BoolProperty: bDontCountTowardsInCombatCheck
    /// </summary>
    public unsafe bool bDontCountTowardsInCombatCheck
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 668) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 668); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 668); }
    }

    /// <summary>
    /// BoolProperty: bForceThugsToRun
    /// </summary>
    public unsafe bool bForceThugsToRun
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 668) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 668); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 668); }
    }

    /// <summary>
    /// BoolProperty: bDisableHelpPrompt
    /// </summary>
    public unsafe bool bDisableHelpPrompt
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 668) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 668); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 668); }
    }

    /// <summary>
    /// BoolProperty: bAllowGrabEvenWhenTargetting
    /// </summary>
    public unsafe bool bAllowGrabEvenWhenTargetting
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 668) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 668); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 668); }
    }

    /// <summary>
    /// BoolProperty: bAllowDivingAwayFromCars
    /// </summary>
    public unsafe bool bAllowDivingAwayFromCars
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 668) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 668); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 668); }
    }

    /// <summary>
    /// BoolProperty: bPreventDroppingWeaponOnClearCombo
    /// </summary>
    public unsafe bool bPreventDroppingWeaponOnClearCombo
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 668) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 668); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 668); }
    }

    /// <summary>
    /// BoolProperty: bPreventOldMoveDroppingWeapons
    /// </summary>
    public unsafe bool bPreventOldMoveDroppingWeapons
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 668) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 668); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 668); }
    }

    /// <summary>
    /// BoolProperty: bTeleportNextFrame
    /// </summary>
    public unsafe bool bTeleportNextFrame
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 668) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 668); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 668); }
    }

    /// <summary>
    /// BoolProperty: bTeleportBackNextFrame
    /// </summary>
    public unsafe bool bTeleportBackNextFrame
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 668) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 668); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 668); }
    }

    /// <summary>
    /// BoolProperty: bInTeleport
    /// </summary>
    public unsafe bool bInTeleport
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 668) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 668); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 668); }
    }

    /// <summary>
    /// BoolProperty: bTeleported
    /// </summary>
    public unsafe bool bTeleported
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 668) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 668); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 668); }
    }

    /// <summary>
    /// BoolProperty: NoForcedCrouch
    /// </summary>
    public unsafe bool NoForcedCrouch
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 668) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 668); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 668); }
    }

    /// <summary>
    /// BoolProperty: bDualPlayFriendly
    /// </summary>
    public unsafe bool bDualPlayFriendly
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 668) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 668); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 668); }
    }

    /// <summary>
    /// BoolProperty: bHiddenDuringMove
    /// </summary>
    public unsafe bool bHiddenDuringMove
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 668) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 668); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 668); }
    }

    /// <summary>
    /// BoolProperty: bCanBeEffectedByQuickGel
    /// </summary>
    public unsafe bool bCanBeEffectedByQuickGel
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 668) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 668); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 668); }
    }

    /// <summary>
    /// ObjectProperty: IgnoreBlockingByException
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT IgnoreBlockingByException
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 672); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 672); }
    }

    /// <summary>
    /// ObjectProperty: TeleportDummyCam
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT TeleportDummyCam
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 680); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 680); }
    }

    /// <summary>
    /// ObjectProperty: TeleportCameraTarget
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT TeleportCameraTarget
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 688); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 688); }
    }

    /// <summary>
    /// ObjectProperty: RPC
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT RPC
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 696); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 696); }
    }

    /// <summary>
    /// ObjectProperty: DOFTarget
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT DOFTarget
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 704); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 704); }
    }

    /// <summary>
    /// ObjectProperty: MyCinematicCamera
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT MyCinematicCamera
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 712); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 712); }
    }

    /// <summary>
    /// StructProperty: TeleportFromLocation
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT TeleportFromLocation
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 720); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 720); }
    }

    /// <summary>
    /// StructProperty: TeleportCamOffset
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT TeleportCamOffset
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 732); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 732); }
    }

    /// <summary>
    /// StructProperty: CameraDOFSettings
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT CameraDOFSettings
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 744); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 744); }
    }

    /// <summary>
    /// FloatProperty: DOFBlur
    /// </summary>
    public unsafe float DOFBlur
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 764); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 764); }
    }

    /// <summary>
    /// NameProperty: PlayerControllerStateOnExit
    /// </summary>
    public unsafe BmSDK.FName PlayerControllerStateOnExit
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 768); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 768); }
    }
}
