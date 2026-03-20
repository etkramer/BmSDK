#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Class: DataStoreClient<br/>
/// (flags = 0)
/// </summary>
public partial class DataStoreClient : BmSDK.Engine.UIRoot, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Engine.DataStoreClient", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal DataStoreClient() { }

    /// <summary>
    /// Constructs a new DataStoreClient
    /// </summary>
    public DataStoreClient(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, DataStoreClient Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected DataStoreClient(nint ptr) : base(ptr) { }

    /// <summary>
    /// ArrayProperty: GlobalDataStoreClasses
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.FString> GlobalDataStoreClasses
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.FString>>(Ptr + 108); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 108); }
    }

    /// <summary>
    /// ArrayProperty: GlobalDataStores
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.Engine.UIDataStore> GlobalDataStores
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.UIDataStore>>(Ptr + 124); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 124); }
    }

    /// <summary>
    /// ArrayProperty: PlayerDataStoreClassNames
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.FString> PlayerDataStoreClassNames
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.FString>>(Ptr + 140); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 140); }
    }

    /// <summary>
    /// ArrayProperty: PlayerDataStoreClasses
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.Class> PlayerDataStoreClasses
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Class>>(Ptr + 156); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 156); }
    }

    /// <summary>
    /// ArrayProperty: PlayerDataStores
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.Engine.DataStoreClient.FPlayerDataStoreGroup> PlayerDataStores
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.DataStoreClient.FPlayerDataStoreGroup>>(Ptr + 172); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 172); }
    }

    /// <summary>
    /// Struct: FPlayerDataStoreGroup
    /// </summary>
    [StructLayout(LayoutKind.Explicit)]
    public partial record struct FPlayerDataStoreGroup
    {
        /// <summary>
        /// ObjectProperty: PlayerOwner
        /// </summary>
        public unsafe BmSDK.Engine.LocalPlayer PlayerOwner
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.LocalPlayer>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// ArrayProperty: DataStores
        /// </summary>
        public unsafe BmSDK.TArray<BmSDK.Engine.UIDataStore> DataStores
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.UIDataStore>>(Ptr + 8); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8); }; }
        }
    }
}
