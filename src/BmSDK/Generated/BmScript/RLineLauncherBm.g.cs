#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmScript;

/// <summary>
/// Class: RLineLauncherBm<br/>
/// (flags = 0)
/// </summary>
public partial class RLineLauncherBm : BmSDK.BmGame.RLineLauncher, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmScript.RLineLauncherBm", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RLineLauncherBm() { }

    /// <summary>
    /// Constructs a new RLineLauncherBm
    /// </summary>
    public RLineLauncherBm(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RLineLauncherBm Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RLineLauncherBm(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="Engine.Actor.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RLineLauncherBm>
        => ((Engine.Actor)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="Engine.Actor.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RLineLauncherBm>, new()
        => (TComponent)((Engine.Actor)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="Engine.Actor.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RLineLauncherBm>
        => ((Engine.Actor)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="Engine.Actor.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RLineLauncherBm>
        => ((Engine.Actor)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="Engine.Actor.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RLineLauncherBm>
        => (TComponent)((Engine.Actor)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="Engine.Actor.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RLineLauncherBm>
        => ((Engine.Actor)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="Engine.Actor.DetachScriptComponent(Type)"/>
    public void DetachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RLineLauncherBm>
        => ((Engine.Actor)this).DetachScriptComponent(typeof(TComponent));

    /// <summary>
    /// FloatProperty: LineLauncherRange
    /// </summary>
    public unsafe float LineLauncherRange
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2068); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2068); }
    }

    /// <summary>
    /// FloatProperty: LineLauncherBackRange
    /// </summary>
    public unsafe float LineLauncherBackRange
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2072); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2072); }
    }

    /// <summary>
    /// FloatProperty: LineLauncherHeight
    /// </summary>
    public unsafe float LineLauncherHeight
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2076); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2076); }
    }

    /// <summary>
    /// FloatProperty: LineLauncherPlayerHeight
    /// </summary>
    public unsafe float LineLauncherPlayerHeight
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2080); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2080); }
    }

    /// <summary>
    /// FloatProperty: MinLineLauncherRange
    /// </summary>
    public unsafe float MinLineLauncherRange
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2084); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2084); }
    }

    /// <summary>
    /// FloatProperty: MinLineLauncherBackRange
    /// </summary>
    public unsafe float MinLineLauncherBackRange
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2088); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2088); }
    }

    /// <summary>
    /// FloatProperty: LineLauncherFireRightOffset
    /// </summary>
    public unsafe float LineLauncherFireRightOffset
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2092); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2092); }
    }

    /// <summary>
    /// ObjectProperty: SuccessfulFireMove
    /// </summary>
    public unsafe BmSDK.BmGame.RSpecialMoveConfig SuccessfulFireMove
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveConfig>(Ptr + 2096); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2096); }
    }

    /// <summary>
    /// ObjectProperty: SuccessfulFire2ndLineLeftMove
    /// </summary>
    public unsafe BmSDK.BmGame.RSpecialMoveConfig SuccessfulFire2ndLineLeftMove
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveConfig>(Ptr + 2104); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2104); }
    }

    /// <summary>
    /// ObjectProperty: SuccessfulFire2ndLineRightMove
    /// </summary>
    public unsafe BmSDK.BmGame.RSpecialMoveConfig SuccessfulFire2ndLineRightMove
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveConfig>(Ptr + 2112); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2112); }
    }

    /// <summary>
    /// ObjectProperty: FailedFireMove
    /// </summary>
    public unsafe BmSDK.BmGame.RSpecialMoveConfig FailedFireMove
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveConfig>(Ptr + 2120); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2120); }
    }

    /// <summary>
    /// ObjectProperty: LineLauncherGlideStopMove
    /// </summary>
    public unsafe BmSDK.BmGame.RSpecialMoveConfig LineLauncherGlideStopMove
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveConfig>(Ptr + 2128); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2128); }
    }

    /// <summary>
    /// ObjectProperty: Projectile
    /// </summary>
    public unsafe BmSDK.BmGame.RProjectileWithRope Projectile_0
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RProjectileWithRope>(Ptr + 2136); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2136); }
    }
    /// <summary>
    /// ObjectProperty: Projectile
    /// </summary>
    public unsafe BmSDK.BmGame.RProjectileWithRope Projectile_1
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RProjectileWithRope>(Ptr + 2144); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2144); }
    }

    /// <summary>
    /// ObjectProperty: RescueVolume
    /// </summary>
    public unsafe BmSDK.BmGame.RLineLauncherRescueVolume RescueVolume
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RLineLauncherRescueVolume>(Ptr + 2152); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2152); }
    }

    /// <summary>
    /// ObjectProperty: HostageVolume
    /// </summary>
    public unsafe BmSDK.BmGame.RLineLauncherRescueVolume HostageVolume
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RLineLauncherRescueVolume>(Ptr + 2160); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2160); }
    }

    /// <summary>
    /// ObjectProperty: TargetedHostage
    /// </summary>
    public unsafe BmSDK.BmGame.RBMPawnAI TargetedHostage
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RBMPawnAI>(Ptr + 2168); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2168); }
    }

    /// <summary>
    /// ObjectProperty: GrabbedVillain
    /// </summary>
    public unsafe BmSDK.BmGame.RPawnVillain GrabbedVillain
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPawnVillain>(Ptr + 2176); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2176); }
    }

    /// <summary>
    /// ObjectProperty: GrabbedHostage
    /// </summary>
    public unsafe BmSDK.BmGame.RBMPawnAI GrabbedHostage
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RBMPawnAI>(Ptr + 2184); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2184); }
    }

    /// <summary>
    /// ObjectProperty: LineLauncherWire
    /// </summary>
    public unsafe BmSDK.BmGame.RHidePoint_RopeBase LineLauncherWire
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RHidePoint_RopeBase>(Ptr + 2192); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2192); }
    }

    /// <summary>
    /// ObjectProperty: FlipUpOntoTightropeMove
    /// </summary>
    public unsafe BmSDK.BmGame.RSpecialMoveConfig FlipUpOntoTightropeMove
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveConfig>(Ptr + 2200); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2200); }
    }

    /// <summary>
    /// ObjectProperty: CameraAnimSet
    /// </summary>
    public unsafe BmSDK.Engine.AnimSet CameraAnimSet
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AnimSet>(Ptr + 2208); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2208); }
    }

    /// <summary>
    /// ObjectProperty: DiveSwingMove
    /// </summary>
    public unsafe BmSDK.BmGame.RSpecialMoveConfig DiveSwingMove
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveConfig>(Ptr + 2216); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2216); }
    }

    /// <summary>
    /// ObjectProperty: FailedFireSound
    /// </summary>
    public unsafe BmSDK.Engine.AkEvent FailedFireSound
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkEvent>(Ptr + 2224); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2224); }
    }

    /// <summary>
    /// ClassProperty: RopeSpawnClass
    /// </summary>
    public unsafe BmSDK.Class RopeSpawnClass
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Class>(Ptr + 2232); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2232); }
    }

    /// <summary>
    /// ComponentProperty: MuzzleFlash
    /// </summary>
    public unsafe BmSDK.Engine.ParticleSystemComponent MuzzleFlash
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleSystemComponent>(Ptr + 2240); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2240); }
    }

    /// <summary>
    /// ComponentProperty: ProjectileRope
    /// </summary>
    public unsafe BmSDK.BmGame.RSimpleRopeComponent ProjectileRope_0
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSimpleRopeComponent>(Ptr + 2248); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2248); }
    }
    /// <summary>
    /// ComponentProperty: ProjectileRope
    /// </summary>
    public unsafe BmSDK.BmGame.RSimpleRopeComponent ProjectileRope_1
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSimpleRopeComponent>(Ptr + 2256); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2256); }
    }

    /// <summary>
    /// FloatProperty: ZipForwardMaxSpeed
    /// </summary>
    public unsafe float ZipForwardMaxSpeed
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2264); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2264); }
    }

    /// <summary>
    /// FloatProperty: ZipForwardAccel
    /// </summary>
    public unsafe float ZipForwardAccel
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2268); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2268); }
    }

    /// <summary>
    /// IntProperty: YawRangeToCheck
    /// </summary>
    public unsafe int YawRangeToCheck
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2272); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2272); }
    }

    /// <summary>
    /// IntProperty: NumChecksOnEachSide
    /// </summary>
    public unsafe int NumChecksOnEachSide
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2276); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2276); }
    }

    /// <summary>
    /// FloatProperty: LineLauncherAttachAngle
    /// </summary>
    public unsafe float LineLauncherAttachAngle
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2280); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2280); }
    }

    /// <summary>
    /// FloatProperty: LowLineLauncherHeightOffset
    /// </summary>
    public unsafe float LowLineLauncherHeightOffset
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2284); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2284); }
    }

    /// <summary>
    /// FloatProperty: LowLineLauncherPlayerHeightOffset
    /// </summary>
    public unsafe float LowLineLauncherPlayerHeightOffset
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2288); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2288); }
    }

    /// <summary>
    /// StructProperty: CurrentWinchUpPosition
    /// </summary>
    public unsafe System.Numerics.Vector3 CurrentWinchUpPosition
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 2292); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2292); }
    }

    /// <summary>
    /// StructProperty: CurrentEndPosition
    /// </summary>
    public unsafe System.Numerics.Vector3 CurrentEndPosition
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 2304); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2304); }
    }

    /// <summary>
    /// FloatProperty: CurrentZipSpeed
    /// </summary>
    public unsafe float CurrentZipSpeed
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2316); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2316); }
    }

    /// <summary>
    /// FloatProperty: CosLineLauncherAttachAngle
    /// </summary>
    public unsafe float CosLineLauncherAttachAngle
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2320); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2320); }
    }

    /// <summary>
    /// StructProperty: EndRopePos
    /// </summary>
    public unsafe System.Numerics.Vector3 EndRopePos
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 2324); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2324); }
    }

    /// <summary>
    /// StructProperty: BackRopePos
    /// </summary>
    public unsafe System.Numerics.Vector3 BackRopePos
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 2336); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2336); }
    }

    /// <summary>
    /// StructProperty: BatmanStartPoint
    /// </summary>
    public unsafe System.Numerics.Vector3 BatmanStartPoint
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 2348); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2348); }
    }

    /// <summary>
    /// StructProperty: BatmanEndPoint
    /// </summary>
    public unsafe System.Numerics.Vector3 BatmanEndPoint
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 2360); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2360); }
    }

    /// <summary>
    /// StructProperty: EndRopePosAim
    /// </summary>
    public unsafe System.Numerics.Vector3 EndRopePosAim
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 2372); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2372); }
    }

    /// <summary>
    /// StructProperty: BackRopePosAim
    /// </summary>
    public unsafe System.Numerics.Vector3 BackRopePosAim
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 2384); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2384); }
    }

    /// <summary>
    /// StructProperty: BatmanStartPointAim
    /// </summary>
    public unsafe System.Numerics.Vector3 BatmanStartPointAim
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 2396); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2396); }
    }

    /// <summary>
    /// StructProperty: BatmanEndPointAim
    /// </summary>
    public unsafe System.Numerics.Vector3 BatmanEndPointAim
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 2408); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2408); }
    }

    /// <summary>
    /// IntProperty: RopeInitTimer
    /// </summary>
    public unsafe int RopeInitTimer
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2420); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2420); }
    }

    /// <summary>
    /// IntProperty: RopesFired
    /// </summary>
    public unsafe int RopesFired
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2424); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2424); }
    }

    /// <summary>
    /// FloatProperty: FirstRopePlayerHeight
    /// </summary>
    public unsafe float FirstRopePlayerHeight
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2428); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2428); }
    }

    /// <summary>
    /// FloatProperty: MinAimAngle
    /// </summary>
    public unsafe float MinAimAngle
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2432); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2432); }
    }

    /// <summary>
    /// FloatProperty: CosMinAimAngle
    /// </summary>
    public unsafe float CosMinAimAngle
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2436); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2436); }
    }

    /// <summary>
    /// BoolProperty: bGrabHostageMode
    /// </summary>
    public unsafe bool bGrabHostageMode
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2440) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2440); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2440); }
    }

    /// <summary>
    /// BoolProperty: BlockedByHostageTaker
    /// </summary>
    public unsafe bool BlockedByHostageTaker
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2440) & 2) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2440); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2440); }
    }

    /// <summary>
    /// BoolProperty: bFailedLaunch
    /// </summary>
    public unsafe bool bFailedLaunch
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2440) & 4) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2440); var newMask = value ? (currentMask | 4) : (currentMask & ~4); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2440); }
    }

    /// <summary>
    /// BoolProperty: AlwaysAllowLineLauncherTightrope
    /// </summary>
    public unsafe bool AlwaysAllowLineLauncherTightrope
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2440) & 8) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2440); var newMask = value ? (currentMask | 8) : (currentMask & ~8); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2440); }
    }

    /// <summary>
    /// NameProperty: CameraFire2ndLineLeftAnim
    /// </summary>
    public unsafe BmSDK.FName CameraFire2ndLineLeftAnim
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 2444); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2444); }
    }

    /// <summary>
    /// NameProperty: CameraFire2ndLineRightAnim
    /// </summary>
    public unsafe BmSDK.FName CameraFire2ndLineRightAnim
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 2452); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2452); }
    }

    /// <summary>
    /// FloatProperty: CameraAnimFactor
    /// </summary>
    public unsafe float CameraAnimFactor
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2460); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2460); }
    }
}
