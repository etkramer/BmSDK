#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RBMWeaponRanged<br/>
/// (size = 0)
/// (flags = 0)
/// </summary>
public partial class RBMWeaponRanged : BmSDK.BmGame.RBMWeapon, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RBMWeaponRanged", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RBMWeaponRanged() { }

    /// <summary>
    /// Constructs a new RBMWeaponRanged
    /// </summary>
    public RBMWeaponRanged(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RBMWeaponRanged Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RBMWeaponRanged(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="Engine.Actor.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RBMWeaponRanged>
        => ((Engine.Actor)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="Engine.Actor.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RBMWeaponRanged>, new()
        => (TComponent)((Engine.Actor)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="Engine.Actor.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RBMWeaponRanged>
        => ((Engine.Actor)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="Engine.Actor.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RBMWeaponRanged>
        => ((Engine.Actor)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="Engine.Actor.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RBMWeaponRanged>
        => (TComponent)((Engine.Actor)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="Engine.Actor.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RBMWeaponRanged>
        => ((Engine.Actor)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="Engine.Actor.DetachScriptComponent(Type)"/>
    public void DetachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RBMWeaponRanged>
        => ((Engine.Actor)this).DetachScriptComponent(typeof(TComponent));

    /// <summary>
    /// FloatProperty: SecondsBetweenShots
    /// </summary>
    public unsafe float SecondsBetweenShots
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1748); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1748); }
    }

    /// <summary>
    /// FloatProperty: ShotDamage
    /// </summary>
    public unsafe float ShotDamage_0
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1752); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1752); }
    }
    /// <summary>
    /// FloatProperty: ShotDamage
    /// </summary>
    public unsafe float ShotDamage_1
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1756); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1756); }
    }
    /// <summary>
    /// FloatProperty: ShotDamage
    /// </summary>
    public unsafe float ShotDamage_2
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1760); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1760); }
    }

    /// <summary>
    /// IntProperty: BurstSize
    /// </summary>
    public unsafe int BurstSize
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1764); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1764); }
    }

    /// <summary>
    /// FloatProperty: BurstPause
    /// </summary>
    public unsafe float BurstPause
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1768); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1768); }
    }

    /// <summary>
    /// BoolProperty: bUsesAmmo
    /// </summary>
    public unsafe bool bUsesAmmo
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1772) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1772); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1772); }
    }

    /// <summary>
    /// BoolProperty: bMissAtRange
    /// </summary>
    public unsafe bool bMissAtRange
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1772) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1772); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1772); }
    }

    /// <summary>
    /// BoolProperty: bMuzzleFlashActive
    /// </summary>
    public unsafe bool bMuzzleFlashActive
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1772) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1772); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1772); }
    }

    /// <summary>
    /// BoolProperty: bRandomiseBurst
    /// </summary>
    public unsafe bool bRandomiseBurst
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1772) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1772); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1772); }
    }

    /// <summary>
    /// BoolProperty: bForceRecoilAnim
    /// </summary>
    public unsafe bool bForceRecoilAnim
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1772) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1772); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1772); }
    }

    /// <summary>
    /// BoolProperty: bLaserSightOn
    /// </summary>
    public unsafe bool bLaserSightOn
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1772) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1772); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1772); }
    }

    /// <summary>
    /// BoolProperty: bExtremeDamage
    /// </summary>
    public unsafe bool bExtremeDamage
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1772) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1772); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1772); }
    }

    /// <summary>
    /// BoolProperty: bHoldOnWhenDivingFromCar
    /// </summary>
    public unsafe bool bHoldOnWhenDivingFromCar
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1772) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1772); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1772); }
    }

    /// <summary>
    /// BoolProperty: AudioWeaponFiring
    /// </summary>
    public unsafe bool AudioWeaponFiring
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1772) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1772); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1772); }
    }

    /// <summary>
    /// BoolProperty: bUseLensFlare
    /// </summary>
    public unsafe bool bUseLensFlare
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1772) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1772); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1772); }
    }

    /// <summary>
    /// IntProperty: ClipSize
    /// </summary>
    public unsafe int ClipSize
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1776); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1776); }
    }

    /// <summary>
    /// ComponentProperty: VFXAttachMesh
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT VFXAttachMesh
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 1780); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1780); }
    }

    /// <summary>
    /// ComponentProperty: MuzzleFlash
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT MuzzleFlash
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 1788); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1788); }
    }

    /// <summary>
    /// NameProperty: MuzzleFlashSocket
    /// </summary>
    public unsafe BmSDK.FName MuzzleFlashSocket
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 1796); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1796); }
    }

    /// <summary>
    /// ComponentProperty: TraceBulletFX
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT TraceBulletFX
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 1804); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1804); }
    }

    /// <summary>
    /// StructProperty: AimLoc
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT AimLoc
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 1812); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1812); }
    }

    /// <summary>
    /// FloatProperty: ShotDeviance
    /// </summary>
    public unsafe float ShotDeviance
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1824); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1824); }
    }

    /// <summary>
    /// NameProperty: TerrifiedCornerOutLeftAnimName
    /// </summary>
    public unsafe BmSDK.FName TerrifiedCornerOutLeftAnimName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 1828); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1828); }
    }

    /// <summary>
    /// NameProperty: TerrifiedCornerOutRightAnimName
    /// </summary>
    public unsafe BmSDK.FName TerrifiedCornerOutRightAnimName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 1836); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1836); }
    }

    /// <summary>
    /// NameProperty: RecoilAnimName
    /// </summary>
    public unsafe BmSDK.FName RecoilAnimName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 1844); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1844); }
    }

    /// <summary>
    /// ObjectProperty: RecoilAnimset
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT RecoilAnimset
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 1852); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1852); }
    }

    /// <summary>
    /// ObjectProperty: JammedExplodeEvent
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT JammedExplodeEvent
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 1860); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1860); }
    }

    /// <summary>
    /// ObjectProperty: JammedClickEvent
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT JammedClickEvent
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 1868); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1868); }
    }

    /// <summary>
    /// ObjectProperty: JammedExplosionVFX
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT JammedExplosionVFX
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 1876); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1876); }
    }

    /// <summary>
    /// ObjectProperty: WeaponFireEvent
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT WeaponFireEvent
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 1884); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1884); }
    }

    /// <summary>
    /// ObjectProperty: WeaponFireLoopEvent
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT WeaponFireLoopEvent
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 1892); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1892); }
    }

    /// <summary>
    /// StructProperty: LaserEndPos
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT LaserEndPos
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 1900); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1900); }
    }

    /// <summary>
    /// ByteProperty: DefinedGunType
    /// </summary>
    public unsafe byte DefinedGunType
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 1912); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1912); }
    }
}
