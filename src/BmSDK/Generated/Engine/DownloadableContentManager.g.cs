#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Class: DownloadableContentManager<br/>
/// (size = 0)
/// (flags = 0)
/// </summary>
public partial class DownloadableContentManager : BmSDK.GameObject, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Engine.DownloadableContentManager", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal DownloadableContentManager() { }

    /// <summary>
    /// Constructs a new DownloadableContentManager
    /// </summary>
    public DownloadableContentManager(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, DownloadableContentManager Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected DownloadableContentManager(nint ptr) : base(ptr) { }

    /// <summary>
    /// ArrayProperty: DLCConfigCacheChanges
    /// </summary>
    public unsafe NEED_UPDATE_ARRAYPROPERTY_LAYOUT DLCConfigCacheChanges
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_ARRAYPROPERTY_LAYOUT>(Ptr + 84); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 84); }
    }

    /// <summary>
    /// ArrayProperty: InstalledDLC
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.TArray<System.IntPtr>> InstalledDLC
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.TArray<System.IntPtr>>>(Ptr + 100); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 100); }
    }

    /// <summary>
    /// StructProperty: NonPackageFilePathMap
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT NonPackageFilePathMap
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 116); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 116); }
    }

    /// <summary>
    /// StructProperty: RockDLCCachePathMap
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT RockDLCCachePathMap
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 188); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 188); }
    }

    /// <summary>
    /// ArrayProperty: ClassesToReload
    /// </summary>
    public unsafe NEED_UPDATE_ARRAYPROPERTY_LAYOUT ClassesToReload
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_ARRAYPROPERTY_LAYOUT>(Ptr + 260); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 260); }
    }

    /// <summary>
    /// ArrayProperty: ObjectsToReload
    /// </summary>
    public unsafe NEED_UPDATE_ARRAYPROPERTY_LAYOUT ObjectsToReload
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_ARRAYPROPERTY_LAYOUT>(Ptr + 276); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 276); }
    }

    /// <summary>
    /// ArrayProperty: QueuedFullyLoadPackageInis
    /// </summary>
    public unsafe BmSDK.TArray<System.IntPtr> QueuedFullyLoadPackageInis
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<System.IntPtr>>(Ptr + 292); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 292); }
    }

    /// <summary>
    /// ObjectProperty: GameEngine
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT GameEngine
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 308); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 308); }
    }

    /// <summary>
    /// DelegateProperty: __OnRefreshComplete__Delegate
    /// </summary>
    public unsafe System.IntPtr __OnRefreshComplete__Delegate
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.IntPtr>(Ptr + 316); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 316); }
    }
}
