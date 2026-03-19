#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Class: RSnowComponent<br/>
/// (size = 0)
/// (flags = 0)
/// </summary>
public partial class RSnowComponent : BmSDK.Engine.PrimitiveComponent, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Engine.RSnowComponent", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RSnowComponent() { }

    /// <summary>
    /// Constructs a new RSnowComponent
    /// </summary>
    public RSnowComponent(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RSnowComponent Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RSnowComponent(nint ptr) : base(ptr) { }

    /// <summary>
    /// IntProperty: ParticleCount
    /// </summary>
    public unsafe int ParticleCount
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 540); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 540); }
    }

    /// <summary>
    /// FloatProperty: BoxSize
    /// </summary>
    public unsafe float BoxSize
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 544); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 544); }
    }

    /// <summary>
    /// FloatProperty: CameraCullingDistance
    /// </summary>
    public unsafe float CameraCullingDistance
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 548); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 548); }
    }

    /// <summary>
    /// BoolProperty: bHasMotionBlurTexture
    /// </summary>
    public unsafe bool bHasMotionBlurTexture
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 552) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 552); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 552); }
    }

    /// <summary>
    /// StructProperty: SnowSettings
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT SnowSettings
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 556); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 556); }
    }

    /// <summary>
    /// StructProperty: VolumeSettings
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT VolumeSettings
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 600); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 600); }
    }
}
