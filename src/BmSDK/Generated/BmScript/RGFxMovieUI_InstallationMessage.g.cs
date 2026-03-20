#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmScript;

/// <summary>
/// Class: RGFxMovieUI_InstallationMessage<br/>
/// (flags = 0)
/// </summary>
public partial class RGFxMovieUI_InstallationMessage : BmSDK.BmGame.RGFxMovieUI, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmScript.RGFxMovieUI_InstallationMessage", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RGFxMovieUI_InstallationMessage() { }

    /// <summary>
    /// Constructs a new RGFxMovieUI_InstallationMessage
    /// </summary>
    public RGFxMovieUI_InstallationMessage(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RGFxMovieUI_InstallationMessage Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RGFxMovieUI_InstallationMessage(nint ptr) : base(ptr) { }

    /// <summary>
    /// IntProperty: InstallChunkRequired
    /// </summary>
    public unsafe int InstallChunkRequired
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1072); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1072); }
    }

    /// <summary>
    /// ObjectProperty: TheAction
    /// </summary>
    public unsafe BmSDK.BmScript.RSeqAct_EnsureChunkInstalled TheAction
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmScript.RSeqAct_EnsureChunkInstalled>(Ptr + 1076); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1076); }
    }

    /// <summary>
    /// ObjectProperty: TheTriggeringUI
    /// </summary>
    public unsafe BmSDK.BmGame.RGFxMovieUI TheTriggeringUI
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RGFxMovieUI>(Ptr + 1084); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1084); }
    }

    /// <summary>
    /// ObjectProperty: ActivePopup
    /// </summary>
    public unsafe BmSDK.BmGame.RGFxMoviePopupRequester ActivePopup
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RGFxMoviePopupRequester>(Ptr + 1092); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1092); }
    }

    /// <summary>
    /// ByteProperty: PopupType
    /// </summary>
    public unsafe BmSDK.BmScript.RGFxMovieUI_InstallationMessage.PopUpTypes PopupType
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmScript.RGFxMovieUI_InstallationMessage.PopUpTypes>(Ptr + 1100); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1100); }
    }

    /// <summary>
    /// BoolProperty: bInstalled
    /// </summary>
    public unsafe bool bInstalled
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1104) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1104); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1104); }
    }

    /// <summary>
    /// BoolProperty: bCancelled
    /// </summary>
    public unsafe bool bCancelled
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1104) & 2) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1104); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1104); }
    }

    /// <summary>
    /// BoolProperty: bError
    /// </summary>
    public unsafe bool bError
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1104) & 4) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1104); var newMask = value ? (currentMask | 4) : (currentMask & ~4); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1104); }
    }

    /// <summary>
    /// IntProperty: Percent
    /// </summary>
    public unsafe int Percent
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1108); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1108); }
    }

    /// <summary>
    /// Enum: PopUpTypes
    /// </summary>
    public enum PopUpTypes
    {
        PT_None = 0,
        PT_Error = 1,
        PT_Exit = 2,
        PT_MAX = 3,
    }
}
