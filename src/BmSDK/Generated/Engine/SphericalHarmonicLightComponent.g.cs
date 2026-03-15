#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Class: SphericalHarmonicLightComponent<br/>
/// (size = 564)
/// (flags = 144707730)
/// </summary>
public partial class SphericalHarmonicLightComponent : BmSDK.Engine.LightComponent, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Engine.SphericalHarmonicLightComponent", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal SphericalHarmonicLightComponent() { }

    /// <summary>
    /// Constructs a new SphericalHarmonicLightComponent
    /// </summary>
    public SphericalHarmonicLightComponent(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, SphericalHarmonicLightComponent Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected SphericalHarmonicLightComponent(nint ptr) : base(ptr) { }

    /// <summary>
    /// StructProperty: WorldSpaceIncidentLighting
    /// </summary>
    public unsafe BmSDK.GameObject.FSHVectorRGB WorldSpaceIncidentLighting
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.GameObject.FSHVectorRGB>(Ptr + 416); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 416); }
    }

    /// <summary>
    /// BoolProperty: bRenderBeforeModShadows
    /// </summary>
    public unsafe bool bRenderBeforeModShadows
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 560) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 560); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 560); }
    }
}
