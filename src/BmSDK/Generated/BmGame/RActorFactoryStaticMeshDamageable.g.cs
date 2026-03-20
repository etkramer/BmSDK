#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RActorFactoryStaticMeshDamageable<br/>
/// (flags = 0)
/// </summary>
public partial class RActorFactoryStaticMeshDamageable : BmSDK.Engine.ActorFactoryStaticMesh, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RActorFactoryStaticMeshDamageable", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RActorFactoryStaticMeshDamageable() { }

    /// <summary>
    /// Constructs a new RActorFactoryStaticMeshDamageable
    /// </summary>
    public RActorFactoryStaticMeshDamageable(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RActorFactoryStaticMeshDamageable Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RActorFactoryStaticMeshDamageable(nint ptr) : base(ptr) { }

}
