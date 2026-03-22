#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RRope2SimpleSphereChainPhysicsUpdater<br/>
/// (size = 212)
/// (flags = 142610578)
/// </summary>
public partial class RRope2SimpleSphereChainPhysicsUpdater : BmSDK.BmGame.RRope2BasePhysicsUpdater, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RRope2SimpleSphereChainPhysicsUpdater", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RRope2SimpleSphereChainPhysicsUpdater() { }

    /// <summary>
    /// Constructs a new RRope2SimpleSphereChainPhysicsUpdater
    /// </summary>
    public RRope2SimpleSphereChainPhysicsUpdater(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RRope2SimpleSphereChainPhysicsUpdater Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RRope2SimpleSphereChainPhysicsUpdater(nint ptr) : base(ptr) { }

    /// <summary>
    /// StructProperty: SphereChainInitData
    /// </summary>
    public unsafe BmSDK.BmGame.RRope2SimpleSphereChainPhysicsUpdater.FRRope2SimpleSphereChainPhysicsUpdaterInitData SphereChainInitData
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RRope2SimpleSphereChainPhysicsUpdater.FRRope2SimpleSphereChainPhysicsUpdaterInitData>(Ptr + 184); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 184); }
    }

    /// <summary>
    /// FloatProperty: DesiredNodeLength
    /// </summary>
    public unsafe float DesiredNodeLength
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 196); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 196); }
    }

    /// <summary>
    /// FloatProperty: MinRopePhysWidth
    /// </summary>
    public unsafe float MinRopePhysWidth
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 200); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 200); }
    }

    /// <summary>
    /// IntProperty: MaxNumNodesInRope
    /// </summary>
    public unsafe int MaxNumNodesInRope
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 204); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 204); }
    }

    /// <summary>
    /// StructProperty: SimpleRopePhysics
    /// </summary>
    public unsafe System.IntPtr SimpleRopePhysics
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.IntPtr>(Ptr + 208); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 208); }
    }

    /// <summary>
    /// Struct: FRRope2SimpleSphereChainPhysicsUpdaterInitData
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 12)]
    public partial record struct FRRope2SimpleSphereChainPhysicsUpdaterInitData
    {
        /// <summary>
        /// ArrayProperty: NodeInitDatas
        /// </summary>
        public unsafe BmSDK.TArray<BmSDK.BmGame.RRope2SimpleSphereChainPhysicsUpdater.FRRope2SimpleSphereChainPhyiscsNodeInitData> NodeInitDatas
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RRope2SimpleSphereChainPhysicsUpdater.FRRope2SimpleSphereChainPhyiscsNodeInitData>>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }
    }

    /// <summary>
    /// Struct: FRRope2SimpleSphereChainPhyiscsNodeInitData
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 32)]
    public partial record struct FRRope2SimpleSphereChainPhyiscsNodeInitData
    {
        /// <summary>
        /// StructProperty: Position
        /// </summary>
        public unsafe System.Numerics.Vector3 Position
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// StructProperty: LinearVelocity
        /// </summary>
        public unsafe System.Numerics.Vector3 LinearVelocity
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 12); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 12); }; }
        }

        /// <summary>
        /// FloatProperty: PreNodeLength
        /// </summary>
        public unsafe float PreNodeLength
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 24); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 24); }; }
        }

        /// <summary>
        /// FloatProperty: PostNodeLength
        /// </summary>
        public unsafe float PostNodeLength
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 28); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 28); }; }
        }
    }
}
