#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Class: RRainComponent<br/>
/// (flags = 0)
/// </summary>
public partial class RRainComponent : BmSDK.Engine.PrimitiveComponent, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Engine.RRainComponent", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RRainComponent() { }

    /// <summary>
    /// Constructs a new RRainComponent
    /// </summary>
    public RRainComponent(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RRainComponent Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RRainComponent(nint ptr) : base(ptr) { }

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
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 552) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 552); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 552); }
    }

    /// <summary>
    /// StructProperty: RainSettings
    /// </summary>
    public unsafe BmSDK.Engine.RRainComponent.FRockRainSettings RainSettings
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RRainComponent.FRockRainSettings>(Ptr + 556); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 556); }
    }

    /// <summary>
    /// StructProperty: VolumeSettings
    /// </summary>
    public unsafe BmSDK.Engine.RRainComponent.FRockRainVolumeSettings VolumeSettings
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RRainComponent.FRockRainVolumeSettings>(Ptr + 620); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 620); }
    }
}
