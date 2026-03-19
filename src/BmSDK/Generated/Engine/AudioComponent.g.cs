#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Class: AudioComponent<br/>
/// (size = 0)
/// (flags = 0)
/// </summary>
public partial class AudioComponent : BmSDK.Engine.ActorComponent, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Engine.AudioComponent", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal AudioComponent() { }

    /// <summary>
    /// Constructs a new AudioComponent
    /// </summary>
    public AudioComponent(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, AudioComponent Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected AudioComponent(nint ptr) : base(ptr) { }

    /// <summary>
    /// ObjectProperty: SoundCue
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT SoundCue
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 124); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 124); }
    }

    /// <summary>
    /// ObjectProperty: CueFirstNode
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT CueFirstNode
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 132); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 132); }
    }

    /// <summary>
    /// ArrayProperty: InstanceParameters
    /// </summary>
    public unsafe BmSDK.TArray<System.IntPtr> InstanceParameters
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<System.IntPtr>>(Ptr + 140); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 140); }
    }

    /// <summary>
    /// BoolProperty: bUseOwnerLocation
    /// </summary>
    public unsafe bool bUseOwnerLocation
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 156) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 156); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 156); }
    }

    /// <summary>
    /// BoolProperty: bAutoPlay
    /// </summary>
    public unsafe bool bAutoPlay
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 156) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 156); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 156); }
    }

    /// <summary>
    /// BoolProperty: bAutoDestroy
    /// </summary>
    public unsafe bool bAutoDestroy
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 156) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 156); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 156); }
    }

    /// <summary>
    /// BoolProperty: bStopWhenOwnerDestroyed
    /// </summary>
    public unsafe bool bStopWhenOwnerDestroyed
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 156) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 156); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 156); }
    }

    /// <summary>
    /// BoolProperty: bShouldRemainActiveIfDropped
    /// </summary>
    public unsafe bool bShouldRemainActiveIfDropped
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 156) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 156); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 156); }
    }

    /// <summary>
    /// BoolProperty: bWasOccluded
    /// </summary>
    public unsafe bool bWasOccluded
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 156) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 156); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 156); }
    }

    /// <summary>
    /// BoolProperty: bSuppressSubtitles
    /// </summary>
    public unsafe bool bSuppressSubtitles
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 156) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 156); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 156); }
    }

    /// <summary>
    /// BoolProperty: bWasPlaying
    /// </summary>
    public unsafe bool bWasPlaying
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 156) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 156); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 156); }
    }

    /// <summary>
    /// BoolProperty: bAllowSpatialization
    /// </summary>
    public unsafe bool bAllowSpatialization
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 156) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 156); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 156); }
    }

    /// <summary>
    /// BoolProperty: bFinished
    /// </summary>
    public unsafe bool bFinished
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 156) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 156); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 156); }
    }

    /// <summary>
    /// BoolProperty: bApplyRadioFilter
    /// </summary>
    public unsafe bool bApplyRadioFilter
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 156) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 156); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 156); }
    }

    /// <summary>
    /// BoolProperty: bRadioFilterSelected
    /// </summary>
    public unsafe bool bRadioFilterSelected
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 156) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 156); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 156); }
    }

    /// <summary>
    /// BoolProperty: bPreviewComponent
    /// </summary>
    public unsafe bool bPreviewComponent
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 156) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 156); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 156); }
    }

    /// <summary>
    /// BoolProperty: bIgnoreForFlushing
    /// </summary>
    public unsafe bool bIgnoreForFlushing
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 156) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 156); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 156); }
    }

    /// <summary>
    /// FloatProperty: StereoBleed
    /// </summary>
    public unsafe float StereoBleed
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 160); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 160); }
    }

    /// <summary>
    /// FloatProperty: LFEBleed
    /// </summary>
    public unsafe float LFEBleed
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 164); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 164); }
    }

    /// <summary>
    /// BoolProperty: bEQFilterApplied
    /// </summary>
    public unsafe bool bEQFilterApplied
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 168) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 168); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 168); }
    }

    /// <summary>
    /// BoolProperty: bAlwaysPlay
    /// </summary>
    public unsafe bool bAlwaysPlay
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 168) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 168); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 168); }
    }

    /// <summary>
    /// BoolProperty: bIsUISound
    /// </summary>
    public unsafe bool bIsUISound
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 168) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 168); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 168); }
    }

    /// <summary>
    /// BoolProperty: bIsMusic
    /// </summary>
    public unsafe bool bIsMusic
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 168) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 168); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 168); }
    }

    /// <summary>
    /// BoolProperty: bReverb
    /// </summary>
    public unsafe bool bReverb
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 168) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 168); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 168); }
    }

    /// <summary>
    /// BoolProperty: bCenterChannelOnly
    /// </summary>
    public unsafe bool bCenterChannelOnly
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 168) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 168); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 168); }
    }

    /// <summary>
    /// ArrayProperty: WaveInstances
    /// </summary>
    public unsafe NEED_UPDATE_ARRAYPROPERTY_LAYOUT WaveInstances
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_ARRAYPROPERTY_LAYOUT>(Ptr + 172); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 172); }
    }

    /// <summary>
    /// ArrayProperty: SoundNodeData
    /// </summary>
    public unsafe NEED_UPDATE_ARRAYPROPERTY_LAYOUT SoundNodeData
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_ARRAYPROPERTY_LAYOUT>(Ptr + 188); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 188); }
    }

    /// <summary>
    /// MapProperty: SoundNodeOffsetMap
    /// </summary>
    public unsafe BmSDK.TMap<object, object> /* TODO */ SoundNodeOffsetMap
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TMap<object, object> /* TODO */>(Ptr + 204); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 204); }
    }

    /// <summary>
    /// StructProperty: SoundNodeResetWaveMap
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT SoundNodeResetWaveMap
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 276); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 276); }
    }

    /// <summary>
    /// StructProperty: Listener
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT Listener
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 348); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 348); }
    }

    /// <summary>
    /// FloatProperty: PlaybackTime
    /// </summary>
    public unsafe float PlaybackTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 356); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 356); }
    }

    /// <summary>
    /// ObjectProperty: PortalVolume
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT PortalVolume
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 360); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 360); }
    }

    /// <summary>
    /// StructProperty: Location
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT Location
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 368); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 368); }
    }

    /// <summary>
    /// StructProperty: ComponentLocation
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT ComponentLocation
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 380); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 380); }
    }

    /// <summary>
    /// ObjectProperty: LastOwner
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT LastOwner
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 392); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 392); }
    }

    /// <summary>
    /// FloatProperty: SubtitlePriority
    /// </summary>
    public unsafe float SubtitlePriority
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 400); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 400); }
    }

    /// <summary>
    /// ObjectProperty: CurrentNotifyBufferFinishedHook
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT CurrentNotifyBufferFinishedHook
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 404); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 404); }
    }

    /// <summary>
    /// StructProperty: CurrentLocation
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT CurrentLocation
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 412); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 412); }
    }

    /// <summary>
    /// StructProperty: CurrentVelocity
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT CurrentVelocity
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 424); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 424); }
    }

    /// <summary>
    /// FloatProperty: CurrentVolume
    /// </summary>
    public unsafe float CurrentVolume
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 436); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 436); }
    }

    /// <summary>
    /// FloatProperty: CurrentPitch
    /// </summary>
    public unsafe float CurrentPitch
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 440); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 440); }
    }

    /// <summary>
    /// IntProperty: CurrentUseSpatialization
    /// </summary>
    public unsafe int CurrentUseSpatialization
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 444); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 444); }
    }

    /// <summary>
    /// IntProperty: CurrentNotifyOnLoop
    /// </summary>
    public unsafe int CurrentNotifyOnLoop
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 448); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 448); }
    }

    /// <summary>
    /// FloatProperty: OmniRadius
    /// </summary>
    public unsafe float OmniRadius
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 452); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 452); }
    }

    /// <summary>
    /// FloatProperty: CurrentVolumeMultiplier
    /// </summary>
    public unsafe float CurrentVolumeMultiplier
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 456); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 456); }
    }

    /// <summary>
    /// FloatProperty: CurrentPitchMultiplier
    /// </summary>
    public unsafe float CurrentPitchMultiplier
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 460); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 460); }
    }

    /// <summary>
    /// FloatProperty: CurrentHighFrequencyGainMultiplier
    /// </summary>
    public unsafe float CurrentHighFrequencyGainMultiplier
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 464); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 464); }
    }

    /// <summary>
    /// StructProperty: LastUpdateTime
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT LastUpdateTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 468); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 468); }
    }

    /// <summary>
    /// FloatProperty: SourceInteriorVolume
    /// </summary>
    public unsafe float SourceInteriorVolume
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 476); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 476); }
    }

    /// <summary>
    /// FloatProperty: SourceInteriorLPF
    /// </summary>
    public unsafe float SourceInteriorLPF
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 480); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 480); }
    }

    /// <summary>
    /// FloatProperty: CurrentInteriorVolume
    /// </summary>
    public unsafe float CurrentInteriorVolume
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 484); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 484); }
    }

    /// <summary>
    /// FloatProperty: CurrentInteriorLPF
    /// </summary>
    public unsafe float CurrentInteriorLPF
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 488); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 488); }
    }

    /// <summary>
    /// StructProperty: LastLocation
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT LastLocation
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 492); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 492); }
    }

    /// <summary>
    /// FloatProperty: VolumeMultiplier
    /// </summary>
    public unsafe float VolumeMultiplier
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 504); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 504); }
    }

    /// <summary>
    /// FloatProperty: PitchMultiplier
    /// </summary>
    public unsafe float PitchMultiplier
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 508); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 508); }
    }

    /// <summary>
    /// FloatProperty: HighFrequencyGainMultiplier
    /// </summary>
    public unsafe float HighFrequencyGainMultiplier
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 512); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 512); }
    }

    /// <summary>
    /// FloatProperty: OcclusionCheckInterval
    /// </summary>
    public unsafe float OcclusionCheckInterval
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 516); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 516); }
    }

    /// <summary>
    /// FloatProperty: LastOcclusionCheckTime
    /// </summary>
    public unsafe float LastOcclusionCheckTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 520); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 520); }
    }

    /// <summary>
    /// DelegateProperty: __OnAudioFinished__Delegate
    /// </summary>
    public unsafe System.IntPtr __OnAudioFinished__Delegate
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.IntPtr>(Ptr + 524); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 524); }
    }
}
