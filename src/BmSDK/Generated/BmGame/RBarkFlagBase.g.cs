#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RBarkFlagBase<br/>
/// (size = 0)
/// (flags = 0)
/// </summary>
public partial class RBarkFlagBase : BmSDK.GameObject, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RBarkFlagBase", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RBarkFlagBase() { }

    /// <summary>
    /// Constructs a new RBarkFlagBase
    /// </summary>
    public RBarkFlagBase(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RBarkFlagBase Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RBarkFlagBase(nint ptr) : base(ptr) { }

    /// <summary>
    /// ArrayProperty: FlagList
    /// </summary>
    public unsafe NEED_UPDATE_ARRAYPROPERTY_LAYOUT FlagList
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_ARRAYPROPERTY_LAYOUT>(Ptr + 84); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 84); }
    }

    /// <summary>
    /// Struct: FBarkFlag
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 0)]
    public partial record struct FBarkFlag
    {
        /// <summary>
        /// ByteProperty: FlagType
        /// </summary>
        public unsafe byte FlagType
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// ArrayProperty: FlagName
        /// </summary>
        public unsafe NEED_UPDATE_ARRAYPROPERTY_LAYOUT FlagName
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_ARRAYPROPERTY_LAYOUT>(Ptr + 4); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4); }; }
        }
    }

    /// <summary>
    /// Enum: EBarkDeliveryType
    /// </summary>
    public enum EBarkDeliveryType
    {
        BDT_DoNotCare = 0,
        BDT_Spoken = 1,
        BDT_Shouted = 2,
        BDT_Auto = 3,
        BDT_MAX = 4,
    }
}
