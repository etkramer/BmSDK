#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.AkAudio;

/// <summary>
/// Class: SeqAct_AkComponentSettings<br/>
/// (size = 272)
/// (flags = 134226066)
/// </summary>
public partial class SeqAct_AkComponentSettings : BmSDK.Engine.SequenceAction, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "AkAudio.SeqAct_AkComponentSettings", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal SeqAct_AkComponentSettings() { }

    /// <summary>
    /// Constructs a new SeqAct_AkComponentSettings
    /// </summary>
    public SeqAct_AkComponentSettings(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, SeqAct_AkComponentSettings Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected SeqAct_AkComponentSettings(nint ptr) : base(ptr) { }

    /// <summary>
    /// ObjectProperty: LifetimeEvent
    /// </summary>
    public unsafe BmSDK.Engine.AkEvent LifetimeEvent
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkEvent>(Ptr + 204); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 204); }
    }

    /// <summary>
    /// ByteProperty: AutoPlayLifetimeEvent
    /// </summary>
    public unsafe BmSDK.AkAudio.SeqAct_AkComponentSettings.EAkComponentSettingsBool AutoPlayLifetimeEvent
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.AkAudio.SeqAct_AkComponentSettings.EAkComponentSettingsBool>(Ptr + 208); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 208); }
    }

    /// <summary>
    /// ByteProperty: NeverAutoDestroySource
    /// </summary>
    public unsafe BmSDK.AkAudio.SeqAct_AkComponentSettings.EAkComponentSettingsBool NeverAutoDestroySource
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.AkAudio.SeqAct_AkComponentSettings.EAkComponentSettingsBool>(Ptr + 209); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 209); }
    }

    /// <summary>
    /// ByteProperty: AlwaysAutoCreateSource
    /// </summary>
    public unsafe BmSDK.AkAudio.SeqAct_AkComponentSettings.EAkComponentSettingsBool AlwaysAutoCreateSource
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.AkAudio.SeqAct_AkComponentSettings.EAkComponentSettingsBool>(Ptr + 210); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 210); }
    }

    /// <summary>
    /// ByteProperty: AutoDestroySourceWhenHidden
    /// </summary>
    public unsafe BmSDK.AkAudio.SeqAct_AkComponentSettings.EAkComponentSettingsBool AutoDestroySourceWhenHidden
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.AkAudio.SeqAct_AkComponentSettings.EAkComponentSettingsBool>(Ptr + 211); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 211); }
    }

    /// <summary>
    /// ByteProperty: AutoDestroySourceWhenDead
    /// </summary>
    public unsafe BmSDK.AkAudio.SeqAct_AkComponentSettings.EAkComponentSettingsBool AutoDestroySourceWhenDead
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.AkAudio.SeqAct_AkComponentSettings.EAkComponentSettingsBool>(Ptr + 212); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 212); }
    }

    /// <summary>
    /// ByteProperty: KillSoundsOnDestroy
    /// </summary>
    public unsafe BmSDK.AkAudio.SeqAct_AkComponentSettings.EAkComponentSettingsBool KillSoundsOnDestroy
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.AkAudio.SeqAct_AkComponentSettings.EAkComponentSettingsBool>(Ptr + 213); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 213); }
    }

    /// <summary>
    /// ByteProperty: CameraDistanceParameters
    /// </summary>
    public unsafe BmSDK.AkAudio.SeqAct_AkComponentSettings.EAkComponentSettingsBool CameraDistanceParameters
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.AkAudio.SeqAct_AkComponentSettings.EAkComponentSettingsBool>(Ptr + 214); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 214); }
    }

    /// <summary>
    /// ByteProperty: CameraOffsetParameters
    /// </summary>
    public unsafe BmSDK.AkAudio.SeqAct_AkComponentSettings.EAkComponentSettingsBool CameraOffsetParameters
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.AkAudio.SeqAct_AkComponentSettings.EAkComponentSettingsBool>(Ptr + 215); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 215); }
    }

    /// <summary>
    /// ByteProperty: CameraAngleParameters
    /// </summary>
    public unsafe BmSDK.AkAudio.SeqAct_AkComponentSettings.EAkComponentSettingsBool CameraAngleParameters
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.AkAudio.SeqAct_AkComponentSettings.EAkComponentSettingsBool>(Ptr + 216); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 216); }
    }

    /// <summary>
    /// ByteProperty: PlayerDistanceParameters
    /// </summary>
    public unsafe BmSDK.AkAudio.SeqAct_AkComponentSettings.EAkComponentSettingsBool PlayerDistanceParameters
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.AkAudio.SeqAct_AkComponentSettings.EAkComponentSettingsBool>(Ptr + 217); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 217); }
    }

    /// <summary>
    /// ByteProperty: PlayerOffsetParameters
    /// </summary>
    public unsafe BmSDK.AkAudio.SeqAct_AkComponentSettings.EAkComponentSettingsBool PlayerOffsetParameters
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.AkAudio.SeqAct_AkComponentSettings.EAkComponentSettingsBool>(Ptr + 218); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 218); }
    }

    /// <summary>
    /// ByteProperty: PlayerAngleParameters
    /// </summary>
    public unsafe BmSDK.AkAudio.SeqAct_AkComponentSettings.EAkComponentSettingsBool PlayerAngleParameters
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.AkAudio.SeqAct_AkComponentSettings.EAkComponentSettingsBool>(Ptr + 219); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 219); }
    }

    /// <summary>
    /// ByteProperty: ObjectVelocityParameters
    /// </summary>
    public unsafe BmSDK.AkAudio.SeqAct_AkComponentSettings.EAkComponentSettingsBool ObjectVelocityParameters
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.AkAudio.SeqAct_AkComponentSettings.EAkComponentSettingsBool>(Ptr + 220); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 220); }
    }

    /// <summary>
    /// ByteProperty: Enable2DMode
    /// </summary>
    public unsafe BmSDK.AkAudio.SeqAct_AkComponentSettings.EAkComponentSettingsBool Enable2DMode
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.AkAudio.SeqAct_AkComponentSettings.EAkComponentSettingsBool>(Ptr + 221); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 221); }
    }

    /// <summary>
    /// ByteProperty: DialogueMeter
    /// </summary>
    public unsafe BmSDK.AkAudio.SeqAct_AkComponentSettings.EAkComponentSettingsBool DialogueMeter
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.AkAudio.SeqAct_AkComponentSettings.EAkComponentSettingsBool>(Ptr + 222); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 222); }
    }

    /// <summary>
    /// ByteProperty: Occlusion
    /// </summary>
    public unsafe BmSDK.AkAudio.SeqAct_AkComponentSettings.EAkComponentSettingsBool Occlusion
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.AkAudio.SeqAct_AkComponentSettings.EAkComponentSettingsBool>(Ptr + 223); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 223); }
    }

    /// <summary>
    /// ByteProperty: ParameterOnlyOcclusion
    /// </summary>
    public unsafe BmSDK.AkAudio.SeqAct_AkComponentSettings.EAkComponentSettingsBool ParameterOnlyOcclusion
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.AkAudio.SeqAct_AkComponentSettings.EAkComponentSettingsBool>(Ptr + 224); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 224); }
    }

    /// <summary>
    /// ObjectProperty: DialogueMeterEffect
    /// </summary>
    public unsafe BmSDK.Engine.AkEnvironmentName DialogueMeterEffect
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkEnvironmentName>(Ptr + 228); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 228); }
    }

    /// <summary>
    /// FloatProperty: OcclusionUpdateTimeFast
    /// </summary>
    public unsafe float OcclusionUpdateTimeFast
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 232); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 232); }
    }

    /// <summary>
    /// FloatProperty: OcclusionUpdateTimeSlow
    /// </summary>
    public unsafe float OcclusionUpdateTimeSlow
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 236); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 236); }
    }

    /// <summary>
    /// FloatProperty: OcclusionInterpolationTime
    /// </summary>
    public unsafe float OcclusionInterpolationTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 240); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 240); }
    }

    /// <summary>
    /// FloatProperty: OcclusionScalingDistance
    /// </summary>
    public unsafe float OcclusionScalingDistance
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 244); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 244); }
    }

    /// <summary>
    /// FloatProperty: OcclusionMultiplier
    /// </summary>
    public unsafe float OcclusionMultiplier
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 248); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 248); }
    }

    /// <summary>
    /// FloatProperty: OcclusionMultiplierAux
    /// </summary>
    public unsafe float OcclusionMultiplierAux
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 252); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 252); }
    }

    /// <summary>
    /// FloatProperty: WetDryMixVolume
    /// </summary>
    public unsafe float WetDryMixVolume
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 256); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 256); }
    }

    /// <summary>
    /// FloatProperty: WetDryMixVolumeAux
    /// </summary>
    public unsafe float WetDryMixVolumeAux
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 260); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 260); }
    }

    /// <summary>
    /// FloatProperty: FalloffRadiusMultiplier
    /// </summary>
    public unsafe float FalloffRadiusMultiplier
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 264); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 264); }
    }

    /// <summary>
    /// FloatProperty: FalloffEnhancement
    /// </summary>
    public unsafe float FalloffEnhancement
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 268); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 268); }
    }

    /// <summary>
    /// Enum: EAkComponentSettingsBool
    /// </summary>
    public enum EAkComponentSettingsBool
    {
        AK_SETTING_UNCHANGED = 0,
        AK_SETTING_TRUE = 1,
        AK_SETTING_FALSE = 2,
        AK_SETTING_MAX = 3,
    }
}
