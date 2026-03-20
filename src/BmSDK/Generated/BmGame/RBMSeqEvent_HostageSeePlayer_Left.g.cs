#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RBMSeqEvent_HostageSeePlayer_Left<br/>
/// (flags = 0)
/// </summary>
public partial class RBMSeqEvent_HostageSeePlayer_Left : BmSDK.BmGame.RBMSeqEvent_BehaviourRoot, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RBMSeqEvent_HostageSeePlayer_Left", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RBMSeqEvent_HostageSeePlayer_Left() { }

    /// <summary>
    /// Constructs a new RBMSeqEvent_HostageSeePlayer_Left
    /// </summary>
    public RBMSeqEvent_HostageSeePlayer_Left(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RBMSeqEvent_HostageSeePlayer_Left Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RBMSeqEvent_HostageSeePlayer_Left(nint ptr) : base(ptr) { }

}
