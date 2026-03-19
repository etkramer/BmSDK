#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Class: AkDialogueEvent<br/>
/// (size = 0)
/// (flags = 0)
/// </summary>
public partial class AkDialogueEvent : BmSDK.Engine.AkHash, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Engine.AkDialogueEvent", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal AkDialogueEvent() { }

    /// <summary>
    /// Constructs a new AkDialogueEvent
    /// </summary>
    public AkDialogueEvent(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, AkDialogueEvent Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected AkDialogueEvent(nint ptr) : base(ptr) { }

    /// <summary>
    /// StructProperty: VfTable_AkDialogueEvent
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT VfTable_AkDialogueEvent
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 92); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 92); }
    }

    /// <summary>
    /// ObjectProperty: SoundEvent
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT SoundEvent
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 100); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 100); }
    }

    /// <summary>
    /// ObjectProperty: DialogueAnim
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT DialogueAnim
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 108); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 108); }
    }

    /// <summary>
    /// ObjectProperty: CustomRobotEvent
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT CustomRobotEvent
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 116); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 116); }
    }

    /// <summary>
    /// ArrayProperty: DialogueDurations
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.TArray<BmSDK.FString>> DialogueDurations
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.TArray<BmSDK.FString>>>(Ptr + 124); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 124); }
    }

    /// <summary>
    /// FloatProperty: SourceLanguageDryDuration
    /// </summary>
    public unsafe float SourceLanguageDryDuration
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 140); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 140); }
    }

    /// <summary>
    /// ArrayProperty: DialogueText
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.FString> DialogueText
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.FString>>(Ptr + 144); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 144); }
    }

    /// <summary>
    /// StrProperty: CustomVoiceSubtitleLookup
    /// </summary>
    public unsafe BmSDK.FString CustomVoiceSubtitleLookup
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 160); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 160); }
    }

    /// <summary>
    /// BoolProperty: bOnceOnly
    /// </summary>
    public unsafe bool bOnceOnly
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 176) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 176); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 176); }
    }

    /// <summary>
    /// BoolProperty: bOnceEver
    /// </summary>
    public unsafe bool bOnceEver
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 176) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 176); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 176); }
    }

    /// <summary>
    /// BoolProperty: bOncePerSession
    /// </summary>
    public unsafe bool bOncePerSession
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 176) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 176); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 176); }
    }

    /// <summary>
    /// BoolProperty: bRecordingFinal
    /// </summary>
    public unsafe bool bRecordingFinal
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 176) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 176); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 176); }
    }

    /// <summary>
    /// BoolProperty: bRecordingUpToDate
    /// </summary>
    public unsafe bool bRecordingUpToDate
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 176) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 176); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 176); }
    }

    /// <summary>
    /// BoolProperty: bDialogueLoaded
    /// </summary>
    public unsafe bool bDialogueLoaded
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 176) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 176); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 176); }
    }

    /// <summary>
    /// BoolProperty: bDialoguePreloaded
    /// </summary>
    public unsafe bool bDialoguePreloaded
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 176) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 176); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 176); }
    }

    /// <summary>
    /// BoolProperty: bPreloadRequested
    /// </summary>
    public unsafe bool bPreloadRequested
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 176) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 176); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 176); }
    }

    /// <summary>
    /// BoolProperty: bPreloadError
    /// </summary>
    public unsafe bool bPreloadError
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 176) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 176); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 176); }
    }

    /// <summary>
    /// FloatProperty: TimeOffset
    /// </summary>
    public unsafe float TimeOffset
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 180); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 180); }
    }

    /// <summary>
    /// ByteProperty: PreloadStreamPriority
    /// </summary>
    public unsafe byte PreloadStreamPriority
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 184); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 184); }
    }

    /// <summary>
    /// StrProperty: RawText
    /// </summary>
    public unsafe BmSDK.FString RawText
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 188); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 188); }
    }
}
