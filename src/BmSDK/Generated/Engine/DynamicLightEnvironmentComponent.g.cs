#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Class: DynamicLightEnvironmentComponent<br/>
/// (size = 0)
/// (flags = 0)
/// </summary>
public partial class DynamicLightEnvironmentComponent : BmSDK.Engine.LightEnvironmentComponent, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Engine.DynamicLightEnvironmentComponent", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal DynamicLightEnvironmentComponent() { }

    /// <summary>
    /// Constructs a new DynamicLightEnvironmentComponent
    /// </summary>
    public DynamicLightEnvironmentComponent(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, DynamicLightEnvironmentComponent Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected DynamicLightEnvironmentComponent(nint ptr) : base(ptr) { }

    /// <summary>
    /// StructProperty: State
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT State
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 156); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 156); }
    }

    /// <summary>
    /// FloatProperty: InvisibleUpdateTime
    /// </summary>
    public unsafe float InvisibleUpdateTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 164); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 164); }
    }

    /// <summary>
    /// FloatProperty: MinTimeBetweenFullUpdates
    /// </summary>
    public unsafe float MinTimeBetweenFullUpdates
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 168); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 168); }
    }

    /// <summary>
    /// FloatProperty: VelocityUpdateTimeScale
    /// </summary>
    public unsafe float VelocityUpdateTimeScale
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 172); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 172); }
    }

    /// <summary>
    /// FloatProperty: ShadowInterpolationSpeed
    /// </summary>
    public unsafe float ShadowInterpolationSpeed
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 176); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 176); }
    }

    /// <summary>
    /// IntProperty: NumVolumeVisibilitySamples
    /// </summary>
    public unsafe int NumVolumeVisibilitySamples
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 180); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 180); }
    }

    /// <summary>
    /// FloatProperty: LightingBoundsScale
    /// </summary>
    public unsafe float LightingBoundsScale
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 184); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 184); }
    }

    /// <summary>
    /// StructProperty: AmbientShadowColor
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT AmbientShadowColor
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 188); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 188); }
    }

    /// <summary>
    /// StructProperty: AmbientShadowSourceDirection
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT AmbientShadowSourceDirection
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 204); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 204); }
    }

    /// <summary>
    /// StructProperty: AmbientGlow
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT AmbientGlow
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 216); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 216); }
    }

    /// <summary>
    /// FloatProperty: LightDistance
    /// </summary>
    public unsafe float LightDistance
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 232); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 232); }
    }

    /// <summary>
    /// FloatProperty: ShadowDistance
    /// </summary>
    public unsafe float ShadowDistance
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 236); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 236); }
    }

    /// <summary>
    /// BoolProperty: bCastShadows
    /// </summary>
    public unsafe bool bCastShadows
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 240) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 240); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 240); }
    }

    /// <summary>
    /// BoolProperty: bCompositeShadowsFromDynamicLights
    /// </summary>
    public unsafe bool bCompositeShadowsFromDynamicLights
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 240) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 240); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 240); }
    }

    /// <summary>
    /// BoolProperty: bForceCompositeAllLights
    /// </summary>
    public unsafe bool bForceCompositeAllLights
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 240) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 240); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 240); }
    }

    /// <summary>
    /// BoolProperty: bAffectedBySmallDynamicLights
    /// </summary>
    public unsafe bool bAffectedBySmallDynamicLights
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 240) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 240); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 240); }
    }

    /// <summary>
    /// BoolProperty: bUseBooleanEnvironmentShadowing
    /// </summary>
    public unsafe bool bUseBooleanEnvironmentShadowing
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 240) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 240); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 240); }
    }

    /// <summary>
    /// BoolProperty: bShadowFromEnvironment
    /// </summary>
    public unsafe bool bShadowFromEnvironment
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 240) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 240); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 240); }
    }

    /// <summary>
    /// BoolProperty: bDynamic
    /// </summary>
    public unsafe bool bDynamic
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 240) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 240); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 240); }
    }

    /// <summary>
    /// BoolProperty: bSynthesizeDirectionalLight
    /// </summary>
    public unsafe bool bSynthesizeDirectionalLight
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 240) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 240); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 240); }
    }

    /// <summary>
    /// BoolProperty: bSynthesizeSHLight
    /// </summary>
    public unsafe bool bSynthesizeSHLight
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 240) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 240); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 240); }
    }

    /// <summary>
    /// BoolProperty: bRequiresNonLatentUpdates
    /// </summary>
    public unsafe bool bRequiresNonLatentUpdates
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 240) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 240); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 240); }
    }

    /// <summary>
    /// BoolProperty: bTraceFromClosestBoundsPoint
    /// </summary>
    public unsafe bool bTraceFromClosestBoundsPoint
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 240) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 240); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 240); }
    }

    /// <summary>
    /// BoolProperty: bIsCharacterLightEnvironment
    /// </summary>
    public unsafe bool bIsCharacterLightEnvironment
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 240) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 240); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 240); }
    }

    /// <summary>
    /// BoolProperty: bOverrideOwnerLightingChannels
    /// </summary>
    public unsafe bool bOverrideOwnerLightingChannels
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 240) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 240); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 240); }
    }

    /// <summary>
    /// BoolProperty: bAlwaysInfluencedByDominantDirectionalLight
    /// </summary>
    public unsafe bool bAlwaysInfluencedByDominantDirectionalLight
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 240) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 240); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 240); }
    }

    /// <summary>
    /// BoolProperty: RestrictInterpolationWhenSlow
    /// </summary>
    public unsafe bool RestrictInterpolationWhenSlow
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 240) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 240); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 240); }
    }

    /// <summary>
    /// BoolProperty: bScaleShadowDistanceWhenAboveCamera
    /// </summary>
    public unsafe bool bScaleShadowDistanceWhenAboveCamera
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 240) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 240); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 240); }
    }

    /// <summary>
    /// BoolProperty: WaitingForDeferredReset
    /// </summary>
    public unsafe bool WaitingForDeferredReset
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 240) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 240); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 240); }
    }

    /// <summary>
    /// FloatProperty: ModShadowFadeoutTime
    /// </summary>
    public unsafe float ModShadowFadeoutTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 244); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 244); }
    }

    /// <summary>
    /// FloatProperty: ModShadowFadeoutExponent
    /// </summary>
    public unsafe float ModShadowFadeoutExponent
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 248); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 248); }
    }

    /// <summary>
    /// StructProperty: MaxModulatedShadowColor
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT MaxModulatedShadowColor
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 252); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 252); }
    }

    /// <summary>
    /// FloatProperty: DominantShadowTransitionStartDistance
    /// </summary>
    public unsafe float DominantShadowTransitionStartDistance
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 268); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 268); }
    }

    /// <summary>
    /// FloatProperty: DominantShadowTransitionEndDistance
    /// </summary>
    public unsafe float DominantShadowTransitionEndDistance
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 272); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 272); }
    }

    /// <summary>
    /// FloatProperty: ShadowFalloffExponent
    /// </summary>
    public unsafe float ShadowFalloffExponent
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 276); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 276); }
    }

    /// <summary>
    /// FloatProperty: MinShadowAngle
    /// </summary>
    public unsafe float MinShadowAngle
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 280); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 280); }
    }

    /// <summary>
    /// ByteProperty: BoundsMethod
    /// </summary>
    public unsafe byte BoundsMethod
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 284); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 284); }
    }

    /// <summary>
    /// StructProperty: OverriddenBounds
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT OverriddenBounds
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 288); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 288); }
    }

    /// <summary>
    /// StructProperty: OverriddenLightingChannels
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT OverriddenLightingChannels
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 316); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 316); }
    }

    /// <summary>
    /// ArrayProperty: OverriddenLightComponents
    /// </summary>
    public unsafe BmSDK.TArray<NEED_UPDATE_ARRAYPROPERTY_LAYOUT> OverriddenLightComponents
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<NEED_UPDATE_ARRAYPROPERTY_LAYOUT>>(Ptr + 320); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 320); }
    }

    /// <summary>
    /// IntProperty: StaticLightingTimestamp
    /// </summary>
    public unsafe int StaticLightingTimestamp
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 336); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 336); }
    }

    /// <summary>
    /// Enum: DLEC_Mode
    /// </summary>
    public enum DLEC_Mode
    {
        DLEC_Unmolested = 0,
        DLEC_APlus3D = 1,
        DLEC_MAX = 2,
    }
}
