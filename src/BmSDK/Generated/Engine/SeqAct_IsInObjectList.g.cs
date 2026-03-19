#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Class: SeqAct_IsInObjectList<br/>
/// (size = 0)
/// (flags = 0)
/// </summary>
public partial class SeqAct_IsInObjectList : BmSDK.Engine.SequenceAction, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Engine.SeqAct_IsInObjectList", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal SeqAct_IsInObjectList() { }

    /// <summary>
    /// Constructs a new SeqAct_IsInObjectList
    /// </summary>
    public SeqAct_IsInObjectList(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, SeqAct_IsInObjectList Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected SeqAct_IsInObjectList(nint ptr) : base(ptr) { }

    /// <summary>
    /// BoolProperty: bCheckForAllObjects
    /// </summary>
    public unsafe bool bCheckForAllObjects
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 352) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 352); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 352); }
    }

    /// <summary>
    /// BoolProperty: bObjectFound
    /// </summary>
    public unsafe bool bObjectFound
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 352) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 352); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 352); }
    }
}
