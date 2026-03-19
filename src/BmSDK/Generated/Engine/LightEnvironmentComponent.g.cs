#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Class: LightEnvironmentComponent<br/>
/// (size = 0)
/// (flags = 0)
/// </summary>
public partial class LightEnvironmentComponent : BmSDK.Engine.ActorComponent, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Engine.LightEnvironmentComponent", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal LightEnvironmentComponent() { }

    /// <summary>
    /// Constructs a new LightEnvironmentComponent
    /// </summary>
    public LightEnvironmentComponent(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, LightEnvironmentComponent Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected LightEnvironmentComponent(nint ptr) : base(ptr) { }

    /// <summary>
    /// BoolProperty: bEnabled
    /// </summary>
    public unsafe bool bEnabled
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 124) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 124); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 124); }
    }

    /// <summary>
    /// BoolProperty: bForceNonCompositeDynamicLights
    /// </summary>
    public unsafe bool bForceNonCompositeDynamicLights
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 124) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 124); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 124); }
    }

    /// <summary>
    /// BoolProperty: bAllowDynamicShadowsOnTranslucency
    /// </summary>
    public unsafe bool bAllowDynamicShadowsOnTranslucency
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 124) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 124); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 124); }
    }

    /// <summary>
    /// BoolProperty: bAllowPreShadow
    /// </summary>
    public unsafe bool bAllowPreShadow
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 124) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 124); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 124); }
    }

    /// <summary>
    /// BoolProperty: bTranslucencyShadowed
    /// </summary>
    public unsafe bool bTranslucencyShadowed
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 124) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 124); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 124); }
    }

    /// <summary>
    /// FloatProperty: DominantShadowFactor
    /// </summary>
    public unsafe float DominantShadowFactor
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 128); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 128); }
    }

    /// <summary>
    /// ComponentProperty: AffectingDominantLight
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT AffectingDominantLight
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 132); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 132); }
    }

    /// <summary>
    /// ArrayProperty: AffectedComponents
    /// </summary>
    public unsafe NEED_UPDATE_ARRAYPROPERTY_LAYOUT AffectedComponents
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_ARRAYPROPERTY_LAYOUT>(Ptr + 140); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 140); }
    }
}
