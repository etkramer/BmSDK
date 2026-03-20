#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RAnimUtil_FaceFXOutput<br/>
/// (flags = 0)
/// </summary>
public partial class RAnimUtil_FaceFXOutput : BmSDK.GameObject, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RAnimUtil_FaceFXOutput", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RAnimUtil_FaceFXOutput() { }

    /// <summary>
    /// Constructs a new RAnimUtil_FaceFXOutput
    /// </summary>
    public RAnimUtil_FaceFXOutput(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RAnimUtil_FaceFXOutput Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RAnimUtil_FaceFXOutput(nint ptr) : base(ptr) { }

    /// <summary>
    /// StructProperty: CurrentBlinkState
    /// </summary>
    public unsafe BmSDK.BmGame.RAnimUtil_FaceFXOutput.FBlinkState CurrentBlinkState
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RAnimUtil_FaceFXOutput.FBlinkState>(Ptr + 84); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 84); }
    }

    /// <summary>
    /// StructProperty: CurrentLeftEyeRotation
    /// </summary>
    public unsafe BmSDK.BmGame.RAnimUtil.FYawPitch CurrentLeftEyeRotation
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RAnimUtil.FYawPitch>(Ptr + 96); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 96); }
    }

    /// <summary>
    /// StructProperty: CurrentRightEyeRotation
    /// </summary>
    public unsafe BmSDK.BmGame.RAnimUtil.FYawPitch CurrentRightEyeRotation
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RAnimUtil.FYawPitch>(Ptr + 104); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 104); }
    }

    /// <summary>
    /// BoolProperty: ReduceBlinksAndEyeMovements
    /// </summary>
    public unsafe bool ReduceBlinksAndEyeMovements
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 112) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 112); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 112); }
    }

    /// <summary>
    /// Struct: FBlinkState
    /// </summary>
    [StructLayout(LayoutKind.Explicit)]
    public partial record struct FBlinkState
    {
        /// <summary>
        /// ByteProperty: SequenceState
        /// </summary>
        public unsafe BmSDK.BmGame.RAnimUtil_FaceFXOutput.EBlinkSequenceState SequenceState
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RAnimUtil_FaceFXOutput.EBlinkSequenceState>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// FloatProperty: RegisterValue
        /// </summary>
        public unsafe float RegisterValue
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4); }; }
        }

        /// <summary>
        /// FloatProperty: TimeRemaining
        /// </summary>
        public unsafe float TimeRemaining
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 8); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8); }; }
        }
    }

    /// <summary>
    /// Enum: EBlinkSequenceState
    /// </summary>
    public enum EBlinkSequenceState
    {
        BSS_Init = 0,
        BSS_Disabled = 1,
        BSS_BlockedByAnim = 2,
        BSS_Waiting = 3,
        BSS_PreBlink = 4,
        BSS_PostBlink = 5,
        BSS_MAX = 6,
    }
}
