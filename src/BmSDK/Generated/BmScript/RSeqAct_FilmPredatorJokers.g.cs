#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmScript;

/// <summary>
/// Class: RSeqAct_FilmPredatorJokers<br/>
/// (size = 452)
/// (flags = 8210)
/// </summary>
public partial class RSeqAct_FilmPredatorJokers : BmSDK.Engine.SeqAct_Latent, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmScript.RSeqAct_FilmPredatorJokers", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RSeqAct_FilmPredatorJokers() { }

    /// <summary>
    /// Constructs a new RSeqAct_FilmPredatorJokers
    /// </summary>
    public RSeqAct_FilmPredatorJokers(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RSeqAct_FilmPredatorJokers Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RSeqAct_FilmPredatorJokers(nint ptr) : base(ptr) { }

    /// <summary>
    /// Function: GetObjClassVersion
    /// </summary>
    public unsafe static int GetObjClassVersion()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RSeqAct_FilmPredatorJokers.GetObjClassVersion", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(StaticClass().DefaultObject.Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<int>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: Update
    /// </summary>
    public unsafe bool Update(float DeltaTime)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RSeqAct_FilmPredatorJokers.Update", true);
        byte* paramsPtr = stackalloc byte[32];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DeltaTime, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 4);
    }

    /// <summary>
    /// Function: JokerHallucinationsAllowed
    /// </summary>
    public unsafe bool JokerHallucinationsAllowed()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RSeqAct_FilmPredatorJokers.JokerHallucinationsAllowed", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: FindSpawnPoint
    /// </summary>
    public unsafe BmSDK.BmScript.RJokerRooftopPoint FindSpawnPoint(bool bHightLightSpheres = default)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RSeqAct_FilmPredatorJokers.FindSpawnPoint", true);
        byte* paramsPtr = stackalloc byte[52];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bHightLightSpheres, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmScript.RJokerRooftopPoint>(paramsPtr + 4);
    }

    /// <summary>
    /// Function: SpawnRooftopJoker
    /// </summary>
    public unsafe void SpawnRooftopJoker()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RSeqAct_FilmPredatorJokers.SpawnRooftopJoker", true);
        byte* paramsPtr = stackalloc byte[24];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: JokerInView
    /// </summary>
    public unsafe bool JokerInView()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RSeqAct_FilmPredatorJokers.JokerInView", true);
        byte* paramsPtr = stackalloc byte[44];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 0);
    }

    /// <summary>
    /// FloatProperty: MinTimeBetweenJokersAfterDialogue
    /// </summary>
    public unsafe float MinTimeBetweenJokersAfterDialogue
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 376); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 376); }
    }

    /// <summary>
    /// FloatProperty: MaxRangeForSpawn
    /// </summary>
    public unsafe float MaxRangeForSpawn
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 380); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 380); }
    }

    /// <summary>
    /// FloatProperty: MaxRangeBeforeDelete
    /// </summary>
    public unsafe float MaxRangeBeforeDelete
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 384); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 384); }
    }

    /// <summary>
    /// ArrayProperty: JokerPoints
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RJokerRooftopPointBase> JokerPoints
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RJokerRooftopPointBase>>(Ptr + 388); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 388); }
    }

    /// <summary>
    /// ArrayProperty: DisabledPoints
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RJokerRooftopPointBase> DisabledPoints
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RJokerRooftopPointBase>>(Ptr + 404); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 404); }
    }

    /// <summary>
    /// ObjectProperty: CurrentJoker
    /// </summary>
    public unsafe BmSDK.BmGame.RPawnJokerHallucination CurrentJoker
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPawnJokerHallucination>(Ptr + 420); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 420); }
    }

    /// <summary>
    /// BoolProperty: bThisJokerHasBeenSeen
    /// </summary>
    public unsafe bool bThisJokerHasBeenSeen
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 428) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 428); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 428); }
    }

    /// <summary>
    /// BoolProperty: bForceNextAppearance
    /// </summary>
    public unsafe bool bForceNextAppearance
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 428) & 2) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 428); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 428); }
    }

    /// <summary>
    /// FloatProperty: JokerSpawnTime
    /// </summary>
    public unsafe float JokerSpawnTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 432); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 432); }
    }

    /// <summary>
    /// FloatProperty: TimeTillNextJoker
    /// </summary>
    public unsafe float TimeTillNextJoker
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 436); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 436); }
    }

    /// <summary>
    /// FloatProperty: JokerOnScreenTime
    /// </summary>
    public unsafe float JokerOnScreenTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 440); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 440); }
    }

    /// <summary>
    /// IntProperty: NumDialoguesDone
    /// </summary>
    public unsafe int NumDialoguesDone
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 444); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 444); }
    }

    /// <summary>
    /// IntProperty: MaxDialogues
    /// </summary>
    public unsafe int MaxDialogues
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 448); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 448); }
    }
}
