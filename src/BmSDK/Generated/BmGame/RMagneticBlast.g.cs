#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RMagneticBlast<br/>
/// (size = 0)
/// (flags = 0)
/// </summary>
public partial class RMagneticBlast : BmSDK.BmGame.RInventoryGadget, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RMagneticBlast", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RMagneticBlast() { }

    /// <summary>
    /// Constructs a new RMagneticBlast
    /// </summary>
    public RMagneticBlast(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RMagneticBlast Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RMagneticBlast(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="Engine.Actor.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RMagneticBlast>
        => ((Engine.Actor)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="Engine.Actor.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RMagneticBlast>, new()
        => (TComponent)((Engine.Actor)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="Engine.Actor.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RMagneticBlast>
        => ((Engine.Actor)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="Engine.Actor.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RMagneticBlast>
        => ((Engine.Actor)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="Engine.Actor.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RMagneticBlast>
        => (TComponent)((Engine.Actor)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="Engine.Actor.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RMagneticBlast>
        => ((Engine.Actor)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="Engine.Actor.DetachScriptComponent(Type)"/>
    public void DetachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RMagneticBlast>
        => ((Engine.Actor)this).DetachScriptComponent(typeof(TComponent));

    /// <summary>
    /// ObjectProperty: PlaceReceiverMove
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT PlaceReceiverMove
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 2068); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2068); }
    }

    /// <summary>
    /// ObjectProperty: CurrentReceiverTarget
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT CurrentReceiverTarget
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 2076); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2076); }
    }

    /// <summary>
    /// ObjectProperty: ExplodeTarget
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT ExplodeTarget
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 2084); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2084); }
    }

    /// <summary>
    /// ObjectProperty: DetonatorSoundEvent
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT DetonatorSoundEvent
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 2092); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2092); }
    }

    /// <summary>
    /// ObjectProperty: PosFireSwitchName
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT PosFireSwitchName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 2100); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2100); }
    }

    /// <summary>
    /// ObjectProperty: NegFireSwitchName
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT NegFireSwitchName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 2108); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2108); }
    }

    /// <summary>
    /// ObjectProperty: FireSoundEvent
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT FireSoundEvent
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 2116); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2116); }
    }

    /// <summary>
    /// ObjectProperty: ValidMagneticSurfaceTarget
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT ValidMagneticSurfaceTarget
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 2124); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2124); }
    }

    /// <summary>
    /// ObjectProperty: MagDoorTarget
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT MagDoorTarget
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 2132); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2132); }
    }

    /// <summary>
    /// ObjectProperty: LevelMagDoorTarget
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT LevelMagDoorTarget
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 2140); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2140); }
    }

    /// <summary>
    /// ObjectProperty: InteractableItem
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT InteractableItem
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 2148); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2148); }
    }

    /// <summary>
    /// ObjectProperty: VillainTarget
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT VillainTarget
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 2156); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2156); }
    }

    /// <summary>
    /// ObjectProperty: HeliTarget
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT HeliTarget
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 2164); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2164); }
    }

    /// <summary>
    /// ObjectProperty: SuperGenerator
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT SuperGenerator
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 2172); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2172); }
    }

    /// <summary>
    /// ObjectProperty: WaterGenerator
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT WaterGenerator
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 2180); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2180); }
    }

    /// <summary>
    /// ObjectProperty: CurrentTarget
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT CurrentTarget
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 2188); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2188); }
    }

    /// <summary>
    /// ObjectProperty: MuzzleFlash
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT MuzzleFlash
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 2196); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2196); }
    }

    /// <summary>
    /// ObjectProperty: Rumble
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT Rumble
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 2204); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2204); }
    }

    /// <summary>
    /// ComponentProperty: ElectricTipPSC
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT ElectricTipPSC
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 2212); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2212); }
    }

    /// <summary>
    /// ClassProperty: ProjectileClass
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT ProjectileClass
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 2220); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2220); }
    }

    /// <summary>
    /// StructProperty: TargetLocation
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT TargetLocation
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 2228); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2228); }
    }

    /// <summary>
    /// StructProperty: DetonatorTransition
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT DetonatorTransition
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 2240); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2240); }
    }

    /// <summary>
    /// FloatProperty: FirstExplodeTime
    /// </summary>
    public unsafe float FirstExplodeTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2244); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2244); }
    }

    /// <summary>
    /// BoolProperty: bForceZeroAmmo
    /// </summary>
    public unsafe bool bForceZeroAmmo
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2248) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2248); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2248); }
    }

    /// <summary>
    /// BoolProperty: bCanRepel
    /// </summary>
    public unsafe bool bCanRepel
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2248) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2248); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2248); }
    }

    /// <summary>
    /// BoolProperty: bMagBlastAttached
    /// </summary>
    public unsafe bool bMagBlastAttached
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2248) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2248); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2248); }
    }

    /// <summary>
    /// BoolProperty: bDebugForceDisarm
    /// </summary>
    public unsafe bool bDebugForceDisarm
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2248) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2248); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2248); }
    }

    /// <summary>
    /// BoolProperty: bDebugForceFail
    /// </summary>
    public unsafe bool bDebugForceFail
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2248) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2248); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2248); }
    }

    /// <summary>
    /// BoolProperty: bCombatFire
    /// </summary>
    public unsafe bool bCombatFire
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2248) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2248); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2248); }
    }

    /// <summary>
    /// BoolProperty: bQuickDraw
    /// </summary>
    public unsafe bool bQuickDraw
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2248) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2248); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2248); }
    }

    /// <summary>
    /// BoolProperty: HasFiredProjectile
    /// </summary>
    public unsafe bool HasFiredProjectile
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2248) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2248); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2248); }
    }

    /// <summary>
    /// BoolProperty: bLockedOn
    /// </summary>
    public unsafe bool bLockedOn
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2248) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2248); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2248); }
    }

    /// <summary>
    /// BoolProperty: bCenterLightOnReceiver
    /// </summary>
    public unsafe bool bCenterLightOnReceiver
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2248) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2248); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2248); }
    }

    /// <summary>
    /// BoolProperty: bDebugIgnoreNewGamePlus
    /// </summary>
    public unsafe bool bDebugIgnoreNewGamePlus
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2248) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2248); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2248); }
    }

    /// <summary>
    /// BoolProperty: bDebugSimulateNoMagBlast
    /// </summary>
    public unsafe bool bDebugSimulateNoMagBlast
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2248) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2248); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2248); }
    }

    /// <summary>
    /// BoolProperty: bBlowUpGeneratorsOnImpact
    /// </summary>
    public unsafe bool bBlowUpGeneratorsOnImpact
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2248) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2248); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2248); }
    }

    /// <summary>
    /// ArrayProperty: Receivers
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RMagneticBlast.MainObjects> Receivers
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RMagneticBlast.MainObjects>>(Ptr + 2252); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2252); }
    }

    /// <summary>
    /// StructProperty: PlaceReceiverOverlay
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT PlaceReceiverOverlay
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 2268); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2268); }
    }

    /// <summary>
    /// ByteProperty: LastMirrorChoice
    /// </summary>
    public unsafe byte LastMirrorChoice
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 2276); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2276); }
    }

    /// <summary>
    /// ByteProperty: ImpulseType
    /// </summary>
    public unsafe byte ImpulseType
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 2277); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2277); }
    }

    /// <summary>
    /// ByteProperty: ControlType
    /// </summary>
    public unsafe byte ControlType
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 2278); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2278); }
    }

    /// <summary>
    /// StructProperty: ThrowDirectionTypes
    /// </summary>
    public unsafe BmSDK.BmGame.RMagneticBlast.MainObjects ThrowDirectionTypes_0
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RMagneticBlast.MainObjects>(Ptr + 2280); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2280); }
    }
    /// <summary>
    /// StructProperty: ThrowDirectionTypes
    /// </summary>
    public unsafe BmSDK.BmGame.RMagneticBlast.MainObjects ThrowDirectionTypes_1
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RMagneticBlast.MainObjects>(Ptr + 2296); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2296); }
    }
    /// <summary>
    /// StructProperty: ThrowDirectionTypes
    /// </summary>
    public unsafe BmSDK.BmGame.RMagneticBlast.MainObjects ThrowDirectionTypes_2
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RMagneticBlast.MainObjects>(Ptr + 2312); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2312); }
    }
    /// <summary>
    /// StructProperty: ThrowDirectionTypes
    /// </summary>
    public unsafe BmSDK.BmGame.RMagneticBlast.MainObjects ThrowDirectionTypes_3
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RMagneticBlast.MainObjects>(Ptr + 2328); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2328); }
    }
    /// <summary>
    /// StructProperty: ThrowDirectionTypes
    /// </summary>
    public unsafe BmSDK.BmGame.RMagneticBlast.MainObjects ThrowDirectionTypes_4
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RMagneticBlast.MainObjects>(Ptr + 2344); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2344); }
    }
    /// <summary>
    /// StructProperty: ThrowDirectionTypes
    /// </summary>
    public unsafe BmSDK.BmGame.RMagneticBlast.MainObjects ThrowDirectionTypes_5
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RMagneticBlast.MainObjects>(Ptr + 2360); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2360); }
    }
    /// <summary>
    /// StructProperty: ThrowDirectionTypes
    /// </summary>
    public unsafe BmSDK.BmGame.RMagneticBlast.MainObjects ThrowDirectionTypes_6
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RMagneticBlast.MainObjects>(Ptr + 2376); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2376); }
    }
    /// <summary>
    /// StructProperty: ThrowDirectionTypes
    /// </summary>
    public unsafe BmSDK.BmGame.RMagneticBlast.MainObjects ThrowDirectionTypes_7
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RMagneticBlast.MainObjects>(Ptr + 2392); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2392); }
    }
    /// <summary>
    /// StructProperty: ThrowDirectionTypes
    /// </summary>
    public unsafe BmSDK.BmGame.RMagneticBlast.MainObjects ThrowDirectionTypes_8
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RMagneticBlast.MainObjects>(Ptr + 2408); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2408); }
    }
    /// <summary>
    /// StructProperty: ThrowDirectionTypes
    /// </summary>
    public unsafe BmSDK.BmGame.RMagneticBlast.MainObjects ThrowDirectionTypes_9
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RMagneticBlast.MainObjects>(Ptr + 2424); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2424); }
    }
    /// <summary>
    /// StructProperty: ThrowDirectionTypes
    /// </summary>
    public unsafe BmSDK.BmGame.RMagneticBlast.MainObjects ThrowDirectionTypes_10
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RMagneticBlast.MainObjects>(Ptr + 2440); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2440); }
    }
    /// <summary>
    /// StructProperty: ThrowDirectionTypes
    /// </summary>
    public unsafe BmSDK.BmGame.RMagneticBlast.MainObjects ThrowDirectionTypes_11
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RMagneticBlast.MainObjects>(Ptr + 2456); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2456); }
    }
    /// <summary>
    /// StructProperty: ThrowDirectionTypes
    /// </summary>
    public unsafe BmSDK.BmGame.RMagneticBlast.MainObjects ThrowDirectionTypes_12
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RMagneticBlast.MainObjects>(Ptr + 2472); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2472); }
    }

    /// <summary>
    /// FloatProperty: MagBlastCloseRange
    /// </summary>
    public unsafe float MagBlastCloseRange
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2488); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2488); }
    }

    /// <summary>
    /// FloatProperty: MagBlastArmouredThugRange
    /// </summary>
    public unsafe float MagBlastArmouredThugRange
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2492); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2492); }
    }

    /// <summary>
    /// FloatProperty: MagBlastMaxRange
    /// </summary>
    public unsafe float MagBlastMaxRange
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2496); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2496); }
    }

    /// <summary>
    /// IntProperty: CurrentReceiver
    /// </summary>
    public unsafe int CurrentReceiver
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2500); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2500); }
    }

    /// <summary>
    /// ArrayProperty: MainObjects
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.FString>>> MainObjects
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.FString>>>>(Ptr + 2504); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2504); }
    }

    /// <summary>
    /// ArrayProperty: FrontObjects
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.TArray<BmSDK.FString>> FrontObjects
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.TArray<BmSDK.FString>>>(Ptr + 2520); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2520); }
    }

    /// <summary>
    /// ArrayProperty: ReceiverObjects
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.FString> ReceiverObjects
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.FString>>(Ptr + 2536); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2536); }
    }

    /// <summary>
    /// FloatProperty: ArmouredThugImpulse
    /// </summary>
    public unsafe float ArmouredThugImpulse
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2552); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2552); }
    }

    /// <summary>
    /// FloatProperty: ArmouredThugImpulsePitch
    /// </summary>
    public unsafe float ArmouredThugImpulsePitch
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2556); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2556); }
    }

    /// <summary>
    /// FloatProperty: ArmouredThugRagdollMassScale
    /// </summary>
    public unsafe float ArmouredThugRagdollMassScale
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2560); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2560); }
    }

    /// <summary>
    /// FloatProperty: ArmouredThugExtraRagdollRadius
    /// </summary>
    public unsafe float ArmouredThugExtraRagdollRadius
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2564); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2564); }
    }
}
