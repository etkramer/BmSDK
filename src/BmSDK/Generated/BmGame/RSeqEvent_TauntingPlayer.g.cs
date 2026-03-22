#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RSeqEvent_TauntingPlayer<br/>
/// (size = 228)
/// (flags = 18)
/// </summary>
public partial class RSeqEvent_TauntingPlayer : BmSDK.Engine.SequenceEvent, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RSeqEvent_TauntingPlayer", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RSeqEvent_TauntingPlayer() { }

    /// <summary>
    /// Constructs a new RSeqEvent_TauntingPlayer
    /// </summary>
    public RSeqEvent_TauntingPlayer(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RSeqEvent_TauntingPlayer Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RSeqEvent_TauntingPlayer(nint ptr) : base(ptr) { }

}
