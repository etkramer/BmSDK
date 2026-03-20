#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Class: UmbraStreamingVolumeRenderingComponent<br/>
/// (size = 540)
/// (flags = 2290094290)
/// </summary>
public partial class UmbraStreamingVolumeRenderingComponent : BmSDK.Engine.PrimitiveComponent, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Engine.UmbraStreamingVolumeRenderingComponent", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal UmbraStreamingVolumeRenderingComponent() { }

    /// <summary>
    /// Constructs a new UmbraStreamingVolumeRenderingComponent
    /// </summary>
    public UmbraStreamingVolumeRenderingComponent(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, UmbraStreamingVolumeRenderingComponent Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected UmbraStreamingVolumeRenderingComponent(nint ptr) : base(ptr) { }

}
