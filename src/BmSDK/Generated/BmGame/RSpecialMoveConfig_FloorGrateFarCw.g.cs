#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RSpecialMoveConfig_FloorGrateFarCw<br/>
/// (flags = 0)
/// </summary>
public partial class RSpecialMoveConfig_FloorGrateFarCw : BmSDK.BmGame.RSpecialMoveConfig_FloorGrateFar, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RSpecialMoveConfig_FloorGrateFarCw", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RSpecialMoveConfig_FloorGrateFarCw() { }

    /// <summary>
    /// Constructs a new RSpecialMoveConfig_FloorGrateFarCw
    /// </summary>
    public RSpecialMoveConfig_FloorGrateFarCw(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RSpecialMoveConfig_FloorGrateFarCw Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RSpecialMoveConfig_FloorGrateFarCw(nint ptr) : base(ptr) { }

}
