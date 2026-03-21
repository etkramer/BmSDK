#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RSeqEvent_LeavingPersistentMap<br/>
/// (size = 228)
/// (flags = 18)
/// </summary>
public partial class RSeqEvent_LeavingPersistentMap : BmSDK.Engine.SequenceEvent, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RSeqEvent_LeavingPersistentMap", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RSeqEvent_LeavingPersistentMap() { }

    /// <summary>
    /// Constructs a new RSeqEvent_LeavingPersistentMap
    /// </summary>
    public RSeqEvent_LeavingPersistentMap(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RSeqEvent_LeavingPersistentMap Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RSeqEvent_LeavingPersistentMap(nint ptr) : base(ptr) { }

}
