#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RChallengeModeStartPointBase<br/>
/// (flags = 0)
/// </summary>
public partial class RChallengeModeStartPointBase : BmSDK.BmGame.RPlayerStartInLevel, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RChallengeModeStartPointBase", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RChallengeModeStartPointBase() { }

    /// <summary>
    /// Constructs a new RChallengeModeStartPointBase
    /// </summary>
    public RChallengeModeStartPointBase(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RChallengeModeStartPointBase Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RChallengeModeStartPointBase(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="Engine.Actor.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RChallengeModeStartPointBase>
        => ((Engine.Actor)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="Engine.Actor.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RChallengeModeStartPointBase>, new()
        => (TComponent)((Engine.Actor)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="Engine.Actor.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RChallengeModeStartPointBase>
        => ((Engine.Actor)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="Engine.Actor.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RChallengeModeStartPointBase>
        => ((Engine.Actor)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="Engine.Actor.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RChallengeModeStartPointBase>
        => (TComponent)((Engine.Actor)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="Engine.Actor.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RChallengeModeStartPointBase>
        => ((Engine.Actor)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="Engine.Actor.DetachScriptComponent(Type)"/>
    public void DetachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RChallengeModeStartPointBase>
        => ((Engine.Actor)this).DetachScriptComponent(typeof(TComponent));

    /// <summary>
    /// IntProperty: ChallengeChapter
    /// </summary>
    public unsafe int ChallengeChapter
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1092); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1092); }
    }

    /// <summary>
    /// ByteProperty: ChallengeSubChapter
    /// </summary>
    public unsafe BmSDK.BmGame.RSeqAct_SetChapter.ESubChapter ChallengeSubChapter
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSeqAct_SetChapter.ESubChapter>(Ptr + 1096); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1096); }
    }

    /// <summary>
    /// StructProperty: BaseChallengeSettings
    /// </summary>
    public unsafe BmSDK.BmGame.RGameInfo.FChallengeDesc BaseChallengeSettings
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RGameInfo.FChallengeDesc>(Ptr + 1100); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1100); }
    }

    /// <summary>
    /// BoolProperty: bPreventLookInDebrief
    /// </summary>
    public unsafe bool bPreventLookInDebrief
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1216) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1216); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1216); }
    }

    /// <summary>
    /// BoolProperty: bAllowQuickRespawn
    /// </summary>
    public unsafe bool bAllowQuickRespawn
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1216) & 2) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1216); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1216); }
    }

    /// <summary>
    /// BoolProperty: bLockedStartLevel
    /// </summary>
    public unsafe bool bLockedStartLevel
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1216) & 4) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1216); var newMask = value ? (currentMask | 4) : (currentMask & ~4); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1216); }
    }

    /// <summary>
    /// BoolProperty: bLockedBaseLevel
    /// </summary>
    public unsafe bool bLockedBaseLevel
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1216) & 8) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1216); var newMask = value ? (currentMask | 8) : (currentMask & ~8); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1216); }
    }

    /// <summary>
    /// BoolProperty: ChallengeDoesNotStartARMusic
    /// </summary>
    public unsafe bool ChallengeDoesNotStartARMusic
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1216) & 16) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1216); var newMask = value ? (currentMask | 16) : (currentMask & ~16); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1216); }
    }

    /// <summary>
    /// BoolProperty: bToggledOff
    /// </summary>
    public unsafe bool bToggledOff
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1216) & 32) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1216); var newMask = value ? (currentMask | 32) : (currentMask & ~32); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1216); }
    }

    /// <summary>
    /// BoolProperty: bVisible
    /// </summary>
    public unsafe bool bVisible
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1216) & 64) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1216); var newMask = value ? (currentMask | 64) : (currentMask & ~64); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1216); }
    }

    /// <summary>
    /// BoolProperty: bUnlocked
    /// </summary>
    public unsafe bool bUnlocked
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1216) & 128) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1216); var newMask = value ? (currentMask | 128) : (currentMask & ~128); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1216); }
    }

    /// <summary>
    /// BoolProperty: bDisabledByGameState
    /// </summary>
    public unsafe bool bDisabledByGameState
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1216) & 256) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1216); var newMask = value ? (currentMask | 256) : (currentMask & ~256); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1216); }
    }

    /// <summary>
    /// BoolProperty: bMustExitToReset
    /// </summary>
    public unsafe bool bMustExitToReset
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1216) & 512) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1216); var newMask = value ? (currentMask | 512) : (currentMask & ~512); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1216); }
    }

    /// <summary>
    /// BoolProperty: StoredPlayerActive
    /// </summary>
    public unsafe bool StoredPlayerActive
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1216) & 1024) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1216); var newMask = value ? (currentMask | 1024) : (currentMask & ~1024); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1216); }
    }

    /// <summary>
    /// BoolProperty: bChallengeModeActive
    /// </summary>
    public unsafe bool bChallengeModeActive
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1216) & 2048) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1216); var newMask = value ? (currentMask | 2048) : (currentMask & ~2048); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1216); }
    }

    /// <summary>
    /// BoolProperty: bPrerequisitesMet
    /// </summary>
    public unsafe bool bPrerequisitesMet
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1216) & 4096) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1216); var newMask = value ? (currentMask | 4096) : (currentMask & ~4096); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1216); }
    }

    /// <summary>
    /// BoolProperty: bUnlockedConditionMet
    /// </summary>
    public unsafe bool bUnlockedConditionMet
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1216) & 8192) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1216); var newMask = value ? (currentMask | 8192) : (currentMask & ~8192); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1216); }
    }

    /// <summary>
    /// BoolProperty: bIsChallengeComplete
    /// </summary>
    public unsafe bool bIsChallengeComplete
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1216) & 16384) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1216); var newMask = value ? (currentMask | 16384) : (currentMask & ~16384); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1216); }
    }

    /// <summary>
    /// BoolProperty: bStoredInBatmobile
    /// </summary>
    public unsafe bool bStoredInBatmobile
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1216) & 32768) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1216); var newMask = value ? (currentMask | 32768) : (currentMask & ~32768); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1216); }
    }

    /// <summary>
    /// BoolProperty: bDisplayingFullPanel
    /// </summary>
    public unsafe bool bDisplayingFullPanel
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1216) & 65536) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1216); var newMask = value ? (currentMask | 65536) : (currentMask & ~65536); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1216); }
    }

    /// <summary>
    /// BoolProperty: bDisplayingMiniPanel
    /// </summary>
    public unsafe bool bDisplayingMiniPanel
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1216) & 131072) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1216); var newMask = value ? (currentMask | 131072) : (currentMask & ~131072); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1216); }
    }

    /// <summary>
    /// StrProperty: AdditionalURLParams
    /// </summary>
    public unsafe BmSDK.FString AdditionalURLParams
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 1220); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1220); }
    }

    /// <summary>
    /// NameProperty: EnsureLevelLoaded
    /// </summary>
    public unsafe BmSDK.FName EnsureLevelLoaded
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 1236); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1236); }
    }

    /// <summary>
    /// IntProperty: PrerequisiteChallengeId
    /// </summary>
    public unsafe int PrerequisiteChallengeId
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1244); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1244); }
    }

    /// <summary>
    /// StrProperty: PrerequisiteFlag
    /// </summary>
    public unsafe BmSDK.FString PrerequisiteFlag
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 1248); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1248); }
    }

    /// <summary>
    /// IntProperty: LockedUntilChallengeId
    /// </summary>
    public unsafe int LockedUntilChallengeId
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1264); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1264); }
    }

    /// <summary>
    /// StrProperty: LockedUntilFlagSet
    /// </summary>
    public unsafe BmSDK.FString LockedUntilFlagSet
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 1268); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1268); }
    }

    /// <summary>
    /// IntProperty: FloatUpAdjust
    /// </summary>
    public unsafe int FloatUpAdjust
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1284); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1284); }
    }

    /// <summary>
    /// IntProperty: nConsecutivePlayCount
    /// </summary>
    public unsafe int nConsecutivePlayCount
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1288); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1288); }
    }

    /// <summary>
    /// ObjectProperty: MainMovieInstance
    /// </summary>
    public unsafe BmSDK.GFxUI.SwfMovie MainMovieInstance
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.GFxUI.SwfMovie>(Ptr + 1292); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1292); }
    }

    /// <summary>
    /// ObjectProperty: MiniMovieInstance
    /// </summary>
    public unsafe BmSDK.GFxUI.SwfMovie MiniMovieInstance
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.GFxUI.SwfMovie>(Ptr + 1300); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1300); }
    }

    /// <summary>
    /// ObjectProperty: BeaconMI
    /// </summary>
    public unsafe BmSDK.Engine.MaterialInstanceConstant BeaconMI
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.MaterialInstanceConstant>(Ptr + 1308); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1308); }
    }

    /// <summary>
    /// ObjectProperty: PlayerData
    /// </summary>
    public unsafe BmSDK.BmGame.RAddContentPlayerCharacter PlayerData
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RAddContentPlayerCharacter>(Ptr + 1316); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1316); }
    }

    /// <summary>
    /// ObjectProperty: PlayerMesh
    /// </summary>
    public unsafe BmSDK.BmGame.RAddContentPlayerCharacterMesh PlayerMesh
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RAddContentPlayerCharacterMesh>(Ptr + 1324); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1324); }
    }

    /// <summary>
    /// ObjectProperty: StoredPlayerData
    /// </summary>
    public unsafe BmSDK.BmGame.RAddContentPlayerCharacter StoredPlayerData
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RAddContentPlayerCharacter>(Ptr + 1332); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1332); }
    }

    /// <summary>
    /// ObjectProperty: StoredPlayerMesh
    /// </summary>
    public unsafe BmSDK.BmGame.RAddContentPlayerCharacterMesh StoredPlayerMesh
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RAddContentPlayerCharacterMesh>(Ptr + 1340); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1340); }
    }

    /// <summary>
    /// ComponentProperty: LevelSwitchFX
    /// </summary>
    public unsafe BmSDK.Engine.ParticleSystemComponent LevelSwitchFX
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleSystemComponent>(Ptr + 1348); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1348); }
    }

    /// <summary>
    /// ComponentProperty: BeaconFX
    /// </summary>
    public unsafe BmSDK.Engine.ParticleSystemComponent BeaconFX
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleSystemComponent>(Ptr + 1356); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1356); }
    }

    /// <summary>
    /// StructProperty: BeaconFXSpring
    /// </summary>
    public unsafe System.Numerics.Vector3 BeaconFXSpring
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 1364); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1364); }
    }

    /// <summary>
    /// FloatProperty: ActivationRange
    /// </summary>
    public unsafe float ActivationRange
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1376); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1376); }
    }

    /// <summary>
    /// FloatProperty: ActivationRangeBatmobile
    /// </summary>
    public unsafe float ActivationRangeBatmobile
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1380); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1380); }
    }

    /// <summary>
    /// FloatProperty: MiniUIRange
    /// </summary>
    public unsafe float MiniUIRange
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1384); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1384); }
    }

    /// <summary>
    /// FloatProperty: StasisRangeIfNotOnScreen
    /// </summary>
    public unsafe float StasisRangeIfNotOnScreen
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1388); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1388); }
    }

    /// <summary>
    /// FloatProperty: VisibleRangeSq
    /// </summary>
    public unsafe float VisibleRangeSq
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1392); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1392); }
    }

    /// <summary>
    /// IntProperty: nMedalsComplete
    /// </summary>
    public unsafe int nMedalsComplete
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1396); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1396); }
    }

    /// <summary>
    /// StructProperty: StoredPlayerPos
    /// </summary>
    public unsafe System.Numerics.Vector3 StoredPlayerPos
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 1400); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1400); }
    }

    /// <summary>
    /// StructProperty: StoredPlayerRot
    /// </summary>
    public unsafe BmSDK.Rotator StoredPlayerRot
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Rotator>(Ptr + 1412); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1412); }
    }

    /// <summary>
    /// StructProperty: StoredBatmobilePos
    /// </summary>
    public unsafe System.Numerics.Vector3 StoredBatmobilePos
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 1424); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1424); }
    }

    /// <summary>
    /// StructProperty: StoredBatmobileRot
    /// </summary>
    public unsafe BmSDK.Rotator StoredBatmobileRot
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Rotator>(Ptr + 1436); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1436); }
    }

    /// <summary>
    /// StrProperty: PlayerDataPkgName
    /// </summary>
    public unsafe BmSDK.FString PlayerDataPkgName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 1448); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1448); }
    }

    /// <summary>
    /// StrProperty: PlayerMeshPkgName
    /// </summary>
    public unsafe BmSDK.FString PlayerMeshPkgName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 1464); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1464); }
    }

    /// <summary>
    /// StrProperty: StoredPlayerDataPkgName
    /// </summary>
    public unsafe BmSDK.FString StoredPlayerDataPkgName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 1480); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1480); }
    }

    /// <summary>
    /// StrProperty: StoredPlayerMeshPkgName
    /// </summary>
    public unsafe BmSDK.FString StoredPlayerMeshPkgName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 1496); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1496); }
    }
}
