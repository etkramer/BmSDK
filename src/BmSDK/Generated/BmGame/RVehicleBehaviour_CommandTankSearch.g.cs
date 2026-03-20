#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RVehicleBehaviour_CommandTankSearch<br/>
/// (flags = 0)
/// </summary>
public partial class RVehicleBehaviour_CommandTankSearch : BmSDK.BmGame.RVehicleBehaviour_HeavyTankSearch, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RVehicleBehaviour_CommandTankSearch", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RVehicleBehaviour_CommandTankSearch() { }

    /// <summary>
    /// Constructs a new RVehicleBehaviour_CommandTankSearch
    /// </summary>
    public RVehicleBehaviour_CommandTankSearch(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RVehicleBehaviour_CommandTankSearch Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RVehicleBehaviour_CommandTankSearch(nint ptr) : base(ptr) { }

    /// <summary>
    /// BoolProperty: bCloudburstVulnerable
    /// </summary>
    public unsafe bool bCloudburstVulnerable
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1008) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1008); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1008); }
    }

    /// <summary>
    /// BoolProperty: bFindNewSearchTarget
    /// </summary>
    public unsafe bool bFindNewSearchTarget
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1008) & 2) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1008); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1008); }
    }

    /// <summary>
    /// BoolProperty: FinalStage
    /// </summary>
    public unsafe bool FinalStage
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1008) & 4) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1008); var newMask = value ? (currentMask | 4) : (currentMask & ~4); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1008); }
    }

    /// <summary>
    /// BoolProperty: bStartOverchargeChase
    /// </summary>
    public unsafe bool bStartOverchargeChase
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1008) & 8) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1008); var newMask = value ? (currentMask | 8) : (currentMask & ~8); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1008); }
    }

    /// <summary>
    /// BoolProperty: bAddedTunnelVolumesToRestrictions
    /// </summary>
    public unsafe bool bAddedTunnelVolumesToRestrictions
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1008) & 16) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1008); var newMask = value ? (currentMask | 16) : (currentMask & ~16); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1008); }
    }

    /// <summary>
    /// ArrayProperty: SearchPoints
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.Engine.Actor> SearchPoints
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.Actor>>(Ptr + 1012); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1012); }
    }

    /// <summary>
    /// StructProperty: SearchLocation
    /// </summary>
    public unsafe System.Numerics.Vector3 SearchLocation
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 1028); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1028); }
    }

    /// <summary>
    /// FloatProperty: OneShotLineDelayMin
    /// </summary>
    public unsafe float OneShotLineDelayMin
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1040); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1040); }
    }

    /// <summary>
    /// FloatProperty: OneShotLineDelayMax
    /// </summary>
    public unsafe float OneShotLineDelayMax
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1044); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1044); }
    }

    /// <summary>
    /// FloatProperty: OneShotTickDown
    /// </summary>
    public unsafe float OneShotTickDown
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1048); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1048); }
    }

    /// <summary>
    /// ArrayProperty: StageScan360Period
    /// </summary>
    public unsafe BmSDK.TArray<float> StageScan360Period
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<float>>(Ptr + 1052); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1052); }
    }

    /// <summary>
    /// ArrayProperty: ChaseTimes
    /// </summary>
    public unsafe BmSDK.TArray<float> ChaseTimes
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<float>>(Ptr + 1068); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1068); }
    }

    /// <summary>
    /// ArrayProperty: WeakPointOutputLinks
    /// </summary>
    public unsafe BmSDK.TArray<int> WeakPointOutputLinks
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<int>>(Ptr + 1084); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1084); }
    }

    /// <summary>
    /// StructProperty: ThrottleVsDistCurve
    /// </summary>
    public unsafe BmSDK.GameObject.FInterpCurveFloat ThrottleVsDistCurve
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.GameObject.FInterpCurveFloat>(Ptr + 1100); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1100); }
    }

    /// <summary>
    /// FloatProperty: ChaseStartTime
    /// </summary>
    public unsafe float ChaseStartTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1120); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1120); }
    }

    /// <summary>
    /// ObjectProperty: BossModule
    /// </summary>
    public unsafe BmSDK.BmGame.RHudModuleBoss BossModule
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RHudModuleBoss>(Ptr + 1124); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1124); }
    }

    /// <summary>
    /// FloatProperty: RunningAwayDuration
    /// </summary>
    public unsafe float RunningAwayDuration
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1132); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1132); }
    }

    /// <summary>
    /// FloatProperty: AlertTimer
    /// </summary>
    public unsafe float AlertTimer
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1136); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1136); }
    }

    /// <summary>
    /// ArrayProperty: TunnelVolumes
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.Engine.Volume> TunnelVolumes
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.Volume>>(Ptr + 1140); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1140); }
    }
}
