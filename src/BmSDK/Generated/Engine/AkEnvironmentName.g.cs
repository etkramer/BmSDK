#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Class: AkEnvironmentName<br/>
/// (size = 132)
/// (flags = 134217874)
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
    /// BoolProperty: EnableRolloff
    /// </summary>
    public unsafe bool EnableRolloff
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 56) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 56); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 56); }
    }

    /// <summary>
    /// BoolProperty: EnableOcclusionSends
    /// </summary>
    public unsafe bool EnableOcclusionSends
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 56) & 2) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 56); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 56); }
    }

    /// <summary>
    /// FloatProperty: EnvironmentRolloffDistanceMin
    /// </summary>
    public unsafe float EnvironmentRolloffDistanceMin
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 60); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 60); }
    }

    /// <summary>
    /// FloatProperty: EnvironmentRolloffDistanceMax
    /// </summary>
    public unsafe float EnvironmentRolloffDistanceMax
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 64); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 64); }
    }

    /// <summary>
    /// FloatProperty: EnvironmentDryMin
    /// </summary>
    public unsafe float EnvironmentDryMin
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 68); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 68); }
    }

    /// <summary>
    /// FloatProperty: EnvironmentDryMax
    /// </summary>
    public unsafe float EnvironmentDryMax
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 72); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 72); }
    }

    /// <summary>
    /// FloatProperty: EnvironmentRolloffSendMin
    /// </summary>
    public unsafe float EnvironmentRolloffSendMin
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 76); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 76); }
    }

    /// <summary>
    /// FloatProperty: EnvironmentRolloffSendMax
    /// </summary>
    public unsafe float EnvironmentRolloffSendMax
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 80); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 80); }
    }

    /// <summary>
    /// FloatProperty: EnvironmentRolloffSendPlayer
    /// </summary>
    public unsafe float EnvironmentRolloffSendPlayer
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 84); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 84); }
    }

    /// <summary>
    /// FloatProperty: EnvironmentRolloffSendNoListener
    /// </summary>
    public unsafe float EnvironmentRolloffSendNoListener
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 88); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 88); }
    }

    /// <summary>
    /// FloatProperty: EnvironmentRolloffSendOnlyListener
    /// </summary>
    public unsafe float EnvironmentRolloffSendOnlyListener
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 92); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 92); }
    }

    /// <summary>
    /// FloatProperty: EnvironmentRolloffSend2DMode
    /// </summary>
    public unsafe float EnvironmentRolloffSend2DMode
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 96); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 96); }
    }

    /// <summary>
    /// FloatProperty: EnhancedWetSendMultiplier
    /// </summary>
    public unsafe float EnhancedWetSendMultiplier
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 100); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 100); }
    }

    /// <summary>
    /// FloatProperty: EnhancedWetSendFalloff
    /// </summary>
    public unsafe float EnhancedWetSendFalloff
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 104); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 104); }
    }

    /// <summary>
    /// FloatProperty: DialogueMeterWetBoost
    /// </summary>
    public unsafe float DialogueMeterWetBoost
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 108); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 108); }
    }

    /// <summary>
    /// FloatProperty: DialogueMeterWetBoostPlayer
    /// </summary>
    public unsafe float DialogueMeterWetBoostPlayer
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 112); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 112); }
    }

    /// <summary>
    /// FloatProperty: EnvironmentWetSendOccludedMultiplier
    /// </summary>
    public unsafe float EnvironmentWetSendOccludedMultiplier
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 116); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 116); }
    }

    /// <summary>
    /// FloatProperty: EnvironmentWetSendNotOccludedMultiplier
    /// </summary>
    public unsafe float EnvironmentWetSendNotOccludedMultiplier
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 120); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 120); }
    }

    /// <summary>
    /// FloatProperty: EnvironmentDrySendOccludedMultiplier
    /// </summary>
    public unsafe float EnvironmentDrySendOccludedMultiplier
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 124); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 124); }
    }

    /// <summary>
    /// FloatProperty: EnvironmentDrySendNotOccludedMultiplier
    /// </summary>
    public unsafe float EnvironmentDrySendNotOccludedMultiplier
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 128); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 128); }
    }
}
