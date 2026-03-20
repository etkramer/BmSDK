#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RPersistentOptions<br/>
/// (flags = 0)
/// </summary>
public partial class RPersistentOptions : BmSDK.GameObject, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RPersistentOptions", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RPersistentOptions() { }

    /// <summary>
    /// Constructs a new RPersistentOptions
    /// </summary>
    public RPersistentOptions(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RPersistentOptions Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RPersistentOptions(nint ptr) : base(ptr) { }

    /// <summary>
    /// IntProperty: Version
    /// </summary>
    public unsafe int Version
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 84); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 84); }
    }

    /// <summary>
    /// StrProperty: User_GUID
    /// </summary>
    public unsafe BmSDK.FString User_GUID
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 88); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 88); }
    }

    /// <summary>
    /// IntProperty: User_SaveSlot
    /// </summary>
    public unsafe int User_SaveSlot
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 104); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 104); }
    }

    /// <summary>
    /// ArrayProperty: GeneralOptions
    /// </summary>
    public unsafe BmSDK.TArray<int> GeneralOptions
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<int>>(Ptr + 108); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 108); }
    }

    /// <summary>
    /// ArrayProperty: Player1Options
    /// </summary>
    public unsafe BmSDK.TArray<int> Player1Options
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<int>>(Ptr + 124); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 124); }
    }

    /// <summary>
    /// ArrayProperty: Player2Options
    /// </summary>
    public unsafe BmSDK.TArray<int> Player2Options
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<int>>(Ptr + 140); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 140); }
    }

    /// <summary>
    /// ArrayProperty: OptionsFlags
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.FString> OptionsFlags
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.FString>>(Ptr + 156); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 156); }
    }

    /// <summary>
    /// ArrayProperty: UnlockedChallenges
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RPersistentOptions.FUnlockedChallenge> UnlockedChallenges
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RPersistentOptions.FUnlockedChallenge>>(Ptr + 172); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 172); }
    }

    /// <summary>
    /// IntProperty: CachedChallengeId
    /// </summary>
    public unsafe int CachedChallengeId
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 188); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 188); }
    }

    /// <summary>
    /// IntProperty: CachedChallengeIndex
    /// </summary>
    public unsafe int CachedChallengeIndex
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 192); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 192); }
    }

    /// <summary>
    /// IntProperty: CachedChallengeCharacterId
    /// </summary>
    public unsafe int CachedChallengeCharacterId
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 196); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 196); }
    }

    /// <summary>
    /// IntProperty: CachedChallengeCharacterIndex
    /// </summary>
    public unsafe int CachedChallengeCharacterIndex
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 200); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 200); }
    }

    /// <summary>
    /// IntProperty: OldUpgradePointsAvailable
    /// </summary>
    public unsafe int OldUpgradePointsAvailable
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 204); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 204); }
    }

    /// <summary>
    /// IntProperty: OldUpgradePointsUsed
    /// </summary>
    public unsafe int OldUpgradePointsUsed
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 208); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 208); }
    }

    /// <summary>
    /// IntProperty: OldUpgradesPurchased
    /// </summary>
    public unsafe int OldUpgradesPurchased
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 212); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 212); }
    }

    /// <summary>
    /// StrProperty: MWRivalName
    /// </summary>
    public unsafe BmSDK.FString MWRivalName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 216); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 216); }
    }

    /// <summary>
    /// ArrayProperty: DeathMovieRecordArray
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RPersistentOptions.FDeathMovieRecord> DeathMovieRecordArray
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RPersistentOptions.FDeathMovieRecord>>(Ptr + 232); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 232); }
    }

    /// <summary>
    /// ArrayProperty: ExtraProfileStrings
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.FString> ExtraProfileStrings
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.FString>>(Ptr + 248); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 248); }
    }

    /// <summary>
    /// StructProperty: TimeStamp
    /// </summary>
    public unsafe BmSDK.Engine.OnlineSubsystem.FUniqueNetId TimeStamp
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.OnlineSubsystem.FUniqueNetId>(Ptr + 264); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 264); }
    }

    /// <summary>
    /// IntProperty: Day
    /// </summary>
    public unsafe int Day
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 272); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 272); }
    }

    /// <summary>
    /// IntProperty: Month
    /// </summary>
    public unsafe int Month
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 276); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 276); }
    }

    /// <summary>
    /// IntProperty: Year
    /// </summary>
    public unsafe int Year
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 280); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 280); }
    }

    /// <summary>
    /// IntProperty: LocationID
    /// </summary>
    public unsafe int LocationID
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 284); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 284); }
    }

    /// <summary>
    /// StrProperty: DifficultyString
    /// </summary>
    public unsafe BmSDK.FString DifficultyString
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 288); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 288); }
    }

    /// <summary>
    /// IntProperty: NewGamePlusEnabled
    /// </summary>
    public unsafe int NewGamePlusEnabled
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 304); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 304); }
    }

    /// <summary>
    /// IntProperty: NewGamePlusStarted
    /// </summary>
    public unsafe int NewGamePlusStarted
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 308); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 308); }
    }

    /// <summary>
    /// IntProperty: SkippedWBIDPrompt
    /// </summary>
    public unsafe int SkippedWBIDPrompt
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 312); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 312); }
    }

    /// <summary>
    /// IntProperty: PercentageCompleted
    /// </summary>
    public unsafe int PercentageCompleted
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 316); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 316); }
    }

    /// <summary>
    /// IntProperty: UsingGamepad
    /// </summary>
    public unsafe int UsingGamepad
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 320); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 320); }
    }

    /// <summary>
    /// IntProperty: DDA_DeathsInRoom
    /// </summary>
    public unsafe int DDA_DeathsInRoom
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 324); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 324); }
    }

    /// <summary>
    /// IntProperty: DLC_BatmanMessage
    /// </summary>
    public unsafe int DLC_BatmanMessage
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 328); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 328); }
    }

    /// <summary>
    /// IntProperty: CurrentChallengeMapPageIndex
    /// </summary>
    public unsafe int CurrentChallengeMapPageIndex
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 332); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 332); }
    }

    /// <summary>
    /// IntProperty: CurrentChallengeMapPageItemIndex
    /// </summary>
    public unsafe int CurrentChallengeMapPageItemIndex
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 336); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 336); }
    }

    /// <summary>
    /// IntProperty: Got_WBID_Bonus
    /// </summary>
    public unsafe int Got_WBID_Bonus
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 340); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 340); }
    }

    /// <summary>
    /// IntProperty: WBIDPrivacyGUID1
    /// </summary>
    public unsafe int WBIDPrivacyGUID1
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 344); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 344); }
    }

    /// <summary>
    /// IntProperty: WBIDPrivacyGUID2
    /// </summary>
    public unsafe int WBIDPrivacyGUID2
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 348); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 348); }
    }

    /// <summary>
    /// IntProperty: WBIDPrivacyGUID3
    /// </summary>
    public unsafe int WBIDPrivacyGUID3
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 352); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 352); }
    }

    /// <summary>
    /// IntProperty: WBIDPrivacyGUID4
    /// </summary>
    public unsafe int WBIDPrivacyGUID4
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 356); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 356); }
    }

    /// <summary>
    /// FloatProperty: CombatDDA
    /// </summary>
    public unsafe float CombatDDA
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 360); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 360); }
    }

    /// <summary>
    /// IntProperty: MaxDDAChapter
    /// </summary>
    public unsafe int MaxDDAChapter
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 364); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 364); }
    }

    /// <summary>
    /// FloatProperty: MaxDDAAddition
    /// </summary>
    public unsafe float MaxDDAAddition
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 368); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 368); }
    }

    /// <summary>
    /// ByteProperty: StartedWithoutCW
    /// </summary>
    public unsafe byte StartedWithoutCW
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 372); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 372); }
    }

    /// <summary>
    /// ByteProperty: StatsNew
    /// </summary>
    public unsafe byte StatsNew
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 373); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 373); }
    }

    /// <summary>
    /// StrProperty: CharacterSkins
    /// </summary>
    public unsafe BmSDK.FString CharacterSkins
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 376); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 376); }
    }

    /// <summary>
    /// ArrayProperty: ActivePlayerSkins
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RPersistentOptions.FActivePlayerSkin> ActivePlayerSkins
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RPersistentOptions.FActivePlayerSkin>>(Ptr + 392); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 392); }
    }

    /// <summary>
    /// FloatProperty: TotalTimePlayed
    /// </summary>
    public unsafe float TotalTimePlayed
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 408); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 408); }
    }

    /// <summary>
    /// IntProperty: PredatorAwarenessDisabled
    /// </summary>
    public unsafe int PredatorAwarenessDisabled
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 412); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 412); }
    }

    /// <summary>
    /// ArrayProperty: WBPlayRewardFlags
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.FString> WBPlayRewardFlags
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.FString>>(Ptr + 416); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 416); }
    }

    /// <summary>
    /// ArrayProperty: Difficulty_Strings
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.FString> Difficulty_Strings
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.FString>>(Ptr + 432); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 432); }
    }

    /// <summary>
    /// ArrayProperty: Tmp_GeneralOptions
    /// </summary>
    public unsafe BmSDK.TArray<int> Tmp_GeneralOptions
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<int>>(Ptr + 448); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 448); }
    }

    /// <summary>
    /// ArrayProperty: Tmp_Player1Options
    /// </summary>
    public unsafe BmSDK.TArray<int> Tmp_Player1Options
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<int>>(Ptr + 464); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 464); }
    }

    /// <summary>
    /// ArrayProperty: Tmp_GraphicsOptions
    /// </summary>
    public unsafe BmSDK.TArray<int> Tmp_GraphicsOptions
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<int>>(Ptr + 480); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 480); }
    }

    /// <summary>
    /// FloatProperty: BatmobileCombatDDA
    /// </summary>
    public unsafe float BatmobileCombatDDA
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 496); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 496); }
    }

    /// <summary>
    /// FloatProperty: BatmobilePredDDA
    /// </summary>
    public unsafe float BatmobilePredDDA
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 500); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 500); }
    }

    /// <summary>
    /// IntProperty: BeatdownsFromFloorPickup
    /// </summary>
    public unsafe int BeatdownsFromFloorPickup
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 504); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 504); }
    }

    /// <summary>
    /// IntProperty: BattleModeOptionAvailable
    /// </summary>
    public unsafe int BattleModeOptionAvailable
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 508); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 508); }
    }

    /// <summary>
    /// IntProperty: PursuitCount
    /// </summary>
    public unsafe int PursuitCount
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 512); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 512); }
    }

    /// <summary>
    /// IntProperty: BattleCount
    /// </summary>
    public unsafe int BattleCount
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 516); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 516); }
    }

    /// <summary>
    /// StructProperty: BatmanKeyBinds
    /// </summary>
    public unsafe BmSDK.BmGame.RPersistentOptions.FStoredKeyMap BatmanKeyBinds_0
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPersistentOptions.FStoredKeyMap>(Ptr + 520); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 520); }
    }
    /// <summary>
    /// StructProperty: BatmanKeyBinds
    /// </summary>
    public unsafe BmSDK.BmGame.RPersistentOptions.FStoredKeyMap BatmanKeyBinds_1
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPersistentOptions.FStoredKeyMap>(Ptr + 560); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 560); }
    }
    /// <summary>
    /// StructProperty: BatmanKeyBinds
    /// </summary>
    public unsafe BmSDK.BmGame.RPersistentOptions.FStoredKeyMap BatmanKeyBinds_2
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPersistentOptions.FStoredKeyMap>(Ptr + 600); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 600); }
    }
    /// <summary>
    /// StructProperty: BatmanKeyBinds
    /// </summary>
    public unsafe BmSDK.BmGame.RPersistentOptions.FStoredKeyMap BatmanKeyBinds_3
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPersistentOptions.FStoredKeyMap>(Ptr + 640); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 640); }
    }
    /// <summary>
    /// StructProperty: BatmanKeyBinds
    /// </summary>
    public unsafe BmSDK.BmGame.RPersistentOptions.FStoredKeyMap BatmanKeyBinds_4
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPersistentOptions.FStoredKeyMap>(Ptr + 680); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 680); }
    }
    /// <summary>
    /// StructProperty: BatmanKeyBinds
    /// </summary>
    public unsafe BmSDK.BmGame.RPersistentOptions.FStoredKeyMap BatmanKeyBinds_5
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPersistentOptions.FStoredKeyMap>(Ptr + 720); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 720); }
    }
    /// <summary>
    /// StructProperty: BatmanKeyBinds
    /// </summary>
    public unsafe BmSDK.BmGame.RPersistentOptions.FStoredKeyMap BatmanKeyBinds_6
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPersistentOptions.FStoredKeyMap>(Ptr + 760); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 760); }
    }
    /// <summary>
    /// StructProperty: BatmanKeyBinds
    /// </summary>
    public unsafe BmSDK.BmGame.RPersistentOptions.FStoredKeyMap BatmanKeyBinds_7
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPersistentOptions.FStoredKeyMap>(Ptr + 800); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 800); }
    }
    /// <summary>
    /// StructProperty: BatmanKeyBinds
    /// </summary>
    public unsafe BmSDK.BmGame.RPersistentOptions.FStoredKeyMap BatmanKeyBinds_8
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPersistentOptions.FStoredKeyMap>(Ptr + 840); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 840); }
    }
    /// <summary>
    /// StructProperty: BatmanKeyBinds
    /// </summary>
    public unsafe BmSDK.BmGame.RPersistentOptions.FStoredKeyMap BatmanKeyBinds_9
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPersistentOptions.FStoredKeyMap>(Ptr + 880); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 880); }
    }
    /// <summary>
    /// StructProperty: BatmanKeyBinds
    /// </summary>
    public unsafe BmSDK.BmGame.RPersistentOptions.FStoredKeyMap BatmanKeyBinds_10
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPersistentOptions.FStoredKeyMap>(Ptr + 920); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 920); }
    }
    /// <summary>
    /// StructProperty: BatmanKeyBinds
    /// </summary>
    public unsafe BmSDK.BmGame.RPersistentOptions.FStoredKeyMap BatmanKeyBinds_11
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPersistentOptions.FStoredKeyMap>(Ptr + 960); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 960); }
    }
    /// <summary>
    /// StructProperty: BatmanKeyBinds
    /// </summary>
    public unsafe BmSDK.BmGame.RPersistentOptions.FStoredKeyMap BatmanKeyBinds_12
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPersistentOptions.FStoredKeyMap>(Ptr + 1000); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1000); }
    }
    /// <summary>
    /// StructProperty: BatmanKeyBinds
    /// </summary>
    public unsafe BmSDK.BmGame.RPersistentOptions.FStoredKeyMap BatmanKeyBinds_13
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPersistentOptions.FStoredKeyMap>(Ptr + 1040); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1040); }
    }
    /// <summary>
    /// StructProperty: BatmanKeyBinds
    /// </summary>
    public unsafe BmSDK.BmGame.RPersistentOptions.FStoredKeyMap BatmanKeyBinds_14
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPersistentOptions.FStoredKeyMap>(Ptr + 1080); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1080); }
    }
    /// <summary>
    /// StructProperty: BatmanKeyBinds
    /// </summary>
    public unsafe BmSDK.BmGame.RPersistentOptions.FStoredKeyMap BatmanKeyBinds_15
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPersistentOptions.FStoredKeyMap>(Ptr + 1120); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1120); }
    }
    /// <summary>
    /// StructProperty: BatmanKeyBinds
    /// </summary>
    public unsafe BmSDK.BmGame.RPersistentOptions.FStoredKeyMap BatmanKeyBinds_16
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPersistentOptions.FStoredKeyMap>(Ptr + 1160); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1160); }
    }
    /// <summary>
    /// StructProperty: BatmanKeyBinds
    /// </summary>
    public unsafe BmSDK.BmGame.RPersistentOptions.FStoredKeyMap BatmanKeyBinds_17
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPersistentOptions.FStoredKeyMap>(Ptr + 1200); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1200); }
    }
    /// <summary>
    /// StructProperty: BatmanKeyBinds
    /// </summary>
    public unsafe BmSDK.BmGame.RPersistentOptions.FStoredKeyMap BatmanKeyBinds_18
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPersistentOptions.FStoredKeyMap>(Ptr + 1240); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1240); }
    }
    /// <summary>
    /// StructProperty: BatmanKeyBinds
    /// </summary>
    public unsafe BmSDK.BmGame.RPersistentOptions.FStoredKeyMap BatmanKeyBinds_19
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPersistentOptions.FStoredKeyMap>(Ptr + 1280); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1280); }
    }
    /// <summary>
    /// StructProperty: BatmanKeyBinds
    /// </summary>
    public unsafe BmSDK.BmGame.RPersistentOptions.FStoredKeyMap BatmanKeyBinds_20
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPersistentOptions.FStoredKeyMap>(Ptr + 1320); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1320); }
    }
    /// <summary>
    /// StructProperty: BatmanKeyBinds
    /// </summary>
    public unsafe BmSDK.BmGame.RPersistentOptions.FStoredKeyMap BatmanKeyBinds_21
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPersistentOptions.FStoredKeyMap>(Ptr + 1360); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1360); }
    }
    /// <summary>
    /// StructProperty: BatmanKeyBinds
    /// </summary>
    public unsafe BmSDK.BmGame.RPersistentOptions.FStoredKeyMap BatmanKeyBinds_22
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPersistentOptions.FStoredKeyMap>(Ptr + 1400); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1400); }
    }
    /// <summary>
    /// StructProperty: BatmanKeyBinds
    /// </summary>
    public unsafe BmSDK.BmGame.RPersistentOptions.FStoredKeyMap BatmanKeyBinds_23
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPersistentOptions.FStoredKeyMap>(Ptr + 1440); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1440); }
    }
    /// <summary>
    /// StructProperty: BatmanKeyBinds
    /// </summary>
    public unsafe BmSDK.BmGame.RPersistentOptions.FStoredKeyMap BatmanKeyBinds_24
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPersistentOptions.FStoredKeyMap>(Ptr + 1480); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1480); }
    }
    /// <summary>
    /// StructProperty: BatmanKeyBinds
    /// </summary>
    public unsafe BmSDK.BmGame.RPersistentOptions.FStoredKeyMap BatmanKeyBinds_25
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPersistentOptions.FStoredKeyMap>(Ptr + 1520); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1520); }
    }
    /// <summary>
    /// StructProperty: BatmanKeyBinds
    /// </summary>
    public unsafe BmSDK.BmGame.RPersistentOptions.FStoredKeyMap BatmanKeyBinds_26
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPersistentOptions.FStoredKeyMap>(Ptr + 1560); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1560); }
    }
    /// <summary>
    /// StructProperty: BatmanKeyBinds
    /// </summary>
    public unsafe BmSDK.BmGame.RPersistentOptions.FStoredKeyMap BatmanKeyBinds_27
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPersistentOptions.FStoredKeyMap>(Ptr + 1600); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1600); }
    }
    /// <summary>
    /// StructProperty: BatmanKeyBinds
    /// </summary>
    public unsafe BmSDK.BmGame.RPersistentOptions.FStoredKeyMap BatmanKeyBinds_28
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPersistentOptions.FStoredKeyMap>(Ptr + 1640); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1640); }
    }
    /// <summary>
    /// StructProperty: BatmanKeyBinds
    /// </summary>
    public unsafe BmSDK.BmGame.RPersistentOptions.FStoredKeyMap BatmanKeyBinds_29
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPersistentOptions.FStoredKeyMap>(Ptr + 1680); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1680); }
    }
    /// <summary>
    /// StructProperty: BatmanKeyBinds
    /// </summary>
    public unsafe BmSDK.BmGame.RPersistentOptions.FStoredKeyMap BatmanKeyBinds_30
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPersistentOptions.FStoredKeyMap>(Ptr + 1720); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1720); }
    }
    /// <summary>
    /// StructProperty: BatmanKeyBinds
    /// </summary>
    public unsafe BmSDK.BmGame.RPersistentOptions.FStoredKeyMap BatmanKeyBinds_31
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPersistentOptions.FStoredKeyMap>(Ptr + 1760); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1760); }
    }
    /// <summary>
    /// StructProperty: BatmanKeyBinds
    /// </summary>
    public unsafe BmSDK.BmGame.RPersistentOptions.FStoredKeyMap BatmanKeyBinds_32
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPersistentOptions.FStoredKeyMap>(Ptr + 1800); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1800); }
    }
    /// <summary>
    /// StructProperty: BatmanKeyBinds
    /// </summary>
    public unsafe BmSDK.BmGame.RPersistentOptions.FStoredKeyMap BatmanKeyBinds_33
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPersistentOptions.FStoredKeyMap>(Ptr + 1840); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1840); }
    }
    /// <summary>
    /// StructProperty: BatmanKeyBinds
    /// </summary>
    public unsafe BmSDK.BmGame.RPersistentOptions.FStoredKeyMap BatmanKeyBinds_34
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPersistentOptions.FStoredKeyMap>(Ptr + 1880); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1880); }
    }
    /// <summary>
    /// StructProperty: BatmanKeyBinds
    /// </summary>
    public unsafe BmSDK.BmGame.RPersistentOptions.FStoredKeyMap BatmanKeyBinds_35
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPersistentOptions.FStoredKeyMap>(Ptr + 1920); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1920); }
    }
    /// <summary>
    /// StructProperty: BatmanKeyBinds
    /// </summary>
    public unsafe BmSDK.BmGame.RPersistentOptions.FStoredKeyMap BatmanKeyBinds_36
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPersistentOptions.FStoredKeyMap>(Ptr + 1960); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1960); }
    }
    /// <summary>
    /// StructProperty: BatmanKeyBinds
    /// </summary>
    public unsafe BmSDK.BmGame.RPersistentOptions.FStoredKeyMap BatmanKeyBinds_37
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPersistentOptions.FStoredKeyMap>(Ptr + 2000); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2000); }
    }
    /// <summary>
    /// StructProperty: BatmanKeyBinds
    /// </summary>
    public unsafe BmSDK.BmGame.RPersistentOptions.FStoredKeyMap BatmanKeyBinds_38
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPersistentOptions.FStoredKeyMap>(Ptr + 2040); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2040); }
    }
    /// <summary>
    /// StructProperty: BatmanKeyBinds
    /// </summary>
    public unsafe BmSDK.BmGame.RPersistentOptions.FStoredKeyMap BatmanKeyBinds_39
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPersistentOptions.FStoredKeyMap>(Ptr + 2080); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2080); }
    }
    /// <summary>
    /// StructProperty: BatmanKeyBinds
    /// </summary>
    public unsafe BmSDK.BmGame.RPersistentOptions.FStoredKeyMap BatmanKeyBinds_40
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPersistentOptions.FStoredKeyMap>(Ptr + 2120); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2120); }
    }

    /// <summary>
    /// StructProperty: PursuitKeyBinds
    /// </summary>
    public unsafe BmSDK.BmGame.RPersistentOptions.FStoredKeyMap PursuitKeyBinds_0
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPersistentOptions.FStoredKeyMap>(Ptr + 2160); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2160); }
    }
    /// <summary>
    /// StructProperty: PursuitKeyBinds
    /// </summary>
    public unsafe BmSDK.BmGame.RPersistentOptions.FStoredKeyMap PursuitKeyBinds_1
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPersistentOptions.FStoredKeyMap>(Ptr + 2200); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2200); }
    }
    /// <summary>
    /// StructProperty: PursuitKeyBinds
    /// </summary>
    public unsafe BmSDK.BmGame.RPersistentOptions.FStoredKeyMap PursuitKeyBinds_2
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPersistentOptions.FStoredKeyMap>(Ptr + 2240); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2240); }
    }
    /// <summary>
    /// StructProperty: PursuitKeyBinds
    /// </summary>
    public unsafe BmSDK.BmGame.RPersistentOptions.FStoredKeyMap PursuitKeyBinds_3
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPersistentOptions.FStoredKeyMap>(Ptr + 2280); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2280); }
    }
    /// <summary>
    /// StructProperty: PursuitKeyBinds
    /// </summary>
    public unsafe BmSDK.BmGame.RPersistentOptions.FStoredKeyMap PursuitKeyBinds_4
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPersistentOptions.FStoredKeyMap>(Ptr + 2320); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2320); }
    }
    /// <summary>
    /// StructProperty: PursuitKeyBinds
    /// </summary>
    public unsafe BmSDK.BmGame.RPersistentOptions.FStoredKeyMap PursuitKeyBinds_5
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPersistentOptions.FStoredKeyMap>(Ptr + 2360); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2360); }
    }
    /// <summary>
    /// StructProperty: PursuitKeyBinds
    /// </summary>
    public unsafe BmSDK.BmGame.RPersistentOptions.FStoredKeyMap PursuitKeyBinds_6
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPersistentOptions.FStoredKeyMap>(Ptr + 2400); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2400); }
    }
    /// <summary>
    /// StructProperty: PursuitKeyBinds
    /// </summary>
    public unsafe BmSDK.BmGame.RPersistentOptions.FStoredKeyMap PursuitKeyBinds_7
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPersistentOptions.FStoredKeyMap>(Ptr + 2440); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2440); }
    }
    /// <summary>
    /// StructProperty: PursuitKeyBinds
    /// </summary>
    public unsafe BmSDK.BmGame.RPersistentOptions.FStoredKeyMap PursuitKeyBinds_8
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPersistentOptions.FStoredKeyMap>(Ptr + 2480); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2480); }
    }
    /// <summary>
    /// StructProperty: PursuitKeyBinds
    /// </summary>
    public unsafe BmSDK.BmGame.RPersistentOptions.FStoredKeyMap PursuitKeyBinds_9
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPersistentOptions.FStoredKeyMap>(Ptr + 2520); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2520); }
    }
    /// <summary>
    /// StructProperty: PursuitKeyBinds
    /// </summary>
    public unsafe BmSDK.BmGame.RPersistentOptions.FStoredKeyMap PursuitKeyBinds_10
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPersistentOptions.FStoredKeyMap>(Ptr + 2560); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2560); }
    }
    /// <summary>
    /// StructProperty: PursuitKeyBinds
    /// </summary>
    public unsafe BmSDK.BmGame.RPersistentOptions.FStoredKeyMap PursuitKeyBinds_11
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPersistentOptions.FStoredKeyMap>(Ptr + 2600); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2600); }
    }
    /// <summary>
    /// StructProperty: PursuitKeyBinds
    /// </summary>
    public unsafe BmSDK.BmGame.RPersistentOptions.FStoredKeyMap PursuitKeyBinds_12
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPersistentOptions.FStoredKeyMap>(Ptr + 2640); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2640); }
    }

    /// <summary>
    /// StructProperty: BattleKeyBinds
    /// </summary>
    public unsafe BmSDK.BmGame.RPersistentOptions.FStoredKeyMap BattleKeyBinds_0
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPersistentOptions.FStoredKeyMap>(Ptr + 2680); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2680); }
    }
    /// <summary>
    /// StructProperty: BattleKeyBinds
    /// </summary>
    public unsafe BmSDK.BmGame.RPersistentOptions.FStoredKeyMap BattleKeyBinds_1
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPersistentOptions.FStoredKeyMap>(Ptr + 2720); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2720); }
    }
    /// <summary>
    /// StructProperty: BattleKeyBinds
    /// </summary>
    public unsafe BmSDK.BmGame.RPersistentOptions.FStoredKeyMap BattleKeyBinds_2
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPersistentOptions.FStoredKeyMap>(Ptr + 2760); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2760); }
    }
    /// <summary>
    /// StructProperty: BattleKeyBinds
    /// </summary>
    public unsafe BmSDK.BmGame.RPersistentOptions.FStoredKeyMap BattleKeyBinds_3
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPersistentOptions.FStoredKeyMap>(Ptr + 2800); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2800); }
    }
    /// <summary>
    /// StructProperty: BattleKeyBinds
    /// </summary>
    public unsafe BmSDK.BmGame.RPersistentOptions.FStoredKeyMap BattleKeyBinds_4
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPersistentOptions.FStoredKeyMap>(Ptr + 2840); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2840); }
    }
    /// <summary>
    /// StructProperty: BattleKeyBinds
    /// </summary>
    public unsafe BmSDK.BmGame.RPersistentOptions.FStoredKeyMap BattleKeyBinds_5
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPersistentOptions.FStoredKeyMap>(Ptr + 2880); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2880); }
    }
    /// <summary>
    /// StructProperty: BattleKeyBinds
    /// </summary>
    public unsafe BmSDK.BmGame.RPersistentOptions.FStoredKeyMap BattleKeyBinds_6
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPersistentOptions.FStoredKeyMap>(Ptr + 2920); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2920); }
    }
    /// <summary>
    /// StructProperty: BattleKeyBinds
    /// </summary>
    public unsafe BmSDK.BmGame.RPersistentOptions.FStoredKeyMap BattleKeyBinds_7
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPersistentOptions.FStoredKeyMap>(Ptr + 2960); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2960); }
    }
    /// <summary>
    /// StructProperty: BattleKeyBinds
    /// </summary>
    public unsafe BmSDK.BmGame.RPersistentOptions.FStoredKeyMap BattleKeyBinds_8
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPersistentOptions.FStoredKeyMap>(Ptr + 3000); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3000); }
    }
    /// <summary>
    /// StructProperty: BattleKeyBinds
    /// </summary>
    public unsafe BmSDK.BmGame.RPersistentOptions.FStoredKeyMap BattleKeyBinds_9
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPersistentOptions.FStoredKeyMap>(Ptr + 3040); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3040); }
    }
    /// <summary>
    /// StructProperty: BattleKeyBinds
    /// </summary>
    public unsafe BmSDK.BmGame.RPersistentOptions.FStoredKeyMap BattleKeyBinds_10
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPersistentOptions.FStoredKeyMap>(Ptr + 3080); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3080); }
    }
    /// <summary>
    /// StructProperty: BattleKeyBinds
    /// </summary>
    public unsafe BmSDK.BmGame.RPersistentOptions.FStoredKeyMap BattleKeyBinds_11
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPersistentOptions.FStoredKeyMap>(Ptr + 3120); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3120); }
    }
    /// <summary>
    /// StructProperty: BattleKeyBinds
    /// </summary>
    public unsafe BmSDK.BmGame.RPersistentOptions.FStoredKeyMap BattleKeyBinds_12
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPersistentOptions.FStoredKeyMap>(Ptr + 3160); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3160); }
    }
    /// <summary>
    /// StructProperty: BattleKeyBinds
    /// </summary>
    public unsafe BmSDK.BmGame.RPersistentOptions.FStoredKeyMap BattleKeyBinds_13
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPersistentOptions.FStoredKeyMap>(Ptr + 3200); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3200); }
    }
    /// <summary>
    /// StructProperty: BattleKeyBinds
    /// </summary>
    public unsafe BmSDK.BmGame.RPersistentOptions.FStoredKeyMap BattleKeyBinds_14
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPersistentOptions.FStoredKeyMap>(Ptr + 3240); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3240); }
    }

    /// <summary>
    /// StructProperty: BatgirlKeyBinds
    /// </summary>
    public unsafe BmSDK.BmGame.RPersistentOptions.FStoredKeyMap BatgirlKeyBinds_0
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPersistentOptions.FStoredKeyMap>(Ptr + 3280); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3280); }
    }
    /// <summary>
    /// StructProperty: BatgirlKeyBinds
    /// </summary>
    public unsafe BmSDK.BmGame.RPersistentOptions.FStoredKeyMap BatgirlKeyBinds_1
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPersistentOptions.FStoredKeyMap>(Ptr + 3320); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3320); }
    }
    /// <summary>
    /// StructProperty: BatgirlKeyBinds
    /// </summary>
    public unsafe BmSDK.BmGame.RPersistentOptions.FStoredKeyMap BatgirlKeyBinds_2
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPersistentOptions.FStoredKeyMap>(Ptr + 3360); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3360); }
    }
    /// <summary>
    /// StructProperty: BatgirlKeyBinds
    /// </summary>
    public unsafe BmSDK.BmGame.RPersistentOptions.FStoredKeyMap BatgirlKeyBinds_3
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPersistentOptions.FStoredKeyMap>(Ptr + 3400); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3400); }
    }
    /// <summary>
    /// StructProperty: BatgirlKeyBinds
    /// </summary>
    public unsafe BmSDK.BmGame.RPersistentOptions.FStoredKeyMap BatgirlKeyBinds_4
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPersistentOptions.FStoredKeyMap>(Ptr + 3440); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3440); }
    }
    /// <summary>
    /// StructProperty: BatgirlKeyBinds
    /// </summary>
    public unsafe BmSDK.BmGame.RPersistentOptions.FStoredKeyMap BatgirlKeyBinds_5
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPersistentOptions.FStoredKeyMap>(Ptr + 3480); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3480); }
    }
    /// <summary>
    /// StructProperty: BatgirlKeyBinds
    /// </summary>
    public unsafe BmSDK.BmGame.RPersistentOptions.FStoredKeyMap BatgirlKeyBinds_6
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPersistentOptions.FStoredKeyMap>(Ptr + 3520); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3520); }
    }
    /// <summary>
    /// StructProperty: BatgirlKeyBinds
    /// </summary>
    public unsafe BmSDK.BmGame.RPersistentOptions.FStoredKeyMap BatgirlKeyBinds_7
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPersistentOptions.FStoredKeyMap>(Ptr + 3560); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3560); }
    }
    /// <summary>
    /// StructProperty: BatgirlKeyBinds
    /// </summary>
    public unsafe BmSDK.BmGame.RPersistentOptions.FStoredKeyMap BatgirlKeyBinds_8
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPersistentOptions.FStoredKeyMap>(Ptr + 3600); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3600); }
    }
    /// <summary>
    /// StructProperty: BatgirlKeyBinds
    /// </summary>
    public unsafe BmSDK.BmGame.RPersistentOptions.FStoredKeyMap BatgirlKeyBinds_9
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPersistentOptions.FStoredKeyMap>(Ptr + 3640); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3640); }
    }
    /// <summary>
    /// StructProperty: BatgirlKeyBinds
    /// </summary>
    public unsafe BmSDK.BmGame.RPersistentOptions.FStoredKeyMap BatgirlKeyBinds_10
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPersistentOptions.FStoredKeyMap>(Ptr + 3680); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3680); }
    }
    /// <summary>
    /// StructProperty: BatgirlKeyBinds
    /// </summary>
    public unsafe BmSDK.BmGame.RPersistentOptions.FStoredKeyMap BatgirlKeyBinds_11
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPersistentOptions.FStoredKeyMap>(Ptr + 3720); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3720); }
    }
    /// <summary>
    /// StructProperty: BatgirlKeyBinds
    /// </summary>
    public unsafe BmSDK.BmGame.RPersistentOptions.FStoredKeyMap BatgirlKeyBinds_12
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPersistentOptions.FStoredKeyMap>(Ptr + 3760); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3760); }
    }
    /// <summary>
    /// StructProperty: BatgirlKeyBinds
    /// </summary>
    public unsafe BmSDK.BmGame.RPersistentOptions.FStoredKeyMap BatgirlKeyBinds_13
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPersistentOptions.FStoredKeyMap>(Ptr + 3800); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3800); }
    }
    /// <summary>
    /// StructProperty: BatgirlKeyBinds
    /// </summary>
    public unsafe BmSDK.BmGame.RPersistentOptions.FStoredKeyMap BatgirlKeyBinds_14
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPersistentOptions.FStoredKeyMap>(Ptr + 3840); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3840); }
    }
    /// <summary>
    /// StructProperty: BatgirlKeyBinds
    /// </summary>
    public unsafe BmSDK.BmGame.RPersistentOptions.FStoredKeyMap BatgirlKeyBinds_15
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPersistentOptions.FStoredKeyMap>(Ptr + 3880); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3880); }
    }
    /// <summary>
    /// StructProperty: BatgirlKeyBinds
    /// </summary>
    public unsafe BmSDK.BmGame.RPersistentOptions.FStoredKeyMap BatgirlKeyBinds_16
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPersistentOptions.FStoredKeyMap>(Ptr + 3920); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3920); }
    }
    /// <summary>
    /// StructProperty: BatgirlKeyBinds
    /// </summary>
    public unsafe BmSDK.BmGame.RPersistentOptions.FStoredKeyMap BatgirlKeyBinds_17
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPersistentOptions.FStoredKeyMap>(Ptr + 3960); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3960); }
    }
    /// <summary>
    /// StructProperty: BatgirlKeyBinds
    /// </summary>
    public unsafe BmSDK.BmGame.RPersistentOptions.FStoredKeyMap BatgirlKeyBinds_18
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPersistentOptions.FStoredKeyMap>(Ptr + 4000); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4000); }
    }
    /// <summary>
    /// StructProperty: BatgirlKeyBinds
    /// </summary>
    public unsafe BmSDK.BmGame.RPersistentOptions.FStoredKeyMap BatgirlKeyBinds_19
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPersistentOptions.FStoredKeyMap>(Ptr + 4040); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4040); }
    }
    /// <summary>
    /// StructProperty: BatgirlKeyBinds
    /// </summary>
    public unsafe BmSDK.BmGame.RPersistentOptions.FStoredKeyMap BatgirlKeyBinds_20
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPersistentOptions.FStoredKeyMap>(Ptr + 4080); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4080); }
    }
    /// <summary>
    /// StructProperty: BatgirlKeyBinds
    /// </summary>
    public unsafe BmSDK.BmGame.RPersistentOptions.FStoredKeyMap BatgirlKeyBinds_21
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPersistentOptions.FStoredKeyMap>(Ptr + 4120); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4120); }
    }
    /// <summary>
    /// StructProperty: BatgirlKeyBinds
    /// </summary>
    public unsafe BmSDK.BmGame.RPersistentOptions.FStoredKeyMap BatgirlKeyBinds_22
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPersistentOptions.FStoredKeyMap>(Ptr + 4160); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4160); }
    }
    /// <summary>
    /// StructProperty: BatgirlKeyBinds
    /// </summary>
    public unsafe BmSDK.BmGame.RPersistentOptions.FStoredKeyMap BatgirlKeyBinds_23
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPersistentOptions.FStoredKeyMap>(Ptr + 4200); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4200); }
    }
    /// <summary>
    /// StructProperty: BatgirlKeyBinds
    /// </summary>
    public unsafe BmSDK.BmGame.RPersistentOptions.FStoredKeyMap BatgirlKeyBinds_24
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPersistentOptions.FStoredKeyMap>(Ptr + 4240); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4240); }
    }
    /// <summary>
    /// StructProperty: BatgirlKeyBinds
    /// </summary>
    public unsafe BmSDK.BmGame.RPersistentOptions.FStoredKeyMap BatgirlKeyBinds_25
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPersistentOptions.FStoredKeyMap>(Ptr + 4280); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4280); }
    }
    /// <summary>
    /// StructProperty: BatgirlKeyBinds
    /// </summary>
    public unsafe BmSDK.BmGame.RPersistentOptions.FStoredKeyMap BatgirlKeyBinds_26
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPersistentOptions.FStoredKeyMap>(Ptr + 4320); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4320); }
    }
    /// <summary>
    /// StructProperty: BatgirlKeyBinds
    /// </summary>
    public unsafe BmSDK.BmGame.RPersistentOptions.FStoredKeyMap BatgirlKeyBinds_27
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPersistentOptions.FStoredKeyMap>(Ptr + 4360); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4360); }
    }
    /// <summary>
    /// StructProperty: BatgirlKeyBinds
    /// </summary>
    public unsafe BmSDK.BmGame.RPersistentOptions.FStoredKeyMap BatgirlKeyBinds_28
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPersistentOptions.FStoredKeyMap>(Ptr + 4400); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4400); }
    }

    /// <summary>
    /// StructProperty: RedHoodKeyBinds
    /// </summary>
    public unsafe BmSDK.BmGame.RPersistentOptions.FStoredKeyMap RedHoodKeyBinds_0
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPersistentOptions.FStoredKeyMap>(Ptr + 4440); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4440); }
    }
    /// <summary>
    /// StructProperty: RedHoodKeyBinds
    /// </summary>
    public unsafe BmSDK.BmGame.RPersistentOptions.FStoredKeyMap RedHoodKeyBinds_1
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPersistentOptions.FStoredKeyMap>(Ptr + 4480); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4480); }
    }
    /// <summary>
    /// StructProperty: RedHoodKeyBinds
    /// </summary>
    public unsafe BmSDK.BmGame.RPersistentOptions.FStoredKeyMap RedHoodKeyBinds_2
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPersistentOptions.FStoredKeyMap>(Ptr + 4520); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4520); }
    }
    /// <summary>
    /// StructProperty: RedHoodKeyBinds
    /// </summary>
    public unsafe BmSDK.BmGame.RPersistentOptions.FStoredKeyMap RedHoodKeyBinds_3
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPersistentOptions.FStoredKeyMap>(Ptr + 4560); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4560); }
    }
    /// <summary>
    /// StructProperty: RedHoodKeyBinds
    /// </summary>
    public unsafe BmSDK.BmGame.RPersistentOptions.FStoredKeyMap RedHoodKeyBinds_4
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPersistentOptions.FStoredKeyMap>(Ptr + 4600); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4600); }
    }
    /// <summary>
    /// StructProperty: RedHoodKeyBinds
    /// </summary>
    public unsafe BmSDK.BmGame.RPersistentOptions.FStoredKeyMap RedHoodKeyBinds_5
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPersistentOptions.FStoredKeyMap>(Ptr + 4640); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4640); }
    }
    /// <summary>
    /// StructProperty: RedHoodKeyBinds
    /// </summary>
    public unsafe BmSDK.BmGame.RPersistentOptions.FStoredKeyMap RedHoodKeyBinds_6
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPersistentOptions.FStoredKeyMap>(Ptr + 4680); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4680); }
    }
    /// <summary>
    /// StructProperty: RedHoodKeyBinds
    /// </summary>
    public unsafe BmSDK.BmGame.RPersistentOptions.FStoredKeyMap RedHoodKeyBinds_7
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPersistentOptions.FStoredKeyMap>(Ptr + 4720); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4720); }
    }
    /// <summary>
    /// StructProperty: RedHoodKeyBinds
    /// </summary>
    public unsafe BmSDK.BmGame.RPersistentOptions.FStoredKeyMap RedHoodKeyBinds_8
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPersistentOptions.FStoredKeyMap>(Ptr + 4760); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4760); }
    }
    /// <summary>
    /// StructProperty: RedHoodKeyBinds
    /// </summary>
    public unsafe BmSDK.BmGame.RPersistentOptions.FStoredKeyMap RedHoodKeyBinds_9
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPersistentOptions.FStoredKeyMap>(Ptr + 4800); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4800); }
    }
    /// <summary>
    /// StructProperty: RedHoodKeyBinds
    /// </summary>
    public unsafe BmSDK.BmGame.RPersistentOptions.FStoredKeyMap RedHoodKeyBinds_10
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPersistentOptions.FStoredKeyMap>(Ptr + 4840); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4840); }
    }
    /// <summary>
    /// StructProperty: RedHoodKeyBinds
    /// </summary>
    public unsafe BmSDK.BmGame.RPersistentOptions.FStoredKeyMap RedHoodKeyBinds_11
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPersistentOptions.FStoredKeyMap>(Ptr + 4880); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4880); }
    }
    /// <summary>
    /// StructProperty: RedHoodKeyBinds
    /// </summary>
    public unsafe BmSDK.BmGame.RPersistentOptions.FStoredKeyMap RedHoodKeyBinds_12
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPersistentOptions.FStoredKeyMap>(Ptr + 4920); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4920); }
    }
    /// <summary>
    /// StructProperty: RedHoodKeyBinds
    /// </summary>
    public unsafe BmSDK.BmGame.RPersistentOptions.FStoredKeyMap RedHoodKeyBinds_13
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPersistentOptions.FStoredKeyMap>(Ptr + 4960); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4960); }
    }
    /// <summary>
    /// StructProperty: RedHoodKeyBinds
    /// </summary>
    public unsafe BmSDK.BmGame.RPersistentOptions.FStoredKeyMap RedHoodKeyBinds_14
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPersistentOptions.FStoredKeyMap>(Ptr + 5000); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5000); }
    }
    /// <summary>
    /// StructProperty: RedHoodKeyBinds
    /// </summary>
    public unsafe BmSDK.BmGame.RPersistentOptions.FStoredKeyMap RedHoodKeyBinds_15
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPersistentOptions.FStoredKeyMap>(Ptr + 5040); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5040); }
    }
    /// <summary>
    /// StructProperty: RedHoodKeyBinds
    /// </summary>
    public unsafe BmSDK.BmGame.RPersistentOptions.FStoredKeyMap RedHoodKeyBinds_16
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPersistentOptions.FStoredKeyMap>(Ptr + 5080); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5080); }
    }
    /// <summary>
    /// StructProperty: RedHoodKeyBinds
    /// </summary>
    public unsafe BmSDK.BmGame.RPersistentOptions.FStoredKeyMap RedHoodKeyBinds_17
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPersistentOptions.FStoredKeyMap>(Ptr + 5120); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5120); }
    }
    /// <summary>
    /// StructProperty: RedHoodKeyBinds
    /// </summary>
    public unsafe BmSDK.BmGame.RPersistentOptions.FStoredKeyMap RedHoodKeyBinds_18
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPersistentOptions.FStoredKeyMap>(Ptr + 5160); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5160); }
    }
    /// <summary>
    /// StructProperty: RedHoodKeyBinds
    /// </summary>
    public unsafe BmSDK.BmGame.RPersistentOptions.FStoredKeyMap RedHoodKeyBinds_19
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPersistentOptions.FStoredKeyMap>(Ptr + 5200); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5200); }
    }
    /// <summary>
    /// StructProperty: RedHoodKeyBinds
    /// </summary>
    public unsafe BmSDK.BmGame.RPersistentOptions.FStoredKeyMap RedHoodKeyBinds_20
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPersistentOptions.FStoredKeyMap>(Ptr + 5240); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5240); }
    }
    /// <summary>
    /// StructProperty: RedHoodKeyBinds
    /// </summary>
    public unsafe BmSDK.BmGame.RPersistentOptions.FStoredKeyMap RedHoodKeyBinds_21
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPersistentOptions.FStoredKeyMap>(Ptr + 5280); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5280); }
    }
    /// <summary>
    /// StructProperty: RedHoodKeyBinds
    /// </summary>
    public unsafe BmSDK.BmGame.RPersistentOptions.FStoredKeyMap RedHoodKeyBinds_22
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPersistentOptions.FStoredKeyMap>(Ptr + 5320); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5320); }
    }
    /// <summary>
    /// StructProperty: RedHoodKeyBinds
    /// </summary>
    public unsafe BmSDK.BmGame.RPersistentOptions.FStoredKeyMap RedHoodKeyBinds_23
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPersistentOptions.FStoredKeyMap>(Ptr + 5360); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5360); }
    }
    /// <summary>
    /// StructProperty: RedHoodKeyBinds
    /// </summary>
    public unsafe BmSDK.BmGame.RPersistentOptions.FStoredKeyMap RedHoodKeyBinds_24
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPersistentOptions.FStoredKeyMap>(Ptr + 5400); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5400); }
    }
    /// <summary>
    /// StructProperty: RedHoodKeyBinds
    /// </summary>
    public unsafe BmSDK.BmGame.RPersistentOptions.FStoredKeyMap RedHoodKeyBinds_25
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPersistentOptions.FStoredKeyMap>(Ptr + 5440); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5440); }
    }
    /// <summary>
    /// StructProperty: RedHoodKeyBinds
    /// </summary>
    public unsafe BmSDK.BmGame.RPersistentOptions.FStoredKeyMap RedHoodKeyBinds_26
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPersistentOptions.FStoredKeyMap>(Ptr + 5480); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5480); }
    }
    /// <summary>
    /// StructProperty: RedHoodKeyBinds
    /// </summary>
    public unsafe BmSDK.BmGame.RPersistentOptions.FStoredKeyMap RedHoodKeyBinds_27
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPersistentOptions.FStoredKeyMap>(Ptr + 5520); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5520); }
    }
    /// <summary>
    /// StructProperty: RedHoodKeyBinds
    /// </summary>
    public unsafe BmSDK.BmGame.RPersistentOptions.FStoredKeyMap RedHoodKeyBinds_28
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPersistentOptions.FStoredKeyMap>(Ptr + 5560); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5560); }
    }

    /// <summary>
    /// StructProperty: HarleyKeyBinds
    /// </summary>
    public unsafe BmSDK.BmGame.RPersistentOptions.FStoredKeyMap HarleyKeyBinds_0
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPersistentOptions.FStoredKeyMap>(Ptr + 5600); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5600); }
    }
    /// <summary>
    /// StructProperty: HarleyKeyBinds
    /// </summary>
    public unsafe BmSDK.BmGame.RPersistentOptions.FStoredKeyMap HarleyKeyBinds_1
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPersistentOptions.FStoredKeyMap>(Ptr + 5640); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5640); }
    }
    /// <summary>
    /// StructProperty: HarleyKeyBinds
    /// </summary>
    public unsafe BmSDK.BmGame.RPersistentOptions.FStoredKeyMap HarleyKeyBinds_2
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPersistentOptions.FStoredKeyMap>(Ptr + 5680); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5680); }
    }
    /// <summary>
    /// StructProperty: HarleyKeyBinds
    /// </summary>
    public unsafe BmSDK.BmGame.RPersistentOptions.FStoredKeyMap HarleyKeyBinds_3
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPersistentOptions.FStoredKeyMap>(Ptr + 5720); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5720); }
    }
    /// <summary>
    /// StructProperty: HarleyKeyBinds
    /// </summary>
    public unsafe BmSDK.BmGame.RPersistentOptions.FStoredKeyMap HarleyKeyBinds_4
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPersistentOptions.FStoredKeyMap>(Ptr + 5760); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5760); }
    }
    /// <summary>
    /// StructProperty: HarleyKeyBinds
    /// </summary>
    public unsafe BmSDK.BmGame.RPersistentOptions.FStoredKeyMap HarleyKeyBinds_5
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPersistentOptions.FStoredKeyMap>(Ptr + 5800); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5800); }
    }
    /// <summary>
    /// StructProperty: HarleyKeyBinds
    /// </summary>
    public unsafe BmSDK.BmGame.RPersistentOptions.FStoredKeyMap HarleyKeyBinds_6
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPersistentOptions.FStoredKeyMap>(Ptr + 5840); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5840); }
    }
    /// <summary>
    /// StructProperty: HarleyKeyBinds
    /// </summary>
    public unsafe BmSDK.BmGame.RPersistentOptions.FStoredKeyMap HarleyKeyBinds_7
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPersistentOptions.FStoredKeyMap>(Ptr + 5880); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5880); }
    }
    /// <summary>
    /// StructProperty: HarleyKeyBinds
    /// </summary>
    public unsafe BmSDK.BmGame.RPersistentOptions.FStoredKeyMap HarleyKeyBinds_8
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPersistentOptions.FStoredKeyMap>(Ptr + 5920); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5920); }
    }
    /// <summary>
    /// StructProperty: HarleyKeyBinds
    /// </summary>
    public unsafe BmSDK.BmGame.RPersistentOptions.FStoredKeyMap HarleyKeyBinds_9
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPersistentOptions.FStoredKeyMap>(Ptr + 5960); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5960); }
    }
    /// <summary>
    /// StructProperty: HarleyKeyBinds
    /// </summary>
    public unsafe BmSDK.BmGame.RPersistentOptions.FStoredKeyMap HarleyKeyBinds_10
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPersistentOptions.FStoredKeyMap>(Ptr + 6000); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6000); }
    }
    /// <summary>
    /// StructProperty: HarleyKeyBinds
    /// </summary>
    public unsafe BmSDK.BmGame.RPersistentOptions.FStoredKeyMap HarleyKeyBinds_11
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPersistentOptions.FStoredKeyMap>(Ptr + 6040); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6040); }
    }
    /// <summary>
    /// StructProperty: HarleyKeyBinds
    /// </summary>
    public unsafe BmSDK.BmGame.RPersistentOptions.FStoredKeyMap HarleyKeyBinds_12
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPersistentOptions.FStoredKeyMap>(Ptr + 6080); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6080); }
    }
    /// <summary>
    /// StructProperty: HarleyKeyBinds
    /// </summary>
    public unsafe BmSDK.BmGame.RPersistentOptions.FStoredKeyMap HarleyKeyBinds_13
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPersistentOptions.FStoredKeyMap>(Ptr + 6120); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6120); }
    }
    /// <summary>
    /// StructProperty: HarleyKeyBinds
    /// </summary>
    public unsafe BmSDK.BmGame.RPersistentOptions.FStoredKeyMap HarleyKeyBinds_14
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPersistentOptions.FStoredKeyMap>(Ptr + 6160); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6160); }
    }
    /// <summary>
    /// StructProperty: HarleyKeyBinds
    /// </summary>
    public unsafe BmSDK.BmGame.RPersistentOptions.FStoredKeyMap HarleyKeyBinds_15
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPersistentOptions.FStoredKeyMap>(Ptr + 6200); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6200); }
    }
    /// <summary>
    /// StructProperty: HarleyKeyBinds
    /// </summary>
    public unsafe BmSDK.BmGame.RPersistentOptions.FStoredKeyMap HarleyKeyBinds_16
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPersistentOptions.FStoredKeyMap>(Ptr + 6240); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6240); }
    }
    /// <summary>
    /// StructProperty: HarleyKeyBinds
    /// </summary>
    public unsafe BmSDK.BmGame.RPersistentOptions.FStoredKeyMap HarleyKeyBinds_17
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPersistentOptions.FStoredKeyMap>(Ptr + 6280); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6280); }
    }
    /// <summary>
    /// StructProperty: HarleyKeyBinds
    /// </summary>
    public unsafe BmSDK.BmGame.RPersistentOptions.FStoredKeyMap HarleyKeyBinds_18
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPersistentOptions.FStoredKeyMap>(Ptr + 6320); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6320); }
    }
    /// <summary>
    /// StructProperty: HarleyKeyBinds
    /// </summary>
    public unsafe BmSDK.BmGame.RPersistentOptions.FStoredKeyMap HarleyKeyBinds_19
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPersistentOptions.FStoredKeyMap>(Ptr + 6360); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6360); }
    }
    /// <summary>
    /// StructProperty: HarleyKeyBinds
    /// </summary>
    public unsafe BmSDK.BmGame.RPersistentOptions.FStoredKeyMap HarleyKeyBinds_20
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPersistentOptions.FStoredKeyMap>(Ptr + 6400); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6400); }
    }
    /// <summary>
    /// StructProperty: HarleyKeyBinds
    /// </summary>
    public unsafe BmSDK.BmGame.RPersistentOptions.FStoredKeyMap HarleyKeyBinds_21
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPersistentOptions.FStoredKeyMap>(Ptr + 6440); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6440); }
    }
    /// <summary>
    /// StructProperty: HarleyKeyBinds
    /// </summary>
    public unsafe BmSDK.BmGame.RPersistentOptions.FStoredKeyMap HarleyKeyBinds_22
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPersistentOptions.FStoredKeyMap>(Ptr + 6480); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6480); }
    }
    /// <summary>
    /// StructProperty: HarleyKeyBinds
    /// </summary>
    public unsafe BmSDK.BmGame.RPersistentOptions.FStoredKeyMap HarleyKeyBinds_23
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPersistentOptions.FStoredKeyMap>(Ptr + 6520); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6520); }
    }
    /// <summary>
    /// StructProperty: HarleyKeyBinds
    /// </summary>
    public unsafe BmSDK.BmGame.RPersistentOptions.FStoredKeyMap HarleyKeyBinds_24
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPersistentOptions.FStoredKeyMap>(Ptr + 6560); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6560); }
    }
    /// <summary>
    /// StructProperty: HarleyKeyBinds
    /// </summary>
    public unsafe BmSDK.BmGame.RPersistentOptions.FStoredKeyMap HarleyKeyBinds_25
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPersistentOptions.FStoredKeyMap>(Ptr + 6600); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6600); }
    }
    /// <summary>
    /// StructProperty: HarleyKeyBinds
    /// </summary>
    public unsafe BmSDK.BmGame.RPersistentOptions.FStoredKeyMap HarleyKeyBinds_26
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPersistentOptions.FStoredKeyMap>(Ptr + 6640); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6640); }
    }
    /// <summary>
    /// StructProperty: HarleyKeyBinds
    /// </summary>
    public unsafe BmSDK.BmGame.RPersistentOptions.FStoredKeyMap HarleyKeyBinds_27
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPersistentOptions.FStoredKeyMap>(Ptr + 6680); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6680); }
    }

    /// <summary>
    /// StructProperty: Tmp_BatmanKeyBinds
    /// </summary>
    public unsafe BmSDK.BmGame.RPersistentOptions.FStoredKeyMap Tmp_BatmanKeyBinds_0
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPersistentOptions.FStoredKeyMap>(Ptr + 6720); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6720); }
    }
    /// <summary>
    /// StructProperty: Tmp_BatmanKeyBinds
    /// </summary>
    public unsafe BmSDK.BmGame.RPersistentOptions.FStoredKeyMap Tmp_BatmanKeyBinds_1
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPersistentOptions.FStoredKeyMap>(Ptr + 6760); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6760); }
    }
    /// <summary>
    /// StructProperty: Tmp_BatmanKeyBinds
    /// </summary>
    public unsafe BmSDK.BmGame.RPersistentOptions.FStoredKeyMap Tmp_BatmanKeyBinds_2
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPersistentOptions.FStoredKeyMap>(Ptr + 6800); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6800); }
    }
    /// <summary>
    /// StructProperty: Tmp_BatmanKeyBinds
    /// </summary>
    public unsafe BmSDK.BmGame.RPersistentOptions.FStoredKeyMap Tmp_BatmanKeyBinds_3
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPersistentOptions.FStoredKeyMap>(Ptr + 6840); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6840); }
    }
    /// <summary>
    /// StructProperty: Tmp_BatmanKeyBinds
    /// </summary>
    public unsafe BmSDK.BmGame.RPersistentOptions.FStoredKeyMap Tmp_BatmanKeyBinds_4
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPersistentOptions.FStoredKeyMap>(Ptr + 6880); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6880); }
    }
    /// <summary>
    /// StructProperty: Tmp_BatmanKeyBinds
    /// </summary>
    public unsafe BmSDK.BmGame.RPersistentOptions.FStoredKeyMap Tmp_BatmanKeyBinds_5
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPersistentOptions.FStoredKeyMap>(Ptr + 6920); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6920); }
    }
    /// <summary>
    /// StructProperty: Tmp_BatmanKeyBinds
    /// </summary>
    public unsafe BmSDK.BmGame.RPersistentOptions.FStoredKeyMap Tmp_BatmanKeyBinds_6
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPersistentOptions.FStoredKeyMap>(Ptr + 6960); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6960); }
    }
    /// <summary>
    /// StructProperty: Tmp_BatmanKeyBinds
    /// </summary>
    public unsafe BmSDK.BmGame.RPersistentOptions.FStoredKeyMap Tmp_BatmanKeyBinds_7
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPersistentOptions.FStoredKeyMap>(Ptr + 7000); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7000); }
    }
    /// <summary>
    /// StructProperty: Tmp_BatmanKeyBinds
    /// </summary>
    public unsafe BmSDK.BmGame.RPersistentOptions.FStoredKeyMap Tmp_BatmanKeyBinds_8
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPersistentOptions.FStoredKeyMap>(Ptr + 7040); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7040); }
    }
    /// <summary>
    /// StructProperty: Tmp_BatmanKeyBinds
    /// </summary>
    public unsafe BmSDK.BmGame.RPersistentOptions.FStoredKeyMap Tmp_BatmanKeyBinds_9
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPersistentOptions.FStoredKeyMap>(Ptr + 7080); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7080); }
    }
    /// <summary>
    /// StructProperty: Tmp_BatmanKeyBinds
    /// </summary>
    public unsafe BmSDK.BmGame.RPersistentOptions.FStoredKeyMap Tmp_BatmanKeyBinds_10
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPersistentOptions.FStoredKeyMap>(Ptr + 7120); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7120); }
    }
    /// <summary>
    /// StructProperty: Tmp_BatmanKeyBinds
    /// </summary>
    public unsafe BmSDK.BmGame.RPersistentOptions.FStoredKeyMap Tmp_BatmanKeyBinds_11
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPersistentOptions.FStoredKeyMap>(Ptr + 7160); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7160); }
    }
    /// <summary>
    /// StructProperty: Tmp_BatmanKeyBinds
    /// </summary>
    public unsafe BmSDK.BmGame.RPersistentOptions.FStoredKeyMap Tmp_BatmanKeyBinds_12
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPersistentOptions.FStoredKeyMap>(Ptr + 7200); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7200); }
    }
    /// <summary>
    /// StructProperty: Tmp_BatmanKeyBinds
    /// </summary>
    public unsafe BmSDK.BmGame.RPersistentOptions.FStoredKeyMap Tmp_BatmanKeyBinds_13
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPersistentOptions.FStoredKeyMap>(Ptr + 7240); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7240); }
    }
    /// <summary>
    /// StructProperty: Tmp_BatmanKeyBinds
    /// </summary>
    public unsafe BmSDK.BmGame.RPersistentOptions.FStoredKeyMap Tmp_BatmanKeyBinds_14
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPersistentOptions.FStoredKeyMap>(Ptr + 7280); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7280); }
    }
    /// <summary>
    /// StructProperty: Tmp_BatmanKeyBinds
    /// </summary>
    public unsafe BmSDK.BmGame.RPersistentOptions.FStoredKeyMap Tmp_BatmanKeyBinds_15
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPersistentOptions.FStoredKeyMap>(Ptr + 7320); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7320); }
    }
    /// <summary>
    /// StructProperty: Tmp_BatmanKeyBinds
    /// </summary>
    public unsafe BmSDK.BmGame.RPersistentOptions.FStoredKeyMap Tmp_BatmanKeyBinds_16
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPersistentOptions.FStoredKeyMap>(Ptr + 7360); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7360); }
    }
    /// <summary>
    /// StructProperty: Tmp_BatmanKeyBinds
    /// </summary>
    public unsafe BmSDK.BmGame.RPersistentOptions.FStoredKeyMap Tmp_BatmanKeyBinds_17
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPersistentOptions.FStoredKeyMap>(Ptr + 7400); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7400); }
    }
    /// <summary>
    /// StructProperty: Tmp_BatmanKeyBinds
    /// </summary>
    public unsafe BmSDK.BmGame.RPersistentOptions.FStoredKeyMap Tmp_BatmanKeyBinds_18
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPersistentOptions.FStoredKeyMap>(Ptr + 7440); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7440); }
    }
    /// <summary>
    /// StructProperty: Tmp_BatmanKeyBinds
    /// </summary>
    public unsafe BmSDK.BmGame.RPersistentOptions.FStoredKeyMap Tmp_BatmanKeyBinds_19
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPersistentOptions.FStoredKeyMap>(Ptr + 7480); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7480); }
    }
    /// <summary>
    /// StructProperty: Tmp_BatmanKeyBinds
    /// </summary>
    public unsafe BmSDK.BmGame.RPersistentOptions.FStoredKeyMap Tmp_BatmanKeyBinds_20
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPersistentOptions.FStoredKeyMap>(Ptr + 7520); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7520); }
    }
    /// <summary>
    /// StructProperty: Tmp_BatmanKeyBinds
    /// </summary>
    public unsafe BmSDK.BmGame.RPersistentOptions.FStoredKeyMap Tmp_BatmanKeyBinds_21
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPersistentOptions.FStoredKeyMap>(Ptr + 7560); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7560); }
    }
    /// <summary>
    /// StructProperty: Tmp_BatmanKeyBinds
    /// </summary>
    public unsafe BmSDK.BmGame.RPersistentOptions.FStoredKeyMap Tmp_BatmanKeyBinds_22
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPersistentOptions.FStoredKeyMap>(Ptr + 7600); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7600); }
    }
    /// <summary>
    /// StructProperty: Tmp_BatmanKeyBinds
    /// </summary>
    public unsafe BmSDK.BmGame.RPersistentOptions.FStoredKeyMap Tmp_BatmanKeyBinds_23
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPersistentOptions.FStoredKeyMap>(Ptr + 7640); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7640); }
    }
    /// <summary>
    /// StructProperty: Tmp_BatmanKeyBinds
    /// </summary>
    public unsafe BmSDK.BmGame.RPersistentOptions.FStoredKeyMap Tmp_BatmanKeyBinds_24
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPersistentOptions.FStoredKeyMap>(Ptr + 7680); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7680); }
    }
    /// <summary>
    /// StructProperty: Tmp_BatmanKeyBinds
    /// </summary>
    public unsafe BmSDK.BmGame.RPersistentOptions.FStoredKeyMap Tmp_BatmanKeyBinds_25
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPersistentOptions.FStoredKeyMap>(Ptr + 7720); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7720); }
    }
    /// <summary>
    /// StructProperty: Tmp_BatmanKeyBinds
    /// </summary>
    public unsafe BmSDK.BmGame.RPersistentOptions.FStoredKeyMap Tmp_BatmanKeyBinds_26
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPersistentOptions.FStoredKeyMap>(Ptr + 7760); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7760); }
    }
    /// <summary>
    /// StructProperty: Tmp_BatmanKeyBinds
    /// </summary>
    public unsafe BmSDK.BmGame.RPersistentOptions.FStoredKeyMap Tmp_BatmanKeyBinds_27
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPersistentOptions.FStoredKeyMap>(Ptr + 7800); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7800); }
    }
    /// <summary>
    /// StructProperty: Tmp_BatmanKeyBinds
    /// </summary>
    public unsafe BmSDK.BmGame.RPersistentOptions.FStoredKeyMap Tmp_BatmanKeyBinds_28
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPersistentOptions.FStoredKeyMap>(Ptr + 7840); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7840); }
    }
    /// <summary>
    /// StructProperty: Tmp_BatmanKeyBinds
    /// </summary>
    public unsafe BmSDK.BmGame.RPersistentOptions.FStoredKeyMap Tmp_BatmanKeyBinds_29
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPersistentOptions.FStoredKeyMap>(Ptr + 7880); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7880); }
    }
    /// <summary>
    /// StructProperty: Tmp_BatmanKeyBinds
    /// </summary>
    public unsafe BmSDK.BmGame.RPersistentOptions.FStoredKeyMap Tmp_BatmanKeyBinds_30
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPersistentOptions.FStoredKeyMap>(Ptr + 7920); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7920); }
    }
    /// <summary>
    /// StructProperty: Tmp_BatmanKeyBinds
    /// </summary>
    public unsafe BmSDK.BmGame.RPersistentOptions.FStoredKeyMap Tmp_BatmanKeyBinds_31
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPersistentOptions.FStoredKeyMap>(Ptr + 7960); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7960); }
    }
    /// <summary>
    /// StructProperty: Tmp_BatmanKeyBinds
    /// </summary>
    public unsafe BmSDK.BmGame.RPersistentOptions.FStoredKeyMap Tmp_BatmanKeyBinds_32
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPersistentOptions.FStoredKeyMap>(Ptr + 8000); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8000); }
    }
    /// <summary>
    /// StructProperty: Tmp_BatmanKeyBinds
    /// </summary>
    public unsafe BmSDK.BmGame.RPersistentOptions.FStoredKeyMap Tmp_BatmanKeyBinds_33
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPersistentOptions.FStoredKeyMap>(Ptr + 8040); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8040); }
    }
    /// <summary>
    /// StructProperty: Tmp_BatmanKeyBinds
    /// </summary>
    public unsafe BmSDK.BmGame.RPersistentOptions.FStoredKeyMap Tmp_BatmanKeyBinds_34
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPersistentOptions.FStoredKeyMap>(Ptr + 8080); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8080); }
    }
    /// <summary>
    /// StructProperty: Tmp_BatmanKeyBinds
    /// </summary>
    public unsafe BmSDK.BmGame.RPersistentOptions.FStoredKeyMap Tmp_BatmanKeyBinds_35
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPersistentOptions.FStoredKeyMap>(Ptr + 8120); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8120); }
    }
    /// <summary>
    /// StructProperty: Tmp_BatmanKeyBinds
    /// </summary>
    public unsafe BmSDK.BmGame.RPersistentOptions.FStoredKeyMap Tmp_BatmanKeyBinds_36
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPersistentOptions.FStoredKeyMap>(Ptr + 8160); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8160); }
    }
    /// <summary>
    /// StructProperty: Tmp_BatmanKeyBinds
    /// </summary>
    public unsafe BmSDK.BmGame.RPersistentOptions.FStoredKeyMap Tmp_BatmanKeyBinds_37
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPersistentOptions.FStoredKeyMap>(Ptr + 8200); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8200); }
    }
    /// <summary>
    /// StructProperty: Tmp_BatmanKeyBinds
    /// </summary>
    public unsafe BmSDK.BmGame.RPersistentOptions.FStoredKeyMap Tmp_BatmanKeyBinds_38
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPersistentOptions.FStoredKeyMap>(Ptr + 8240); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8240); }
    }
    /// <summary>
    /// StructProperty: Tmp_BatmanKeyBinds
    /// </summary>
    public unsafe BmSDK.BmGame.RPersistentOptions.FStoredKeyMap Tmp_BatmanKeyBinds_39
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPersistentOptions.FStoredKeyMap>(Ptr + 8280); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8280); }
    }
    /// <summary>
    /// StructProperty: Tmp_BatmanKeyBinds
    /// </summary>
    public unsafe BmSDK.BmGame.RPersistentOptions.FStoredKeyMap Tmp_BatmanKeyBinds_40
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPersistentOptions.FStoredKeyMap>(Ptr + 8320); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8320); }
    }

    /// <summary>
    /// StructProperty: Tmp_PursuitKeyBinds
    /// </summary>
    public unsafe BmSDK.BmGame.RPersistentOptions.FStoredKeyMap Tmp_PursuitKeyBinds_0
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPersistentOptions.FStoredKeyMap>(Ptr + 8360); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8360); }
    }
    /// <summary>
    /// StructProperty: Tmp_PursuitKeyBinds
    /// </summary>
    public unsafe BmSDK.BmGame.RPersistentOptions.FStoredKeyMap Tmp_PursuitKeyBinds_1
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPersistentOptions.FStoredKeyMap>(Ptr + 8400); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8400); }
    }
    /// <summary>
    /// StructProperty: Tmp_PursuitKeyBinds
    /// </summary>
    public unsafe BmSDK.BmGame.RPersistentOptions.FStoredKeyMap Tmp_PursuitKeyBinds_2
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPersistentOptions.FStoredKeyMap>(Ptr + 8440); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8440); }
    }
    /// <summary>
    /// StructProperty: Tmp_PursuitKeyBinds
    /// </summary>
    public unsafe BmSDK.BmGame.RPersistentOptions.FStoredKeyMap Tmp_PursuitKeyBinds_3
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPersistentOptions.FStoredKeyMap>(Ptr + 8480); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8480); }
    }
    /// <summary>
    /// StructProperty: Tmp_PursuitKeyBinds
    /// </summary>
    public unsafe BmSDK.BmGame.RPersistentOptions.FStoredKeyMap Tmp_PursuitKeyBinds_4
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPersistentOptions.FStoredKeyMap>(Ptr + 8520); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8520); }
    }
    /// <summary>
    /// StructProperty: Tmp_PursuitKeyBinds
    /// </summary>
    public unsafe BmSDK.BmGame.RPersistentOptions.FStoredKeyMap Tmp_PursuitKeyBinds_5
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPersistentOptions.FStoredKeyMap>(Ptr + 8560); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8560); }
    }
    /// <summary>
    /// StructProperty: Tmp_PursuitKeyBinds
    /// </summary>
    public unsafe BmSDK.BmGame.RPersistentOptions.FStoredKeyMap Tmp_PursuitKeyBinds_6
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPersistentOptions.FStoredKeyMap>(Ptr + 8600); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8600); }
    }
    /// <summary>
    /// StructProperty: Tmp_PursuitKeyBinds
    /// </summary>
    public unsafe BmSDK.BmGame.RPersistentOptions.FStoredKeyMap Tmp_PursuitKeyBinds_7
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPersistentOptions.FStoredKeyMap>(Ptr + 8640); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8640); }
    }
    /// <summary>
    /// StructProperty: Tmp_PursuitKeyBinds
    /// </summary>
    public unsafe BmSDK.BmGame.RPersistentOptions.FStoredKeyMap Tmp_PursuitKeyBinds_8
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPersistentOptions.FStoredKeyMap>(Ptr + 8680); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8680); }
    }
    /// <summary>
    /// StructProperty: Tmp_PursuitKeyBinds
    /// </summary>
    public unsafe BmSDK.BmGame.RPersistentOptions.FStoredKeyMap Tmp_PursuitKeyBinds_9
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPersistentOptions.FStoredKeyMap>(Ptr + 8720); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8720); }
    }
    /// <summary>
    /// StructProperty: Tmp_PursuitKeyBinds
    /// </summary>
    public unsafe BmSDK.BmGame.RPersistentOptions.FStoredKeyMap Tmp_PursuitKeyBinds_10
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPersistentOptions.FStoredKeyMap>(Ptr + 8760); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8760); }
    }
    /// <summary>
    /// StructProperty: Tmp_PursuitKeyBinds
    /// </summary>
    public unsafe BmSDK.BmGame.RPersistentOptions.FStoredKeyMap Tmp_PursuitKeyBinds_11
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPersistentOptions.FStoredKeyMap>(Ptr + 8800); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8800); }
    }
    /// <summary>
    /// StructProperty: Tmp_PursuitKeyBinds
    /// </summary>
    public unsafe BmSDK.BmGame.RPersistentOptions.FStoredKeyMap Tmp_PursuitKeyBinds_12
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPersistentOptions.FStoredKeyMap>(Ptr + 8840); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8840); }
    }

    /// <summary>
    /// StructProperty: Tmp_BattleKeyBinds
    /// </summary>
    public unsafe BmSDK.BmGame.RPersistentOptions.FStoredKeyMap Tmp_BattleKeyBinds_0
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPersistentOptions.FStoredKeyMap>(Ptr + 8880); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8880); }
    }
    /// <summary>
    /// StructProperty: Tmp_BattleKeyBinds
    /// </summary>
    public unsafe BmSDK.BmGame.RPersistentOptions.FStoredKeyMap Tmp_BattleKeyBinds_1
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPersistentOptions.FStoredKeyMap>(Ptr + 8920); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8920); }
    }
    /// <summary>
    /// StructProperty: Tmp_BattleKeyBinds
    /// </summary>
    public unsafe BmSDK.BmGame.RPersistentOptions.FStoredKeyMap Tmp_BattleKeyBinds_2
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPersistentOptions.FStoredKeyMap>(Ptr + 8960); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8960); }
    }
    /// <summary>
    /// StructProperty: Tmp_BattleKeyBinds
    /// </summary>
    public unsafe BmSDK.BmGame.RPersistentOptions.FStoredKeyMap Tmp_BattleKeyBinds_3
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPersistentOptions.FStoredKeyMap>(Ptr + 9000); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 9000); }
    }
    /// <summary>
    /// StructProperty: Tmp_BattleKeyBinds
    /// </summary>
    public unsafe BmSDK.BmGame.RPersistentOptions.FStoredKeyMap Tmp_BattleKeyBinds_4
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPersistentOptions.FStoredKeyMap>(Ptr + 9040); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 9040); }
    }
    /// <summary>
    /// StructProperty: Tmp_BattleKeyBinds
    /// </summary>
    public unsafe BmSDK.BmGame.RPersistentOptions.FStoredKeyMap Tmp_BattleKeyBinds_5
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPersistentOptions.FStoredKeyMap>(Ptr + 9080); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 9080); }
    }
    /// <summary>
    /// StructProperty: Tmp_BattleKeyBinds
    /// </summary>
    public unsafe BmSDK.BmGame.RPersistentOptions.FStoredKeyMap Tmp_BattleKeyBinds_6
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPersistentOptions.FStoredKeyMap>(Ptr + 9120); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 9120); }
    }
    /// <summary>
    /// StructProperty: Tmp_BattleKeyBinds
    /// </summary>
    public unsafe BmSDK.BmGame.RPersistentOptions.FStoredKeyMap Tmp_BattleKeyBinds_7
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPersistentOptions.FStoredKeyMap>(Ptr + 9160); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 9160); }
    }
    /// <summary>
    /// StructProperty: Tmp_BattleKeyBinds
    /// </summary>
    public unsafe BmSDK.BmGame.RPersistentOptions.FStoredKeyMap Tmp_BattleKeyBinds_8
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPersistentOptions.FStoredKeyMap>(Ptr + 9200); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 9200); }
    }
    /// <summary>
    /// StructProperty: Tmp_BattleKeyBinds
    /// </summary>
    public unsafe BmSDK.BmGame.RPersistentOptions.FStoredKeyMap Tmp_BattleKeyBinds_9
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPersistentOptions.FStoredKeyMap>(Ptr + 9240); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 9240); }
    }
    /// <summary>
    /// StructProperty: Tmp_BattleKeyBinds
    /// </summary>
    public unsafe BmSDK.BmGame.RPersistentOptions.FStoredKeyMap Tmp_BattleKeyBinds_10
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPersistentOptions.FStoredKeyMap>(Ptr + 9280); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 9280); }
    }
    /// <summary>
    /// StructProperty: Tmp_BattleKeyBinds
    /// </summary>
    public unsafe BmSDK.BmGame.RPersistentOptions.FStoredKeyMap Tmp_BattleKeyBinds_11
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPersistentOptions.FStoredKeyMap>(Ptr + 9320); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 9320); }
    }
    /// <summary>
    /// StructProperty: Tmp_BattleKeyBinds
    /// </summary>
    public unsafe BmSDK.BmGame.RPersistentOptions.FStoredKeyMap Tmp_BattleKeyBinds_12
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPersistentOptions.FStoredKeyMap>(Ptr + 9360); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 9360); }
    }
    /// <summary>
    /// StructProperty: Tmp_BattleKeyBinds
    /// </summary>
    public unsafe BmSDK.BmGame.RPersistentOptions.FStoredKeyMap Tmp_BattleKeyBinds_13
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPersistentOptions.FStoredKeyMap>(Ptr + 9400); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 9400); }
    }
    /// <summary>
    /// StructProperty: Tmp_BattleKeyBinds
    /// </summary>
    public unsafe BmSDK.BmGame.RPersistentOptions.FStoredKeyMap Tmp_BattleKeyBinds_14
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPersistentOptions.FStoredKeyMap>(Ptr + 9440); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 9440); }
    }

    /// <summary>
    /// StructProperty: Tmp_BatgirlKeyBinds
    /// </summary>
    public unsafe BmSDK.BmGame.RPersistentOptions.FStoredKeyMap Tmp_BatgirlKeyBinds_0
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPersistentOptions.FStoredKeyMap>(Ptr + 9480); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 9480); }
    }
    /// <summary>
    /// StructProperty: Tmp_BatgirlKeyBinds
    /// </summary>
    public unsafe BmSDK.BmGame.RPersistentOptions.FStoredKeyMap Tmp_BatgirlKeyBinds_1
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPersistentOptions.FStoredKeyMap>(Ptr + 9520); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 9520); }
    }
    /// <summary>
    /// StructProperty: Tmp_BatgirlKeyBinds
    /// </summary>
    public unsafe BmSDK.BmGame.RPersistentOptions.FStoredKeyMap Tmp_BatgirlKeyBinds_2
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPersistentOptions.FStoredKeyMap>(Ptr + 9560); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 9560); }
    }
    /// <summary>
    /// StructProperty: Tmp_BatgirlKeyBinds
    /// </summary>
    public unsafe BmSDK.BmGame.RPersistentOptions.FStoredKeyMap Tmp_BatgirlKeyBinds_3
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPersistentOptions.FStoredKeyMap>(Ptr + 9600); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 9600); }
    }
    /// <summary>
    /// StructProperty: Tmp_BatgirlKeyBinds
    /// </summary>
    public unsafe BmSDK.BmGame.RPersistentOptions.FStoredKeyMap Tmp_BatgirlKeyBinds_4
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPersistentOptions.FStoredKeyMap>(Ptr + 9640); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 9640); }
    }
    /// <summary>
    /// StructProperty: Tmp_BatgirlKeyBinds
    /// </summary>
    public unsafe BmSDK.BmGame.RPersistentOptions.FStoredKeyMap Tmp_BatgirlKeyBinds_5
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPersistentOptions.FStoredKeyMap>(Ptr + 9680); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 9680); }
    }
    /// <summary>
    /// StructProperty: Tmp_BatgirlKeyBinds
    /// </summary>
    public unsafe BmSDK.BmGame.RPersistentOptions.FStoredKeyMap Tmp_BatgirlKeyBinds_6
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPersistentOptions.FStoredKeyMap>(Ptr + 9720); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 9720); }
    }
    /// <summary>
    /// StructProperty: Tmp_BatgirlKeyBinds
    /// </summary>
    public unsafe BmSDK.BmGame.RPersistentOptions.FStoredKeyMap Tmp_BatgirlKeyBinds_7
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPersistentOptions.FStoredKeyMap>(Ptr + 9760); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 9760); }
    }
    /// <summary>
    /// StructProperty: Tmp_BatgirlKeyBinds
    /// </summary>
    public unsafe BmSDK.BmGame.RPersistentOptions.FStoredKeyMap Tmp_BatgirlKeyBinds_8
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPersistentOptions.FStoredKeyMap>(Ptr + 9800); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 9800); }
    }
    /// <summary>
    /// StructProperty: Tmp_BatgirlKeyBinds
    /// </summary>
    public unsafe BmSDK.BmGame.RPersistentOptions.FStoredKeyMap Tmp_BatgirlKeyBinds_9
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPersistentOptions.FStoredKeyMap>(Ptr + 9840); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 9840); }
    }
    /// <summary>
    /// StructProperty: Tmp_BatgirlKeyBinds
    /// </summary>
    public unsafe BmSDK.BmGame.RPersistentOptions.FStoredKeyMap Tmp_BatgirlKeyBinds_10
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPersistentOptions.FStoredKeyMap>(Ptr + 9880); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 9880); }
    }
    /// <summary>
    /// StructProperty: Tmp_BatgirlKeyBinds
    /// </summary>
    public unsafe BmSDK.BmGame.RPersistentOptions.FStoredKeyMap Tmp_BatgirlKeyBinds_11
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPersistentOptions.FStoredKeyMap>(Ptr + 9920); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 9920); }
    }
    /// <summary>
    /// StructProperty: Tmp_BatgirlKeyBinds
    /// </summary>
    public unsafe BmSDK.BmGame.RPersistentOptions.FStoredKeyMap Tmp_BatgirlKeyBinds_12
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPersistentOptions.FStoredKeyMap>(Ptr + 9960); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 9960); }
    }
    /// <summary>
    /// StructProperty: Tmp_BatgirlKeyBinds
    /// </summary>
    public unsafe BmSDK.BmGame.RPersistentOptions.FStoredKeyMap Tmp_BatgirlKeyBinds_13
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPersistentOptions.FStoredKeyMap>(Ptr + 10000); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 10000); }
    }
    /// <summary>
    /// StructProperty: Tmp_BatgirlKeyBinds
    /// </summary>
    public unsafe BmSDK.BmGame.RPersistentOptions.FStoredKeyMap Tmp_BatgirlKeyBinds_14
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPersistentOptions.FStoredKeyMap>(Ptr + 10040); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 10040); }
    }
    /// <summary>
    /// StructProperty: Tmp_BatgirlKeyBinds
    /// </summary>
    public unsafe BmSDK.BmGame.RPersistentOptions.FStoredKeyMap Tmp_BatgirlKeyBinds_15
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPersistentOptions.FStoredKeyMap>(Ptr + 10080); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 10080); }
    }
    /// <summary>
    /// StructProperty: Tmp_BatgirlKeyBinds
    /// </summary>
    public unsafe BmSDK.BmGame.RPersistentOptions.FStoredKeyMap Tmp_BatgirlKeyBinds_16
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPersistentOptions.FStoredKeyMap>(Ptr + 10120); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 10120); }
    }
    /// <summary>
    /// StructProperty: Tmp_BatgirlKeyBinds
    /// </summary>
    public unsafe BmSDK.BmGame.RPersistentOptions.FStoredKeyMap Tmp_BatgirlKeyBinds_17
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPersistentOptions.FStoredKeyMap>(Ptr + 10160); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 10160); }
    }
    /// <summary>
    /// StructProperty: Tmp_BatgirlKeyBinds
    /// </summary>
    public unsafe BmSDK.BmGame.RPersistentOptions.FStoredKeyMap Tmp_BatgirlKeyBinds_18
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPersistentOptions.FStoredKeyMap>(Ptr + 10200); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 10200); }
    }
    /// <summary>
    /// StructProperty: Tmp_BatgirlKeyBinds
    /// </summary>
    public unsafe BmSDK.BmGame.RPersistentOptions.FStoredKeyMap Tmp_BatgirlKeyBinds_19
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPersistentOptions.FStoredKeyMap>(Ptr + 10240); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 10240); }
    }
    /// <summary>
    /// StructProperty: Tmp_BatgirlKeyBinds
    /// </summary>
    public unsafe BmSDK.BmGame.RPersistentOptions.FStoredKeyMap Tmp_BatgirlKeyBinds_20
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPersistentOptions.FStoredKeyMap>(Ptr + 10280); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 10280); }
    }
    /// <summary>
    /// StructProperty: Tmp_BatgirlKeyBinds
    /// </summary>
    public unsafe BmSDK.BmGame.RPersistentOptions.FStoredKeyMap Tmp_BatgirlKeyBinds_21
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPersistentOptions.FStoredKeyMap>(Ptr + 10320); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 10320); }
    }
    /// <summary>
    /// StructProperty: Tmp_BatgirlKeyBinds
    /// </summary>
    public unsafe BmSDK.BmGame.RPersistentOptions.FStoredKeyMap Tmp_BatgirlKeyBinds_22
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPersistentOptions.FStoredKeyMap>(Ptr + 10360); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 10360); }
    }
    /// <summary>
    /// StructProperty: Tmp_BatgirlKeyBinds
    /// </summary>
    public unsafe BmSDK.BmGame.RPersistentOptions.FStoredKeyMap Tmp_BatgirlKeyBinds_23
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPersistentOptions.FStoredKeyMap>(Ptr + 10400); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 10400); }
    }
    /// <summary>
    /// StructProperty: Tmp_BatgirlKeyBinds
    /// </summary>
    public unsafe BmSDK.BmGame.RPersistentOptions.FStoredKeyMap Tmp_BatgirlKeyBinds_24
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPersistentOptions.FStoredKeyMap>(Ptr + 10440); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 10440); }
    }
    /// <summary>
    /// StructProperty: Tmp_BatgirlKeyBinds
    /// </summary>
    public unsafe BmSDK.BmGame.RPersistentOptions.FStoredKeyMap Tmp_BatgirlKeyBinds_25
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPersistentOptions.FStoredKeyMap>(Ptr + 10480); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 10480); }
    }
    /// <summary>
    /// StructProperty: Tmp_BatgirlKeyBinds
    /// </summary>
    public unsafe BmSDK.BmGame.RPersistentOptions.FStoredKeyMap Tmp_BatgirlKeyBinds_26
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPersistentOptions.FStoredKeyMap>(Ptr + 10520); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 10520); }
    }
    /// <summary>
    /// StructProperty: Tmp_BatgirlKeyBinds
    /// </summary>
    public unsafe BmSDK.BmGame.RPersistentOptions.FStoredKeyMap Tmp_BatgirlKeyBinds_27
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPersistentOptions.FStoredKeyMap>(Ptr + 10560); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 10560); }
    }
    /// <summary>
    /// StructProperty: Tmp_BatgirlKeyBinds
    /// </summary>
    public unsafe BmSDK.BmGame.RPersistentOptions.FStoredKeyMap Tmp_BatgirlKeyBinds_28
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPersistentOptions.FStoredKeyMap>(Ptr + 10600); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 10600); }
    }

    /// <summary>
    /// StructProperty: Tmp_RedHoodKeyBinds
    /// </summary>
    public unsafe BmSDK.BmGame.RPersistentOptions.FStoredKeyMap Tmp_RedHoodKeyBinds_0
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPersistentOptions.FStoredKeyMap>(Ptr + 10640); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 10640); }
    }
    /// <summary>
    /// StructProperty: Tmp_RedHoodKeyBinds
    /// </summary>
    public unsafe BmSDK.BmGame.RPersistentOptions.FStoredKeyMap Tmp_RedHoodKeyBinds_1
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPersistentOptions.FStoredKeyMap>(Ptr + 10680); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 10680); }
    }
    /// <summary>
    /// StructProperty: Tmp_RedHoodKeyBinds
    /// </summary>
    public unsafe BmSDK.BmGame.RPersistentOptions.FStoredKeyMap Tmp_RedHoodKeyBinds_2
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPersistentOptions.FStoredKeyMap>(Ptr + 10720); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 10720); }
    }
    /// <summary>
    /// StructProperty: Tmp_RedHoodKeyBinds
    /// </summary>
    public unsafe BmSDK.BmGame.RPersistentOptions.FStoredKeyMap Tmp_RedHoodKeyBinds_3
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPersistentOptions.FStoredKeyMap>(Ptr + 10760); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 10760); }
    }
    /// <summary>
    /// StructProperty: Tmp_RedHoodKeyBinds
    /// </summary>
    public unsafe BmSDK.BmGame.RPersistentOptions.FStoredKeyMap Tmp_RedHoodKeyBinds_4
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPersistentOptions.FStoredKeyMap>(Ptr + 10800); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 10800); }
    }
    /// <summary>
    /// StructProperty: Tmp_RedHoodKeyBinds
    /// </summary>
    public unsafe BmSDK.BmGame.RPersistentOptions.FStoredKeyMap Tmp_RedHoodKeyBinds_5
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPersistentOptions.FStoredKeyMap>(Ptr + 10840); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 10840); }
    }
    /// <summary>
    /// StructProperty: Tmp_RedHoodKeyBinds
    /// </summary>
    public unsafe BmSDK.BmGame.RPersistentOptions.FStoredKeyMap Tmp_RedHoodKeyBinds_6
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPersistentOptions.FStoredKeyMap>(Ptr + 10880); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 10880); }
    }
    /// <summary>
    /// StructProperty: Tmp_RedHoodKeyBinds
    /// </summary>
    public unsafe BmSDK.BmGame.RPersistentOptions.FStoredKeyMap Tmp_RedHoodKeyBinds_7
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPersistentOptions.FStoredKeyMap>(Ptr + 10920); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 10920); }
    }
    /// <summary>
    /// StructProperty: Tmp_RedHoodKeyBinds
    /// </summary>
    public unsafe BmSDK.BmGame.RPersistentOptions.FStoredKeyMap Tmp_RedHoodKeyBinds_8
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPersistentOptions.FStoredKeyMap>(Ptr + 10960); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 10960); }
    }
    /// <summary>
    /// StructProperty: Tmp_RedHoodKeyBinds
    /// </summary>
    public unsafe BmSDK.BmGame.RPersistentOptions.FStoredKeyMap Tmp_RedHoodKeyBinds_9
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPersistentOptions.FStoredKeyMap>(Ptr + 11000); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 11000); }
    }
    /// <summary>
    /// StructProperty: Tmp_RedHoodKeyBinds
    /// </summary>
    public unsafe BmSDK.BmGame.RPersistentOptions.FStoredKeyMap Tmp_RedHoodKeyBinds_10
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPersistentOptions.FStoredKeyMap>(Ptr + 11040); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 11040); }
    }
    /// <summary>
    /// StructProperty: Tmp_RedHoodKeyBinds
    /// </summary>
    public unsafe BmSDK.BmGame.RPersistentOptions.FStoredKeyMap Tmp_RedHoodKeyBinds_11
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPersistentOptions.FStoredKeyMap>(Ptr + 11080); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 11080); }
    }
    /// <summary>
    /// StructProperty: Tmp_RedHoodKeyBinds
    /// </summary>
    public unsafe BmSDK.BmGame.RPersistentOptions.FStoredKeyMap Tmp_RedHoodKeyBinds_12
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPersistentOptions.FStoredKeyMap>(Ptr + 11120); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 11120); }
    }
    /// <summary>
    /// StructProperty: Tmp_RedHoodKeyBinds
    /// </summary>
    public unsafe BmSDK.BmGame.RPersistentOptions.FStoredKeyMap Tmp_RedHoodKeyBinds_13
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPersistentOptions.FStoredKeyMap>(Ptr + 11160); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 11160); }
    }
    /// <summary>
    /// StructProperty: Tmp_RedHoodKeyBinds
    /// </summary>
    public unsafe BmSDK.BmGame.RPersistentOptions.FStoredKeyMap Tmp_RedHoodKeyBinds_14
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPersistentOptions.FStoredKeyMap>(Ptr + 11200); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 11200); }
    }
    /// <summary>
    /// StructProperty: Tmp_RedHoodKeyBinds
    /// </summary>
    public unsafe BmSDK.BmGame.RPersistentOptions.FStoredKeyMap Tmp_RedHoodKeyBinds_15
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPersistentOptions.FStoredKeyMap>(Ptr + 11240); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 11240); }
    }
    /// <summary>
    /// StructProperty: Tmp_RedHoodKeyBinds
    /// </summary>
    public unsafe BmSDK.BmGame.RPersistentOptions.FStoredKeyMap Tmp_RedHoodKeyBinds_16
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPersistentOptions.FStoredKeyMap>(Ptr + 11280); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 11280); }
    }
    /// <summary>
    /// StructProperty: Tmp_RedHoodKeyBinds
    /// </summary>
    public unsafe BmSDK.BmGame.RPersistentOptions.FStoredKeyMap Tmp_RedHoodKeyBinds_17
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPersistentOptions.FStoredKeyMap>(Ptr + 11320); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 11320); }
    }
    /// <summary>
    /// StructProperty: Tmp_RedHoodKeyBinds
    /// </summary>
    public unsafe BmSDK.BmGame.RPersistentOptions.FStoredKeyMap Tmp_RedHoodKeyBinds_18
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPersistentOptions.FStoredKeyMap>(Ptr + 11360); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 11360); }
    }
    /// <summary>
    /// StructProperty: Tmp_RedHoodKeyBinds
    /// </summary>
    public unsafe BmSDK.BmGame.RPersistentOptions.FStoredKeyMap Tmp_RedHoodKeyBinds_19
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPersistentOptions.FStoredKeyMap>(Ptr + 11400); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 11400); }
    }
    /// <summary>
    /// StructProperty: Tmp_RedHoodKeyBinds
    /// </summary>
    public unsafe BmSDK.BmGame.RPersistentOptions.FStoredKeyMap Tmp_RedHoodKeyBinds_20
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPersistentOptions.FStoredKeyMap>(Ptr + 11440); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 11440); }
    }
    /// <summary>
    /// StructProperty: Tmp_RedHoodKeyBinds
    /// </summary>
    public unsafe BmSDK.BmGame.RPersistentOptions.FStoredKeyMap Tmp_RedHoodKeyBinds_21
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPersistentOptions.FStoredKeyMap>(Ptr + 11480); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 11480); }
    }
    /// <summary>
    /// StructProperty: Tmp_RedHoodKeyBinds
    /// </summary>
    public unsafe BmSDK.BmGame.RPersistentOptions.FStoredKeyMap Tmp_RedHoodKeyBinds_22
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPersistentOptions.FStoredKeyMap>(Ptr + 11520); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 11520); }
    }
    /// <summary>
    /// StructProperty: Tmp_RedHoodKeyBinds
    /// </summary>
    public unsafe BmSDK.BmGame.RPersistentOptions.FStoredKeyMap Tmp_RedHoodKeyBinds_23
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPersistentOptions.FStoredKeyMap>(Ptr + 11560); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 11560); }
    }
    /// <summary>
    /// StructProperty: Tmp_RedHoodKeyBinds
    /// </summary>
    public unsafe BmSDK.BmGame.RPersistentOptions.FStoredKeyMap Tmp_RedHoodKeyBinds_24
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPersistentOptions.FStoredKeyMap>(Ptr + 11600); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 11600); }
    }
    /// <summary>
    /// StructProperty: Tmp_RedHoodKeyBinds
    /// </summary>
    public unsafe BmSDK.BmGame.RPersistentOptions.FStoredKeyMap Tmp_RedHoodKeyBinds_25
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPersistentOptions.FStoredKeyMap>(Ptr + 11640); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 11640); }
    }
    /// <summary>
    /// StructProperty: Tmp_RedHoodKeyBinds
    /// </summary>
    public unsafe BmSDK.BmGame.RPersistentOptions.FStoredKeyMap Tmp_RedHoodKeyBinds_26
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPersistentOptions.FStoredKeyMap>(Ptr + 11680); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 11680); }
    }
    /// <summary>
    /// StructProperty: Tmp_RedHoodKeyBinds
    /// </summary>
    public unsafe BmSDK.BmGame.RPersistentOptions.FStoredKeyMap Tmp_RedHoodKeyBinds_27
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPersistentOptions.FStoredKeyMap>(Ptr + 11720); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 11720); }
    }
    /// <summary>
    /// StructProperty: Tmp_RedHoodKeyBinds
    /// </summary>
    public unsafe BmSDK.BmGame.RPersistentOptions.FStoredKeyMap Tmp_RedHoodKeyBinds_28
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPersistentOptions.FStoredKeyMap>(Ptr + 11760); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 11760); }
    }

    /// <summary>
    /// StructProperty: Tmp_HarleyKeyBinds
    /// </summary>
    public unsafe BmSDK.BmGame.RPersistentOptions.FStoredKeyMap Tmp_HarleyKeyBinds_0
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPersistentOptions.FStoredKeyMap>(Ptr + 11800); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 11800); }
    }
    /// <summary>
    /// StructProperty: Tmp_HarleyKeyBinds
    /// </summary>
    public unsafe BmSDK.BmGame.RPersistentOptions.FStoredKeyMap Tmp_HarleyKeyBinds_1
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPersistentOptions.FStoredKeyMap>(Ptr + 11840); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 11840); }
    }
    /// <summary>
    /// StructProperty: Tmp_HarleyKeyBinds
    /// </summary>
    public unsafe BmSDK.BmGame.RPersistentOptions.FStoredKeyMap Tmp_HarleyKeyBinds_2
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPersistentOptions.FStoredKeyMap>(Ptr + 11880); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 11880); }
    }
    /// <summary>
    /// StructProperty: Tmp_HarleyKeyBinds
    /// </summary>
    public unsafe BmSDK.BmGame.RPersistentOptions.FStoredKeyMap Tmp_HarleyKeyBinds_3
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPersistentOptions.FStoredKeyMap>(Ptr + 11920); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 11920); }
    }
    /// <summary>
    /// StructProperty: Tmp_HarleyKeyBinds
    /// </summary>
    public unsafe BmSDK.BmGame.RPersistentOptions.FStoredKeyMap Tmp_HarleyKeyBinds_4
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPersistentOptions.FStoredKeyMap>(Ptr + 11960); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 11960); }
    }
    /// <summary>
    /// StructProperty: Tmp_HarleyKeyBinds
    /// </summary>
    public unsafe BmSDK.BmGame.RPersistentOptions.FStoredKeyMap Tmp_HarleyKeyBinds_5
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPersistentOptions.FStoredKeyMap>(Ptr + 12000); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 12000); }
    }
    /// <summary>
    /// StructProperty: Tmp_HarleyKeyBinds
    /// </summary>
    public unsafe BmSDK.BmGame.RPersistentOptions.FStoredKeyMap Tmp_HarleyKeyBinds_6
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPersistentOptions.FStoredKeyMap>(Ptr + 12040); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 12040); }
    }
    /// <summary>
    /// StructProperty: Tmp_HarleyKeyBinds
    /// </summary>
    public unsafe BmSDK.BmGame.RPersistentOptions.FStoredKeyMap Tmp_HarleyKeyBinds_7
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPersistentOptions.FStoredKeyMap>(Ptr + 12080); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 12080); }
    }
    /// <summary>
    /// StructProperty: Tmp_HarleyKeyBinds
    /// </summary>
    public unsafe BmSDK.BmGame.RPersistentOptions.FStoredKeyMap Tmp_HarleyKeyBinds_8
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPersistentOptions.FStoredKeyMap>(Ptr + 12120); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 12120); }
    }
    /// <summary>
    /// StructProperty: Tmp_HarleyKeyBinds
    /// </summary>
    public unsafe BmSDK.BmGame.RPersistentOptions.FStoredKeyMap Tmp_HarleyKeyBinds_9
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPersistentOptions.FStoredKeyMap>(Ptr + 12160); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 12160); }
    }
    /// <summary>
    /// StructProperty: Tmp_HarleyKeyBinds
    /// </summary>
    public unsafe BmSDK.BmGame.RPersistentOptions.FStoredKeyMap Tmp_HarleyKeyBinds_10
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPersistentOptions.FStoredKeyMap>(Ptr + 12200); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 12200); }
    }
    /// <summary>
    /// StructProperty: Tmp_HarleyKeyBinds
    /// </summary>
    public unsafe BmSDK.BmGame.RPersistentOptions.FStoredKeyMap Tmp_HarleyKeyBinds_11
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPersistentOptions.FStoredKeyMap>(Ptr + 12240); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 12240); }
    }
    /// <summary>
    /// StructProperty: Tmp_HarleyKeyBinds
    /// </summary>
    public unsafe BmSDK.BmGame.RPersistentOptions.FStoredKeyMap Tmp_HarleyKeyBinds_12
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPersistentOptions.FStoredKeyMap>(Ptr + 12280); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 12280); }
    }
    /// <summary>
    /// StructProperty: Tmp_HarleyKeyBinds
    /// </summary>
    public unsafe BmSDK.BmGame.RPersistentOptions.FStoredKeyMap Tmp_HarleyKeyBinds_13
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPersistentOptions.FStoredKeyMap>(Ptr + 12320); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 12320); }
    }
    /// <summary>
    /// StructProperty: Tmp_HarleyKeyBinds
    /// </summary>
    public unsafe BmSDK.BmGame.RPersistentOptions.FStoredKeyMap Tmp_HarleyKeyBinds_14
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPersistentOptions.FStoredKeyMap>(Ptr + 12360); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 12360); }
    }
    /// <summary>
    /// StructProperty: Tmp_HarleyKeyBinds
    /// </summary>
    public unsafe BmSDK.BmGame.RPersistentOptions.FStoredKeyMap Tmp_HarleyKeyBinds_15
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPersistentOptions.FStoredKeyMap>(Ptr + 12400); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 12400); }
    }
    /// <summary>
    /// StructProperty: Tmp_HarleyKeyBinds
    /// </summary>
    public unsafe BmSDK.BmGame.RPersistentOptions.FStoredKeyMap Tmp_HarleyKeyBinds_16
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPersistentOptions.FStoredKeyMap>(Ptr + 12440); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 12440); }
    }
    /// <summary>
    /// StructProperty: Tmp_HarleyKeyBinds
    /// </summary>
    public unsafe BmSDK.BmGame.RPersistentOptions.FStoredKeyMap Tmp_HarleyKeyBinds_17
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPersistentOptions.FStoredKeyMap>(Ptr + 12480); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 12480); }
    }
    /// <summary>
    /// StructProperty: Tmp_HarleyKeyBinds
    /// </summary>
    public unsafe BmSDK.BmGame.RPersistentOptions.FStoredKeyMap Tmp_HarleyKeyBinds_18
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPersistentOptions.FStoredKeyMap>(Ptr + 12520); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 12520); }
    }
    /// <summary>
    /// StructProperty: Tmp_HarleyKeyBinds
    /// </summary>
    public unsafe BmSDK.BmGame.RPersistentOptions.FStoredKeyMap Tmp_HarleyKeyBinds_19
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPersistentOptions.FStoredKeyMap>(Ptr + 12560); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 12560); }
    }
    /// <summary>
    /// StructProperty: Tmp_HarleyKeyBinds
    /// </summary>
    public unsafe BmSDK.BmGame.RPersistentOptions.FStoredKeyMap Tmp_HarleyKeyBinds_20
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPersistentOptions.FStoredKeyMap>(Ptr + 12600); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 12600); }
    }
    /// <summary>
    /// StructProperty: Tmp_HarleyKeyBinds
    /// </summary>
    public unsafe BmSDK.BmGame.RPersistentOptions.FStoredKeyMap Tmp_HarleyKeyBinds_21
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPersistentOptions.FStoredKeyMap>(Ptr + 12640); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 12640); }
    }
    /// <summary>
    /// StructProperty: Tmp_HarleyKeyBinds
    /// </summary>
    public unsafe BmSDK.BmGame.RPersistentOptions.FStoredKeyMap Tmp_HarleyKeyBinds_22
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPersistentOptions.FStoredKeyMap>(Ptr + 12680); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 12680); }
    }
    /// <summary>
    /// StructProperty: Tmp_HarleyKeyBinds
    /// </summary>
    public unsafe BmSDK.BmGame.RPersistentOptions.FStoredKeyMap Tmp_HarleyKeyBinds_23
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPersistentOptions.FStoredKeyMap>(Ptr + 12720); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 12720); }
    }
    /// <summary>
    /// StructProperty: Tmp_HarleyKeyBinds
    /// </summary>
    public unsafe BmSDK.BmGame.RPersistentOptions.FStoredKeyMap Tmp_HarleyKeyBinds_24
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPersistentOptions.FStoredKeyMap>(Ptr + 12760); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 12760); }
    }
    /// <summary>
    /// StructProperty: Tmp_HarleyKeyBinds
    /// </summary>
    public unsafe BmSDK.BmGame.RPersistentOptions.FStoredKeyMap Tmp_HarleyKeyBinds_25
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPersistentOptions.FStoredKeyMap>(Ptr + 12800); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 12800); }
    }
    /// <summary>
    /// StructProperty: Tmp_HarleyKeyBinds
    /// </summary>
    public unsafe BmSDK.BmGame.RPersistentOptions.FStoredKeyMap Tmp_HarleyKeyBinds_26
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPersistentOptions.FStoredKeyMap>(Ptr + 12840); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 12840); }
    }
    /// <summary>
    /// StructProperty: Tmp_HarleyKeyBinds
    /// </summary>
    public unsafe BmSDK.BmGame.RPersistentOptions.FStoredKeyMap Tmp_HarleyKeyBinds_27
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPersistentOptions.FStoredKeyMap>(Ptr + 12880); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 12880); }
    }

    /// <summary>
    /// IntProperty: BatgirlCount
    /// </summary>
    public unsafe int BatgirlCount
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 12920); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 12920); }
    }

    /// <summary>
    /// IntProperty: RedHoodCount
    /// </summary>
    public unsafe int RedHoodCount
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 12924); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 12924); }
    }

    /// <summary>
    /// IntProperty: HarleyCount
    /// </summary>
    public unsafe int HarleyCount
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 12928); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 12928); }
    }

    /// <summary>
    /// FloatProperty: MouseSensitivity
    /// </summary>
    public unsafe float MouseSensitivity
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 12932); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 12932); }
    }

    /// <summary>
    /// FloatProperty: MinMouseSensitivity
    /// </summary>
    public unsafe float MinMouseSensitivity
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 12936); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 12936); }
    }

    /// <summary>
    /// FloatProperty: MaxMouseSensitivity
    /// </summary>
    public unsafe float MaxMouseSensitivity
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 12940); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 12940); }
    }

    /// <summary>
    /// FloatProperty: Tmp_MouseSensitivity
    /// </summary>
    public unsafe float Tmp_MouseSensitivity
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 12944); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 12944); }
    }

    /// <summary>
    /// IntProperty: MouseSmoothing
    /// </summary>
    public unsafe int MouseSmoothing
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 12948); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 12948); }
    }

    /// <summary>
    /// IntProperty: Tmp_MouseSmoothing
    /// </summary>
    public unsafe int Tmp_MouseSmoothing
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 12952); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 12952); }
    }

    /// <summary>
    /// IntProperty: BatmobilesAlwaysAvailable
    /// </summary>
    public unsafe int BatmobilesAlwaysAvailable
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 12956); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 12956); }
    }

    /// <summary>
    /// ByteProperty: BluntTraumaTakedownsPerformed
    /// </summary>
    public unsafe byte BluntTraumaTakedownsPerformed_0
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 12960); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 12960); }
    }
    /// <summary>
    /// ByteProperty: BluntTraumaTakedownsPerformed
    /// </summary>
    public unsafe byte BluntTraumaTakedownsPerformed_1
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 12961); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 12961); }
    }
    /// <summary>
    /// ByteProperty: BluntTraumaTakedownsPerformed
    /// </summary>
    public unsafe byte BluntTraumaTakedownsPerformed_2
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 12962); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 12962); }
    }
    /// <summary>
    /// ByteProperty: BluntTraumaTakedownsPerformed
    /// </summary>
    public unsafe byte BluntTraumaTakedownsPerformed_3
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 12963); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 12963); }
    }
    /// <summary>
    /// ByteProperty: BluntTraumaTakedownsPerformed
    /// </summary>
    public unsafe byte BluntTraumaTakedownsPerformed_4
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 12964); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 12964); }
    }
    /// <summary>
    /// ByteProperty: BluntTraumaTakedownsPerformed
    /// </summary>
    public unsafe byte BluntTraumaTakedownsPerformed_5
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 12965); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 12965); }
    }
    /// <summary>
    /// ByteProperty: BluntTraumaTakedownsPerformed
    /// </summary>
    public unsafe byte BluntTraumaTakedownsPerformed_6
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 12966); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 12966); }
    }
    /// <summary>
    /// ByteProperty: BluntTraumaTakedownsPerformed
    /// </summary>
    public unsafe byte BluntTraumaTakedownsPerformed_7
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 12967); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 12967); }
    }
    /// <summary>
    /// ByteProperty: BluntTraumaTakedownsPerformed
    /// </summary>
    public unsafe byte BluntTraumaTakedownsPerformed_8
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 12968); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 12968); }
    }
    /// <summary>
    /// ByteProperty: BluntTraumaTakedownsPerformed
    /// </summary>
    public unsafe byte BluntTraumaTakedownsPerformed_9
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 12969); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 12969); }
    }
    /// <summary>
    /// ByteProperty: BluntTraumaTakedownsPerformed
    /// </summary>
    public unsafe byte BluntTraumaTakedownsPerformed_10
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 12970); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 12970); }
    }
    /// <summary>
    /// ByteProperty: BluntTraumaTakedownsPerformed
    /// </summary>
    public unsafe byte BluntTraumaTakedownsPerformed_11
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 12971); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 12971); }
    }
    /// <summary>
    /// ByteProperty: BluntTraumaTakedownsPerformed
    /// </summary>
    public unsafe byte BluntTraumaTakedownsPerformed_12
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 12972); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 12972); }
    }
    /// <summary>
    /// ByteProperty: BluntTraumaTakedownsPerformed
    /// </summary>
    public unsafe byte BluntTraumaTakedownsPerformed_13
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 12973); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 12973); }
    }
    /// <summary>
    /// ByteProperty: BluntTraumaTakedownsPerformed
    /// </summary>
    public unsafe byte BluntTraumaTakedownsPerformed_14
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 12974); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 12974); }
    }

    /// <summary>
    /// IntProperty: PerformedFiftyTakedownsInEndlessKnightAsBatman
    /// </summary>
    public unsafe int PerformedFiftyTakedownsInEndlessKnightAsBatman
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 12976); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 12976); }
    }

    /// <summary>
    /// IntProperty: PerformedFiftyTakedownsInEndlessKnightAsCatwoman
    /// </summary>
    public unsafe int PerformedFiftyTakedownsInEndlessKnightAsCatwoman
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 12980); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 12980); }
    }

    /// <summary>
    /// IntProperty: PerformedFiftyTakedownsInEndlessKnightAsAzrael
    /// </summary>
    public unsafe int PerformedFiftyTakedownsInEndlessKnightAsAzrael
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 12984); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 12984); }
    }

    /// <summary>
    /// IntProperty: CompletedCrimeAlleyWithoutTakingDamageAsBatman
    /// </summary>
    public unsafe int CompletedCrimeAlleyWithoutTakingDamageAsBatman
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 12988); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 12988); }
    }

    /// <summary>
    /// IntProperty: CompletedCrimeAlleyWithoutTakingDamageAsRobin
    /// </summary>
    public unsafe int CompletedCrimeAlleyWithoutTakingDamageAsRobin
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 12992); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 12992); }
    }

    /// <summary>
    /// IntProperty: CompletedCrimeAlleyWithoutTakingDamageAsNightwing
    /// </summary>
    public unsafe int CompletedCrimeAlleyWithoutTakingDamageAsNightwing
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 12996); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 12996); }
    }

    /// <summary>
    /// IntProperty: CompletedMonarchTheatreWithPerfectFreeflowAsBatman
    /// </summary>
    public unsafe int CompletedMonarchTheatreWithPerfectFreeflowAsBatman
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 13000); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 13000); }
    }

    /// <summary>
    /// IntProperty: CompletedMonarchTheatreWithPerfectFreeflowAsRobin
    /// </summary>
    public unsafe int CompletedMonarchTheatreWithPerfectFreeflowAsRobin
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 13004); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 13004); }
    }

    /// <summary>
    /// IntProperty: CompletedMonarchTheatreWithPerfectFreeflowAsNightwing
    /// </summary>
    public unsafe int CompletedMonarchTheatreWithPerfectFreeflowAsNightwing
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 13008); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 13008); }
    }

    /// <summary>
    /// IntProperty: CompletedMonarchTheatreWithPerfectFreeflowAsCatwoman
    /// </summary>
    public unsafe int CompletedMonarchTheatreWithPerfectFreeflowAsCatwoman
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 13012); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 13012); }
    }

    /// <summary>
    /// IntProperty: CompletedBatcaveWithBeatdownsAsBatman
    /// </summary>
    public unsafe int CompletedBatcaveWithBeatdownsAsBatman
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 13016); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 13016); }
    }

    /// <summary>
    /// IntProperty: CompletedBatcaveWithBeatdownsAsNightwing
    /// </summary>
    public unsafe int CompletedBatcaveWithBeatdownsAsNightwing
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 13020); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 13020); }
    }

    /// <summary>
    /// IntProperty: CompletedSilentKnightWithKnockoutSmashesAsBatman
    /// </summary>
    public unsafe int CompletedSilentKnightWithKnockoutSmashesAsBatman
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 13024); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 13024); }
    }

    /// <summary>
    /// IntProperty: CompletedSilentKnightWithKnockoutSmashesAsRobin
    /// </summary>
    public unsafe int CompletedSilentKnightWithKnockoutSmashesAsRobin
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 13028); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 13028); }
    }

    /// <summary>
    /// Struct: FActivePlayerSkin
    /// </summary>
    [StructLayout(LayoutKind.Explicit)]
    public partial record struct FActivePlayerSkin
    {
        /// <summary>
        /// ByteProperty: Version
        /// </summary>
        public unsafe byte Version
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// StrProperty: Id
        /// </summary>
        public unsafe BmSDK.FString Id
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 4); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4); }; }
        }

        /// <summary>
        /// StrProperty: Skin
        /// </summary>
        public unsafe BmSDK.FString Skin
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 20); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 20); }; }
        }
    }

    /// <summary>
    /// Enum: ActivePlayerSkin_Version
    /// </summary>
    public enum ActivePlayerSkin_Version
    {
        ActivePlayerSkin_Version_Initial = 0,
        ActivePlayerSkin_Version_MAX = 1,
    }

    /// <summary>
    /// Enum: MobileUnlocks
    /// </summary>
    public enum MobileUnlocks
    {
        MobileUnlocks_Scarecrow = 0,
        MobileUnlocks_Catwoman = 1,
        MobileUnlocks_Firecrews = 2,
        MobileUnlocks_Watchtowers = 3,
        MobileUnlocks_IslandDriving = 4,
        MobileUnlocks_Explosives = 5,
        MobileUnlocks_Banks = 6,
        MobileUnlocks_RiddlerChallenges = 7,
        MobileUnlocks_PenguinCaches = 8,
        MobileUnlocks_Supervillains = 9,
        MobileUnlocks_Count = 10,
        MobileUnlocks_MAX = 11,
    }

    /// <summary>
    /// Struct: FUnlockedChallenge
    /// </summary>
    [StructLayout(LayoutKind.Explicit)]
    public partial record struct FUnlockedChallenge
    {
        /// <summary>
        /// ByteProperty: Version
        /// </summary>
        public unsafe byte Version
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// IntProperty: Id
        /// </summary>
        public unsafe int Id
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4); }; }
        }

        /// <summary>
        /// ByteProperty: Status
        /// </summary>
        public unsafe byte Status
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 8); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8); }; }
        }

        /// <summary>
        /// ByteProperty: Requirements
        /// </summary>
        public unsafe byte Requirements
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 9); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 9); }; }
        }

        /// <summary>
        /// ArrayProperty: DataPerCharacter
        /// </summary>
        public unsafe BmSDK.TArray<BmSDK.BmGame.RPersistentOptions.FUnlockedChallengePerCharacter> DataPerCharacter
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RPersistentOptions.FUnlockedChallengePerCharacter>>(Ptr + 12); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 12); }; }
        }

        /// <summary>
        /// IntProperty: ActiveCharacterId
        /// </summary>
        public unsafe int ActiveCharacterId
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 28); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 28); }; }
        }

        /// <summary>
        /// IntProperty: DefaultCharacterId
        /// </summary>
        public unsafe int DefaultCharacterId
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 32); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 32); }; }
        }
    }

    /// <summary>
    /// Enum: ChallengePerCharacter_Version
    /// </summary>
    public enum ChallengePerCharacter_Version
    {
        ChallengePerCharacter_Version_Initial = 0,
        ChallengePerCharacter_Version_Requirements = 1,
        ChallengePerCharacter_Version_Active = 2,
        ChallengePerCharacter_Version_Default = 3,
        ChallengePerCharacter_Version_MAX = 4,
    }

    /// <summary>
    /// Struct: FUnlockedChallengePerCharacter
    /// </summary>
    [StructLayout(LayoutKind.Explicit)]
    public partial record struct FUnlockedChallengePerCharacter
    {
        /// <summary>
        /// ByteProperty: Version
        /// </summary>
        public unsafe byte Version
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// IntProperty: LocalRating
        /// </summary>
        public unsafe int LocalRating
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4); }; }
        }

        /// <summary>
        /// IntProperty: Score
        /// </summary>
        public unsafe int Score
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8); }; }
        }

        /// <summary>
        /// IntProperty: CustomLocalRating
        /// </summary>
        public unsafe int CustomLocalRating
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 12); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 12); }; }
        }

        /// <summary>
        /// IntProperty: CustomScore
        /// </summary>
        public unsafe int CustomScore
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 16); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 16); }; }
        }

        /// <summary>
        /// ByteProperty: Medals
        /// </summary>
        public unsafe byte Medals
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 20); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 20); }; }
        }

        /// <summary>
        /// ByteProperty: CustomMedals
        /// </summary>
        public unsafe byte CustomMedals
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 21); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 21); }; }
        }

        /// <summary>
        /// ByteProperty: CharacterId
        /// </summary>
        public unsafe byte CharacterId
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 22); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 22); }; }
        }

        /// <summary>
        /// IntProperty: RivalPoints
        /// </summary>
        public unsafe int RivalPoints
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 24); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 24); }; }
        }
    }

    /// <summary>
    /// Enum: ChallengePerCharacter_Data_Version
    /// </summary>
    public enum ChallengePerCharacter_Data_Version
    {
        ChallengePerCharacter_Data_Version_Initial = 0,
        ChallengePerCharacter_Data_Version_MAX = 1,
    }

    /// <summary>
    /// Enum: EPlayerOptions
    /// </summary>
    public enum EPlayerOptions
    {
        EPlayerOption_InvertMouse = 0,
        EPlayerOption_InvertRotation = 1,
        EPlayerOption_InvertGlide = 2,
        EPlayerOption_InvertBatarang = 3,
        EPlayerOption_Autoflow = 4,
        EPlayerOption_CameraAssist = 5,
        EPlayerOption_Vibration = 6,
        EPlayerOption_SouthPaw = 7,
        EPlayerOption_SixAxis = 8,
        EPlayerOption_ControlType = 9,
        EPlayerOption_BattleModeToggle = 10,
        EPlayerOption_PredatorAwareness = 11,
        EPlayerOption_MAX = 12,
    }

    /// <summary>
    /// Enum: EGeneralOptions
    /// </summary>
    public enum EGeneralOptions
    {
        ECommonOption_Difficulty = 0,
        ECommonOption_PCControlsPage = 1,
        ECommonOption_Subtitles = 2,
        ECommonOption_Gamma = 3,
        ECommonOption_VolumeSFX = 4,
        ECommonOption_VolumeDialogue = 5,
        ECommonOption_VolumeMusic = 6,
        ECommonOption_Render3D = 7,
        ECommonOption_Hints = 8,
        ECommonOption_EyeInversion3D = 9,
        ECommonOption_Intensity3D = 10,
        ECommonOption_Tutorial = 11,
        ECommonOption_CombatEasyMode = 12,
        ECommonOption_PadSpeaker = 13,
        ECommonOption_SpeechRec = 14,
        ECommonOption_AudioDynRange = 15,
        ECommonOption_EnglishVoiceCast = 16,
        ECommonOption_MAX = 17,
    }

    /// <summary>
    /// Struct: FDeathMovieRecord
    /// </summary>
    [StructLayout(LayoutKind.Explicit)]
    public partial record struct FDeathMovieRecord
    {
        /// <summary>
        /// ByteProperty: Version
        /// </summary>
        public unsafe byte Version
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// StrProperty: DeathMovieName
        /// </summary>
        public unsafe BmSDK.FString DeathMovieName
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 4); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4); }; }
        }

        /// <summary>
        /// ArrayProperty: PlayCounts
        /// </summary>
        public unsafe BmSDK.TArray<byte> PlayCounts
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<byte>>(Ptr + 20); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 20); }; }
        }
    }

    /// <summary>
    /// Enum: DeathMovieRecord_Version
    /// </summary>
    public enum DeathMovieRecord_Version
    {
        DeathMovieRecord_Version_Initial = 0,
        DeathMovieRecord_Version_FirstTest = 1,
        DeathMovieRecord_Version_MAX = 2,
    }

    /// <summary>
    /// Enum: HelpTextLevel
    /// </summary>
    public enum HelpTextLevel
    {
        HelpText_None = 0,
        HelpText_Some = 1,
        HelpText_Full = 2,
        HelpText_MAX = 3,
    }

    /// <summary>
    /// Enum: DifficultyLevels
    /// </summary>
    public enum DifficultyLevels
    {
        Difficulty_Easy = 0,
        Difficulty_Normal = 1,
        Difficulty_Hard = 2,
        Difficulty_Knightmare = 3,
        Difficulty_MAX = 4,
    }

    /// <summary>
    /// Enum: DDAIntType
    /// </summary>
    public enum DDAIntType
    {
        DDAI_DeathsInRoom = 0,
        DDAI_MAX = 1,
    }

    /// <summary>
    /// Enum: POVersion
    /// </summary>
    public enum POVersion
    {
        POVer_Initial = 0,
        POVer_ChallengeData = 1,
        POVer_GalleryUnlocks = 2,
        POVer_LocalChallenges = 3,
        POVer_CatwomanEpisodes = 4,
        POVer_AddedNewGamePlusFlag = 5,
        POVer_MovedStuff1 = 6,
        POVer_RemovedCatwomanFlag = 7,
        POVer_AddedWBIDPrompt = 8,
        POVer_FreezeUnlockStatus = 9,
        POVer_StartedWithoutCW = 10,
        POVer_WBID_Bonus = 11,
        POVer_ChallengeUpdate1 = 12,
        POVer_LeaderboardCache = 13,
        POVer_StatsNew = 14,
        POVer_WBID_GUID = 15,
        POVer_RemovingOldBm1Bm2 = 16,
        POVer_AddedGenericTypeArrays = 17,
        POVer_CombatEasyMode = 18,
        POVer_RemovedCombatEasyMode = 19,
        POVer_LocalChallenges2 = 20,
        POVer_AddedSkinsString = 21,
        POVer_RemovedLeaderboardCache = 22,
        POVer_BatmobileDDA = 23,
        POVer_RemoveChallengeCharacterData = 24,
        POVer_BumpUpToFixCorruptSaves = 25,
        POVer_AddedSaveGameUserInfo = 26,
        POVer_PCKeyBinds = 27,
        POVer_PCKeyBindsPursuitBattle = 28,
        POVer_PCKeyBindsSerializeBattle = 29,
        POVer_PCKeyBindsWithModifierKeys = 30,
        POVer_OnceEverDialogue = 31,
        POVer_BeatdownsFromPickup = 32,
        POVer_DialogueLinePlayCount = 33,
        POVer_OnceEverDialogueRemoved = 34,
        POVer_NewPlayerSkinsData = 35,
        POVer_TimeStamp = 36,
        POVer_TotalTimePlayed = 37,
        POVer_PredatorAwareness = 38,
        POVer_PredatorAwarenessMove = 39,
        POVer_DeathMoviePlayCounts = 40,
        POVer_BattleModeOptionAvailable = 41,
        POVer_MostWantedRival = 42,
        POVer_DiffStr = 43,
        POVer_WBPlayRewardsMoved = 44,
        POVer_UpgradePointsSave = 45,
        POVer_UpgradePointsSave2 = 46,
        POVer_Flags = 47,
        POVer_RemoveDialogueLinePlayCount = 48,
        POVer_UpgradePointsSave3 = 49,
        POVer_UpgradePointsSave4 = 50,
        POVer_MoveUpgradesToPersistentShared = 51,
        POVer_PCKeyBindsDLC = 52,
        POVer_PCKeyBindsDLCEdits = 53,
        POVer_PCConfigDLCSpecialCombosRemoved = 54,
        POVer_PCMouseOptions = 55,
        POVer_NewBatmobilesData = 56,
        POVer_BluntTraumaAchievementWithARChallengeSupport = 57,
        POVer_PCPhotoMode = 58,
        POVer_PCDLCPhotoMode = 59,
        POVer_ChallengePack6Achievements = 60,
        POVer_MAX = 61,
    }
}
