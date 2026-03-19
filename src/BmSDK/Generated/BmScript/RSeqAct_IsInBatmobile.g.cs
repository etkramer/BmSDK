#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmScript;

/// <summary>
/// Class: RSeqAct_IsInBatmobile<br/>
/// (size = 0)
/// (flags = 0)
/// </summary>
public partial class RSeqAct_IsInBatmobile : BmSDK.Engine.SequenceAction, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmScript.RSeqAct_IsInBatmobile", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RSeqAct_IsInBatmobile() { }

    /// <summary>
    /// Constructs a new RSeqAct_IsInBatmobile
    /// </summary>
    public RSeqAct_IsInBatmobile(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RSeqAct_IsInBatmobile Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RSeqAct_IsInBatmobile(nint ptr) : base(ptr) { }

    /// <summary>
    /// ObjectProperty: TargetPlayer
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT TargetPlayer
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 352); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 352); }
    }

    /// <summary>
    /// ByteProperty: WhichMode
    /// </summary>
    public unsafe byte WhichMode
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 360); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 360); }
    }

    /// <summary>
    /// BoolProperty: bMustHaveFinishedGetInAnim
    /// </summary>
    public unsafe bool bMustHaveFinishedGetInAnim
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 364) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 364); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 364); }
    }
}
