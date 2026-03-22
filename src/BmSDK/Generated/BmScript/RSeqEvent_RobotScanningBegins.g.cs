#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmScript;

/// <summary>
/// Class: RSeqEvent_RobotScanningBegins<br/>
/// (size = 228)
/// (flags = 18)
/// </summary>
public partial class RSeqEvent_RobotScanningBegins : BmSDK.Engine.SequenceEvent, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmScript.RSeqEvent_RobotScanningBegins", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RSeqEvent_RobotScanningBegins() { }

    /// <summary>
    /// Constructs a new RSeqEvent_RobotScanningBegins
    /// </summary>
    public RSeqEvent_RobotScanningBegins(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RSeqEvent_RobotScanningBegins Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RSeqEvent_RobotScanningBegins(nint ptr) : base(ptr) { }

}
