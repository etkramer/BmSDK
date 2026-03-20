#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Class: AnimNotify<br/>
/// (size = 84)
/// (flags = 0)
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
    /// Constructs a new AnimNotify
    /// </summary>
    public AnimNotify(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, AnimNotify Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected AnimNotify(nint ptr) : base(ptr) { }

    /// <summary>
    /// Function: FindNextNotifyOfClass
    /// </summary>
    public unsafe bool FindNextNotifyOfClass(BmSDK.Engine.AnimNodeSequence AnimSeqInstigator, BmSDK.Class NotifyClass, out BmSDK.Engine.AnimSequence.FAnimNotifyEvent OutEvent)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "Engine.AnimNotify.FindNextNotifyOfClass", true);
        byte* paramsPtr = stackalloc byte[48];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(AnimSeqInstigator, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NotifyClass, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        OutEvent = BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AnimSequence.FAnimNotifyEvent>(paramsPtr + 16);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 28);
    }

    /// <summary>
    /// Enum: ENotifyCategory
    /// </summary>
    public enum ENotifyCategory
    {
        NOTIFYCATEGORY_Misc = 0,
        NOTIFYCATEGORY_IK = 1,
        NOTIFYCATEGORY_Sound = 2,
        NOTIFYCATEGORY_Catwoman = 3,
        NOTIFYCATEGORY_Character = 4,
        NOTIFYCATEGORY_VFX = 5,
        NOTIFYCATEGORY_Animation = 6,
        NOTIFYCATEGORY_Footstep = 7,
        NOTIFYCATEGORY_Cape = 8,
        NOTIFYCATEGORY_Ragdoll = 9,
        NOTIFYCATEGORY_Physics = 10,
        NOTIFYCATEGORY_Destruction = 11,
        NOTIFYCATEGORY_MAX = 12,
    }

    /// <summary>
    /// Enum: ENotifyRenderCategory
    /// </summary>
    public enum ENotifyRenderCategory
    {
        NOTIFYRENDERCATEGORY_Misc = 0,
        NOTIFYRENDERCATEGORY_MotionExtraction = 1,
        NOTIFYRENDERCATEGORY_Transition = 2,
        NOTIFYRENDERCATEGORY_Footsteps = 3,
        NOTIFYRENDERCATEGORY_IK_Left = 4,
        NOTIFYRENDERCATEGORY_IK_Right = 5,
        NOTIFYRENDERCATEGORY_Sound = 6,
        NOTIFYRENDERCATEGORY_Dialogue = 7,
        NOTIFYRENDERCATEGORY_CachedDialogue = 8,
        NOTIFYRENDERCATEGORY_MAX = 9,
    }

    /// <summary>
    /// Struct: FNotifierInfo
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 48)]
    public partial record struct FNotifierInfo
    {
        /// <summary>
        /// ObjectProperty: AnimNotify
        /// </summary>
        public unsafe BmSDK.Engine.AnimNotify AnimNotify
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AnimNotify>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// ObjectProperty: Owner
        /// </summary>
        public unsafe BmSDK.Engine.Actor Owner
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.Actor>(Ptr + 8); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8); }; }
        }

        /// <summary>
        /// ComponentProperty: SkelComponent
        /// </summary>
        public unsafe BmSDK.Engine.SkeletalMeshComponent SkelComponent
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.SkeletalMeshComponent>(Ptr + 16); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 16); }; }
        }

        /// <summary>
        /// ObjectProperty: AnimSequence
        /// </summary>
        public unsafe BmSDK.Engine.AnimSequence AnimSequence
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AnimSequence>(Ptr + 24); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 24); }; }
        }

        /// <summary>
        /// FloatProperty: Time
        /// </summary>
        public unsafe float Time
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 32); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 32); }; }
        }

        /// <summary>
        /// FloatProperty: Weight
        /// </summary>
        public unsafe float Weight
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 36); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 36); }; }
        }

        /// <summary>
        /// FloatProperty: TimeDifference
        /// </summary>
        public unsafe float TimeDifference
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 40); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 40); }; }
        }

        /// <summary>
        /// BoolProperty: AnimMirrored
        /// </summary>
        public unsafe bool AnimMirrored
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 44) & 1) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 44); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 44); }; }
        }

        /// <summary>
        /// BoolProperty: PlayedBackwards
        /// </summary>
        public unsafe bool PlayedBackwards
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 44) & 2) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 44); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 44); }; }
        }

        /// <summary>
        /// BoolProperty: PreNotify
        /// </summary>
        public unsafe bool PreNotify
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 44) & 4) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 44); var newMask = value ? (currentMask | 4) : (currentMask & ~4); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 44); }; }
        }
    }
}
