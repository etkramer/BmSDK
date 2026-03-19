#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmScript;

/// <summary>
/// Class: RPredatorDroneMiniSpotlight<br/>
/// (size = 0)
/// (flags = 0)
/// </summary>
public partial class RPredatorDroneMiniSpotlight : BmSDK.Engine.SpotLightComponent, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmScript.RPredatorDroneMiniSpotlight", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RPredatorDroneMiniSpotlight() { }

    /// <summary>
    /// Constructs a new RPredatorDroneMiniSpotlight
    /// </summary>
    public RPredatorDroneMiniSpotlight(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RPredatorDroneMiniSpotlight Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RPredatorDroneMiniSpotlight(nint ptr) : base(ptr) { }

    /// <summary>
    /// FloatProperty: InnerConeAngle
    /// </summary>
    public unsafe float InnerConeAngle
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 732); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 732); }
    }

    /// <summary>
    /// FloatProperty: OuterConeAngle
    /// </summary>
    public unsafe float OuterConeAngle
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 736); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 736); }
    }

    /// <summary>
    /// FloatProperty: LightShaftConeAngle
    /// </summary>
    public unsafe float LightShaftConeAngle
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 740); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 740); }
    }

    /// <summary>
    /// ComponentProperty: PreviewInnerCone
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT PreviewInnerCone
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 744); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 744); }
    }

    /// <summary>
    /// ComponentProperty: PreviewOuterCone
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT PreviewOuterCone
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 752); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 752); }
    }

    /// <summary>
    /// StructProperty: Rotation
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT Rotation
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 760); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 760); }
    }

    /// <summary>
    /// BoolProperty: bAbsoluteRotation
    /// </summary>
    public unsafe bool bAbsoluteRotation
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 772) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 772); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 772); }
    }

    /// <summary>
    /// BoolProperty: bNvidiaLightShafts
    /// </summary>
    public unsafe bool bNvidiaLightShafts
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 772) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 772); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 772); }
    }

    /// <summary>
    /// BoolProperty: bCastOpacityShadows
    /// </summary>
    public unsafe bool bCastOpacityShadows
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 772) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 772); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 772); }
    }

    /// <summary>
    /// ByteProperty: QualityLevel
    /// </summary>
    public unsafe byte QualityLevel
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 776); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 776); }
    }

    /// <summary>
    /// ByteProperty: PhaseFunction
    /// </summary>
    public unsafe byte PhaseFunction
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 777); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 777); }
    }

    /// <summary>
    /// FloatProperty: DistanceScale
    /// </summary>
    public unsafe float DistanceScale
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 780); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 780); }
    }

    /// <summary>
    /// FloatProperty: GelThreshold
    /// </summary>
    public unsafe float GelThreshold
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 784); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 784); }
    }

    /// <summary>
    /// FloatProperty: Scatter
    /// </summary>
    public unsafe float Scatter
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 788); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 788); }
    }

    /// <summary>
    /// FloatProperty: Absorption
    /// </summary>
    public unsafe float Absorption
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 792); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 792); }
    }

    /// <summary>
    /// FloatProperty: Phase
    /// </summary>
    public unsafe float Phase
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 796); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 796); }
    }

    /// <summary>
    /// FloatProperty: NvLightShaftsBrightness
    /// </summary>
    public unsafe float NvLightShaftsBrightness
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 800); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 800); }
    }

    /// <summary>
    /// FloatProperty: OpacityShadowNearDepth
    /// </summary>
    public unsafe float OpacityShadowNearDepth
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 804); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 804); }
    }

    /// <summary>
    /// FloatProperty: OpacityShadowOpacityMultiplier
    /// </summary>
    public unsafe float OpacityShadowOpacityMultiplier
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 808); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 808); }
    }

    /// <summary>
    /// FloatProperty: OpacityShadowAmbientSelf
    /// </summary>
    public unsafe float OpacityShadowAmbientSelf
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 812); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 812); }
    }

    /// <summary>
    /// FloatProperty: OpacityShadowAmbientProjected
    /// </summary>
    public unsafe float OpacityShadowAmbientProjected
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 816); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 816); }
    }
}
