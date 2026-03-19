#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Class: NavigationPoint<br/>
/// (size = 0)
/// (flags = 0)
/// </summary>
public partial class NavigationPoint : BmSDK.Engine.Actor, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Engine.NavigationPoint", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal NavigationPoint() { }

    /// <summary>
    /// Constructs a new NavigationPoint
    /// </summary>
    public NavigationPoint(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, NavigationPoint Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected NavigationPoint(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="Engine.Actor.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<NavigationPoint>
        => ((Engine.Actor)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="Engine.Actor.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<NavigationPoint>, new()
        => (TComponent)((Engine.Actor)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="Engine.Actor.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<NavigationPoint>
        => ((Engine.Actor)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="Engine.Actor.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<NavigationPoint>
        => ((Engine.Actor)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="Engine.Actor.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<NavigationPoint>
        => (TComponent)((Engine.Actor)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="Engine.Actor.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<NavigationPoint>
        => ((Engine.Actor)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="Engine.Actor.DetachScriptComponent(Type)"/>
    public void DetachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<NavigationPoint>
        => ((Engine.Actor)this).DetachScriptComponent(typeof(TComponent));

    /// <summary>
    /// BoolProperty: bEndPoint
    /// </summary>
    public unsafe bool bEndPoint
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 668) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 668); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 668); }
    }

    /// <summary>
    /// BoolProperty: bTransientEndPoint
    /// </summary>
    public unsafe bool bTransientEndPoint
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 668) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 668); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 668); }
    }

    /// <summary>
    /// BoolProperty: bHideEditorPaths
    /// </summary>
    public unsafe bool bHideEditorPaths
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 668) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 668); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 668); }
    }

    /// <summary>
    /// BoolProperty: bCanReach
    /// </summary>
    public unsafe bool bCanReach
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 668) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 668); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 668); }
    }

    /// <summary>
    /// BoolProperty: bBlocked
    /// </summary>
    public unsafe bool bBlocked
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 668) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 668); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 668); }
    }

    /// <summary>
    /// BoolProperty: bOneWayPath
    /// </summary>
    public unsafe bool bOneWayPath
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 668) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 668); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 668); }
    }

    /// <summary>
    /// BoolProperty: bNeverUseStrafing
    /// </summary>
    public unsafe bool bNeverUseStrafing
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 668) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 668); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 668); }
    }

    /// <summary>
    /// BoolProperty: bForceNoStrafing
    /// </summary>
    public unsafe bool bForceNoStrafing
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 668) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 668); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 668); }
    }

    /// <summary>
    /// BoolProperty: bAutoBuilt
    /// </summary>
    public unsafe bool bAutoBuilt
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 668) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 668); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 668); }
    }

    /// <summary>
    /// BoolProperty: bSpecialMove
    /// </summary>
    public unsafe bool bSpecialMove
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 668) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 668); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 668); }
    }

    /// <summary>
    /// BoolProperty: bNoAutoConnect
    /// </summary>
    public unsafe bool bNoAutoConnect
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 668) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 668); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 668); }
    }

    /// <summary>
    /// BoolProperty: bNotBased
    /// </summary>
    public unsafe bool bNotBased
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 668) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 668); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 668); }
    }

    /// <summary>
    /// BoolProperty: bPathsChanged
    /// </summary>
    public unsafe bool bPathsChanged
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 668) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 668); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 668); }
    }

    /// <summary>
    /// BoolProperty: bDestinationOnly
    /// </summary>
    public unsafe bool bDestinationOnly
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 668) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 668); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 668); }
    }

    /// <summary>
    /// BoolProperty: bSourceOnly
    /// </summary>
    public unsafe bool bSourceOnly
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 668) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 668); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 668); }
    }

    /// <summary>
    /// BoolProperty: bSpecialForced
    /// </summary>
    public unsafe bool bSpecialForced
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 668) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 668); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 668); }
    }

    /// <summary>
    /// BoolProperty: bMustBeReachable
    /// </summary>
    public unsafe bool bMustBeReachable
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 668) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 668); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 668); }
    }

    /// <summary>
    /// BoolProperty: bBlockable
    /// </summary>
    public unsafe bool bBlockable
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 668) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 668); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 668); }
    }

    /// <summary>
    /// BoolProperty: bFlyingPreferred
    /// </summary>
    public unsafe bool bFlyingPreferred
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 668) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 668); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 668); }
    }

    /// <summary>
    /// BoolProperty: bMayCausePain
    /// </summary>
    public unsafe bool bMayCausePain
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 668) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 668); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 668); }
    }

    /// <summary>
    /// BoolProperty: bAlreadyVisited
    /// </summary>
    public unsafe bool bAlreadyVisited
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 668) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 668); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 668); }
    }

    /// <summary>
    /// BoolProperty: bVehicleDestination
    /// </summary>
    public unsafe bool bVehicleDestination
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 668) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 668); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 668); }
    }

    /// <summary>
    /// BoolProperty: bMakeSourceOnly
    /// </summary>
    public unsafe bool bMakeSourceOnly
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 668) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 668); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 668); }
    }

    /// <summary>
    /// BoolProperty: bMustTouchToReach
    /// </summary>
    public unsafe bool bMustTouchToReach
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 668) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 668); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 668); }
    }

    /// <summary>
    /// BoolProperty: bCanWalkOnToReach
    /// </summary>
    public unsafe bool bCanWalkOnToReach
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 668) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 668); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 668); }
    }

    /// <summary>
    /// BoolProperty: bBuildLongPaths
    /// </summary>
    public unsafe bool bBuildLongPaths
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 668) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 668); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 668); }
    }

    /// <summary>
    /// BoolProperty: bBlockedForVehicles
    /// </summary>
    public unsafe bool bBlockedForVehicles
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 668) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 668); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 668); }
    }

    /// <summary>
    /// BoolProperty: bPreferredVehiclePath
    /// </summary>
    public unsafe bool bPreferredVehiclePath
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 668) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 668); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 668); }
    }

    /// <summary>
    /// BoolProperty: bHasCrossLevelPaths
    /// </summary>
    public unsafe bool bHasCrossLevelPaths
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 668) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 668); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 668); }
    }

    /// <summary>
    /// BoolProperty: bSkipPathBuilding
    /// </summary>
    public unsafe bool bSkipPathBuilding
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 668) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 668); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 668); }
    }

    /// <summary>
    /// StructProperty: NavOctreeObject
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT NavOctreeObject
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 672); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 672); }
    }

    /// <summary>
    /// ArrayProperty: PathList
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.Engine.Actor.Timers>>>>>>> PathList
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.Engine.Actor.Timers>>>>>>>>(Ptr + 732); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 732); }
    }

    /// <summary>
    /// ArrayProperty: EditorProscribedPaths
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.Engine.Actor.Timers>>>>>> EditorProscribedPaths
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.Engine.Actor.Timers>>>>>>>(Ptr + 748); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 748); }
    }

    /// <summary>
    /// ArrayProperty: EditorForcedPaths
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.Engine.Actor.Timers>>>>> EditorForcedPaths
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.Engine.Actor.Timers>>>>>>(Ptr + 764); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 764); }
    }

    /// <summary>
    /// ArrayProperty: Volumes
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.Engine.Actor.Timers>>>> Volumes
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.Engine.Actor.Timers>>>>>(Ptr + 780); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 780); }
    }

    /// <summary>
    /// IntProperty: visitedWeight
    /// </summary>
    public unsafe int visitedWeight
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 796); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 796); }
    }

    /// <summary>
    /// IntProperty: bestPathWeight
    /// </summary>
    public unsafe int bestPathWeight
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 800); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 800); }
    }

    /// <summary>
    /// ObjectProperty: nextNavigationPoint
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT nextNavigationPoint
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 804); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 804); }
    }

    /// <summary>
    /// ObjectProperty: nextOrdered
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT nextOrdered
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 812); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 812); }
    }

    /// <summary>
    /// ObjectProperty: prevOrdered
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT prevOrdered
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 820); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 820); }
    }

    /// <summary>
    /// ObjectProperty: previousPath
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT previousPath
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 828); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 828); }
    }

    /// <summary>
    /// ObjectProperty: InventoryCache
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT InventoryCache
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 836); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 836); }
    }

    /// <summary>
    /// ObjectProperty: AnchoredPawn
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT AnchoredPawn
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 844); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 844); }
    }

    /// <summary>
    /// ComponentProperty: BadSprite
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT BadSprite
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 852); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 852); }
    }

    /// <summary>
    /// ComponentProperty: GoodSprite
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT GoodSprite
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 860); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 860); }
    }

    /// <summary>
    /// ComponentProperty: CylinderComponent
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT CylinderComponent
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 868); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 868); }
    }

    /// <summary>
    /// IntProperty: Cost
    /// </summary>
    public unsafe int Cost
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 876); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 876); }
    }

    /// <summary>
    /// IntProperty: ExtraCost
    /// </summary>
    public unsafe int ExtraCost
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 880); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 880); }
    }

    /// <summary>
    /// IntProperty: TransientCost
    /// </summary>
    public unsafe int TransientCost
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 884); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 884); }
    }

    /// <summary>
    /// ArrayProperty: CostArray
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.Engine.Actor.Timers>>> CostArray
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.Engine.Actor.Timers>>>>(Ptr + 888); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 888); }
    }

    /// <summary>
    /// FloatProperty: InventoryDist
    /// </summary>
    public unsafe float InventoryDist
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 904); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 904); }
    }

    /// <summary>
    /// FloatProperty: LastDetourWeight
    /// </summary>
    public unsafe float LastDetourWeight
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 908); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 908); }
    }

    /// <summary>
    /// StructProperty: MaxPathSize
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT MaxPathSize
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 912); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 912); }
    }

    /// <summary>
    /// StructProperty: NavGuid
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT NavGuid
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 920); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 920); }
    }

    /// <summary>
    /// IntProperty: NetworkID
    /// </summary>
    public unsafe int NetworkID
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 936); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 936); }
    }

    /// <summary>
    /// FloatProperty: LastAnchoredPawnTime
    /// </summary>
    public unsafe float LastAnchoredPawnTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 940); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 940); }
    }

}
