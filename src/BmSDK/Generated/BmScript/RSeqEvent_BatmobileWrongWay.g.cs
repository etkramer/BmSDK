#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmScript;

/// <summary>
/// Class: RSeqEvent_BatmobileWrongWay<br/>
/// (size = 380)
/// (flags = 18)
/// </summary>
public partial class RSeqEvent_BatmobileWrongWay : BmSDK.Engine.SequenceEvent, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmScript.RSeqEvent_BatmobileWrongWay", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RSeqEvent_BatmobileWrongWay() { }

    /// <summary>
    /// Constructs a new RSeqEvent_BatmobileWrongWay
    /// </summary>
    public RSeqEvent_BatmobileWrongWay(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RSeqEvent_BatmobileWrongWay Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RSeqEvent_BatmobileWrongWay(nint ptr) : base(ptr) { }

}
