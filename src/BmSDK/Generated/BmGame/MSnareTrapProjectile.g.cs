#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: MSnareTrapProjectile<br/>
/// (size = 0)
/// (flags = 0)
/// </summary>
public partial class MSnareTrapProjectile : BmSDK.BmGame.RGadgetProjectileBase, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.MSnareTrapProjectile", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal MSnareTrapProjectile() { }

    /// <summary>
    /// Constructs a new MSnareTrapProjectile
    /// </summary>
    public MSnareTrapProjectile(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, MSnareTrapProjectile Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected MSnareTrapProjectile(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="Engine.Actor.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<MSnareTrapProjectile>
        => ((Engine.Actor)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="Engine.Actor.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<MSnareTrapProjectile>, new()
        => (TComponent)((Engine.Actor)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="Engine.Actor.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<MSnareTrapProjectile>
        => ((Engine.Actor)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="Engine.Actor.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<MSnareTrapProjectile>
        => ((Engine.Actor)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="Engine.Actor.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<MSnareTrapProjectile>
        => (TComponent)((Engine.Actor)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="Engine.Actor.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<MSnareTrapProjectile>
        => ((Engine.Actor)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="Engine.Actor.DetachScriptComponent(Type)"/>
    public void DetachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<MSnareTrapProjectile>
        => ((Engine.Actor)this).DetachScriptComponent(typeof(TComponent));

    /// <summary>
    /// StructProperty: TargetHitNormal
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT TargetHitNormal
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 928); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 928); }
    }

    /// <summary>
    /// StructProperty: TargetHitLocation
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT TargetHitLocation
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 940); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 940); }
    }

    /// <summary>
    /// FloatProperty: BlastTime
    /// </summary>
    public unsafe float BlastTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 952); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 952); }
    }

    /// <summary>
    /// FloatProperty: BlastRadius
    /// </summary>
    public unsafe float BlastRadius
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 956); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 956); }
    }

    /// <summary>
    /// ObjectProperty: GroundBlastParticles
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT GroundBlastParticles
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 960); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 960); }
    }

    /// <summary>
    /// ObjectProperty: FloorBlastSound
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT FloorBlastSound
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 968); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 968); }
    }

    /// <summary>
    /// ObjectProperty: ChestBlastSound
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT ChestBlastSound
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 976); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 976); }
    }

    /// <summary>
    /// ObjectProperty: ImpactEnemySound
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT ImpactEnemySound
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 984); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 984); }
    }

    /// <summary>
    /// ObjectProperty: ImpactEnemyWithShieldSound
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT ImpactEnemyWithShieldSound
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 992); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 992); }
    }

    /// <summary>
    /// ObjectProperty: ImpactWallSound
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT ImpactWallSound
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 1000); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1000); }
    }

    /// <summary>
    /// ObjectProperty: Trigger
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT Trigger
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 1008); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1008); }
    }

    /// <summary>
    /// ObjectProperty: DeployedVillain
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT DeployedVillain
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 1016); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1016); }
    }

    /// <summary>
    /// ObjectProperty: TrapExplosionVFX
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT TrapExplosionVFX
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 1024); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1024); }
    }

    /// <summary>
    /// ObjectProperty: MidAirExplosionVFX
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT MidAirExplosionVFX
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 1032); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1032); }
    }

    /// <summary>
    /// ComponentProperty: RoomState
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT RoomState
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 1040); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1040); }
    }

    /// <summary>
    /// ComponentProperty: SnareTrapMesh
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT SnareTrapMesh
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 1048); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1048); }
    }

    /// <summary>
    /// FloatProperty: TimeBeforeNextImpactSound
    /// </summary>
    public unsafe float TimeBeforeNextImpactSound
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1056); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1056); }
    }

    /// <summary>
    /// FloatProperty: TimeTillDetonate
    /// </summary>
    public unsafe float TimeTillDetonate
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1060); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1060); }
    }

    /// <summary>
    /// BoolProperty: HitFrontOfThug
    /// </summary>
    public unsafe bool HitFrontOfThug
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1064) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1064); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1064); }
    }

    /// <summary>
    /// BoolProperty: bPredThug
    /// </summary>
    public unsafe bool bPredThug
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1064) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1064); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1064); }
    }
}
