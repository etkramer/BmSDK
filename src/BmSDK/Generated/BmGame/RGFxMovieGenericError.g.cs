#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RGFxMovieGenericError<br/>
/// (flags = 0)
/// </summary>
public partial class RGFxMovieGenericError : BmSDK.BmGame.RGFxMovieUI, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RGFxMovieGenericError", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RGFxMovieGenericError() { }

    /// <summary>
    /// Constructs a new RGFxMovieGenericError
    /// </summary>
    public RGFxMovieGenericError(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RGFxMovieGenericError Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RGFxMovieGenericError(nint ptr) : base(ptr) { }

    /// <summary>
    /// ByteProperty: CurrentType
    /// </summary>
    public unsafe BmSDK.BmGame.RGFxMovieGenericError.GE_Type CurrentType
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RGFxMovieGenericError.GE_Type>(Ptr + 1072); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1072); }
    }

    /// <summary>
    /// StrProperty: LastFocusMovie
    /// </summary>
    public unsafe BmSDK.FString LastFocusMovie
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 1076); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1076); }
    }

    /// <summary>
    /// BoolProperty: bMonitorPS3
    /// </summary>
    public unsafe bool bMonitorPS3
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1092) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1092); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1092); }
    }

    /// <summary>
    /// IntProperty: ButtonSelected
    /// </summary>
    public unsafe int ButtonSelected
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1096); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1096); }
    }

    /// <summary>
    /// StrProperty: TitleString
    /// </summary>
    public unsafe BmSDK.FString TitleString
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 1100); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1100); }
    }

    /// <summary>
    /// StrProperty: MessageString
    /// </summary>
    public unsafe BmSDK.FString MessageString
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 1116); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1116); }
    }

    /// <summary>
    /// ArrayProperty: MenuItems
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.FString> MenuItems
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.FString>>(Ptr + 1132); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1132); }
    }

    /// <summary>
    /// ArrayProperty: BufferedPrompts
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RGFxMovieFrontMost.FPromptRecord> BufferedPrompts
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RGFxMovieFrontMost.FPromptRecord>>(Ptr + 1148); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1148); }
    }

    /// <summary>
    /// Enum: GE_Type
    /// </summary>
    public enum GE_Type
    {
        GE_StorageDeviceLost = 0,
        GE_DeviceSelectorRetry = 1,
        GE_OverwriteCheck = 2,
        GE_LoginStatusError = 3,
        GE_MsgOnlyError = 4,
        GE_CorruptDLCError = 5,
        GE_PS3NotConnected = 6,
        GE_PS3NotLoggedIn = 7,
        GE_PS3StatsWriteError = 8,
        GE_NotLoggedIn_ReturnToMainMenu = 9,
        GE_SaveRetry = 10,
        GE_DLC_ContentInstalledMsg = 11,
        GE_MAX = 12,
    }
}
