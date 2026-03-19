#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Class: AnimNodeAimOffset<br/>
/// (size = 0)
/// (flags = 0)
/// </summary>
public partial class AnimNodeAimOffset : BmSDK.Engine.AnimNodeBlendBase, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Engine.AnimNodeAimOffset", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal AnimNodeAimOffset() { }

    /// <summary>
    /// Constructs a new AnimNodeAimOffset
    /// </summary>
    public AnimNodeAimOffset(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, AnimNodeAimOffset Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected AnimNodeAimOffset(nint ptr) : base(ptr) { }

    /// <summary>
    /// StructProperty: Aim
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT Aim
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 304); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 304); }
    }

    /// <summary>
    /// StructProperty: AngleOffset
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT AngleOffset
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 312); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 312); }
    }

    /// <summary>
    /// BoolProperty: bForceAimDir
    /// </summary>
    public unsafe bool bForceAimDir
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 320) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 320); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 320); }
    }

    /// <summary>
    /// BoolProperty: bBakeFromAnimations
    /// </summary>
    public unsafe bool bBakeFromAnimations
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 320) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 320); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 320); }
    }

    /// <summary>
    /// BoolProperty: bPassThroughWhenNotRendered
    /// </summary>
    public unsafe bool bPassThroughWhenNotRendered
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 320) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 320); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 320); }
    }

    /// <summary>
    /// BoolProperty: bSynchronizeNodesInEditor
    /// </summary>
    public unsafe bool bSynchronizeNodesInEditor
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 320) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 320); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 320); }
    }

    /// <summary>
    /// IntProperty: PassThroughAtOrAboveLOD
    /// </summary>
    public unsafe int PassThroughAtOrAboveLOD
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 324); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 324); }
    }

    /// <summary>
    /// ByteProperty: ForcedAimDir
    /// </summary>
    public unsafe byte ForcedAimDir
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 328); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 328); }
    }

    /// <summary>
    /// ArrayProperty: RequiredBones
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.FString>>>>>>>> RequiredBones
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.FString>>>>>>>>>(Ptr + 332); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 332); }
    }

    /// <summary>
    /// ArrayProperty: AimCpntIndexLUT
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.FString>>>>>>> AimCpntIndexLUT
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.FString>>>>>>>>(Ptr + 348); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 348); }
    }

    /// <summary>
    /// ObjectProperty: TemplateNode
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT TemplateNode
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 364); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 364); }
    }

    /// <summary>
    /// ArrayProperty: Profiles
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.FString>>>>>> Profiles
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.FString>>>>>>>(Ptr + 372); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 372); }
    }

    /// <summary>
    /// IntProperty: CurrentProfileIndex
    /// </summary>
    public unsafe int CurrentProfileIndex
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 388); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 388); }
    }

    /// <summary>
    /// Enum: EAimID
    /// </summary>
    public enum EAimID
    {
        EAID_LeftUp = 0,
        EAID_LeftDown = 1,
        EAID_RightUp = 2,
        EAID_RightDown = 3,
        EAID_ZeroUp = 4,
        EAID_ZeroDown = 5,
        EAID_ZeroLeft = 6,
        EAID_ZeroRight = 7,
        EAID_CellLU = 8,
        EAID_CellCU = 9,
        EAID_CellRU = 10,
        EAID_CellLC = 11,
        EAID_CellCC = 12,
        EAID_CellRC = 13,
        EAID_CellLD = 14,
        EAID_CellCD = 15,
        EAID_CellRD = 16,
        EAID_MAX = 17,
    }

    /// <summary>
    /// Enum: EAnimAimDir
    /// </summary>
    public enum EAnimAimDir
    {
        ANIMAIM_LEFTUP = 0,
        ANIMAIM_CENTERUP = 1,
        ANIMAIM_RIGHTUP = 2,
        ANIMAIM_LEFTCENTER = 3,
        ANIMAIM_CENTERCENTER = 4,
        ANIMAIM_RIGHTCENTER = 5,
        ANIMAIM_LEFTDOWN = 6,
        ANIMAIM_CENTERDOWN = 7,
        ANIMAIM_RIGHTDOWN = 8,
        ANIMAIM_MAX = 9,
    }

    /// <summary>
    /// Struct: FAimComponent
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 0)]
    public partial record struct FAimComponent
    {
        /// <summary>
        /// NameProperty: BoneName
        /// </summary>
        public unsafe BmSDK.FName BoneName
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// StructProperty: LU
        /// </summary>
        public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT LU
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 16); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 16); }; }
        }

        /// <summary>
        /// StructProperty: LC
        /// </summary>
        public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT LC
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 48); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 48); }; }
        }

        /// <summary>
        /// StructProperty: LD
        /// </summary>
        public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT LD
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 80); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 80); }; }
        }

        /// <summary>
        /// StructProperty: CU
        /// </summary>
        public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT CU
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 112); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 112); }; }
        }

        /// <summary>
        /// StructProperty: CC
        /// </summary>
        public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT CC
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 144); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 144); }; }
        }

        /// <summary>
        /// StructProperty: CD
        /// </summary>
        public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT CD
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 176); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 176); }; }
        }

        /// <summary>
        /// StructProperty: RU
        /// </summary>
        public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT RU
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 208); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 208); }; }
        }

        /// <summary>
        /// StructProperty: RC
        /// </summary>
        public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT RC
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 240); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 240); }; }
        }

        /// <summary>
        /// StructProperty: RD
        /// </summary>
        public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT RD
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 272); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 272); }; }
        }
    }

    /// <summary>
    /// Struct: FAimTransform
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 0)]
    public partial record struct FAimTransform
    {
        /// <summary>
        /// StructProperty: Quaternion
        /// </summary>
        public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT Quaternion
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// StructProperty: Translation
        /// </summary>
        public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT Translation
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 16); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 16); }; }
        }
    }
}
