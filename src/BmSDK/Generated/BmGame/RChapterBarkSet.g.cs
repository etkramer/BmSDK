#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RChapterBarkSet<br/>
/// (size = 56)
/// (flags = 134230162)
/// </summary>
public partial class RChapterBarkSet : BmSDK.GameObject, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RChapterBarkSet", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RChapterBarkSet() { }

    /// <summary>
    /// Constructs a new RChapterBarkSet
    /// </summary>
    public RChapterBarkSet(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RChapterBarkSet Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RChapterBarkSet(nint ptr) : base(ptr) { }

    /// <summary>
    /// ArrayProperty: ChapterBarks
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RChapterBarkSet.FChapterBarkDefinition> ChapterBarks
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RChapterBarkSet.FChapterBarkDefinition>>(Ptr + 44); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 44); }
    }

    /// <summary>
    /// Struct: FChapterBarkDefinition
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 16)]
    public partial record struct FChapterBarkDefinition
    {
        /// <summary>
        /// FloatProperty: Weight
        /// </summary>
        public unsafe float Weight
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// ObjectProperty: ChapterDialogueLine
        /// </summary>
        public unsafe BmSDK.Engine.RDialogueLine ChapterDialogueLine
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RDialogueLine>(Ptr + 4); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4); }; }
        }

        /// <summary>
        /// FloatProperty: UseWeight
        /// </summary>
        public unsafe float UseWeight
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 8); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8); }; }
        }

        /// <summary>
        /// BoolProperty: Used
        /// </summary>
        public unsafe bool Used
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 12) & 1) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 12); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 12); }; }
        }
    }
}
