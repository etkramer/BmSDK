#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RBMBehaviour_HitReaction<br/>
/// (size = 0)
/// (flags = 0)
/// </summary>
public partial class RBMBehaviour_HitReaction : BmSDK.BmGame.RBMBehaviour, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RBMBehaviour_HitReaction", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RBMBehaviour_HitReaction() { }

    /// <summary>
    /// Constructs a new RBMBehaviour_HitReaction
    /// </summary>
    public RBMBehaviour_HitReaction(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RBMBehaviour_HitReaction Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RBMBehaviour_HitReaction(nint ptr) : base(ptr) { }

    /// <summary>
    /// StructProperty: HitDmgInfo
    /// </summary>
    public unsafe BmSDK.BmGame.RBMBehaviour_HitReaction.HitTargets HitDmgInfo
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RBMBehaviour_HitReaction.HitTargets>(Ptr + 588); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 588); }
    }

    /// <summary>
    /// NameProperty: DestMoveStance
    /// </summary>
    public unsafe BmSDK.FName DestMoveStance
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 836); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 836); }
    }

    /// <summary>
    /// NameProperty: DestWeaponStance
    /// </summary>
    public unsafe BmSDK.FName DestWeaponStance
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 844); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 844); }
    }

    /// <summary>
    /// BoolProperty: bStoredJustClimbedLadder
    /// </summary>
    public unsafe bool bStoredJustClimbedLadder
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 852) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 852); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 852); }
    }

    /// <summary>
    /// BoolProperty: bInterruptedHitReaction
    /// </summary>
    public unsafe bool bInterruptedHitReaction
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 852) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 852); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 852); }
    }

    /// <summary>
    /// BoolProperty: bCanRepel
    /// </summary>
    public unsafe bool bCanRepel
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 852) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 852); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 852); }
    }

    /// <summary>
    /// BoolProperty: bCanBlock
    /// </summary>
    public unsafe bool bCanBlock
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 852) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 852); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 852); }
    }

    /// <summary>
    /// BoolProperty: bPlayedHitFX
    /// </summary>
    public unsafe bool bPlayedHitFX
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 852) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 852); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 852); }
    }

    /// <summary>
    /// BoolProperty: bStunned
    /// </summary>
    public unsafe bool bStunned
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 852) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 852); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 852); }
    }

    /// <summary>
    /// BoolProperty: Orig_bForceAllowToHitThugs
    /// </summary>
    public unsafe bool Orig_bForceAllowToHitThugs
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 852) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 852); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 852); }
    }

    /// <summary>
    /// BoolProperty: bDisarmTriggersRagdoll
    /// </summary>
    public unsafe bool bDisarmTriggersRagdoll
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 852) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 852); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 852); }
    }

    /// <summary>
    /// BoolProperty: bCheckForEnvironmentDuringReaction
    /// </summary>
    public unsafe bool bCheckForEnvironmentDuringReaction
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 852) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 852); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 852); }
    }

    /// <summary>
    /// BoolProperty: bRECShotgunAIReactionTriggered
    /// </summary>
    public unsafe bool bRECShotgunAIReactionTriggered
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 852) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 852); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 852); }
    }

    /// <summary>
    /// BoolProperty: bOrigPawnStasis
    /// </summary>
    public unsafe bool bOrigPawnStasis
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 852) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 852); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 852); }
    }

    /// <summary>
    /// ObjectProperty: CurrWeapon
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT CurrWeapon
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 856); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 856); }
    }

    /// <summary>
    /// ComponentProperty: StunnedFX
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT StunnedFX
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 864); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 864); }
    }

    /// <summary>
    /// StructProperty: MovementDirection
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT MovementDirection
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 872); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 872); }
    }

    /// <summary>
    /// StructProperty: HitAnim
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT HitAnim
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 884); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 884); }
    }

    /// <summary>
    /// ArrayProperty: HitTargets
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.FString>>>>>>> HitTargets
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.FString>>>>>>>>(Ptr + 888); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 888); }
    }

    /// <summary>
    /// ByteProperty: HitReactionTransType
    /// </summary>
    public unsafe byte HitReactionTransType
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 904); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 904); }
    }
}
