#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// ABSTRACT Class: RAnimUtil_Layers<br/>
/// (size = 44)
/// (flags = 134217875)
/// </summary>
public partial class RAnimUtil_Layers : BmSDK.GameObject, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RAnimUtil_Layers", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RAnimUtil_Layers() { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RAnimUtil_Layers(nint ptr) : base(ptr) { }

    /// <summary>
    /// Struct: FFallLandLayer
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 12)]
    public partial record struct FFallLandLayer
    {
        /// <summary>
        /// StructProperty: FallTime
        /// </summary>
        public unsafe BmSDK.BmGame.RAnimUtil.FNormalizedTimeSpan FallTime
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RAnimUtil.FNormalizedTimeSpan>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }
    }
}
