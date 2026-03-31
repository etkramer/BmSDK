#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Class: CameraShake<br/>
/// (size = 168)
/// (flags = 134221970)
/// </summary>
public partial class CameraShake : BmSDK.GameObject, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Engine.CameraShake", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    /// <summary>
    /// Gets the class default object as CameraShake.
    /// </summary>
    public static CameraShake DefaultObject => (CameraShake)StaticClass().DefaultObject;

    internal CameraShake() { }

    /// <summary>
    /// Constructs a new CameraShake
    /// </summary>
    public CameraShake(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, CameraShake Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected CameraShake(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<CameraShake>
        => ((GameObject)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<CameraShake>, new()
        => (TComponent)((GameObject)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<CameraShake>
        => ((GameObject)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<CameraShake>
        => ((GameObject)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<CameraShake>
        => (TComponent)((GameObject)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponents(Type)"/>
    public System.Collections.Generic.IReadOnlyList<TComponent> GetScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<CameraShake>
        => ((GameObject)this).GetScriptComponents(typeof(TComponent)).Cast<TComponent>().ToList();

    /// <inheritdoc cref="GameObject.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<CameraShake>
        => ((GameObject)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.DetachScriptComponents(Type)"/>
    public void DetachScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<CameraShake>
        => ((GameObject)this).DetachScriptComponents(typeof(TComponent));

    /// <summary>
    /// Struct: FVOscillator
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 36)]
    public partial record struct FVOscillator
    {
        /// <summary>
        /// StructProperty: X
        /// </summary>
        public unsafe BmSDK.Engine.CameraShake.FFOscillator X
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.CameraShake.FFOscillator>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// StructProperty: Y
        /// </summary>
        public unsafe BmSDK.Engine.CameraShake.FFOscillator Y
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.CameraShake.FFOscillator>(Ptr + 12); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 12); }; }
        }

        /// <summary>
        /// StructProperty: Z
        /// </summary>
        public unsafe BmSDK.Engine.CameraShake.FFOscillator Z
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.CameraShake.FFOscillator>(Ptr + 24); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 24); }; }
        }
    }

    /// <summary>
    /// Struct: FROscillator
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 36)]
    public partial record struct FROscillator
    {
        /// <summary>
        /// StructProperty: Pitch
        /// </summary>
        public unsafe BmSDK.Engine.CameraShake.FFOscillator Pitch
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.CameraShake.FFOscillator>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// StructProperty: Yaw
        /// </summary>
        public unsafe BmSDK.Engine.CameraShake.FFOscillator Yaw
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.CameraShake.FFOscillator>(Ptr + 12); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 12); }; }
        }

        /// <summary>
        /// StructProperty: Roll
        /// </summary>
        public unsafe BmSDK.Engine.CameraShake.FFOscillator Roll
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.CameraShake.FFOscillator>(Ptr + 24); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 24); }; }
        }
    }

    /// <summary>
    /// Struct: FFOscillator
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 9)]
    public partial record struct FFOscillator
    {
        /// <summary>
        /// FloatProperty: Amplitude
        /// </summary>
        public unsafe float Amplitude
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// FloatProperty: Frequency
        /// </summary>
        public unsafe float Frequency
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4); }; }
        }

        /// <summary>
        /// ByteProperty: InitialOffset
        /// </summary>
        public unsafe BmSDK.Engine.CameraShake.EInitialOscillatorOffset InitialOffset
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.CameraShake.EInitialOscillatorOffset>(Ptr + 8); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8); }; }
        }
    }

    /// <summary>
    /// Enum: EInitialOscillatorOffset
    /// </summary>
    public enum EInitialOscillatorOffset
    {
        EOO_OffsetRandom = 0,
        EOO_OffsetZero = 1,
        EOO_MAX = 2,
    }

    /// <summary>
    /// BoolProperty: bSingleInstance
    /// </summary>
    public unsafe bool bSingleInstance
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 44) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 44); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 44); }
    }

    /// <summary>
    /// BoolProperty: bRandomAnimSegment
    /// </summary>
    public unsafe bool bRandomAnimSegment
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 44) & 2) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 44); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 44); }
    }

    /// <summary>
    /// FloatProperty: OscillationDuration
    /// </summary>
    public unsafe float OscillationDuration
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 48); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 48); }
    }

    /// <summary>
    /// FloatProperty: OscillationBlendInTime
    /// </summary>
    public unsafe float OscillationBlendInTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 52); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 52); }
    }

    /// <summary>
    /// FloatProperty: OscillationBlendOutTime
    /// </summary>
    public unsafe float OscillationBlendOutTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 56); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 56); }
    }

    /// <summary>
    /// StructProperty: RotOscillation
    /// </summary>
    public unsafe ref BmSDK.Engine.CameraShake.FROscillator RotOscillation
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.Engine.CameraShake.FROscillator>(Ptr + 60);

    /// <summary>
    /// StructProperty: LocOscillation
    /// </summary>
    public unsafe ref BmSDK.Engine.CameraShake.FVOscillator LocOscillation
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.Engine.CameraShake.FVOscillator>(Ptr + 96);

    /// <summary>
    /// StructProperty: FOVOscillation
    /// </summary>
    public unsafe ref BmSDK.Engine.CameraShake.FFOscillator FOVOscillation
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.Engine.CameraShake.FFOscillator>(Ptr + 132);

    /// <summary>
    /// ObjectProperty: Anim
    /// </summary>
    public unsafe BmSDK.Engine.CameraAnim Anim
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.CameraAnim>(Ptr + 144); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 144); }
    }

    /// <summary>
    /// FloatProperty: AnimPlayRate
    /// </summary>
    public unsafe float AnimPlayRate
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 148); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 148); }
    }

    /// <summary>
    /// FloatProperty: AnimScale
    /// </summary>
    public unsafe float AnimScale
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 152); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 152); }
    }

    /// <summary>
    /// FloatProperty: AnimBlendInTime
    /// </summary>
    public unsafe float AnimBlendInTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 156); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 156); }
    }

    /// <summary>
    /// FloatProperty: AnimBlendOutTime
    /// </summary>
    public unsafe float AnimBlendOutTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 160); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 160); }
    }

    /// <summary>
    /// FloatProperty: RandomAnimSegmentDuration
    /// </summary>
    public unsafe float RandomAnimSegmentDuration
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 164); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 164); }
    }
}
