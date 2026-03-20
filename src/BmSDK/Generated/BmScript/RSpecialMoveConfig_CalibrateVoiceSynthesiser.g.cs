#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmScript;

/// <summary>
/// Class: RSpecialMoveConfig_CalibrateVoiceSynthesiser<br/>
/// (size = 524)
/// (flags = 4114)
/// </summary>
public partial class RSpecialMoveConfig_CalibrateVoiceSynthesiser : BmSDK.BmGame.RSpecialMoveConfig, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmScript.RSpecialMoveConfig_CalibrateVoiceSynthesiser", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RSpecialMoveConfig_CalibrateVoiceSynthesiser() { }

    /// <summary>
    /// Constructs a new RSpecialMoveConfig_CalibrateVoiceSynthesiser
    /// </summary>
    public RSpecialMoveConfig_CalibrateVoiceSynthesiser(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RSpecialMoveConfig_CalibrateVoiceSynthesiser Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RSpecialMoveConfig_CalibrateVoiceSynthesiser(nint ptr) : base(ptr) { }

    /// <summary>
    /// Function: UnloadAudio
    /// </summary>
    public unsafe void UnloadAudio()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RSpecialMoveConfig_CalibrateVoiceSynthesiser.UnloadAudio", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: IsAudioLoaded
    /// </summary>
    public unsafe bool IsAudioLoaded()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RSpecialMoveConfig_CalibrateVoiceSynthesiser.IsAudioLoaded", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: LoadAudio
    /// </summary>
    public unsafe void LoadAudio()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RSpecialMoveConfig_CalibrateVoiceSynthesiser.LoadAudio", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Enum: VoiceSyntheserTarget
    /// </summary>
    public enum VoiceSyntheserTarget
    {
        VST_HarleyQuinn = 0,
        VST_SimonStagg = 1,
        VST_Riddler = 2,
        VST_MAX = 3,
    }

    /// <summary>
    /// NameProperty: OperateInAnimationName
    /// </summary>
    public unsafe BmSDK.FName OperateInAnimationName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 400); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 400); }
    }

    /// <summary>
    /// NameProperty: OperateLoopCameraAnimationName
    /// </summary>
    public unsafe BmSDK.FName OperateLoopCameraAnimationName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 408); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 408); }
    }

    /// <summary>
    /// NameProperty: OperateOutAnimationName
    /// </summary>
    public unsafe BmSDK.FName OperateOutAnimationName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 416); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 416); }
    }

    /// <summary>
    /// NameProperty: OperateLoopBatmanPoseName
    /// </summary>
    public unsafe BmSDK.FName OperateLoopBatmanPoseName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 424); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 424); }
    }

    /// <summary>
    /// ObjectProperty: CalibrationSWF
    /// </summary>
    public unsafe BmSDK.GFxUI.SwfMovie CalibrationSWF
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.GFxUI.SwfMovie>(Ptr + 432); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 432); }
    }

    /// <summary>
    /// ObjectProperty: CalibrationRenderTexture
    /// </summary>
    public unsafe BmSDK.Engine.TextureRenderTarget2D CalibrationRenderTexture
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.TextureRenderTarget2D>(Ptr + 440); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 440); }
    }

    /// <summary>
    /// ObjectProperty: VoiceSynthIntroDlg
    /// </summary>
    public unsafe BmSDK.Engine.AkDialogueLine VoiceSynthIntroDlg
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkDialogueLine>(Ptr + 448); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 448); }
    }

    /// <summary>
    /// ObjectProperty: VoiceSynthOuttroDlg
    /// </summary>
    public unsafe BmSDK.Engine.AkDialogueLine VoiceSynthOuttroDlg
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkDialogueLine>(Ptr + 456); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 456); }
    }

    /// <summary>
    /// ObjectProperty: VoiceSynthSample
    /// </summary>
    public unsafe BmSDK.Engine.AkEvent VoiceSynthSample
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkEvent>(Ptr + 464); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 464); }
    }

    /// <summary>
    /// ObjectProperty: VoiceSynthIntroEvt
    /// </summary>
    public unsafe BmSDK.Engine.AkEvent VoiceSynthIntroEvt
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkEvent>(Ptr + 472); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 472); }
    }

    /// <summary>
    /// ObjectProperty: VoiceSynthOuttroEvt
    /// </summary>
    public unsafe BmSDK.Engine.AkEvent VoiceSynthOuttroEvt
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkEvent>(Ptr + 480); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 480); }
    }

    /// <summary>
    /// BoolProperty: bUseIntroAndOutroAnimations
    /// </summary>
    public unsafe bool bUseIntroAndOutroAnimations
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 488) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 488); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 488); }
    }

    /// <summary>
    /// BoolProperty: bAudioLoaded
    /// </summary>
    public unsafe bool bAudioLoaded
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 488) & 2) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 488); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 488); }
    }

    /// <summary>
    /// StructProperty: DOFSettings
    /// </summary>
    public unsafe BmSDK.BmGame.RGameInfo.FDofStruct DOFSettings
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RGameInfo.FDofStruct>(Ptr + 492); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 492); }
    }

    /// <summary>
    /// ByteProperty: Target
    /// </summary>
    public unsafe BmSDK.BmScript.RSpecialMoveConfig_CalibrateVoiceSynthesiser.VoiceSyntheserTarget Target
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmScript.RSpecialMoveConfig_CalibrateVoiceSynthesiser.VoiceSyntheserTarget>(Ptr + 512); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 512); }
    }

    /// <summary>
    /// FloatProperty: PitchShiftSolution
    /// </summary>
    public unsafe float PitchShiftSolution
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 516); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 516); }
    }

    /// <summary>
    /// FloatProperty: FilterSolution
    /// </summary>
    public unsafe float FilterSolution
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 520); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 520); }
    }
}
