#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// ABSTRACT Class: AnimNotify<br/>
/// (size = 44)
/// (flags = 134230163)
/// </summary>
public partial class AnimNotify : BmSDK.GameObject, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Engine.AnimNotify", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal AnimNotify() { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected AnimNotify(nint ptr) : base(ptr) { }

    /// <summary>
    /// Enum: ENotifyCategory
    /// </summary>
    public enum ENotifyCategory
    {
        NOTIFYCATEGORY_Misc = 0,
        NOTIFYCATEGORY_Footsteps = 1,
        NOTIFYCATEGORY_IK_Left = 2,
        NOTIFYCATEGORY_IK_Right = 3,
        NOTIFYCATEGORY_Sound = 4,
        NOTIFYCATEGORY_MAX = 5,
    }

    /// <summary>
    /// Struct: FNotifierInfo
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 12)]
    public partial record struct FNotifierInfo
    {
        /// <summary>
        /// ComponentProperty: SkelComponent
        /// </summary>
        public unsafe BmSDK.Engine.SkeletalMeshComponent SkelComponent
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.SkeletalMeshComponent>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// BoolProperty: AnimMirrored
        /// </summary>
        public unsafe bool AnimMirrored
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4) & 1) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 4); }; }
        }

        /// <summary>
        /// ObjectProperty: AnimSequence
        /// </summary>
        public unsafe BmSDK.Engine.AnimSequence AnimSequence
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AnimSequence>(Ptr + 8); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8); }; }
        }
    }
}
