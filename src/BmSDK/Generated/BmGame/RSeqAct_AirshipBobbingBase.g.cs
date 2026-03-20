#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RSeqAct_AirshipBobbingBase<br/>
/// (flags = 0)
/// </summary>
public partial class RSeqAct_AirshipBobbingBase : BmSDK.Engine.SeqAct_Latent, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RSeqAct_AirshipBobbingBase", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RSeqAct_AirshipBobbingBase() { }

    /// <summary>
    /// Constructs a new RSeqAct_AirshipBobbingBase
    /// </summary>
    public RSeqAct_AirshipBobbingBase(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RSeqAct_AirshipBobbingBase Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RSeqAct_AirshipBobbingBase(nint ptr) : base(ptr) { }

    /// <summary>
    /// ObjectProperty: TargetPlayer
    /// </summary>
    public unsafe BmSDK.BmGame.RPlayerController TargetPlayer
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPlayerController>(Ptr + 376); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 376); }
    }

    /// <summary>
    /// ObjectProperty: OwVista
    /// </summary>
    public unsafe BmSDK.Engine.Actor OwVista
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.Actor>(Ptr + 384); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 384); }
    }

    /// <summary>
    /// ObjectProperty: RotationOrigin
    /// </summary>
    public unsafe BmSDK.Engine.Actor RotationOrigin
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.Actor>(Ptr + 392); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 392); }
    }

    /// <summary>
    /// ObjectProperty: GlobalEffectVolume
    /// </summary>
    public unsafe BmSDK.Engine.Volume GlobalEffectVolume
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.Volume>(Ptr + 400); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 400); }
    }

    /// <summary>
    /// ObjectProperty: XAxisBobAudioParameter
    /// </summary>
    public unsafe BmSDK.Engine.AkParameterName XAxisBobAudioParameter
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkParameterName>(Ptr + 408); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 408); }
    }

    /// <summary>
    /// ObjectProperty: YAxisBobAudioParameter
    /// </summary>
    public unsafe BmSDK.Engine.AkParameterName YAxisBobAudioParameter
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkParameterName>(Ptr + 416); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 416); }
    }

    /// <summary>
    /// ObjectProperty: ZAxisBobAudioParameter
    /// </summary>
    public unsafe BmSDK.Engine.AkParameterName ZAxisBobAudioParameter
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkParameterName>(Ptr + 424); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 424); }
    }

    /// <summary>
    /// ObjectProperty: TotalBobAudioParameter
    /// </summary>
    public unsafe BmSDK.Engine.AkParameterName TotalBobAudioParameter
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkParameterName>(Ptr + 432); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 432); }
    }

    /// <summary>
    /// ObjectProperty: StabilityLostSFX
    /// </summary>
    public unsafe BmSDK.Engine.AkEvent StabilityLostSFX
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkEvent>(Ptr + 440); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 440); }
    }

    /// <summary>
    /// ObjectProperty: StabilityRegainedSFX
    /// </summary>
    public unsafe BmSDK.Engine.AkEvent StabilityRegainedSFX
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkEvent>(Ptr + 448); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 448); }
    }

    /// <summary>
    /// ObjectProperty: PlayTiltControlActiveSFX
    /// </summary>
    public unsafe BmSDK.Engine.AkEvent PlayTiltControlActiveSFX
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkEvent>(Ptr + 456); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 456); }
    }

    /// <summary>
    /// StructProperty: InitialVistaRotation
    /// </summary>
    public unsafe BmSDK.Rotator InitialVistaRotation
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Rotator>(Ptr + 464); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 464); }
    }

    /// <summary>
    /// ArrayProperty: ForceFieldVolume
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RAirshipBobbingForceFieldVolume> ForceFieldVolume
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RAirshipBobbingForceFieldVolume>>(Ptr + 476); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 476); }
    }

    /// <summary>
    /// BoolProperty: bCanControlAirship
    /// </summary>
    public unsafe bool bCanControlAirship
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 492) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 492); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 492); }
    }

    /// <summary>
    /// BoolProperty: bBobActive
    /// </summary>
    public unsafe bool bBobActive
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 492) & 2) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 492); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 492); }
    }

    /// <summary>
    /// BoolProperty: bCratesAreSafeOutputHasFired
    /// </summary>
    public unsafe bool bCratesAreSafeOutputHasFired
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 492) & 4) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 492); var newMask = value ? (currentMask | 4) : (currentMask & ~4); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 492); }
    }

    /// <summary>
    /// BoolProperty: bForceAllowAirshipControl
    /// </summary>
    public unsafe bool bForceAllowAirshipControl
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 492) & 8) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 492); var newMask = value ? (currentMask | 8) : (currentMask & ~8); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 492); }
    }

    /// <summary>
    /// BoolProperty: SirenActivated
    /// </summary>
    public unsafe bool SirenActivated
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 492) & 16) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 492); var newMask = value ? (currentMask | 16) : (currentMask & ~16); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 492); }
    }

    /// <summary>
    /// FloatProperty: BobTimer
    /// </summary>
    public unsafe float BobTimer
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 496); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 496); }
    }

    /// <summary>
    /// FloatProperty: fTiltIsSafeForCratesThreshold
    /// </summary>
    public unsafe float fTiltIsSafeForCratesThreshold
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 500); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 500); }
    }

    /// <summary>
    /// ByteProperty: BlimpRenderingDPG
    /// </summary>
    public unsafe BmSDK.Engine.Scene.ESceneDepthPriorityGroup BlimpRenderingDPG
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.Scene.ESceneDepthPriorityGroup>(Ptr + 504); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 504); }
    }

    /// <summary>
    /// StructProperty: XAxisBob
    /// </summary>
    public unsafe BmSDK.BmGame.RSeqAct_AirshipBobbingBase.FAxisBobSettings XAxisBob
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSeqAct_AirshipBobbingBase.FAxisBobSettings>(Ptr + 508); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 508); }
    }

    /// <summary>
    /// StructProperty: YAxisBob
    /// </summary>
    public unsafe BmSDK.BmGame.RSeqAct_AirshipBobbingBase.FAxisBobSettings YAxisBob
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSeqAct_AirshipBobbingBase.FAxisBobSettings>(Ptr + 528); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 528); }
    }

    /// <summary>
    /// StructProperty: ZAxisBob
    /// </summary>
    public unsafe BmSDK.BmGame.RSeqAct_AirshipBobbingBase.FAxisBobSettings ZAxisBob
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSeqAct_AirshipBobbingBase.FAxisBobSettings>(Ptr + 548); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 548); }
    }

    /// <summary>
    /// FloatProperty: TiltAccel
    /// </summary>
    public unsafe float TiltAccel
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 568); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 568); }
    }

    /// <summary>
    /// FloatProperty: TiltMaxSpeed
    /// </summary>
    public unsafe float TiltMaxSpeed
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 572); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 572); }
    }

    /// <summary>
    /// FloatProperty: TiltExponentialDamping
    /// </summary>
    public unsafe float TiltExponentialDamping
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 576); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 576); }
    }

    /// <summary>
    /// FloatProperty: CameraTiltProp
    /// </summary>
    public unsafe float CameraTiltProp
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 580); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 580); }
    }

    /// <summary>
    /// FloatProperty: MaxManualTilt
    /// </summary>
    public unsafe float MaxManualTilt
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 584); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 584); }
    }

    /// <summary>
    /// FloatProperty: CurrentTiltVelocity
    /// </summary>
    public unsafe float CurrentTiltVelocity
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 588); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 588); }
    }

    /// <summary>
    /// FloatProperty: CurrentManualTilt
    /// </summary>
    public unsafe float CurrentManualTilt
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 592); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 592); }
    }

    /// <summary>
    /// FloatProperty: DesiredManualTilt
    /// </summary>
    public unsafe float DesiredManualTilt
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 596); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 596); }
    }

    /// <summary>
    /// FloatProperty: SirenDeactivateDelay
    /// </summary>
    public unsafe float SirenDeactivateDelay
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 600); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 600); }
    }

    /// <summary>
    /// ArrayProperty: ForceFieldDefaultForce
    /// </summary>
    public unsafe BmSDK.TArray<System.Numerics.Vector3> ForceFieldDefaultForce
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<System.Numerics.Vector3>>(Ptr + 604); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 604); }
    }
}
