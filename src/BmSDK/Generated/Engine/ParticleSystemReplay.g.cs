#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Class: ParticleSystemReplay<br/>
/// (size = 60)
/// (flags = 134217874)
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
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 44); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 44); }
    }

    /// <summary>
    /// ArrayProperty: Frames
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.Engine.ParticleSystemReplay.FParticleSystemReplayFrame> Frames
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.ParticleSystemReplay.FParticleSystemReplayFrame>>(Ptr + 48); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 48); }
    }

    /// <summary>
    /// Struct: FParticleSystemReplayFrame
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 12)]
    public partial record struct FParticleSystemReplayFrame
    {
        /// <summary>
        /// ArrayProperty: Emitters
        /// </summary>
        public unsafe BmSDK.TArray<BmSDK.Engine.ParticleSystemReplay.FParticleEmitterReplayFrame> Emitters
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.ParticleSystemReplay.FParticleEmitterReplayFrame>>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }
    }

    /// <summary>
    /// Struct: FParticleEmitterReplayFrame
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 12)]
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
        public unsafe System.IntPtr FrameState
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<System.IntPtr>(Ptr + 8); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8); }; }
        }
    }
}
