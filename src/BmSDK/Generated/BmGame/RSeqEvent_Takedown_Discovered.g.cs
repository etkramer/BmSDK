#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RSeqEvent_Takedown_Discovered<br/>
/// (flags = 0)
/// </summary>
public partial class RSeqEvent_Takedown_Discovered : BmSDK.Engine.SequenceEvent, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RSeqEvent_Takedown_Discovered", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RSeqEvent_Takedown_Discovered() { }

    /// <summary>
    /// Constructs a new RSeqEvent_Takedown_Discovered
    /// </summary>
    public RSeqEvent_Takedown_Discovered(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RSeqEvent_Takedown_Discovered Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RSeqEvent_Takedown_Discovered(nint ptr) : base(ptr) { }

}
