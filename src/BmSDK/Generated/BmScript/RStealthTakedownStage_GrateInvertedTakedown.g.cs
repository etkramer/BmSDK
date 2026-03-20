#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmScript;

/// <summary>
/// Class: RStealthTakedownStage_GrateInvertedTakedown<br/>
/// (flags = 0)
/// </summary>
public partial class RStealthTakedownStage_GrateInvertedTakedown : BmSDK.BmGame.RStealthTakeDownStage, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmScript.RStealthTakedownStage_GrateInvertedTakedown", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RStealthTakedownStage_GrateInvertedTakedown() { }

    /// <summary>
    /// Constructs a new RStealthTakedownStage_GrateInvertedTakedown
    /// </summary>
    public RStealthTakedownStage_GrateInvertedTakedown(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RStealthTakedownStage_GrateInvertedTakedown Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RStealthTakedownStage_GrateInvertedTakedown(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="Engine.Actor.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RStealthTakedownStage_GrateInvertedTakedown>
        => ((Engine.Actor)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="Engine.Actor.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RStealthTakedownStage_GrateInvertedTakedown>, new()
        => (TComponent)((Engine.Actor)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="Engine.Actor.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RStealthTakedownStage_GrateInvertedTakedown>
        => ((Engine.Actor)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="Engine.Actor.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RStealthTakedownStage_GrateInvertedTakedown>
        => ((Engine.Actor)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="Engine.Actor.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RStealthTakedownStage_GrateInvertedTakedown>
        => (TComponent)((Engine.Actor)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="Engine.Actor.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RStealthTakedownStage_GrateInvertedTakedown>
        => ((Engine.Actor)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="Engine.Actor.DetachScriptComponent(Type)"/>
    public void DetachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RStealthTakedownStage_GrateInvertedTakedown>
        => ((Engine.Actor)this).DetachScriptComponent(typeof(TComponent));

    /// <summary>
    /// ObjectProperty: Victim
    /// </summary>
    public unsafe BmSDK.BmGame.RPawnVillain Victim
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPawnVillain>(Ptr + 668); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 668); }
    }

    /// <summary>
    /// ObjectProperty: Victim2
    /// </summary>
    public unsafe BmSDK.BmGame.RPawnVillain Victim2
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPawnVillain>(Ptr + 676); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 676); }
    }

    /// <summary>
    /// ObjectProperty: ControlledBehaviour
    /// </summary>
    public unsafe BmSDK.BmGame.RBMBehaviour_BeingTakenDown ControlledBehaviour
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RBMBehaviour_BeingTakenDown>(Ptr + 684); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 684); }
    }

    /// <summary>
    /// ObjectProperty: CachedAttacker
    /// </summary>
    public unsafe BmSDK.BmGame.RPawnPlayer CachedAttacker
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPawnPlayer>(Ptr + 692); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 692); }
    }

    /// <summary>
    /// ObjectProperty: NotifyTakedownCamera
    /// </summary>
    public unsafe BmSDK.BmGame.RAnimNotify_TakedownCamera NotifyTakedownCamera
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RAnimNotify_TakedownCamera>(Ptr + 700); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 700); }
    }

    /// <summary>
    /// ObjectProperty: Grate
    /// </summary>
    public unsafe BmSDK.BmGame.RTunnelGrateBase Grate
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RTunnelGrateBase>(Ptr + 708); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 708); }
    }

    /// <summary>
    /// ClassProperty: DamageType
    /// </summary>
    public unsafe BmSDK.Class DamageType
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Class>(Ptr + 716); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 716); }
    }

    /// <summary>
    /// ArrayProperty: StageAnim
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RStealthTakeDownStage.FTakeDownStageAnimSet> StageAnim
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RStealthTakeDownStage.FTakeDownStageAnimSet>>(Ptr + 724); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 724); }
    }

    /// <summary>
    /// ByteProperty: NextStage
    /// </summary>
    public unsafe BmSDK.BmGame.RGameInfo.EStealthTakeDownStages NextStage
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RGameInfo.EStealthTakeDownStages>(Ptr + 740); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 740); }
    }

    /// <summary>
    /// ByteProperty: AISilentTakedownType
    /// </summary>
    public unsafe BmSDK.BmGame.RGameInfo.AAITakedownType AISilentTakedownType
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RGameInfo.AAITakedownType>(Ptr + 741); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 741); }
    }

    /// <summary>
    /// ByteProperty: BluntTraumaAchievementCategory
    /// </summary>
    public unsafe BmSDK.BmGame.RPersistentData.BluntTraumaTakedowns BluntTraumaAchievementCategory
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPersistentData.BluntTraumaTakedowns>(Ptr + 742); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 742); }
    }

    /// <summary>
    /// ByteProperty: EscapeTakedown
    /// </summary>
    public unsafe BmSDK.BmGame.RStealthTakeDownStage.EEscapeTakedownType EscapeTakedown
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RStealthTakeDownStage.EEscapeTakedownType>(Ptr + 743); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 743); }
    }

    /// <summary>
    /// BoolProperty: bAutomaticTransitionTypeChangeAfterMeetingPoint
    /// </summary>
    public unsafe bool bAutomaticTransitionTypeChangeAfterMeetingPoint
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 744) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 744); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 744); }
    }

    /// <summary>
    /// BoolProperty: bDisableCollision
    /// </summary>
    public unsafe bool bDisableCollision
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 744) & 2) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 744); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 744); }
    }

    /// <summary>
    /// BoolProperty: bVictimKnocksOverOtherThugs
    /// </summary>
    public unsafe bool bVictimKnocksOverOtherThugs
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 744) & 4) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 744); var newMask = value ? (currentMask | 4) : (currentMask & ~4); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 744); }
    }

    /// <summary>
    /// BoolProperty: bCharactersStartSynced
    /// </summary>
    public unsafe bool bCharactersStartSynced
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 744) & 8) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 744); var newMask = value ? (currentMask | 8) : (currentMask & ~8); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 744); }
    }

    /// <summary>
    /// BoolProperty: bMirrored
    /// </summary>
    public unsafe bool bMirrored
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 744) & 16) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 744); var newMask = value ? (currentMask | 16) : (currentMask & ~16); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 744); }
    }

    /// <summary>
    /// BoolProperty: bPlayedCameraAnim
    /// </summary>
    public unsafe bool bPlayedCameraAnim
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 744) & 32) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 744); var newMask = value ? (currentMask | 32) : (currentMask & ~32); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 744); }
    }

    /// <summary>
    /// BoolProperty: bSlaveCameraToAttackerMesh
    /// </summary>
    public unsafe bool bSlaveCameraToAttackerMesh
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 744) & 64) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 744); var newMask = value ? (currentMask | 64) : (currentMask & ~64); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 744); }
    }

    /// <summary>
    /// BoolProperty: bUseDOFSettingsForSpecialCameraAnim
    /// </summary>
    public unsafe bool bUseDOFSettingsForSpecialCameraAnim
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 744) & 128) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 744); var newMask = value ? (currentMask | 128) : (currentMask & ~128); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 744); }
    }

    /// <summary>
    /// BoolProperty: bIsNoisy
    /// </summary>
    public unsafe bool bIsNoisy
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 744) & 256) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 744); var newMask = value ? (currentMask | 256) : (currentMask & ~256); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 744); }
    }

    /// <summary>
    /// BoolProperty: bUseDofChange
    /// </summary>
    public unsafe bool bUseDofChange
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 744) & 512) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 744); var newMask = value ? (currentMask | 512) : (currentMask & ~512); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 744); }
    }

    /// <summary>
    /// BoolProperty: HasDoneFinaleCamera
    /// </summary>
    public unsafe bool HasDoneFinaleCamera
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 744) & 1024) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 744); var newMask = value ? (currentMask | 1024) : (currentMask & ~1024); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 744); }
    }

    /// <summary>
    /// BoolProperty: bPlayedFinaleCamera
    /// </summary>
    public unsafe bool bPlayedFinaleCamera
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 744) & 2048) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 744); var newMask = value ? (currentMask | 2048) : (currentMask & ~2048); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 744); }
    }

    /// <summary>
    /// BoolProperty: AlwaysDoAnimatedFinaleCam
    /// </summary>
    public unsafe bool AlwaysDoAnimatedFinaleCam
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 744) & 4096) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 744); var newMask = value ? (currentMask | 4096) : (currentMask & ~4096); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 744); }
    }

    /// <summary>
    /// BoolProperty: bFatal
    /// </summary>
    public unsafe bool bFatal
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 744) & 8192) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 744); var newMask = value ? (currentMask | 8192) : (currentMask & ~8192); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 744); }
    }

    /// <summary>
    /// BoolProperty: bStartsRagdoll
    /// </summary>
    public unsafe bool bStartsRagdoll
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 744) & 16384) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 744); var newMask = value ? (currentMask | 16384) : (currentMask & ~16384); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 744); }
    }

    /// <summary>
    /// BoolProperty: bAllowEarlyFinish
    /// </summary>
    public unsafe bool bAllowEarlyFinish
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 744) & 32768) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 744); var newMask = value ? (currentMask | 32768) : (currentMask & ~32768); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 744); }
    }

    /// <summary>
    /// BoolProperty: bVictimFinished
    /// </summary>
    public unsafe bool bVictimFinished
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 744) & 65536) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 744); var newMask = value ? (currentMask | 65536) : (currentMask & ~65536); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 744); }
    }

    /// <summary>
    /// BoolProperty: bNotFirstStage
    /// </summary>
    public unsafe bool bNotFirstStage
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 744) & 131072) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 744); var newMask = value ? (currentMask | 131072) : (currentMask & ~131072); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 744); }
    }

    /// <summary>
    /// BoolProperty: bUseLastTakedownId
    /// </summary>
    public unsafe bool bUseLastTakedownId
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 744) & 262144) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 744); var newMask = value ? (currentMask | 262144) : (currentMask & ~262144); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 744); }
    }

    /// <summary>
    /// BoolProperty: bUseLastStageAnimId
    /// </summary>
    public unsafe bool bUseLastStageAnimId
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 744) & 524288) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 744); var newMask = value ? (currentMask | 524288) : (currentMask & ~524288); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 744); }
    }

    /// <summary>
    /// BoolProperty: bSynchToAttackerTime
    /// </summary>
    public unsafe bool bSynchToAttackerTime
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 744) & 1048576) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 744); var newMask = value ? (currentMask | 1048576) : (currentMask & ~1048576); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 744); }
    }

    /// <summary>
    /// BoolProperty: bAllowAuthority
    /// </summary>
    public unsafe bool bAllowAuthority
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 744) & 2097152) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 744); var newMask = value ? (currentMask | 2097152) : (currentMask & ~2097152); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 744); }
    }

    /// <summary>
    /// BoolProperty: bDisarmVictimAtStart
    /// </summary>
    public unsafe bool bDisarmVictimAtStart
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 744) & 4194304) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 744); var newMask = value ? (currentMask | 4194304) : (currentMask & ~4194304); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 744); }
    }

    /// <summary>
    /// BoolProperty: bUseVictimReferenceLocation
    /// </summary>
    public unsafe bool bUseVictimReferenceLocation
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 744) & 8388608) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 744); var newMask = value ? (currentMask | 8388608) : (currentMask & ~8388608); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 744); }
    }

    /// <summary>
    /// BoolProperty: bSynchVictimRefPoint
    /// </summary>
    public unsafe bool bSynchVictimRefPoint
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 744) & 16777216) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 744); var newMask = value ? (currentMask | 16777216) : (currentMask & ~16777216); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 744); }
    }

    /// <summary>
    /// BoolProperty: SupressFinaleCamera
    /// </summary>
    public unsafe bool SupressFinaleCamera
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 744) & 33554432) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 744); var newMask = value ? (currentMask | 33554432) : (currentMask & ~33554432); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 744); }
    }

    /// <summary>
    /// BoolProperty: bCanBeAttacked
    /// </summary>
    public unsafe bool bCanBeAttacked
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 744) & 67108864) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 744); var newMask = value ? (currentMask | 67108864) : (currentMask & ~67108864); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 744); }
    }

    /// <summary>
    /// BoolProperty: bTriggeredFromCorner
    /// </summary>
    public unsafe bool bTriggeredFromCorner
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 744) & 134217728) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 744); var newMask = value ? (currentMask | 134217728) : (currentMask & ~134217728); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 744); }
    }

    /// <summary>
    /// BoolProperty: bStartsCombo
    /// </summary>
    public unsafe bool bStartsCombo
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 744) & 268435456) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 744); var newMask = value ? (currentMask | 268435456) : (currentMask & ~268435456); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 744); }
    }

    /// <summary>
    /// BoolProperty: bBreaksWindow
    /// </summary>
    public unsafe bool bBreaksWindow
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 744) & 536870912) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 744); var newMask = value ? (currentMask | 536870912) : (currentMask & ~536870912); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 744); }
    }

    /// <summary>
    /// BoolProperty: bDoingIdle
    /// </summary>
    public unsafe bool bDoingIdle
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 744) & 1073741824) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 744); var newMask = value ? (currentMask | 1073741824) : (currentMask & ~1073741824); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 744); }
    }

    /// <summary>
    /// BoolProperty: bAllowCombat
    /// </summary>
    public unsafe bool bAllowCombat
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 744) & -2147483648) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 744); var newMask = value ? (currentMask | -2147483648) : (currentMask & ~-2147483648); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 744); }
    }

    /// <summary>
    /// BoolProperty: bAllowFallOffEdges
    /// </summary>
    public unsafe bool bAllowFallOffEdges
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 748) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 748); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 748); }
    }

    /// <summary>
    /// BoolProperty: bInSmoke
    /// </summary>
    public unsafe bool bInSmoke
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 748) & 2) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 748); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 748); }
    }

    /// <summary>
    /// BoolProperty: bVictimUseCleanPoseChange
    /// </summary>
    public unsafe bool bVictimUseCleanPoseChange
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 748) & 4) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 748); var newMask = value ? (currentMask | 4) : (currentMask & ~4); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 748); }
    }

    /// <summary>
    /// BoolProperty: bDelayVictimReaction
    /// </summary>
    public unsafe bool bDelayVictimReaction
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 748) & 8) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 748); var newMask = value ? (currentMask | 8) : (currentMask & ~8); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 748); }
    }

    /// <summary>
    /// BoolProperty: bUseFallbackAnimSet
    /// </summary>
    public unsafe bool bUseFallbackAnimSet
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 748) & 16) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 748); var newMask = value ? (currentMask | 16) : (currentMask & ~16); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 748); }
    }

    /// <summary>
    /// BoolProperty: bGrabbedWeapon
    /// </summary>
    public unsafe bool bGrabbedWeapon
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 748) & 32) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 748); var newMask = value ? (currentMask | 32) : (currentMask & ~32); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 748); }
    }

    /// <summary>
    /// BoolProperty: bCanGrabWeapon
    /// </summary>
    public unsafe bool bCanGrabWeapon
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 748) & 64) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 748); var newMask = value ? (currentMask | 64) : (currentMask & ~64); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 748); }
    }

    /// <summary>
    /// BoolProperty: bUseCapeAnimNotifies
    /// </summary>
    public unsafe bool bUseCapeAnimNotifies
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 748) & 128) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 748); var newMask = value ? (currentMask | 128) : (currentMask & ~128); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 748); }
    }

    /// <summary>
    /// BoolProperty: bCanDoEscapeTakedown
    /// </summary>
    public unsafe bool bCanDoEscapeTakedown
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 748) & 256) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 748); var newMask = value ? (currentMask | 256) : (currentMask & ~256); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 748); }
    }

    /// <summary>
    /// BoolProperty: bAlwaysAllowLedgeFinish
    /// </summary>
    public unsafe bool bAlwaysAllowLedgeFinish
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 748) & 512) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 748); var newMask = value ? (currentMask | 512) : (currentMask & ~512); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 748); }
    }

    /// <summary>
    /// BoolProperty: bFearTakedown
    /// </summary>
    public unsafe bool bFearTakedown
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 748) & 1024) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 748); var newMask = value ? (currentMask | 1024) : (currentMask & ~1024); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 748); }
    }

    /// <summary>
    /// BoolProperty: bKnockoutSmash
    /// </summary>
    public unsafe bool bKnockoutSmash
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 748) & 2048) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 748); var newMask = value ? (currentMask | 2048) : (currentMask & ~2048); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 748); }
    }

    /// <summary>
    /// BoolProperty: bPlayerPressedButtonToGoToNextFearTakedown
    /// </summary>
    public unsafe bool bPlayerPressedButtonToGoToNextFearTakedown
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 748) & 4096) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 748); var newMask = value ? (currentMask | 4096) : (currentMask & ~4096); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 748); }
    }

    /// <summary>
    /// BoolProperty: bAcceptingButtonPressForFearTakedown
    /// </summary>
    public unsafe bool bAcceptingButtonPressForFearTakedown
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 748) & 8192) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 748); var newMask = value ? (currentMask | 8192) : (currentMask & ~8192); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 748); }
    }

    /// <summary>
    /// BoolProperty: bRefundFearTakedownCost
    /// </summary>
    public unsafe bool bRefundFearTakedownCost
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 748) & 16384) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 748); var newMask = value ? (currentMask | 16384) : (currentMask & ~16384); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 748); }
    }

    /// <summary>
    /// BoolProperty: bChainingFromLedge
    /// </summary>
    public unsafe bool bChainingFromLedge
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 748) & 32768) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 748); var newMask = value ? (currentMask | 32768) : (currentMask & ~32768); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 748); }
    }

    /// <summary>
    /// BoolProperty: bChainingFromWeakWall
    /// </summary>
    public unsafe bool bChainingFromWeakWall
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 748) & 65536) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 748); var newMask = value ? (currentMask | 65536) : (currentMask & ~65536); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 748); }
    }

    /// <summary>
    /// BoolProperty: bAttackerDamagedDuringTakedown
    /// </summary>
    public unsafe bool bAttackerDamagedDuringTakedown
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 748) & 131072) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 748); var newMask = value ? (currentMask | 131072) : (currentMask & ~131072); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 748); }
    }

    /// <summary>
    /// BoolProperty: bDisableCameraCollisionDuringBlendBackToPlayer
    /// </summary>
    public unsafe bool bDisableCameraCollisionDuringBlendBackToPlayer
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 748) & 262144) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 748); var newMask = value ? (currentMask | 262144) : (currentMask & ~262144); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 748); }
    }

    /// <summary>
    /// BoolProperty: bCanDoFinaleCameraInCombat
    /// </summary>
    public unsafe bool bCanDoFinaleCameraInCombat
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 748) & 524288) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 748); var newMask = value ? (currentMask | 524288) : (currentMask & ~524288); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 748); }
    }

    /// <summary>
    /// BoolProperty: bUseCharacterBonesOnlyForRagdollZoneSearch
    /// </summary>
    public unsafe bool bUseCharacterBonesOnlyForRagdollZoneSearch
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 748) & 1048576) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 748); var newMask = value ? (currentMask | 1048576) : (currentMask & ~1048576); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 748); }
    }

    /// <summary>
    /// NameProperty: CameraState
    /// </summary>
    public unsafe BmSDK.FName CameraState
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 752); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 752); }
    }

    /// <summary>
    /// StructProperty: AttackLocation
    /// </summary>
    public unsafe System.Numerics.Vector3 AttackLocation
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 760); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 760); }
    }

    /// <summary>
    /// StructProperty: ImpactScreenShake
    /// </summary>
    public unsafe BmSDK.BmGame.RBMScreenShakeModifier.FBMScreenShakeStruct ImpactScreenShake
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RBMScreenShakeModifier.FBMScreenShakeStruct>(Ptr + 772); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 772); }
    }

    /// <summary>
    /// StructProperty: CameraDOFSettings
    /// </summary>
    public unsafe BmSDK.BmGame.RGameInfo.FDofStruct CameraDOFSettings
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RGameInfo.FDofStruct>(Ptr + 928); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 928); }
    }

    /// <summary>
    /// StructProperty: StageAnims
    /// </summary>
    public unsafe BmSDK.BmGame.RStealthTakeDownStage.FTakeDownStageAnimSet StageAnims
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RStealthTakeDownStage.FTakeDownStageAnimSet>(Ptr + 948); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 948); }
    }

    /// <summary>
    /// IntProperty: StageAnimId
    /// </summary>
    public unsafe int StageAnimId
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1256); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1256); }
    }

    /// <summary>
    /// IntProperty: Damage
    /// </summary>
    public unsafe int Damage
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1260); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1260); }
    }

    /// <summary>
    /// StructProperty: TakeDownTransition
    /// </summary>
    public unsafe BmSDK.BmGame.RAnimUtil_PosePlayer.FTransitionId TakeDownTransition
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RAnimUtil_PosePlayer.FTransitionId>(Ptr + 1264); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1264); }
    }

    /// <summary>
    /// ArrayProperty: VictimTransitions
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RAnimUtil_PosePlayer.FTransitionId> VictimTransitions
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RAnimUtil_PosePlayer.FTransitionId>>(Ptr + 1268); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1268); }
    }

    /// <summary>
    /// StructProperty: CustomLocator
    /// </summary>
    public unsafe BmSDK.BmGame.REnvironmentCheckTicker.FEnvironmentSpecialMoveLocator CustomLocator
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.REnvironmentCheckTicker.FEnvironmentSpecialMoveLocator>(Ptr + 1284); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1284); }
    }

    /// <summary>
    /// IntProperty: MinVictims
    /// </summary>
    public unsafe int MinVictims
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1416); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1416); }
    }

    /// <summary>
    /// IntProperty: MaxVictims
    /// </summary>
    public unsafe int MaxVictims
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1420); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1420); }
    }

    /// <summary>
    /// StructProperty: LastReferencePosition
    /// </summary>
    public unsafe System.Numerics.Vector3 LastReferencePosition
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 1424); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1424); }
    }

    /// <summary>
    /// StructProperty: LastReferenceRotation
    /// </summary>
    public unsafe BmSDK.Rotator LastReferenceRotation
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Rotator>(Ptr + 1436); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1436); }
    }

    /// <summary>
    /// StructProperty: VictimReferencePosition
    /// </summary>
    public unsafe System.Numerics.Vector3 VictimReferencePosition
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 1448); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1448); }
    }

    /// <summary>
    /// StructProperty: VictimReferenceRotation
    /// </summary>
    public unsafe BmSDK.Rotator VictimReferenceRotation
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Rotator>(Ptr + 1460); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1460); }
    }

    /// <summary>
    /// IntProperty: ChosenAnim
    /// </summary>
    public unsafe int ChosenAnim
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1472); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1472); }
    }

    /// <summary>
    /// FloatProperty: RateScale
    /// </summary>
    public unsafe float RateScale
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1476); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1476); }
    }

    /// <summary>
    /// ArrayProperty: Victims
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RStealthTakeDownStage.FVictimStruct> Victims
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RStealthTakeDownStage.FVictimStruct>>(Ptr + 1480); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1480); }
    }

    /// <summary>
    /// ArrayProperty: GameActionsToTriggerOnFinish
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RGameInfo.EGameAction> GameActionsToTriggerOnFinish
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RGameInfo.EGameAction>>(Ptr + 1496); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1496); }
    }

    /// <summary>
    /// FloatProperty: NotifyTakedownCameraTime
    /// </summary>
    public unsafe float NotifyTakedownCameraTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1512); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1512); }
    }

    /// <summary>
    /// StructProperty: EscapeLocator
    /// </summary>
    public unsafe BmSDK.BmGame.REnvironmentCheckTicker.FEnvironmentSpecialMoveLocator EscapeLocator
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.REnvironmentCheckTicker.FEnvironmentSpecialMoveLocator>(Ptr + 1516); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1516); }
    }

    /// <summary>
    /// IntProperty: iFearTakedownEnergyCost
    /// </summary>
    public unsafe int iFearTakedownEnergyCost
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1648); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1648); }
    }

    /// <summary>
    /// FloatProperty: fTimeSpentDoingTakedown
    /// </summary>
    public unsafe float fTimeSpentDoingTakedown
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1652); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1652); }
    }

    /// <summary>
    /// FloatProperty: fVictimDropWeaponTime
    /// </summary>
    public unsafe float fVictimDropWeaponTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1656); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1656); }
    }

    /// <summary>
    /// FloatProperty: fStartingNoInterruptDuration
    /// </summary>
    public unsafe float fStartingNoInterruptDuration
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1660); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1660); }
    }

    /// <summary>
    /// Enum: AttackApproachDirection
    /// </summary>
    public enum AttackApproachDirection
    {
        AAP_Back = 0,
        AAP_Front = 1,
        AAP_Left = 2,
        AAP_Right = 3,
        AAP_Environment = 4,
        AAP_MAX = 5,
    }

    /// <summary>
    /// Struct: FTakeDownStageAnimSet
    /// </summary>
    [StructLayout(LayoutKind.Explicit)]
    public partial record struct FTakeDownStageAnimSet
    {
        /// <summary>
        /// ArrayProperty: AttackerAnimation
        /// </summary>
        public unsafe BmSDK.TArray<BmSDK.FName> AttackerAnimation
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.FName>>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// ArrayProperty: AttackerIdle
        /// </summary>
        public unsafe BmSDK.TArray<BmSDK.FName> AttackerIdle
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.FName>>(Ptr + 16); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 16); }; }
        }

        /// <summary>
        /// StrProperty: AttackerAnimationPrefix
        /// </summary>
        public unsafe BmSDK.FString AttackerAnimationPrefix
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 32); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 32); }; }
        }

        /// <summary>
        /// StrProperty: AttackerAnimationSuffix
        /// </summary>
        public unsafe BmSDK.FString AttackerAnimationSuffix
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 48); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 48); }; }
        }

        /// <summary>
        /// ObjectProperty: AttackerAnimSet
        /// </summary>
        public unsafe BmSDK.Engine.AnimSet AttackerAnimSet
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AnimSet>(Ptr + 64); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 64); }; }
        }

        /// <summary>
        /// NameProperty: DefaultCapeStateName
        /// </summary>
        public unsafe BmSDK.FName DefaultCapeStateName
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 72); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 72); }; }
        }

        /// <summary>
        /// ArrayProperty: CapeStateName
        /// </summary>
        public unsafe BmSDK.TArray<BmSDK.FName> CapeStateName
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.FName>>(Ptr + 80); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 80); }; }
        }

        /// <summary>
        /// ArrayProperty: CapeAnimName
        /// </summary>
        public unsafe BmSDK.TArray<BmSDK.FName> CapeAnimName
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.FName>>(Ptr + 96); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 96); }; }
        }

        /// <summary>
        /// NameProperty: CapeFinishStateName
        /// </summary>
        public unsafe BmSDK.FName CapeFinishStateName
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 112); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 112); }; }
        }

        /// <summary>
        /// ArrayProperty: VictimAnimations
        /// </summary>
        public unsafe BmSDK.TArray<BmSDK.BmGame.RStealthTakeDownStage.FAnimList> VictimAnimations
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RStealthTakeDownStage.FAnimList>>(Ptr + 120); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 120); }; }
        }

        /// <summary>
        /// ArrayProperty: VictimIdle
        /// </summary>
        public unsafe BmSDK.TArray<BmSDK.FName> VictimIdle
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.FName>>(Ptr + 136); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 136); }; }
        }

        /// <summary>
        /// StrProperty: VictimAnimationPrefix
        /// </summary>
        public unsafe BmSDK.FString VictimAnimationPrefix
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 152); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 152); }; }
        }

        /// <summary>
        /// StrProperty: VictimAnimationSuffix
        /// </summary>
        public unsafe BmSDK.FString VictimAnimationSuffix
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 168); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 168); }; }
        }

        /// <summary>
        /// ObjectProperty: VictimAnimSet
        /// </summary>
        public unsafe BmSDK.Engine.AnimSet VictimAnimSet
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AnimSet>(Ptr + 184); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 184); }; }
        }

        /// <summary>
        /// FloatProperty: MeetingTime
        /// </summary>
        public unsafe float MeetingTime
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 192); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 192); }; }
        }

        /// <summary>
        /// FloatProperty: AnimatedCameraFOV
        /// </summary>
        public unsafe float AnimatedCameraFOV
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 196); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 196); }; }
        }

        /// <summary>
        /// BoolProperty: bMirrored
        /// </summary>
        public unsafe bool bMirrored
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 200) & 1) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 200); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 200); }; }
        }

        /// <summary>
        /// NameProperty: AttackerEndPose
        /// </summary>
        public unsafe BmSDK.FName AttackerEndPose
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 204); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 204); }; }
        }

        /// <summary>
        /// NameProperty: VictimEndPose
        /// </summary>
        public unsafe BmSDK.FName VictimEndPose
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 212); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 212); }; }
        }

        /// <summary>
        /// ObjectProperty: CameraAnimSet
        /// </summary>
        public unsafe BmSDK.Engine.AnimSet CameraAnimSet
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AnimSet>(Ptr + 220); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 220); }; }
        }

        /// <summary>
        /// NameProperty: CameraAnimation
        /// </summary>
        public unsafe BmSDK.FName CameraAnimation
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 228); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 228); }; }
        }

        /// <summary>
        /// ArrayProperty: CameraAnimations
        /// </summary>
        public unsafe BmSDK.TArray<BmSDK.FName> CameraAnimations
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.FName>>(Ptr + 236); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 236); }; }
        }

        /// <summary>
        /// StrProperty: CameraAnimationPrefix
        /// </summary>
        public unsafe BmSDK.FString CameraAnimationPrefix
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 252); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 252); }; }
        }

        /// <summary>
        /// StrProperty: CameraAnimationSuffix
        /// </summary>
        public unsafe BmSDK.FString CameraAnimationSuffix
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 268); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 268); }; }
        }

        /// <summary>
        /// BoolProperty: OverlayAnim
        /// </summary>
        public unsafe bool OverlayAnim
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 284) & 1) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 284); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 284); }; }
        }

        /// <summary>
        /// BoolProperty: ForceCameraAnimation
        /// </summary>
        public unsafe bool ForceCameraAnimation
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 284) & 2) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 284); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 284); }; }
        }

        /// <summary>
        /// BoolProperty: bBlendBackToPlayerCameraWhenFinishedCameraAnimation
        /// </summary>
        public unsafe bool bBlendBackToPlayerCameraWhenFinishedCameraAnimation
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 284) & 4) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 284); var newMask = value ? (currentMask | 4) : (currentMask & ~4); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 284); }; }
        }

        /// <summary>
        /// BoolProperty: CameraCollision
        /// </summary>
        public unsafe bool CameraCollision
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 284) & 8) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 284); var newMask = value ? (currentMask | 8) : (currentMask & ~8); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 284); }; }
        }

        /// <summary>
        /// BoolProperty: bUseBatmanAsCameraCollisionTargetInsteadOfVictim
        /// </summary>
        public unsafe bool bUseBatmanAsCameraCollisionTargetInsteadOfVictim
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 284) & 16) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 284); var newMask = value ? (currentMask | 16) : (currentMask & ~16); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 284); }; }
        }

        /// <summary>
        /// BoolProperty: bCameraHardCut
        /// </summary>
        public unsafe bool bCameraHardCut
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 284) & 32) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 284); var newMask = value ? (currentMask | 32) : (currentMask & ~32); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 284); }; }
        }

        /// <summary>
        /// FloatProperty: fCameraBlendInTime
        /// </summary>
        public unsafe float fCameraBlendInTime
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 288); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 288); }; }
        }

        /// <summary>
        /// ByteProperty: OnStairsAnimIndex
        /// </summary>
        public unsafe byte OnStairsAnimIndex
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 292); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 292); }; }
        }

        /// <summary>
        /// BoolProperty: bUseMovementAnimSet
        /// </summary>
        public unsafe bool bUseMovementAnimSet
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 296) & 1) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 296); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 296); }; }
        }

        /// <summary>
        /// BoolProperty: bUsePredatorOverrideAnimSets
        /// </summary>
        public unsafe bool bUsePredatorOverrideAnimSets
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 296) & 2) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 296); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 296); }; }
        }

        /// <summary>
        /// NameProperty: StrikeBone
        /// </summary>
        public unsafe BmSDK.FName StrikeBone
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 300); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 300); }; }
        }
    }

    /// <summary>
    /// Struct: FAnimList
    /// </summary>
    [StructLayout(LayoutKind.Explicit)]
    public partial record struct FAnimList
    {
        /// <summary>
        /// ArrayProperty: Anims
        /// </summary>
        public unsafe BmSDK.TArray<BmSDK.FName> Anims
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.FName>>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }
    }
}
