#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmScript;

/// <summary>
/// Class: RSeqEvent_MinidroneAndThugInteractions<br/>
/// (flags = 0)
/// </summary>
public partial class RSeqEvent_MinidroneAndThugInteractions : BmSDK.Engine.SequenceEvent, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmScript.RSeqEvent_MinidroneAndThugInteractions", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RSeqEvent_MinidroneAndThugInteractions() { }

    /// <summary>
    /// Constructs a new RSeqEvent_MinidroneAndThugInteractions
    /// </summary>
    public RSeqEvent_MinidroneAndThugInteractions(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RSeqEvent_MinidroneAndThugInteractions Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RSeqEvent_MinidroneAndThugInteractions(nint ptr) : base(ptr) { }

    /// <summary>
    /// Enum: SACBCB_OUT_Links
    /// </summary>
    public enum SACBCB_OUT_Links
    {
        SEMDATI_OUT_CodesDownloaded = 0,
        SEMDATI_OUT_TargettedByMinidrone = 1,
        SEMDATI_OUT_MAX = 2,
    }
}
