#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Class: SeqAct_ActorFactoryEx<br/>
/// (flags = 0)
/// </summary>
public partial class SeqAct_ActorFactoryEx : BmSDK.Engine.SeqAct_ActorFactory, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Engine.SeqAct_ActorFactoryEx", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal SeqAct_ActorFactoryEx() { }

    /// <summary>
    /// Constructs a new SeqAct_ActorFactoryEx
    /// </summary>
    public SeqAct_ActorFactoryEx(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, SeqAct_ActorFactoryEx Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected SeqAct_ActorFactoryEx(nint ptr) : base(ptr) { }

    /// <summary>
    /// BoolProperty: bEnabled
    /// </summary>
    public unsafe bool bEnabled
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 376) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 376); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 376); }
    }

    /// <summary>
    /// BoolProperty: bIsSpawning
    /// </summary>
    public unsafe bool bIsSpawning
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 376) & 2) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 376); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 376); }
    }

    /// <summary>
    /// BoolProperty: bCheckSpawnCollision
    /// </summary>
    public unsafe bool bCheckSpawnCollision
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 376) & 4) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 376); var newMask = value ? (currentMask | 4) : (currentMask & ~4); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 376); }
    }

    /// <summary>
    /// ObjectProperty: Factory
    /// </summary>
    public unsafe BmSDK.Engine.ActorFactory Factory
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ActorFactory>(Ptr + 380); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 380); }
    }

    /// <summary>
    /// ByteProperty: PointSelection
    /// </summary>
    public unsafe BmSDK.Engine.SeqAct_ActorFactory.EPointSelection PointSelection
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.SeqAct_ActorFactory.EPointSelection>(Ptr + 388); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 388); }
    }

    /// <summary>
    /// ArrayProperty: SpawnPoints
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.Engine.Actor> SpawnPoints
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.Actor>>(Ptr + 392); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 392); }
    }

    /// <summary>
    /// ArrayProperty: SpawnLocations
    /// </summary>
    public unsafe BmSDK.TArray<System.Numerics.Vector3> SpawnLocations
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<System.Numerics.Vector3>>(Ptr + 408); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 408); }
    }

    /// <summary>
    /// ArrayProperty: SpawnOrientations
    /// </summary>
    public unsafe BmSDK.TArray<System.Numerics.Vector3> SpawnOrientations
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<System.Numerics.Vector3>>(Ptr + 424); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 424); }
    }

    /// <summary>
    /// IntProperty: SpawnCount
    /// </summary>
    public unsafe int SpawnCount
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 440); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 440); }
    }

    /// <summary>
    /// FloatProperty: SpawnDelay
    /// </summary>
    public unsafe float SpawnDelay
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 444); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 444); }
    }

    /// <summary>
    /// IntProperty: LastSpawnIdx
    /// </summary>
    public unsafe int LastSpawnIdx
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 448); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 448); }
    }

    /// <summary>
    /// IntProperty: CurrentSpawnIdx
    /// </summary>
    public unsafe int CurrentSpawnIdx
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 452); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 452); }
    }

    /// <summary>
    /// IntProperty: SpawnedCount
    /// </summary>
    public unsafe int SpawnedCount
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 456); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 456); }
    }

    /// <summary>
    /// FloatProperty: RemainingDelay
    /// </summary>
    public unsafe float RemainingDelay
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 460); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 460); }
    }

    /// <summary>
    /// ArrayProperty: SpawnScales
    /// </summary>
    public unsafe BmSDK.TArray<System.Numerics.Vector3> SpawnScales
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<System.Numerics.Vector3>>(Ptr + 464); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 464); }
    }

    /// <summary>
    /// Enum: EPointSelection
    /// </summary>
    public enum EPointSelection
    {
        PS_Normal = 0,
        PS_Random = 1,
        PS_Reverse = 2,
        PS_MAX = 3,
    }
}
