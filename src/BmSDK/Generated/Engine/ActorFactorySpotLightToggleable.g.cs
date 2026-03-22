#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Class: ActorFactorySpotLightToggleable<br/>
/// (size = 96)
/// (flags = 8400918)
/// </summary>
public partial class ActorFactorySpotLightToggleable : BmSDK.Engine.ActorFactorySpotLight, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Engine.ActorFactorySpotLightToggleable", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal ActorFactorySpotLightToggleable() { }

    /// <summary>
    /// Constructs a new ActorFactorySpotLightToggleable
    /// </summary>
    public ActorFactorySpotLightToggleable(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, ActorFactorySpotLightToggleable Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected ActorFactorySpotLightToggleable(nint ptr) : base(ptr) { }

}
