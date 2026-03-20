#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RFloatingRaft<br/>
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
    public unsafe BmSDK.BmGame.RSpecialMoveConfig HarpoonPullMove
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveConfig>(Ptr + 908); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 908); }
    }

    /// <summary>
    /// ObjectProperty: FromShorePullMove
    /// </summary>
    public unsafe BmSDK.BmGame.RSpecialMoveConfig FromShorePullMove
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveConfig>(Ptr + 916); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 916); }
    }

    /// <summary>
    /// ObjectProperty: DamageFX
    /// </summary>
    public unsafe BmSDK.Engine.ParticleSystem DamageFX
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleSystem>(Ptr + 924); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 924); }
    }

    /// <summary>
    /// ObjectProperty: DestroyFX
    /// </summary>
    public unsafe BmSDK.Engine.ParticleSystem DestroyFX
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleSystem>(Ptr + 932); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 932); }
    }

    /// <summary>
    /// ObjectProperty: Player
    /// </summary>
    public unsafe BmSDK.BmGame.RPawnPlayer Player
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPawnPlayer>(Ptr + 940); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 940); }
    }

    /// <summary>
    /// ObjectProperty: SpawnParticles
    /// </summary>
    public unsafe BmSDK.Engine.Emitter SpawnParticles
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.Emitter>(Ptr + 948); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 948); }
    }

    /// <summary>
    /// ObjectProperty: FrontWakeFX
    /// </summary>
    public unsafe BmSDK.Engine.ParticleSystem FrontWakeFX
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleSystem>(Ptr + 956); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 956); }
    }

    /// <summary>
    /// ObjectProperty: SideWakeFX
    /// </summary>
    public unsafe BmSDK.Engine.ParticleSystem SideWakeFX
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleSystem>(Ptr + 964); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 964); }
    }

    /// <summary>
    /// ObjectProperty: BackWakeFX
    /// </summary>
    public unsafe BmSDK.Engine.ParticleSystem BackWakeFX
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleSystem>(Ptr + 972); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 972); }
    }

    /// <summary>
    /// ObjectProperty: WakeEmitters
    /// </summary>
    public unsafe BmSDK.Engine.Emitter WakeEmitters_0
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.Emitter>(Ptr + 980); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 980); }
    }
    /// <summary>
    /// ObjectProperty: WakeEmitters
    /// </summary>
    public unsafe BmSDK.Engine.Emitter WakeEmitters_1
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.Emitter>(Ptr + 988); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 988); }
    }
    /// <summary>
    /// ObjectProperty: WakeEmitters
    /// </summary>
    public unsafe BmSDK.Engine.Emitter WakeEmitters_2
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.Emitter>(Ptr + 996); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 996); }
    }
    /// <summary>
    /// ObjectProperty: WakeEmitters
    /// </summary>
    public unsafe BmSDK.Engine.Emitter WakeEmitters_3
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.Emitter>(Ptr + 1004); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1004); }
    }

    /// <summary>
    /// ObjectProperty: RaftFloatingSound
    /// </summary>
    public unsafe BmSDK.Engine.AkEvent RaftFloatingSound
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkEvent>(Ptr + 1012); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1012); }
    }

    /// <summary>
    /// ObjectProperty: RaftBumpSound
    /// </summary>
    public unsafe BmSDK.Engine.AkEvent RaftBumpSound
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkEvent>(Ptr + 1020); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1020); }
    }

    /// <summary>
    /// ObjectProperty: ImpactRumble
    /// </summary>
    public unsafe BmSDK.Engine.ForceFeedbackWaveform ImpactRumble
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ForceFeedbackWaveform>(Ptr + 1028); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1028); }
    }

    /// <summary>
    /// ObjectProperty: GrinderRumble
    /// </summary>
    public unsafe BmSDK.Engine.ForceFeedbackWaveform GrinderRumble
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ForceFeedbackWaveform>(Ptr + 1036); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1036); }
    }

    /// <summary>
    /// ComponentProperty: BatclawInteraction
    /// </summary>
    public unsafe BmSDK.Engine.RInteractionComponent BatclawInteraction
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RInteractionComponent>(Ptr + 1044); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1044); }
    }

    /// <summary>
    /// ComponentProperty: CylinderAttractor
    /// </summary>
    public unsafe BmSDK.Engine.CylinderComponent CylinderAttractor
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.CylinderComponent>(Ptr + 1052); }
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
    public unsafe System.Numerics.Vector3 RaftTargetOffset
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 1064); }
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
    public unsafe BmSDK.TArray<BmSDK.Engine.Actor> ReturnLocators
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.Actor>>(Ptr + 1080); }
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
    public unsafe System.Numerics.Vector3 StartLocation
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 1100); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1100); }
    }

    /// <summary>
    /// BoolProperty: InitiallyFrozen
    /// </summary>
    public unsafe bool InitiallyFrozen
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1112) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1112); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1112); }
    }

    /// <summary>
    /// BoolProperty: ZeroVelocityOnDragEnd
    /// </summary>
    public unsafe bool ZeroVelocityOnDragEnd
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1112) & 2) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1112); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1112); }
    }

    /// <summary>
    /// BoolProperty: bDebugGrinder
    /// </summary>
    public unsafe bool bDebugGrinder
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1112) & 4) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1112); var newMask = value ? (currentMask | 4) : (currentMask & ~4); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1112); }
    }

    /// <summary>
    /// BoolProperty: bIceRaft
    /// </summary>
    public unsafe bool bIceRaft
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1112) & 8) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1112); var newMask = value ? (currentMask | 8) : (currentMask & ~8); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1112); }
    }

    /// <summary>
    /// BoolProperty: DockingActive
    /// </summary>
    public unsafe bool DockingActive
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1112) & 16) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1112); var newMask = value ? (currentMask | 16) : (currentMask & ~16); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1112); }
    }

    /// <summary>
    /// StructProperty: LastGrinderHitLocation
    /// </summary>
    public unsafe System.Numerics.Vector3 LastGrinderHitLocation
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 1116); }
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
    public unsafe BmSDK.TArray<System.Numerics.Vector3> AnchorPoints
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<System.Numerics.Vector3>>(Ptr + 1152); }
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
    public unsafe BmSDK.BmGame.RBMScreenShakeModifier.FBMScreenShakeStruct Shaker
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RBMScreenShakeModifier.FBMScreenShakeStruct>(Ptr + 1176); }
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
    public unsafe System.Numerics.Vector3 DockingPoint
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 1336); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1336); }
    }

    /// <summary>
    /// StructProperty: WakeOffsets
    /// </summary>
    public unsafe System.Numerics.Vector3 WakeOffsets_0
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 1348); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1348); }
    }
    /// <summary>
    /// StructProperty: WakeOffsets
    /// </summary>
    public unsafe System.Numerics.Vector3 WakeOffsets_1
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 1360); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1360); }
    }
    /// <summary>
    /// StructProperty: WakeOffsets
    /// </summary>
    public unsafe System.Numerics.Vector3 WakeOffsets_2
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 1372); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1372); }
    }
    /// <summary>
    /// StructProperty: WakeOffsets
    /// </summary>
    public unsafe System.Numerics.Vector3 WakeOffsets_3
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 1384); }
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
