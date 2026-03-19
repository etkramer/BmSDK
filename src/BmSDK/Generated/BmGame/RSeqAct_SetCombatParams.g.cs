#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RSeqAct_SetCombatParams<br/>
/// (size = 0)
/// (flags = 0)
/// </summary>
public partial class RSeqAct_SetCombatParams : BmSDK.Engine.SequenceAction, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RSeqAct_SetCombatParams", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RSeqAct_SetCombatParams() { }

    /// <summary>
    /// Constructs a new RSeqAct_SetCombatParams
    /// </summary>
    public RSeqAct_SetCombatParams(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RSeqAct_SetCombatParams Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RSeqAct_SetCombatParams(nint ptr) : base(ptr) { }

    /// <summary>
    /// BoolProperty: bEnableAllAttacksByDefault
    /// </summary>
    public unsafe bool bEnableAllAttacksByDefault
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 352) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 352); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 352); }
    }

    /// <summary>
    /// BoolProperty: bDisableNormalAttack
    /// </summary>
    public unsafe bool bDisableNormalAttack
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 352) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 352); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 352); }
    }

    /// <summary>
    /// BoolProperty: bDisableGrabAttack
    /// </summary>
    public unsafe bool bDisableGrabAttack
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 352) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 352); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 352); }
    }

    /// <summary>
    /// BoolProperty: bDisableChargeAttack
    /// </summary>
    public unsafe bool bDisableChargeAttack
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 352) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 352); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 352); }
    }

    /// <summary>
    /// BoolProperty: bDisableBeatdown
    /// </summary>
    public unsafe bool bDisableBeatdown
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 352) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 352); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 352); }
    }

    /// <summary>
    /// BoolProperty: bHeavyFloorStrike
    /// </summary>
    public unsafe bool bHeavyFloorStrike
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 352) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 352); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 352); }
    }

    /// <summary>
    /// BoolProperty: bDisableAdrenaline
    /// </summary>
    public unsafe bool bDisableAdrenaline
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 352) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 352); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 352); }
    }

    /// <summary>
    /// BoolProperty: bDisableCombatTakedownCheck
    /// </summary>
    public unsafe bool bDisableCombatTakedownCheck
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 352) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 352); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 352); }
    }

    /// <summary>
    /// BoolProperty: bDisableCombatExpertFuryAttack
    /// </summary>
    public unsafe bool bDisableCombatExpertFuryAttack
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 352) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 352); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 352); }
    }

    /// <summary>
    /// BoolProperty: bDisableMedicChargeUpThug
    /// </summary>
    public unsafe bool bDisableMedicChargeUpThug
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 352) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 352); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 352); }
    }

    /// <summary>
    /// BoolProperty: bDisableBotDialogue
    /// </summary>
    public unsafe bool bDisableBotDialogue
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 352) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 352); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 352); }
    }

    /// <summary>
    /// BoolProperty: bDisableMedicRevives
    /// </summary>
    public unsafe bool bDisableMedicRevives
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 352) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 352); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 352); }
    }

    /// <summary>
    /// BoolProperty: bDisableQuickGadgetPrompts
    /// </summary>
    public unsafe bool bDisableQuickGadgetPrompts
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 352) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 352); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 352); }
    }

    /// <summary>
    /// BoolProperty: bSeperatedDualplay
    /// </summary>
    public unsafe bool bSeperatedDualplay
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 352) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 352); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 352); }
    }

    /// <summary>
    /// ByteProperty: MaxSCounterSize
    /// </summary>
    public unsafe byte MaxSCounterSize
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 356); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 356); }
    }

    /// <summary>
    /// Enum: MaxSimultaneousCounterSize
    /// </summary>
    public enum MaxSimultaneousCounterSize
    {
        MSCS_Default = 0,
        MSCS_2Thugs = 1,
        MSCS_3Thugs = 2,
        MSCS_Off = 3,
        MSCS_MAX = 4,
    }
}
