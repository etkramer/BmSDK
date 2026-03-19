#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RSideStoryManager<br/>
/// (size = 0)
/// (flags = 0)
/// </summary>
public partial class RSideStoryManager : BmSDK.GameObject, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RSideStoryManager", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RSideStoryManager() { }

    /// <summary>
    /// Constructs a new RSideStoryManager
    /// </summary>
    public RSideStoryManager(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RSideStoryManager Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RSideStoryManager(nint ptr) : base(ptr) { }

    /// <summary>
    /// StructProperty: VfTable_AkDialogueListener
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT VfTable_AkDialogueListener
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 84); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 84); }
    }

    /// <summary>
    /// ArrayProperty: RiddlerHints
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.FString>>> RiddlerHints
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.FString>>>>(Ptr + 92); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 92); }
    }

    /// <summary>
    /// ObjectProperty: CurrentFocusActor
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT CurrentFocusActor
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 108); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 108); }
    }

    /// <summary>
    /// ObjectProperty: PreviousFrameFocusActor
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT PreviousFrameFocusActor
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 116); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 116); }
    }

    /// <summary>
    /// FloatProperty: TimeActorInFocus
    /// </summary>
    public unsafe float TimeActorInFocus
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 124); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 124); }
    }

    /// <summary>
    /// ArrayProperty: ActorGroups
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.TArray<BmSDK.FString>> ActorGroups
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.TArray<BmSDK.FString>>>(Ptr + 128); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 128); }
    }

    /// <summary>
    /// ArrayProperty: VisibleEntryList
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.FString> VisibleEntryList
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.FString>>(Ptr + 144); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 144); }
    }

    /// <summary>
    /// StructProperty: CameraLocation
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT CameraLocation
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 160); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 160); }
    }

    /// <summary>
    /// StructProperty: CameraDirection
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT CameraDirection
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 172); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 172); }
    }

    /// <summary>
    /// IntProperty: BestGroupIndex
    /// </summary>
    public unsafe int BestGroupIndex
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 184); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 184); }
    }

    /// <summary>
    /// IntProperty: BestActorIndex
    /// </summary>
    public unsafe int BestActorIndex
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 188); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 188); }
    }

    /// <summary>
    /// IntProperty: CachedGroupIndex
    /// </summary>
    public unsafe int CachedGroupIndex
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 192); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 192); }
    }

    /// <summary>
    /// StrProperty: CachedFocusDetail
    /// </summary>
    public unsafe BmSDK.FString CachedFocusDetail
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 196); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 196); }
    }

    /// <summary>
    /// IntProperty: TimeSliceGroupIndex
    /// </summary>
    public unsafe int TimeSliceGroupIndex
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 212); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 212); }
    }

    /// <summary>
    /// FloatProperty: ChapterNineIntelRecurrencePeriod
    /// </summary>
    public unsafe float ChapterNineIntelRecurrencePeriod
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 216); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 216); }
    }

    /// <summary>
    /// ArrayProperty: DiscoveryTargets
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.FString>>> DiscoveryTargets
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.FString>>>>(Ptr + 220); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 220); }
    }

    /// <summary>
    /// ArrayProperty: MissionDialogueArray
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.TArray<BmSDK.FString>> MissionDialogueArray
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.TArray<BmSDK.FString>>>(Ptr + 236); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 236); }
    }

    /// <summary>
    /// ArrayProperty: MissionDialogueArrayQueued
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.FString> MissionDialogueArrayQueued
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.FString>>(Ptr + 252); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 252); }
    }

    /// <summary>
    /// IntProperty: MissionLoadingDlgIndex
    /// </summary>
    public unsafe int MissionLoadingDlgIndex
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 268); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 268); }
    }

    /// <summary>
    /// ByteProperty: CurrentlyActiveSideStory
    /// </summary>
    public unsafe byte CurrentlyActiveSideStory
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 272); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 272); }
    }

    /// <summary>
    /// StrProperty: CurrentlyActiveSideStoryName
    /// </summary>
    public unsafe BmSDK.FString CurrentlyActiveSideStoryName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 276); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 276); }
    }

    /// <summary>
    /// StrProperty: CurrentlyActiveSideStoryMapMarker
    /// </summary>
    public unsafe BmSDK.FString CurrentlyActiveSideStoryMapMarker
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 292); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 292); }
    }

    /// <summary>
    /// BoolProperty: IsInitialised
    /// </summary>
    public unsafe bool IsInitialised
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 308) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 308); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 308); }
    }

    /// <summary>
    /// BoolProperty: ForceOpenWheelPromptAfterReload
    /// </summary>
    public unsafe bool ForceOpenWheelPromptAfterReload
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 308) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 308); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 308); }
    }
}
