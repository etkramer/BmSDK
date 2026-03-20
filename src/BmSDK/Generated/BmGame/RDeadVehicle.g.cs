#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RDeadVehicle<br/>
/// (size = 0)
/// (flags = 0)
/// </summary>
public partial class RDeadVehicle : BmSDK.BmGame.RSkeletalMeshActor, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RDeadVehicle", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RDeadVehicle() { }

    /// <summary>
    /// Constructs a new RDeadVehicle
    /// </summary>
    public RDeadVehicle(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RDeadVehicle Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RDeadVehicle(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="Engine.Actor.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RDeadVehicle>
        => ((Engine.Actor)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="Engine.Actor.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RDeadVehicle>, new()
        => (TComponent)((Engine.Actor)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="Engine.Actor.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RDeadVehicle>
        => ((Engine.Actor)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="Engine.Actor.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RDeadVehicle>
        => ((Engine.Actor)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="Engine.Actor.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RDeadVehicle>
        => (TComponent)((Engine.Actor)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="Engine.Actor.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RDeadVehicle>
        => ((Engine.Actor)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="Engine.Actor.DetachScriptComponent(Type)"/>
    public void DetachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RDeadVehicle>
        => ((Engine.Actor)this).DetachScriptComponent(typeof(TComponent));

    /// <summary>
    /// StructProperty: VfTable_IInterface_NavMeshPathObstacle
    /// </summary>
    public unsafe System.IntPtr VfTable_IInterface_NavMeshPathObstacle
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.IntPtr>(Ptr + 824); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 824); }
    }

    /// <summary>
    /// ComponentProperty: HitMaskComp
    /// </summary>
    public unsafe BmSDK.Engine.SceneCapture2DHitMaskComponent HitMaskComp
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.SceneCapture2DHitMaskComponent>(Ptr + 832); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 832); }
    }

    /// <summary>
    /// StructProperty: InitialLoc
    /// </summary>
    public unsafe System.Numerics.Vector3 InitialLoc
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 840); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 840); }
    }

    /// <summary>
    /// IntProperty: AllowDeform
    /// </summary>
    public unsafe int AllowDeform
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 852); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 852); }
    }

    /// <summary>
    /// BoolProperty: bObstacleRegistered
    /// </summary>
    public unsafe bool bObstacleRegistered
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 856) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 856); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 856); }
    }

    /// <summary>
    /// BoolProperty: bCanRegisterObstacle
    /// </summary>
    public unsafe bool bCanRegisterObstacle
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 856) & 2) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 856); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 856); }
    }

    /// <summary>
    /// BoolProperty: bCachedMeshBodyToBone
    /// </summary>
    public unsafe bool bCachedMeshBodyToBone
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 856) & 4) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 856); var newMask = value ? (currentMask | 4) : (currentMask & ~4); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 856); }
    }

    /// <summary>
    /// ObjectProperty: RoofRack
    /// </summary>
    public unsafe BmSDK.Engine.KActorSpawnable RoofRack
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.KActorSpawnable>(Ptr + 860); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 860); }
    }

    /// <summary>
    /// ObjectProperty: DeformParticlesSmall
    /// </summary>
    public unsafe BmSDK.Engine.ParticleSystem DeformParticlesSmall
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleSystem>(Ptr + 868); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 868); }
    }

    /// <summary>
    /// ObjectProperty: DeformParticlesMedium
    /// </summary>
    public unsafe BmSDK.Engine.ParticleSystem DeformParticlesMedium
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleSystem>(Ptr + 876); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 876); }
    }

    /// <summary>
    /// ObjectProperty: DeformParticlesLarge
    /// </summary>
    public unsafe BmSDK.Engine.ParticleSystem DeformParticlesLarge
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleSystem>(Ptr + 884); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 884); }
    }

    /// <summary>
    /// ObjectProperty: ImpactParticlesSmall
    /// </summary>
    public unsafe BmSDK.Engine.ParticleSystem ImpactParticlesSmall
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleSystem>(Ptr + 892); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 892); }
    }

    /// <summary>
    /// ObjectProperty: ImpactParticlesMedium
    /// </summary>
    public unsafe BmSDK.Engine.ParticleSystem ImpactParticlesMedium
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleSystem>(Ptr + 900); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 900); }
    }

    /// <summary>
    /// ObjectProperty: ImpactParticlesLarge
    /// </summary>
    public unsafe BmSDK.Engine.ParticleSystem ImpactParticlesLarge
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleSystem>(Ptr + 908); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 908); }
    }

    /// <summary>
    /// ObjectProperty: AudioPhysicalMaterialOverride
    /// </summary>
    public unsafe BmSDK.Engine.PhysicalMaterial AudioPhysicalMaterialOverride
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.PhysicalMaterial>(Ptr + 916); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 916); }
    }

    /// <summary>
    /// ByteProperty: NumObstacleBodies
    /// </summary>
    public unsafe byte NumObstacleBodies
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 924); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 924); }
    }

    /// <summary>
    /// ByteProperty: ObstacleBodies
    /// </summary>
    public unsafe byte ObstacleBodies_0
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 925); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 925); }
    }
    /// <summary>
    /// ByteProperty: ObstacleBodies
    /// </summary>
    public unsafe byte ObstacleBodies_1
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 926); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 926); }
    }
    /// <summary>
    /// ByteProperty: ObstacleBodies
    /// </summary>
    public unsafe byte ObstacleBodies_2
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 927); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 927); }
    }
    /// <summary>
    /// ByteProperty: ObstacleBodies
    /// </summary>
    public unsafe byte ObstacleBodies_3
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 928); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 928); }
    }
    /// <summary>
    /// ByteProperty: ObstacleBodies
    /// </summary>
    public unsafe byte ObstacleBodies_4
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 929); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 929); }
    }
    /// <summary>
    /// ByteProperty: ObstacleBodies
    /// </summary>
    public unsafe byte ObstacleBodies_5
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 930); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 930); }
    }
    /// <summary>
    /// ByteProperty: ObstacleBodies
    /// </summary>
    public unsafe byte ObstacleBodies_6
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 931); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 931); }
    }
    /// <summary>
    /// ByteProperty: ObstacleBodies
    /// </summary>
    public unsafe byte ObstacleBodies_7
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 932); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 932); }
    }
    /// <summary>
    /// ByteProperty: ObstacleBodies
    /// </summary>
    public unsafe byte ObstacleBodies_8
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 933); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 933); }
    }
    /// <summary>
    /// ByteProperty: ObstacleBodies
    /// </summary>
    public unsafe byte ObstacleBodies_9
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 934); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 934); }
    }
    /// <summary>
    /// ByteProperty: ObstacleBodies
    /// </summary>
    public unsafe byte ObstacleBodies_10
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 935); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 935); }
    }
    /// <summary>
    /// ByteProperty: ObstacleBodies
    /// </summary>
    public unsafe byte ObstacleBodies_11
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 936); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 936); }
    }
    /// <summary>
    /// ByteProperty: ObstacleBodies
    /// </summary>
    public unsafe byte ObstacleBodies_12
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 937); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 937); }
    }
    /// <summary>
    /// ByteProperty: ObstacleBodies
    /// </summary>
    public unsafe byte ObstacleBodies_13
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 938); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 938); }
    }
    /// <summary>
    /// ByteProperty: ObstacleBodies
    /// </summary>
    public unsafe byte ObstacleBodies_14
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 939); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 939); }
    }
    /// <summary>
    /// ByteProperty: ObstacleBodies
    /// </summary>
    public unsafe byte ObstacleBodies_15
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 940); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 940); }
    }
    /// <summary>
    /// ByteProperty: ObstacleBodies
    /// </summary>
    public unsafe byte ObstacleBodies_16
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 941); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 941); }
    }
    /// <summary>
    /// ByteProperty: ObstacleBodies
    /// </summary>
    public unsafe byte ObstacleBodies_17
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 942); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 942); }
    }
    /// <summary>
    /// ByteProperty: ObstacleBodies
    /// </summary>
    public unsafe byte ObstacleBodies_18
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 943); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 943); }
    }
    /// <summary>
    /// ByteProperty: ObstacleBodies
    /// </summary>
    public unsafe byte ObstacleBodies_19
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 944); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 944); }
    }
    /// <summary>
    /// ByteProperty: ObstacleBodies
    /// </summary>
    public unsafe byte ObstacleBodies_20
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 945); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 945); }
    }
    /// <summary>
    /// ByteProperty: ObstacleBodies
    /// </summary>
    public unsafe byte ObstacleBodies_21
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 946); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 946); }
    }
    /// <summary>
    /// ByteProperty: ObstacleBodies
    /// </summary>
    public unsafe byte ObstacleBodies_22
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 947); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 947); }
    }
    /// <summary>
    /// ByteProperty: ObstacleBodies
    /// </summary>
    public unsafe byte ObstacleBodies_23
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 948); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 948); }
    }
    /// <summary>
    /// ByteProperty: ObstacleBodies
    /// </summary>
    public unsafe byte ObstacleBodies_24
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 949); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 949); }
    }
    /// <summary>
    /// ByteProperty: ObstacleBodies
    /// </summary>
    public unsafe byte ObstacleBodies_25
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 950); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 950); }
    }
    /// <summary>
    /// ByteProperty: ObstacleBodies
    /// </summary>
    public unsafe byte ObstacleBodies_26
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 951); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 951); }
    }
    /// <summary>
    /// ByteProperty: ObstacleBodies
    /// </summary>
    public unsafe byte ObstacleBodies_27
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 952); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 952); }
    }
    /// <summary>
    /// ByteProperty: ObstacleBodies
    /// </summary>
    public unsafe byte ObstacleBodies_28
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 953); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 953); }
    }
    /// <summary>
    /// ByteProperty: ObstacleBodies
    /// </summary>
    public unsafe byte ObstacleBodies_29
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 954); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 954); }
    }
    /// <summary>
    /// ByteProperty: ObstacleBodies
    /// </summary>
    public unsafe byte ObstacleBodies_30
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 955); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 955); }
    }
    /// <summary>
    /// ByteProperty: ObstacleBodies
    /// </summary>
    public unsafe byte ObstacleBodies_31
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 956); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 956); }
    }

    /// <summary>
    /// ByteProperty: ObstacleBodyIslands
    /// </summary>
    public unsafe byte ObstacleBodyIslands_0
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 957); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 957); }
    }
    /// <summary>
    /// ByteProperty: ObstacleBodyIslands
    /// </summary>
    public unsafe byte ObstacleBodyIslands_1
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 958); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 958); }
    }
    /// <summary>
    /// ByteProperty: ObstacleBodyIslands
    /// </summary>
    public unsafe byte ObstacleBodyIslands_2
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 959); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 959); }
    }
    /// <summary>
    /// ByteProperty: ObstacleBodyIslands
    /// </summary>
    public unsafe byte ObstacleBodyIslands_3
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 960); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 960); }
    }
    /// <summary>
    /// ByteProperty: ObstacleBodyIslands
    /// </summary>
    public unsafe byte ObstacleBodyIslands_4
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 961); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 961); }
    }
    /// <summary>
    /// ByteProperty: ObstacleBodyIslands
    /// </summary>
    public unsafe byte ObstacleBodyIslands_5
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 962); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 962); }
    }
    /// <summary>
    /// ByteProperty: ObstacleBodyIslands
    /// </summary>
    public unsafe byte ObstacleBodyIslands_6
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 963); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 963); }
    }
    /// <summary>
    /// ByteProperty: ObstacleBodyIslands
    /// </summary>
    public unsafe byte ObstacleBodyIslands_7
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 964); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 964); }
    }
    /// <summary>
    /// ByteProperty: ObstacleBodyIslands
    /// </summary>
    public unsafe byte ObstacleBodyIslands_8
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 965); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 965); }
    }
    /// <summary>
    /// ByteProperty: ObstacleBodyIslands
    /// </summary>
    public unsafe byte ObstacleBodyIslands_9
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 966); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 966); }
    }
    /// <summary>
    /// ByteProperty: ObstacleBodyIslands
    /// </summary>
    public unsafe byte ObstacleBodyIslands_10
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 967); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 967); }
    }
    /// <summary>
    /// ByteProperty: ObstacleBodyIslands
    /// </summary>
    public unsafe byte ObstacleBodyIslands_11
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 968); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 968); }
    }
    /// <summary>
    /// ByteProperty: ObstacleBodyIslands
    /// </summary>
    public unsafe byte ObstacleBodyIslands_12
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 969); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 969); }
    }
    /// <summary>
    /// ByteProperty: ObstacleBodyIslands
    /// </summary>
    public unsafe byte ObstacleBodyIslands_13
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 970); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 970); }
    }
    /// <summary>
    /// ByteProperty: ObstacleBodyIslands
    /// </summary>
    public unsafe byte ObstacleBodyIslands_14
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 971); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 971); }
    }
    /// <summary>
    /// ByteProperty: ObstacleBodyIslands
    /// </summary>
    public unsafe byte ObstacleBodyIslands_15
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 972); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 972); }
    }
    /// <summary>
    /// ByteProperty: ObstacleBodyIslands
    /// </summary>
    public unsafe byte ObstacleBodyIslands_16
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 973); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 973); }
    }
    /// <summary>
    /// ByteProperty: ObstacleBodyIslands
    /// </summary>
    public unsafe byte ObstacleBodyIslands_17
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 974); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 974); }
    }
    /// <summary>
    /// ByteProperty: ObstacleBodyIslands
    /// </summary>
    public unsafe byte ObstacleBodyIslands_18
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 975); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 975); }
    }
    /// <summary>
    /// ByteProperty: ObstacleBodyIslands
    /// </summary>
    public unsafe byte ObstacleBodyIslands_19
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 976); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 976); }
    }
    /// <summary>
    /// ByteProperty: ObstacleBodyIslands
    /// </summary>
    public unsafe byte ObstacleBodyIslands_20
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 977); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 977); }
    }
    /// <summary>
    /// ByteProperty: ObstacleBodyIslands
    /// </summary>
    public unsafe byte ObstacleBodyIslands_21
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 978); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 978); }
    }
    /// <summary>
    /// ByteProperty: ObstacleBodyIslands
    /// </summary>
    public unsafe byte ObstacleBodyIslands_22
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 979); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 979); }
    }
    /// <summary>
    /// ByteProperty: ObstacleBodyIslands
    /// </summary>
    public unsafe byte ObstacleBodyIslands_23
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 980); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 980); }
    }
    /// <summary>
    /// ByteProperty: ObstacleBodyIslands
    /// </summary>
    public unsafe byte ObstacleBodyIslands_24
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 981); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 981); }
    }
    /// <summary>
    /// ByteProperty: ObstacleBodyIslands
    /// </summary>
    public unsafe byte ObstacleBodyIslands_25
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 982); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 982); }
    }
    /// <summary>
    /// ByteProperty: ObstacleBodyIslands
    /// </summary>
    public unsafe byte ObstacleBodyIslands_26
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 983); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 983); }
    }
    /// <summary>
    /// ByteProperty: ObstacleBodyIslands
    /// </summary>
    public unsafe byte ObstacleBodyIslands_27
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 984); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 984); }
    }
    /// <summary>
    /// ByteProperty: ObstacleBodyIslands
    /// </summary>
    public unsafe byte ObstacleBodyIslands_28
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 985); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 985); }
    }
    /// <summary>
    /// ByteProperty: ObstacleBodyIslands
    /// </summary>
    public unsafe byte ObstacleBodyIslands_29
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 986); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 986); }
    }
    /// <summary>
    /// ByteProperty: ObstacleBodyIslands
    /// </summary>
    public unsafe byte ObstacleBodyIslands_30
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 987); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 987); }
    }
    /// <summary>
    /// ByteProperty: ObstacleBodyIslands
    /// </summary>
    public unsafe byte ObstacleBodyIslands_31
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 988); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 988); }
    }

    /// <summary>
    /// FloatProperty: DeformParticlesSmallThreshold
    /// </summary>
    public unsafe float DeformParticlesSmallThreshold
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 992); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 992); }
    }

    /// <summary>
    /// FloatProperty: DeformParticlesMediumThreshold
    /// </summary>
    public unsafe float DeformParticlesMediumThreshold
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 996); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 996); }
    }

    /// <summary>
    /// FloatProperty: DeformParticlesLargeThreshold
    /// </summary>
    public unsafe float DeformParticlesLargeThreshold
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1000); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1000); }
    }

    /// <summary>
    /// FloatProperty: ImpactParticlesSmallThreshold
    /// </summary>
    public unsafe float ImpactParticlesSmallThreshold
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1004); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1004); }
    }

    /// <summary>
    /// FloatProperty: ImpactParticlesMediumThreshold
    /// </summary>
    public unsafe float ImpactParticlesMediumThreshold
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1008); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1008); }
    }

    /// <summary>
    /// FloatProperty: ImpactParticlesLargeThreshold
    /// </summary>
    public unsafe float ImpactParticlesLargeThreshold
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1012); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1012); }
    }

    /// <summary>
    /// FloatProperty: FlipTime
    /// </summary>
    public unsafe float FlipTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1016); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1016); }
    }

    /// <summary>
    /// StructProperty: FlipTorque
    /// </summary>
    public unsafe System.Numerics.Vector3 FlipTorque
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 1020); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1020); }
    }

    /// <summary>
    /// FloatProperty: HowFarCanItFall
    /// </summary>
    public unsafe float HowFarCanItFall
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1032); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1032); }
    }

    /// <summary>
    /// ArrayProperty: CachedBodyToBone
    /// </summary>
    public unsafe BmSDK.TArray<int> CachedBodyToBone
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<int>>(Ptr + 1036); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1036); }
    }
}
