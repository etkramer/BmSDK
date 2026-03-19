#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RBMSeqAct_AttachPawnToBehaviour<br/>
/// (size = 0)
/// (flags = 0)
/// </summary>
public partial class RBMSeqAct_AttachPawnToBehaviour : BmSDK.Engine.SequenceAction, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RBMSeqAct_AttachPawnToBehaviour", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RBMSeqAct_AttachPawnToBehaviour() { }

    /// <summary>
    /// Constructs a new RBMSeqAct_AttachPawnToBehaviour
    /// </summary>
    public RBMSeqAct_AttachPawnToBehaviour(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RBMSeqAct_AttachPawnToBehaviour Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RBMSeqAct_AttachPawnToBehaviour(nint ptr) : base(ptr) { }

    /// <summary>
    /// BoolProperty: bForce
    /// </summary>
    public unsafe bool bForce
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 352) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 352); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 352); }
    }

    /// <summary>
    /// BoolProperty: bDestroyIfRagdoll
    /// </summary>
    public unsafe bool bDestroyIfRagdoll
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 352) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 352); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 352); }
    }

    /// <summary>
    /// BoolProperty: bResetAnimPose
    /// </summary>
    public unsafe bool bResetAnimPose
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 352) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 352); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 352); }
    }
}
