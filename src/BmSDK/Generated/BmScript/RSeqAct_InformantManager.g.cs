#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmScript;

/// <summary>
/// Class: RSeqAct_InformantManager<br/>
/// (size = 2728)
/// (flags = 8210)
/// </summary>
public partial class RSeqAct_InformantManager : BmSDK.Engine.SeqAct_Latent, BmSDK.BmGame.RHUDInterface, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmScript.RSeqAct_InformantManager", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RSeqAct_InformantManager() { }

    /// <summary>
    /// Constructs a new RSeqAct_InformantManager
    /// </summary>
    public RSeqAct_InformantManager(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RSeqAct_InformantManager Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RSeqAct_InformantManager(nint ptr) : base(ptr) { }

    /// <summary>
    /// Function: GetObjClassVersion
    /// </summary>
    public unsafe static int GetObjClassVersion()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RSeqAct_InformantManager.GetObjClassVersion", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(StaticClass().DefaultObject.Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<int>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: CheckInputs
    /// </summary>
    public unsafe virtual void CheckInputs()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RSeqAct_InformantManager.CheckInputs", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: ShutdownHUD
    /// </summary>
    public unsafe virtual void ShutdownHUD()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RSeqAct_InformantManager.ShutdownHUD", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: InitHUD
    /// </summary>
    public unsafe virtual void InitHUD()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RSeqAct_InformantManager.InitHUD", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: DrawHUD
    /// </summary>
    public unsafe virtual void DrawHUD(BmSDK.Engine.Canvas Canvas)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RSeqAct_InformantManager.DrawHUD", true);
        byte* paramsPtr = stackalloc byte[44];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Canvas, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: PrintStatus
    /// </summary>
    public unsafe virtual void PrintStatus()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RSeqAct_InformantManager.PrintStatus", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: FindFlagIndexByPriority
    /// </summary>
    public unsafe virtual int FindFlagIndexByPriority(BmSDK.BmScript.RSeqAct_InformantManager.eInformantZone Zone, int Priority)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RSeqAct_InformantManager.FindFlagIndexByPriority", true);
        byte* paramsPtr = stackalloc byte[24];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Zone, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Priority, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<int>(paramsPtr + 8);
    }

    /// <summary>
    /// Function: SetAllFlags
    /// </summary>
    public unsafe virtual void SetAllFlags()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RSeqAct_InformantManager.SetAllFlags", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: SetNeededFlags
    /// </summary>
    public unsafe virtual void SetNeededFlags()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RSeqAct_InformantManager.SetNeededFlags", true);
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: UnsetAllFlags
    /// </summary>
    public unsafe virtual void UnsetAllFlags()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RSeqAct_InformantManager.UnsetAllFlags", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: SanitiseFlagPriorities
    /// </summary>
    public unsafe virtual void SanitiseFlagPriorities()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RSeqAct_InformantManager.SanitiseFlagPriorities", true);
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: SetInitialFlagPrioritiesReversed
    /// </summary>
    public unsafe virtual void SetInitialFlagPrioritiesReversed()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RSeqAct_InformantManager.SetInitialFlagPrioritiesReversed", true);
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: SetInitialFlagPriorities
    /// </summary>
    public unsafe virtual void SetInitialFlagPriorities()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RSeqAct_InformantManager.SetInitialFlagPriorities", true);
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: HaveFlagPrioritiesBeenSet
    /// </summary>
    public unsafe virtual bool HaveFlagPrioritiesBeenSet()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RSeqAct_InformantManager.HaveFlagPrioritiesBeenSet", true);
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: UpdateFlagPriorities
    /// </summary>
    public unsafe virtual void UpdateFlagPriorities()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RSeqAct_InformantManager.UpdateFlagPriorities", true);
        byte* paramsPtr = stackalloc byte[20];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: InformantInterrogated
    /// </summary>
    public unsafe virtual void InformantInterrogated()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RSeqAct_InformantManager.InformantInterrogated", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: UnsetMaintainPriorityFlags
    /// </summary>
    public unsafe virtual void UnsetMaintainPriorityFlags()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RSeqAct_InformantManager.UnsetMaintainPriorityFlags", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: AdjustPrioritiesForNewChapter
    /// </summary>
    public unsafe virtual void AdjustPrioritiesForNewChapter()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RSeqAct_InformantManager.AdjustPrioritiesForNewChapter", true);
        byte* paramsPtr = stackalloc byte[68];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: GetNewFlagPriority
    /// </summary>
    public unsafe virtual int GetNewFlagPriority(BmSDK.BmScript.RSeqAct_InformantManager.eInformantZone Zone)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RSeqAct_InformantManager.GetNewFlagPriority", true);
        byte* paramsPtr = stackalloc byte[24];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Zone, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<int>(paramsPtr + 4);
    }

    /// <summary>
    /// Function: OnLevelLoaded
    /// </summary>
    public unsafe virtual void OnLevelLoaded()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RSeqAct_InformantManager.OnLevelLoaded", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: ActiveInPreviousChapter
    /// </summary>
    public unsafe virtual bool ActiveInPreviousChapter(BmSDK.BmScript.RSeqAct_InformantManager.FInformantFlag flag)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RSeqAct_InformantManager.ActiveInPreviousChapter", true);
        byte* paramsPtr = stackalloc byte[56];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(flag, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 52);
    }

    /// <summary>
    /// Function: ActiveInCurrentChapter
    /// </summary>
    public unsafe virtual bool ActiveInCurrentChapter(BmSDK.BmScript.RSeqAct_InformantManager.FInformantFlag flag)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RSeqAct_InformantManager.ActiveInCurrentChapter", true);
        byte* paramsPtr = stackalloc byte[56];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(flag, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 52);
    }

    /// <summary>
    /// Function: ActiveInChapter
    /// </summary>
    public unsafe virtual bool ActiveInChapter(BmSDK.BmScript.RSeqAct_InformantManager.FInformantFlag flag, int Chapter)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RSeqAct_InformantManager.ActiveInChapter", true);
        byte* paramsPtr = stackalloc byte[60];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(flag, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Chapter, paramsPtr + 52);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 56);
    }

    /// <summary>
    /// Function: Deactivated
    /// </summary>
    public unsafe override void Deactivated()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RSeqAct_InformantManager.Deactivated", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: Activated
    /// </summary>
    public unsafe override void Activated()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RSeqAct_InformantManager.Activated", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: Update
    /// </summary>
    public unsafe override bool Update(float DeltaTime)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RSeqAct_InformantManager.Update", true);
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DeltaTime, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 4);
    }

    /// <summary>
    /// Function: BlockLevelName
    /// </summary>
    public unsafe virtual bool BlockLevelName()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RSeqAct_InformantManager.BlockLevelName", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 0);
    }

    /// <summary>
    /// Struct: FInformantFlag
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 52)]
    public partial record struct FInformantFlag
    {
        /// <summary>
        /// StrProperty: FlagName
        /// </summary>
        public unsafe BmSDK.FString FlagName
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// IntProperty: availableInChapters
        /// </summary>
        public unsafe int availableInChapters_0
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 12); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 12); }; }
        }
        /// <summary>
        /// IntProperty: availableInChapters
        /// </summary>
        public unsafe int availableInChapters_1
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 16); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 16); }; }
        }
        /// <summary>
        /// IntProperty: availableInChapters
        /// </summary>
        public unsafe int availableInChapters_2
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 20); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 20); }; }
        }
        /// <summary>
        /// IntProperty: availableInChapters
        /// </summary>
        public unsafe int availableInChapters_3
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 24); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 24); }; }
        }
        /// <summary>
        /// IntProperty: availableInChapters
        /// </summary>
        public unsafe int availableInChapters_4
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 28); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 28); }; }
        }
        /// <summary>
        /// IntProperty: availableInChapters
        /// </summary>
        public unsafe int availableInChapters_5
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 32); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 32); }; }
        }
        /// <summary>
        /// IntProperty: availableInChapters
        /// </summary>
        public unsafe int availableInChapters_6
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 36); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 36); }; }
        }
        /// <summary>
        /// IntProperty: availableInChapters
        /// </summary>
        public unsafe int availableInChapters_7
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 40); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 40); }; }
        }
        /// <summary>
        /// IntProperty: availableInChapters
        /// </summary>
        public unsafe int availableInChapters_8
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 44); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 44); }; }
        }
        /// <summary>
        /// IntProperty: availableInChapters
        /// </summary>
        public unsafe int availableInChapters_9
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 48); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 48); }; }
        }
    }

    /// <summary>
    /// Enum: eInformantZone
    /// </summary>
    public enum eInformantZone
    {
        eInformantZone_OW_A = 0,
        eInformantZone_OW_C = 1,
        eInformantZone_OW_E = 2,
        eInformantZone_ALL = 3,
        eInformantZone_MAX = 4,
    }

    /// <summary>
    /// ObjectProperty: PData
    /// </summary>
    public unsafe BmSDK.BmGame.RPersistentData PData
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPersistentData>(Ptr + 220); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 220); }
    }

    /// <summary>
    /// ObjectProperty: FlagMan
    /// </summary>
    public unsafe BmSDK.BmGame.RFlagManager FlagMan
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RFlagManager>(Ptr + 224); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 224); }
    }

    /// <summary>
    /// StructProperty: OW_A_InformantFlags
    /// </summary>
    public unsafe BmSDK.BmScript.RSeqAct_InformantManager.FInformantFlag OW_A_InformantFlags_0
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmScript.RSeqAct_InformantManager.FInformantFlag>(Ptr + 228); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 228); }
    }
    /// <summary>
    /// StructProperty: OW_A_InformantFlags
    /// </summary>
    public unsafe BmSDK.BmScript.RSeqAct_InformantManager.FInformantFlag OW_A_InformantFlags_1
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmScript.RSeqAct_InformantManager.FInformantFlag>(Ptr + 280); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 280); }
    }
    /// <summary>
    /// StructProperty: OW_A_InformantFlags
    /// </summary>
    public unsafe BmSDK.BmScript.RSeqAct_InformantManager.FInformantFlag OW_A_InformantFlags_2
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmScript.RSeqAct_InformantManager.FInformantFlag>(Ptr + 332); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 332); }
    }
    /// <summary>
    /// StructProperty: OW_A_InformantFlags
    /// </summary>
    public unsafe BmSDK.BmScript.RSeqAct_InformantManager.FInformantFlag OW_A_InformantFlags_3
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmScript.RSeqAct_InformantManager.FInformantFlag>(Ptr + 384); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 384); }
    }
    /// <summary>
    /// StructProperty: OW_A_InformantFlags
    /// </summary>
    public unsafe BmSDK.BmScript.RSeqAct_InformantManager.FInformantFlag OW_A_InformantFlags_4
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmScript.RSeqAct_InformantManager.FInformantFlag>(Ptr + 436); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 436); }
    }
    /// <summary>
    /// StructProperty: OW_A_InformantFlags
    /// </summary>
    public unsafe BmSDK.BmScript.RSeqAct_InformantManager.FInformantFlag OW_A_InformantFlags_5
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmScript.RSeqAct_InformantManager.FInformantFlag>(Ptr + 488); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 488); }
    }
    /// <summary>
    /// StructProperty: OW_A_InformantFlags
    /// </summary>
    public unsafe BmSDK.BmScript.RSeqAct_InformantManager.FInformantFlag OW_A_InformantFlags_6
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmScript.RSeqAct_InformantManager.FInformantFlag>(Ptr + 540); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 540); }
    }
    /// <summary>
    /// StructProperty: OW_A_InformantFlags
    /// </summary>
    public unsafe BmSDK.BmScript.RSeqAct_InformantManager.FInformantFlag OW_A_InformantFlags_7
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmScript.RSeqAct_InformantManager.FInformantFlag>(Ptr + 592); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 592); }
    }
    /// <summary>
    /// StructProperty: OW_A_InformantFlags
    /// </summary>
    public unsafe BmSDK.BmScript.RSeqAct_InformantManager.FInformantFlag OW_A_InformantFlags_8
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmScript.RSeqAct_InformantManager.FInformantFlag>(Ptr + 644); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 644); }
    }
    /// <summary>
    /// StructProperty: OW_A_InformantFlags
    /// </summary>
    public unsafe BmSDK.BmScript.RSeqAct_InformantManager.FInformantFlag OW_A_InformantFlags_9
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmScript.RSeqAct_InformantManager.FInformantFlag>(Ptr + 696); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 696); }
    }
    /// <summary>
    /// StructProperty: OW_A_InformantFlags
    /// </summary>
    public unsafe BmSDK.BmScript.RSeqAct_InformantManager.FInformantFlag OW_A_InformantFlags_10
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmScript.RSeqAct_InformantManager.FInformantFlag>(Ptr + 748); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 748); }
    }
    /// <summary>
    /// StructProperty: OW_A_InformantFlags
    /// </summary>
    public unsafe BmSDK.BmScript.RSeqAct_InformantManager.FInformantFlag OW_A_InformantFlags_11
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmScript.RSeqAct_InformantManager.FInformantFlag>(Ptr + 800); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 800); }
    }
    /// <summary>
    /// StructProperty: OW_A_InformantFlags
    /// </summary>
    public unsafe BmSDK.BmScript.RSeqAct_InformantManager.FInformantFlag OW_A_InformantFlags_12
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmScript.RSeqAct_InformantManager.FInformantFlag>(Ptr + 852); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 852); }
    }
    /// <summary>
    /// StructProperty: OW_A_InformantFlags
    /// </summary>
    public unsafe BmSDK.BmScript.RSeqAct_InformantManager.FInformantFlag OW_A_InformantFlags_13
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmScript.RSeqAct_InformantManager.FInformantFlag>(Ptr + 904); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 904); }
    }
    /// <summary>
    /// StructProperty: OW_A_InformantFlags
    /// </summary>
    public unsafe BmSDK.BmScript.RSeqAct_InformantManager.FInformantFlag OW_A_InformantFlags_14
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmScript.RSeqAct_InformantManager.FInformantFlag>(Ptr + 956); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 956); }
    }
    /// <summary>
    /// StructProperty: OW_A_InformantFlags
    /// </summary>
    public unsafe BmSDK.BmScript.RSeqAct_InformantManager.FInformantFlag OW_A_InformantFlags_15
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmScript.RSeqAct_InformantManager.FInformantFlag>(Ptr + 1008); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1008); }
    }

    /// <summary>
    /// StructProperty: OW_C_InformantFlags
    /// </summary>
    public unsafe BmSDK.BmScript.RSeqAct_InformantManager.FInformantFlag OW_C_InformantFlags_0
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmScript.RSeqAct_InformantManager.FInformantFlag>(Ptr + 1060); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1060); }
    }
    /// <summary>
    /// StructProperty: OW_C_InformantFlags
    /// </summary>
    public unsafe BmSDK.BmScript.RSeqAct_InformantManager.FInformantFlag OW_C_InformantFlags_1
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmScript.RSeqAct_InformantManager.FInformantFlag>(Ptr + 1112); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1112); }
    }
    /// <summary>
    /// StructProperty: OW_C_InformantFlags
    /// </summary>
    public unsafe BmSDK.BmScript.RSeqAct_InformantManager.FInformantFlag OW_C_InformantFlags_2
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmScript.RSeqAct_InformantManager.FInformantFlag>(Ptr + 1164); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1164); }
    }
    /// <summary>
    /// StructProperty: OW_C_InformantFlags
    /// </summary>
    public unsafe BmSDK.BmScript.RSeqAct_InformantManager.FInformantFlag OW_C_InformantFlags_3
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmScript.RSeqAct_InformantManager.FInformantFlag>(Ptr + 1216); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1216); }
    }
    /// <summary>
    /// StructProperty: OW_C_InformantFlags
    /// </summary>
    public unsafe BmSDK.BmScript.RSeqAct_InformantManager.FInformantFlag OW_C_InformantFlags_4
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmScript.RSeqAct_InformantManager.FInformantFlag>(Ptr + 1268); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1268); }
    }
    /// <summary>
    /// StructProperty: OW_C_InformantFlags
    /// </summary>
    public unsafe BmSDK.BmScript.RSeqAct_InformantManager.FInformantFlag OW_C_InformantFlags_5
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmScript.RSeqAct_InformantManager.FInformantFlag>(Ptr + 1320); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1320); }
    }
    /// <summary>
    /// StructProperty: OW_C_InformantFlags
    /// </summary>
    public unsafe BmSDK.BmScript.RSeqAct_InformantManager.FInformantFlag OW_C_InformantFlags_6
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmScript.RSeqAct_InformantManager.FInformantFlag>(Ptr + 1372); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1372); }
    }
    /// <summary>
    /// StructProperty: OW_C_InformantFlags
    /// </summary>
    public unsafe BmSDK.BmScript.RSeqAct_InformantManager.FInformantFlag OW_C_InformantFlags_7
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmScript.RSeqAct_InformantManager.FInformantFlag>(Ptr + 1424); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1424); }
    }
    /// <summary>
    /// StructProperty: OW_C_InformantFlags
    /// </summary>
    public unsafe BmSDK.BmScript.RSeqAct_InformantManager.FInformantFlag OW_C_InformantFlags_8
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmScript.RSeqAct_InformantManager.FInformantFlag>(Ptr + 1476); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1476); }
    }
    /// <summary>
    /// StructProperty: OW_C_InformantFlags
    /// </summary>
    public unsafe BmSDK.BmScript.RSeqAct_InformantManager.FInformantFlag OW_C_InformantFlags_9
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmScript.RSeqAct_InformantManager.FInformantFlag>(Ptr + 1528); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1528); }
    }
    /// <summary>
    /// StructProperty: OW_C_InformantFlags
    /// </summary>
    public unsafe BmSDK.BmScript.RSeqAct_InformantManager.FInformantFlag OW_C_InformantFlags_10
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmScript.RSeqAct_InformantManager.FInformantFlag>(Ptr + 1580); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1580); }
    }
    /// <summary>
    /// StructProperty: OW_C_InformantFlags
    /// </summary>
    public unsafe BmSDK.BmScript.RSeqAct_InformantManager.FInformantFlag OW_C_InformantFlags_11
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmScript.RSeqAct_InformantManager.FInformantFlag>(Ptr + 1632); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1632); }
    }
    /// <summary>
    /// StructProperty: OW_C_InformantFlags
    /// </summary>
    public unsafe BmSDK.BmScript.RSeqAct_InformantManager.FInformantFlag OW_C_InformantFlags_12
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmScript.RSeqAct_InformantManager.FInformantFlag>(Ptr + 1684); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1684); }
    }
    /// <summary>
    /// StructProperty: OW_C_InformantFlags
    /// </summary>
    public unsafe BmSDK.BmScript.RSeqAct_InformantManager.FInformantFlag OW_C_InformantFlags_13
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmScript.RSeqAct_InformantManager.FInformantFlag>(Ptr + 1736); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1736); }
    }
    /// <summary>
    /// StructProperty: OW_C_InformantFlags
    /// </summary>
    public unsafe BmSDK.BmScript.RSeqAct_InformantManager.FInformantFlag OW_C_InformantFlags_14
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmScript.RSeqAct_InformantManager.FInformantFlag>(Ptr + 1788); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1788); }
    }
    /// <summary>
    /// StructProperty: OW_C_InformantFlags
    /// </summary>
    public unsafe BmSDK.BmScript.RSeqAct_InformantManager.FInformantFlag OW_C_InformantFlags_15
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmScript.RSeqAct_InformantManager.FInformantFlag>(Ptr + 1840); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1840); }
    }

    /// <summary>
    /// StructProperty: OW_E_InformantFlags
    /// </summary>
    public unsafe BmSDK.BmScript.RSeqAct_InformantManager.FInformantFlag OW_E_InformantFlags_0
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmScript.RSeqAct_InformantManager.FInformantFlag>(Ptr + 1892); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1892); }
    }
    /// <summary>
    /// StructProperty: OW_E_InformantFlags
    /// </summary>
    public unsafe BmSDK.BmScript.RSeqAct_InformantManager.FInformantFlag OW_E_InformantFlags_1
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmScript.RSeqAct_InformantManager.FInformantFlag>(Ptr + 1944); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1944); }
    }
    /// <summary>
    /// StructProperty: OW_E_InformantFlags
    /// </summary>
    public unsafe BmSDK.BmScript.RSeqAct_InformantManager.FInformantFlag OW_E_InformantFlags_2
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmScript.RSeqAct_InformantManager.FInformantFlag>(Ptr + 1996); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1996); }
    }
    /// <summary>
    /// StructProperty: OW_E_InformantFlags
    /// </summary>
    public unsafe BmSDK.BmScript.RSeqAct_InformantManager.FInformantFlag OW_E_InformantFlags_3
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmScript.RSeqAct_InformantManager.FInformantFlag>(Ptr + 2048); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2048); }
    }
    /// <summary>
    /// StructProperty: OW_E_InformantFlags
    /// </summary>
    public unsafe BmSDK.BmScript.RSeqAct_InformantManager.FInformantFlag OW_E_InformantFlags_4
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmScript.RSeqAct_InformantManager.FInformantFlag>(Ptr + 2100); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2100); }
    }
    /// <summary>
    /// StructProperty: OW_E_InformantFlags
    /// </summary>
    public unsafe BmSDK.BmScript.RSeqAct_InformantManager.FInformantFlag OW_E_InformantFlags_5
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmScript.RSeqAct_InformantManager.FInformantFlag>(Ptr + 2152); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2152); }
    }
    /// <summary>
    /// StructProperty: OW_E_InformantFlags
    /// </summary>
    public unsafe BmSDK.BmScript.RSeqAct_InformantManager.FInformantFlag OW_E_InformantFlags_6
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmScript.RSeqAct_InformantManager.FInformantFlag>(Ptr + 2204); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2204); }
    }
    /// <summary>
    /// StructProperty: OW_E_InformantFlags
    /// </summary>
    public unsafe BmSDK.BmScript.RSeqAct_InformantManager.FInformantFlag OW_E_InformantFlags_7
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmScript.RSeqAct_InformantManager.FInformantFlag>(Ptr + 2256); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2256); }
    }
    /// <summary>
    /// StructProperty: OW_E_InformantFlags
    /// </summary>
    public unsafe BmSDK.BmScript.RSeqAct_InformantManager.FInformantFlag OW_E_InformantFlags_8
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmScript.RSeqAct_InformantManager.FInformantFlag>(Ptr + 2308); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2308); }
    }
    /// <summary>
    /// StructProperty: OW_E_InformantFlags
    /// </summary>
    public unsafe BmSDK.BmScript.RSeqAct_InformantManager.FInformantFlag OW_E_InformantFlags_9
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmScript.RSeqAct_InformantManager.FInformantFlag>(Ptr + 2360); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2360); }
    }
    /// <summary>
    /// StructProperty: OW_E_InformantFlags
    /// </summary>
    public unsafe BmSDK.BmScript.RSeqAct_InformantManager.FInformantFlag OW_E_InformantFlags_10
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmScript.RSeqAct_InformantManager.FInformantFlag>(Ptr + 2412); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2412); }
    }
    /// <summary>
    /// StructProperty: OW_E_InformantFlags
    /// </summary>
    public unsafe BmSDK.BmScript.RSeqAct_InformantManager.FInformantFlag OW_E_InformantFlags_11
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmScript.RSeqAct_InformantManager.FInformantFlag>(Ptr + 2464); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2464); }
    }
    /// <summary>
    /// StructProperty: OW_E_InformantFlags
    /// </summary>
    public unsafe BmSDK.BmScript.RSeqAct_InformantManager.FInformantFlag OW_E_InformantFlags_12
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmScript.RSeqAct_InformantManager.FInformantFlag>(Ptr + 2516); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2516); }
    }
    /// <summary>
    /// StructProperty: OW_E_InformantFlags
    /// </summary>
    public unsafe BmSDK.BmScript.RSeqAct_InformantManager.FInformantFlag OW_E_InformantFlags_13
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmScript.RSeqAct_InformantManager.FInformantFlag>(Ptr + 2568); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2568); }
    }
    /// <summary>
    /// StructProperty: OW_E_InformantFlags
    /// </summary>
    public unsafe BmSDK.BmScript.RSeqAct_InformantManager.FInformantFlag OW_E_InformantFlags_14
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmScript.RSeqAct_InformantManager.FInformantFlag>(Ptr + 2620); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2620); }
    }
    /// <summary>
    /// StructProperty: OW_E_InformantFlags
    /// </summary>
    public unsafe BmSDK.BmScript.RSeqAct_InformantManager.FInformantFlag OW_E_InformantFlags_15
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmScript.RSeqAct_InformantManager.FInformantFlag>(Ptr + 2672); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2672); }
    }

    /// <summary>
    /// BoolProperty: bDrawDebug
    /// </summary>
    public unsafe bool bDrawDebug
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2724) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2724); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2724); }
    }

    /// <summary>
    /// BoolProperty: bDebugSetAllFlags
    /// </summary>
    public unsafe bool bDebugSetAllFlags
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2724) & 2) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2724); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2724); }
    }

    /// <summary>
    /// BoolProperty: bDebugImmediatelySetFlagsOnInterrogate
    /// </summary>
    public unsafe bool bDebugImmediatelySetFlagsOnInterrogate
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2724) & 4) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2724); var newMask = value ? (currentMask | 4) : (currentMask & ~4); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2724); }
    }

    /// <summary>
    /// BoolProperty: bActivated
    /// </summary>
    public unsafe bool bActivated
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2724) & 8) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2724); var newMask = value ? (currentMask | 8) : (currentMask & ~8); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2724); }
    }
}
