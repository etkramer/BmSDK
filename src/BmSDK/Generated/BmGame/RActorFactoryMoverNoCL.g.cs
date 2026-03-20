#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RActorFactoryMoverNoCL<br/>
/// (size = 172)
/// (flags = 0)
/// </summary>
public partial class RActorFactoryMoverNoCL : BmSDK.Engine.ActorFactoryMover, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RActorFactoryMoverNoCL", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RActorFactoryMoverNoCL() { }

    /// <summary>
    /// Constructs a new RActorFactoryMoverNoCL
    /// </summary>
    public RActorFactoryMoverNoCL(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RActorFactoryMoverNoCL Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RActorFactoryMoverNoCL(nint ptr) : base(ptr) { }

}
