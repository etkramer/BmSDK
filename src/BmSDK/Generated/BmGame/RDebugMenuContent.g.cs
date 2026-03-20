#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RDebugMenuContent<br/>
/// (flags = 0)
/// </summary>
public partial class RDebugMenuContent : BmSDK.BmGame.RDebugMenu, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RDebugMenuContent", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RDebugMenuContent() { }

    /// <summary>
    /// Constructs a new RDebugMenuContent
    /// </summary>
    public RDebugMenuContent(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RDebugMenuContent Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RDebugMenuContent(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="Engine.Actor.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RDebugMenuContent>
        => ((Engine.Actor)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="Engine.Actor.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RDebugMenuContent>, new()
        => (TComponent)((Engine.Actor)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="Engine.Actor.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RDebugMenuContent>
        => ((Engine.Actor)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="Engine.Actor.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RDebugMenuContent>
        => ((Engine.Actor)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="Engine.Actor.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RDebugMenuContent>
        => (TComponent)((Engine.Actor)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="Engine.Actor.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RDebugMenuContent>
        => ((Engine.Actor)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="Engine.Actor.DetachScriptComponent(Type)"/>
    public void DetachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RDebugMenuContent>
        => ((Engine.Actor)this).DetachScriptComponent(typeof(TComponent));

    /// <summary>
    /// ObjectProperty: GameInfo
    /// </summary>
    public unsafe BmSDK.BmGame.RGameInfo GameInfo
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RGameInfo>(Ptr + 1052); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1052); }
    }

    /// <summary>
    /// ComponentProperty: DebrisMaxHeightStaticMeshComponent
    /// </summary>
    public unsafe BmSDK.Engine.StaticMeshComponent DebrisMaxHeightStaticMeshComponent
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.StaticMeshComponent>(Ptr + 1060); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1060); }
    }

    /// <summary>
    /// ComponentProperty: AudioComponent
    /// </summary>
    public unsafe BmSDK.Engine.AudioComponent AudioComponent
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AudioComponent>(Ptr + 1068); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1068); }
    }

    /// <summary>
    /// BoolProperty: ConsoleEventsOpen
    /// </summary>
    public unsafe bool ConsoleEventsOpen
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1076) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1076); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1076); }
    }

    /// <summary>
    /// BoolProperty: bStatUnit
    /// </summary>
    public unsafe bool bStatUnit
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1076) & 2) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1076); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1076); }
    }

    /// <summary>
    /// BoolProperty: bEnableSharedCapeOptions
    /// </summary>
    public unsafe bool bEnableSharedCapeOptions
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1076) & 4) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1076); var newMask = value ? (currentMask | 4) : (currentMask & ~4); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1076); }
    }

    /// <summary>
    /// BoolProperty: RopeOptions
    /// </summary>
    public unsafe bool RopeOptions
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1076) & 8) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1076); var newMask = value ? (currentMask | 8) : (currentMask & ~8); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1076); }
    }

    /// <summary>
    /// BoolProperty: PhysicsOptions
    /// </summary>
    public unsafe bool PhysicsOptions
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1076) & 16) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1076); var newMask = value ? (currentMask | 16) : (currentMask & ~16); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1076); }
    }

    /// <summary>
    /// BoolProperty: DepthBiasOptions
    /// </summary>
    public unsafe bool DepthBiasOptions
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1076) & 32) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1076); var newMask = value ? (currentMask | 32) : (currentMask & ~32); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1076); }
    }

    /// <summary>
    /// BoolProperty: OceanBuoyancyOptions
    /// </summary>
    public unsafe bool OceanBuoyancyOptions
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1076) & 64) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1076); var newMask = value ? (currentMask | 64) : (currentMask & ~64); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1076); }
    }

    /// <summary>
    /// BoolProperty: bDebrisMaxHeightStaticMeshComponentAttached
    /// </summary>
    public unsafe bool bDebrisMaxHeightStaticMeshComponentAttached
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1076) & 128) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1076); var newMask = value ? (currentMask | 128) : (currentMask & ~128); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1076); }
    }

    /// <summary>
    /// BoolProperty: bShowCurrentDistrictScenarios
    /// </summary>
    public unsafe bool bShowCurrentDistrictScenarios
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1076) & 256) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1076); var newMask = value ? (currentMask | 256) : (currentMask & ~256); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1076); }
    }

    /// <summary>
    /// ArrayProperty: ConsoleEvents
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.FString> ConsoleEvents
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.FString>>(Ptr + 1080); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1080); }
    }

    /// <summary>
    /// ArrayProperty: ConsoleEventDescs
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.FString> ConsoleEventDescs
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.FString>>(Ptr + 1096); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1096); }
    }

    /// <summary>
    /// IntProperty: ConsoleEventIndex
    /// </summary>
    public unsafe int ConsoleEventIndex
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1112); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1112); }
    }

    /// <summary>
    /// ArrayProperty: LevelStreamingTypes
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.FString> LevelStreamingTypes
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.FString>>(Ptr + 1116); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1116); }
    }

    /// <summary>
    /// IntProperty: AngleAudioComponent
    /// </summary>
    public unsafe int AngleAudioComponent
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1132); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1132); }
    }

    /// <summary>
    /// IntProperty: LevelStreamingOptions
    /// </summary>
    public unsafe int LevelStreamingOptions
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1136); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1136); }
    }

    /// <summary>
    /// IntProperty: CurrDebugCapeStateChangeSetting
    /// </summary>
    public unsafe int CurrDebugCapeStateChangeSetting
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1140); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1140); }
    }

    /// <summary>
    /// IntProperty: VehEncounterType
    /// </summary>
    public unsafe int VehEncounterType
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1144); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1144); }
    }

    /// <summary>
    /// IntProperty: PrevDrawDestructiblesMode
    /// </summary>
    public unsafe int PrevDrawDestructiblesMode
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1148); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1148); }
    }

    /// <summary>
    /// ArrayProperty: CachedPopulationActions
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.Engine.SequenceObject> CachedPopulationActions
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.SequenceObject>>(Ptr + 1152); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1152); }
    }

    /// <summary>
    /// ArrayProperty: PopulationTypes
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.FString> PopulationTypes
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.FString>>(Ptr + 1168); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1168); }
    }

    /// <summary>
    /// IntProperty: PopTypeIdx
    /// </summary>
    public unsafe int PopTypeIdx
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1184); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1184); }
    }

    /// <summary>
    /// FloatProperty: PopulationWarmUpTime
    /// </summary>
    public unsafe float PopulationWarmUpTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1188); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1188); }
    }
}
