#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RSeqAct_CheckPredatorAttackState<br/>
/// (size = 0)
/// (flags = 0)
/// </summary>
public partial class RSeqAct_CheckPredatorAttackState : BmSDK.Engine.SequenceAction, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RSeqAct_CheckPredatorAttackState", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RSeqAct_CheckPredatorAttackState() { }

    /// <summary>
    /// Constructs a new RSeqAct_CheckPredatorAttackState
    /// </summary>
    public RSeqAct_CheckPredatorAttackState(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RSeqAct_CheckPredatorAttackState Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RSeqAct_CheckPredatorAttackState(nint ptr) : base(ptr) { }

    /// <summary>
    /// BoolProperty: bOnlyCheckCurrentPlayer
    /// </summary>
    public unsafe bool bOnlyCheckCurrentPlayer
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 352) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 352); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 352); }
    }
}
