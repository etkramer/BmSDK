#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Class: AppNotificationsBase<br/>
/// (flags = 0)
/// </summary>
public partial class AppNotificationsBase : BmSDK.Engine.PlatformInterfaceBase, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Engine.AppNotificationsBase", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal AppNotificationsBase() { }

    /// <summary>
    /// Constructs a new AppNotificationsBase
    /// </summary>
    public AppNotificationsBase(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, AppNotificationsBase Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected AppNotificationsBase(nint ptr) : base(ptr) { }

    /// <summary>
    /// Function: DebugLogNotification
    /// </summary>
    public unsafe void DebugLogNotification(out BmSDK.Engine.AppNotificationsBase.FNotificationInfo Notification)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "Engine.AppNotificationsBase.DebugLogNotification", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        Notification = BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AppNotificationsBase.FNotificationInfo>(paramsPtr + 0);
        return;
    }

    /// <summary>
    /// Function: OnReceivedRemoteNotification
    /// </summary>
    public unsafe void OnReceivedRemoteNotification(out BmSDK.Engine.AppNotificationsBase.FNotificationInfo Notification, bool bWasAppActive)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "Engine.AppNotificationsBase.OnReceivedRemoteNotification", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bWasAppActive, paramsPtr + 40);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        Notification = BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AppNotificationsBase.FNotificationInfo>(paramsPtr + 0);
        return;
    }

    /// <summary>
    /// Function: OnReceivedLocalNotification
    /// </summary>
    public unsafe void OnReceivedLocalNotification(out BmSDK.Engine.AppNotificationsBase.FNotificationInfo Notification, bool bWasAppActive)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "Engine.AppNotificationsBase.OnReceivedLocalNotification", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bWasAppActive, paramsPtr + 40);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        Notification = BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AppNotificationsBase.FNotificationInfo>(paramsPtr + 0);
        return;
    }

    /// <summary>
    /// Function: CancelAllScheduledLocalNotifications
    /// </summary>
    public unsafe void CancelAllScheduledLocalNotifications()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "Engine.AppNotificationsBase.CancelAllScheduledLocalNotifications", true);
        byte* paramsPtr = stackalloc byte[64];
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
    /// Function: ScheduleLocalNotification
    /// </summary>
    public unsafe void ScheduleLocalNotification(out BmSDK.Engine.AppNotificationsBase.FNotificationInfo Notification, int StartOffsetSeconds)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "Engine.AppNotificationsBase.ScheduleLocalNotification", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(StartOffsetSeconds, paramsPtr + 40);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        Notification = BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AppNotificationsBase.FNotificationInfo>(paramsPtr + 0);
        return;
    }

    /// <summary>
    /// Function: WasLaunchedViaNotification
    /// </summary>
    public unsafe bool WasLaunchedViaNotification()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "Engine.AppNotificationsBase.WasLaunchedViaNotification", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: Init
    /// </summary>
    public unsafe void Init()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "Engine.AppNotificationsBase.Init", true);
        byte* paramsPtr = stackalloc byte[64];
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
    /// StructProperty: AppLaunchNotification
    /// </summary>
    public unsafe BmSDK.Engine.AppNotificationsBase.FLaunchNotificationInfo AppLaunchNotification
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AppNotificationsBase.FLaunchNotificationInfo>(Ptr + 116); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 116); }
    }

    /// <summary>
    /// DelegateProperty: __OnReceivedLocalNotification__Delegate
    /// </summary>
    public unsafe System.IntPtr __OnReceivedLocalNotification__Delegate
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.IntPtr>(Ptr + 160); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 160); }
    }

    /// <summary>
    /// DelegateProperty: __OnReceivedRemoteNotification__Delegate
    /// </summary>
    public unsafe System.IntPtr __OnReceivedRemoteNotification__Delegate
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.IntPtr>(Ptr + 176); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 176); }
    }

    /// <summary>
    /// Struct: FLaunchNotificationInfo
    /// </summary>
    [StructLayout(LayoutKind.Explicit)]
    public partial record struct FLaunchNotificationInfo
    {
        /// <summary>
        /// BoolProperty: bWasLaunchedViaNotification
        /// </summary>
        public unsafe bool bWasLaunchedViaNotification
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 0) & 1) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 0); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 0); }; }
        }

        /// <summary>
        /// StructProperty: Notification
        /// </summary>
        public unsafe BmSDK.Engine.AppNotificationsBase.FNotificationInfo Notification
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AppNotificationsBase.FNotificationInfo>(Ptr + 4); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4); }; }
        }
    }

    /// <summary>
    /// Struct: FNotificationInfo
    /// </summary>
    [StructLayout(LayoutKind.Explicit)]
    public partial record struct FNotificationInfo
    {
        /// <summary>
        /// BoolProperty: bIsLocal
        /// </summary>
        public unsafe bool bIsLocal
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 0) & 1) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 0); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 0); }; }
        }

        /// <summary>
        /// StrProperty: MessageBody
        /// </summary>
        public unsafe BmSDK.FString MessageBody
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 4); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4); }; }
        }

        /// <summary>
        /// IntProperty: BadgeNumber
        /// </summary>
        public unsafe int BadgeNumber
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 20); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 20); }; }
        }

        /// <summary>
        /// ArrayProperty: MessageInfo
        /// </summary>
        public unsafe BmSDK.TArray<BmSDK.Engine.AppNotificationsBase.FNotificationMessageInfo> MessageInfo
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.AppNotificationsBase.FNotificationMessageInfo>>(Ptr + 24); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 24); }; }
        }
    }

    /// <summary>
    /// Struct: FNotificationMessageInfo
    /// </summary>
    [StructLayout(LayoutKind.Explicit)]
    public partial record struct FNotificationMessageInfo
    {
        /// <summary>
        /// StrProperty: Key
        /// </summary>
        public unsafe BmSDK.FString Key
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// StrProperty: Value
        /// </summary>
        public unsafe BmSDK.FString Value
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 16); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 16); }; }
        }
    }
}
