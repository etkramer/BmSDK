#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Class: ForceFeedbackWaveform<br/>
/// (flags = 0)
/// </summary>
public partial class ForceFeedbackWaveform : BmSDK.GameObject, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Engine.ForceFeedbackWaveform", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal ForceFeedbackWaveform() { }

    /// <summary>
    /// Constructs a new ForceFeedbackWaveform
    /// </summary>
    public ForceFeedbackWaveform(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, ForceFeedbackWaveform Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected ForceFeedbackWaveform(nint ptr) : base(ptr) { }

    /// <summary>
    /// BoolProperty: bIsLooping
    /// </summary>
    public unsafe bool bIsLooping
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 84) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 84); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 84); }
    }

    /// <summary>
    /// BoolProperty: bIsHaptic
    /// </summary>
    public unsafe bool bIsHaptic
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 84) & 2) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 84); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 84); }
    }

    /// <summary>
    /// BoolProperty: bIsRightHaptic
    /// </summary>
    public unsafe bool bIsRightHaptic
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 84) & 4) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 84); var newMask = value ? (currentMask | 4) : (currentMask & ~4); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 84); }
    }

    /// <summary>
    /// ArrayProperty: Samples
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.Engine.ForceFeedbackWaveform.FWaveformSample> Samples
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.ForceFeedbackWaveform.FWaveformSample>>(Ptr + 88); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 88); }
    }

    /// <summary>
    /// FloatProperty: WaveformFalloffStartDistance
    /// </summary>
    public unsafe float WaveformFalloffStartDistance
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 104); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 104); }
    }

    /// <summary>
    /// FloatProperty: MaxWaveformDistance
    /// </summary>
    public unsafe float MaxWaveformDistance
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 108); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 108); }
    }

    /// <summary>
    /// Struct: FWaveformSample
    /// </summary>
    [StructLayout(LayoutKind.Explicit)]
    public partial record struct FWaveformSample
    {
        /// <summary>
        /// ByteProperty: LeftAmplitude
        /// </summary>
        public unsafe byte LeftAmplitude
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// ByteProperty: RightAmplitude
        /// </summary>
        public unsafe byte RightAmplitude
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 1); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1); }; }
        }

        /// <summary>
        /// ByteProperty: LeftFunction
        /// </summary>
        public unsafe BmSDK.Engine.ForceFeedbackWaveform.EWaveformFunction LeftFunction
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ForceFeedbackWaveform.EWaveformFunction>(Ptr + 2); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2); }; }
        }

        /// <summary>
        /// ByteProperty: RightFunction
        /// </summary>
        public unsafe BmSDK.Engine.ForceFeedbackWaveform.EWaveformFunction RightFunction
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ForceFeedbackWaveform.EWaveformFunction>(Ptr + 3); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3); }; }
        }

        /// <summary>
        /// FloatProperty: Duration
        /// </summary>
        public unsafe float Duration
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4); }; }
        }
    }

    /// <summary>
    /// Enum: EWaveformFunction
    /// </summary>
    public enum EWaveformFunction
    {
        WF_Constant = 0,
        WF_LinearIncreasing = 1,
        WF_LinearDecreasing = 2,
        WF_Sin0to90 = 3,
        WF_Sin90to180 = 4,
        WF_Sin0to180 = 5,
        WF_Noise = 6,
        WF_MAX = 7,
    }
}
