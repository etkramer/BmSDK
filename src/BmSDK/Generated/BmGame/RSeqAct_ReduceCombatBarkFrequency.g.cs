#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RSeqAct_ReduceCombatBarkFrequency<br/>
/// (size = 0)
/// (flags = 0)
/// </summary>
public partial class RSeqAct_ReduceCombatBarkFrequency : BmSDK.Engine.SequenceAction, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RSeqAct_ReduceCombatBarkFrequency", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RSeqAct_ReduceCombatBarkFrequency() { }

    /// <summary>
    /// Constructs a new RSeqAct_ReduceCombatBarkFrequency
    /// </summary>
    public RSeqAct_ReduceCombatBarkFrequency(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RSeqAct_ReduceCombatBarkFrequency Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RSeqAct_ReduceCombatBarkFrequency(nint ptr) : base(ptr) { }

    /// <summary>
    /// FloatProperty: TimeBetweenBarkMultiplier
    /// </summary>
    public unsafe float TimeBetweenBarkMultiplier
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 352); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 352); }
    }
}
