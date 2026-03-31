#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RRope2CapsuleChainPhysicsUpdater<br/>
/// (size = 244)
/// (flags = 142610578)
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

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RRope2CapsuleChainPhysicsUpdater>
        => ((GameObject)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RRope2CapsuleChainPhysicsUpdater>, new()
        => (TComponent)((GameObject)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RRope2CapsuleChainPhysicsUpdater>
        => ((GameObject)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RRope2CapsuleChainPhysicsUpdater>
        => ((GameObject)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RRope2CapsuleChainPhysicsUpdater>
        => (TComponent)((GameObject)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponents(Type)"/>
    public System.Collections.Generic.IReadOnlyList<TComponent> GetScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RRope2CapsuleChainPhysicsUpdater>
        => ((GameObject)this).GetScriptComponents(typeof(TComponent)).Cast<TComponent>().ToList();

    /// <inheritdoc cref="GameObject.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RRope2CapsuleChainPhysicsUpdater>
        => ((GameObject)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.DetachScriptComponents(Type)"/>
    public void DetachScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RRope2CapsuleChainPhysicsUpdater>
        => ((GameObject)this).DetachScriptComponents(typeof(TComponent));

    /// <summary>
    /// FloatProperty: RopeSwingLimitPerMetre
    /// </summary>
    public unsafe float RopeSwingLimitPerMetre
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 184); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 184); }
    }

    /// <summary>
    /// FloatProperty: SwingLimitPerConnection
    /// </summary>
    public unsafe float SwingLimitPerConnection
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 188); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 188); }
    }

    /// <summary>
    /// FloatProperty: SwingSpringStrength
    /// </summary>
    public unsafe float SwingSpringStrength
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 192); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 192); }
    }

    /// <summary>
    /// FloatProperty: SwingSpringDamping
    /// </summary>
    public unsafe float SwingSpringDamping
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 196); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 196); }
    }

    /// <summary>
    /// FloatProperty: TwistSpringStrength
    /// </summary>
    public unsafe float TwistSpringStrength
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 200); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 200); }
    }

    /// <summary>
    /// FloatProperty: TwistSpringDamping
    /// </summary>
    public unsafe float TwistSpringDamping
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 204); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 204); }
    }

    /// <summary>
    /// FloatProperty: DesiredCapsuleLength
    /// </summary>
    public unsafe float DesiredCapsuleLength
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 208); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 208); }
    }

    /// <summary>
    /// FloatProperty: MinRopeWidth
    /// </summary>
    public unsafe float MinRopeWidth
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 212); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 212); }
    }

    /// <summary>
    /// FloatProperty: CapsuleLinearDamping
    /// </summary>
    public unsafe float CapsuleLinearDamping
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 216); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 216); }
    }

    /// <summary>
    /// FloatProperty: CapsuleAngularDamping
    /// </summary>
    public unsafe float CapsuleAngularDamping
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 220); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 220); }
    }

    /// <summary>
    /// BoolProperty: bLimitTwistAndRotationAtRopeEnds
    /// </summary>
    public unsafe bool bLimitTwistAndRotationAtRopeEnds
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 224) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 224); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 224); }
    }

    /// <summary>
    /// BoolProperty: bTestDontCreateCapsules
    /// </summary>
    public unsafe bool bTestDontCreateCapsules
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 224) & 2) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 224); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 224); }
    }

    /// <summary>
    /// StructProperty: CapsuleChainInitData
    /// </summary>
    public unsafe ref BmSDK.BmGame.RRope2CapsuleChainPhysicsUpdater.FRope2CapsuleChainPhysicsUpdaterInitData CapsuleChainInitData
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RRope2CapsuleChainPhysicsUpdater.FRope2CapsuleChainPhysicsUpdaterInitData>(Ptr + 228);

    /// <summary>
    /// StructProperty: RopeCapsuleChainPhysics
    /// </summary>
    public unsafe ref System.IntPtr RopeCapsuleChainPhysics
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.IntPtr>(Ptr + 240);

    /// <summary>
    /// Struct: FRope2CapsuleChainPhysicsUpdaterInitData
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 12)]
    public partial record struct FRope2CapsuleChainPhysicsUpdaterInitData
    {
        /// <summary>
        /// ArrayProperty: CapsuleInitDatas
        /// </summary>
        public unsafe BmSDK.TArray<BmSDK.BmGame.RRope2CapsuleChainPhysicsUpdater.FRRope2CapsuleInitData> CapsuleInitDatas
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RRope2CapsuleChainPhysicsUpdater.FRRope2CapsuleInitData>>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }
    }

    /// <summary>
    /// Struct: FRRope2CapsuleInitData
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 52)]
    public partial record struct FRRope2CapsuleInitData
    {
        /// <summary>
        /// StructProperty: CapsuleEnd1Position
        /// </summary>
        public unsafe ref System.Numerics.Vector3 CapsuleEnd1Position
        {
            get { fixed (void* thisPtr = &this) { return ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>((IntPtr)thisPtr + 0); } }
        }

        /// <summary>
        /// StructProperty: CapsuleRotation
        /// </summary>
        public unsafe ref BmSDK.Rotator CapsuleRotation
        {
            get { fixed (void* thisPtr = &this) { return ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.Rotator>((IntPtr)thisPtr + 12); } }
        }

        /// <summary>
        /// StructProperty: CapsuleEnd1LinearVelocity
        /// </summary>
        public unsafe ref System.Numerics.Vector3 CapsuleEnd1LinearVelocity
        {
            get { fixed (void* thisPtr = &this) { return ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>((IntPtr)thisPtr + 24); } }
        }

        /// <summary>
        /// StructProperty: CapsuleEnd1AngularVelocity
        /// </summary>
        public unsafe ref System.Numerics.Vector3 CapsuleEnd1AngularVelocity
        {
            get { fixed (void* thisPtr = &this) { return ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>((IntPtr)thisPtr + 36); } }
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
