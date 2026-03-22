#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmScript;

/// <summary>
/// Class: RSeqEvent_SnapFlashDetonated<br/>
/// (size = 228)
/// (flags = 18)
/// </summary>
public partial class RSeqEvent_SnapFlashDetonated : BmSDK.Engine.SequenceEvent, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmScript.RSeqEvent_SnapFlashDetonated", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RSeqEvent_SnapFlashDetonated() { }

    /// <summary>
    /// Constructs a new RSeqEvent_SnapFlashDetonated
    /// </summary>
    public RSeqEvent_SnapFlashDetonated(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RSeqEvent_SnapFlashDetonated Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RSeqEvent_SnapFlashDetonated(nint ptr) : base(ptr) { }

}
