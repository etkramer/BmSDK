#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Class: SeqCond_SwitchObject<br/>
/// (flags = 0)
/// </summary>
public partial class SeqCond_SwitchObject : BmSDK.Engine.SeqCond_SwitchBase, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Engine.SeqCond_SwitchObject", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal SeqCond_SwitchObject() { }

    /// <summary>
    /// Constructs a new SeqCond_SwitchObject
    /// </summary>
    public SeqCond_SwitchObject(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, SeqCond_SwitchObject Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected SeqCond_SwitchObject(nint ptr) : base(ptr) { }

    /// <summary>
    /// ArrayProperty: SupportedValues
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.Engine.SeqCond_SwitchObject.FSwitchObjectCase> SupportedValues
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.SeqCond_SwitchObject.FSwitchObjectCase>>(Ptr + 324); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 324); }
    }

    /// <summary>
    /// Struct: FSwitchObjectCase
    /// </summary>
    [StructLayout(LayoutKind.Explicit)]
    public partial record struct FSwitchObjectCase
    {
        /// <summary>
        /// ObjectProperty: ObjectValue
        /// </summary>
        public unsafe BmSDK.GameObject ObjectValue
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.GameObject>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// BoolProperty: bFallThru
        /// </summary>
        public unsafe bool bFallThru
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8) & 1) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 8); }; }
        }

        /// <summary>
        /// BoolProperty: bDefaultValue
        /// </summary>
        public unsafe bool bDefaultValue
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8) & 2) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 8); }; }
        }
    }
}
