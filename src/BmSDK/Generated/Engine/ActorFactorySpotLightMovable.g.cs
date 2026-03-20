#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Class: ActorFactorySpotLightMovable<br/>
/// (size = 0)
/// (flags = 0)
/// </summary>
public partial class ActorFactorySpotLightMovable : BmSDK.Engine.ActorFactorySpotLight, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Engine.ActorFactorySpotLightMovable", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal ActorFactorySpotLightMovable() { }

    /// <summary>
    /// Constructs a new ActorFactorySpotLightMovable
    /// </summary>
    public ActorFactorySpotLightMovable(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, ActorFactorySpotLightMovable Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected ActorFactorySpotLightMovable(nint ptr) : base(ptr) { }

    /// <summary>
    /// ComponentProperty: LightComponent
    /// </summary>
    public unsafe BmSDK.Engine.SpotLightComponent LightComponent
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.SpotLightComponent>(Ptr + 144); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 144); }
    }
}
