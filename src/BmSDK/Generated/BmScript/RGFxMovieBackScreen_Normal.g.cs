#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmScript;

/// <summary>
/// Class: RGFxMovieBackScreen_Normal<br/>
/// (size = 0)
/// (flags = 0)
/// </summary>
public partial class RGFxMovieBackScreen_Normal : BmSDK.BmGame.RGFxMovieBackScreen, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmScript.RGFxMovieBackScreen_Normal", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RGFxMovieBackScreen_Normal() { }

    /// <summary>
    /// Constructs a new RGFxMovieBackScreen_Normal
    /// </summary>
    public RGFxMovieBackScreen_Normal(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RGFxMovieBackScreen_Normal Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RGFxMovieBackScreen_Normal(nint ptr) : base(ptr) { }

    /// <summary>
    /// BoolProperty: bReadPending
    /// </summary>
    public unsafe bool bReadPending
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1712) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1712); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1712); }
    }

    /// <summary>
    /// BoolProperty: bMovedUserMarker
    /// </summary>
    public unsafe bool bMovedUserMarker
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1712) & 2) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1712); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1712); }
    }

    /// <summary>
    /// BoolProperty: bCreatedIcons
    /// </summary>
    public unsafe bool bCreatedIcons
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1712) & 4) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1712); var newMask = value ? (currentMask | 4) : (currentMask & ~4); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1712); }
    }

    /// <summary>
    /// BoolProperty: bPanEnabled
    /// </summary>
    public unsafe bool bPanEnabled
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1712) & 8) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1712); var newMask = value ? (currentMask | 8) : (currentMask & ~8); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1712); }
    }

    /// <summary>
    /// BoolProperty: bPanEnabledLast
    /// </summary>
    public unsafe bool bPanEnabledLast
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1712) & 16) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1712); var newMask = value ? (currentMask | 16) : (currentMask & ~16); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1712); }
    }

    /// <summary>
    /// BoolProperty: bPanNoFirstEntryDelay
    /// </summary>
    public unsafe bool bPanNoFirstEntryDelay
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1712) & 32) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1712); var newMask = value ? (currentMask | 32) : (currentMask & ~32); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1712); }
    }

    /// <summary>
    /// BoolProperty: bPanTweenElevationToo
    /// </summary>
    public unsafe bool bPanTweenElevationToo
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1712) & 64) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1712); var newMask = value ? (currentMask | 64) : (currentMask & ~64); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1712); }
    }

    /// <summary>
    /// BoolProperty: bUpgradeCommitted
    /// </summary>
    public unsafe bool bUpgradeCommitted
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1712) & 128) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1712); var newMask = value ? (currentMask | 128) : (currentMask & ~128); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1712); }
    }

    /// <summary>
    /// BoolProperty: BioAutoSelect
    /// </summary>
    public unsafe bool BioAutoSelect
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1712) & 256) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1712); var newMask = value ? (currentMask | 256) : (currentMask & ~256); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1712); }
    }

    /// <summary>
    /// BoolProperty: BiobAutoPlay
    /// </summary>
    public unsafe bool BiobAutoPlay
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1712) & 512) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1712); var newMask = value ? (currentMask | 512) : (currentMask & ~512); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1712); }
    }

    /// <summary>
    /// BoolProperty: RumbleActive
    /// </summary>
    public unsafe bool RumbleActive
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1712) & 1024) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1712); var newMask = value ? (currentMask | 1024) : (currentMask & ~1024); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1712); }
    }

    /// <summary>
    /// BoolProperty: bManualOpen
    /// </summary>
    public unsafe bool bManualOpen
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1712) & 2048) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1712); var newMask = value ? (currentMask | 2048) : (currentMask & ~2048); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1712); }
    }

    /// <summary>
    /// BoolProperty: bSaveGameWhenClosed
    /// </summary>
    public unsafe bool bSaveGameWhenClosed
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1712) & 4096) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1712); var newMask = value ? (currentMask | 4096) : (currentMask & ~4096); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1712); }
    }

    /// <summary>
    /// IntProperty: ChallengeID
    /// </summary>
    public unsafe int ChallengeID
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1716); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1716); }
    }

    /// <summary>
    /// StrProperty: LeaderboardPath
    /// </summary>
    public unsafe BmSDK.FString LeaderboardPath
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 1720); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1720); }
    }

    /// <summary>
    /// FloatProperty: LerpRatio
    /// </summary>
    public unsafe float LerpRatio
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1736); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1736); }
    }

    /// <summary>
    /// IntProperty: ChapterId
    /// </summary>
    public unsafe int ChapterId
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1740); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1740); }
    }

    /// <summary>
    /// StrProperty: ASClassPathTmp
    /// </summary>
    public unsafe BmSDK.FString ASClassPathTmp
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 1744); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1744); }
    }

    /// <summary>
    /// ArrayProperty: SubMapDefaults
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmScript.RGFxMovieBackScreen_Normal.FSubMapDefault> SubMapDefaults
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmScript.RGFxMovieBackScreen_Normal.FSubMapDefault>>(Ptr + 1760); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1760); }
    }

    /// <summary>
    /// ArrayProperty: Dialogs
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmScript.RGFxMovieBackScreen_Normal.FDialogEntry> Dialogs
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmScript.RGFxMovieBackScreen_Normal.FDialogEntry>>(Ptr + 1776); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1776); }
    }

    /// <summary>
    /// ArrayProperty: SpeechIdsActive
    /// </summary>
    public unsafe BmSDK.TArray<int> SpeechIdsActive
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<int>>(Ptr + 1792); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1792); }
    }

    /// <summary>
    /// IntProperty: IdOfGlobalSpeechPlaying
    /// </summary>
    public unsafe int IdOfGlobalSpeechPlaying
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1808); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1808); }
    }

    /// <summary>
    /// IntProperty: IndexOfLastGlobalSpeech
    /// </summary>
    public unsafe int IndexOfLastGlobalSpeech
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1812); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1812); }
    }

    /// <summary>
    /// ArrayProperty: MapRiddleIconsInSubLocations
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.FString> MapRiddleIconsInSubLocations
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.FString>>(Ptr + 1816); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1816); }
    }

    /// <summary>
    /// StrProperty: CachedFunction_SetThreatLevel
    /// </summary>
    public unsafe BmSDK.FString CachedFunction_SetThreatLevel
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 1832); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1832); }
    }

    /// <summary>
    /// IntProperty: ThreatLevelAreaLast
    /// </summary>
    public unsafe int ThreatLevelAreaLast
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1848); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1848); }
    }

    /// <summary>
    /// ArrayProperty: ThreatLevels
    /// </summary>
    public unsafe BmSDK.TArray<int> ThreatLevels
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<int>>(Ptr + 1852); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1852); }
    }

    /// <summary>
    /// ArrayProperty: ThreatLevelsLast
    /// </summary>
    public unsafe BmSDK.TArray<int> ThreatLevelsLast
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<int>>(Ptr + 1868); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1868); }
    }

    /// <summary>
    /// ArrayProperty: OW_IncludeTheseExceptions
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.FString> OW_IncludeTheseExceptions
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.FString>>(Ptr + 1884); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1884); }
    }

    /// <summary>
    /// ArrayProperty: OW_ExcludeTheseExceptions
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.FString> OW_ExcludeTheseExceptions
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.FString>>(Ptr + 1900); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1900); }
    }

    /// <summary>
    /// StrProperty: MapScreenBasePath
    /// </summary>
    public unsafe BmSDK.FString MapScreenBasePath
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 1916); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1916); }
    }

    /// <summary>
    /// StrProperty: MapScript
    /// </summary>
    public unsafe BmSDK.FString MapScript
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 1932); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1932); }
    }

    /// <summary>
    /// StrProperty: MapCallback
    /// </summary>
    public unsafe BmSDK.FString MapCallback
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 1948); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1948); }
    }

    /// <summary>
    /// FloatProperty: TweenInRate
    /// </summary>
    public unsafe float TweenInRate
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1964); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1964); }
    }

    /// <summary>
    /// FloatProperty: TweenOutRate
    /// </summary>
    public unsafe float TweenOutRate
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1968); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1968); }
    }

    /// <summary>
    /// FloatProperty: DefaultHeight
    /// </summary>
    public unsafe float DefaultHeight
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1972); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1972); }
    }

    /// <summary>
    /// FloatProperty: DefaultElevation
    /// </summary>
    public unsafe float DefaultElevation
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1976); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1976); }
    }

    /// <summary>
    /// FloatProperty: DefaultDistance
    /// </summary>
    public unsafe float DefaultDistance
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1980); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1980); }
    }

    /// <summary>
    /// StructProperty: StickLocation
    /// </summary>
    public unsafe System.Numerics.Vector3 StickLocation
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 1984); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1984); }
    }

    /// <summary>
    /// FloatProperty: StickRotation
    /// </summary>
    public unsafe float StickRotation
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1996); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1996); }
    }

    /// <summary>
    /// FloatProperty: StickElevation
    /// </summary>
    public unsafe float StickElevation
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2000); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2000); }
    }

    /// <summary>
    /// FloatProperty: StickDistance
    /// </summary>
    public unsafe float StickDistance
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2004); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2004); }
    }

    /// <summary>
    /// StructProperty: TweenSourceLocation
    /// </summary>
    public unsafe System.Numerics.Vector3 TweenSourceLocation
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 2008); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2008); }
    }

    /// <summary>
    /// StructProperty: TweenSourceRotation
    /// </summary>
    public unsafe BmSDK.Rotator TweenSourceRotation
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Rotator>(Ptr + 2020); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2020); }
    }

    /// <summary>
    /// FloatProperty: TweenSourceFOV
    /// </summary>
    public unsafe float TweenSourceFOV
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2032); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2032); }
    }

    /// <summary>
    /// StructProperty: TweenTargetLocation
    /// </summary>
    public unsafe System.Numerics.Vector3 TweenTargetLocation
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 2036); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2036); }
    }

    /// <summary>
    /// StructProperty: TweenTargetRotation
    /// </summary>
    public unsafe BmSDK.Rotator TweenTargetRotation
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Rotator>(Ptr + 2048); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2048); }
    }

    /// <summary>
    /// FloatProperty: TweenTargetFOV
    /// </summary>
    public unsafe float TweenTargetFOV
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2060); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2060); }
    }

    /// <summary>
    /// StructProperty: CityOffset
    /// </summary>
    public unsafe System.Numerics.Vector3 CityOffset
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 2064); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2064); }
    }

    /// <summary>
    /// ArrayProperty: PanToIcons
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.FString> PanToIcons
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.FString>>(Ptr + 2076); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2076); }
    }

    /// <summary>
    /// StructProperty: PanReturnToLocation
    /// </summary>
    public unsafe System.Numerics.Vector3 PanReturnToLocation
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 2092); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2092); }
    }

    /// <summary>
    /// StructProperty: PanDelta
    /// </summary>
    public unsafe System.Numerics.Vector3 PanDelta
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 2104); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2104); }
    }

    /// <summary>
    /// StructProperty: PanXYZTarget
    /// </summary>
    public unsafe System.Numerics.Vector3 PanXYZTarget
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 2116); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2116); }
    }

    /// <summary>
    /// IntProperty: PanStep
    /// </summary>
    public unsafe int PanStep
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2128); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2128); }
    }

    /// <summary>
    /// IntProperty: PanWait
    /// </summary>
    public unsafe int PanWait
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2132); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2132); }
    }

    /// <summary>
    /// FloatProperty: PanRate
    /// </summary>
    public unsafe float PanRate
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2136); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2136); }
    }

    /// <summary>
    /// FloatProperty: PanDeltaElev
    /// </summary>
    public unsafe float PanDeltaElev
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2140); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2140); }
    }

    /// <summary>
    /// ArrayProperty: VolumeActors
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.Engine.RockMapHighlight> VolumeActors
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.RockMapHighlight>>(Ptr + 2144); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2144); }
    }

    /// <summary>
    /// StrProperty: TargettedIconLast
    /// </summary>
    public unsafe BmSDK.FString TargettedIconLast
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 2160); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2160); }
    }

    /// <summary>
    /// ArrayProperty: RiddlerItems_InBuildings
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.FString> RiddlerItems_InBuildings
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.FString>>(Ptr + 2176); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2176); }
    }

    /// <summary>
    /// ArrayProperty: RiddlerItem_OffsetNames
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.FString> RiddlerItem_OffsetNames
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.FString>>(Ptr + 2192); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2192); }
    }

    /// <summary>
    /// ArrayProperty: RiddlerItem_OffsetValues
    /// </summary>
    public unsafe BmSDK.TArray<int> RiddlerItem_OffsetValues
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<int>>(Ptr + 2208); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2208); }
    }

    /// <summary>
    /// StrProperty: CachedFunction_UpgradeScreen
    /// </summary>
    public unsafe BmSDK.FString CachedFunction_UpgradeScreen
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 2224); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2224); }
    }

    /// <summary>
    /// ArrayProperty: UpgradePrompts
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmScript.RGFxMovieBackScreen_Normal.FPromptEntry> UpgradePrompts
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmScript.RGFxMovieBackScreen_Normal.FPromptEntry>>(Ptr + 2240); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2240); }
    }

    /// <summary>
    /// IntProperty: BioLocIndex
    /// </summary>
    public unsafe int BioLocIndex
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2256); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2256); }
    }

    /// <summary>
    /// ArrayProperty: BioIndex
    /// </summary>
    public unsafe BmSDK.TArray<int> BioIndex
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<int>>(Ptr + 2260); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2260); }
    }

    /// <summary>
    /// IntProperty: BioPageId
    /// </summary>
    public unsafe int BioPageId
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2276); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2276); }
    }

    /// <summary>
    /// IntProperty: BioTapeId
    /// </summary>
    public unsafe int BioTapeId
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2280); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2280); }
    }

    /// <summary>
    /// StrProperty: CachedFunction_RiddlerScreen
    /// </summary>
    public unsafe BmSDK.FString CachedFunction_RiddlerScreen
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 2284); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2284); }
    }

    /// <summary>
    /// FloatProperty: FlashRumbleValueLeft
    /// </summary>
    public unsafe float FlashRumbleValueLeft
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2300); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2300); }
    }

    /// <summary>
    /// FloatProperty: FlashRumbleValueRight
    /// </summary>
    public unsafe float FlashRumbleValueRight
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2304); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2304); }
    }

    /// <summary>
    /// ObjectProperty: MinigameFFWaveForm
    /// </summary>
    public unsafe BmSDK.Engine.ForceFeedbackWaveform MinigameFFWaveForm
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ForceFeedbackWaveform>(Ptr + 2308); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2308); }
    }
}
