#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Class: FogVolumeSphericalDensityComponent<br/>
/// (size = 0)
/// (flags = 0)
/// </summary>
public partial class FogVolumeSphericalDensityComponent : BmSDK.Engine.FogVolumeDensityComponent, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Engine.FogVolumeSphericalDensityComponent", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal FogVolumeSphericalDensityComponent() { }

    /// <summary>
    /// Constructs a new FogVolumeSphericalDensityComponent
    /// </summary>
    public FogVolumeSphericalDensityComponent(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, FogVolumeSphericalDensityComponent Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected FogVolumeSphericalDensityComponent(nint ptr) : base(ptr) { }

    /// <summary>
    /// FloatProperty: MaxDensity
    /// </summary>
    public unsafe float MaxDensity
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 200); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 200); }
    }

    /// <summary>
    /// BoolProperty: bFadeIn
    /// </summary>
    public unsafe bool bFadeIn
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 204) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 204); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 204); }
    }

    /// <summary>
    /// FloatProperty: fadeStart
    /// </summary>
    public unsafe float fadeStart
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 208); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 208); }
    }

    /// <summary>
    /// FloatProperty: fadeEnd
    /// </summary>
    public unsafe float fadeEnd
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 212); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 212); }
    }

    /// <summary>
    /// StructProperty: SphereCenter
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT SphereCenter
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 216); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 216); }
    }

    /// <summary>
    /// FloatProperty: SphereRadius
    /// </summary>
    public unsafe float SphereRadius
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 228); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 228); }
    }

    /// <summary>
    /// ComponentProperty: PreviewSphereRadius
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT PreviewSphereRadius
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 232); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 232); }
    }
}
