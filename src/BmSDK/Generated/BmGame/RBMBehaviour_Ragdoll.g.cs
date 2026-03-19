#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RBMBehaviour_Ragdoll<br/>
/// (size = 0)
/// (flags = 0)
/// </summary>
public partial class RBMBehaviour_Ragdoll : BmSDK.BmGame.RBMBehaviour, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RBMBehaviour_Ragdoll", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RBMBehaviour_Ragdoll() { }

    /// <summary>
    /// Constructs a new RBMBehaviour_Ragdoll
    /// </summary>
    public RBMBehaviour_Ragdoll(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RBMBehaviour_Ragdoll Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RBMBehaviour_Ragdoll(nint ptr) : base(ptr) { }

    /// <summary>
    /// FloatProperty: DieByFallingTimer
    /// </summary>
    public unsafe float DieByFallingTimer
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 588); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 588); }
    }

    /// <summary>
    /// FloatProperty: GetupTimer
    /// </summary>
    public unsafe float GetupTimer
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 592); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 592); }
    }

    /// <summary>
    /// BoolProperty: bKillWhenFinished
    /// </summary>
    public unsafe bool bKillWhenFinished
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 596) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 596); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 596); }
    }

    /// <summary>
    /// BoolProperty: bKeepRagdoll
    /// </summary>
    public unsafe bool bKeepRagdoll
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 596) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 596); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 596); }
    }

    /// <summary>
    /// BoolProperty: bStartedGetUp
    /// </summary>
    public unsafe bool bStartedGetUp
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 596) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 596); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 596); }
    }

    /// <summary>
    /// BoolProperty: bFinishedGetUp
    /// </summary>
    public unsafe bool bFinishedGetUp
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 596) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 596); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 596); }
    }

    /// <summary>
    /// BoolProperty: bDontDisableRagdoll
    /// </summary>
    public unsafe bool bDontDisableRagdoll
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 596) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 596); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 596); }
    }

    /// <summary>
    /// BoolProperty: bHitWall
    /// </summary>
    public unsafe bool bHitWall
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 596) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 596); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 596); }
    }

    /// <summary>
    /// BoolProperty: bDontPerformGetUp
    /// </summary>
    public unsafe bool bDontPerformGetUp
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 596) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 596); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 596); }
    }

    /// <summary>
    /// BoolProperty: bStunnedFXOn
    /// </summary>
    public unsafe bool bStunnedFXOn
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 596) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 596); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 596); }
    }

    /// <summary>
    /// BoolProperty: bBatmanEscapedSinceStunStarted
    /// </summary>
    public unsafe bool bBatmanEscapedSinceStunStarted
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 596) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 596); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 596); }
    }

    /// <summary>
    /// BoolProperty: bFrozen
    /// </summary>
    public unsafe bool bFrozen
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 596) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 596); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 596); }
    }

    /// <summary>
    /// BoolProperty: bGoneRagdoll
    /// </summary>
    public unsafe bool bGoneRagdoll
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 596) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 596); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 596); }
    }

    /// <summary>
    /// BoolProperty: JustClimbedLadder
    /// </summary>
    public unsafe bool JustClimbedLadder
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 596) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 596); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 596); }
    }

    /// <summary>
    /// BoolProperty: bCheckedForThugHelper
    /// </summary>
    public unsafe bool bCheckedForThugHelper
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 596) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 596); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 596); }
    }

    /// <summary>
    /// BoolProperty: bPreviousRobotCanBeTakenDown
    /// </summary>
    public unsafe bool bPreviousRobotCanBeTakenDown
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 596) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 596); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 596); }
    }

    /// <summary>
    /// ByteProperty: StunType
    /// </summary>
    public unsafe byte StunType
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 600); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 600); }
    }

    /// <summary>
    /// NameProperty: GetUpMovementStance
    /// </summary>
    public unsafe BmSDK.FName GetUpMovementStance
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 604); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 604); }
    }

    /// <summary>
    /// NameProperty: GetupWeaponStance
    /// </summary>
    public unsafe BmSDK.FName GetupWeaponStance
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 612); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 612); }
    }

    /// <summary>
    /// StructProperty: WritheDmgInfo
    /// </summary>
    public unsafe BmSDK.Engine.SeqAct_Latent.LatentActors WritheDmgInfo
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.SeqAct_Latent.LatentActors>(Ptr + 620); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 620); }
    }

    /// <summary>
    /// FloatProperty: ARFMulti
    /// </summary>
    public unsafe float ARFMulti
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 868); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 868); }
    }

    /// <summary>
    /// FloatProperty: ParticleAlpha
    /// </summary>
    public unsafe float ParticleAlpha
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 872); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 872); }
    }

    /// <summary>
    /// ComponentProperty: StunnedFX
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT StunnedFX
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 876); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 876); }
    }

    /// <summary>
    /// IntProperty: ActivateStunnedFXFrames
    /// </summary>
    public unsafe int ActivateStunnedFXFrames
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 884); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 884); }
    }

    /// <summary>
    /// ObjectProperty: ThugHelper
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT ThugHelper
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 888); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 888); }
    }

    /// <summary>
    /// FloatProperty: RetryCallForHelpTime
    /// </summary>
    public unsafe float RetryCallForHelpTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 896); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 896); }
    }
}
