#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmScript;

/// <summary>
/// Class: RGFxMovieUI_ArkhamEpisodes<br/>
/// (flags = 0)
/// </summary>
public partial class RGFxMovieUI_ArkhamEpisodes : BmSDK.BmGame.RGFxMovieUI, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmScript.RGFxMovieUI_ArkhamEpisodes", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RGFxMovieUI_ArkhamEpisodes() { }

    /// <summary>
    /// Constructs a new RGFxMovieUI_ArkhamEpisodes
    /// </summary>
    public RGFxMovieUI_ArkhamEpisodes(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RGFxMovieUI_ArkhamEpisodes Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RGFxMovieUI_ArkhamEpisodes(nint ptr) : base(ptr) { }

    /// <summary>
    /// ObjectProperty: RGI
    /// </summary>
    public unsafe BmSDK.BmGame.RGameInfo RGI
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RGameInfo>(Ptr + 1072); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1072); }
    }

    /// <summary>
    /// ObjectProperty: ActivePopup
    /// </summary>
    public unsafe BmSDK.BmGame.RGFxMoviePopupRequester ActivePopup
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RGFxMoviePopupRequester>(Ptr + 1080); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1080); }
    }

    /// <summary>
    /// ObjectProperty: InstallerGFxMovieInstance
    /// </summary>
    public unsafe BmSDK.GFxUI.SwfMovie InstallerGFxMovieInstance
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.GFxUI.SwfMovie>(Ptr + 1088); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1088); }
    }

    /// <summary>
    /// ObjectProperty: InstallerMovieUI
    /// </summary>
    public unsafe BmSDK.BmScript.RGFxMovieUI_InstallationMessage InstallerMovieUI
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmScript.RGFxMovieUI_InstallationMessage>(Ptr + 1096); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1096); }
    }

    /// <summary>
    /// ArrayProperty: Stories
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RGameInfo.FStoryDLCItem> Stories
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RGameInfo.FStoryDLCItem>>(Ptr + 1104); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1104); }
    }

    /// <summary>
    /// ByteProperty: PopType
    /// </summary>
    public unsafe BmSDK.BmScript.RGFxMovieUI_ArkhamEpisodes.AEPopTypes PopType
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmScript.RGFxMovieUI_ArkhamEpisodes.AEPopTypes>(Ptr + 1120); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1120); }
    }

    /// <summary>
    /// IntProperty: FadeMode
    /// </summary>
    public unsafe int FadeMode
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1124); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1124); }
    }

    /// <summary>
    /// IntProperty: LatentInstallFromId
    /// </summary>
    public unsafe int LatentInstallFromId
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1128); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1128); }
    }

    /// <summary>
    /// DelegateProperty: __SortByUISortId__Delegate
    /// </summary>
    public unsafe System.IntPtr __SortByUISortId__Delegate
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.IntPtr>(Ptr + 1132); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1132); }
    }

    /// <summary>
    /// Enum: AEPopTypes
    /// </summary>
    public enum AEPopTypes
    {
        AEPopType_None = 0,
        AEPopType_Menu = 1,
        AEPopType_Confirm = 2,
        AEPopType_MAX = 3,
    }
}
