#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Class: OnlineProfileSettings<br/>
/// (size = 0)
/// (flags = 0)
/// </summary>
public partial class OnlineProfileSettings : BmSDK.Engine.OnlinePlayerStorage, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Engine.OnlineProfileSettings", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal OnlineProfileSettings() { }

    /// <summary>
    /// Constructs a new OnlineProfileSettings
    /// </summary>
    public OnlineProfileSettings(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, OnlineProfileSettings Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected OnlineProfileSettings(nint ptr) : base(ptr) { }

    /// <summary>
    /// ArrayProperty: ProfileSettingIds
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<NEED_UPDATE_ARRAYPROPERTY_LAYOUT>>>> ProfileSettingIds
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<NEED_UPDATE_ARRAYPROPERTY_LAYOUT>>>>>(Ptr + 136); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 136); }
    }

    /// <summary>
    /// ArrayProperty: DefaultSettings
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<NEED_UPDATE_ARRAYPROPERTY_LAYOUT>>> DefaultSettings
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<NEED_UPDATE_ARRAYPROPERTY_LAYOUT>>>>(Ptr + 152); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 152); }
    }

    /// <summary>
    /// ArrayProperty: OwnerMappings
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.TArray<NEED_UPDATE_ARRAYPROPERTY_LAYOUT>> OwnerMappings
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.TArray<NEED_UPDATE_ARRAYPROPERTY_LAYOUT>>>(Ptr + 168); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 168); }
    }

    /// <summary>
    /// Enum: EProfileSettingID
    /// </summary>
    public enum EProfileSettingID
    {
        PSI_Unknown = 0,
        PSI_ControllerVibration = 1,
        PSI_YInversion = 2,
        PSI_GamerCred = 3,
        PSI_GamerRep = 4,
        PSI_VoiceMuted = 5,
        PSI_VoiceThruSpeakers = 6,
        PSI_VoiceVolume = 7,
        PSI_GamerPictureKey = 8,
        PSI_GamerMotto = 9,
        PSI_GamerTitlesPlayed = 10,
        PSI_GamerAchievementsEarned = 11,
        PSI_GameDifficulty = 12,
        PSI_ControllerSensitivity = 13,
        PSI_PreferredColor1 = 14,
        PSI_PreferredColor2 = 15,
        PSI_AutoAim = 16,
        PSI_AutoCenter = 17,
        PSI_MovementControl = 18,
        PSI_RaceTransmission = 19,
        PSI_RaceCameraLocation = 20,
        PSI_RaceBrakeControl = 21,
        PSI_RaceAcceleratorControl = 22,
        PSI_GameCredEarned = 23,
        PSI_GameAchievementsEarned = 24,
        PSI_EndLiveIds = 25,
        PSI_ProfileVersionNum = 26,
        PSI_ProfileSaveCount = 27,
        PSI_MAX = 28,
    }
}
