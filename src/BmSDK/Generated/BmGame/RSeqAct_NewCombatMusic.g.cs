#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RSeqAct_NewCombatMusic<br/>
/// (size = 376)
/// (flags = 0)
/// </summary>
public partial class RSeqAct_NewCombatMusic : BmSDK.Engine.SeqAct_Latent, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RSeqAct_NewCombatMusic", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RSeqAct_NewCombatMusic() { }

    /// <summary>
    /// Constructs a new RSeqAct_NewCombatMusic
    /// </summary>
    public RSeqAct_NewCombatMusic(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RSeqAct_NewCombatMusic Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RSeqAct_NewCombatMusic(nint ptr) : base(ptr) { }

}
