#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: MSpecialMoveInstance_ShootHandGunRh<br/>
/// (size = 0)
/// (flags = 0)
/// </summary>
public partial class MSpecialMoveInstance_ShootHandGunRh : BmSDK.BmGame.RSpecialMoveInstance, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.MSpecialMoveInstance_ShootHandGunRh", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal MSpecialMoveInstance_ShootHandGunRh() { }

    /// <summary>
    /// Constructs a new MSpecialMoveInstance_ShootHandGunRh
    /// </summary>
    public MSpecialMoveInstance_ShootHandGunRh(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, MSpecialMoveInstance_ShootHandGunRh Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected MSpecialMoveInstance_ShootHandGunRh(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="Engine.Actor.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<MSpecialMoveInstance_ShootHandGunRh>
        => ((Engine.Actor)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="Engine.Actor.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<MSpecialMoveInstance_ShootHandGunRh>, new()
        => (TComponent)((Engine.Actor)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="Engine.Actor.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<MSpecialMoveInstance_ShootHandGunRh>
        => ((Engine.Actor)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="Engine.Actor.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<MSpecialMoveInstance_ShootHandGunRh>
        => ((Engine.Actor)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="Engine.Actor.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<MSpecialMoveInstance_ShootHandGunRh>
        => (TComponent)((Engine.Actor)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="Engine.Actor.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<MSpecialMoveInstance_ShootHandGunRh>
        => ((Engine.Actor)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="Engine.Actor.DetachScriptComponent(Type)"/>
    public void DetachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<MSpecialMoveInstance_ShootHandGunRh>
        => ((Engine.Actor)this).DetachScriptComponent(typeof(TComponent));

    /// <summary>
    /// StructProperty: CurrentMoveLocator
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT CurrentMoveLocator
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 668); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 668); }
    }

    /// <summary>
    /// BoolProperty: bPushedState
    /// </summary>
    public unsafe bool bPushedState
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 800) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 800); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 800); }
    }

    /// <summary>
    /// BoolProperty: bUsesMoveTo
    /// </summary>
    public unsafe bool bUsesMoveTo
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 800) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 800); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 800); }
    }

    /// <summary>
    /// BoolProperty: bAuthoritativeMovement
    /// </summary>
    public unsafe bool bAuthoritativeMovement
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 800) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 800); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 800); }
    }

    /// <summary>
    /// BoolProperty: bIsVulnerableDuringCombat
    /// </summary>
    public unsafe bool bIsVulnerableDuringCombat
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 800) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 800); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 800); }
    }

    /// <summary>
    /// BoolProperty: bCanBeAttacked
    /// </summary>
    public unsafe bool bCanBeAttacked
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 800) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 800); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 800); }
    }

    /// <summary>
    /// BoolProperty: bHiddenMove
    /// </summary>
    public unsafe bool bHiddenMove
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 800) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 800); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 800); }
    }

    /// <summary>
    /// BoolProperty: bUseCameraAnim
    /// </summary>
    public unsafe bool bUseCameraAnim
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 800) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 800); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 800); }
    }

    /// <summary>
    /// BoolProperty: bCameraAnimPlayed
    /// </summary>
    public unsafe bool bCameraAnimPlayed
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 800) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 800); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 800); }
    }

    /// <summary>
    /// BoolProperty: DontChangeState
    /// </summary>
    public unsafe bool DontChangeState
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 800) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 800); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 800); }
    }

    /// <summary>
    /// BoolProperty: bCanUseGrapple
    /// </summary>
    public unsafe bool bCanUseGrapple
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 800) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 800); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 800); }
    }

    /// <summary>
    /// BoolProperty: bCanAimGrapple
    /// </summary>
    public unsafe bool bCanAimGrapple
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 800) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 800); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 800); }
    }

    /// <summary>
    /// BoolProperty: bAllowNewAgilityMove
    /// </summary>
    public unsafe bool bAllowNewAgilityMove
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 800) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 800); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 800); }
    }

    /// <summary>
    /// BoolProperty: bDisallowRun
    /// </summary>
    public unsafe bool bDisallowRun
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 800) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 800); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 800); }
    }

    /// <summary>
    /// BoolProperty: bIgnoreInterpolationForCameraAnim
    /// </summary>
    public unsafe bool bIgnoreInterpolationForCameraAnim
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 800) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 800); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 800); }
    }

    /// <summary>
    /// BoolProperty: bDontAllowBatmobilePickup
    /// </summary>
    public unsafe bool bDontAllowBatmobilePickup
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 800) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 800); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 800); }
    }

    /// <summary>
    /// BoolProperty: mIsCaseFileMove
    /// </summary>
    public unsafe bool mIsCaseFileMove
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 800) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 800); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 800); }
    }

    /// <summary>
    /// BoolProperty: bInSlowMo
    /// </summary>
    public unsafe bool bInSlowMo
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 800) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 800); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 800); }
    }

    /// <summary>
    /// BoolProperty: bCanSetRadioMode
    /// </summary>
    public unsafe bool bCanSetRadioMode
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 800) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 800); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 800); }
    }

    /// <summary>
    /// BoolProperty: bNotBlockedByThugs
    /// </summary>
    public unsafe bool bNotBlockedByThugs
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 800) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 800); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 800); }
    }

    /// <summary>
    /// BoolProperty: bForceThugsToFlee
    /// </summary>
    public unsafe bool bForceThugsToFlee
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 800) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 800); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 800); }
    }

    /// <summary>
    /// BoolProperty: bMirrorCameraAlignOffset
    /// </summary>
    public unsafe bool bMirrorCameraAlignOffset
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 800) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 800); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 800); }
    }

    /// <summary>
    /// BoolProperty: bCanSmashWindows
    /// </summary>
    public unsafe bool bCanSmashWindows
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 800) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 800); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 800); }
    }

    /// <summary>
    /// BoolProperty: bNotBlockedByWire
    /// </summary>
    public unsafe bool bNotBlockedByWire
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 800) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 800); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 800); }
    }

    /// <summary>
    /// ObjectProperty: Config
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT Config
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 804); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 804); }
    }

    /// <summary>
    /// ObjectProperty: SequenceAction
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT SequenceAction
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 812); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 812); }
    }

    /// <summary>
    /// ObjectProperty: Player
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT Player
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 820); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 820); }
    }

    /// <summary>
    /// ObjectProperty: PlayerPawn
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT PlayerPawn
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 828); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 828); }
    }

    /// <summary>
    /// ObjectProperty: PlayerController
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT PlayerController
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 836); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 836); }
    }

    /// <summary>
    /// ObjectProperty: SpecialMoveCamera
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT SpecialMoveCamera
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 844); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 844); }
    }

    /// <summary>
    /// ObjectProperty: OverrideCameraFallback
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT OverrideCameraFallback
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 852); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 852); }
    }

    /// <summary>
    /// ByteProperty: CommentType
    /// </summary>
    public unsafe byte CommentType
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 860); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 860); }
    }

    /// <summary>
    /// StructProperty: PlayerAlertLoc
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT PlayerAlertLoc
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 864); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 864); }
    }
}
