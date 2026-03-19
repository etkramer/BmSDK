#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RRope2CapsuleChainPhysicsUpdater<br/>
/// (size = 0)
/// (flags = 0)
/// </summary>
public partial class RRope2CapsuleChainPhysicsUpdater : BmSDK.BmGame.RRope2BasePhysicsUpdater, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RRope2CapsuleChainPhysicsUpdater", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RRope2CapsuleChainPhysicsUpdater() { }

    /// <summary>
    /// Constructs a new RRope2CapsuleChainPhysicsUpdater
    /// </summary>
    public RRope2CapsuleChainPhysicsUpdater(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RRope2CapsuleChainPhysicsUpdater Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RRope2CapsuleChainPhysicsUpdater(nint ptr) : base(ptr) { }

    /// <summary>
    /// FloatProperty: RopeSwingLimitPerMetre
    /// </summary>
    public unsafe float RopeSwingLimitPerMetre
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 240); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 240); }
    }

    /// <summary>
    /// FloatProperty: SwingLimitPerConnection
    /// </summary>
    public unsafe float SwingLimitPerConnection
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 244); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 244); }
    }

    /// <summary>
    /// FloatProperty: SwingSpringStrength
    /// </summary>
    public unsafe float SwingSpringStrength
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 248); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 248); }
    }

    /// <summary>
    /// FloatProperty: SwingSpringDamping
    /// </summary>
    public unsafe float SwingSpringDamping
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 252); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 252); }
    }

    /// <summary>
    /// FloatProperty: TwistSpringStrength
    /// </summary>
    public unsafe float TwistSpringStrength
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 256); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 256); }
    }

    /// <summary>
    /// FloatProperty: TwistSpringDamping
    /// </summary>
    public unsafe float TwistSpringDamping
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 260); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 260); }
    }

    /// <summary>
    /// FloatProperty: DesiredCapsuleLength
    /// </summary>
    public unsafe float DesiredCapsuleLength
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 264); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 264); }
    }

    /// <summary>
    /// FloatProperty: MinRopeWidth
    /// </summary>
    public unsafe float MinRopeWidth
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 268); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 268); }
    }

    /// <summary>
    /// FloatProperty: CapsuleLinearDamping
    /// </summary>
    public unsafe float CapsuleLinearDamping
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 272); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 272); }
    }

    /// <summary>
    /// FloatProperty: CapsuleAngularDamping
    /// </summary>
    public unsafe float CapsuleAngularDamping
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 276); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 276); }
    }

    /// <summary>
    /// BoolProperty: bLimitTwistAndRotationAtRopeEnds
    /// </summary>
    public unsafe bool bLimitTwistAndRotationAtRopeEnds
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 280) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 280); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 280); }
    }

    /// <summary>
    /// BoolProperty: bTestDontCreateCapsules
    /// </summary>
    public unsafe bool bTestDontCreateCapsules
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 280) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 280); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 280); }
    }

    /// <summary>
    /// StructProperty: CapsuleChainInitData
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT CapsuleChainInitData
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 284); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 284); }
    }

    /// <summary>
    /// StructProperty: RopeCapsuleChainPhysics
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT RopeCapsuleChainPhysics
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 300); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 300); }
    }

    /// <summary>
    /// Struct: FRope2CapsuleChainPhysicsUpdaterInitData
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 0)]
    public partial record struct FRope2CapsuleChainPhysicsUpdaterInitData
    {
        /// <summary>
        /// ArrayProperty: CapsuleInitDatas
        /// </summary>
        public unsafe NEED_UPDATE_ARRAYPROPERTY_LAYOUT CapsuleInitDatas
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_ARRAYPROPERTY_LAYOUT>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }
    }

    /// <summary>
    /// Struct: FRRope2CapsuleInitData
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 0)]
    public partial record struct FRRope2CapsuleInitData
    {
        /// <summary>
        /// StructProperty: CapsuleEnd1Position
        /// </summary>
        public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT CapsuleEnd1Position
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// StructProperty: CapsuleRotation
        /// </summary>
        public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT CapsuleRotation
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 12); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 12); }; }
        }

        /// <summary>
        /// StructProperty: CapsuleEnd1LinearVelocity
        /// </summary>
        public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT CapsuleEnd1LinearVelocity
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 24); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 24); }; }
        }

        /// <summary>
        /// StructProperty: CapsuleEnd1AngularVelocity
        /// </summary>
        public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT CapsuleEnd1AngularVelocity
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 36); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 36); }; }
        }

        /// <summary>
        /// FloatProperty: CapsuleLength
        /// </summary>
        public unsafe float CapsuleLength
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 48); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 48); }; }
        }
    }
}
