#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RGFxMovieOmnitronBase<br/>
/// (size = 724)
/// (flags = 0)
/// </summary>
public partial class RGFxMovieOmnitronBase : BmSDK.BmGame.RGFxMovie, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RGFxMovieOmnitronBase", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RGFxMovieOmnitronBase() { }

    /// <summary>
    /// Constructs a new RGFxMovieOmnitronBase
    /// </summary>
    public RGFxMovieOmnitronBase(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RGFxMovieOmnitronBase Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RGFxMovieOmnitronBase(nint ptr) : base(ptr) { }

    /// <summary>
    /// Function: XI_FindDistanceFromPointToLine
    /// </summary>
    public unsafe float XI_FindDistanceFromPointToLine(float nodePointX, float nodePointY, float laserPointX, float laserPointY, float laser_angle)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RGFxMovieOmnitronBase.XI_FindDistanceFromPointToLine", true);
        byte* paramsPtr = stackalloc byte[24];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(nodePointX, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(nodePointY, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(laserPointX, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(laserPointY, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(laser_angle, paramsPtr + 16);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<float>(paramsPtr + 20);
    }

    /// <summary>
    /// Function: XI_SetCurveData
    /// </summary>
    public unsafe void XI_SetCurveData(float CurveAngleRange, float CurveAngleMin, float CurveAngleMax, float CurveRadiusHorz, float CurveRadiusVert, float CurveCentreX, float CurveCentreY, float CurveFocusX, float CurveFocusY)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RGFxMovieOmnitronBase.XI_SetCurveData", true);
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
    /// Function: XI_TickIntersect
    /// </summary>
    public unsafe void XI_TickIntersect(BmSDK.TArray<int> aNodesLeft, BmSDK.TArray<int> aNodesRight)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RGFxMovieOmnitronBase.XI_TickIntersect", true);
        byte* paramsPtr = stackalloc byte[32];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(aNodesLeft, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(aNodesRight, paramsPtr + 16);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: XI_StickStartsOrStopsMoving
    /// </summary>
    public unsafe void XI_StickStartsOrStopsMoving(int stick_index, bool is_moving)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RGFxMovieOmnitronBase.XI_StickStartsOrStopsMoving", true);
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(stick_index, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(is_moving, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: UC_SetLaserPositionAndAngle
    /// </summary>
    public unsafe void UC_SetLaserPositionAndAngle(int side_index, float fDollyX, float fDollyY, float fAngleToFocus)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RGFxMovieOmnitronBase.UC_SetLaserPositionAndAngle", true);
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(side_index, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(fDollyX, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(fDollyY, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(fAngleToFocus, paramsPtr + 12);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: UC_SetBeamIntersectNodes
    /// </summary>
    public unsafe void UC_SetBeamIntersectNodes(int node1, int node2)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RGFxMovieOmnitronBase.UC_SetBeamIntersectNodes", true);
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(node1, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(node2, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: UC_DoGameOver
    /// </summary>
    public unsafe void UC_DoGameOver(bool did_player_win)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RGFxMovieOmnitronBase.UC_DoGameOver", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(did_player_win, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: UC_SetNodeState
    /// </summary>
    public unsafe void UC_SetNodeState(int side_index, int node_index, int iState)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RGFxMovieOmnitronBase.UC_SetNodeState", true);
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(side_index, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(node_index, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(iState, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: UC_SetBombMeterProportion
    /// </summary>
    public unsafe void UC_SetBombMeterProportion(float Proportion)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RGFxMovieOmnitronBase.UC_SetBombMeterProportion", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Proportion, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: UC_SetupMadHatterMinigame
    /// </summary>
    public unsafe void UC_SetupMadHatterMinigame(float fHitArea, float fProportion, float fLaserSpeed)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RGFxMovieOmnitronBase.UC_SetupMadHatterMinigame", true);
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(fHitArea, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(fProportion, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(fLaserSpeed, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: UC_CheckSolution
    /// </summary>
    public unsafe void UC_CheckSolution()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RGFxMovieOmnitronBase.UC_CheckSolution", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: XI_CalibrationComplete
    /// </summary>
    public unsafe void XI_CalibrationComplete()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RGFxMovieOmnitronBase.XI_CalibrationComplete", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: XI_StopVoicePlayback
    /// </summary>
    public unsafe void XI_StopVoicePlayback()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RGFxMovieOmnitronBase.XI_StopVoicePlayback", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: XI_StartVoicePlayback
    /// </summary>
    public unsafe void XI_StartVoicePlayback()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RGFxMovieOmnitronBase.XI_StartVoicePlayback", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: XI_ClosingDialogueBoxAfterOutro
    /// </summary>
    public unsafe void XI_ClosingDialogueBoxAfterOutro()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RGFxMovieOmnitronBase.XI_ClosingDialogueBoxAfterOutro", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: XI_ClosingDialogueBoxAfterScan
    /// </summary>
    public unsafe void XI_ClosingDialogueBoxAfterScan()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RGFxMovieOmnitronBase.XI_ClosingDialogueBoxAfterScan", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: XI_ClosingDialogueBoxAfterIntro
    /// </summary>
    public unsafe void XI_ClosingDialogueBoxAfterIntro()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RGFxMovieOmnitronBase.XI_ClosingDialogueBoxAfterIntro", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: XI_PlayVoiceNormal
    /// </summary>
    public unsafe void XI_PlayVoiceNormal()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RGFxMovieOmnitronBase.XI_PlayVoiceNormal", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: XI_PushWaveParams
    /// </summary>
    public unsafe void XI_PushWaveParams(float audioLength, float audioValue)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RGFxMovieOmnitronBase.XI_PushWaveParams", true);
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(audioLength, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(audioValue, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: XI_GameReady
    /// </summary>
    public unsafe void XI_GameReady()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RGFxMovieOmnitronBase.XI_GameReady", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: InitVoiceSynth
    /// </summary>
    public unsafe void InitVoiceSynth(float solutionVal, float solutionLength, float barSize, float perfectMargin, float correctMargin, BmSDK.FString localisedName, BmSDK.FString PortraitName)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RGFxMovieOmnitronBase.InitVoiceSynth", true);
        byte* paramsPtr = stackalloc byte[52];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(solutionVal, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(solutionLength, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(barSize, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(perfectMargin, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(correctMargin, paramsPtr + 16);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(localisedName, paramsPtr + 20);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PortraitName, paramsPtr + 36);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: StartPlayhead
    /// </summary>
    public unsafe void StartPlayhead()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RGFxMovieOmnitronBase.StartPlayhead", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: PushControllerToFlash
    /// </summary>
    public unsafe void PushControllerToFlash(float left_x, float right_y)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RGFxMovieOmnitronBase.PushControllerToFlash", true);
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(left_x, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(right_y, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: TriggerIntroSound
    /// </summary>
    public unsafe void TriggerIntroSound()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RGFxMovieOmnitronBase.TriggerIntroSound", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: XI_AnimationEvent
    /// </summary>
    public unsafe void XI_AnimationEvent(BmSDK.FString sEvent)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RGFxMovieOmnitronBase.XI_AnimationEvent", true);
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(sEvent, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: XI_SetRumble
    /// </summary>
    public unsafe void XI_SetRumble(float fRumbleL, float fRumbleR)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RGFxMovieOmnitronBase.XI_SetRumble", true);
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(fRumbleL, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(fRumbleR, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: XI_PasswordFound
    /// </summary>
    public unsafe void XI_PasswordFound()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RGFxMovieOmnitronBase.XI_PasswordFound", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: XI_OutroComplete
    /// </summary>
    public unsafe void XI_OutroComplete()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RGFxMovieOmnitronBase.XI_OutroComplete", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: UC_PlaySweep
    /// </summary>
    public unsafe void UC_PlaySweep()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RGFxMovieOmnitronBase.UC_PlaySweep", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: UC_SetStickAngles
    /// </summary>
    public unsafe void UC_SetStickAngles(float fLeft, float fRight)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RGFxMovieOmnitronBase.UC_SetStickAngles", true);
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(fLeft, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(fRight, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: UC_SetDistance
    /// </summary>
    public unsafe void UC_SetDistance(float fDistance)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RGFxMovieOmnitronBase.UC_SetDistance", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(fDistance, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: UC_SetLockOnPercentage
    /// </summary>
    public unsafe void UC_SetLockOnPercentage(float fPercent)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RGFxMovieOmnitronBase.UC_SetLockOnPercentage", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(fPercent, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: UC_LockOn
    /// </summary>
    public unsafe void UC_LockOn(BmSDK.FString sState, BmSDK.FString sPrimaryText, BmSDK.FString sSecondaryText, BmSDK.FString sIcon, int nDifficulty)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RGFxMovieOmnitronBase.UC_LockOn", true);
        byte* paramsPtr = stackalloc byte[68];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(sState, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(sPrimaryText, paramsPtr + 16);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(sSecondaryText, paramsPtr + 32);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(sIcon, paramsPtr + 48);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(nDifficulty, paramsPtr + 64);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: UC_BeginHacking
    /// </summary>
    public unsafe void UC_BeginHacking(BmSDK.FString sPasswords, int nDifficulty, int nSeed)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RGFxMovieOmnitronBase.UC_BeginHacking", true);
        byte* paramsPtr = stackalloc byte[24];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(sPasswords, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(nDifficulty, paramsPtr + 16);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(nSeed, paramsPtr + 20);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: BeginHacking
    /// </summary>
    public unsafe void BeginHacking(BmSDK.BmGame.RRemoteControlHighSecurityInterface the_target)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RGFxMovieOmnitronBase.BeginHacking", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(the_target, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: OnClose
    /// </summary>
    public unsafe void OnClose()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RGFxMovieOmnitronBase.OnClose", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: Init
    /// </summary>
    public unsafe void Init(BmSDK.Engine.LocalPlayer LocPlay = default)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RGFxMovieOmnitronBase.Init", true);
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LocPlay, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// FloatProperty: FlashRumbleValueLeft
    /// </summary>
    public unsafe float FlashRumbleValueLeft
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 696); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 696); }
    }

    /// <summary>
    /// FloatProperty: FlashRumbleValueRight
    /// </summary>
    public unsafe float FlashRumbleValueRight
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 700); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 700); }
    }

    /// <summary>
    /// BoolProperty: PasswordFound
    /// </summary>
    public unsafe bool PasswordFound
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 704) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 704); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 704); }
    }

    /// <summary>
    /// BoolProperty: MinigameComplete
    /// </summary>
    public unsafe bool MinigameComplete
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 704) & 2) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 704); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 704); }
    }

    /// <summary>
    /// ObjectProperty: SpecialMoveVar
    /// </summary>
    public unsafe BmSDK.BmGame.RSpecialMovieInstance_MinigameBase SpecialMoveVar
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMovieInstance_MinigameBase>(Ptr + 708); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 708); }
    }

    /// <summary>
    /// ObjectProperty: MovieInfoBrainHacking
    /// </summary>
    public unsafe BmSDK.GFxUI.SwfMovie MovieInfoBrainHacking
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.GFxUI.SwfMovie>(Ptr + 716); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 716); }
    }
}
