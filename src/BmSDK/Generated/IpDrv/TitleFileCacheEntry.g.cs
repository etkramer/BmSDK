#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.IpDrv;

/// <summary>
/// Class: TitleFileCacheEntry<br/>
/// (size = 138)
/// (flags = 134217874)
/// </summary>
public partial class TitleFileCacheEntry : BmSDK.GameObject, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "IpDrv.TitleFileCacheEntry", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal TitleFileCacheEntry() { }

    /// <summary>
    /// Constructs a new TitleFileCacheEntry
    /// </summary>
    public TitleFileCacheEntry(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, TitleFileCacheEntry Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected TitleFileCacheEntry(nint ptr) : base(ptr) { }

    /// <summary>
    /// StrProperty: Filename
    /// </summary>
    public unsafe BmSDK.FString Filename
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 84); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 84); }
    }

    /// <summary>
    /// ArrayProperty: Data
    /// </summary>
    public unsafe BmSDK.TArray<byte> Data
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<byte>>(Ptr + 100); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 100); }
    }

    /// <summary>
    /// StrProperty: LogicalName
    /// </summary>
    public unsafe BmSDK.FString LogicalName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 116); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 116); }
    }

    /// <summary>
    /// IntProperty: Hash
    /// </summary>
    public unsafe int Hash
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 132); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 132); }
    }

    /// <summary>
    /// ByteProperty: FileOp
    /// </summary>
    public unsafe BmSDK.IpDrv.TitleFileCacheEntry.ETitleFileFileOp FileOp
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.IpDrv.TitleFileCacheEntry.ETitleFileFileOp>(Ptr + 136); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 136); }
    }

    /// <summary>
    /// ByteProperty: AsyncState
    /// </summary>
    public unsafe BmSDK.Engine.OnlineSubsystem.EOnlineEnumerationReadState AsyncState
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.OnlineSubsystem.EOnlineEnumerationReadState>(Ptr + 137); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 137); }
    }

    /// <summary>
    /// Enum: ETitleFileFileOp
    /// </summary>
    public enum ETitleFileFileOp
    {
        TitleFile_None = 0,
        TitleFile_Save = 1,
        TitleFile_Load = 2,
        TitleFile_Delete = 3,
        TitleFile_MAX = 4,
    }
}
