#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RHudObjectivesContainer<br/>
/// (size = 120)
/// (flags = 0)
/// </summary>
public partial class RHudObjectivesContainer : BmSDK.GameObject, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RHudObjectivesContainer", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RHudObjectivesContainer() { }

    /// <summary>
    /// Constructs a new RHudObjectivesContainer
    /// </summary>
    public RHudObjectivesContainer(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RHudObjectivesContainer Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RHudObjectivesContainer(nint ptr) : base(ptr) { }

    /// <summary>
    /// Function: FlushPendingObjectiveMessage
    /// </summary>
    public unsafe void FlushPendingObjectiveMessage(BmSDK.FString Title)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RHudObjectivesContainer.FlushPendingObjectiveMessage", true);
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Title, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: QueueObjectiveMessageCustomIcon
    /// </summary>
    public unsafe void QueueObjectiveMessageCustomIcon(float Time, BmSDK.FString Title, BmSDK.FString Desc, BmSDK.FString OrgDesc, BmSDK.FString CustomIconName, bool bForceShowMap, BmSDK.FString BackPrompt, bool bNoDuplicates, bool bPulseCompassIndicator, BmSDK.FString MostWantedPipeSeparatedArray = default)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RHudObjectivesContainer.QueueObjectiveMessageCustomIcon", true);
        byte* paramsPtr = stackalloc byte[208];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Time, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Title, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Desc, paramsPtr + 20);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(OrgDesc, paramsPtr + 36);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CustomIconName, paramsPtr + 52);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bForceShowMap, paramsPtr + 68);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(BackPrompt, paramsPtr + 72);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bNoDuplicates, paramsPtr + 88);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bPulseCompassIndicator, paramsPtr + 92);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(MostWantedPipeSeparatedArray, paramsPtr + 96);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: QueueObjectiveMessage
    /// </summary>
    public unsafe void QueueObjectiveMessage(float Time, BmSDK.FString Title, BmSDK.FString Desc, BmSDK.FString OrgDesc, int ArrowType, bool bForceShowMap, BmSDK.FString BackPrompt, bool bNoDuplicates, bool bPulseCompassIndicator)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RHudObjectivesContainer.QueueObjectiveMessage", true);
        byte* paramsPtr = stackalloc byte[180];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Time, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Title, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Desc, paramsPtr + 20);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(OrgDesc, paramsPtr + 36);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ArrowType, paramsPtr + 52);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bForceShowMap, paramsPtr + 56);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(BackPrompt, paramsPtr + 60);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bNoDuplicates, paramsPtr + 76);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bPulseCompassIndicator, paramsPtr + 80);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// ArrayProperty: QueuedObjectivesArray
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RHudObjectivesContainer.FQueuedObjectives> QueuedObjectivesArray
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RHudObjectivesContainer.FQueuedObjectives>>(Ptr + 84); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 84); }
    }

    /// <summary>
    /// ArrayProperty: PendingObjectivesToFlush
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.FString> PendingObjectivesToFlush
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.FString>>(Ptr + 100); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 100); }
    }

    /// <summary>
    /// BoolProperty: bAnyObjectiveFunctionsQueued
    /// </summary>
    public unsafe bool bAnyObjectiveFunctionsQueued
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 116) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 116); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 116); }
    }

    /// <summary>
    /// Struct: FQueuedObjectives
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 96)]
    public partial record struct FQueuedObjectives
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
        /// StrProperty: Title
        /// </summary>
        public unsafe BmSDK.FString Title
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 4); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4); }; }
        }

        /// <summary>
        /// StrProperty: Desc
        /// </summary>
        public unsafe BmSDK.FString Desc
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 20); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 20); }; }
        }

        /// <summary>
        /// StrProperty: OrgDesc
        /// </summary>
        public unsafe BmSDK.FString OrgDesc
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 36); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 36); }; }
        }

        /// <summary>
        /// IntProperty: ArrowType
        /// </summary>
        public unsafe int ArrowType
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 52); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 52); }; }
        }

        /// <summary>
        /// BoolProperty: bForceShowMap
        /// </summary>
        public unsafe bool bForceShowMap
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 56) & 1) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 56); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 56); }; }
        }

        /// <summary>
        /// StrProperty: BackPrompt
        /// </summary>
        public unsafe BmSDK.FString BackPrompt
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 60); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 60); }; }
        }

        /// <summary>
        /// BoolProperty: bNoDuplicates
        /// </summary>
        public unsafe bool bNoDuplicates
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 76) & 1) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 76); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 76); }; }
        }

        /// <summary>
        /// BoolProperty: bPulseCompassIndicator
        /// </summary>
        public unsafe bool bPulseCompassIndicator
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 76) & 2) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 76); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 76); }; }
        }

        /// <summary>
        /// StrProperty: MostWantedPipeSeparatedArray
        /// </summary>
        public unsafe BmSDK.FString MostWantedPipeSeparatedArray
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 80); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 80); }; }
        }
    }
}
