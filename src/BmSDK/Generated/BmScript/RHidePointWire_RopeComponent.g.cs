#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmScript;

/// <summary>
/// Class: RHidePointWire_RopeComponent<br/>
/// (size = 0)
/// (flags = 0)
/// </summary>
public partial class RHidePointWire_RopeComponent : BmSDK.BmGame.RHidePointRope_RopeComponent, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmScript.RHidePointWire_RopeComponent", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RHidePointWire_RopeComponent() { }

    /// <summary>
    /// Constructs a new RHidePointWire_RopeComponent
    /// </summary>
    public RHidePointWire_RopeComponent(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RHidePointWire_RopeComponent Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RHidePointWire_RopeComponent(nint ptr) : base(ptr) { }

    /// <summary>
    /// StructProperty: RopeEndAttachDatas
    /// </summary>
    public unsafe BmSDK.BmGame.RRope2Component.RopeRenderUpdater RopeEndAttachDatas_0
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RRope2Component.RopeRenderUpdater>(Ptr + 540); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 540); }
    }
    /// <summary>
    /// StructProperty: RopeEndAttachDatas
    /// </summary>
    public unsafe BmSDK.BmGame.RRope2Component.RopeRenderUpdater RopeEndAttachDatas_1
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RRope2Component.RopeRenderUpdater>(Ptr + 572); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 572); }
    }

    /// <summary>
    /// FloatProperty: RopeLength
    /// </summary>
    public unsafe float RopeLength
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 604); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 604); }
    }

    /// <summary>
    /// FloatProperty: RopeWidth
    /// </summary>
    public unsafe float RopeWidth
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 608); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 608); }
    }

    /// <summary>
    /// ObjectProperty: RopeRenderUpdater
    /// </summary>
    public unsafe BmSDK.BmGame.RRope2Component.RopePhysicsUpdater RopeRenderUpdater
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RRope2Component.RopePhysicsUpdater>(Ptr + 612); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 612); }
    }

    /// <summary>
    /// ObjectProperty: RopePhysicsUpdater
    /// </summary>
    public unsafe BmSDK.BmGame.RRope2Component.RopeUpdaters RopePhysicsUpdater
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RRope2Component.RopeUpdaters>(Ptr + 620); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 620); }
    }

    /// <summary>
    /// ObjectProperty: XRayMaterial
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT XRayMaterial
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 628); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 628); }
    }

    /// <summary>
    /// ArrayProperty: RopeUpdaters
    /// </summary>
    public unsafe BmSDK.TArray<NEED_UPDATE_ARRAYPROPERTY_LAYOUT> RopeUpdaters
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<NEED_UPDATE_ARRAYPROPERTY_LAYOUT>>(Ptr + 636); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 636); }
    }

    /// <summary>
    /// FloatProperty: RopeRenderStartPos
    /// </summary>
    public unsafe float RopeRenderStartPos
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 652); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 652); }
    }

    /// <summary>
    /// FloatProperty: RenderStretch
    /// </summary>
    public unsafe float RenderStretch
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 656); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 656); }
    }

    /// <summary>
    /// BoolProperty: bInitialised
    /// </summary>
    public unsafe bool bInitialised
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 660) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 660); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 660); }
    }

    /// <summary>
    /// BoolProperty: bPhysicsDirtied
    /// </summary>
    public unsafe bool bPhysicsDirtied
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 660) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 660); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 660); }
    }

    /// <summary>
    /// BoolProperty: bRenderDirtied
    /// </summary>
    public unsafe bool bRenderDirtied
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 660) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 660); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 660); }
    }

    /// <summary>
    /// BoolProperty: bInitialisationDataNeedsUpdating
    /// </summary>
    public unsafe bool bInitialisationDataNeedsUpdating
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 660) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 660); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 660); }
    }

    /// <summary>
    /// BoolProperty: bAllowPhysInitialise
    /// </summary>
    public unsafe bool bAllowPhysInitialise
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 660) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 660); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 660); }
    }

    /// <summary>
    /// BoolProperty: bAllowStasis
    /// </summary>
    public unsafe bool bAllowStasis
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 660) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 660); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 660); }
    }

    /// <summary>
    /// ArrayProperty: DependentRopeSections
    /// </summary>
    public unsafe NEED_UPDATE_ARRAYPROPERTY_LAYOUT DependentRopeSections
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_ARRAYPROPERTY_LAYOUT>(Ptr + 664); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 664); }
    }

    /// <summary>
    /// Struct: FRopeRenderPoint
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 0)]
    public partial record struct FRopeRenderPoint
    {
        /// <summary>
        /// StructProperty: Position
        /// </summary>
        public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT Position
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// StructProperty: Rotation
        /// </summary>
        public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT Rotation
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 16); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 16); }; }
        }
    }

    /// <summary>
    /// Struct: FConnectionAttachCalculatedData
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 0)]
    public partial record struct FConnectionAttachCalculatedData
    {
        /// <summary>
        /// StructProperty: ConnectActor
        /// </summary>
        public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT ConnectActor
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// StructProperty: ActorAttachPose
        /// </summary>
        public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT ActorAttachPose
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 16); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 16); }; }
        }

        /// <summary>
        /// StructProperty: RopeAttachPose
        /// </summary>
        public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT RopeAttachPose
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 80); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 80); }; }
        }

        /// <summary>
        /// FloatProperty: ConnectMaxDistance
        /// </summary>
        public unsafe float ConnectMaxDistance
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 144); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 144); }; }
        }

        /// <summary>
        /// FloatProperty: ConnectSwingLimit
        /// </summary>
        public unsafe float ConnectSwingLimit
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 148); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 148); }; }
        }

        /// <summary>
        /// FloatProperty: ConnectTwistLimit
        /// </summary>
        public unsafe float ConnectTwistLimit
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 152); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 152); }; }
        }

        /// <summary>
        /// BoolProperty: bSpringConnection
        /// </summary>
        public unsafe bool bSpringConnection
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 156) & 0) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 156); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 156); }; }
        }
    }

    /// <summary>
    /// Struct: FRopeEndAttachData
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 0)]
    public partial record struct FRopeEndAttachData
    {
        /// <summary>
        /// ArrayProperty: RopeEndConnections
        /// </summary>
        public unsafe NEED_UPDATE_ARRAYPROPERTY_LAYOUT RopeEndConnections
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_ARRAYPROPERTY_LAYOUT>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// StructProperty: RopeEndRenderOffset
        /// </summary>
        public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT RopeEndRenderOffset
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 16); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 16); }; }
        }

        /// <summary>
        /// BoolProperty: bInludeEndBeforeEndWithRenderOffset
        /// </summary>
        public unsafe bool bInludeEndBeforeEndWithRenderOffset
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 28) & 0) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 28); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 28); }; }
        }
    }

    /// <summary>
    /// Struct: FRopeConnectData
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 0)]
    public partial record struct FRopeConnectData
    {
        /// <summary>
        /// ComponentProperty: ConnectComponent
        /// </summary>
        public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT ConnectComponent
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// NameProperty: ConnectBoneName
        /// </summary>
        public unsafe BmSDK.FName ConnectBoneName
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 8); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8); }; }
        }

        /// <summary>
        /// NameProperty: ConnectSocketName
        /// </summary>
        public unsafe BmSDK.FName ConnectSocketName
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 16); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 16); }; }
        }

        /// <summary>
        /// StructProperty: ConnectComponentLocation
        /// </summary>
        public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT ConnectComponentLocation
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 24); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 24); }; }
        }

        /// <summary>
        /// StructProperty: ConnectComponentRotation
        /// </summary>
        public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT ConnectComponentRotation
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 36); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 36); }; }
        }

        /// <summary>
        /// StructProperty: ConnectRopeLocation
        /// </summary>
        public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT ConnectRopeLocation
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 48); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 48); }; }
        }

        /// <summary>
        /// StructProperty: ConnectRopeRotation
        /// </summary>
        public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT ConnectRopeRotation
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 60); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 60); }; }
        }

        /// <summary>
        /// FloatProperty: ConnectMaxDistance
        /// </summary>
        public unsafe float ConnectMaxDistance
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 72); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 72); }; }
        }

        /// <summary>
        /// FloatProperty: ConnectSwingLimit
        /// </summary>
        public unsafe float ConnectSwingLimit
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 76); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 76); }; }
        }

        /// <summary>
        /// FloatProperty: ConnectTwistLimit
        /// </summary>
        public unsafe float ConnectTwistLimit
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 80); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 80); }; }
        }

        /// <summary>
        /// BoolProperty: bSpringConnection
        /// </summary>
        public unsafe bool bSpringConnection
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 84) & 0) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 84); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 84); }; }
        }

        /// <summary>
        /// BoolProperty: bDisableEndCollision
        /// </summary>
        public unsafe bool bDisableEndCollision
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 84) & 0) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 84); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 84); }; }
        }

        /// <summary>
        /// BoolProperty: bAllowDirectConnection
        /// </summary>
        public unsafe bool bAllowDirectConnection
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 84) & 0) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 84); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 84); }; }
        }

        /// <summary>
        /// BoolProperty: bAllowRenderToConnection
        /// </summary>
        public unsafe bool bAllowRenderToConnection
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 84) & 0) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 84); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 84); }; }
        }
    }

    /// <summary>
    /// Enum: ERope2LengthChangeEndType
    /// </summary>
    public enum ERope2LengthChangeEndType
    {
        ROPE2LENGTHCHANGEEND_ChangeFromEnd1 = 0,
        ROPE2LENGTHCHANGEEND_ChangeFromEnd2 = 1,
        ROPE2LENGTHCHANGEEND_ChangeFromBothEnds = 2,
        ROPE2LENGTHCHANGEEND_MAX = 3,
    }

    /// <summary>
    /// Enum: ERope2EndType
    /// </summary>
    public enum ERope2EndType
    {
        ROPE2END_End1 = 0,
        ROPE2END_End2 = 1,
        ROPE2END_MAX = 2,
    }
}
