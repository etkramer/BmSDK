#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmScript;

/// <summary>
/// Class: RSeqAct_InfiniteCombatStats<br/>
/// (size = 232)
/// (flags = 8210)
/// </summary>
public partial class RSeqAct_InfiniteCombatStats : BmSDK.BmScript.RSeqAct_StartCombatChallengeStats, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmScript.RSeqAct_InfiniteCombatStats", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RSeqAct_InfiniteCombatStats() { }

    /// <summary>
    /// Constructs a new RSeqAct_InfiniteCombatStats
    /// </summary>
    public RSeqAct_InfiniteCombatStats(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RSeqAct_InfiniteCombatStats Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RSeqAct_InfiniteCombatStats(nint ptr) : base(ptr) { }

}
