#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RSeqAct_TriggerOnce<br/>
/// (size = 0)
/// (flags = 0)
/// </summary>
public partial class RSeqAct_TriggerOnce : BmSDK.Engine.SequenceAction, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RSeqAct_TriggerOnce", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RSeqAct_TriggerOnce() { }

    /// <summary>
    /// Constructs a new RSeqAct_TriggerOnce
    /// </summary>
    public RSeqAct_TriggerOnce(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RSeqAct_TriggerOnce Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RSeqAct_TriggerOnce(nint ptr) : base(ptr) { }

    /// <summary>
    /// BoolProperty: bTriggered
    /// </summary>
    public unsafe bool bTriggered
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 352) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 352); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 352); }
    }

    /// <summary>
    /// BoolProperty: bSaved
    /// </summary>
    public unsafe bool bSaved
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 352) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 352); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 352); }
    }
}
