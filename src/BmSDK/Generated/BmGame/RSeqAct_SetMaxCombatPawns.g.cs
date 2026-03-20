#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RSeqAct_SetMaxCombatPawns<br/>
/// (flags = 0)
/// </summary>
public partial class RSeqAct_SetMaxCombatPawns : BmSDK.Engine.SequenceAction, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RSeqAct_SetMaxCombatPawns", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RSeqAct_SetMaxCombatPawns() { }

    /// <summary>
    /// Constructs a new RSeqAct_SetMaxCombatPawns
    /// </summary>
    public RSeqAct_SetMaxCombatPawns(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RSeqAct_SetMaxCombatPawns Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RSeqAct_SetMaxCombatPawns(nint ptr) : base(ptr) { }

    /// <summary>
    /// IntProperty: MaxCombatPawns
    /// </summary>
    public unsafe int MaxCombatPawns
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 352); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 352); }
    }
}
