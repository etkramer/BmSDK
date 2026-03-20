#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Class: RAsyncPhysXSceneInterface<br/>
/// (flags = 0)
/// </summary>
public partial class RAsyncPhysXSceneInterface : BmSDK.Interface, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Engine.RAsyncPhysXSceneInterface", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RAsyncPhysXSceneInterface() { }

    /// <summary>
    /// Constructs a new RAsyncPhysXSceneInterface
    /// </summary>
    public RAsyncPhysXSceneInterface(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RAsyncPhysXSceneInterface Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RAsyncPhysXSceneInterface(nint ptr) : base(ptr) { }

}
