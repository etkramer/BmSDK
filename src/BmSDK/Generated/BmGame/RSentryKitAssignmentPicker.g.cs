#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RSentryKitAssignmentPicker<br/>
/// (size = 172)
/// (flags = 8388626)
/// </summary>
public partial class RSentryKitAssignmentPicker : BmSDK.BmGame.RGroupAssignmentPicker, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RSentryKitAssignmentPicker", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RSentryKitAssignmentPicker() { }

    /// <summary>
    /// Constructs a new RSentryKitAssignmentPicker
    /// </summary>
    public RSentryKitAssignmentPicker(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RSentryKitAssignmentPicker Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RSentryKitAssignmentPicker(nint ptr) : base(ptr) { }

    /// <summary>
    /// Function: InitGoalDataInstance
    /// </summary>
    public unsafe virtual BmSDK.BmGame.RMultiDestGoalData InitGoalDataInstance()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RSentryKitAssignmentPicker.InitGoalDataInstance", true);
        byte* paramsPtr = stackalloc byte[20];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RMultiDestGoalData>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: BuildThugSearch
    /// </summary>
    public unsafe virtual void BuildThugSearch()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RSentryKitAssignmentPicker.BuildThugSearch", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: Update
    /// </summary>
    public unsafe override bool Update()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RSentryKitAssignmentPicker.Update", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: ClearAllSearch
    /// </summary>
    public unsafe virtual void ClearAllSearch()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RSentryKitAssignmentPicker.ClearAllSearch", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: Abort
    /// </summary>
    public unsafe virtual void Abort()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RSentryKitAssignmentPicker.Abort", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: Init
    /// </summary>
    public unsafe virtual void Init(BmSDK.BmGame.RBMRoomAIState NewRoomState, BmSDK.BmGame.RSentryGunPlacementPoint NewTargetPoint, System.IntPtr NewSentryKitAssignmentFound, System.IntPtr NewSentryKitAssignmentFailed)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RSentryKitAssignmentPicker.Init", true);
        byte* paramsPtr = stackalloc byte[48];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewRoomState, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewTargetPoint, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewSentryKitAssignmentFound, paramsPtr + 16);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewSentryKitAssignmentFailed, paramsPtr + 32);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: SentryKitAssignmentFailed
    /// </summary>
    public unsafe virtual void SentryKitAssignmentFailed(BmSDK.BmGame.RSentryKitAssignmentPicker SKAP)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RSentryKitAssignmentPicker.SentryKitAssignmentFailed", true);
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SKAP, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: SentryKitAssignmentFound
    /// </summary>
    public unsafe virtual void SentryKitAssignmentFound(BmSDK.BmGame.RSentryKitAssignmentPicker SKAP, BmSDK.BmGame.RLootSourceBase ChosenKit)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RSentryKitAssignmentPicker.SentryKitAssignmentFound", true);
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SKAP, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ChosenKit, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Struct: FMultiDestPathFindInfo
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 16)]
    public partial record struct FMultiDestPathFindInfo
    {
        /// <summary>
        /// ObjectProperty: Handle
        /// </summary>
        public unsafe BmSDK.BmGame.RNavigationHandle Handle
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RNavigationHandle>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// ObjectProperty: GoalData
        /// </summary>
        public unsafe BmSDK.BmGame.RMultiDestGoalData GoalData
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RMultiDestGoalData>(Ptr + 8); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8); }; }
        }
    }

    /// <summary>
    /// ComponentProperty: RoomState
    /// </summary>
    public unsafe BmSDK.BmGame.RBMRoomAIState RoomState
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RBMRoomAIState>(Ptr + 92); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 92); }
    }

    /// <summary>
    /// ObjectProperty: TargetPoint
    /// </summary>
    public unsafe BmSDK.BmGame.RSentryGunPlacementPoint TargetPoint
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSentryGunPlacementPoint>(Ptr + 100); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 100); }
    }

    /// <summary>
    /// ArrayProperty: SentryKitList
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RLootSourceBase> SentryKitList
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RLootSourceBase>>(Ptr + 108); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 108); }
    }

    /// <summary>
    /// ArrayProperty: DestSearch
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RSentryKitAssignmentPicker.FMultiDestPathFindInfo> DestSearch
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RSentryKitAssignmentPicker.FMultiDestPathFindInfo>>(Ptr + 124); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 124); }
    }

    /// <summary>
    /// DelegateProperty: __SentryKitAssignmentFound__Delegate
    /// </summary>
    public unsafe System.IntPtr __SentryKitAssignmentFound__Delegate
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.IntPtr>(Ptr + 140); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 140); }
    }

    /// <summary>
    /// DelegateProperty: __SentryKitAssignmentFailed__Delegate
    /// </summary>
    public unsafe System.IntPtr __SentryKitAssignmentFailed__Delegate
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.IntPtr>(Ptr + 156); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 156); }
    }
}
