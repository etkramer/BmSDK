#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RSeqAct_IntThresholdChecker<br/>
/// (flags = 0)
/// </summary>
public partial class RSeqAct_IntThresholdChecker : BmSDK.Engine.SequenceAction, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RSeqAct_IntThresholdChecker", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RSeqAct_IntThresholdChecker() { }

    /// <summary>
    /// Constructs a new RSeqAct_IntThresholdChecker
    /// </summary>
    public RSeqAct_IntThresholdChecker(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RSeqAct_IntThresholdChecker Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RSeqAct_IntThresholdChecker(nint ptr) : base(ptr) { }

    /// <summary>
    /// ArrayProperty: Thresholds
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RSeqAct_IntThresholdChecker.FIntThreshold> Thresholds
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RSeqAct_IntThresholdChecker.FIntThreshold>>(Ptr + 352); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 352); }
    }

    /// <summary>
    /// IntProperty: CheckInt
    /// </summary>
    public unsafe int CheckInt
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 368); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 368); }
    }

    /// <summary>
    /// Struct: FIntThreshold
    /// </summary>
    [StructLayout(LayoutKind.Explicit)]
    public partial record struct FIntThreshold
    {
        /// <summary>
        /// IntProperty: aMin
        /// </summary>
        public unsafe int aMin
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// IntProperty: bMax
        /// </summary>
        public unsafe int bMax
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4); }; }
        }
    }
}
