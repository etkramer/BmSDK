#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.AkAudio;

/// <summary>
/// Class: SeqAct_AkComponentSettings<br/>
/// (size = 0)
/// (flags = 0)
/// </summary>
public partial class SeqAct_AkComponentSettings : BmSDK.Engine.SequenceAction, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "AkAudio.SeqAct_AkComponentSettings", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal SeqAct_AkComponentSettings() { }

    /// <summary>
    /// Constructs a new SeqAct_AkComponentSettings
    /// </summary>
    public SeqAct_AkComponentSettings(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, SeqAct_AkComponentSettings Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected SeqAct_AkComponentSettings(nint ptr) : base(ptr) { }

    /// <summary>
    /// ByteProperty: NeverAutoDestroySource
    /// </summary>
    public unsafe byte NeverAutoDestroySource
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 352); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 352); }
    }

    /// <summary>
    /// ByteProperty: AutoDestroySourceWhenHidden
    /// </summary>
    public unsafe byte AutoDestroySourceWhenHidden
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 353); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 353); }
    }

    /// <summary>
    /// ByteProperty: AutoDestroySourceWhenDead
    /// </summary>
    public unsafe byte AutoDestroySourceWhenDead
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 354); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 354); }
    }

    /// <summary>
    /// ByteProperty: KillSoundsOnDestroy
    /// </summary>
    public unsafe byte KillSoundsOnDestroy
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 355); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 355); }
    }

    /// <summary>
    /// ByteProperty: ObstructionOcclusion
    /// </summary>
    public unsafe byte ObstructionOcclusion
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 356); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 356); }
    }

    /// <summary>
    /// ByteProperty: EnableEnvironments
    /// </summary>
    public unsafe byte EnableEnvironments
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 357); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 357); }
    }

    /// <summary>
    /// ByteProperty: CameraOffsetParameters
    /// </summary>
    public unsafe byte CameraOffsetParameters
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 358); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 358); }
    }

    /// <summary>
    /// ByteProperty: CameraAngleParameters
    /// </summary>
    public unsafe byte CameraAngleParameters
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 359); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 359); }
    }

    /// <summary>
    /// ByteProperty: PlayerDistanceParameters
    /// </summary>
    public unsafe byte PlayerDistanceParameters
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 360); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 360); }
    }

    /// <summary>
    /// ByteProperty: PlayerOffsetParameters
    /// </summary>
    public unsafe byte PlayerOffsetParameters
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 361); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 361); }
    }

    /// <summary>
    /// ByteProperty: PlayerAngleParameters
    /// </summary>
    public unsafe byte PlayerAngleParameters
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 362); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 362); }
    }

    /// <summary>
    /// ByteProperty: ObjectVelocityParameters
    /// </summary>
    public unsafe byte ObjectVelocityParameters
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 363); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 363); }
    }

    /// <summary>
    /// ByteProperty: ObjectVisibilityParameters
    /// </summary>
    public unsafe byte ObjectVisibilityParameters
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 364); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 364); }
    }

    /// <summary>
    /// ByteProperty: Occlusion
    /// </summary>
    public unsafe byte Occlusion
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 365); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 365); }
    }

    /// <summary>
    /// ByteProperty: ParameterOnlyOcclusion
    /// </summary>
    public unsafe byte ParameterOnlyOcclusion
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 366); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 366); }
    }

    /// <summary>
    /// FloatProperty: AudibilityCap
    /// </summary>
    public unsafe float AudibilityCap
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 368); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 368); }
    }

    /// <summary>
    /// FloatProperty: FalloffRadiusMultiplier
    /// </summary>
    public unsafe float FalloffRadiusMultiplier
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 372); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 372); }
    }

    /// <summary>
    /// NameProperty: AttachmentSocket
    /// </summary>
    public unsafe BmSDK.FName AttachmentSocket
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 376); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 376); }
    }

    /// <summary>
    /// ObjectProperty: ParameterSetup
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT ParameterSetup
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 384); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 384); }
    }

    /// <summary>
    /// ObjectProperty: PropagationSetup
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT PropagationSetup
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 392); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 392); }
    }

    /// <summary>
    /// ObjectProperty: PlayerDistanceParameter
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT PlayerDistanceParameter
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 400); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 400); }
    }

    /// <summary>
    /// ObjectProperty: AngleToSourceFromListenerPlayerParameter
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT AngleToSourceFromListenerPlayerParameter
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 408); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 408); }
    }

    /// <summary>
    /// ObjectProperty: AngleFromSourceToListenerPlayerParameter
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT AngleFromSourceToListenerPlayerParameter
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 416); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 416); }
    }

    /// <summary>
    /// ObjectProperty: VerticalOffsetToPlayerParameter
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT VerticalOffsetToPlayerParameter
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 424); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 424); }
    }

    /// <summary>
    /// ObjectProperty: HorizontalOffsetToPlayerParameter
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT HorizontalOffsetToPlayerParameter
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 432); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 432); }
    }

    /// <summary>
    /// ObjectProperty: ObjectVelocityParameter
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT ObjectVelocityParameter
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 440); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 440); }
    }

    /// <summary>
    /// ObjectProperty: ObjectVelocityHorizontalParameter
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT ObjectVelocityHorizontalParameter
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 448); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 448); }
    }

    /// <summary>
    /// ObjectProperty: ObjectVelocityVerticalParameter
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT ObjectVelocityVerticalParameter
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 456); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 456); }
    }

    /// <summary>
    /// ObjectProperty: RelativeVelocityParameter
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT RelativeVelocityParameter
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 464); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 464); }
    }

    /// <summary>
    /// ObjectProperty: VerticalOffsetToCameraParameter
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT VerticalOffsetToCameraParameter
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 472); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 472); }
    }

    /// <summary>
    /// ObjectProperty: HorizontalOffsetToCameraParameter
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT HorizontalOffsetToCameraParameter
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 480); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 480); }
    }

    /// <summary>
    /// ObjectProperty: AngleFromSourceToListenerCameraParameter
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT AngleFromSourceToListenerCameraParameter
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 488); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 488); }
    }

    /// <summary>
    /// ObjectProperty: ObjectVisibilityParameter
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT ObjectVisibilityParameter
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 496); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 496); }
    }

    /// <summary>
    /// BoolProperty: bMergeParameterSetup
    /// </summary>
    public unsafe bool bMergeParameterSetup
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 504) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 504); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 504); }
    }

    /// <summary>
    /// BoolProperty: bMergePropagationSetup
    /// </summary>
    public unsafe bool bMergePropagationSetup
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 504) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 504); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 504); }
    }

    /// <summary>
    /// FloatProperty: ObsOccMultiplier
    /// </summary>
    public unsafe float ObsOccMultiplier
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 508); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 508); }
    }

    /// <summary>
    /// FloatProperty: ObsOccMultiplierDlg
    /// </summary>
    public unsafe float ObsOccMultiplierDlg
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 512); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 512); }
    }

    /// <summary>
    /// FloatProperty: WetDryMixVolume
    /// </summary>
    public unsafe float WetDryMixVolume
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 516); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 516); }
    }

    /// <summary>
    /// FloatProperty: DopplerVelocity
    /// </summary>
    public unsafe float DopplerVelocity
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 520); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 520); }
    }

    /// <summary>
    /// FloatProperty: OcclusionScalingDistance
    /// </summary>
    public unsafe float OcclusionScalingDistance
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 524); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 524); }
    }

    /// <summary>
    /// FloatProperty: OcclusionMultiplier
    /// </summary>
    public unsafe float OcclusionMultiplier
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 528); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 528); }
    }

    /// <summary>
    /// FloatProperty: OcclusionMultiplierAux
    /// </summary>
    public unsafe float OcclusionMultiplierAux
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 532); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 532); }
    }

    /// <summary>
    /// FloatProperty: OcclusionMultiplierDlg
    /// </summary>
    public unsafe float OcclusionMultiplierDlg
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 536); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 536); }
    }

    /// <summary>
    /// FloatProperty: OcclusionBubble
    /// </summary>
    public unsafe float OcclusionBubble
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 540); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 540); }
    }

    /// <summary>
    /// Enum: EAkComponentSettingsObsOcc
    /// </summary>
    public enum EAkComponentSettingsObsOcc
    {
        AK_OBS_OCC_SETTING_UNCHANGED = 0,
        AK_OBS_OCC_SETTING_DISABLE = 1,
        AK_OBS_OCC_SETTING_ENABLE_BUILTINS_ONLY = 2,
        AK_OBS_OCC_SETTING_ENABLE_PARAMS_ONLY = 3,
        AK_OBS_OCC_SETTING_MAX = 4,
    }

    /// <summary>
    /// Enum: EAkComponentSettingsBool
    /// </summary>
    public enum EAkComponentSettingsBool
    {
        AK_SETTING_UNCHANGED = 0,
        AK_SETTING_TRUE = 1,
        AK_SETTING_FALSE = 2,
        AK_SETTING_MAX = 3,
    }
}
