#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RBarkSet<br/>
/// (flags = 0)
/// </summary>
public partial class RBarkSet : BmSDK.Engine.AkHash, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RBarkSet", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RBarkSet() { }

    /// <summary>
    /// Constructs a new RBarkSet
    /// </summary>
    public RBarkSet(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RBarkSet Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RBarkSet(nint ptr) : base(ptr) { }

    /// <summary>
    /// Struct: FMapProxyForSaving
    /// </summary>
    [StructLayout(LayoutKind.Explicit)]
    public partial record struct FMapProxyForSaving
    {
        /// <summary>
        /// NameProperty: Key
        /// </summary>
        public unsafe BmSDK.FName Key
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// ArrayProperty: BarkList
        /// </summary>
        public unsafe BmSDK.TArray<BmSDK.BmGame.RBarkConvo> BarkList
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RBarkConvo>>(Ptr + 8); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8); }; }
        }
    }

    /// <summary>
    /// ArrayProperty: BarkConvos
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RBarkConvo> BarkConvos
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RBarkConvo>>(Ptr + 92); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 92); }
    }

    /// <summary>
    /// ArrayProperty: StoredEVM
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RBarkSet.FMapProxyForSaving> StoredEVM
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RBarkSet.FMapProxyForSaving>>(Ptr + 108); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 108); }
    }

    /// <summary>
    /// MapProperty: EventValMap
    /// </summary>
    public unsafe BmSDK.TMap<object, object> /* TODO */ EventValMap
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TMap<object, object> /* TODO */>(Ptr + 124); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 124); }
    }
}
