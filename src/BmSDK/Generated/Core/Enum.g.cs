#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK;

/// <summary>
/// Class: Enum<br/>
/// (size = 0)
/// (flags = 0)
/// </summary>
public partial class Enum : BmSDK.Field, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Core.Enum", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal Enum() { }

    /// <summary>
    /// Constructs a new Enum
    /// </summary>
    public Enum(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, Enum Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected Enum(nint ptr) : base(ptr) { }

    /// <summary>
    /// StructProperty: VfTableObject
    /// </summary>
    public unsafe System.IntPtr VfTableObject
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.IntPtr>(Ptr + 0); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }
    }

    /// <summary>
    /// IntProperty: ObjectFlags
    /// </summary>
    public unsafe BmSDK.GameObject.EObjectFlags ObjectFlags
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.GameObject.EObjectFlags>(Ptr + 8); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8); }
    }

    /// <summary>
    /// IntProperty: EditorObjectFlags
    /// </summary>
    public unsafe int EditorObjectFlags
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 12); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 12); }
    }

    /// <summary>
    /// IntProperty: HashIndexPrev
    /// </summary>
    public unsafe int HashIndexPrev
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 16); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 16); }
    }

    /// <summary>
    /// IntProperty: HashIndexNext
    /// </summary>
    public unsafe int HashIndexNext
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 20); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 20); }
    }

    /// <summary>
    /// IntProperty: HashOuterIndexPrev
    /// </summary>
    public unsafe int HashOuterIndexPrev
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 24); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 24); }
    }

    /// <summary>
    /// IntProperty: HashOuterIndexNext
    /// </summary>
    public unsafe int HashOuterIndexNext
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 28); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 28); }
    }

    /// <summary>
    /// ObjectProperty: Linker
    /// </summary>
    public unsafe BmSDK.GameObject Linker
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.GameObject>(Ptr + 32); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 32); }
    }

    /// <summary>
    /// StructProperty: LinkerIndex
    /// </summary>
    public unsafe System.IntPtr LinkerIndex
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.IntPtr>(Ptr + 40); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 40); }
    }

    /// <summary>
    /// IntProperty: ObjectInternalInteger
    /// </summary>
    public unsafe int ObjectInternalInteger
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 48); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 48); }
    }

    /// <summary>
    /// ObjectProperty: Outer
    /// </summary>
    public unsafe BmSDK.GameObject Outer
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.GameObject>(Ptr + 52); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 52); }
    }

    /// <summary>
    /// NameProperty: Name
    /// </summary>
    public unsafe BmSDK.FName Name
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 60); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 60); }
    }

    /// <summary>
    /// ClassProperty: Class
    /// </summary>
    public unsafe BmSDK.Class Class
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Class>(Ptr + 68); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 68); }
    }

    /// <summary>
    /// ObjectProperty: ObjectArchetype
    /// </summary>
    public unsafe BmSDK.GameObject ObjectArchetype
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.GameObject>(Ptr + 76); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 76); }
    }

    /// <summary>
    /// Struct: FQWord
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 0)]
    public partial record struct FQWord
    {
        /// <summary>
        /// IntProperty: A
        /// </summary>
        public unsafe int A
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// IntProperty: B
        /// </summary>
        public unsafe int B
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4); }; }
        }
    }

    /// <summary>
    /// Struct: FPointer
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 0)]
    public partial record struct FPointer
    {
        /// <summary>
        /// IntProperty: Dummy
        /// </summary>
        public unsafe int Dummy
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }
    }
}
