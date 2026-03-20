#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmScript;

/// <summary>
/// Class: RSpecialMoveInstance_CwClawClimbWallLand<br/>
/// (size = 1200)
/// (flags = 10485778)
/// </summary>
public partial class RSpecialMoveInstance_CwClawClimbWallLand : BmSDK.BmGame.RSpecialMoveInstance_RelativeAnimMove, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmScript.RSpecialMoveInstance_CwClawClimbWallLand", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RSpecialMoveInstance_CwClawClimbWallLand() { }

    /// <summary>
    /// Constructs a new RSpecialMoveInstance_CwClawClimbWallLand
    /// </summary>
    public RSpecialMoveInstance_CwClawClimbWallLand(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RSpecialMoveInstance_CwClawClimbWallLand Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RSpecialMoveInstance_CwClawClimbWallLand(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="Engine.Actor.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RSpecialMoveInstance_CwClawClimbWallLand>
        => ((Engine.Actor)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="Engine.Actor.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RSpecialMoveInstance_CwClawClimbWallLand>, new()
        => (TComponent)((Engine.Actor)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="Engine.Actor.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RSpecialMoveInstance_CwClawClimbWallLand>
        => ((Engine.Actor)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="Engine.Actor.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RSpecialMoveInstance_CwClawClimbWallLand>
        => ((Engine.Actor)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="Engine.Actor.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RSpecialMoveInstance_CwClawClimbWallLand>
        => (TComponent)((Engine.Actor)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="Engine.Actor.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RSpecialMoveInstance_CwClawClimbWallLand>
        => ((Engine.Actor)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="Engine.Actor.DetachScriptComponent(Type)"/>
    public void DetachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RSpecialMoveInstance_CwClawClimbWallLand>
        => ((Engine.Actor)this).DetachScriptComponent(typeof(TComponent));

    /// <summary>
    /// Function: GetHelpPrompt
    /// </summary>
    public unsafe void GetHelpPrompt(BmSDK.BmGame.RHUDPrompt HelpPrompt, bool bKismetHelpOn)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RSpecialMoveInstance_CwClawClimbWallLand.GetHelpPrompt", true);
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(HelpPrompt, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bKismetHelpOn, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: DrawHUD
    /// </summary>
    public unsafe void DrawHUD(BmSDK.Engine.HUD H)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RSpecialMoveInstance_CwClawClimbWallLand.DrawHUD", true);
        byte* paramsPtr = stackalloc byte[24];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(H, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: FinishSpecialMove
    /// </summary>
    public unsafe void FinishSpecialMove()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RSpecialMoveInstance_CwClawClimbWallLand.FinishSpecialMove", true);
        byte* paramsPtr = stackalloc byte[428];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: CancelSpecialMove
    /// </summary>
    public unsafe void CancelSpecialMove(BmSDK.BmGame.RSpecialMoveConfig CancellingMove)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RSpecialMoveInstance_CwClawClimbWallLand.CancelSpecialMove", true);
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CancellingMove, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: CancelMove
    /// </summary>
    public unsafe void CancelMove()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RSpecialMoveInstance_CwClawClimbWallLand.CancelMove", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: UpdateSpecialMove
    /// </summary>
    public unsafe bool UpdateSpecialMove(float DeltaTime)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RSpecialMoveInstance_CwClawClimbWallLand.UpdateSpecialMove", true);
        byte* paramsPtr = stackalloc byte[448];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DeltaTime, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 4);
    }

    /// <summary>
    /// Function: IsGrapplePressed
    /// </summary>
    public unsafe bool IsGrapplePressed()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RSpecialMoveInstance_CwClawClimbWallLand.IsGrapplePressed", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: CanPounceAgain
    /// </summary>
    public unsafe bool CanPounceAgain()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RSpecialMoveInstance_CwClawClimbWallLand.CanPounceAgain", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: NextPounceTimer
    /// </summary>
    public unsafe void NextPounceTimer()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RSpecialMoveInstance_CwClawClimbWallLand.NextPounceTimer", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: SetPounceTimer
    /// </summary>
    public unsafe void SetPounceTimer()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RSpecialMoveInstance_CwClawClimbWallLand.SetPounceTimer", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: PerfectTiming
    /// </summary>
    public unsafe void PerfectTiming()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RSpecialMoveInstance_CwClawClimbWallLand.PerfectTiming", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: CanLaunchFromHere
    /// </summary>
    public unsafe void CanLaunchFromHere()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RSpecialMoveInstance_CwClawClimbWallLand.CanLaunchFromHere", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: StartAutoClimb
    /// </summary>
    public unsafe void StartAutoClimb()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RSpecialMoveInstance_CwClawClimbWallLand.StartAutoClimb", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: ButtonMashPenalty
    /// </summary>
    public unsafe void ButtonMashPenalty()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RSpecialMoveInstance_CwClawClimbWallLand.ButtonMashPenalty", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: ShowFeedbackMessage
    /// </summary>
    public unsafe void ShowFeedbackMessage(BmSDK.FString Feedback)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RSpecialMoveInstance_CwClawClimbWallLand.ShowFeedbackMessage", true);
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Feedback, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: HandleAction
    /// </summary>
    public unsafe void HandleAction(BmSDK.FName actionName)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RSpecialMoveInstance_CwClawClimbWallLand.HandleAction", true);
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(actionName, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: WallIdleTimeout
    /// </summary>
    public unsafe void WallIdleTimeout()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RSpecialMoveInstance_CwClawClimbWallLand.WallIdleTimeout", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: LookAtNextPoint
    /// </summary>
    public unsafe void LookAtNextPoint()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RSpecialMoveInstance_CwClawClimbWallLand.LookAtNextPoint", true);
        byte* paramsPtr = stackalloc byte[608];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: TriggerLandCamUp
    /// </summary>
    public unsafe void TriggerLandCamUp()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RSpecialMoveInstance_CwClawClimbWallLand.TriggerLandCamUp", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: TriggerLandCamRight
    /// </summary>
    public unsafe void TriggerLandCamRight()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RSpecialMoveInstance_CwClawClimbWallLand.TriggerLandCamRight", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: TriggerLandCamLeft
    /// </summary>
    public unsafe void TriggerLandCamLeft()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RSpecialMoveInstance_CwClawClimbWallLand.TriggerLandCamLeft", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: TriggerLandCam
    /// </summary>
    public unsafe void TriggerLandCam()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RSpecialMoveInstance_CwClawClimbWallLand.TriggerLandCam", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: CantHoldOnToWallAnymore
    /// </summary>
    public unsafe void CantHoldOnToWallAnymore()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RSpecialMoveInstance_CwClawClimbWallLand.CantHoldOnToWallAnymore", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: TriggerSpecialMove
    /// </summary>
    public unsafe void TriggerSpecialMove(BmSDK.BmGame.REnvironmentCheckTicker.FEnvironmentSpecialMoveLocator MoveLocation)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RSpecialMoveInstance_CwClawClimbWallLand.TriggerSpecialMove", true);
        byte* paramsPtr = stackalloc byte[532];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(MoveLocation, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Enum: LaunchLandDir
    /// </summary>
    public enum LaunchLandDir
    {
        LD_Up = 0,
        LD_Left = 1,
        LD_Right = 2,
        LD_MAX = 3,
    }

    /// <summary>
    /// IntProperty: Phase
    /// </summary>
    public unsafe int Phase
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 988); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 988); }
    }

    /// <summary>
    /// StructProperty: LandLocator
    /// </summary>
    public unsafe BmSDK.BmGame.REnvironmentCheckTicker.FEnvironmentSpecialMoveLocator LandLocator
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.REnvironmentCheckTicker.FEnvironmentSpecialMoveLocator>(Ptr + 992); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 992); }
    }

    /// <summary>
    /// FloatProperty: MaxWallIdleTime
    /// </summary>
    public unsafe float MaxWallIdleTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1124); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1124); }
    }

    /// <summary>
    /// StructProperty: CurrentLocation
    /// </summary>
    public unsafe System.Numerics.Vector3 CurrentLocation
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 1128); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1128); }
    }

    /// <summary>
    /// BoolProperty: bCancelPressed
    /// </summary>
    public unsafe bool bCancelPressed
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1140) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1140); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1140); }
    }

    /// <summary>
    /// BoolProperty: bCanLaunchAlready
    /// </summary>
    public unsafe bool bCanLaunchAlready
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1140) & 2) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1140); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1140); }
    }

    /// <summary>
    /// BoolProperty: bLaunchFromWallStick
    /// </summary>
    public unsafe bool bLaunchFromWallStick
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1140) & 4) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1140); var newMask = value ? (currentMask | 4) : (currentMask & ~4); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1140); }
    }

    /// <summary>
    /// BoolProperty: bAutoPounceToTarget
    /// </summary>
    public unsafe bool bAutoPounceToTarget
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1140) & 8) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1140); var newMask = value ? (currentMask | 8) : (currentMask & ~8); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1140); }
    }

    /// <summary>
    /// BoolProperty: bJumpOffPressed
    /// </summary>
    public unsafe bool bJumpOffPressed
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1140) & 16) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1140); var newMask = value ? (currentMask | 16) : (currentMask & ~16); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1140); }
    }

    /// <summary>
    /// BoolProperty: bGrapplePressed
    /// </summary>
    public unsafe bool bGrapplePressed
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1140) & 32) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1140); var newMask = value ? (currentMask | 32) : (currentMask & ~32); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1140); }
    }

    /// <summary>
    /// BoolProperty: bManuallyTriggeredFromWallStick
    /// </summary>
    public unsafe bool bManuallyTriggeredFromWallStick
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1140) & 64) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1140); var newMask = value ? (currentMask | 64) : (currentMask & ~64); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1140); }
    }

    /// <summary>
    /// BoolProperty: bLaunchLeft
    /// </summary>
    public unsafe bool bLaunchLeft
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1140) & 128) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1140); var newMask = value ? (currentMask | 128) : (currentMask & ~128); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1140); }
    }

    /// <summary>
    /// BoolProperty: bLandLeft
    /// </summary>
    public unsafe bool bLandLeft
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1140) & 256) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1140); var newMask = value ? (currentMask | 256) : (currentMask & ~256); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1140); }
    }

    /// <summary>
    /// BoolProperty: bNextClimbStep
    /// </summary>
    public unsafe bool bNextClimbStep
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1140) & 512) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1140); var newMask = value ? (currentMask | 512) : (currentMask & ~512); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1140); }
    }

    /// <summary>
    /// BoolProperty: bFinalClimbStep
    /// </summary>
    public unsafe bool bFinalClimbStep
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1140) & 1024) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1140); var newMask = value ? (currentMask | 1024) : (currentMask & ~1024); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1140); }
    }

    /// <summary>
    /// BoolProperty: bPlayLaunch
    /// </summary>
    public unsafe bool bPlayLaunch
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1140) & 2048) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1140); var newMask = value ? (currentMask | 2048) : (currentMask & ~2048); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1140); }
    }

    /// <summary>
    /// BoolProperty: bUseMidAirAnim
    /// </summary>
    public unsafe bool bUseMidAirAnim
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1140) & 4096) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1140); var newMask = value ? (currentMask | 4096) : (currentMask & ~4096); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1140); }
    }

    /// <summary>
    /// FloatProperty: AutoPounceDelay
    /// </summary>
    public unsafe float AutoPounceDelay
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1144); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1144); }
    }

    /// <summary>
    /// FloatProperty: AutoPounceExtraRandomDelay
    /// </summary>
    public unsafe float AutoPounceExtraRandomDelay
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1148); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1148); }
    }

    /// <summary>
    /// FloatProperty: WallJumpOffSpeed
    /// </summary>
    public unsafe float WallJumpOffSpeed
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1152); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1152); }
    }

    /// <summary>
    /// FloatProperty: WallJumpOffAngle
    /// </summary>
    public unsafe float WallJumpOffAngle
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1156); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1156); }
    }

    /// <summary>
    /// ObjectProperty: MyConfig
    /// </summary>
    public unsafe BmSDK.BmScript.RSpecialMoveConfig_CwClawClimbWallLand MyConfig
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmScript.RSpecialMoveConfig_CwClawClimbWallLand>(Ptr + 1160); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1160); }
    }

    /// <summary>
    /// ObjectProperty: GrappleGun
    /// </summary>
    public unsafe BmSDK.BmScript.RCwGrappleGun GrappleGun
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmScript.RCwGrappleGun>(Ptr + 1168); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1168); }
    }

    /// <summary>
    /// ByteProperty: FeatureType
    /// </summary>
    public unsafe BmSDK.BmGame.REnvironmentCheckTicker.EnvironmentSpecialMoveTypes FeatureType
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.REnvironmentCheckTicker.EnvironmentSpecialMoveTypes>(Ptr + 1176); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1176); }
    }

    /// <summary>
    /// ByteProperty: LandDir
    /// </summary>
    public unsafe BmSDK.BmScript.RSpecialMoveInstance_CwClawClimbWallLand.LaunchLandDir LandDir
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmScript.RSpecialMoveInstance_CwClawClimbWallLand.LaunchLandDir>(Ptr + 1177); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1177); }
    }

    /// <summary>
    /// ByteProperty: LaunchDir
    /// </summary>
    public unsafe BmSDK.BmScript.RSpecialMoveInstance_CwClawClimbWallLand.LaunchLandDir LaunchDir
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmScript.RSpecialMoveInstance_CwClawClimbWallLand.LaunchLandDir>(Ptr + 1178); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1178); }
    }

    /// <summary>
    /// FloatProperty: LaunchTan
    /// </summary>
    public unsafe float LaunchTan
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1180); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1180); }
    }

    /// <summary>
    /// FloatProperty: LandTan
    /// </summary>
    public unsafe float LandTan
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1184); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1184); }
    }

    /// <summary>
    /// FloatProperty: TanUp
    /// </summary>
    public unsafe float TanUp
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1188); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1188); }
    }

    /// <summary>
    /// FloatProperty: TanSteepLR
    /// </summary>
    public unsafe float TanSteepLR
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1192); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1192); }
    }

    /// <summary>
    /// FloatProperty: ButtonMashPenaltyTime
    /// </summary>
    public unsafe float ButtonMashPenaltyTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1196); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1196); }
    }
}
