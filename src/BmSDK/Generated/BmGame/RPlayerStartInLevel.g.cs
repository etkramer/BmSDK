#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RPlayerStartInLevel<br/>
/// (size = 0)
/// (flags = 0)
/// </summary>
public partial class RPlayerStartInLevel : BmSDK.Engine.PlayerStart, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RPlayerStartInLevel", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RPlayerStartInLevel() { }

    /// <summary>
    /// Constructs a new RPlayerStartInLevel
    /// </summary>
    public RPlayerStartInLevel(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RPlayerStartInLevel Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RPlayerStartInLevel(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="Engine.Actor.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RPlayerStartInLevel>
        => ((Engine.Actor)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="Engine.Actor.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RPlayerStartInLevel>, new()
        => (TComponent)((Engine.Actor)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="Engine.Actor.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RPlayerStartInLevel>
        => ((Engine.Actor)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="Engine.Actor.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RPlayerStartInLevel>
        => ((Engine.Actor)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="Engine.Actor.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RPlayerStartInLevel>
        => (TComponent)((Engine.Actor)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="Engine.Actor.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RPlayerStartInLevel>
        => ((Engine.Actor)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="Engine.Actor.DetachScriptComponent(Type)"/>
    public void DetachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RPlayerStartInLevel>
        => ((Engine.Actor)this).DetachScriptComponent(typeof(TComponent));

    /// <summary>
    /// NameProperty: Level
    /// </summary>
    public unsafe BmSDK.FName Level
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 960); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 960); }
    }

    /// <summary>
    /// ArrayProperty: AdditionalStreamingLevels
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.Engine.NavigationPoint.PathList>>>> AdditionalStreamingLevels
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.Engine.NavigationPoint.PathList>>>>>(Ptr + 968); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 968); }
    }

    /// <summary>
    /// ArrayProperty: AdditionalStreamingLODLevels
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.Engine.NavigationPoint.PathList>>> AdditionalStreamingLODLevels
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.Engine.NavigationPoint.PathList>>>>(Ptr + 984); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 984); }
    }

    /// <summary>
    /// ArrayProperty: AdditionalStreamingLevelRequiredInstallChunks
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.TArray<BmSDK.Engine.NavigationPoint.PathList>> AdditionalStreamingLevelRequiredInstallChunks
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.TArray<BmSDK.Engine.NavigationPoint.PathList>>>(Ptr + 1000); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1000); }
    }

    /// <summary>
    /// ArrayProperty: AdditionalStreamingLODLevelRequiredInstallChunks
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.Engine.NavigationPoint.PathList> AdditionalStreamingLODLevelRequiredInstallChunks
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.NavigationPoint.PathList>>(Ptr + 1016); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1016); }
    }

    /// <summary>
    /// BoolProperty: bSaveWhenTeleportedTo
    /// </summary>
    public unsafe bool bSaveWhenTeleportedTo
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1032) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1032); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1032); }
    }

    /// <summary>
    /// BoolProperty: bOnlySaveOnce
    /// </summary>
    public unsafe bool bOnlySaveOnce
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1032) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1032); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1032); }
    }

    /// <summary>
    /// BoolProperty: bReshowCurrentObjectiveOnLoad
    /// </summary>
    public unsafe bool bReshowCurrentObjectiveOnLoad
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1032) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1032); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1032); }
    }

    /// <summary>
    /// BoolProperty: bStartCrouched
    /// </summary>
    public unsafe bool bStartCrouched
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1032) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1032); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1032); }
    }

    /// <summary>
    /// BoolProperty: bUsableForAutoSaving
    /// </summary>
    public unsafe bool bUsableForAutoSaving
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1032) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1032); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1032); }
    }

    /// <summary>
    /// BoolProperty: bFlushTextureStreaming
    /// </summary>
    public unsafe bool bFlushTextureStreaming
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1032) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1032); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1032); }
    }

    /// <summary>
    /// BoolProperty: bWasInsideBox
    /// </summary>
    public unsafe bool bWasInsideBox
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1032) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1032); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1032); }
    }

    /// <summary>
    /// BoolProperty: bStreamingInLevel
    /// </summary>
    public unsafe bool bStreamingInLevel
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1032) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1032); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1032); }
    }

    /// <summary>
    /// BoolProperty: bEnableCheckpointSystem
    /// </summary>
    public unsafe bool bEnableCheckpointSystem
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1032) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1032); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1032); }
    }

    /// <summary>
    /// BoolProperty: bForceDisableCheckpointSystem
    /// </summary>
    public unsafe bool bForceDisableCheckpointSystem
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1032) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1032); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1032); }
    }

    /// <summary>
    /// BoolProperty: bAllowTickIsDisabled
    /// </summary>
    public unsafe bool bAllowTickIsDisabled
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1032) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1032); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1032); }
    }

    /// <summary>
    /// BoolProperty: bStartInBatmobile
    /// </summary>
    public unsafe bool bStartInBatmobile
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1032) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1032); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1032); }
    }

    /// <summary>
    /// BoolProperty: bStartInBatmobileFakeRemoteDrive
    /// </summary>
    public unsafe bool bStartInBatmobileFakeRemoteDrive
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1032) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1032); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1032); }
    }

    /// <summary>
    /// BoolProperty: bForceStartOutOfBatmobile
    /// </summary>
    public unsafe bool bForceStartOutOfBatmobile
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1032) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1032); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1032); }
    }

    /// <summary>
    /// BoolProperty: bChallengeStartPoint
    /// </summary>
    public unsafe bool bChallengeStartPoint
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1032) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1032); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1032); }
    }

    /// <summary>
    /// FloatProperty: CheckpointWidth
    /// </summary>
    public unsafe float CheckpointWidth
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1036); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1036); }
    }

    /// <summary>
    /// FloatProperty: CheckpointLength
    /// </summary>
    public unsafe float CheckpointLength
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1040); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1040); }
    }

    /// <summary>
    /// StructProperty: CheckpointSaveGameDescription
    /// </summary>
    public unsafe BmSDK.Engine.NavigationPoint.PathList CheckpointSaveGameDescription
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.NavigationPoint.PathList>(Ptr + 1044); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1044); }
    }

    /// <summary>
    /// FloatProperty: LastCheckpointTime
    /// </summary>
    public unsafe float LastCheckpointTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1080); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1080); }
    }

    /// <summary>
    /// ObjectProperty: BatmobileStartLocation
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT BatmobileStartLocation
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 1084); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1084); }
    }
}
