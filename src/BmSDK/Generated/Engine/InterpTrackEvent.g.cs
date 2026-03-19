#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Class: InterpTrackEvent<br/>
/// (size = 0)
/// (flags = 0)
/// </summary>
public partial class InterpTrackEvent : BmSDK.Engine.InterpTrack, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Engine.InterpTrackEvent", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal InterpTrackEvent() { }

    /// <summary>
    /// Constructs a new InterpTrackEvent
    /// </summary>
    public InterpTrackEvent(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, InterpTrackEvent Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected InterpTrackEvent(nint ptr) : base(ptr) { }

    /// <summary>
    /// ArrayProperty: EventTrack
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.FString>>>> EventTrack
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.FString>>>>>(Ptr + 180); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 180); }
    }

    /// <summary>
    /// BoolProperty: bFireEventsWhenForwards
    /// </summary>
    public unsafe bool bFireEventsWhenForwards
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 196) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 196); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 196); }
    }

    /// <summary>
    /// BoolProperty: bFireEventsWhenBackwards
    /// </summary>
    public unsafe bool bFireEventsWhenBackwards
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 196) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 196); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 196); }
    }

    /// <summary>
    /// BoolProperty: bFireEventsWhenJumpingForwards
    /// </summary>
    public unsafe bool bFireEventsWhenJumpingForwards
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 196) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 196); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 196); }
    }

    /// <summary>
    /// BoolProperty: bFireEventsWhenJumpingBackwards
    /// </summary>
    public unsafe bool bFireEventsWhenJumpingBackwards
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 196) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 196); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 196); }
    }

    /// <summary>
    /// Struct: FEventTrackKey
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 0)]
    public partial record struct FEventTrackKey
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
        /// NameProperty: EventName
        /// </summary>
        public unsafe BmSDK.FName EventName
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 4); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4); }; }
        }
    }
}
