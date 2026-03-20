#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmScript;

/// <summary>
/// Class: RSeqAct_TwoFaceLairController<br/>
/// (size = 616)
/// (flags = 8210)
/// </summary>
public partial class RSeqAct_TwoFaceLairController : BmSDK.BmGame.RSeqAct_CombatSpawnerBase, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmScript.RSeqAct_TwoFaceLairController", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RSeqAct_TwoFaceLairController() { }

    /// <summary>
    /// Constructs a new RSeqAct_TwoFaceLairController
    /// </summary>
    public RSeqAct_TwoFaceLairController(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RSeqAct_TwoFaceLairController Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RSeqAct_TwoFaceLairController(nint ptr) : base(ptr) { }

    /// <summary>
    /// Function: GetObjClassVersion
    /// </summary>
    public unsafe static int GetObjClassVersion()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RSeqAct_TwoFaceLairController.GetObjClassVersion", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(StaticClass().DefaultObject.Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<int>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: Update
    /// </summary>
    public unsafe bool Update(float DeltaTime)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RSeqAct_TwoFaceLairController.Update", true);
        byte* paramsPtr = stackalloc byte[44];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DeltaTime, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 4);
    }

    /// <summary>
    /// Function: StartTwoface
    /// </summary>
    public unsafe void StartTwoface()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RSeqAct_TwoFaceLairController.StartTwoface", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: SpawnTwoface
    /// </summary>
    public unsafe void SpawnTwoface()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RSeqAct_TwoFaceLairController.SpawnTwoface", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: SpawnPenguin
    /// </summary>
    public unsafe void SpawnPenguin()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RSeqAct_TwoFaceLairController.SpawnPenguin", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: SpawnRiddler
    /// </summary>
    public unsafe void SpawnRiddler()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RSeqAct_TwoFaceLairController.SpawnRiddler", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: Activated
    /// </summary>
    public unsafe void Activated()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RSeqAct_TwoFaceLairController.Activated", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// ObjectProperty: Joker
    /// </summary>
    public unsafe BmSDK.BmGame.RPawnPlayer Joker
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPawnPlayer>(Ptr + 384); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 384); }
    }

    /// <summary>
    /// ObjectProperty: RiddlerSpawnPoint
    /// </summary>
    public unsafe BmSDK.Engine.Actor RiddlerSpawnPoint
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.Actor>(Ptr + 392); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 392); }
    }

    /// <summary>
    /// ObjectProperty: RiddlerHostageSpawnPoint
    /// </summary>
    public unsafe BmSDK.Engine.Actor RiddlerHostageSpawnPoint
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.Actor>(Ptr + 400); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 400); }
    }

    /// <summary>
    /// ObjectProperty: RiddlerDefine
    /// </summary>
    public unsafe BmSDK.BmGame.RCharacterDefine RiddlerDefine
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RCharacterDefine>(Ptr + 408); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 408); }
    }

    /// <summary>
    /// ObjectProperty: PenguinSpawnPoint
    /// </summary>
    public unsafe BmSDK.Engine.Actor PenguinSpawnPoint
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.Actor>(Ptr + 416); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 416); }
    }

    /// <summary>
    /// ObjectProperty: PenguinDefine
    /// </summary>
    public unsafe BmSDK.BmGame.RCharacterDefine PenguinDefine
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RCharacterDefine>(Ptr + 424); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 424); }
    }

    /// <summary>
    /// ObjectProperty: TwofaceSpawnPoint
    /// </summary>
    public unsafe BmSDK.Engine.Actor TwofaceSpawnPoint
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.Actor>(Ptr + 432); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 432); }
    }

    /// <summary>
    /// ObjectProperty: TwofaceDefine
    /// </summary>
    public unsafe BmSDK.BmGame.RCharacterDefine TwofaceDefine
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RCharacterDefine>(Ptr + 440); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 440); }
    }

    /// <summary>
    /// ObjectProperty: ThugDefine
    /// </summary>
    public unsafe BmSDK.BmGame.RCharacterDefine ThugDefine
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RCharacterDefine>(Ptr + 448); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 448); }
    }

    /// <summary>
    /// ObjectProperty: TwofaceBeh
    /// </summary>
    public unsafe BmSDK.BmScript.RBMBehaviour_JokerBossTwoface TwofaceBeh
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmScript.RBMBehaviour_JokerBossTwoface>(Ptr + 456); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 456); }
    }

    /// <summary>
    /// ObjectProperty: PenguinBeh
    /// </summary>
    public unsafe BmSDK.BmScript.RBMBehaviour_JokerBossPenguin PenguinBeh
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmScript.RBMBehaviour_JokerBossPenguin>(Ptr + 464); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 464); }
    }

    /// <summary>
    /// ObjectProperty: RiddlerBeh
    /// </summary>
    public unsafe BmSDK.BmScript.RBMBehaviour_JokerBossRiddler RiddlerBeh
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmScript.RBMBehaviour_JokerBossRiddler>(Ptr + 472); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 472); }
    }

    /// <summary>
    /// ObjectProperty: RiddlerHostageBeh
    /// </summary>
    public unsafe BmSDK.BmScript.RBMBehaviour_JokerBossRiddlerHostage RiddlerHostageBeh
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmScript.RBMBehaviour_JokerBossRiddlerHostage>(Ptr + 480); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 480); }
    }

    /// <summary>
    /// ObjectProperty: TwoFaceGun
    /// </summary>
    public unsafe BmSDK.BmGame.RSkeletalMeshActor TwoFaceGun
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSkeletalMeshActor>(Ptr + 488); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 488); }
    }

    /// <summary>
    /// ObjectProperty: Riddler
    /// </summary>
    public unsafe BmSDK.BmGame.RPawnVillain Riddler
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPawnVillain>(Ptr + 496); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 496); }
    }

    /// <summary>
    /// ObjectProperty: Oracle
    /// </summary>
    public unsafe BmSDK.BmGame.RPawnVillain Oracle
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPawnVillain>(Ptr + 504); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 504); }
    }

    /// <summary>
    /// ObjectProperty: penguin
    /// </summary>
    public unsafe BmSDK.BmGame.RPawnVillainThug penguin
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPawnVillainThug>(Ptr + 512); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 512); }
    }

    /// <summary>
    /// ObjectProperty: TwoFace
    /// </summary>
    public unsafe BmSDK.BmGame.RPawnVillainThug TwoFace
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPawnVillainThug>(Ptr + 520); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 520); }
    }

    /// <summary>
    /// ObjectProperty: PickedGordonSpawnPoint
    /// </summary>
    public unsafe BmSDK.Engine.Actor PickedGordonSpawnPoint
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.Actor>(Ptr + 528); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 528); }
    }

    /// <summary>
    /// ObjectProperty: PenguinHandTarget
    /// </summary>
    public unsafe BmSDK.Engine.Actor PenguinHandTarget
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.Actor>(Ptr + 536); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 536); }
    }

    /// <summary>
    /// ClassProperty: ThugCharacter
    /// </summary>
    public unsafe BmSDK.Class ThugCharacter
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Class>(Ptr + 544); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 544); }
    }

    /// <summary>
    /// ClassProperty: TwofaceCharacter
    /// </summary>
    public unsafe BmSDK.Class TwofaceCharacter
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Class>(Ptr + 552); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 552); }
    }

    /// <summary>
    /// ClassProperty: PenguinCharacter
    /// </summary>
    public unsafe BmSDK.Class PenguinCharacter
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Class>(Ptr + 560); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 560); }
    }

    /// <summary>
    /// ClassProperty: RiddlerCharacter
    /// </summary>
    public unsafe BmSDK.Class RiddlerCharacter
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Class>(Ptr + 568); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 568); }
    }

    /// <summary>
    /// ArrayProperty: TwoFaceThugDefines
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RCharacterDefine> TwoFaceThugDefines
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RCharacterDefine>>(Ptr + 576); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 576); }
    }

    /// <summary>
    /// ArrayProperty: GordonSpawnPoints
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.Engine.Actor> GordonSpawnPoints
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.Actor>>(Ptr + 592); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 592); }
    }

    /// <summary>
    /// BoolProperty: bPickingGordonPoint
    /// </summary>
    public unsafe bool bPickingGordonPoint
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 608) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 608); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 608); }
    }

    /// <summary>
    /// FloatProperty: MinGordonDistForSpawn
    /// </summary>
    public unsafe float MinGordonDistForSpawn
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 612); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 612); }
    }
}
