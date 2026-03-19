#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RExplosiveGooMine<br/>
/// (size = 0)
/// (flags = 0)
/// </summary>
public partial class RExplosiveGooMine : BmSDK.BmGame.RThugTrap, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RExplosiveGooMine", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RExplosiveGooMine() { }

    /// <summary>
    /// Constructs a new RExplosiveGooMine
    /// </summary>
    public RExplosiveGooMine(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RExplosiveGooMine Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RExplosiveGooMine(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="Engine.Actor.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RExplosiveGooMine>
        => ((Engine.Actor)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="Engine.Actor.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RExplosiveGooMine>, new()
        => (TComponent)((Engine.Actor)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="Engine.Actor.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RExplosiveGooMine>
        => ((Engine.Actor)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="Engine.Actor.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RExplosiveGooMine>
        => ((Engine.Actor)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="Engine.Actor.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RExplosiveGooMine>
        => (TComponent)((Engine.Actor)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="Engine.Actor.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RExplosiveGooMine>
        => ((Engine.Actor)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="Engine.Actor.DetachScriptComponent(Type)"/>
    public void DetachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RExplosiveGooMine>
        => ((Engine.Actor)this).DetachScriptComponent(typeof(TComponent));

    /// <summary>
    /// StructProperty: VfTable_IRSpotableInterface
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT VfTable_IRSpotableInterface
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 684); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 684); }
    }

    /// <summary>
    /// FloatProperty: ExplosionRadius
    /// </summary>
    public unsafe float ExplosionRadius
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 692); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 692); }
    }

    /// <summary>
    /// FloatProperty: FractureRadius
    /// </summary>
    public unsafe float FractureRadius
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 696); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 696); }
    }

    /// <summary>
    /// FloatProperty: explosionImpulse
    /// </summary>
    public unsafe float explosionImpulse
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 700); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 700); }
    }

    /// <summary>
    /// FloatProperty: WallKillRadius
    /// </summary>
    public unsafe float WallKillRadius
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 704); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 704); }
    }

    /// <summary>
    /// ComponentProperty: GooSprayParticles
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT GooSprayParticles
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 708); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 708); }
    }

    /// <summary>
    /// ComponentProperty: GooSprayParticles2ndGun
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT GooSprayParticles2ndGun
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 716); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 716); }
    }

    /// <summary>
    /// ComponentProperty: BatSymbolEmitter
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT BatSymbolEmitter
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 724); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 724); }
    }

    /// <summary>
    /// ObjectProperty: GooSprayer
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT GooSprayer
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 732); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 732); }
    }

    /// <summary>
    /// ObjectProperty: ExplosionRumble
    /// </summary>
    public unsafe BmSDK.BmGame.RThugTrap.ComponentsToCheck ExplosionRumble
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RThugTrap.ComponentsToCheck>(Ptr + 740); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 740); }
    }

    /// <summary>
    /// ObjectProperty: ProximityTrigger
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT ProximityTrigger
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 748); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 748); }
    }

    /// <summary>
    /// ObjectProperty: DirectionalExplosion
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT DirectionalExplosion
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 756); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 756); }
    }

    /// <summary>
    /// ObjectProperty: Explosion
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT Explosion
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 764); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 764); }
    }

    /// <summary>
    /// ObjectProperty: ControlledExplosion
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT ControlledExplosion
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 772); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 772); }
    }

    /// <summary>
    /// ObjectProperty: GelSettingLoop
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT GelSettingLoop
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 780); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 780); }
    }

    /// <summary>
    /// ObjectProperty: ControlledExplosionSound
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT ControlledExplosionSound
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 788); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 788); }
    }

    /// <summary>
    /// ObjectProperty: JokerfiedSpray
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT JokerfiedSpray
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 796); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 796); }
    }

    /// <summary>
    /// ObjectProperty: JokerfiedPieces
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT JokerfiedPieces
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 804); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 804); }
    }

    /// <summary>
    /// ObjectProperty: BaseSpray
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT BaseSpray
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 812); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 812); }
    }

    /// <summary>
    /// ObjectProperty: BasePieces
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT BasePieces
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 820); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 820); }
    }

    /// <summary>
    /// ObjectProperty: ShootGelAEC
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT ShootGelAEC
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 828); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 828); }
    }

    /// <summary>
    /// ObjectProperty: CachedEventToSweetenTheExplosion
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT CachedEventToSweetenTheExplosion
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 836); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 836); }
    }

    /// <summary>
    /// ComponentProperty: RoomState
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT RoomState
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 844); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 844); }
    }

    /// <summary>
    /// ComponentProperty: VantageInfluenceAreaMarker
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT VantageInfluenceAreaMarker
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 852); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 852); }
    }

    /// <summary>
    /// ComponentProperty: WallCylinder
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT WallCylinder
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 860); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 860); }
    }

    /// <summary>
    /// ComponentProperty: ImpulseComponent
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT ImpulseComponent
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 868); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 868); }
    }

    /// <summary>
    /// ComponentProperty: DetonatorInteractions
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT DetonatorInteractions
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 876); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 876); }
    }

    /// <summary>
    /// BoolProperty: bSpraying
    /// </summary>
    public unsafe bool bSpraying
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 884) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 884); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 884); }
    }

    /// <summary>
    /// BoolProperty: bSpraying2
    /// </summary>
    public unsafe bool bSpraying2
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 884) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 884); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 884); }
    }

    /// <summary>
    /// BoolProperty: bActive
    /// </summary>
    public unsafe bool bActive
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 884) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 884); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 884); }
    }

    /// <summary>
    /// BoolProperty: bFinalExplosion
    /// </summary>
    public unsafe bool bFinalExplosion
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 884) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 884); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 884); }
    }

    /// <summary>
    /// BoolProperty: bProximityMine
    /// </summary>
    public unsafe bool bProximityMine
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 884) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 884); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 884); }
    }

    /// <summary>
    /// BoolProperty: AlwaysDoBatBits
    /// </summary>
    public unsafe bool AlwaysDoBatBits
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 884) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 884); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 884); }
    }

    /// <summary>
    /// BoolProperty: NeverDoBatBits
    /// </summary>
    public unsafe bool NeverDoBatBits
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 884) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 884); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 884); }
    }

    /// <summary>
    /// BoolProperty: bDontDoSprayCollisionCheck
    /// </summary>
    public unsafe bool bDontDoSprayCollisionCheck
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 884) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 884); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 884); }
    }

    /// <summary>
    /// BoolProperty: bNoExplosionFX
    /// </summary>
    public unsafe bool bNoExplosionFX
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 884) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 884); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 884); }
    }

    /// <summary>
    /// BoolProperty: bPositionSet
    /// </summary>
    public unsafe bool bPositionSet
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 884) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 884); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 884); }
    }

    /// <summary>
    /// BoolProperty: bOwnerSet
    /// </summary>
    public unsafe bool bOwnerSet
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 884) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 884); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 884); }
    }

    /// <summary>
    /// BoolProperty: bRedundant
    /// </summary>
    public unsafe bool bRedundant
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 884) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 884); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 884); }
    }

    /// <summary>
    /// BoolProperty: bClientExplode
    /// </summary>
    public unsafe bool bClientExplode
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 884) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 884); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 884); }
    }

    /// <summary>
    /// BoolProperty: bAffectOnlyOneEnemy
    /// </summary>
    public unsafe bool bAffectOnlyOneEnemy
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 884) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 884); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 884); }
    }

    /// <summary>
    /// BoolProperty: bSuperCombo
    /// </summary>
    public unsafe bool bSuperCombo
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 884) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 884); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 884); }
    }

    /// <summary>
    /// BoolProperty: bAlwaysDisplayOnHUD
    /// </summary>
    public unsafe bool bAlwaysDisplayOnHUD
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 884) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 884); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 884); }
    }

    /// <summary>
    /// BoolProperty: bFinishedPlacing
    /// </summary>
    public unsafe bool bFinishedPlacing
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 884) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 884); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 884); }
    }

    /// <summary>
    /// BoolProperty: bLethalUpgrade
    /// </summary>
    public unsafe bool bLethalUpgrade
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 884) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 884); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 884); }
    }

    /// <summary>
    /// BoolProperty: bDurationUpgrade
    /// </summary>
    public unsafe bool bDurationUpgrade
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 884) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 884); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 884); }
    }

    /// <summary>
    /// BoolProperty: bDontUpdateBase
    /// </summary>
    public unsafe bool bDontUpdateBase
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 884) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 884); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 884); }
    }

    /// <summary>
    /// StructProperty: WallNormal
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT WallNormal
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 888); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 888); }
    }

    /// <summary>
    /// FloatProperty: SettleTimer
    /// </summary>
    public unsafe float SettleTimer
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 900); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 900); }
    }

    /// <summary>
    /// FloatProperty: SprayLength
    /// </summary>
    public unsafe float SprayLength
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 904); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 904); }
    }

    /// <summary>
    /// StructProperty: Shaker
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT Shaker
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 908); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 908); }
    }

    /// <summary>
    /// IntProperty: AmmoPerMine
    /// </summary>
    public unsafe int AmmoPerMine
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1064); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1064); }
    }

    /// <summary>
    /// IntProperty: GelDamage
    /// </summary>
    public unsafe int GelDamage
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1068); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1068); }
    }

    /// <summary>
    /// StructProperty: ExplosionDirection
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT ExplosionDirection
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 1072); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1072); }
    }

    /// <summary>
    /// StructProperty: ExplosionArrowOffset
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT ExplosionArrowOffset
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 1084); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1084); }
    }
}
