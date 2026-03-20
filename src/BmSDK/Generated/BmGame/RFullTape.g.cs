#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RFullTape<br/>
/// (flags = 0)
/// </summary>
public partial class RFullTape : BmSDK.GameObject, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RFullTape", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RFullTape() { }

    /// <summary>
    /// Constructs a new RFullTape
    /// </summary>
    public RFullTape(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RFullTape Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RFullTape(nint ptr) : base(ptr) { }

    /// <summary>
    /// ObjectProperty: Conversation
    /// </summary>
    public unsafe BmSDK.Engine.AkDialogueSpeech Conversation
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkDialogueSpeech>(Ptr + 84); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 84); }
    }

    /// <summary>
    /// ObjectProperty: FullTapeLine
    /// </summary>
    public unsafe BmSDK.Engine.AkEvent FullTapeLine
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkEvent>(Ptr + 92); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 92); }
    }

    /// <summary>
    /// BoolProperty: FullTape
    /// </summary>
    public unsafe bool FullTape
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 100) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 100); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 100); }
    }

    /// <summary>
    /// ArrayProperty: ArraySubtitles
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RFullTape.FRArraySubtitleCue> ArraySubtitles
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RFullTape.FRArraySubtitleCue>>(Ptr + 104); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 104); }
    }

    /// <summary>
    /// ArrayProperty: ArrayOfSubs
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RFullTape.FRArrayLocalizedSubtitles> ArrayOfSubs
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RFullTape.FRArrayLocalizedSubtitles>>(Ptr + 120); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 120); }
    }

    /// <summary>
    /// Struct: FRArraySubtitleCue
    /// </summary>
    [StructLayout(LayoutKind.Explicit)]
    public partial record struct FRArraySubtitleCue
    {
        /// <summary>
        /// FloatProperty: Duration
        /// </summary>
        public unsafe float Duration
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// StrProperty: SubtitleCharacterName
        /// </summary>
        public unsafe BmSDK.FString SubtitleCharacterName
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 4); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4); }; }
        }

        /// <summary>
        /// ArrayProperty: Subtitles
        /// </summary>
        public unsafe BmSDK.TArray<BmSDK.Engine.EngineTypes.FSubtitleCue> Subtitles
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.EngineTypes.FSubtitleCue>>(Ptr + 20); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 20); }; }
        }
    }

    /// <summary>
    /// Struct: FRArrayLocalizedSubtitles
    /// </summary>
    [StructLayout(LayoutKind.Explicit)]
    public partial record struct FRArrayLocalizedSubtitles
    {
        /// <summary>
        /// ArrayProperty: SubtitleArray
        /// </summary>
        public unsafe BmSDK.TArray<BmSDK.BmGame.RFullTape.FRLocalizedSubtitles> SubtitleArray
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RFullTape.FRLocalizedSubtitles>>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }
    }

    /// <summary>
    /// Struct: FRLocalizedSubtitles
    /// </summary>
    [StructLayout(LayoutKind.Explicit)]
    public partial record struct FRLocalizedSubtitles
    {
        /// <summary>
        /// StrProperty: Language
        /// </summary>
        public unsafe BmSDK.FString Language
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// ArrayProperty: Subtitles
        /// </summary>
        public unsafe BmSDK.TArray<BmSDK.Engine.EngineTypes.FSubtitleCue> Subtitles
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.EngineTypes.FSubtitleCue>>(Ptr + 16); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 16); }; }
        }
    }
}
