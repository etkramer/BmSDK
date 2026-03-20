#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Class: InterpTrackVisibility<br/>
/// (size = 200)
/// (flags = 134226066)
/// </summary>
public partial class InterpTrackVisibility : BmSDK.Engine.InterpTrack, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Engine.InterpTrackVisibility", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal InterpTrackVisibility() { }

    /// <summary>
    /// Constructs a new InterpTrackVisibility
    /// </summary>
    public InterpTrackVisibility(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, InterpTrackVisibility Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected InterpTrackVisibility(nint ptr) : base(ptr) { }

    /// <summary>
    /// ArrayProperty: VisibilityTrack
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.Engine.InterpTrackVisibility.FVisibilityTrackKey> VisibilityTrack
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.InterpTrackVisibility.FVisibilityTrackKey>>(Ptr + 180); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 180); }
    }

    /// <summary>
    /// BoolProperty: bFireEventsWhenForwards
    /// </summary>
    public unsafe bool bFireEventsWhenForwards
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 196) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 196); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 196); }
    }

    /// <summary>
    /// BoolProperty: bFireEventsWhenBackwards
    /// </summary>
    public unsafe bool bFireEventsWhenBackwards
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 196) & 2) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 196); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 196); }
    }

    /// <summary>
    /// BoolProperty: bFireEventsWhenJumpingForwards
    /// </summary>
    public unsafe bool bFireEventsWhenJumpingForwards
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 196) & 4) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 196); var newMask = value ? (currentMask | 4) : (currentMask & ~4); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 196); }
    }

    /// <summary>
    /// Struct: FVisibilityTrackKey
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 6)]
    public partial record struct FVisibilityTrackKey
    {
        /// <summary>
        /// FloatProperty: Time
        /// </summary>
        public unsafe float Time
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// ByteProperty: Action
        /// </summary>
        public unsafe BmSDK.Engine.InterpTrackVisibility.EVisibilityTrackAction Action
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.InterpTrackVisibility.EVisibilityTrackAction>(Ptr + 4); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4); }; }
        }

        /// <summary>
        /// ByteProperty: ActiveCondition
        /// </summary>
        public unsafe BmSDK.Engine.InterpTrackVisibility.EVisibilityTrackCondition ActiveCondition
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.InterpTrackVisibility.EVisibilityTrackCondition>(Ptr + 5); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5); }; }
        }
    }

    /// <summary>
    /// Enum: EVisibilityTrackCondition
    /// </summary>
    public enum EVisibilityTrackCondition
    {
        EVTC_Always = 0,
        EVTC_GoreEnabled = 1,
        EVTC_GoreDisabled = 2,
        EVTC_MAX = 3,
    }

    /// <summary>
    /// Enum: EVisibilityTrackAction
    /// </summary>
    public enum EVisibilityTrackAction
    {
        EVTA_Hide = 0,
        EVTA_Show = 1,
        EVTA_Toggle = 2,
        EVTA_MAX = 3,
    }
}
