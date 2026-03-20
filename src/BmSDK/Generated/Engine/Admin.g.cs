#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Class: Admin<br/>
/// (flags = 0)
/// </summary>
public partial class Admin : BmSDK.Engine.PlayerController, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Engine.Admin", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal Admin() { }

    /// <summary>
    /// Constructs a new Admin
    /// </summary>
    public Admin(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, Admin Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected Admin(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="Engine.Actor.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<Admin>
        => ((Engine.Actor)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="Engine.Actor.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<Admin>, new()
        => (TComponent)((Engine.Actor)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="Engine.Actor.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<Admin>
        => ((Engine.Actor)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="Engine.Actor.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<Admin>
        => ((Engine.Actor)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="Engine.Actor.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<Admin>
        => (TComponent)((Engine.Actor)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="Engine.Actor.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<Admin>
        => ((Engine.Actor)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="Engine.Actor.DetachScriptComponent(Type)"/>
    public void DetachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<Admin>
        => ((Engine.Actor)this).DetachScriptComponent(typeof(TComponent));

    /// <summary>
    /// ObjectProperty: Player
    /// </summary>
    public unsafe BmSDK.Engine.Player Player
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.Player>(Ptr + 1136); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1136); }
    }

    /// <summary>
    /// ObjectProperty: PlayerCamera
    /// </summary>
    public unsafe BmSDK.Engine.Camera PlayerCamera
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.Camera>(Ptr + 1144); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1144); }
    }

    /// <summary>
    /// ObjectProperty: simpleFFWaveform
    /// </summary>
    public unsafe BmSDK.Engine.ForceFeedbackWaveform simpleFFWaveform
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ForceFeedbackWaveform>(Ptr + 1152); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1152); }
    }

    /// <summary>
    /// ObjectProperty: AcknowledgedPawn
    /// </summary>
    public unsafe BmSDK.Engine.Pawn AcknowledgedPawn
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.Pawn>(Ptr + 1160); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1160); }
    }

    /// <summary>
    /// ObjectProperty: ViewTarget
    /// </summary>
    public unsafe BmSDK.Engine.Actor ViewTarget
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.Actor>(Ptr + 1168); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1168); }
    }

    /// <summary>
    /// ObjectProperty: RealViewTarget
    /// </summary>
    public unsafe BmSDK.Engine.PlayerReplicationInfo RealViewTarget
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.PlayerReplicationInfo>(Ptr + 1176); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1176); }
    }

    /// <summary>
    /// ObjectProperty: ControllingDirTrackInst
    /// </summary>
    public unsafe BmSDK.Engine.InterpTrackInstDirector ControllingDirTrackInst
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.InterpTrackInstDirector>(Ptr + 1184); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1184); }
    }

    /// <summary>
    /// ObjectProperty: myHUD
    /// </summary>
    public unsafe BmSDK.Engine.HUD myHUD
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.HUD>(Ptr + 1192); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1192); }
    }

    /// <summary>
    /// ObjectProperty: mySecondaryHUD
    /// </summary>
    public unsafe BmSDK.Engine.HUD mySecondaryHUD
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.HUD>(Ptr + 1200); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1200); }
    }

    /// <summary>
    /// ObjectProperty: SavedMoves
    /// </summary>
    public unsafe BmSDK.Engine.SavedMove SavedMoves
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.SavedMove>(Ptr + 1208); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1208); }
    }

    /// <summary>
    /// ObjectProperty: FreeMoves
    /// </summary>
    public unsafe BmSDK.Engine.SavedMove FreeMoves
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.SavedMove>(Ptr + 1216); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1216); }
    }

    /// <summary>
    /// ObjectProperty: PendingMove
    /// </summary>
    public unsafe BmSDK.Engine.SavedMove PendingMove
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.SavedMove>(Ptr + 1224); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1224); }
    }

    /// <summary>
    /// ObjectProperty: CheatManager
    /// </summary>
    public unsafe BmSDK.Engine.CheatManager CheatManager
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.CheatManager>(Ptr + 1232); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1232); }
    }

    /// <summary>
    /// ObjectProperty: PlayerInput
    /// </summary>
    public unsafe BmSDK.Engine.PlayerInput PlayerInput
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.PlayerInput>(Ptr + 1240); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1240); }
    }

    /// <summary>
    /// ObjectProperty: ForceFeedbackManager
    /// </summary>
    public unsafe BmSDK.Engine.ForceFeedbackManager ForceFeedbackManager
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ForceFeedbackManager>(Ptr + 1248); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1248); }
    }

    /// <summary>
    /// ObjectProperty: MigratedSearchToJoin
    /// </summary>
    public unsafe BmSDK.Engine.OnlineGameSearch MigratedSearchToJoin
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.OnlineGameSearch>(Ptr + 1256); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1256); }
    }

    /// <summary>
    /// ObjectProperty: OnlineSub
    /// </summary>
    public unsafe BmSDK.Engine.OnlineSubsystem OnlineSub
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.OnlineSubsystem>(Ptr + 1264); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1264); }
    }

    /// <summary>
    /// ObjectProperty: OnlinePlayerData
    /// </summary>
    public unsafe BmSDK.Engine.UIDataStore_OnlinePlayerData OnlinePlayerData
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.UIDataStore_OnlinePlayerData>(Ptr + 1272); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1272); }
    }

    /// <summary>
    /// ObjectProperty: PendingSwapConnection
    /// </summary>
    public unsafe BmSDK.Engine.NetConnection PendingSwapConnection
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.NetConnection>(Ptr + 1280); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1280); }
    }

    /// <summary>
    /// ComponentProperty: CylinderComponent
    /// </summary>
    public unsafe BmSDK.Engine.CylinderComponent CylinderComponent
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.CylinderComponent>(Ptr + 1288); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1288); }
    }

    /// <summary>
    /// ClassProperty: InputClass
    /// </summary>
    public unsafe BmSDK.Class InputClass
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Class>(Ptr + 1296); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1296); }
    }

    /// <summary>
    /// ClassProperty: CheatClass
    /// </summary>
    public unsafe BmSDK.Class CheatClass
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Class>(Ptr + 1304); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1304); }
    }

    /// <summary>
    /// ClassProperty: SavedMoveClass
    /// </summary>
    public unsafe BmSDK.Class SavedMoveClass
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Class>(Ptr + 1312); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1312); }
    }

    /// <summary>
    /// ClassProperty: CameraClass
    /// </summary>
    public unsafe BmSDK.Class CameraClass
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Class>(Ptr + 1320); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1320); }
    }

    /// <summary>
    /// BoolProperty: bFrozen
    /// </summary>
    public unsafe bool bFrozen
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1328) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1328); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1328); }
    }

    /// <summary>
    /// BoolProperty: bPressedJump
    /// </summary>
    public unsafe bool bPressedJump
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1328) & 2) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1328); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1328); }
    }

    /// <summary>
    /// BoolProperty: bDoubleJump
    /// </summary>
    public unsafe bool bDoubleJump
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1328) & 4) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1328); var newMask = value ? (currentMask | 4) : (currentMask & ~4); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1328); }
    }

    /// <summary>
    /// BoolProperty: bUpdatePosition
    /// </summary>
    public unsafe bool bUpdatePosition
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1328) & 8) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1328); var newMask = value ? (currentMask | 8) : (currentMask & ~8); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1328); }
    }

    /// <summary>
    /// BoolProperty: bUpdating
    /// </summary>
    public unsafe bool bUpdating
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1328) & 16) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1328); var newMask = value ? (currentMask | 16) : (currentMask & ~16); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1328); }
    }

    /// <summary>
    /// BoolProperty: bNeverSwitchOnPickup
    /// </summary>
    public unsafe bool bNeverSwitchOnPickup
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1328) & 32) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1328); var newMask = value ? (currentMask | 32) : (currentMask & ~32); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1328); }
    }

    /// <summary>
    /// BoolProperty: bCheatFlying
    /// </summary>
    public unsafe bool bCheatFlying
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1328) & 64) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1328); var newMask = value ? (currentMask | 64) : (currentMask & ~64); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1328); }
    }

    /// <summary>
    /// BoolProperty: bCameraPositionLocked
    /// </summary>
    public unsafe bool bCameraPositionLocked
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1328) & 128) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1328); var newMask = value ? (currentMask | 128) : (currentMask & ~128); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1328); }
    }

    /// <summary>
    /// BoolProperty: bShortConnectTimeOut
    /// </summary>
    public unsafe bool bShortConnectTimeOut
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1328) & 256) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1328); var newMask = value ? (currentMask | 256) : (currentMask & ~256); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1328); }
    }

    /// <summary>
    /// BoolProperty: bPendingDestroy
    /// </summary>
    public unsafe bool bPendingDestroy
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1328) & 512) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1328); var newMask = value ? (currentMask | 512) : (currentMask & ~512); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1328); }
    }

    /// <summary>
    /// BoolProperty: bWasSpeedHack
    /// </summary>
    public unsafe bool bWasSpeedHack
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1328) & 1024) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1328); var newMask = value ? (currentMask | 1024) : (currentMask & ~1024); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1328); }
    }

    /// <summary>
    /// BoolProperty: bWasSaturated
    /// </summary>
    public unsafe bool bWasSaturated
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1328) & 2048) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1328); var newMask = value ? (currentMask | 2048) : (currentMask & ~2048); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1328); }
    }

    /// <summary>
    /// BoolProperty: bAimingHelp
    /// </summary>
    public unsafe bool bAimingHelp
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1328) & 4096) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1328); var newMask = value ? (currentMask | 4096) : (currentMask & ~4096); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1328); }
    }

    /// <summary>
    /// BoolProperty: bCameraCut
    /// </summary>
    public unsafe bool bCameraCut
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1328) & 8192) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1328); var newMask = value ? (currentMask | 8192) : (currentMask & ~8192); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1328); }
    }

    /// <summary>
    /// BoolProperty: bClientSimulatingViewTarget
    /// </summary>
    public unsafe bool bClientSimulatingViewTarget
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1328) & 16384) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1328); var newMask = value ? (currentMask | 16384) : (currentMask & ~16384); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1328); }
    }

    /// <summary>
    /// BoolProperty: bHasVoiceHandshakeCompleted
    /// </summary>
    public unsafe bool bHasVoiceHandshakeCompleted
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1328) & 32768) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1328); var newMask = value ? (currentMask | 32768) : (currentMask & ~32768); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1328); }
    }

    /// <summary>
    /// BoolProperty: bCinematicMode
    /// </summary>
    public unsafe bool bCinematicMode
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1328) & 65536) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1328); var newMask = value ? (currentMask | 65536) : (currentMask & ~65536); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1328); }
    }

    /// <summary>
    /// BoolProperty: bCinematicLightingMode
    /// </summary>
    public unsafe bool bCinematicLightingMode
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1328) & 131072) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1328); var newMask = value ? (currentMask | 131072) : (currentMask & ~131072); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1328); }
    }

    /// <summary>
    /// BoolProperty: bInteractiveMode
    /// </summary>
    public unsafe bool bInteractiveMode
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1328) & 262144) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1328); var newMask = value ? (currentMask | 262144) : (currentMask & ~262144); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1328); }
    }

    /// <summary>
    /// BoolProperty: bCinemaDisableInputMove
    /// </summary>
    public unsafe bool bCinemaDisableInputMove
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1328) & 524288) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1328); var newMask = value ? (currentMask | 524288) : (currentMask & ~524288); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1328); }
    }

    /// <summary>
    /// BoolProperty: bCinemaDisableInputLook
    /// </summary>
    public unsafe bool bCinemaDisableInputLook
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1328) & 1048576) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1328); var newMask = value ? (currentMask | 1048576) : (currentMask & ~1048576); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1328); }
    }

    /// <summary>
    /// BoolProperty: bCinemaDisableInputButtons
    /// </summary>
    public unsafe bool bCinemaDisableInputButtons
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1328) & 2097152) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1328); var newMask = value ? (currentMask | 2097152) : (currentMask & ~2097152); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1328); }
    }

    /// <summary>
    /// BoolProperty: bRenderHUDFullScreen
    /// </summary>
    public unsafe bool bRenderHUDFullScreen
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1328) & 4194304) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1328); var newMask = value ? (currentMask | 4194304) : (currentMask & ~4194304); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1328); }
    }

    /// <summary>
    /// BoolProperty: bIgnoreNetworkMessages
    /// </summary>
    public unsafe bool bIgnoreNetworkMessages
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1328) & 8388608) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1328); var newMask = value ? (currentMask | 8388608) : (currentMask & ~8388608); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1328); }
    }

    /// <summary>
    /// BoolProperty: bShowKismetDrawText
    /// </summary>
    public unsafe bool bShowKismetDrawText
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1328) & 16777216) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1328); var newMask = value ? (currentMask | 16777216) : (currentMask & ~16777216); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1328); }
    }

    /// <summary>
    /// BoolProperty: bReplicateAllPawns
    /// </summary>
    public unsafe bool bReplicateAllPawns
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1328) & 33554432) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1328); var newMask = value ? (currentMask | 33554432) : (currentMask & ~33554432); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1328); }
    }

    /// <summary>
    /// BoolProperty: bIsUsingStreamingVolumes
    /// </summary>
    public unsafe bool bIsUsingStreamingVolumes
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1328) & 67108864) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1328); var newMask = value ? (currentMask | 67108864) : (currentMask & ~67108864); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1328); }
    }

    /// <summary>
    /// BoolProperty: bIsExternalUIOpen
    /// </summary>
    public unsafe bool bIsExternalUIOpen
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1328) & 134217728) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1328); var newMask = value ? (currentMask | 134217728) : (currentMask & ~134217728); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1328); }
    }

    /// <summary>
    /// BoolProperty: bIsControllerConnected
    /// </summary>
    public unsafe bool bIsControllerConnected
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1328) & 268435456) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1328); var newMask = value ? (currentMask | 268435456) : (currentMask & ~268435456); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1328); }
    }

    /// <summary>
    /// BoolProperty: bCheckSoundOcclusion
    /// </summary>
    public unsafe bool bCheckSoundOcclusion
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1328) & 536870912) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1328); var newMask = value ? (currentMask | 536870912) : (currentMask & ~536870912); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1328); }
    }

    /// <summary>
    /// BoolProperty: bDebugCameraAnims
    /// </summary>
    public unsafe bool bDebugCameraAnims
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1328) & 1073741824) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1328); var newMask = value ? (currentMask | 1073741824) : (currentMask & ~1073741824); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1328); }
    }

    /// <summary>
    /// BoolProperty: bBlockCameraAnimsFromOverridingPostProcess
    /// </summary>
    public unsafe bool bBlockCameraAnimsFromOverridingPostProcess
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1328) & -2147483648) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1328); var newMask = value ? (currentMask | -2147483648) : (currentMask & ~-2147483648); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1328); }
    }

    /// <summary>
    /// BoolProperty: bCheckRelevancyThroughPortals
    /// </summary>
    public unsafe bool bCheckRelevancyThroughPortals
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1332) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1332); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1332); }
    }

    /// <summary>
    /// BoolProperty: bControllerWasDisconnected
    /// </summary>
    public unsafe bool bControllerWasDisconnected
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1332) & 2) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1332); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1332); }
    }

    /// <summary>
    /// BoolProperty: bDidLoseFocusDeferPause
    /// </summary>
    public unsafe bool bDidLoseFocusDeferPause
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1332) & 4) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1332); var newMask = value ? (currentMask | 4) : (currentMask & ~4); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1332); }
    }

    /// <summary>
    /// BoolProperty: bDebugClientAdjustPosition
    /// </summary>
    public unsafe bool bDebugClientAdjustPosition
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1332) & 8) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1332); var newMask = value ? (currentMask | 8) : (currentMask & ~8); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1332); }
    }

    /// <summary>
    /// FloatProperty: MaxResponseTime
    /// </summary>
    public unsafe float MaxResponseTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1336); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1336); }
    }

    /// <summary>
    /// FloatProperty: WaitDelay
    /// </summary>
    public unsafe float WaitDelay
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1340); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1340); }
    }

    /// <summary>
    /// ByteProperty: DoubleClickDir
    /// </summary>
    public unsafe BmSDK.Engine.Actor.EDoubleClickDir DoubleClickDir
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.Actor.EDoubleClickDir>(Ptr + 1344); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1344); }
    }

    /// <summary>
    /// ByteProperty: bIgnoreMoveInput
    /// </summary>
    public unsafe byte bIgnoreMoveInput
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 1345); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1345); }
    }

    /// <summary>
    /// ByteProperty: bIgnoreLookInput
    /// </summary>
    public unsafe byte bIgnoreLookInput
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 1346); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1346); }
    }

    /// <summary>
    /// ByteProperty: bIgnoreButtonInput
    /// </summary>
    public unsafe byte bIgnoreButtonInput
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 1347); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1347); }
    }

    /// <summary>
    /// ByteProperty: bRun
    /// </summary>
    public unsafe byte bRun
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 1348); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1348); }
    }

    /// <summary>
    /// ByteProperty: bDuck
    /// </summary>
    public unsafe byte bDuck
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 1349); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1349); }
    }

    /// <summary>
    /// ByteProperty: NetPlayerIndex
    /// </summary>
    public unsafe byte NetPlayerIndex
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 1350); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1350); }
    }

    /// <summary>
    /// FloatProperty: FOVAngle
    /// </summary>
    public unsafe float FOVAngle
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1352); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1352); }
    }

    /// <summary>
    /// FloatProperty: DesiredFOV
    /// </summary>
    public unsafe float DesiredFOV
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1356); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1356); }
    }

    /// <summary>
    /// FloatProperty: DefaultFOV
    /// </summary>
    public unsafe float DefaultFOV
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1360); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1360); }
    }

    /// <summary>
    /// FloatProperty: LODDistanceFactor
    /// </summary>
    public unsafe float LODDistanceFactor
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1364); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1364); }
    }

    /// <summary>
    /// StructProperty: TargetViewRotation
    /// </summary>
    public unsafe BmSDK.Rotator TargetViewRotation
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Rotator>(Ptr + 1368); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1368); }
    }

    /// <summary>
    /// FloatProperty: TargetEyeHeight
    /// </summary>
    public unsafe float TargetEyeHeight
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1380); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1380); }
    }

    /// <summary>
    /// StructProperty: BlendedTargetViewRotation
    /// </summary>
    public unsafe BmSDK.Rotator BlendedTargetViewRotation
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Rotator>(Ptr + 1384); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1384); }
    }

    /// <summary>
    /// StructProperty: LastAckedAccel
    /// </summary>
    public unsafe System.Numerics.Vector3 LastAckedAccel
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 1396); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1396); }
    }

    /// <summary>
    /// FloatProperty: CurrentTimeStamp
    /// </summary>
    public unsafe float CurrentTimeStamp
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1408); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1408); }
    }

    /// <summary>
    /// FloatProperty: LastUpdateTime
    /// </summary>
    public unsafe float LastUpdateTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1412); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1412); }
    }

    /// <summary>
    /// FloatProperty: ServerTimeStamp
    /// </summary>
    public unsafe float ServerTimeStamp
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1416); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1416); }
    }

    /// <summary>
    /// FloatProperty: TimeMargin
    /// </summary>
    public unsafe float TimeMargin
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1420); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1420); }
    }

    /// <summary>
    /// FloatProperty: ClientUpdateTime
    /// </summary>
    public unsafe float ClientUpdateTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1424); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1424); }
    }

    /// <summary>
    /// FloatProperty: MaxTimeMargin
    /// </summary>
    public unsafe float MaxTimeMargin
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1428); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1428); }
    }

    /// <summary>
    /// FloatProperty: LastActiveTime
    /// </summary>
    public unsafe float LastActiveTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1432); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1432); }
    }

    /// <summary>
    /// IntProperty: ClientCap
    /// </summary>
    public unsafe int ClientCap
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1436); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1436); }
    }

    /// <summary>
    /// FloatProperty: DynamicPingThreshold
    /// </summary>
    public unsafe float DynamicPingThreshold
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1440); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1440); }
    }

    /// <summary>
    /// FloatProperty: LastPingUpdate
    /// </summary>
    public unsafe float LastPingUpdate
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1444); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1444); }
    }

    /// <summary>
    /// FloatProperty: LastSpeedHackLog
    /// </summary>
    public unsafe float LastSpeedHackLog
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1448); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1448); }
    }

    /// <summary>
    /// StructProperty: PendingAdjustment
    /// </summary>
    public unsafe BmSDK.Engine.PlayerController.FClientAdjustment PendingAdjustment
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.PlayerController.FClientAdjustment>(Ptr + 1452); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1452); }
    }

    /// <summary>
    /// IntProperty: GroundPitch
    /// </summary>
    public unsafe int GroundPitch
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1508); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1508); }
    }

    /// <summary>
    /// StructProperty: FailedPathStart
    /// </summary>
    public unsafe System.Numerics.Vector3 FailedPathStart
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 1512); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1512); }
    }

    /// <summary>
    /// StrProperty: ForceFeedbackManagerClassName
    /// </summary>
    public unsafe BmSDK.FString ForceFeedbackManagerClassName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 1524); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1524); }
    }

    /// <summary>
    /// ArrayProperty: Interactions
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.Engine.Interaction> Interactions
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.Interaction>>(Ptr + 1540); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1540); }
    }

    /// <summary>
    /// ArrayProperty: VoiceMuteList
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.Engine.OnlineSubsystem.FUniqueNetId> VoiceMuteList
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.OnlineSubsystem.FUniqueNetId>>(Ptr + 1556); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1556); }
    }

    /// <summary>
    /// ArrayProperty: GameplayVoiceMuteList
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.Engine.OnlineSubsystem.FUniqueNetId> GameplayVoiceMuteList
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.OnlineSubsystem.FUniqueNetId>>(Ptr + 1572); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1572); }
    }

    /// <summary>
    /// ArrayProperty: VoicePacketFilter
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.Engine.OnlineSubsystem.FUniqueNetId> VoicePacketFilter
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.OnlineSubsystem.FUniqueNetId>>(Ptr + 1588); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1588); }
    }

    /// <summary>
    /// ArrayProperty: ConnectedPeers
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.Engine.PlayerController.FConnectedPeerInfo> ConnectedPeers
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.PlayerController.FConnectedPeerInfo>>(Ptr + 1604); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1604); }
    }

    /// <summary>
    /// ArrayProperty: BestNextHostPeers
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.Engine.OnlineSubsystem.FUniqueNetId> BestNextHostPeers
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.OnlineSubsystem.FUniqueNetId>>(Ptr + 1620); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1620); }
    }

    /// <summary>
    /// InterfaceProperty: VoiceInterface
    /// </summary>
    public unsafe BmSDK.Engine.OnlineVoiceInterface VoiceInterface
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.OnlineVoiceInterface>(Ptr + 1636); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1636); }
    }

    /// <summary>
    /// FloatProperty: InteractDistance
    /// </summary>
    public unsafe float InteractDistance
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1652); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1652); }
    }

    /// <summary>
    /// NameProperty: DelayedJoinSessionName
    /// </summary>
    public unsafe BmSDK.FName DelayedJoinSessionName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 1656); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1656); }
    }

    /// <summary>
    /// ArrayProperty: InputRequests
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.Engine.PlayerController.FInputMatchRequest> InputRequests
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.PlayerController.FInputMatchRequest>>(Ptr + 1664); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1664); }
    }

    /// <summary>
    /// FloatProperty: LastBroadcastTime
    /// </summary>
    public unsafe float LastBroadcastTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1680); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1680); }
    }

    /// <summary>
    /// StrProperty: LastBroadcastString
    /// </summary>
    public unsafe BmSDK.FString LastBroadcastString_0
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 1684); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1684); }
    }
    /// <summary>
    /// StrProperty: LastBroadcastString
    /// </summary>
    public unsafe BmSDK.FString LastBroadcastString_1
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 1700); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1700); }
    }
    /// <summary>
    /// StrProperty: LastBroadcastString
    /// </summary>
    public unsafe BmSDK.FString LastBroadcastString_2
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 1716); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1716); }
    }
    /// <summary>
    /// StrProperty: LastBroadcastString
    /// </summary>
    public unsafe BmSDK.FString LastBroadcastString_3
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 1732); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1732); }
    }

    /// <summary>
    /// ArrayProperty: PendingMapChangeLevelNames
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.FName> PendingMapChangeLevelNames
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.FName>>(Ptr + 1748); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1748); }
    }

    /// <summary>
    /// ArrayProperty: DebugTextList
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.Engine.PlayerController.FDebugTextInfo> DebugTextList
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.PlayerController.FDebugTextInfo>>(Ptr + 1764); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1764); }
    }

    /// <summary>
    /// FloatProperty: SpectatorCameraSpeed
    /// </summary>
    public unsafe float SpectatorCameraSpeed
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1780); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1780); }
    }

    /// <summary>
    /// FloatProperty: MinRespawnDelay
    /// </summary>
    public unsafe float MinRespawnDelay
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1784); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1784); }
    }

    /// <summary>
    /// ArrayProperty: HiddenActors
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.Engine.Actor> HiddenActors
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.Actor>>(Ptr + 1788); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1788); }
    }

    /// <summary>
    /// FloatProperty: LastSpectatorStateSynchTime
    /// </summary>
    public unsafe float LastSpectatorStateSynchTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1804); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1804); }
    }

    /// <summary>
    /// FloatProperty: mCaseFileCameraBlendTime
    /// </summary>
    public unsafe float mCaseFileCameraBlendTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1808); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1808); }
    }

    /// <summary>
    /// DelegateProperty: __CanUnpause__Delegate
    /// </summary>
    public unsafe System.IntPtr __CanUnpause__Delegate
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.IntPtr>(Ptr + 1812); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1812); }
    }

    /// <summary>
    /// DelegateProperty: __InputMatchDelegate__Delegate
    /// </summary>
    public unsafe System.IntPtr __InputMatchDelegate__Delegate
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.IntPtr>(Ptr + 1828); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1828); }
    }
}
