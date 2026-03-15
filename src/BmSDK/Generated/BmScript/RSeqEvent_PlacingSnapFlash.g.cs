#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmScript;

/// <summary>
/// Class: RSeqEvent_PlacingSnapFlash<br/>
/// (size = 228)
/// (flags = 18)
/// </summary>
public partial class RSeqEvent_PlacingSnapFlash : BmSDK.Engine.SequenceEvent, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmScript.RSeqEvent_PlacingSnapFlash", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RSeqEvent_PlacingSnapFlash() { }

    /// <summary>
    /// Constructs a new RSeqEvent_PlacingSnapFlash
    /// </summary>
    public RSeqEvent_PlacingSnapFlash(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RSeqEvent_PlacingSnapFlash Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RSeqEvent_PlacingSnapFlash(nint ptr) : base(ptr) { }

}
