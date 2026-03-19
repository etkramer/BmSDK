#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Class: SeqAct_MultiLevelStreaming<br/>
/// (size = 0)
/// (flags = 0)
/// </summary>
public partial class SeqAct_MultiLevelStreaming : BmSDK.Engine.SeqAct_LevelStreamingBase, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Engine.SeqAct_MultiLevelStreaming", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal SeqAct_MultiLevelStreaming() { }

    /// <summary>
    /// Constructs a new SeqAct_MultiLevelStreaming
    /// </summary>
    public SeqAct_MultiLevelStreaming(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, SeqAct_MultiLevelStreaming Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected SeqAct_MultiLevelStreaming(nint ptr) : base(ptr) { }

    /// <summary>
    /// ArrayProperty: Levels
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.FString>>>>>>> Levels
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.FString>>>>>>>>(Ptr + 392); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 392); }
    }

    /// <summary>
    /// BoolProperty: bUnloadAllOtherLevels
    /// </summary>
    public unsafe bool bUnloadAllOtherLevels
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 408) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 408); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 408); }
    }

    /// <summary>
    /// BoolProperty: bApplyToAllAvailableLevels
    /// </summary>
    public unsafe bool bApplyToAllAvailableLevels
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 408) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 408); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 408); }
    }

    /// <summary>
    /// BoolProperty: bRemovedBlockOnLoad
    /// </summary>
    public unsafe bool bRemovedBlockOnLoad
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 408) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 408); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 408); }
    }

    /// <summary>
    /// BoolProperty: bStatusIsOk
    /// </summary>
    public unsafe bool bStatusIsOk
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 408) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 408); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 408); }
    }

    /// <summary>
    /// Struct: FLevelStreamingNameCombo
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 0)]
    public partial record struct FLevelStreamingNameCombo
    {
        /// <summary>
        /// ObjectProperty: Level
        /// </summary>
        public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT Level
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// NameProperty: LevelName
        /// </summary>
        public unsafe BmSDK.FName LevelName
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 8); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8); }; }
        }
    }
}
