#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RHudModuleDetectiveMode<br/>
/// (flags = 0)
/// </summary>
public partial class RHudModuleDetectiveMode : BmSDK.BmGame.RHudModule, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RHudModuleDetectiveMode", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RHudModuleDetectiveMode() { }

    /// <summary>
    /// Constructs a new RHudModuleDetectiveMode
    /// </summary>
    public RHudModuleDetectiveMode(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RHudModuleDetectiveMode Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RHudModuleDetectiveMode(nint ptr) : base(ptr) { }

    /// <summary>
    /// Function: HideScannerDetail
    /// </summary>
    public unsafe void HideScannerDetail()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RHudModuleDetectiveMode.HideScannerDetail", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: SetScannerDetailPrivate
    /// </summary>
    public unsafe void SetScannerDetailPrivate(BmSDK.FString swfmovie_name, bool bScanned)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RHudModuleDetectiveMode.SetScannerDetailPrivate", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(swfmovie_name, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bScanned, paramsPtr + 16);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: SetScannerDetail
    /// </summary>
    public unsafe void SetScannerDetail(float location_x, float location_y, float location_depth, BmSDK.BmGame.RPhysicalEvidenceBase CSE)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RHudModuleDetectiveMode.SetScannerDetail", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(location_x, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(location_y, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(location_depth, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CSE, paramsPtr + 12);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: HideEvidenceDetail
    /// </summary>
    public unsafe void HideEvidenceDetail()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RHudModuleDetectiveMode.HideEvidenceDetail", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: SetEvidenceDetailPrivate
    /// </summary>
    public unsafe void SetEvidenceDetailPrivate(float location_x, float location_y, float location_depth, BmSDK.FString swfmovie_name, bool bScanned)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RHudModuleDetectiveMode.SetEvidenceDetailPrivate", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(location_x, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(location_y, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(location_depth, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(swfmovie_name, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bScanned, paramsPtr + 28);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: SetEvidenceDetail
    /// </summary>
    public unsafe void SetEvidenceDetail(float location_x, float location_y, float location_depth, BmSDK.BmGame.RPhysicalEvidenceBase CSE)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RHudModuleDetectiveMode.SetEvidenceDetail", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(location_x, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(location_y, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(location_depth, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CSE, paramsPtr + 12);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: UpdateCachedEvidence
    /// </summary>
    public unsafe void UpdateCachedEvidence(BmSDK.GFxUI.SwfMovie NewEvidence)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RHudModuleDetectiveMode.UpdateCachedEvidence", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewEvidence, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: HideInfoText
    /// </summary>
    public unsafe void HideInfoText()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RHudModuleDetectiveMode.HideInfoText", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: SetInfoText
    /// </summary>
    public unsafe void SetInfoText(float location_x, float location_y, float location_depth, BmSDK.FString Heading, BmSDK.FString Description, bool Warning)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RHudModuleDetectiveMode.SetInfoText", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(location_x, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(location_y, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(location_depth, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Heading, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Description, paramsPtr + 28);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Warning, paramsPtr + 44);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: HideNPCDetail
    /// </summary>
    public unsafe void HideNPCDetail()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RHudModuleDetectiveMode.HideNPCDetail", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: SetNPCDetail
    /// </summary>
    public unsafe void SetNPCDetail(float location_x, float location_y, float location_depth, int physical_state_enum, int weapon_enum, int extra_info_enum, bool is_armoured, BmSDK.FString optional_name)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RHudModuleDetectiveMode.SetNPCDetail", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(location_x, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(location_y, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(location_depth, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(physical_state_enum, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(weapon_enum, paramsPtr + 16);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(extra_info_enum, paramsPtr + 20);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(is_armoured, paramsPtr + 24);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(optional_name, paramsPtr + 28);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: HideSmokePercentage
    /// </summary>
    public unsafe void HideSmokePercentage()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RHudModuleDetectiveMode.HideSmokePercentage", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: SetSmokePercentage
    /// </summary>
    public unsafe void SetSmokePercentage(int SmokePercentage)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RHudModuleDetectiveMode.SetSmokePercentage", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SmokePercentage, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: SetNPCCountString
    /// </summary>
    public unsafe void SetNPCCountString(int total, BmSDK.FString Str)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RHudModuleDetectiveMode.SetNPCCountString", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(total, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Str, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: UpdateNPCCounts
    /// </summary>
    public unsafe void UpdateNPCCounts(int Armed, int UnArmed)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RHudModuleDetectiveMode.UpdateNPCCounts", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Armed, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(UnArmed, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: CloseCurrentDetail
    /// </summary>
    public unsafe void CloseCurrentDetail()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RHudModuleDetectiveMode.CloseCurrentDetail", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: ClearDetailIfMatches
    /// </summary>
    public unsafe void ClearDetailIfMatches(BmSDK.BmGame.RHudModuleDetectiveMode.DetailDisplayType _TestDetailType)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RHudModuleDetectiveMode.ClearDetailIfMatches", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(_TestDetailType, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: SetCurrentDetail
    /// </summary>
    public unsafe void SetCurrentDetail(BmSDK.BmGame.RHudModuleDetectiveMode.DetailDisplayType _CurrentDetailType)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RHudModuleDetectiveMode.SetCurrentDetail", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(_CurrentDetailType, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: Detective_InfoBoxOpenSound
    /// </summary>
    public unsafe void Detective_InfoBoxOpenSound()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RHudModuleDetectiveMode.Detective_InfoBoxOpenSound", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: SetVisible
    /// </summary>
    public unsafe void SetVisible(bool is_visible)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RHudModuleDetectiveMode.SetVisible", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(is_visible, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: Close
    /// </summary>
    public unsafe void Close()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RHudModuleDetectiveMode.Close", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: InitialiseFlash
    /// </summary>
    public unsafe void InitialiseFlash()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RHudModuleDetectiveMode.InitialiseFlash", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: Init
    /// </summary>
    public unsafe bool Init(BmSDK.BmGame.RPlayerController _RPC, BmSDK.FString _ExtensionName, BmSDK.FString _ExtensionPath)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RHudModuleDetectiveMode.Init", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(_RPC, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(_ExtensionName, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(_ExtensionPath, paramsPtr + 24);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 40);
    }

    /// <summary>
    /// Enum: ENpcExtraInfo
    /// </summary>
    public enum ENpcExtraInfo
    {
        ENpcExtraInfo_None = 0,
        ENpcExtraInfo_Friendly = 1,
        ENpcExtraInfo_Undead = 2,
        ENpcExtraInfo_ThugJammer = 3,
        ENpcExtraInfo_ThugMines = 4,
        ENpcExtraInfo_ThugThermalVision = 5,
        ENpcExtraInfo_Robot = 6,
        ENpcExtraInfo_ThugJammerBroken = 7,
        ENpcExtraInfo_DroneController = 8,
        ENpcExtraInfo_DetectiveModeDetector = 9,
        ENpcExtraInfo_Medic3 = 10,
        ENpcExtraInfo_Medic2 = 11,
        ENpcExtraInfo_Medic1 = 12,
        ENpcExtraInfo_Medic0 = 13,
        ENpcExtraInfo_MAX = 14,
    }

    /// <summary>
    /// Enum: DetailDisplayType
    /// </summary>
    public enum DetailDisplayType
    {
        DDT_None = 0,
        DDT_Smoke = 1,
        DDT_NPC = 2,
        DDT_Info = 3,
        DDT_Evidence = 4,
        DDT_Scanner = 5,
        DDT_MAX = 6,
    }

    /// <summary>
    /// StrProperty: CachedFunction_SetNPCCountString
    /// </summary>
    public unsafe BmSDK.FString CachedFunction_SetNPCCountString
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 240); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 240); }
    }

    /// <summary>
    /// StrProperty: CachedFunction_SetSmokeLevel
    /// </summary>
    public unsafe BmSDK.FString CachedFunction_SetSmokeLevel
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 256); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 256); }
    }

    /// <summary>
    /// StrProperty: CachedFunction_HideSmokeLevel
    /// </summary>
    public unsafe BmSDK.FString CachedFunction_HideSmokeLevel
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 272); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 272); }
    }

    /// <summary>
    /// StrProperty: CachedFunction_SetNPCDetail
    /// </summary>
    public unsafe BmSDK.FString CachedFunction_SetNPCDetail
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 288); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 288); }
    }

    /// <summary>
    /// StrProperty: CachedFunction_HideNPCDetail
    /// </summary>
    public unsafe BmSDK.FString CachedFunction_HideNPCDetail
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 304); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 304); }
    }

    /// <summary>
    /// StrProperty: CachedFunction_SetInfoText
    /// </summary>
    public unsafe BmSDK.FString CachedFunction_SetInfoText
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 320); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 320); }
    }

    /// <summary>
    /// StrProperty: CachedFunction_HideInfoText
    /// </summary>
    public unsafe BmSDK.FString CachedFunction_HideInfoText
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 336); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 336); }
    }

    /// <summary>
    /// StrProperty: CachedFunction_SetEvidenceDetail
    /// </summary>
    public unsafe BmSDK.FString CachedFunction_SetEvidenceDetail
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 352); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 352); }
    }

    /// <summary>
    /// StrProperty: CachedFunction_HideEvidenceDetail
    /// </summary>
    public unsafe BmSDK.FString CachedFunction_HideEvidenceDetail
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 368); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 368); }
    }

    /// <summary>
    /// StrProperty: CachedFunction_SetScannerDetail
    /// </summary>
    public unsafe BmSDK.FString CachedFunction_SetScannerDetail
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 384); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 384); }
    }

    /// <summary>
    /// StrProperty: CachedFunction_HideScannerDetail
    /// </summary>
    public unsafe BmSDK.FString CachedFunction_HideScannerDetail
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 400); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 400); }
    }

    /// <summary>
    /// ObjectProperty: LastEvidenceSwf
    /// </summary>
    public unsafe BmSDK.GFxUI.SwfMovie LastEvidenceSwf
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.GFxUI.SwfMovie>(Ptr + 416); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 416); }
    }

    /// <summary>
    /// StrProperty: LastEvidenceString
    /// </summary>
    public unsafe BmSDK.FString LastEvidenceString
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 424); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 424); }
    }

    /// <summary>
    /// BoolProperty: NPCDetailActive
    /// </summary>
    public unsafe bool NPCDetailActive
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 440) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 440); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 440); }
    }

    /// <summary>
    /// BoolProperty: InfoTextActive
    /// </summary>
    public unsafe bool InfoTextActive
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 440) & 2) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 440); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 440); }
    }

    /// <summary>
    /// ByteProperty: CurrentDetailType
    /// </summary>
    public unsafe BmSDK.BmGame.RHudModuleDetectiveMode.DetailDisplayType CurrentDetailType
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RHudModuleDetectiveMode.DetailDisplayType>(Ptr + 444); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 444); }
    }
}
