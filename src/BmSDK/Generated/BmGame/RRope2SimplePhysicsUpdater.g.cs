#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RRope2SimplePhysicsUpdater<br/>
/// (size = 0)
/// (flags = 0)
/// </summary>
public partial class RRope2SimplePhysicsUpdater : BmSDK.BmGame.RRope2BasePhysicsUpdater, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RRope2SimplePhysicsUpdater", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RRope2SimplePhysicsUpdater() { }

    /// <summary>
    /// Constructs a new RRope2SimplePhysicsUpdater
    /// </summary>
    public RRope2SimplePhysicsUpdater(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RRope2SimplePhysicsUpdater Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RRope2SimplePhysicsUpdater(nint ptr) : base(ptr) { }

    /// <summary>
    /// StructProperty: InitData
    /// </summary>
    public unsafe BmSDK.BmGame.RRope2SimplePhysicsUpdater.ControlPoints InitData
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RRope2SimplePhysicsUpdater.ControlPoints>(Ptr + 240); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 240); }
    }

    /// <summary>
    /// FloatProperty: DesiredNodeLength
    /// </summary>
    public unsafe float DesiredNodeLength
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 256); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 256); }
    }

    /// <summary>
    /// IntProperty: MaxNumNodesInRope
    /// </summary>
    public unsafe int MaxNumNodesInRope
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 260); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 260); }
    }

    /// <summary>
    /// IntProperty: NumNodeConstraintSolverIterations
    /// </summary>
    public unsafe int NumNodeConstraintSolverIterations
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 264); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 264); }
    }

    /// <summary>
    /// FloatProperty: TargetTighteningFactor
    /// </summary>
    public unsafe float TargetTighteningFactor
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 268); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 268); }
    }

    /// <summary>
    /// StructProperty: SimpleRopePhysics
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT SimpleRopePhysics
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 272); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 272); }
    }

    /// <summary>
    /// ArrayProperty: ControlPoints
    /// </summary>
    public unsafe NEED_UPDATE_ARRAYPROPERTY_LAYOUT ControlPoints
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_ARRAYPROPERTY_LAYOUT>(Ptr + 280); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 280); }
    }

    /// <summary>
    /// Struct: FRRope2SimplePhysicsUpdaterInitData
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 0)]
    public partial record struct FRRope2SimplePhysicsUpdaterInitData
    {
        /// <summary>
        /// ArrayProperty: NodeInitDatas
        /// </summary>
        public unsafe NEED_UPDATE_ARRAYPROPERTY_LAYOUT NodeInitDatas
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_ARRAYPROPERTY_LAYOUT>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }
    }

    /// <summary>
    /// Struct: FRRope2SimplePhyiscsNodeInitData
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 0)]
    public partial record struct FRRope2SimplePhyiscsNodeInitData
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
        /// StructProperty: LinearVelocity
        /// </summary>
        public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT LinearVelocity
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 12); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 12); }; }
        }

        /// <summary>
        /// FloatProperty: Length
        /// </summary>
        public unsafe float Length
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 24); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 24); }; }
        }
    }
}
