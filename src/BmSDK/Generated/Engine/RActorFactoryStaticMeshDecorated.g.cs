#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Class: RActorFactoryStaticMeshDecorated<br/>
/// (size = 164)
/// (flags = 0)
/// </summary>
public partial class RActorFactoryStaticMeshDecorated : BmSDK.Engine.ActorFactoryStaticMesh, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Engine.RActorFactoryStaticMeshDecorated", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RActorFactoryStaticMeshDecorated() { }

    /// <summary>
    /// Constructs a new RActorFactoryStaticMeshDecorated
    /// </summary>
    public RActorFactoryStaticMeshDecorated(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RActorFactoryStaticMeshDecorated Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RActorFactoryStaticMeshDecorated(nint ptr) : base(ptr) { }

}
