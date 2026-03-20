#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Class: AkEnvironmentName<br/>
/// (size = 0)
/// (flags = 0)
/// </summary>
public partial class AkEnvironmentName : BmSDK.Engine.AkAsset, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Engine.AkEnvironmentName", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal AkEnvironmentName() { }

    /// <summary>
    /// Constructs a new AkEnvironmentName
    /// </summary>
    public AkEnvironmentName(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, AkEnvironmentName Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected AkEnvironmentName(nint ptr) : base(ptr) { }

    /// <summary>
    /// ByteProperty: EffectType
    /// </summary>
    public unsafe BmSDK.Engine.AkEnvironmentName.EAuxEffectType EffectType
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkEnvironmentName.EAuxEffectType>(Ptr + 100); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 100); }
    }

    /// <summary>
    /// BoolProperty: EnableRolloff
    /// </summary>
    public unsafe bool EnableRolloff
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 104) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 104); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 104); }
    }

    /// <summary>
    /// BoolProperty: EnableOcclusionSends
    /// </summary>
    public unsafe bool EnableOcclusionSends
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 104) & 2) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 104); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 104); }
    }

    /// <summary>
    /// ObjectProperty: EnvironmentRolloff
    /// </summary>
    public unsafe BmSDK.Engine.AkCurve EnvironmentRolloff
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkCurve>(Ptr + 108); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 108); }
    }

    /// <summary>
    /// FloatProperty: EnvironmentRolloffSendPlayer
    /// </summary>
    public unsafe float EnvironmentRolloffSendPlayer
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 116); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 116); }
    }

    /// <summary>
    /// FloatProperty: EnvironmentRolloffSendNoListener
    /// </summary>
    public unsafe float EnvironmentRolloffSendNoListener
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 120); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 120); }
    }

    /// <summary>
    /// FloatProperty: EnvironmentRolloffSendOnlyListener
    /// </summary>
    public unsafe float EnvironmentRolloffSendOnlyListener
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 124); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 124); }
    }

    /// <summary>
    /// FloatProperty: EnvironmentRolloffSend2DMode
    /// </summary>
    public unsafe float EnvironmentRolloffSend2DMode
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 128); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 128); }
    }

    /// <summary>
    /// FloatProperty: EnvironmentWetSendOccludedMultiplier
    /// </summary>
    public unsafe float EnvironmentWetSendOccludedMultiplier
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 132); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 132); }
    }

    /// <summary>
    /// FloatProperty: EnvironmentWetSendNotOccludedMultiplier
    /// </summary>
    public unsafe float EnvironmentWetSendNotOccludedMultiplier
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 136); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 136); }
    }

    /// <summary>
    /// FloatProperty: EnvironmentDrySendOccludedMultiplier
    /// </summary>
    public unsafe float EnvironmentDrySendOccludedMultiplier
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 140); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 140); }
    }

    /// <summary>
    /// FloatProperty: EnvironmentDrySendNotOccludedMultiplier
    /// </summary>
    public unsafe float EnvironmentDrySendNotOccludedMultiplier
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 144); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 144); }
    }

    /// <summary>
    /// Enum: EAuxEffectType
    /// </summary>
    public enum EAuxEffectType
    {
        AK_AUX_EFFECT_ENVIRONMENT_NORMAL = 0,
        AK_AUX_EFFECT_ENVIRONMENT_HIGH = 1,
        AK_AUX_EFFECT_ENVIRONMENT_LOW = 2,
        AK_AUX_EFFECT_ENVIRONMENT_MAX = 3,
    }
}
