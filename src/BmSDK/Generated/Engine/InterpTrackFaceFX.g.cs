#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Class: InterpTrackFaceFX<br/>
/// (size = 168)
/// (flags = 134226066)
/// </summary>
public partial class InterpTrackFaceFX : BmSDK.Engine.InterpTrack, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Engine.InterpTrackFaceFX", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal InterpTrackFaceFX() { }

    /// <summary>
    /// Constructs a new InterpTrackFaceFX
    /// </summary>
    public InterpTrackFaceFX(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, InterpTrackFaceFX Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected InterpTrackFaceFX(nint ptr) : base(ptr) { }

    /// <summary>
    /// Struct: FFaceFXDialogueEventKey
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 4)]
    public partial record struct FFaceFXDialogueEventKey
    {
        /// <summary>
        /// ObjectProperty: FaceFXDialogueEvent
        /// </summary>
        public unsafe BmSDK.Engine.RDialogueEvent FaceFXDialogueEvent
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RDialogueEvent>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }
    }

    /// <summary>
    /// Struct: FFaceFXSoundCueKey
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 4)]
    public partial record struct FFaceFXSoundCueKey
    {
        /// <summary>
        /// ObjectProperty: FaceFXSoundCue
        /// </summary>
        public unsafe BmSDK.Engine.SoundCue FaceFXSoundCue
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.SoundCue>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }
    }

    /// <summary>
    /// ArrayProperty: FaceFXAnimSets
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.Engine.FaceFXAnimSet> FaceFXAnimSets
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.FaceFXAnimSet>>(Ptr + 112); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 112); }
    }

    /// <summary>
    /// ArrayProperty: FaceFXSeqs
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.Engine.InterpTrackFaceFX.FFaceFXTrackKey> FaceFXSeqs
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.InterpTrackFaceFX.FFaceFXTrackKey>>(Ptr + 124); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 124); }
    }

    /// <summary>
    /// ObjectProperty: CachedActorFXAsset
    /// </summary>
    public unsafe BmSDK.Engine.FaceFXAsset CachedActorFXAsset
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.FaceFXAsset>(Ptr + 136); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 136); }
    }

    /// <summary>
    /// ArrayProperty: FaceFXSoundCueKeys
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.Engine.InterpTrackFaceFX.FFaceFXSoundCueKey> FaceFXSoundCueKeys
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.InterpTrackFaceFX.FFaceFXSoundCueKey>>(Ptr + 140); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 140); }
    }

    /// <summary>
    /// ArrayProperty: FaceFXDialogueEventKeys
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.Engine.InterpTrackFaceFX.FFaceFXDialogueEventKey> FaceFXDialogueEventKeys
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.InterpTrackFaceFX.FFaceFXDialogueEventKey>>(Ptr + 152); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 152); }
    }

    /// <summary>
    /// BoolProperty: bAlwaysPlayOnFirstUpdate
    /// </summary>
    public unsafe bool bAlwaysPlayOnFirstUpdate
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 164) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 164); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 164); }
    }

    /// <summary>
    /// Struct: FFaceFXTrackKey
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 28)]
    public partial record struct FFaceFXTrackKey
    {
        /// <summary>
        /// FloatProperty: StartTime
        /// </summary>
        public unsafe float StartTime
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// StrProperty: FaceFXGroupName
        /// </summary>
        public unsafe BmSDK.FString FaceFXGroupName
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 4); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4); }; }
        }

        /// <summary>
        /// StrProperty: FaceFXSeqName
        /// </summary>
        public unsafe BmSDK.FString FaceFXSeqName
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 16); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 16); }; }
        }
    }
}
