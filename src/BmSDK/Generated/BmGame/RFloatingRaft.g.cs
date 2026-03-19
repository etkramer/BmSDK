#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RFloatingRaft<br/>
/// (size = 0)
/// (flags = 0)
/// </summary>
public partial class RFloatingRaft : BmSDK.BmGame.ROceanSMActor, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RFloatingRaft", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RFloatingRaft() { }

    /// <summary>
    /// Constructs a new RFloatingRaft
    /// </summary>
    public RFloatingRaft(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RFloatingRaft Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RFloatingRaft(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="Engine.Actor.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RFloatingRaft>
        => ((Engine.Actor)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="Engine.Actor.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RFloatingRaft>, new()
        => (TComponent)((Engine.Actor)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="Engine.Actor.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RFloatingRaft>
        => ((Engine.Actor)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="Engine.Actor.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RFloatingRaft>
        => ((Engine.Actor)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="Engine.Actor.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RFloatingRaft>
        => (TComponent)((Engine.Actor)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="Engine.Actor.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RFloatingRaft>
        => ((Engine.Actor)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="Engine.Actor.DetachScriptComponent(Type)"/>
    public void DetachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RFloatingRaft>
        => ((Engine.Actor)this).DetachScriptComponent(typeof(TComponent));

    /// <summary>
    /// ObjectProperty: HarpoonPullMove
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT HarpoonPullMove
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 908); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 908); }
    }

    /// <summary>
    /// ObjectProperty: FromShorePullMove
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT FromShorePullMove
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 916); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 916); }
    }

    /// <summary>
    /// ObjectProperty: DamageFX
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT DamageFX
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 924); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 924); }
    }

    /// <summary>
    /// ObjectProperty: DestroyFX
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT DestroyFX
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 932); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 932); }
    }

    /// <summary>
    /// ObjectProperty: Player
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT Player
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 940); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 940); }
    }

    /// <summary>
    /// ObjectProperty: SpawnParticles
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT SpawnParticles
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 948); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 948); }
    }

    /// <summary>
    /// ObjectProperty: FrontWakeFX
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT FrontWakeFX
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 956); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 956); }
    }

    /// <summary>
    /// ObjectProperty: SideWakeFX
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT SideWakeFX
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 964); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 964); }
    }

    /// <summary>
    /// ObjectProperty: BackWakeFX
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT BackWakeFX
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 972); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 972); }
    }

    /// <summary>
    /// ObjectProperty: WakeEmitters
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT WakeEmitters_0
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 980); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 980); }
    }
    /// <summary>
    /// ObjectProperty: WakeEmitters
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT WakeEmitters_1
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 988); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 988); }
    }
    /// <summary>
    /// ObjectProperty: WakeEmitters
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT WakeEmitters_2
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 996); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 996); }
    }
    /// <summary>
    /// ObjectProperty: WakeEmitters
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT WakeEmitters_3
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 1004); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1004); }
    }

    /// <summary>
    /// ObjectProperty: RaftFloatingSound
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT RaftFloatingSound
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 1012); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1012); }
    }

    /// <summary>
    /// ObjectProperty: RaftBumpSound
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT RaftBumpSound
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 1020); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1020); }
    }

    /// <summary>
    /// ObjectProperty: ImpactRumble
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT ImpactRumble
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 1028); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1028); }
    }

    /// <summary>
    /// ObjectProperty: GrinderRumble
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT GrinderRumble
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 1036); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1036); }
    }

    /// <summary>
    /// ComponentProperty: BatclawInteraction
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT BatclawInteraction
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 1044); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1044); }
    }

    /// <summary>
    /// ComponentProperty: CylinderAttractor
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT CylinderAttractor
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 1052); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1052); }
    }

    /// <summary>
    /// FloatProperty: ForceApplicationBaseOffsetProportion
    /// </summary>
    public unsafe float ForceApplicationBaseOffsetProportion
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1060); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1060); }
    }

    /// <summary>
    /// StructProperty: RaftTargetOffset
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT RaftTargetOffset
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 1064); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1064); }
    }

    /// <summary>
    /// FloatProperty: fMaximumOceanChoppicityThatRaftCanSpawnIn
    /// </summary>
    public unsafe float fMaximumOceanChoppicityThatRaftCanSpawnIn
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1076); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1076); }
    }

    /// <summary>
    /// ArrayProperty: ReturnLocators
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.Engine.Actor.Timers>>>>>> ReturnLocators
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.Engine.Actor.Timers>>>>>>>(Ptr + 1080); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1080); }
    }

    /// <summary>
    /// IntProperty: CurrentSavedLocation
    /// </summary>
    public unsafe int CurrentSavedLocation
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1096); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1096); }
    }

    /// <summary>
    /// StructProperty: StartLocation
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT StartLocation
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 1100); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1100); }
    }

    /// <summary>
    /// BoolProperty: InitiallyFrozen
    /// </summary>
    public unsafe bool InitiallyFrozen
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1112) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1112); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1112); }
    }

    /// <summary>
    /// BoolProperty: ZeroVelocityOnDragEnd
    /// </summary>
    public unsafe bool ZeroVelocityOnDragEnd
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1112) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1112); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1112); }
    }

    /// <summary>
    /// BoolProperty: bDebugGrinder
    /// </summary>
    public unsafe bool bDebugGrinder
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1112) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1112); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1112); }
    }

    /// <summary>
    /// BoolProperty: bIceRaft
    /// </summary>
    public unsafe bool bIceRaft
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1112) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1112); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1112); }
    }

    /// <summary>
    /// BoolProperty: DockingActive
    /// </summary>
    public unsafe bool DockingActive
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1112) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1112); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1112); }
    }

    /// <summary>
    /// StructProperty: LastGrinderHitLocation
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT LastGrinderHitLocation
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 1116); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1116); }
    }

    /// <summary>
    /// FloatProperty: LastGrinderHitTime
    /// </summary>
    public unsafe float LastGrinderHitTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1128); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1128); }
    }

    /// <summary>
    /// FloatProperty: GrinderPushPeakTime
    /// </summary>
    public unsafe float GrinderPushPeakTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1132); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1132); }
    }

    /// <summary>
    /// FloatProperty: GrinderPushPeakDuration
    /// </summary>
    public unsafe float GrinderPushPeakDuration
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1136); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1136); }
    }

    /// <summary>
    /// FloatProperty: GrinderPushDuration
    /// </summary>
    public unsafe float GrinderPushDuration
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1140); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1140); }
    }

    /// <summary>
    /// FloatProperty: GrinderPushMaxForce
    /// </summary>
    public unsafe float GrinderPushMaxForce
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1144); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1144); }
    }

    /// <summary>
    /// FloatProperty: GrinderPushImpulse
    /// </summary>
    public unsafe float GrinderPushImpulse
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1148); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1148); }
    }

    /// <summary>
    /// ArrayProperty: AnchorPoints
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.Engine.Actor.Timers>>>>> AnchorPoints
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.Engine.Actor.Timers>>>>>>(Ptr + 1152); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1152); }
    }

    /// <summary>
    /// IntProperty: Health
    /// </summary>
    public unsafe int Health
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1168); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1168); }
    }

    /// <summary>
    /// IntProperty: MaxHealth
    /// </summary>
    public unsafe int MaxHealth
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1172); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1172); }
    }

    /// <summary>
    /// StructProperty: Shaker
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT Shaker
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 1176); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1176); }
    }

    /// <summary>
    /// FloatProperty: DockingForce
    /// </summary>
    public unsafe float DockingForce
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1332); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1332); }
    }

    /// <summary>
    /// StructProperty: DockingPoint
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT DockingPoint
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 1336); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1336); }
    }

    /// <summary>
    /// StructProperty: WakeOffsets
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT WakeOffsets_0
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 1348); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1348); }
    }
    /// <summary>
    /// StructProperty: WakeOffsets
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT WakeOffsets_1
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 1360); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1360); }
    }
    /// <summary>
    /// StructProperty: WakeOffsets
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT WakeOffsets_2
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 1372); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1372); }
    }
    /// <summary>
    /// StructProperty: WakeOffsets
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT WakeOffsets_3
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 1384); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1384); }
    }

    /// <summary>
    /// FloatProperty: WakeScales
    /// </summary>
    public unsafe float WakeScales_0
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1396); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1396); }
    }
    /// <summary>
    /// FloatProperty: WakeScales
    /// </summary>
    public unsafe float WakeScales_1
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1400); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1400); }
    }
    /// <summary>
    /// FloatProperty: WakeScales
    /// </summary>
    public unsafe float WakeScales_2
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1404); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1404); }
    }
    /// <summary>
    /// FloatProperty: WakeScales
    /// </summary>
    public unsafe float WakeScales_3
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1408); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1408); }
    }

    /// <summary>
    /// IntProperty: WakeEmitterTypes
    /// </summary>
    public unsafe int WakeEmitterTypes_0
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1412); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1412); }
    }
    /// <summary>
    /// IntProperty: WakeEmitterTypes
    /// </summary>
    public unsafe int WakeEmitterTypes_1
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1416); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1416); }
    }
    /// <summary>
    /// IntProperty: WakeEmitterTypes
    /// </summary>
    public unsafe int WakeEmitterTypes_2
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1420); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1420); }
    }
    /// <summary>
    /// IntProperty: WakeEmitterTypes
    /// </summary>
    public unsafe int WakeEmitterTypes_3
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1424); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1424); }
    }

    /// <summary>
    /// FloatProperty: impactRumbleVelocityThreshold
    /// </summary>
    public unsafe float impactRumbleVelocityThreshold
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1428); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1428); }
    }
}
