#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RGFxMoviePopupRequester<br/>
/// (size = 0)
/// (flags = 0)
/// </summary>
public partial class RGFxMoviePopupRequester : BmSDK.BmGame.RGFxMovieUI, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RGFxMoviePopupRequester", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RGFxMoviePopupRequester() { }

    /// <summary>
    /// Constructs a new RGFxMoviePopupRequester
    /// </summary>
    public RGFxMoviePopupRequester(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RGFxMoviePopupRequester Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RGFxMoviePopupRequester(nint ptr) : base(ptr) { }

    /// <summary>
    /// ByteProperty: CurrentType
    /// </summary>
    public unsafe byte CurrentType
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 1072); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1072); }
    }

    /// <summary>
    /// ObjectProperty: RespondToMovie
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT RespondToMovie
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 1076); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1076); }
    }

    /// <summary>
    /// IntProperty: ButtonSelected
    /// </summary>
    public unsafe int ButtonSelected
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1084); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1084); }
    }

    /// <summary>
    /// StrProperty: TitleString
    /// </summary>
    public unsafe BmSDK.FString TitleString
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 1088); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1088); }
    }

    /// <summary>
    /// StrProperty: MessageString
    /// </summary>
    public unsafe BmSDK.FString MessageString
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 1104); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1104); }
    }

    /// <summary>
    /// ArrayProperty: MenuItems
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.FString> MenuItems
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.FString>>(Ptr + 1120); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1120); }
    }

    /// <summary>
    /// BoolProperty: bAllowBack
    /// </summary>
    public unsafe bool bAllowBack
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1136) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1136); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1136); }
    }

    /// <summary>
    /// BoolProperty: bButtonPressed
    /// </summary>
    public unsafe bool bButtonPressed
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1136) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1136); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1136); }
    }

    /// <summary>
    /// BoolProperty: bHasModifier
    /// </summary>
    public unsafe bool bHasModifier
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1136) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1136); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1136); }
    }

    /// <summary>
    /// BoolProperty: bDisableNavigation
    /// </summary>
    public unsafe bool bDisableNavigation
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1136) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1136); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1136); }
    }

    /// <summary>
    /// StrProperty: CountdownPath
    /// </summary>
    public unsafe BmSDK.FString CountdownPath
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 1140); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1140); }
    }

    /// <summary>
    /// StrProperty: KeyInputPath
    /// </summary>
    public unsafe BmSDK.FString KeyInputPath
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 1156); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1156); }
    }

    /// <summary>
    /// StrProperty: CurrentKeyBind
    /// </summary>
    public unsafe BmSDK.FString CurrentKeyBind
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 1172); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1172); }
    }

    /// <summary>
    /// StrProperty: KeyPressed
    /// </summary>
    public unsafe BmSDK.FString KeyPressed
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 1188); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1188); }
    }

    /// <summary>
    /// Enum: GPopup_Type
    /// </summary>
    public enum GPopup_Type
    {
        GPopup_Callback = 0,
        GPopup_AltF4Handler = 1,
        GPopup_StorageDeviceLost = 2,
        GPopup_DeviceSelectorRetry = 3,
        GPopup_OverwriteCheck = 4,
        GPopup_LoginStatusError = 5,
        GPopup_CorruptDLCError = 6,
        GPopup_PS3NotConnected = 7,
        GPopup_PS3NotLoggedIn = 8,
        GPopup_PS3NotConnectedRetry = 9,
        GPopup_PS3StatsWriteError = 10,
        GPopup_MAX = 11,
    }
}
