#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RGFxMovieUI_ContentBeaconPanel<br/>
/// (flags = 0)
/// </summary>
public partial class RGFxMovieUI_ContentBeaconPanel : BmSDK.BmGame.RGFxMovieUI, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RGFxMovieUI_ContentBeaconPanel", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RGFxMovieUI_ContentBeaconPanel() { }

    /// <summary>
    /// Constructs a new RGFxMovieUI_ContentBeaconPanel
    /// </summary>
    public RGFxMovieUI_ContentBeaconPanel(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RGFxMovieUI_ContentBeaconPanel Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RGFxMovieUI_ContentBeaconPanel(nint ptr) : base(ptr) { }

    /// <summary>
    /// ByteProperty: m_eCachedDisplayMode
    /// </summary>
    public unsafe BmSDK.BmGame.RGameInfo.EContentBeaconDisplayMode m_eCachedDisplayMode
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RGameInfo.EContentBeaconDisplayMode>(Ptr + 1072); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1072); }
    }

    /// <summary>
    /// IntProperty: m_nCachedBeaconIndex
    /// </summary>
    public unsafe int m_nCachedBeaconIndex
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1076); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1076); }
    }

    /// <summary>
    /// StrProperty: m_sCachedAction
    /// </summary>
    public unsafe BmSDK.FString m_sCachedAction
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 1080); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1080); }
    }

    /// <summary>
    /// IntProperty: m_nCachedEpisodeIndex
    /// </summary>
    public unsafe int m_nCachedEpisodeIndex
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1096); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1096); }
    }

    /// <summary>
    /// ObjectProperty: m_iConfirmLaunchPopup
    /// </summary>
    public unsafe BmSDK.BmGame.RGFxMoviePopupRequester m_iConfirmLaunchPopup
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RGFxMoviePopupRequester>(Ptr + 1100); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1100); }
    }

    /// <summary>
    /// ObjectProperty: m_iContentNotFoundPopup
    /// </summary>
    public unsafe BmSDK.BmGame.RGFxMoviePopupRequester m_iContentNotFoundPopup
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RGFxMoviePopupRequester>(Ptr + 1108); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1108); }
    }

    /// <summary>
    /// ObjectProperty: m_iWantOnlinePopup
    /// </summary>
    public unsafe BmSDK.BmGame.RGFxMoviePopupRequester m_iWantOnlinePopup
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RGFxMoviePopupRequester>(Ptr + 1116); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1116); }
    }

    /// <summary>
    /// DelegateProperty: __ContentBeaconContentLoaded__Delegate
    /// </summary>
    public unsafe System.IntPtr __ContentBeaconContentLoaded__Delegate
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.IntPtr>(Ptr + 1124); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1124); }
    }
}
