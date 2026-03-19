#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Class: RAnimSet_Skeleton<br/>
/// (size = 0)
/// (flags = 0)
/// </summary>
public partial class RAnimSet_Skeleton : BmSDK.GameObject, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Engine.RAnimSet_Skeleton", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RAnimSet_Skeleton() { }

    /// <summary>
    /// Constructs a new RAnimSet_Skeleton
    /// </summary>
    public RAnimSet_Skeleton(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RAnimSet_Skeleton Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RAnimSet_Skeleton(nint ptr) : base(ptr) { }

    /// <summary>
    /// BoolProperty: RequiresMaxSolvers
    /// </summary>
    public unsafe bool RequiresMaxSolvers
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 84) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 84); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 84); }
    }

    /// <summary>
    /// ArrayProperty: RefSkeleton
    /// </summary>
    public unsafe BmSDK.TArray<NEED_UPDATE_STRUCTPROPERTY_LAYOUT> RefSkeleton
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>>(Ptr + 88); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 88); }
    }

    /// <summary>
    /// StructProperty: NormalizedBoneMasses
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT NormalizedBoneMasses
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 104); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 104); }
    }

    /// <summary>
    /// Struct: FAnimSetRefSkeletonBone
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 0)]
    public partial record struct FAnimSetRefSkeletonBone
    {
        /// <summary>
        /// NameProperty: Name
        /// </summary>
        public unsafe BmSDK.FName Name
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// IntProperty: ParentIndex
        /// </summary>
        public unsafe int ParentIndex
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8); }; }
        }

        /// <summary>
        /// StructProperty: ParentspaceReferencePose
        /// </summary>
        public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT ParentspaceReferencePose
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 16); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 16); }; }
        }
    }
}
