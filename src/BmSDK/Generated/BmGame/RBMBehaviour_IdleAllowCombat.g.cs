#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RBMBehaviour_IdleAllowCombat<br/>
/// (size = 0)
/// (flags = 0)
/// </summary>
public partial class RBMBehaviour_IdleAllowCombat : BmSDK.BmGame.RBMBehaviour_Idle, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RBMBehaviour_IdleAllowCombat", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RBMBehaviour_IdleAllowCombat() { }

    /// <summary>
    /// Constructs a new RBMBehaviour_IdleAllowCombat
    /// </summary>
    public RBMBehaviour_IdleAllowCombat(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RBMBehaviour_IdleAllowCombat Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RBMBehaviour_IdleAllowCombat(nint ptr) : base(ptr) { }

    /// <summary>
    /// FloatProperty: WaitTime
    /// </summary>
    public unsafe float WaitTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 588); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 588); }
    }

    /// <summary>
    /// FloatProperty: IdleTimer
    /// </summary>
    public unsafe float IdleTimer
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 592); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 592); }
    }

    /// <summary>
    /// ObjectProperty: FaceAtTarget
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT FaceAtTarget
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 596); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 596); }
    }

    /// <summary>
    /// BoolProperty: bLookAtPlayer
    /// </summary>
    public unsafe bool bLookAtPlayer
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 604) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 604); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 604); }
    }

    /// <summary>
    /// BoolProperty: bIgnoreLookAtPlayerOverride
    /// </summary>
    public unsafe bool bIgnoreLookAtPlayerOverride
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 604) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 604); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 604); }
    }

    /// <summary>
    /// BoolProperty: bStartCombatOnLOS
    /// </summary>
    public unsafe bool bStartCombatOnLOS
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 604) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 604); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 604); }
    }

    /// <summary>
    /// BoolProperty: bCombatTriggered
    /// </summary>
    public unsafe bool bCombatTriggered
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 604) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 604); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 604); }
    }

    /// <summary>
    /// ByteProperty: Pose
    /// </summary>
    public unsafe byte Pose
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 608); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 608); }
    }

    /// <summary>
    /// ByteProperty: Pose_Mirroring
    /// </summary>
    public unsafe byte Pose_Mirroring
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 609); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 609); }
    }

    /// <summary>
    /// NameProperty: Pose_CustomMovement
    /// </summary>
    public unsafe BmSDK.FName Pose_CustomMovement
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 612); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 612); }
    }

    /// <summary>
    /// NameProperty: Pose_CustomWeapon
    /// </summary>
    public unsafe BmSDK.FName Pose_CustomWeapon
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 620); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 620); }
    }
}
