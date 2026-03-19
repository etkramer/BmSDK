#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Class: AnimNodeSequence<br/>
/// (size = 0)
/// (flags = 0)
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
    /// NameProperty: AnimSeqName
    /// </summary>
    public unsafe BmSDK.FName AnimSeqName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 280); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 280); }
    }

    /// <summary>
    /// FloatProperty: Rate
    /// </summary>
    public unsafe float Rate
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 288); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 288); }
    }

    /// <summary>
    /// BoolProperty: bPlaying
    /// </summary>
    public unsafe bool bPlaying
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 292) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 292); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 292); }
    }

    /// <summary>
    /// BoolProperty: bLooping
    /// </summary>
    public unsafe bool bLooping
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 292) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 292); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 292); }
    }

    /// <summary>
    /// BoolProperty: bCauseActorAnimEnd
    /// </summary>
    public unsafe bool bCauseActorAnimEnd
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 292) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 292); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 292); }
    }

    /// <summary>
    /// BoolProperty: bCauseActorAnimPlay
    /// </summary>
    public unsafe bool bCauseActorAnimPlay
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 292) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 292); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 292); }
    }

    /// <summary>
    /// BoolProperty: bZeroRootRotation
    /// </summary>
    public unsafe bool bZeroRootRotation
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 292) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 292); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 292); }
    }

    /// <summary>
    /// BoolProperty: bZeroRootTranslation
    /// </summary>
    public unsafe bool bZeroRootTranslation
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 292) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 292); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 292); }
    }

    /// <summary>
    /// BoolProperty: bDisableWarningWhenAnimNotFound
    /// </summary>
    public unsafe bool bDisableWarningWhenAnimNotFound
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 292) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 292); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 292); }
    }

    /// <summary>
    /// BoolProperty: bNoNotifies
    /// </summary>
    public unsafe bool bNoNotifies
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 292) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 292); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 292); }
    }

    /// <summary>
    /// BoolProperty: bForceRefposeWhenNotPlaying
    /// </summary>
    public unsafe bool bForceRefposeWhenNotPlaying
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 292) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 292); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 292); }
    }

    /// <summary>
    /// BoolProperty: bIsIssuingNotifies
    /// </summary>
    public unsafe bool bIsIssuingNotifies
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 292) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 292); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 292); }
    }

    /// <summary>
    /// BoolProperty: bForceAlwaysSlave
    /// </summary>
    public unsafe bool bForceAlwaysSlave
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 292) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 292); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 292); }
    }

    /// <summary>
    /// BoolProperty: bSynchronize
    /// </summary>
    public unsafe bool bSynchronize
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 292) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 292); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 292); }
    }

    /// <summary>
    /// BoolProperty: bReverseSync
    /// </summary>
    public unsafe bool bReverseSync
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 292) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 292); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 292); }
    }

    /// <summary>
    /// BoolProperty: bShowTimeLineSlider
    /// </summary>
    public unsafe bool bShowTimeLineSlider
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 292) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 292); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 292); }
    }

    /// <summary>
    /// BoolProperty: bLoopCameraAnim
    /// </summary>
    public unsafe bool bLoopCameraAnim
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 292) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 292); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 292); }
    }

    /// <summary>
    /// BoolProperty: bRandomizeCameraAnimLoopStartTime
    /// </summary>
    public unsafe bool bRandomizeCameraAnimLoopStartTime
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 292) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 292); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 292); }
    }

    /// <summary>
    /// BoolProperty: bEditorOnlyAddRefPoseToAdditiveAnimation
    /// </summary>
    public unsafe bool bEditorOnlyAddRefPoseToAdditiveAnimation
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 292) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 292); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 292); }
    }

    /// <summary>
    /// BoolProperty: bCheckForFinishAnimEarly
    /// </summary>
    public unsafe bool bCheckForFinishAnimEarly
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 292) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 292); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 292); }
    }

    /// <summary>
    /// BoolProperty: bBlendingOut
    /// </summary>
    public unsafe bool bBlendingOut
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 292) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 292); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 292); }
    }

    /// <summary>
    /// BoolProperty: bIssueNotifiesMirrored
    /// </summary>
    public unsafe bool bIssueNotifiesMirrored
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 292) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 292); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 292); }
    }

    /// <summary>
    /// FloatProperty: CurrentTime
    /// </summary>
    public unsafe float CurrentTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 296); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 296); }
    }

    /// <summary>
    /// FloatProperty: PreviousTime
    /// </summary>
    public unsafe float PreviousTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 300); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 300); }
    }

    /// <summary>
    /// FloatProperty: EndTime
    /// </summary>
    public unsafe float EndTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 304); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 304); }
    }

    /// <summary>
    /// ObjectProperty: AnimSeq
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT AnimSeq
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 308); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 308); }
    }

    /// <summary>
    /// ObjectProperty: CameraAnim
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT CameraAnim
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 316); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 316); }
    }

    /// <summary>
    /// ObjectProperty: ActiveCameraAnimInstance
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT ActiveCameraAnimInstance
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 324); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 324); }
    }

    /// <summary>
    /// FloatProperty: NotifyWeightThreshold
    /// </summary>
    public unsafe float NotifyWeightThreshold
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 332); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 332); }
    }

    /// <summary>
    /// NameProperty: SynchGroupName
    /// </summary>
    public unsafe BmSDK.FName SynchGroupName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 336); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 336); }
    }

    /// <summary>
    /// FloatProperty: SynchPosOffset
    /// </summary>
    public unsafe float SynchPosOffset
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 344); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 344); }
    }

    /// <summary>
    /// FloatProperty: CameraAnimScale
    /// </summary>
    public unsafe float CameraAnimScale
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 348); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 348); }
    }

    /// <summary>
    /// FloatProperty: CameraAnimPlayRate
    /// </summary>
    public unsafe float CameraAnimPlayRate
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 352); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 352); }
    }

    /// <summary>
    /// FloatProperty: CameraAnimBlendInTime
    /// </summary>
    public unsafe float CameraAnimBlendInTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 356); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 356); }
    }

    /// <summary>
    /// FloatProperty: CameraAnimBlendOutTime
    /// </summary>
    public unsafe float CameraAnimBlendOutTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 360); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 360); }
    }

    /// <summary>
    /// ByteProperty: RootBoneOption
    /// </summary>
    public unsafe byte RootBoneOption_0
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 364); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 364); }
    }
    /// <summary>
    /// ByteProperty: RootBoneOption
    /// </summary>
    public unsafe byte RootBoneOption_1
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 365); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 365); }
    }
    /// <summary>
    /// ByteProperty: RootBoneOption
    /// </summary>
    public unsafe byte RootBoneOption_2
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 366); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 366); }
    }

    /// <summary>
    /// ByteProperty: RootRotationOption
    /// </summary>
    public unsafe byte RootRotationOption_0
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 367); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 367); }
    }
    /// <summary>
    /// ByteProperty: RootRotationOption
    /// </summary>
    public unsafe byte RootRotationOption_1
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 368); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 368); }
    }
    /// <summary>
    /// ByteProperty: RootRotationOption
    /// </summary>
    public unsafe byte RootRotationOption_2
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 369); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 369); }
    }

    /// <summary>
    /// ArrayProperty: MetaDataSkelControlList
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.FString>>>>> MetaDataSkelControlList
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.FString>>>>>>(Ptr + 372); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 372); }
    }
}
