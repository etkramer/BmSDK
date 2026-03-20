#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RCheapLightComponent<br/>
/// (size = 248)
/// (flags = 176173202)
/// </summary>
public partial class RCheapLightComponent : BmSDK.Engine.FogVolumeSphericalDensityComponent, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RCheapLightComponent", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RCheapLightComponent() { }

    /// <summary>
    /// Constructs a new RCheapLightComponent
    /// </summary>
    public RCheapLightComponent(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RCheapLightComponent Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RCheapLightComponent(nint ptr) : base(ptr) { }

    /// <summary>
    /// ComponentProperty: AutomaticMeshComponent
    /// </summary>
    public unsafe BmSDK.Engine.StaticMeshComponent AutomaticMeshComponent
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.StaticMeshComponent>(Ptr + 240); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 240); }
    }
}
