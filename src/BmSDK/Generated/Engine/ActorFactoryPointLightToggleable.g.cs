#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Class: ActorFactoryPointLightToggleable<br/>
/// (flags = 0)
/// </summary>
public partial class ActorFactoryPointLightToggleable : BmSDK.Engine.ActorFactoryLight, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Engine.ActorFactoryPointLightToggleable", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal ActorFactoryPointLightToggleable() { }

    /// <summary>
    /// Constructs a new ActorFactoryPointLightToggleable
    /// </summary>
    public ActorFactoryPointLightToggleable(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, ActorFactoryPointLightToggleable Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected ActorFactoryPointLightToggleable(nint ptr) : base(ptr) { }

    /// <summary>
    /// ComponentProperty: LightComponent
    /// </summary>
    public unsafe BmSDK.Engine.PointLightComponent LightComponent
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.PointLightComponent>(Ptr + 144); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 144); }
    }
}
