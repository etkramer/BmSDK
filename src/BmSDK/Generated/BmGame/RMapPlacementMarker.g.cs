#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RMapPlacementMarker<br/>
/// (flags = 0)
/// </summary>
public partial class RMapPlacementMarker : BmSDK.Engine.Actor, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RMapPlacementMarker", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RMapPlacementMarker() { }

    /// <summary>
    /// Constructs a new RMapPlacementMarker
    /// </summary>
    public RMapPlacementMarker(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RMapPlacementMarker Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RMapPlacementMarker(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="Engine.Actor.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RMapPlacementMarker>
        => ((Engine.Actor)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="Engine.Actor.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RMapPlacementMarker>, new()
        => (TComponent)((Engine.Actor)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="Engine.Actor.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RMapPlacementMarker>
        => ((Engine.Actor)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="Engine.Actor.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RMapPlacementMarker>
        => ((Engine.Actor)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="Engine.Actor.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RMapPlacementMarker>
        => (TComponent)((Engine.Actor)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="Engine.Actor.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RMapPlacementMarker>
        => ((Engine.Actor)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="Engine.Actor.DetachScriptComponent(Type)"/>
    public void DetachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RMapPlacementMarker>
        => ((Engine.Actor)this).DetachScriptComponent(typeof(TComponent));

    /// <summary>
    /// ByteProperty: MarkerType
    /// </summary>
    public unsafe BmSDK.BmGame.RMapPlacementMarker.MapMarkerType MarkerType
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RMapPlacementMarker.MapMarkerType>(Ptr + 668); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 668); }
    }

    /// <summary>
    /// ByteProperty: Zone
    /// </summary>
    public unsafe BmSDK.BmGame.RGameInfo.ERiddlerLocationName Zone
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RGameInfo.ERiddlerLocationName>(Ptr + 669); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 669); }
    }

    /// <summary>
    /// ByteProperty: LabelType
    /// </summary>
    public unsafe BmSDK.BmGame.RMapPlacementMarker.MapLabelType LabelType
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RMapPlacementMarker.MapLabelType>(Ptr + 670); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 670); }
    }

    /// <summary>
    /// ByteProperty: GroupingArea
    /// </summary>
    public unsafe BmSDK.BmGame.RMapPlacementMarker.MapGroupArea GroupingArea
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RMapPlacementMarker.MapGroupArea>(Ptr + 671); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 671); }
    }

    /// <summary>
    /// ByteProperty: GroupingRange
    /// </summary>
    public unsafe BmSDK.BmGame.RMapPlacementMarker.MapGroupRange GroupingRange
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RMapPlacementMarker.MapGroupRange>(Ptr + 672); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 672); }
    }

    /// <summary>
    /// IntProperty: Index
    /// </summary>
    public unsafe int Index
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 676); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 676); }
    }

    /// <summary>
    /// StrProperty: StringName
    /// </summary>
    public unsafe BmSDK.FString StringName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 680); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 680); }
    }

    /// <summary>
    /// StrProperty: SubType
    /// </summary>
    public unsafe BmSDK.FString SubType
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 696); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 696); }
    }

    /// <summary>
    /// BoolProperty: bLabelAlwaysVisible
    /// </summary>
    public unsafe bool bLabelAlwaysVisible
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 712) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 712); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 712); }
    }

    /// <summary>
    /// BoolProperty: bLabelSupportsFlip
    /// </summary>
    public unsafe bool bLabelSupportsFlip
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 712) & 2) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 712); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 712); }
    }

    /// <summary>
    /// BoolProperty: bUseOxyFromRockHighlightVolume
    /// </summary>
    public unsafe bool bUseOxyFromRockHighlightVolume
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 712) & 4) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 712); var newMask = value ? (currentMask | 4) : (currentMask & ~4); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 712); }
    }

    /// <summary>
    /// BoolProperty: bPlaceHudTargetExactlyHere
    /// </summary>
    public unsafe bool bPlaceHudTargetExactlyHere
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 712) & 8) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 712); var newMask = value ? (currentMask | 8) : (currentMask & ~8); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 712); }
    }

    /// <summary>
    /// BoolProperty: bNoProjectedBatSignal
    /// </summary>
    public unsafe bool bNoProjectedBatSignal
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 712) & 16) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 712); var newMask = value ? (currentMask | 16) : (currentMask & ~16); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 712); }
    }

    /// <summary>
    /// BoolProperty: bShowParkingMarker
    /// </summary>
    public unsafe bool bShowParkingMarker
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 712) & 32) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 712); var newMask = value ? (currentMask | 32) : (currentMask & ~32); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 712); }
    }

    /// <summary>
    /// BoolProperty: bSatnavToRoadAtSameHeight
    /// </summary>
    public unsafe bool bSatnavToRoadAtSameHeight
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 712) & 64) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 712); var newMask = value ? (currentMask | 64) : (currentMask & ~64); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 712); }
    }

    /// <summary>
    /// BoolProperty: bSatnavAllowArmouredRoads
    /// </summary>
    public unsafe bool bSatnavAllowArmouredRoads
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 712) & 128) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 712); var newMask = value ? (currentMask | 128) : (currentMask & ~128); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 712); }
    }

    /// <summary>
    /// BoolProperty: bSatnavToRoadBelow
    /// </summary>
    public unsafe bool bSatnavToRoadBelow
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 712) & 256) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 712); var newMask = value ? (currentMask | 256) : (currentMask & ~256); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 712); }
    }

    /// <summary>
    /// IntProperty: FloatUpAdjust
    /// </summary>
    public unsafe int FloatUpAdjust
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 716); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 716); }
    }

    /// <summary>
    /// StrProperty: CustomFlags
    /// </summary>
    public unsafe BmSDK.FString CustomFlags
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 720); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 720); }
    }

    /// <summary>
    /// IntProperty: Oxy
    /// </summary>
    public unsafe int Oxy
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 736); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 736); }
    }

    /// <summary>
    /// Enum: MMTFlags
    /// </summary>
    public enum MMTFlags
    {
        MMTFlag_NoHitTest = 0,
        MMTFlag_NoProjectUp = 1,
        MMTFlag_AlwaysVisible = 2,
        MMTFlag_IsNew = 3,
        MMTFlag_NoYTargetting = 4,
        MMTFlag_PlaceHudTargetExactlyHere = 5,
        MMTFlag_LabelFlips = 6,
        MMTFlag_NoProjectedBatSignal = 7,
        MMTFlag_ShowParkingMarker = 8,
        MMTFlag_SatnavToRoadAtSameHeight = 9,
        MMTFlag_IsInFearGas = 10,
        MMTFlag_SatnavAllowArmouredRoads = 11,
        MMTFlag_SatnavToRoadBelow = 12,
        MMTFlag_RiddlerCameoNoRange = 13,
        MMTFlag_RiddlerCameoShortRange = 14,
        MMTFlag_RiddlerCameoLongRange = 15,
        MMTFlag_MAX = 16,
    }

    /// <summary>
    /// Enum: MapGroupRange
    /// </summary>
    public enum MapGroupRange
    {
        MGR_Always = 0,
        MGR_NearOnly = 1,
        MGR_MidOnly = 2,
        MGR_FarOnly = 3,
        MGR_MAX = 4,
    }

    /// <summary>
    /// Enum: MapGroupArea
    /// </summary>
    public enum MapGroupArea
    {
        MGA_Any = 0,
        MGA_CityX = 1,
        MGA_CityY = 2,
        MGA_CityZ = 3,
        MGA_MAX = 4,
    }

    /// <summary>
    /// Enum: MapLabelType
    /// </summary>
    public enum MapLabelType
    {
        MLT_BigArea = 0,
        MLT_Area = 1,
        MLT_Road = 2,
        MLT_Feature1 = 3,
        MLT_Feature2 = 4,
        MLT_MAX = 5,
    }

    /// <summary>
    /// Enum: MapMarkerType
    /// </summary>
    public enum MapMarkerType
    {
        MMT_Objective = 0,
        MMT_ObjectiveBatmobile = 1,
        MMT_CrimeScene = 2,
        MMT_Riddle = 3,
        MMT_RiddleBomb = 4,
        MMT_RiddleProjectedQ = 5,
        MMT_Cipher = 6,
        MMT_Officer = 7,
        MMT_PointOfInterest = 8,
        MMT_ARChallenge = 9,
        MMT_ThugAssult = 10,
        MMT_SecurityCamera = 11,
        MMT_SideStoryIcon = 12,
        MMT_BuildingMarker = 13,
        MMT_Label = 14,
        MMT_RiddlerRace = 15,
        MMT_MAX = 16,
    }

    /// <summary>
    /// Enum: MapFilterType
    /// </summary>
    public enum MapFilterType
    {
        MFT_None = 0,
        MFT_Main = 1,
        MFT_Secret = 2,
        MFT_Challenge = 3,
        MFT_Militia = 4,
        MFT_MAX = 5,
    }
}
