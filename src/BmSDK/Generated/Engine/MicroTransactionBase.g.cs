#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Class: MicroTransactionBase<br/>
/// (size = 0)
/// (flags = 0)
/// </summary>
public partial class MicroTransactionBase : BmSDK.Engine.PlatformInterfaceBase, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Engine.MicroTransactionBase", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal MicroTransactionBase() { }

    /// <summary>
    /// Constructs a new MicroTransactionBase
    /// </summary>
    public MicroTransactionBase(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, MicroTransactionBase Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected MicroTransactionBase(nint ptr) : base(ptr) { }

    /// <summary>
    /// ArrayProperty: AvailableProducts
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.Engine.MicroTransactionBase.FPurchaseInfo> AvailableProducts
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.MicroTransactionBase.FPurchaseInfo>>(Ptr + 116); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 116); }
    }

    /// <summary>
    /// StrProperty: LastError
    /// </summary>
    public unsafe BmSDK.FString LastError
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 132); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 132); }
    }

    /// <summary>
    /// StrProperty: LastErrorSolution
    /// </summary>
    public unsafe BmSDK.FString LastErrorSolution
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 148); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 148); }
    }

    /// <summary>
    /// Struct: FPurchaseInfo
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 0)]
    public partial record struct FPurchaseInfo
    {
        /// <summary>
        /// StrProperty: Identifier
        /// </summary>
        public unsafe BmSDK.FString Identifier
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// StrProperty: DisplayName
        /// </summary>
        public unsafe BmSDK.FString DisplayName
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 16); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 16); }; }
        }

        /// <summary>
        /// StrProperty: DisplayDescription
        /// </summary>
        public unsafe BmSDK.FString DisplayDescription
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 32); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 32); }; }
        }

        /// <summary>
        /// StrProperty: DisplayPrice
        /// </summary>
        public unsafe BmSDK.FString DisplayPrice
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 48); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 48); }; }
        }
    }

    /// <summary>
    /// Enum: EMicroTransactionResult
    /// </summary>
    public enum EMicroTransactionResult
    {
        MTR_Succeeded = 0,
        MTR_Failed = 1,
        MTR_Canceled = 2,
        MTR_RestoredFromServer = 3,
        MTR_MAX = 4,
    }

    /// <summary>
    /// Enum: EMicroTransactionDelegate
    /// </summary>
    public enum EMicroTransactionDelegate
    {
        MTD_PurchaseQueryComplete = 0,
        MTD_PurchaseComplete = 1,
        MTD_MAX = 2,
    }
}
