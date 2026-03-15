#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmScript;

/// <summary>
/// Class: RSeqEvent_RobinHitBySteam<br/>
/// (size = 228)
/// (flags = 18)
/// </summary>
public partial class RSeqEvent_RobinHitBySteam : BmSDK.Engine.SequenceEvent, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmScript.RSeqEvent_RobinHitBySteam", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RSeqEvent_RobinHitBySteam() { }

    /// <summary>
    /// Constructs a new RSeqEvent_RobinHitBySteam
    /// </summary>
    public RSeqEvent_RobinHitBySteam(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RSeqEvent_RobinHitBySteam Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RSeqEvent_RobinHitBySteam(nint ptr) : base(ptr) { }

}
