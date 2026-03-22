#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmScript;

/// <summary>
/// Class: RSpecialMoveConfig_PDLCLedgeCounter<br/>
/// (size = 348)
/// (flags = 4114)
/// </summary>
public partial class RSpecialMoveConfig_PDLCLedgeCounter : BmSDK.BmGame.RSpecialMoveConfig_RelativeAnimMove, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmScript.RSpecialMoveConfig_PDLCLedgeCounter", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RSpecialMoveConfig_PDLCLedgeCounter() { }

    /// <summary>
    /// Constructs a new RSpecialMoveConfig_PDLCLedgeCounter
    /// </summary>
    public RSpecialMoveConfig_PDLCLedgeCounter(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RSpecialMoveConfig_PDLCLedgeCounter Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RSpecialMoveConfig_PDLCLedgeCounter(nint ptr) : base(ptr) { }

}
