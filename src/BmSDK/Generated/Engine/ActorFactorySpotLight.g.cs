#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Class: ActorFactorySpotLight<br/>
/// (size = 96)
/// (flags = 142618774)
/// </summary>
public partial class ActorFactorySpotLight : BmSDK.Engine.ActorFactory, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Engine.ActorFactorySpotLight", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal ActorFactorySpotLight() { }

    /// <summary>
    /// Constructs a new ActorFactorySpotLight
    /// </summary>
    public ActorFactorySpotLight(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, ActorFactorySpotLight Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected ActorFactorySpotLight(nint ptr) : base(ptr) { }

    /// <summary>
    /// ComponentProperty: LightComponent
    /// </summary>
    public unsafe BmSDK.Engine.SpotLightComponent LightComponent
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.SpotLightComponent>(Ptr + 92); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 92); }
    }
}
