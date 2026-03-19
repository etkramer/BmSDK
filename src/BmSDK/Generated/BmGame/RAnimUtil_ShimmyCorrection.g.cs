#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RAnimUtil_ShimmyCorrection<br/>
/// (size = 0)
/// (flags = 0)
/// </summary>
public partial class RAnimUtil_ShimmyCorrection : BmSDK.GameObject, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RAnimUtil_ShimmyCorrection", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RAnimUtil_ShimmyCorrection() { }

    /// <summary>
    /// Constructs a new RAnimUtil_ShimmyCorrection
    /// </summary>
    public RAnimUtil_ShimmyCorrection(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RAnimUtil_ShimmyCorrection Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RAnimUtil_ShimmyCorrection(nint ptr) : base(ptr) { }

    /// <summary>
    /// FloatProperty: OverextensionCompensationWidth
    /// </summary>
    public unsafe float OverextensionCompensationWidth
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 84); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 84); }
    }

    /// <summary>
    /// StructProperty: Arms
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT Arms_0
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 88); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 88); }
    }
    /// <summary>
    /// StructProperty: Arms
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT Arms_1
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 104); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 104); }
    }

    /// <summary>
    /// StructProperty: Debug
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT Debug
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 128); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 128); }
    }

    /// <summary>
    /// BoolProperty: Active
    /// </summary>
    public unsafe bool Active
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 480) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 480); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 480); }
    }

    /// <summary>
    /// StructProperty: WorldspaceLedgeLeftTranslation
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT WorldspaceLedgeLeftTranslation
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 484); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 484); }
    }

    /// <summary>
    /// StructProperty: WorldspaceLedgeRightTranslation
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT WorldspaceLedgeRightTranslation
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 496); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 496); }
    }

    /// <summary>
    /// StructProperty: LeftHandOffset
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT LeftHandOffset
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 508); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 508); }
    }

    /// <summary>
    /// StructProperty: RightHandOffset
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT RightHandOffset
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 520); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 520); }
    }

    /// <summary>
    /// Struct: FShimmyArm
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 0)]
    public partial record struct FShimmyArm
    {
        /// <summary>
        /// IntProperty: Clavicle
        /// </summary>
        public unsafe int Clavicle
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// IntProperty: UpperArm
        /// </summary>
        public unsafe int UpperArm
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4); }; }
        }

        /// <summary>
        /// IntProperty: Forearm
        /// </summary>
        public unsafe int Forearm
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8); }; }
        }

        /// <summary>
        /// IntProperty: Hand
        /// </summary>
        public unsafe int Hand
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 12); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 12); }; }
        }
    }
}
