#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RFreezeGrenadeCommonProjectile<br/>
/// (flags = 0)
/// </summary>
public partial class RFreezeGrenadeCommonProjectile : BmSDK.BmGame.RGadgetProjectileBase, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RFreezeGrenadeCommonProjectile", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RFreezeGrenadeCommonProjectile() { }

    /// <summary>
    /// Constructs a new RFreezeGrenadeCommonProjectile
    /// </summary>
    public RFreezeGrenadeCommonProjectile(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RFreezeGrenadeCommonProjectile Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RFreezeGrenadeCommonProjectile(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="Engine.Actor.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RFreezeGrenadeCommonProjectile>
        => ((Engine.Actor)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="Engine.Actor.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RFreezeGrenadeCommonProjectile>, new()
        => (TComponent)((Engine.Actor)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="Engine.Actor.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RFreezeGrenadeCommonProjectile>
        => ((Engine.Actor)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="Engine.Actor.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RFreezeGrenadeCommonProjectile>
        => ((Engine.Actor)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="Engine.Actor.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RFreezeGrenadeCommonProjectile>
        => (TComponent)((Engine.Actor)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="Engine.Actor.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RFreezeGrenadeCommonProjectile>
        => ((Engine.Actor)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="Engine.Actor.DetachScriptComponent(Type)"/>
    public void DetachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RFreezeGrenadeCommonProjectile>
        => ((Engine.Actor)this).DetachScriptComponent(typeof(TComponent));

    /// <summary>
    /// StructProperty: TargetHitNormal
    /// </summary>
    public unsafe System.Numerics.Vector3 TargetHitNormal
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 928); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 928); }
    }

    /// <summary>
    /// StructProperty: TargetHitLocation
    /// </summary>
    public unsafe System.Numerics.Vector3 TargetHitLocation
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 940); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 940); }
    }

    /// <summary>
    /// ObjectProperty: IceRaftSpawnParticles
    /// </summary>
    public unsafe BmSDK.Engine.ParticleSystem IceRaftSpawnParticles
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleSystem>(Ptr + 952); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 952); }
    }

    /// <summary>
    /// ObjectProperty: SpawnableRaftArchetype
    /// </summary>
    public unsafe BmSDK.BmGame.RFloatingRaft SpawnableRaftArchetype
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RFloatingRaft>(Ptr + 960); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 960); }
    }

    /// <summary>
    /// ObjectProperty: WaterVolume
    /// </summary>
    public unsafe BmSDK.BmGame.RWaterVolumeBase WaterVolume
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RWaterVolumeBase>(Ptr + 968); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 968); }
    }

    /// <summary>
    /// ObjectProperty: RaftSpawnParticles
    /// </summary>
    public unsafe BmSDK.Engine.Emitter RaftSpawnParticles
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.Emitter>(Ptr + 976); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 976); }
    }

    /// <summary>
    /// ObjectProperty: DeployedVillain
    /// </summary>
    public unsafe BmSDK.BmGame.RPawnVillain DeployedVillain
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPawnVillain>(Ptr + 984); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 984); }
    }

    /// <summary>
    /// ObjectProperty: WaterBlastSound
    /// </summary>
    public unsafe BmSDK.Engine.AkEvent WaterBlastSound
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkEvent>(Ptr + 992); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 992); }
    }

    /// <summary>
    /// ObjectProperty: ImpactWaterSound
    /// </summary>
    public unsafe BmSDK.Engine.AkEvent ImpactWaterSound
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkEvent>(Ptr + 1000); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1000); }
    }

    /// <summary>
    /// ObjectProperty: ImpactWallSound
    /// </summary>
    public unsafe BmSDK.Engine.AkEvent ImpactWallSound
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkEvent>(Ptr + 1008); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1008); }
    }

    /// <summary>
    /// ObjectProperty: WaterIsTooTurbulentForAnIceRaftThought
    /// </summary>
    public unsafe BmSDK.Engine.AkDialogueSpeech WaterIsTooTurbulentForAnIceRaftThought
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkDialogueSpeech>(Ptr + 1016); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1016); }
    }

    /// <summary>
    /// ObjectProperty: Trigger
    /// </summary>
    public unsafe BmSDK.BmGame.RProximityGadgetTrigger Trigger
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RProximityGadgetTrigger>(Ptr + 1024); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1024); }
    }

    /// <summary>
    /// StructProperty: RaftSpawnLocation
    /// </summary>
    public unsafe System.Numerics.Vector3 RaftSpawnLocation
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 1032); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1032); }
    }

    /// <summary>
    /// StructProperty: RaftSpawnCenter
    /// </summary>
    public unsafe System.Numerics.Vector3 RaftSpawnCenter
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 1044); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1044); }
    }

    /// <summary>
    /// BoolProperty: bSpawnUnderwater
    /// </summary>
    public unsafe bool bSpawnUnderwater
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1056) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1056); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1056); }
    }

    /// <summary>
    /// BoolProperty: bFreezeVillainWhenFreezeGrenadeDetonates
    /// </summary>
    public unsafe bool bFreezeVillainWhenFreezeGrenadeDetonates
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1056) & 2) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1056); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1056); }
    }

    /// <summary>
    /// BoolProperty: bAvoidedTarget
    /// </summary>
    public unsafe bool bAvoidedTarget
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1056) & 4) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1056); var newMask = value ? (currentMask | 4) : (currentMask & ~4); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1056); }
    }

    /// <summary>
    /// FloatProperty: fProximityCylinderRadius
    /// </summary>
    public unsafe float fProximityCylinderRadius
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1060); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1060); }
    }

    /// <summary>
    /// FloatProperty: TimeTillDetonate
    /// </summary>
    public unsafe float TimeTillDetonate
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1064); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1064); }
    }
}
