#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Class: RDeferred_LightEffector<br/>
/// (size = 124)
/// (flags = 0)
/// </summary>
public partial class RDeferred_LightEffector : BmSDK.Engine.ActorComponent, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Engine.RDeferred_LightEffector", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RDeferred_LightEffector() { }

    /// <summary>
    /// Constructs a new RDeferred_LightEffector
    /// </summary>
    public RDeferred_LightEffector(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RDeferred_LightEffector Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RDeferred_LightEffector(nint ptr) : base(ptr) { }

}
