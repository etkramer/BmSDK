#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RSeqAct_SmashablePropChange<br/>
/// (flags = 0)
/// </summary>
public partial class RSeqAct_SmashablePropChange : BmSDK.Engine.SequenceAction, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RSeqAct_SmashablePropChange", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RSeqAct_SmashablePropChange() { }

    /// <summary>
    /// Constructs a new RSeqAct_SmashablePropChange
    /// </summary>
    public RSeqAct_SmashablePropChange(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RSeqAct_SmashablePropChange Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RSeqAct_SmashablePropChange(nint ptr) : base(ptr) { }

    /// <summary>
    /// ByteProperty: PropChangeType
    /// </summary>
    public unsafe BmSDK.BmGame.RSeqAct_SmashablePropChange.ESmashablePropChangeType PropChangeType
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSeqAct_SmashablePropChange.ESmashablePropChangeType>(Ptr + 352); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 352); }
    }

    /// <summary>
    /// ByteProperty: NewBreakableType
    /// </summary>
    public unsafe BmSDK.BmGame.RSmashablePropConfig.EBreakableType NewBreakableType
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSmashablePropConfig.EBreakableType>(Ptr + 353); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 353); }
    }

    /// <summary>
    /// BoolProperty: NewBoolValue
    /// </summary>
    public unsafe bool NewBoolValue
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 356) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 356); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 356); }
    }

    /// <summary>
    /// FloatProperty: NewFloatValue
    /// </summary>
    public unsafe float NewFloatValue
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 360); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 360); }
    }

    /// <summary>
    /// Enum: ESmashablePropChangeType
    /// </summary>
    public enum ESmashablePropChangeType
    {
        SMASHABLEPROPCHANGE_TriggerBreakProp = 0,
        SMASHABLEPROPCHANGE_TurnStaticOnStationary = 1,
        SMASHABLEPROPCHANGE_IgnorePawnCollisions = 2,
        SMASHABLEPROPCHANGE_BreakableType = 3,
        SMASHABLEPROPCHANGE_MAX = 4,
    }
}
