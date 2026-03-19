#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RBMWaveController<br/>
/// (size = 0)
/// (flags = 0)
/// </summary>
public partial class RBMWaveController : BmSDK.Engine.SeqAct_Latent, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RBMWaveController", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RBMWaveController() { }

    /// <summary>
    /// Constructs a new RBMWaveController
    /// </summary>
    public RBMWaveController(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RBMWaveController Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RBMWaveController(nint ptr) : base(ptr) { }

    /// <summary>
    /// IntProperty: PreviousDeadPawns
    /// </summary>
    public unsafe int PreviousDeadPawns
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 376); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 376); }
    }

    /// <summary>
    /// BoolProperty: bExitWaveController
    /// </summary>
    public unsafe bool bExitWaveController
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 380) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 380); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 380); }
    }

    /// <summary>
    /// BoolProperty: bCanRespawnPartialWave
    /// </summary>
    public unsafe bool bCanRespawnPartialWave
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 380) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 380); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 380); }
    }

    /// <summary>
    /// BoolProperty: bPawnsSpawned
    /// </summary>
    public unsafe bool bPawnsSpawned
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 380) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 380); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 380); }
    }

    /// <summary>
    /// BoolProperty: bStaggerPawnSpawning
    /// </summary>
    public unsafe bool bStaggerPawnSpawning
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 380) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 380); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 380); }
    }

    /// <summary>
    /// BoolProperty: bSpawningPawns
    /// </summary>
    public unsafe bool bSpawningPawns
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 380) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 380); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 380); }
    }

    /// <summary>
    /// BoolProperty: bWaitForPawnsToBeActuallyDead
    /// </summary>
    public unsafe bool bWaitForPawnsToBeActuallyDead
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 380) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 380); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 380); }
    }

    /// <summary>
    /// BoolProperty: bOnlyDelayRespawnIfAllDead
    /// </summary>
    public unsafe bool bOnlyDelayRespawnIfAllDead
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 380) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 380); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 380); }
    }

    /// <summary>
    /// BoolProperty: bAddToSpawnedPawnCount
    /// </summary>
    public unsafe bool bAddToSpawnedPawnCount
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 380) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 380); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 380); }
    }

    /// <summary>
    /// BoolProperty: bSyncPawnsIntoCombat
    /// </summary>
    public unsafe bool bSyncPawnsIntoCombat
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 380) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 380); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 380); }
    }

    /// <summary>
    /// IntProperty: CurrPawnToSpawn
    /// </summary>
    public unsafe int CurrPawnToSpawn
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 384); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 384); }
    }

    /// <summary>
    /// IntProperty: FramesUntilNextSpawn
    /// </summary>
    public unsafe int FramesUntilNextSpawn
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 388); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 388); }
    }

    /// <summary>
    /// FloatProperty: DelayBetweenSpawns
    /// </summary>
    public unsafe float DelayBetweenSpawns
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 392); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 392); }
    }

    /// <summary>
    /// StrProperty: AllDeadFlagName
    /// </summary>
    public unsafe BmSDK.FString AllDeadFlagName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 396); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 396); }
    }
}
