#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RSeqEvent_TriedGrappleToVantageWithVillainOn<br/>
/// (flags = 0)
/// </summary>
public partial class RSeqEvent_TriedGrappleToVantageWithVillainOn : BmSDK.Engine.SequenceEvent, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RSeqEvent_TriedGrappleToVantageWithVillainOn", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RSeqEvent_TriedGrappleToVantageWithVillainOn() { }

    /// <summary>
    /// Constructs a new RSeqEvent_TriedGrappleToVantageWithVillainOn
    /// </summary>
    public RSeqEvent_TriedGrappleToVantageWithVillainOn(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RSeqEvent_TriedGrappleToVantageWithVillainOn Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RSeqEvent_TriedGrappleToVantageWithVillainOn(nint ptr) : base(ptr) { }

}
