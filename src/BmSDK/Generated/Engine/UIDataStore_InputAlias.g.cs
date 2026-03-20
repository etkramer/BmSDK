#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Class: UIDataStore_InputAlias<br/>
/// (size = 0)
/// (flags = 0)
/// </summary>
public partial class UIDataStore_InputAlias : BmSDK.Engine.UIDataStore_StringBase, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Engine.UIDataStore_InputAlias", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal UIDataStore_InputAlias() { }

    /// <summary>
    /// Constructs a new UIDataStore_InputAlias
    /// </summary>
    public UIDataStore_InputAlias(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, UIDataStore_InputAlias Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected UIDataStore_InputAlias(nint ptr) : base(ptr) { }

    /// <summary>
    /// ArrayProperty: InputAliases
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.Engine.UIDataStore_InputAlias.FUIDataStoreInputAlias> InputAliases
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.UIDataStore_InputAlias.FUIDataStoreInputAlias>>(Ptr + 148); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 148); }
    }

    /// <summary>
    /// MapProperty: InputAliasLookupMap
    /// </summary>
    public unsafe BmSDK.TMap<object, object> /* TODO */ InputAliasLookupMap
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TMap<object, object> /* TODO */>(Ptr + 164); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 164); }
    }

    /// <summary>
    /// Struct: FUIDataStoreInputAlias
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 0)]
    public partial record struct FUIDataStoreInputAlias
    {
        /// <summary>
        /// NameProperty: AliasName
        /// </summary>
        public unsafe BmSDK.FName AliasName
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// StructProperty: PlatformInputKeys
        /// </summary>
        public unsafe BmSDK.Engine.UIDataStore_InputAlias.FUIInputKeyData PlatformInputKeys_0
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.UIDataStore_InputAlias.FUIInputKeyData>(Ptr + 8); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8); }; }
        }
        /// <summary>
        /// StructProperty: PlatformInputKeys
        /// </summary>
        public unsafe BmSDK.Engine.UIDataStore_InputAlias.FUIInputKeyData PlatformInputKeys_1
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.UIDataStore_InputAlias.FUIInputKeyData>(Ptr + 36); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 36); }; }
        }
        /// <summary>
        /// StructProperty: PlatformInputKeys
        /// </summary>
        public unsafe BmSDK.Engine.UIDataStore_InputAlias.FUIInputKeyData PlatformInputKeys_2
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.UIDataStore_InputAlias.FUIInputKeyData>(Ptr + 64); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 64); }; }
        }
    }

    /// <summary>
    /// Struct: FUIInputKeyData
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 0)]
    public partial record struct FUIInputKeyData
    {
        /// <summary>
        /// StructProperty: InputKeyData
        /// </summary>
        public unsafe BmSDK.Engine.UIRoot.FRawInputKeyEventData InputKeyData
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.UIRoot.FRawInputKeyEventData>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// StrProperty: ButtonFontMarkupString
        /// </summary>
        public unsafe BmSDK.FString ButtonFontMarkupString
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 12); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 12); }; }
        }
    }
}
