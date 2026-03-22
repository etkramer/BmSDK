#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmScript;

/// <summary>
/// Class: RSeqAct_Riddler8HostageController<br/>
/// (size = 304)
/// (flags = 8210)
/// </summary>
public partial class RSeqAct_Riddler8HostageController : BmSDK.Engine.SeqAct_Latent, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmScript.RSeqAct_Riddler8HostageController", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RSeqAct_Riddler8HostageController() { }

    /// <summary>
    /// Constructs a new RSeqAct_Riddler8HostageController
    /// </summary>
    public RSeqAct_Riddler8HostageController(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RSeqAct_Riddler8HostageController Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RSeqAct_Riddler8HostageController(nint ptr) : base(ptr) { }

    /// <summary>
    /// Function: GetObjClassVersion
    /// </summary>
    public unsafe static int GetObjClassVersion()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RSeqAct_Riddler8HostageController.GetObjClassVersion", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(StaticClass().DefaultObject.Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<int>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: Update
    /// </summary>
    public unsafe override bool Update(float DeltaTime)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RSeqAct_Riddler8HostageController.Update", true);
        byte* paramsPtr = stackalloc byte[28];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DeltaTime, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 4);
    }

    /// <summary>
    /// Function: Activated
    /// </summary>
    public unsafe override void Activated()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RSeqAct_Riddler8HostageController.Activated", true);
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// FloatProperty: IdealDistFromChain
    /// </summary>
    public unsafe float IdealDistFromChain
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 220); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 220); }
    }

    /// <summary>
    /// FloatProperty: SpeedPercIncPerUnit
    /// </summary>
    public unsafe float SpeedPercIncPerUnit
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 224); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 224); }
    }

    /// <summary>
    /// FloatProperty: RopeMinDist
    /// </summary>
    public unsafe float RopeMinDist
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 228); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 228); }
    }

    /// <summary>
    /// FloatProperty: RopeMaxDist
    /// </summary>
    public unsafe float RopeMaxDist
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 232); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 232); }
    }

    /// <summary>
    /// ArrayProperty: Hostages
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RBMPawnAI> Hostages
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RBMPawnAI>>(Ptr + 236); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 236); }
    }

    /// <summary>
    /// ArrayProperty: CurrentDestination
    /// </summary>
    public unsafe BmSDK.TArray<System.Numerics.Vector3> CurrentDestination
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<System.Numerics.Vector3>>(Ptr + 248); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 248); }
    }

    /// <summary>
    /// ArrayProperty: Chains
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.Engine.SkeletalMeshActor> Chains
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.SkeletalMeshActor>>(Ptr + 260); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 260); }
    }

    /// <summary>
    /// ArrayProperty: HangRope
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RRopeBaseSpawnable> HangRope
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RRopeBaseSpawnable>>(Ptr + 272); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 272); }
    }

    /// <summary>
    /// ObjectProperty: RopeMat
    /// </summary>
    public unsafe BmSDK.Engine.Material RopeMat
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.Material>(Ptr + 284); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 284); }
    }

    /// <summary>
    /// IntProperty: NumFramesForRopeUpdate
    /// </summary>
    public unsafe int NumFramesForRopeUpdate
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 288); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 288); }
    }

    /// <summary>
    /// StructProperty: ChainForwardDir
    /// </summary>
    public unsafe BmSDK.Rotator ChainForwardDir
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Rotator>(Ptr + 292); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 292); }
    }
}
