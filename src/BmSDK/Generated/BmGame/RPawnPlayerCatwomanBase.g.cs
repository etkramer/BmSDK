#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// ABSTRACT Class: RPawnPlayerCatwomanBase<br/>
/// (size = 10340)
/// (flags = 144703671)
/// </summary>
public partial class RPawnPlayerCatwomanBase : BmSDK.BmGame.RPawnPlayer, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RPawnPlayerCatwomanBase", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RPawnPlayerCatwomanBase() { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RPawnPlayerCatwomanBase(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="Engine.Actor.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RPawnPlayerCatwomanBase>
        => ((Engine.Actor)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="Engine.Actor.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RPawnPlayerCatwomanBase>, new()
        => (TComponent)((Engine.Actor)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="Engine.Actor.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RPawnPlayerCatwomanBase>
        => ((Engine.Actor)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="Engine.Actor.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RPawnPlayerCatwomanBase>
        => ((Engine.Actor)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="Engine.Actor.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RPawnPlayerCatwomanBase>
        => (TComponent)((Engine.Actor)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="Engine.Actor.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RPawnPlayerCatwomanBase>
        => ((Engine.Actor)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="Engine.Actor.DetachScriptComponent(Type)"/>
    public void DetachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RPawnPlayerCatwomanBase>
        => ((Engine.Actor)this).DetachScriptComponent(typeof(TComponent));

    /// <summary>
    /// Function: GetCornerCoverIdleOverlayAnimset
    /// </summary>
    public unsafe virtual BmSDK.Engine.AnimSet GetCornerCoverIdleOverlayAnimset()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPawnPlayerCatwomanBase.GetCornerCoverIdleOverlayAnimset", true);
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AnimSet>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: CheckRiddleScanVisibility
    /// </summary>
    public unsafe override bool CheckRiddleScanVisibility(BmSDK.GameObject.FTPOV CameraPOV, out BmSDK.BmGame.RGameInfo.FVisibilityResult ReasonItFailed)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPawnPlayerCatwomanBase.CheckRiddleScanVisibility", true);
        byte* paramsPtr = stackalloc byte[136];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CameraPOV, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        ReasonItFailed = BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RGameInfo.FVisibilityResult>(paramsPtr + 28);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 48);
    }

    /// <summary>
    /// Function: RiddleFound
    /// </summary>
    public unsafe virtual void RiddleFound(BmSDK.BmGame.RPlayerController PC)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPawnPlayerCatwomanBase.RiddleFound", true);
        byte* paramsPtr = stackalloc byte[24];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PC, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: GetRiddle
    /// </summary>
    public unsafe virtual BmSDK.FString GetRiddle()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPawnPlayerCatwomanBase.GetRiddle", true);
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: RiddleReScanned
    /// </summary>
    public unsafe virtual void RiddleReScanned(BmSDK.BmGame.RPlayerController PC)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPawnPlayerCatwomanBase.RiddleReScanned", true);
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PC, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: TakePhoto
    /// </summary>
    public unsafe override void TakePhoto(BmSDK.BmGame.RPlayerController PC)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPawnPlayerCatwomanBase.TakePhoto", true);
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PC, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: ReleaseWall
    /// </summary>
    public unsafe virtual void ReleaseWall()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPawnPlayerCatwomanBase.ReleaseWall", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: ClimbOnWall
    /// </summary>
    public unsafe virtual void ClimbOnWall()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPawnPlayerCatwomanBase.ClimbOnWall", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: DisplayCatwomanWhipRappelPromptIfNecessary
    /// </summary>
    public unsafe virtual void DisplayCatwomanWhipRappelPromptIfNecessary(BmSDK.BmGame.RHUDPrompt HelpPrompt, bool bDisplayPromptInCentreOfScreen)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPawnPlayerCatwomanBase.DisplayCatwomanWhipRappelPromptIfNecessary", true);
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(HelpPrompt, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bDisplayPromptInCentreOfScreen, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: IsCatwomanTouchingAWallClimbVolume
    /// </summary>
    public unsafe virtual bool IsCatwomanTouchingAWallClimbVolume()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPawnPlayerCatwomanBase.IsCatwomanTouchingAWallClimbVolume", true);
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: CanJumpOffWallStick
    /// </summary>
    public unsafe virtual bool CanJumpOffWallStick(BmSDK.BmGame.RSpecialMoveConfig Config, BmSDK.BmGame.REnvironmentCheckTicker.FEnvironmentSpecialMoveLocator Loc)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPawnPlayerCatwomanBase.CanJumpOffWallStick", true);
        byte* paramsPtr = stackalloc byte[144];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Config, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Loc, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 140);
    }

    /// <summary>
    /// Function: FlushDebugDraws
    /// </summary>
    public unsafe virtual void FlushDebugDraws(bool bOnlyOncePerFrame = default)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPawnPlayerCatwomanBase.FlushDebugDraws", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bOnlyOncePerFrame, paramsPtr + 0);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return;
    }

    /// <summary>
    /// Function: OnHelicopterHit
    /// </summary>
    public unsafe virtual void OnHelicopterHit(BmSDK.BmGame.RHelicopterBase Heli, System.Numerics.Vector3 HitLocation, System.Numerics.Vector3 HitNormal)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPawnPlayerCatwomanBase.OnHelicopterHit", true);
        byte* paramsPtr = stackalloc byte[32];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Heli, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(HitLocation, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(HitNormal, paramsPtr + 20);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: ClampPointToCeilingVolumes
    /// </summary>
    public unsafe virtual bool ClampPointToCeilingVolumes(out System.Numerics.Vector3 Point, float ExtraShiftInwards = default, bool bDebugDraw = default)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPawnPlayerCatwomanBase.ClampPointToCeilingVolumes", true);
        byte* paramsPtr = stackalloc byte[24];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ExtraShiftInwards, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bDebugDraw, paramsPtr + 16);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        Point = BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(paramsPtr + 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 20);
    }

    /// <summary>
    /// Function: UpdateTouchingCeilingVolume
    /// </summary>
    public unsafe virtual void UpdateTouchingCeilingVolume()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPawnPlayerCatwomanBase.UpdateTouchingCeilingVolume", true);
        byte* paramsPtr = stackalloc byte[0];
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return;
    }

    /// <summary>
    /// Function: ButtonMashPenalty
    /// </summary>
    public unsafe virtual void ButtonMashPenalty()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPawnPlayerCatwomanBase.ButtonMashPenalty", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: ResetAutoSwing
    /// </summary>
    public unsafe virtual void ResetAutoSwing()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPawnPlayerCatwomanBase.ResetAutoSwing", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: TriggerAerialWhipPounce
    /// </summary>
    public unsafe virtual bool TriggerAerialWhipPounce()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPawnPlayerCatwomanBase.TriggerAerialWhipPounce", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: GetEdgeSwingGrappleLocation
    /// </summary>
    public unsafe virtual System.Numerics.Vector3 GetEdgeSwingGrappleLocation()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPawnPlayerCatwomanBase.GetEdgeSwingGrappleLocation", true);
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: GetEdgeSwingWallLocation
    /// </summary>
    public unsafe virtual System.Numerics.Vector3 GetEdgeSwingWallLocation(out System.Numerics.Vector3 WallNormal)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPawnPlayerCatwomanBase.GetEdgeSwingWallLocation", true);
        byte* paramsPtr = stackalloc byte[24];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        WallNormal = BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(paramsPtr + 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(paramsPtr + 12);
    }

    /// <summary>
    /// Function: GetEdgeSwingStartLocation
    /// </summary>
    public unsafe virtual System.Numerics.Vector3 GetEdgeSwingStartLocation()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPawnPlayerCatwomanBase.GetEdgeSwingStartLocation", true);
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: IsAutoSwingToGargoyle
    /// </summary>
    public unsafe virtual bool IsAutoSwingToGargoyle()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPawnPlayerCatwomanBase.IsAutoSwingToGargoyle", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: IsAutoSwing
    /// </summary>
    public unsafe virtual bool IsAutoSwing()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPawnPlayerCatwomanBase.IsAutoSwing", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: IsConcealedDuringSwing
    /// </summary>
    public unsafe virtual bool IsConcealedDuringSwing()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPawnPlayerCatwomanBase.IsConcealedDuringSwing", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: SetAutoSwingState
    /// </summary>
    public unsafe virtual void SetAutoSwingState(BmSDK.BmGame.RPawnPlayerCatwomanBase.EAutoSwingState State)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPawnPlayerCatwomanBase.SetAutoSwingState", true);
        byte* paramsPtr = stackalloc byte[1];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(State, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: IsValidClimbStartPoint
    /// </summary>
    public unsafe virtual bool IsValidClimbStartPoint()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPawnPlayerCatwomanBase.IsValidClimbStartPoint", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: GetFirstClimbPoint
    /// </summary>
    public unsafe virtual void GetFirstClimbPoint(out System.Numerics.Vector3 Position, out System.Numerics.Vector3 Normal)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPawnPlayerCatwomanBase.GetFirstClimbPoint", true);
        byte* paramsPtr = stackalloc byte[24];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        Position = BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(paramsPtr + 0);
        Normal = BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(paramsPtr + 12);
        return;
    }

    /// <summary>
    /// Function: RecalculatePath
    /// </summary>
    public unsafe virtual void RecalculatePath()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPawnPlayerCatwomanBase.RecalculatePath", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: HasPath
    /// </summary>
    public unsafe virtual bool HasPath()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPawnPlayerCatwomanBase.HasPath", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: ClearPath
    /// </summary>
    public unsafe virtual void ClearPath()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPawnPlayerCatwomanBase.ClearPath", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: SetAllowAerialWhipPounce
    /// </summary>
    public unsafe virtual void SetAllowAerialWhipPounce(bool bAllow)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPawnPlayerCatwomanBase.SetAllowAerialWhipPounce", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bAllow, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: TriggerHitAndDropFromCeilingMove
    /// </summary>
    public unsafe virtual void TriggerHitAndDropFromCeilingMove()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPawnPlayerCatwomanBase.TriggerHitAndDropFromCeilingMove", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: SetWhipTargetPose
    /// </summary>
    public unsafe virtual void SetWhipTargetPose(System.Numerics.Vector3 NewPosition, BmSDK.Rotator NewRotation = default)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPawnPlayerCatwomanBase.SetWhipTargetPose", true);
        byte* paramsPtr = stackalloc byte[24];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewPosition, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewRotation, paramsPtr + 12);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return;
    }

    /// <summary>
    /// Function: GetWhipTargetPose
    /// </summary>
    public unsafe virtual void GetWhipTargetPose(out System.Numerics.Vector3 OutPosition, out BmSDK.Rotator OutRotation)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPawnPlayerCatwomanBase.GetWhipTargetPose", true);
        byte* paramsPtr = stackalloc byte[24];
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        OutPosition = BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(paramsPtr + 0);
        OutRotation = BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Rotator>(paramsPtr + 12);
        return;
    }

    /// <summary>
    /// Function: FindNearbyLedgeFromCeiling
    /// </summary>
    public unsafe virtual bool FindNearbyLedgeFromCeiling(System.Numerics.Vector3 PlayerLocation, out BmSDK.BmGame.REnvironmentCheckTicker.FEnvironmentSpecialMoveLocator Locator)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPawnPlayerCatwomanBase.FindNearbyLedgeFromCeiling", true);
        byte* paramsPtr = stackalloc byte[148];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PlayerLocation, paramsPtr + 0);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        Locator = BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.REnvironmentCheckTicker.FEnvironmentSpecialMoveLocator>(paramsPtr + 12);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 144);
    }

    /// <summary>
    /// Function: AddEdgeCollisionNormals
    /// </summary>
    public unsafe virtual void AddEdgeCollisionNormals(System.Numerics.Vector3 Delta)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPawnPlayerCatwomanBase.AddEdgeCollisionNormals", true);
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Delta, paramsPtr + 0);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return;
    }

    /// <summary>
    /// Function: SlideOffCeilingVolumeBorders
    /// </summary>
    public unsafe virtual System.Numerics.Vector3 SlideOffCeilingVolumeBorders(System.Numerics.Vector3 Delta)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPawnPlayerCatwomanBase.SlideOffCeilingVolumeBorders", true);
        byte* paramsPtr = stackalloc byte[24];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Delta, paramsPtr + 0);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(paramsPtr + 12);
    }

    /// <summary>
    /// Function: RestrictMoveToCeiling
    /// </summary>
    public unsafe virtual System.Numerics.Vector3 RestrictMoveToCeiling(System.Numerics.Vector3 Delta)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPawnPlayerCatwomanBase.RestrictMoveToCeiling", true);
        byte* paramsPtr = stackalloc byte[24];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Delta, paramsPtr + 0);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(paramsPtr + 12);
    }

    /// <summary>
    /// Function: GetPlayerThoughts
    /// </summary>
    public unsafe override void GetPlayerThoughts(out BmSDK.TArray<BmSDK.Engine.Actor.FThought> ThoughtList)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPawnPlayerCatwomanBase.GetPlayerThoughts", true);
        byte* paramsPtr = stackalloc byte[16];
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        ThoughtList = BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.Actor.FThought>>(paramsPtr + 0);
        return;
    }

    /// <summary>
    /// Function: DrawSwingSpot
    /// </summary>
    public unsafe virtual void DrawSwingSpot()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPawnPlayerCatwomanBase.DrawSwingSpot", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: DrawSwingLastFrame
    /// </summary>
    public unsafe virtual void DrawSwingLastFrame()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPawnPlayerCatwomanBase.DrawSwingLastFrame", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: StopSwingFallSound
    /// </summary>
    public unsafe virtual void StopSwingFallSound()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPawnPlayerCatwomanBase.StopSwingFallSound", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: StartSwingFallSound
    /// </summary>
    public unsafe virtual void StartSwingFallSound()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPawnPlayerCatwomanBase.StartSwingFallSound", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Enum: ESwingDirection
    /// </summary>
    public enum ESwingDirection
    {
        SWD_Default = 0,
        SWD_Left = 1,
        SWD_Right = 2,
        SWD_LeftFar = 3,
        SWD_RightFar = 4,
        SWD_MAX = 5,
    }

    /// <summary>
    /// Enum: EAutoSwingState
    /// </summary>
    public enum EAutoSwingState
    {
        ASS_None = 0,
        ASS_InitialJump = 1,
        ASS_Swing = 2,
        ASS_JumpToWall = 3,
        ASS_WallStick = 4,
        ASS_MAX = 5,
    }

    /// <summary>
    /// Struct: FWhipTrailData
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 36)]
    public partial record struct FWhipTrailData
    {
        /// <summary>
        /// ComponentProperty: ParticleSystemComp
        /// </summary>
        public unsafe BmSDK.Engine.ParticleSystemComponent ParticleSystemComp
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleSystemComponent>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// NameProperty: BoneAttachName
        /// </summary>
        public unsafe BmSDK.FName BoneAttachName
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 8); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8); }; }
        }

        /// <summary>
        /// BoolProperty: bCurrentlyActive
        /// </summary>
        public unsafe bool bCurrentlyActive
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 16) & 1) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 16); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 16); }; }
        }

        /// <summary>
        /// StructProperty: LastUpdatePosition
        /// </summary>
        public unsafe System.Numerics.Vector3 LastUpdatePosition
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 20); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 20); }; }
        }

        /// <summary>
        /// IntProperty: CachedBoneAttachIndex
        /// </summary>
        public unsafe int CachedBoneAttachIndex
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 32); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 32); }; }
        }
    }

    /// <summary>
    /// StructProperty: vOldWallClimbPosition
    /// </summary>
    public unsafe System.Numerics.Vector3 vOldWallClimbPosition
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 10032); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 10032); }
    }

    /// <summary>
    /// ObjectProperty: WallClimbingCrawlLeftMoves
    /// </summary>
    public unsafe BmSDK.BmGame.RSpecialMoveController WallClimbingCrawlLeftMoves
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveController>(Ptr + 10044); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 10044); }
    }

    /// <summary>
    /// ObjectProperty: WallClimbingCrawlRightMoves
    /// </summary>
    public unsafe BmSDK.BmGame.RSpecialMoveController WallClimbingCrawlRightMoves
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveController>(Ptr + 10052); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 10052); }
    }

    /// <summary>
    /// ObjectProperty: LineLaunchingWithBatmanLaunchTargetMarker
    /// </summary>
    public unsafe BmSDK.Engine.ParticleSystem LineLaunchingWithBatmanLaunchTargetMarker
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleSystem>(Ptr + 10060); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 10060); }
    }

    /// <summary>
    /// ObjectProperty: AttachMoveConfig
    /// </summary>
    public unsafe BmSDK.BmGame.RSpecialMoveConfigConfigurable AttachMoveConfig
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveConfigConfigurable>(Ptr + 10068); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 10068); }
    }

    /// <summary>
    /// ObjectProperty: StandingRandomOverlayOverride
    /// </summary>
    public unsafe BmSDK.Engine.AnimSet StandingRandomOverlayOverride
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AnimSet>(Ptr + 10076); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 10076); }
    }

    /// <summary>
    /// ObjectProperty: WhipCrackFX
    /// </summary>
    public unsafe BmSDK.Engine.ParticleSystem WhipCrackFX
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleSystem>(Ptr + 10084); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 10084); }
    }

    /// <summary>
    /// ObjectProperty: TouchingCeilingVolume
    /// </summary>
    public unsafe BmSDK.BmGame.RCeilingClimbVolume TouchingCeilingVolume
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RCeilingClimbVolume>(Ptr + 10092); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 10092); }
    }

    /// <summary>
    /// ObjectProperty: SwingStartEvent
    /// </summary>
    public unsafe BmSDK.Engine.AkEvent SwingStartEvent
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkEvent>(Ptr + 10100); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 10100); }
    }

    /// <summary>
    /// ObjectProperty: SwingStopEvent
    /// </summary>
    public unsafe BmSDK.Engine.AkEvent SwingStopEvent
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkEvent>(Ptr + 10108); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 10108); }
    }

    /// <summary>
    /// ObjectProperty: JammerTakedownPlayerAnimSet
    /// </summary>
    public unsafe BmSDK.Engine.AnimSet JammerTakedownPlayerAnimSet
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AnimSet>(Ptr + 10116); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 10116); }
    }

    /// <summary>
    /// ObjectProperty: JammerTakedownVictimAnimSet
    /// </summary>
    public unsafe BmSDK.Engine.AnimSet JammerTakedownVictimAnimSet
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AnimSet>(Ptr + 10124); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 10124); }
    }

    /// <summary>
    /// ObjectProperty: CollarMat
    /// </summary>
    public unsafe BmSDK.Engine.MaterialInstanceConstant CollarMat
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.MaterialInstanceConstant>(Ptr + 10132); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 10132); }
    }

    /// <summary>
    /// ComponentProperty: CollarLight
    /// </summary>
    public unsafe BmSDK.Engine.PointLightComponent CollarLight
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.PointLightComponent>(Ptr + 10140); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 10140); }
    }

    /// <summary>
    /// ComponentProperty: CollarMesh
    /// </summary>
    public unsafe BmSDK.Engine.SkeletalMeshComponent CollarMesh
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.SkeletalMeshComponent>(Ptr + 10148); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 10148); }
    }

    /// <summary>
    /// ComponentProperty: WhipMesh
    /// </summary>
    public unsafe BmSDK.Engine.SkeletalMeshComponent WhipMesh
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.SkeletalMeshComponent>(Ptr + 10156); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 10156); }
    }

    /// <summary>
    /// StructProperty: OldCeilingTracePosition
    /// </summary>
    public unsafe System.Numerics.Vector3 OldCeilingTracePosition
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 10164); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 10164); }
    }

    /// <summary>
    /// BoolProperty: bPhysUseCeilingConstraints
    /// </summary>
    public unsafe bool bPhysUseCeilingConstraints
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 10176) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 10176); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 10176); }
    }

    /// <summary>
    /// BoolProperty: bFlipCeilingCamera
    /// </summary>
    public unsafe bool bFlipCeilingCamera
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 10176) & 2) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 10176); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 10176); }
    }

    /// <summary>
    /// BoolProperty: bAllowAerialWhipPounce
    /// </summary>
    public unsafe bool bAllowAerialWhipPounce
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 10176) & 4) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 10176); var newMask = value ? (currentMask | 4) : (currentMask & ~4); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 10176); }
    }

    /// <summary>
    /// BoolProperty: bAutoSwingEarlyWhip
    /// </summary>
    public unsafe bool bAutoSwingEarlyWhip
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 10176) & 8) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 10176); var newMask = value ? (currentMask | 8) : (currentMask & ~8); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 10176); }
    }

    /// <summary>
    /// BoolProperty: bAutoSwingTriggeredFromEdge
    /// </summary>
    public unsafe bool bAutoSwingTriggeredFromEdge
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 10176) & 16) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 10176); var newMask = value ? (currentMask | 16) : (currentMask & ~16); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 10176); }
    }

    /// <summary>
    /// BoolProperty: bDebugSwingAllowEarlyWhipIn
    /// </summary>
    public unsafe bool bDebugSwingAllowEarlyWhipIn
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 10176) & 32) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 10176); var newMask = value ? (currentMask | 32) : (currentMask & ~32); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 10176); }
    }

    /// <summary>
    /// BoolProperty: bDebugSwingForceEarlyWhipIn
    /// </summary>
    public unsafe bool bDebugSwingForceEarlyWhipIn
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 10176) & 64) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 10176); var newMask = value ? (currentMask | 64) : (currentMask & ~64); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 10176); }
    }

    /// <summary>
    /// BoolProperty: bDebugCeilingVisibility
    /// </summary>
    public unsafe bool bDebugCeilingVisibility
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 10176) & 128) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 10176); var newMask = value ? (currentMask | 128) : (currentMask & ~128); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 10176); }
    }

    /// <summary>
    /// BoolProperty: bDebugCeilingEdgeDetection
    /// </summary>
    public unsafe bool bDebugCeilingEdgeDetection
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 10176) & 256) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 10176); var newMask = value ? (currentMask | 256) : (currentMask & ~256); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 10176); }
    }

    /// <summary>
    /// BoolProperty: bPlayingSwingFallSound
    /// </summary>
    public unsafe bool bPlayingSwingFallSound
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 10176) & 512) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 10176); var newMask = value ? (currentMask | 512) : (currentMask & ~512); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 10176); }
    }

    /// <summary>
    /// BoolProperty: bDebugDrawFallSwingSound
    /// </summary>
    public unsafe bool bDebugDrawFallSwingSound
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 10176) & 1024) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 10176); var newMask = value ? (currentMask | 1024) : (currentMask & ~1024); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 10176); }
    }

    /// <summary>
    /// BoolProperty: bDebugJumpOffWalls
    /// </summary>
    public unsafe bool bDebugJumpOffWalls
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 10176) & 2048) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 10176); var newMask = value ? (currentMask | 2048) : (currentMask & ~2048); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 10176); }
    }

    /// <summary>
    /// BoolProperty: bSetCeilingBase
    /// </summary>
    public unsafe bool bSetCeilingBase
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 10176) & 4096) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 10176); var newMask = value ? (currentMask | 4096) : (currentMask & ~4096); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 10176); }
    }

    /// <summary>
    /// NameProperty: WhipSkelControlName
    /// </summary>
    public unsafe BmSDK.FName WhipSkelControlName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 10180); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 10180); }
    }

    /// <summary>
    /// FloatProperty: MaxDirectPounceHeightToCeilings
    /// </summary>
    public unsafe float MaxDirectPounceHeightToCeilings
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 10188); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 10188); }
    }

    /// <summary>
    /// FloatProperty: WhipTrailMinAppearSpeed
    /// </summary>
    public unsafe float WhipTrailMinAppearSpeed
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 10192); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 10192); }
    }

    /// <summary>
    /// FloatProperty: MinTrailsWhipExtent
    /// </summary>
    public unsafe float MinTrailsWhipExtent
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 10196); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 10196); }
    }

    /// <summary>
    /// ArrayProperty: WhipTrails
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RPawnPlayerCatwomanBase.FWhipTrailData> WhipTrails
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RPawnPlayerCatwomanBase.FWhipTrailData>>(Ptr + 10200); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 10200); }
    }

    /// <summary>
    /// ByteProperty: AutoSwingState
    /// </summary>
    public unsafe BmSDK.BmGame.RPawnPlayerCatwomanBase.EAutoSwingState AutoSwingState
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPawnPlayerCatwomanBase.EAutoSwingState>(Ptr + 10216); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 10216); }
    }

    /// <summary>
    /// ByteProperty: SwingDirection
    /// </summary>
    public unsafe BmSDK.BmGame.RPawnPlayerCatwomanBase.ESwingDirection SwingDirection
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPawnPlayerCatwomanBase.ESwingDirection>(Ptr + 10217); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 10217); }
    }

    /// <summary>
    /// FloatProperty: CeilingSuspiciousBodyRange
    /// </summary>
    public unsafe float CeilingSuspiciousBodyRange
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 10220); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 10220); }
    }

    /// <summary>
    /// FloatProperty: CeilingSuspiciousPredThugsRange
    /// </summary>
    public unsafe float CeilingSuspiciousPredThugsRange
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 10224); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 10224); }
    }

    /// <summary>
    /// StructProperty: LastSwingSoundLocation
    /// </summary>
    public unsafe System.Numerics.Vector3 LastSwingSoundLocation
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 10228); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 10228); }
    }

    /// <summary>
    /// FloatProperty: FallSoundStartSpeed
    /// </summary>
    public unsafe float FallSoundStartSpeed
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 10240); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 10240); }
    }

    /// <summary>
    /// FloatProperty: BolasRadius
    /// </summary>
    public unsafe float BolasRadius
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 10244); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 10244); }
    }

    /// <summary>
    /// FloatProperty: BolasHeight
    /// </summary>
    public unsafe float BolasHeight
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 10248); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 10248); }
    }

    /// <summary>
    /// StructProperty: BolasShift
    /// </summary>
    public unsafe System.Numerics.Vector3 BolasShift
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 10252); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 10252); }
    }

    /// <summary>
    /// FloatProperty: BolasRBSpeedFactor
    /// </summary>
    public unsafe float BolasRBSpeedFactor
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 10264); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 10264); }
    }

    /// <summary>
    /// FloatProperty: BolasRBMaxSpeed
    /// </summary>
    public unsafe float BolasRBMaxSpeed
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 10268); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 10268); }
    }

    /// <summary>
    /// StructProperty: BolasAngularSpeed
    /// </summary>
    public unsafe System.Numerics.Vector3 BolasAngularSpeed
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 10272); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 10272); }
    }

    /// <summary>
    /// FloatProperty: LastFlushPersistentLinesFrame
    /// </summary>
    public unsafe float LastFlushPersistentLinesFrame
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 10284); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 10284); }
    }

    /// <summary>
    /// StructProperty: CeilingNormal
    /// </summary>
    public unsafe System.Numerics.Vector3 CeilingNormal
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 10288); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 10288); }
    }

    /// <summary>
    /// FloatProperty: GrateClimbUpStartCheckDistance
    /// </summary>
    public unsafe float GrateClimbUpStartCheckDistance
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 10300); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 10300); }
    }

    /// <summary>
    /// FloatProperty: GrateClimbUpTargetCheckDistance
    /// </summary>
    public unsafe float GrateClimbUpTargetCheckDistance
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 10304); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 10304); }
    }

    /// <summary>
    /// FloatProperty: GrateClimbUpTargetFloorCheckDistance
    /// </summary>
    public unsafe float GrateClimbUpTargetFloorCheckDistance
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 10308); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 10308); }
    }

    /// <summary>
    /// FloatProperty: GrateClimbDownTargetCheckDistance
    /// </summary>
    public unsafe float GrateClimbDownTargetCheckDistance
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 10312); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 10312); }
    }

    /// <summary>
    /// FloatProperty: JumpOffWallCheckDistance
    /// </summary>
    public unsafe float JumpOffWallCheckDistance
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 10316); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 10316); }
    }

    /// <summary>
    /// FloatProperty: MaxPullFromCatwalkDistance
    /// </summary>
    public unsafe float MaxPullFromCatwalkDistance
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 10320); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 10320); }
    }

    /// <summary>
    /// StructProperty: PullFromCatwalkEdgeCheckExtent
    /// </summary>
    public unsafe System.Numerics.Vector3 PullFromCatwalkEdgeCheckExtent
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 10324); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 10324); }
    }

    /// <summary>
    /// FloatProperty: PullFromCatwalkEdgeCheckShift
    /// </summary>
    public unsafe float PullFromCatwalkEdgeCheckShift
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 10336); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 10336); }
    }
}
