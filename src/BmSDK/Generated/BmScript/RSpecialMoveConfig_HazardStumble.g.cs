#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmScript;

/// <summary>
/// Class: RSpecialMoveConfig_HazardStumble<br/>
/// (size = 348)
/// (flags = 4114)
/// </summary>
public partial class RSpecialMoveConfig_HazardStumble : BmSDK.BmGame.RSpecialMoveConfig_RelativeAnimMove, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmScript.RSpecialMoveConfig_HazardStumble", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RSpecialMoveConfig_HazardStumble() { }

    /// <summary>
    /// Constructs a new RSpecialMoveConfig_HazardStumble
    /// </summary>
    public RSpecialMoveConfig_HazardStumble(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RSpecialMoveConfig_HazardStumble Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RSpecialMoveConfig_HazardStumble(nint ptr) : base(ptr) { }

}
