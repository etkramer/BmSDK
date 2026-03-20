#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.IpDrv;

/// <summary>
/// Class: TitleFileDownloadCache<br/>
/// (size = 0)
/// (flags = 0)
/// </summary>
public partial class TitleFileDownloadCache : BmSDK.IpDrv.MCPBase, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "IpDrv.TitleFileDownloadCache", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal TitleFileDownloadCache() { }

    /// <summary>
    /// Constructs a new TitleFileDownloadCache
    /// </summary>
    public TitleFileDownloadCache(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, TitleFileDownloadCache Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected TitleFileDownloadCache(nint ptr) : base(ptr) { }

    /// <summary>
    /// ObjectProperty: OnlineSub
    /// </summary>
    public unsafe BmSDK.Engine.OnlineSubsystem OnlineSub
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.OnlineSubsystem>(Ptr + 116); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 116); }
    }

    /// <summary>
    /// ArrayProperty: TitleFiles
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.IpDrv.TitleFileCacheEntry> TitleFiles
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.IpDrv.TitleFileCacheEntry>>(Ptr + 124); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 124); }
    }

    /// <summary>
    /// ArrayProperty: LoadCompleteDelegates
    /// </summary>
    public unsafe BmSDK.TArray<System.IntPtr> LoadCompleteDelegates
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<System.IntPtr>>(Ptr + 140); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 140); }
    }

    /// <summary>
    /// ArrayProperty: SaveCompleteDelegates
    /// </summary>
    public unsafe BmSDK.TArray<System.IntPtr> SaveCompleteDelegates
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<System.IntPtr>>(Ptr + 156); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 156); }
    }

    /// <summary>
    /// ArrayProperty: DeleteCompleteDelegates
    /// </summary>
    public unsafe BmSDK.TArray<System.IntPtr> DeleteCompleteDelegates
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<System.IntPtr>>(Ptr + 172); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 172); }
    }

    /// <summary>
    /// DelegateProperty: __OnLoadTitleFileComplete__Delegate
    /// </summary>
    public unsafe System.IntPtr __OnLoadTitleFileComplete__Delegate
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.IntPtr>(Ptr + 188); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 188); }
    }

    /// <summary>
    /// DelegateProperty: __OnSaveTitleFileComplete__Delegate
    /// </summary>
    public unsafe System.IntPtr __OnSaveTitleFileComplete__Delegate
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.IntPtr>(Ptr + 204); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 204); }
    }

    /// <summary>
    /// DelegateProperty: __OnDeleteTitleFileComplete__Delegate
    /// </summary>
    public unsafe System.IntPtr __OnDeleteTitleFileComplete__Delegate
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.IntPtr>(Ptr + 220); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 220); }
    }
}
