#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RBarkPillarLookup<br/>
/// (flags = 0)
/// </summary>
public partial class RBarkPillarLookup : BmSDK.Engine.AkHash, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RBarkPillarLookup", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RBarkPillarLookup() { }

    /// <summary>
    /// Constructs a new RBarkPillarLookup
    /// </summary>
    public RBarkPillarLookup(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RBarkPillarLookup Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RBarkPillarLookup(nint ptr) : base(ptr) { }

    /// <summary>
    /// ArrayProperty: PillarList
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RBarkPillarLookup.FRuntimePillar> PillarList
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RBarkPillarLookup.FRuntimePillar>>(Ptr + 92); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 92); }
    }

    /// <summary>
    /// ArrayProperty: PillarBarks
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RBarkPillarLookup.FPillarBarkInfo> PillarBarks
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RBarkPillarLookup.FPillarBarkInfo>>(Ptr + 108); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 108); }
    }

    /// <summary>
    /// StrProperty: CurrentChapterString
    /// </summary>
    public unsafe BmSDK.FString CurrentChapterString
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 124); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 124); }
    }

    /// <summary>
    /// IntProperty: CurrentDialogueChapter
    /// </summary>
    public unsafe int CurrentDialogueChapter
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 140); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 140); }
    }

    /// <summary>
    /// Struct: FRuntimePillar
    /// </summary>
    [StructLayout(LayoutKind.Explicit)]
    public partial record struct FRuntimePillar
    {
        /// <summary>
        /// ByteProperty: Type
        /// </summary>
        public unsafe BmSDK.BmGame.RBarkValDef.FlagTypeEnum Type
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RBarkValDef.FlagTypeEnum>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// ArrayProperty: ValList
        /// </summary>
        public unsafe BmSDK.TArray<BmSDK.BmGame.RBarkPillarLookup.FFlagValAndFileName> ValList
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RBarkPillarLookup.FFlagValAndFileName>>(Ptr + 4); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4); }; }
        }
    }

    /// <summary>
    /// Struct: FFlagValAndFileName
    /// </summary>
    [StructLayout(LayoutKind.Explicit)]
    public partial record struct FFlagValAndFileName
    {
        /// <summary>
        /// NameProperty: FlagVal
        /// </summary>
        public unsafe BmSDK.FName FlagVal
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// StrProperty: Filename
        /// </summary>
        public unsafe BmSDK.FString Filename
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 8); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8); }; }
        }
    }
}
