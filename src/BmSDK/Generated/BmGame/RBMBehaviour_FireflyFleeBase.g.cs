#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RBMBehaviour_FireflyFleeBase<br/>
/// (size = 0)
/// (flags = 0)
/// </summary>
public partial class RBMBehaviour_FireflyFleeBase : BmSDK.BmGame.RBMBehaviour_MoveToBase, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RBMBehaviour_FireflyFleeBase", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RBMBehaviour_FireflyFleeBase() { }

    /// <summary>
    /// Constructs a new RBMBehaviour_FireflyFleeBase
    /// </summary>
    public RBMBehaviour_FireflyFleeBase(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RBMBehaviour_FireflyFleeBase Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RBMBehaviour_FireflyFleeBase(nint ptr) : base(ptr) { }

    /// <summary>
    /// FloatProperty: distLaggingBehind
    /// </summary>
    public unsafe float distLaggingBehind
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 648); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 648); }
    }

    /// <summary>
    /// StructProperty: CurrentVelocity
    /// </summary>
    public unsafe System.Numerics.Vector3 CurrentVelocity
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 652); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 652); }
    }

    /// <summary>
    /// FloatProperty: minDistFromPlayer_initial
    /// </summary>
    public unsafe float minDistFromPlayer_initial
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 664); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 664); }
    }

    /// <summary>
    /// FloatProperty: minDistFromPlayer_final
    /// </summary>
    public unsafe float minDistFromPlayer_final
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 668); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 668); }
    }

    /// <summary>
    /// FloatProperty: ffCruisingSpeedSettings
    /// </summary>
    public unsafe float ffCruisingSpeedSettings_0
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 672); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 672); }
    }
    /// <summary>
    /// FloatProperty: ffCruisingSpeedSettings
    /// </summary>
    public unsafe float ffCruisingSpeedSettings_1
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 676); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 676); }
    }
    /// <summary>
    /// FloatProperty: ffCruisingSpeedSettings
    /// </summary>
    public unsafe float ffCruisingSpeedSettings_2
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 680); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 680); }
    }

    /// <summary>
    /// FloatProperty: ffCruisingSpeed
    /// </summary>
    public unsafe float ffCruisingSpeed
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 684); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 684); }
    }

    /// <summary>
    /// FloatProperty: ffEvasionSpeed
    /// </summary>
    public unsafe float ffEvasionSpeed
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 688); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 688); }
    }

    /// <summary>
    /// FloatProperty: slowCruisingSpeedProportion
    /// </summary>
    public unsafe float slowCruisingSpeedProportion
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 692); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 692); }
    }

    /// <summary>
    /// FloatProperty: ffSlowCruisingSpeed
    /// </summary>
    public unsafe float ffSlowCruisingSpeed
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 696); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 696); }
    }

    /// <summary>
    /// FloatProperty: ffOutOfFuelSpeed
    /// </summary>
    public unsafe float ffOutOfFuelSpeed
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 700); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 700); }
    }

    /// <summary>
    /// FloatProperty: allowSideRoadsChanceSettings
    /// </summary>
    public unsafe float allowSideRoadsChanceSettings_0
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 704); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 704); }
    }
    /// <summary>
    /// FloatProperty: allowSideRoadsChanceSettings
    /// </summary>
    public unsafe float allowSideRoadsChanceSettings_1
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 708); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 708); }
    }
    /// <summary>
    /// FloatProperty: allowSideRoadsChanceSettings
    /// </summary>
    public unsafe float allowSideRoadsChanceSettings_2
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 712); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 712); }
    }

    /// <summary>
    /// FloatProperty: allowSideRoadsChance
    /// </summary>
    public unsafe float allowSideRoadsChance
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 716); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 716); }
    }

    /// <summary>
    /// FloatProperty: speedBoostDecayTime
    /// </summary>
    public unsafe float speedBoostDecayTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 720); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 720); }
    }

    /// <summary>
    /// FloatProperty: takedownPromptRange
    /// </summary>
    public unsafe float takedownPromptRange
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 724); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 724); }
    }

    /// <summary>
    /// FloatProperty: takedownRange
    /// </summary>
    public unsafe float takedownRange
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 728); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 728); }
    }

    /// <summary>
    /// FloatProperty: failDistance
    /// </summary>
    public unsafe float failDistance
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 732); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 732); }
    }

    /// <summary>
    /// FloatProperty: WaitTime
    /// </summary>
    public unsafe float WaitTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 736); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 736); }
    }

    /// <summary>
    /// ObjectProperty: FF
    /// </summary>
    public unsafe BmSDK.BmGame.RPawnBossFireflyBase FF
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPawnBossFireflyBase>(Ptr + 740); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 740); }
    }

    /// <summary>
    /// ObjectProperty: TheMovieInstance
    /// </summary>
    public unsafe BmSDK.GFxUI.SwfMovie TheMovieInstance
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.GFxUI.SwfMovie>(Ptr + 748); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 748); }
    }

    /// <summary>
    /// FloatProperty: TimeRunning
    /// </summary>
    public unsafe float TimeRunning
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 756); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 756); }
    }

    /// <summary>
    /// FloatProperty: currentMinDistFromPlayer
    /// </summary>
    public unsafe float currentMinDistFromPlayer
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 760); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 760); }
    }

    /// <summary>
    /// FloatProperty: prevMaxSpeed
    /// </summary>
    public unsafe float prevMaxSpeed
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 764); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 764); }
    }

    /// <summary>
    /// FloatProperty: movementStartTime
    /// </summary>
    public unsafe float movementStartTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 768); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 768); }
    }

    /// <summary>
    /// FloatProperty: timeBetweenBombs_Min
    /// </summary>
    public unsafe float timeBetweenBombs_Min
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 772); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 772); }
    }

    /// <summary>
    /// FloatProperty: timeBetweenBombs_Max
    /// </summary>
    public unsafe float timeBetweenBombs_Max
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 776); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 776); }
    }

    /// <summary>
    /// FloatProperty: bombDamageAmount
    /// </summary>
    public unsafe float bombDamageAmount
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 780); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 780); }
    }

    /// <summary>
    /// FloatProperty: FFBombBlastRadius
    /// </summary>
    public unsafe float FFBombBlastRadius
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 784); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 784); }
    }

    /// <summary>
    /// FloatProperty: FFBombBlastRadius_Multibomb
    /// </summary>
    public unsafe float FFBombBlastRadius_Multibomb
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 788); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 788); }
    }

    /// <summary>
    /// FloatProperty: timeTillNextBomb
    /// </summary>
    public unsafe float timeTillNextBomb
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 792); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 792); }
    }

    /// <summary>
    /// IntProperty: BombDropDirection
    /// </summary>
    public unsafe int BombDropDirection
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 796); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 796); }
    }

    /// <summary>
    /// IntProperty: multiBombBurstCount
    /// </summary>
    public unsafe int multiBombBurstCount
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 800); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 800); }
    }

    /// <summary>
    /// FloatProperty: multiBombInterval
    /// </summary>
    public unsafe float multiBombInterval
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 804); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 804); }
    }

    /// <summary>
    /// FloatProperty: minTimeBetweenMultiBombRuns
    /// </summary>
    public unsafe float minTimeBetweenMultiBombRuns
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 808); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 808); }
    }

    /// <summary>
    /// FloatProperty: lastMultiBombRunStartTime
    /// </summary>
    public unsafe float lastMultiBombRunStartTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 812); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 812); }
    }

    /// <summary>
    /// IntProperty: multiBombNumRemaining
    /// </summary>
    public unsafe int multiBombNumRemaining
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 816); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 816); }
    }

    /// <summary>
    /// FloatProperty: bombs_LaunchVel
    /// </summary>
    public unsafe float bombs_LaunchVel
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 820); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 820); }
    }

    /// <summary>
    /// IntProperty: bombs_numSpansAhead
    /// </summary>
    public unsafe int bombs_numSpansAhead
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 824); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 824); }
    }

    /// <summary>
    /// FloatProperty: bombs_minRoadWidth
    /// </summary>
    public unsafe float bombs_minRoadWidth
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 828); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 828); }
    }

    /// <summary>
    /// FloatProperty: bombs_DistFromRoadEdge
    /// </summary>
    public unsafe float bombs_DistFromRoadEdge
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 832); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 832); }
    }

    /// <summary>
    /// FloatProperty: bombs_maxDistFromCentre
    /// </summary>
    public unsafe float bombs_maxDistFromCentre
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 836); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 836); }
    }

    /// <summary>
    /// BoolProperty: bombs_CanDoSingleBomb
    /// </summary>
    public unsafe bool bombs_CanDoSingleBomb
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 840) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 840); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 840); }
    }

    /// <summary>
    /// BoolProperty: bombs_CanDoMultiBomb
    /// </summary>
    public unsafe bool bombs_CanDoMultiBomb
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 840) & 2) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 840); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 840); }
    }

    /// <summary>
    /// BoolProperty: bDbgDrawHistory
    /// </summary>
    public unsafe bool bDbgDrawHistory
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 840) & 4) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 840); var newMask = value ? (currentMask | 4) : (currentMask & ~4); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 840); }
    }

    /// <summary>
    /// BoolProperty: bDbgDrawAccelTo
    /// </summary>
    public unsafe bool bDbgDrawAccelTo
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 840) & 8) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 840); var newMask = value ? (currentMask | 8) : (currentMask & ~8); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 840); }
    }

    /// <summary>
    /// BoolProperty: bDbgDrawAccelToPersistent
    /// </summary>
    public unsafe bool bDbgDrawAccelToPersistent
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 840) & 16) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 840); var newMask = value ? (currentMask | 16) : (currentMask & ~16); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 840); }
    }

    /// <summary>
    /// BoolProperty: bDbgDrawColToggle
    /// </summary>
    public unsafe bool bDbgDrawColToggle
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 840) & 32) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 840); var newMask = value ? (currentMask | 32) : (currentMask & ~32); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 840); }
    }

    /// <summary>
    /// BoolProperty: bDbgDrawRoute
    /// </summary>
    public unsafe bool bDbgDrawRoute
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 840) & 64) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 840); var newMask = value ? (currentMask | 64) : (currentMask & ~64); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 840); }
    }

    /// <summary>
    /// BoolProperty: bDbgDrawSpans
    /// </summary>
    public unsafe bool bDbgDrawSpans
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 840) & 128) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 840); var newMask = value ? (currentMask | 128) : (currentMask & ~128); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 840); }
    }

    /// <summary>
    /// BoolProperty: bDbgDrawRacingLine
    /// </summary>
    public unsafe bool bDbgDrawRacingLine
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 840) & 256) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 840); var newMask = value ? (currentMask | 256) : (currentMask & ~256); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 840); }
    }

    /// <summary>
    /// BoolProperty: bDbgDrawDistFromPlayer
    /// </summary>
    public unsafe bool bDbgDrawDistFromPlayer
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 840) & 512) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 840); var newMask = value ? (currentMask | 512) : (currentMask & ~512); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 840); }
    }

    /// <summary>
    /// BoolProperty: bDbgDrawBombs
    /// </summary>
    public unsafe bool bDbgDrawBombs
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 840) & 1024) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 840); var newMask = value ? (currentMask | 1024) : (currentMask & ~1024); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 840); }
    }

    /// <summary>
    /// BoolProperty: bDbgDrawRefineParams
    /// </summary>
    public unsafe bool bDbgDrawRefineParams
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 840) & 2048) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 840); var newMask = value ? (currentMask | 2048) : (currentMask & ~2048); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 840); }
    }

    /// <summary>
    /// BoolProperty: bDbgRefineUseCurrentLoc
    /// </summary>
    public unsafe bool bDbgRefineUseCurrentLoc
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 840) & 4096) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 840); var newMask = value ? (currentMask | 4096) : (currentMask & ~4096); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 840); }
    }

    /// <summary>
    /// BoolProperty: bDbgRefineUseFutureLoc
    /// </summary>
    public unsafe bool bDbgRefineUseFutureLoc
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 840) & 8192) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 840); var newMask = value ? (currentMask | 8192) : (currentMask & ~8192); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 840); }
    }

    /// <summary>
    /// BoolProperty: bDbgNoBombs
    /// </summary>
    public unsafe bool bDbgNoBombs
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 840) & 16384) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 840); var newMask = value ? (currentMask | 16384) : (currentMask & ~16384); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 840); }
    }

    /// <summary>
    /// BoolProperty: BMHasLOSToFF
    /// </summary>
    public unsafe bool BMHasLOSToFF
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 840) & 32768) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 840); var newMask = value ? (currentMask | 32768) : (currentMask & ~32768); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 840); }
    }

    /// <summary>
    /// BoolProperty: bTakedownStarted
    /// </summary>
    public unsafe bool bTakedownStarted
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 840) & 65536) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 840); var newMask = value ? (currentMask | 65536) : (currentMask & ~65536); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 840); }
    }

    /// <summary>
    /// ArrayProperty: bombs_MultiBombFutureTargets
    /// </summary>
    public unsafe BmSDK.TArray<System.Numerics.Vector3> bombs_MultiBombFutureTargets
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<System.Numerics.Vector3>>(Ptr + 844); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 844); }
    }

    /// <summary>
    /// FloatProperty: boostProportion
    /// </summary>
    public unsafe float boostProportion
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 860); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 860); }
    }
}
