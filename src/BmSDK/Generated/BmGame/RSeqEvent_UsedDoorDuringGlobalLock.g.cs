#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RSeqEvent_UsedDoorDuringGlobalLock<br/>
/// (size = 380)
/// (flags = 0)
/// </summary>
public partial class RSeqEvent_UsedDoorDuringGlobalLock : BmSDK.Engine.SequenceEvent, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RSeqEvent_UsedDoorDuringGlobalLock", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RSeqEvent_UsedDoorDuringGlobalLock() { }

    /// <summary>
    /// Constructs a new RSeqEvent_UsedDoorDuringGlobalLock
    /// </summary>
    public RSeqEvent_UsedDoorDuringGlobalLock(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RSeqEvent_UsedDoorDuringGlobalLock Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RSeqEvent_UsedDoorDuringGlobalLock(nint ptr) : base(ptr) { }

}
