#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Class: LocHelper<br/>
/// (size = 0)
/// (flags = 0)
/// </summary>
public partial class LocHelper : BmSDK.GameObject, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Engine.LocHelper", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal LocHelper() { }

    /// <summary>
    /// Constructs a new LocHelper
    /// </summary>
    public LocHelper(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, LocHelper Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected LocHelper(nint ptr) : base(ptr) { }

    /// <summary>
    /// ArrayProperty: CountryCodeLookup
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.Engine.LocHelper.FCountryCodeMap> CountryCodeLookup
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.LocHelper.FCountryCodeMap>>(Ptr + 84); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 84); }
    }

    /// <summary>
    /// StrProperty: DefaultCountry
    /// </summary>
    public unsafe BmSDK.FString DefaultCountry
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 100); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 100); }
    }

    /// <summary>
    /// Struct: FCountryCodeMap
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 0)]
    public partial record struct FCountryCodeMap
    {
        /// <summary>
        /// StrProperty: CountryCode
        /// </summary>
        public unsafe BmSDK.FString CountryCode
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// StrProperty: TOS
        /// </summary>
        public unsafe BmSDK.FString TOS
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 16); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 16); }; }
        }

        /// <summary>
        /// StrProperty: PP
        /// </summary>
        public unsafe BmSDK.FString PP
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 32); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 32); }; }
        }

        /// <summary>
        /// IntProperty: PS4Age
        /// </summary>
        public unsafe int PS4Age
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 48); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 48); }; }
        }

        /// <summary>
        /// ByteProperty: XBoxAgeGroup
        /// </summary>
        public unsafe BmSDK.Engine.LocHelper.XBOX_AGEGROUP XBoxAgeGroup
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.LocHelper.XBOX_AGEGROUP>(Ptr + 52); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 52); }; }
        }
    }

    /// <summary>
    /// Enum: XBOX_AGEGROUP
    /// </summary>
    public enum XBOX_AGEGROUP
    {
        XBOX_AGEGROUP_UNKNOWN = 0,
        XBOX_AGEGROUP_CHILD = 1,
        XBOX_AGEGROUP_TEEN = 2,
        XBOX_AGEGROUP_ADULT = 3,
        XBOX_AGEGROUP_MAX = 4,
    }
}
