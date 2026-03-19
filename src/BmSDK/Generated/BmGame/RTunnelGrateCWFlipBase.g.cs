#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RTunnelGrateCWFlipBase<br/>
/// (size = 0)
/// (flags = 0)
/// </summary>
public partial class RTunnelGrateCWFlipBase : BmSDK.BmGame.RSpecialMoveEnvironmentObject, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RTunnelGrateCWFlipBase", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RTunnelGrateCWFlipBase() { }

    /// <summary>
    /// Constructs a new RTunnelGrateCWFlipBase
    /// </summary>
    public RTunnelGrateCWFlipBase(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RTunnelGrateCWFlipBase Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RTunnelGrateCWFlipBase(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="Engine.Actor.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RTunnelGrateCWFlipBase>
        => ((Engine.Actor)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="Engine.Actor.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RTunnelGrateCWFlipBase>, new()
        => (TComponent)((Engine.Actor)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="Engine.Actor.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RTunnelGrateCWFlipBase>
        => ((Engine.Actor)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="Engine.Actor.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RTunnelGrateCWFlipBase>
        => ((Engine.Actor)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="Engine.Actor.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RTunnelGrateCWFlipBase>
        => (TComponent)((Engine.Actor)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="Engine.Actor.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RTunnelGrateCWFlipBase>
        => ((Engine.Actor)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="Engine.Actor.DetachScriptComponent(Type)"/>
    public void DetachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RTunnelGrateCWFlipBase>
        => ((Engine.Actor)this).DetachScriptComponent(typeof(TComponent));

    /// <summary>
    /// ObjectProperty: ExitGrateMove
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT ExitGrateMove
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 696); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 696); }
    }

    /// <summary>
    /// ObjectProperty: EnterGrateMove
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT EnterGrateMove
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 704); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 704); }
    }

    /// <summary>
    /// ObjectProperty: EnterGrate512Move
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT EnterGrate512Move
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 712); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 712); }
    }

    /// <summary>
    /// ObjectProperty: EnterGrate1024Move
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT EnterGrate1024Move
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 720); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 720); }
    }

    /// <summary>
    /// ObjectProperty: EnterGrateFromTakedownMove
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT EnterGrateFromTakedownMove
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 728); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 728); }
    }

    /// <summary>
    /// ObjectProperty: EvidenceFilterRequired
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT EvidenceFilterRequired
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 736); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 736); }
    }

    /// <summary>
    /// ObjectProperty: tempStaggMesh
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT tempStaggMesh
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 744); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 744); }
    }

    /// <summary>
    /// ObjectProperty: ThugVisionHighlightMIC
    /// </summary>
    public unsafe BmSDK.BmGame.RTunnelGrateCWFlipBase.ThugVisionHighlightMIC_DetectiveMode ThugVisionHighlightMIC
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RTunnelGrateCWFlipBase.ThugVisionHighlightMIC_DetectiveMode>(Ptr + 752); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 752); }
    }

    /// <summary>
    /// ObjectProperty: ThugVisionHighlightMIC_DetectiveMode
    /// </summary>
    public unsafe BmSDK.BmGame.RTunnelGrateCWFlipBase.VentMinesCoveringThisGrate ThugVisionHighlightMIC_DetectiveMode
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RTunnelGrateCWFlipBase.VentMinesCoveringThisGrate>(Ptr + 760); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 760); }
    }

    /// <summary>
    /// ComponentProperty: XrayLight
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT XrayLight
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 768); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 768); }
    }

    /// <summary>
    /// ComponentProperty: ThugVisionHighlightMesh_Damaged
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT ThugVisionHighlightMesh_Damaged
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 776); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 776); }
    }

    /// <summary>
    /// ComponentProperty: ThugVisionHighlightMesh
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT ThugVisionHighlightMesh
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 784); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 784); }
    }

    /// <summary>
    /// ComponentProperty: AnimatedStaticGrateMesh
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT AnimatedStaticGrateMesh
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 792); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 792); }
    }

    /// <summary>
    /// ComponentProperty: StaticGrateMesh
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT StaticGrateMesh
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 800); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 800); }
    }

    /// <summary>
    /// ComponentProperty: persistentDmgFX
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT persistentDmgFX
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 808); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 808); }
    }

    /// <summary>
    /// ComponentProperty: dmgEventFX
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT dmgEventFX
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 816); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 816); }
    }

    /// <summary>
    /// ComponentProperty: GrateMeshDamaged
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT GrateMeshDamaged
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 824); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 824); }
    }

    /// <summary>
    /// ComponentProperty: VoiceSynthesiserHighlightGrateMesh
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT VoiceSynthesiserHighlightGrateMesh
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 832); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 832); }
    }

    /// <summary>
    /// ComponentProperty: GrateMesh
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT GrateMesh
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 840); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 840); }
    }

    /// <summary>
    /// NameProperty: GrateOpenFromAboveAnim
    /// </summary>
    public unsafe BmSDK.FName GrateOpenFromAboveAnim
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 848); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 848); }
    }

    /// <summary>
    /// NameProperty: GrateOpenFromBelowAnimAnim
    /// </summary>
    public unsafe BmSDK.FName GrateOpenFromBelowAnimAnim
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 856); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 856); }
    }

    /// <summary>
    /// NameProperty: GrateOpenFromAboveCwAnim
    /// </summary>
    public unsafe BmSDK.FName GrateOpenFromAboveCwAnim
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 864); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 864); }
    }

    /// <summary>
    /// NameProperty: GrateOpenFromBelowCwAnim
    /// </summary>
    public unsafe BmSDK.FName GrateOpenFromBelowCwAnim
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 872); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 872); }
    }

    /// <summary>
    /// NameProperty: GrateOpenFromAbove512Anim
    /// </summary>
    public unsafe BmSDK.FName GrateOpenFromAbove512Anim
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 880); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 880); }
    }

    /// <summary>
    /// NameProperty: GrateOpenFromAbove1024Anim
    /// </summary>
    public unsafe BmSDK.FName GrateOpenFromAbove1024Anim
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 888); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 888); }
    }

    /// <summary>
    /// BoolProperty: bPlayingAnim
    /// </summary>
    public unsafe bool bPlayingAnim
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 896) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 896); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 896); }
    }

    /// <summary>
    /// BoolProperty: bUseAboveGrateCamera
    /// </summary>
    public unsafe bool bUseAboveGrateCamera
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 896) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 896); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 896); }
    }

    /// <summary>
    /// BoolProperty: bForceEarlyCameraExit
    /// </summary>
    public unsafe bool bForceEarlyCameraExit
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 896) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 896); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 896); }
    }

    /// <summary>
    /// BoolProperty: bCachedDisableCapeCollision
    /// </summary>
    public unsafe bool bCachedDisableCapeCollision
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 896) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 896); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 896); }
    }

    /// <summary>
    /// BoolProperty: bCachedTimedDisableCapeCollision
    /// </summary>
    public unsafe bool bCachedTimedDisableCapeCollision
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 896) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 896); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 896); }
    }

    /// <summary>
    /// BoolProperty: bCurrentCollisionDisabledState
    /// </summary>
    public unsafe bool bCurrentCollisionDisabledState
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 896) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 896); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 896); }
    }

    /// <summary>
    /// BoolProperty: bRegisteredWithMesh
    /// </summary>
    public unsafe bool bRegisteredWithMesh
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 896) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 896); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 896); }
    }

    /// <summary>
    /// BoolProperty: bDamaged
    /// </summary>
    public unsafe bool bDamaged
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 896) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 896); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 896); }
    }

    /// <summary>
    /// BoolProperty: bDamagedOutsideOfChallengeMode
    /// </summary>
    public unsafe bool bDamagedOutsideOfChallengeMode
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 896) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 896); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 896); }
    }

    /// <summary>
    /// BoolProperty: bAllowTakedownOnly
    /// </summary>
    public unsafe bool bAllowTakedownOnly
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 896) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 896); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 896); }
    }

    /// <summary>
    /// BoolProperty: hasIncendiaryChargeBeneath
    /// </summary>
    public unsafe bool hasIncendiaryChargeBeneath
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 896) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 896); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 896); }
    }

    /// <summary>
    /// BoolProperty: bHighlightedByThugVision
    /// </summary>
    public unsafe bool bHighlightedByThugVision
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 896) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 896); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 896); }
    }

    /// <summary>
    /// BoolProperty: bShowingDamagedMesh
    /// </summary>
    public unsafe bool bShowingDamagedMesh
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 896) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 896); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 896); }
    }

    /// <summary>
    /// BoolProperty: bHighlightFadeInProgress
    /// </summary>
    public unsafe bool bHighlightFadeInProgress
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 896) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 896); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 896); }
    }

    /// <summary>
    /// BoolProperty: bInXrayMode
    /// </summary>
    public unsafe bool bInXrayMode
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 896) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 896); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 896); }
    }

    /// <summary>
    /// BoolProperty: bDestroyedCalled
    /// </summary>
    public unsafe bool bDestroyedCalled
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 896) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 896); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 896); }
    }

    /// <summary>
    /// BoolProperty: bPreStreamOutCalled
    /// </summary>
    public unsafe bool bPreStreamOutCalled
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 896) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 896); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 896); }
    }

    /// <summary>
    /// BoolProperty: bImmuneToDamage
    /// </summary>
    public unsafe bool bImmuneToDamage
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 896) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 896); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 896); }
    }

    /// <summary>
    /// BoolProperty: bDontBlockDuringCombat
    /// </summary>
    public unsafe bool bDontBlockDuringCombat
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 896) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 896); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 896); }
    }

    /// <summary>
    /// BoolProperty: bAllwaysClimbOutForwards
    /// </summary>
    public unsafe bool bAllwaysClimbOutForwards
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 896) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 896); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 896); }
    }

    /// <summary>
    /// BoolProperty: DelayPlayingAnim
    /// </summary>
    public unsafe bool DelayPlayingAnim
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 896) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 896); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 896); }
    }

    /// <summary>
    /// BoolProperty: bForceInteractPromptToBeDisplayedEvenIfInteractionIsProhibited
    /// </summary>
    public unsafe bool bForceInteractPromptToBeDisplayedEvenIfInteractionIsProhibited
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 896) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 896); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 896); }
    }

    /// <summary>
    /// NameProperty: SkelMeshBoneToMatch
    /// </summary>
    public unsafe BmSDK.FName SkelMeshBoneToMatch
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 900); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 900); }
    }

    /// <summary>
    /// StructProperty: PlayerCheckExtent
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT PlayerCheckExtent
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 908); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 908); }
    }

    /// <summary>
    /// StructProperty: CheckDownOffset
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT CheckDownOffset
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 920); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 920); }
    }

    /// <summary>
    /// StructProperty: CheckUpOffset
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT CheckUpOffset
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 932); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 932); }
    }

    /// <summary>
    /// ByteProperty: TunnelGroupID
    /// </summary>
    public unsafe byte TunnelGroupID
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 944); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 944); }
    }

    /// <summary>
    /// StructProperty: AnimationRotation
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT AnimationRotation
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 948); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 948); }
    }

    /// <summary>
    /// FloatProperty: lastOpenedByThugTime
    /// </summary>
    public unsafe float lastOpenedByThugTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 960); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 960); }
    }

    /// <summary>
    /// ArrayProperty: VentMinesCoveringThisGrate
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.Engine.Actor.Timers>>>> VentMinesCoveringThisGrate
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.Engine.Actor.Timers>>>>>(Ptr + 964); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 964); }
    }

    /// <summary>
    /// FloatProperty: grateLockDuration
    /// </summary>
    public unsafe float grateLockDuration
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 980); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 980); }
    }

    /// <summary>
    /// StructProperty: StoredNavMeshLocation
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT StoredNavMeshLocation
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 984); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 984); }
    }

    /// <summary>
    /// FloatProperty: smokeAmount
    /// </summary>
    public unsafe float smokeAmount
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 996); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 996); }
    }

    /// <summary>
    /// FloatProperty: lastDamagedTime
    /// </summary>
    public unsafe float lastDamagedTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1000); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1000); }
    }

    /// <summary>
    /// ArrayProperty: pawnsCausingThugVision
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.Engine.Actor.Timers>>> pawnsCausingThugVision
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.Engine.Actor.Timers>>>>(Ptr + 1004); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1004); }
    }

    /// <summary>
    /// StructProperty: InRangeHighlightColour
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT InRangeHighlightColour
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 1020); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1020); }
    }

    /// <summary>
    /// FloatProperty: thugVisionHighlightAlpha
    /// </summary>
    public unsafe float thugVisionHighlightAlpha
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1036); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1036); }
    }

    /// <summary>
    /// FloatProperty: thugVisionHighlightFadeInTime
    /// </summary>
    public unsafe float thugVisionHighlightFadeInTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1040); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1040); }
    }

    /// <summary>
    /// FloatProperty: thugVisionHighlightFadeOutTime
    /// </summary>
    public unsafe float thugVisionHighlightFadeOutTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1044); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1044); }
    }

    /// <summary>
    /// ArrayProperty: RegisteredPolyList
    /// </summary>
    public unsafe NEED_UPDATE_ARRAYPROPERTY_LAYOUT RegisteredPolyList
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_ARRAYPROPERTY_LAYOUT>(Ptr + 1048); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1048); }
    }
}
