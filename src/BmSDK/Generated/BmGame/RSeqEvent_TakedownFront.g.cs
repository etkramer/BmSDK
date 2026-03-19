#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RSeqEvent_TakedownFront<br/>
/// (size = 0)
/// (flags = 0)
/// </summary>
public partial class RSeqEvent_TakedownFront : BmSDK.BmGame.RSeqEvent_TakedownBase, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RSeqEvent_TakedownFront", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RSeqEvent_TakedownFront() { }

    /// <summary>
    /// Constructs a new RSeqEvent_TakedownFront
    /// </summary>
    public RSeqEvent_TakedownFront(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RSeqEvent_TakedownFront Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RSeqEvent_TakedownFront(nint ptr) : base(ptr) { }

    /// <summary>
    /// ObjectProperty: vic0
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT vic0
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 380); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 380); }
    }

    /// <summary>
    /// ObjectProperty: vic1
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT vic1
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 388); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 388); }
    }
}
