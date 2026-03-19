#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Class: RAutomaticTransitions<br/>
/// (size = 0)
/// (flags = 0)
/// </summary>
public partial class RAutomaticTransitions : BmSDK.GameObject, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Engine.RAutomaticTransitions", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RAutomaticTransitions() { }

    /// <summary>
    /// Constructs a new RAutomaticTransitions
    /// </summary>
    public RAutomaticTransitions(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RAutomaticTransitions Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RAutomaticTransitions(nint ptr) : base(ptr) { }

    /// <summary>
    /// ArrayProperty: Layer1
    /// </summary>
    public unsafe NEED_UPDATE_ARRAYPROPERTY_LAYOUT Layer1
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_ARRAYPROPERTY_LAYOUT>(Ptr + 84); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 84); }
    }

    /// <summary>
    /// Struct: FAutomaticTransitionLayer1
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 0)]
    public partial record struct FAutomaticTransitionLayer1
    {
        /// <summary>
        /// StructProperty: Description
        /// </summary>
        public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT Description
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// ArrayProperty: Layer2
        /// </summary>
        public unsafe NEED_UPDATE_ARRAYPROPERTY_LAYOUT Layer2
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_ARRAYPROPERTY_LAYOUT>(Ptr + 24); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 24); }; }
        }
    }

    /// <summary>
    /// Struct: FAutomaticTransitionLayer1Description
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 0)]
    public partial record struct FAutomaticTransitionLayer1Description
    {
        /// <summary>
        /// FloatProperty: MinYawDelta
        /// </summary>
        public unsafe float MinYawDelta
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// FloatProperty: MaxYawDelta
        /// </summary>
        public unsafe float MaxYawDelta
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4); }; }
        }

        /// <summary>
        /// ByteProperty: MinBeginSpeed
        /// </summary>
        public unsafe byte MinBeginSpeed
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 8); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8); }; }
        }

        /// <summary>
        /// ByteProperty: MaxBeginSpeed
        /// </summary>
        public unsafe byte MaxBeginSpeed
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 9); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 9); }; }
        }

        /// <summary>
        /// ByteProperty: MinEndSpeed
        /// </summary>
        public unsafe byte MinEndSpeed
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 10); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 10); }; }
        }

        /// <summary>
        /// ByteProperty: MaxEndSpeed
        /// </summary>
        public unsafe byte MaxEndSpeed
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 11); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 11); }; }
        }

        /// <summary>
        /// BoolProperty: AllowTurn
        /// </summary>
        public unsafe bool AllowTurn
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 12) & 0) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 12); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 12); }; }
        }

        /// <summary>
        /// FloatProperty: UndershootMarginAngle
        /// </summary>
        public unsafe float UndershootMarginAngle
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 16); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 16); }; }
        }

        /// <summary>
        /// FloatProperty: OvershootMarginAngle
        /// </summary>
        public unsafe float OvershootMarginAngle
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 20); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 20); }; }
        }
    }

    /// <summary>
    /// Struct: FAutomaticTransitionLayer2
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 0)]
    public partial record struct FAutomaticTransitionLayer2
    {
        /// <summary>
        /// ArrayProperty: AnimNames
        /// </summary>
        public unsafe NEED_UPDATE_ARRAYPROPERTY_LAYOUT AnimNames
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_ARRAYPROPERTY_LAYOUT>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// StructProperty: Description
        /// </summary>
        public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT Description
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 16); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 16); }; }
        }
    }

    /// <summary>
    /// Struct: FAutomaticTransitionLayer2Description
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 0)]
    public partial record struct FAutomaticTransitionLayer2Description
    {
        /// <summary>
        /// ByteProperty: BeginSpeed
        /// </summary>
        public unsafe byte BeginSpeed
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// ByteProperty: BeginDirection
        /// </summary>
        public unsafe byte BeginDirection
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 1); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1); }; }
        }

        /// <summary>
        /// ByteProperty: BeginPhase
        /// </summary>
        public unsafe byte BeginPhase
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 2); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2); }; }
        }

        /// <summary>
        /// ByteProperty: EndSpeed
        /// </summary>
        public unsafe byte EndSpeed
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 3); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3); }; }
        }

        /// <summary>
        /// ByteProperty: EndDirection
        /// </summary>
        public unsafe byte EndDirection
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 4); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4); }; }
        }

        /// <summary>
        /// ByteProperty: TurnAngle
        /// </summary>
        public unsafe byte TurnAngle
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 5); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5); }; }
        }

        /// <summary>
        /// ByteProperty: TurnDirection
        /// </summary>
        public unsafe byte TurnDirection
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 6); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6); }; }
        }

        /// <summary>
        /// BoolProperty: Mirrored
        /// </summary>
        public unsafe bool Mirrored
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8) & 0) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 8); }; }
        }
    }

    /// <summary>
    /// Enum: EFootSyncPoint
    /// </summary>
    public enum EFootSyncPoint
    {
        FSP_LeftDown = 0,
        FSP_RightPassing = 1,
        FSP_RightDown = 2,
        FSP_LeftPassing = 3,
        FSP_MAX = 4,
    }

    /// <summary>
    /// Enum: EAutomaticTransitionTurnDirection
    /// </summary>
    public enum EAutomaticTransitionTurnDirection
    {
        ATTD_Left = 0,
        ATTD_Right = 1,
        ATTD_MAX = 2,
    }

    /// <summary>
    /// Enum: EAutomaticTransitionTurnAngle
    /// </summary>
    public enum EAutomaticTransitionTurnAngle
    {
        ATTA = 0,
        ATTA_2 = 1,
        ATTA_3 = 2,
        ATTA_MAX = 3,
    }

    /// <summary>
    /// Enum: EDirectionBlendGroup
    /// </summary>
    public enum EDirectionBlendGroup
    {
        DBG_Forward = 0,
        DBG_Back = 1,
        DBG_Left = 2,
        DBG_Right = 3,
        DBG_MAX = 4,
    }

    /// <summary>
    /// Enum: EMovementSpeed
    /// </summary>
    public enum EMovementSpeed
    {
        MS_WalkSlow = 0,
        MS_Walk = 1,
        MS_Run = 2,
        MS_Sprint = 3,
        MS_MAX = 4,
    }
}
