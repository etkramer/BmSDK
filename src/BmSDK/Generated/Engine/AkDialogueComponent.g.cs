#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Class: AkDialogueComponent<br/>
/// (size = 0)
/// (flags = 0)
/// </summary>
public partial class AkDialogueComponent : BmSDK.Engine.ActorComponent, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Engine.AkDialogueComponent", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal AkDialogueComponent() { }

    /// <summary>
    /// Constructs a new AkDialogueComponent
    /// </summary>
    public AkDialogueComponent(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, AkDialogueComponent Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected AkDialogueComponent(nint ptr) : base(ptr) { }

    /// <summary>
    /// StructProperty: VfTable_AkDialogueSpeaker
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT VfTable_AkDialogueSpeaker
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 124); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 124); }
    }

    /// <summary>
    /// ObjectProperty: Voice
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT Voice
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 132); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 132); }
    }

    /// <summary>
    /// StrProperty: CustomVoiceSubtitleLookup
    /// </summary>
    public unsafe BmSDK.FString CustomVoiceSubtitleLookup
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 140); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 140); }
    }

    /// <summary>
    /// NameProperty: AttachmentSocket
    /// </summary>
    public unsafe BmSDK.FName AttachmentSocket
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 156); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 156); }
    }

    /// <summary>
    /// DelegateProperty: OnStartSpeech
    /// </summary>
    public unsafe System.IntPtr OnStartSpeech
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.IntPtr>(Ptr + 164); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 164); }
    }

    /// <summary>
    /// DelegateProperty: OnStopSpeech
    /// </summary>
    public unsafe System.IntPtr OnStopSpeech
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.IntPtr>(Ptr + 180); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 180); }
    }

    /// <summary>
    /// DelegateProperty: OnStartDialogueLine
    /// </summary>
    public unsafe System.IntPtr OnStartDialogueLine
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.IntPtr>(Ptr + 196); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 196); }
    }

    /// <summary>
    /// DelegateProperty: OnStopDialogueLine
    /// </summary>
    public unsafe System.IntPtr OnStopDialogueLine
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.IntPtr>(Ptr + 212); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 212); }
    }

    /// <summary>
    /// BoolProperty: bAllowEmotes
    /// </summary>
    public unsafe bool bAllowEmotes
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 228) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 228); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 228); }
    }

    /// <summary>
    /// BoolProperty: bKillDialogueOnDestroy
    /// </summary>
    public unsafe bool bKillDialogueOnDestroy
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 228) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 228); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 228); }
    }

    /// <summary>
    /// BoolProperty: bDefaultDialogueComponent
    /// </summary>
    public unsafe bool bDefaultDialogueComponent
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 228) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 228); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 228); }
    }

    /// <summary>
    /// BoolProperty: bHasFocus
    /// </summary>
    public unsafe bool bHasFocus
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 228) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 228); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 228); }
    }

    /// <summary>
    /// BoolProperty: bIsEnhanced
    /// </summary>
    public unsafe bool bIsEnhanced
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 228) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 228); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 228); }
    }

    /// <summary>
    /// StructProperty: DialogueSourceId
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT DialogueSourceId
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 232); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 232); }
    }

    /// <summary>
    /// IntProperty: RecentVoiceId
    /// </summary>
    public unsafe int RecentVoiceId
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 240); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 240); }
    }

    /// <summary>
    /// IntProperty: SpeakingCounter
    /// </summary>
    public unsafe int SpeakingCounter
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 244); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 244); }
    }

    /// <summary>
    /// StructProperty: SpeakingTimestamp
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT SpeakingTimestamp
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 248); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 248); }
    }

    /// <summary>
    /// IntProperty: SurveillanceOccluders
    /// </summary>
    public unsafe int SurveillanceOccluders
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 256); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 256); }
    }

    /// <summary>
    /// IntProperty: DebugLastDialogueEventId
    /// </summary>
    public unsafe int DebugLastDialogueEventId
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 260); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 260); }
    }
}
