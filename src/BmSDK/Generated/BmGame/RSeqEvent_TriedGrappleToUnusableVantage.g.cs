#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RSeqEvent_TriedGrappleToUnusableVantage<br/>
/// (size = 380)
/// (flags = 18)
/// </summary>
public partial class RSeqEvent_TriedGrappleToUnusableVantage : BmSDK.Engine.SequenceEvent, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RSeqEvent_TriedGrappleToUnusableVantage", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RSeqEvent_TriedGrappleToUnusableVantage() { }

    /// <summary>
    /// Constructs a new RSeqEvent_TriedGrappleToUnusableVantage
    /// </summary>
    public RSeqEvent_TriedGrappleToUnusableVantage(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RSeqEvent_TriedGrappleToUnusableVantage Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RSeqEvent_TriedGrappleToUnusableVantage(nint ptr) : base(ptr) { }

}
