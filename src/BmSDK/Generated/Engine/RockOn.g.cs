#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Class: RockOn<br/>
/// (size = 0)
/// (flags = 0)
/// </summary>
public partial class RockOn : BmSDK.Engine.DOFBloomMotionBlurEffect, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Engine.RockOn", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RockOn() { }

    /// <summary>
    /// Constructs a new RockOn
    /// </summary>
    public RockOn(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RockOn Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RockOn(nint ptr) : base(ptr) { }

    /// <summary>
    /// StructProperty: SceneShadows
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT SceneShadows
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 176); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 176); }
    }

    /// <summary>
    /// StructProperty: SceneHighLights
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT SceneHighLights
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 192); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 192); }
    }

    /// <summary>
    /// StructProperty: SceneMidTones
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT SceneMidTones
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 208); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 208); }
    }

    /// <summary>
    /// FloatProperty: SceneDesaturation
    /// </summary>
    public unsafe float SceneDesaturation
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 224); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 224); }
    }

    /// <summary>
    /// StructProperty: SceneColorize
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT SceneColorize
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 228); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 228); }
    }

    /// <summary>
    /// FloatProperty: MotionBlurSoftEdgeKernelSize
    /// </summary>
    public unsafe float MotionBlurSoftEdgeKernelSize
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 240); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 240); }
    }

    /// <summary>
    /// FloatProperty: EdgeDetectionThreshold
    /// </summary>
    public unsafe float EdgeDetectionThreshold
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 244); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 244); }
    }

    /// <summary>
    /// ByteProperty: PostProcessAAType
    /// </summary>
    public unsafe byte PostProcessAAType
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 248); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 248); }
    }
}
