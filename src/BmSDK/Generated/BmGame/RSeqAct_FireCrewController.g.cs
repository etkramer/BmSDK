#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RSeqAct_FireCrewController<br/>
/// (flags = 0)
/// </summary>
public partial class RSeqAct_FireCrewController : BmSDK.Engine.SequenceAction, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RSeqAct_FireCrewController", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RSeqAct_FireCrewController() { }

    /// <summary>
    /// Constructs a new RSeqAct_FireCrewController
    /// </summary>
    public RSeqAct_FireCrewController(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RSeqAct_FireCrewController Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RSeqAct_FireCrewController(nint ptr) : base(ptr) { }

    /// <summary>
    /// StructProperty: allTiers
    /// </summary>
    public unsafe BmSDK.BmGame.RSeqAct_FireCrewController.FsingleTier allTiers_0
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSeqAct_FireCrewController.FsingleTier>(Ptr + 352); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 352); }
    }
    /// <summary>
    /// StructProperty: allTiers
    /// </summary>
    public unsafe BmSDK.BmGame.RSeqAct_FireCrewController.FsingleTier allTiers_1
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSeqAct_FireCrewController.FsingleTier>(Ptr + 368); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 368); }
    }

    /// <summary>
    /// StrProperty: flagSuffixes
    /// </summary>
    public unsafe BmSDK.FString flagSuffixes_0
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 384); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 384); }
    }
    /// <summary>
    /// StrProperty: flagSuffixes
    /// </summary>
    public unsafe BmSDK.FString flagSuffixes_1
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 400); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 400); }
    }
    /// <summary>
    /// StrProperty: flagSuffixes
    /// </summary>
    public unsafe BmSDK.FString flagSuffixes_2
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 416); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 416); }
    }
    /// <summary>
    /// StrProperty: flagSuffixes
    /// </summary>
    public unsafe BmSDK.FString flagSuffixes_3
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 432); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 432); }
    }
    /// <summary>
    /// StrProperty: flagSuffixes
    /// </summary>
    public unsafe BmSDK.FString flagSuffixes_4
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 448); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 448); }
    }

    /// <summary>
    /// StrProperty: tierCompletedFlag
    /// </summary>
    public unsafe BmSDK.FString tierCompletedFlag
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 464); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 464); }
    }

    /// <summary>
    /// BoolProperty: bSetupTierStruct
    /// </summary>
    public unsafe bool bSetupTierStruct
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 480) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 480); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 480); }
    }

    /// <summary>
    /// IntProperty: encounterIndex
    /// </summary>
    public unsafe int encounterIndex
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 484); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 484); }
    }

    /// <summary>
    /// IntProperty: numRescued
    /// </summary>
    public unsafe int numRescued
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 488); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 488); }
    }

    /// <summary>
    /// Struct: FsingleTier
    /// </summary>
    [StructLayout(LayoutKind.Explicit)]
    public partial record struct FsingleTier
    {
        /// <summary>
        /// ArrayProperty: members
        /// </summary>
        public unsafe BmSDK.TArray<int> members
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<int>>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }
    }

}
