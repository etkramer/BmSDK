#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RHudModuleTargets<br/>
/// (size = 0)
/// (flags = 0)
/// </summary>
public partial class RHudModuleTargets : BmSDK.BmGame.RHudModule, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RHudModuleTargets", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RHudModuleTargets() { }

    /// <summary>
    /// Constructs a new RHudModuleTargets
    /// </summary>
    public RHudModuleTargets(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RHudModuleTargets Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RHudModuleTargets(nint ptr) : base(ptr) { }

    /// <summary>
    /// ArrayProperty: ConsolidatedArray
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.FString> ConsolidatedArray
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.FString>>(Ptr + 240); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 240); }
    }

    /// <summary>
    /// ArrayProperty: ConsolidatedArrayCopy
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.FString> ConsolidatedArrayCopy
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.FString>>(Ptr + 256); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 256); }
    }

    /// <summary>
    /// IntProperty: Num_Cursors
    /// </summary>
    public unsafe int Num_Cursors
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 272); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 272); }
    }

    /// <summary>
    /// ArrayProperty: ThreeDeeTargetArray
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RHudModuleTargets.FThreeDeeTarget> ThreeDeeTargetArray
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RHudModuleTargets.FThreeDeeTarget>>(Ptr + 276); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 276); }
    }

    /// <summary>
    /// BoolProperty: SuppressMainTargetThisFrame
    /// </summary>
    public unsafe bool SuppressMainTargetThisFrame
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 292) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 292); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 292); }
    }

    /// <summary>
    /// BoolProperty: MainCursorPulsing
    /// </summary>
    public unsafe bool MainCursorPulsing
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 292) & 2) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 292); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 292); }
    }

    /// <summary>
    /// BoolProperty: BatmobileHeavyWeaponValid
    /// </summary>
    public unsafe bool BatmobileHeavyWeaponValid
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 292) & 4) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 292); var newMask = value ? (currentMask | 4) : (currentMask & ~4); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 292); }
    }

    /// <summary>
    /// BoolProperty: CurrentlyInCombat
    /// </summary>
    public unsafe bool CurrentlyInCombat
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 292) & 8) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 292); var newMask = value ? (currentMask | 8) : (currentMask & ~8); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 292); }
    }

    /// <summary>
    /// BoolProperty: ScreenGrappleVisible
    /// </summary>
    public unsafe bool ScreenGrappleVisible
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 292) & 16) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 292); var newMask = value ? (currentMask | 16) : (currentMask & ~16); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 292); }
    }

    /// <summary>
    /// BoolProperty: ScreenGrappleDirty
    /// </summary>
    public unsafe bool ScreenGrappleDirty
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 292) & 32) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 292); var newMask = value ? (currentMask | 32) : (currentMask & ~32); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 292); }
    }

    /// <summary>
    /// BoolProperty: bCompassVisible
    /// </summary>
    public unsafe bool bCompassVisible
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 292) & 64) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 292); var newMask = value ? (currentMask | 64) : (currentMask & ~64); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 292); }
    }

    /// <summary>
    /// BoolProperty: bCompassVisibleInFlash
    /// </summary>
    public unsafe bool bCompassVisibleInFlash
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 292) & 128) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 292); var newMask = value ? (currentMask | 128) : (currentMask & ~128); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 292); }
    }

    /// <summary>
    /// BoolProperty: LevelUpVisible
    /// </summary>
    public unsafe bool LevelUpVisible
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 292) & 256) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 292); var newMask = value ? (currentMask | 256) : (currentMask & ~256); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 292); }
    }

    /// <summary>
    /// BoolProperty: LevelUpSuppressed
    /// </summary>
    public unsafe bool LevelUpSuppressed
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 292) & 512) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 292); var newMask = value ? (currentMask | 512) : (currentMask & ~512); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 292); }
    }

    /// <summary>
    /// BoolProperty: LevelUpVisiblePrivate
    /// </summary>
    public unsafe bool LevelUpVisiblePrivate
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 292) & 1024) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 292); var newMask = value ? (currentMask | 1024) : (currentMask & ~1024); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 292); }
    }

    /// <summary>
    /// BoolProperty: bAnyCursorsActive
    /// </summary>
    public unsafe bool bAnyCursorsActive
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 292) & 2048) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 292); var newMask = value ? (currentMask | 2048) : (currentMask & ~2048); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 292); }
    }

    /// <summary>
    /// ObjectProperty: FlashTargetsArrayObject
    /// </summary>
    public unsafe BmSDK.GFxUI.GFxObject FlashTargetsArrayObject
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.GFxUI.GFxObject>(Ptr + 296); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 296); }
    }

    /// <summary>
    /// IntProperty: FocusTargetIndex
    /// </summary>
    public unsafe int FocusTargetIndex
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 304); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 304); }
    }

    /// <summary>
    /// IntProperty: FocusTargetIndexCurrentlyDisplayed
    /// </summary>
    public unsafe int FocusTargetIndexCurrentlyDisplayed
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 308); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 308); }
    }

    /// <summary>
    /// IntProperty: FocusTargetIndexPending
    /// </summary>
    public unsafe int FocusTargetIndexPending
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 312); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 312); }
    }

    /// <summary>
    /// FloatProperty: FocusTargetDistSqFromCentre
    /// </summary>
    public unsafe float FocusTargetDistSqFromCentre
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 316); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 316); }
    }

    /// <summary>
    /// FloatProperty: FocusTargetChangeTimer
    /// </summary>
    public unsafe float FocusTargetChangeTimer
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 320); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 320); }
    }

    /// <summary>
    /// IntProperty: MainCursorIndex
    /// </summary>
    public unsafe int MainCursorIndex
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 324); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 324); }
    }

    /// <summary>
    /// IntProperty: MainCursorCharges
    /// </summary>
    public unsafe int MainCursorCharges
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 328); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 328); }
    }

    /// <summary>
    /// IntProperty: MainCursorMaxCharges
    /// </summary>
    public unsafe int MainCursorMaxCharges
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 332); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 332); }
    }

    /// <summary>
    /// FloatProperty: DefaultCursorDepth
    /// </summary>
    public unsafe float DefaultCursorDepth
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 336); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 336); }
    }

    /// <summary>
    /// StrProperty: BatmobileCurrentHeavyWeapon
    /// </summary>
    public unsafe BmSDK.FString BatmobileCurrentHeavyWeapon
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 340); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 340); }
    }

    /// <summary>
    /// FloatProperty: ScreenGrappleX
    /// </summary>
    public unsafe float ScreenGrappleX
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 356); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 356); }
    }

    /// <summary>
    /// FloatProperty: ScreenGrappleY
    /// </summary>
    public unsafe float ScreenGrappleY
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 360); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 360); }
    }

    /// <summary>
    /// FloatProperty: ScreenGrappleDepth
    /// </summary>
    public unsafe float ScreenGrappleDepth
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 364); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 364); }
    }

    /// <summary>
    /// StrProperty: ScreenGrappleString
    /// </summary>
    public unsafe BmSDK.FString ScreenGrappleString
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 368); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 368); }
    }

    /// <summary>
    /// IntProperty: NumVisibleCompassArrayItems
    /// </summary>
    public unsafe int NumVisibleCompassArrayItems
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 384); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 384); }
    }

    /// <summary>
    /// FloatProperty: CompassFacingAngle
    /// </summary>
    public unsafe float CompassFacingAngle
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 388); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 388); }
    }

    /// <summary>
    /// ArrayProperty: CompassItemThreeDeeArray
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RHudModuleTargets.FCompassItemThreeDee> CompassItemThreeDeeArray
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RHudModuleTargets.FCompassItemThreeDee>>(Ptr + 392); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 392); }
    }

    /// <summary>
    /// IntProperty: ExclusiveCompassItem
    /// </summary>
    public unsafe int ExclusiveCompassItem
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 408); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 408); }
    }

    /// <summary>
    /// FloatProperty: fCurrentGrappleBoostLevel
    /// </summary>
    public unsafe float fCurrentGrappleBoostLevel
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 412); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 412); }
    }

    /// <summary>
    /// IntProperty: iCurrentGrappleEjectUpgLevel
    /// </summary>
    public unsafe int iCurrentGrappleEjectUpgLevel
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 416); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 416); }
    }

    /// <summary>
    /// StrProperty: CachedVariable_ConsolidatedArray
    /// </summary>
    public unsafe BmSDK.FString CachedVariable_ConsolidatedArray
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 420); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 420); }
    }

    /// <summary>
    /// StrProperty: CachedFunction_SendToFlash
    /// </summary>
    public unsafe BmSDK.FString CachedFunction_SendToFlash
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 436); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 436); }
    }

    /// <summary>
    /// StrProperty: CachedFunction_SendCompassInfo
    /// </summary>
    public unsafe BmSDK.FString CachedFunction_SendCompassInfo
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 452); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 452); }
    }

    /// <summary>
    /// StrProperty: CachedFunction_SetLevelUpVisible
    /// </summary>
    public unsafe BmSDK.FString CachedFunction_SetLevelUpVisible
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 468); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 468); }
    }

    /// <summary>
    /// StrProperty: CachedFunction_SetCompassMode
    /// </summary>
    public unsafe BmSDK.FString CachedFunction_SetCompassMode
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 484); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 484); }
    }

    /// <summary>
    /// StrProperty: CachedFunction_SetGrappleBoostLevel
    /// </summary>
    public unsafe BmSDK.FString CachedFunction_SetGrappleBoostLevel
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 500); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 500); }
    }

    /// <summary>
    /// StrProperty: CachedFunction_SetSuperEjectLevel
    /// </summary>
    public unsafe BmSDK.FString CachedFunction_SetSuperEjectLevel
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 516); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 516); }
    }

    /// <summary>
    /// StrProperty: CachedFunction_SendFocusDetailToFlash
    /// </summary>
    public unsafe BmSDK.FString CachedFunction_SendFocusDetailToFlash
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 532); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 532); }
    }

    /// <summary>
    /// StrProperty: CachedFunction_PlaySubAnimOnCursor3D
    /// </summary>
    public unsafe BmSDK.FString CachedFunction_PlaySubAnimOnCursor3D
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 548); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 548); }
    }

    /// <summary>
    /// Enum: CompassArrayIndices
    /// </summary>
    public enum CompassArrayIndices
    {
        CAI_Compass_Angle = 0,
        CAI_Compass_Alpha = 1,
        CAI_Compass_IconName = 2,
        CAI_Compass_MAX = 3,
    }

    /// <summary>
    /// Enum: TargetsArrayIndices
    /// </summary>
    public enum TargetsArrayIndices
    {
        TAI_Cursor_X = 0,
        TAI_Cursor_Y = 1,
        TAI_Cursor_Depth = 2,
        TAI_Cursor_ScreenSize = 3,
        TAI_Cursor_IconName = 4,
        TAI_Cursor_LockonProportion = 5,
        TAI_Cursor_Opacity = 6,
        TAI_Cursor_MAX = 7,
    }

    /// <summary>
    /// Enum: HeaderArrayIndices
    /// </summary>
    public enum HeaderArrayIndices
    {
        HAI_Header_ScreenGrappleDirty = 0,
        HAI_Header_ScreenGrappleVisible = 1,
        HAI_Header_ScreenGrappleString = 2,
        HAI_Header_ScreenGrappleX = 3,
        HAI_Header_ScreenGrappleY = 4,
        HAI_Header_ScreenGrappleDepth = 5,
        HAI_Header_MAX = 6,
    }
}
