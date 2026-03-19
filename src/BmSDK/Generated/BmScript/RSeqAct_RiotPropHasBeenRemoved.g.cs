#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmScript;

/// <summary>
/// Class: RSeqAct_RiotPropHasBeenRemoved<br/>
/// (size = 0)
/// (flags = 0)
/// </summary>
public partial class RSeqAct_RiotPropHasBeenRemoved : BmSDK.Engine.SequenceAction, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmScript.RSeqAct_RiotPropHasBeenRemoved", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RSeqAct_RiotPropHasBeenRemoved() { }

    /// <summary>
    /// Constructs a new RSeqAct_RiotPropHasBeenRemoved
    /// </summary>
    public RSeqAct_RiotPropHasBeenRemoved(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RSeqAct_RiotPropHasBeenRemoved Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RSeqAct_RiotPropHasBeenRemoved(nint ptr) : base(ptr) { }

    /// <summary>
    /// ObjectProperty: Prop
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT Prop
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 352); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 352); }
    }
}
