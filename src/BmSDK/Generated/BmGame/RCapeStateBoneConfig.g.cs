#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RCapeStateBoneConfig<br/>
/// (flags = 0)
/// </summary>
public partial class RCapeStateBoneConfig : BmSDK.GameObject, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RCapeStateBoneConfig", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RCapeStateBoneConfig() { }

    /// <summary>
    /// Constructs a new RCapeStateBoneConfig
    /// </summary>
    public RCapeStateBoneConfig(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RCapeStateBoneConfig Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RCapeStateBoneConfig(nint ptr) : base(ptr) { }

    /// <summary>
    /// ObjectProperty: ParentBoneConfig
    /// </summary>
    public unsafe BmSDK.BmGame.RCapeStateBoneConfig ParentBoneConfig
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RCapeStateBoneConfig>(Ptr + 84); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 84); }
    }

    /// <summary>
    /// ArrayProperty: BoneStates
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RCapeStateBoneConfig.FCapeStateDataIndicator> BoneStates
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RCapeStateBoneConfig.FCapeStateDataIndicator>>(Ptr + 92); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 92); }
    }

    /// <summary>
    /// Struct: FCapeStateDataIndicator
    /// </summary>
    [StructLayout(LayoutKind.Explicit)]
    public partial record struct FCapeStateDataIndicator
    {
        /// <summary>
        /// IntProperty: ChainIndex
        /// </summary>
        public unsafe int ChainIndex
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// IntProperty: BoneIndex
        /// </summary>
        public unsafe int BoneIndex
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4); }; }
        }

        /// <summary>
        /// ArrayProperty: ParentSkinningBoneDatas
        /// </summary>
        public unsafe BmSDK.TArray<BmSDK.BmGame.RCapeStateBoneConfig.FCapeSkinningBoneData> ParentSkinningBoneDatas
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RCapeStateBoneConfig.FCapeSkinningBoneData>>(Ptr + 8); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8); }; }
        }

        /// <summary>
        /// ByteProperty: StateEffectType
        /// </summary>
        public unsafe BmSDK.BmGame.RCapeStateBoneConfig.EStateEffectType StateEffectType
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RCapeStateBoneConfig.EStateEffectType>(Ptr + 24); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 24); }; }
        }

        /// <summary>
        /// ByteProperty: BoneState
        /// </summary>
        public unsafe BmSDK.BmGame.RCapeStateBoneConfig.ECapeBoneState BoneState
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RCapeStateBoneConfig.ECapeBoneState>(Ptr + 25); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 25); }; }
        }

        /// <summary>
        /// BoolProperty: IsCollide
        /// </summary>
        public unsafe bool IsCollide
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 28) & 1) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 28); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 28); }; }
        }

        /// <summary>
        /// BoolProperty: bForceDisableCollisionWithWorld
        /// </summary>
        public unsafe bool bForceDisableCollisionWithWorld
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 28) & 2) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 28); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 28); }; }
        }

        /// <summary>
        /// BoolProperty: IsForceRefPose
        /// </summary>
        public unsafe bool IsForceRefPose
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 28) & 4) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 28); var newMask = value ? (currentMask | 4) : (currentMask & ~4); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 28); }; }
        }

        /// <summary>
        /// BoolProperty: IsIgnoreWindEffects
        /// </summary>
        public unsafe bool IsIgnoreWindEffects
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 28) & 8) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 28); var newMask = value ? (currentMask | 8) : (currentMask & ~8); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 28); }; }
        }

        /// <summary>
        /// FloatProperty: AnimDriveJointLinearComponentStrengthOverride
        /// </summary>
        public unsafe float AnimDriveJointLinearComponentStrengthOverride
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 32); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 32); }; }
        }

        /// <summary>
        /// FloatProperty: AnimDriveJointAngularComponentStrengthOverride
        /// </summary>
        public unsafe float AnimDriveJointAngularComponentStrengthOverride
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 36); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 36); }; }
        }

        /// <summary>
        /// BoolProperty: bPushUsingParentComponentBone
        /// </summary>
        public unsafe bool bPushUsingParentComponentBone
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 40) & 1) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 40); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 40); }; }
        }

        /// <summary>
        /// NameProperty: PushBoneName
        /// </summary>
        public unsafe BmSDK.FName PushBoneName
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 44); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 44); }; }
        }

        /// <summary>
        /// StructProperty: PushTowardsDirection
        /// </summary>
        public unsafe System.Numerics.Vector3 PushTowardsDirection
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 52); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 52); }; }
        }

        /// <summary>
        /// FloatProperty: PushAngle
        /// </summary>
        public unsafe float PushAngle
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 64); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 64); }; }
        }

        /// <summary>
        /// BoolProperty: bPushUsingParentComponentBone2
        /// </summary>
        public unsafe bool bPushUsingParentComponentBone2
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 68) & 1) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 68); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 68); }; }
        }

        /// <summary>
        /// NameProperty: PushBoneName2
        /// </summary>
        public unsafe BmSDK.FName PushBoneName2
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 72); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 72); }; }
        }

        /// <summary>
        /// StructProperty: PushTowardsDirection2
        /// </summary>
        public unsafe System.Numerics.Vector3 PushTowardsDirection2
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 80); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 80); }; }
        }

        /// <summary>
        /// FloatProperty: PushAngle2
        /// </summary>
        public unsafe float PushAngle2
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 92); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 92); }; }
        }
    }

    /// <summary>
    /// Struct: FCapeSkinningBoneData
    /// </summary>
    [StructLayout(LayoutKind.Explicit)]
    public partial record struct FCapeSkinningBoneData
    {
        /// <summary>
        /// NameProperty: SkinningBoneName
        /// </summary>
        public unsafe BmSDK.FName SkinningBoneName
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// FloatProperty: SkinningBoneWeight
        /// </summary>
        public unsafe float SkinningBoneWeight
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 8); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8); }; }
        }

        /// <summary>
        /// ByteProperty: SkinningType
        /// </summary>
        public unsafe BmSDK.BmGame.RCapeStateBoneConfig.ECapeBoneSkinningType SkinningType
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RCapeStateBoneConfig.ECapeBoneSkinningType>(Ptr + 12); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 12); }; }
        }
    }

    /// <summary>
    /// Enum: ECapeBoneSkinningType
    /// </summary>
    public enum ECapeBoneSkinningType
    {
        CAPEBONESKINNINGTYPE_Full = 0,
        CAPEBONESKINNINGTYPE_TranslationOnly = 1,
        CAPEBONESKINNINGTYPE_RotationOnly = 2,
        CAPEBONESKINNINGTYPE_NoRoll = 3,
        CAPEBONESKINNINGTYPE_MAX = 4,
    }

    /// <summary>
    /// Enum: EStateEffectType
    /// </summary>
    public enum EStateEffectType
    {
        STATEEFFECT_SingleBone = 0,
        STATEEFFECT_ChainParents = 1,
        STATEEFFECT_ChainChildren = 2,
        STATEEFFECT_AllBones = 3,
        STATEEFFECT_MAX = 4,
    }

    /// <summary>
    /// Enum: ECapeBoneState
    /// </summary>
    public enum ECapeBoneState
    {
        ECAPEBONESTATE_Animated = 0,
        ECAPEBONESTATE_AnimationDriven = 1,
        ECAPEBONESTATE_Physics = 2,
        ECAPEBONESTATE_Fixed = 3,
        ECAPEBONESTATE_Paused = 4,
        ECAPEBONESTATE_DriveToAnimated = 5,
        ECAPEBONESTATE_MAX = 6,
    }
}
