#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RBatmobileEMPMissile<br/>
/// (flags = 0)
/// </summary>
public partial class RBatmobileEMPMissile : BmSDK.BmGame.RPursuitModeMissileLauncher, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RBatmobileEMPMissile", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RBatmobileEMPMissile() { }

    /// <summary>
    /// Constructs a new RBatmobileEMPMissile
    /// </summary>
    public RBatmobileEMPMissile(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RBatmobileEMPMissile Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RBatmobileEMPMissile(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="Engine.Actor.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RBatmobileEMPMissile>
        => ((Engine.Actor)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="Engine.Actor.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RBatmobileEMPMissile>, new()
        => (TComponent)((Engine.Actor)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="Engine.Actor.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RBatmobileEMPMissile>
        => ((Engine.Actor)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="Engine.Actor.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RBatmobileEMPMissile>
        => ((Engine.Actor)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="Engine.Actor.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RBatmobileEMPMissile>
        => (TComponent)((Engine.Actor)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="Engine.Actor.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RBatmobileEMPMissile>
        => ((Engine.Actor)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="Engine.Actor.DetachScriptComponent(Type)"/>
    public void DetachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RBatmobileEMPMissile>
        => ((Engine.Actor)this).DetachScriptComponent(typeof(TComponent));

    /// <summary>
    /// ObjectProperty: LockOnTarget
    /// </summary>
    public unsafe BmSDK.BmGame.RVehicleNPC LockOnTarget
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RVehicleNPC>(Ptr + 2468); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2468); }
    }

    /// <summary>
    /// ObjectProperty: LastLockTarget
    /// </summary>
    public unsafe BmSDK.BmGame.RVehicleNPC LastLockTarget
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RVehicleNPC>(Ptr + 2476); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2476); }
    }

    /// <summary>
    /// ObjectProperty: TagTarget
    /// </summary>
    public unsafe BmSDK.BmGame.RVehicle TagTarget
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RVehicle>(Ptr + 2484); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2484); }
    }

    /// <summary>
    /// ObjectProperty: ProjectileForCarsArchetype
    /// </summary>
    public unsafe BmSDK.BmGame.RProjectile ProjectileForCarsArchetype
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RProjectile>(Ptr + 2492); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2492); }
    }

    /// <summary>
    /// ObjectProperty: ExplosionEvent
    /// </summary>
    public unsafe BmSDK.Engine.AkEvent ExplosionEvent
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkEvent>(Ptr + 2500); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2500); }
    }

    /// <summary>
    /// ObjectProperty: UntagWarningEvent
    /// </summary>
    public unsafe BmSDK.Engine.AkEvent UntagWarningEvent
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkEvent>(Ptr + 2508); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2508); }
    }

    /// <summary>
    /// ObjectProperty: MissileAnimNode
    /// </summary>
    public unsafe BmSDK.Engine.AnimNodeSequence MissileAnimNode
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AnimNodeSequence>(Ptr + 2516); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2516); }
    }

    /// <summary>
    /// ObjectProperty: PursuitMissileBlendNode
    /// </summary>
    public unsafe BmSDK.Engine.AnimNodeBlend PursuitMissileBlendNode
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AnimNodeBlend>(Ptr + 2524); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2524); }
    }

    /// <summary>
    /// ObjectProperty: CantFireOnPenguinVanDialogue
    /// </summary>
    public unsafe BmSDK.Engine.AkDialogueSpeech CantFireOnPenguinVanDialogue
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkDialogueSpeech>(Ptr + 2532); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2532); }
    }

    /// <summary>
    /// FloatProperty: LockOnTime
    /// </summary>
    public unsafe float LockOnTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2540); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2540); }
    }

    /// <summary>
    /// FloatProperty: MaxDamageAngle
    /// </summary>
    public unsafe float MaxDamageAngle
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2544); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2544); }
    }

    /// <summary>
    /// FloatProperty: SinWave1Param
    /// </summary>
    public unsafe float SinWave1Param
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2548); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2548); }
    }

    /// <summary>
    /// FloatProperty: SinWave2Param
    /// </summary>
    public unsafe float SinWave2Param
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2552); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2552); }
    }

    /// <summary>
    /// FloatProperty: AngleDamageFactor
    /// </summary>
    public unsafe float AngleDamageFactor
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2556); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2556); }
    }

    /// <summary>
    /// FloatProperty: MissileLockOnDuration
    /// </summary>
    public unsafe float MissileLockOnDuration
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2560); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2560); }
    }

    /// <summary>
    /// FloatProperty: CivilianMissileLockOnDuration
    /// </summary>
    public unsafe float CivilianMissileLockOnDuration
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2564); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2564); }
    }

    /// <summary>
    /// FloatProperty: CurrentDamageFactor
    /// </summary>
    public unsafe float CurrentDamageFactor
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2568); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2568); }
    }

    /// <summary>
    /// ArrayProperty: MissileLaunchSockets
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.FName> MissileLaunchSockets
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.FName>>(Ptr + 2572); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2572); }
    }

    /// <summary>
    /// NameProperty: LauncherAnimNodeName
    /// </summary>
    public unsafe BmSDK.FName LauncherAnimNodeName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 2588); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2588); }
    }

    /// <summary>
    /// NameProperty: LauncherBlendNodeName
    /// </summary>
    public unsafe BmSDK.FName LauncherBlendNodeName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 2596); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2596); }
    }

    /// <summary>
    /// ByteProperty: CurrentLaunchSocket
    /// </summary>
    public unsafe byte CurrentLaunchSocket
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 2604); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2604); }
    }

    /// <summary>
    /// ByteProperty: MissileAnimState
    /// </summary>
    public unsafe BmSDK.BmGame.RBatmobileEMPMissile.EMissileAnimState MissileAnimState
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RBatmobileEMPMissile.EMissileAnimState>(Ptr + 2605); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2605); }
    }

    /// <summary>
    /// BoolProperty: bTryingToAcquireNewTarget
    /// </summary>
    public unsafe bool bTryingToAcquireNewTarget
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2608) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2608); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2608); }
    }

    /// <summary>
    /// FloatProperty: PromoteUntagPromptTime
    /// </summary>
    public unsafe float PromoteUntagPromptTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2612); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2612); }
    }

    /// <summary>
    /// FloatProperty: YTargetRange
    /// </summary>
    public unsafe float YTargetRange
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2616); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2616); }
    }

    /// <summary>
    /// FloatProperty: YTargetRangeMax
    /// </summary>
    public unsafe float YTargetRangeMax
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2620); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2620); }
    }

    /// <summary>
    /// FloatProperty: ZTargetRange
    /// </summary>
    public unsafe float ZTargetRange
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2624); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2624); }
    }

    /// <summary>
    /// FloatProperty: TunnelYTargetRange
    /// </summary>
    public unsafe float TunnelYTargetRange
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2628); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2628); }
    }

    /// <summary>
    /// FloatProperty: TunnelYTargetRangeMax
    /// </summary>
    public unsafe float TunnelYTargetRangeMax
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2632); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2632); }
    }

    /// <summary>
    /// FloatProperty: TunnelZTargetRange
    /// </summary>
    public unsafe float TunnelZTargetRange
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2636); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2636); }
    }

    /// <summary>
    /// FloatProperty: LoseLockXBonus
    /// </summary>
    public unsafe float LoseLockXBonus
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2640); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2640); }
    }

    /// <summary>
    /// FloatProperty: LoseLockYBonus
    /// </summary>
    public unsafe float LoseLockYBonus
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2644); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2644); }
    }

    /// <summary>
    /// FloatProperty: LoseLockZBonus
    /// </summary>
    public unsafe float LoseLockZBonus
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2648); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2648); }
    }

    /// <summary>
    /// FloatProperty: AngleAimFactor
    /// </summary>
    public unsafe float AngleAimFactor
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2652); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2652); }
    }

    /// <summary>
    /// StructProperty: TargetScreenLoc
    /// </summary>
    public unsafe System.Numerics.Vector3 TargetScreenLoc
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 2656); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2656); }
    }

    /// <summary>
    /// FloatProperty: LoseLockTime
    /// </summary>
    public unsafe float LoseLockTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2668); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2668); }
    }
}
