#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Class: ParticleSystemReplay<br/>
/// (size = 0)
/// (flags = 0)
/// </summary>
public partial class ParticleSystemReplay : BmSDK.GameObject, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Engine.ParticleSystemReplay", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal ParticleSystemReplay() { }

    /// <summary>
    /// Constructs a new ParticleSystemReplay
    /// </summary>
    public ParticleSystemReplay(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, ParticleSystemReplay Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected ParticleSystemReplay(nint ptr) : base(ptr) { }

    /// <summary>
    /// IntProperty: ClipIDNumber
    /// </summary>
    public unsafe int ClipIDNumber
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 84); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 84); }
    }

    /// <summary>
    /// ArrayProperty: Frames
    /// </summary>
    public unsafe NEED_UPDATE_ARRAYPROPERTY_LAYOUT Frames
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_ARRAYPROPERTY_LAYOUT>(Ptr + 88); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 88); }
    }

    /// <summary>
    /// Struct: FParticleSystemReplayFrame
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 0)]
    public partial record struct FParticleSystemReplayFrame
    {
        /// <summary>
        /// ArrayProperty: Emitters
        /// </summary>
        public unsafe NEED_UPDATE_ARRAYPROPERTY_LAYOUT Emitters
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_ARRAYPROPERTY_LAYOUT>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// FloatProperty: Time
        /// </summary>
        public unsafe float Time
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 16); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 16); }; }
        }
    }

    /// <summary>
    /// Struct: FParticleEmitterReplayFrame
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 0)]
    public partial record struct FParticleEmitterReplayFrame
    {
        /// <summary>
        /// IntProperty: EmitterType
        /// </summary>
        public unsafe int EmitterType
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// IntProperty: OriginalEmitterIndex
        /// </summary>
        public unsafe int OriginalEmitterIndex
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4); }; }
        }

        /// <summary>
        /// StructProperty: FrameState
        /// </summary>
        public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT FrameState
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 8); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8); }; }
        }
    }
}
