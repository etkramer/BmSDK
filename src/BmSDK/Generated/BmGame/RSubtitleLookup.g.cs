#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RSubtitleLookup<br/>
/// (size = 0)
/// (flags = 0)
/// </summary>
public partial class RSubtitleLookup : BmSDK.GameObject, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RSubtitleLookup", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RSubtitleLookup() { }

    /// <summary>
    /// Constructs a new RSubtitleLookup
    /// </summary>
    public RSubtitleLookup(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RSubtitleLookup Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RSubtitleLookup(nint ptr) : base(ptr) { }

    /// <summary>
    /// ArrayProperty: Subtitles
    /// </summary>
    public unsafe NEED_UPDATE_ARRAYPROPERTY_LAYOUT Subtitles
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_ARRAYPROPERTY_LAYOUT>(Ptr + 84); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 84); }
    }

    /// <summary>
    /// Struct: FRSubtitleLookupEntry
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 0)]
    public partial record struct FRSubtitleLookupEntry
    {
        /// <summary>
        /// IntProperty: SubtitleHash
        /// </summary>
        public unsafe int SubtitleHash
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// ObjectProperty: Subtitle
        /// </summary>
        public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT Subtitle
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 4); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4); }; }
        }
    }
}
