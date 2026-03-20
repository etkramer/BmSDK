#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RSeqEvent_GunJammedDiscovery<br/>
/// (size = 380)
/// (flags = 18)
/// </summary>
public partial class RSeqEvent_GunJammedDiscovery : BmSDK.Engine.SequenceEvent, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RSeqEvent_GunJammedDiscovery", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RSeqEvent_GunJammedDiscovery() { }

    /// <summary>
    /// Constructs a new RSeqEvent_GunJammedDiscovery
    /// </summary>
    public RSeqEvent_GunJammedDiscovery(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RSeqEvent_GunJammedDiscovery Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RSeqEvent_GunJammedDiscovery(nint ptr) : base(ptr) { }

}
