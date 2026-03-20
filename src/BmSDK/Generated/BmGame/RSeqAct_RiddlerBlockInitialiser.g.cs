#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RSeqAct_RiddlerBlockInitialiser<br/>
/// (size = 376)
/// (flags = 134226066)
/// </summary>
public partial class RSeqAct_RiddlerBlockInitialiser : BmSDK.Engine.SequenceAction, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RSeqAct_RiddlerBlockInitialiser", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RSeqAct_RiddlerBlockInitialiser() { }

    /// <summary>
    /// Constructs a new RSeqAct_RiddlerBlockInitialiser
    /// </summary>
    public RSeqAct_RiddlerBlockInitialiser(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RSeqAct_RiddlerBlockInitialiser Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RSeqAct_RiddlerBlockInitialiser(nint ptr) : base(ptr) { }

    /// <summary>
    /// Function: Activated
    /// </summary>
    public unsafe override void Activated()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RSeqAct_RiddlerBlockInitialiser.Activated", true);
        byte* paramsPtr = stackalloc byte[20];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// ArrayProperty: Blocks
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RSeqAct_RiddlerBlockInitialiser.FBlockSettings> Blocks
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RSeqAct_RiddlerBlockInitialiser.FBlockSettings>>(Ptr + 352); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 352); }
    }

    /// <summary>
    /// BoolProperty: bIsSetter
    /// </summary>
    public unsafe bool bIsSetter
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 368) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 368); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 368); }
    }

    /// <summary>
    /// BoolProperty: StartState
    /// </summary>
    public unsafe bool StartState
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 368) & 2) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 368); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 368); }
    }

    /// <summary>
    /// IntProperty: Col
    /// </summary>
    public unsafe int Col
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 372); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 372); }
    }

    /// <summary>
    /// Struct: FBlockSettings
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 8)]
    public partial record struct FBlockSettings
    {
        /// <summary>
        /// ByteProperty: Col
        /// </summary>
        public unsafe BmSDK.BmGame.RSeqAct_RiddlerBlockInitialiser.RiddlerBlockColour Col
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSeqAct_RiddlerBlockInitialiser.RiddlerBlockColour>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// ByteProperty: StartState
        /// </summary>
        public unsafe BmSDK.BmGame.RSeqAct_RiddlerBlockInitialiser.RiddlerBlockStartState StartState
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSeqAct_RiddlerBlockInitialiser.RiddlerBlockStartState>(Ptr + 1); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1); }; }
        }

        /// <summary>
        /// IntProperty: Padding
        /// </summary>
        public unsafe int Padding
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4); }; }
        }
    }

    /// <summary>
    /// Enum: RiddlerBlockStartState
    /// </summary>
    public enum RiddlerBlockStartState
    {
        RBSS_In = 0,
        RBSS_Out = 1,
        RBSS_MAX = 2,
    }

    /// <summary>
    /// Enum: RiddlerBlockColour
    /// </summary>
    public enum RiddlerBlockColour
    {
        RBC_Gray = 0,
        RBC_White = 1,
        RBC_Red = 2,
        RBC_MAX = 3,
    }
}
