#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmScript;

/// <summary>
/// Class: MGFxMovieUI_WBIDMain<br/>
/// (size = 0)
/// (flags = 0)
/// </summary>
public partial class MGFxMovieUI_WBIDMain : BmSDK.BmGame.MGFxMovieUI_WBIDMainBase, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmScript.MGFxMovieUI_WBIDMain", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal MGFxMovieUI_WBIDMain() { }

    /// <summary>
    /// Constructs a new MGFxMovieUI_WBIDMain
    /// </summary>
    public MGFxMovieUI_WBIDMain(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, MGFxMovieUI_WBIDMain Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected MGFxMovieUI_WBIDMain(nint ptr) : base(ptr) { }

    /// <summary>
    /// ObjectProperty: OverlayMaster
    /// </summary>
    public unsafe BmSDK.BmScript.MGFxWidgetOverlayMain OverlayMaster
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmScript.MGFxWidgetOverlayMain>(Ptr + 1072); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1072); }
    }

    /// <summary>
    /// ObjectProperty: ScreenMovie
    /// </summary>
    public unsafe BmSDK.GFxUI.GFxObject ScreenMovie
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.GFxUI.GFxObject>(Ptr + 1080); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1080); }
    }

    /// <summary>
    /// ObjectProperty: ManagerRef
    /// </summary>
    public unsafe BmSDK.BmGame.MWBIDOverlayManager ManagerRef
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.MWBIDOverlayManager>(Ptr + 1088); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1088); }
    }

    /// <summary>
    /// ObjectProperty: DataMessage
    /// </summary>
    public unsafe BmSDK.BmGame.MWBIDDataMessage DataMessage
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.MWBIDDataMessage>(Ptr + 1096); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1096); }
    }

    /// <summary>
    /// ObjectProperty: MainMenu
    /// </summary>
    public unsafe BmSDK.BmScript.RGFxMovieUI_MainMenu MainMenu
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmScript.RGFxMovieUI_MainMenu>(Ptr + 1104); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1104); }
    }

    /// <summary>
    /// ObjectProperty: RewardsMenu
    /// </summary>
    public unsafe BmSDK.BmScript.RGFxMovieUI_WBIDUnlocksAndRewards RewardsMenu
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmScript.RGFxMovieUI_WBIDUnlocksAndRewards>(Ptr + 1112); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1112); }
    }
}
