#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Class: UISoundTheme<br/>
/// (size = 0)
/// (flags = 0)
/// </summary>
public partial class UISoundTheme : BmSDK.GameObject, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Engine.UISoundTheme", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal UISoundTheme() { }

    /// <summary>
    /// Constructs a new UISoundTheme
    /// </summary>
    public UISoundTheme(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, UISoundTheme Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected UISoundTheme(nint ptr) : base(ptr) { }

    /// <summary>
    /// ArrayProperty: SoundEventBindings
    /// </summary>
    public unsafe NEED_UPDATE_ARRAYPROPERTY_LAYOUT SoundEventBindings
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_ARRAYPROPERTY_LAYOUT>(Ptr + 84); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 84); }
    }

    /// <summary>
    /// Struct: FSoundEventMapping
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 0)]
    public partial record struct FSoundEventMapping
    {
        /// <summary>
        /// NameProperty: SoundEventName
        /// </summary>
        public unsafe BmSDK.FName SoundEventName
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// ObjectProperty: SoundToPlay
        /// </summary>
        public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT SoundToPlay
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 8); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8); }; }
        }
    }
}
