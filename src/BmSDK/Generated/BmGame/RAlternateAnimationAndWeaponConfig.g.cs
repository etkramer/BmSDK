#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RAlternateAnimationAndWeaponConfig<br/>
/// (flags = 0)
/// </summary>
public partial class RAlternateAnimationAndWeaponConfig : BmSDK.BmGame.RConfig, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RAlternateAnimationAndWeaponConfig", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RAlternateAnimationAndWeaponConfig() { }

    /// <summary>
    /// Constructs a new RAlternateAnimationAndWeaponConfig
    /// </summary>
    public RAlternateAnimationAndWeaponConfig(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RAlternateAnimationAndWeaponConfig Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RAlternateAnimationAndWeaponConfig(nint ptr) : base(ptr) { }

    /// <summary>
    /// ObjectProperty: WeaponMesh
    /// </summary>
    public unsafe BmSDK.Engine.SkeletalMesh WeaponMesh
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.SkeletalMesh>(Ptr + 84); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 84); }
    }

    /// <summary>
    /// ObjectProperty: Physics
    /// </summary>
    public unsafe BmSDK.Engine.PhysicsAsset Physics
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.PhysicsAsset>(Ptr + 92); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 92); }
    }

    /// <summary>
    /// ObjectProperty: AnimSet1
    /// </summary>
    public unsafe BmSDK.Engine.AnimSet AnimSet1
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AnimSet>(Ptr + 100); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 100); }
    }

    /// <summary>
    /// ObjectProperty: AnimSet2
    /// </summary>
    public unsafe BmSDK.Engine.AnimSet AnimSet2
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AnimSet>(Ptr + 108); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 108); }
    }

    /// <summary>
    /// ObjectProperty: TurnAnimSet
    /// </summary>
    public unsafe BmSDK.Engine.AnimSet TurnAnimSet
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AnimSet>(Ptr + 116); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 116); }
    }

    /// <summary>
    /// ObjectProperty: StartledAnimSet
    /// </summary>
    public unsafe BmSDK.Engine.AnimSet StartledAnimSet
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AnimSet>(Ptr + 124); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 124); }
    }

    /// <summary>
    /// ObjectProperty: ExtraWalksAnimSet
    /// </summary>
    public unsafe BmSDK.Engine.AnimSet ExtraWalksAnimSet
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AnimSet>(Ptr + 132); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 132); }
    }

    /// <summary>
    /// ObjectProperty: XRayMaterial
    /// </summary>
    public unsafe BmSDK.Engine.MaterialInterface XRayMaterial
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.MaterialInterface>(Ptr + 140); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 140); }
    }

    /// <summary>
    /// ClassProperty: DefaultAlternateWeaponBaseClass
    /// </summary>
    public unsafe BmSDK.Class DefaultAlternateWeaponBaseClass
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Class>(Ptr + 148); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 148); }
    }

    /// <summary>
    /// ClassProperty: AlternateWeaponBaseClass
    /// </summary>
    public unsafe BmSDK.Class AlternateWeaponBaseClass
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Class>(Ptr + 156); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 156); }
    }

    /// <summary>
    /// ClassProperty: DropClass
    /// </summary>
    public unsafe BmSDK.Class DropClass
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Class>(Ptr + 164); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 164); }
    }

    /// <summary>
    /// NameProperty: AttachBoneName
    /// </summary>
    public unsafe BmSDK.FName AttachBoneName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 172); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 172); }
    }

    /// <summary>
    /// BoolProperty: bForceWeaponMesh
    /// </summary>
    public unsafe bool bForceWeaponMesh
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 180) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 180); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 180); }
    }

    /// <summary>
    /// BoolProperty: bAllowTurningToAim
    /// </summary>
    public unsafe bool bAllowTurningToAim
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 180) & 2) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 180); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 180); }
    }

    /// <summary>
    /// BoolProperty: bDropOnFirstHit
    /// </summary>
    public unsafe bool bDropOnFirstHit
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 180) & 4) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 180); var newMask = value ? (currentMask | 4) : (currentMask & ~4); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 180); }
    }

    /// <summary>
    /// StructProperty: MovementAnims
    /// </summary>
    public unsafe BmSDK.BmGame.RAlternateAnimationAndWeaponConfig.FMovementAnimNames MovementAnims
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RAlternateAnimationAndWeaponConfig.FMovementAnimNames>(Ptr + 184); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 184); }
    }

    /// <summary>
    /// ArrayProperty: Overlays
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RAlternateAnimationAndWeaponConfig.FOverlayAnimNames> Overlays
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RAlternateAnimationAndWeaponConfig.FOverlayAnimNames>>(Ptr + 228); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 228); }
    }

    /// <summary>
    /// ArrayProperty: AdditiveOverlays
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RAlternateAnimationAndWeaponConfig.FAdditiveOverlayAnimNames> AdditiveOverlays
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RAlternateAnimationAndWeaponConfig.FAdditiveOverlayAnimNames>>(Ptr + 244); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 244); }
    }
}
