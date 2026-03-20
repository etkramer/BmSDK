#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RHudModuleAlertsAndSurveillance<br/>
/// (flags = 0)
/// </summary>
public partial class RHudModuleAlertsAndSurveillance : BmSDK.BmGame.RHudModule, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RHudModuleAlertsAndSurveillance", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RHudModuleAlertsAndSurveillance() { }

    /// <summary>
    /// Constructs a new RHudModuleAlertsAndSurveillance
    /// </summary>
    public RHudModuleAlertsAndSurveillance(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RHudModuleAlertsAndSurveillance Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RHudModuleAlertsAndSurveillance(nint ptr) : base(ptr) { }

    /// <summary>
    /// Function: SetSurveillanceStationAndSpeaker
    /// </summary>
    public unsafe void SetSurveillanceStationAndSpeaker(BmSDK.FString surv_station, BmSDK.FString surv_speaker)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RHudModuleAlertsAndSurveillance.SetSurveillanceStationAndSpeaker", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(surv_station, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(surv_speaker, paramsPtr + 16);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: SetInterceptAngleAndRangePrivate
    /// </summary>
    public unsafe void SetInterceptAngleAndRangePrivate(int AngleToInterceptActor, int DistanceToInterceptActor)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RHudModuleAlertsAndSurveillance.SetInterceptAngleAndRangePrivate", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(AngleToInterceptActor, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DistanceToInterceptActor, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: SetInterceptAngleAndRange
    /// </summary>
    public unsafe void SetInterceptAngleAndRange(int AngleToInterceptActor, int DistanceToInterceptActor)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RHudModuleAlertsAndSurveillance.SetInterceptAngleAndRange", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(AngleToInterceptActor, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DistanceToInterceptActor, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: SetSurveillanceMovieState
    /// </summary>
    public unsafe void SetSurveillanceMovieState(BmSDK.FString surv_type, BmSDK.FString surv_frame)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RHudModuleAlertsAndSurveillance.SetSurveillanceMovieState", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(surv_type, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(surv_frame, paramsPtr + 16);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: SetInvestigateModeActive
    /// </summary>
    public unsafe void SetInvestigateModeActive(bool is_active)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RHudModuleAlertsAndSurveillance.SetInvestigateModeActive", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(is_active, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: SetSurveillanceMode
    /// </summary>
    public unsafe void SetSurveillanceMode(BmSDK.BmGame.RHudModuleAlertsAndSurveillance.SurveillanceModes surv_mode, BmSDK.FString surv_station, BmSDK.FString surv_speaker)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RHudModuleAlertsAndSurveillance.SetSurveillanceMode", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(surv_mode, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(surv_station, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(surv_speaker, paramsPtr + 20);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: HideAudioAlert
    /// </summary>
    public unsafe void HideAudioAlert()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RHudModuleAlertsAndSurveillance.HideAudioAlert", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: SetTripleTrailParamsPrivate
    /// </summary>
    public unsafe void SetTripleTrailParamsPrivate(bool is_visible, int active_trail_index, bool trail_0_complete, bool trail_1_complete, bool trail_2_complete)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RHudModuleAlertsAndSurveillance.SetTripleTrailParamsPrivate", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(is_visible, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(active_trail_index, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(trail_0_complete, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(trail_1_complete, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(trail_2_complete, paramsPtr + 16);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: DisableTripleTrail
    /// </summary>
    public unsafe void DisableTripleTrail()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RHudModuleAlertsAndSurveillance.DisableTripleTrail", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: UpdateTripleTrail
    /// </summary>
    public unsafe void UpdateTripleTrail()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RHudModuleAlertsAndSurveillance.UpdateTripleTrail", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: SetTripleTrailFocus
    /// </summary>
    public unsafe void SetTripleTrailFocus(BmSDK.BmGame.REvidence TheEvidence)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RHudModuleAlertsAndSurveillance.SetTripleTrailFocus", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TheEvidence, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: SetupTripleTracker
    /// </summary>
    public unsafe void SetupTripleTracker(BmSDK.FString name0, BmSDK.FString name1, BmSDK.FString name2)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RHudModuleAlertsAndSurveillance.SetupTripleTracker", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(name0, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(name1, paramsPtr + 16);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(name2, paramsPtr + 32);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: SetForensicTrailString
    /// </summary>
    public unsafe void SetForensicTrailString(BmSDK.FString trail_name)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RHudModuleAlertsAndSurveillance.SetForensicTrailString", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(trail_name, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: SetForensicTrail
    /// </summary>
    public unsafe void SetForensicTrail(BmSDK.BmGame.REvidence TheEvidence)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RHudModuleAlertsAndSurveillance.SetForensicTrail", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TheEvidence, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: InitialiseFlash
    /// </summary>
    public unsafe void InitialiseFlash()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RHudModuleAlertsAndSurveillance.InitialiseFlash", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: Close
    /// </summary>
    public unsafe void Close()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RHudModuleAlertsAndSurveillance.Close", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: Init
    /// </summary>
    public unsafe bool Init(BmSDK.BmGame.RPlayerController _RPC, BmSDK.FString _ExtensionName, BmSDK.FString _ExtensionPath)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RHudModuleAlertsAndSurveillance.Init", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(_RPC, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(_ExtensionName, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(_ExtensionPath, paramsPtr + 24);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 40);
    }

    /// <summary>
    /// Enum: SurveillanceModes
    /// </summary>
    public enum SurveillanceModes
    {
        SM_None = 0,
        SM_Local = 1,
        SM_Broadcast = 2,
        SM_MAX = 3,
    }

    /// <summary>
    /// BoolProperty: TripleTrailActive
    /// </summary>
    public unsafe bool TripleTrailActive
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 240) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 240); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 240); }
    }

    /// <summary>
    /// IntProperty: TripleTrailFocusIndex
    /// </summary>
    public unsafe int TripleTrailFocusIndex
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 244); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 244); }
    }

    /// <summary>
    /// StrProperty: AudioSurvFrame
    /// </summary>
    public unsafe BmSDK.FString AudioSurvFrame
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 248); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 248); }
    }

    /// <summary>
    /// ByteProperty: CurrentSurveillanceMode
    /// </summary>
    public unsafe BmSDK.BmGame.RHudModuleAlertsAndSurveillance.SurveillanceModes CurrentSurveillanceMode
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RHudModuleAlertsAndSurveillance.SurveillanceModes>(Ptr + 264); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 264); }
    }

    /// <summary>
    /// StrProperty: CachedFunction_SetInterceptAngle
    /// </summary>
    public unsafe BmSDK.FString CachedFunction_SetInterceptAngle
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 268); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 268); }
    }

    /// <summary>
    /// StrProperty: CachedFunction_SetSurveillanceMovieState
    /// </summary>
    public unsafe BmSDK.FString CachedFunction_SetSurveillanceMovieState
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 284); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 284); }
    }

    /// <summary>
    /// StrProperty: CachedFunction_SetAudioText
    /// </summary>
    public unsafe BmSDK.FString CachedFunction_SetAudioText
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 300); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 300); }
    }

    /// <summary>
    /// FloatProperty: InterceptActorAngle
    /// </summary>
    public unsafe float InterceptActorAngle
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 316); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 316); }
    }

    /// <summary>
    /// IntProperty: InterceptActorDistance
    /// </summary>
    public unsafe int InterceptActorDistance
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 320); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 320); }
    }
}
