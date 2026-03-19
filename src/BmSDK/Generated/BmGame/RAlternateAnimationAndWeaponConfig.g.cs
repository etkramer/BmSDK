#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RAlternateAnimationAndWeaponConfig<br/>
/// (size = 0)
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
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT WeaponMesh
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 84); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 84); }
    }

    /// <summary>
    /// ObjectProperty: Physics
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT Physics
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 92); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 92); }
    }

    /// <summary>
    /// ObjectProperty: AnimSet1
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT AnimSet1
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 100); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 100); }
    }

    /// <summary>
    /// ObjectProperty: AnimSet2
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT AnimSet2
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 108); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 108); }
    }

    /// <summary>
    /// ObjectProperty: TurnAnimSet
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT TurnAnimSet
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 116); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 116); }
    }

    /// <summary>
    /// ObjectProperty: StartledAnimSet
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT StartledAnimSet
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 124); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 124); }
    }

    /// <summary>
    /// ObjectProperty: ExtraWalksAnimSet
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT ExtraWalksAnimSet
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 132); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 132); }
    }

    /// <summary>
    /// ObjectProperty: XRayMaterial
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT XRayMaterial
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 140); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 140); }
    }

    /// <summary>
    /// ClassProperty: DefaultAlternateWeaponBaseClass
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT DefaultAlternateWeaponBaseClass
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 148); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 148); }
    }

    /// <summary>
    /// ClassProperty: AlternateWeaponBaseClass
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT AlternateWeaponBaseClass
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 156); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 156); }
    }

    /// <summary>
    /// ClassProperty: DropClass
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT DropClass
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 164); }
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
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 180) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 180); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 180); }
    }

    /// <summary>
    /// BoolProperty: bAllowTurningToAim
    /// </summary>
    public unsafe bool bAllowTurningToAim
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 180) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 180); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 180); }
    }

    /// <summary>
    /// BoolProperty: bDropOnFirstHit
    /// </summary>
    public unsafe bool bDropOnFirstHit
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 180) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 180); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 180); }
    }

    /// <summary>
    /// StructProperty: MovementAnims
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT MovementAnims
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 184); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 184); }
    }

    /// <summary>
    /// ArrayProperty: Overlays
    /// </summary>
    public unsafe BmSDK.TArray<NEED_UPDATE_ARRAYPROPERTY_LAYOUT> Overlays
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<NEED_UPDATE_ARRAYPROPERTY_LAYOUT>>(Ptr + 228); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 228); }
    }

    /// <summary>
    /// ArrayProperty: AdditiveOverlays
    /// </summary>
    public unsafe NEED_UPDATE_ARRAYPROPERTY_LAYOUT AdditiveOverlays
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_ARRAYPROPERTY_LAYOUT>(Ptr + 244); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 244); }
    }
}
