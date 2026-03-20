#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Class: InterpTrackFaceFX<br/>
/// (flags = 0)
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
    /// Struct: FFaceFXSoundCueKey
    /// </summary>
    [StructLayout(LayoutKind.Explicit)]
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
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.FaceFXAnimSet>>(Ptr + 180); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 180); }
    }

    /// <summary>
    /// ArrayProperty: FaceFXSeqs
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.Engine.InterpTrackFaceFX.FFaceFXTrackKey> FaceFXSeqs
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.InterpTrackFaceFX.FFaceFXTrackKey>>(Ptr + 196); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 196); }
    }

    /// <summary>
    /// ObjectProperty: CachedActorFXAsset
    /// </summary>
    public unsafe BmSDK.Engine.FaceFXAsset CachedActorFXAsset
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.FaceFXAsset>(Ptr + 212); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 212); }
    }

    /// <summary>
    /// ArrayProperty: FaceFXSoundCueKeys
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.Engine.InterpTrackFaceFX.FFaceFXSoundCueKey> FaceFXSoundCueKeys
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.InterpTrackFaceFX.FFaceFXSoundCueKey>>(Ptr + 220); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 220); }
    }

    /// <summary>
    /// BoolProperty: bAlwaysPlayOnFirstUpdate
    /// </summary>
    public unsafe bool bAlwaysPlayOnFirstUpdate
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 236) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 236); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 236); }
    }

    /// <summary>
    /// Struct: FFaceFXTrackKey
    /// </summary>
    [StructLayout(LayoutKind.Explicit)]
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
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 20); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 20); }; }
        }
    }
}
