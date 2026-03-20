#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RCombatEvent_QuickStrikeHit<br/>
/// (size = 380)
/// (flags = 0)
/// </summary>
public partial class RCombatEvent_QuickStrikeHit : BmSDK.BmGame.RCombatEvent, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RCombatEvent_QuickStrikeHit", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RCombatEvent_QuickStrikeHit() { }

    /// <summary>
    /// Constructs a new RCombatEvent_QuickStrikeHit
    /// </summary>
    public RCombatEvent_QuickStrikeHit(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RCombatEvent_QuickStrikeHit Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RCombatEvent_QuickStrikeHit(nint ptr) : base(ptr) { }

}
