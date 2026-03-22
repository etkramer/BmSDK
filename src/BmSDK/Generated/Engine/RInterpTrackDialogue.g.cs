#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Class: RInterpTrackDialogue<br/>
/// (size = 252)
/// (flags = 134226066)
/// </summary>
public partial class RInterpTrackDialogue : BmSDK.Engine.InterpTrackVectorBase, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Engine.RInterpTrackDialogue", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RInterpTrackDialogue() { }

    /// <summary>
    /// Constructs a new RInterpTrackDialogue
    /// </summary>
    public RInterpTrackDialogue(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RInterpTrackDialogue Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RInterpTrackDialogue(nint ptr) : base(ptr) { }

    /// <summary>
    /// ArrayProperty: Dialogues
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.Engine.RInterpTrackDialogue.FDialogueTrackKey> Dialogues
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.RInterpTrackDialogue.FDialogueTrackKey>>(Ptr + 232); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 232); }
    }

    /// <summary>
    /// BoolProperty: bContinueDialogueOnMatineeEnd
    /// </summary>
    public unsafe bool bContinueDialogueOnMatineeEnd
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 244) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 244); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 244); }
    }

    /// <summary>
    /// BoolProperty: bSuppressSubtitles
    /// </summary>
    public unsafe bool bSuppressSubtitles
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 244) & 2) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 244); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 244); }
    }

    /// <summary>
    /// BoolProperty: bSubTitlesOnly
    /// </summary>
    public unsafe bool bSubTitlesOnly
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 244) & 4) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 244); var newMask = value ? (currentMask | 4) : (currentMask & ~4); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 244); }
    }

    /// <summary>
    /// BoolProperty: bTVSubtitles
    /// </summary>
    public unsafe bool bTVSubtitles
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 244) & 8) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 244); var newMask = value ? (currentMask | 8) : (currentMask & ~8); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 244); }
    }

    /// <summary>
    /// BoolProperty: bStopDialogueOnMatineeSkip
    /// </summary>
    public unsafe bool bStopDialogueOnMatineeSkip
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 244) & 16) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 244); var newMask = value ? (currentMask | 16) : (currentMask & ~16); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 244); }
    }

    /// <summary>
    /// BoolProperty: bHighPriorityStream
    /// </summary>
    public unsafe bool bHighPriorityStream
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 244) & 32) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 244); var newMask = value ? (currentMask | 32) : (currentMask & ~32); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 244); }
    }

    /// <summary>
    /// FloatProperty: SubtitleTimeOffset
    /// </summary>
    public unsafe float SubtitleTimeOffset
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 248); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 248); }
    }

    /// <summary>
    /// Struct: FDialogueTrackKey
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 16)]
    public partial record struct FDialogueTrackKey
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
        /// ObjectProperty: Line
        /// </summary>
        public unsafe BmSDK.Engine.RDialogueEvent Line
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RDialogueEvent>(Ptr + 4); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4); }; }
        }

        /// <summary>
        /// FloatProperty: WwiseDuration
        /// </summary>
        public unsafe float WwiseDuration
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 8); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8); }; }
        }

        /// <summary>
        /// FloatProperty: SubtitleDuration
        /// </summary>
        public unsafe float SubtitleDuration
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 12); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 12); }; }
        }
    }
}
