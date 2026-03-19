#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: MWBIDOverlayManager<br/>
/// (size = 0)
/// (flags = 0)
/// </summary>
public partial class MWBIDOverlayManager : BmSDK.GameObject, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.MWBIDOverlayManager", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal MWBIDOverlayManager() { }

    /// <summary>
    /// Constructs a new MWBIDOverlayManager
    /// </summary>
    public MWBIDOverlayManager(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, MWBIDOverlayManager Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected MWBIDOverlayManager(nint ptr) : base(ptr) { }

    /// <summary>
    /// ArrayProperty: LegalTextImage
    /// </summary>
    public unsafe NEED_UPDATE_ARRAYPROPERTY_LAYOUT LegalTextImage
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_ARRAYPROPERTY_LAYOUT>(Ptr + 84); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 84); }
    }

    /// <summary>
    /// ArrayProperty: GenericCookieImage
    /// </summary>
    public unsafe NEED_UPDATE_ARRAYPROPERTY_LAYOUT GenericCookieImage
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_ARRAYPROPERTY_LAYOUT>(Ptr + 100); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 100); }
    }

    /// <summary>
    /// BoolProperty: bIsWBIDLinked
    /// </summary>
    public unsafe bool bIsWBIDLinked
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 116) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 116); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 116); }
    }

    /// <summary>
    /// BoolProperty: bIsTOS
    /// </summary>
    public unsafe bool bIsTOS
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 116) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 116); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 116); }
    }

    /// <summary>
    /// BoolProperty: bIsOverlayLoaded
    /// </summary>
    public unsafe bool bIsOverlayLoaded
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 116) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 116); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 116); }
    }

    /// <summary>
    /// ArrayProperty: m_aSWFTest
    /// </summary>
    public unsafe BmSDK.TArray<System.IntPtr> m_aSWFTest
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<System.IntPtr>>(Ptr + 120); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 120); }
    }

    /// <summary>
    /// StructProperty: GenericOverlayData
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT GenericOverlayData
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 136); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 136); }
    }

    /// <summary>
    /// StructProperty: EmailFormPreData
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT EmailFormPreData
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 220); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 220); }
    }

    /// <summary>
    /// StructProperty: NetworkStatusData
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT NetworkStatusData
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 256); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 256); }
    }

    /// <summary>
    /// ByteProperty: QueuedScreen
    /// </summary>
    public unsafe byte QueuedScreen
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 356); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 356); }
    }

    /// <summary>
    /// ObjectProperty: OverlayController
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT OverlayController
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 360); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 360); }
    }

    /// <summary>
    /// DelegateProperty: __DataCallbackFnc__Delegate
    /// </summary>
    public unsafe System.IntPtr __DataCallbackFnc__Delegate
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.IntPtr>(Ptr + 368); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 368); }
    }

    /// <summary>
    /// Enum: NetworkDebugColourCode
    /// </summary>
    public enum NetworkDebugColourCode
    {
        NDCC_None = 0,
        NDCC_Red = 1,
        NDCC_Green = 2,
        NDCC_MAX = 3,
    }

    /// <summary>
    /// Enum: WBIDStatus
    /// </summary>
    public enum WBIDStatus
    {
        WBIDStatus_Initializing = 0,
        WBIDStatus_DisabledNotConnected = 1,
        WBIDStatus_DisabledNotSignedIn = 2,
        WBIDStatus_DisabledGameUpdateRequired = 3,
        WBIDStatus_DisabledNoHydra = 4,
        WBIDStatus_DisabledByKillSwitch = 5,
        WBIDStatus_DisabledIneligibleRegion = 6,
        WBIDStatus_DisabledIneligibleAge = 7,
        WBIDStatus_DisabledFailedToInitialize = 8,
        WBIDStatus_Online = 9,
        WBIDStatus_Offline = 10,
        WBIDStatus_OfflineButReadyForLinking = 11,
        WBIDStatus_MAX = 12,
    }

    /// <summary>
    /// Enum: E_WBID_Screen_Type
    /// </summary>
    public enum E_WBID_Screen_Type
    {
        EWSI_Main = 0,
        EWSI_Attract = 1,
        EWSI_Legal = 2,
        EWSI_Create = 3,
        EWSI_Link = 4,
        EWSI_Verify = 5,
        EWSI_VerifyReminder = 6,
        EWSI_Cookie = 7,
        EWSI_WBIDOptions = 8,
        EWSI_Generic = 9,
        EWSI_PleaseWait = 10,
        EWSI_NetworkDebug = 11,
        EWSI_None = 12,
        EWSI_MAX = 13,
    }
}
