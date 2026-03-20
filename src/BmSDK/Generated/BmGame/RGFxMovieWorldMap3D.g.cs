#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RGFxMovieWorldMap3D<br/>
/// (flags = 0)
/// </summary>
public partial class RGFxMovieWorldMap3D : BmSDK.BmGame.RGFxMovieWorldBase, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RGFxMovieWorldMap3D", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RGFxMovieWorldMap3D() { }

    /// <summary>
    /// Constructs a new RGFxMovieWorldMap3D
    /// </summary>
    public RGFxMovieWorldMap3D(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RGFxMovieWorldMap3D Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RGFxMovieWorldMap3D(nint ptr) : base(ptr) { }

    /// <summary>
    /// StructProperty: BaseLocation
    /// </summary>
    public unsafe System.Numerics.Vector3 BaseLocation
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 696); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 696); }
    }

    /// <summary>
    /// StructProperty: Offset
    /// </summary>
    public unsafe System.Numerics.Vector3 Offset
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 708); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 708); }
    }

    /// <summary>
    /// ObjectProperty: RGI
    /// </summary>
    public unsafe BmSDK.BmGame.RGameInfo RGI
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RGameInfo>(Ptr + 720); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 720); }
    }

    /// <summary>
    /// ObjectProperty: GRI
    /// </summary>
    public unsafe BmSDK.BmGame.RGameRI GRI
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RGameRI>(Ptr + 728); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 728); }
    }

    /// <summary>
    /// ObjectProperty: pData
    /// </summary>
    public unsafe BmSDK.BmGame.RPersistentData pData
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPersistentData>(Ptr + 736); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 736); }
    }

    /// <summary>
    /// ObjectProperty: PDD
    /// </summary>
    public unsafe BmSDK.BmGame.RPersistentDebugData PDD
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPersistentDebugData>(Ptr + 744); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 744); }
    }

    /// <summary>
    /// IntProperty: SelectedIconIndex
    /// </summary>
    public unsafe int SelectedIconIndex
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 752); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 752); }
    }

    /// <summary>
    /// StrProperty: RemapIconType
    /// </summary>
    public unsafe BmSDK.FString RemapIconType
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 756); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 756); }
    }

    /// <summary>
    /// StrProperty: RemapIconName
    /// </summary>
    public unsafe BmSDK.FString RemapIconName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 772); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 772); }
    }

    /// <summary>
    /// ArrayProperty: Icon_TypeName
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.FString> Icon_TypeName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.FString>>(Ptr + 788); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 788); }
    }

    /// <summary>
    /// ArrayProperty: Icon_InstanceName
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.FString> Icon_InstanceName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.FString>>(Ptr + 804); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 804); }
    }

    /// <summary>
    /// ArrayProperty: Icon_X
    /// </summary>
    public unsafe BmSDK.TArray<int> Icon_X
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<int>>(Ptr + 820); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 820); }
    }

    /// <summary>
    /// ArrayProperty: Icon_Y
    /// </summary>
    public unsafe BmSDK.TArray<int> Icon_Y
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<int>>(Ptr + 836); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 836); }
    }

    /// <summary>
    /// ArrayProperty: Icon_Z
    /// </summary>
    public unsafe BmSDK.TArray<int> Icon_Z
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<int>>(Ptr + 852); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 852); }
    }

    /// <summary>
    /// ArrayProperty: Icon_ZBase
    /// </summary>
    public unsafe BmSDK.TArray<int> Icon_ZBase
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<int>>(Ptr + 868); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 868); }
    }

    /// <summary>
    /// ArrayProperty: Icon_Rotation
    /// </summary>
    public unsafe BmSDK.TArray<int> Icon_Rotation
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<int>>(Ptr + 884); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 884); }
    }

    /// <summary>
    /// ArrayProperty: Icon_GroupRange
    /// </summary>
    public unsafe BmSDK.TArray<int> Icon_GroupRange
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<int>>(Ptr + 900); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 900); }
    }

    /// <summary>
    /// ArrayProperty: Icon_GroupArea
    /// </summary>
    public unsafe BmSDK.TArray<int> Icon_GroupArea
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<int>>(Ptr + 916); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 916); }
    }

    /// <summary>
    /// ArrayProperty: Icon_Flags
    /// </summary>
    public unsafe BmSDK.TArray<int> Icon_Flags
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<int>>(Ptr + 932); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 932); }
    }

    /// <summary>
    /// ArrayProperty: Icon_CustomFlags
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.FString> Icon_CustomFlags
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.FString>>(Ptr + 948); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 948); }
    }

    /// <summary>
    /// ArrayProperty: Icon_Clipping
    /// </summary>
    public unsafe BmSDK.TArray<int> Icon_Clipping
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<int>>(Ptr + 964); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 964); }
    }

    /// <summary>
    /// ArrayProperty: Icon_Scale
    /// </summary>
    public unsafe BmSDK.TArray<float> Icon_Scale
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<float>>(Ptr + 980); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 980); }
    }

    /// <summary>
    /// ArrayProperty: Icon_Filter
    /// </summary>
    public unsafe BmSDK.TArray<int> Icon_Filter
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<int>>(Ptr + 996); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 996); }
    }

    /// <summary>
    /// ArrayProperty: MapObjIndexList
    /// </summary>
    public unsafe BmSDK.TArray<int> MapObjIndexList
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<int>>(Ptr + 1012); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1012); }
    }

    /// <summary>
    /// ArrayProperty: RemapListItem
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.FString> RemapListItem
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.FString>>(Ptr + 1028); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1028); }
    }

    /// <summary>
    /// ArrayProperty: RemapListItemOther
    /// </summary>
    public unsafe BmSDK.TArray<int> RemapListItemOther
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<int>>(Ptr + 1044); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1044); }
    }

    /// <summary>
    /// IntProperty: FilterMask
    /// </summary>
    public unsafe int FilterMask
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1060); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1060); }
    }

    /// <summary>
    /// IntProperty: ActiveFilter
    /// </summary>
    public unsafe int ActiveFilter
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1064); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1064); }
    }

    /// <summary>
    /// StructProperty: StatNavStart
    /// </summary>
    public unsafe System.Numerics.Vector3 StatNavStart
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 1068); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1068); }
    }

    /// <summary>
    /// StructProperty: StatNavEnd
    /// </summary>
    public unsafe System.Numerics.Vector3 StatNavEnd
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 1080); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1080); }
    }

    /// <summary>
    /// ArrayProperty: SatNavRoute
    /// </summary>
    public unsafe BmSDK.TArray<int> SatNavRoute
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<int>>(Ptr + 1092); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1092); }
    }

    /// <summary>
    /// IntProperty: SatNavRouteStartPoint
    /// </summary>
    public unsafe int SatNavRouteStartPoint
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1108); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1108); }
    }

    /// <summary>
    /// BoolProperty: bMapMoving
    /// </summary>
    public unsafe bool bMapMoving
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1112) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1112); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1112); }
    }

    /// <summary>
    /// BoolProperty: bMapSelectionDisabled
    /// </summary>
    public unsafe bool bMapSelectionDisabled
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1112) & 2) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1112); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1112); }
    }

    /// <summary>
    /// BoolProperty: bLockedInBatmobile
    /// </summary>
    public unsafe bool bLockedInBatmobile
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1112) & 4) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1112); var newMask = value ? (currentMask | 4) : (currentMask & ~4); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1112); }
    }

    /// <summary>
    /// BoolProperty: bSideStoriesDisabled
    /// </summary>
    public unsafe bool bSideStoriesDisabled
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1112) & 8) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1112); var newMask = value ? (currentMask | 8) : (currentMask & ~8); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1112); }
    }

    /// <summary>
    /// BoolProperty: bGasActive
    /// </summary>
    public unsafe bool bGasActive
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1112) & 16) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1112); var newMask = value ? (currentMask | 16) : (currentMask & ~16); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1112); }
    }

    /// <summary>
    /// BoolProperty: bGCPDAssualt
    /// </summary>
    public unsafe bool bGCPDAssualt
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1112) & 32) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1112); var newMask = value ? (currentMask | 32) : (currentMask & ~32); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1112); }
    }

    /// <summary>
    /// BoolProperty: bMissionBundleInstalled
    /// </summary>
    public unsafe bool bMissionBundleInstalled
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1112) & 64) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1112); var newMask = value ? (currentMask | 64) : (currentMask & ~64); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1112); }
    }

    /// <summary>
    /// StrProperty: ActiveMissionName
    /// </summary>
    public unsafe BmSDK.FString ActiveMissionName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 1116); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1116); }
    }

    /// <summary>
    /// FloatProperty: CameraRotation
    /// </summary>
    public unsafe float CameraRotation
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1132); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1132); }
    }

    /// <summary>
    /// FloatProperty: CameraX
    /// </summary>
    public unsafe float CameraX
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1136); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1136); }
    }

    /// <summary>
    /// FloatProperty: CameraY
    /// </summary>
    public unsafe float CameraY
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1140); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1140); }
    }

    /// <summary>
    /// FloatProperty: CameraZ
    /// </summary>
    public unsafe float CameraZ
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1144); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1144); }
    }
}
