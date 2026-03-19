#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmScript;

/// <summary>
/// Class: RHarpoonGunBm<br/>
/// (size = 0)
/// (flags = 0)
/// </summary>
public partial class RHarpoonGunBm : BmSDK.BmGame.RHarpoonGun, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmScript.RHarpoonGunBm", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RHarpoonGunBm() { }

    /// <summary>
    /// Constructs a new RHarpoonGunBm
    /// </summary>
    public RHarpoonGunBm(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RHarpoonGunBm Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RHarpoonGunBm(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="Engine.Actor.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RHarpoonGunBm>
        => ((Engine.Actor)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="Engine.Actor.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RHarpoonGunBm>, new()
        => (TComponent)((Engine.Actor)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="Engine.Actor.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RHarpoonGunBm>
        => ((Engine.Actor)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="Engine.Actor.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RHarpoonGunBm>
        => ((Engine.Actor)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="Engine.Actor.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RHarpoonGunBm>
        => (TComponent)((Engine.Actor)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="Engine.Actor.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RHarpoonGunBm>
        => ((Engine.Actor)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="Engine.Actor.DetachScriptComponent(Type)"/>
    public void DetachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RHarpoonGunBm>
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
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2072) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2072); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2072); }
    }

    /// <summary>
    /// BoolProperty: CanFireWhenFloating
    /// </summary>
    public unsafe bool CanFireWhenFloating
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2072) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2072); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2072); }
    }

    /// <summary>
    /// BoolProperty: bHarpoonReactionOverriden
    /// </summary>
    public unsafe bool bHarpoonReactionOverriden
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2072) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2072); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2072); }
    }

    /// <summary>
    /// BoolProperty: bHarpoonedWall
    /// </summary>
    public unsafe bool bHarpoonedWall
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2072) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2072); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2072); }
    }

    /// <summary>
    /// BoolProperty: HarpooningNothing
    /// </summary>
    public unsafe bool HarpooningNothing
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2072) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2072); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2072); }
    }

    /// <summary>
    /// BoolProperty: WasDodged
    /// </summary>
    public unsafe bool WasDodged
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2072) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2072); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2072); }
    }

    /// <summary>
    /// ByteProperty: FireDirectionAnim
    /// </summary>
    public unsafe byte FireDirectionAnim
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 2076); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2076); }
    }

    /// <summary>
    /// ByteProperty: HarpoonTargetArea
    /// </summary>
    public unsafe byte HarpoonTargetArea
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 2077); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2077); }
    }

    /// <summary>
    /// ByteProperty: LastThrowType
    /// </summary>
    public unsafe byte LastThrowType
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 2078); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2078); }
    }

    /// <summary>
    /// ArrayProperty: Projectile
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.FString>>>>>>> Projectile
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.FString>>>>>>>>(Ptr + 2080); }
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
    public unsafe BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.FString>>>>>> HarpoonRope
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.FString>>>>>>>(Ptr + 2104); }
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
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT MuzzleFlashFx
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 2124); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2124); }
    }

    /// <summary>
    /// ObjectProperty: HarpoonTarget
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT HarpoonTarget
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 2132); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2132); }
    }

    /// <summary>
    /// ObjectProperty: HarpoonTargetMaterial
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT HarpoonTargetMaterial
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 2140); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2140); }
    }

    /// <summary>
    /// ObjectProperty: HarpoonYankMove
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT HarpoonYankMove
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 2148); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2148); }
    }

    /// <summary>
    /// ObjectProperty: HarpoonDragMove
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT HarpoonDragMove
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 2156); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2156); }
    }

    /// <summary>
    /// ObjectProperty: HarpoonDragTrackedObjectMove
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT HarpoonDragTrackedObjectMove
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 2164); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2164); }
    }

    /// <summary>
    /// ObjectProperty: HarpoonDragTriggerMove
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT HarpoonDragTriggerMove
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 2172); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2172); }
    }

    /// <summary>
    /// ObjectProperty: HarpoonFireMove
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT HarpoonFireMove
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 2180); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2180); }
    }

    /// <summary>
    /// ObjectProperty: CornerFireMove
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT CornerFireMove
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 2188); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2188); }
    }

    /// <summary>
    /// ObjectProperty: HarpoonFailMove
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT HarpoonFailMove
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 2196); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2196); }
    }

    /// <summary>
    /// ObjectProperty: HarpoonThugMove
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT HarpoonThugMove
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 2204); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2204); }
    }

    /// <summary>
    /// ObjectProperty: HarpoonGlideKickMove
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT HarpoonGlideKickMove
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 2212); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2212); }
    }

    /// <summary>
    /// ObjectProperty: TargetIcon
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT TargetIcon
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 2220); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2220); }
    }

    /// <summary>
    /// ObjectProperty: FireSound
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT FireSound
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 2228); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2228); }
    }

    /// <summary>
    /// ObjectProperty: CameraFireSound
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT CameraFireSound
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 2236); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2236); }
    }

    /// <summary>
    /// ObjectProperty: ClawReleaseSound
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT ClawReleaseSound
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 2244); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2244); }
    }

    /// <summary>
    /// ObjectProperty: DummyFireActor
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT DummyFireActor
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 2252); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2252); }
    }

    /// <summary>
    /// ObjectProperty: CantHarpoonWinchableObjectThought
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT CantHarpoonWinchableObjectThought
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 2260); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2260); }
    }

    /// <summary>
    /// StructProperty: HarpoonTargetPos
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT HarpoonTargetPos_0
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 2268); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2268); }
    }
    /// <summary>
    /// StructProperty: HarpoonTargetPos
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT HarpoonTargetPos_1
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 2280); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2280); }
    }
    /// <summary>
    /// StructProperty: HarpoonTargetPos
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT HarpoonTargetPos_2
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 2292); }
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
    public unsafe BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.FString>>>>> ProjectileAttachSocket
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.FString>>>>>>(Ptr + 2312); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2312); }
    }

    /// <summary>
    /// ArrayProperty: ProjectileRetractRope
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.FString>>>> ProjectileRetractRope
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.FString>>>>>(Ptr + 2328); }
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
    public unsafe BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.FString>>> CurrentTargets
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.FString>>>>(Ptr + 2352); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2352); }
    }

    /// <summary>
    /// ArrayProperty: CurrentTargetParts
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.TArray<BmSDK.FString>> CurrentTargetParts
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.TArray<BmSDK.FString>>>(Ptr + 2368); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2368); }
    }

    /// <summary>
    /// ArrayProperty: UltraBatClawGrateSockets
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.FString> UltraBatClawGrateSockets
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.FString>>(Ptr + 2384); }
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
