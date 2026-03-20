#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmScript;

/// <summary>
/// Class: RSeqAct_UpdateJokerNuke<br/>
/// (size = 640)
/// (flags = 8210)
/// </summary>
public partial class RSeqAct_UpdateJokerNuke : BmSDK.BmGame.RSeqAct_UpdateJokerNukeBase, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmScript.RSeqAct_UpdateJokerNuke", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RSeqAct_UpdateJokerNuke() { }

    /// <summary>
    /// Constructs a new RSeqAct_UpdateJokerNuke
    /// </summary>
    public RSeqAct_UpdateJokerNuke(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RSeqAct_UpdateJokerNuke Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RSeqAct_UpdateJokerNuke(nint ptr) : base(ptr) { }

    /// <summary>
    /// Function: GetObjClassVersion
    /// </summary>
    public unsafe static int GetObjClassVersion()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RSeqAct_UpdateJokerNuke.GetObjClassVersion", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(StaticClass().DefaultObject.Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<int>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: Activated
    /// </summary>
    public unsafe void Activated()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RSeqAct_UpdateJokerNuke.Activated", true);
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// ObjectProperty: Joker
    /// </summary>
    public unsafe BmSDK.BmScript.RPawnBossJokerNukeGun Joker
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmScript.RPawnBossJokerNukeGun>(Ptr + 352); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 352); }
    }

    /// <summary>
    /// ObjectProperty: PlayerJoker
    /// </summary>
    public unsafe BmSDK.BmGame.RPawnPlayerFPS PlayerJoker
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPawnPlayerFPS>(Ptr + 360); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 360); }
    }

    /// <summary>
    /// ObjectProperty: PlayerBatman
    /// </summary>
    public unsafe BmSDK.BmScript.RJokerBossBatmanBotController PlayerBatman
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmScript.RJokerBossBatmanBotController>(Ptr + 368); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 368); }
    }

    /// <summary>
    /// ObjectProperty: ValidAreaVolume
    /// </summary>
    public unsafe BmSDK.Engine.Volume ValidAreaVolume
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.Volume>(Ptr + 376); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 376); }
    }

    /// <summary>
    /// ObjectProperty: JokerOutOfWayLocator
    /// </summary>
    public unsafe BmSDK.Engine.Actor JokerOutOfWayLocator
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.Actor>(Ptr + 384); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 384); }
    }

    /// <summary>
    /// ObjectProperty: Cell
    /// </summary>
    public unsafe BmSDK.Engine.Actor Cell
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.Actor>(Ptr + 392); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 392); }
    }

    /// <summary>
    /// ObjectProperty: BatmanSafePoint
    /// </summary>
    public unsafe BmSDK.Engine.Actor BatmanSafePoint
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.Actor>(Ptr + 400); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 400); }
    }

    /// <summary>
    /// ObjectProperty: CentrePoint
    /// </summary>
    public unsafe BmSDK.Engine.Actor CentrePoint
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.Actor>(Ptr + 408); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 408); }
    }

    /// <summary>
    /// ObjectProperty: LanternPoint
    /// </summary>
    public unsafe BmSDK.Engine.Actor LanternPoint
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.Actor>(Ptr + 416); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 416); }
    }

    /// <summary>
    /// ObjectProperty: BeatDownCam
    /// </summary>
    public unsafe BmSDK.Engine.CameraActor BeatDownCam
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.CameraActor>(Ptr + 424); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 424); }
    }

    /// <summary>
    /// ArrayProperty: Railings
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.Engine.Actor> Railings
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.Actor>>(Ptr + 432); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 432); }
    }

    /// <summary>
    /// ArrayProperty: ManequinPlinths
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RJokerManequin> ManequinPlinths
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RJokerManequin>>(Ptr + 448); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 448); }
    }

    /// <summary>
    /// ArrayProperty: ForcedRailings
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.Engine.Actor> ForcedRailings
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.Actor>>(Ptr + 464); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 464); }
    }

    /// <summary>
    /// ArrayProperty: ForcedManequinPlinths
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RJokerManequin> ForcedManequinPlinths
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RJokerManequin>>(Ptr + 480); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 480); }
    }

    /// <summary>
    /// ArrayProperty: ForcedGrates
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.Engine.Actor> ForcedGrates
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.Actor>>(Ptr + 496); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 496); }
    }

    /// <summary>
    /// NameProperty: CellOpenAnimName
    /// </summary>
    public unsafe BmSDK.FName CellOpenAnimName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 512); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 512); }
    }

    /// <summary>
    /// NameProperty: CellCloseAnimName
    /// </summary>
    public unsafe BmSDK.FName CellCloseAnimName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 520); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 520); }
    }

    /// <summary>
    /// ArrayProperty: DummyAnimsetref
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.Engine.AnimSet> DummyAnimsetref
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.AnimSet>>(Ptr + 528); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 528); }
    }

    /// <summary>
    /// ArrayProperty: CornerPoints
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.Engine.Actor> CornerPoints
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.Actor>>(Ptr + 544); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 544); }
    }

    /// <summary>
    /// ByteProperty: ForceTakeDownType
    /// </summary>
    public unsafe BmSDK.BmScript.RJokerBossBatmanBotController.JokerBossTakedownTypes ForceTakeDownType
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmScript.RJokerBossBatmanBotController.JokerBossTakedownTypes>(Ptr + 560); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 560); }
    }

    /// <summary>
    /// BoolProperty: bForceSecondPhase
    /// </summary>
    public unsafe bool bForceSecondPhase
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 564) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 564); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 564); }
    }

    /// <summary>
    /// ArrayProperty: SteamPoints
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.Engine.Emitter> SteamPoints
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.Emitter>>(Ptr + 568); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 568); }
    }

    /// <summary>
    /// FloatProperty: FadeTimeForNormal
    /// </summary>
    public unsafe float FadeTimeForNormal
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 584); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 584); }
    }

    /// <summary>
    /// FloatProperty: FadeTimeForInOut
    /// </summary>
    public unsafe float FadeTimeForInOut
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 588); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 588); }
    }

    /// <summary>
    /// NameProperty: FadeParamName
    /// </summary>
    public unsafe BmSDK.FName FadeParamName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 592); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 592); }
    }

    /// <summary>
    /// IntProperty: NumManequinsToMiss
    /// </summary>
    public unsafe int NumManequinsToMiss
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 600); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 600); }
    }

    /// <summary>
    /// IntProperty: NumRailingsToMiss
    /// </summary>
    public unsafe int NumRailingsToMiss
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 604); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 604); }
    }

    /// <summary>
    /// IntProperty: NumGratesToMiss
    /// </summary>
    public unsafe int NumGratesToMiss
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 608); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 608); }
    }

    /// <summary>
    /// FloatProperty: MaxBeatDownFov
    /// </summary>
    public unsafe float MaxBeatDownFov
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 612); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 612); }
    }

    /// <summary>
    /// FloatProperty: MinBeatDownFov
    /// </summary>
    public unsafe float MinBeatDownFov
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 616); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 616); }
    }

    /// <summary>
    /// IntProperty: NumHitsForMinFov
    /// </summary>
    public unsafe int NumHitsForMinFov
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 620); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 620); }
    }

    /// <summary>
    /// ArrayProperty: NoShootItems
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.Engine.Actor> NoShootItems
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.Actor>>(Ptr + 624); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 624); }
    }
}
