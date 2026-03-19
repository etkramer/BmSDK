#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RGFxMovieUI_Pause<br/>
/// (size = 0)
/// (flags = 0)
/// </summary>
public partial class RGFxMovieUI_Pause : BmSDK.BmGame.RGFxMovieUI_PauseBase, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RGFxMovieUI_Pause", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RGFxMovieUI_Pause() { }

    /// <summary>
    /// Constructs a new RGFxMovieUI_Pause
    /// </summary>
    public RGFxMovieUI_Pause(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RGFxMovieUI_Pause Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RGFxMovieUI_Pause(nint ptr) : base(ptr) { }

    /// <summary>
    /// IntProperty: GoSubScreen
    /// </summary>
    public unsafe int GoSubScreen
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1612); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1612); }
    }

    /// <summary>
    /// IntProperty: PopupType
    /// </summary>
    public unsafe int PopupType
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1616); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1616); }
    }

    /// <summary>
    /// BoolProperty: bLeavePaused
    /// </summary>
    public unsafe bool bLeavePaused
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1620) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1620); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1620); }
    }

    /// <summary>
    /// BoolProperty: bGoingBack
    /// </summary>
    public unsafe bool bGoingBack
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1620) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1620); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1620); }
    }

    /// <summary>
    /// BoolProperty: bPhotoModeFocus
    /// </summary>
    public unsafe bool bPhotoModeFocus
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1620) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1620); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1620); }
    }

    /// <summary>
    /// ObjectProperty: ActivePopup
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT ActivePopup
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 1624); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1624); }
    }

    /// <summary>
    /// Enum: PopUpTypes
    /// </summary>
    public enum PopUpTypes
    {
        PT_None = 0,
        PT_Restart = 1,
        PT_EndChallenge = 2,
        PT_ExitGame = 3,
        PT_MAX = 4,
    }
}
