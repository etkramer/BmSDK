#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Class: WorldInfo<br/>
/// (size = 0)
/// (flags = 0)
/// </summary>
public partial class WorldInfo : BmSDK.Engine.ZoneInfo, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Engine.WorldInfo", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal WorldInfo() { }

    /// <summary>
    /// Constructs a new WorldInfo
    /// </summary>
    public WorldInfo(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, WorldInfo Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected WorldInfo(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="Engine.Actor.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<WorldInfo>
        => ((Engine.Actor)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="Engine.Actor.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<WorldInfo>, new()
        => (TComponent)((Engine.Actor)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="Engine.Actor.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<WorldInfo>
        => ((Engine.Actor)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="Engine.Actor.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<WorldInfo>
        => ((Engine.Actor)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="Engine.Actor.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<WorldInfo>
        => (TComponent)((Engine.Actor)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="Engine.Actor.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<WorldInfo>
        => ((Engine.Actor)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="Engine.Actor.DetachScriptComponent(Type)"/>
    public void DetachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<WorldInfo>
        => ((Engine.Actor)this).DetachScriptComponent(typeof(TComponent));

    /// <summary>
    /// StructProperty: DefaultPostProcessSettings
    /// </summary>
    public unsafe BmSDK.Engine.WorldInfo.MyMapInfo DefaultPostProcessSettings
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.WorldInfo.MyMapInfo>(Ptr + 688); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 688); }
    }

    /// <summary>
    /// ObjectProperty: WorldPostProcessChain
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT WorldPostProcessChain
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 1212); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1212); }
    }

    /// <summary>
    /// ObjectProperty: HighestPriorityPostProcessVolume
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT HighestPriorityPostProcessVolume
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 1220); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1220); }
    }

    /// <summary>
    /// ObjectProperty: ForcedActivePostProcessVolume
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT ForcedActivePostProcessVolume
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 1228); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1228); }
    }

    /// <summary>
    /// ObjectProperty: BookMarks
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT BookMarks_0
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 1236); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1236); }
    }
    /// <summary>
    /// ObjectProperty: BookMarks
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT BookMarks_1
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 1244); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1244); }
    }
    /// <summary>
    /// ObjectProperty: BookMarks
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT BookMarks_2
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 1252); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1252); }
    }
    /// <summary>
    /// ObjectProperty: BookMarks
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT BookMarks_3
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 1260); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1260); }
    }
    /// <summary>
    /// ObjectProperty: BookMarks
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT BookMarks_4
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 1268); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1268); }
    }
    /// <summary>
    /// ObjectProperty: BookMarks
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT BookMarks_5
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 1276); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1276); }
    }
    /// <summary>
    /// ObjectProperty: BookMarks
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT BookMarks_6
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 1284); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1284); }
    }
    /// <summary>
    /// ObjectProperty: BookMarks
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT BookMarks_7
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 1292); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1292); }
    }
    /// <summary>
    /// ObjectProperty: BookMarks
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT BookMarks_8
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 1300); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1300); }
    }
    /// <summary>
    /// ObjectProperty: BookMarks
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT BookMarks_9
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 1308); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1308); }
    }

    /// <summary>
    /// ObjectProperty: KismetBookMarks
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT KismetBookMarks_0
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 1316); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1316); }
    }
    /// <summary>
    /// ObjectProperty: KismetBookMarks
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT KismetBookMarks_1
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 1324); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1324); }
    }
    /// <summary>
    /// ObjectProperty: KismetBookMarks
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT KismetBookMarks_2
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 1332); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1332); }
    }
    /// <summary>
    /// ObjectProperty: KismetBookMarks
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT KismetBookMarks_3
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 1340); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1340); }
    }
    /// <summary>
    /// ObjectProperty: KismetBookMarks
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT KismetBookMarks_4
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 1348); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1348); }
    }
    /// <summary>
    /// ObjectProperty: KismetBookMarks
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT KismetBookMarks_5
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 1356); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1356); }
    }
    /// <summary>
    /// ObjectProperty: KismetBookMarks
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT KismetBookMarks_6
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 1364); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1364); }
    }
    /// <summary>
    /// ObjectProperty: KismetBookMarks
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT KismetBookMarks_7
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 1372); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1372); }
    }
    /// <summary>
    /// ObjectProperty: KismetBookMarks
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT KismetBookMarks_8
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 1380); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1380); }
    }
    /// <summary>
    /// ObjectProperty: KismetBookMarks
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT KismetBookMarks_9
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 1388); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1388); }
    }

    /// <summary>
    /// ObjectProperty: Pauser
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT Pauser
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 1396); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1396); }
    }

    /// <summary>
    /// ObjectProperty: DefaultTexture
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT DefaultTexture
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 1404); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1404); }
    }

    /// <summary>
    /// ObjectProperty: WireframeTexture
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT WireframeTexture
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 1412); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1412); }
    }

    /// <summary>
    /// ObjectProperty: WhiteSquareTexture
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT WhiteSquareTexture
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 1420); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1420); }
    }

    /// <summary>
    /// ObjectProperty: LargeVertex
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT LargeVertex
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 1428); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1428); }
    }

    /// <summary>
    /// ObjectProperty: BSPVertex
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT BSPVertex
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 1436); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1436); }
    }

    /// <summary>
    /// ObjectProperty: GRI
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT GRI
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 1444); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1444); }
    }

    /// <summary>
    /// ObjectProperty: Game
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT Game
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 1452); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1452); }
    }

    /// <summary>
    /// ObjectProperty: NavigationPointList
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT NavigationPointList
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 1460); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1460); }
    }

    /// <summary>
    /// ObjectProperty: ControllerList
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT ControllerList
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 1468); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1468); }
    }

    /// <summary>
    /// ObjectProperty: PawnList
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT PawnList
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 1476); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1476); }
    }

    /// <summary>
    /// ObjectProperty: CoverList
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT CoverList
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 1484); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1484); }
    }

    /// <summary>
    /// ObjectProperty: PylonList
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT PylonList
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 1492); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1492); }
    }

    /// <summary>
    /// ObjectProperty: PersistentMapForcedObjects
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT PersistentMapForcedObjects
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 1500); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1500); }
    }

    /// <summary>
    /// ObjectProperty: MyMapInfo
    /// </summary>
    public unsafe BmSDK.Engine.WorldInfo.MassiveLODOverrideVolumes MyMapInfo
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.WorldInfo.MassiveLODOverrideVolumes>(Ptr + 1508); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1508); }
    }

    /// <summary>
    /// ObjectProperty: OceanRef
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT OceanRef
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 1516); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1516); }
    }

    /// <summary>
    /// ObjectProperty: MyEmitterPool
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT MyEmitterPool
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 1524); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1524); }
    }

    /// <summary>
    /// ObjectProperty: MyDecalManager
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT MyDecalManager
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 1532); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1532); }
    }

    /// <summary>
    /// ObjectProperty: MyFractureManager
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT MyFractureManager
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 1540); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1540); }
    }

    /// <summary>
    /// ObjectProperty: MyParticleEventManager
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT MyParticleEventManager
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 1548); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1548); }
    }

    /// <summary>
    /// ObjectProperty: EmitterVertical
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT EmitterVertical
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 1556); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1556); }
    }

    /// <summary>
    /// ObjectProperty: ImageReflectionEnvironmentTexture
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT ImageReflectionEnvironmentTexture
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 1564); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1564); }
    }

    /// <summary>
    /// ObjectProperty: FirstPhysicsVolume
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT FirstPhysicsVolume
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 1572); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1572); }
    }

    /// <summary>
    /// ComponentProperty: InteractionManager
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT InteractionManager
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 1580); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1580); }
    }

    /// <summary>
    /// ClassProperty: GameTypeForPIE
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT GameTypeForPIE
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 1588); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1588); }
    }

    /// <summary>
    /// ClassProperty: DefaultGameType
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT DefaultGameType
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 1596); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1596); }
    }

    /// <summary>
    /// BoolProperty: bPersistPostProcessToNextLevel
    /// </summary>
    public unsafe bool bPersistPostProcessToNextLevel
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1604) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1604); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1604); }
    }

    /// <summary>
    /// BoolProperty: bMapNeedsLightingFullyRebuilt
    /// </summary>
    public unsafe bool bMapNeedsLightingFullyRebuilt
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1604) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1604); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1604); }
    }

    /// <summary>
    /// BoolProperty: bMapHasMultipleDominantLightsAffectingOnePrimitive
    /// </summary>
    public unsafe bool bMapHasMultipleDominantLightsAffectingOnePrimitive
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1604) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1604); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1604); }
    }

    /// <summary>
    /// BoolProperty: bMapHasPathingErrors
    /// </summary>
    public unsafe bool bMapHasPathingErrors
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1604) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1604); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1604); }
    }

    /// <summary>
    /// BoolProperty: bRequestedBlockOnAsyncLoading
    /// </summary>
    public unsafe bool bRequestedBlockOnAsyncLoading
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1604) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1604); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1604); }
    }

    /// <summary>
    /// BoolProperty: bRequestedBlockOnAddToWorldOnlyDuringAsyncLoading
    /// </summary>
    public unsafe bool bRequestedBlockOnAddToWorldOnlyDuringAsyncLoading
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1604) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1604); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1604); }
    }

    /// <summary>
    /// BoolProperty: bBegunPlay
    /// </summary>
    public unsafe bool bBegunPlay
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1604) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1604); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1604); }
    }

    /// <summary>
    /// BoolProperty: bPlayersOnly
    /// </summary>
    public unsafe bool bPlayersOnly
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1604) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1604); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1604); }
    }

    /// <summary>
    /// BoolProperty: bPlayersOnlyPending
    /// </summary>
    public unsafe bool bPlayersOnlyPending
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1604) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1604); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1604); }
    }

    /// <summary>
    /// BoolProperty: bSuspendAI
    /// </summary>
    public unsafe bool bSuspendAI
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1604) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1604); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1604); }
    }

    /// <summary>
    /// BoolProperty: bDropDetail
    /// </summary>
    public unsafe bool bDropDetail
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1604) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1604); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1604); }
    }

    /// <summary>
    /// BoolProperty: bAggressiveLOD
    /// </summary>
    public unsafe bool bAggressiveLOD
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1604) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1604); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1604); }
    }

    /// <summary>
    /// BoolProperty: bStartup
    /// </summary>
    public unsafe bool bStartup
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1604) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1604); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1604); }
    }

    /// <summary>
    /// BoolProperty: bPathsRebuilt
    /// </summary>
    public unsafe bool bPathsRebuilt
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1604) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1604); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1604); }
    }

    /// <summary>
    /// BoolProperty: bHasPathNodes
    /// </summary>
    public unsafe bool bHasPathNodes
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1604) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1604); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1604); }
    }

    /// <summary>
    /// BoolProperty: bIsMenuLevel
    /// </summary>
    public unsafe bool bIsMenuLevel
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1604) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1604); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1604); }
    }

    /// <summary>
    /// BoolProperty: bDebugPauseExecution
    /// </summary>
    public unsafe bool bDebugPauseExecution
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1604) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1604); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1604); }
    }

    /// <summary>
    /// BoolProperty: bDebugStepExecution
    /// </summary>
    public unsafe bool bDebugStepExecution
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1604) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1604); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1604); }
    }

    /// <summary>
    /// BoolProperty: bUseConsoleInput
    /// </summary>
    public unsafe bool bUseConsoleInput
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1604) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1604); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1604); }
    }

    /// <summary>
    /// BoolProperty: bMinimizeBSPSections
    /// </summary>
    public unsafe bool bMinimizeBSPSections
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1604) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1604); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1604); }
    }

    /// <summary>
    /// BoolProperty: bNoDefaultInventoryForPlayer
    /// </summary>
    public unsafe bool bNoDefaultInventoryForPlayer
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1604) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1604); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1604); }
    }

    /// <summary>
    /// BoolProperty: bNoPathWarnings
    /// </summary>
    public unsafe bool bNoPathWarnings
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1604) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1604); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1604); }
    }

    /// <summary>
    /// BoolProperty: bNoMobileMapWarnings
    /// </summary>
    public unsafe bool bNoMobileMapWarnings
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1604) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1604); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1604); }
    }

    /// <summary>
    /// BoolProperty: bHighPriorityLoading
    /// </summary>
    public unsafe bool bHighPriorityLoading
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1604) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1604); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1604); }
    }

    /// <summary>
    /// BoolProperty: bHighPriorityLoadingLocal
    /// </summary>
    public unsafe bool bHighPriorityLoadingLocal
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1604) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1604); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1604); }
    }

    /// <summary>
    /// BoolProperty: DebugMenuWantsPause
    /// </summary>
    public unsafe bool DebugMenuWantsPause
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1604) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1604); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1604); }
    }

    /// <summary>
    /// BoolProperty: bSupportDoubleBufferedPhysics
    /// </summary>
    public unsafe bool bSupportDoubleBufferedPhysics
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1604) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1604); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1604); }
    }

    /// <summary>
    /// BoolProperty: bPhysicsIgnoreDeltaTime
    /// </summary>
    public unsafe bool bPhysicsIgnoreDeltaTime
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1604) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1604); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1604); }
    }

    /// <summary>
    /// BoolProperty: bEnableChanceOfPhysicsChunkOverride
    /// </summary>
    public unsafe bool bEnableChanceOfPhysicsChunkOverride
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1604) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1604); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1604); }
    }

    /// <summary>
    /// BoolProperty: bLimitExplosionChunkSize
    /// </summary>
    public unsafe bool bLimitExplosionChunkSize
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1604) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1604); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1604); }
    }

    /// <summary>
    /// BoolProperty: bLimitDamageChunkSize
    /// </summary>
    public unsafe bool bLimitDamageChunkSize
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1604) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1604); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1604); }
    }

    /// <summary>
    /// BoolProperty: bPrecomputeVisibility
    /// </summary>
    public unsafe bool bPrecomputeVisibility
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1604) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1604); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1604); }
    }

    /// <summary>
    /// BoolProperty: bIgnoreUmbraVersioning
    /// </summary>
    public unsafe bool bIgnoreUmbraVersioning
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1608) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1608); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1608); }
    }

    /// <summary>
    /// BoolProperty: bPlaceCellsOnSurfaces
    /// </summary>
    public unsafe bool bPlaceCellsOnSurfaces
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1608) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1608); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1608); }
    }

    /// <summary>
    /// BoolProperty: bUseUnreal
    /// </summary>
    public unsafe bool bUseUnreal
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1608) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1608); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1608); }
    }

    /// <summary>
    /// BoolProperty: bUseUmbra
    /// </summary>
    public unsafe bool bUseUmbra
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1608) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1608); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1608); }
    }

    /// <summary>
    /// BoolProperty: bReassignAllUmbraIds
    /// </summary>
    public unsafe bool bReassignAllUmbraIds
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1608) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1608); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1608); }
    }

    /// <summary>
    /// BoolProperty: bUmbraBuildStreamingData
    /// </summary>
    public unsafe bool bUmbraBuildStreamingData
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1608) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1608); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1608); }
    }

    /// <summary>
    /// BoolProperty: bAllowTemporalAA
    /// </summary>
    public unsafe bool bAllowTemporalAA
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1608) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1608); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1608); }
    }

    /// <summary>
    /// BoolProperty: bUseGlobalIllumination
    /// </summary>
    public unsafe bool bUseGlobalIllumination
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1608) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1608); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1608); }
    }

    /// <summary>
    /// BoolProperty: bForceNoPrecomputedLighting
    /// </summary>
    public unsafe bool bForceNoPrecomputedLighting
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1608) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1608); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1608); }
    }

    /// <summary>
    /// BoolProperty: bHaveActiveCrowd
    /// </summary>
    public unsafe bool bHaveActiveCrowd
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1608) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1608); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1608); }
    }

    /// <summary>
    /// BoolProperty: bMapAudioMode
    /// </summary>
    public unsafe bool bMapAudioMode
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1608) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1608); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1608); }
    }

    /// <summary>
    /// BoolProperty: bAllowHostMigration
    /// </summary>
    public unsafe bool bAllowHostMigration
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1608) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1608); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1608); }
    }

    /// <summary>
    /// BoolProperty: bGameplayFramePause
    /// </summary>
    public unsafe bool bGameplayFramePause
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1608) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1608); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1608); }
    }

    /// <summary>
    /// FloatProperty: StreamingTimePerFrame
    /// </summary>
    public unsafe float StreamingTimePerFrame
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1612); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1612); }
    }

    /// <summary>
    /// ArrayProperty: MassiveLODOverrideVolumes
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.FString>>>>> MassiveLODOverrideVolumes
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.FString>>>>>>(Ptr + 1616); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1616); }
    }

    /// <summary>
    /// ArrayProperty: PortalVolumes
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.FString>>>> PortalVolumes
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.FString>>>>>(Ptr + 1632); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1632); }
    }

    /// <summary>
    /// ArrayProperty: EnvironmentVolumes
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.FString>>> EnvironmentVolumes
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.FString>>>>(Ptr + 1648); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1648); }
    }

    /// <summary>
    /// ArrayProperty: StreamingLevels
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.TArray<BmSDK.FString>> StreamingLevels
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.TArray<BmSDK.FString>>>(Ptr + 1664); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1664); }
    }

    /// <summary>
    /// StructProperty: LastTimeUnbuiltLightingWasEncountered
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT LastTimeUnbuiltLightingWasEncountered
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 1680); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1680); }
    }

    /// <summary>
    /// ArrayProperty: ClipPadEntries
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.FString> ClipPadEntries
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.FString>>(Ptr + 1688); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1688); }
    }

    /// <summary>
    /// FloatProperty: TimeDilation
    /// </summary>
    public unsafe float TimeDilation
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1704); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1704); }
    }

    /// <summary>
    /// FloatProperty: NextTickTimeDilation
    /// </summary>
    public unsafe float NextTickTimeDilation
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1708); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1708); }
    }

    /// <summary>
    /// FloatProperty: DemoPlayTimeDilation
    /// </summary>
    public unsafe float DemoPlayTimeDilation
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1712); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1712); }
    }

    /// <summary>
    /// FloatProperty: TimeSeconds
    /// </summary>
    public unsafe float TimeSeconds
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1716); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1716); }
    }

    /// <summary>
    /// FloatProperty: RealTimeSeconds
    /// </summary>
    public unsafe float RealTimeSeconds
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1720); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1720); }
    }

    /// <summary>
    /// FloatProperty: AudioTimeSeconds
    /// </summary>
    public unsafe float AudioTimeSeconds
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1724); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1724); }
    }

    /// <summary>
    /// FloatProperty: DeltaSeconds
    /// </summary>
    public unsafe float DeltaSeconds
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1728); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1728); }
    }

    /// <summary>
    /// FloatProperty: PauseDelay
    /// </summary>
    public unsafe float PauseDelay
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1732); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1732); }
    }

    /// <summary>
    /// FloatProperty: RealTimeToUnPause
    /// </summary>
    public unsafe float RealTimeToUnPause
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1736); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1736); }
    }

    /// <summary>
    /// FloatProperty: SubtitleTimeSeconds
    /// </summary>
    public unsafe float SubtitleTimeSeconds
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1740); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1740); }
    }

    /// <summary>
    /// StrProperty: VisibleGroups
    /// </summary>
    public unsafe BmSDK.FString VisibleGroups
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 1744); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1744); }
    }

    /// <summary>
    /// StrProperty: VisibleLayers
    /// </summary>
    public unsafe BmSDK.FString VisibleLayers
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 1760); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1760); }
    }

    /// <summary>
    /// ArrayProperty: DeferredExecs
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.FString> DeferredExecs
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.FString>>(Ptr + 1776); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1776); }
    }

    /// <summary>
    /// ByteProperty: NetMode
    /// </summary>
    public unsafe byte NetMode
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 1792); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1792); }
    }

    /// <summary>
    /// ByteProperty: NextTravelType
    /// </summary>
    public unsafe byte NextTravelType
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 1793); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1793); }
    }

    /// <summary>
    /// ByteProperty: SetInPIEPreset
    /// </summary>
    public unsafe byte SetInPIEPreset
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 1794); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1794); }
    }

    /// <summary>
    /// ByteProperty: VisibilityAggressiveness
    /// </summary>
    public unsafe byte VisibilityAggressiveness
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 1795); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1795); }
    }

    /// <summary>
    /// ByteProperty: PreferredLightmapType
    /// </summary>
    public unsafe byte PreferredLightmapType
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 1796); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1796); }
    }

    /// <summary>
    /// ByteProperty: LevelLightingQuality
    /// </summary>
    public unsafe byte LevelLightingQuality
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 1797); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1797); }
    }

    /// <summary>
    /// ByteProperty: DebugDrawDestructiblesMode
    /// </summary>
    public unsafe byte DebugDrawDestructiblesMode
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 1798); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1798); }
    }

    /// <summary>
    /// ByteProperty: OverrideDepthPriority
    /// </summary>
    public unsafe byte OverrideDepthPriority
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 1799); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1799); }
    }

    /// <summary>
    /// StrProperty: ComputerName
    /// </summary>
    public unsafe BmSDK.FString ComputerName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 1800); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1800); }
    }

    /// <summary>
    /// StrProperty: EngineVersion
    /// </summary>
    public unsafe BmSDK.FString EngineVersion
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 1816); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1816); }
    }

    /// <summary>
    /// StrProperty: MinNetVersion
    /// </summary>
    public unsafe BmSDK.FString MinNetVersion
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 1832); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1832); }
    }

    /// <summary>
    /// FloatProperty: StallZ
    /// </summary>
    public unsafe float StallZ
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1848); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1848); }
    }

    /// <summary>
    /// FloatProperty: WorldGravityZ
    /// </summary>
    public unsafe float WorldGravityZ
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1852); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1852); }
    }

    /// <summary>
    /// FloatProperty: DefaultGravityZ
    /// </summary>
    public unsafe float DefaultGravityZ
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1856); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1856); }
    }

    /// <summary>
    /// FloatProperty: GlobalGravityZ
    /// </summary>
    public unsafe float GlobalGravityZ
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1860); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1860); }
    }

    /// <summary>
    /// FloatProperty: RBPhysicsGravityScaling
    /// </summary>
    public unsafe float RBPhysicsGravityScaling
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1864); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1864); }
    }

    /// <summary>
    /// FloatProperty: MoveRepSize
    /// </summary>
    public unsafe float MoveRepSize
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1868); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1868); }
    }

    /// <summary>
    /// ArrayProperty: ReplicationViewers
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.FString> ReplicationViewers
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.FString>>(Ptr + 1872); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1872); }
    }

    /// <summary>
    /// StrProperty: NextURL
    /// </summary>
    public unsafe BmSDK.FString NextURL
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 1888); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1888); }
    }

    /// <summary>
    /// FloatProperty: NextSwitchCountdown
    /// </summary>
    public unsafe float NextSwitchCountdown
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1904); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1904); }
    }

    /// <summary>
    /// IntProperty: PackedLightAndShadowMapTextureSize
    /// </summary>
    public unsafe int PackedLightAndShadowMapTextureSize
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1908); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1908); }
    }

    /// <summary>
    /// StructProperty: DefaultColorScale
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT DefaultColorScale
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 1912); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1912); }
    }

    /// <summary>
    /// ArrayProperty: GameTypesSupportedOnThisMap
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.FString>>> GameTypesSupportedOnThisMap
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.FString>>>>(Ptr + 1924); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1924); }
    }

    /// <summary>
    /// ArrayProperty: ClientDestroyedActorContent
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.TArray<BmSDK.FString>> ClientDestroyedActorContent
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.TArray<BmSDK.FString>>>(Ptr + 1940); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1940); }
    }

    /// <summary>
    /// ArrayProperty: PreparingLevelNames
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.FString> PreparingLevelNames
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.FString>>(Ptr + 1956); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1956); }
    }

    /// <summary>
    /// NameProperty: CommittedPersistentLevelName
    /// </summary>
    public unsafe BmSDK.FName CommittedPersistentLevelName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 1972); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1972); }
    }

    /// <summary>
    /// StrProperty: Title
    /// </summary>
    public unsafe BmSDK.FString Title
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 1980); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1980); }
    }

    /// <summary>
    /// ArrayProperty: ParticleAttractorComponents
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.FString>>>>> ParticleAttractorComponents
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.FString>>>>>>(Ptr + 1996); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1996); }
    }

    /// <summary>
    /// ArrayProperty: WeatherVolumes
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.FString>>>> WeatherVolumes
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.FString>>>>>(Ptr + 2012); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2012); }
    }

    /// <summary>
    /// ArrayProperty: RainBlockers
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.FString>>> RainBlockers
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.FString>>>>(Ptr + 2028); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2028); }
    }

    /// <summary>
    /// ArrayProperty: OceanHeightBlockers
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.TArray<BmSDK.FString>> OceanHeightBlockers
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.TArray<BmSDK.FString>>>(Ptr + 2044); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2044); }
    }

    /// <summary>
    /// ArrayProperty: SetInPIEPresets
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.FString> SetInPIEPresets
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.FString>>(Ptr + 2060); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2060); }
    }

    /// <summary>
    /// StrProperty: SetFlagsInPIE
    /// </summary>
    public unsafe BmSDK.FString SetFlagsInPIE
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 2076); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2076); }
    }

    /// <summary>
    /// StrProperty: SetChaptersInPIE
    /// </summary>
    public unsafe BmSDK.FString SetChaptersInPIE
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 2092); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2092); }
    }

    /// <summary>
    /// NameProperty: StartPointInPIE
    /// </summary>
    public unsafe BmSDK.FName StartPointInPIE
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 2108); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2108); }
    }

    /// <summary>
    /// NameProperty: PlayerCharacterName
    /// </summary>
    public unsafe BmSDK.FName PlayerCharacterName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 2116); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2116); }
    }

    /// <summary>
    /// StrProperty: EmitterPoolClassPath
    /// </summary>
    public unsafe BmSDK.FString EmitterPoolClassPath
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 2124); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2124); }
    }

    /// <summary>
    /// StrProperty: DecalManagerClassPath
    /// </summary>
    public unsafe BmSDK.FString DecalManagerClassPath
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 2140); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2140); }
    }

    /// <summary>
    /// StrProperty: FractureManagerClassPath
    /// </summary>
    public unsafe BmSDK.FString FractureManagerClassPath
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 2156); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2156); }
    }

    /// <summary>
    /// StrProperty: ParticleEventManagerClassPath
    /// </summary>
    public unsafe BmSDK.FString ParticleEventManagerClassPath
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 2172); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2172); }
    }

    /// <summary>
    /// FloatProperty: MaxPhysicsDeltaTime
    /// </summary>
    public unsafe float MaxPhysicsDeltaTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2188); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2188); }
    }

    /// <summary>
    /// IntProperty: MaxPhysicsSubsteps
    /// </summary>
    public unsafe int MaxPhysicsSubsteps
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2192); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2192); }
    }

    /// <summary>
    /// StructProperty: PhysicsProperties
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT PhysicsProperties
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 2196); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2196); }
    }

    /// <summary>
    /// ArrayProperty: CompartmentRunFrames
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.Engine.WorldInfo.DebugDrawDestructiblesStrings> CompartmentRunFrames
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.WorldInfo.DebugDrawDestructiblesStrings>>(Ptr + 2276); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2276); }
    }

    /// <summary>
    /// FloatProperty: DefaultSkinWidth
    /// </summary>
    public unsafe float DefaultSkinWidth
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2292); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2292); }
    }

    /// <summary>
    /// FloatProperty: ApexLODResourceBudget
    /// </summary>
    public unsafe float ApexLODResourceBudget
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2296); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2296); }
    }

    /// <summary>
    /// FloatProperty: ApexDestructionLODResourceValue
    /// </summary>
    public unsafe float ApexDestructionLODResourceValue
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2300); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2300); }
    }

    /// <summary>
    /// FloatProperty: ApexClothingLODResourceValue
    /// </summary>
    public unsafe float ApexClothingLODResourceValue
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2304); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2304); }
    }

    /// <summary>
    /// StructProperty: DestructibleSettings
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT DestructibleSettings
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 2308); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2308); }
    }

    /// <summary>
    /// StructProperty: VerticalProperties
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT VerticalProperties
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 2328); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2328); }
    }

    /// <summary>
    /// ArrayProperty: WorldAttractors
    /// </summary>
    public unsafe NEED_UPDATE_ARRAYPROPERTY_LAYOUT WorldAttractors
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_ARRAYPROPERTY_LAYOUT>(Ptr + 2352); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2352); }
    }

    /// <summary>
    /// FloatProperty: ChanceOfPhysicsChunkOverride
    /// </summary>
    public unsafe float ChanceOfPhysicsChunkOverride
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2368); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2368); }
    }

    /// <summary>
    /// FloatProperty: MaxExplosionChunkSize
    /// </summary>
    public unsafe float MaxExplosionChunkSize
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2372); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2372); }
    }

    /// <summary>
    /// FloatProperty: MaxDamageChunkSize
    /// </summary>
    public unsafe float MaxDamageChunkSize
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2376); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2376); }
    }

    /// <summary>
    /// FloatProperty: FractureExplosionVelScale
    /// </summary>
    public unsafe float FractureExplosionVelScale
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2380); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2380); }
    }

    /// <summary>
    /// IntProperty: MaxNumFacturedChunksToSpawnInAFrame
    /// </summary>
    public unsafe int MaxNumFacturedChunksToSpawnInAFrame
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2384); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2384); }
    }

    /// <summary>
    /// IntProperty: NumFacturedChunksSpawnedThisFrame
    /// </summary>
    public unsafe int NumFacturedChunksSpawnedThisFrame
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2388); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2388); }
    }

    /// <summary>
    /// FloatProperty: FracturedMeshWeaponDamage
    /// </summary>
    public unsafe float FracturedMeshWeaponDamage
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2392); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2392); }
    }

    /// <summary>
    /// IntProperty: VisibilityCellSize
    /// </summary>
    public unsafe int VisibilityCellSize
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2396); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2396); }
    }

    /// <summary>
    /// IntProperty: UmbraSmallestHole
    /// </summary>
    public unsafe int UmbraSmallestHole
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2400); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2400); }
    }

    /// <summary>
    /// IntProperty: UmbraBackfaceLimit
    /// </summary>
    public unsafe int UmbraBackfaceLimit
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2404); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2404); }
    }

    /// <summary>
    /// IntProperty: UmbraIdPrefix
    /// </summary>
    public unsafe int UmbraIdPrefix
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2408); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2408); }
    }

    /// <summary>
    /// IntProperty: NextUmbraId
    /// </summary>
    public unsafe int NextUmbraId
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2412); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2412); }
    }

    /// <summary>
    /// IntProperty: UmbraIdRenumberingVersion
    /// </summary>
    public unsafe int UmbraIdRenumberingVersion
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2416); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2416); }
    }

    /// <summary>
    /// FloatProperty: CharacterLitIndirectBrightness
    /// </summary>
    public unsafe float CharacterLitIndirectBrightness
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2420); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2420); }
    }

    /// <summary>
    /// FloatProperty: CharacterLitIndirectContrastFactor
    /// </summary>
    public unsafe float CharacterLitIndirectContrastFactor
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2424); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2424); }
    }

    /// <summary>
    /// FloatProperty: CharacterShadowedIndirectBrightness
    /// </summary>
    public unsafe float CharacterShadowedIndirectBrightness
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2428); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2428); }
    }

    /// <summary>
    /// FloatProperty: CharacterShadowedIndirectContrastFactor
    /// </summary>
    public unsafe float CharacterShadowedIndirectContrastFactor
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2432); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2432); }
    }

    /// <summary>
    /// FloatProperty: CharacterLightingContrastFactor
    /// </summary>
    public unsafe float CharacterLightingContrastFactor
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2436); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2436); }
    }

    /// <summary>
    /// StructProperty: ImageReflectionEnvironmentColor
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT ImageReflectionEnvironmentColor
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 2440); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2440); }
    }

    /// <summary>
    /// FloatProperty: ImageReflectionEnvironmentRotation
    /// </summary>
    public unsafe float ImageReflectionEnvironmentRotation
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2456); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2456); }
    }

    /// <summary>
    /// StructProperty: ScreenMessages
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT ScreenMessages
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 2460); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2460); }
    }

    /// <summary>
    /// ArrayProperty: PriorityScreenMessages
    /// </summary>
    public unsafe NEED_UPDATE_ARRAYPROPERTY_LAYOUT PriorityScreenMessages
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_ARRAYPROPERTY_LAYOUT>(Ptr + 2532); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2532); }
    }

    /// <summary>
    /// IntProperty: MaxTrianglesPerLeaf
    /// </summary>
    public unsafe int MaxTrianglesPerLeaf
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2548); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2548); }
    }

    /// <summary>
    /// StructProperty: PlayerLocation
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT PlayerLocation
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 2552); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2552); }
    }

    /// <summary>
    /// MapProperty: LandscapeInfoMap
    /// </summary>
    public unsafe BmSDK.TMap<object, object> /* TODO */ LandscapeInfoMap
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TMap<object, object> /* TODO */>(Ptr + 2564); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2564); }
    }

    /// <summary>
    /// StructProperty: LightmassSettings
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT LightmassSettings
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 2636); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2636); }
    }

    /// <summary>
    /// MapProperty: NavMeshPathConstraintCache
    /// </summary>
    public unsafe BmSDK.TMap<object, object> /* TODO */ NavMeshPathConstraintCache
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TMap<object, object> /* TODO */>(Ptr + 2724); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2724); }
    }

    /// <summary>
    /// MapProperty: NavMeshPathGoalEvaluatorCache
    /// </summary>
    public unsafe BmSDK.TMap<object, object> /* TODO */ NavMeshPathGoalEvaluatorCache
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TMap<object, object> /* TODO */>(Ptr + 2796); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2796); }
    }

    /// <summary>
    /// StructProperty: PeerHostMigration
    /// </summary>
    public unsafe BmSDK.Engine.WorldInfo.DebugDrawDestructiblesStrings PeerHostMigration
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.WorldInfo.DebugDrawDestructiblesStrings>(Ptr + 2868); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2868); }
    }

    /// <summary>
    /// FloatProperty: HostMigrationTimeout
    /// </summary>
    public unsafe float HostMigrationTimeout
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2900); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2900); }
    }

    /// <summary>
    /// FloatProperty: DebrisMaxHeightAboveGroundWhenSettled
    /// </summary>
    public unsafe float DebrisMaxHeightAboveGroundWhenSettled
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2904); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2904); }
    }

    /// <summary>
    /// ArrayProperty: DebugDrawDestructiblesStrings
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.Engine.Actor.Timers>>>>> DebugDrawDestructiblesStrings
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.Engine.Actor.Timers>>>>>>(Ptr + 2908); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2908); }
    }

    /// <summary>
    /// FloatProperty: DebugDrawDestructiblesDistance
    /// </summary>
    public unsafe float DebugDrawDestructiblesDistance
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2924); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2924); }
    }

    /// <summary>
    /// ArrayProperty: VisibleDestructibleArchetypes
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.Engine.Actor.Timers>>>> VisibleDestructibleArchetypes
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.Engine.Actor.Timers>>>>>(Ptr + 2928); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2928); }
    }

    /// <summary>
    /// ArrayProperty: VisibleDestructibleArchetypeColors
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.Engine.Actor.Timers>>> VisibleDestructibleArchetypeColors
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.Engine.Actor.Timers>>>>(Ptr + 2944); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2944); }
    }

}
