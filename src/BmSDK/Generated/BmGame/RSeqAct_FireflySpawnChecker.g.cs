#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RSeqAct_FireflySpawnChecker<br/>
/// (size = 404)
/// (flags = 8210)
/// </summary>
public partial class RSeqAct_FireflySpawnChecker : BmSDK.Engine.SequenceAction, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RSeqAct_FireflySpawnChecker", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RSeqAct_FireflySpawnChecker() { }

    /// <summary>
    /// Constructs a new RSeqAct_FireflySpawnChecker
    /// </summary>
    public RSeqAct_FireflySpawnChecker(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RSeqAct_FireflySpawnChecker Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RSeqAct_FireflySpawnChecker(nint ptr) : base(ptr) { }

    /// <summary>
    /// Function: GetObjClassVersion
    /// </summary>
    public unsafe static int GetObjClassVersion()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RSeqAct_FireflySpawnChecker.GetObjClassVersion", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(StaticClass().DefaultObject.Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<int>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: FireOutputs
    /// </summary>
    public unsafe void FireOutputs()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RSeqAct_FireflySpawnChecker.FireOutputs", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: CheckInputs
    /// </summary>
    public unsafe void CheckInputs()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RSeqAct_FireflySpawnChecker.CheckInputs", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: Activated
    /// </summary>
    public unsafe void Activated()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RSeqAct_FireflySpawnChecker.Activated", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: GetEncounterState
    /// </summary>
    public unsafe BmSDK.BmGame.RSeqAct_FireflySpawnChecker.FireflyEncounterState GetEncounterState(int inEncounterIndex)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RSeqAct_FireflySpawnChecker.GetEncounterState", true);
        byte* paramsPtr = stackalloc byte[5];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(inEncounterIndex, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSeqAct_FireflySpawnChecker.FireflyEncounterState>(paramsPtr + 4);
    }

    /// <summary>
    /// Function: SetEncounterFlag
    /// </summary>
    public unsafe bool SetEncounterFlag(int inEncounterIndex, BmSDK.BmGame.RSeqAct_FireflySpawnChecker.FireflyEncounterState encounterState, bool val = default, bool bAutoPan = default)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RSeqAct_FireflySpawnChecker.SetEncounterFlag", true);
        byte* paramsPtr = stackalloc byte[36];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(inEncounterIndex, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(encounterState, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(val, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bAutoPan, paramsPtr + 12);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 16);
    }

    /// <summary>
    /// Function: IsEncounterFlagSet
    /// </summary>
    public unsafe bool IsEncounterFlagSet(int inEncounterIndex, BmSDK.BmGame.RSeqAct_FireflySpawnChecker.FireflyEncounterState encounterState)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RSeqAct_FireflySpawnChecker.IsEncounterFlagSet", true);
        byte* paramsPtr = stackalloc byte[28];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(inEncounterIndex, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(encounterState, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 8);
    }

    /// <summary>
    /// Function: GetEncounterFlagString
    /// </summary>
    public unsafe static BmSDK.FString GetEncounterFlagString(int inEncounterIndex, BmSDK.BmGame.RSeqAct_FireflySpawnChecker.FireflyEncounterState encounterState)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RSeqAct_FireflySpawnChecker.GetEncounterFlagString", true);
        byte* paramsPtr = stackalloc byte[40];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(inEncounterIndex, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(encounterState, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(StaticClass().DefaultObject.Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(paramsPtr + 8);
    }

    /// <summary>
    /// Enum: FireflyEncounterState
    /// </summary>
    public enum FireflyEncounterState
    {
        eFFES_locked = 0,
        eFFES_available = 1,
        eFFES_completed = 2,
        eFFES_MAX = 3,
    }

    /// <summary>
    /// StrProperty: flagSuffixes
    /// </summary>
    public unsafe BmSDK.FString flagSuffixes_0
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 352); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 352); }
    }
    /// <summary>
    /// StrProperty: flagSuffixes
    /// </summary>
    public unsafe BmSDK.FString flagSuffixes_1
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 368); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 368); }
    }
    /// <summary>
    /// StrProperty: flagSuffixes
    /// </summary>
    public unsafe BmSDK.FString flagSuffixes_2
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 384); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 384); }
    }

    /// <summary>
    /// IntProperty: encounterIndex
    /// </summary>
    public unsafe int encounterIndex
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 400); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 400); }
    }

}
