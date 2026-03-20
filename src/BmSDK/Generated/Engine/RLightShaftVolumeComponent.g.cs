#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Class: RLightShaftVolumeComponent<br/>
/// (flags = 0)
/// </summary>
public partial class RLightShaftVolumeComponent : BmSDK.Engine.PrimitiveComponent, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Engine.RLightShaftVolumeComponent", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RLightShaftVolumeComponent() { }

    /// <summary>
    /// Constructs a new RLightShaftVolumeComponent
    /// </summary>
    public RLightShaftVolumeComponent(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RLightShaftVolumeComponent Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RLightShaftVolumeComponent(nint ptr) : base(ptr) { }

    /// <summary>
    /// FloatProperty: ConeAngle
    /// </summary>
    public unsafe float ConeAngle
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 540); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 540); }
    }

    /// <summary>
    /// FloatProperty: Radius
    /// </summary>
    public unsafe float Radius
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 544); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 544); }
    }

    /// <summary>
    /// FloatProperty: FalloffExponent
    /// </summary>
    public unsafe float FalloffExponent
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 548); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 548); }
    }

    /// <summary>
    /// FloatProperty: FalloffHighEnd
    /// </summary>
    public unsafe float FalloffHighEnd
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 552); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 552); }
    }

    /// <summary>
    /// FloatProperty: FalloffOriginMul
    /// </summary>
    public unsafe float FalloffOriginMul
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 556); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 556); }
    }

    /// <summary>
    /// StructProperty: LightColor
    /// </summary>
    public unsafe BmSDK.GameObject.FColor LightColor
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.GameObject.FColor>(Ptr + 560); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 560); }
    }

    /// <summary>
    /// FloatProperty: Brightness
    /// </summary>
    public unsafe float Brightness
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 564); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 564); }
    }

    /// <summary>
    /// StructProperty: ClippingPlane
    /// </summary>
    public unsafe BmSDK.GameObject.FPlane ClippingPlane
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.GameObject.FPlane>(Ptr + 576); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 576); }
    }

    /// <summary>
    /// BoolProperty: Enabled
    /// </summary>
    public unsafe bool Enabled
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 592) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 592); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 592); }
    }

    /// <summary>
    /// ObjectProperty: LightShaftMesh
    /// </summary>
    public unsafe BmSDK.Engine.StaticMesh LightShaftMesh
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.StaticMesh>(Ptr + 596); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 596); }
    }

    /// <summary>
    /// ObjectProperty: NoiseTexture
    /// </summary>
    public unsafe BmSDK.Engine.Texture2D NoiseTexture
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.Texture2D>(Ptr + 604); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 604); }
    }
}
