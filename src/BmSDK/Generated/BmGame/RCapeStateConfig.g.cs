#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RCapeStateConfig<br/>
/// (size = 216)
/// (flags = 134217874)
/// </summary>
public partial class RCapeStateConfig : BmSDK.GameObject, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RCapeStateConfig", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    /// <summary>
    /// Gets the class default object as RCapeStateConfig.
    /// </summary>
    public static RCapeStateConfig DefaultObject => (RCapeStateConfig)StaticClass().DefaultObject;

    internal RCapeStateConfig() { }

    /// <summary>
    /// Constructs a new RCapeStateConfig
    /// </summary>
    public RCapeStateConfig(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RCapeStateConfig Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RCapeStateConfig(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RCapeStateConfig>
        => ((GameObject)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RCapeStateConfig>, new()
        => (TComponent)((GameObject)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RCapeStateConfig>
        => ((GameObject)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RCapeStateConfig>
        => ((GameObject)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RCapeStateConfig>
        => (TComponent)((GameObject)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponents(Type)"/>
    public System.Collections.Generic.IReadOnlyList<TComponent> GetScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RCapeStateConfig>
        => ((GameObject)this).GetScriptComponents(typeof(TComponent)).Cast<TComponent>().ToList();

    /// <inheritdoc cref="GameObject.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RCapeStateConfig>
        => ((GameObject)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.DetachScriptComponents(Type)"/>
    public void DetachScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RCapeStateConfig>
        => ((GameObject)this).DetachScriptComponents(typeof(TComponent));

    /// <summary>
    /// NameProperty: CapeStateName
    /// </summary>
    public unsafe BmSDK.FName CapeStateName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 44); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 44); }
    }

    /// <summary>
    /// NameProperty: AnimStateName
    /// </summary>
    public unsafe BmSDK.FName AnimStateName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 52); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 52); }
    }

    /// <summary>
    /// NameProperty: AnimName
    /// </summary>
    public unsafe BmSDK.FName AnimName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 60); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 60); }
    }

    /// <summary>
    /// BoolProperty: IsMirrorAnim
    /// </summary>
    public unsafe bool IsMirrorAnim
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 68) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 68); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 68); }
    }

    /// <summary>
    /// BoolProperty: IsBlendInAnim
    /// </summary>
    public unsafe bool IsBlendInAnim
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 68) & 2) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 68); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 68); }
    }

    /// <summary>
    /// BoolProperty: bBlendInPose
    /// </summary>
    public unsafe bool bBlendInPose
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 68) & 4) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 68); var newMask = value ? (currentMask | 4) : (currentMask & ~4); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 68); }
    }

    /// <summary>
    /// BoolProperty: IsDisableSupportConstraints
    /// </summary>
    public unsafe bool IsDisableSupportConstraints
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 68) & 8) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 68); var newMask = value ? (currentMask | 8) : (currentMask & ~8); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 68); }
    }

    /// <summary>
    /// BoolProperty: IsAllowCollisionShapeCollisionWithAllBones
    /// </summary>
    public unsafe bool IsAllowCollisionShapeCollisionWithAllBones
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 68) & 16) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 68); var newMask = value ? (currentMask | 16) : (currentMask & ~16); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 68); }
    }

    /// <summary>
    /// BoolProperty: bEnableSupportSprings
    /// </summary>
    public unsafe bool bEnableSupportSprings
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 68) & 32) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 68); var newMask = value ? (currentMask | 32) : (currentMask & ~32); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 68); }
    }

    /// <summary>
    /// BoolProperty: DisableWorldCollision
    /// </summary>
    public unsafe bool DisableWorldCollision
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 68) & 64) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 68); var newMask = value ? (currentMask | 64) : (currentMask & ~64); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 68); }
    }

    /// <summary>
    /// BoolProperty: IsApplyRotationBackForces
    /// </summary>
    public unsafe bool IsApplyRotationBackForces
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 68) & 128) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 68); var newMask = value ? (currentMask | 128) : (currentMask & ~128); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 68); }
    }

    /// <summary>
    /// BoolProperty: bBlendToDesiredSpringWeight
    /// </summary>
    public unsafe bool bBlendToDesiredSpringWeight
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 68) & 256) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 68); var newMask = value ? (currentMask | 256) : (currentMask & ~256); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 68); }
    }

    /// <summary>
    /// BoolProperty: IsEnableRunEffect
    /// </summary>
    public unsafe bool IsEnableRunEffect
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 68) & 512) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 68); var newMask = value ? (currentMask | 512) : (currentMask & ~512); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 68); }
    }

    /// <summary>
    /// BoolProperty: bSyncParentAnimMirroredness
    /// </summary>
    public unsafe bool bSyncParentAnimMirroredness
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 68) & 1024) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 68); var newMask = value ? (currentMask | 1024) : (currentMask & ~1024); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 68); }
    }

    /// <summary>
    /// BoolProperty: OnlyTakeParentTranslationAtAttachPos
    /// </summary>
    public unsafe bool OnlyTakeParentTranslationAtAttachPos
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 68) & 2048) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 68); var newMask = value ? (currentMask | 2048) : (currentMask & ~2048); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 68); }
    }

    /// <summary>
    /// BoolProperty: DisableHeadDepthBias
    /// </summary>
    public unsafe bool DisableHeadDepthBias
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 68) & 4096) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 68); var newMask = value ? (currentMask | 4096) : (currentMask & ~4096); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 68); }
    }

    /// <summary>
    /// BoolProperty: bDebugDisableState
    /// </summary>
    public unsafe bool bDebugDisableState
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 68) & 8192) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 68); var newMask = value ? (currentMask | 8192) : (currentMask & ~8192); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 68); }
    }

    /// <summary>
    /// FloatProperty: AnimBlendInDuration
    /// </summary>
    public unsafe float AnimBlendInDuration
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 72); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 72); }
    }

    /// <summary>
    /// FloatProperty: PoseBlendDuration
    /// </summary>
    public unsafe float PoseBlendDuration
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 76); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 76); }
    }

    /// <summary>
    /// ByteProperty: AutoForwardType
    /// </summary>
    public unsafe BmSDK.BmGame.RCapeStateConfig.EAutoForwardType AutoForwardType
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RCapeStateConfig.EAutoForwardType>(Ptr + 80); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 80); }
    }

    /// <summary>
    /// ByteProperty: StateOvertretchHandlingMethod
    /// </summary>
    public unsafe BmSDK.BmGame.RCapeStateConfig.OverstretchHandlingMethod StateOvertretchHandlingMethod
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RCapeStateConfig.OverstretchHandlingMethod>(Ptr + 81); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 81); }
    }

    /// <summary>
    /// FloatProperty: AutoForwardTimer
    /// </summary>
    public unsafe float AutoForwardTimer
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 84); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 84); }
    }

    /// <summary>
    /// NameProperty: AutoForwardToCapeStateName
    /// </summary>
    public unsafe BmSDK.FName AutoForwardToCapeStateName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 88); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 88); }
    }

    /// <summary>
    /// ObjectProperty: CapeCollisionConfig
    /// </summary>
    public unsafe BmSDK.BmGame.RCapeCollisionConfig CapeCollisionConfig
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RCapeCollisionConfig>(Ptr + 96); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 96); }
    }

    /// <summary>
    /// ObjectProperty: CapeBoneConfig
    /// </summary>
    public unsafe BmSDK.BmGame.RCapeStateBoneConfig CapeBoneConfig
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RCapeStateBoneConfig>(Ptr + 100); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 100); }
    }

    /// <summary>
    /// ArrayProperty: CapeMaterialSettings
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RCapeStateConfig.FCapeMaterialPropertySetting> CapeMaterialSettings
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RCapeStateConfig.FCapeMaterialPropertySetting>>(Ptr + 104); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 104); }
    }

    /// <summary>
    /// FloatProperty: AnimDriveJointLinearComponentForceLimit
    /// </summary>
    public unsafe float AnimDriveJointLinearComponentForceLimit
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 116); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 116); }
    }

    /// <summary>
    /// FloatProperty: AnimDriveJointLinearComponentStrength
    /// </summary>
    public unsafe float AnimDriveJointLinearComponentStrength
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 120); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 120); }
    }

    /// <summary>
    /// FloatProperty: AnimDriveJointLinearComponentDamping
    /// </summary>
    public unsafe float AnimDriveJointLinearComponentDamping
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 124); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 124); }
    }

    /// <summary>
    /// FloatProperty: AnimDriveJointAngularComponentForceLimit
    /// </summary>
    public unsafe float AnimDriveJointAngularComponentForceLimit
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 128); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 128); }
    }

    /// <summary>
    /// FloatProperty: AnimDriveJointAngularComponentStrength
    /// </summary>
    public unsafe float AnimDriveJointAngularComponentStrength
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 132); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 132); }
    }

    /// <summary>
    /// FloatProperty: AnimDriveJointAngularComponentDamping
    /// </summary>
    public unsafe float AnimDriveJointAngularComponentDamping
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 136); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 136); }
    }

    /// <summary>
    /// FloatProperty: DriveToAnimatedTolerance
    /// </summary>
    public unsafe float DriveToAnimatedTolerance
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 140); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 140); }
    }

    /// <summary>
    /// FloatProperty: MinApplyRotVel
    /// </summary>
    public unsafe float MinApplyRotVel
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 144); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 144); }
    }

    /// <summary>
    /// FloatProperty: ForceStrengthMultiplier
    /// </summary>
    public unsafe float ForceStrengthMultiplier
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 148); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 148); }
    }

    /// <summary>
    /// FloatProperty: MaxForceCap
    /// </summary>
    public unsafe float MaxForceCap
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 152); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 152); }
    }

    /// <summary>
    /// FloatProperty: ChainPosStrengthMultiplierMin
    /// </summary>
    public unsafe float ChainPosStrengthMultiplierMin
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 156); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 156); }
    }

    /// <summary>
    /// FloatProperty: ChainPosStrengthMultiplierChangeOverLength
    /// </summary>
    public unsafe float ChainPosStrengthMultiplierChangeOverLength
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 160); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 160); }
    }

    /// <summary>
    /// FloatProperty: OverstretchHandlingDistanceOverride
    /// </summary>
    public unsafe float OverstretchHandlingDistanceOverride
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 164); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 164); }
    }

    /// <summary>
    /// FloatProperty: SpringWeightBlendSpeed
    /// </summary>
    public unsafe float SpringWeightBlendSpeed
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 168); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 168); }
    }

    /// <summary>
    /// FloatProperty: RunEffectStartLength
    /// </summary>
    public unsafe float RunEffectStartLength
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 172); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 172); }
    }

    /// <summary>
    /// FloatProperty: RunEffectStartForceStrengthMultiplier
    /// </summary>
    public unsafe float RunEffectStartForceStrengthMultiplier
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 176); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 176); }
    }

    /// <summary>
    /// FloatProperty: RunEffectForceStrengthMultiplierIncreaseRate
    /// </summary>
    public unsafe float RunEffectForceStrengthMultiplierIncreaseRate
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 180); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 180); }
    }

    /// <summary>
    /// NameProperty: ParentTimeSyncAnim
    /// </summary>
    public unsafe BmSDK.FName ParentTimeSyncAnim
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 184); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 184); }
    }

    /// <summary>
    /// FloatProperty: ParentTimeSyncOffset
    /// </summary>
    public unsafe float ParentTimeSyncOffset
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 192); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 192); }
    }

    /// <summary>
    /// FloatProperty: DepthBiasMagnitudeClamp
    /// </summary>
    public unsafe float DepthBiasMagnitudeClamp
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 196); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 196); }
    }

    /// <summary>
    /// FloatProperty: DepthBiasMagnitudeClampCentrePos
    /// </summary>
    public unsafe float DepthBiasMagnitudeClampCentrePos
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 200); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 200); }
    }

    /// <summary>
    /// FloatProperty: ForwardDepthBiasOverride
    /// </summary>
    public unsafe float ForwardDepthBiasOverride
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 204); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 204); }
    }

    /// <summary>
    /// FloatProperty: BackwardDepthBiasOverride
    /// </summary>
    public unsafe float BackwardDepthBiasOverride
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 208); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 208); }
    }

    /// <summary>
    /// ObjectProperty: MaterialOverride
    /// </summary>
    public unsafe BmSDK.Engine.MaterialInterface MaterialOverride
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.MaterialInterface>(Ptr + 212); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 212); }
    }

    /// <summary>
    /// Enum: OverstretchHandlingMethod
    /// </summary>
    public enum OverstretchHandlingMethod
    {
        OVERSTRETCHHANDLINGMETHOD_Default = 0,
        OVERSTRETCHHANDLINGMETHOD_Simple = 1,
        OVERSTRETCHHANDLINGMETHOD_None = 2,
        OVERSTRETCHHANDLINGMETHOD_MAX = 3,
    }

    /// <summary>
    /// Struct: FCapeMaterialPropertySetting
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 16)]
    public partial record struct FCapeMaterialPropertySetting
    {
        /// <summary>
        /// NameProperty: MaterialConstantName
        /// </summary>
        public unsafe BmSDK.FName MaterialConstantName
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// FloatProperty: MaterialConstantValue
        /// </summary>
        public unsafe float MaterialConstantValue
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 8); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8); }; }
        }

        /// <summary>
        /// FloatProperty: MaterialConstantMaxChangePerSecond
        /// </summary>
        public unsafe float MaterialConstantMaxChangePerSecond
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 12); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 12); }; }
        }
    }

    /// <summary>
    /// Enum: EAutoForwardType
    /// </summary>
    public enum EAutoForwardType
    {
        AUTOFORWARDTYPE_None = 0,
        AUTOFORWARDTYPE_AtEndOfAnim = 1,
        AUTOFORWARDTYPE_Timer = 2,
        AUTOFORWARDTYPE_MAX = 3,
    }
}
