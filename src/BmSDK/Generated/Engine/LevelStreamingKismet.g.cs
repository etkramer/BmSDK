#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Class: LevelStreamingKismet<br/>
/// (size = 0)
/// (flags = 0)
/// </summary>
public partial class LevelStreamingKismet : BmSDK.Engine.LevelStreaming, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Engine.LevelStreamingKismet", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal LevelStreamingKismet() { }

    /// <summary>
    /// Constructs a new LevelStreamingKismet
    /// </summary>
    public LevelStreamingKismet(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, LevelStreamingKismet Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected LevelStreamingKismet(nint ptr) : base(ptr) { }

    /// <summary>
    /// NameProperty: PackageName
    /// </summary>
    public unsafe BmSDK.FName PackageName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 84); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 84); }
    }

    /// <summary>
    /// StrProperty: PackageNameAsString
    /// </summary>
    public unsafe BmSDK.FString PackageNameAsString
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 92); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 92); }
    }

    /// <summary>
    /// ObjectProperty: LoadedLevel
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT LoadedLevel
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 108); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 108); }
    }

    /// <summary>
    /// ObjectProperty: EditorGridVolume
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT EditorGridVolume
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 116); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 116); }
    }

    /// <summary>
    /// StructProperty: Offset
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT Offset
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 124); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 124); }
    }

    /// <summary>
    /// StructProperty: LevelTransform
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT LevelTransform
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 144); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 144); }
    }

    /// <summary>
    /// StructProperty: OldOffset
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT OldOffset
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 208); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 208); }
    }

    /// <summary>
    /// BoolProperty: bIsVisible
    /// </summary>
    public unsafe bool bIsVisible
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 220) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 220); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 220); }
    }

    /// <summary>
    /// BoolProperty: bIsLevelHidden
    /// </summary>
    public unsafe bool bIsLevelHidden
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 220) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 220); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 220); }
    }

    /// <summary>
    /// BoolProperty: bHasLoadRequestPending
    /// </summary>
    public unsafe bool bHasLoadRequestPending
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 220) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 220); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 220); }
    }

    /// <summary>
    /// BoolProperty: bHasUnloadRequestPending
    /// </summary>
    public unsafe bool bHasUnloadRequestPending
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 220) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 220); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 220); }
    }

    /// <summary>
    /// BoolProperty: bRemoveFromStreamingLevelsWhenUnloaded
    /// </summary>
    public unsafe bool bRemoveFromStreamingLevelsWhenUnloaded
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 220) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 220); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 220); }
    }

    /// <summary>
    /// BoolProperty: bShouldBeVisibleInEditor
    /// </summary>
    public unsafe bool bShouldBeVisibleInEditor
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 220) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 220); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 220); }
    }

    /// <summary>
    /// BoolProperty: bBoundingBoxVisible
    /// </summary>
    public unsafe bool bBoundingBoxVisible
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 220) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 220); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 220); }
    }

    /// <summary>
    /// BoolProperty: bLocked
    /// </summary>
    public unsafe bool bLocked
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 220) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 220); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 220); }
    }

    /// <summary>
    /// BoolProperty: bIsFullyStatic
    /// </summary>
    public unsafe bool bIsFullyStatic
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 220) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 220); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 220); }
    }

    /// <summary>
    /// BoolProperty: bShouldBeLoaded
    /// </summary>
    public unsafe bool bShouldBeLoaded
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 220) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 220); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 220); }
    }

    /// <summary>
    /// BoolProperty: bShouldBeVisible
    /// </summary>
    public unsafe bool bShouldBeVisible
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 220) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 220); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 220); }
    }

    /// <summary>
    /// BoolProperty: bShouldBeLevelHidden
    /// </summary>
    public unsafe bool bShouldBeLevelHidden
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 220) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 220); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 220); }
    }

    /// <summary>
    /// BoolProperty: bShouldBlockOnLoad
    /// </summary>
    public unsafe bool bShouldBlockOnLoad
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 220) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 220); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 220); }
    }

    /// <summary>
    /// BoolProperty: bShouldBeVisibleInLevelBrowser
    /// </summary>
    public unsafe bool bShouldBeVisibleInLevelBrowser
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 220) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 220); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 220); }
    }

    /// <summary>
    /// BoolProperty: bExpandedInLevelBrowser
    /// </summary>
    public unsafe bool bExpandedInLevelBrowser
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 220) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 220); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 220); }
    }

    /// <summary>
    /// BoolProperty: bIsParent
    /// </summary>
    public unsafe bool bIsParent
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 220) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 220); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 220); }
    }

    /// <summary>
    /// BoolProperty: bIsChild
    /// </summary>
    public unsafe bool bIsChild
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 220) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 220); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 220); }
    }

    /// <summary>
    /// BoolProperty: bDrawOnLevelStatusMap
    /// </summary>
    public unsafe bool bDrawOnLevelStatusMap
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 220) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 220); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 220); }
    }

    /// <summary>
    /// BoolProperty: bIsRequestingUnloadAndRemoval
    /// </summary>
    public unsafe bool bIsRequestingUnloadAndRemoval
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 220) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 220); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 220); }
    }

    /// <summary>
    /// BoolProperty: bForceNotToRemoveLevel
    /// </summary>
    public unsafe bool bForceNotToRemoveLevel
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 220) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 220); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 220); }
    }

    /// <summary>
    /// BoolProperty: bExcludeFromPathBuilding
    /// </summary>
    public unsafe bool bExcludeFromPathBuilding
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 220) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 220); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 220); }
    }

    /// <summary>
    /// BoolProperty: bExcludeFromPathBuilding_Old_bShouldBeVisibleInEditor
    /// </summary>
    public unsafe bool bExcludeFromPathBuilding_Old_bShouldBeVisibleInEditor
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 220) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 220); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 220); }
    }

    /// <summary>
    /// BoolProperty: bHighPriorityLoadRequest
    /// </summary>
    public unsafe bool bHighPriorityLoadRequest
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 220) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 220); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 220); }
    }

    /// <summary>
    /// BoolProperty: bIsDelayedLoadLevel
    /// </summary>
    public unsafe bool bIsDelayedLoadLevel
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 220) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 220); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 220); }
    }

    /// <summary>
    /// BoolProperty: bUseAllReflectionGroupsAfterCurrent
    /// </summary>
    public unsafe bool bUseAllReflectionGroupsAfterCurrent
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 220) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 220); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 220); }
    }

    /// <summary>
    /// StructProperty: DrawColor
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT DrawColor
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 224); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 224); }
    }

    /// <summary>
    /// ArrayProperty: EditorStreamingVolumes
    /// </summary>
    public unsafe BmSDK.TArray<NEED_UPDATE_ARRAYPROPERTY_LAYOUT> EditorStreamingVolumes
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<NEED_UPDATE_ARRAYPROPERTY_LAYOUT>>(Ptr + 228); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 228); }
    }

    /// <summary>
    /// FloatProperty: MinTimeBetweenVolumeUnloadRequests
    /// </summary>
    public unsafe float MinTimeBetweenVolumeUnloadRequests
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 244); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 244); }
    }

    /// <summary>
    /// FloatProperty: LastVolumeUnloadRequestTime
    /// </summary>
    public unsafe float LastVolumeUnloadRequestTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 248); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 248); }
    }

    /// <summary>
    /// ByteProperty: OverrideDepthPriority
    /// </summary>
    public unsafe byte OverrideDepthPriority
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 252); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 252); }
    }

    /// <summary>
    /// ByteProperty: NavMeshGroup
    /// </summary>
    public unsafe byte NavMeshGroup
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 253); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 253); }
    }

    /// <summary>
    /// ByteProperty: ReflectionGroup
    /// </summary>
    public unsafe byte ReflectionGroup
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 254); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 254); }
    }

    /// <summary>
    /// ArrayProperty: Keywords
    /// </summary>
    public unsafe NEED_UPDATE_ARRAYPROPERTY_LAYOUT Keywords
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_ARRAYPROPERTY_LAYOUT>(Ptr + 256); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 256); }
    }

    /// <summary>
    /// IntProperty: GridPosition
    /// </summary>
    public unsafe int GridPosition_0
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 272); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 272); }
    }
    /// <summary>
    /// IntProperty: GridPosition
    /// </summary>
    public unsafe int GridPosition_1
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 276); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 276); }
    }
    /// <summary>
    /// IntProperty: GridPosition
    /// </summary>
    public unsafe int GridPosition_2
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 280); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 280); }
    }
}
