#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.AkAudio;

/// <summary>
/// Class: SeqAct_AkAudioParameter<br/>
/// (flags = 0)
/// </summary>
public partial class SeqAct_AkAudioParameter : BmSDK.Engine.SequenceAction, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "AkAudio.SeqAct_AkAudioParameter", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal SeqAct_AkAudioParameter() { }

    /// <summary>
    /// Constructs a new SeqAct_AkAudioParameter
    /// </summary>
    public SeqAct_AkAudioParameter(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, SeqAct_AkAudioParameter Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected SeqAct_AkAudioParameter(nint ptr) : base(ptr) { }

    /// <summary>
    /// ObjectProperty: AudioParameter
    /// </summary>
    public unsafe BmSDK.Engine.AkParameterName AudioParameter
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkParameterName>(Ptr + 352); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 352); }
    }

    /// <summary>
    /// FloatProperty: ToValue
    /// </summary>
    public unsafe float ToValue
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 360); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 360); }
    }

    /// <summary>
    /// FloatProperty: InterpolationTime
    /// </summary>
    public unsafe float InterpolationTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 364); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 364); }
    }

    /// <summary>
    /// ArrayProperty: InterpolationInfo
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.AkAudio.SeqAct_AkAudioParameter.FSeqAct_AkAudioParameterInterpolationInfo> InterpolationInfo
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.AkAudio.SeqAct_AkAudioParameter.FSeqAct_AkAudioParameterInterpolationInfo>>(Ptr + 368); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 368); }
    }

    /// <summary>
    /// FloatProperty: CurrentInterpolationTime
    /// </summary>
    public unsafe float CurrentInterpolationTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 384); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 384); }
    }

    /// <summary>
    /// StructProperty: InterpolationStartTime
    /// </summary>
    public unsafe double InterpolationStartTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<double>(Ptr + 388); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 388); }
    }

    /// <summary>
    /// Struct: FSeqAct_AkAudioParameterInterpolationInfo
    /// </summary>
    [StructLayout(LayoutKind.Explicit)]
    public partial record struct FSeqAct_AkAudioParameterInterpolationInfo
    {
        /// <summary>
        /// ObjectProperty: InterpolationParameterTarget
        /// </summary>
        public unsafe BmSDK.Engine.Actor InterpolationParameterTarget
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.Actor>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// FloatProperty: InterpolationStartValue
        /// </summary>
        public unsafe float InterpolationStartValue
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 8); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8); }; }
        }

        /// <summary>
        /// FloatProperty: InterpolationEndValue
        /// </summary>
        public unsafe float InterpolationEndValue
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 12); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 12); }; }
        }
    }
}
