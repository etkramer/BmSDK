#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RCombatEvent_HeavyStrikeHit<br/>
/// (flags = 0)
/// </summary>
public partial class RCombatEvent_HeavyStrikeHit : BmSDK.BmGame.RCombatEvent, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RCombatEvent_HeavyStrikeHit", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RCombatEvent_HeavyStrikeHit() { }

    /// <summary>
    /// Constructs a new RCombatEvent_HeavyStrikeHit
    /// </summary>
    public RCombatEvent_HeavyStrikeHit(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RCombatEvent_HeavyStrikeHit Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RCombatEvent_HeavyStrikeHit(nint ptr) : base(ptr) { }

}
