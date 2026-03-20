#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmScript;

/// <summary>
/// Class: RBMWeaponKnife<br/>
/// (flags = 0)
/// </summary>
public partial class RBMWeaponKnife : BmSDK.BmScript.RBMWeaponKnifeBase, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmScript.RBMWeaponKnife", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RBMWeaponKnife() { }

    /// <summary>
    /// Constructs a new RBMWeaponKnife
    /// </summary>
    public RBMWeaponKnife(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RBMWeaponKnife Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RBMWeaponKnife(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="Engine.Actor.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RBMWeaponKnife>
        => ((Engine.Actor)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="Engine.Actor.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RBMWeaponKnife>, new()
        => (TComponent)((Engine.Actor)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="Engine.Actor.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RBMWeaponKnife>
        => ((Engine.Actor)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="Engine.Actor.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RBMWeaponKnife>
        => ((Engine.Actor)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="Engine.Actor.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RBMWeaponKnife>
        => (TComponent)((Engine.Actor)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="Engine.Actor.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RBMWeaponKnife>
        => ((Engine.Actor)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="Engine.Actor.DetachScriptComponent(Type)"/>
    public void DetachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RBMWeaponKnife>
        => ((Engine.Actor)this).DetachScriptComponent(typeof(TComponent));

    /// <summary>
    /// BoolProperty: bAttached
    /// </summary>
    public unsafe bool bAttached
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 784) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 784); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 784); }
    }

    /// <summary>
    /// BoolProperty: bCanBeHitHoldingWeapon
    /// </summary>
    public unsafe bool bCanBeHitHoldingWeapon
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 784) & 2) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 784); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 784); }
    }

    /// <summary>
    /// BoolProperty: bCanBlockHoldingWeapon
    /// </summary>
    public unsafe bool bCanBlockHoldingWeapon
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 784) & 4) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 784); var newMask = value ? (currentMask | 4) : (currentMask & ~4); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 784); }
    }

    /// <summary>
    /// BoolProperty: bCanBlockBatarang
    /// </summary>
    public unsafe bool bCanBlockBatarang
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 784) & 8) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 784); var newMask = value ? (currentMask | 8) : (currentMask & ~8); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 784); }
    }

    /// <summary>
    /// BoolProperty: bCanRepelHoldingWeapon
    /// </summary>
    public unsafe bool bCanRepelHoldingWeapon
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 784) & 16) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 784); var newMask = value ? (currentMask | 16) : (currentMask & ~16); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 784); }
    }

    /// <summary>
    /// BoolProperty: bCanTraverseHoldingWeapon
    /// </summary>
    public unsafe bool bCanTraverseHoldingWeapon
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 784) & 32) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 784); var newMask = value ? (currentMask | 32) : (currentMask & ~32); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 784); }
    }

    /// <summary>
    /// BoolProperty: bBatclawDisarmsOnHit
    /// </summary>
    public unsafe bool bBatclawDisarmsOnHit
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 784) & 64) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 784); var newMask = value ? (currentMask | 64) : (currentMask & ~64); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 784); }
    }

    /// <summary>
    /// BoolProperty: bDropOnDisarm
    /// </summary>
    public unsafe bool bDropOnDisarm
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 784) & 128) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 784); var newMask = value ? (currentMask | 128) : (currentMask & ~128); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 784); }
    }

    /// <summary>
    /// BoolProperty: bDisplayDeathTip
    /// </summary>
    public unsafe bool bDisplayDeathTip
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 784) & 256) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 784); var newMask = value ? (currentMask | 256) : (currentMask & ~256); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 784); }
    }

    /// <summary>
    /// BoolProperty: bIsKnife
    /// </summary>
    public unsafe bool bIsKnife
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 784) & 512) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 784); var newMask = value ? (currentMask | 512) : (currentMask & ~512); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 784); }
    }

    /// <summary>
    /// BoolProperty: bIsPipe
    /// </summary>
    public unsafe bool bIsPipe
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 784) & 1024) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 784); var newMask = value ? (currentMask | 1024) : (currentMask & ~1024); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 784); }
    }

    /// <summary>
    /// BoolProperty: bIsHeavyObject
    /// </summary>
    public unsafe bool bIsHeavyObject
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 784) & 2048) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 784); var newMask = value ? (currentMask | 2048) : (currentMask & ~2048); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 784); }
    }

    /// <summary>
    /// BoolProperty: bExplodesOnBatarang
    /// </summary>
    public unsafe bool bExplodesOnBatarang
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 784) & 4096) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 784); var newMask = value ? (currentMask | 4096) : (currentMask & ~4096); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 784); }
    }

    /// <summary>
    /// BoolProperty: bIsSniper
    /// </summary>
    public unsafe bool bIsSniper
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 784) & 8192) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 784); var newMask = value ? (currentMask | 8192) : (currentMask & ~8192); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 784); }
    }

    /// <summary>
    /// BoolProperty: bReactsToMagneticBlast
    /// </summary>
    public unsafe bool bReactsToMagneticBlast
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 784) & 16384) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 784); var newMask = value ? (currentMask | 16384) : (currentMask & ~16384); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 784); }
    }

    /// <summary>
    /// BoolProperty: bAlwaysDisarmedByMagneticBlast
    /// </summary>
    public unsafe bool bAlwaysDisarmedByMagneticBlast
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 784) & 32768) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 784); var newMask = value ? (currentMask | 32768) : (currentMask & ~32768); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 784); }
    }

    /// <summary>
    /// BoolProperty: bBlocksDirectMagBlastHit
    /// </summary>
    public unsafe bool bBlocksDirectMagBlastHit
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 784) & 65536) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 784); var newMask = value ? (currentMask | 65536) : (currentMask & ~65536); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 784); }
    }

    /// <summary>
    /// BoolProperty: bCanAerialRedirect
    /// </summary>
    public unsafe bool bCanAerialRedirect
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 784) & 131072) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 784); var newMask = value ? (currentMask | 131072) : (currentMask & ~131072); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 784); }
    }

    /// <summary>
    /// BoolProperty: bCanBeUsedByArmoured
    /// </summary>
    public unsafe bool bCanBeUsedByArmoured
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 784) & 262144) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 784); var newMask = value ? (currentMask | 262144) : (currentMask & ~262144); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 784); }
    }

    /// <summary>
    /// BoolProperty: bHasLowHitReactions
    /// </summary>
    public unsafe bool bHasLowHitReactions
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 784) & 524288) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 784); var newMask = value ? (currentMask | 524288) : (currentMask & ~524288); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 784); }
    }

    /// <summary>
    /// BoolProperty: bCanBeShoved
    /// </summary>
    public unsafe bool bCanBeShoved
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 784) & 1048576) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 784); var newMask = value ? (currentMask | 1048576) : (currentMask & ~1048576); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 784); }
    }

    /// <summary>
    /// BoolProperty: bCanBePooled
    /// </summary>
    public unsafe bool bCanBePooled
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 784) & 2097152) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 784); var newMask = value ? (currentMask | 2097152) : (currentMask & ~2097152); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 784); }
    }

    /// <summary>
    /// BoolProperty: bSetMaterialsInstanceConstants
    /// </summary>
    public unsafe bool bSetMaterialsInstanceConstants
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 784) & 4194304) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 784); var newMask = value ? (currentMask | 4194304) : (currentMask & ~4194304); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 784); }
    }

    /// <summary>
    /// BoolProperty: bNotInCombatWhenOutOfRange
    /// </summary>
    public unsafe bool bNotInCombatWhenOutOfRange
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 784) & 8388608) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 784); var newMask = value ? (currentMask | 8388608) : (currentMask & ~8388608); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 784); }
    }

    /// <summary>
    /// BoolProperty: DropOnFirstHit
    /// </summary>
    public unsafe bool DropOnFirstHit
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 784) & 16777216) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 784); var newMask = value ? (currentMask | 16777216) : (currentMask & ~16777216); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 784); }
    }

    /// <summary>
    /// BoolProperty: DropOnBeatdown
    /// </summary>
    public unsafe bool DropOnBeatdown
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 784) & 33554432) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 784); var newMask = value ? (currentMask | 33554432) : (currentMask & ~33554432); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 784); }
    }

    /// <summary>
    /// BoolProperty: bWeaponHidden
    /// </summary>
    public unsafe bool bWeaponHidden
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 784) & 67108864) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 784); var newMask = value ? (currentMask | 67108864) : (currentMask & ~67108864); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 784); }
    }

    /// <summary>
    /// BoolProperty: bHasDoneGeneralXrayChecks
    /// </summary>
    public unsafe bool bHasDoneGeneralXrayChecks
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 784) & 134217728) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 784); var newMask = value ? (currentMask | 134217728) : (currentMask & ~134217728); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 784); }
    }

    /// <summary>
    /// BoolProperty: bUseForceXrayCheckResult
    /// </summary>
    public unsafe bool bUseForceXrayCheckResult
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 784) & 268435456) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 784); var newMask = value ? (currentMask | 268435456) : (currentMask & ~268435456); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 784); }
    }

    /// <summary>
    /// BoolProperty: bForcedXrayCheckResult
    /// </summary>
    public unsafe bool bForcedXrayCheckResult
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 784) & 536870912) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 784); var newMask = value ? (currentMask | 536870912) : (currentMask & ~536870912); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 784); }
    }

    /// <summary>
    /// BoolProperty: bIsOverWorld
    /// </summary>
    public unsafe bool bIsOverWorld
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 784) & 1073741824) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 784); var newMask = value ? (currentMask | 1073741824) : (currentMask & ~1073741824); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 784); }
    }

    /// <summary>
    /// BoolProperty: XRaySet
    /// </summary>
    public unsafe bool XRaySet
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 784) & -2147483648) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 784); var newMask = value ? (currentMask | -2147483648) : (currentMask & ~-2147483648); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 784); }
    }

    /// <summary>
    /// BoolProperty: bActiveProjectileWeapon
    /// </summary>
    public unsafe bool bActiveProjectileWeapon
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 788) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 788); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 788); }
    }

    /// <summary>
    /// BoolProperty: AllowMirroring
    /// </summary>
    public unsafe bool AllowMirroring
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 788) & 2) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 788); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 788); }
    }

    /// <summary>
    /// BoolProperty: bXrayPostbeginInit
    /// </summary>
    public unsafe bool bXrayPostbeginInit
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 788) & 4) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 788); var newMask = value ? (currentMask | 4) : (currentMask & ~4); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 788); }
    }

    /// <summary>
    /// BoolProperty: bHasSlidePickup
    /// </summary>
    public unsafe bool bHasSlidePickup
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 788) & 8) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 788); var newMask = value ? (currentMask | 8) : (currentMask & ~8); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 788); }
    }

    /// <summary>
    /// BoolProperty: bCanBatClawAttach
    /// </summary>
    public unsafe bool bCanBatClawAttach
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 788) & 16) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 788); var newMask = value ? (currentMask | 16) : (currentMask & ~16); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 788); }
    }

    /// <summary>
    /// BoolProperty: bLoadedPairedAnimsets
    /// </summary>
    public unsafe bool bLoadedPairedAnimsets
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 788) & 32) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 788); var newMask = value ? (currentMask | 32) : (currentMask & ~32); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 788); }
    }

    /// <summary>
    /// BoolProperty: bCanBeJammed
    /// </summary>
    public unsafe bool bCanBeJammed
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 788) & 64) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 788); var newMask = value ? (currentMask | 64) : (currentMask & ~64); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 788); }
    }

    /// <summary>
    /// BoolProperty: bWeaponJammed
    /// </summary>
    public unsafe bool bWeaponJammed
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 788) & 128) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 788); var newMask = value ? (currentMask | 128) : (currentMask & ~128); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 788); }
    }

    /// <summary>
    /// BoolProperty: bCanBeDoubleJammed
    /// </summary>
    public unsafe bool bCanBeDoubleJammed
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 788) & 256) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 788); var newMask = value ? (currentMask | 256) : (currentMask & ~256); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 788); }
    }

    /// <summary>
    /// BoolProperty: bWeaponDoubleJammed
    /// </summary>
    public unsafe bool bWeaponDoubleJammed
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 788) & 512) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 788); var newMask = value ? (currentMask | 512) : (currentMask & ~512); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 788); }
    }

    /// <summary>
    /// BoolProperty: bJamDiscovered
    /// </summary>
    public unsafe bool bJamDiscovered
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 788) & 1024) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 788); var newMask = value ? (currentMask | 1024) : (currentMask & ~1024); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 788); }
    }

    /// <summary>
    /// BoolProperty: bCanBeDestroyedByFearTakedown
    /// </summary>
    public unsafe bool bCanBeDestroyedByFearTakedown
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 788) & 2048) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 788); var newMask = value ? (currentMask | 2048) : (currentMask & ~2048); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 788); }
    }

    /// <summary>
    /// BoolProperty: bIgnoreWeaponSwitchCallback
    /// </summary>
    public unsafe bool bIgnoreWeaponSwitchCallback
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 788) & 4096) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 788); var newMask = value ? (currentMask | 4096) : (currentMask & ~4096); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 788); }
    }

    /// <summary>
    /// BoolProperty: bPawnGoRagdollWhenHitByBaseballBat
    /// </summary>
    public unsafe bool bPawnGoRagdollWhenHitByBaseballBat
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 788) & 8192) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 788); var newMask = value ? (currentMask | 8192) : (currentMask & ~8192); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 788); }
    }

    /// <summary>
    /// BoolProperty: bPooledWeapon_Inactive
    /// </summary>
    public unsafe bool bPooledWeapon_Inactive
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 788) & 16384) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 788); var newMask = value ? (currentMask | 16384) : (currentMask & ~16384); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 788); }
    }

    /// <summary>
    /// BoolProperty: bTickIsDisabled_BeforePool
    /// </summary>
    public unsafe bool bTickIsDisabled_BeforePool
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 788) & 32768) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 788); var newMask = value ? (currentMask | 32768) : (currentMask & ~32768); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 788); }
    }

    /// <summary>
    /// BoolProperty: bCollideActors_BeforePool
    /// </summary>
    public unsafe bool bCollideActors_BeforePool
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 788) & 65536) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 788); var newMask = value ? (currentMask | 65536) : (currentMask & ~65536); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 788); }
    }

    /// <summary>
    /// BoolProperty: bBlockActors_BeforePool
    /// </summary>
    public unsafe bool bBlockActors_BeforePool
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 788) & 131072) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 788); var newMask = value ? (currentMask | 131072) : (currentMask & ~131072); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 788); }
    }

    /// <summary>
    /// NameProperty: CurrentAttachBone
    /// </summary>
    public unsafe BmSDK.FName CurrentAttachBone
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 792); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 792); }
    }

    /// <summary>
    /// NameProperty: PrimaryAttachBone
    /// </summary>
    public unsafe BmSDK.FName PrimaryAttachBone
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 800); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 800); }
    }

    /// <summary>
    /// NameProperty: OffhandAttachBone
    /// </summary>
    public unsafe BmSDK.FName OffhandAttachBone
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 808); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 808); }
    }

    /// <summary>
    /// ComponentProperty: Mesh
    /// </summary>
    public unsafe BmSDK.Engine.SkeletalMeshComponent Mesh
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.SkeletalMeshComponent>(Ptr + 816); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 816); }
    }

    /// <summary>
    /// ObjectProperty: WeaponConfig
    /// </summary>
    public unsafe BmSDK.BmGame.RWeaponConfig WeaponConfig
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RWeaponConfig>(Ptr + 824); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 824); }
    }

    /// <summary>
    /// ObjectProperty: OverrideWeaponConfig
    /// </summary>
    public unsafe BmSDK.BmGame.RWeaponConfig OverrideWeaponConfig
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RWeaponConfig>(Ptr + 832); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 832); }
    }

    /// <summary>
    /// ObjectProperty: DisarmSound
    /// </summary>
    public unsafe BmSDK.Engine.AkEvent DisarmSound
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkEvent>(Ptr + 840); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 840); }
    }

    /// <summary>
    /// ObjectProperty: BlockSound
    /// </summary>
    public unsafe BmSDK.Engine.AkEvent BlockSound
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkEvent>(Ptr + 848); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 848); }
    }

    /// <summary>
    /// ObjectProperty: HitSound
    /// </summary>
    public unsafe BmSDK.Engine.AkEvent HitSound
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkEvent>(Ptr + 856); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 856); }
    }

    /// <summary>
    /// ObjectProperty: HitNPCSound
    /// </summary>
    public unsafe BmSDK.Engine.AkEvent HitNPCSound
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkEvent>(Ptr + 864); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 864); }
    }

    /// <summary>
    /// ObjectProperty: SwingSound
    /// </summary>
    public unsafe BmSDK.Engine.AkEvent SwingSound
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkEvent>(Ptr + 872); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 872); }
    }

    /// <summary>
    /// ObjectProperty: BreakSound
    /// </summary>
    public unsafe BmSDK.Engine.AkEvent BreakSound
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkEvent>(Ptr + 880); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 880); }
    }

    /// <summary>
    /// ObjectProperty: TauntAnimset
    /// </summary>
    public unsafe BmSDK.Engine.AnimSet TauntAnimset
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AnimSet>(Ptr + 888); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 888); }
    }

    /// <summary>
    /// ObjectProperty: CombatMovementAnimset
    /// </summary>
    public unsafe BmSDK.Engine.AnimSet CombatMovementAnimset
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AnimSet>(Ptr + 896); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 896); }
    }

    /// <summary>
    /// ObjectProperty: GrabAndThrowWeaponAnimset_Batman
    /// </summary>
    public unsafe BmSDK.Engine.AnimSet GrabAndThrowWeaponAnimset_Batman
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AnimSet>(Ptr + 904); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 904); }
    }

    /// <summary>
    /// ObjectProperty: GrabAndThrowWeaponAnimset_Thug
    /// </summary>
    public unsafe BmSDK.Engine.AnimSet GrabAndThrowWeaponAnimset_Thug
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AnimSet>(Ptr + 912); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 912); }
    }

    /// <summary>
    /// ObjectProperty: OwnerPawn
    /// </summary>
    public unsafe BmSDK.BmGame.RPawnCharacter OwnerPawn
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPawnCharacter>(Ptr + 920); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 920); }
    }

    /// <summary>
    /// ObjectProperty: AttachedToPawn
    /// </summary>
    public unsafe BmSDK.BmGame.RPawn AttachedToPawn
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPawn>(Ptr + 928); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 928); }
    }

    /// <summary>
    /// ObjectProperty: StartledAnimSet
    /// </summary>
    public unsafe BmSDK.Engine.AnimSet StartledAnimSet
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AnimSet>(Ptr + 936); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 936); }
    }

    /// <summary>
    /// ObjectProperty: ExtraWalksAnimSet
    /// </summary>
    public unsafe BmSDK.Engine.AnimSet ExtraWalksAnimSet
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AnimSet>(Ptr + 944); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 944); }
    }

    /// <summary>
    /// ObjectProperty: WeaponAnimSet
    /// </summary>
    public unsafe BmSDK.Engine.AnimSet WeaponAnimSet
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AnimSet>(Ptr + 952); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 952); }
    }

    /// <summary>
    /// ObjectProperty: ForceTargetPlayer
    /// </summary>
    public unsafe BmSDK.Engine.PlayerController ForceTargetPlayer
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.PlayerController>(Ptr + 960); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 960); }
    }

    /// <summary>
    /// ObjectProperty: XRayJammedMaterial
    /// </summary>
    public unsafe BmSDK.Engine.MaterialInterface XRayJammedMaterial
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.MaterialInterface>(Ptr + 968); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 968); }
    }

    /// <summary>
    /// ObjectProperty: XRayDoubleJammedMaterial
    /// </summary>
    public unsafe BmSDK.Engine.MaterialInterface XRayDoubleJammedMaterial
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.MaterialInterface>(Ptr + 976); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 976); }
    }

    /// <summary>
    /// ObjectProperty: XRayDangerousMaterial
    /// </summary>
    public unsafe BmSDK.Engine.MaterialInterface XRayDangerousMaterial
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.MaterialInterface>(Ptr + 984); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 984); }
    }

    /// <summary>
    /// ObjectProperty: ThermalMaterial
    /// </summary>
    public unsafe BmSDK.Engine.MaterialInterface ThermalMaterial
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.MaterialInterface>(Ptr + 992); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 992); }
    }

    /// <summary>
    /// ObjectProperty: XRayMaterialMIC
    /// </summary>
    public unsafe BmSDK.Engine.MaterialInstanceConstant XRayMaterialMIC
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.MaterialInstanceConstant>(Ptr + 1000); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1000); }
    }

    /// <summary>
    /// ObjectProperty: XRayMetalMaterialMIC
    /// </summary>
    public unsafe BmSDK.Engine.MaterialInstanceConstant XRayMetalMaterialMIC
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.MaterialInstanceConstant>(Ptr + 1008); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1008); }
    }

    /// <summary>
    /// ObjectProperty: ThermalMIC
    /// </summary>
    public unsafe BmSDK.Engine.MaterialInstanceConstant ThermalMIC
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.MaterialInstanceConstant>(Ptr + 1016); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1016); }
    }

    /// <summary>
    /// ObjectProperty: MyLevelForXray
    /// </summary>
    public unsafe BmSDK.Engine.LevelStreaming MyLevelForXray
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.LevelStreaming>(Ptr + 1024); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1024); }
    }

    /// <summary>
    /// ObjectProperty: BlockAnimset
    /// </summary>
    public unsafe BmSDK.Engine.AnimSet BlockAnimset
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AnimSet>(Ptr + 1032); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1032); }
    }

    /// <summary>
    /// ObjectProperty: HitReactionAnimSet
    /// </summary>
    public unsafe BmSDK.Engine.AnimSet HitReactionAnimSet
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AnimSet>(Ptr + 1040); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1040); }
    }

    /// <summary>
    /// ObjectProperty: JammedVFXTemplate
    /// </summary>
    public unsafe BmSDK.Engine.ParticleSystem JammedVFXTemplate
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleSystem>(Ptr + 1048); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1048); }
    }

    /// <summary>
    /// ObjectProperty: DoubleJammedVFXTemplate
    /// </summary>
    public unsafe BmSDK.Engine.ParticleSystem DoubleJammedVFXTemplate
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleSystem>(Ptr + 1056); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1056); }
    }

    /// <summary>
    /// ObjectProperty: WeaponAudioSwitchName
    /// </summary>
    public unsafe BmSDK.Engine.AkSwitchName WeaponAudioSwitchName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkSwitchName>(Ptr + 1064); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1064); }
    }

    /// <summary>
    /// ObjectProperty: WeaponPool
    /// </summary>
    public unsafe BmSDK.BmGame.RWeaponPool WeaponPool
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RWeaponPool>(Ptr + 1072); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1072); }
    }

    /// <summary>
    /// ObjectProperty: MultiplayerAuraMIC
    /// </summary>
    public unsafe BmSDK.Engine.MaterialInstanceConstant MultiplayerAuraMIC
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.MaterialInstanceConstant>(Ptr + 1080); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1080); }
    }

    /// <summary>
    /// ComponentProperty: MultiplayerAuraMesh
    /// </summary>
    public unsafe BmSDK.Engine.SkeletalMeshComponent MultiplayerAuraMesh
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.SkeletalMeshComponent>(Ptr + 1088); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1088); }
    }

    /// <summary>
    /// ComponentProperty: DLCXtraMaskMesh
    /// </summary>
    public unsafe BmSDK.Engine.SkeletalMeshComponent DLCXtraMaskMesh
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.SkeletalMeshComponent>(Ptr + 1096); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1096); }
    }

    /// <summary>
    /// ClassProperty: DamageType
    /// </summary>
    public unsafe BmSDK.Class DamageType
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Class>(Ptr + 1104); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1104); }
    }

    /// <summary>
    /// ClassProperty: MilitiaOverride
    /// </summary>
    public unsafe BmSDK.Class MilitiaOverride
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Class>(Ptr + 1112); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1112); }
    }

    /// <summary>
    /// ClassProperty: SmokeBombReactionClass
    /// </summary>
    public unsafe BmSDK.Class SmokeBombReactionClass
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Class>(Ptr + 1120); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1120); }
    }

    /// <summary>
    /// ClassProperty: JammedAttackMoveClass
    /// </summary>
    public unsafe BmSDK.Class JammedAttackMoveClass
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Class>(Ptr + 1128); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1128); }
    }

    /// <summary>
    /// ClassProperty: AttackMoveClass
    /// </summary>
    public unsafe BmSDK.Class AttackMoveClass
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Class>(Ptr + 1136); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1136); }
    }

    /// <summary>
    /// ClassProperty: CombatBehaviourClass
    /// </summary>
    public unsafe BmSDK.Class CombatBehaviourClass
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Class>(Ptr + 1144); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1144); }
    }

    /// <summary>
    /// ClassProperty: DestroyedObjectClass
    /// </summary>
    public unsafe BmSDK.Class DestroyedObjectClass
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Class>(Ptr + 1152); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1152); }
    }

    /// <summary>
    /// ClassProperty: ThrownObjectClass
    /// </summary>
    public unsafe BmSDK.Class ThrownObjectClass
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Class>(Ptr + 1160); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1160); }
    }

    /// <summary>
    /// ClassProperty: WeaponPoolEquivalent
    /// </summary>
    public unsafe BmSDK.Class WeaponPoolEquivalent
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Class>(Ptr + 1168); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1168); }
    }

    /// <summary>
    /// ByteProperty: Smashability
    /// </summary>
    public unsafe BmSDK.BmGame.RBMWeapon.ESmashStatus Smashability
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RBMWeapon.ESmashStatus>(Ptr + 1176); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1176); }
    }

    /// <summary>
    /// ByteProperty: takedownType
    /// </summary>
    public unsafe BmSDK.BmGame.RPawnPlayerCombat.ETakedownType takedownType
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPawnPlayerCombat.ETakedownType>(Ptr + 1177); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1177); }
    }

    /// <summary>
    /// ByteProperty: WeaponDestroyType
    /// </summary>
    public unsafe BmSDK.BmGame.RPawnPlayerCombat.EWeaponDestroyType WeaponDestroyType
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPawnPlayerCombat.EWeaponDestroyType>(Ptr + 1178); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1178); }
    }

    /// <summary>
    /// ByteProperty: BeatdownTargetType
    /// </summary>
    public unsafe BmSDK.BmGame.RPawnPlayerCombat.StrikeTargetType BeatdownTargetType
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPawnPlayerCombat.StrikeTargetType>(Ptr + 1179); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1179); }
    }

    /// <summary>
    /// ByteProperty: KOGameAction
    /// </summary>
    public unsafe BmSDK.BmGame.RGameInfo.EGameAction KOGameAction
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RGameInfo.EGameAction>(Ptr + 1180); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1180); }
    }

    /// <summary>
    /// ByteProperty: HudWeaponType
    /// </summary>
    public unsafe BmSDK.BmGame.RGameInfo.EHudWeaponType HudWeaponType
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RGameInfo.EHudWeaponType>(Ptr + 1181); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1181); }
    }

    /// <summary>
    /// ByteProperty: HudWeaponTypeWhenJammed
    /// </summary>
    public unsafe BmSDK.BmGame.RGameInfo.EHudWeaponType HudWeaponTypeWhenJammed
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RGameInfo.EHudWeaponType>(Ptr + 1182); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1182); }
    }

    /// <summary>
    /// ByteProperty: MultiAttackCounterLimb
    /// </summary>
    public unsafe BmSDK.BmGame.RGameInfo.CounterLimb MultiAttackCounterLimb
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RGameInfo.CounterLimb>(Ptr + 1183); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1183); }
    }

    /// <summary>
    /// ByteProperty: WeaponConfigType
    /// </summary>
    public unsafe BmSDK.BmGame.RBMCombatManager.EWeaponConfigType WeaponConfigType
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RBMCombatManager.EWeaponConfigType>(Ptr + 1184); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1184); }
    }

    /// <summary>
    /// ByteProperty: CombatReadiness
    /// </summary>
    public unsafe BmSDK.BmGame.RPawnVillain.CombatReadinessState CombatReadiness
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPawnVillain.CombatReadinessState>(Ptr + 1185); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1185); }
    }

    /// <summary>
    /// ByteProperty: CombatReadinessBot
    /// </summary>
    public unsafe BmSDK.BmGame.RPawnVillain.CombatReadinessState CombatReadinessBot
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPawnVillain.CombatReadinessState>(Ptr + 1186); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1186); }
    }

    /// <summary>
    /// FloatProperty: VillainThrowDistanceMulti
    /// </summary>
    public unsafe float VillainThrowDistanceMulti
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1188); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1188); }
    }

    /// <summary>
    /// NameProperty: CombatMoveStance
    /// </summary>
    public unsafe BmSDK.FName CombatMoveStance
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 1192); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1192); }
    }

    /// <summary>
    /// NameProperty: TauntMoveStance
    /// </summary>
    public unsafe BmSDK.FName TauntMoveStance
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 1200); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1200); }
    }

    /// <summary>
    /// ArrayProperty: TauntAnims
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.FName> TauntAnims
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.FName>>(Ptr + 1208); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1208); }
    }

    /// <summary>
    /// ArrayProperty: TauntAnimInfos
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RGameRI.FTauntAnimInfo> TauntAnimInfos
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RGameRI.FTauntAnimInfo>>(Ptr + 1224); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1224); }
    }

    /// <summary>
    /// ArrayProperty: OverlayAnims
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.FName> OverlayAnims
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.FName>>(Ptr + 1240); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1240); }
    }

    /// <summary>
    /// ArrayProperty: CombatIdleStances
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.FName> CombatIdleStances
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.FName>>(Ptr + 1256); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1256); }
    }

    /// <summary>
    /// ArrayProperty: StepList
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.FName> StepList
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.FName>>(Ptr + 1272); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1272); }
    }

    /// <summary>
    /// FloatProperty: StepLength
    /// </summary>
    public unsafe float StepLength
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1288); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1288); }
    }

    /// <summary>
    /// ArrayProperty: LongStepList
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.FName> LongStepList
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.FName>>(Ptr + 1292); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1292); }
    }

    /// <summary>
    /// NameProperty: ForwardStepName
    /// </summary>
    public unsafe BmSDK.FName ForwardStepName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 1308); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1308); }
    }

    /// <summary>
    /// NameProperty: SkeletonGetUpAnim
    /// </summary>
    public unsafe BmSDK.FName SkeletonGetUpAnim
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 1316); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1316); }
    }

    /// <summary>
    /// FloatProperty: SavedXrayAlpha
    /// </summary>
    public unsafe float SavedXrayAlpha
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1324); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1324); }
    }

    /// <summary>
    /// FloatProperty: XrayFadeDist
    /// </summary>
    public unsafe float XrayFadeDist
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1328); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1328); }
    }

    /// <summary>
    /// FloatProperty: XRayVisibilityTimer
    /// </summary>
    public unsafe float XRayVisibilityTimer
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1332); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1332); }
    }

    /// <summary>
    /// FloatProperty: XRayVisibilityFadeInStartTime
    /// </summary>
    public unsafe float XRayVisibilityFadeInStartTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1336); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1336); }
    }

    /// <summary>
    /// FloatProperty: XRayVisibilityFadeInDuration
    /// </summary>
    public unsafe float XRayVisibilityFadeInDuration
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1340); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1340); }
    }

    /// <summary>
    /// StrProperty: FriendlyName
    /// </summary>
    public unsafe BmSDK.FString FriendlyName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 1344); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1344); }
    }

    /// <summary>
    /// ArrayProperty: AdditionalBarksets
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RBarkSet> AdditionalBarksets
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RBarkSet>>(Ptr + 1360); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1360); }
    }

    /// <summary>
    /// ArrayProperty: LoadBarkSetStrings
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.FString> LoadBarkSetStrings
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.FString>>(Ptr + 1376); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1376); }
    }

    /// <summary>
    /// StrProperty: LoadingBarkSetPackage
    /// </summary>
    public unsafe BmSDK.FString LoadingBarkSetPackage
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 1392); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1392); }
    }

    /// <summary>
    /// NameProperty: WeaponFlagValue
    /// </summary>
    public unsafe BmSDK.FName WeaponFlagValue
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 1408); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1408); }
    }

    /// <summary>
    /// NameProperty: OverworldName
    /// </summary>
    public unsafe BmSDK.FName OverworldName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 1416); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1416); }
    }

    /// <summary>
    /// NameProperty: PickupTransitionName
    /// </summary>
    public unsafe BmSDK.FName PickupTransitionName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 1424); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1424); }
    }

    /// <summary>
    /// NameProperty: PickupSlideTransitionName
    /// </summary>
    public unsafe BmSDK.FName PickupSlideTransitionName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 1432); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1432); }
    }

    /// <summary>
    /// NameProperty: PickupKnackeredTransitionName
    /// </summary>
    public unsafe BmSDK.FName PickupKnackeredTransitionName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 1440); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1440); }
    }

    /// <summary>
    /// ArrayProperty: PlayerPairedAnimsetPackageDefs
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RBMCombatManager.FPairedAnimsetPackageDef> PlayerPairedAnimsetPackageDefs
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RBMCombatManager.FPairedAnimsetPackageDef>>(Ptr + 1448); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1448); }
    }

    /// <summary>
    /// IntProperty: CurrPairedAnimsetIndex
    /// </summary>
    public unsafe int CurrPairedAnimsetIndex
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1464); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1464); }
    }

    /// <summary>
    /// IntProperty: CurrPairedAnimsetIndexBot
    /// </summary>
    public unsafe int CurrPairedAnimsetIndexBot
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1468); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1468); }
    }

    /// <summary>
    /// ArrayProperty: RegisteredPairedAnimsets
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RPawnVillain.FRegisteredPairedAnimsetInfo> RegisteredPairedAnimsets
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RPawnVillain.FRegisteredPairedAnimsetInfo>>(Ptr + 1472); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1472); }
    }

    /// <summary>
    /// StrProperty: LoadingPairedAnimsetPackage
    /// </summary>
    public unsafe BmSDK.FString LoadingPairedAnimsetPackage
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 1488); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1488); }
    }

    /// <summary>
    /// StrProperty: LoadingPairedAnimsetPackageBot
    /// </summary>
    public unsafe BmSDK.FString LoadingPairedAnimsetPackageBot
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 1504); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1504); }
    }

    /// <summary>
    /// ArrayProperty: CombatAnimsetRefHolders
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RCharacterBioCue> CombatAnimsetRefHolders
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RCharacterBioCue>>(Ptr + 1520); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1520); }
    }

    /// <summary>
    /// NameProperty: nJammedVFXAttachBone
    /// </summary>
    public unsafe BmSDK.FName nJammedVFXAttachBone
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 1536); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1536); }
    }

    /// <summary>
    /// StructProperty: vJammedVFXPivotParameter
    /// </summary>
    public unsafe System.Numerics.Vector3 vJammedVFXPivotParameter
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 1544); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1544); }
    }

    /// <summary>
    /// FloatProperty: fJammedVFXRadiusParameter
    /// </summary>
    public unsafe float fJammedVFXRadiusParameter
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1556); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1556); }
    }

    /// <summary>
    /// FloatProperty: fJammedVFXLengthParameter
    /// </summary>
    public unsafe float fJammedVFXLengthParameter
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1560); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1560); }
    }

    /// <summary>
    /// StrProperty: sDisruptorHUDDescription
    /// </summary>
    public unsafe BmSDK.FString sDisruptorHUDDescription
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 1564); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1564); }
    }

    /// <summary>
    /// FloatProperty: TurnOnPickupTime
    /// </summary>
    public unsafe float TurnOnPickupTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1580); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1580); }
    }

    /// <summary>
    /// IntProperty: NumTimesUsedByPlayer
    /// </summary>
    public unsafe int NumTimesUsedByPlayer
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1584); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1584); }
    }

    /// <summary>
    /// ArrayProperty: BMCounterAnimset
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.Engine.AnimSet> BMCounterAnimset
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.AnimSet>>(Ptr + 1588); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1588); }
    }

    /// <summary>
    /// ArrayProperty: CounterAnimset
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.Engine.AnimSet> CounterAnimset
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.AnimSet>>(Ptr + 1604); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1604); }
    }

    /// <summary>
    /// ArrayProperty: TakedownAnimset
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.Engine.AnimSet> TakedownAnimset
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.AnimSet>>(Ptr + 1620); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1620); }
    }

    /// <summary>
    /// ArrayProperty: BMTakedownAnimset
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.Engine.AnimSet> BMTakedownAnimset
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.AnimSet>>(Ptr + 1636); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1636); }
    }

    /// <summary>
    /// ArrayProperty: BeatdownHitReactionAnimset
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.Engine.AnimSet> BeatdownHitReactionAnimset
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.AnimSet>>(Ptr + 1652); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1652); }
    }

    /// <summary>
    /// ArrayProperty: VillainAerialAttackAnimset
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.Engine.AnimSet> VillainAerialAttackAnimset
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.AnimSet>>(Ptr + 1668); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1668); }
    }

    /// <summary>
    /// ArrayProperty: PlayerAerialAttackAnimset
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.Engine.AnimSet> PlayerAerialAttackAnimset
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.AnimSet>>(Ptr + 1684); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1684); }
    }

    /// <summary>
    /// ArrayProperty: VillainFloorTakedownAnimset
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.Engine.AnimSet> VillainFloorTakedownAnimset
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.AnimSet>>(Ptr + 1700); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1700); }
    }

    /// <summary>
    /// ArrayProperty: PlayerFloorTakedownAnimset
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.Engine.AnimSet> PlayerFloorTakedownAnimset
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.AnimSet>>(Ptr + 1716); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1716); }
    }

    /// <summary>
    /// ArrayProperty: CameraAnimsets
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.Engine.AnimSet> CameraAnimsets
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.AnimSet>>(Ptr + 1732); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1732); }
    }
}
