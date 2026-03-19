#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Class: OnlineStatsRead<br/>
/// (size = 0)
/// (flags = 0)
/// </summary>
public partial class OnlineStatsRead : BmSDK.Engine.OnlineStats, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Engine.OnlineStatsRead", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal OnlineStatsRead() { }

    /// <summary>
    /// Constructs a new OnlineStatsRead
    /// </summary>
    public OnlineStatsRead(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, OnlineStatsRead Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected OnlineStatsRead(nint ptr) : base(ptr) { }

    /// <summary>
    /// IntProperty: ViewId
    /// </summary>
    public unsafe int ViewId
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 100); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 100); }
    }

    /// <summary>
    /// IntProperty: SortColumnId
    /// </summary>
    public unsafe int SortColumnId
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 104); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 104); }
    }

    /// <summary>
    /// ArrayProperty: ColumnIds
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.FString>>> ColumnIds
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.FString>>>>(Ptr + 108); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 108); }
    }

    /// <summary>
    /// IntProperty: TotalRowsInView
    /// </summary>
    public unsafe int TotalRowsInView
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 124); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 124); }
    }

    /// <summary>
    /// ArrayProperty: Rows
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.TArray<BmSDK.FString>> Rows
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.TArray<BmSDK.FString>>>(Ptr + 128); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 128); }
    }

    /// <summary>
    /// ArrayProperty: ColumnMappings
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.FString> ColumnMappings
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.FString>>(Ptr + 144); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 144); }
    }

    /// <summary>
    /// StrProperty: ViewName
    /// </summary>
    public unsafe BmSDK.FString ViewName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 160); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 160); }
    }

    /// <summary>
    /// IntProperty: TitleId
    /// </summary>
    public unsafe int TitleId
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 176); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 176); }
    }

    /// <summary>
    /// Struct: FOnlineStatsRow
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 0)]
    public partial record struct FOnlineStatsRow
    {
        /// <summary>
        /// StructProperty: PlayerID
        /// </summary>
        public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT PlayerID
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// StructProperty: Rank
        /// </summary>
        public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT Rank
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 8); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8); }; }
        }

        /// <summary>
        /// StrProperty: NickName
        /// </summary>
        public unsafe BmSDK.FString NickName
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 24); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 24); }; }
        }

        /// <summary>
        /// ArrayProperty: Columns
        /// </summary>
        public unsafe NEED_UPDATE_ARRAYPROPERTY_LAYOUT Columns
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_ARRAYPROPERTY_LAYOUT>(Ptr + 40); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 40); }; }
        }
    }

    /// <summary>
    /// Struct: FOnlineStatsColumn
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 0)]
    public partial record struct FOnlineStatsColumn
    {
        /// <summary>
        /// IntProperty: ColumnNo
        /// </summary>
        public unsafe int ColumnNo
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// StructProperty: StatValue
        /// </summary>
        public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT StatValue
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 4); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4); }; }
        }
    }
}
