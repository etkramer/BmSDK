#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RDestructibleProp_PointLight<br/>
/// (flags = 0)
/// </summary>
public partial class RDestructibleProp_PointLight : BmSDK.BmGame.RDestructibleProp, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RDestructibleProp_PointLight", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RDestructibleProp_PointLight() { }

    /// <summary>
    /// Constructs a new RDestructibleProp_PointLight
    /// </summary>
    public RDestructibleProp_PointLight(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RDestructibleProp_PointLight Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RDestructibleProp_PointLight(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="Engine.Actor.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RDestructibleProp_PointLight>
        => ((Engine.Actor)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="Engine.Actor.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RDestructibleProp_PointLight>, new()
        => (TComponent)((Engine.Actor)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="Engine.Actor.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RDestructibleProp_PointLight>
        => ((Engine.Actor)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="Engine.Actor.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RDestructibleProp_PointLight>
        => ((Engine.Actor)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="Engine.Actor.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RDestructibleProp_PointLight>
        => (TComponent)((Engine.Actor)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="Engine.Actor.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RDestructibleProp_PointLight>
        => ((Engine.Actor)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="Engine.Actor.DetachScriptComponent(Type)"/>
    public void DetachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RDestructibleProp_PointLight>
        => ((Engine.Actor)this).DetachScriptComponent(typeof(TComponent));

    /// <summary>
    /// StructProperty: VfTable_IInterface_NavMeshPathObstacle
    /// </summary>
    public unsafe System.IntPtr VfTable_IInterface_NavMeshPathObstacle
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.IntPtr>(Ptr + 772); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 772); }
    }

    /// <summary>
    /// StructProperty: VfTable_IInterface_NavMeshPathObject
    /// </summary>
    public unsafe System.IntPtr VfTable_IInterface_NavMeshPathObject
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.IntPtr>(Ptr + 780); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 780); }
    }

    /// <summary>
    /// StructProperty: InitialAppearance
    /// </summary>
    public unsafe BmSDK.BmGame.RDestructibleProp.FDestructibleAppearance InitialAppearance
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RDestructibleProp.FDestructibleAppearance>(Ptr + 788); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 788); }
    }

    /// <summary>
    /// ObjectProperty: StaticMeshForClimbableInfo
    /// </summary>
    public unsafe BmSDK.Engine.StaticMesh StaticMeshForClimbableInfo
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.StaticMesh>(Ptr + 912); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 912); }
    }

    /// <summary>
    /// ObjectProperty: InitialSoundEffect
    /// </summary>
    public unsafe BmSDK.Engine.AkEvent InitialSoundEffect
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkEvent>(Ptr + 920); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 920); }
    }

    /// <summary>
    /// ObjectProperty: ParticleEmitter
    /// </summary>
    public unsafe BmSDK.Engine.Emitter ParticleEmitter
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.Emitter>(Ptr + 928); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 928); }
    }

    /// <summary>
    /// ObjectProperty: ClimbEdgeFloorActor
    /// </summary>
    public unsafe BmSDK.Engine.Actor ClimbEdgeFloorActor
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.Actor>(Ptr + 936); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 936); }
    }

    /// <summary>
    /// ObjectProperty: ImpactDamageCauserThisFrame
    /// </summary>
    public unsafe BmSDK.Engine.Actor ImpactDamageCauserThisFrame
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.Actor>(Ptr + 944); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 944); }
    }

    /// <summary>
    /// ObjectProperty: CachedShardSound
    /// </summary>
    public unsafe BmSDK.Engine.AkEvent CachedShardSound
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkEvent>(Ptr + 952); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 952); }
    }

    /// <summary>
    /// ObjectProperty: CachedDamageSound
    /// </summary>
    public unsafe BmSDK.Engine.AkEvent CachedDamageSound
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkEvent>(Ptr + 960); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 960); }
    }

    /// <summary>
    /// ObjectProperty: DecorationSkeletalMesh
    /// </summary>
    public unsafe BmSDK.Engine.SkeletalMesh DecorationSkeletalMesh
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.SkeletalMesh>(Ptr + 968); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 968); }
    }

    /// <summary>
    /// ObjectProperty: DecorationPhysicsAsset
    /// </summary>
    public unsafe BmSDK.Engine.PhysicsAsset DecorationPhysicsAsset
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.PhysicsAsset>(Ptr + 976); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 976); }
    }

    /// <summary>
    /// ObjectProperty: BlockedRoadLink
    /// </summary>
    public unsafe BmSDK.BmGame.RRoadLink BlockedRoadLink
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RRoadLink>(Ptr + 984); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 984); }
    }

    /// <summary>
    /// ObjectProperty: VehicleDustTrailParticleEffect
    /// </summary>
    public unsafe BmSDK.Engine.ParticleSystem VehicleDustTrailParticleEffect
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleSystem>(Ptr + 992); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 992); }
    }

    /// <summary>
    /// ClassProperty: ExplosiveGelDamageType
    /// </summary>
    public unsafe BmSDK.Class ExplosiveGelDamageType
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Class>(Ptr + 1000); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1000); }
    }

    /// <summary>
    /// ComponentProperty: DecorationSkelMeshComp
    /// </summary>
    public unsafe BmSDK.Engine.SkeletalMeshComponent DecorationSkelMeshComp
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.SkeletalMeshComponent>(Ptr + 1008); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1008); }
    }

    /// <summary>
    /// ComponentProperty: RDestructibleComponent
    /// </summary>
    public unsafe BmSDK.BmGame.RApexStaticDestructibleComponent RDestructibleComponent
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RApexStaticDestructibleComponent>(Ptr + 1016); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1016); }
    }

    /// <summary>
    /// ComponentProperty: LensFlareComp4
    /// </summary>
    public unsafe BmSDK.Engine.LensFlareComponent LensFlareComp4
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.LensFlareComponent>(Ptr + 1024); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1024); }
    }

    /// <summary>
    /// ComponentProperty: LensFlareComp3
    /// </summary>
    public unsafe BmSDK.Engine.LensFlareComponent LensFlareComp3
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.LensFlareComponent>(Ptr + 1032); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1032); }
    }

    /// <summary>
    /// ComponentProperty: LensFlareComp2
    /// </summary>
    public unsafe BmSDK.Engine.LensFlareComponent LensFlareComp2
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.LensFlareComponent>(Ptr + 1040); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1040); }
    }

    /// <summary>
    /// ComponentProperty: LensFlareComp
    /// </summary>
    public unsafe BmSDK.Engine.LensFlareComponent LensFlareComp
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.LensFlareComponent>(Ptr + 1048); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1048); }
    }

    /// <summary>
    /// ComponentProperty: LightComp4
    /// </summary>
    public unsafe BmSDK.Engine.PointLightComponent LightComp4
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.PointLightComponent>(Ptr + 1056); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1056); }
    }

    /// <summary>
    /// ComponentProperty: LightComp3
    /// </summary>
    public unsafe BmSDK.Engine.PointLightComponent LightComp3
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.PointLightComponent>(Ptr + 1064); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1064); }
    }

    /// <summary>
    /// ComponentProperty: LightComp2
    /// </summary>
    public unsafe BmSDK.Engine.PointLightComponent LightComp2
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.PointLightComponent>(Ptr + 1072); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1072); }
    }

    /// <summary>
    /// ComponentProperty: LightComp
    /// </summary>
    public unsafe BmSDK.Engine.PointLightComponent LightComp
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.PointLightComponent>(Ptr + 1080); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1080); }
    }

    /// <summary>
    /// ComponentProperty: MeshComp
    /// </summary>
    public unsafe BmSDK.Engine.MeshComponent MeshComp
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.MeshComponent>(Ptr + 1088); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1088); }
    }

    /// <summary>
    /// ComponentProperty: InitialParticleSystem
    /// </summary>
    public unsafe BmSDK.Engine.ParticleSystemComponent InitialParticleSystem
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleSystemComponent>(Ptr + 1096); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1096); }
    }

    /// <summary>
    /// StructProperty: InitalAppearancePivotOffset
    /// </summary>
    public unsafe System.Numerics.Vector3 InitalAppearancePivotOffset
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 1104); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1104); }
    }

    /// <summary>
    /// NameProperty: InitialParticleSystemSocket
    /// </summary>
    public unsafe BmSDK.FName InitialParticleSystemSocket
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 1116); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1116); }
    }

    /// <summary>
    /// BoolProperty: DeferredInitialAppearanceUpdate
    /// </summary>
    public unsafe bool DeferredInitialAppearanceUpdate
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1124) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1124); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1124); }
    }

    /// <summary>
    /// BoolProperty: HideInRiot
    /// </summary>
    public unsafe bool HideInRiot
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1124) & 2) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1124); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1124); }
    }

    /// <summary>
    /// BoolProperty: BlocksHeavyProjectiles
    /// </summary>
    public unsafe bool BlocksHeavyProjectiles
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1124) & 4) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1124); var newMask = value ? (currentMask | 4) : (currentMask & ~4); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1124); }
    }

    /// <summary>
    /// BoolProperty: PushedByHumans
    /// </summary>
    public unsafe bool PushedByHumans
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1124) & 8) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1124); var newMask = value ? (currentMask | 8) : (currentMask & ~8); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1124); }
    }

    /// <summary>
    /// BoolProperty: BrokenByHumans
    /// </summary>
    public unsafe bool BrokenByHumans
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1124) & 16) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1124); var newMask = value ? (currentMask | 16) : (currentMask & ~16); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1124); }
    }

    /// <summary>
    /// BoolProperty: BrokenByThrownRagdolls
    /// </summary>
    public unsafe bool BrokenByThrownRagdolls
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1124) & 32) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1124); var newMask = value ? (currentMask | 32) : (currentMask & ~32); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1124); }
    }

    /// <summary>
    /// BoolProperty: BrokenByPlayer
    /// </summary>
    public unsafe bool BrokenByPlayer
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1124) & 64) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1124); var newMask = value ? (currentMask | 64) : (currentMask & ~64); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1124); }
    }

    /// <summary>
    /// BoolProperty: bObstacleRegistered
    /// </summary>
    public unsafe bool bObstacleRegistered
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1124) & 128) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1124); var newMask = value ? (currentMask | 128) : (currentMask & ~128); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1124); }
    }

    /// <summary>
    /// BoolProperty: bQueuedObstacleRemove
    /// </summary>
    public unsafe bool bQueuedObstacleRemove
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1124) & 256) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1124); var newMask = value ? (currentMask | 256) : (currentMask & ~256); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1124); }
    }

    /// <summary>
    /// BoolProperty: bUnregisteredInStreamOutOrDestroyed
    /// </summary>
    public unsafe bool bUnregisteredInStreamOutOrDestroyed
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1124) & 512) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1124); var newMask = value ? (currentMask | 512) : (currentMask & ~512); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1124); }
    }

    /// <summary>
    /// BoolProperty: bUseDynamicClimbingInfo
    /// </summary>
    public unsafe bool bUseDynamicClimbingInfo
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1124) & 1024) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1124); var newMask = value ? (currentMask | 1024) : (currentMask & ~1024); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1124); }
    }

    /// <summary>
    /// BoolProperty: IsApex
    /// </summary>
    public unsafe bool IsApex
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1124) & 2048) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1124); var newMask = value ? (currentMask | 2048) : (currentMask & ~2048); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1124); }
    }

    /// <summary>
    /// BoolProperty: bAddSpecialNavEdges
    /// </summary>
    public unsafe bool bAddSpecialNavEdges
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1124) & 4096) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1124); var newMask = value ? (currentMask | 4096) : (currentMask & ~4096); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1124); }
    }

    /// <summary>
    /// BoolProperty: bRebuildSpecialNavEdges
    /// </summary>
    public unsafe bool bRebuildSpecialNavEdges
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1124) & 8192) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1124); var newMask = value ? (currentMask | 8192) : (currentMask & ~8192); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1124); }
    }

    /// <summary>
    /// BoolProperty: bDisabledObstaclePolys
    /// </summary>
    public unsafe bool bDisabledObstaclePolys
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1124) & 16384) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1124); var newMask = value ? (currentMask | 16384) : (currentMask & ~16384); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1124); }
    }

    /// <summary>
    /// BoolProperty: Debug_DisableObstaclePolys
    /// </summary>
    public unsafe bool Debug_DisableObstaclePolys
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1124) & 32768) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1124); var newMask = value ? (currentMask | 32768) : (currentMask & ~32768); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1124); }
    }

    /// <summary>
    /// BoolProperty: Debug_EnableObstaclePolys
    /// </summary>
    public unsafe bool Debug_EnableObstaclePolys
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1124) & 65536) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1124); var newMask = value ? (currentMask | 65536) : (currentMask & ~65536); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1124); }
    }

    /// <summary>
    /// BoolProperty: Debug_RegisterObstacleDynamic
    /// </summary>
    public unsafe bool Debug_RegisterObstacleDynamic
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1124) & 131072) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1124); var newMask = value ? (currentMask | 131072) : (currentMask & ~131072); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1124); }
    }

    /// <summary>
    /// BoolProperty: bClearedNavMeshEdgeCosts
    /// </summary>
    public unsafe bool bClearedNavMeshEdgeCosts
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1124) & 262144) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1124); var newMask = value ? (currentMask | 262144) : (currentMask & ~262144); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1124); }
    }

    /// <summary>
    /// BoolProperty: bCanBeUsedForJokerHallucination
    /// </summary>
    public unsafe bool bCanBeUsedForJokerHallucination
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1124) & 524288) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1124); var newMask = value ? (currentMask | 524288) : (currentMask & ~524288); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1124); }
    }

    /// <summary>
    /// BoolProperty: bSetAppearanceCalled
    /// </summary>
    public unsafe bool bSetAppearanceCalled
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1124) & 1048576) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1124); var newMask = value ? (currentMask | 1048576) : (currentMask & ~1048576); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1124); }
    }

    /// <summary>
    /// BoolProperty: InitialDamageOnlyByArmouredVehicles
    /// </summary>
    public unsafe bool InitialDamageOnlyByArmouredVehicles
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1124) & 2097152) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1124); var newMask = value ? (currentMask | 2097152) : (currentMask & ~2097152); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1124); }
    }

    /// <summary>
    /// BoolProperty: bDrawInFrontOfPostProcessWhenInXrayMode
    /// </summary>
    public unsafe bool bDrawInFrontOfPostProcessWhenInXrayMode
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1124) & 4194304) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1124); var newMask = value ? (currentMask | 4194304) : (currentMask & ~4194304); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1124); }
    }

    /// <summary>
    /// BoolProperty: bDrawInForegroundAndInFrontOfPostProcessWhenInXrayMode
    /// </summary>
    public unsafe bool bDrawInForegroundAndInFrontOfPostProcessWhenInXrayMode
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1124) & 8388608) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1124); var newMask = value ? (currentMask | 8388608) : (currentMask & ~8388608); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1124); }
    }

    /// <summary>
    /// BoolProperty: bDrawInFrontOfPostProcessWhenInThermalMode
    /// </summary>
    public unsafe bool bDrawInFrontOfPostProcessWhenInThermalMode
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1124) & 16777216) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1124); var newMask = value ? (currentMask | 16777216) : (currentMask & ~16777216); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1124); }
    }

    /// <summary>
    /// BoolProperty: bDrawInForegroundAndInFrontOfPostProcessWhenInThermalMode
    /// </summary>
    public unsafe bool bDrawInForegroundAndInFrontOfPostProcessWhenInThermalMode
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1124) & 33554432) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1124); var newMask = value ? (currentMask | 33554432) : (currentMask & ~33554432); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1124); }
    }

    /// <summary>
    /// BoolProperty: bDrawInFrontOfPostProcessWhenInBatmobileViewMode
    /// </summary>
    public unsafe bool bDrawInFrontOfPostProcessWhenInBatmobileViewMode
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1124) & 67108864) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1124); var newMask = value ? (currentMask | 67108864) : (currentMask & ~67108864); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1124); }
    }

    /// <summary>
    /// BoolProperty: bDrawInForegroundAndInFrontOfPostProcessWhenInBatmobileViewMode
    /// </summary>
    public unsafe bool bDrawInForegroundAndInFrontOfPostProcessWhenInBatmobileViewMode
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1124) & 134217728) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1124); var newMask = value ? (currentMask | 134217728) : (currentMask & ~134217728); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1124); }
    }

    /// <summary>
    /// BoolProperty: bReflectionProbeNoSee
    /// </summary>
    public unsafe bool bReflectionProbeNoSee
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1124) & 268435456) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1124); var newMask = value ? (currentMask | 268435456) : (currentMask & ~268435456); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1124); }
    }

    /// <summary>
    /// BoolProperty: CastShadow
    /// </summary>
    public unsafe bool CastShadow
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1124) & 536870912) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1124); var newMask = value ? (currentMask | 536870912) : (currentMask & ~536870912); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1124); }
    }

    /// <summary>
    /// BoolProperty: DontDamageCollidingVehicle
    /// </summary>
    public unsafe bool DontDamageCollidingVehicle
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1124) & 1073741824) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1124); var newMask = value ? (currentMask | 1073741824) : (currentMask & ~1073741824); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1124); }
    }

    /// <summary>
    /// BoolProperty: bRegisterNavMeshObstacle
    /// </summary>
    public unsafe bool bRegisterNavMeshObstacle
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1124) & -2147483648) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1124); var newMask = value ? (currentMask | -2147483648) : (currentMask & ~-2147483648); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1124); }
    }

    /// <summary>
    /// BoolProperty: bPreCutFromNavMesh
    /// </summary>
    public unsafe bool bPreCutFromNavMesh
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1128) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1128); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1128); }
    }

    /// <summary>
    /// BoolProperty: bIsPreCut
    /// </summary>
    public unsafe bool bIsPreCut
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1128) & 2) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1128); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1128); }
    }

    /// <summary>
    /// BoolProperty: bDisablePreCuttingByDefault
    /// </summary>
    public unsafe bool bDisablePreCuttingByDefault
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1128) & 4) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1128); var newMask = value ? (currentMask | 4) : (currentMask & ~4); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1128); }
    }

    /// <summary>
    /// BoolProperty: bHaveRunInitialiseNavMesh
    /// </summary>
    public unsafe bool bHaveRunInitialiseNavMesh
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1128) & 8) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1128); var newMask = value ? (currentMask | 8) : (currentMask & ~8); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1128); }
    }

    /// <summary>
    /// BoolProperty: bRegisterAfterInit
    /// </summary>
    public unsafe bool bRegisterAfterInit
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1128) & 16) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1128); var newMask = value ? (currentMask | 16) : (currentMask & ~16); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1128); }
    }

    /// <summary>
    /// BoolProperty: bDisableObstacleSnapToFloor
    /// </summary>
    public unsafe bool bDisableObstacleSnapToFloor
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1128) & 32) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1128); var newMask = value ? (currentMask | 32) : (currentMask & ~32); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1128); }
    }

    /// <summary>
    /// BoolProperty: bDebugMe
    /// </summary>
    public unsafe bool bDebugMe
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1128) & 64) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1128); var newMask = value ? (currentMask | 64) : (currentMask & ~64); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1128); }
    }

    /// <summary>
    /// BoolProperty: bUseUpdatedNavMeshCalculation
    /// </summary>
    public unsafe bool bUseUpdatedNavMeshCalculation
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1128) & 128) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1128); var newMask = value ? (currentMask | 128) : (currentMask & ~128); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1128); }
    }

    /// <summary>
    /// BoolProperty: bImmediatelyUnregisterFromNavMeshOnDestruction
    /// </summary>
    public unsafe bool bImmediatelyUnregisterFromNavMeshOnDestruction
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1128) & 256) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1128); var newMask = value ? (currentMask | 256) : (currentMask & ~256); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1128); }
    }

    /// <summary>
    /// BoolProperty: bImmediatelyUnregisterPreCutPolys
    /// </summary>
    public unsafe bool bImmediatelyUnregisterPreCutPolys
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1128) & 512) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1128); var newMask = value ? (currentMask | 512) : (currentMask & ~512); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1128); }
    }

    /// <summary>
    /// BoolProperty: bLeaveNavMeshWhenHidden
    /// </summary>
    public unsafe bool bLeaveNavMeshWhenHidden
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1128) & 1024) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1128); var newMask = value ? (currentMask | 1024) : (currentMask & ~1024); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1128); }
    }

    /// <summary>
    /// BoolProperty: bDamagedInCurrentStage
    /// </summary>
    public unsafe bool bDamagedInCurrentStage
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1128) & 2048) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1128); var newMask = value ? (currentMask | 2048) : (currentMask & ~2048); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1128); }
    }

    /// <summary>
    /// BoolProperty: bHasTakenInitialDamage
    /// </summary>
    public unsafe bool bHasTakenInitialDamage
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1128) & 4096) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1128); var newMask = value ? (currentMask | 4096) : (currentMask & ~4096); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1128); }
    }

    /// <summary>
    /// BoolProperty: bSaveDamageStateInSaveGame
    /// </summary>
    public unsafe bool bSaveDamageStateInSaveGame
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1128) & 8192) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1128); var newMask = value ? (currentMask | 8192) : (currentMask & ~8192); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1128); }
    }

    /// <summary>
    /// BoolProperty: bDecorationMeshHasBrokenOff
    /// </summary>
    public unsafe bool bDecorationMeshHasBrokenOff
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1128) & 16384) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1128); var newMask = value ? (currentMask | 16384) : (currentMask & ~16384); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1128); }
    }

    /// <summary>
    /// BoolProperty: bGangInteracting
    /// </summary>
    public unsafe bool bGangInteracting
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1128) & 32768) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1128); var newMask = value ? (currentMask | 32768) : (currentMask & ~32768); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1128); }
    }

    /// <summary>
    /// BoolProperty: bPostInitComponentRBPhysComplete
    /// </summary>
    public unsafe bool bPostInitComponentRBPhysComplete
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1128) & 65536) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1128); var newMask = value ? (currentMask | 65536) : (currentMask & ~65536); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1128); }
    }

    /// <summary>
    /// BoolProperty: bApexDestructibleWentToSleepThisFrame
    /// </summary>
    public unsafe bool bApexDestructibleWentToSleepThisFrame
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1128) & 131072) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1128); var newMask = value ? (currentMask | 131072) : (currentMask & ~131072); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1128); }
    }

    /// <summary>
    /// BoolProperty: bRemoveOtherBasedActorsNextTick
    /// </summary>
    public unsafe bool bRemoveOtherBasedActorsNextTick
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1128) & 262144) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1128); var newMask = value ? (currentMask | 262144) : (currentMask & ~262144); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1128); }
    }

    /// <summary>
    /// BoolProperty: DestroyedByBatmawnWhenEjecting
    /// </summary>
    public unsafe bool DestroyedByBatmawnWhenEjecting
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1128) & 524288) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1128); var newMask = value ? (currentMask | 524288) : (currentMask & ~524288); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1128); }
    }

    /// <summary>
    /// BoolProperty: bHasCachedNavMeshShape
    /// </summary>
    public unsafe bool bHasCachedNavMeshShape
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1128) & 1048576) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1128); var newMask = value ? (currentMask | 1048576) : (currentMask & ~1048576); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1128); }
    }

    /// <summary>
    /// BoolProperty: bHasCachedNavMeshShapeSuccessfully
    /// </summary>
    public unsafe bool bHasCachedNavMeshShapeSuccessfully
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1128) & 2097152) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1128); var newMask = value ? (currentMask | 2097152) : (currentMask & ~2097152); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1128); }
    }

    /// <summary>
    /// BoolProperty: bCanBreakOnAnything
    /// </summary>
    public unsafe bool bCanBreakOnAnything
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1128) & 4194304) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1128); var newMask = value ? (currentMask | 4194304) : (currentMask & ~4194304); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1128); }
    }

    /// <summary>
    /// BoolProperty: AlwaysBreaksWithHighThrottle
    /// </summary>
    public unsafe bool AlwaysBreaksWithHighThrottle
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1128) & 8388608) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1128); var newMask = value ? (currentMask | 8388608) : (currentMask & ~8388608); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1128); }
    }

    /// <summary>
    /// BoolProperty: AlwaysBreaksWithFullBattleModePush
    /// </summary>
    public unsafe bool AlwaysBreaksWithFullBattleModePush
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1128) & 16777216) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1128); var newMask = value ? (currentMask | 16777216) : (currentMask & ~16777216); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1128); }
    }

    /// <summary>
    /// BoolProperty: RoadsideBarrier
    /// </summary>
    public unsafe bool RoadsideBarrier
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1128) & 33554432) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1128); var newMask = value ? (currentMask | 33554432) : (currentMask & ~33554432); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1128); }
    }

    /// <summary>
    /// BoolProperty: bDamagedOnTouch
    /// </summary>
    public unsafe bool bDamagedOnTouch
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1128) & 67108864) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1128); var newMask = value ? (currentMask | 67108864) : (currentMask & ~67108864); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1128); }
    }

    /// <summary>
    /// BoolProperty: bWasDisabledByFlag
    /// </summary>
    public unsafe bool bWasDisabledByFlag
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1128) & 134217728) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1128); var newMask = value ? (currentMask | 134217728) : (currentMask & ~134217728); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1128); }
    }

    /// <summary>
    /// BoolProperty: bReformOnChallengeModeBegin
    /// </summary>
    public unsafe bool bReformOnChallengeModeBegin
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1128) & 268435456) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1128); var newMask = value ? (currentMask | 268435456) : (currentMask & ~268435456); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1128); }
    }

    /// <summary>
    /// BoolProperty: bAllowOverrideDamageFromExplosiveGel
    /// </summary>
    public unsafe bool bAllowOverrideDamageFromExplosiveGel
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1128) & 536870912) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1128); var newMask = value ? (currentMask | 536870912) : (currentMask & ~536870912); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1128); }
    }

    /// <summary>
    /// BoolProperty: bEnableApexDestructibleHardSleeping
    /// </summary>
    public unsafe bool bEnableApexDestructibleHardSleeping
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1128) & 1073741824) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1128); var newMask = value ? (currentMask | 1073741824) : (currentMask & ~1073741824); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1128); }
    }

    /// <summary>
    /// BoolProperty: bPawnCanBaseOn
    /// </summary>
    public unsafe bool bPawnCanBaseOn
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1128) & -2147483648) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1128); var newMask = value ? (currentMask | -2147483648) : (currentMask & ~-2147483648); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1128); }
    }

    /// <summary>
    /// BoolProperty: bCallSetHiddenWhenInitRBPhysCompleted
    /// </summary>
    public unsafe bool bCallSetHiddenWhenInitRBPhysCompleted
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1132) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1132); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1132); }
    }

    /// <summary>
    /// BoolProperty: bValueOfSetHiddenWhenInitRBPhysCompleted
    /// </summary>
    public unsafe bool bValueOfSetHiddenWhenInitRBPhysCompleted
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1132) & 2) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1132); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1132); }
    }

    /// <summary>
    /// BoolProperty: bMovableApex
    /// </summary>
    public unsafe bool bMovableApex
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1132) & 4) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1132); var newMask = value ? (currentMask | 4) : (currentMask & ~4); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1132); }
    }

    /// <summary>
    /// ArrayProperty: Materials
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.Engine.MaterialInterface> Materials
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.MaterialInterface>>(Ptr + 1136); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1136); }
    }

    /// <summary>
    /// FloatProperty: PrimedAppearanceRange
    /// </summary>
    public unsafe float PrimedAppearanceRange
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1152); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1152); }
    }

    /// <summary>
    /// FloatProperty: PrimedAppearanceSpeed
    /// </summary>
    public unsafe float PrimedAppearanceSpeed
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1156); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1156); }
    }

    /// <summary>
    /// FloatProperty: Health
    /// </summary>
    public unsafe float Health
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1160); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1160); }
    }

    /// <summary>
    /// ArrayProperty: DamageStages
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RDestructibleProp.FDestructStage> DamageStages
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RDestructibleProp.FDestructStage>>(Ptr + 1164); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1164); }
    }

    /// <summary>
    /// IntProperty: CurrentDamageStage
    /// </summary>
    public unsafe int CurrentDamageStage
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1180); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1180); }
    }

    /// <summary>
    /// IntProperty: DeferredDamageStage
    /// </summary>
    public unsafe int DeferredDamageStage
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1184); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1184); }
    }

    /// <summary>
    /// FloatProperty: CurrentDamageStageTime
    /// </summary>
    public unsafe float CurrentDamageStageTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1188); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1188); }
    }

    /// <summary>
    /// StructProperty: ImpactVelocity
    /// </summary>
    public unsafe System.Numerics.Vector3 ImpactVelocity
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 1192); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1192); }
    }

    /// <summary>
    /// FloatProperty: ParticleVelocityInitialScale
    /// </summary>
    public unsafe float ParticleVelocityInitialScale
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1204); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1204); }
    }

    /// <summary>
    /// FloatProperty: ParticleVelocityFalloffSpeed
    /// </summary>
    public unsafe float ParticleVelocityFalloffSpeed
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1208); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1208); }
    }

    /// <summary>
    /// StructProperty: WhooshStartOffset
    /// </summary>
    public unsafe System.Numerics.Vector3 WhooshStartOffset
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 1212); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1212); }
    }

    /// <summary>
    /// StructProperty: WhooshStopOffset
    /// </summary>
    public unsafe System.Numerics.Vector3 WhooshStopOffset
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 1224); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1224); }
    }

    /// <summary>
    /// ArrayProperty: WhooshBys
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RDestructibleProp.FDestructWhooshBy> WhooshBys
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RDestructibleProp.FDestructWhooshBy>>(Ptr + 1236); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1236); }
    }

    /// <summary>
    /// FloatProperty: ParticleVelocityFalloff
    /// </summary>
    public unsafe float ParticleVelocityFalloff
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1252); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1252); }
    }

    /// <summary>
    /// ArrayProperty: VulnerableDamageTypes
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.Class> VulnerableDamageTypes
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Class>>(Ptr + 1256); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1256); }
    }

    /// <summary>
    /// ArrayProperty: InVulnerableDamageTypes
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.Class> InVulnerableDamageTypes
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Class>>(Ptr + 1272); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1272); }
    }

    /// <summary>
    /// StructProperty: PreviousObstacleLocation
    /// </summary>
    public unsafe System.Numerics.Vector3 PreviousObstacleLocation
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 1288); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1288); }
    }

    /// <summary>
    /// FloatProperty: ApproxMassForImpactEffects
    /// </summary>
    public unsafe float ApproxMassForImpactEffects
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1300); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1300); }
    }

    /// <summary>
    /// ByteProperty: ClimbEdgeFailReason
    /// </summary>
    public unsafe BmSDK.BmGame.RGameInfo.EClimbEdgeFailReason ClimbEdgeFailReason
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RGameInfo.EClimbEdgeFailReason>(Ptr + 1304); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1304); }
    }

    /// <summary>
    /// ByteProperty: EdgeJumpType
    /// </summary>
    public unsafe BmSDK.BmGame.RGameInfo.FenceJumpEdgeType EdgeJumpType
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RGameInfo.FenceJumpEdgeType>(Ptr + 1305); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1305); }
    }

    /// <summary>
    /// ByteProperty: RBChannel
    /// </summary>
    public unsafe BmSDK.Engine.PrimitiveComponent.ERBCollisionChannel RBChannel
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.PrimitiveComponent.ERBCollisionChannel>(Ptr + 1306); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1306); }
    }

    /// <summary>
    /// ByteProperty: DebugDestructibleArchetype
    /// </summary>
    public unsafe BmSDK.BmGame.RDestructibleProp.EDebugDestructibleArchetype DebugDestructibleArchetype
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RDestructibleProp.EDebugDestructibleArchetype>(Ptr + 1307); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1307); }
    }

    /// <summary>
    /// ByteProperty: DebugTickingReason
    /// </summary>
    public unsafe BmSDK.BmGame.RDestructibleProp.EDebugDestructiblesTickReason DebugTickingReason
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RDestructibleProp.EDebugDestructiblesTickReason>(Ptr + 1308); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1308); }
    }

    /// <summary>
    /// ByteProperty: RBDominanceGroup
    /// </summary>
    public unsafe byte RBDominanceGroup
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 1309); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1309); }
    }

    /// <summary>
    /// ByteProperty: DepthPriorityGroup
    /// </summary>
    public unsafe BmSDK.Engine.Scene.ESceneDepthPriorityGroup DepthPriorityGroup
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.Scene.ESceneDepthPriorityGroup>(Ptr + 1310); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1310); }
    }

    /// <summary>
    /// StructProperty: ClimbEdgeStart
    /// </summary>
    public unsafe System.Numerics.Vector3 ClimbEdgeStart
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 1312); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1312); }
    }

    /// <summary>
    /// StructProperty: ClimbEdgeEnd
    /// </summary>
    public unsafe System.Numerics.Vector3 ClimbEdgeEnd
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 1324); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1324); }
    }

    /// <summary>
    /// FloatProperty: ClimbEdgeHeight
    /// </summary>
    public unsafe float ClimbEdgeHeight
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1336); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1336); }
    }

    /// <summary>
    /// FloatProperty: ClimbEdgeWidth
    /// </summary>
    public unsafe float ClimbEdgeWidth
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1340); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1340); }
    }

    /// <summary>
    /// FloatProperty: ClimbEdgeDepth
    /// </summary>
    public unsafe float ClimbEdgeDepth
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1344); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1344); }
    }

    /// <summary>
    /// FloatProperty: ClimbEdgeFloorHeight
    /// </summary>
    public unsafe float ClimbEdgeFloorHeight
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1348); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1348); }
    }

    /// <summary>
    /// ArrayProperty: SpecialNavEdgeList
    /// </summary>
    public unsafe BmSDK.TArray<System.IntPtr> SpecialNavEdgeList
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<System.IntPtr>>(Ptr + 1352); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1352); }
    }

    /// <summary>
    /// ArrayProperty: SpecialNavEdgeList_SubMesh
    /// </summary>
    public unsafe BmSDK.TArray<System.IntPtr> SpecialNavEdgeList_SubMesh
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<System.IntPtr>>(Ptr + 1368); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1368); }
    }

    /// <summary>
    /// ArrayProperty: EdgeTraversers
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RBMPawnAI> EdgeTraversers
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RBMPawnAI>>(Ptr + 1384); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1384); }
    }

    /// <summary>
    /// ArrayProperty: MyNavMeshEdges
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.Engine.Pylon.FEdgeReference> MyNavMeshEdges
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.Pylon.FEdgeReference>>(Ptr + 1400); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1400); }
    }

    /// <summary>
    /// ArrayProperty: MyObstaclePolys
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.Engine.Pylon.FObstaclePolyPylonPair> MyObstaclePolys
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.Pylon.FObstaclePolyPylonPair>>(Ptr + 1416); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1416); }
    }

    /// <summary>
    /// IntProperty: MaxObstaclePolys
    /// </summary>
    public unsafe int MaxObstaclePolys
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1432); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1432); }
    }

    /// <summary>
    /// IntProperty: CachedClimbableCollection
    /// </summary>
    public unsafe int CachedClimbableCollection
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1436); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1436); }
    }

    /// <summary>
    /// ArrayProperty: XRayMaterials
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.Engine.MaterialInterface> XRayMaterials
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.MaterialInterface>>(Ptr + 1440); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1440); }
    }

    /// <summary>
    /// ArrayProperty: ThermalMaterials
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.Engine.MaterialInterface> ThermalMaterials
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.MaterialInterface>>(Ptr + 1456); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1456); }
    }

    /// <summary>
    /// ArrayProperty: BatmobileViewMaterials
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.Engine.MaterialInterface> BatmobileViewMaterials
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.MaterialInterface>>(Ptr + 1472); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1472); }
    }

    /// <summary>
    /// StructProperty: RBCollideWithChannels
    /// </summary>
    public unsafe BmSDK.Engine.PrimitiveComponent.FRBCollisionChannelContainer RBCollideWithChannels
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.PrimitiveComponent.FRBCollisionChannelContainer>(Ptr + 1488); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1488); }
    }

    /// <summary>
    /// FloatProperty: MinimumAmountOfSupportToRemainStanding
    /// </summary>
    public unsafe float MinimumAmountOfSupportToRemainStanding
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1492); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1492); }
    }

    /// <summary>
    /// FloatProperty: NavMeshObstacleSizeMultiplier
    /// </summary>
    public unsafe float NavMeshObstacleSizeMultiplier
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1496); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1496); }
    }

    /// <summary>
    /// StructProperty: NavMeshObstacleSizeMultiplier3D
    /// </summary>
    public unsafe System.Numerics.Vector3 NavMeshObstacleSizeMultiplier3D
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 1500); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1500); }
    }

    /// <summary>
    /// FloatProperty: NavMeshObstacleMaxHeight
    /// </summary>
    public unsafe float NavMeshObstacleMaxHeight
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1512); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1512); }
    }

    /// <summary>
    /// FloatProperty: NavMeshShapeHeightOffset
    /// </summary>
    public unsafe float NavMeshShapeHeightOffset
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1516); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1516); }
    }

    /// <summary>
    /// FloatProperty: NavMeshShapeAbsoluteHeight
    /// </summary>
    public unsafe float NavMeshShapeAbsoluteHeight
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1520); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1520); }
    }

    /// <summary>
    /// FloatProperty: DynamicNavMeshShapeHeightOffset
    /// </summary>
    public unsafe float DynamicNavMeshShapeHeightOffset
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1524); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1524); }
    }

    /// <summary>
    /// IntProperty: PylonReferences
    /// </summary>
    public unsafe int PylonReferences
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1528); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1528); }
    }

    /// <summary>
    /// FloatProperty: TimeSinceLastChunkFractured
    /// </summary>
    public unsafe float TimeSinceLastChunkFractured
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1532); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1532); }
    }

    /// <summary>
    /// FloatProperty: TimeSinceLastChunkAwoke
    /// </summary>
    public unsafe float TimeSinceLastChunkAwoke
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1536); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1536); }
    }

    /// <summary>
    /// IntProperty: OverrideDamageTakenFromBatarangs
    /// </summary>
    public unsafe int OverrideDamageTakenFromBatarangs
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1540); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1540); }
    }

    /// <summary>
    /// StructProperty: PropGuid
    /// </summary>
    public unsafe BmSDK.GameObject.FGuid PropGuid
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.GameObject.FGuid>(Ptr + 1544); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1544); }
    }

    /// <summary>
    /// NameProperty: DecorationSocketName
    /// </summary>
    public unsafe BmSDK.FName DecorationSocketName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 1560); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1560); }
    }

    /// <summary>
    /// FloatProperty: VerticalOffsetWhenComesToRest
    /// </summary>
    public unsafe float VerticalOffsetWhenComesToRest
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1568); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1568); }
    }

    /// <summary>
    /// ArrayProperty: CachedNavMeshShape
    /// </summary>
    public unsafe BmSDK.TArray<System.Numerics.Vector3> CachedNavMeshShape
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<System.Numerics.Vector3>>(Ptr + 1572); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1572); }
    }

    /// <summary>
    /// FloatProperty: ImpactEffectMassFactor
    /// </summary>
    public unsafe float ImpactEffectMassFactor
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1588); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1588); }
    }

    /// <summary>
    /// StructProperty: LastImpactDamage
    /// </summary>
    public unsafe BmSDK.BmGame.RDestructibleProp.FDestructiblePropDamage LastImpactDamage
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RDestructibleProp.FDestructiblePropDamage>(Ptr + 1592); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1592); }
    }

    /// <summary>
    /// StrProperty: GlobalFlagNameToDisableActor
    /// </summary>
    public unsafe BmSDK.FString GlobalFlagNameToDisableActor
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 1652); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1652); }
    }

    /// <summary>
    /// StrProperty: GlobalFlagNameToEnableActor
    /// </summary>
    public unsafe BmSDK.FString GlobalFlagNameToEnableActor
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 1668); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1668); }
    }

    /// <summary>
    /// ArrayProperty: PreviousAllComponentsList
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.FString> PreviousAllComponentsList
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.FString>>(Ptr + 1684); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1684); }
    }

    /// <summary>
    /// ArrayProperty: RegisteredPolyList
    /// </summary>
    public unsafe BmSDK.TArray<System.IntPtr> RegisteredPolyList
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<System.IntPtr>>(Ptr + 1700); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1700); }
    }

    /// <summary>
    /// FloatProperty: BreakLargeChunksMomentum
    /// </summary>
    public unsafe float BreakLargeChunksMomentum
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1716); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1716); }
    }

    /// <summary>
    /// FloatProperty: ToppleOverAngularVelocityMagnitude
    /// </summary>
    public unsafe float ToppleOverAngularVelocityMagnitude
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1720); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1720); }
    }
}
