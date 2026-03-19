#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Class: GameEngine<br/>
/// (size = 0)
/// (flags = 0)
/// </summary>
public partial class GameEngine : BmSDK.Engine._Engine, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Engine.GameEngine", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal GameEngine() { }

    /// <summary>
    /// Constructs a new GameEngine
    /// </summary>
    public GameEngine(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, GameEngine Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected GameEngine(nint ptr) : base(ptr) { }

    /// <summary>
    /// ObjectProperty: GPendingLevel
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT GPendingLevel
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 2648); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2648); }
    }

    /// <summary>
    /// ObjectProperty: OnlineSubsystem
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT OnlineSubsystem
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 2656); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2656); }
    }

    /// <summary>
    /// ObjectProperty: DLCEnumerator
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT DLCEnumerator
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 2664); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2664); }
    }

    /// <summary>
    /// ObjectProperty: DLCManager
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT DLCManager
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 2672); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2672); }
    }

    /// <summary>
    /// ObjectProperty: LocHelperSystem
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT LocHelperSystem
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 2680); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2680); }
    }

    /// <summary>
    /// StrProperty: PendingLevelPlayerControllerClassName
    /// </summary>
    public unsafe BmSDK.FString PendingLevelPlayerControllerClassName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 2688); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2688); }
    }

    /// <summary>
    /// StructProperty: LastURL
    /// </summary>
    public unsafe BmSDK.Engine.GameEngine.LastRemoteURL LastURL
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.GameEngine.LastRemoteURL>(Ptr + 2704); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2704); }
    }

    /// <summary>
    /// StructProperty: LastRemoteURL
    /// </summary>
    public unsafe BmSDK.Engine.GameEngine.ServerActors LastRemoteURL
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.GameEngine.ServerActors>(Ptr + 2792); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2792); }
    }

    /// <summary>
    /// ArrayProperty: ServerActors
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.FString> ServerActors
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.FString>>(Ptr + 2880); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2880); }
    }

    /// <summary>
    /// StrProperty: TravelURL
    /// </summary>
    public unsafe BmSDK.FString TravelURL
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 2896); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2896); }
    }

    /// <summary>
    /// ByteProperty: TravelType
    /// </summary>
    public unsafe byte TravelType
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 2912); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2912); }
    }

    /// <summary>
    /// BoolProperty: bWorldWasLoadedThisTick
    /// </summary>
    public unsafe bool bWorldWasLoadedThisTick
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2916) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2916); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2916); }
    }

    /// <summary>
    /// BoolProperty: bCheckForMovieCapture
    /// </summary>
    public unsafe bool bCheckForMovieCapture
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2916) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2916); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2916); }
    }

    /// <summary>
    /// BoolProperty: bTriggerPostLoadMap
    /// </summary>
    public unsafe bool bTriggerPostLoadMap
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2916) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2916); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2916); }
    }

    /// <summary>
    /// BoolProperty: bStartedLoadMapMovie
    /// </summary>
    public unsafe bool bStartedLoadMapMovie
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2916) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2916); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2916); }
    }

    /// <summary>
    /// BoolProperty: bShouldCommitPendingMapChange
    /// </summary>
    public unsafe bool bShouldCommitPendingMapChange
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2916) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2916); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2916); }
    }

    /// <summary>
    /// BoolProperty: bClearAnimSetLinkupCachesOnLoadMap
    /// </summary>
    public unsafe bool bClearAnimSetLinkupCachesOnLoadMap
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2916) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2916); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2916); }
    }

    /// <summary>
    /// BoolProperty: bEnableSecondaryDisplay
    /// </summary>
    public unsafe bool bEnableSecondaryDisplay
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2916) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2916); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2916); }
    }

    /// <summary>
    /// BoolProperty: bEnableSecondaryViewport
    /// </summary>
    public unsafe bool bEnableSecondaryViewport
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2916) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2916); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2916); }
    }

    /// <summary>
    /// StrProperty: DownloadableContentEnumeratorClassName
    /// </summary>
    public unsafe BmSDK.FString DownloadableContentEnumeratorClassName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 2920); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2920); }
    }

    /// <summary>
    /// StrProperty: DownloadableContentManagerClassName
    /// </summary>
    public unsafe BmSDK.FString DownloadableContentManagerClassName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 2936); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2936); }
    }

    /// <summary>
    /// StrProperty: LocHelperSystemClassName
    /// </summary>
    public unsafe BmSDK.FString LocHelperSystemClassName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 2952); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2952); }
    }

    /// <summary>
    /// ArrayProperty: LevelsToLoadForPendingMapChange
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.TArray<BmSDK.FString>> LevelsToLoadForPendingMapChange
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.TArray<BmSDK.FString>>>(Ptr + 2968); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2968); }
    }

    /// <summary>
    /// ArrayProperty: LoadedLevelsForPendingMapChange
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.FString> LoadedLevelsForPendingMapChange
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.FString>>(Ptr + 2984); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2984); }
    }

    /// <summary>
    /// StrProperty: PendingMapChangeFailureDescription
    /// </summary>
    public unsafe BmSDK.FString PendingMapChangeFailureDescription
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 3000); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3000); }
    }

    /// <summary>
    /// FloatProperty: MaxDeltaTime
    /// </summary>
    public unsafe float MaxDeltaTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 3016); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3016); }
    }

    /// <summary>
    /// StrProperty: SecondaryViewportClientClassName
    /// </summary>
    public unsafe BmSDK.FString SecondaryViewportClientClassName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 3020); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3020); }
    }

    /// <summary>
    /// ArrayProperty: SecondaryViewportClients
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.FString>>>>>>> SecondaryViewportClients
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.FString>>>>>>>>(Ptr + 3036); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3036); }
    }

    /// <summary>
    /// ArrayProperty: SecondaryViewportFrames
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.FString>>>>>> SecondaryViewportFrames
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.FString>>>>>>>(Ptr + 3052); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3052); }
    }

    /// <summary>
    /// ArrayProperty: PendingLevelStreamingStatusUpdates
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.FString>>>>> PendingLevelStreamingStatusUpdates
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.FString>>>>>>(Ptr + 3068); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3068); }
    }

    /// <summary>
    /// ArrayProperty: ObjectReferencers
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.FString>>>> ObjectReferencers
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.FString>>>>>(Ptr + 3084); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3084); }
    }

    /// <summary>
    /// ArrayProperty: PackagesToFullyLoad
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.FString>>> PackagesToFullyLoad
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.FString>>>>(Ptr + 3100); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3100); }
    }

    /// <summary>
    /// ArrayProperty: NamedNetDrivers
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.TArray<BmSDK.FString>> NamedNetDrivers
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.TArray<BmSDK.FString>>>(Ptr + 3116); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3116); }
    }

    /// <summary>
    /// ArrayProperty: AnimTags
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.FString> AnimTags
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.FString>>(Ptr + 3132); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3132); }
    }

    /// <summary>
    /// Struct: FURL
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 0)]
    public partial record struct FURL
    {
        /// <summary>
        /// StrProperty: Protocol
        /// </summary>
        public unsafe BmSDK.FString Protocol
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// StrProperty: Host
        /// </summary>
        public unsafe BmSDK.FString Host
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 16); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 16); }; }
        }

        /// <summary>
        /// IntProperty: Port
        /// </summary>
        public unsafe int Port
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 32); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 32); }; }
        }

        /// <summary>
        /// StrProperty: Map
        /// </summary>
        public unsafe BmSDK.FString Map
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 36); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 36); }; }
        }

        /// <summary>
        /// ArrayProperty: Op
        /// </summary>
        public unsafe BmSDK.TArray<BmSDK.FString> Op
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.FString>>(Ptr + 52); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 52); }; }
        }

        /// <summary>
        /// StrProperty: Portal
        /// </summary>
        public unsafe BmSDK.FString Portal
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 68); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 68); }; }
        }

        /// <summary>
        /// IntProperty: Valid
        /// </summary>
        public unsafe int Valid
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 84); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 84); }; }
        }
    }
}
