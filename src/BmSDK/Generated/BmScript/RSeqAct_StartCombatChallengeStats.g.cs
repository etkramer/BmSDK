#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmScript;

/// <summary>
/// ABSTRACT Class: RSeqAct_StartCombatChallengeStats<br/>
/// (size = 232)
/// (flags = 8211)
/// </summary>
public partial class RSeqAct_StartCombatChallengeStats : BmSDK.BmGame.RSeqAct_StartCombatChallengeBase, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmScript.RSeqAct_StartCombatChallengeStats", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RSeqAct_StartCombatChallengeStats() { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RSeqAct_StartCombatChallengeStats(nint ptr) : base(ptr) { }

    /// <summary>
    /// Function: GetObjClassVersion
    /// </summary>
    public unsafe static int GetObjClassVersion()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RSeqAct_StartCombatChallengeStats.GetObjClassVersion", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(StaticClass().DefaultObject.Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<int>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: PublishStats
    /// </summary>
    public unsafe override void PublishStats(BmSDK.BmGame.RGFxMovieChallengeHUD GFXHud)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RSeqAct_StartCombatChallengeStats.PublishStats", true);
        byte* paramsPtr = stackalloc byte[80];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(GFXHud, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: OutputMoveScores
    /// </summary>
    public unsafe override void OutputMoveScores()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RSeqAct_StartCombatChallengeStats.OutputMoveScores", true);
        byte* paramsPtr = stackalloc byte[17];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: ClearChallengeStats
    /// </summary>
    public unsafe override void ClearChallengeStats()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RSeqAct_StartCombatChallengeStats.ClearChallengeStats", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: AddCombatMove
    /// </summary>
    public unsafe override void AddCombatMove(BmSDK.BmGame.RGameInfo.EComboMoveType MoveType, int MoveScore, int MoveMultiplier)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RSeqAct_StartCombatChallengeStats.AddCombatMove", true);
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(MoveType, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(MoveScore, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(MoveMultiplier, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: Activated
    /// </summary>
    public unsafe override void Activated()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RSeqAct_StartCombatChallengeStats.Activated", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// ArrayProperty: CombatMoveScores
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmScript.RSeqAct_StartCombatChallengeStats.FMoveInfo> CombatMoveScores
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmScript.RSeqAct_StartCombatChallengeStats.FMoveInfo>>(Ptr + 220); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 220); }
    }

    /// <summary>
    /// Struct: FMoveInfo
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 20)]
    public partial record struct FMoveInfo
    {
        /// <summary>
        /// ByteProperty: MoveType
        /// </summary>
        public unsafe BmSDK.BmGame.RGameInfo.EComboMoveType MoveType
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RGameInfo.EComboMoveType>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// IntProperty: MoveScore
        /// </summary>
        public unsafe int MoveScore
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4); }; }
        }

        /// <summary>
        /// IntProperty: MoveUses
        /// </summary>
        public unsafe int MoveUses
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8); }; }
        }

        /// <summary>
        /// IntProperty: HighestSingleScore
        /// </summary>
        public unsafe int HighestSingleScore
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 12); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 12); }; }
        }

        /// <summary>
        /// IntProperty: HighestSingleScoreMultiplier
        /// </summary>
        public unsafe int HighestSingleScoreMultiplier
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 16); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 16); }; }
        }
    }
}
