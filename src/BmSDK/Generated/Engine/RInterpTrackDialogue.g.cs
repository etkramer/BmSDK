#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Class: RInterpTrackDialogue<br/>
/// (size = 0)
/// (flags = 0)
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
    public unsafe BmSDK.TArray<BmSDK.Engine.InterpTrackVectorBase.VectorTrack> Dialogues
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.InterpTrackVectorBase.VectorTrack>>(Ptr + 304); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 304); }
    }

    /// <summary>
    /// BoolProperty: bContinueDialogueOnMatineeEnd
    /// </summary>
    public unsafe bool bContinueDialogueOnMatineeEnd
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 320) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 320); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 320); }
    }

    /// <summary>
    /// BoolProperty: bStopDialogueOnSkip
    /// </summary>
    public unsafe bool bStopDialogueOnSkip
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 320) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 320); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 320); }
    }

    /// <summary>
    /// BoolProperty: NeedsWarmupFixup
    /// </summary>
    public unsafe bool NeedsWarmupFixup
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 320) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 320); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 320); }
    }

    /// <summary>
    /// StructProperty: SpeechOptions
    /// </summary>
    public unsafe BmSDK.Engine.InterpTrackVectorBase.VectorTrack SpeechOptions
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.InterpTrackVectorBase.VectorTrack>(Ptr + 324); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 324); }
    }

    /// <summary>
    /// Struct: FDialogueTrackKey
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 0)]
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
        public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT Line
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 4); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4); }; }
        }
    }
}
