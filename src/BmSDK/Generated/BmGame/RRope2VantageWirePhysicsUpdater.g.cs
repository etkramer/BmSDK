#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RRope2VantageWirePhysicsUpdater<br/>
/// (size = 296)
/// (flags = 0)
/// </summary>
public partial class RRope2VantageWirePhysicsUpdater : BmSDK.BmGame.RRope2SimplePhysicsUpdater, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RRope2VantageWirePhysicsUpdater", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RRope2VantageWirePhysicsUpdater() { }

    /// <summary>
    /// Constructs a new RRope2VantageWirePhysicsUpdater
    /// </summary>
    public RRope2VantageWirePhysicsUpdater(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RRope2VantageWirePhysicsUpdater Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RRope2VantageWirePhysicsUpdater(nint ptr) : base(ptr) { }

}
