#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.AkAudio;

/// <summary>
/// Class: InterpTrackAkEvent<br/>
/// (size = 0)
/// (flags = 0)
/// </summary>
public partial class InterpTrackAkEvent : BmSDK.Engine.InterpTrack, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "AkAudio.InterpTrackAkEvent", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal InterpTrackAkEvent() { }

    /// <summary>
    /// Constructs a new InterpTrackAkEvent
    /// </summary>
    public InterpTrackAkEvent(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, InterpTrackAkEvent Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected InterpTrackAkEvent(nint ptr) : base(ptr) { }

    /// <summary>
    /// ArrayProperty: AkEvents
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.FString>>>> AkEvents
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.FString>>>>>(Ptr + 180); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 180); }
    }

    /// <summary>
    /// BoolProperty: FireEventsWhenForwards
    /// </summary>
    public unsafe bool FireEventsWhenForwards
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 196) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 196); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 196); }
    }

    /// <summary>
    /// BoolProperty: FireEventsWhenBackwards
    /// </summary>
    public unsafe bool FireEventsWhenBackwards
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 196) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 196); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 196); }
    }

    /// <summary>
    /// BoolProperty: StopSoundOnMatineeEnd
    /// </summary>
    public unsafe bool StopSoundOnMatineeEnd
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 196) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 196); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 196); }
    }

    /// <summary>
    /// BoolProperty: AudioShouldStopOnSkip
    /// </summary>
    public unsafe bool AudioShouldStopOnSkip
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 196) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 196); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 196); }
    }

    /// <summary>
    /// BoolProperty: DoNotPlayIfGroupActorIsNone
    /// </summary>
    public unsafe bool DoNotPlayIfGroupActorIsNone
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 196) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 196); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 196); }
    }

    /// <summary>
    /// NameProperty: OptionalBoneToFollow
    /// </summary>
    public unsafe BmSDK.FName OptionalBoneToFollow
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 200); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 200); }
    }

    /// <summary>
    /// Struct: FAkEventTrackKey
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 0)]
    public partial record struct FAkEventTrackKey
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
        /// ObjectProperty: Event
        /// </summary>
        public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT Event
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 4); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4); }; }
        }

        /// <summary>
        /// FloatProperty: WwiseDuration
        /// </summary>
        public unsafe float WwiseDuration
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 12); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 12); }; }
        }
    }
}
