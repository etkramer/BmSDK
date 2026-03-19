#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RPawnPlayerCatwomanBase<br/>
/// (size = 0)
/// (flags = 0)
/// </summary>
public partial class RPawnPlayerCatwomanBase : BmSDK.BmGame.RPawnPlayer, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RPawnPlayerCatwomanBase", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RPawnPlayerCatwomanBase() { }

    /// <summary>
    /// Constructs a new RPawnPlayerCatwomanBase
    /// </summary>
    public RPawnPlayerCatwomanBase(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RPawnPlayerCatwomanBase Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RPawnPlayerCatwomanBase(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="Engine.Actor.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RPawnPlayerCatwomanBase>
        => ((Engine.Actor)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="Engine.Actor.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RPawnPlayerCatwomanBase>, new()
        => (TComponent)((Engine.Actor)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="Engine.Actor.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RPawnPlayerCatwomanBase>
        => ((Engine.Actor)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="Engine.Actor.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RPawnPlayerCatwomanBase>
        => ((Engine.Actor)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="Engine.Actor.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RPawnPlayerCatwomanBase>
        => (TComponent)((Engine.Actor)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="Engine.Actor.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RPawnPlayerCatwomanBase>
        => ((Engine.Actor)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="Engine.Actor.DetachScriptComponent(Type)"/>
    public void DetachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RPawnPlayerCatwomanBase>
        => ((Engine.Actor)this).DetachScriptComponent(typeof(TComponent));

    /// <summary>
    /// StructProperty: vOldWallClimbPosition
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT vOldWallClimbPosition
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 10032); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 10032); }
    }

    /// <summary>
    /// ObjectProperty: WallClimbingCrawlLeftMoves
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT WallClimbingCrawlLeftMoves
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 10044); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 10044); }
    }

    /// <summary>
    /// ObjectProperty: WallClimbingCrawlRightMoves
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT WallClimbingCrawlRightMoves
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 10052); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 10052); }
    }

    /// <summary>
    /// ObjectProperty: LineLaunchingWithBatmanLaunchTargetMarker
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT LineLaunchingWithBatmanLaunchTargetMarker
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 10060); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 10060); }
    }

    /// <summary>
    /// ObjectProperty: AttachMoveConfig
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT AttachMoveConfig
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 10068); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 10068); }
    }

    /// <summary>
    /// ObjectProperty: StandingRandomOverlayOverride
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT StandingRandomOverlayOverride
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 10076); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 10076); }
    }

    /// <summary>
    /// ObjectProperty: WhipCrackFX
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT WhipCrackFX
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 10084); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 10084); }
    }

    /// <summary>
    /// ObjectProperty: TouchingCeilingVolume
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT TouchingCeilingVolume
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 10092); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 10092); }
    }

    /// <summary>
    /// ObjectProperty: SwingStartEvent
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT SwingStartEvent
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 10100); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 10100); }
    }

    /// <summary>
    /// ObjectProperty: SwingStopEvent
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT SwingStopEvent
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 10108); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 10108); }
    }

    /// <summary>
    /// ObjectProperty: JammerTakedownPlayerAnimSet
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT JammerTakedownPlayerAnimSet
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 10116); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 10116); }
    }

    /// <summary>
    /// ObjectProperty: JammerTakedownVictimAnimSet
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT JammerTakedownVictimAnimSet
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 10124); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 10124); }
    }

    /// <summary>
    /// ObjectProperty: CollarMat
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT CollarMat
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 10132); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 10132); }
    }

    /// <summary>
    /// ComponentProperty: CollarLight
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT CollarLight
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 10140); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 10140); }
    }

    /// <summary>
    /// ComponentProperty: CollarMesh
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT CollarMesh
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 10148); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 10148); }
    }

    /// <summary>
    /// ComponentProperty: WhipMesh
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT WhipMesh
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 10156); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 10156); }
    }

    /// <summary>
    /// StructProperty: OldCeilingTracePosition
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT OldCeilingTracePosition
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 10164); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 10164); }
    }

    /// <summary>
    /// BoolProperty: bPhysUseCeilingConstraints
    /// </summary>
    public unsafe bool bPhysUseCeilingConstraints
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 10176) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 10176); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 10176); }
    }

    /// <summary>
    /// BoolProperty: bFlipCeilingCamera
    /// </summary>
    public unsafe bool bFlipCeilingCamera
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 10176) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 10176); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 10176); }
    }

    /// <summary>
    /// BoolProperty: bAllowAerialWhipPounce
    /// </summary>
    public unsafe bool bAllowAerialWhipPounce
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 10176) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 10176); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 10176); }
    }

    /// <summary>
    /// BoolProperty: bAutoSwingEarlyWhip
    /// </summary>
    public unsafe bool bAutoSwingEarlyWhip
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 10176) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 10176); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 10176); }
    }

    /// <summary>
    /// BoolProperty: bAutoSwingTriggeredFromEdge
    /// </summary>
    public unsafe bool bAutoSwingTriggeredFromEdge
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 10176) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 10176); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 10176); }
    }

    /// <summary>
    /// BoolProperty: bDebugSwingAllowEarlyWhipIn
    /// </summary>
    public unsafe bool bDebugSwingAllowEarlyWhipIn
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 10176) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 10176); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 10176); }
    }

    /// <summary>
    /// BoolProperty: bDebugSwingForceEarlyWhipIn
    /// </summary>
    public unsafe bool bDebugSwingForceEarlyWhipIn
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 10176) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 10176); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 10176); }
    }

    /// <summary>
    /// BoolProperty: bDebugCeilingVisibility
    /// </summary>
    public unsafe bool bDebugCeilingVisibility
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 10176) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 10176); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 10176); }
    }

    /// <summary>
    /// BoolProperty: bDebugCeilingEdgeDetection
    /// </summary>
    public unsafe bool bDebugCeilingEdgeDetection
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 10176) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 10176); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 10176); }
    }

    /// <summary>
    /// BoolProperty: bPlayingSwingFallSound
    /// </summary>
    public unsafe bool bPlayingSwingFallSound
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 10176) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 10176); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 10176); }
    }

    /// <summary>
    /// BoolProperty: bDebugDrawFallSwingSound
    /// </summary>
    public unsafe bool bDebugDrawFallSwingSound
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 10176) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 10176); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 10176); }
    }

    /// <summary>
    /// BoolProperty: bDebugJumpOffWalls
    /// </summary>
    public unsafe bool bDebugJumpOffWalls
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 10176) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 10176); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 10176); }
    }

    /// <summary>
    /// BoolProperty: bSetCeilingBase
    /// </summary>
    public unsafe bool bSetCeilingBase
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 10176) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 10176); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 10176); }
    }

    /// <summary>
    /// NameProperty: WhipSkelControlName
    /// </summary>
    public unsafe BmSDK.FName WhipSkelControlName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 10180); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 10180); }
    }

    /// <summary>
    /// FloatProperty: MaxDirectPounceHeightToCeilings
    /// </summary>
    public unsafe float MaxDirectPounceHeightToCeilings
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 10188); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 10188); }
    }

    /// <summary>
    /// FloatProperty: WhipTrailMinAppearSpeed
    /// </summary>
    public unsafe float WhipTrailMinAppearSpeed
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 10192); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 10192); }
    }

    /// <summary>
    /// FloatProperty: MinTrailsWhipExtent
    /// </summary>
    public unsafe float MinTrailsWhipExtent
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 10196); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 10196); }
    }

    /// <summary>
    /// ArrayProperty: WhipTrails
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RPawnPlayer.XRayBoneMaterialMIC> WhipTrails
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RPawnPlayer.XRayBoneMaterialMIC>>(Ptr + 10200); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 10200); }
    }

    /// <summary>
    /// ByteProperty: AutoSwingState
    /// </summary>
    public unsafe byte AutoSwingState
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 10216); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 10216); }
    }

    /// <summary>
    /// ByteProperty: SwingDirection
    /// </summary>
    public unsafe byte SwingDirection
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 10217); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 10217); }
    }

    /// <summary>
    /// FloatProperty: CeilingSuspiciousBodyRange
    /// </summary>
    public unsafe float CeilingSuspiciousBodyRange
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 10220); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 10220); }
    }

    /// <summary>
    /// FloatProperty: CeilingSuspiciousPredThugsRange
    /// </summary>
    public unsafe float CeilingSuspiciousPredThugsRange
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 10224); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 10224); }
    }

    /// <summary>
    /// StructProperty: LastSwingSoundLocation
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT LastSwingSoundLocation
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 10228); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 10228); }
    }

    /// <summary>
    /// FloatProperty: FallSoundStartSpeed
    /// </summary>
    public unsafe float FallSoundStartSpeed
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 10240); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 10240); }
    }

    /// <summary>
    /// FloatProperty: BolasRadius
    /// </summary>
    public unsafe float BolasRadius
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 10244); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 10244); }
    }

    /// <summary>
    /// FloatProperty: BolasHeight
    /// </summary>
    public unsafe float BolasHeight
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 10248); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 10248); }
    }

    /// <summary>
    /// StructProperty: BolasShift
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT BolasShift
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 10252); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 10252); }
    }

    /// <summary>
    /// FloatProperty: BolasRBSpeedFactor
    /// </summary>
    public unsafe float BolasRBSpeedFactor
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 10264); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 10264); }
    }

    /// <summary>
    /// FloatProperty: BolasRBMaxSpeed
    /// </summary>
    public unsafe float BolasRBMaxSpeed
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 10268); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 10268); }
    }

    /// <summary>
    /// StructProperty: BolasAngularSpeed
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT BolasAngularSpeed
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 10272); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 10272); }
    }

    /// <summary>
    /// FloatProperty: LastFlushPersistentLinesFrame
    /// </summary>
    public unsafe float LastFlushPersistentLinesFrame
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 10284); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 10284); }
    }

    /// <summary>
    /// StructProperty: CeilingNormal
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT CeilingNormal
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 10288); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 10288); }
    }

    /// <summary>
    /// FloatProperty: GrateClimbUpStartCheckDistance
    /// </summary>
    public unsafe float GrateClimbUpStartCheckDistance
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 10300); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 10300); }
    }

    /// <summary>
    /// FloatProperty: GrateClimbUpTargetCheckDistance
    /// </summary>
    public unsafe float GrateClimbUpTargetCheckDistance
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 10304); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 10304); }
    }

    /// <summary>
    /// FloatProperty: GrateClimbUpTargetFloorCheckDistance
    /// </summary>
    public unsafe float GrateClimbUpTargetFloorCheckDistance
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 10308); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 10308); }
    }

    /// <summary>
    /// FloatProperty: GrateClimbDownTargetCheckDistance
    /// </summary>
    public unsafe float GrateClimbDownTargetCheckDistance
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 10312); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 10312); }
    }

    /// <summary>
    /// FloatProperty: JumpOffWallCheckDistance
    /// </summary>
    public unsafe float JumpOffWallCheckDistance
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 10316); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 10316); }
    }

    /// <summary>
    /// FloatProperty: MaxPullFromCatwalkDistance
    /// </summary>
    public unsafe float MaxPullFromCatwalkDistance
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 10320); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 10320); }
    }

    /// <summary>
    /// StructProperty: PullFromCatwalkEdgeCheckExtent
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT PullFromCatwalkEdgeCheckExtent
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 10324); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 10324); }
    }

    /// <summary>
    /// FloatProperty: PullFromCatwalkEdgeCheckShift
    /// </summary>
    public unsafe float PullFromCatwalkEdgeCheckShift
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 10336); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 10336); }
    }
}
