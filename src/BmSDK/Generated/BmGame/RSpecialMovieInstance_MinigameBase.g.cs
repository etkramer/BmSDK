#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// ABSTRACT Class: RSpecialMovieInstance_MinigameBase<br/>
/// (size = 896)
/// (flags = 144703635)
/// </summary>
public partial class RSpecialMovieInstance_MinigameBase : BmSDK.BmGame.RSpecialMoveInstance, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RSpecialMovieInstance_MinigameBase", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RSpecialMovieInstance_MinigameBase() { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RSpecialMovieInstance_MinigameBase(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="Engine.Actor.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RSpecialMovieInstance_MinigameBase>
        => ((Engine.Actor)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="Engine.Actor.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RSpecialMovieInstance_MinigameBase>, new()
        => (TComponent)((Engine.Actor)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="Engine.Actor.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RSpecialMovieInstance_MinigameBase>
        => ((Engine.Actor)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="Engine.Actor.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RSpecialMovieInstance_MinigameBase>
        => ((Engine.Actor)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="Engine.Actor.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RSpecialMovieInstance_MinigameBase>
        => (TComponent)((Engine.Actor)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="Engine.Actor.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RSpecialMovieInstance_MinigameBase>
        => ((Engine.Actor)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="Engine.Actor.DetachScriptComponent(Type)"/>
    public void DetachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RSpecialMovieInstance_MinigameBase>
        => ((Engine.Actor)this).DetachScriptComponent(typeof(TComponent));

    /// <summary>
    /// Function: UpdatePCResonatorPos
    /// </summary>
    public unsafe virtual void UpdatePCResonatorPos(BmSDK.BmGame.RPlayerInput Input, float DeltaTime, float TurnSpeed, float Accel, float Decel)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RSpecialMovieInstance_MinigameBase.UpdatePCResonatorPos", true);
        byte* paramsPtr = stackalloc byte[24];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Input, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DeltaTime, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TurnSpeed, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Accel, paramsPtr + 16);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Decel, paramsPtr + 20);
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
    /// Function: GetLeftAndRightAngles
    /// </summary>
    public unsafe virtual void GetLeftAndRightAngles(out float LeftAngle, out float RightAngle, float RawLeftX, float RawLeftY, float RawRightX, float RawRightY)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RSpecialMovieInstance_MinigameBase.GetLeftAndRightAngles", true);
        byte* paramsPtr = stackalloc byte[24];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(RawLeftX, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(RawLeftY, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(RawRightX, paramsPtr + 16);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(RawRightY, paramsPtr + 20);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        LeftAngle = BmSDK.Framework.MarshalUtil.ToManaged<float>(paramsPtr + 0);
        RightAngle = BmSDK.Framework.MarshalUtil.ToManaged<float>(paramsPtr + 4);
        return;
    }

    /// <summary>
    /// Function: InterpThumbStraight
    /// </summary>
    public unsafe virtual float InterpThumbStraight(float DesiredPos, float CurrentPos, float DeltaTime)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RSpecialMovieInstance_MinigameBase.InterpThumbStraight", true);
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DesiredPos, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CurrentPos, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DeltaTime, paramsPtr + 8);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManaged<float>(paramsPtr + 12);
    }

    /// <summary>
    /// Function: InterpThumb
    /// </summary>
    public unsafe virtual float InterpThumb(float DesiredPos, float CurrentPos, float DeltaTime)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RSpecialMovieInstance_MinigameBase.InterpThumb", true);
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DesiredPos, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CurrentPos, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DeltaTime, paramsPtr + 8);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManaged<float>(paramsPtr + 12);
    }

    /// <summary>
    /// Function: FindDistanceFromPointToLine
    /// </summary>
    public unsafe virtual float FindDistanceFromPointToLine(float nodePointX, float nodePointY, float laserPointX, float laserPointY, float laser_angle)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RSpecialMovieInstance_MinigameBase.FindDistanceFromPointToLine", true);
        byte* paramsPtr = stackalloc byte[72];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(nodePointX, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(nodePointY, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(laserPointX, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(laserPointY, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(laser_angle, paramsPtr + 16);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<float>(paramsPtr + 20);
    }

    /// <summary>
    /// Function: DoGameOver
    /// </summary>
    public unsafe virtual void DoGameOver(bool did_player_win)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RSpecialMovieInstance_MinigameBase.DoGameOver", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(did_player_win, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: SetNodeState
    /// </summary>
    public unsafe virtual void SetNodeState(int side_index, int node_index, int iState)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RSpecialMovieInstance_MinigameBase.SetNodeState", true);
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(side_index, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(node_index, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(iState, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: SetBeamIntersectNodes
    /// </summary>
    public unsafe virtual void SetBeamIntersectNodes(int node1, int node2)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RSpecialMovieInstance_MinigameBase.SetBeamIntersectNodes", true);
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(node1, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(node2, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: SetBombMeterProportion
    /// </summary>
    public unsafe virtual void SetBombMeterProportion(float Proportion)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RSpecialMovieInstance_MinigameBase.SetBombMeterProportion", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Proportion, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: SetupMadHatterMinigame
    /// </summary>
    public unsafe virtual void SetupMadHatterMinigame(float fHitArea, float fProportion, float fLaserSpeed)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RSpecialMovieInstance_MinigameBase.SetupMadHatterMinigame", true);
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(fHitArea, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(fProportion, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(fLaserSpeed, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: SetLaserPositionAndAngle
    /// </summary>
    public unsafe virtual void SetLaserPositionAndAngle(int side_index, float fDollyX, float fDollyY, float fAngleToFocus)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RSpecialMovieInstance_MinigameBase.SetLaserPositionAndAngle", true);
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(side_index, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(fDollyX, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(fDollyY, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(fAngleToFocus, paramsPtr + 12);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: TickIntersect
    /// </summary>
    public unsafe virtual void TickIntersect(BmSDK.TArray<int> aNodesLeft, BmSDK.TArray<int> aNodesRight)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RSpecialMovieInstance_MinigameBase.TickIntersect", true);
        byte* paramsPtr = stackalloc byte[32];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(aNodesLeft, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(aNodesRight, paramsPtr + 16);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: SetCurveData
    /// </summary>
    public unsafe virtual void SetCurveData(float CurveAngleRange, float CurveAngleMin, float CurveAngleMax, float CurveRadiusHorz, float CurveRadiusVert, float CurveCentreX, float CurveCentreY, float CurveFocusX, float CurveFocusY)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RSpecialMovieInstance_MinigameBase.SetCurveData", true);
        byte* paramsPtr = stackalloc byte[36];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CurveAngleRange, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CurveAngleMin, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CurveAngleMax, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CurveRadiusHorz, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CurveRadiusVert, paramsPtr + 16);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CurveCentreX, paramsPtr + 20);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CurveCentreY, paramsPtr + 24);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CurveFocusX, paramsPtr + 28);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CurveFocusY, paramsPtr + 32);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: StickStartsOrStopsMoving
    /// </summary>
    public unsafe virtual void StickStartsOrStopsMoving(int stick_index, bool is_moving)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RSpecialMovieInstance_MinigameBase.StickStartsOrStopsMoving", true);
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(stick_index, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(is_moving, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: MiniGameBarProportion
    /// </summary>
    public unsafe virtual void MiniGameBarProportion(float barProportion)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RSpecialMovieInstance_MinigameBase.MiniGameBarProportion", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(barProportion, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: MiniGameLost
    /// </summary>
    public unsafe virtual void MiniGameLost()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RSpecialMovieInstance_MinigameBase.MiniGameLost", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: MiniGameWon
    /// </summary>
    public unsafe virtual void MiniGameWon()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RSpecialMovieInstance_MinigameBase.MiniGameWon", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: PlayCalibrationComplete
    /// </summary>
    public unsafe virtual void PlayCalibrationComplete()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RSpecialMovieInstance_MinigameBase.PlayCalibrationComplete", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: WinClearPrompts
    /// </summary>
    public unsafe virtual void WinClearPrompts()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RSpecialMovieInstance_MinigameBase.WinClearPrompts", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: AudioParams
    /// </summary>
    public unsafe virtual void AudioParams(float audioSpeedMod, float audioValue)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RSpecialMovieInstance_MinigameBase.AudioParams", true);
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(audioSpeedMod, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(audioValue, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: StopVoicePlayback
    /// </summary>
    public unsafe virtual void StopVoicePlayback()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RSpecialMovieInstance_MinigameBase.StopVoicePlayback", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: StartVoicePlayback
    /// </summary>
    public unsafe virtual void StartVoicePlayback()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RSpecialMovieInstance_MinigameBase.StartVoicePlayback", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: ClosingDialogueBoxAfterOutro
    /// </summary>
    public unsafe virtual void ClosingDialogueBoxAfterOutro()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RSpecialMovieInstance_MinigameBase.ClosingDialogueBoxAfterOutro", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: ClosingDialogueBoxAfterScan
    /// </summary>
    public unsafe virtual void ClosingDialogueBoxAfterScan()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RSpecialMovieInstance_MinigameBase.ClosingDialogueBoxAfterScan", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: ClosingDialogueBoxAfterIntro
    /// </summary>
    public unsafe virtual void ClosingDialogueBoxAfterIntro()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RSpecialMovieInstance_MinigameBase.ClosingDialogueBoxAfterIntro", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: PlayVoiceNormal
    /// </summary>
    public unsafe virtual void PlayVoiceNormal()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RSpecialMovieInstance_MinigameBase.PlayVoiceNormal", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: PlayAudio
    /// </summary>
    public unsafe virtual void PlayAudio()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RSpecialMovieInstance_MinigameBase.PlayAudio", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// FloatProperty: PCLeftThumbVel
    /// </summary>
    public unsafe float PCLeftThumbVel
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 876); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 876); }
    }

    /// <summary>
    /// FloatProperty: PCRightThumbVel
    /// </summary>
    public unsafe float PCRightThumbVel
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 880); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 880); }
    }

    /// <summary>
    /// FloatProperty: PCLeftThumbPos
    /// </summary>
    public unsafe float PCLeftThumbPos
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 884); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 884); }
    }

    /// <summary>
    /// FloatProperty: PCRightThumbPos
    /// </summary>
    public unsafe float PCRightThumbPos
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 888); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 888); }
    }

    /// <summary>
    /// BoolProperty: GameReady
    /// </summary>
    public unsafe bool GameReady
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 892) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 892); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 892); }
    }
}
