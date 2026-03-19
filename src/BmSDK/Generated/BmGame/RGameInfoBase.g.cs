#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RGameInfoBase<br/>
/// (size = 0)
/// (flags = 0)
/// </summary>
public partial class RGameInfoBase : BmSDK.Engine.GameInfo, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RGameInfoBase", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RGameInfoBase() { }

    /// <summary>
    /// Constructs a new RGameInfoBase
    /// </summary>
    public RGameInfoBase(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RGameInfoBase Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RGameInfoBase(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="Engine.Actor.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RGameInfoBase>
        => ((Engine.Actor)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="Engine.Actor.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RGameInfoBase>, new()
        => (TComponent)((Engine.Actor)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="Engine.Actor.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RGameInfoBase>
        => ((Engine.Actor)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="Engine.Actor.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RGameInfoBase>
        => ((Engine.Actor)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="Engine.Actor.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RGameInfoBase>
        => (TComponent)((Engine.Actor)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="Engine.Actor.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RGameInfoBase>
        => ((Engine.Actor)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="Engine.Actor.DetachScriptComponent(Type)"/>
    public void DetachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RGameInfoBase>
        => ((Engine.Actor)this).DetachScriptComponent(typeof(TComponent));

    /// <summary>
    /// FloatProperty: DesiredGameSpeed
    /// </summary>
    public unsafe float DesiredGameSpeed
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1532); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1532); }
    }

    /// <summary>
    /// FloatProperty: GameSpeedTransitionTime
    /// </summary>
    public unsafe float GameSpeedTransitionTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1536); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1536); }
    }

    /// <summary>
    /// ObjectProperty: SloMoAudioParam
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT SloMoAudioParam
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 1540); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1540); }
    }

    /// <summary>
    /// ObjectProperty: CurrentLoopingAudioEvent
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT CurrentLoopingAudioEvent
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 1548); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1548); }
    }

    /// <summary>
    /// ObjectProperty: PersistentData
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT PersistentData
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 1556); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1556); }
    }

    /// <summary>
    /// ObjectProperty: PersistentShared
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT PersistentShared
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 1564); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1564); }
    }

    /// <summary>
    /// ObjectProperty: ChallengeManager
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT ChallengeManager
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 1572); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1572); }
    }

    /// <summary>
    /// ObjectProperty: SideStoryManager
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT SideStoryManager
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 1580); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1580); }
    }

    /// <summary>
    /// ObjectProperty: SlowMoSFX
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT SlowMoSFX
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 1588); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1588); }
    }

    /// <summary>
    /// BoolProperty: SloMoAudioParamMaxSet
    /// </summary>
    public unsafe bool SloMoAudioParamMaxSet
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1596) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1596); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1596); }
    }

    /// <summary>
    /// BoolProperty: SloMoAudioParamMinSet
    /// </summary>
    public unsafe bool SloMoAudioParamMinSet
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1596) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1596); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1596); }
    }

    /// <summary>
    /// BoolProperty: bLockGameSpeed
    /// </summary>
    public unsafe bool bLockGameSpeed
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1596) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1596); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1596); }
    }

    /// <summary>
    /// BoolProperty: SlowMoSFXPlaying
    /// </summary>
    public unsafe bool SlowMoSFXPlaying
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1596) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1596); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1596); }
    }

    /// <summary>
    /// BoolProperty: EnableErrorThoughtDetails
    /// </summary>
    public unsafe bool EnableErrorThoughtDetails
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1596) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1596); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1596); }
    }

    /// <summary>
    /// FloatProperty: DebugGameSpeed
    /// </summary>
    public unsafe float DebugGameSpeed
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1600); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1600); }
    }

    /// <summary>
    /// ArrayProperty: PersistentMapNames
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.FString>>>>>> PersistentMapNames
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.FString>>>>>>>(Ptr + 1604); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1604); }
    }

    /// <summary>
    /// ArrayProperty: LOD2Levels
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.FString>>>>> LOD2Levels
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.FString>>>>>>(Ptr + 1620); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1620); }
    }

    /// <summary>
    /// MapProperty: AlwaysLoadedMaps
    /// </summary>
    public unsafe BmSDK.TMap<object, object> /* TODO */ AlwaysLoadedMaps
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TMap<object, object> /* TODO */>(Ptr + 1636); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1636); }
    }

    /// <summary>
    /// MapProperty: LevelSubMaps
    /// </summary>
    public unsafe BmSDK.TMap<object, object> /* TODO */ LevelSubMaps
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TMap<object, object> /* TODO */>(Ptr + 1708); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1708); }
    }

    /// <summary>
    /// ArrayProperty: CatwomanLevelTagsToNotLoad
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.FString>>>> CatwomanLevelTagsToNotLoad
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.FString>>>>>(Ptr + 1780); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1780); }
    }

    /// <summary>
    /// ArrayProperty: PMapsWithLOD2s
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.FString>>> PMapsWithLOD2s
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.FString>>>>(Ptr + 1796); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1796); }
    }

    /// <summary>
    /// ArrayProperty: DisablableSideStories
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.TArray<BmSDK.FString>> DisablableSideStories
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.TArray<BmSDK.FString>>>(Ptr + 1812); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1812); }
    }

    /// <summary>
    /// ArrayProperty: DisablableSideStoriesAsChar
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.FString> DisablableSideStoriesAsChar
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.FString>>(Ptr + 1828); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1828); }
    }

    /// <summary>
    /// StrProperty: CurrentFactToSetDuringSlowMo
    /// </summary>
    public unsafe BmSDK.FString CurrentFactToSetDuringSlowMo
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 1844); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1844); }
    }

    /// <summary>
    /// IntProperty: CurrentSpeedChangeId
    /// </summary>
    public unsafe int CurrentSpeedChangeId
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1860); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1860); }
    }

    /// <summary>
    /// ArrayProperty: RegisteredThoughtActors
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.Engine.GameInfo.CauseEventCommand>>> RegisteredThoughtActors
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.Engine.GameInfo.CauseEventCommand>>>>(Ptr + 1864); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1864); }
    }

    /// <summary>
    /// ArrayProperty: PendingPersistentThoughts
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.TArray<BmSDK.Engine.GameInfo.CauseEventCommand>> PendingPersistentThoughts
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.TArray<BmSDK.Engine.GameInfo.CauseEventCommand>>>(Ptr + 1880); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1880); }
    }

    /// <summary>
    /// ArrayProperty: DestructiblePropsToStartTicking
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.Engine.GameInfo.CauseEventCommand> DestructiblePropsToStartTicking
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.GameInfo.CauseEventCommand>>(Ptr + 1896); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1896); }
    }
}
