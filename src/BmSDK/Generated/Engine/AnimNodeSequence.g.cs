#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Class: AnimNodeSequence<br/>
/// (size = 300)
/// (flags = 142606482)
/// </summary>
public partial class AnimNodeSequence : BmSDK.Engine.AnimNode, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Engine.AnimNodeSequence", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal AnimNodeSequence() { }

    /// <summary>
    /// Constructs a new AnimNodeSequence
    /// </summary>
    public AnimNodeSequence(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, AnimNodeSequence Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected AnimNodeSequence(nint ptr) : base(ptr) { }

    /// <summary>
    /// Function: SetRootBoneRotationOption
    /// </summary>
    public unsafe virtual void SetRootBoneRotationOption(BmSDK.Engine.AnimNodeSequence.ERootRotationOption AxisX = default, BmSDK.Engine.AnimNodeSequence.ERootRotationOption AxisY = default, BmSDK.Engine.AnimNodeSequence.ERootRotationOption AxisZ = default)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "Engine.AnimNodeSequence.SetRootBoneRotationOption", true);
        byte* paramsPtr = stackalloc byte[3];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(AxisX, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(AxisY, paramsPtr + 1);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(AxisZ, paramsPtr + 2);
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
    /// Function: SetRootBoneAxisOption
    /// </summary>
    public unsafe virtual void SetRootBoneAxisOption(BmSDK.Engine.AnimNodeSequence.ERootBoneAxis AxisX = default, BmSDK.Engine.AnimNodeSequence.ERootBoneAxis AxisY = default, BmSDK.Engine.AnimNodeSequence.ERootBoneAxis AxisZ = default)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "Engine.AnimNodeSequence.SetRootBoneAxisOption", true);
        byte* paramsPtr = stackalloc byte[3];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(AxisX, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(AxisY, paramsPtr + 1);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(AxisZ, paramsPtr + 2);
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
    /// Function: GetTimeLeft
    /// </summary>
    public unsafe virtual float GetTimeLeft()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "Engine.AnimNodeSequence.GetTimeLeft", true);
        byte* paramsPtr = stackalloc byte[4];
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManaged<float>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: GetAnimPlaybackLength
    /// </summary>
    public unsafe virtual float GetAnimPlaybackLength()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "Engine.AnimNodeSequence.GetAnimPlaybackLength", true);
        byte* paramsPtr = stackalloc byte[4];
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManaged<float>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: GetGlobalPlayRate
    /// </summary>
    public unsafe virtual float GetGlobalPlayRate()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "Engine.AnimNodeSequence.GetGlobalPlayRate", true);
        byte* paramsPtr = stackalloc byte[4];
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManaged<float>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: GetGroupRelativePosition
    /// </summary>
    public unsafe virtual float GetGroupRelativePosition()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "Engine.AnimNodeSequence.GetGroupRelativePosition", true);
        byte* paramsPtr = stackalloc byte[4];
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManaged<float>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: FindGroupPosition
    /// </summary>
    public unsafe virtual float FindGroupPosition(float GroupRelativePosition)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "Engine.AnimNodeSequence.FindGroupPosition", true);
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(GroupRelativePosition, paramsPtr + 0);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManaged<float>(paramsPtr + 4);
    }

    /// <summary>
    /// Function: FindGroupRelativePosition
    /// </summary>
    public unsafe virtual float FindGroupRelativePosition(float GroupRelativePosition)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "Engine.AnimNodeSequence.FindGroupRelativePosition", true);
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(GroupRelativePosition, paramsPtr + 0);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManaged<float>(paramsPtr + 4);
    }

    /// <summary>
    /// Function: GetNormalizedPosition
    /// </summary>
    public unsafe virtual float GetNormalizedPosition()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "Engine.AnimNodeSequence.GetNormalizedPosition", true);
        byte* paramsPtr = stackalloc byte[4];
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManaged<float>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: SetPosition
    /// </summary>
    public unsafe virtual void SetPosition(float NewTime, bool bFireNotifies)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "Engine.AnimNodeSequence.SetPosition", true);
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewTime, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bFireNotifies, paramsPtr + 4);
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
    /// Function: ReplayAnim
    /// </summary>
    public unsafe override void ReplayAnim()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "Engine.AnimNodeSequence.ReplayAnim", true);
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
    /// Function: StopAnim
    /// </summary>
    public unsafe override void StopAnim()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "Engine.AnimNodeSequence.StopAnim", true);
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
    /// Function: PlayAnim
    /// </summary>
    public unsafe override void PlayAnim(bool bLoop = default, float InRate = default, float StartTime = default)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "Engine.AnimNodeSequence.PlayAnim", true);
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bLoop, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(InRate, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(StartTime, paramsPtr + 8);
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
    /// Function: SetAnim
    /// </summary>
    public unsafe virtual void SetAnim(BmSDK.FName Sequence)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "Engine.AnimNodeSequence.SetAnim", true);
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Sequence, paramsPtr + 0);
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
    /// Enum: ERootRotationOption
    /// </summary>
    public enum ERootRotationOption
    {
        RRO_Default = 0,
        RRO_Discard = 1,
        RRO_Extract = 2,
        RRO_MAX = 3,
    }

    /// <summary>
    /// Enum: ERootBoneAxis
    /// </summary>
    public enum ERootBoneAxis
    {
        RBA_Default = 0,
        RBA_Discard = 1,
        RBA_Translate = 2,
        RBA_MAX = 3,
    }

    /// <summary>
    /// NameProperty: AnimSeqName
    /// </summary>
    public unsafe BmSDK.FName AnimSeqName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 208); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 208); }
    }

    /// <summary>
    /// FloatProperty: Rate
    /// </summary>
    public unsafe float Rate
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 216); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 216); }
    }

    /// <summary>
    /// BoolProperty: bPlaying
    /// </summary>
    public unsafe bool bPlaying
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 220) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 220); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 220); }
    }

    /// <summary>
    /// BoolProperty: bLooping
    /// </summary>
    public unsafe bool bLooping
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 220) & 2) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 220); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 220); }
    }

    /// <summary>
    /// BoolProperty: bCauseActorAnimEnd
    /// </summary>
    public unsafe bool bCauseActorAnimEnd
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 220) & 4) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 220); var newMask = value ? (currentMask | 4) : (currentMask & ~4); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 220); }
    }

    /// <summary>
    /// BoolProperty: bCauseActorAnimPlay
    /// </summary>
    public unsafe bool bCauseActorAnimPlay
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 220) & 8) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 220); var newMask = value ? (currentMask | 8) : (currentMask & ~8); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 220); }
    }

    /// <summary>
    /// BoolProperty: bZeroRootRotation
    /// </summary>
    public unsafe bool bZeroRootRotation
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 220) & 16) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 220); var newMask = value ? (currentMask | 16) : (currentMask & ~16); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 220); }
    }

    /// <summary>
    /// BoolProperty: bZeroRootTranslation
    /// </summary>
    public unsafe bool bZeroRootTranslation
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 220) & 32) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 220); var newMask = value ? (currentMask | 32) : (currentMask & ~32); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 220); }
    }

    /// <summary>
    /// BoolProperty: bDisableWarningWhenAnimNotFound
    /// </summary>
    public unsafe bool bDisableWarningWhenAnimNotFound
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 220) & 64) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 220); var newMask = value ? (currentMask | 64) : (currentMask & ~64); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 220); }
    }

    /// <summary>
    /// BoolProperty: bNoNotifies
    /// </summary>
    public unsafe bool bNoNotifies
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 220) & 128) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 220); var newMask = value ? (currentMask | 128) : (currentMask & ~128); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 220); }
    }

    /// <summary>
    /// BoolProperty: bForceRefposeWhenNotPlaying
    /// </summary>
    public unsafe bool bForceRefposeWhenNotPlaying
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 220) & 256) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 220); var newMask = value ? (currentMask | 256) : (currentMask & ~256); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 220); }
    }

    /// <summary>
    /// BoolProperty: bIsIssuingNotifies
    /// </summary>
    public unsafe bool bIsIssuingNotifies
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 220) & 512) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 220); var newMask = value ? (currentMask | 512) : (currentMask & ~512); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 220); }
    }

    /// <summary>
    /// BoolProperty: bForceAlwaysSlave
    /// </summary>
    public unsafe bool bForceAlwaysSlave
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 220) & 1024) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 220); var newMask = value ? (currentMask | 1024) : (currentMask & ~1024); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 220); }
    }

    /// <summary>
    /// BoolProperty: bSynchronize
    /// </summary>
    public unsafe bool bSynchronize
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 220) & 2048) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 220); var newMask = value ? (currentMask | 2048) : (currentMask & ~2048); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 220); }
    }

    /// <summary>
    /// BoolProperty: bReverseSync
    /// </summary>
    public unsafe bool bReverseSync
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 220) & 4096) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 220); var newMask = value ? (currentMask | 4096) : (currentMask & ~4096); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 220); }
    }

    /// <summary>
    /// BoolProperty: bShowTimeLineSlider
    /// </summary>
    public unsafe bool bShowTimeLineSlider
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 220) & 8192) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 220); var newMask = value ? (currentMask | 8192) : (currentMask & ~8192); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 220); }
    }

    /// <summary>
    /// BoolProperty: bLoopCameraAnim
    /// </summary>
    public unsafe bool bLoopCameraAnim
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 220) & 16384) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 220); var newMask = value ? (currentMask | 16384) : (currentMask & ~16384); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 220); }
    }

    /// <summary>
    /// BoolProperty: bRandomizeCameraAnimLoopStartTime
    /// </summary>
    public unsafe bool bRandomizeCameraAnimLoopStartTime
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 220) & 32768) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 220); var newMask = value ? (currentMask | 32768) : (currentMask & ~32768); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 220); }
    }

    /// <summary>
    /// BoolProperty: bEditorOnlyAddRefPoseToAdditiveAnimation
    /// </summary>
    public unsafe bool bEditorOnlyAddRefPoseToAdditiveAnimation
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 220) & 65536) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 220); var newMask = value ? (currentMask | 65536) : (currentMask & ~65536); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 220); }
    }

    /// <summary>
    /// FloatProperty: CurrentTime
    /// </summary>
    public unsafe float CurrentTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 224); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 224); }
    }

    /// <summary>
    /// FloatProperty: PreviousTime
    /// </summary>
    public unsafe float PreviousTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 228); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 228); }
    }

    /// <summary>
    /// FloatProperty: EndTime
    /// </summary>
    public unsafe float EndTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 232); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 232); }
    }

    /// <summary>
    /// ObjectProperty: AnimSeq
    /// </summary>
    public unsafe BmSDK.Engine.AnimSequence AnimSeq
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AnimSequence>(Ptr + 236); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 236); }
    }

    /// <summary>
    /// FloatProperty: NotifyWeightThreshold
    /// </summary>
    public unsafe float NotifyWeightThreshold
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 240); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 240); }
    }

    /// <summary>
    /// NameProperty: SynchGroupName
    /// </summary>
    public unsafe BmSDK.FName SynchGroupName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 244); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 244); }
    }

    /// <summary>
    /// FloatProperty: SynchPosOffset
    /// </summary>
    public unsafe float SynchPosOffset
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 252); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 252); }
    }

    /// <summary>
    /// ObjectProperty: CameraAnim
    /// </summary>
    public unsafe BmSDK.Engine.CameraAnim CameraAnim
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.CameraAnim>(Ptr + 256); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 256); }
    }

    /// <summary>
    /// ObjectProperty: ActiveCameraAnimInstance
    /// </summary>
    public unsafe BmSDK.Engine.CameraAnimInst ActiveCameraAnimInstance
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.CameraAnimInst>(Ptr + 260); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 260); }
    }

    /// <summary>
    /// FloatProperty: CameraAnimScale
    /// </summary>
    public unsafe float CameraAnimScale
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 264); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 264); }
    }

    /// <summary>
    /// FloatProperty: CameraAnimPlayRate
    /// </summary>
    public unsafe float CameraAnimPlayRate
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 268); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 268); }
    }

    /// <summary>
    /// FloatProperty: CameraAnimBlendInTime
    /// </summary>
    public unsafe float CameraAnimBlendInTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 272); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 272); }
    }

    /// <summary>
    /// FloatProperty: CameraAnimBlendOutTime
    /// </summary>
    public unsafe float CameraAnimBlendOutTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 276); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 276); }
    }

    /// <summary>
    /// ByteProperty: RootBoneOption
    /// </summary>
    public unsafe BmSDK.Engine.AnimNodeSequence.ERootBoneAxis RootBoneOption_0
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AnimNodeSequence.ERootBoneAxis>(Ptr + 280); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 280); }
    }
    /// <summary>
    /// ByteProperty: RootBoneOption
    /// </summary>
    public unsafe BmSDK.Engine.AnimNodeSequence.ERootBoneAxis RootBoneOption_1
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AnimNodeSequence.ERootBoneAxis>(Ptr + 281); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 281); }
    }
    /// <summary>
    /// ByteProperty: RootBoneOption
    /// </summary>
    public unsafe BmSDK.Engine.AnimNodeSequence.ERootBoneAxis RootBoneOption_2
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AnimNodeSequence.ERootBoneAxis>(Ptr + 282); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 282); }
    }

    /// <summary>
    /// ByteProperty: RootRotationOption
    /// </summary>
    public unsafe BmSDK.Engine.AnimNodeSequence.ERootRotationOption RootRotationOption_0
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AnimNodeSequence.ERootRotationOption>(Ptr + 283); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 283); }
    }
    /// <summary>
    /// ByteProperty: RootRotationOption
    /// </summary>
    public unsafe BmSDK.Engine.AnimNodeSequence.ERootRotationOption RootRotationOption_1
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AnimNodeSequence.ERootRotationOption>(Ptr + 284); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 284); }
    }
    /// <summary>
    /// ByteProperty: RootRotationOption
    /// </summary>
    public unsafe BmSDK.Engine.AnimNodeSequence.ERootRotationOption RootRotationOption_2
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AnimNodeSequence.ERootRotationOption>(Ptr + 285); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 285); }
    }

    /// <summary>
    /// ArrayProperty: MetaDataSkelControlList
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.Engine.SkelControlBase> MetaDataSkelControlList
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.SkelControlBase>>(Ptr + 288); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 288); }
    }
}
