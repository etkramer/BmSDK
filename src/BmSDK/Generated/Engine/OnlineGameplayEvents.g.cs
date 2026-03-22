#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Class: OnlineGameplayEvents<br/>
/// (size = 124)
/// (flags = 134217874)
/// </summary>
public partial class OnlineGameplayEvents : BmSDK.GameObject, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Engine.OnlineGameplayEvents", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal OnlineGameplayEvents() { }

    /// <summary>
    /// Constructs a new OnlineGameplayEvents
    /// </summary>
    public OnlineGameplayEvents(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, OnlineGameplayEvents Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected OnlineGameplayEvents(nint ptr) : base(ptr) { }

    /// <summary>
    /// Struct: FPlayerEvent
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 24)]
    public partial record struct FPlayerEvent
    {
        /// <summary>
        /// FloatProperty: EventTime
        /// </summary>
        public unsafe float EventTime
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// StructProperty: EventLocation
        /// </summary>
        public unsafe System.Numerics.Vector3 EventLocation
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 4); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4); }; }
        }

        /// <summary>
        /// IntProperty: PlayerIndexAndYaw
        /// </summary>
        public unsafe int PlayerIndexAndYaw
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 16); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 16); }; }
        }

        /// <summary>
        /// IntProperty: PlayerPitchAndRoll
        /// </summary>
        public unsafe int PlayerPitchAndRoll
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 20); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 20); }; }
        }
    }

    /// <summary>
    /// Struct: FGameplayEvent
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 8)]
    public partial record struct FGameplayEvent
    {
        /// <summary>
        /// IntProperty: PlayerEventAndTarget
        /// </summary>
        public unsafe int PlayerEventAndTarget
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// IntProperty: EventNameAndDesc
        /// </summary>
        public unsafe int EventNameAndDesc
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4); }; }
        }
    }

    /// <summary>
    /// ArrayProperty: PlayerList
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.Engine.OnlineGameplayEvents.FPlayerInformation> PlayerList
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.OnlineGameplayEvents.FPlayerInformation>>(Ptr + 44); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 44); }
    }

    /// <summary>
    /// ArrayProperty: EventDescList
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.FString> EventDescList
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.FString>>(Ptr + 56); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 56); }
    }

    /// <summary>
    /// ArrayProperty: EventNames
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.FName> EventNames
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.FName>>(Ptr + 68); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 68); }
    }

    /// <summary>
    /// ArrayProperty: GameplayEvents
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.Engine.OnlineGameplayEvents.FGameplayEvent> GameplayEvents
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.OnlineGameplayEvents.FGameplayEvent>>(Ptr + 80); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 80); }
    }

    /// <summary>
    /// ArrayProperty: PlayerEvents
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.Engine.OnlineGameplayEvents.FPlayerEvent> PlayerEvents
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.OnlineGameplayEvents.FPlayerEvent>>(Ptr + 92); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 92); }
    }

    /// <summary>
    /// StrProperty: GameplaySessionStartTime
    /// </summary>
    public unsafe BmSDK.FString GameplaySessionStartTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 104); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 104); }
    }

    /// <summary>
    /// BoolProperty: bGameplaySessionInProgress
    /// </summary>
    public unsafe bool bGameplaySessionInProgress
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 116) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 116); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 116); }
    }

    /// <summary>
    /// StructProperty: GameplaySessionID
    /// </summary>
    public unsafe BmSDK.GameObject.FGuid GameplaySessionID
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.GameObject.FGuid>(Ptr + 120); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 120); }
    }

    /// <summary>
    /// Struct: FPlayerInformation
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 40)]
    public partial record struct FPlayerInformation
    {
        /// <summary>
        /// StrProperty: ControllerName
        /// </summary>
        public unsafe BmSDK.FString ControllerName
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// StrProperty: PlayerName
        /// </summary>
        public unsafe BmSDK.FString PlayerName
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 12); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 12); }; }
        }

        /// <summary>
        /// StructProperty: UniqueId
        /// </summary>
        public unsafe BmSDK.Engine.OnlineSubsystem.FUniqueNetId UniqueId
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.OnlineSubsystem.FUniqueNetId>(Ptr + 24); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 24); }; }
        }

        /// <summary>
        /// BoolProperty: bIsBot
        /// </summary>
        public unsafe bool bIsBot
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 32) & 1) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 32); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 32); }; }
        }

        /// <summary>
        /// IntProperty: LastPlayerEventIdx
        /// </summary>
        public unsafe int LastPlayerEventIdx
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 36); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 36); }; }
        }
    }
}
