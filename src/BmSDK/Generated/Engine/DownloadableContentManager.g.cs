#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Class: DownloadableContentManager<br/>
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
    public unsafe BmSDK.TArray<System.IntPtr> DLCConfigCacheChanges
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<System.IntPtr>>(Ptr + 84); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 84); }
    }

    /// <summary>
    /// ArrayProperty: InstalledDLC
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.FString> InstalledDLC
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.FString>>(Ptr + 100); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 100); }
    }

    /// <summary>
    /// StructProperty: NonPackageFilePathMap
    /// </summary>
    public unsafe BmSDK.GameObject.FMap_Mirror NonPackageFilePathMap
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.GameObject.FMap_Mirror>(Ptr + 116); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 116); }
    }

    /// <summary>
    /// StructProperty: RockDLCCachePathMap
    /// </summary>
    public unsafe BmSDK.GameObject.FMap_Mirror RockDLCCachePathMap
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.GameObject.FMap_Mirror>(Ptr + 188); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 188); }
    }

    /// <summary>
    /// ArrayProperty: ClassesToReload
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.Class> ClassesToReload
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Class>>(Ptr + 260); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 260); }
    }

    /// <summary>
    /// ArrayProperty: ObjectsToReload
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.GameObject> ObjectsToReload
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.GameObject>>(Ptr + 276); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 276); }
    }

    /// <summary>
    /// ArrayProperty: QueuedFullyLoadPackageInis
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.FString> QueuedFullyLoadPackageInis
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.FString>>(Ptr + 292); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 292); }
    }

    /// <summary>
    /// ObjectProperty: GameEngine
    /// </summary>
    public unsafe BmSDK.Engine.GameEngine GameEngine
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.GameEngine>(Ptr + 308); }
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
