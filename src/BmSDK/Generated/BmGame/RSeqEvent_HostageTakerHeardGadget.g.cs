#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RSeqEvent_HostageTakerHeardGadget<br/>
/// (size = 380)
/// (flags = 18)
/// </summary>
public partial class RSeqEvent_HostageTakerHeardGadget : BmSDK.Engine.SequenceEvent, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RSeqEvent_HostageTakerHeardGadget", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RSeqEvent_HostageTakerHeardGadget() { }

    /// <summary>
    /// Constructs a new RSeqEvent_HostageTakerHeardGadget
    /// </summary>
    public RSeqEvent_HostageTakerHeardGadget(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RSeqEvent_HostageTakerHeardGadget Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RSeqEvent_HostageTakerHeardGadget(nint ptr) : base(ptr) { }

}
