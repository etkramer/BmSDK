#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmScript;

/// <summary>
/// Class: RGFxMovieUI_BatCave<br/>
/// (size = 0)
/// (flags = 0)
/// </summary>
public partial class RGFxMovieUI_BatCave : BmSDK.BmGame.RGFxMovieUI, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmScript.RGFxMovieUI_BatCave", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RGFxMovieUI_BatCave() { }

    /// <summary>
    /// Constructs a new RGFxMovieUI_BatCave
    /// </summary>
    public RGFxMovieUI_BatCave(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RGFxMovieUI_BatCave Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RGFxMovieUI_BatCave(nint ptr) : base(ptr) { }

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
    /// ArrayProperty: m_aOriginalLevels
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<System.IntPtr>>> m_aOriginalLevels
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<System.IntPtr>>>>(Ptr + 1104); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1104); }
    }

    /// <summary>
    /// ArrayProperty: m_aLoadingLevels
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.TArray<System.IntPtr>> m_aLoadingLevels
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.TArray<System.IntPtr>>>(Ptr + 1120); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1120); }
    }

    /// <summary>
    /// ArrayProperty: m_aActiveLevels
    /// </summary>
    public unsafe BmSDK.TArray<System.IntPtr> m_aActiveLevels
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<System.IntPtr>>(Ptr + 1136); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1136); }
    }

    /// <summary>
    /// BoolProperty: m_bInspectReady
    /// </summary>
    public unsafe bool m_bInspectReady
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1152) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1152); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1152); }
    }

    /// <summary>
    /// BoolProperty: m_bSaveNeeded
    /// </summary>
    public unsafe bool m_bSaveNeeded
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1152) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1152); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1152); }
    }

    /// <summary>
    /// BoolProperty: m_bBatmobilesAlwaysAvailable
    /// </summary>
    public unsafe bool m_bBatmobilesAlwaysAvailable
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1152) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1152); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1152); }
    }

    /// <summary>
    /// BoolProperty: bAllowHarleySkin
    /// </summary>
    public unsafe bool bAllowHarleySkin
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1152) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1152); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1152); }
    }

    /// <summary>
    /// BoolProperty: bAllowRedhoodSkin
    /// </summary>
    public unsafe bool bAllowRedhoodSkin
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1152) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1152); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1152); }
    }

    /// <summary>
    /// IntProperty: m_nLoadedReferenceCount
    /// </summary>
    public unsafe int m_nLoadedReferenceCount
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1156); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1156); }
    }

    /// <summary>
    /// DelegateProperty: __CustomManifestLoadedSC__Delegate
    /// </summary>
    public unsafe System.IntPtr __CustomManifestLoadedSC__Delegate
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.IntPtr>(Ptr + 1160); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1160); }
    }

    /// <summary>
    /// DelegateProperty: __CustomContentLoadedSC__Delegate
    /// </summary>
    public unsafe System.IntPtr __CustomContentLoadedSC__Delegate
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.IntPtr>(Ptr + 1176); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1176); }
    }
}
