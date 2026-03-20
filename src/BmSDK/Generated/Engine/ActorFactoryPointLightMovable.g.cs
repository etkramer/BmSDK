#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Class: ActorFactoryPointLightMovable<br/>
/// (flags = 0)
/// </summary>
public partial class ActorFactoryPointLightMovable : BmSDK.Engine.ActorFactoryLight, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Engine.ActorFactoryPointLightMovable", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal ActorFactoryPointLightMovable() { }

    /// <summary>
    /// Constructs a new ActorFactoryPointLightMovable
    /// </summary>
    public ActorFactoryPointLightMovable(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, ActorFactoryPointLightMovable Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected ActorFactoryPointLightMovable(nint ptr) : base(ptr) { }

}
