#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RCombatEvent_CounterHit<br/>
/// (size = 228)
/// (flags = 18)
/// </summary>
public partial class RCombatEvent_CounterHit : BmSDK.BmGame.RCombatEvent, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RCombatEvent_CounterHit", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RCombatEvent_CounterHit() { }

    /// <summary>
    /// Constructs a new RCombatEvent_CounterHit
    /// </summary>
    public RCombatEvent_CounterHit(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RCombatEvent_CounterHit Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RCombatEvent_CounterHit(nint ptr) : base(ptr) { }

}
