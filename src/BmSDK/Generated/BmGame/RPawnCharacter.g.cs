#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RPawnCharacter<br/>
/// (flags = 0)
/// </summary>
public partial class RPawnCharacter : BmSDK.BmGame.RPawn, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RPawnCharacter", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RPawnCharacter() { }

    /// <summary>
    /// Constructs a new RPawnCharacter
    /// </summary>
    public RPawnCharacter(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RPawnCharacter Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RPawnCharacter(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="Engine.Actor.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RPawnCharacter>
        => ((Engine.Actor)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="Engine.Actor.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RPawnCharacter>, new()
        => (TComponent)((Engine.Actor)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="Engine.Actor.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RPawnCharacter>
        => ((Engine.Actor)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="Engine.Actor.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RPawnCharacter>
        => ((Engine.Actor)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="Engine.Actor.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RPawnCharacter>
        => (TComponent)((Engine.Actor)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="Engine.Actor.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RPawnCharacter>
        => ((Engine.Actor)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="Engine.Actor.DetachScriptComponent(Type)"/>
    public void DetachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RPawnCharacter>
        => ((Engine.Actor)this).DetachScriptComponent(typeof(TComponent));

    /// <summary>
    /// ObjectProperty: AIController
    /// </summary>
    public unsafe BmSDK.BmGame.RBMAIController AIController
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RBMAIController>(Ptr + 1796); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1796); }
    }

    /// <summary>
    /// ObjectProperty: PlayerController
    /// </summary>
    public unsafe BmSDK.BmGame.RPlayerControllerCombat PlayerController
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPlayerControllerCombat>(Ptr + 1804); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1804); }
    }

    /// <summary>
    /// ObjectProperty: Anim
    /// </summary>
    public unsafe BmSDK.BmGame.RAnimNode_Pose Anim
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RAnimNode_Pose>(Ptr + 1812); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1812); }
    }

    /// <summary>
    /// ObjectProperty: ActualWeapon
    /// </summary>
    public unsafe BmSDK.Engine.Inventory ActualWeapon
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.Inventory>(Ptr + 1820); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1820); }
    }

    /// <summary>
    /// ObjectProperty: UnarmedWeaponConfig
    /// </summary>
    public unsafe BmSDK.BmGame.RWeaponConfig UnarmedWeaponConfig
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RWeaponConfig>(Ptr + 1828); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1828); }
    }

    /// <summary>
    /// ObjectProperty: OverrideUnarmedWeaponConfig
    /// </summary>
    public unsafe BmSDK.BmGame.RWeaponConfig OverrideUnarmedWeaponConfig
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RWeaponConfig>(Ptr + 1836); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1836); }
    }

    /// <summary>
    /// ObjectProperty: CarriedObject
    /// </summary>
    public unsafe BmSDK.BmGame.RCarriableObjectBase CarriedObject
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RCarriableObjectBase>(Ptr + 1844); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1844); }
    }

    /// <summary>
    /// ObjectProperty: GetUpMaster
    /// </summary>
    public unsafe BmSDK.BmGame.RPawnCharacter GetUpMaster
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPawnCharacter>(Ptr + 1852); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1852); }
    }

    /// <summary>
    /// ObjectProperty: GetUpAnimset
    /// </summary>
    public unsafe BmSDK.Engine.AnimSet GetUpAnimset
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AnimSet>(Ptr + 1860); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1860); }
    }

    /// <summary>
    /// ObjectProperty: SoundCharacterAudioFilter
    /// </summary>
    public unsafe BmSDK.Engine.AkCharacterFilter SoundCharacterAudioFilter
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkCharacterFilter>(Ptr + 1868); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1868); }
    }

    /// <summary>
    /// ObjectProperty: IgnoreCollisionWithPawn
    /// </summary>
    public unsafe BmSDK.Engine.Actor IgnoreCollisionWithPawn
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.Actor>(Ptr + 1876); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1876); }
    }

    /// <summary>
    /// ObjectProperty: Tweak_Anim_AnimSet
    /// </summary>
    public unsafe BmSDK.Engine.AnimSet Tweak_Anim_AnimSet
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AnimSet>(Ptr + 1884); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1884); }
    }

    /// <summary>
    /// ObjectProperty: CurrentRiotObjectLeftHand
    /// </summary>
    public unsafe BmSDK.BmGame.RRiotObjectBase CurrentRiotObjectLeftHand
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RRiotObjectBase>(Ptr + 1892); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1892); }
    }

    /// <summary>
    /// ObjectProperty: CurrentRiotObjectRightHand
    /// </summary>
    public unsafe BmSDK.BmGame.RRiotObjectBase CurrentRiotObjectRightHand
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RRiotObjectBase>(Ptr + 1900); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1900); }
    }

    /// <summary>
    /// ComponentProperty: BodyConstrainingComponent
    /// </summary>
    public unsafe BmSDK.BmGame.RConstrainingComponent BodyConstrainingComponent
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RConstrainingComponent>(Ptr + 1908); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1908); }
    }

    /// <summary>
    /// BoolProperty: AllowFlappyBits
    /// </summary>
    public unsafe bool AllowFlappyBits
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1916) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1916); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1916); }
    }

    /// <summary>
    /// BoolProperty: AlwaysUsePhysics
    /// </summary>
    public unsafe bool AlwaysUsePhysics
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1916) & 2) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1916); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1916); }
    }

    /// <summary>
    /// BoolProperty: DisableRagdollCalming
    /// </summary>
    public unsafe bool DisableRagdollCalming
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1916) & 4) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1916); var newMask = value ? (currentMask | 4) : (currentMask & ~4); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1916); }
    }

    /// <summary>
    /// BoolProperty: AllowProceduralBreathing
    /// </summary>
    public unsafe bool AllowProceduralBreathing
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1916) & 8) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1916); var newMask = value ? (currentMask | 8) : (currentMask & ~8); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1916); }
    }

    /// <summary>
    /// BoolProperty: AllowCustomPhysics
    /// </summary>
    public unsafe bool AllowCustomPhysics
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1916) & 16) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1916); var newMask = value ? (currentMask | 16) : (currentMask & ~16); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1916); }
    }

    /// <summary>
    /// BoolProperty: AllowCustomPhysicsUpdate
    /// </summary>
    public unsafe bool AllowCustomPhysicsUpdate
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1916) & 32) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1916); var newMask = value ? (currentMask | 32) : (currentMask & ~32); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1916); }
    }

    /// <summary>
    /// BoolProperty: EnableFloorCorrection
    /// </summary>
    public unsafe bool EnableFloorCorrection
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1916) & 64) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1916); var newMask = value ? (currentMask | 64) : (currentMask & ~64); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1916); }
    }

    /// <summary>
    /// BoolProperty: AllowFloorCorrectionRaycast
    /// </summary>
    public unsafe bool AllowFloorCorrectionRaycast
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1916) & 128) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1916); var newMask = value ? (currentMask | 128) : (currentMask & ~128); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1916); }
    }

    /// <summary>
    /// BoolProperty: ReduceBlinksAndEyeMovements
    /// </summary>
    public unsafe bool ReduceBlinksAndEyeMovements
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1916) & 256) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1916); var newMask = value ? (currentMask | 256) : (currentMask & ~256); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1916); }
    }

    /// <summary>
    /// BoolProperty: InsideChangePose
    /// </summary>
    public unsafe bool InsideChangePose
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1916) & 512) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1916); var newMask = value ? (currentMask | 512) : (currentMask & ~512); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1916); }
    }

    /// <summary>
    /// BoolProperty: bPlayConfusedGetup
    /// </summary>
    public unsafe bool bPlayConfusedGetup
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1916) & 1024) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1916); var newMask = value ? (currentMask | 1024) : (currentMask & ~1024); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1916); }
    }

    /// <summary>
    /// BoolProperty: bDisableScrambleGetup
    /// </summary>
    public unsafe bool bDisableScrambleGetup
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1916) & 2048) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1916); var newMask = value ? (currentMask | 2048) : (currentMask & ~2048); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1916); }
    }

    /// <summary>
    /// BoolProperty: bBounceIntoCombat
    /// </summary>
    public unsafe bool bBounceIntoCombat
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1916) & 4096) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1916); var newMask = value ? (currentMask | 4096) : (currentMask & ~4096); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1916); }
    }

    /// <summary>
    /// BoolProperty: bForceScrambleIntoCombat
    /// </summary>
    public unsafe bool bForceScrambleIntoCombat
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1916) & 8192) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1916); var newMask = value ? (currentMask | 8192) : (currentMask & ~8192); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1916); }
    }

    /// <summary>
    /// BoolProperty: bConstrainingComponentNeedsUpdate
    /// </summary>
    public unsafe bool bConstrainingComponentNeedsUpdate
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1916) & 16384) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1916); var newMask = value ? (currentMask | 16384) : (currentMask & ~16384); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1916); }
    }

    /// <summary>
    /// BoolProperty: bIsRobot
    /// </summary>
    public unsafe bool bIsRobot
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1916) & 32768) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1916); var newMask = value ? (currentMask | 32768) : (currentMask & ~32768); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1916); }
    }

    /// <summary>
    /// BoolProperty: SilentRagdoll
    /// </summary>
    public unsafe bool SilentRagdoll
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1916) & 65536) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1916); var newMask = value ? (currentMask | 65536) : (currentMask & ~65536); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1916); }
    }

    /// <summary>
    /// BoolProperty: bNoBackscreenSupport
    /// </summary>
    public unsafe bool bNoBackscreenSupport
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1916) & 131072) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1916); var newMask = value ? (currentMask | 131072) : (currentMask & ~131072); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1916); }
    }

    /// <summary>
    /// BoolProperty: bForceGetupFacing
    /// </summary>
    public unsafe bool bForceGetupFacing
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1916) & 262144) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1916); var newMask = value ? (currentMask | 262144) : (currentMask & ~262144); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1916); }
    }

    /// <summary>
    /// BoolProperty: bConstrainRagdollToDynamicNavMesh
    /// </summary>
    public unsafe bool bConstrainRagdollToDynamicNavMesh
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1916) & 524288) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1916); var newMask = value ? (currentMask | 524288) : (currentMask & ~524288); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1916); }
    }

    /// <summary>
    /// BoolProperty: bDisableRagdollVsNavMeshConstraint
    /// </summary>
    public unsafe bool bDisableRagdollVsNavMeshConstraint
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1916) & 1048576) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1916); var newMask = value ? (currentMask | 1048576) : (currentMask & ~1048576); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1916); }
    }

    /// <summary>
    /// BoolProperty: bTempDisableRagdollVsNavMeshConstraint
    /// </summary>
    public unsafe bool bTempDisableRagdollVsNavMeshConstraint
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1916) & 2097152) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1916); var newMask = value ? (currentMask | 2097152) : (currentMask & ~2097152); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1916); }
    }

    /// <summary>
    /// BoolProperty: bTempForceRagdollVsNavMeshConstraint
    /// </summary>
    public unsafe bool bTempForceRagdollVsNavMeshConstraint
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1916) & 4194304) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1916); var newMask = value ? (currentMask | 4194304) : (currentMask & ~4194304); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1916); }
    }

    /// <summary>
    /// BoolProperty: bLastFrameWasRagdoll
    /// </summary>
    public unsafe bool bLastFrameWasRagdoll
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1916) & 8388608) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1916); var newMask = value ? (currentMask | 8388608) : (currentMask & ~8388608); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1916); }
    }

    /// <summary>
    /// BoolProperty: bAllowBaseRotationOnPawn
    /// </summary>
    public unsafe bool bAllowBaseRotationOnPawn
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1916) & 16777216) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1916); var newMask = value ? (currentMask | 16777216) : (currentMask & ~16777216); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1916); }
    }

    /// <summary>
    /// BoolProperty: Tweak_FaceFXRegisters_Enabled
    /// </summary>
    public unsafe bool Tweak_FaceFXRegisters_Enabled
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1916) & 33554432) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1916); var newMask = value ? (currentMask | 33554432) : (currentMask & ~33554432); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1916); }
    }

    /// <summary>
    /// BoolProperty: Tweak_Anim_Enabled
    /// </summary>
    public unsafe bool Tweak_Anim_Enabled
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1916) & 67108864) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1916); var newMask = value ? (currentMask | 67108864) : (currentMask & ~67108864); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1916); }
    }

    /// <summary>
    /// BoolProperty: bSpedUpGetUpAnim
    /// </summary>
    public unsafe bool bSpedUpGetUpAnim
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1916) & 134217728) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1916); var newMask = value ? (currentMask | 134217728) : (currentMask & ~134217728); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1916); }
    }

    /// <summary>
    /// ArrayProperty: MatineeControlReferences
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.Engine.InterpGroupInst> MatineeControlReferences
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.InterpGroupInst>>(Ptr + 1920); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1920); }
    }

    /// <summary>
    /// ArrayProperty: Bodysounds
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RPawnCharacter.FSoundTracking> Bodysounds
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RPawnCharacter.FSoundTracking>>(Ptr + 1936); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1936); }
    }

    /// <summary>
    /// StructProperty: PreviousPose
    /// </summary>
    public unsafe BmSDK.BmGame.RAnimNode_Pose.FPreviousPoseDescription PreviousPose
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RAnimNode_Pose.FPreviousPoseDescription>(Ptr + 1952); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1952); }
    }

    /// <summary>
    /// StructProperty: Pose
    /// </summary>
    public unsafe BmSDK.BmGame.RAnimNode_Pose.FPoseDescription Pose
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RAnimNode_Pose.FPoseDescription>(Ptr + 2056); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2056); }
    }

    /// <summary>
    /// NameProperty: GetUpTargetMovementStance
    /// </summary>
    public unsafe BmSDK.FName GetUpTargetMovementStance
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 2416); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2416); }
    }

    /// <summary>
    /// NameProperty: GetUpTargetWeaponStance
    /// </summary>
    public unsafe BmSDK.FName GetUpTargetWeaponStance
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 2424); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2424); }
    }

    /// <summary>
    /// StructProperty: GetUpTransitionID
    /// </summary>
    public unsafe BmSDK.BmGame.RAnimUtil_PosePlayer.FTransitionId GetUpTransitionID
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RAnimUtil_PosePlayer.FTransitionId>(Ptr + 2432); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2432); }
    }

    /// <summary>
    /// StructProperty: GetUpMasterAnimID
    /// </summary>
    public unsafe BmSDK.BmGame.RAnimUtil_PosePlayer.FTransitionId GetUpMasterAnimID
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RAnimUtil_PosePlayer.FTransitionId>(Ptr + 2436); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2436); }
    }

    /// <summary>
    /// NameProperty: GetUpAnimName
    /// </summary>
    public unsafe BmSDK.FName GetUpAnimName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 2440); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2440); }
    }

    /// <summary>
    /// FloatProperty: GetupBlendOutDuration
    /// </summary>
    public unsafe float GetupBlendOutDuration
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2448); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2448); }
    }

    /// <summary>
    /// FloatProperty: TimeOfLastBodyFallParticle
    /// </summary>
    public unsafe float TimeOfLastBodyFallParticle
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2452); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2452); }
    }

    /// <summary>
    /// ByteProperty: RagdollVsNavMeshSolution
    /// </summary>
    public unsafe BmSDK.BmGame.RPawnCharacter.ERagdollVsNavMesh RagdollVsNavMeshSolution
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPawnCharacter.ERagdollVsNavMesh>(Ptr + 2456); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2456); }
    }

    /// <summary>
    /// StructProperty: PrevSafePelvisLocation
    /// </summary>
    public unsafe System.Numerics.Vector3 PrevSafePelvisLocation
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 2460); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2460); }
    }

    /// <summary>
    /// StructProperty: LastSafeLocation
    /// </summary>
    public unsafe System.Numerics.Vector3 LastSafeLocation
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 2472); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2472); }
    }

    /// <summary>
    /// IntProperty: NavMeshConstrainFrames
    /// </summary>
    public unsafe int NavMeshConstrainFrames
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2484); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2484); }
    }

    /// <summary>
    /// IntProperty: NavMeshConstrainBuffer
    /// </summary>
    public unsafe int NavMeshConstrainBuffer
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2488); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2488); }
    }

    /// <summary>
    /// ArrayProperty: RagdollCollisionBodies
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RPawnCharacter.FRagdollNavMeshCollisionTrackingInfo> RagdollCollisionBodies
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RPawnCharacter.FRagdollNavMeshCollisionTrackingInfo>>(Ptr + 2492); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2492); }
    }

    /// <summary>
    /// StructProperty: OldShadowReflectionPlane
    /// </summary>
    public unsafe BmSDK.GameObject.FPlane OldShadowReflectionPlane
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.GameObject.FPlane>(Ptr + 2512); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2512); }
    }

    /// <summary>
    /// FloatProperty: ShadowReflectionRagdollCache
    /// </summary>
    public unsafe float ShadowReflectionRagdollCache
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2528); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2528); }
    }

    /// <summary>
    /// StructProperty: Tweak_LocationNudge
    /// </summary>
    public unsafe System.Numerics.Vector3 Tweak_LocationNudge
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 2532); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2532); }
    }

    /// <summary>
    /// ArrayProperty: Tweak_FaceFXRegisters
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RPawnCharacter.FTweakFaceFXRegister> Tweak_FaceFXRegisters
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RPawnCharacter.FTweakFaceFXRegister>>(Ptr + 2544); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2544); }
    }

    /// <summary>
    /// NameProperty: Tweak_Anim_AnimName
    /// </summary>
    public unsafe BmSDK.FName Tweak_Anim_AnimName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 2560); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2560); }
    }

    /// <summary>
    /// FloatProperty: Tweak_Anim_Time
    /// </summary>
    public unsafe float Tweak_Anim_Time
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2568); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2568); }
    }

    /// <summary>
    /// FloatProperty: NavTestLength
    /// </summary>
    public unsafe float NavTestLength
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2572); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2572); }
    }

    /// <summary>
    /// FloatProperty: RagdollFacingThreshold
    /// </summary>
    public unsafe float RagdollFacingThreshold
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2576); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2576); }
    }

    /// <summary>
    /// ArrayProperty: RainMaterials
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.Engine.MaterialInstanceConstant> RainMaterials
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.MaterialInstanceConstant>>(Ptr + 2580); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2580); }
    }

    /// <summary>
    /// FloatProperty: RainAccumulationAlpha
    /// </summary>
    public unsafe float RainAccumulationAlpha
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2596); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2596); }
    }

    /// <summary>
    /// FloatProperty: WetnessAccumulationAlpha
    /// </summary>
    public unsafe float WetnessAccumulationAlpha
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2600); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2600); }
    }

    /// <summary>
    /// NameProperty: RainParameterName
    /// </summary>
    public unsafe BmSDK.FName RainParameterName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 2604); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2604); }
    }

    /// <summary>
    /// StructProperty: PreviousRainDirectionColor
    /// </summary>
    public unsafe BmSDK.GameObject.FLinearColor PreviousRainDirectionColor
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.GameObject.FLinearColor>(Ptr + 2612); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2612); }
    }

    /// <summary>
    /// FloatProperty: LastRainMaterialUpdateTime
    /// </summary>
    public unsafe float LastRainMaterialUpdateTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2628); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2628); }
    }

    /// <summary>
    /// NameProperty: BeginGetUp_MovementStance
    /// </summary>
    public unsafe BmSDK.FName BeginGetUp_MovementStance
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 2632); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2632); }
    }

    /// <summary>
    /// StructProperty: BeginGetUp_TransitionId
    /// </summary>
    public unsafe BmSDK.BmGame.RAnimUtil_PosePlayer.FTransitionId BeginGetUp_TransitionId
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RAnimUtil_PosePlayer.FTransitionId>(Ptr + 2640); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2640); }
    }

    /// <summary>
    /// DelegateProperty: __OnPlayedQueuedTransition__Delegate
    /// </summary>
    public unsafe System.IntPtr __OnPlayedQueuedTransition__Delegate
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.IntPtr>(Ptr + 2644); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2644); }
    }
}
