#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmScript;

/// <summary>
/// Class: RGFxMovieUI_InGameStore<br/>
/// (size = 0)
/// (flags = 0)
/// </summary>
public partial class RGFxMovieUI_InGameStore : BmSDK.BmGame.RGFxMovieUI, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmScript.RGFxMovieUI_InGameStore", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RGFxMovieUI_InGameStore() { }

    /// <summary>
    /// Constructs a new RGFxMovieUI_InGameStore
    /// </summary>
    public RGFxMovieUI_InGameStore(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RGFxMovieUI_InGameStore Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RGFxMovieUI_InGameStore(nint ptr) : base(ptr) { }

    /// <summary>
    /// StrProperty: sManifest
    /// </summary>
    public unsafe BmSDK.FString sManifest
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
    /// ArrayProperty: m_aStoreContent
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<System.IntPtr>>>> m_aStoreContent
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<System.IntPtr>>>>>(Ptr + 1104); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1104); }
    }

    /// <summary>
    /// ArrayProperty: m_aSWFTest
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<System.IntPtr>>> m_aSWFTest
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<System.IntPtr>>>>(Ptr + 1120); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1120); }
    }

    /// <summary>
    /// ArrayProperty: m_aActiveCustomRequestIds
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.TArray<System.IntPtr>> m_aActiveCustomRequestIds
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.TArray<System.IntPtr>>>(Ptr + 1136); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1136); }
    }

    /// <summary>
    /// BoolProperty: m_bStoreContentEnumerated
    /// </summary>
    public unsafe bool m_bStoreContentEnumerated
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1152) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1152); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1152); }
    }

    /// <summary>
    /// BoolProperty: m_bStoreContentSuccessful
    /// </summary>
    public unsafe bool m_bStoreContentSuccessful
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1152) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1152); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1152); }
    }

    /// <summary>
    /// BoolProperty: m_bHydraContentEnumerated
    /// </summary>
    public unsafe bool m_bHydraContentEnumerated
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1152) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1152); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1152); }
    }

    /// <summary>
    /// BoolProperty: m_bHydraContentSuccessful
    /// </summary>
    public unsafe bool m_bHydraContentSuccessful
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1152) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1152); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1152); }
    }

    /// <summary>
    /// BoolProperty: bXYAvailable
    /// </summary>
    public unsafe bool bXYAvailable
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1152) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1152); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1152); }
    }

    /// <summary>
    /// BoolProperty: m_bSteamDLCPriceContentEnumerated
    /// </summary>
    public unsafe bool m_bSteamDLCPriceContentEnumerated
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1152) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1152); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1152); }
    }

    /// <summary>
    /// ArrayProperty: m_aHydraTrackingInfo
    /// </summary>
    public unsafe BmSDK.TArray<System.IntPtr> m_aHydraTrackingInfo
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<System.IntPtr>>(Ptr + 1156); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1156); }
    }

    /// <summary>
    /// DelegateProperty: __CustomManifestLoadedIGS__Delegate
    /// </summary>
    public unsafe System.IntPtr __CustomManifestLoadedIGS__Delegate
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.IntPtr>(Ptr + 1172); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1172); }
    }

    /// <summary>
    /// DelegateProperty: __CustomContentLoadedIGS__Delegate
    /// </summary>
    public unsafe System.IntPtr __CustomContentLoadedIGS__Delegate
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.IntPtr>(Ptr + 1188); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1188); }
    }
}
