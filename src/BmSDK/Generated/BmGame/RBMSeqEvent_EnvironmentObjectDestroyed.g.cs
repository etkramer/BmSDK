#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RBMSeqEvent_EnvironmentObjectDestroyed<br/>
/// (size = 380)
/// (flags = 18)
/// </summary>
public partial class RBMSeqEvent_EnvironmentObjectDestroyed : BmSDK.Engine.SequenceEvent, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RBMSeqEvent_EnvironmentObjectDestroyed", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RBMSeqEvent_EnvironmentObjectDestroyed() { }

    /// <summary>
    /// Constructs a new RBMSeqEvent_EnvironmentObjectDestroyed
    /// </summary>
    public RBMSeqEvent_EnvironmentObjectDestroyed(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RBMSeqEvent_EnvironmentObjectDestroyed Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RBMSeqEvent_EnvironmentObjectDestroyed(nint ptr) : base(ptr) { }

}
