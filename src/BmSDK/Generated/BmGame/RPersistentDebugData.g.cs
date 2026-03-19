#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RPersistentDebugData<br/>
/// (size = 0)
/// (flags = 0)
/// </summary>
public partial class RPersistentDebugData : BmSDK.Engine.PersistentDebugData, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RPersistentDebugData", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RPersistentDebugData() { }

    /// <summary>
    /// Constructs a new RPersistentDebugData
    /// </summary>
    public RPersistentDebugData(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RPersistentDebugData Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RPersistentDebugData(nint ptr) : base(ptr) { }

    /// <summary>
    /// BoolProperty: bDeathCountGodMode
    /// </summary>
    public unsafe bool bDeathCountGodMode
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 92) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 92); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 92); }
    }

    /// <summary>
    /// BoolProperty: bDisableDamagePostProcess
    /// </summary>
    public unsafe bool bDisableDamagePostProcess
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 92) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 92); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 92); }
    }

    /// <summary>
    /// BoolProperty: bDebugForceGarbageCollect
    /// </summary>
    public unsafe bool bDebugForceGarbageCollect
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 92) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 92); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 92); }
    }

    /// <summary>
    /// BoolProperty: Debug_CharacterAI_ShowThoughts
    /// </summary>
    public unsafe bool Debug_CharacterAI_ShowThoughts
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 92) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 92); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 92); }
    }

    /// <summary>
    /// BoolProperty: Debug_CharacterAI_ShowErrorThoughts
    /// </summary>
    public unsafe bool Debug_CharacterAI_ShowErrorThoughts
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 92) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 92); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 92); }
    }

    /// <summary>
    /// BoolProperty: Debug_AI_FearInfo
    /// </summary>
    public unsafe bool Debug_AI_FearInfo
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 92) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 92); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 92); }
    }

    /// <summary>
    /// BoolProperty: Debug_AI_SentryPlaceChance
    /// </summary>
    public unsafe bool Debug_AI_SentryPlaceChance
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 92) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 92); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 92); }
    }

    /// <summary>
    /// BoolProperty: Debug_AI_DialogueLocks
    /// </summary>
    public unsafe bool Debug_AI_DialogueLocks
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 92) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 92); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 92); }
    }

    /// <summary>
    /// BoolProperty: Debug_AI_AttackProgState
    /// </summary>
    public unsafe bool Debug_AI_AttackProgState
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 92) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 92); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 92); }
    }

    /// <summary>
    /// BoolProperty: Debug_AI_LevelScriptingInfo
    /// </summary>
    public unsafe bool Debug_AI_LevelScriptingInfo
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 92) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 92); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 92); }
    }

    /// <summary>
    /// BoolProperty: Debug_AI_LevelScriptingLogging
    /// </summary>
    public unsafe bool Debug_AI_LevelScriptingLogging
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 92) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 92); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 92); }
    }

    /// <summary>
    /// BoolProperty: Debug_AI_ShowDDA
    /// </summary>
    public unsafe bool Debug_AI_ShowDDA
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 92) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 92); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 92); }
    }

    /// <summary>
    /// BoolProperty: Debug_AI_IgnoreDDA
    /// </summary>
    public unsafe bool Debug_AI_IgnoreDDA
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 92) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 92); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 92); }
    }

    /// <summary>
    /// BoolProperty: Debug_AI_ShowStasisLevel
    /// </summary>
    public unsafe bool Debug_AI_ShowStasisLevel
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 92) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 92); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 92); }
    }

    /// <summary>
    /// BoolProperty: Debug_AI_StuckNavDetection
    /// </summary>
    public unsafe bool Debug_AI_StuckNavDetection
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 92) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 92); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 92); }
    }

    /// <summary>
    /// BoolProperty: Debug_AI_PerformInlineHandling
    /// </summary>
    public unsafe bool Debug_AI_PerformInlineHandling
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 92) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 92); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 92); }
    }

    /// <summary>
    /// BoolProperty: Debug_AI_RandomTeleport
    /// </summary>
    public unsafe bool Debug_AI_RandomTeleport
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 92) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 92); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 92); }
    }

    /// <summary>
    /// BoolProperty: Debug_AI_VertTimeSinceSeen
    /// </summary>
    public unsafe bool Debug_AI_VertTimeSinceSeen
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 92) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 92); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 92); }
    }

    /// <summary>
    /// BoolProperty: Debug_AI_ShowCanSeeVerts
    /// </summary>
    public unsafe bool Debug_AI_ShowCanSeeVerts
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 92) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 92); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 92); }
    }

    /// <summary>
    /// BoolProperty: Debug_AI_ShowCantSeeVerts
    /// </summary>
    public unsafe bool Debug_AI_ShowCantSeeVerts
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 92) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 92); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 92); }
    }

    /// <summary>
    /// BoolProperty: Debug_AI_ShowVertsVisibleFromPlayer
    /// </summary>
    public unsafe bool Debug_AI_ShowVertsVisibleFromPlayer
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 92) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 92); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 92); }
    }

    /// <summary>
    /// BoolProperty: Debug_AI_ShowNudgePropForces
    /// </summary>
    public unsafe bool Debug_AI_ShowNudgePropForces
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 92) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 92); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 92); }
    }

    /// <summary>
    /// BoolProperty: Debug_AI_DisableNavMeshObstacleQueueToggling
    /// </summary>
    public unsafe bool Debug_AI_DisableNavMeshObstacleQueueToggling
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 92) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 92); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 92); }
    }

    /// <summary>
    /// BoolProperty: Debug_AI_ShowRunAwayDebug
    /// </summary>
    public unsafe bool Debug_AI_ShowRunAwayDebug
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 92) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 92); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 92); }
    }

    /// <summary>
    /// BoolProperty: Debug_AI_FallingDebug
    /// </summary>
    public unsafe bool Debug_AI_FallingDebug
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 92) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 92); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 92); }
    }

    /// <summary>
    /// BoolProperty: Debug_AI_ZEP147037Logging
    /// </summary>
    public unsafe bool Debug_AI_ZEP147037Logging
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 92) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 92); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 92); }
    }

    /// <summary>
    /// BoolProperty: bReactionBehaviours
    /// </summary>
    public unsafe bool bReactionBehaviours
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 92) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 92); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 92); }
    }

    /// <summary>
    /// BoolProperty: bReactionBehavioursPlayer
    /// </summary>
    public unsafe bool bReactionBehavioursPlayer
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 92) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 92); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 92); }
    }

    /// <summary>
    /// BoolProperty: bEnableWonkyPolyTesting
    /// </summary>
    public unsafe bool bEnableWonkyPolyTesting
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 92) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 92); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 92); }
    }

    /// <summary>
    /// BoolProperty: bShowHistory
    /// </summary>
    public unsafe bool bShowHistory
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 92) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 92); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 92); }
    }

    /// <summary>
    /// BoolProperty: bShowHistory_General
    /// </summary>
    public unsafe bool bShowHistory_General
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 92) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 92); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 92); }
    }

    /// <summary>
    /// BoolProperty: bShowHistory_Behaviour
    /// </summary>
    public unsafe bool bShowHistory_Behaviour
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 92) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 92); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 92); }
    }

    /// <summary>
    /// BoolProperty: bShowHistory_BehaviourState
    /// </summary>
    public unsafe bool bShowHistory_BehaviourState
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 96) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 96); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 96); }
    }

    /// <summary>
    /// BoolProperty: bShowHistory_ActionQueue
    /// </summary>
    public unsafe bool bShowHistory_ActionQueue
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 96) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 96); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 96); }
    }

    /// <summary>
    /// BoolProperty: bShowHistory_Callstacks
    /// </summary>
    public unsafe bool bShowHistory_Callstacks
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 96) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 96); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 96); }
    }

    /// <summary>
    /// BoolProperty: bShowTimestamps
    /// </summary>
    public unsafe bool bShowTimestamps
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 96) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 96); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 96); }
    }

    /// <summary>
    /// BoolProperty: bShowFilteringMenu
    /// </summary>
    public unsafe bool bShowFilteringMenu
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 96) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 96); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 96); }
    }

    /// <summary>
    /// BoolProperty: bShowThoughtsPawn
    /// </summary>
    public unsafe bool bShowThoughtsPawn
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 96) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 96); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 96); }
    }

    /// <summary>
    /// BoolProperty: bShowThoughtsPawnState
    /// </summary>
    public unsafe bool bShowThoughtsPawnState
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 96) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 96); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 96); }
    }

    /// <summary>
    /// BoolProperty: bShowThoughtsPawnPooling
    /// </summary>
    public unsafe bool bShowThoughtsPawnPooling
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 96) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 96); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 96); }
    }

    /// <summary>
    /// BoolProperty: bShowThoughtsPawnStasis
    /// </summary>
    public unsafe bool bShowThoughtsPawnStasis
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 96) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 96); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 96); }
    }

    /// <summary>
    /// BoolProperty: bShowThoughtsPawnStasis_InStasis
    /// </summary>
    public unsafe bool bShowThoughtsPawnStasis_InStasis
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 96) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 96); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 96); }
    }

    /// <summary>
    /// BoolProperty: bShowThoughtsPawnStasis_NotInStasis
    /// </summary>
    public unsafe bool bShowThoughtsPawnStasis_NotInStasis
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 96) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 96); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 96); }
    }

    /// <summary>
    /// BoolProperty: bShowThoughtsPawnTimeSinceRender
    /// </summary>
    public unsafe bool bShowThoughtsPawnTimeSinceRender
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 96) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 96); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 96); }
    }

    /// <summary>
    /// BoolProperty: bShowThoughtsCharacterType
    /// </summary>
    public unsafe bool bShowThoughtsCharacterType
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 96) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 96); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 96); }
    }

    /// <summary>
    /// BoolProperty: bShowThoughtsCombatTargetting
    /// </summary>
    public unsafe bool bShowThoughtsCombatTargetting
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 96) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 96); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 96); }
    }

    /// <summary>
    /// BoolProperty: bShowThoughtsCombatReadiness
    /// </summary>
    public unsafe bool bShowThoughtsCombatReadiness
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 96) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 96); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 96); }
    }

    /// <summary>
    /// BoolProperty: bShowThoughtsCombatBarks
    /// </summary>
    public unsafe bool bShowThoughtsCombatBarks
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 96) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 96); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 96); }
    }

    /// <summary>
    /// BoolProperty: bShowThoughtsSpawn
    /// </summary>
    public unsafe bool bShowThoughtsSpawn
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 96) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 96); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 96); }
    }

    /// <summary>
    /// BoolProperty: bShowThoughtsController
    /// </summary>
    public unsafe bool bShowThoughtsController
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 96) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 96); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 96); }
    }

    /// <summary>
    /// BoolProperty: bShowThoughtsControllerState
    /// </summary>
    public unsafe bool bShowThoughtsControllerState
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 96) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 96); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 96); }
    }

    /// <summary>
    /// BoolProperty: bShowThoughtsWeapon
    /// </summary>
    public unsafe bool bShowThoughtsWeapon
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 96) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 96); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 96); }
    }

    /// <summary>
    /// BoolProperty: bShowThoughtsPawnPhysics
    /// </summary>
    public unsafe bool bShowThoughtsPawnPhysics
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 96) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 96); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 96); }
    }

    /// <summary>
    /// BoolProperty: bShowThoughtsActionQueue
    /// </summary>
    public unsafe bool bShowThoughtsActionQueue
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 96) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 96); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 96); }
    }

    /// <summary>
    /// BoolProperty: bShowThoughtsBrain
    /// </summary>
    public unsafe bool bShowThoughtsBrain
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 96) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 96); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 96); }
    }

    /// <summary>
    /// BoolProperty: bShowThoughtsEventState
    /// </summary>
    public unsafe bool bShowThoughtsEventState
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 96) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 96); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 96); }
    }

    /// <summary>
    /// BoolProperty: bShowThoughtsBehaviour
    /// </summary>
    public unsafe bool bShowThoughtsBehaviour
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 96) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 96); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 96); }
    }

    /// <summary>
    /// BoolProperty: bShowThoughtsBehaviourList
    /// </summary>
    public unsafe bool bShowThoughtsBehaviourList
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 96) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 96); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 96); }
    }

    /// <summary>
    /// BoolProperty: bShowThoughtsBehaviourListStanceStack
    /// </summary>
    public unsafe bool bShowThoughtsBehaviourListStanceStack
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 96) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 96); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 96); }
    }

    /// <summary>
    /// BoolProperty: bShowThoughtsBehaviourState
    /// </summary>
    public unsafe bool bShowThoughtsBehaviourState
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 96) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 96); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 96); }
    }

    /// <summary>
    /// BoolProperty: bShowThoughtsEventOwnerVis
    /// </summary>
    public unsafe bool bShowThoughtsEventOwnerVis
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 96) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 96); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 96); }
    }

    /// <summary>
    /// BoolProperty: bShowThoughtsPlayerRunTowards
    /// </summary>
    public unsafe bool bShowThoughtsPlayerRunTowards
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 96) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 96); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 96); }
    }

    /// <summary>
    /// BoolProperty: bShowThoughtsHealth
    /// </summary>
    public unsafe bool bShowThoughtsHealth
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 96) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 96); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 96); }
    }

    /// <summary>
    /// BoolProperty: bShowThoughtsRouter
    /// </summary>
    public unsafe bool bShowThoughtsRouter
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 96) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 96); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 96); }
    }

    /// <summary>
    /// BoolProperty: bShowThoughtsRouter_Priority
    /// </summary>
    public unsafe bool bShowThoughtsRouter_Priority
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 100) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 100); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 100); }
    }

    /// <summary>
    /// BoolProperty: bShowThoughtsRouter_HasPath
    /// </summary>
    public unsafe bool bShowThoughtsRouter_HasPath
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 100) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 100); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 100); }
    }

    /// <summary>
    /// BoolProperty: bShowThoughtsRouter_PathLength
    /// </summary>
    public unsafe bool bShowThoughtsRouter_PathLength
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 100) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 100); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 100); }
    }

    /// <summary>
    /// BoolProperty: bShowThoughtsRouter_FailReason
    /// </summary>
    public unsafe bool bShowThoughtsRouter_FailReason
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 100) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 100); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 100); }
    }

    /// <summary>
    /// BoolProperty: bShowThoughtsRouter_NavActors
    /// </summary>
    public unsafe bool bShowThoughtsRouter_NavActors
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 100) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 100); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 100); }
    }

    /// <summary>
    /// BoolProperty: bShowThoughtsRouter_EmptyHandles
    /// </summary>
    public unsafe bool bShowThoughtsRouter_EmptyHandles
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 100) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 100); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 100); }
    }

    /// <summary>
    /// BoolProperty: bShowThoughtsRouter_Traversal
    /// </summary>
    public unsafe bool bShowThoughtsRouter_Traversal
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 100) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 100); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 100); }
    }

    /// <summary>
    /// BoolProperty: bShowThoughtsRouter_ReproInfo
    /// </summary>
    public unsafe bool bShowThoughtsRouter_ReproInfo
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 100) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 100); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 100); }
    }

    /// <summary>
    /// BoolProperty: bShowThoughtsRouterFailHistory
    /// </summary>
    public unsafe bool bShowThoughtsRouterFailHistory
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 100) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 100); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 100); }
    }

    /// <summary>
    /// BoolProperty: bAcceleratedRiddlerProgress
    /// </summary>
    public unsafe bool bAcceleratedRiddlerProgress
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 100) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 100); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 100); }
    }

    /// <summary>
    /// BoolProperty: bBehaviourDebugOutput
    /// </summary>
    public unsafe bool bBehaviourDebugOutput
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 100) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 100); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 100); }
    }

    /// <summary>
    /// BoolProperty: bCombatDebugOutput
    /// </summary>
    public unsafe bool bCombatDebugOutput
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 100) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 100); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 100); }
    }

    /// <summary>
    /// BoolProperty: bThoughtListDebugOutput
    /// </summary>
    public unsafe bool bThoughtListDebugOutput
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 100) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 100); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 100); }
    }

    /// <summary>
    /// BoolProperty: bAIInvulnerable
    /// </summary>
    public unsafe bool bAIInvulnerable
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 100) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 100); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 100); }
    }

    /// <summary>
    /// BoolProperty: bOverworldSpawnLosDisable
    /// </summary>
    public unsafe bool bOverworldSpawnLosDisable
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 100) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 100); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 100); }
    }

    /// <summary>
    /// BoolProperty: bShowAlerts
    /// </summary>
    public unsafe bool bShowAlerts
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 100) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 100); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 100); }
    }

    /// <summary>
    /// BoolProperty: bShowAlertLines
    /// </summary>
    public unsafe bool bShowAlertLines
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 100) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 100); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 100); }
    }

    /// <summary>
    /// BoolProperty: bShowPlayerVisibility
    /// </summary>
    public unsafe bool bShowPlayerVisibility
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 100) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 100); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 100); }
    }

    /// <summary>
    /// BoolProperty: bShowEventInstigatorVisibility
    /// </summary>
    public unsafe bool bShowEventInstigatorVisibility
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 100) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 100); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 100); }
    }

    /// <summary>
    /// BoolProperty: bShowChaseTrees
    /// </summary>
    public unsafe bool bShowChaseTrees
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 100) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 100); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 100); }
    }

    /// <summary>
    /// BoolProperty: bShowViewCone
    /// </summary>
    public unsafe bool bShowViewCone
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 100) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 100); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 100); }
    }

    /// <summary>
    /// BoolProperty: bPauseOnChaseFail
    /// </summary>
    public unsafe bool bPauseOnChaseFail
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 100) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 100); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 100); }
    }

    /// <summary>
    /// BoolProperty: bShowPauseLookAroundInfo
    /// </summary>
    public unsafe bool bShowPauseLookAroundInfo
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 100) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 100); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 100); }
    }

    /// <summary>
    /// BoolProperty: bShowLookDirections
    /// </summary>
    public unsafe bool bShowLookDirections
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 100) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 100); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 100); }
    }

    /// <summary>
    /// BoolProperty: bShowRandomPopulationDebug
    /// </summary>
    public unsafe bool bShowRandomPopulationDebug
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 100) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 100); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 100); }
    }

    /// <summary>
    /// BoolProperty: bShowThreatLevelDebug
    /// </summary>
    public unsafe bool bShowThreatLevelDebug
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 100) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 100); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 100); }
    }

    /// <summary>
    /// BoolProperty: bShowInformants
    /// </summary>
    public unsafe bool bShowInformants
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 100) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 100); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 100); }
    }

    /// <summary>
    /// BoolProperty: bGargSmashingActive
    /// </summary>
    public unsafe bool bGargSmashingActive
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 100) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 100); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 100); }
    }

    /// <summary>
    /// BoolProperty: bPlaceMineOnDestructibleVantagePoints
    /// </summary>
    public unsafe bool bPlaceMineOnDestructibleVantagePoints
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 100) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 100); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 100); }
    }

    /// <summary>
    /// BoolProperty: bForceBuddyBump
    /// </summary>
    public unsafe bool bForceBuddyBump
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 100) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 100); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 100); }
    }

    /// <summary>
    /// BoolProperty: bEnableAdHocGrouping
    /// </summary>
    public unsafe bool bEnableAdHocGrouping
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 100) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 100); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 100); }
    }

    /// <summary>
    /// BoolProperty: bAIVocalDebug
    /// </summary>
    public unsafe bool bAIVocalDebug
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 100) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 100); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 100); }
    }

    /// <summary>
    /// BoolProperty: bAIVocalDebugVoices
    /// </summary>
    public unsafe bool bAIVocalDebugVoices
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 104) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 104); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 104); }
    }

    /// <summary>
    /// BoolProperty: bAIVocalDebugEmotes
    /// </summary>
    public unsafe bool bAIVocalDebugEmotes
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 104) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 104); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 104); }
    }

    /// <summary>
    /// BoolProperty: bAIVocalDebugBarks
    /// </summary>
    public unsafe bool bAIVocalDebugBarks
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 104) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 104); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 104); }
    }

    /// <summary>
    /// BoolProperty: bAIVocalDebugSpeech
    /// </summary>
    public unsafe bool bAIVocalDebugSpeech
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 104) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 104); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 104); }
    }

    /// <summary>
    /// BoolProperty: bBarkLogAllAssignmentHistory
    /// </summary>
    public unsafe bool bBarkLogAllAssignmentHistory
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 104) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 104); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 104); }
    }

    /// <summary>
    /// BoolProperty: bRiotingDestinationDebug
    /// </summary>
    public unsafe bool bRiotingDestinationDebug
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 104) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 104); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 104); }
    }

    /// <summary>
    /// BoolProperty: bShowJokerSickness
    /// </summary>
    public unsafe bool bShowJokerSickness
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 104) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 104); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 104); }
    }

    /// <summary>
    /// BoolProperty: bForceJokerInRiots
    /// </summary>
    public unsafe bool bForceJokerInRiots
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 104) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 104); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 104); }
    }

    /// <summary>
    /// BoolProperty: bExposeJokerRooftopOptions
    /// </summary>
    public unsafe bool bExposeJokerRooftopOptions
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 104) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 104); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 104); }
    }

    /// <summary>
    /// BoolProperty: bAlwaysSpawnJokerRooftop
    /// </summary>
    public unsafe bool bAlwaysSpawnJokerRooftop
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 104) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 104); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 104); }
    }

    /// <summary>
    /// BoolProperty: bHighlightJokerRooftop
    /// </summary>
    public unsafe bool bHighlightJokerRooftop
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 104) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 104); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 104); }
    }

    /// <summary>
    /// BoolProperty: bSpawnAllJokerRooftop
    /// </summary>
    public unsafe bool bSpawnAllJokerRooftop
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 104) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 104); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 104); }
    }

    /// <summary>
    /// BoolProperty: bResetJokerRooftopTimer
    /// </summary>
    public unsafe bool bResetJokerRooftopTimer
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 104) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 104); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 104); }
    }

    /// <summary>
    /// BoolProperty: bMaxJokersAllowedInRiots
    /// </summary>
    public unsafe bool bMaxJokersAllowedInRiots
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 104) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 104); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 104); }
    }

    /// <summary>
    /// BoolProperty: bShowThugDebugRendering
    /// </summary>
    public unsafe bool bShowThugDebugRendering
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 104) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 104); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 104); }
    }

    /// <summary>
    /// BoolProperty: bShowThugLongRangeHighlights
    /// </summary>
    public unsafe bool bShowThugLongRangeHighlights
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 104) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 104); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 104); }
    }

    /// <summary>
    /// BoolProperty: bForceInformantFightbacks
    /// </summary>
    public unsafe bool bForceInformantFightbacks
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 104) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 104); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 104); }
    }

    /// <summary>
    /// BoolProperty: bDisableAntiBacktrack
    /// </summary>
    public unsafe bool bDisableAntiBacktrack
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 104) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 104); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 104); }
    }

    /// <summary>
    /// BoolProperty: Debug_Combat_CanAlwaysTakedown
    /// </summary>
    public unsafe bool Debug_Combat_CanAlwaysTakedown
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 104) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 104); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 104); }
    }

    /// <summary>
    /// BoolProperty: Debug_Combat_AlwaysFreeflowFocusMode
    /// </summary>
    public unsafe bool Debug_Combat_AlwaysFreeflowFocusMode
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 104) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 104); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 104); }
    }

    /// <summary>
    /// BoolProperty: Debug_Combat_AlwaysFinalBlow
    /// </summary>
    public unsafe bool Debug_Combat_AlwaysFinalBlow
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 104) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 104); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 104); }
    }

    /// <summary>
    /// BoolProperty: Debug_Combat_CanAttack
    /// </summary>
    public unsafe bool Debug_Combat_CanAttack
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 104) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 104); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 104); }
    }

    /// <summary>
    /// BoolProperty: Debug_Combat_ForceEnvironmentUse
    /// </summary>
    public unsafe bool Debug_Combat_ForceEnvironmentUse
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 104) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 104); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 104); }
    }

    /// <summary>
    /// BoolProperty: Debug_Combat_PreventEnvironmentUse
    /// </summary>
    public unsafe bool Debug_Combat_PreventEnvironmentUse
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 104) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 104); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 104); }
    }

    /// <summary>
    /// BoolProperty: Debug_Combat_ShowDamageCollision
    /// </summary>
    public unsafe bool Debug_Combat_ShowDamageCollision
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 104) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 104); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 104); }
    }

    /// <summary>
    /// BoolProperty: Debug_Combat_CameraAssist
    /// </summary>
    public unsafe bool Debug_Combat_CameraAssist
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 104) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 104); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 104); }
    }

    /// <summary>
    /// BoolProperty: Debug_Combat_ShowRagdollImpulse
    /// </summary>
    public unsafe bool Debug_Combat_ShowRagdollImpulse
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 104) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 104); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 104); }
    }

    /// <summary>
    /// BoolProperty: Debug_Combat_EnableCounterBreak
    /// </summary>
    public unsafe bool Debug_Combat_EnableCounterBreak
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 104) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 104); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 104); }
    }

    /// <summary>
    /// BoolProperty: Debug_Combat_DisableHighlights
    /// </summary>
    public unsafe bool Debug_Combat_DisableHighlights
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 104) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 104); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 104); }
    }

    /// <summary>
    /// BoolProperty: Debug_Combat_DisableStunStars
    /// </summary>
    public unsafe bool Debug_Combat_DisableStunStars
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 104) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 104); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 104); }
    }

    /// <summary>
    /// BoolProperty: Debug_Combat_DisableImpactVFX
    /// </summary>
    public unsafe bool Debug_Combat_DisableImpactVFX
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 104) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 104); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 104); }
    }

    /// <summary>
    /// BoolProperty: Debug_Combat_DisableStrikeTrails
    /// </summary>
    public unsafe bool Debug_Combat_DisableStrikeTrails
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 104) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 104); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 104); }
    }

    /// <summary>
    /// BoolProperty: Debug_Combat_OnlySimultaneousAttacks
    /// </summary>
    public unsafe bool Debug_Combat_OnlySimultaneousAttacks
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 108) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 108); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 108); }
    }

    /// <summary>
    /// BoolProperty: Debug_Combat_SCounter2ThugAngled
    /// </summary>
    public unsafe bool Debug_Combat_SCounter2ThugAngled
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 108) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 108); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 108); }
    }

    /// <summary>
    /// BoolProperty: Debug_Combat_SCounter2ThugStraight
    /// </summary>
    public unsafe bool Debug_Combat_SCounter2ThugStraight
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 108) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 108); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 108); }
    }

    /// <summary>
    /// BoolProperty: Debug_Combat_AlwaysSlowdownSimultaneousAttacks
    /// </summary>
    public unsafe bool Debug_Combat_AlwaysSlowdownSimultaneousAttacks
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 108) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 108); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 108); }
    }

    /// <summary>
    /// BoolProperty: Debug_Combat_ForceMaxSimultaneousAttackers
    /// </summary>
    public unsafe bool Debug_Combat_ForceMaxSimultaneousAttackers
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 108) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 108); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 108); }
    }

    /// <summary>
    /// BoolProperty: Debug_Combat_CriticalSimultaneousDebug
    /// </summary>
    public unsafe bool Debug_Combat_CriticalSimultaneousDebug
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 108) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 108); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 108); }
    }

    /// <summary>
    /// BoolProperty: Debug_Combat_ShowDesiredPosition
    /// </summary>
    public unsafe bool Debug_Combat_ShowDesiredPosition
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 108) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 108); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 108); }
    }

    /// <summary>
    /// BoolProperty: Debug_Combat_DisableWeakMoves
    /// </summary>
    public unsafe bool Debug_Combat_DisableWeakMoves
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 108) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 108); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 108); }
    }

    /// <summary>
    /// BoolProperty: Debug_Combat_DisableBot
    /// </summary>
    public unsafe bool Debug_Combat_DisableBot
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 108) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 108); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 108); }
    }

    /// <summary>
    /// BoolProperty: Debug_Combat_DualPlayGhost
    /// </summary>
    public unsafe bool Debug_Combat_DualPlayGhost
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 108) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 108); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 108); }
    }

    /// <summary>
    /// BoolProperty: Debug_Combat_ShowDualStrikeDebug
    /// </summary>
    public unsafe bool Debug_Combat_ShowDualStrikeDebug
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 108) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 108); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 108); }
    }

    /// <summary>
    /// BoolProperty: Debug_Combat_DisableXPBats
    /// </summary>
    public unsafe bool Debug_Combat_DisableXPBats
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 108) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 108); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 108); }
    }

    /// <summary>
    /// BoolProperty: Debug_Combat_DisableUndeadCheck
    /// </summary>
    public unsafe bool Debug_Combat_DisableUndeadCheck
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 108) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 108); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 108); }
    }

    /// <summary>
    /// BoolProperty: Debug_Combat_DisableEnvironmentObjectHighlight
    /// </summary>
    public unsafe bool Debug_Combat_DisableEnvironmentObjectHighlight
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 108) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 108); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 108); }
    }

    /// <summary>
    /// BoolProperty: Debug_Combat_UseRainVFX
    /// </summary>
    public unsafe bool Debug_Combat_UseRainVFX
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 108) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 108); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 108); }
    }

    /// <summary>
    /// BoolProperty: Debug_Combat_ForceWetDirt
    /// </summary>
    public unsafe bool Debug_Combat_ForceWetDirt
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 108) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 108); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 108); }
    }

    /// <summary>
    /// BoolProperty: Debug_Combat_ShowBatmobileTakedownPoints
    /// </summary>
    public unsafe bool Debug_Combat_ShowBatmobileTakedownPoints
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 108) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 108); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 108); }
    }

    /// <summary>
    /// BoolProperty: Debug_Combat_ShowEnvTakedownDebug
    /// </summary>
    public unsafe bool Debug_Combat_ShowEnvTakedownDebug
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 108) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 108); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 108); }
    }

    /// <summary>
    /// BoolProperty: Debug_Combat_EnableSimultaneousAttacks
    /// </summary>
    public unsafe bool Debug_Combat_EnableSimultaneousAttacks
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 108) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 108); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 108); }
    }

    /// <summary>
    /// BoolProperty: Debug_Combat_EnableTGPunches
    /// </summary>
    public unsafe bool Debug_Combat_EnableTGPunches
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 108) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 108); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 108); }
    }

    /// <summary>
    /// BoolProperty: Debug_Combat_EnableTGKicks
    /// </summary>
    public unsafe bool Debug_Combat_EnableTGKicks
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 108) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 108); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 108); }
    }

    /// <summary>
    /// BoolProperty: Debug_Combat_EnableTGGrab
    /// </summary>
    public unsafe bool Debug_Combat_EnableTGGrab
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 108) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 108); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 108); }
    }

    /// <summary>
    /// BoolProperty: Debug_Combat_EnableTGCharge
    /// </summary>
    public unsafe bool Debug_Combat_EnableTGCharge
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 108) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 108); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 108); }
    }

    /// <summary>
    /// BoolProperty: Debug_Combat_EnableCESingle
    /// </summary>
    public unsafe bool Debug_Combat_EnableCESingle
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 108) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 108); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 108); }
    }

    /// <summary>
    /// BoolProperty: Debug_Combat_EnableCEMulti
    /// </summary>
    public unsafe bool Debug_Combat_EnableCEMulti
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 108) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 108); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 108); }
    }

    /// <summary>
    /// BoolProperty: Debug_Combat_EnableCEWall
    /// </summary>
    public unsafe bool Debug_Combat_EnableCEWall
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 108) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 108); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 108); }
    }

    /// <summary>
    /// BoolProperty: Debug_Combat_EnableCEAlly
    /// </summary>
    public unsafe bool Debug_Combat_EnableCEAlly
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 108) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 108); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 108); }
    }

    /// <summary>
    /// BoolProperty: Debug_Combat_EnableCEFury
    /// </summary>
    public unsafe bool Debug_Combat_EnableCEFury
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 108) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 108); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 108); }
    }

    /// <summary>
    /// BoolProperty: Debug_Combat_TargettingCone
    /// </summary>
    public unsafe bool Debug_Combat_TargettingCone
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 108) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 108); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 108); }
    }

    /// <summary>
    /// BoolProperty: Debug_Combat_Targets
    /// </summary>
    public unsafe bool Debug_Combat_Targets
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 108) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 108); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 108); }
    }

    /// <summary>
    /// BoolProperty: Debug_Combat_CameraOrientation
    /// </summary>
    public unsafe bool Debug_Combat_CameraOrientation
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 108) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 108); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 108); }
    }

    /// <summary>
    /// BoolProperty: Debug_Combat_ShowMoveForceLines
    /// </summary>
    public unsafe bool Debug_Combat_ShowMoveForceLines
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 108) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 108); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 108); }
    }

    /// <summary>
    /// BoolProperty: Debug_Combat_LogCombatMoves
    /// </summary>
    public unsafe bool Debug_Combat_LogCombatMoves
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 112) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 112); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 112); }
    }

    /// <summary>
    /// BoolProperty: Debug_Combat_ShowCombatAreas
    /// </summary>
    public unsafe bool Debug_Combat_ShowCombatAreas
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 112) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 112); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 112); }
    }

    /// <summary>
    /// BoolProperty: Debug_Combat_ShowCylinderCollisionChecks
    /// </summary>
    public unsafe bool Debug_Combat_ShowCylinderCollisionChecks
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 112) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 112); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 112); }
    }

    /// <summary>
    /// BoolProperty: Debug_Combat_ShowGroupStunRadius
    /// </summary>
    public unsafe bool Debug_Combat_ShowGroupStunRadius
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 112) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 112); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 112); }
    }

    /// <summary>
    /// BoolProperty: Debug_Combat_OneHitKill
    /// </summary>
    public unsafe bool Debug_Combat_OneHitKill
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 112) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 112); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 112); }
    }

    /// <summary>
    /// BoolProperty: Debug_Combat_ShowMoveToPlayerDebug
    /// </summary>
    public unsafe bool Debug_Combat_ShowMoveToPlayerDebug
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 112) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 112); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 112); }
    }

    /// <summary>
    /// BoolProperty: Debug_Combat_ShowVariationList
    /// </summary>
    public unsafe bool Debug_Combat_ShowVariationList
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 112) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 112); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 112); }
    }

    /// <summary>
    /// BoolProperty: Debug_Combat_ForceKnackered
    /// </summary>
    public unsafe bool Debug_Combat_ForceKnackered
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 112) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 112); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 112); }
    }

    /// <summary>
    /// BoolProperty: Debug_Combat_CanAlwaysDualPlay
    /// </summary>
    public unsafe bool Debug_Combat_CanAlwaysDualPlay
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 112) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 112); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 112); }
    }

    /// <summary>
    /// BoolProperty: Debug_Combat_bAlwaysRemoveHelmets
    /// </summary>
    public unsafe bool Debug_Combat_bAlwaysRemoveHelmets
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 112) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 112); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 112); }
    }

    /// <summary>
    /// BoolProperty: Debug_Sniper_ShowViewCones
    /// </summary>
    public unsafe bool Debug_Sniper_ShowViewCones
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 112) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 112); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 112); }
    }

    /// <summary>
    /// BoolProperty: Debug_Show_VenomDebug
    /// </summary>
    public unsafe bool Debug_Show_VenomDebug
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 112) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 112); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 112); }
    }

    /// <summary>
    /// BoolProperty: Debug_Venom_KeepInView
    /// </summary>
    public unsafe bool Debug_Venom_KeepInView
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 112) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 112); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 112); }
    }

    /// <summary>
    /// BoolProperty: Debug_Venom_ShowClampedAim
    /// </summary>
    public unsafe bool Debug_Venom_ShowClampedAim
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 112) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 112); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 112); }
    }

    /// <summary>
    /// BoolProperty: Debug_Venom_ShowAttacking
    /// </summary>
    public unsafe bool Debug_Venom_ShowAttacking
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 112) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 112); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 112); }
    }

    /// <summary>
    /// BoolProperty: Debug_Player_ShowXP
    /// </summary>
    public unsafe bool Debug_Player_ShowXP
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 112) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 112); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 112); }
    }

    /// <summary>
    /// BoolProperty: Debug_Player_ShowXPAttractors
    /// </summary>
    public unsafe bool Debug_Player_ShowXPAttractors
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 112) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 112); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 112); }
    }

    /// <summary>
    /// BoolProperty: Debug_Player_EnableThoughts
    /// </summary>
    public unsafe bool Debug_Player_EnableThoughts
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 112) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 112); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 112); }
    }

    /// <summary>
    /// BoolProperty: Debug_Player_EnableThoughtsInterrogation
    /// </summary>
    public unsafe bool Debug_Player_EnableThoughtsInterrogation
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 112) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 112); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 112); }
    }

    /// <summary>
    /// BoolProperty: Debug_Player_TakeDownTestMenuOn
    /// </summary>
    public unsafe bool Debug_Player_TakeDownTestMenuOn
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 112) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 112); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 112); }
    }

    /// <summary>
    /// BoolProperty: Debug_Player_DisableEnvironmentTakedowns
    /// </summary>
    public unsafe bool Debug_Player_DisableEnvironmentTakedowns
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 112) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 112); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 112); }
    }

    /// <summary>
    /// BoolProperty: Debug_Player_SuppressFinaleCamera
    /// </summary>
    public unsafe bool Debug_Player_SuppressFinaleCamera
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 112) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 112); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 112); }
    }

    /// <summary>
    /// BoolProperty: Debug_Player_ForceSilentCombatTakedowns
    /// </summary>
    public unsafe bool Debug_Player_ForceSilentCombatTakedowns
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 112) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 112); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 112); }
    }

    /// <summary>
    /// BoolProperty: Debug_Player_IgnoreTakedownNotifyRestrictions
    /// </summary>
    public unsafe bool Debug_Player_IgnoreTakedownNotifyRestrictions
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 112) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 112); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 112); }
    }

    /// <summary>
    /// BoolProperty: Debug_Player_ShowCeilingInfo
    /// </summary>
    public unsafe bool Debug_Player_ShowCeilingInfo
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 112) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 112); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 112); }
    }

    /// <summary>
    /// BoolProperty: Debug_Player_DebugFootsteps
    /// </summary>
    public unsafe bool Debug_Player_DebugFootsteps
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 112) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 112); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 112); }
    }

    /// <summary>
    /// BoolProperty: Debug_Player_IgnoreInterrogationSafeCheck
    /// </summary>
    public unsafe bool Debug_Player_IgnoreInterrogationSafeCheck
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 112) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 112); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 112); }
    }

    /// <summary>
    /// BoolProperty: Debug_Player_ForceScanForBombThugs
    /// </summary>
    public unsafe bool Debug_Player_ForceScanForBombThugs
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 112) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 112); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 112); }
    }

    /// <summary>
    /// BoolProperty: Debug_PowerGlide
    /// </summary>
    public unsafe bool Debug_PowerGlide
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 112) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 112); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 112); }
    }

    /// <summary>
    /// BoolProperty: Debug_UseNormalGlideAccelDecel
    /// </summary>
    public unsafe bool Debug_UseNormalGlideAccelDecel
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 112) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 112); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 112); }
    }

    /// <summary>
    /// BoolProperty: Debug_NoPrompts
    /// </summary>
    public unsafe bool Debug_NoPrompts
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 112) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 112); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 112); }
    }

    /// <summary>
    /// BoolProperty: Debug_NoCompass
    /// </summary>
    public unsafe bool Debug_NoCompass
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 112) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 112); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 112); }
    }

    /// <summary>
    /// BoolProperty: Debug_Navigation_ShowDebug
    /// </summary>
    public unsafe bool Debug_Navigation_ShowDebug
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 116) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 116); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 116); }
    }

    /// <summary>
    /// BoolProperty: Debug_Navigation_ShowAIPaths
    /// </summary>
    public unsafe bool Debug_Navigation_ShowAIPaths
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 116) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 116); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 116); }
    }

    /// <summary>
    /// BoolProperty: Debug_Navigation_ShowAIPathShortening
    /// </summary>
    public unsafe bool Debug_Navigation_ShowAIPathShortening
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 116) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 116); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 116); }
    }

    /// <summary>
    /// BoolProperty: Debug_Navigation_ShowAIPathAiming
    /// </summary>
    public unsafe bool Debug_Navigation_ShowAIPathAiming
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 116) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 116); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 116); }
    }

    /// <summary>
    /// BoolProperty: Debug_Navigation_ShowAIPathStairDetection
    /// </summary>
    public unsafe bool Debug_Navigation_ShowAIPathStairDetection
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 116) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 116); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 116); }
    }

    /// <summary>
    /// BoolProperty: Debug_Navigation_ShowPathPolys
    /// </summary>
    public unsafe bool Debug_Navigation_ShowPathPolys
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 116) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 116); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 116); }
    }

    /// <summary>
    /// BoolProperty: Debug_Navigation_ShowInlineHandling
    /// </summary>
    public unsafe bool Debug_Navigation_ShowInlineHandling
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 116) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 116); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 116); }
    }

    /// <summary>
    /// BoolProperty: Debug_Navigation_ShowAllPaths
    /// </summary>
    public unsafe bool Debug_Navigation_ShowAllPaths
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 116) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 116); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 116); }
    }

    /// <summary>
    /// BoolProperty: Debug_Navigation_ShowAIAvoidance
    /// </summary>
    public unsafe bool Debug_Navigation_ShowAIAvoidance
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 116) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 116); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 116); }
    }

    /// <summary>
    /// BoolProperty: Debug_Navigation_ShowTraversalHistory
    /// </summary>
    public unsafe bool Debug_Navigation_ShowTraversalHistory
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 116) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 116); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 116); }
    }

    /// <summary>
    /// BoolProperty: Debug_Navigation_PauseOnStuck
    /// </summary>
    public unsafe bool Debug_Navigation_PauseOnStuck
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 116) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 116); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 116); }
    }

    /// <summary>
    /// BoolProperty: Debug_Navigation_ShowSlideLines
    /// </summary>
    public unsafe bool Debug_Navigation_ShowSlideLines
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 116) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 116); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 116); }
    }

    /// <summary>
    /// BoolProperty: bVisualiseGrenades
    /// </summary>
    public unsafe bool bVisualiseGrenades
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 116) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 116); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 116); }
    }

    /// <summary>
    /// BoolProperty: bAlwaysDoHallucinations
    /// </summary>
    public unsafe bool bAlwaysDoHallucinations
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 116) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 116); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 116); }
    }

    /// <summary>
    /// BoolProperty: bAlwaysDoManbatAppearances
    /// </summary>
    public unsafe bool bAlwaysDoManbatAppearances
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 116) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 116); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 116); }
    }

    /// <summary>
    /// BoolProperty: Debug_ShowProgress
    /// </summary>
    public unsafe bool Debug_ShowProgress
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 116) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 116); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 116); }
    }

    /// <summary>
    /// BoolProperty: Debug_ShowSavePoints
    /// </summary>
    public unsafe bool Debug_ShowSavePoints
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 116) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 116); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 116); }
    }

    /// <summary>
    /// BoolProperty: Debug_DisableSlowStuff
    /// </summary>
    public unsafe bool Debug_DisableSlowStuff
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 116) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 116); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 116); }
    }

    /// <summary>
    /// BoolProperty: Debug_ShowSideStoryDiscoverables
    /// </summary>
    public unsafe bool Debug_ShowSideStoryDiscoverables
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 116) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 116); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 116); }
    }

    /// <summary>
    /// BoolProperty: Debug_ShowHelicopterPointsOfInterest
    /// </summary>
    public unsafe bool Debug_ShowHelicopterPointsOfInterest
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 116) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 116); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 116); }
    }

    /// <summary>
    /// BoolProperty: Debug_ShowSoakTimer
    /// </summary>
    public unsafe bool Debug_ShowSoakTimer
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 116) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 116); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 116); }
    }

    /// <summary>
    /// BoolProperty: Debug_ShowAllMapIcons
    /// </summary>
    public unsafe bool Debug_ShowAllMapIcons
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 116) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 116); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 116); }
    }

    /// <summary>
    /// BoolProperty: Debug_DebugLabels
    /// </summary>
    public unsafe bool Debug_DebugLabels
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 116) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 116); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 116); }
    }

    /// <summary>
    /// BoolProperty: Debug_PickupLabels
    /// </summary>
    public unsafe bool Debug_PickupLabels
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 116) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 116); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 116); }
    }

    /// <summary>
    /// BoolProperty: Debug_Disable_All_Capes
    /// </summary>
    public unsafe bool Debug_Disable_All_Capes
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 116) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 116); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 116); }
    }

    /// <summary>
    /// BoolProperty: Debug_Hide_Cape
    /// </summary>
    public unsafe bool Debug_Hide_Cape
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 116) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 116); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 116); }
    }

    /// <summary>
    /// BoolProperty: Debug_Enable_Cape_Thoughts
    /// </summary>
    public unsafe bool Debug_Enable_Cape_Thoughts
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 116) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 116); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 116); }
    }

    /// <summary>
    /// BoolProperty: Debug_Draw_Cape_Debug_Lines
    /// </summary>
    public unsafe bool Debug_Draw_Cape_Debug_Lines
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 116) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 116); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 116); }
    }

    /// <summary>
    /// BoolProperty: Debug_Draw_Water_Volume_Debug_Lines
    /// </summary>
    public unsafe bool Debug_Draw_Water_Volume_Debug_Lines
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 116) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 116); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 116); }
    }

    /// <summary>
    /// BoolProperty: Debug_Draw_Full_Cape_Debug_Lines
    /// </summary>
    public unsafe bool Debug_Draw_Full_Cape_Debug_Lines
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 116) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 116); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 116); }
    }

    /// <summary>
    /// BoolProperty: Debug_Force_Animated_Cape
    /// </summary>
    public unsafe bool Debug_Force_Animated_Cape
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 116) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 116); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 116); }
    }

    /// <summary>
    /// BoolProperty: Debug_Disable_Cape_Depth_Bias
    /// </summary>
    public unsafe bool Debug_Disable_Cape_Depth_Bias
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 116) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 116); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 116); }
    }

    /// <summary>
    /// BoolProperty: Debug_Enable_Actor_Thoughts
    /// </summary>
    public unsafe bool Debug_Enable_Actor_Thoughts
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 120) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 120); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 120); }
    }

    /// <summary>
    /// BoolProperty: Debug_Enable_Material_Parameter_Thoughts
    /// </summary>
    public unsafe bool Debug_Enable_Material_Parameter_Thoughts
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 120) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 120); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 120); }
    }

    /// <summary>
    /// BoolProperty: Debug_Enable_Actor_Name_Thoughts
    /// </summary>
    public unsafe bool Debug_Enable_Actor_Name_Thoughts
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 120) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 120); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 120); }
    }

    /// <summary>
    /// BoolProperty: Disable_Grate_Excluders
    /// </summary>
    public unsafe bool Disable_Grate_Excluders
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 120) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 120); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 120); }
    }

    /// <summary>
    /// BoolProperty: Debug_Draw_Rope_Debug_Lines
    /// </summary>
    public unsafe bool Debug_Draw_Rope_Debug_Lines
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 120) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 120); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 120); }
    }

    /// <summary>
    /// BoolProperty: Debug_Enable_Rope_Thoughts
    /// </summary>
    public unsafe bool Debug_Enable_Rope_Thoughts
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 120) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 120); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 120); }
    }

    /// <summary>
    /// BoolProperty: Debug_DisableRiddlerChallenges
    /// </summary>
    public unsafe bool Debug_DisableRiddlerChallenges
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 120) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 120); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 120); }
    }

    /// <summary>
    /// BoolProperty: Debug_Enable_OnlineInfo
    /// </summary>
    public unsafe bool Debug_Enable_OnlineInfo
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 120) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 120); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 120); }
    }

    /// <summary>
    /// BoolProperty: Debug_Enable_QA_Record
    /// </summary>
    public unsafe bool Debug_Enable_QA_Record
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 120) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 120); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 120); }
    }

    /// <summary>
    /// BoolProperty: Debug_Enable_Audio_Thoughts
    /// </summary>
    public unsafe bool Debug_Enable_Audio_Thoughts
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 120) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 120); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 120); }
    }

    /// <summary>
    /// BoolProperty: Debug_Enable_Vehicle_Vis
    /// </summary>
    public unsafe bool Debug_Enable_Vehicle_Vis
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 120) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 120); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 120); }
    }

    /// <summary>
    /// BoolProperty: Debug_Enable_Vehicle_SuspensionRaycasts
    /// </summary>
    public unsafe bool Debug_Enable_Vehicle_SuspensionRaycasts
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 120) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 120); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 120); }
    }

    /// <summary>
    /// BoolProperty: Debug_Vehicle_DoubleExplosionSounds
    /// </summary>
    public unsafe bool Debug_Vehicle_DoubleExplosionSounds
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 120) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 120); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 120); }
    }

    /// <summary>
    /// BoolProperty: Debug_Destructibles_OverrideBatclawDamage
    /// </summary>
    public unsafe bool Debug_Destructibles_OverrideBatclawDamage
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 120) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 120); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 120); }
    }

    /// <summary>
    /// BoolProperty: Debug_Destructibles_ShowDebrisMaxHeight
    /// </summary>
    public unsafe bool Debug_Destructibles_ShowDebrisMaxHeight
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 120) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 120); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 120); }
    }

    /// <summary>
    /// BoolProperty: Debug_Destructibles_ShowScalarToReduceParticlesAtHighSpeed
    /// </summary>
    public unsafe bool Debug_Destructibles_ShowScalarToReduceParticlesAtHighSpeed
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 120) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 120); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 120); }
    }

    /// <summary>
    /// BoolProperty: Debug_Destructibles_ShowFracturedAndExposedChunks
    /// </summary>
    public unsafe bool Debug_Destructibles_ShowFracturedAndExposedChunks
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 120) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 120); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 120); }
    }

    /// <summary>
    /// BoolProperty: Debug_ApexCloth_PhysicsMeshWire
    /// </summary>
    public unsafe bool Debug_ApexCloth_PhysicsMeshWire
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 120) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 120); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 120); }
    }

    /// <summary>
    /// BoolProperty: Debug_ApexCloth_CollisionShapesWire
    /// </summary>
    public unsafe bool Debug_ApexCloth_CollisionShapesWire
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 120) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 120); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 120); }
    }

    /// <summary>
    /// BoolProperty: Debug_Vehicles_DebugHeavyTanksIssues
    /// </summary>
    public unsafe bool Debug_Vehicles_DebugHeavyTanksIssues
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 120) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 120); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 120); }
    }

    /// <summary>
    /// BoolProperty: Debug_Batmobile_DisableSatNav
    /// </summary>
    public unsafe bool Debug_Batmobile_DisableSatNav
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 120) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 120); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 120); }
    }

    /// <summary>
    /// BoolProperty: Debug_Batmobile_ShowSatNavDestination
    /// </summary>
    public unsafe bool Debug_Batmobile_ShowSatNavDestination
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 120) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 120); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 120); }
    }

    /// <summary>
    /// BoolProperty: Debug_Batmobile_ShowBatmobileDDA
    /// </summary>
    public unsafe bool Debug_Batmobile_ShowBatmobileDDA
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 120) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 120); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 120); }
    }

    /// <summary>
    /// BoolProperty: Debug_Batmobile_IgnoreBatmobileDDA
    /// </summary>
    public unsafe bool Debug_Batmobile_IgnoreBatmobileDDA
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 120) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 120); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 120); }
    }

    /// <summary>
    /// BoolProperty: Debug_EnableLookInAllCineCams
    /// </summary>
    public unsafe bool Debug_EnableLookInAllCineCams
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 120) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 120); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 120); }
    }

    /// <summary>
    /// BoolProperty: Debug_Player_FallFromCeilingOnDamage
    /// </summary>
    public unsafe bool Debug_Player_FallFromCeilingOnDamage
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 120) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 120); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 120); }
    }

    /// <summary>
    /// FloatProperty: DebugGCTime
    /// </summary>
    public unsafe float DebugGCTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 124); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 124); }
    }

    /// <summary>
    /// IntProperty: CurrentLevelSelectPage
    /// </summary>
    public unsafe int CurrentLevelSelectPage
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 128); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 128); }
    }

    /// <summary>
    /// IntProperty: CurrentLevelSelectItem
    /// </summary>
    public unsafe int CurrentLevelSelectItem
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 132); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 132); }
    }

    /// <summary>
    /// IntProperty: Debug_AI_PathFindsPerFrame
    /// </summary>
    public unsafe int Debug_AI_PathFindsPerFrame
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 136); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 136); }
    }

    /// <summary>
    /// IntProperty: Debug_AI_PathShortensPerFrame
    /// </summary>
    public unsafe int Debug_AI_PathShortensPerFrame
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 140); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 140); }
    }

    /// <summary>
    /// IntProperty: Debug_AI_RunAwayLookAhead
    /// </summary>
    public unsafe int Debug_AI_RunAwayLookAhead
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 144); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 144); }
    }

    /// <summary>
    /// FloatProperty: Debug_AI_RunAwayLookAheadDist
    /// </summary>
    public unsafe float Debug_AI_RunAwayLookAheadDist
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 148); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 148); }
    }

    /// <summary>
    /// IntProperty: WonkyPolyToolTolerance
    /// </summary>
    public unsafe int WonkyPolyToolTolerance
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 152); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 152); }
    }

    /// <summary>
    /// IntProperty: ChaseTreeSearchDist
    /// </summary>
    public unsafe int ChaseTreeSearchDist
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 156); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 156); }
    }

    /// <summary>
    /// IntProperty: LeftForceGestureAnimIndex
    /// </summary>
    public unsafe int LeftForceGestureAnimIndex
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 160); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 160); }
    }

    /// <summary>
    /// IntProperty: RightForceGestureAnimIndex
    /// </summary>
    public unsafe int RightForceGestureAnimIndex
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 164); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 164); }
    }

    /// <summary>
    /// FloatProperty: JokerRoofMaxRangeForDialogue
    /// </summary>
    public unsafe float JokerRoofMaxRangeForDialogue
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 168); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 168); }
    }

    /// <summary>
    /// FloatProperty: JokerRoofMaxRangeForSpawn
    /// </summary>
    public unsafe float JokerRoofMaxRangeForSpawn
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 172); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 172); }
    }

    /// <summary>
    /// FloatProperty: JokerRoofMaxRangeBeforeDeleteAfterSeen
    /// </summary>
    public unsafe float JokerRoofMaxRangeBeforeDeleteAfterSeen
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 176); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 176); }
    }

    /// <summary>
    /// FloatProperty: JokerRoofMinTimeBetweenJokersAfterFailedChance
    /// </summary>
    public unsafe float JokerRoofMinTimeBetweenJokersAfterFailedChance
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 180); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 180); }
    }

    /// <summary>
    /// FloatProperty: JokerRoofMinTimeBetweenJokersNoDialogue
    /// </summary>
    public unsafe float JokerRoofMinTimeBetweenJokersNoDialogue
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 184); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 184); }
    }

    /// <summary>
    /// FloatProperty: JokerRoofMinTimeBetweenJokersAfterDialogue
    /// </summary>
    public unsafe float JokerRoofMinTimeBetweenJokersAfterDialogue
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 188); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 188); }
    }

    /// <summary>
    /// FloatProperty: JokerInRiotPercChance
    /// </summary>
    public unsafe float JokerInRiotPercChance
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 192); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 192); }
    }

    /// <summary>
    /// IntProperty: JokerTimeBetweenRiotAppearance
    /// </summary>
    public unsafe int JokerTimeBetweenRiotAppearance
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 196); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 196); }
    }

    /// <summary>
    /// FloatProperty: Debug_Combat_TargettingArc
    /// </summary>
    public unsafe float Debug_Combat_TargettingArc
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 200); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 200); }
    }

    /// <summary>
    /// FloatProperty: Debug_Combat_ComboLengthMin
    /// </summary>
    public unsafe float Debug_Combat_ComboLengthMin
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 204); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 204); }
    }

    /// <summary>
    /// FloatProperty: Debug_Combat_AllyDist
    /// </summary>
    public unsafe float Debug_Combat_AllyDist
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 208); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 208); }
    }

    /// <summary>
    /// FloatProperty: Debug_Combat_BMForce
    /// </summary>
    public unsafe float Debug_Combat_BMForce
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 212); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 212); }
    }

    /// <summary>
    /// FloatProperty: Debug_Combat_AllyForce
    /// </summary>
    public unsafe float Debug_Combat_AllyForce
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 216); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 216); }
    }

    /// <summary>
    /// FloatProperty: Debug_Combat_MinMoveForce
    /// </summary>
    public unsafe float Debug_Combat_MinMoveForce
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 220); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 220); }
    }

    /// <summary>
    /// FloatProperty: Debug_Combat_StunTime
    /// </summary>
    public unsafe float Debug_Combat_StunTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 224); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 224); }
    }

    /// <summary>
    /// FloatProperty: Debug_Combat_ZapTime
    /// </summary>
    public unsafe float Debug_Combat_ZapTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 228); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 228); }
    }

    /// <summary>
    /// FloatProperty: Debug_Combat_LaseredTime
    /// </summary>
    public unsafe float Debug_Combat_LaseredTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 232); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 232); }
    }

    /// <summary>
    /// IntProperty: Debug_Combat_OverrideChapter
    /// </summary>
    public unsafe int Debug_Combat_OverrideChapter
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 236); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 236); }
    }

    /// <summary>
    /// ArrayProperty: Debug_Combat_Sets
    /// </summary>
    public unsafe BmSDK.TArray<NEED_UPDATE_ARRAYPROPERTY_LAYOUT> Debug_Combat_Sets
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<NEED_UPDATE_ARRAYPROPERTY_LAYOUT>>(Ptr + 240); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 240); }
    }

    /// <summary>
    /// IntProperty: Debug_Sniper_ViewConeDisplayRange
    /// </summary>
    public unsafe int Debug_Sniper_ViewConeDisplayRange
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 256); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 256); }
    }

    /// <summary>
    /// FloatProperty: Debug_Sniper_ViewConeFOV
    /// </summary>
    public unsafe float Debug_Sniper_ViewConeFOV
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 260); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 260); }
    }

    /// <summary>
    /// FloatProperty: Debug_Sniper_ViewConeVertMulti
    /// </summary>
    public unsafe float Debug_Sniper_ViewConeVertMulti
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 264); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 264); }
    }

    /// <summary>
    /// IntProperty: Debug_Player_CheatTakedownIndex
    /// </summary>
    public unsafe int Debug_Player_CheatTakedownIndex
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 268); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 268); }
    }

    /// <summary>
    /// FloatProperty: Debug_Player_ScanForBombThugsRange
    /// </summary>
    public unsafe float Debug_Player_ScanForBombThugsRange
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 272); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 272); }
    }

    /// <summary>
    /// FloatProperty: Debug_Player_ScanForBombThugsCosAngle
    /// </summary>
    public unsafe float Debug_Player_ScanForBombThugsCosAngle
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 276); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 276); }
    }

    /// <summary>
    /// IntProperty: Debug_Navigation_ShowShortenHistory
    /// </summary>
    public unsafe int Debug_Navigation_ShowShortenHistory
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 280); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 280); }
    }

    /// <summary>
    /// IntProperty: Debug_Navigation_ShowEdgeHistory
    /// </summary>
    public unsafe int Debug_Navigation_ShowEdgeHistory
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 284); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 284); }
    }

    /// <summary>
    /// ByteProperty: Debug_AI_PhysWalkingType
    /// </summary>
    public unsafe byte Debug_AI_PhysWalkingType
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 288); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 288); }
    }

    /// <summary>
    /// FloatProperty: MaxGrenadeXYSpeed
    /// </summary>
    public unsafe float MaxGrenadeXYSpeed
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 292); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 292); }
    }

    /// <summary>
    /// FloatProperty: MaxGrenadeOverallSpeed
    /// </summary>
    public unsafe float MaxGrenadeOverallSpeed
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 296); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 296); }
    }

    /// <summary>
    /// StructProperty: GrenTraceExtent
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT GrenTraceExtent
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 300); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 300); }
    }

    /// <summary>
    /// IntProperty: Debug_PickupLabelsRange
    /// </summary>
    public unsafe int Debug_PickupLabelsRange
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 312); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 312); }
    }

    /// <summary>
    /// StructProperty: Debug_Anim_Player
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT Debug_Anim_Player
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 316); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 316); }
    }

    /// <summary>
    /// StructProperty: Debug_Anim_Npc
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT Debug_Anim_Npc
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 364); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 364); }
    }

    /// <summary>
    /// StructProperty: Debug_Anim_Vehicle
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT Debug_Anim_Vehicle
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 412); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 412); }
    }

    /// <summary>
    /// StructProperty: Debug_Anim_Batmobile
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT Debug_Anim_Batmobile
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 416); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 416); }
    }

    /// <summary>
    /// StructProperty: Debug_Anim_Cinematic
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT Debug_Anim_Cinematic
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 420); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 420); }
    }

    /// <summary>
    /// FloatProperty: GroupSplitBranchTooCloseDist
    /// </summary>
    public unsafe float GroupSplitBranchTooCloseDist
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 424); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 424); }
    }

    /// <summary>
    /// FloatProperty: Debug_Destructibles_BatclawDamageAmount
    /// </summary>
    public unsafe float Debug_Destructibles_BatclawDamageAmount
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 428); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 428); }
    }

    /// <summary>
    /// ArrayProperty: Debug_MostWantedData
    /// </summary>
    public unsafe NEED_UPDATE_ARRAYPROPERTY_LAYOUT Debug_MostWantedData
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_ARRAYPROPERTY_LAYOUT>(Ptr + 432); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 432); }
    }

    /// <summary>
    /// StructProperty: Debug_BackscreenDebugData
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT Debug_BackscreenDebugData
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 448); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 448); }
    }
}
