#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: MPawnPlayerRedHoodBase<br/>
/// (size = 0)
/// (flags = 0)
/// </summary>
public partial class MPawnPlayerRedHoodBase : BmSDK.BmGame.RPawnPlayer, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.MPawnPlayerRedHoodBase", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal MPawnPlayerRedHoodBase() { }

    /// <summary>
    /// Constructs a new MPawnPlayerRedHoodBase
    /// </summary>
    public MPawnPlayerRedHoodBase(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, MPawnPlayerRedHoodBase Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected MPawnPlayerRedHoodBase(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="Engine.Actor.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<MPawnPlayerRedHoodBase>
        => ((Engine.Actor)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="Engine.Actor.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<MPawnPlayerRedHoodBase>, new()
        => (TComponent)((Engine.Actor)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="Engine.Actor.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<MPawnPlayerRedHoodBase>
        => ((Engine.Actor)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="Engine.Actor.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<MPawnPlayerRedHoodBase>
        => ((Engine.Actor)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="Engine.Actor.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<MPawnPlayerRedHoodBase>
        => (TComponent)((Engine.Actor)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="Engine.Actor.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<MPawnPlayerRedHoodBase>
        => ((Engine.Actor)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="Engine.Actor.DetachScriptComponent(Type)"/>
    public void DetachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<MPawnPlayerRedHoodBase>
        => ((Engine.Actor)this).DetachScriptComponent(typeof(TComponent));

    /// <summary>
    /// ComponentProperty: LeftWeapon
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT LeftWeapon
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 10032); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 10032); }
    }

    /// <summary>
    /// ComponentProperty: RightWeapon
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT RightWeapon
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 10040); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 10040); }
    }

    /// <summary>
    /// BoolProperty: LeftWeaponEquipped
    /// </summary>
    public unsafe bool LeftWeaponEquipped
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 10048) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 10048); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 10048); }
    }

    /// <summary>
    /// BoolProperty: RightWeaponEquipped
    /// </summary>
    public unsafe bool RightWeaponEquipped
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 10048) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 10048); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 10048); }
    }

    /// <summary>
    /// BoolProperty: UsePostCombatStance
    /// </summary>
    public unsafe bool UsePostCombatStance
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 10048) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 10048); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 10048); }
    }

    /// <summary>
    /// BoolProperty: PostCombatStanceDisabled
    /// </summary>
    public unsafe bool PostCombatStanceDisabled
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 10048) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 10048); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 10048); }
    }

    /// <summary>
    /// BoolProperty: UseStrikeMirrored
    /// </summary>
    public unsafe bool UseStrikeMirrored
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 10048) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 10048); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 10048); }
    }

    /// <summary>
    /// BoolProperty: CurrentStrikeMirrored
    /// </summary>
    public unsafe bool CurrentStrikeMirrored
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 10048) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 10048); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 10048); }
    }

    /// <summary>
    /// BoolProperty: GettingTarget
    /// </summary>
    public unsafe bool GettingTarget
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 10048) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 10048); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 10048); }
    }

    /// <summary>
    /// BoolProperty: bExtraMeshHidden
    /// </summary>
    public unsafe bool bExtraMeshHidden
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 10048) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 10048); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 10048); }
    }

    /// <summary>
    /// BoolProperty: bBlackMaskTarget
    /// </summary>
    public unsafe bool bBlackMaskTarget
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 10048) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 10048); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 10048); }
    }

    /// <summary>
    /// StructProperty: PutAwayHandgunId
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT PutAwayHandgunId
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 10052); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 10052); }
    }

    /// <summary>
    /// NameProperty: TargetClass
    /// </summary>
    public unsafe BmSDK.FName TargetClass
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 10056); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 10056); }
    }

    /// <summary>
    /// IntProperty: RicochetRay
    /// </summary>
    public unsafe int RicochetRay
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 10064); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 10064); }
    }

    /// <summary>
    /// IntProperty: RicochetNumRays
    /// </summary>
    public unsafe int RicochetNumRays
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 10068); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 10068); }
    }

    /// <summary>
    /// FloatProperty: RicochetMaxRange
    /// </summary>
    public unsafe float RicochetMaxRange
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 10072); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 10072); }
    }

    /// <summary>
    /// IntProperty: RicochetMaxBounces
    /// </summary>
    public unsafe int RicochetMaxBounces
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 10076); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 10076); }
    }

    /// <summary>
    /// FloatProperty: RicochetMaxAngle
    /// </summary>
    public unsafe float RicochetMaxAngle
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 10080); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 10080); }
    }

    /// <summary>
    /// IntProperty: RicochetMaxExtraTargets
    /// </summary>
    public unsafe int RicochetMaxExtraTargets
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 10084); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 10084); }
    }

    /// <summary>
    /// FloatProperty: RicochetExtraTargetMaxDist
    /// </summary>
    public unsafe float RicochetExtraTargetMaxDist
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 10088); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 10088); }
    }

    /// <summary>
    /// ArrayProperty: RicochetBouncePoints
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RPawnPlayer.XRayBoneMaterialMIC> RicochetBouncePoints
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RPawnPlayer.XRayBoneMaterialMIC>>(Ptr + 10092); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 10092); }
    }

    /// <summary>
    /// IntProperty: RicochetNumTargets
    /// </summary>
    public unsafe int RicochetNumTargets
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 10108); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 10108); }
    }

    /// <summary>
    /// ObjectProperty: StrikeContactEvent
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT StrikeContactEvent
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 10112); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 10112); }
    }

    /// <summary>
    /// ObjectProperty: DockShootingConversation
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT DockShootingConversation
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 10120); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 10120); }
    }

    /// <summary>
    /// ObjectProperty: DockTakedownConversation
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT DockTakedownConversation
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 10128); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 10128); }
    }

    /// <summary>
    /// ObjectProperty: MallShootingConversation
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT MallShootingConversation
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 10136); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 10136); }
    }

    /// <summary>
    /// ObjectProperty: MallTakedownConversation
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT MallTakedownConversation
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 10144); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 10144); }
    }

    /// <summary>
    /// ObjectProperty: OfficeShootingConversation
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT OfficeShootingConversation
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 10152); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 10152); }
    }

    /// <summary>
    /// ObjectProperty: OfficeTakedownConversation
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT OfficeTakedownConversation
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 10160); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 10160); }
    }

    /// <summary>
    /// ObjectProperty: CounterBMShotConversation
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT CounterBMShotConversation
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 10168); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 10168); }
    }

    /// <summary>
    /// ObjectProperty: ThugBulletReactionAnimSet
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT ThugBulletReactionAnimSet
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 10176); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 10176); }
    }

    /// <summary>
    /// ObjectProperty: BulletRicochetFX
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT BulletRicochetFX
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 10184); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 10184); }
    }

    /// <summary>
    /// ObjectProperty: CustomCamAnimset
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT CustomCamAnimset
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 10192); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 10192); }
    }

    /// <summary>
    /// Struct: FRhStickBouncePoint
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 0)]
    public partial record struct FRhStickBouncePoint
    {
        /// <summary>
        /// StructProperty: Location
        /// </summary>
        public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT Location
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// StructProperty: Normal
        /// </summary>
        public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT Normal
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 12); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 12); }; }
        }

        /// <summary>
        /// ObjectProperty: Pawn
        /// </summary>
        public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT Pawn
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 24); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 24); }; }
        }
    }
}
