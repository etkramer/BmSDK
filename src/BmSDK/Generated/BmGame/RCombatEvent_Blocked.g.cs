#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RCombatEvent_Blocked<br/>
/// (flags = 0)
/// </summary>
public partial class RCombatEvent_Blocked : BmSDK.BmGame.RCombatEvent, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RCombatEvent_Blocked", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RCombatEvent_Blocked() { }

    /// <summary>
    /// Constructs a new RCombatEvent_Blocked
    /// </summary>
    public RCombatEvent_Blocked(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RCombatEvent_Blocked Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RCombatEvent_Blocked(nint ptr) : base(ptr) { }

}
