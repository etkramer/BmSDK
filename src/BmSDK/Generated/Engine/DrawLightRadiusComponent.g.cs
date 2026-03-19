#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Class: DrawLightRadiusComponent<br/>
/// (size = 0)
/// (flags = 0)
/// </summary>
public partial class DrawLightRadiusComponent : BmSDK.Engine.DrawSphereComponent, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Engine.DrawLightRadiusComponent", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal DrawLightRadiusComponent() { }

    /// <summary>
    /// Constructs a new DrawLightRadiusComponent
    /// </summary>
    public DrawLightRadiusComponent(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, DrawLightRadiusComponent Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected DrawLightRadiusComponent(nint ptr) : base(ptr) { }

    /// <summary>
    /// StructProperty: SphereColor
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT SphereColor
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 540); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 540); }
    }

    /// <summary>
    /// ObjectProperty: SphereMaterial
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT SphereMaterial
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 544); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 544); }
    }

    /// <summary>
    /// FloatProperty: SphereRadius
    /// </summary>
    public unsafe float SphereRadius
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 552); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 552); }
    }

    /// <summary>
    /// IntProperty: SphereSides
    /// </summary>
    public unsafe int SphereSides
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 556); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 556); }
    }

    /// <summary>
    /// BoolProperty: bDrawWireSphere
    /// </summary>
    public unsafe bool bDrawWireSphere
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 560) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 560); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 560); }
    }

    /// <summary>
    /// BoolProperty: bDrawLitSphere
    /// </summary>
    public unsafe bool bDrawLitSphere
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 560) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 560); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 560); }
    }

    /// <summary>
    /// BoolProperty: bDrawOnlyIfSelected
    /// </summary>
    public unsafe bool bDrawOnlyIfSelected
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 560) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 560); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 560); }
    }
}
