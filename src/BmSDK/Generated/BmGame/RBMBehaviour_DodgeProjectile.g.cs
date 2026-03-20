#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RBMBehaviour_DodgeProjectile<br/>
/// (flags = 0)
/// </summary>
public partial class RBMBehaviour_DodgeProjectile : BmSDK.BmGame.RBMBehaviour, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RBMBehaviour_DodgeProjectile", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RBMBehaviour_DodgeProjectile() { }

    /// <summary>
    /// Constructs a new RBMBehaviour_DodgeProjectile
    /// </summary>
    public RBMBehaviour_DodgeProjectile(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RBMBehaviour_DodgeProjectile Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RBMBehaviour_DodgeProjectile(nint ptr) : base(ptr) { }

    /// <summary>
    /// ObjectProperty: Thrower
    /// </summary>
    public unsafe BmSDK.BmGame.RPawn Thrower
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPawn>(Ptr + 588); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 588); }
    }

    /// <summary>
    /// StructProperty: DodgeID
    /// </summary>
    public unsafe BmSDK.BmGame.RAnimUtil_PosePlayer.FTransitionId DodgeID
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RAnimUtil_PosePlayer.FTransitionId>(Ptr + 596); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 596); }
    }

    /// <summary>
    /// NameProperty: TargetBone
    /// </summary>
    public unsafe BmSDK.FName TargetBone
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 600); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 600); }
    }

    /// <summary>
    /// FloatProperty: CanRedodgeTimer
    /// </summary>
    public unsafe float CanRedodgeTimer
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 608); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 608); }
    }

    /// <summary>
    /// IntProperty: BatarangID
    /// </summary>
    public unsafe int BatarangID
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 612); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 612); }
    }

    /// <summary>
    /// FloatProperty: WaitTime
    /// </summary>
    public unsafe float WaitTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 616); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 616); }
    }

    /// <summary>
    /// BoolProperty: bPredAttackOnFinish
    /// </summary>
    public unsafe bool bPredAttackOnFinish
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 620) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 620); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 620); }
    }

    /// <summary>
    /// BoolProperty: bCanDodgeAgain
    /// </summary>
    public unsafe bool bCanDodgeAgain
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 620) & 2) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 620); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 620); }
    }

    /// <summary>
    /// BoolProperty: bAllowDodgeAgain
    /// </summary>
    public unsafe bool bAllowDodgeAgain
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 620) & 4) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 620); var newMask = value ? (currentMask | 4) : (currentMask & ~4); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 620); }
    }

    /// <summary>
    /// BoolProperty: bDodgeLineLauncher
    /// </summary>
    public unsafe bool bDodgeLineLauncher
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 620) & 8) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 620); var newMask = value ? (currentMask | 8) : (currentMask & ~8); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 620); }
    }

    /// <summary>
    /// BoolProperty: bDodgeAwayFromPosition
    /// </summary>
    public unsafe bool bDodgeAwayFromPosition
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 620) & 16) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 620); var newMask = value ? (currentMask | 16) : (currentMask & ~16); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 620); }
    }
}
