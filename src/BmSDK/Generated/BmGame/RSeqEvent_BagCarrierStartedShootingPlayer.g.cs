#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RSeqEvent_BagCarrierStartedShootingPlayer<br/>
/// (flags = 0)
/// </summary>
public partial class RSeqEvent_BagCarrierStartedShootingPlayer : BmSDK.Engine.SequenceEvent, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RSeqEvent_BagCarrierStartedShootingPlayer", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RSeqEvent_BagCarrierStartedShootingPlayer() { }

    /// <summary>
    /// Constructs a new RSeqEvent_BagCarrierStartedShootingPlayer
    /// </summary>
    public RSeqEvent_BagCarrierStartedShootingPlayer(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RSeqEvent_BagCarrierStartedShootingPlayer Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RSeqEvent_BagCarrierStartedShootingPlayer(nint ptr) : base(ptr) { }

}
