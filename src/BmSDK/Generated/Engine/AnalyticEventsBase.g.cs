#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Class: AnalyticEventsBase<br/>
/// (size = 0)
/// (flags = 0)
/// </summary>
public partial class AnalyticEventsBase : BmSDK.Engine.PlatformInterfaceBase, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Engine.AnalyticEventsBase", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal AnalyticEventsBase() { }

    /// <summary>
    /// Constructs a new AnalyticEventsBase
    /// </summary>
    public AnalyticEventsBase(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, AnalyticEventsBase Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected AnalyticEventsBase(nint ptr) : base(ptr) { }

    /// <summary>
    /// BoolProperty: bSessionInProgress
    /// </summary>
    public unsafe bool bSessionInProgress
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 116) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 116); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 116); }
    }

    /// <summary>
    /// Struct: FEventStringParam
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 0)]
    public partial record struct FEventStringParam
    {
        /// <summary>
        /// StrProperty: ParamName
        /// </summary>
        public unsafe BmSDK.FString ParamName
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// StrProperty: ParamValue
        /// </summary>
        public unsafe BmSDK.FString ParamValue
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 16); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 16); }; }
        }
    }
}
