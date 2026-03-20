#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RAnnounceAAITannoyRunner<br/>
/// (size = 168)
/// (flags = 18)
/// </summary>
public partial class RAnnounceAAITannoyRunner : BmSDK.GameObject, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RAnnounceAAITannoyRunner", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RAnnounceAAITannoyRunner() { }

    /// <summary>
    /// Constructs a new RAnnounceAAITannoyRunner
    /// </summary>
    public RAnnounceAAITannoyRunner(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RAnnounceAAITannoyRunner Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RAnnounceAAITannoyRunner(nint ptr) : base(ptr) { }

    /// <summary>
    /// Function: FlushQueue
    /// </summary>
    public unsafe virtual void FlushQueue()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RAnnounceAAITannoyRunner.FlushQueue", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: TryComboUpWithMines
    /// </summary>
    public unsafe virtual bool TryComboUpWithMines()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RAnnounceAAITannoyRunner.TryComboUpWithMines", true);
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: Update
    /// </summary>
    public unsafe virtual void Update(float DeltaTime)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RAnnounceAAITannoyRunner.Update", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DeltaTime, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Struct: FAnnouncementInfo
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 28)]
    public partial record struct FAnnouncementInfo
    {
        /// <summary>
        /// NameProperty: FlagVal
        /// </summary>
        public unsafe BmSDK.FName FlagVal
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// ArrayProperty: Type
        /// </summary>
        public unsafe BmSDK.TArray<BmSDK.BmGame.RAnnounceAAITannoyRunner.AAIResponseType> Type
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RAnnounceAAITannoyRunner.AAIResponseType>>(Ptr + 8); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8); }; }
        }

        /// <summary>
        /// BoolProperty: bPlayedDialogue
        /// </summary>
        public unsafe bool bPlayedDialogue
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 24) & 1) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 24); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 24); }; }
        }
    }

    /// <summary>
    /// Enum: AAIResponseType
    /// </summary>
    public enum AAIResponseType
    {
        AAIRT_Silent = 0,
        AAIRT_Ledge = 1,
        AAIRT_VeryWeakWall = 2,
        AAIRT_Tunnel = 3,
        AAIRT_Grate = 4,
        AAIRT_Glide = 5,
        AAIRT_Drop = 6,
        AAIRT_Inverted = 7,
        AAIRT_PlaceSentry = 8,
        AAIRT_PlaceMine = 9,
        AAIRT_DisableVoiceSynth = 10,
        AAIRT_ClockTowerSpecial = 11,
        AAIRT_MAX = 12,
    }

    /// <summary>
    /// ObjectProperty: Tannoy
    /// </summary>
    public unsafe BmSDK.BmGame.RJokerTannoy Tannoy
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RJokerTannoy>(Ptr + 84); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 84); }
    }

    /// <summary>
    /// ObjectProperty: OwningCasAEC
    /// </summary>
    public unsafe BmSDK.BmGame.RAEC_Casualty OwningCasAEC
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RAEC_Casualty>(Ptr + 92); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 92); }
    }

    /// <summary>
    /// ArrayProperty: PendingAnnouncementList
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RAnnounceAAITannoyRunner.FAnnouncementInfo> PendingAnnouncementList
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RAnnounceAAITannoyRunner.FAnnouncementInfo>>(Ptr + 100); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 100); }
    }

    /// <summary>
    /// StructProperty: CurrentAnnouncement
    /// </summary>
    public unsafe BmSDK.BmGame.RAnnounceAAITannoyRunner.FAnnouncementInfo CurrentAnnouncement
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RAnnounceAAITannoyRunner.FAnnouncementInfo>(Ptr + 116); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 116); }
    }

    /// <summary>
    /// ArrayProperty: QueuedResponseList
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RAnnounceAAITannoyRunner.FAnnouncementInfo> QueuedResponseList
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RAnnounceAAITannoyRunner.FAnnouncementInfo>>(Ptr + 144); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 144); }
    }

    /// <summary>
    /// BoolProperty: bPlayedLine
    /// </summary>
    public unsafe bool bPlayedLine
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 160) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 160); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 160); }
    }

    /// <summary>
    /// FloatProperty: WaitTimer
    /// </summary>
    public unsafe float WaitTimer
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 164); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 164); }
    }
}
