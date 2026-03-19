#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RSeqAct_ModifyStreaming<br/>
/// (size = 0)
/// (flags = 0)
/// </summary>
public partial class RSeqAct_ModifyStreaming : BmSDK.Engine.SeqAct_Latent, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RSeqAct_ModifyStreaming", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RSeqAct_ModifyStreaming() { }

    /// <summary>
    /// Constructs a new RSeqAct_ModifyStreaming
    /// </summary>
    public RSeqAct_ModifyStreaming(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RSeqAct_ModifyStreaming Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RSeqAct_ModifyStreaming(nint ptr) : base(ptr) { }

    /// <summary>
    /// StructProperty: SaveGameDescription
    /// </summary>
    public unsafe BmSDK.BmGame.RSeqAct_ModifyStreaming.LevelsLoadedWhileLocked SaveGameDescription
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSeqAct_ModifyStreaming.LevelsLoadedWhileLocked>(Ptr + 376); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 376); }
    }

    /// <summary>
    /// BoolProperty: bForceSaveInBatmobile
    /// </summary>
    public unsafe bool bForceSaveInBatmobile
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 412) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 412); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 412); }
    }

    /// <summary>
    /// BoolProperty: bForceSaveBatmobileFakeRemoteDrive
    /// </summary>
    public unsafe bool bForceSaveBatmobileFakeRemoteDrive
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 412) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 412); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 412); }
    }

    /// <summary>
    /// BoolProperty: bMemoryOnlySave
    /// </summary>
    public unsafe bool bMemoryOnlySave
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 412) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 412); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 412); }
    }

    /// <summary>
    /// BoolProperty: bWhenLockingDontUnloadCurrentLevels
    /// </summary>
    public unsafe bool bWhenLockingDontUnloadCurrentLevels
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 412) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 412); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 412); }
    }

    /// <summary>
    /// BoolProperty: bOnlyReloadConditionalsOnCurrentLevel
    /// </summary>
    public unsafe bool bOnlyReloadConditionalsOnCurrentLevel
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 412) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 412); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 412); }
    }

    /// <summary>
    /// BoolProperty: bKeptCurrentLevelLoaded
    /// </summary>
    public unsafe bool bKeptCurrentLevelLoaded
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 412) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 412); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 412); }
    }

    /// <summary>
    /// BoolProperty: bLockedStreaming
    /// </summary>
    public unsafe bool bLockedStreaming
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 412) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 412); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 412); }
    }

    /// <summary>
    /// BoolProperty: bRefreshingConditional
    /// </summary>
    public unsafe bool bRefreshingConditional
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 412) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 412); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 412); }
    }

    /// <summary>
    /// BoolProperty: bLockingStreaming
    /// </summary>
    public unsafe bool bLockingStreaming
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 412) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 412); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 412); }
    }

    /// <summary>
    /// BoolProperty: bIsFlushingStreaming
    /// </summary>
    public unsafe bool bIsFlushingStreaming
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 412) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 412); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 412); }
    }

    /// <summary>
    /// BoolProperty: bPreparingConditional
    /// </summary>
    public unsafe bool bPreparingConditional
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 412) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 412); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 412); }
    }

    /// <summary>
    /// BoolProperty: bReloadingConditional
    /// </summary>
    public unsafe bool bReloadingConditional
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 412) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 412); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 412); }
    }

    /// <summary>
    /// BoolProperty: bMakeLODsVisibleImmediately
    /// </summary>
    public unsafe bool bMakeLODsVisibleImmediately
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 412) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 412); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 412); }
    }

    /// <summary>
    /// BoolProperty: bAllowSaveDuringChase
    /// </summary>
    public unsafe bool bAllowSaveDuringChase
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 412) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 412); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 412); }
    }

    /// <summary>
    /// ArrayProperty: LevelsLoadedWhileLocked
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.FString>>>>>>>> LevelsLoadedWhileLocked
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.FString>>>>>>>>>(Ptr + 416); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 416); }
    }

    /// <summary>
    /// ArrayProperty: LevelLODsLoadedWhileLocked
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.FString>>>>>>> LevelLODsLoadedWhileLocked
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.FString>>>>>>>>(Ptr + 432); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 432); }
    }

    /// <summary>
    /// NameProperty: CurrentLevelWhileLocked
    /// </summary>
    public unsafe BmSDK.FName CurrentLevelWhileLocked
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 448); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 448); }
    }

    /// <summary>
    /// ByteProperty: GlobalDoorLockType
    /// </summary>
    public unsafe byte GlobalDoorLockType
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 456); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 456); }
    }

    /// <summary>
    /// ByteProperty: SideStoryToReload
    /// </summary>
    public unsafe byte SideStoryToReload
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 457); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 457); }
    }

    /// <summary>
    /// ByteProperty: PrepareSideStory
    /// </summary>
    public unsafe byte PrepareSideStory
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 458); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 458); }
    }

    /// <summary>
    /// ByteProperty: PrepareSubChapter
    /// </summary>
    public unsafe byte PrepareSubChapter
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 459); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 459); }
    }

    /// <summary>
    /// NameProperty: GlobalLockRoom
    /// </summary>
    public unsafe BmSDK.FName GlobalLockRoom
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 460); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 460); }
    }

    /// <summary>
    /// IntProperty: PrepareChapter
    /// </summary>
    public unsafe int PrepareChapter
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 468); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 468); }
    }

    /// <summary>
    /// NameProperty: CurrentLevelWhenLocked
    /// </summary>
    public unsafe BmSDK.FName CurrentLevelWhenLocked
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 472); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 472); }
    }

    /// <summary>
    /// ObjectProperty: CurrentLevelVolumeWhenLocked
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT CurrentLevelVolumeWhenLocked
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 480); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 480); }
    }
}
