#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RPersistentDebugData<br/>
/// (size = 256)
/// (flags = 134217874)
/// </summary>
public partial class RPersistentDebugData : BmSDK.Engine.PersistentDebugData, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RPersistentDebugData", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RPersistentDebugData() { }

    /// <summary>
    /// Constructs a new RPersistentDebugData
    /// </summary>
    public RPersistentDebugData(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RPersistentDebugData Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RPersistentDebugData(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RPersistentDebugData>
        => ((GameObject)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RPersistentDebugData>, new()
        => (TComponent)((GameObject)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RPersistentDebugData>
        => ((GameObject)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RPersistentDebugData>
        => ((GameObject)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RPersistentDebugData>
        => (TComponent)((GameObject)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RPersistentDebugData>
        => ((GameObject)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.DetachScriptComponent(Type)"/>
    public void DetachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RPersistentDebugData>
        => ((GameObject)this).DetachScriptComponent(typeof(TComponent));

    /// <summary>
    /// Struct: FPerCharacterTypeAnimDebug
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 36)]
    public partial record struct FPerCharacterTypeAnimDebug
    {
        /// <summary>
        /// BoolProperty: Enabled
        /// </summary>
        public unsafe bool Enabled
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 0) & 1) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 0); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 0); }; }
        }

        /// <summary>
        /// BoolProperty: Poses
        /// </summary>
        public unsafe bool Poses
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 0) & 2) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 0); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 0); }; }
        }

        /// <summary>
        /// BoolProperty: Poses_Detailed
        /// </summary>
        public unsafe bool Poses_Detailed
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 0) & 4) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 0); var newMask = value ? (currentMask | 4) : (currentMask & ~4); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 0); }; }
        }

        /// <summary>
        /// BoolProperty: Poses_DirectionalWeights
        /// </summary>
        public unsafe bool Poses_DirectionalWeights
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 0) & 8) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 0); var newMask = value ? (currentMask | 8) : (currentMask & ~8); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 0); }; }
        }

        /// <summary>
        /// BoolProperty: Poses_AimAt
        /// </summary>
        public unsafe bool Poses_AimAt
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 0) & 16) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 0); var newMask = value ? (currentMask | 16) : (currentMask & ~16); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 0); }; }
        }

        /// <summary>
        /// BoolProperty: PoseLog
        /// </summary>
        public unsafe bool PoseLog
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 0) & 32) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 0); var newMask = value ? (currentMask | 32) : (currentMask & ~32); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 0); }; }
        }

        /// <summary>
        /// BoolProperty: PoseLog_Detailed
        /// </summary>
        public unsafe bool PoseLog_Detailed
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 0) & 64) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 0); var newMask = value ? (currentMask | 64) : (currentMask & ~64); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 0); }; }
        }

        /// <summary>
        /// BoolProperty: ActorLocation
        /// </summary>
        public unsafe bool ActorLocation
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 0) & 128) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 0); var newMask = value ? (currentMask | 128) : (currentMask & ~128); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 0); }; }
        }

        /// <summary>
        /// BoolProperty: TargetLines
        /// </summary>
        public unsafe bool TargetLines
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 0) & 256) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 0); var newMask = value ? (currentMask | 256) : (currentMask & ~256); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 0); }; }
        }

        /// <summary>
        /// BoolProperty: RelativeTransitions
        /// </summary>
        public unsafe bool RelativeTransitions
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 0) & 512) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 0); var newMask = value ? (currentMask | 512) : (currentMask & ~512); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 0); }; }
        }

        /// <summary>
        /// BoolProperty: Notifies
        /// </summary>
        public unsafe bool Notifies
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 0) & 1024) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 0); var newMask = value ? (currentMask | 1024) : (currentMask & ~1024); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 0); }; }
        }

        /// <summary>
        /// BoolProperty: Notifies_Log
        /// </summary>
        public unsafe bool Notifies_Log
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 0) & 2048) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 0); var newMask = value ? (currentMask | 2048) : (currentMask & ~2048); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 0); }; }
        }

        /// <summary>
        /// BoolProperty: Notifies_Anim
        /// </summary>
        public unsafe bool Notifies_Anim
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 0) & 4096) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 0); var newMask = value ? (currentMask | 4096) : (currentMask & ~4096); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 0); }; }
        }

        /// <summary>
        /// BoolProperty: Notifies_SoundFilter
        /// </summary>
        public unsafe bool Notifies_SoundFilter
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 0) & 8192) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 0); var newMask = value ? (currentMask | 8192) : (currentMask & ~8192); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 0); }; }
        }

        /// <summary>
        /// BoolProperty: Collision
        /// </summary>
        public unsafe bool Collision
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 0) & 16384) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 0); var newMask = value ? (currentMask | 16384) : (currentMask & ~16384); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 0); }; }
        }

        /// <summary>
        /// BoolProperty: Ragdoll
        /// </summary>
        public unsafe bool Ragdoll
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 0) & 32768) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 0); var newMask = value ? (currentMask | 32768) : (currentMask & ~32768); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 0); }; }
        }

        /// <summary>
        /// BoolProperty: Ragdoll_Details
        /// </summary>
        public unsafe bool Ragdoll_Details
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 0) & 65536) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 0); var newMask = value ? (currentMask | 65536) : (currentMask & ~65536); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 0); }; }
        }

        /// <summary>
        /// BoolProperty: Ragdoll_ForceAlwaysActive
        /// </summary>
        public unsafe bool Ragdoll_ForceAlwaysActive
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 0) & 131072) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 0); var newMask = value ? (currentMask | 131072) : (currentMask & ~131072); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 0); }; }
        }

        /// <summary>
        /// BoolProperty: Ragdoll_PhysDetails
        /// </summary>
        public unsafe bool Ragdoll_PhysDetails
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 0) & 262144) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 0); var newMask = value ? (currentMask | 262144) : (currentMask & ~262144); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 0); }; }
        }

        /// <summary>
        /// BoolProperty: MoveTo
        /// </summary>
        public unsafe bool MoveTo
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 0) & 524288) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 0); var newMask = value ? (currentMask | 524288) : (currentMask & ~524288); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 0); }; }
        }

        /// <summary>
        /// BoolProperty: MoveTo_Anims
        /// </summary>
        public unsafe bool MoveTo_Anims
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 0) & 1048576) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 0); var newMask = value ? (currentMask | 1048576) : (currentMask & ~1048576); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 0); }; }
        }

        /// <summary>
        /// BoolProperty: MoveTo_Detailed
        /// </summary>
        public unsafe bool MoveTo_Detailed
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 0) & 2097152) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 0); var newMask = value ? (currentMask | 2097152) : (currentMask & ~2097152); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 0); }; }
        }

        /// <summary>
        /// BoolProperty: FaceAt
        /// </summary>
        public unsafe bool FaceAt
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 0) & 4194304) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 0); var newMask = value ? (currentMask | 4194304) : (currentMask & ~4194304); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 0); }; }
        }

        /// <summary>
        /// BoolProperty: AimAt
        /// </summary>
        public unsafe bool AimAt
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 0) & 8388608) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 0); var newMask = value ? (currentMask | 8388608) : (currentMask & ~8388608); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 0); }; }
        }

        /// <summary>
        /// BoolProperty: LookAt
        /// </summary>
        public unsafe bool LookAt
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 0) & 16777216) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 0); var newMask = value ? (currentMask | 16777216) : (currentMask & ~16777216); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 0); }; }
        }

        /// <summary>
        /// BoolProperty: ProceduralAiming
        /// </summary>
        public unsafe bool ProceduralAiming
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 0) & 33554432) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 0); var newMask = value ? (currentMask | 33554432) : (currentMask & ~33554432); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 0); }; }
        }

        /// <summary>
        /// BoolProperty: ProceduralAiming_ForceOff
        /// </summary>
        public unsafe bool ProceduralAiming_ForceOff
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 0) & 67108864) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 0); var newMask = value ? (currentMask | 67108864) : (currentMask & ~67108864); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 0); }; }
        }

        /// <summary>
        /// BoolProperty: ProceduralAiming_Details
        /// </summary>
        public unsafe bool ProceduralAiming_Details
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 0) & 134217728) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 0); var newMask = value ? (currentMask | 134217728) : (currentMask & ~134217728); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 0); }; }
        }

        /// <summary>
        /// BoolProperty: Trails
        /// </summary>
        public unsafe bool Trails
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 0) & 268435456) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 0); var newMask = value ? (currentMask | 268435456) : (currentMask & ~268435456); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 0); }; }
        }

        /// <summary>
        /// BoolProperty: Trails_MovementType
        /// </summary>
        public unsafe bool Trails_MovementType
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 0) & 536870912) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 0); var newMask = value ? (currentMask | 536870912) : (currentMask & ~536870912); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 0); }; }
        }

        /// <summary>
        /// BoolProperty: Trails_PhysicsType
        /// </summary>
        public unsafe bool Trails_PhysicsType
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 0) & 1073741824) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 0); var newMask = value ? (currentMask | 1073741824) : (currentMask & ~1073741824); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 0); }; }
        }

        /// <summary>
        /// BoolProperty: Trails_Crumbs
        /// </summary>
        public unsafe bool Trails_Crumbs
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 0) & -2147483648) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 0); var newMask = value ? (currentMask | -2147483648) : (currentMask & ~-2147483648); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 0); }; }
        }

        /// <summary>
        /// BoolProperty: Trails_VelocityRainbow
        /// </summary>
        public unsafe bool Trails_VelocityRainbow
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4) & 1) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 4); }; }
        }

        /// <summary>
        /// BoolProperty: AnimNames
        /// </summary>
        public unsafe bool AnimNames
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4) & 2) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 4); }; }
        }

        /// <summary>
        /// BoolProperty: MeshNames
        /// </summary>
        public unsafe bool MeshNames
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4) & 4) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4); var newMask = value ? (currentMask | 4) : (currentMask & ~4); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 4); }; }
        }

        /// <summary>
        /// BoolProperty: MeshLOD
        /// </summary>
        public unsafe bool MeshLOD
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4) & 8) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4); var newMask = value ? (currentMask | 8) : (currentMask & ~8); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 4); }; }
        }

        /// <summary>
        /// BoolProperty: MeshLOD_Detailed
        /// </summary>
        public unsafe bool MeshLOD_Detailed
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4) & 16) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4); var newMask = value ? (currentMask | 16) : (currentMask & ~16); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 4); }; }
        }

        /// <summary>
        /// BoolProperty: BlendedAnimDetails
        /// </summary>
        public unsafe bool BlendedAnimDetails
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4) & 32) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4); var newMask = value ? (currentMask | 32) : (currentMask & ~32); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 4); }; }
        }

        /// <summary>
        /// BoolProperty: AdditiveAnimDetails
        /// </summary>
        public unsafe bool AdditiveAnimDetails
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4) & 64) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4); var newMask = value ? (currentMask | 64) : (currentMask & ~64); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 4); }; }
        }

        /// <summary>
        /// BoolProperty: FaceFX
        /// </summary>
        public unsafe bool FaceFX
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4) & 128) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4); var newMask = value ? (currentMask | 128) : (currentMask & ~128); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 4); }; }
        }

        /// <summary>
        /// BoolProperty: FaceFX_Asset
        /// </summary>
        public unsafe bool FaceFX_Asset
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4) & 256) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4); var newMask = value ? (currentMask | 256) : (currentMask & ~256); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 4); }; }
        }

        /// <summary>
        /// BoolProperty: FaceFX_Anims
        /// </summary>
        public unsafe bool FaceFX_Anims
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4) & 512) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4); var newMask = value ? (currentMask | 512) : (currentMask & ~512); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 4); }; }
        }

        /// <summary>
        /// BoolProperty: FaceFX_Registers
        /// </summary>
        public unsafe bool FaceFX_Registers
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4) & 1024) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4); var newMask = value ? (currentMask | 1024) : (currentMask & ~1024); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 4); }; }
        }

        /// <summary>
        /// BoolProperty: FaceFX_Lod
        /// </summary>
        public unsafe bool FaceFX_Lod
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4) & 2048) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4); var newMask = value ? (currentMask | 2048) : (currentMask & ~2048); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 4); }; }
        }

        /// <summary>
        /// BoolProperty: FaceFX_Blinking
        /// </summary>
        public unsafe bool FaceFX_Blinking
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4) & 4096) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4); var newMask = value ? (currentMask | 4096) : (currentMask & ~4096); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 4); }; }
        }

        /// <summary>
        /// BoolProperty: Overlays
        /// </summary>
        public unsafe bool Overlays
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4) & 8192) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4); var newMask = value ? (currentMask | 8192) : (currentMask & ~8192); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 4); }; }
        }

        /// <summary>
        /// BoolProperty: RandomIdleOverlays
        /// </summary>
        public unsafe bool RandomIdleOverlays
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4) & 16384) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4); var newMask = value ? (currentMask | 16384) : (currentMask & ~16384); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 4); }; }
        }

        /// <summary>
        /// BoolProperty: Scale
        /// </summary>
        public unsafe bool Scale
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4) & 32768) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4); var newMask = value ? (currentMask | 32768) : (currentMask & ~32768); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 4); }; }
        }

        /// <summary>
        /// BoolProperty: Skeletons
        /// </summary>
        public unsafe bool Skeletons
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4) & 65536) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4); var newMask = value ? (currentMask | 65536) : (currentMask & ~65536); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 4); }; }
        }

        /// <summary>
        /// BoolProperty: Skeletons_1_AfterBlend
        /// </summary>
        public unsafe bool Skeletons_1_AfterBlend
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4) & 131072) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4); var newMask = value ? (currentMask | 131072) : (currentMask & ~131072); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 4); }; }
        }

        /// <summary>
        /// BoolProperty: Skeletons_2_AfterAiming
        /// </summary>
        public unsafe bool Skeletons_2_AfterAiming
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4) & 262144) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4); var newMask = value ? (currentMask | 262144) : (currentMask & ~262144); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 4); }; }
        }

        /// <summary>
        /// BoolProperty: Skeletons_3_AfterAdditive
        /// </summary>
        public unsafe bool Skeletons_3_AfterAdditive
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4) & 524288) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4); var newMask = value ? (currentMask | 524288) : (currentMask & ~524288); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 4); }; }
        }

        /// <summary>
        /// BoolProperty: Skeletons_4_AfterFixup
        /// </summary>
        public unsafe bool Skeletons_4_AfterFixup
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4) & 1048576) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4); var newMask = value ? (currentMask | 1048576) : (currentMask & ~1048576); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 4); }; }
        }

        /// <summary>
        /// BoolProperty: Skeletons_UsePersistentLines
        /// </summary>
        public unsafe bool Skeletons_UsePersistentLines
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4) & 2097152) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4); var newMask = value ? (currentMask | 2097152) : (currentMask & ~2097152); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 4); }; }
        }

        /// <summary>
        /// BoolProperty: Unconscious
        /// </summary>
        public unsafe bool Unconscious
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4) & 4194304) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4); var newMask = value ? (currentMask | 4194304) : (currentMask & ~4194304); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 4); }; }
        }

        /// <summary>
        /// BoolProperty: HandIK
        /// </summary>
        public unsafe bool HandIK
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4) & 8388608) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4); var newMask = value ? (currentMask | 8388608) : (currentMask & ~8388608); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 4); }; }
        }

        /// <summary>
        /// BoolProperty: HandIK_Details
        /// </summary>
        public unsafe bool HandIK_Details
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4) & 16777216) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4); var newMask = value ? (currentMask | 16777216) : (currentMask & ~16777216); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 4); }; }
        }

        /// <summary>
        /// BoolProperty: HandIK_ForceDisable
        /// </summary>
        public unsafe bool HandIK_ForceDisable
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4) & 33554432) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4); var newMask = value ? (currentMask | 33554432) : (currentMask & ~33554432); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 4); }; }
        }

        /// <summary>
        /// BoolProperty: FloorCorrection
        /// </summary>
        public unsafe bool FloorCorrection
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4) & 67108864) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4); var newMask = value ? (currentMask | 67108864) : (currentMask & ~67108864); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 4); }; }
        }

        /// <summary>
        /// BoolProperty: FloorCorrection_Details
        /// </summary>
        public unsafe bool FloorCorrection_Details
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4) & 134217728) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4); var newMask = value ? (currentMask | 134217728) : (currentMask & ~134217728); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 4); }; }
        }

        /// <summary>
        /// BoolProperty: FloorCorrection_Render
        /// </summary>
        public unsafe bool FloorCorrection_Render
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4) & 268435456) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4); var newMask = value ? (currentMask | 268435456) : (currentMask & ~268435456); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 4); }; }
        }

        /// <summary>
        /// BoolProperty: FloorCorrection_RenderGrid
        /// </summary>
        public unsafe bool FloorCorrection_RenderGrid
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4) & 536870912) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4); var newMask = value ? (currentMask | 536870912) : (currentMask & ~536870912); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 4); }; }
        }

        /// <summary>
        /// BoolProperty: FloorCorrection_OverrideConfig
        /// </summary>
        public unsafe bool FloorCorrection_OverrideConfig
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4) & 1073741824) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4); var newMask = value ? (currentMask | 1073741824) : (currentMask & ~1073741824); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 4); }; }
        }

        /// <summary>
        /// BoolProperty: FloorCorrection_ForceDisableApply
        /// </summary>
        public unsafe bool FloorCorrection_ForceDisableApply
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4) & -2147483648) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4); var newMask = value ? (currentMask | -2147483648) : (currentMask & ~-2147483648); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 4); }; }
        }

        /// <summary>
        /// BoolProperty: FloorCorrection_ForceDisableApplyNormal
        /// </summary>
        public unsafe bool FloorCorrection_ForceDisableApplyNormal
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8) & 1) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 8); }; }
        }

        /// <summary>
        /// BoolProperty: FloorCorrection_ForceDisableMaxFootZ
        /// </summary>
        public unsafe bool FloorCorrection_ForceDisableMaxFootZ
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8) & 2) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 8); }; }
        }

        /// <summary>
        /// BoolProperty: FloorCorrection_ForceDisableOverExtensionClamp
        /// </summary>
        public unsafe bool FloorCorrection_ForceDisableOverExtensionClamp
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8) & 4) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8); var newMask = value ? (currentMask | 4) : (currentMask & ~4); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 8); }; }
        }

        /// <summary>
        /// StructProperty: FloorCorrection_OverrideConfig_Config
        /// </summary>
        public unsafe BmSDK.BmGame.RGameInfo.FFloorMovementCorrectionConfig FloorCorrection_OverrideConfig_Config
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RGameInfo.FFloorMovementCorrectionConfig>(Ptr + 12); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 12); }; }
        }

        /// <summary>
        /// BoolProperty: AutomaticTransitions
        /// </summary>
        public unsafe bool AutomaticTransitions
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 32) & 1) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 32); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 32); }; }
        }

        /// <summary>
        /// BoolProperty: Dump
        /// </summary>
        public unsafe bool Dump
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 32) & 2) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 32); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 32); }; }
        }
    }

    /// <summary>
    /// BoolProperty: bDeathCountGodMode
    /// </summary>
    public unsafe bool bDeathCountGodMode
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 48) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 48); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 48); }
    }

    /// <summary>
    /// BoolProperty: bDisableDamagePostProcess
    /// </summary>
    public unsafe bool bDisableDamagePostProcess
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 48) & 2) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 48); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 48); }
    }

    /// <summary>
    /// BoolProperty: bDebugForceGarbageCollect
    /// </summary>
    public unsafe bool bDebugForceGarbageCollect
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 48) & 4) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 48); var newMask = value ? (currentMask | 4) : (currentMask & ~4); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 48); }
    }

    /// <summary>
    /// BoolProperty: Debug_CharacterAI_ShowThoughts
    /// </summary>
    public unsafe bool Debug_CharacterAI_ShowThoughts
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 48) & 8) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 48); var newMask = value ? (currentMask | 8) : (currentMask & ~8); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 48); }
    }

    /// <summary>
    /// BoolProperty: Debug_AI_FearInfo
    /// </summary>
    public unsafe bool Debug_AI_FearInfo
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 48) & 16) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 48); var newMask = value ? (currentMask | 16) : (currentMask & ~16); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 48); }
    }

    /// <summary>
    /// BoolProperty: Debug_AI_ShowDDA
    /// </summary>
    public unsafe bool Debug_AI_ShowDDA
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 48) & 32) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 48); var newMask = value ? (currentMask | 32) : (currentMask & ~32); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 48); }
    }

    /// <summary>
    /// BoolProperty: Debug_AI_IgnoreDDA
    /// </summary>
    public unsafe bool Debug_AI_IgnoreDDA
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 48) & 64) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 48); var newMask = value ? (currentMask | 64) : (currentMask & ~64); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 48); }
    }

    /// <summary>
    /// BoolProperty: Debug_AI_ShowStasisLevel
    /// </summary>
    public unsafe bool Debug_AI_ShowStasisLevel
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 48) & 128) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 48); var newMask = value ? (currentMask | 128) : (currentMask & ~128); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 48); }
    }

    /// <summary>
    /// BoolProperty: Debug_AI_StuckNavDetection
    /// </summary>
    public unsafe bool Debug_AI_StuckNavDetection
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 48) & 256) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 48); var newMask = value ? (currentMask | 256) : (currentMask & ~256); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 48); }
    }

    /// <summary>
    /// BoolProperty: Debug_AI_RandomTeleport
    /// </summary>
    public unsafe bool Debug_AI_RandomTeleport
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 48) & 512) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 48); var newMask = value ? (currentMask | 512) : (currentMask & ~512); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 48); }
    }

    /// <summary>
    /// BoolProperty: Debug_AI_VertTimeSinceSeen
    /// </summary>
    public unsafe bool Debug_AI_VertTimeSinceSeen
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 48) & 1024) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 48); var newMask = value ? (currentMask | 1024) : (currentMask & ~1024); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 48); }
    }

    /// <summary>
    /// BoolProperty: Debug_AI_ShowCanSeeVerts
    /// </summary>
    public unsafe bool Debug_AI_ShowCanSeeVerts
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 48) & 2048) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 48); var newMask = value ? (currentMask | 2048) : (currentMask & ~2048); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 48); }
    }

    /// <summary>
    /// BoolProperty: Debug_AI_ShowCantSeeVerts
    /// </summary>
    public unsafe bool Debug_AI_ShowCantSeeVerts
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 48) & 4096) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 48); var newMask = value ? (currentMask | 4096) : (currentMask & ~4096); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 48); }
    }

    /// <summary>
    /// BoolProperty: bReactionBehaviours
    /// </summary>
    public unsafe bool bReactionBehaviours
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 48) & 8192) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 48); var newMask = value ? (currentMask | 8192) : (currentMask & ~8192); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 48); }
    }

    /// <summary>
    /// BoolProperty: bReactionBehavioursPlayer
    /// </summary>
    public unsafe bool bReactionBehavioursPlayer
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 48) & 16384) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 48); var newMask = value ? (currentMask | 16384) : (currentMask & ~16384); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 48); }
    }

    /// <summary>
    /// BoolProperty: bShowHistory
    /// </summary>
    public unsafe bool bShowHistory
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 48) & 32768) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 48); var newMask = value ? (currentMask | 32768) : (currentMask & ~32768); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 48); }
    }

    /// <summary>
    /// BoolProperty: bShowHistory_General
    /// </summary>
    public unsafe bool bShowHistory_General
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 48) & 65536) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 48); var newMask = value ? (currentMask | 65536) : (currentMask & ~65536); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 48); }
    }

    /// <summary>
    /// BoolProperty: bShowHistory_Behaviour
    /// </summary>
    public unsafe bool bShowHistory_Behaviour
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 48) & 131072) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 48); var newMask = value ? (currentMask | 131072) : (currentMask & ~131072); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 48); }
    }

    /// <summary>
    /// BoolProperty: bShowHistory_BehaviourState
    /// </summary>
    public unsafe bool bShowHistory_BehaviourState
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 48) & 262144) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 48); var newMask = value ? (currentMask | 262144) : (currentMask & ~262144); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 48); }
    }

    /// <summary>
    /// BoolProperty: bShowHistory_ActionQueue
    /// </summary>
    public unsafe bool bShowHistory_ActionQueue
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 48) & 524288) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 48); var newMask = value ? (currentMask | 524288) : (currentMask & ~524288); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 48); }
    }

    /// <summary>
    /// BoolProperty: bShowTimestamps
    /// </summary>
    public unsafe bool bShowTimestamps
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 48) & 1048576) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 48); var newMask = value ? (currentMask | 1048576) : (currentMask & ~1048576); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 48); }
    }

    /// <summary>
    /// BoolProperty: bShowFilteringMenu
    /// </summary>
    public unsafe bool bShowFilteringMenu
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 48) & 2097152) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 48); var newMask = value ? (currentMask | 2097152) : (currentMask & ~2097152); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 48); }
    }

    /// <summary>
    /// BoolProperty: bShowThoughtsPawn
    /// </summary>
    public unsafe bool bShowThoughtsPawn
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 48) & 4194304) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 48); var newMask = value ? (currentMask | 4194304) : (currentMask & ~4194304); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 48); }
    }

    /// <summary>
    /// BoolProperty: bShowThoughtsPawnState
    /// </summary>
    public unsafe bool bShowThoughtsPawnState
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 48) & 8388608) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 48); var newMask = value ? (currentMask | 8388608) : (currentMask & ~8388608); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 48); }
    }

    /// <summary>
    /// BoolProperty: bShowThoughtsPawnStasis
    /// </summary>
    public unsafe bool bShowThoughtsPawnStasis
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 48) & 16777216) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 48); var newMask = value ? (currentMask | 16777216) : (currentMask & ~16777216); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 48); }
    }

    /// <summary>
    /// BoolProperty: bShowThoughtsPawnStasis_InStasis
    /// </summary>
    public unsafe bool bShowThoughtsPawnStasis_InStasis
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 48) & 33554432) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 48); var newMask = value ? (currentMask | 33554432) : (currentMask & ~33554432); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 48); }
    }

    /// <summary>
    /// BoolProperty: bShowThoughtsPawnStasis_NotInStasis
    /// </summary>
    public unsafe bool bShowThoughtsPawnStasis_NotInStasis
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 48) & 67108864) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 48); var newMask = value ? (currentMask | 67108864) : (currentMask & ~67108864); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 48); }
    }

    /// <summary>
    /// BoolProperty: bShowThoughtsCharacterType
    /// </summary>
    public unsafe bool bShowThoughtsCharacterType
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 48) & 134217728) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 48); var newMask = value ? (currentMask | 134217728) : (currentMask & ~134217728); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 48); }
    }

    /// <summary>
    /// BoolProperty: bShowThoughtsCombatReadiness
    /// </summary>
    public unsafe bool bShowThoughtsCombatReadiness
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 48) & 268435456) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 48); var newMask = value ? (currentMask | 268435456) : (currentMask & ~268435456); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 48); }
    }

    /// <summary>
    /// BoolProperty: bShowThoughtsCombatBarks
    /// </summary>
    public unsafe bool bShowThoughtsCombatBarks
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 48) & 536870912) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 48); var newMask = value ? (currentMask | 536870912) : (currentMask & ~536870912); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 48); }
    }

    /// <summary>
    /// BoolProperty: bShowThoughtsSpawn
    /// </summary>
    public unsafe bool bShowThoughtsSpawn
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 48) & 1073741824) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 48); var newMask = value ? (currentMask | 1073741824) : (currentMask & ~1073741824); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 48); }
    }

    /// <summary>
    /// BoolProperty: bShowThoughtsController
    /// </summary>
    public unsafe bool bShowThoughtsController
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 48) & -2147483648) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 48); var newMask = value ? (currentMask | -2147483648) : (currentMask & ~-2147483648); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 48); }
    }

    /// <summary>
    /// BoolProperty: bShowThoughtsControllerState
    /// </summary>
    public unsafe bool bShowThoughtsControllerState
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 52) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 52); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 52); }
    }

    /// <summary>
    /// BoolProperty: bShowThoughtsWeapon
    /// </summary>
    public unsafe bool bShowThoughtsWeapon
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 52) & 2) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 52); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 52); }
    }

    /// <summary>
    /// BoolProperty: bShowThoughtsPawnPhysics
    /// </summary>
    public unsafe bool bShowThoughtsPawnPhysics
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 52) & 4) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 52); var newMask = value ? (currentMask | 4) : (currentMask & ~4); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 52); }
    }

    /// <summary>
    /// BoolProperty: bShowThoughtsActionQueue
    /// </summary>
    public unsafe bool bShowThoughtsActionQueue
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 52) & 8) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 52); var newMask = value ? (currentMask | 8) : (currentMask & ~8); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 52); }
    }

    /// <summary>
    /// BoolProperty: bShowThoughtsReplicator
    /// </summary>
    public unsafe bool bShowThoughtsReplicator
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 52) & 16) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 52); var newMask = value ? (currentMask | 16) : (currentMask & ~16); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 52); }
    }

    /// <summary>
    /// BoolProperty: bShowThoughtsBehaviour
    /// </summary>
    public unsafe bool bShowThoughtsBehaviour
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 52) & 32) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 52); var newMask = value ? (currentMask | 32) : (currentMask & ~32); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 52); }
    }

    /// <summary>
    /// BoolProperty: bShowThoughtsBehaviourList
    /// </summary>
    public unsafe bool bShowThoughtsBehaviourList
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 52) & 64) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 52); var newMask = value ? (currentMask | 64) : (currentMask & ~64); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 52); }
    }

    /// <summary>
    /// BoolProperty: bShowThoughtsBehaviourListStanceStack
    /// </summary>
    public unsafe bool bShowThoughtsBehaviourListStanceStack
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 52) & 128) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 52); var newMask = value ? (currentMask | 128) : (currentMask & ~128); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 52); }
    }

    /// <summary>
    /// BoolProperty: bShowThoughtsBehaviourState
    /// </summary>
    public unsafe bool bShowThoughtsBehaviourState
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 52) & 256) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 52); var newMask = value ? (currentMask | 256) : (currentMask & ~256); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 52); }
    }

    /// <summary>
    /// BoolProperty: bShowThoughtsEventOwnerVis
    /// </summary>
    public unsafe bool bShowThoughtsEventOwnerVis
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 52) & 512) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 52); var newMask = value ? (currentMask | 512) : (currentMask & ~512); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 52); }
    }

    /// <summary>
    /// BoolProperty: bShowThoughtsHealth
    /// </summary>
    public unsafe bool bShowThoughtsHealth
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 52) & 1024) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 52); var newMask = value ? (currentMask | 1024) : (currentMask & ~1024); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 52); }
    }

    /// <summary>
    /// BoolProperty: bShowThoughtsRouter
    /// </summary>
    public unsafe bool bShowThoughtsRouter
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 52) & 2048) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 52); var newMask = value ? (currentMask | 2048) : (currentMask & ~2048); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 52); }
    }

    /// <summary>
    /// BoolProperty: bShowThoughtsRouter_Priority
    /// </summary>
    public unsafe bool bShowThoughtsRouter_Priority
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 52) & 4096) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 52); var newMask = value ? (currentMask | 4096) : (currentMask & ~4096); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 52); }
    }

    /// <summary>
    /// BoolProperty: bShowThoughtsRouter_HasPath
    /// </summary>
    public unsafe bool bShowThoughtsRouter_HasPath
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 52) & 8192) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 52); var newMask = value ? (currentMask | 8192) : (currentMask & ~8192); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 52); }
    }

    /// <summary>
    /// BoolProperty: bShowThoughtsRouter_PathLength
    /// </summary>
    public unsafe bool bShowThoughtsRouter_PathLength
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 52) & 16384) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 52); var newMask = value ? (currentMask | 16384) : (currentMask & ~16384); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 52); }
    }

    /// <summary>
    /// BoolProperty: bShowThoughtsRouter_FailReason
    /// </summary>
    public unsafe bool bShowThoughtsRouter_FailReason
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 52) & 32768) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 52); var newMask = value ? (currentMask | 32768) : (currentMask & ~32768); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 52); }
    }

    /// <summary>
    /// BoolProperty: bShowThoughtsRouter_NavActors
    /// </summary>
    public unsafe bool bShowThoughtsRouter_NavActors
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 52) & 65536) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 52); var newMask = value ? (currentMask | 65536) : (currentMask & ~65536); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 52); }
    }

    /// <summary>
    /// BoolProperty: bShowThoughtsRouter_EmptyHandles
    /// </summary>
    public unsafe bool bShowThoughtsRouter_EmptyHandles
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 52) & 131072) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 52); var newMask = value ? (currentMask | 131072) : (currentMask & ~131072); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 52); }
    }

    /// <summary>
    /// BoolProperty: bShowThoughtsRouter_Traversal
    /// </summary>
    public unsafe bool bShowThoughtsRouter_Traversal
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 52) & 262144) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 52); var newMask = value ? (currentMask | 262144) : (currentMask & ~262144); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 52); }
    }

    /// <summary>
    /// BoolProperty: bShowThoughtsRouter_ReproInfo
    /// </summary>
    public unsafe bool bShowThoughtsRouter_ReproInfo
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 52) & 524288) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 52); var newMask = value ? (currentMask | 524288) : (currentMask & ~524288); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 52); }
    }

    /// <summary>
    /// BoolProperty: bShowFreezeFeatures
    /// </summary>
    public unsafe bool bShowFreezeFeatures
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 52) & 1048576) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 52); var newMask = value ? (currentMask | 1048576) : (currentMask & ~1048576); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 52); }
    }

    /// <summary>
    /// BoolProperty: bSingleTakedownKill
    /// </summary>
    public unsafe bool bSingleTakedownKill
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 52) & 2097152) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 52); var newMask = value ? (currentMask | 2097152) : (currentMask & ~2097152); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 52); }
    }

    /// <summary>
    /// BoolProperty: bDisableFreezeFootprintCheat
    /// </summary>
    public unsafe bool bDisableFreezeFootprintCheat
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 52) & 4194304) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 52); var newMask = value ? (currentMask | 4194304) : (currentMask & ~4194304); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 52); }
    }

    /// <summary>
    /// BoolProperty: bPauseWhenFreezeChangesNavStrat
    /// </summary>
    public unsafe bool bPauseWhenFreezeChangesNavStrat
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 52) & 8388608) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 52); var newMask = value ? (currentMask | 8388608) : (currentMask & ~8388608); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 52); }
    }

    /// <summary>
    /// BoolProperty: bPauseWhenFreezeChangesVisualContact
    /// </summary>
    public unsafe bool bPauseWhenFreezeChangesVisualContact
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 52) & 16777216) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 52); var newMask = value ? (currentMask | 16777216) : (currentMask & ~16777216); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 52); }
    }

    /// <summary>
    /// BoolProperty: bFreezeCanNeutraliseEverything
    /// </summary>
    public unsafe bool bFreezeCanNeutraliseEverything
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 52) & 33554432) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 52); var newMask = value ? (currentMask | 33554432) : (currentMask & ~33554432); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 52); }
    }

    /// <summary>
    /// BoolProperty: bFreezeSoakBehaviour
    /// </summary>
    public unsafe bool bFreezeSoakBehaviour
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 52) & 67108864) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 52); var newMask = value ? (currentMask | 67108864) : (currentMask & ~67108864); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 52); }
    }

    /// <summary>
    /// BoolProperty: bAcceleratedRiddlerProgress
    /// </summary>
    public unsafe bool bAcceleratedRiddlerProgress
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 52) & 134217728) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 52); var newMask = value ? (currentMask | 134217728) : (currentMask & ~134217728); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 52); }
    }

    /// <summary>
    /// BoolProperty: bBehaviourDebugOutput
    /// </summary>
    public unsafe bool bBehaviourDebugOutput
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 52) & 268435456) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 52); var newMask = value ? (currentMask | 268435456) : (currentMask & ~268435456); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 52); }
    }

    /// <summary>
    /// BoolProperty: bCombatDebugOutput
    /// </summary>
    public unsafe bool bCombatDebugOutput
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 52) & 536870912) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 52); var newMask = value ? (currentMask | 536870912) : (currentMask & ~536870912); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 52); }
    }

    /// <summary>
    /// BoolProperty: bAIInvulnerable
    /// </summary>
    public unsafe bool bAIInvulnerable
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 52) & 1073741824) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 52); var newMask = value ? (currentMask | 1073741824) : (currentMask & ~1073741824); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 52); }
    }

    /// <summary>
    /// BoolProperty: bShowAlerts
    /// </summary>
    public unsafe bool bShowAlerts
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 52) & -2147483648) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 52); var newMask = value ? (currentMask | -2147483648) : (currentMask & ~-2147483648); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 52); }
    }

    /// <summary>
    /// BoolProperty: bShowAlertLines
    /// </summary>
    public unsafe bool bShowAlertLines
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 56) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 56); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 56); }
    }

    /// <summary>
    /// BoolProperty: bShowPlayerVisibility
    /// </summary>
    public unsafe bool bShowPlayerVisibility
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 56) & 2) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 56); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 56); }
    }

    /// <summary>
    /// BoolProperty: bShowEventInstigatorVisibility
    /// </summary>
    public unsafe bool bShowEventInstigatorVisibility
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 56) & 4) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 56); var newMask = value ? (currentMask | 4) : (currentMask & ~4); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 56); }
    }

    /// <summary>
    /// BoolProperty: bShowChaseTrees
    /// </summary>
    public unsafe bool bShowChaseTrees
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 56) & 8) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 56); var newMask = value ? (currentMask | 8) : (currentMask & ~8); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 56); }
    }

    /// <summary>
    /// BoolProperty: bShowViewCone
    /// </summary>
    public unsafe bool bShowViewCone
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 56) & 16) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 56); var newMask = value ? (currentMask | 16) : (currentMask & ~16); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 56); }
    }

    /// <summary>
    /// BoolProperty: bPauseOnChaseFail
    /// </summary>
    public unsafe bool bPauseOnChaseFail
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 56) & 32) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 56); var newMask = value ? (currentMask | 32) : (currentMask & ~32); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 56); }
    }

    /// <summary>
    /// BoolProperty: bShowAntiBacktrack
    /// </summary>
    public unsafe bool bShowAntiBacktrack
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 56) & 64) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 56); var newMask = value ? (currentMask | 64) : (currentMask & ~64); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 56); }
    }

    /// <summary>
    /// BoolProperty: bGargSmashingActive
    /// </summary>
    public unsafe bool bGargSmashingActive
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 56) & 128) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 56); var newMask = value ? (currentMask | 128) : (currentMask & ~128); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 56); }
    }

    /// <summary>
    /// BoolProperty: bForceCasualtyKicking
    /// </summary>
    public unsafe bool bForceCasualtyKicking
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 56) & 256) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 56); var newMask = value ? (currentMask | 256) : (currentMask & ~256); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 56); }
    }

    /// <summary>
    /// BoolProperty: bAIVocalDebug
    /// </summary>
    public unsafe bool bAIVocalDebug
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 56) & 512) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 56); var newMask = value ? (currentMask | 512) : (currentMask & ~512); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 56); }
    }

    /// <summary>
    /// BoolProperty: bAIVocalDebugEmotes
    /// </summary>
    public unsafe bool bAIVocalDebugEmotes
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 56) & 1024) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 56); var newMask = value ? (currentMask | 1024) : (currentMask & ~1024); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 56); }
    }

    /// <summary>
    /// BoolProperty: bAIVocalDebugBarks
    /// </summary>
    public unsafe bool bAIVocalDebugBarks
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 56) & 2048) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 56); var newMask = value ? (currentMask | 2048) : (currentMask & ~2048); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 56); }
    }

    /// <summary>
    /// BoolProperty: bAIVocalDebugSpeech
    /// </summary>
    public unsafe bool bAIVocalDebugSpeech
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 56) & 4096) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 56); var newMask = value ? (currentMask | 4096) : (currentMask & ~4096); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 56); }
    }

    /// <summary>
    /// BoolProperty: Debug_Combat_CanAlwaysTakedown
    /// </summary>
    public unsafe bool Debug_Combat_CanAlwaysTakedown
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 56) & 8192) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 56); var newMask = value ? (currentMask | 8192) : (currentMask & ~8192); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 56); }
    }

    /// <summary>
    /// BoolProperty: Debug_Combat_AlwaysSuperComboMode
    /// </summary>
    public unsafe bool Debug_Combat_AlwaysSuperComboMode
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 56) & 16384) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 56); var newMask = value ? (currentMask | 16384) : (currentMask & ~16384); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 56); }
    }

    /// <summary>
    /// BoolProperty: Debug_Combat_AlwaysFinalBlow
    /// </summary>
    public unsafe bool Debug_Combat_AlwaysFinalBlow
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 56) & 32768) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 56); var newMask = value ? (currentMask | 32768) : (currentMask & ~32768); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 56); }
    }

    /// <summary>
    /// BoolProperty: Debug_Combat_CanAttack
    /// </summary>
    public unsafe bool Debug_Combat_CanAttack
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 56) & 65536) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 56); var newMask = value ? (currentMask | 65536) : (currentMask & ~65536); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 56); }
    }

    /// <summary>
    /// BoolProperty: Debug_Combat_ForceEnvironmentUse
    /// </summary>
    public unsafe bool Debug_Combat_ForceEnvironmentUse
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 56) & 131072) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 56); var newMask = value ? (currentMask | 131072) : (currentMask & ~131072); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 56); }
    }

    /// <summary>
    /// BoolProperty: Debug_Combat_PreventEnvironmentUse
    /// </summary>
    public unsafe bool Debug_Combat_PreventEnvironmentUse
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 56) & 262144) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 56); var newMask = value ? (currentMask | 262144) : (currentMask & ~262144); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 56); }
    }

    /// <summary>
    /// BoolProperty: Debug_Combat_ShowDamageCollision
    /// </summary>
    public unsafe bool Debug_Combat_ShowDamageCollision
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 56) & 524288) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 56); var newMask = value ? (currentMask | 524288) : (currentMask & ~524288); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 56); }
    }

    /// <summary>
    /// BoolProperty: Debug_Combat_CameraAssist
    /// </summary>
    public unsafe bool Debug_Combat_CameraAssist
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 56) & 1048576) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 56); var newMask = value ? (currentMask | 1048576) : (currentMask & ~1048576); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 56); }
    }

    /// <summary>
    /// BoolProperty: Debug_Combat_ShowRagdollImpulse
    /// </summary>
    public unsafe bool Debug_Combat_ShowRagdollImpulse
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 56) & 2097152) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 56); var newMask = value ? (currentMask | 2097152) : (currentMask & ~2097152); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 56); }
    }

    /// <summary>
    /// BoolProperty: Debug_Combat_EnableCounterBreak
    /// </summary>
    public unsafe bool Debug_Combat_EnableCounterBreak
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 56) & 4194304) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 56); var newMask = value ? (currentMask | 4194304) : (currentMask & ~4194304); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 56); }
    }

    /// <summary>
    /// BoolProperty: Debug_Combat_DisableHighlights
    /// </summary>
    public unsafe bool Debug_Combat_DisableHighlights
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 56) & 8388608) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 56); var newMask = value ? (currentMask | 8388608) : (currentMask & ~8388608); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 56); }
    }

    /// <summary>
    /// BoolProperty: Debug_Combat_DisableStunStars
    /// </summary>
    public unsafe bool Debug_Combat_DisableStunStars
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 56) & 16777216) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 56); var newMask = value ? (currentMask | 16777216) : (currentMask & ~16777216); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 56); }
    }

    /// <summary>
    /// BoolProperty: Debug_Combat_DisableImpactVFX
    /// </summary>
    public unsafe bool Debug_Combat_DisableImpactVFX
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 56) & 33554432) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 56); var newMask = value ? (currentMask | 33554432) : (currentMask & ~33554432); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 56); }
    }

    /// <summary>
    /// BoolProperty: Debug_Combat_DisableStrikeTrails
    /// </summary>
    public unsafe bool Debug_Combat_DisableStrikeTrails
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 56) & 67108864) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 56); var newMask = value ? (currentMask | 67108864) : (currentMask & ~67108864); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 56); }
    }

    /// <summary>
    /// BoolProperty: Debug_Combat_EnableSimultaneousAttacks
    /// </summary>
    public unsafe bool Debug_Combat_EnableSimultaneousAttacks
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 56) & 134217728) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 56); var newMask = value ? (currentMask | 134217728) : (currentMask & ~134217728); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 56); }
    }

    /// <summary>
    /// BoolProperty: Debug_Combat_OnlySimultaneousAttacks
    /// </summary>
    public unsafe bool Debug_Combat_OnlySimultaneousAttacks
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 56) & 268435456) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 56); var newMask = value ? (currentMask | 268435456) : (currentMask & ~268435456); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 56); }
    }

    /// <summary>
    /// BoolProperty: Debug_Combat_AlwaysSlowdownSimultaneousAttacks
    /// </summary>
    public unsafe bool Debug_Combat_AlwaysSlowdownSimultaneousAttacks
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 56) & 536870912) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 56); var newMask = value ? (currentMask | 536870912) : (currentMask & ~536870912); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 56); }
    }

    /// <summary>
    /// BoolProperty: Debug_Combat_ForceMaxSimultaneousAttackers
    /// </summary>
    public unsafe bool Debug_Combat_ForceMaxSimultaneousAttackers
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 56) & 1073741824) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 56); var newMask = value ? (currentMask | 1073741824) : (currentMask & ~1073741824); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 56); }
    }

    /// <summary>
    /// BoolProperty: Debug_Combat_ShowDesiredPosition
    /// </summary>
    public unsafe bool Debug_Combat_ShowDesiredPosition
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 56) & -2147483648) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 56); var newMask = value ? (currentMask | -2147483648) : (currentMask & ~-2147483648); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 56); }
    }

    /// <summary>
    /// BoolProperty: Debug_Combat_DisableWeakMoves
    /// </summary>
    public unsafe bool Debug_Combat_DisableWeakMoves
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 60) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 60); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 60); }
    }

    /// <summary>
    /// BoolProperty: Debug_Combat_BatBot
    /// </summary>
    public unsafe bool Debug_Combat_BatBot
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 60) & 2) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 60); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 60); }
    }

    /// <summary>
    /// BoolProperty: Debug_Combat_CatBot
    /// </summary>
    public unsafe bool Debug_Combat_CatBot
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 60) & 4) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 60); var newMask = value ? (currentMask | 4) : (currentMask & ~4); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 60); }
    }

    /// <summary>
    /// BoolProperty: Debug_Combat_RasChargeOn
    /// </summary>
    public unsafe bool Debug_Combat_RasChargeOn
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 60) & 8) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 60); var newMask = value ? (currentMask | 8) : (currentMask & ~8); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 60); }
    }

    /// <summary>
    /// BoolProperty: Debug_Combat_RasRepeatSwordAttack
    /// </summary>
    public unsafe bool Debug_Combat_RasRepeatSwordAttack
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 60) & 16) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 60); var newMask = value ? (currentMask | 16) : (currentMask & ~16); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 60); }
    }

    /// <summary>
    /// BoolProperty: Debug_Combat_RasSwordClusterOn
    /// </summary>
    public unsafe bool Debug_Combat_RasSwordClusterOn
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 60) & 32) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 60); var newMask = value ? (currentMask | 32) : (currentMask & ~32); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 60); }
    }

    /// <summary>
    /// BoolProperty: Debug_Combat_RasShowLookAt
    /// </summary>
    public unsafe bool Debug_Combat_RasShowLookAt
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 60) & 64) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 60); var newMask = value ? (currentMask | 64) : (currentMask & ~64); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 60); }
    }

    /// <summary>
    /// BoolProperty: Debug_Combat_DisableXPBats
    /// </summary>
    public unsafe bool Debug_Combat_DisableXPBats
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 60) & 128) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 60); var newMask = value ? (currentMask | 128) : (currentMask & ~128); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 60); }
    }

    /// <summary>
    /// BoolProperty: Debug_Combat_TargettingCone
    /// </summary>
    public unsafe bool Debug_Combat_TargettingCone
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 60) & 256) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 60); var newMask = value ? (currentMask | 256) : (currentMask & ~256); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 60); }
    }

    /// <summary>
    /// BoolProperty: Debug_Combat_Targets
    /// </summary>
    public unsafe bool Debug_Combat_Targets
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 60) & 512) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 60); var newMask = value ? (currentMask | 512) : (currentMask & ~512); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 60); }
    }

    /// <summary>
    /// BoolProperty: Debug_Combat_CameraOrientation
    /// </summary>
    public unsafe bool Debug_Combat_CameraOrientation
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 60) & 1024) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 60); var newMask = value ? (currentMask | 1024) : (currentMask & ~1024); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 60); }
    }

    /// <summary>
    /// BoolProperty: Debug_Combat_ShowMoveForceLines
    /// </summary>
    public unsafe bool Debug_Combat_ShowMoveForceLines
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 60) & 2048) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 60); var newMask = value ? (currentMask | 2048) : (currentMask & ~2048); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 60); }
    }

    /// <summary>
    /// BoolProperty: Debug_Combat_LogCombatMoves
    /// </summary>
    public unsafe bool Debug_Combat_LogCombatMoves
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 60) & 4096) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 60); var newMask = value ? (currentMask | 4096) : (currentMask & ~4096); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 60); }
    }

    /// <summary>
    /// BoolProperty: Debug_Combat_ShowCombatAreas
    /// </summary>
    public unsafe bool Debug_Combat_ShowCombatAreas
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 60) & 8192) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 60); var newMask = value ? (currentMask | 8192) : (currentMask & ~8192); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 60); }
    }

    /// <summary>
    /// BoolProperty: Debug_Combat_ShowCylinderCollisionChecks
    /// </summary>
    public unsafe bool Debug_Combat_ShowCylinderCollisionChecks
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 60) & 16384) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 60); var newMask = value ? (currentMask | 16384) : (currentMask & ~16384); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 60); }
    }

    /// <summary>
    /// BoolProperty: Debug_Combat_ShowGroupStunRadius
    /// </summary>
    public unsafe bool Debug_Combat_ShowGroupStunRadius
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 60) & 32768) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 60); var newMask = value ? (currentMask | 32768) : (currentMask & ~32768); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 60); }
    }

    /// <summary>
    /// BoolProperty: Debug_Combat_OneHitKill
    /// </summary>
    public unsafe bool Debug_Combat_OneHitKill
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 60) & 65536) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 60); var newMask = value ? (currentMask | 65536) : (currentMask & ~65536); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 60); }
    }

    /// <summary>
    /// BoolProperty: Debug_Combat_ShowMoveToPlayerDebug
    /// </summary>
    public unsafe bool Debug_Combat_ShowMoveToPlayerDebug
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 60) & 131072) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 60); var newMask = value ? (currentMask | 131072) : (currentMask & ~131072); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 60); }
    }

    /// <summary>
    /// BoolProperty: Debug_Sniper_ShowViewCones
    /// </summary>
    public unsafe bool Debug_Sniper_ShowViewCones
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 60) & 262144) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 60); var newMask = value ? (currentMask | 262144) : (currentMask & ~262144); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 60); }
    }

    /// <summary>
    /// BoolProperty: Debug_Show_VenomDebug
    /// </summary>
    public unsafe bool Debug_Show_VenomDebug
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 60) & 524288) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 60); var newMask = value ? (currentMask | 524288) : (currentMask & ~524288); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 60); }
    }

    /// <summary>
    /// BoolProperty: Debug_Venom_KeepInView
    /// </summary>
    public unsafe bool Debug_Venom_KeepInView
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 60) & 1048576) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 60); var newMask = value ? (currentMask | 1048576) : (currentMask & ~1048576); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 60); }
    }

    /// <summary>
    /// BoolProperty: Debug_Venom_ShowClampedAim
    /// </summary>
    public unsafe bool Debug_Venom_ShowClampedAim
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 60) & 2097152) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 60); var newMask = value ? (currentMask | 2097152) : (currentMask & ~2097152); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 60); }
    }

    /// <summary>
    /// BoolProperty: Debug_Venom_ShowAttacking
    /// </summary>
    public unsafe bool Debug_Venom_ShowAttacking
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 60) & 4194304) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 60); var newMask = value ? (currentMask | 4194304) : (currentMask & ~4194304); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 60); }
    }

    /// <summary>
    /// BoolProperty: Debug_Player_ShowXP
    /// </summary>
    public unsafe bool Debug_Player_ShowXP
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 60) & 8388608) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 60); var newMask = value ? (currentMask | 8388608) : (currentMask & ~8388608); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 60); }
    }

    /// <summary>
    /// BoolProperty: Debug_Player_ShowXPAttractors
    /// </summary>
    public unsafe bool Debug_Player_ShowXPAttractors
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 60) & 16777216) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 60); var newMask = value ? (currentMask | 16777216) : (currentMask & ~16777216); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 60); }
    }

    /// <summary>
    /// BoolProperty: Debug_Player_EnableThoughts
    /// </summary>
    public unsafe bool Debug_Player_EnableThoughts
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 60) & 33554432) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 60); var newMask = value ? (currentMask | 33554432) : (currentMask & ~33554432); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 60); }
    }

    /// <summary>
    /// BoolProperty: Debug_Player_EnableThoughtsInterrogation
    /// </summary>
    public unsafe bool Debug_Player_EnableThoughtsInterrogation
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 60) & 67108864) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 60); var newMask = value ? (currentMask | 67108864) : (currentMask & ~67108864); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 60); }
    }

    /// <summary>
    /// BoolProperty: Debug_Player_ShowCeilingInfo
    /// </summary>
    public unsafe bool Debug_Player_ShowCeilingInfo
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 60) & 134217728) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 60); var newMask = value ? (currentMask | 134217728) : (currentMask & ~134217728); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 60); }
    }

    /// <summary>
    /// BoolProperty: Debug_Navigation_ShowDebug
    /// </summary>
    public unsafe bool Debug_Navigation_ShowDebug
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 60) & 268435456) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 60); var newMask = value ? (currentMask | 268435456) : (currentMask & ~268435456); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 60); }
    }

    /// <summary>
    /// BoolProperty: Debug_Navigation_ShowAIPaths
    /// </summary>
    public unsafe bool Debug_Navigation_ShowAIPaths
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 60) & 536870912) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 60); var newMask = value ? (currentMask | 536870912) : (currentMask & ~536870912); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 60); }
    }

    /// <summary>
    /// BoolProperty: Debug_Navigation_ShowPathPolys
    /// </summary>
    public unsafe bool Debug_Navigation_ShowPathPolys
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 60) & 1073741824) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 60); var newMask = value ? (currentMask | 1073741824) : (currentMask & ~1073741824); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 60); }
    }

    /// <summary>
    /// BoolProperty: Debug_Navigation_ShowInlineHandling
    /// </summary>
    public unsafe bool Debug_Navigation_ShowInlineHandling
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 60) & -2147483648) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 60); var newMask = value ? (currentMask | -2147483648) : (currentMask & ~-2147483648); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 60); }
    }

    /// <summary>
    /// BoolProperty: Debug_Navigation_ShowAllPaths
    /// </summary>
    public unsafe bool Debug_Navigation_ShowAllPaths
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 64) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 64); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 64); }
    }

    /// <summary>
    /// BoolProperty: Debug_Navigation_ShowAIAvoidance
    /// </summary>
    public unsafe bool Debug_Navigation_ShowAIAvoidance
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 64) & 2) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 64); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 64); }
    }

    /// <summary>
    /// BoolProperty: Debug_Navigation_ShowTraversalHistory
    /// </summary>
    public unsafe bool Debug_Navigation_ShowTraversalHistory
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 64) & 4) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 64); var newMask = value ? (currentMask | 4) : (currentMask & ~4); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 64); }
    }

    /// <summary>
    /// BoolProperty: Debug_Navigation_PauseOnStuck
    /// </summary>
    public unsafe bool Debug_Navigation_PauseOnStuck
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 64) & 8) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 64); var newMask = value ? (currentMask | 8) : (currentMask & ~8); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 64); }
    }

    /// <summary>
    /// BoolProperty: bVisualiseGrenades
    /// </summary>
    public unsafe bool bVisualiseGrenades
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 64) & 16) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 64); var newMask = value ? (currentMask | 16) : (currentMask & ~16); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 64); }
    }

    /// <summary>
    /// BoolProperty: Debug_ShowProgress
    /// </summary>
    public unsafe bool Debug_ShowProgress
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 64) & 32) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 64); var newMask = value ? (currentMask | 32) : (currentMask & ~32); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 64); }
    }

    /// <summary>
    /// BoolProperty: Debug_DebugLabels
    /// </summary>
    public unsafe bool Debug_DebugLabels
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 64) & 64) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 64); var newMask = value ? (currentMask | 64) : (currentMask & ~64); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 64); }
    }

    /// <summary>
    /// BoolProperty: Debug_bLocalizationWarning
    /// </summary>
    public unsafe bool Debug_bLocalizationWarning
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 64) & 128) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 64); var newMask = value ? (currentMask | 128) : (currentMask & ~128); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 64); }
    }

    /// <summary>
    /// BoolProperty: Debug_Disable_All_Capes
    /// </summary>
    public unsafe bool Debug_Disable_All_Capes
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 64) & 256) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 64); var newMask = value ? (currentMask | 256) : (currentMask & ~256); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 64); }
    }

    /// <summary>
    /// BoolProperty: Debug_Hide_Cape
    /// </summary>
    public unsafe bool Debug_Hide_Cape
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 64) & 512) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 64); var newMask = value ? (currentMask | 512) : (currentMask & ~512); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 64); }
    }

    /// <summary>
    /// BoolProperty: Debug_Enable_Cape_Thoughts
    /// </summary>
    public unsafe bool Debug_Enable_Cape_Thoughts
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 64) & 1024) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 64); var newMask = value ? (currentMask | 1024) : (currentMask & ~1024); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 64); }
    }

    /// <summary>
    /// BoolProperty: Debug_Draw_Cape_Debug_Lines
    /// </summary>
    public unsafe bool Debug_Draw_Cape_Debug_Lines
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 64) & 2048) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 64); var newMask = value ? (currentMask | 2048) : (currentMask & ~2048); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 64); }
    }

    /// <summary>
    /// BoolProperty: Debug_Draw_Water_Volume_Debug_Lines
    /// </summary>
    public unsafe bool Debug_Draw_Water_Volume_Debug_Lines
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 64) & 4096) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 64); var newMask = value ? (currentMask | 4096) : (currentMask & ~4096); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 64); }
    }

    /// <summary>
    /// BoolProperty: Debug_Draw_Full_Cape_Debug_Lines
    /// </summary>
    public unsafe bool Debug_Draw_Full_Cape_Debug_Lines
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 64) & 8192) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 64); var newMask = value ? (currentMask | 8192) : (currentMask & ~8192); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 64); }
    }

    /// <summary>
    /// BoolProperty: Debug_Force_Animated_Cape
    /// </summary>
    public unsafe bool Debug_Force_Animated_Cape
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 64) & 16384) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 64); var newMask = value ? (currentMask | 16384) : (currentMask & ~16384); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 64); }
    }

    /// <summary>
    /// BoolProperty: Debug_Disable_Cape_Depth_Bias
    /// </summary>
    public unsafe bool Debug_Disable_Cape_Depth_Bias
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 64) & 32768) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 64); var newMask = value ? (currentMask | 32768) : (currentMask & ~32768); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 64); }
    }

    /// <summary>
    /// BoolProperty: Debug_Enable_Actor_Thoughts
    /// </summary>
    public unsafe bool Debug_Enable_Actor_Thoughts
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 64) & 65536) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 64); var newMask = value ? (currentMask | 65536) : (currentMask & ~65536); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 64); }
    }

    /// <summary>
    /// BoolProperty: Disable_Grate_Excluders
    /// </summary>
    public unsafe bool Disable_Grate_Excluders
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 64) & 131072) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 64); var newMask = value ? (currentMask | 131072) : (currentMask & ~131072); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 64); }
    }

    /// <summary>
    /// BoolProperty: Debug_Draw_Rope_Debug_Lines
    /// </summary>
    public unsafe bool Debug_Draw_Rope_Debug_Lines
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 64) & 262144) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 64); var newMask = value ? (currentMask | 262144) : (currentMask & ~262144); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 64); }
    }

    /// <summary>
    /// BoolProperty: Debug_Enable_Rope_Thoughts
    /// </summary>
    public unsafe bool Debug_Enable_Rope_Thoughts
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 64) & 524288) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 64); var newMask = value ? (currentMask | 524288) : (currentMask & ~524288); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 64); }
    }

    /// <summary>
    /// BoolProperty: Debug_DisableRiddlerChallenges
    /// </summary>
    public unsafe bool Debug_DisableRiddlerChallenges
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 64) & 1048576) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 64); var newMask = value ? (currentMask | 1048576) : (currentMask & ~1048576); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 64); }
    }

    /// <summary>
    /// BoolProperty: Debug_Enable_Audio_Thoughts
    /// </summary>
    public unsafe bool Debug_Enable_Audio_Thoughts
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 64) & 2097152) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 64); var newMask = value ? (currentMask | 2097152) : (currentMask & ~2097152); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 64); }
    }

    /// <summary>
    /// FloatProperty: DebugGCTime
    /// </summary>
    public unsafe float DebugGCTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 68); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 68); }
    }

    /// <summary>
    /// IntProperty: Debug_AI_PathFindsPerFrame
    /// </summary>
    public unsafe int Debug_AI_PathFindsPerFrame
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 72); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 72); }
    }

    /// <summary>
    /// IntProperty: Debug_AI_PathShortensPerFrame
    /// </summary>
    public unsafe int Debug_AI_PathShortensPerFrame
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 76); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 76); }
    }

    /// <summary>
    /// IntProperty: ChaseTreeSearchDist
    /// </summary>
    public unsafe int ChaseTreeSearchDist
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 80); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 80); }
    }

    /// <summary>
    /// FloatProperty: Debug_Combat_TargettingArc
    /// </summary>
    public unsafe float Debug_Combat_TargettingArc
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 84); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 84); }
    }

    /// <summary>
    /// FloatProperty: Debug_Combat_ComboLengthMin
    /// </summary>
    public unsafe float Debug_Combat_ComboLengthMin
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 88); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 88); }
    }

    /// <summary>
    /// FloatProperty: Debug_Combat_AllyDist
    /// </summary>
    public unsafe float Debug_Combat_AllyDist
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 92); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 92); }
    }

    /// <summary>
    /// FloatProperty: Debug_Combat_BMForce
    /// </summary>
    public unsafe float Debug_Combat_BMForce
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 96); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 96); }
    }

    /// <summary>
    /// FloatProperty: Debug_Combat_AllyForce
    /// </summary>
    public unsafe float Debug_Combat_AllyForce
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 100); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 100); }
    }

    /// <summary>
    /// FloatProperty: Debug_Combat_MinMoveForce
    /// </summary>
    public unsafe float Debug_Combat_MinMoveForce
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 104); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 104); }
    }

    /// <summary>
    /// FloatProperty: Debug_Combat_StunTime
    /// </summary>
    public unsafe float Debug_Combat_StunTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 108); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 108); }
    }

    /// <summary>
    /// FloatProperty: Debug_Combat_ZapTime
    /// </summary>
    public unsafe float Debug_Combat_ZapTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 112); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 112); }
    }

    /// <summary>
    /// IntProperty: Debug_Combat_OverrideChapter
    /// </summary>
    public unsafe int Debug_Combat_OverrideChapter
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 116); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 116); }
    }

    /// <summary>
    /// ArrayProperty: Debug_Combat_Sets
    /// </summary>
    public unsafe BmSDK.TArray<bool> Debug_Combat_Sets
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<bool>>(Ptr + 120); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 120); }
    }

    /// <summary>
    /// IntProperty: Debug_Sniper_ViewConeDisplayRange
    /// </summary>
    public unsafe int Debug_Sniper_ViewConeDisplayRange
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 132); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 132); }
    }

    /// <summary>
    /// FloatProperty: Debug_Sniper_ViewConeFOV
    /// </summary>
    public unsafe float Debug_Sniper_ViewConeFOV
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 136); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 136); }
    }

    /// <summary>
    /// FloatProperty: Debug_Sniper_ViewConeVertMulti
    /// </summary>
    public unsafe float Debug_Sniper_ViewConeVertMulti
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 140); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 140); }
    }

    /// <summary>
    /// ByteProperty: Debug_Azrael_SideStoryProgress
    /// </summary>
    public unsafe byte Debug_Azrael_SideStoryProgress
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 144); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 144); }
    }

    /// <summary>
    /// ByteProperty: Debug_Bane_SideStoryProgress
    /// </summary>
    public unsafe byte Debug_Bane_SideStoryProgress
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 145); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 145); }
    }

    /// <summary>
    /// ByteProperty: Debug_Deadshot_SideStoryProgress
    /// </summary>
    public unsafe byte Debug_Deadshot_SideStoryProgress
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 146); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 146); }
    }

    /// <summary>
    /// ByteProperty: Debug_Hush_SideStoryProgress
    /// </summary>
    public unsafe byte Debug_Hush_SideStoryProgress
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 147); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 147); }
    }

    /// <summary>
    /// ByteProperty: Debug_MadHatter_SideStoryProgress
    /// </summary>
    public unsafe byte Debug_MadHatter_SideStoryProgress
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 148); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 148); }
    }

    /// <summary>
    /// ByteProperty: Debug_NoraFries_SideStoryProgress
    /// </summary>
    public unsafe byte Debug_NoraFries_SideStoryProgress
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 149); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 149); }
    }

    /// <summary>
    /// ByteProperty: Debug_Riddler_SideStoryProgress
    /// </summary>
    public unsafe byte Debug_Riddler_SideStoryProgress
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 150); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 150); }
    }

    /// <summary>
    /// ByteProperty: Debug_Zsasz_SideStoryProgress
    /// </summary>
    public unsafe byte Debug_Zsasz_SideStoryProgress
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 151); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 151); }
    }

    /// <summary>
    /// ByteProperty: Debug_AI_PhysWalkingType
    /// </summary>
    public unsafe BmSDK.BmGame.RGameRI.EPhysWalkingType Debug_AI_PhysWalkingType
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RGameRI.EPhysWalkingType>(Ptr + 152); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 152); }
    }

    /// <summary>
    /// IntProperty: Debug_Navigation_ShowShortenHistory
    /// </summary>
    public unsafe int Debug_Navigation_ShowShortenHistory
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 156); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 156); }
    }

    /// <summary>
    /// IntProperty: Debug_Navigation_ShowEdgeHistory
    /// </summary>
    public unsafe int Debug_Navigation_ShowEdgeHistory
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 160); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 160); }
    }

    /// <summary>
    /// FloatProperty: MaxGrenadeXYSpeed
    /// </summary>
    public unsafe float MaxGrenadeXYSpeed
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 164); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 164); }
    }

    /// <summary>
    /// FloatProperty: MaxGrenadeOverallSpeed
    /// </summary>
    public unsafe float MaxGrenadeOverallSpeed
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 168); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 168); }
    }

    /// <summary>
    /// StructProperty: GrenTraceExtent
    /// </summary>
    public unsafe System.Numerics.Vector3 GrenTraceExtent
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 172); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 172); }
    }

    /// <summary>
    /// StructProperty: Debug_Anim_Player
    /// </summary>
    public unsafe BmSDK.BmGame.RPersistentDebugData.FPerCharacterTypeAnimDebug Debug_Anim_Player
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPersistentDebugData.FPerCharacterTypeAnimDebug>(Ptr + 184); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 184); }
    }

    /// <summary>
    /// StructProperty: Debug_Anim_Npc
    /// </summary>
    public unsafe BmSDK.BmGame.RPersistentDebugData.FPerCharacterTypeAnimDebug Debug_Anim_Npc
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPersistentDebugData.FPerCharacterTypeAnimDebug>(Ptr + 220); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 220); }
    }
}
