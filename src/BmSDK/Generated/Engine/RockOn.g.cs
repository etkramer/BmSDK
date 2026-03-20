#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Class: RockOn<br/>
/// (size = 249)
/// (flags = 134217874)
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
    /// Enum: EPostProcessAAType
    /// </summary>
    public enum EPostProcessAAType
    {
        PostProcessAA_Off = 0,
        PostProcessAA_FXAA0 = 1,
        PostProcessAA_FXAA1 = 2,
        PostProcessAA_FXAA2 = 3,
        PostProcessAA_FXAA3 = 4,
        PostProcessAA_FXAA4 = 5,
        PostProcessAA_FXAA5 = 6,
        PostProcessAA_MLAA = 7,
        PostProcessAA_MAX = 8,
    }

    /// <summary>
    /// StructProperty: SceneShadows
    /// </summary>
    public unsafe BmSDK.GameObject.FLinearColor SceneShadows
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.GameObject.FLinearColor>(Ptr + 176); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 176); }
    }

    /// <summary>
    /// StructProperty: SceneHighLights
    /// </summary>
    public unsafe BmSDK.GameObject.FLinearColor SceneHighLights
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.GameObject.FLinearColor>(Ptr + 192); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 192); }
    }

    /// <summary>
    /// StructProperty: SceneMidTones
    /// </summary>
    public unsafe BmSDK.GameObject.FLinearColor SceneMidTones
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.GameObject.FLinearColor>(Ptr + 208); }
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
    public unsafe System.Numerics.Vector3 SceneColorize
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 228); }
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
    public unsafe BmSDK.Engine.RockOn.EPostProcessAAType PostProcessAAType
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RockOn.EPostProcessAAType>(Ptr + 248); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 248); }
    }
}
