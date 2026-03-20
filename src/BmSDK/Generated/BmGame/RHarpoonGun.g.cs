#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RHarpoonGun<br/>
/// (flags = 0)
/// </summary>
public partial class RHarpoonGun : BmSDK.BmGame.RInventoryGadget, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RHarpoonGun", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RHarpoonGun() { }

    /// <summary>
    /// Constructs a new RHarpoonGun
    /// </summary>
    public RHarpoonGun(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RHarpoonGun Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RHarpoonGun(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="Engine.Actor.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RHarpoonGun>
        => ((Engine.Actor)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="Engine.Actor.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RHarpoonGun>, new()
        => (TComponent)((Engine.Actor)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="Engine.Actor.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RHarpoonGun>
        => ((Engine.Actor)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="Engine.Actor.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RHarpoonGun>
        => ((Engine.Actor)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="Engine.Actor.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RHarpoonGun>
        => (TComponent)((Engine.Actor)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="Engine.Actor.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RHarpoonGun>
        => ((Engine.Actor)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="Engine.Actor.DetachScriptComponent(Type)"/>
    public void DetachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RHarpoonGun>
        => ((Engine.Actor)this).DetachScriptComponent(typeof(TComponent));

    /// <summary>
    /// FloatProperty: HarpoonRange
    /// </summary>
    public unsafe float HarpoonRange
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2068); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2068); }
    }

    /// <summary>
    /// BoolProperty: CanHarpoonWalls
    /// </summary>
    public unsafe bool CanHarpoonWalls
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2072) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2072); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2072); }
    }

    /// <summary>
    /// BoolProperty: CanFireWhenFloating
    /// </summary>
    public unsafe bool CanFireWhenFloating
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2072) & 2) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2072); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2072); }
    }

    /// <summary>
    /// BoolProperty: bHarpoonReactionOverriden
    /// </summary>
    public unsafe bool bHarpoonReactionOverriden
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2072) & 4) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2072); var newMask = value ? (currentMask | 4) : (currentMask & ~4); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2072); }
    }

    /// <summary>
    /// BoolProperty: bHarpoonedWall
    /// </summary>
    public unsafe bool bHarpoonedWall
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2072) & 8) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2072); var newMask = value ? (currentMask | 8) : (currentMask & ~8); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2072); }
    }

    /// <summary>
    /// BoolProperty: HarpooningNothing
    /// </summary>
    public unsafe bool HarpooningNothing
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2072) & 16) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2072); var newMask = value ? (currentMask | 16) : (currentMask & ~16); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2072); }
    }

    /// <summary>
    /// BoolProperty: WasDodged
    /// </summary>
    public unsafe bool WasDodged
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2072) & 32) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2072); var newMask = value ? (currentMask | 32) : (currentMask & ~32); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2072); }
    }

    /// <summary>
    /// ByteProperty: FireDirectionAnim
    /// </summary>
    public unsafe BmSDK.BmGame.RHarpoonGun.EBatclawFireDirections FireDirectionAnim
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RHarpoonGun.EBatclawFireDirections>(Ptr + 2076); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2076); }
    }

    /// <summary>
    /// ByteProperty: HarpoonTargetArea
    /// </summary>
    public unsafe BmSDK.BmGame.RHarpoonGun.HarpoonAttackType HarpoonTargetArea
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RHarpoonGun.HarpoonAttackType>(Ptr + 2077); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2077); }
    }

    /// <summary>
    /// ByteProperty: LastThrowType
    /// </summary>
    public unsafe BmSDK.BmGame.RInventoryGadget.BatarangThrowType LastThrowType
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RInventoryGadget.BatarangThrowType>(Ptr + 2078); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2078); }
    }

    /// <summary>
    /// ArrayProperty: Projectile
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RHarpoonProjectile> Projectile
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RHarpoonProjectile>>(Ptr + 2080); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2080); }
    }

    /// <summary>
    /// NameProperty: TargetSocketForProjectile
    /// </summary>
    public unsafe BmSDK.FName TargetSocketForProjectile
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 2096); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2096); }
    }

    /// <summary>
    /// ArrayProperty: HarpoonRope
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RSimpleRopeComponent> HarpoonRope
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RSimpleRopeComponent>>(Ptr + 2104); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2104); }
    }

    /// <summary>
    /// IntProperty: RopeInitTimer
    /// </summary>
    public unsafe int RopeInitTimer
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2120); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2120); }
    }

    /// <summary>
    /// ObjectProperty: MuzzleFlashFx
    /// </summary>
    public unsafe BmSDK.Engine.ParticleSystem MuzzleFlashFx
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleSystem>(Ptr + 2124); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2124); }
    }

    /// <summary>
    /// ObjectProperty: HarpoonTarget
    /// </summary>
    public unsafe BmSDK.Engine.Actor HarpoonTarget
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.Actor>(Ptr + 2132); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2132); }
    }

    /// <summary>
    /// ObjectProperty: HarpoonTargetMaterial
    /// </summary>
    public unsafe BmSDK.Engine.PhysicalMaterial HarpoonTargetMaterial
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.PhysicalMaterial>(Ptr + 2140); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2140); }
    }

    /// <summary>
    /// ObjectProperty: HarpoonYankMove
    /// </summary>
    public unsafe BmSDK.BmGame.RSpecialMoveConfig HarpoonYankMove
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveConfig>(Ptr + 2148); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2148); }
    }

    /// <summary>
    /// ObjectProperty: HarpoonDragMove
    /// </summary>
    public unsafe BmSDK.BmGame.RSpecialMoveConfig HarpoonDragMove
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveConfig>(Ptr + 2156); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2156); }
    }

    /// <summary>
    /// ObjectProperty: HarpoonDragTrackedObjectMove
    /// </summary>
    public unsafe BmSDK.BmGame.RSpecialMoveConfig HarpoonDragTrackedObjectMove
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveConfig>(Ptr + 2164); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2164); }
    }

    /// <summary>
    /// ObjectProperty: HarpoonDragTriggerMove
    /// </summary>
    public unsafe BmSDK.BmGame.RSpecialMoveConfig HarpoonDragTriggerMove
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveConfig>(Ptr + 2172); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2172); }
    }

    /// <summary>
    /// ObjectProperty: HarpoonFireMove
    /// </summary>
    public unsafe BmSDK.BmGame.RSpecialMoveConfig HarpoonFireMove
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveConfig>(Ptr + 2180); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2180); }
    }

    /// <summary>
    /// ObjectProperty: CornerFireMove
    /// </summary>
    public unsafe BmSDK.BmGame.RSpecialMoveConfig CornerFireMove
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveConfig>(Ptr + 2188); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2188); }
    }

    /// <summary>
    /// ObjectProperty: HarpoonFailMove
    /// </summary>
    public unsafe BmSDK.BmGame.RSpecialMoveConfig HarpoonFailMove
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveConfig>(Ptr + 2196); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2196); }
    }

    /// <summary>
    /// ObjectProperty: HarpoonThugMove
    /// </summary>
    public unsafe BmSDK.BmGame.RSpecialMoveConfig HarpoonThugMove
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveConfig>(Ptr + 2204); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2204); }
    }

    /// <summary>
    /// ObjectProperty: HarpoonGlideKickMove
    /// </summary>
    public unsafe BmSDK.BmGame.RSpecialMoveConfig HarpoonGlideKickMove
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveConfig>(Ptr + 2212); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2212); }
    }

    /// <summary>
    /// ObjectProperty: TargetIcon
    /// </summary>
    public unsafe BmSDK.Engine.Material TargetIcon
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.Material>(Ptr + 2220); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2220); }
    }

    /// <summary>
    /// ObjectProperty: FireSound
    /// </summary>
    public unsafe BmSDK.Engine.AkEvent FireSound
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkEvent>(Ptr + 2228); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2228); }
    }

    /// <summary>
    /// ObjectProperty: CameraFireSound
    /// </summary>
    public unsafe BmSDK.Engine.AkEvent CameraFireSound
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkEvent>(Ptr + 2236); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2236); }
    }

    /// <summary>
    /// ObjectProperty: ClawReleaseSound
    /// </summary>
    public unsafe BmSDK.Engine.AkEvent ClawReleaseSound
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkEvent>(Ptr + 2244); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2244); }
    }

    /// <summary>
    /// ObjectProperty: DummyFireActor
    /// </summary>
    public unsafe BmSDK.Engine.Actor DummyFireActor
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.Actor>(Ptr + 2252); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2252); }
    }

    /// <summary>
    /// ObjectProperty: CantHarpoonWinchableObjectThought
    /// </summary>
    public unsafe BmSDK.Engine.AkDialogueSpeech CantHarpoonWinchableObjectThought
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkDialogueSpeech>(Ptr + 2260); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2260); }
    }

    /// <summary>
    /// StructProperty: HarpoonTargetPos
    /// </summary>
    public unsafe System.Numerics.Vector3 HarpoonTargetPos_0
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 2268); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2268); }
    }
    /// <summary>
    /// StructProperty: HarpoonTargetPos
    /// </summary>
    public unsafe System.Numerics.Vector3 HarpoonTargetPos_1
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 2280); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2280); }
    }
    /// <summary>
    /// StructProperty: HarpoonTargetPos
    /// </summary>
    public unsafe System.Numerics.Vector3 HarpoonTargetPos_2
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 2292); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2292); }
    }

    /// <summary>
    /// FloatProperty: HarpoonYankRadius
    /// </summary>
    public unsafe float HarpoonYankRadius
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2304); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2304); }
    }

    /// <summary>
    /// IntProperty: MaxYankTargets
    /// </summary>
    public unsafe int MaxYankTargets
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2308); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2308); }
    }

    /// <summary>
    /// ArrayProperty: ProjectileAttachSocket
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.FName> ProjectileAttachSocket
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.FName>>(Ptr + 2312); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2312); }
    }

    /// <summary>
    /// ArrayProperty: ProjectileRetractRope
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RRopeComponentBase> ProjectileRetractRope
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RRopeComponentBase>>(Ptr + 2328); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2328); }
    }

    /// <summary>
    /// FloatProperty: IconSize
    /// </summary>
    public unsafe float IconSize
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2344); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2344); }
    }

    /// <summary>
    /// FloatProperty: EnemyTargetAngle
    /// </summary>
    public unsafe float EnemyTargetAngle
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2348); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2348); }
    }

    /// <summary>
    /// ArrayProperty: CurrentTargets
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.Engine.Actor> CurrentTargets
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.Actor>>(Ptr + 2352); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2352); }
    }

    /// <summary>
    /// ArrayProperty: CurrentTargetParts
    /// </summary>
    public unsafe BmSDK.TArray<int> CurrentTargetParts
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<int>>(Ptr + 2368); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2368); }
    }

    /// <summary>
    /// ArrayProperty: UltraBatClawGrateSockets
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.FName> UltraBatClawGrateSockets
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.FName>>(Ptr + 2384); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2384); }
    }

    /// <summary>
    /// IntProperty: TargetPhase
    /// </summary>
    public unsafe int TargetPhase
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2400); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2400); }
    }
}
