#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmScript;

/// <summary>
/// Class: RSpecialMoveInstance_CalibrateVoiceSynthesiser<br/>
/// (size = 1004)
/// (flags = 10485778)
/// </summary>
public partial class RSpecialMoveInstance_CalibrateVoiceSynthesiser : BmSDK.BmGame.RSpecialMovieInstance_MinigameBase, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmScript.RSpecialMoveInstance_CalibrateVoiceSynthesiser", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RSpecialMoveInstance_CalibrateVoiceSynthesiser() { }

    /// <summary>
    /// Constructs a new RSpecialMoveInstance_CalibrateVoiceSynthesiser
    /// </summary>
    public RSpecialMoveInstance_CalibrateVoiceSynthesiser(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RSpecialMoveInstance_CalibrateVoiceSynthesiser Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RSpecialMoveInstance_CalibrateVoiceSynthesiser(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="Engine.Actor.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RSpecialMoveInstance_CalibrateVoiceSynthesiser>
        => ((Engine.Actor)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="Engine.Actor.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RSpecialMoveInstance_CalibrateVoiceSynthesiser>, new()
        => (TComponent)((Engine.Actor)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="Engine.Actor.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RSpecialMoveInstance_CalibrateVoiceSynthesiser>
        => ((Engine.Actor)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="Engine.Actor.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RSpecialMoveInstance_CalibrateVoiceSynthesiser>
        => ((Engine.Actor)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="Engine.Actor.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RSpecialMoveInstance_CalibrateVoiceSynthesiser>
        => (TComponent)((Engine.Actor)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="Engine.Actor.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RSpecialMoveInstance_CalibrateVoiceSynthesiser>
        => ((Engine.Actor)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="Engine.Actor.DetachScriptComponent(Type)"/>
    public void DetachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RSpecialMoveInstance_CalibrateVoiceSynthesiser>
        => ((Engine.Actor)this).DetachScriptComponent(typeof(TComponent));

    /// <summary>
    /// Function: SetRumble
    /// </summary>
    public unsafe void SetRumble(float Rumble)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RSpecialMoveInstance_CalibrateVoiceSynthesiser.SetRumble", true);
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Rumble, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: FinishSpecialMove
    /// </summary>
    public unsafe void FinishSpecialMove()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RSpecialMoveInstance_CalibrateVoiceSynthesiser.FinishSpecialMove", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: HackingMiniGameWon
    /// </summary>
    public unsafe void HackingMiniGameWon()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RSpecialMoveInstance_CalibrateVoiceSynthesiser.HackingMiniGameWon", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: PlayCalibrationComplete
    /// </summary>
    public unsafe void PlayCalibrationComplete()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RSpecialMoveInstance_CalibrateVoiceSynthesiser.PlayCalibrationComplete", true);
        byte* paramsPtr = stackalloc byte[116];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: UpdateSpecialMove
    /// </summary>
    public unsafe bool UpdateSpecialMove(float DeltaTime)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RSpecialMoveInstance_CalibrateVoiceSynthesiser.UpdateSpecialMove", true);
        byte* paramsPtr = stackalloc byte[60];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DeltaTime, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 4);
    }

    /// <summary>
    /// Function: PushControllerToFlash
    /// </summary>
    public unsafe void PushControllerToFlash(float left_y, float right_y)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RSpecialMoveInstance_CalibrateVoiceSynthesiser.PushControllerToFlash", true);
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(left_y, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(right_y, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: AudioParams
    /// </summary>
    public unsafe void AudioParams(float _PitchValue, float _FilterValue)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RSpecialMoveInstance_CalibrateVoiceSynthesiser.AudioParams", true);
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(_PitchValue, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(_FilterValue, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: PlayAudio
    /// </summary>
    public unsafe void PlayAudio()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RSpecialMoveInstance_CalibrateVoiceSynthesiser.PlayAudio", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: StopVoicePlayback
    /// </summary>
    public unsafe void StopVoicePlayback()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RSpecialMoveInstance_CalibrateVoiceSynthesiser.StopVoicePlayback", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: StartVoicePlayback
    /// </summary>
    public unsafe void StartVoicePlayback()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RSpecialMoveInstance_CalibrateVoiceSynthesiser.StartVoicePlayback", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: PlayVoiceNormal
    /// </summary>
    public unsafe void PlayVoiceNormal()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RSpecialMoveInstance_CalibrateVoiceSynthesiser.PlayVoiceNormal", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: ClosingDialogueBoxAfterOutro
    /// </summary>
    public unsafe void ClosingDialogueBoxAfterOutro()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RSpecialMoveInstance_CalibrateVoiceSynthesiser.ClosingDialogueBoxAfterOutro", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: ClosingDialogueBoxAfterScan
    /// </summary>
    public unsafe void ClosingDialogueBoxAfterScan()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RSpecialMoveInstance_CalibrateVoiceSynthesiser.ClosingDialogueBoxAfterScan", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: ClosingDialogueBoxAfterIntro
    /// </summary>
    public unsafe void ClosingDialogueBoxAfterIntro()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RSpecialMoveInstance_CalibrateVoiceSynthesiser.ClosingDialogueBoxAfterIntro", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: WinClearPrompts
    /// </summary>
    public unsafe void WinClearPrompts()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RSpecialMoveInstance_CalibrateVoiceSynthesiser.WinClearPrompts", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: UpdatePrompts
    /// </summary>
    public unsafe void UpdatePrompts()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RSpecialMoveInstance_CalibrateVoiceSynthesiser.UpdatePrompts", true);
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: StartDOFChange
    /// </summary>
    public unsafe void StartDOFChange()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RSpecialMoveInstance_CalibrateVoiceSynthesiser.StartDOFChange", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: InitialSetupVoiceSynthMinigame
    /// </summary>
    public unsafe void InitialSetupVoiceSynthMinigame()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RSpecialMoveInstance_CalibrateVoiceSynthesiser.InitialSetupVoiceSynthMinigame", true);
        byte* paramsPtr = stackalloc byte[32];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: TriggerSpecialMove
    /// </summary>
    public unsafe void TriggerSpecialMove(BmSDK.BmGame.REnvironmentCheckTicker.FEnvironmentSpecialMoveLocator MoveLocation)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RSpecialMoveInstance_CalibrateVoiceSynthesiser.TriggerSpecialMove", true);
        byte* paramsPtr = stackalloc byte[132];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(MoveLocation, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: VoiceSampleCallback
    /// </summary>
    public unsafe void VoiceSampleCallback(int CallbackFlags, BmSDK.Engine.AkWwise.FAkSoundHandle SoundHandle, int MarkerID, int MarkerTypeID, float Duration)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RSpecialMoveInstance_CalibrateVoiceSynthesiser.VoiceSampleCallback", true);
        byte* paramsPtr = stackalloc byte[40];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CallbackFlags, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SoundHandle, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(MarkerID, paramsPtr + 20);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(MarkerTypeID, paramsPtr + 24);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Duration, paramsPtr + 28);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// StructProperty: CurrentTransition
    /// </summary>
    public unsafe BmSDK.BmGame.RAnimUtil_PosePlayer.FTransitionId CurrentTransition
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RAnimUtil_PosePlayer.FTransitionId>(Ptr + 896); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 896); }
    }

    /// <summary>
    /// ObjectProperty: MyConfig
    /// </summary>
    public unsafe BmSDK.BmScript.RSpecialMoveConfig_CalibrateVoiceSynthesiser MyConfig
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmScript.RSpecialMoveConfig_CalibrateVoiceSynthesiser>(Ptr + 900); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 900); }
    }

    /// <summary>
    /// ObjectProperty: Batman
    /// </summary>
    public unsafe BmSDK.BmGame.RPawnPlayerBmBase Batman
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPawnPlayerBmBase>(Ptr + 908); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 908); }
    }

    /// <summary>
    /// ObjectProperty: TheOmnitronMovie
    /// </summary>
    public unsafe BmSDK.BmGame.RGFxMovieOmnitronBase TheOmnitronMovie
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RGFxMovieOmnitronBase>(Ptr + 916); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 916); }
    }

    /// <summary>
    /// ObjectProperty: VoiceToMatchAudio
    /// </summary>
    public unsafe BmSDK.Engine.AkEvent VoiceToMatchAudio
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkEvent>(Ptr + 924); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 924); }
    }

    /// <summary>
    /// ObjectProperty: SuccessAudio
    /// </summary>
    public unsafe BmSDK.Engine.AkDialogueLine SuccessAudio
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkDialogueLine>(Ptr + 932); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 932); }
    }

    /// <summary>
    /// ObjectProperty: TunerFFWaveForm
    /// </summary>
    public unsafe BmSDK.Engine.ForceFeedbackWaveform TunerFFWaveForm
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ForceFeedbackWaveform>(Ptr + 940); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 940); }
    }

    /// <summary>
    /// ObjectProperty: myBank
    /// </summary>
    public unsafe BmSDK.Engine.AkBank myBank
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkBank>(Ptr + 948); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 948); }
    }

    /// <summary>
    /// BoolProperty: promptSet
    /// </summary>
    public unsafe bool promptSet
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 956) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 956); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 956); }
    }

    /// <summary>
    /// BoolProperty: MatchFound
    /// </summary>
    public unsafe bool MatchFound
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 956) & 2) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 956); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 956); }
    }

    /// <summary>
    /// BoolProperty: Playing
    /// </summary>
    public unsafe bool Playing
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 956) & 4) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 956); var newMask = value ? (currentMask | 4) : (currentMask & ~4); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 956); }
    }

    /// <summary>
    /// BoolProperty: DebounceCheckSolution
    /// </summary>
    public unsafe bool DebounceCheckSolution
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 956) & 8) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 956); var newMask = value ? (currentMask | 8) : (currentMask & ~8); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 956); }
    }

    /// <summary>
    /// BoolProperty: PausedWhenLooping
    /// </summary>
    public unsafe bool PausedWhenLooping
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 956) & 16) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 956); var newMask = value ? (currentMask | 16) : (currentMask & ~16); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 956); }
    }

    /// <summary>
    /// BoolProperty: PrevbUsingGamepad
    /// </summary>
    public unsafe bool PrevbUsingGamepad
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 956) & 32) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 956); var newMask = value ? (currentMask | 32) : (currentMask & ~32); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 956); }
    }

    /// <summary>
    /// FloatProperty: FilterValue
    /// </summary>
    public unsafe float FilterValue
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 960); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 960); }
    }

    /// <summary>
    /// FloatProperty: FilterSolution
    /// </summary>
    public unsafe float FilterSolution
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 964); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 964); }
    }

    /// <summary>
    /// FloatProperty: PitchValue
    /// </summary>
    public unsafe float PitchValue
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 968); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 968); }
    }

    /// <summary>
    /// FloatProperty: PitchSolution
    /// </summary>
    public unsafe float PitchSolution
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 972); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 972); }
    }

    /// <summary>
    /// FloatProperty: LeftThumbPos
    /// </summary>
    public unsafe float LeftThumbPos
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 976); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 976); }
    }

    /// <summary>
    /// FloatProperty: RightThumbPos
    /// </summary>
    public unsafe float RightThumbPos
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 980); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 980); }
    }

    /// <summary>
    /// FloatProperty: FlashRumbleValue
    /// </summary>
    public unsafe float FlashRumbleValue
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 984); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 984); }
    }

    /// <summary>
    /// StructProperty: VoiceSampleHandle
    /// </summary>
    public unsafe BmSDK.Engine.AkWwise.FAkSoundHandle VoiceSampleHandle
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkWwise.FAkSoundHandle>(Ptr + 988); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 988); }
    }
}
