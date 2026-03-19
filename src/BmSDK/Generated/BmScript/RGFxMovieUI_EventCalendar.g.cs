#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmScript;

/// <summary>
/// Class: RGFxMovieUI_EventCalendar<br/>
/// (size = 0)
/// (flags = 0)
/// </summary>
public partial class RGFxMovieUI_EventCalendar : BmSDK.BmGame.RGFxMovieUI, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmScript.RGFxMovieUI_EventCalendar", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RGFxMovieUI_EventCalendar() { }

    /// <summary>
    /// Constructs a new RGFxMovieUI_EventCalendar
    /// </summary>
    public RGFxMovieUI_EventCalendar(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RGFxMovieUI_EventCalendar Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RGFxMovieUI_EventCalendar(nint ptr) : base(ptr) { }

    /// <summary>
    /// StrProperty: m_sManifest
    /// </summary>
    public unsafe BmSDK.FString m_sManifest
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 1072); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1072); }
    }

    /// <summary>
    /// StrProperty: m_sMoviePath
    /// </summary>
    public unsafe BmSDK.FString m_sMoviePath
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 1088); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1088); }
    }

    /// <summary>
    /// ArrayProperty: m_aActiveContentRequests
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<System.IntPtr>>>> m_aActiveContentRequests
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<System.IntPtr>>>>>(Ptr + 1104); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1104); }
    }

    /// <summary>
    /// IntProperty: m_nContentControllerId
    /// </summary>
    public unsafe int m_nContentControllerId
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1120); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1120); }
    }

    /// <summary>
    /// BoolProperty: m_bHydraContentEnumerated
    /// </summary>
    public unsafe bool m_bHydraContentEnumerated
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1124) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1124); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1124); }
    }

    /// <summary>
    /// BoolProperty: m_bHydraContentSuccessful
    /// </summary>
    public unsafe bool m_bHydraContentSuccessful
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1124) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1124); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1124); }
    }

    /// <summary>
    /// BoolProperty: m_bPopFirstPartyStore
    /// </summary>
    public unsafe bool m_bPopFirstPartyStore
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1124) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1124); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1124); }
    }

    /// <summary>
    /// BoolProperty: m_bRefreshContentStatus
    /// </summary>
    public unsafe bool m_bRefreshContentStatus
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1124) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1124); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1124); }
    }

    /// <summary>
    /// BoolProperty: m_bCalendarPopulated
    /// </summary>
    public unsafe bool m_bCalendarPopulated
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1124) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1124); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1124); }
    }

    /// <summary>
    /// BoolProperty: bSeasonPassOwned
    /// </summary>
    public unsafe bool bSeasonPassOwned
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1124) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1124); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1124); }
    }

    /// <summary>
    /// ArrayProperty: m_aManifestItemInfo
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<System.IntPtr>>> m_aManifestItemInfo
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<System.IntPtr>>>>(Ptr + 1128); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1128); }
    }

    /// <summary>
    /// ArrayProperty: m_aSteamAppInfo
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.TArray<System.IntPtr>> m_aSteamAppInfo
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.TArray<System.IntPtr>>>(Ptr + 1144); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1144); }
    }

    /// <summary>
    /// ArrayProperty: m_aHydraTrackingInfo
    /// </summary>
    public unsafe BmSDK.TArray<System.IntPtr> m_aHydraTrackingInfo
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<System.IntPtr>>(Ptr + 1160); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1160); }
    }

    /// <summary>
    /// DelegateProperty: __CustomManifestLoadedEC__Delegate
    /// </summary>
    public unsafe System.IntPtr __CustomManifestLoadedEC__Delegate
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.IntPtr>(Ptr + 1176); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1176); }
    }

    /// <summary>
    /// DelegateProperty: __CustomContentLoadedEC__Delegate
    /// </summary>
    public unsafe System.IntPtr __CustomContentLoadedEC__Delegate
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.IntPtr>(Ptr + 1192); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1192); }
    }

    /// <summary>
    /// DelegateProperty: __OnGetSteamDLCAppInfoComplete__Delegate
    /// </summary>
    public unsafe System.IntPtr __OnGetSteamDLCAppInfoComplete__Delegate
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.IntPtr>(Ptr + 1208); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1208); }
    }
}
