#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: MWBIDEmailFormScreenMessage<br/>
/// (size = 0)
/// (flags = 0)
/// </summary>
public partial class MWBIDEmailFormScreenMessage : BmSDK.BmGame.MWBIDDataMessage, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.MWBIDEmailFormScreenMessage", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal MWBIDEmailFormScreenMessage() { }

    /// <summary>
    /// Constructs a new MWBIDEmailFormScreenMessage
    /// </summary>
    public MWBIDEmailFormScreenMessage(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, MWBIDEmailFormScreenMessage Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected MWBIDEmailFormScreenMessage(nint ptr) : base(ptr) { }

    /// <summary>
    /// StructProperty: WBIDAccountInfo
    /// </summary>
    public unsafe BmSDK.BmGame.MWBIDEmailFormScreenMessage.FUserData WBIDAccountInfo
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.MWBIDEmailFormScreenMessage.FUserData>(Ptr + 92); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 92); }
    }

    /// <summary>
    /// Enum: ButtonGroup_EmailForm
    /// </summary>
    public enum ButtonGroup_EmailForm
    {
        BGEF_Entry1 = 0,
        BGEF_Entry2 = 1,
        BGEF_HidePassword = 2,
        BGEF_ReceiveEmails = 3,
        BGEF_AgeDropDown = 4,
        BGEF_Accept = 5,
        BGEF_ForgetPass = 6,
        BGEF_MAX = 7,
    }

    /// <summary>
    /// Struct: FUserData
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 0)]
    public partial record struct FUserData
    {
        /// <summary>
        /// StrProperty: Email
        /// </summary>
        public unsafe BmSDK.FString Email
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// StrProperty: Password
        /// </summary>
        public unsafe BmSDK.FString Password
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 16); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 16); }; }
        }

        /// <summary>
        /// BoolProperty: bReceiveEmails
        /// </summary>
        public unsafe bool bReceiveEmails
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 32) & 1) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 32); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 32); }; }
        }

        /// <summary>
        /// IntProperty: PlayerAge
        /// </summary>
        public unsafe int PlayerAge
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 36); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 36); }; }
        }

        /// <summary>
        /// BoolProperty: bIsValidAge
        /// </summary>
        public unsafe bool bIsValidAge
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 40) & 1) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 40); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 40); }; }
        }
    }
}
