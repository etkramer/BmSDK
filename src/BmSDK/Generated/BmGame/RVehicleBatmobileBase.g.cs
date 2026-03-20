#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RVehicleBatmobileBase<br/>
/// (size = 0)
/// (flags = 0)
/// </summary>
public partial class RVehicleBatmobileBase : BmSDK.BmGame.RVehicle, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RVehicleBatmobileBase", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RVehicleBatmobileBase() { }

    /// <summary>
    /// Constructs a new RVehicleBatmobileBase
    /// </summary>
    public RVehicleBatmobileBase(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RVehicleBatmobileBase Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RVehicleBatmobileBase(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="Engine.Actor.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RVehicleBatmobileBase>
        => ((Engine.Actor)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="Engine.Actor.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RVehicleBatmobileBase>, new()
        => (TComponent)((Engine.Actor)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="Engine.Actor.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RVehicleBatmobileBase>
        => ((Engine.Actor)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="Engine.Actor.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RVehicleBatmobileBase>
        => ((Engine.Actor)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="Engine.Actor.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RVehicleBatmobileBase>
        => (TComponent)((Engine.Actor)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="Engine.Actor.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RVehicleBatmobileBase>
        => ((Engine.Actor)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="Engine.Actor.DetachScriptComponent(Type)"/>
    public void DetachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RVehicleBatmobileBase>
        => ((Engine.Actor)this).DetachScriptComponent(typeof(TComponent));

    /// <summary>
    /// StructProperty: VfTable_IRSpotableInterface
    /// </summary>
    public unsafe System.IntPtr VfTable_IRSpotableInterface
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.IntPtr>(Ptr + 4560); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4560); }
    }

    /// <summary>
    /// BoolProperty: RollingStart
    /// </summary>
    public unsafe bool RollingStart
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4568) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4568); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 4568); }
    }

    /// <summary>
    /// BoolProperty: ArmouredMode
    /// </summary>
    public unsafe bool ArmouredMode
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4568) & 2) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4568); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 4568); }
    }

    /// <summary>
    /// BoolProperty: ArmouredModeOld
    /// </summary>
    public unsafe bool ArmouredModeOld
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4568) & 4) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4568); var newMask = value ? (currentMask | 4) : (currentMask & ~4); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 4568); }
    }

    /// <summary>
    /// BoolProperty: bTransforming
    /// </summary>
    public unsafe bool bTransforming
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4568) & 8) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4568); var newMask = value ? (currentMask | 8) : (currentMask & ~8); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 4568); }
    }

    /// <summary>
    /// BoolProperty: bWeaponsReady
    /// </summary>
    public unsafe bool bWeaponsReady
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4568) & 16) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4568); var newMask = value ? (currentMask | 16) : (currentMask & ~16); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 4568); }
    }

    /// <summary>
    /// BoolProperty: KismetForceWheelspin
    /// </summary>
    public unsafe bool KismetForceWheelspin
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4568) & 32) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4568); var newMask = value ? (currentMask | 32) : (currentMask & ~32); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 4568); }
    }

    /// <summary>
    /// BoolProperty: StopBoxForceWheelspin
    /// </summary>
    public unsafe bool StopBoxForceWheelspin
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4568) & 64) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4568); var newMask = value ? (currentMask | 64) : (currentMask & ~64); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 4568); }
    }

    /// <summary>
    /// BoolProperty: WallScrapeL
    /// </summary>
    public unsafe bool WallScrapeL
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4568) & 128) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4568); var newMask = value ? (currentMask | 128) : (currentMask & ~128); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 4568); }
    }

    /// <summary>
    /// BoolProperty: WallScrapeR
    /// </summary>
    public unsafe bool WallScrapeR
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4568) & 256) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4568); var newMask = value ? (currentMask | 256) : (currentMask & ~256); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 4568); }
    }

    /// <summary>
    /// BoolProperty: EnemyTaunt_DebugVisualisation
    /// </summary>
    public unsafe bool EnemyTaunt_DebugVisualisation
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4568) & 512) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4568); var newMask = value ? (currentMask | 512) : (currentMask & ~512); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 4568); }
    }

    /// <summary>
    /// BoolProperty: AudioPlayingIn
    /// </summary>
    public unsafe bool AudioPlayingIn
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4568) & 1024) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4568); var newMask = value ? (currentMask | 1024) : (currentMask & ~1024); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 4568); }
    }

    /// <summary>
    /// BoolProperty: bIsPrototypeBatmobile
    /// </summary>
    public unsafe bool bIsPrototypeBatmobile
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4568) & 2048) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4568); var newMask = value ? (currentMask | 2048) : (currentMask & ~2048); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 4568); }
    }

    /// <summary>
    /// BoolProperty: bIsJokerfiedBatmobile
    /// </summary>
    public unsafe bool bIsJokerfiedBatmobile
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4568) & 4096) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4568); var newMask = value ? (currentMask | 4096) : (currentMask & ~4096); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 4568); }
    }

    /// <summary>
    /// BoolProperty: AbseilBlocked
    /// </summary>
    public unsafe bool AbseilBlocked
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4568) & 8192) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4568); var newMask = value ? (currentMask | 8192) : (currentMask & ~8192); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 4568); }
    }

    /// <summary>
    /// BoolProperty: bBoostLocked
    /// </summary>
    public unsafe bool bBoostLocked
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4568) & 16384) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4568); var newMask = value ? (currentMask | 16384) : (currentMask & ~16384); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 4568); }
    }

    /// <summary>
    /// BoolProperty: bBattleModeLocked
    /// </summary>
    public unsafe bool bBattleModeLocked
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4568) & 32768) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4568); var newMask = value ? (currentMask | 32768) : (currentMask & ~32768); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 4568); }
    }

    /// <summary>
    /// BoolProperty: bLockInBattleMode
    /// </summary>
    public unsafe bool bLockInBattleMode
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4568) & 65536) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4568); var newMask = value ? (currentMask | 65536) : (currentMask & ~65536); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 4568); }
    }

    /// <summary>
    /// BoolProperty: ForceHeadlightsSwitchedOn
    /// </summary>
    public unsafe bool ForceHeadlightsSwitchedOn
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4568) & 131072) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4568); var newMask = value ? (currentMask | 131072) : (currentMask & ~131072); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 4568); }
    }

    /// <summary>
    /// BoolProperty: bFailedWeaponFlag
    /// </summary>
    public unsafe bool bFailedWeaponFlag
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4568) & 262144) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4568); var newMask = value ? (currentMask | 262144) : (currentMask & ~262144); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 4568); }
    }

    /// <summary>
    /// BoolProperty: bCockpitOpen
    /// </summary>
    public unsafe bool bCockpitOpen
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4568) & 524288) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4568); var newMask = value ? (currentMask | 524288) : (currentMask & ~524288); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 4568); }
    }

    /// <summary>
    /// BoolProperty: AudioClutch
    /// </summary>
    public unsafe bool AudioClutch
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4568) & 1048576) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4568); var newMask = value ? (currentMask | 1048576) : (currentMask & ~1048576); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 4568); }
    }

    /// <summary>
    /// BoolProperty: SatNavChallengeActive
    /// </summary>
    public unsafe bool SatNavChallengeActive
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4568) & 2097152) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4568); var newMask = value ? (currentMask | 2097152) : (currentMask & ~2097152); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 4568); }
    }

    /// <summary>
    /// BoolProperty: SelfDriveAllowBoost
    /// </summary>
    public unsafe bool SelfDriveAllowBoost
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4568) & 4194304) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4568); var newMask = value ? (currentMask | 4194304) : (currentMask & ~4194304); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 4568); }
    }

    /// <summary>
    /// BoolProperty: SelfDriveUturn
    /// </summary>
    public unsafe bool SelfDriveUturn
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4568) & 8388608) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4568); var newMask = value ? (currentMask | 8388608) : (currentMask & ~8388608); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 4568); }
    }

    /// <summary>
    /// BoolProperty: bRemoteDrive
    /// </summary>
    public unsafe bool bRemoteDrive
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4568) & 16777216) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4568); var newMask = value ? (currentMask | 16777216) : (currentMask & ~16777216); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 4568); }
    }

    /// <summary>
    /// BoolProperty: bFakeRemoteDrive
    /// </summary>
    public unsafe bool bFakeRemoteDrive
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4568) & 33554432) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4568); var newMask = value ? (currentMask | 33554432) : (currentMask & ~33554432); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 4568); }
    }

    /// <summary>
    /// BoolProperty: bRemoteScoopUp
    /// </summary>
    public unsafe bool bRemoteScoopUp
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4568) & 67108864) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4568); var newMask = value ? (currentMask | 67108864) : (currentMask & ~67108864); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 4568); }
    }

    /// <summary>
    /// BoolProperty: bWasRemoteDriving
    /// </summary>
    public unsafe bool bWasRemoteDriving
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4568) & 134217728) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4568); var newMask = value ? (currentMask | 134217728) : (currentMask & ~134217728); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 4568); }
    }

    /// <summary>
    /// BoolProperty: bRemoteDriveBatmanTrackerDisabled
    /// </summary>
    public unsafe bool bRemoteDriveBatmanTrackerDisabled
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4568) & 268435456) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4568); var newMask = value ? (currentMask | 268435456) : (currentMask & ~268435456); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 4568); }
    }

    /// <summary>
    /// BoolProperty: InfiniteBoost
    /// </summary>
    public unsafe bool InfiniteBoost
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4568) & 536870912) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4568); var newMask = value ? (currentMask | 536870912) : (currentMask & ~536870912); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 4568); }
    }

    /// <summary>
    /// BoolProperty: DisabledByEMP
    /// </summary>
    public unsafe bool DisabledByEMP
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4568) & 1073741824) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4568); var newMask = value ? (currentMask | 1073741824) : (currentMask & ~1073741824); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 4568); }
    }

    /// <summary>
    /// BoolProperty: VulnerableToEMP
    /// </summary>
    public unsafe bool VulnerableToEMP
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4568) & -2147483648) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4568); var newMask = value ? (currentMask | -2147483648) : (currentMask & ~-2147483648); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 4568); }
    }

    /// <summary>
    /// BoolProperty: EMPRepairable
    /// </summary>
    public unsafe bool EMPRepairable
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4572) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4572); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 4572); }
    }

    /// <summary>
    /// BoolProperty: IsStolen
    /// </summary>
    public unsafe bool IsStolen
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4572) & 2) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4572); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 4572); }
    }

    /// <summary>
    /// BoolProperty: DoNotBreakRemoteControlIfBatmanInCombat
    /// </summary>
    public unsafe bool DoNotBreakRemoteControlIfBatmanInCombat
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4572) & 4) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4572); var newMask = value ? (currentMask | 4) : (currentMask & ~4); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 4572); }
    }

    /// <summary>
    /// BoolProperty: CurrentStrafeTargetOnRight
    /// </summary>
    public unsafe bool CurrentStrafeTargetOnRight
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4572) & 8) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4572); var newMask = value ? (currentMask | 8) : (currentMask & ~8); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 4572); }
    }

    /// <summary>
    /// BoolProperty: SideSwipeInSweetSpot
    /// </summary>
    public unsafe bool SideSwipeInSweetSpot
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4572) & 16) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4572); var newMask = value ? (currentMask | 16) : (currentMask & ~16); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 4572); }
    }

    /// <summary>
    /// BoolProperty: RemoteTeleported
    /// </summary>
    public unsafe bool RemoteTeleported
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4572) & 32) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4572); var newMask = value ? (currentMask | 32) : (currentMask & ~32); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 4572); }
    }

    /// <summary>
    /// BoolProperty: bControlledBySeqAct
    /// </summary>
    public unsafe bool bControlledBySeqAct
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4572) & 64) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4572); var newMask = value ? (currentMask | 64) : (currentMask & ~64); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 4572); }
    }

    /// <summary>
    /// BoolProperty: bForceBattleModeMovement
    /// </summary>
    public unsafe bool bForceBattleModeMovement
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4572) & 128) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4572); var newMask = value ? (currentMask | 128) : (currentMask & ~128); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 4572); }
    }

    /// <summary>
    /// BoolProperty: bDisableProximityPickup
    /// </summary>
    public unsafe bool bDisableProximityPickup
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4572) & 256) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4572); var newMask = value ? (currentMask | 256) : (currentMask & ~256); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 4572); }
    }

    /// <summary>
    /// BoolProperty: bDebugAdjustedAvoidanceDirection
    /// </summary>
    public unsafe bool bDebugAdjustedAvoidanceDirection
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4572) & 512) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4572); var newMask = value ? (currentMask | 512) : (currentMask & ~512); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 4572); }
    }

    /// <summary>
    /// BoolProperty: RemoteCallIn
    /// </summary>
    public unsafe bool RemoteCallIn
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4572) & 1024) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4572); var newMask = value ? (currentMask | 1024) : (currentMask & ~1024); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 4572); }
    }

    /// <summary>
    /// BoolProperty: OverrideSkidToStopYaw
    /// </summary>
    public unsafe bool OverrideSkidToStopYaw
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4572) & 2048) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4572); var newMask = value ? (currentMask | 2048) : (currentMask & ~2048); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 4572); }
    }

    /// <summary>
    /// BoolProperty: bPMWeaponWarning
    /// </summary>
    public unsafe bool bPMWeaponWarning
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4572) & 4096) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4572); var newMask = value ? (currentMask | 4096) : (currentMask & ~4096); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 4572); }
    }

    /// <summary>
    /// BoolProperty: ForcedFixedTimeDelta
    /// </summary>
    public unsafe bool ForcedFixedTimeDelta
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4572) & 8192) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4572); var newMask = value ? (currentMask | 8192) : (currentMask & ~8192); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 4572); }
    }

    /// <summary>
    /// BoolProperty: DisableWeaponWarnings
    /// </summary>
    public unsafe bool DisableWeaponWarnings
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4572) & 16384) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4572); var newMask = value ? (currentMask | 16384) : (currentMask & ~16384); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 4572); }
    }

    /// <summary>
    /// BoolProperty: BatmobileHitWater
    /// </summary>
    public unsafe bool BatmobileHitWater
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4572) & 32768) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4572); var newMask = value ? (currentMask | 32768) : (currentMask & ~32768); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 4572); }
    }

    /// <summary>
    /// BoolProperty: BatmobileAboveOceanLevel
    /// </summary>
    public unsafe bool BatmobileAboveOceanLevel
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4572) & 65536) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4572); var newMask = value ? (currentMask | 65536) : (currentMask & ~65536); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 4572); }
    }

    /// <summary>
    /// BoolProperty: BatmobileAboutToHitWater
    /// </summary>
    public unsafe bool BatmobileAboutToHitWater
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4572) & 131072) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4572); var newMask = value ? (currentMask | 131072) : (currentMask & ~131072); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 4572); }
    }

    /// <summary>
    /// BoolProperty: BatmobileAboutToAboveOceanLevel
    /// </summary>
    public unsafe bool BatmobileAboutToAboveOceanLevel
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4572) & 262144) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4572); var newMask = value ? (currentMask | 262144) : (currentMask & ~262144); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 4572); }
    }

    /// <summary>
    /// BoolProperty: SceneryCollisionDisabled
    /// </summary>
    public unsafe bool SceneryCollisionDisabled
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4572) & 524288) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4572); var newMask = value ? (currentMask | 524288) : (currentMask & ~524288); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 4572); }
    }

    /// <summary>
    /// BoolProperty: DisableFallOutOfWorldLogic
    /// </summary>
    public unsafe bool DisableFallOutOfWorldLogic
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4572) & 1048576) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4572); var newMask = value ? (currentMask | 1048576) : (currentMask & ~1048576); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 4572); }
    }

    /// <summary>
    /// BoolProperty: RemoteSafePointBlocked
    /// </summary>
    public unsafe bool RemoteSafePointBlocked
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4572) & 2097152) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4572); var newMask = value ? (currentMask | 2097152) : (currentMask & ~2097152); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 4572); }
    }

    /// <summary>
    /// BoolProperty: CheatBatmobilePower
    /// </summary>
    public unsafe bool CheatBatmobilePower
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4572) & 4194304) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4572); var newMask = value ? (currentMask | 4194304) : (currentMask & ~4194304); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 4572); }
    }

    /// <summary>
    /// BoolProperty: PingHushCamera
    /// </summary>
    public unsafe bool PingHushCamera
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4572) & 8388608) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4572); var newMask = value ? (currentMask | 8388608) : (currentMask & ~8388608); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 4572); }
    }

    /// <summary>
    /// BoolProperty: CheatIgnoreCollisionLeft
    /// </summary>
    public unsafe bool CheatIgnoreCollisionLeft
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4572) & 16777216) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4572); var newMask = value ? (currentMask | 16777216) : (currentMask & ~16777216); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 4572); }
    }

    /// <summary>
    /// BoolProperty: CheatIgnoreCollisionRight
    /// </summary>
    public unsafe bool CheatIgnoreCollisionRight
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4572) & 33554432) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4572); var newMask = value ? (currentMask | 33554432) : (currentMask & ~33554432); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 4572); }
    }

    /// <summary>
    /// BoolProperty: bPreventBatmbileExit
    /// </summary>
    public unsafe bool bPreventBatmbileExit
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4572) & 67108864) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4572); var newMask = value ? (currentMask | 67108864) : (currentMask & ~67108864); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 4572); }
    }

    /// <summary>
    /// BoolProperty: bJustLandedJump
    /// </summary>
    public unsafe bool bJustLandedJump
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4572) & 134217728) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4572); var newMask = value ? (currentMask | 134217728) : (currentMask & ~134217728); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 4572); }
    }

    /// <summary>
    /// BoolProperty: PassengerInformationSuppressed
    /// </summary>
    public unsafe bool PassengerInformationSuppressed
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4572) & 268435456) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4572); var newMask = value ? (currentMask | 268435456) : (currentMask & ~268435456); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 4572); }
    }

    /// <summary>
    /// BoolProperty: PassengerInformationSuppressedByFocusDetail
    /// </summary>
    public unsafe bool PassengerInformationSuppressedByFocusDetail
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4572) & 536870912) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4572); var newMask = value ? (currentMask | 536870912) : (currentMask & ~536870912); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 4572); }
    }

    /// <summary>
    /// BoolProperty: DisableJumpCamera
    /// </summary>
    public unsafe bool DisableJumpCamera
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4572) & 1073741824) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4572); var newMask = value ? (currentMask | 1073741824) : (currentMask & ~1073741824); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 4572); }
    }

    /// <summary>
    /// BoolProperty: DisableUnderAttackWarning
    /// </summary>
    public unsafe bool DisableUnderAttackWarning
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4572) & -2147483648) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4572); var newMask = value ? (currentMask | -2147483648) : (currentMask & ~-2147483648); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 4572); }
    }

    /// <summary>
    /// BoolProperty: MovementDisabled
    /// </summary>
    public unsafe bool MovementDisabled
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4576) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4576); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 4576); }
    }

    /// <summary>
    /// BoolProperty: bCanGetOutOnLeftSide
    /// </summary>
    public unsafe bool bCanGetOutOnLeftSide
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4576) & 2) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4576); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 4576); }
    }

    /// <summary>
    /// BoolProperty: bDisableBoostOut
    /// </summary>
    public unsafe bool bDisableBoostOut
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4576) & 4) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4576); var newMask = value ? (currentMask | 4) : (currentMask & ~4); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 4576); }
    }

    /// <summary>
    /// BoolProperty: bBattleModeControlled
    /// </summary>
    public unsafe bool bBattleModeControlled
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4576) & 8) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4576); var newMask = value ? (currentMask | 8) : (currentMask & ~8); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 4576); }
    }

    /// <summary>
    /// BoolProperty: DoingEmergencyStop
    /// </summary>
    public unsafe bool DoingEmergencyStop
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4576) & 16) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4576); var newMask = value ? (currentMask | 16) : (currentMask & ~16); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 4576); }
    }

    /// <summary>
    /// BoolProperty: BlockThrottleUntilReleased
    /// </summary>
    public unsafe bool BlockThrottleUntilReleased
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4576) & 32) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4576); var newMask = value ? (currentMask | 32) : (currentMask & ~32); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 4576); }
    }

    /// <summary>
    /// BoolProperty: CanBeCrushed
    /// </summary>
    public unsafe bool CanBeCrushed
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4576) & 64) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4576); var newMask = value ? (currentMask | 64) : (currentMask & ~64); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 4576); }
    }

    /// <summary>
    /// BoolProperty: CrushedThisFrame
    /// </summary>
    public unsafe bool CrushedThisFrame
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4576) & 128) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4576); var newMask = value ? (currentMask | 128) : (currentMask & ~128); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 4576); }
    }

    /// <summary>
    /// BoolProperty: BouncedThisFrame
    /// </summary>
    public unsafe bool BouncedThisFrame
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4576) & 256) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4576); var newMask = value ? (currentMask | 256) : (currentMask & ~256); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 4576); }
    }

    /// <summary>
    /// BoolProperty: bAwardDodgeBonus
    /// </summary>
    public unsafe bool bAwardDodgeBonus
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4576) & 512) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4576); var newMask = value ? (currentMask | 512) : (currentMask & ~512); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 4576); }
    }

    /// <summary>
    /// BoolProperty: bAreKeysBound
    /// </summary>
    public unsafe bool bAreKeysBound
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4576) & 1024) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4576); var newMask = value ? (currentMask | 1024) : (currentMask & ~1024); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 4576); }
    }

    /// <summary>
    /// BoolProperty: bAllowPMDodge
    /// </summary>
    public unsafe bool bAllowPMDodge
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4576) & 2048) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4576); var newMask = value ? (currentMask | 2048) : (currentMask & ~2048); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 4576); }
    }

    /// <summary>
    /// BoolProperty: CameraFollowsRotationForLoopTheLoop
    /// </summary>
    public unsafe bool CameraFollowsRotationForLoopTheLoop
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4576) & 4096) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4576); var newMask = value ? (currentMask | 4096) : (currentMask & ~4096); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 4576); }
    }

    /// <summary>
    /// BoolProperty: bEmergencyWeaponGenerator
    /// </summary>
    public unsafe bool bEmergencyWeaponGenerator
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4576) & 8192) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4576); var newMask = value ? (currentMask | 8192) : (currentMask & ~8192); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 4576); }
    }

    /// <summary>
    /// BoolProperty: bWeaponGeneratorShielding
    /// </summary>
    public unsafe bool bWeaponGeneratorShielding
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4576) & 16384) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4576); var newMask = value ? (currentMask | 16384) : (currentMask & ~16384); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 4576); }
    }

    /// <summary>
    /// BoolProperty: bDoubleDodgeUpgrade
    /// </summary>
    public unsafe bool bDoubleDodgeUpgrade
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4576) & 32768) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4576); var newMask = value ? (currentMask | 32768) : (currentMask & ~32768); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 4576); }
    }

    /// <summary>
    /// BoolProperty: bUsedAirControlDuringJump
    /// </summary>
    public unsafe bool bUsedAirControlDuringJump
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4576) & 65536) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4576); var newMask = value ? (currentMask | 65536) : (currentMask & ~65536); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 4576); }
    }

    /// <summary>
    /// BoolProperty: bRollingPickup
    /// </summary>
    public unsafe bool bRollingPickup
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4576) & 131072) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4576); var newMask = value ? (currentMask | 131072) : (currentMask & ~131072); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 4576); }
    }

    /// <summary>
    /// FloatProperty: StrafeCooldown
    /// </summary>
    public unsafe float StrafeCooldown
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4580); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4580); }
    }

    /// <summary>
    /// FloatProperty: CurrentStrafeCooldown
    /// </summary>
    public unsafe float CurrentStrafeCooldown
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4584); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4584); }
    }

    /// <summary>
    /// StructProperty: StrafeRight
    /// </summary>
    public unsafe System.Numerics.Vector3 StrafeRight
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 4588); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4588); }
    }

    /// <summary>
    /// FloatProperty: StrafeForce
    /// </summary>
    public unsafe float StrafeForce
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4600); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4600); }
    }

    /// <summary>
    /// FloatProperty: StrafeTorque
    /// </summary>
    public unsafe float StrafeTorque
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4604); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4604); }
    }

    /// <summary>
    /// FloatProperty: StrafeDuration
    /// </summary>
    public unsafe float StrafeDuration
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4608); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4608); }
    }

    /// <summary>
    /// FloatProperty: StrafeTime
    /// </summary>
    public unsafe float StrafeTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4612); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4612); }
    }

    /// <summary>
    /// FloatProperty: StrafeFwdCorrectionForce
    /// </summary>
    public unsafe float StrafeFwdCorrectionForce
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4616); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4616); }
    }

    /// <summary>
    /// FloatProperty: EmergencyBrakeTimer
    /// </summary>
    public unsafe float EmergencyBrakeTimer
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4620); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4620); }
    }

    /// <summary>
    /// FloatProperty: EbrakeTime
    /// </summary>
    public unsafe float EbrakeTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4624); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4624); }
    }

    /// <summary>
    /// FloatProperty: EBrakeBrakeForce
    /// </summary>
    public unsafe float EBrakeBrakeForce
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4628); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4628); }
    }

    /// <summary>
    /// FloatProperty: EBrakeAccelForce
    /// </summary>
    public unsafe float EBrakeAccelForce
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4632); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4632); }
    }

    /// <summary>
    /// ComponentProperty: AfterburnerSystem
    /// </summary>
    public unsafe BmSDK.Engine.ParticleSystemComponent AfterburnerSystem
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleSystemComponent>(Ptr + 4636); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4636); }
    }

    /// <summary>
    /// ComponentProperty: AfterburnerWarmupSystem
    /// </summary>
    public unsafe BmSDK.Engine.ParticleSystemComponent AfterburnerWarmupSystem
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleSystemComponent>(Ptr + 4644); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4644); }
    }

    /// <summary>
    /// ComponentProperty: RearFinTrail
    /// </summary>
    public unsafe BmSDK.Engine.ParticleSystemComponent RearFinTrail
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleSystemComponent>(Ptr + 4652); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4652); }
    }

    /// <summary>
    /// ComponentProperty: BrakeLightTrailSystemL
    /// </summary>
    public unsafe BmSDK.Engine.ParticleSystemComponent BrakeLightTrailSystemL
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleSystemComponent>(Ptr + 4660); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4660); }
    }

    /// <summary>
    /// ComponentProperty: BrakeLightTrailSystemR
    /// </summary>
    public unsafe BmSDK.Engine.ParticleSystemComponent BrakeLightTrailSystemR
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleSystemComponent>(Ptr + 4668); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4668); }
    }

    /// <summary>
    /// ComponentProperty: SpeedLinesSystem
    /// </summary>
    public unsafe BmSDK.Engine.ParticleSystemComponent SpeedLinesSystem
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleSystemComponent>(Ptr + 4676); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4676); }
    }

    /// <summary>
    /// ObjectProperty: ExhaustBurstEffect
    /// </summary>
    public unsafe BmSDK.Engine.ParticleSystem ExhaustBurstEffect
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleSystem>(Ptr + 4684); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4684); }
    }

    /// <summary>
    /// ObjectProperty: SideExhaustBurstEffect
    /// </summary>
    public unsafe BmSDK.Engine.ParticleSystem SideExhaustBurstEffect
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleSystem>(Ptr + 4692); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4692); }
    }

    /// <summary>
    /// ObjectProperty: SideExhaustBoostEffect
    /// </summary>
    public unsafe BmSDK.Engine.ParticleSystem SideExhaustBoostEffect
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleSystem>(Ptr + 4700); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4700); }
    }

    /// <summary>
    /// ObjectProperty: ImpactSparks
    /// </summary>
    public unsafe BmSDK.Engine.ParticleSystem ImpactSparks
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleSystem>(Ptr + 4708); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4708); }
    }

    /// <summary>
    /// ObjectProperty: JumpLandSparksEffectL
    /// </summary>
    public unsafe BmSDK.Engine.ParticleSystem JumpLandSparksEffectL
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleSystem>(Ptr + 4716); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4716); }
    }

    /// <summary>
    /// ObjectProperty: JumpLandSparksEffectR
    /// </summary>
    public unsafe BmSDK.Engine.ParticleSystem JumpLandSparksEffectR
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleSystem>(Ptr + 4724); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4724); }
    }

    /// <summary>
    /// ObjectProperty: AbseilSparksEffect
    /// </summary>
    public unsafe BmSDK.Engine.ParticleSystem AbseilSparksEffect
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleSystem>(Ptr + 4732); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4732); }
    }

    /// <summary>
    /// ObjectProperty: AbseilSparksSoundEffect
    /// </summary>
    public unsafe BmSDK.Engine.AkEvent AbseilSparksSoundEffect
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkEvent>(Ptr + 4740); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4740); }
    }

    /// <summary>
    /// ObjectProperty: BurnoutDynamicGridActorTemplate
    /// </summary>
    public unsafe BmSDK.Engine.ApexDynamicGridActor BurnoutDynamicGridActorTemplate
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ApexDynamicGridActor>(Ptr + 4748); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4748); }
    }

    /// <summary>
    /// ObjectProperty: BurnoutDynamicGridActorInstance
    /// </summary>
    public unsafe BmSDK.Engine.ApexDynamicGridActor BurnoutDynamicGridActorInstance
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ApexDynamicGridActor>(Ptr + 4756); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4756); }
    }

    /// <summary>
    /// ObjectProperty: WispyDynamicGridActorTemplate
    /// </summary>
    public unsafe BmSDK.Engine.ApexDynamicGridActor WispyDynamicGridActorTemplate
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ApexDynamicGridActor>(Ptr + 4764); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4764); }
    }

    /// <summary>
    /// ObjectProperty: WispyDynamicGridActorInstance
    /// </summary>
    public unsafe BmSDK.Engine.ApexDynamicGridActor WispyDynamicGridActorInstance
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ApexDynamicGridActor>(Ptr + 4772); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4772); }
    }

    /// <summary>
    /// ObjectProperty: PSMLightTemplate
    /// </summary>
    public unsafe BmSDK.BmGame.RDeferred_SpotLight_Shadowed_Spawnable PSMLightTemplate
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RDeferred_SpotLight_Shadowed_Spawnable>(Ptr + 4780); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4780); }
    }

    /// <summary>
    /// ObjectProperty: PSMLightInstance
    /// </summary>
    public unsafe BmSDK.BmGame.RDeferred_SpotLight_Shadowed_Spawnable PSMLightInstance
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RDeferred_SpotLight_Shadowed_Spawnable>(Ptr + 4788); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4788); }
    }

    /// <summary>
    /// ObjectProperty: PlayerVehicleInfo
    /// </summary>
    public unsafe BmSDK.Engine.AkPlayerVehicleSoundInfo PlayerVehicleInfo
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkPlayerVehicleSoundInfo>(Ptr + 4796); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4796); }
    }

    /// <summary>
    /// ObjectProperty: ExplosiveImpactSound
    /// </summary>
    public unsafe BmSDK.Engine.AkEvent ExplosiveImpactSound
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkEvent>(Ptr + 4804); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4804); }
    }

    /// <summary>
    /// ObjectProperty: SpinningSpikesImpactFX
    /// </summary>
    public unsafe BmSDK.Engine.ParticleSystem SpinningSpikesImpactFX
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleSystem>(Ptr + 4812); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4812); }
    }

    /// <summary>
    /// ObjectProperty: SpinningSpikesImpactSound
    /// </summary>
    public unsafe BmSDK.Engine.AkEvent SpinningSpikesImpactSound
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkEvent>(Ptr + 4820); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4820); }
    }

    /// <summary>
    /// ObjectProperty: TransformationReverseDirectionIntoPursuitModeSound
    /// </summary>
    public unsafe BmSDK.Engine.AkEvent TransformationReverseDirectionIntoPursuitModeSound
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkEvent>(Ptr + 4828); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4828); }
    }

    /// <summary>
    /// ObjectProperty: TransformationReverseDirectionIntoBattleModeSound
    /// </summary>
    public unsafe BmSDK.Engine.AkEvent TransformationReverseDirectionIntoBattleModeSound
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkEvent>(Ptr + 4836); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4836); }
    }

    /// <summary>
    /// ObjectProperty: Transform_In_Bed
    /// </summary>
    public unsafe BmSDK.Engine.AkEvent Transform_In_Bed
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkEvent>(Ptr + 4844); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4844); }
    }

    /// <summary>
    /// ObjectProperty: Transform_In_Reverse_Bed
    /// </summary>
    public unsafe BmSDK.Engine.AkEvent Transform_In_Reverse_Bed
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkEvent>(Ptr + 4852); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4852); }
    }

    /// <summary>
    /// ObjectProperty: Transform_Out_Bed
    /// </summary>
    public unsafe BmSDK.Engine.AkEvent Transform_Out_Bed
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkEvent>(Ptr + 4860); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4860); }
    }

    /// <summary>
    /// ObjectProperty: Transform_Out_Reverse_Bed
    /// </summary>
    public unsafe BmSDK.Engine.AkEvent Transform_Out_Reverse_Bed
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkEvent>(Ptr + 4868); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4868); }
    }

    /// <summary>
    /// ObjectProperty: CurrentWeapon
    /// </summary>
    public unsafe BmSDK.BmGame.RVehicleWeapon CurrentWeapon
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RVehicleWeapon>(Ptr + 4876); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4876); }
    }

    /// <summary>
    /// ObjectProperty: SecondaryWeapon
    /// </summary>
    public unsafe BmSDK.BmGame.RVehicleWeapon SecondaryWeapon
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RVehicleWeapon>(Ptr + 4884); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4884); }
    }

    /// <summary>
    /// ObjectProperty: BatmobileWinch
    /// </summary>
    public unsafe BmSDK.BmGame.RBatmobileWinch BatmobileWinch
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RBatmobileWinch>(Ptr + 4892); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4892); }
    }

    /// <summary>
    /// ObjectProperty: SideSwipeTargetsList
    /// </summary>
    public unsafe BmSDK.Engine.RInteractionClass SideSwipeTargetsList
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RInteractionClass>(Ptr + 4900); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4900); }
    }

    /// <summary>
    /// ObjectProperty: ZappableThugs
    /// </summary>
    public unsafe BmSDK.Engine.RInteractionClass ZappableThugs
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RInteractionClass>(Ptr + 4908); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4908); }
    }

    /// <summary>
    /// ObjectProperty: VehicleWeapons
    /// </summary>
    public unsafe BmSDK.BmGame.RVehicleWeapon VehicleWeapons_0
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RVehicleWeapon>(Ptr + 4916); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4916); }
    }
    /// <summary>
    /// ObjectProperty: VehicleWeapons
    /// </summary>
    public unsafe BmSDK.BmGame.RVehicleWeapon VehicleWeapons_1
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RVehicleWeapon>(Ptr + 4924); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4924); }
    }
    /// <summary>
    /// ObjectProperty: VehicleWeapons
    /// </summary>
    public unsafe BmSDK.BmGame.RVehicleWeapon VehicleWeapons_2
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RVehicleWeapon>(Ptr + 4932); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4932); }
    }
    /// <summary>
    /// ObjectProperty: VehicleWeapons
    /// </summary>
    public unsafe BmSDK.BmGame.RVehicleWeapon VehicleWeapons_3
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RVehicleWeapon>(Ptr + 4940); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4940); }
    }
    /// <summary>
    /// ObjectProperty: VehicleWeapons
    /// </summary>
    public unsafe BmSDK.BmGame.RVehicleWeapon VehicleWeapons_4
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RVehicleWeapon>(Ptr + 4948); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4948); }
    }
    /// <summary>
    /// ObjectProperty: VehicleWeapons
    /// </summary>
    public unsafe BmSDK.BmGame.RVehicleWeapon VehicleWeapons_5
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RVehicleWeapon>(Ptr + 4956); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4956); }
    }
    /// <summary>
    /// ObjectProperty: VehicleWeapons
    /// </summary>
    public unsafe BmSDK.BmGame.RVehicleWeapon VehicleWeapons_6
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RVehicleWeapon>(Ptr + 4964); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4964); }
    }
    /// <summary>
    /// ObjectProperty: VehicleWeapons
    /// </summary>
    public unsafe BmSDK.BmGame.RVehicleWeapon VehicleWeapons_7
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RVehicleWeapon>(Ptr + 4972); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4972); }
    }
    /// <summary>
    /// ObjectProperty: VehicleWeapons
    /// </summary>
    public unsafe BmSDK.BmGame.RVehicleWeapon VehicleWeapons_8
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RVehicleWeapon>(Ptr + 4980); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4980); }
    }
    /// <summary>
    /// ObjectProperty: VehicleWeapons
    /// </summary>
    public unsafe BmSDK.BmGame.RVehicleWeapon VehicleWeapons_9
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RVehicleWeapon>(Ptr + 4988); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4988); }
    }

    /// <summary>
    /// ObjectProperty: PursuitModeWeapons
    /// </summary>
    public unsafe BmSDK.BmGame.RVehicleWeapon PursuitModeWeapons_0
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RVehicleWeapon>(Ptr + 4996); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4996); }
    }
    /// <summary>
    /// ObjectProperty: PursuitModeWeapons
    /// </summary>
    public unsafe BmSDK.BmGame.RVehicleWeapon PursuitModeWeapons_1
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RVehicleWeapon>(Ptr + 5004); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5004); }
    }
    /// <summary>
    /// ObjectProperty: PursuitModeWeapons
    /// </summary>
    public unsafe BmSDK.BmGame.RVehicleWeapon PursuitModeWeapons_2
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RVehicleWeapon>(Ptr + 5012); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5012); }
    }
    /// <summary>
    /// ObjectProperty: PursuitModeWeapons
    /// </summary>
    public unsafe BmSDK.BmGame.RVehicleWeapon PursuitModeWeapons_3
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RVehicleWeapon>(Ptr + 5020); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5020); }
    }
    /// <summary>
    /// ObjectProperty: PursuitModeWeapons
    /// </summary>
    public unsafe BmSDK.BmGame.RVehicleWeapon PursuitModeWeapons_4
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RVehicleWeapon>(Ptr + 5028); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5028); }
    }
    /// <summary>
    /// ObjectProperty: PursuitModeWeapons
    /// </summary>
    public unsafe BmSDK.BmGame.RVehicleWeapon PursuitModeWeapons_5
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RVehicleWeapon>(Ptr + 5036); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5036); }
    }
    /// <summary>
    /// ObjectProperty: PursuitModeWeapons
    /// </summary>
    public unsafe BmSDK.BmGame.RVehicleWeapon PursuitModeWeapons_6
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RVehicleWeapon>(Ptr + 5044); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5044); }
    }
    /// <summary>
    /// ObjectProperty: PursuitModeWeapons
    /// </summary>
    public unsafe BmSDK.BmGame.RVehicleWeapon PursuitModeWeapons_7
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RVehicleWeapon>(Ptr + 5052); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5052); }
    }
    /// <summary>
    /// ObjectProperty: PursuitModeWeapons
    /// </summary>
    public unsafe BmSDK.BmGame.RVehicleWeapon PursuitModeWeapons_8
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RVehicleWeapon>(Ptr + 5060); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5060); }
    }
    /// <summary>
    /// ObjectProperty: PursuitModeWeapons
    /// </summary>
    public unsafe BmSDK.BmGame.RVehicleWeapon PursuitModeWeapons_9
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RVehicleWeapon>(Ptr + 5068); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5068); }
    }

    /// <summary>
    /// ObjectProperty: ActualWeapons
    /// </summary>
    public unsafe BmSDK.BmGame.RVehicleWeapon ActualWeapons_0
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RVehicleWeapon>(Ptr + 5076); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5076); }
    }
    /// <summary>
    /// ObjectProperty: ActualWeapons
    /// </summary>
    public unsafe BmSDK.BmGame.RVehicleWeapon ActualWeapons_1
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RVehicleWeapon>(Ptr + 5084); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5084); }
    }
    /// <summary>
    /// ObjectProperty: ActualWeapons
    /// </summary>
    public unsafe BmSDK.BmGame.RVehicleWeapon ActualWeapons_2
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RVehicleWeapon>(Ptr + 5092); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5092); }
    }
    /// <summary>
    /// ObjectProperty: ActualWeapons
    /// </summary>
    public unsafe BmSDK.BmGame.RVehicleWeapon ActualWeapons_3
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RVehicleWeapon>(Ptr + 5100); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5100); }
    }
    /// <summary>
    /// ObjectProperty: ActualWeapons
    /// </summary>
    public unsafe BmSDK.BmGame.RVehicleWeapon ActualWeapons_4
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RVehicleWeapon>(Ptr + 5108); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5108); }
    }
    /// <summary>
    /// ObjectProperty: ActualWeapons
    /// </summary>
    public unsafe BmSDK.BmGame.RVehicleWeapon ActualWeapons_5
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RVehicleWeapon>(Ptr + 5116); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5116); }
    }
    /// <summary>
    /// ObjectProperty: ActualWeapons
    /// </summary>
    public unsafe BmSDK.BmGame.RVehicleWeapon ActualWeapons_6
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RVehicleWeapon>(Ptr + 5124); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5124); }
    }
    /// <summary>
    /// ObjectProperty: ActualWeapons
    /// </summary>
    public unsafe BmSDK.BmGame.RVehicleWeapon ActualWeapons_7
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RVehicleWeapon>(Ptr + 5132); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5132); }
    }
    /// <summary>
    /// ObjectProperty: ActualWeapons
    /// </summary>
    public unsafe BmSDK.BmGame.RVehicleWeapon ActualWeapons_8
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RVehicleWeapon>(Ptr + 5140); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5140); }
    }
    /// <summary>
    /// ObjectProperty: ActualWeapons
    /// </summary>
    public unsafe BmSDK.BmGame.RVehicleWeapon ActualWeapons_9
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RVehicleWeapon>(Ptr + 5148); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5148); }
    }

    /// <summary>
    /// ObjectProperty: ActualPMWeapons
    /// </summary>
    public unsafe BmSDK.BmGame.RVehicleWeapon ActualPMWeapons_0
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RVehicleWeapon>(Ptr + 5156); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5156); }
    }
    /// <summary>
    /// ObjectProperty: ActualPMWeapons
    /// </summary>
    public unsafe BmSDK.BmGame.RVehicleWeapon ActualPMWeapons_1
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RVehicleWeapon>(Ptr + 5164); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5164); }
    }
    /// <summary>
    /// ObjectProperty: ActualPMWeapons
    /// </summary>
    public unsafe BmSDK.BmGame.RVehicleWeapon ActualPMWeapons_2
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RVehicleWeapon>(Ptr + 5172); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5172); }
    }
    /// <summary>
    /// ObjectProperty: ActualPMWeapons
    /// </summary>
    public unsafe BmSDK.BmGame.RVehicleWeapon ActualPMWeapons_3
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RVehicleWeapon>(Ptr + 5180); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5180); }
    }
    /// <summary>
    /// ObjectProperty: ActualPMWeapons
    /// </summary>
    public unsafe BmSDK.BmGame.RVehicleWeapon ActualPMWeapons_4
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RVehicleWeapon>(Ptr + 5188); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5188); }
    }
    /// <summary>
    /// ObjectProperty: ActualPMWeapons
    /// </summary>
    public unsafe BmSDK.BmGame.RVehicleWeapon ActualPMWeapons_5
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RVehicleWeapon>(Ptr + 5196); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5196); }
    }
    /// <summary>
    /// ObjectProperty: ActualPMWeapons
    /// </summary>
    public unsafe BmSDK.BmGame.RVehicleWeapon ActualPMWeapons_6
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RVehicleWeapon>(Ptr + 5204); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5204); }
    }
    /// <summary>
    /// ObjectProperty: ActualPMWeapons
    /// </summary>
    public unsafe BmSDK.BmGame.RVehicleWeapon ActualPMWeapons_7
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RVehicleWeapon>(Ptr + 5212); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5212); }
    }
    /// <summary>
    /// ObjectProperty: ActualPMWeapons
    /// </summary>
    public unsafe BmSDK.BmGame.RVehicleWeapon ActualPMWeapons_8
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RVehicleWeapon>(Ptr + 5220); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5220); }
    }
    /// <summary>
    /// ObjectProperty: ActualPMWeapons
    /// </summary>
    public unsafe BmSDK.BmGame.RVehicleWeapon ActualPMWeapons_9
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RVehicleWeapon>(Ptr + 5228); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5228); }
    }

    /// <summary>
    /// ObjectProperty: PursuitModePrimaryWeapon
    /// </summary>
    public unsafe BmSDK.BmGame.RVehicleWeapon PursuitModePrimaryWeapon
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RVehicleWeapon>(Ptr + 5236); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5236); }
    }

    /// <summary>
    /// ObjectProperty: BattleModePrimaryWeapon
    /// </summary>
    public unsafe BmSDK.BmGame.RVehicleWeapon BattleModePrimaryWeapon
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RVehicleWeapon>(Ptr + 5244); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5244); }
    }

    /// <summary>
    /// ObjectProperty: BattleDodgeFFWaveForm
    /// </summary>
    public unsafe BmSDK.Engine.ForceFeedbackWaveform BattleDodgeFFWaveForm
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ForceFeedbackWaveform>(Ptr + 5252); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5252); }
    }

    /// <summary>
    /// ObjectProperty: DiedFFWaveForm
    /// </summary>
    public unsafe BmSDK.Engine.ForceFeedbackWaveform DiedFFWaveForm
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ForceFeedbackWaveform>(Ptr + 5260); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5260); }
    }

    /// <summary>
    /// ObjectProperty: TransformationAnimNode
    /// </summary>
    public unsafe BmSDK.Engine.AnimNodeSequence TransformationAnimNode
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AnimNodeSequence>(Ptr + 5268); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5268); }
    }

    /// <summary>
    /// ObjectProperty: CockpitAnimNode
    /// </summary>
    public unsafe BmSDK.Engine.AnimNodeSequence CockpitAnimNode
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AnimNodeSequence>(Ptr + 5276); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5276); }
    }

    /// <summary>
    /// ObjectProperty: TurretController
    /// </summary>
    public unsafe BmSDK.Engine.SkelControlSingleBone TurretController
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.SkelControlSingleBone>(Ptr + 5284); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5284); }
    }

    /// <summary>
    /// ObjectProperty: BoostBlendNode
    /// </summary>
    public unsafe BmSDK.Engine.AnimNodeBlend BoostBlendNode
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AnimNodeBlend>(Ptr + 5292); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5292); }
    }

    /// <summary>
    /// ObjectProperty: ArmourBlendNode
    /// </summary>
    public unsafe BmSDK.Engine.AnimNodeBlend ArmourBlendNode
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AnimNodeBlend>(Ptr + 5300); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5300); }
    }

    /// <summary>
    /// ObjectProperty: AirBrakeLeftNode
    /// </summary>
    public unsafe BmSDK.Engine.AnimNodeSequence AirBrakeLeftNode
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AnimNodeSequence>(Ptr + 5308); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5308); }
    }

    /// <summary>
    /// ObjectProperty: AirBrakeRightNode
    /// </summary>
    public unsafe BmSDK.Engine.AnimNodeSequence AirBrakeRightNode
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AnimNodeSequence>(Ptr + 5316); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5316); }
    }

    /// <summary>
    /// ObjectProperty: AfterburnerBlendNode
    /// </summary>
    public unsafe BmSDK.Engine.AnimNodeBlend AfterburnerBlendNode
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AnimNodeBlend>(Ptr + 5324); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5324); }
    }

    /// <summary>
    /// ObjectProperty: AfterburnerAnimNode
    /// </summary>
    public unsafe BmSDK.Engine.AnimNodeSequence AfterburnerAnimNode
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AnimNodeSequence>(Ptr + 5332); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5332); }
    }

    /// <summary>
    /// ObjectProperty: GeneratorPowerMaterial
    /// </summary>
    public unsafe BmSDK.Engine.MaterialInstanceConstant GeneratorPowerMaterial
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.MaterialInstanceConstant>(Ptr + 5340); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5340); }
    }

    /// <summary>
    /// ObjectProperty: StrafeTarget
    /// </summary>
    public unsafe BmSDK.BmGame.RVehicle StrafeTarget
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RVehicle>(Ptr + 5348); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5348); }
    }

    /// <summary>
    /// ObjectProperty: CurrentStrafeTarget
    /// </summary>
    public unsafe BmSDK.BmGame.RVehicle CurrentStrafeTarget
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RVehicle>(Ptr + 5356); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5356); }
    }

    /// <summary>
    /// ObjectProperty: BatmobileRoadNetwork
    /// </summary>
    public unsafe BmSDK.BmGame.RRoadNetwork BatmobileRoadNetwork
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RRoadNetwork>(Ptr + 5364); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5364); }
    }

    /// <summary>
    /// ObjectProperty: BatwingRescueArchetype
    /// </summary>
    public unsafe BmSDK.BmGame.RBatwing BatwingRescueArchetype
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RBatwing>(Ptr + 5372); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5372); }
    }

    /// <summary>
    /// ObjectProperty: BatwingRescue
    /// </summary>
    public unsafe BmSDK.BmGame.RBatwing BatwingRescue
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RBatwing>(Ptr + 5380); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5380); }
    }

    /// <summary>
    /// ObjectProperty: WarningParticleSystemTemplate
    /// </summary>
    public unsafe BmSDK.Engine.ParticleSystem WarningParticleSystemTemplate_0
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleSystem>(Ptr + 5388); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5388); }
    }
    /// <summary>
    /// ObjectProperty: WarningParticleSystemTemplate
    /// </summary>
    public unsafe BmSDK.Engine.ParticleSystem WarningParticleSystemTemplate_1
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleSystem>(Ptr + 5396); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5396); }
    }
    /// <summary>
    /// ObjectProperty: WarningParticleSystemTemplate
    /// </summary>
    public unsafe BmSDK.Engine.ParticleSystem WarningParticleSystemTemplate_2
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleSystem>(Ptr + 5404); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5404); }
    }
    /// <summary>
    /// ObjectProperty: WarningParticleSystemTemplate
    /// </summary>
    public unsafe BmSDK.Engine.ParticleSystem WarningParticleSystemTemplate_3
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleSystem>(Ptr + 5412); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5412); }
    }
    /// <summary>
    /// ObjectProperty: WarningParticleSystemTemplate
    /// </summary>
    public unsafe BmSDK.Engine.ParticleSystem WarningParticleSystemTemplate_4
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleSystem>(Ptr + 5420); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5420); }
    }

    /// <summary>
    /// ObjectProperty: WarningOnAudioEvent
    /// </summary>
    public unsafe BmSDK.Engine.AkEvent WarningOnAudioEvent_0
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkEvent>(Ptr + 5428); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5428); }
    }
    /// <summary>
    /// ObjectProperty: WarningOnAudioEvent
    /// </summary>
    public unsafe BmSDK.Engine.AkEvent WarningOnAudioEvent_1
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkEvent>(Ptr + 5436); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5436); }
    }
    /// <summary>
    /// ObjectProperty: WarningOnAudioEvent
    /// </summary>
    public unsafe BmSDK.Engine.AkEvent WarningOnAudioEvent_2
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkEvent>(Ptr + 5444); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5444); }
    }
    /// <summary>
    /// ObjectProperty: WarningOnAudioEvent
    /// </summary>
    public unsafe BmSDK.Engine.AkEvent WarningOnAudioEvent_3
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkEvent>(Ptr + 5452); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5452); }
    }
    /// <summary>
    /// ObjectProperty: WarningOnAudioEvent
    /// </summary>
    public unsafe BmSDK.Engine.AkEvent WarningOnAudioEvent_4
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkEvent>(Ptr + 5460); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5460); }
    }

    /// <summary>
    /// ObjectProperty: InPollenWarningMaterial
    /// </summary>
    public unsafe BmSDK.Engine.MaterialInstanceConstant InPollenWarningMaterial
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.MaterialInstanceConstant>(Ptr + 5468); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5468); }
    }

    /// <summary>
    /// ObjectProperty: OneTimeSpecialGetIn
    /// </summary>
    public unsafe BmSDK.BmGame.RSpecialMoveConfig OneTimeSpecialGetIn
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveConfig>(Ptr + 5476); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5476); }
    }

    /// <summary>
    /// ObjectProperty: ShortRangeGlideKick
    /// </summary>
    public unsafe BmSDK.BmGame.RSpecialMoveConfig ShortRangeGlideKick
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveConfig>(Ptr + 5484); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5484); }
    }

    /// <summary>
    /// ObjectProperty: HeadLightsMaterial
    /// </summary>
    public unsafe BmSDK.Engine.MaterialInstanceConstant HeadLightsMaterial
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.MaterialInstanceConstant>(Ptr + 5492); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5492); }
    }

    /// <summary>
    /// ObjectProperty: DiskBrakeMaterial
    /// </summary>
    public unsafe BmSDK.Engine.MaterialInstanceConstant DiskBrakeMaterial
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.MaterialInstanceConstant>(Ptr + 5500); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5500); }
    }

    /// <summary>
    /// ObjectProperty: EMPMaterial
    /// </summary>
    public unsafe BmSDK.Engine.MaterialInstanceConstant EMPMaterial
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.MaterialInstanceConstant>(Ptr + 5508); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5508); }
    }

    /// <summary>
    /// ObjectProperty: BrakeLightsLensFlare
    /// </summary>
    public unsafe BmSDK.Engine.LensFlare BrakeLightsLensFlare
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.LensFlare>(Ptr + 5516); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5516); }
    }

    /// <summary>
    /// ObjectProperty: TailLightsLensFlare
    /// </summary>
    public unsafe BmSDK.Engine.LensFlare TailLightsLensFlare
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.LensFlare>(Ptr + 5524); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5524); }
    }

    /// <summary>
    /// ObjectProperty: BatmobileViewMaterial
    /// </summary>
    public unsafe BmSDK.Engine.MaterialInterface BatmobileViewMaterial
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.MaterialInterface>(Ptr + 5532); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5532); }
    }

    /// <summary>
    /// ObjectProperty: BatmobileViewMaterialForPawns
    /// </summary>
    public unsafe BmSDK.Engine.MaterialInterface BatmobileViewMaterialForPawns
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.MaterialInterface>(Ptr + 5540); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5540); }
    }

    /// <summary>
    /// ObjectProperty: QueuedImpactActor
    /// </summary>
    public unsafe BmSDK.Engine.Actor QueuedImpactActor
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.Actor>(Ptr + 5548); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5548); }
    }

    /// <summary>
    /// ObjectProperty: DeadBatmobileArchetype
    /// </summary>
    public unsafe BmSDK.BmGame.RDeadVehicle DeadBatmobileArchetype
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RDeadVehicle>(Ptr + 5556); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5556); }
    }

    /// <summary>
    /// ObjectProperty: DeathExplosion
    /// </summary>
    public unsafe BmSDK.Engine.ParticleSystem DeathExplosion
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleSystem>(Ptr + 5564); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5564); }
    }

    /// <summary>
    /// ObjectProperty: DeathExplosionSound
    /// </summary>
    public unsafe BmSDK.Engine.AkEvent DeathExplosionSound
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkEvent>(Ptr + 5572); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5572); }
    }

    /// <summary>
    /// ObjectProperty: LocationPredictor
    /// </summary>
    public unsafe BmSDK.BmGame.RVehicleBatmobilePredictor LocationPredictor
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RVehicleBatmobilePredictor>(Ptr + 5580); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5580); }
    }

    /// <summary>
    /// ObjectProperty: FakeDestructibleEffectMat
    /// </summary>
    public unsafe BmSDK.Engine.PhysicalMaterial FakeDestructibleEffectMat
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.PhysicalMaterial>(Ptr + 5588); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5588); }
    }

    /// <summary>
    /// ObjectProperty: CollisionFFWaveForm
    /// </summary>
    public unsafe BmSDK.Engine.ForceFeedbackWaveform CollisionFFWaveForm
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ForceFeedbackWaveform>(Ptr + 5596); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5596); }
    }

    /// <summary>
    /// ObjectProperty: OverrideNextEject
    /// </summary>
    public unsafe BmSDK.BmGame.RSeqAct_OverrideBatmobileEject OverrideNextEject
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSeqAct_OverrideBatmobileEject>(Ptr + 5604); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5604); }
    }

    /// <summary>
    /// ObjectProperty: HeatSteamEffect
    /// </summary>
    public unsafe BmSDK.Engine.ParticleSystem HeatSteamEffect
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleSystem>(Ptr + 5612); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5612); }
    }

    /// <summary>
    /// ObjectProperty: WaitForBatmobileActionSequenceAction
    /// </summary>
    public unsafe BmSDK.BmGame.RSeqAct_WaitForBatmobileAction WaitForBatmobileActionSequenceAction
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSeqAct_WaitForBatmobileAction>(Ptr + 5620); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5620); }
    }

    /// <summary>
    /// ObjectProperty: BatmobileOnFireMaterial
    /// </summary>
    public unsafe BmSDK.Engine.MaterialInstanceConstant BatmobileOnFireMaterial
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.MaterialInstanceConstant>(Ptr + 5628); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5628); }
    }

    /// <summary>
    /// ObjectProperty: CurrentWeaponGeneratorMesh
    /// </summary>
    public unsafe BmSDK.BmGame.RWeaponGeneratorContainer CurrentWeaponGeneratorMesh
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RWeaponGeneratorContainer>(Ptr + 5636); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5636); }
    }

    /// <summary>
    /// ObjectProperty: LastDamageCauser
    /// </summary>
    public unsafe BmSDK.Engine.Actor LastDamageCauser
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.Actor>(Ptr + 5644); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5644); }
    }

    /// <summary>
    /// ObjectProperty: RunningPickup
    /// </summary>
    public unsafe BmSDK.BmGame.RSpecialMoveConfig RunningPickup
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveConfig>(Ptr + 5652); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5652); }
    }

    /// <summary>
    /// ComponentProperty: WeaponGeneratorMeshComp
    /// </summary>
    public unsafe BmSDK.Engine.SkeletalMeshComponent WeaponGeneratorMeshComp
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.SkeletalMeshComponent>(Ptr + 5660); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5660); }
    }

    /// <summary>
    /// ClassProperty: CrushDamageType
    /// </summary>
    public unsafe BmSDK.Class CrushDamageType
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Class>(Ptr + 5668); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5668); }
    }

    /// <summary>
    /// ClassProperty: RamDamageType
    /// </summary>
    public unsafe BmSDK.Class RamDamageType
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Class>(Ptr + 5676); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5676); }
    }

    /// <summary>
    /// ComponentProperty: BatmobileOnFireMeshComp
    /// </summary>
    public unsafe BmSDK.Engine.SkeletalMeshComponent BatmobileOnFireMeshComp
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.SkeletalMeshComponent>(Ptr + 5684); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5684); }
    }

    /// <summary>
    /// ComponentProperty: RearCylinderComponent
    /// </summary>
    public unsafe BmSDK.Engine.CylinderComponent RearCylinderComponent
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.CylinderComponent>(Ptr + 5692); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5692); }
    }

    /// <summary>
    /// ComponentProperty: FrontCylinderComponent
    /// </summary>
    public unsafe BmSDK.Engine.CylinderComponent FrontCylinderComponent
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.CylinderComponent>(Ptr + 5700); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5700); }
    }

    /// <summary>
    /// ComponentProperty: HeatSteam
    /// </summary>
    public unsafe BmSDK.Engine.ParticleSystemComponent HeatSteam
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleSystemComponent>(Ptr + 5708); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5708); }
    }

    /// <summary>
    /// ComponentProperty: BatmobileViewMesh
    /// </summary>
    public unsafe BmSDK.Engine.SkeletalMeshComponent BatmobileViewMesh
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.SkeletalMeshComponent>(Ptr + 5716); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5716); }
    }

    /// <summary>
    /// ComponentProperty: BatmanCollisionMeshBattleMode
    /// </summary>
    public unsafe BmSDK.Engine.StaticMeshComponent BatmanCollisionMeshBattleMode
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.StaticMeshComponent>(Ptr + 5724); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5724); }
    }

    /// <summary>
    /// ComponentProperty: BatmanCollisionMeshPursuitMode
    /// </summary>
    public unsafe BmSDK.Engine.StaticMeshComponent BatmanCollisionMeshPursuitMode
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.StaticMeshComponent>(Ptr + 5732); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5732); }
    }

    /// <summary>
    /// ComponentProperty: WarningPSCache
    /// </summary>
    public unsafe BmSDK.Engine.ParticleSystemComponent WarningPSCache_0
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleSystemComponent>(Ptr + 5740); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5740); }
    }
    /// <summary>
    /// ComponentProperty: WarningPSCache
    /// </summary>
    public unsafe BmSDK.Engine.ParticleSystemComponent WarningPSCache_1
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleSystemComponent>(Ptr + 5748); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5748); }
    }
    /// <summary>
    /// ComponentProperty: WarningPSCache
    /// </summary>
    public unsafe BmSDK.Engine.ParticleSystemComponent WarningPSCache_2
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleSystemComponent>(Ptr + 5756); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5756); }
    }
    /// <summary>
    /// ComponentProperty: WarningPSCache
    /// </summary>
    public unsafe BmSDK.Engine.ParticleSystemComponent WarningPSCache_3
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleSystemComponent>(Ptr + 5764); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5764); }
    }
    /// <summary>
    /// ComponentProperty: WarningPSCache
    /// </summary>
    public unsafe BmSDK.Engine.ParticleSystemComponent WarningPSCache_4
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleSystemComponent>(Ptr + 5772); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5772); }
    }
    /// <summary>
    /// ComponentProperty: WarningPSCache
    /// </summary>
    public unsafe BmSDK.Engine.ParticleSystemComponent WarningPSCache_5
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleSystemComponent>(Ptr + 5780); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5780); }
    }
    /// <summary>
    /// ComponentProperty: WarningPSCache
    /// </summary>
    public unsafe BmSDK.Engine.ParticleSystemComponent WarningPSCache_6
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleSystemComponent>(Ptr + 5788); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5788); }
    }
    /// <summary>
    /// ComponentProperty: WarningPSCache
    /// </summary>
    public unsafe BmSDK.Engine.ParticleSystemComponent WarningPSCache_7
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleSystemComponent>(Ptr + 5796); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5796); }
    }

    /// <summary>
    /// ComponentProperty: ThugZapperInteractions
    /// </summary>
    public unsafe BmSDK.Engine.RInteractionComponent ThugZapperInteractions
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RInteractionComponent>(Ptr + 5804); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5804); }
    }

    /// <summary>
    /// ComponentProperty: XrayLight
    /// </summary>
    public unsafe BmSDK.Engine.PointLightComponent XrayLight
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.PointLightComponent>(Ptr + 5812); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5812); }
    }

    /// <summary>
    /// ComponentProperty: NVBurnoutIosPSC
    /// </summary>
    public unsafe BmSDK.Engine.ParticleSystemComponent NVBurnoutIosPSC
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleSystemComponent>(Ptr + 5820); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5820); }
    }

    /// <summary>
    /// ComponentProperty: NVCannonIosPSC
    /// </summary>
    public unsafe BmSDK.Engine.ParticleSystemComponent NVCannonIosPSC
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleSystemComponent>(Ptr + 5828); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5828); }
    }

    /// <summary>
    /// ComponentProperty: ZapperRR
    /// </summary>
    public unsafe BmSDK.Engine.ParticleSystemComponent ZapperRR
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleSystemComponent>(Ptr + 5836); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5836); }
    }

    /// <summary>
    /// ComponentProperty: ZapperRL
    /// </summary>
    public unsafe BmSDK.Engine.ParticleSystemComponent ZapperRL
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleSystemComponent>(Ptr + 5844); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5844); }
    }

    /// <summary>
    /// ComponentProperty: ZapperFR
    /// </summary>
    public unsafe BmSDK.Engine.ParticleSystemComponent ZapperFR
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleSystemComponent>(Ptr + 5852); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5852); }
    }

    /// <summary>
    /// ComponentProperty: ZapperFL
    /// </summary>
    public unsafe BmSDK.Engine.ParticleSystemComponent ZapperFL
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleSystemComponent>(Ptr + 5860); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5860); }
    }

    /// <summary>
    /// ComponentProperty: WallScrapeSparksSystemR
    /// </summary>
    public unsafe BmSDK.Engine.ParticleSystemComponent WallScrapeSparksSystemR
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleSystemComponent>(Ptr + 5868); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5868); }
    }

    /// <summary>
    /// ComponentProperty: WallScrapeSparksSystemL
    /// </summary>
    public unsafe BmSDK.Engine.ParticleSystemComponent WallScrapeSparksSystemL
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleSystemComponent>(Ptr + 5876); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5876); }
    }

    /// <summary>
    /// FloatProperty: ZapperTime
    /// </summary>
    public unsafe float ZapperTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 5884); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5884); }
    }

    /// <summary>
    /// ByteProperty: WallScrapeCounterL
    /// </summary>
    public unsafe byte WallScrapeCounterL
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 5888); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5888); }
    }

    /// <summary>
    /// ByteProperty: WallScrapeCounterR
    /// </summary>
    public unsafe byte WallScrapeCounterR
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 5889); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5889); }
    }

    /// <summary>
    /// ByteProperty: JumpLandSparksCounterL
    /// </summary>
    public unsafe byte JumpLandSparksCounterL
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 5890); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5890); }
    }

    /// <summary>
    /// ByteProperty: JumpLandSparksCounterR
    /// </summary>
    public unsafe byte JumpLandSparksCounterR
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 5891); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5891); }
    }

    /// <summary>
    /// ByteProperty: InCrushVolume
    /// </summary>
    public unsafe byte InCrushVolume
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 5892); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5892); }
    }

    /// <summary>
    /// ByteProperty: InTunnelVolume
    /// </summary>
    public unsafe byte InTunnelVolume
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 5893); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5893); }
    }

    /// <summary>
    /// ByteProperty: PickupMode
    /// </summary>
    public unsafe BmSDK.BmGame.RVehicleBatmobileBase.EBatmobilePickupMode PickupMode
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RVehicleBatmobileBase.EBatmobilePickupMode>(Ptr + 5894); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5894); }
    }

    /// <summary>
    /// ByteProperty: BatmanVsBatmobileCollisionMode
    /// </summary>
    public unsafe BmSDK.BmGame.RVehicleBatmobileBase.EBatmanVsBatmobileCollisionMode BatmanVsBatmobileCollisionMode
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RVehicleBatmobileBase.EBatmanVsBatmobileCollisionMode>(Ptr + 5895); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5895); }
    }

    /// <summary>
    /// ByteProperty: ZeroStoredAccelFrames
    /// </summary>
    public unsafe byte ZeroStoredAccelFrames
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 5896); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5896); }
    }

    /// <summary>
    /// ByteProperty: DisableStasisFrames
    /// </summary>
    public unsafe byte DisableStasisFrames
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 5897); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5897); }
    }

    /// <summary>
    /// ByteProperty: HandbrakeTurnType
    /// </summary>
    public unsafe BmSDK.BmGame.RVehicleBatmobileBase.EHandbrakeTurnType HandbrakeTurnType
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RVehicleBatmobileBase.EHandbrakeTurnType>(Ptr + 5898); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5898); }
    }

    /// <summary>
    /// ByteProperty: WeaponUnavailableReason
    /// </summary>
    public unsafe BmSDK.BmGame.RVehicleWeapon.EHudDisplayLevel WeaponUnavailableReason
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RVehicleWeapon.EHudDisplayLevel>(Ptr + 5899); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5899); }
    }

    /// <summary>
    /// ByteProperty: SelfRightingMode
    /// </summary>
    public unsafe byte SelfRightingMode
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 5900); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5900); }
    }

    /// <summary>
    /// ByteProperty: BoostingOut
    /// </summary>
    public unsafe BmSDK.BmGame.RVehicleBatmobileBase.EBatmobileEjectType BoostingOut
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RVehicleBatmobileBase.EBatmobileEjectType>(Ptr + 5901); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5901); }
    }

    /// <summary>
    /// ByteProperty: MaxEjectType
    /// </summary>
    public unsafe BmSDK.BmGame.RVehicleBatmobileBase.EBatmobileEjectType MaxEjectType
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RVehicleBatmobileBase.EBatmobileEjectType>(Ptr + 5902); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5902); }
    }

    /// <summary>
    /// NameProperty: ImpactSparksSizeName
    /// </summary>
    public unsafe BmSDK.FName ImpactSparksSizeName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 5904); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5904); }
    }

    /// <summary>
    /// IntProperty: HeadLightMaterialIndex
    /// </summary>
    public unsafe int HeadLightMaterialIndex
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5912); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5912); }
    }

    /// <summary>
    /// IntProperty: DiskBrakeMaterialIndex
    /// </summary>
    public unsafe int DiskBrakeMaterialIndex
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5916); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5916); }
    }

    /// <summary>
    /// ArrayProperty: MuddyCarMaterialIndices
    /// </summary>
    public unsafe BmSDK.TArray<int> MuddyCarMaterialIndices
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<int>>(Ptr + 5920); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5920); }
    }

    /// <summary>
    /// IntProperty: EMPMaterialIndex
    /// </summary>
    public unsafe int EMPMaterialIndex
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5936); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5936); }
    }

    /// <summary>
    /// FloatProperty: TimeSinceDriving
    /// </summary>
    public unsafe float TimeSinceDriving
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 5940); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5940); }
    }

    /// <summary>
    /// FloatProperty: LastMobileTime
    /// </summary>
    public unsafe float LastMobileTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 5944); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5944); }
    }

    /// <summary>
    /// StructProperty: ImmobileCheckLocation
    /// </summary>
    public unsafe System.Numerics.Vector3 ImmobileCheckLocation
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 5948); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5948); }
    }

    /// <summary>
    /// ArrayProperty: TauntPositions
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RVehicleBatmobileBase.FTauntPosition> TauntPositions
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RVehicleBatmobileBase.FTauntPosition>>(Ptr + 5960); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5960); }
    }

    /// <summary>
    /// FloatProperty: ImpactRoadAssistTimer
    /// </summary>
    public unsafe float ImpactRoadAssistTimer
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 5976); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5976); }
    }

    /// <summary>
    /// FloatProperty: ImpactRoadAssistSceneryDuration
    /// </summary>
    public unsafe float ImpactRoadAssistSceneryDuration
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 5980); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5980); }
    }

    /// <summary>
    /// FloatProperty: ImpactRoadAssistEnemyDuration
    /// </summary>
    public unsafe float ImpactRoadAssistEnemyDuration
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 5984); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5984); }
    }

    /// <summary>
    /// FloatProperty: ImpactRoadAssistFactor
    /// </summary>
    public unsafe float ImpactRoadAssistFactor
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 5988); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5988); }
    }

    /// <summary>
    /// FloatProperty: ImpactRoadAssistMaxTorque
    /// </summary>
    public unsafe float ImpactRoadAssistMaxTorque
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 5992); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5992); }
    }

    /// <summary>
    /// FloatProperty: ImpactRoadAssistMaxAngle
    /// </summary>
    public unsafe float ImpactRoadAssistMaxAngle
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 5996); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5996); }
    }

    /// <summary>
    /// FloatProperty: ImpactRoadAssistAngVelocityTime
    /// </summary>
    public unsafe float ImpactRoadAssistAngVelocityTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 6000); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6000); }
    }

    /// <summary>
    /// FloatProperty: ImpactRoadAssistSteeringFactor
    /// </summary>
    public unsafe float ImpactRoadAssistSteeringFactor
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 6004); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6004); }
    }

    /// <summary>
    /// FloatProperty: ImpactRoadAssistLookAheadTime
    /// </summary>
    public unsafe float ImpactRoadAssistLookAheadTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 6008); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6008); }
    }

    /// <summary>
    /// FloatProperty: ImpactRoadAssistAngleStrength
    /// </summary>
    public unsafe float ImpactRoadAssistAngleStrength
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 6012); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6012); }
    }

    /// <summary>
    /// StructProperty: TransformBed
    /// </summary>
    public unsafe BmSDK.Engine.AkWwise.FAkSoundHandle TransformBed
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkWwise.FAkSoundHandle>(Ptr + 6016); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6016); }
    }

    /// <summary>
    /// FloatProperty: EjectUpDist
    /// </summary>
    public unsafe float EjectUpDist
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 6032); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6032); }
    }

    /// <summary>
    /// StructProperty: CheckpointBlockadeCantMoveDir
    /// </summary>
    public unsafe System.Numerics.Vector3 CheckpointBlockadeCantMoveDir
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 6036); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6036); }
    }

    /// <summary>
    /// FloatProperty: AccelTorqueFactor
    /// </summary>
    public unsafe float AccelTorqueFactor
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 6048); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6048); }
    }

    /// <summary>
    /// FloatProperty: BrakeSpinOutAngVel
    /// </summary>
    public unsafe float BrakeSpinOutAngVel
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 6052); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6052); }
    }

    /// <summary>
    /// FloatProperty: BrakeSpinOutTorqueFactor
    /// </summary>
    public unsafe float BrakeSpinOutTorqueFactor
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 6056); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6056); }
    }

    /// <summary>
    /// FloatProperty: GearChangeBodyPitch
    /// </summary>
    public unsafe float GearChangeBodyPitch
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 6060); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6060); }
    }

    /// <summary>
    /// ArrayProperty: PressurePads
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RPresurePadBase> PressurePads
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RPresurePadBase>>(Ptr + 6064); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6064); }
    }

    /// <summary>
    /// StrProperty: VehicleWeaponFlags
    /// </summary>
    public unsafe BmSDK.FString VehicleWeaponFlags_0
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 6080); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6080); }
    }
    /// <summary>
    /// StrProperty: VehicleWeaponFlags
    /// </summary>
    public unsafe BmSDK.FString VehicleWeaponFlags_1
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 6096); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6096); }
    }
    /// <summary>
    /// StrProperty: VehicleWeaponFlags
    /// </summary>
    public unsafe BmSDK.FString VehicleWeaponFlags_2
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 6112); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6112); }
    }
    /// <summary>
    /// StrProperty: VehicleWeaponFlags
    /// </summary>
    public unsafe BmSDK.FString VehicleWeaponFlags_3
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 6128); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6128); }
    }
    /// <summary>
    /// StrProperty: VehicleWeaponFlags
    /// </summary>
    public unsafe BmSDK.FString VehicleWeaponFlags_4
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 6144); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6144); }
    }
    /// <summary>
    /// StrProperty: VehicleWeaponFlags
    /// </summary>
    public unsafe BmSDK.FString VehicleWeaponFlags_5
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 6160); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6160); }
    }
    /// <summary>
    /// StrProperty: VehicleWeaponFlags
    /// </summary>
    public unsafe BmSDK.FString VehicleWeaponFlags_6
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 6176); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6176); }
    }
    /// <summary>
    /// StrProperty: VehicleWeaponFlags
    /// </summary>
    public unsafe BmSDK.FString VehicleWeaponFlags_7
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 6192); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6192); }
    }
    /// <summary>
    /// StrProperty: VehicleWeaponFlags
    /// </summary>
    public unsafe BmSDK.FString VehicleWeaponFlags_8
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 6208); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6208); }
    }
    /// <summary>
    /// StrProperty: VehicleWeaponFlags
    /// </summary>
    public unsafe BmSDK.FString VehicleWeaponFlags_9
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 6224); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6224); }
    }

    /// <summary>
    /// StrProperty: PursuitModeWeaponFlags
    /// </summary>
    public unsafe BmSDK.FString PursuitModeWeaponFlags_0
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 6240); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6240); }
    }
    /// <summary>
    /// StrProperty: PursuitModeWeaponFlags
    /// </summary>
    public unsafe BmSDK.FString PursuitModeWeaponFlags_1
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 6256); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6256); }
    }
    /// <summary>
    /// StrProperty: PursuitModeWeaponFlags
    /// </summary>
    public unsafe BmSDK.FString PursuitModeWeaponFlags_2
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 6272); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6272); }
    }
    /// <summary>
    /// StrProperty: PursuitModeWeaponFlags
    /// </summary>
    public unsafe BmSDK.FString PursuitModeWeaponFlags_3
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 6288); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6288); }
    }
    /// <summary>
    /// StrProperty: PursuitModeWeaponFlags
    /// </summary>
    public unsafe BmSDK.FString PursuitModeWeaponFlags_4
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 6304); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6304); }
    }
    /// <summary>
    /// StrProperty: PursuitModeWeaponFlags
    /// </summary>
    public unsafe BmSDK.FString PursuitModeWeaponFlags_5
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 6320); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6320); }
    }
    /// <summary>
    /// StrProperty: PursuitModeWeaponFlags
    /// </summary>
    public unsafe BmSDK.FString PursuitModeWeaponFlags_6
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 6336); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6336); }
    }
    /// <summary>
    /// StrProperty: PursuitModeWeaponFlags
    /// </summary>
    public unsafe BmSDK.FString PursuitModeWeaponFlags_7
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 6352); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6352); }
    }
    /// <summary>
    /// StrProperty: PursuitModeWeaponFlags
    /// </summary>
    public unsafe BmSDK.FString PursuitModeWeaponFlags_8
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 6368); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6368); }
    }
    /// <summary>
    /// StrProperty: PursuitModeWeaponFlags
    /// </summary>
    public unsafe BmSDK.FString PursuitModeWeaponFlags_9
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 6384); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6384); }
    }

    /// <summary>
    /// FloatProperty: SelfDriveStuckTime
    /// </summary>
    public unsafe float SelfDriveStuckTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 6400); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6400); }
    }

    /// <summary>
    /// FloatProperty: SelfDriveReverseTime
    /// </summary>
    public unsafe float SelfDriveReverseTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 6404); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6404); }
    }

    /// <summary>
    /// FloatProperty: CurrentThrottle
    /// </summary>
    public unsafe float CurrentThrottle
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 6408); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6408); }
    }

    /// <summary>
    /// FloatProperty: ThrottleSpeed
    /// </summary>
    public unsafe float ThrottleSpeed
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 6412); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6412); }
    }

    /// <summary>
    /// IntProperty: BattleModeYawOffset
    /// </summary>
    public unsafe int BattleModeYawOffset
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 6416); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6416); }
    }

    /// <summary>
    /// FloatProperty: BattleDodgeImpulse
    /// </summary>
    public unsafe float BattleDodgeImpulse
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 6420); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6420); }
    }

    /// <summary>
    /// IntProperty: ArmourModeDamageReduction
    /// </summary>
    public unsafe int ArmourModeDamageReduction
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 6424); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6424); }
    }

    /// <summary>
    /// ArrayProperty: TurretPitchController
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.Engine.SkelControlSingleBone> TurretPitchController
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.SkelControlSingleBone>>(Ptr + 6428); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6428); }
    }

    /// <summary>
    /// FloatProperty: AirBrakeLeft
    /// </summary>
    public unsafe float AirBrakeLeft
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 6444); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6444); }
    }

    /// <summary>
    /// FloatProperty: AirBrakeRight
    /// </summary>
    public unsafe float AirBrakeRight
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 6448); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6448); }
    }

    /// <summary>
    /// FloatProperty: WantAirBrakeLeft
    /// </summary>
    public unsafe float WantAirBrakeLeft
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 6452); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6452); }
    }

    /// <summary>
    /// FloatProperty: WantAirBrakeRight
    /// </summary>
    public unsafe float WantAirBrakeRight
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 6456); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6456); }
    }

    /// <summary>
    /// NameProperty: BattleModeTransformationAnimName
    /// </summary>
    public unsafe BmSDK.FName BattleModeTransformationAnimName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 6460); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6460); }
    }

    /// <summary>
    /// NameProperty: PursuitModeTransformationAnimName
    /// </summary>
    public unsafe BmSDK.FName PursuitModeTransformationAnimName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 6468); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6468); }
    }

    /// <summary>
    /// FloatProperty: LastStrafeRange
    /// </summary>
    public unsafe float LastStrafeRange
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 6476); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6476); }
    }

    /// <summary>
    /// IntProperty: CurrentGeneratorLevel
    /// </summary>
    public unsafe int CurrentGeneratorLevel
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 6480); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6480); }
    }

    /// <summary>
    /// ArrayProperty: ColourLevels
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.GameObject.FLinearColor> ColourLevels
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.GameObject.FLinearColor>>(Ptr + 6484); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6484); }
    }

    /// <summary>
    /// FloatProperty: CurrentStrafeTargetRange
    /// </summary>
    public unsafe float CurrentStrafeTargetRange
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 6500); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6500); }
    }

    /// <summary>
    /// IntProperty: BatmobileRoadLink
    /// </summary>
    public unsafe int BatmobileRoadLink
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 6504); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6504); }
    }

    /// <summary>
    /// FloatProperty: BatmobileRoadLinkTime
    /// </summary>
    public unsafe float BatmobileRoadLinkTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 6508); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6508); }
    }

    /// <summary>
    /// StructProperty: RemoteSafePointLocation
    /// </summary>
    public unsafe System.Numerics.Vector3 RemoteSafePointLocation
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 6512); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6512); }
    }

    /// <summary>
    /// StructProperty: RemoteSafePointRotation
    /// </summary>
    public unsafe BmSDK.Rotator RemoteSafePointRotation
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Rotator>(Ptr + 6524); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6524); }
    }

    /// <summary>
    /// IntProperty: SafePointLevelIndex
    /// </summary>
    public unsafe int SafePointLevelIndex
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 6536); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6536); }
    }

    /// <summary>
    /// IntProperty: BatmobileLevelVolIndex
    /// </summary>
    public unsafe int BatmobileLevelVolIndex
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 6540); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6540); }
    }

    /// <summary>
    /// FloatProperty: PreventModeSwitchDuration
    /// </summary>
    public unsafe float PreventModeSwitchDuration
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 6544); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6544); }
    }

    /// <summary>
    /// FloatProperty: BattleModeWidth
    /// </summary>
    public unsafe float BattleModeWidth
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 6548); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6548); }
    }

    /// <summary>
    /// FloatProperty: BattleModeLength
    /// </summary>
    public unsafe float BattleModeLength
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 6552); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6552); }
    }

    /// <summary>
    /// FloatProperty: BattleModeHeight
    /// </summary>
    public unsafe float BattleModeHeight
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 6556); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6556); }
    }

    /// <summary>
    /// FloatProperty: PursuitModeWidth
    /// </summary>
    public unsafe float PursuitModeWidth
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 6560); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6560); }
    }

    /// <summary>
    /// FloatProperty: PursuitModeLength
    /// </summary>
    public unsafe float PursuitModeLength
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 6564); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6564); }
    }

    /// <summary>
    /// FloatProperty: PursuitModeHeight
    /// </summary>
    public unsafe float PursuitModeHeight
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 6568); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6568); }
    }

    /// <summary>
    /// FloatProperty: AdjustedCarDirectionFactor
    /// </summary>
    public unsafe float AdjustedCarDirectionFactor
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 6572); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6572); }
    }

    /// <summary>
    /// IntProperty: OverrideSkidToStopYawAngle
    /// </summary>
    public unsafe int OverrideSkidToStopYawAngle
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 6576); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6576); }
    }

    /// <summary>
    /// FloatProperty: LastBoostPickupTime
    /// </summary>
    public unsafe float LastBoostPickupTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 6580); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6580); }
    }

    /// <summary>
    /// FloatProperty: AfterburnerRumbleStrength
    /// </summary>
    public unsafe float AfterburnerRumbleStrength
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 6584); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6584); }
    }

    /// <summary>
    /// NameProperty: InPollenWarningOverrideName
    /// </summary>
    public unsafe BmSDK.FName InPollenWarningOverrideName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 6588); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6588); }
    }

    /// <summary>
    /// StructProperty: ExplosiveImpactScreenShake
    /// </summary>
    public unsafe BmSDK.BmGame.RBMScreenShakeModifier.FBMScreenShakeStruct ExplosiveImpactScreenShake
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RBMScreenShakeModifier.FBMScreenShakeStruct>(Ptr + 6596); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6596); }
    }

    /// <summary>
    /// FloatProperty: JumpRampUpwardForce
    /// </summary>
    public unsafe float JumpRampUpwardForce
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 6752); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6752); }
    }

    /// <summary>
    /// FloatProperty: JumpRampRightingTorque
    /// </summary>
    public unsafe float JumpRampRightingTorque
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 6756); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6756); }
    }

    /// <summary>
    /// FloatProperty: JumpNoRampRightingTorque
    /// </summary>
    public unsafe float JumpNoRampRightingTorque
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 6760); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6760); }
    }

    /// <summary>
    /// NameProperty: MissileBoneNames
    /// </summary>
    public unsafe BmSDK.FName MissileBoneNames_0
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 6764); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6764); }
    }
    /// <summary>
    /// NameProperty: MissileBoneNames
    /// </summary>
    public unsafe BmSDK.FName MissileBoneNames_1
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 6772); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6772); }
    }
    /// <summary>
    /// NameProperty: MissileBoneNames
    /// </summary>
    public unsafe BmSDK.FName MissileBoneNames_2
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 6780); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6780); }
    }
    /// <summary>
    /// NameProperty: MissileBoneNames
    /// </summary>
    public unsafe BmSDK.FName MissileBoneNames_3
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 6788); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6788); }
    }
    /// <summary>
    /// NameProperty: MissileBoneNames
    /// </summary>
    public unsafe BmSDK.FName MissileBoneNames_4
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 6796); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6796); }
    }
    /// <summary>
    /// NameProperty: MissileBoneNames
    /// </summary>
    public unsafe BmSDK.FName MissileBoneNames_5
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 6804); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6804); }
    }
    /// <summary>
    /// NameProperty: MissileBoneNames
    /// </summary>
    public unsafe BmSDK.FName MissileBoneNames_6
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 6812); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6812); }
    }
    /// <summary>
    /// NameProperty: MissileBoneNames
    /// </summary>
    public unsafe BmSDK.FName MissileBoneNames_7
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 6820); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6820); }
    }

    /// <summary>
    /// ArrayProperty: WeaponWarnings
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RVehicleBatmobileBase.FBatmobileWeaponWarningContainer> WeaponWarnings
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RVehicleBatmobileBase.FBatmobileWeaponWarningContainer>>(Ptr + 6828); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6828); }
    }

    /// <summary>
    /// IntProperty: CurrentWeaponWarningCheckId
    /// </summary>
    public unsafe int CurrentWeaponWarningCheckId
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 6844); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6844); }
    }

    /// <summary>
    /// FloatProperty: ShortRangeGlideKickRange
    /// </summary>
    public unsafe float ShortRangeGlideKickRange
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 6848); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6848); }
    }

    /// <summary>
    /// StructProperty: SelfDriveRoadObstacleTypes
    /// </summary>
    public unsafe BmSDK.BmGame.RVehicle.FRoadObstacleTypes SelfDriveRoadObstacleTypes
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RVehicle.FRoadObstacleTypes>(Ptr + 6852); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6852); }
    }

    /// <summary>
    /// FloatProperty: ImpactMaxDamage
    /// </summary>
    public unsafe float ImpactMaxDamage
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 6856); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6856); }
    }

    /// <summary>
    /// FloatProperty: ImpactMaxDamageSpeed
    /// </summary>
    public unsafe float ImpactMaxDamageSpeed
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 6860); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6860); }
    }

    /// <summary>
    /// FloatProperty: ImpactMinDamageSpeed
    /// </summary>
    public unsafe float ImpactMinDamageSpeed
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 6864); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6864); }
    }

    /// <summary>
    /// FloatProperty: ImpactStrafeMod
    /// </summary>
    public unsafe float ImpactStrafeMod
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 6868); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6868); }
    }

    /// <summary>
    /// FloatProperty: ImpactCivilianVehicleMod
    /// </summary>
    public unsafe float ImpactCivilianVehicleMod
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 6872); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6872); }
    }

    /// <summary>
    /// FloatProperty: ImpactBoostMod
    /// </summary>
    public unsafe float ImpactBoostMod
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 6876); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6876); }
    }

    /// <summary>
    /// FloatProperty: ImpactMaxDamagePow
    /// </summary>
    public unsafe float ImpactMaxDamagePow
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 6880); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6880); }
    }

    /// <summary>
    /// FloatProperty: BattleModeImpactMaxDamageSpeed
    /// </summary>
    public unsafe float BattleModeImpactMaxDamageSpeed
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 6884); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6884); }
    }

    /// <summary>
    /// FloatProperty: BattleModeImpactMinDamageSpeed
    /// </summary>
    public unsafe float BattleModeImpactMinDamageSpeed
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 6888); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6888); }
    }

    /// <summary>
    /// FloatProperty: BattleModeImpactMaxDamagePow
    /// </summary>
    public unsafe float BattleModeImpactMaxDamagePow
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 6892); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6892); }
    }

    /// <summary>
    /// FloatProperty: StafeImpactImpulse
    /// </summary>
    public unsafe float StafeImpactImpulse
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 6896); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6896); }
    }

    /// <summary>
    /// StructProperty: QueuedVehDamage
    /// </summary>
    public unsafe BmSDK.BmGame.RVehicleBatmobileBase.FQueuedVehicleImpactDamage QueuedVehDamage_0
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RVehicleBatmobileBase.FQueuedVehicleImpactDamage>(Ptr + 6900); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6900); }
    }
    /// <summary>
    /// StructProperty: QueuedVehDamage
    /// </summary>
    public unsafe BmSDK.BmGame.RVehicleBatmobileBase.FQueuedVehicleImpactDamage QueuedVehDamage_1
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RVehicleBatmobileBase.FQueuedVehicleImpactDamage>(Ptr + 6924); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6924); }
    }
    /// <summary>
    /// StructProperty: QueuedVehDamage
    /// </summary>
    public unsafe BmSDK.BmGame.RVehicleBatmobileBase.FQueuedVehicleImpactDamage QueuedVehDamage_2
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RVehicleBatmobileBase.FQueuedVehicleImpactDamage>(Ptr + 6948); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6948); }
    }
    /// <summary>
    /// StructProperty: QueuedVehDamage
    /// </summary>
    public unsafe BmSDK.BmGame.RVehicleBatmobileBase.FQueuedVehicleImpactDamage QueuedVehDamage_3
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RVehicleBatmobileBase.FQueuedVehicleImpactDamage>(Ptr + 6972); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6972); }
    }
    /// <summary>
    /// StructProperty: QueuedVehDamage
    /// </summary>
    public unsafe BmSDK.BmGame.RVehicleBatmobileBase.FQueuedVehicleImpactDamage QueuedVehDamage_4
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RVehicleBatmobileBase.FQueuedVehicleImpactDamage>(Ptr + 6996); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6996); }
    }
    /// <summary>
    /// StructProperty: QueuedVehDamage
    /// </summary>
    public unsafe BmSDK.BmGame.RVehicleBatmobileBase.FQueuedVehicleImpactDamage QueuedVehDamage_5
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RVehicleBatmobileBase.FQueuedVehicleImpactDamage>(Ptr + 7020); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7020); }
    }
    /// <summary>
    /// StructProperty: QueuedVehDamage
    /// </summary>
    public unsafe BmSDK.BmGame.RVehicleBatmobileBase.FQueuedVehicleImpactDamage QueuedVehDamage_6
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RVehicleBatmobileBase.FQueuedVehicleImpactDamage>(Ptr + 7044); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7044); }
    }
    /// <summary>
    /// StructProperty: QueuedVehDamage
    /// </summary>
    public unsafe BmSDK.BmGame.RVehicleBatmobileBase.FQueuedVehicleImpactDamage QueuedVehDamage_7
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RVehicleBatmobileBase.FQueuedVehicleImpactDamage>(Ptr + 7068); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7068); }
    }

    /// <summary>
    /// ArrayProperty: MuddyCarMaterials
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.Engine.MaterialInstanceConstant> MuddyCarMaterials
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.MaterialInstanceConstant>>(Ptr + 7092); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7092); }
    }

    /// <summary>
    /// StructProperty: HeadLightsColourPursuit
    /// </summary>
    public unsafe BmSDK.GameObject.FLinearColor HeadLightsColourPursuit
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.GameObject.FLinearColor>(Ptr + 7108); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7108); }
    }

    /// <summary>
    /// StructProperty: HeadLightsColourBattle
    /// </summary>
    public unsafe BmSDK.GameObject.FLinearColor HeadLightsColourBattle
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.GameObject.FLinearColor>(Ptr + 7124); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7124); }
    }

    /// <summary>
    /// FloatProperty: DiskBrakeHeatFront
    /// </summary>
    public unsafe float DiskBrakeHeatFront
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 7140); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7140); }
    }

    /// <summary>
    /// FloatProperty: DiskBrakeHeatRear
    /// </summary>
    public unsafe float DiskBrakeHeatRear
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 7144); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7144); }
    }

    /// <summary>
    /// FloatProperty: MuddyCar
    /// </summary>
    public unsafe float MuddyCar
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 7148); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7148); }
    }

    /// <summary>
    /// FloatProperty: FakeExtraSpeed
    /// </summary>
    public unsafe float FakeExtraSpeed
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 7152); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7152); }
    }

    /// <summary>
    /// FloatProperty: FakeExtraSpeedMax
    /// </summary>
    public unsafe float FakeExtraSpeedMax
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 7156); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7156); }
    }

    /// <summary>
    /// FloatProperty: FakeExtaSpeedAccel
    /// </summary>
    public unsafe float FakeExtaSpeedAccel
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 7160); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7160); }
    }

    /// <summary>
    /// FloatProperty: FakeExtaSpeedDecel
    /// </summary>
    public unsafe float FakeExtaSpeedDecel
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 7164); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7164); }
    }

    /// <summary>
    /// ArrayProperty: DamageNumbers
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RVehicleBatmobileBase.FFloatingDamageNumber> DamageNumbers
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RVehicleBatmobileBase.FFloatingDamageNumber>>(Ptr + 7168); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7168); }
    }

    /// <summary>
    /// FloatProperty: SideSwipeRange
    /// </summary>
    public unsafe float SideSwipeRange
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 7184); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7184); }
    }

    /// <summary>
    /// FloatProperty: SideSwipeFwdRange
    /// </summary>
    public unsafe float SideSwipeFwdRange
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 7188); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7188); }
    }

    /// <summary>
    /// FloatProperty: KillFlipTorque
    /// </summary>
    public unsafe float KillFlipTorque
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 7192); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7192); }
    }

    /// <summary>
    /// FloatProperty: KillFlipTorqueDuration
    /// </summary>
    public unsafe float KillFlipTorqueDuration
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 7196); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7196); }
    }

    /// <summary>
    /// FloatProperty: KillKeepyUpFactor
    /// </summary>
    public unsafe float KillKeepyUpFactor
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 7200); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7200); }
    }

    /// <summary>
    /// FloatProperty: KillKeepyUpFactorDuration
    /// </summary>
    public unsafe float KillKeepyUpFactorDuration
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 7204); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7204); }
    }

    /// <summary>
    /// StructProperty: ImpactShake
    /// </summary>
    public unsafe BmSDK.BmGame.RBMScreenShakeModifier.FBMScreenShakeStruct ImpactShake
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RBMScreenShakeModifier.FBMScreenShakeStruct>(Ptr + 7208); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7208); }
    }

    /// <summary>
    /// FloatProperty: ImpactShakeForceFactor
    /// </summary>
    public unsafe float ImpactShakeForceFactor
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 7364); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7364); }
    }

    /// <summary>
    /// FloatProperty: ImpactShakeVehicleFactor
    /// </summary>
    public unsafe float ImpactShakeVehicleFactor
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 7368); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7368); }
    }

    /// <summary>
    /// FloatProperty: ImpactShakeAbandonedVehicleFactor
    /// </summary>
    public unsafe float ImpactShakeAbandonedVehicleFactor
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 7372); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7372); }
    }

    /// <summary>
    /// FloatProperty: ImpactShakeDestructiblesFactor
    /// </summary>
    public unsafe float ImpactShakeDestructiblesFactor
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 7376); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7376); }
    }

    /// <summary>
    /// FloatProperty: ImpactShakeCoolDown
    /// </summary>
    public unsafe float ImpactShakeCoolDown
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 7380); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7380); }
    }

    /// <summary>
    /// FloatProperty: CameraImpactEffectFactorFwd
    /// </summary>
    public unsafe float CameraImpactEffectFactorFwd
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 7384); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7384); }
    }

    /// <summary>
    /// FloatProperty: CameraImpactEffectFactorSide
    /// </summary>
    public unsafe float CameraImpactEffectFactorSide
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 7388); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7388); }
    }

    /// <summary>
    /// FloatProperty: VehicleImpactEffectFactorFwd
    /// </summary>
    public unsafe float VehicleImpactEffectFactorFwd
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 7392); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7392); }
    }

    /// <summary>
    /// FloatProperty: VehicleImpactEffectFactorSide
    /// </summary>
    public unsafe float VehicleImpactEffectFactorSide
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 7396); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7396); }
    }

    /// <summary>
    /// FloatProperty: VehicleImpactForceFactorFwd
    /// </summary>
    public unsafe float VehicleImpactForceFactorFwd
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 7400); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7400); }
    }

    /// <summary>
    /// FloatProperty: VehicleImpactForceFalloff
    /// </summary>
    public unsafe float VehicleImpactForceFalloff
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 7404); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7404); }
    }

    /// <summary>
    /// FloatProperty: VehicleImpactForceMax
    /// </summary>
    public unsafe float VehicleImpactForceMax
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 7408); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7408); }
    }

    /// <summary>
    /// FloatProperty: CurrentImpactEffectForce
    /// </summary>
    public unsafe float CurrentImpactEffectForce
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 7412); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7412); }
    }

    /// <summary>
    /// FloatProperty: VehicleShovingTorque
    /// </summary>
    public unsafe float VehicleShovingTorque
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 7416); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7416); }
    }

    /// <summary>
    /// StructProperty: QueuedImpactEffect
    /// </summary>
    public unsafe System.Numerics.Vector3 QueuedImpactEffect
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 7420); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7420); }
    }

    /// <summary>
    /// ArrayProperty: DeathExplosionSoundArray
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.Engine.AkEvent> DeathExplosionSoundArray
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.AkEvent>>(Ptr + 7432); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7432); }
    }

    /// <summary>
    /// FloatProperty: BatmobileStuckTime
    /// </summary>
    public unsafe float BatmobileStuckTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 7448); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7448); }
    }

    /// <summary>
    /// FloatProperty: BatmobileStuckTimeMax
    /// </summary>
    public unsafe float BatmobileStuckTimeMax
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 7452); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7452); }
    }

    /// <summary>
    /// FloatProperty: BatmobileStuckTimeFlip
    /// </summary>
    public unsafe float BatmobileStuckTimeFlip
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 7456); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7456); }
    }

    /// <summary>
    /// IntProperty: NumFlipTries
    /// </summary>
    public unsafe int NumFlipTries
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7460); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7460); }
    }

    /// <summary>
    /// FloatProperty: LastDeltaTime
    /// </summary>
    public unsafe float LastDeltaTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 7464); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7464); }
    }

    /// <summary>
    /// StructProperty: OldVelocity
    /// </summary>
    public unsafe System.Numerics.Vector3 OldVelocity
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 7468); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7468); }
    }

    /// <summary>
    /// StructProperty: StoredAccel
    /// </summary>
    public unsafe System.Numerics.Vector3 StoredAccel
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 7480); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7480); }
    }

    /// <summary>
    /// FloatProperty: CheatIgnoreCollisionWidth
    /// </summary>
    public unsafe float CheatIgnoreCollisionWidth
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 7492); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7492); }
    }

    /// <summary>
    /// FloatProperty: CheatIgnoreCollisionMinSpeedFactor
    /// </summary>
    public unsafe float CheatIgnoreCollisionMinSpeedFactor
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 7496); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7496); }
    }

    /// <summary>
    /// FloatProperty: FakeDestructibleEffectTimer
    /// </summary>
    public unsafe float FakeDestructibleEffectTimer
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 7500); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7500); }
    }

    /// <summary>
    /// StructProperty: FakeDestructibleEffectLoc
    /// </summary>
    public unsafe System.Numerics.Vector3 FakeDestructibleEffectLoc
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 7504); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7504); }
    }

    /// <summary>
    /// StructProperty: FakeDestructibleEffectNormal
    /// </summary>
    public unsafe System.Numerics.Vector3 FakeDestructibleEffectNormal
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 7516); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7516); }
    }

    /// <summary>
    /// StructProperty: Passengers
    /// </summary>
    public unsafe BmSDK.BmGame.RVehicleBatmobileBase.FBatmobilePassenger Passengers_0
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RVehicleBatmobileBase.FBatmobilePassenger>(Ptr + 7528); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7528); }
    }
    /// <summary>
    /// StructProperty: Passengers
    /// </summary>
    public unsafe BmSDK.BmGame.RVehicleBatmobileBase.FBatmobilePassenger Passengers_1
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RVehicleBatmobileBase.FBatmobilePassenger>(Ptr + 7588); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7588); }
    }
    /// <summary>
    /// StructProperty: Passengers
    /// </summary>
    public unsafe BmSDK.BmGame.RVehicleBatmobileBase.FBatmobilePassenger Passengers_2
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RVehicleBatmobileBase.FBatmobilePassenger>(Ptr + 7648); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7648); }
    }
    /// <summary>
    /// StructProperty: Passengers
    /// </summary>
    public unsafe BmSDK.BmGame.RVehicleBatmobileBase.FBatmobilePassenger Passengers_3
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RVehicleBatmobileBase.FBatmobilePassenger>(Ptr + 7708); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7708); }
    }

    /// <summary>
    /// ArrayProperty: BatmobileViewNonPassengers
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RBMPawnAI> BatmobileViewNonPassengers
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RBMPawnAI>>(Ptr + 7768); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7768); }
    }

    /// <summary>
    /// ArrayProperty: PassengerNoise
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RVehicleBatmobileBase.FBatmobilePassengerNoise> PassengerNoise
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RVehicleBatmobileBase.FBatmobilePassengerNoise>>(Ptr + 7784); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7784); }
    }

    /// <summary>
    /// FloatProperty: PassengerNoiseDelay
    /// </summary>
    public unsafe float PassengerNoiseDelay
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 7800); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7800); }
    }

    /// <summary>
    /// IntProperty: PassengerNoiseIndex
    /// </summary>
    public unsafe int PassengerNoiseIndex
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7804); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7804); }
    }

    /// <summary>
    /// FloatProperty: fRumbleMinimumThreshold
    /// </summary>
    public unsafe float fRumbleMinimumThreshold
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 7808); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7808); }
    }

    /// <summary>
    /// FloatProperty: fRumbleWallImpactScaleMultiplier
    /// </summary>
    public unsafe float fRumbleWallImpactScaleMultiplier
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 7812); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7812); }
    }

    /// <summary>
    /// FloatProperty: fRumblePhysicsObjectScaleMultiplier
    /// </summary>
    public unsafe float fRumblePhysicsObjectScaleMultiplier
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 7816); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7816); }
    }

    /// <summary>
    /// FloatProperty: fRumblePhysicsObjectMaxValue
    /// </summary>
    public unsafe float fRumblePhysicsObjectMaxValue
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 7820); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7820); }
    }

    /// <summary>
    /// FloatProperty: fRumbleAbandonedVehicleScaleMultiplier
    /// </summary>
    public unsafe float fRumbleAbandonedVehicleScaleMultiplier
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 7824); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7824); }
    }

    /// <summary>
    /// FloatProperty: fRumbleJumpLandingScaleMultiplier
    /// </summary>
    public unsafe float fRumbleJumpLandingScaleMultiplier
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 7828); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7828); }
    }

    /// <summary>
    /// StructProperty: LowerChassisCollision
    /// </summary>
    public unsafe System.IntPtr LowerChassisCollision
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.IntPtr>(Ptr + 7832); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7832); }
    }

    /// <summary>
    /// StructProperty: TurbulenceChassisCollision
    /// </summary>
    public unsafe System.IntPtr TurbulenceChassisCollision
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.IntPtr>(Ptr + 7840); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7840); }
    }

    /// <summary>
    /// IntProperty: InitialNumShapes
    /// </summary>
    public unsafe int InitialNumShapes
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7848); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7848); }
    }

    /// <summary>
    /// FloatProperty: LastBattleModeControlledTime
    /// </summary>
    public unsafe float LastBattleModeControlledTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 7852); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7852); }
    }

    /// <summary>
    /// FloatProperty: EmergencyStopDist
    /// </summary>
    public unsafe float EmergencyStopDist
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 7856); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7856); }
    }

    /// <summary>
    /// FloatProperty: BattleModeSpeedDelta
    /// </summary>
    public unsafe float BattleModeSpeedDelta
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 7860); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7860); }
    }

    /// <summary>
    /// FloatProperty: CrushThreshold
    /// </summary>
    public unsafe float CrushThreshold
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 7864); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7864); }
    }

    /// <summary>
    /// StructProperty: CrushTotal
    /// </summary>
    public unsafe System.Numerics.Vector3 CrushTotal
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 7868); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7868); }
    }

    /// <summary>
    /// StructProperty: CrushAbsTotal
    /// </summary>
    public unsafe System.Numerics.Vector3 CrushAbsTotal
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 7880); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7880); }
    }

    /// <summary>
    /// StructProperty: BounceOrigin
    /// </summary>
    public unsafe System.Numerics.Vector3 BounceOrigin
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 7892); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7892); }
    }

    /// <summary>
    /// FloatProperty: AirborneTime
    /// </summary>
    public unsafe float AirborneTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 7904); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7904); }
    }

    /// <summary>
    /// FloatProperty: lastDamagedByCheckPointMineTime
    /// </summary>
    public unsafe float lastDamagedByCheckPointMineTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 7908); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7908); }
    }

    /// <summary>
    /// FloatProperty: WeaponGeneratorPower
    /// </summary>
    public unsafe float WeaponGeneratorPower
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 7912); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7912); }
    }

    /// <summary>
    /// FloatProperty: WeaponGeneratorPowerTickUp
    /// </summary>
    public unsafe float WeaponGeneratorPowerTickUp
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 7916); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7916); }
    }

    /// <summary>
    /// ArrayProperty: MaxWeaponGeneratorPower
    /// </summary>
    public unsafe BmSDK.TArray<float> MaxWeaponGeneratorPower
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<float>>(Ptr + 7920); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7920); }
    }

    /// <summary>
    /// FloatProperty: WeaponGeneratorKillBonus
    /// </summary>
    public unsafe float WeaponGeneratorKillBonus
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 7936); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7936); }
    }

    /// <summary>
    /// FloatProperty: WeaponGeneratorHeavyTankKillBonus
    /// </summary>
    public unsafe float WeaponGeneratorHeavyTankKillBonus
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 7940); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7940); }
    }

    /// <summary>
    /// FloatProperty: WeaponGeneratorThugKillBonus
    /// </summary>
    public unsafe float WeaponGeneratorThugKillBonus
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 7944); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7944); }
    }

    /// <summary>
    /// FloatProperty: WeaponGeneratorHeadShotBonus
    /// </summary>
    public unsafe float WeaponGeneratorHeadShotBonus
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 7948); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7948); }
    }

    /// <summary>
    /// FloatProperty: WeaponGeneratorArmourShotBonus
    /// </summary>
    public unsafe float WeaponGeneratorArmourShotBonus
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 7952); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7952); }
    }

    /// <summary>
    /// FloatProperty: WeaponGeneratorMissileBonus
    /// </summary>
    public unsafe float WeaponGeneratorMissileBonus
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 7956); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7956); }
    }

    /// <summary>
    /// FloatProperty: WeaponGeneratorDodgeBonus
    /// </summary>
    public unsafe float WeaponGeneratorDodgeBonus
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 7960); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7960); }
    }

    /// <summary>
    /// FloatProperty: WeaponGeneratorBonusMultiplier
    /// </summary>
    public unsafe float WeaponGeneratorBonusMultiplier
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 7964); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7964); }
    }

    /// <summary>
    /// FloatProperty: WeaponGeneratorDrain
    /// </summary>
    public unsafe float WeaponGeneratorDrain
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 7968); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7968); }
    }

    /// <summary>
    /// FloatProperty: WeaponGeneratorDefaultPower
    /// </summary>
    public unsafe float WeaponGeneratorDefaultPower
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 7972); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7972); }
    }

    /// <summary>
    /// FloatProperty: WeaponGeneratorShielding
    /// </summary>
    public unsafe float WeaponGeneratorShielding
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 7976); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7976); }
    }

    /// <summary>
    /// FloatProperty: WeaponGeneratorScarecrowBonus
    /// </summary>
    public unsafe float WeaponGeneratorScarecrowBonus
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 7980); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7980); }
    }

    /// <summary>
    /// IntProperty: CriticalCounter
    /// </summary>
    public unsafe int CriticalCounter
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7984); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7984); }
    }

    /// <summary>
    /// IntProperty: PerfectCriticalCounter
    /// </summary>
    public unsafe int PerfectCriticalCounter
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7988); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7988); }
    }

    /// <summary>
    /// FloatProperty: CurrentSteaminess
    /// </summary>
    public unsafe float CurrentSteaminess
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 7992); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7992); }
    }

    /// <summary>
    /// FloatProperty: HeatSteamFallOffTime
    /// </summary>
    public unsafe float HeatSteamFallOffTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 7996); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7996); }
    }

    /// <summary>
    /// FloatProperty: HeatSteamBuildUpTime
    /// </summary>
    public unsafe float HeatSteamBuildUpTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 8000); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8000); }
    }

    /// <summary>
    /// FloatProperty: HowMuchTheRainAffectsHeatSteam
    /// </summary>
    public unsafe float HowMuchTheRainAffectsHeatSteam
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 8004); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8004); }
    }

    /// <summary>
    /// StructProperty: DriftAngularVelocityBySteer
    /// </summary>
    public unsafe BmSDK.GameObject.FInterpCurveFloat DriftAngularVelocityBySteer
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.GameObject.FInterpCurveFloat>(Ptr + 8008); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8008); }
    }

    /// <summary>
    /// StructProperty: DriftSpeedBySteer
    /// </summary>
    public unsafe BmSDK.GameObject.FInterpCurveFloat DriftSpeedBySteer
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.GameObject.FInterpCurveFloat>(Ptr + 8028); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8028); }
    }

    /// <summary>
    /// FloatProperty: DriftAngularVelocityFactor
    /// </summary>
    public unsafe float DriftAngularVelocityFactor
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 8048); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8048); }
    }

    /// <summary>
    /// FloatProperty: DriftAngularVelocityFactorMax
    /// </summary>
    public unsafe float DriftAngularVelocityFactorMax
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 8052); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8052); }
    }

    /// <summary>
    /// FloatProperty: DriftVelocityFactor
    /// </summary>
    public unsafe float DriftVelocityFactor
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 8056); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8056); }
    }

    /// <summary>
    /// FloatProperty: DriftVelocityFactorMax
    /// </summary>
    public unsafe float DriftVelocityFactorMax
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 8060); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8060); }
    }

    /// <summary>
    /// StructProperty: DriftVelocityForcePosOffset
    /// </summary>
    public unsafe System.Numerics.Vector3 DriftVelocityForcePosOffset
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 8064); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8064); }
    }

    /// <summary>
    /// FloatProperty: DriftCorrectionSteerSpeed
    /// </summary>
    public unsafe float DriftCorrectionSteerSpeed
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 8076); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8076); }
    }

    /// <summary>
    /// FloatProperty: DriftWobbleFrequencyMax
    /// </summary>
    public unsafe float DriftWobbleFrequencyMax
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 8080); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8080); }
    }

    /// <summary>
    /// FloatProperty: DriftWobblePeriodMaxSpeed
    /// </summary>
    public unsafe float DriftWobblePeriodMaxSpeed
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 8084); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8084); }
    }

    /// <summary>
    /// FloatProperty: DriftWobbleStrengthMax
    /// </summary>
    public unsafe float DriftWobbleStrengthMax
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 8088); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8088); }
    }

    /// <summary>
    /// FloatProperty: CurrentDriftWobbleTimer
    /// </summary>
    public unsafe float CurrentDriftWobbleTimer
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 8092); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8092); }
    }

    /// <summary>
    /// FloatProperty: LastDriftDir
    /// </summary>
    public unsafe float LastDriftDir
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 8096); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8096); }
    }

    /// <summary>
    /// FloatProperty: CurrentDriftSteer
    /// </summary>
    public unsafe float CurrentDriftSteer
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 8100); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8100); }
    }

    /// <summary>
    /// IntProperty: CurrentArmourLevel
    /// </summary>
    public unsafe int CurrentArmourLevel
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8104); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8104); }
    }

    /// <summary>
    /// ArrayProperty: ArmourLevels
    /// </summary>
    public unsafe BmSDK.TArray<int> ArmourLevels
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<int>>(Ptr + 8108); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8108); }
    }

    /// <summary>
    /// IntProperty: LowHealthWarningLevel
    /// </summary>
    public unsafe int LowHealthWarningLevel
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8124); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8124); }
    }

    /// <summary>
    /// FloatProperty: BatmobileOnFireDamageRadiusScale
    /// </summary>
    public unsafe float BatmobileOnFireDamageRadiusScale
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 8128); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8128); }
    }

    /// <summary>
    /// FloatProperty: BatmobileOnFireRadiusDecayDelay
    /// </summary>
    public unsafe float BatmobileOnFireRadiusDecayDelay
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 8132); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8132); }
    }

    /// <summary>
    /// FloatProperty: BatmobileOnFireRadiusDecayRate
    /// </summary>
    public unsafe float BatmobileOnFireRadiusDecayRate
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 8136); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8136); }
    }

    /// <summary>
    /// ArrayProperty: BatmobileOnFire
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RVehicleBatmobileBase.FBatmobileOnFireInfo> BatmobileOnFire
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RVehicleBatmobileBase.FBatmobileOnFireInfo>>(Ptr + 8140); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8140); }
    }

    /// <summary>
    /// FloatProperty: PMDodgeTorque
    /// </summary>
    public unsafe float PMDodgeTorque
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 8156); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8156); }
    }

    /// <summary>
    /// FloatProperty: PMDodgeForce
    /// </summary>
    public unsafe float PMDodgeForce
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 8160); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8160); }
    }

    /// <summary>
    /// FloatProperty: PMDodgeDuration
    /// </summary>
    public unsafe float PMDodgeDuration
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 8164); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8164); }
    }

    /// <summary>
    /// ArrayProperty: PreviousAllComponentsList
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.FString> PreviousAllComponentsList
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.FString>>(Ptr + 8168); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8168); }
    }

    /// <summary>
    /// ArrayProperty: WeaponGeneratorMeshPackage
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.FString> WeaponGeneratorMeshPackage
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.FString>>(Ptr + 8184); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8184); }
    }

    /// <summary>
    /// ArrayProperty: WeaponGeneratorMesh
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.Engine.SkeletalMesh> WeaponGeneratorMesh
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.SkeletalMesh>>(Ptr + 8200); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8200); }
    }

    /// <summary>
    /// IntProperty: CurrentDisplayedWeaponGenerator
    /// </summary>
    public unsafe int CurrentDisplayedWeaponGenerator
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8216); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8216); }
    }

    /// <summary>
    /// ArrayProperty: HealthRecoverRate
    /// </summary>
    public unsafe BmSDK.TArray<float> HealthRecoverRate
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<float>>(Ptr + 8220); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8220); }
    }

    /// <summary>
    /// StructProperty: JumpStartLocation
    /// </summary>
    public unsafe System.Numerics.Vector3 JumpStartLocation
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 8236); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8236); }
    }

    /// <summary>
    /// ArrayProperty: Guarders
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RPawnCombat> Guarders
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RPawnCombat>>(Ptr + 8248); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8248); }
    }

    /// <summary>
    /// IntProperty: NumGuardPoints
    /// </summary>
    public unsafe int NumGuardPoints
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8264); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8264); }
    }

    /// <summary>
    /// StructProperty: BatmobileSafePointLocation
    /// </summary>
    public unsafe System.Numerics.Vector3 BatmobileSafePointLocation
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 8268); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8268); }
    }

    /// <summary>
    /// StructProperty: BatmobileSafePointRotation
    /// </summary>
    public unsafe BmSDK.Rotator BatmobileSafePointRotation
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Rotator>(Ptr + 8280); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8280); }
    }

    /// <summary>
    /// StrProperty: BatmobileSafePointLevel
    /// </summary>
    public unsafe BmSDK.FString BatmobileSafePointLevel
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 8292); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8292); }
    }

    /// <summary>
    /// ArrayProperty: BatmobileSafePointStreamingLevels
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.FString> BatmobileSafePointStreamingLevels
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.FString>>(Ptr + 8308); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8308); }
    }

    /// <summary>
    /// ArrayProperty: BatmobileSafePointStreamingLevelsLODs
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.FString> BatmobileSafePointStreamingLevelsLODs
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.FString>>(Ptr + 8324); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8324); }
    }

    /// <summary>
    /// FloatProperty: ScalarToReduceDestructibleParticlesAtHighSpeed
    /// </summary>
    public unsafe float ScalarToReduceDestructibleParticlesAtHighSpeed
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 8340); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8340); }
    }

    /// <summary>
    /// IntProperty: HideDriverPitch
    /// </summary>
    public unsafe int HideDriverPitch
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8344); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8344); }
    }

    /// <summary>
    /// IntProperty: HideDriverYaw
    /// </summary>
    public unsafe int HideDriverYaw
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8348); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8348); }
    }
}
