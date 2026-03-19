#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RCapeComponent<br/>
/// (size = 0)
/// (flags = 0)
/// </summary>
public partial class RCapeComponent : BmSDK.Engine.MeshComponent, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RCapeComponent", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RCapeComponent() { }

    /// <summary>
    /// Constructs a new RCapeComponent
    /// </summary>
    public RCapeComponent(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RCapeComponent Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RCapeComponent(nint ptr) : base(ptr) { }

    /// <summary>
    /// StructProperty: VfTable_IRAsyncPhysXSceneInterface
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT VfTable_IRAsyncPhysXSceneInterface
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 640); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 640); }
    }

    /// <summary>
    /// IntProperty: RequiredCapeDataVersionNumber
    /// </summary>
    public unsafe int RequiredCapeDataVersionNumber
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 648); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 648); }
    }

    /// <summary>
    /// ObjectProperty: CapeConfig
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT CapeConfig
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 652); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 652); }
    }

    /// <summary>
    /// ObjectProperty: CapeAnimNode
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT CapeAnimNode
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 660); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 660); }
    }

    /// <summary>
    /// ObjectProperty: CapeStateController
    /// </summary>
    public unsafe BmSDK.BmGame.RCapeComponent.CurrOwnerStateName CapeStateController
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RCapeComponent.CurrOwnerStateName>(Ptr + 668); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 668); }
    }

    /// <summary>
    /// ObjectProperty: GenericCapeSound
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT GenericCapeSound
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 676); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 676); }
    }

    /// <summary>
    /// ObjectProperty: CapeRainSoundCentre
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT CapeRainSoundCentre
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 684); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 684); }
    }

    /// <summary>
    /// ObjectProperty: CapeRainSoundGlide
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT CapeRainSoundGlide
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 692); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 692); }
    }

    /// <summary>
    /// ObjectProperty: CapeParam_WindStrength
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT CapeParam_WindStrength
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 700); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 700); }
    }

    /// <summary>
    /// ObjectProperty: CapeParam_WindBlusteryness
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT CapeParam_WindBlusteryness
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 708); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 708); }
    }

    /// <summary>
    /// ObjectProperty: PhysDampedMaterialOverride
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT PhysDampedMaterialOverride
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 716); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 716); }
    }

    /// <summary>
    /// ObjectProperty: CapeCollisionShapePhysicalMaterial
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT CapeCollisionShapePhysicalMaterial
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 724); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 724); }
    }

    /// <summary>
    /// ComponentProperty: CapeRenderingComponent
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT CapeRenderingComponent
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 732); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 732); }
    }

    /// <summary>
    /// ComponentProperty: BatmanSkeletalMesh
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT BatmanSkeletalMesh
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 740); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 740); }
    }

    /// <summary>
    /// ComponentProperty: AdditionalHeadMesh
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT AdditionalHeadMesh
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 748); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 748); }
    }

    /// <summary>
    /// ComponentProperty: HeadMesh
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT HeadMesh
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 756); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 756); }
    }

    /// <summary>
    /// ComponentProperty: AdditionalCapeComponent
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT AdditionalCapeComponent
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 764); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 764); }
    }

    /// <summary>
    /// ComponentProperty: ClothSkeletalMesh
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT ClothSkeletalMesh
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 772); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 772); }
    }

    /// <summary>
    /// BoolProperty: IsBatmanInitEnabled
    /// </summary>
    public unsafe bool IsBatmanInitEnabled
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 780) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 780); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 780); }
    }

    /// <summary>
    /// BoolProperty: IsPhysInitEnabled
    /// </summary>
    public unsafe bool IsPhysInitEnabled
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 780) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 780); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 780); }
    }

    /// <summary>
    /// BoolProperty: IsUserInitEnabled
    /// </summary>
    public unsafe bool IsUserInitEnabled
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 780) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 780); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 780); }
    }

    /// <summary>
    /// BoolProperty: IsAttemptInit
    /// </summary>
    public unsafe bool IsAttemptInit
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 780) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 780); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 780); }
    }

    /// <summary>
    /// BoolProperty: IsCapeFrameRatePaused
    /// </summary>
    public unsafe bool IsCapeFrameRatePaused
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 780) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 780); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 780); }
    }

    /// <summary>
    /// BoolProperty: IsPauseRequested
    /// </summary>
    public unsafe bool IsPauseRequested
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 780) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 780); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 780); }
    }

    /// <summary>
    /// BoolProperty: bDebugTrackingCapeStateChangers
    /// </summary>
    public unsafe bool bDebugTrackingCapeStateChangers
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 780) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 780); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 780); }
    }

    /// <summary>
    /// BoolProperty: bCapeStateDebuggingModeEnabled
    /// </summary>
    public unsafe bool bCapeStateDebuggingModeEnabled
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 780) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 780); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 780); }
    }

    /// <summary>
    /// BoolProperty: IsStateChangeRequested
    /// </summary>
    public unsafe bool IsStateChangeRequested
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 780) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 780); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 780); }
    }

    /// <summary>
    /// BoolProperty: ForwardToCinematitClearVelocityOnExit
    /// </summary>
    public unsafe bool ForwardToCinematitClearVelocityOnExit
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 780) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 780); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 780); }
    }

    /// <summary>
    /// BoolProperty: ForwardToTeleportToInitialPose
    /// </summary>
    public unsafe bool ForwardToTeleportToInitialPose
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 780) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 780); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 780); }
    }

    /// <summary>
    /// BoolProperty: IsOverrideDepthBias
    /// </summary>
    public unsafe bool IsOverrideDepthBias
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 780) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 780); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 780); }
    }

    /// <summary>
    /// BoolProperty: bDisableDepthBias
    /// </summary>
    public unsafe bool bDisableDepthBias
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 780) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 780); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 780); }
    }

    /// <summary>
    /// BoolProperty: bReduceDepthBias
    /// </summary>
    public unsafe bool bReduceDepthBias
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 780) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 780); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 780); }
    }

    /// <summary>
    /// BoolProperty: IsCapeHiddenGame
    /// </summary>
    public unsafe bool IsCapeHiddenGame
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 780) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 780); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 780); }
    }

    /// <summary>
    /// BoolProperty: IsPhysicsPostProcessEnabled
    /// </summary>
    public unsafe bool IsPhysicsPostProcessEnabled
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 780) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 780); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 780); }
    }

    /// <summary>
    /// BoolProperty: bDebugEnableCapeOptions
    /// </summary>
    public unsafe bool bDebugEnableCapeOptions
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 780) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 780); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 780); }
    }

    /// <summary>
    /// BoolProperty: bEnableStateChangeDebugOutput
    /// </summary>
    public unsafe bool bEnableStateChangeDebugOutput
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 780) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 780); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 780); }
    }

    /// <summary>
    /// BoolProperty: bEnableStateChangeScriptLog
    /// </summary>
    public unsafe bool bEnableStateChangeScriptLog
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 780) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 780); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 780); }
    }

    /// <summary>
    /// BoolProperty: bCinematic
    /// </summary>
    public unsafe bool bCinematic
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 780) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 780); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 780); }
    }

    /// <summary>
    /// BoolProperty: DisableHeadDepthBias
    /// </summary>
    public unsafe bool DisableHeadDepthBias
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 780) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 780); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 780); }
    }

    /// <summary>
    /// BoolProperty: bAutoDetectTeleport
    /// </summary>
    public unsafe bool bAutoDetectTeleport
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 780) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 780); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 780); }
    }

    /// <summary>
    /// BoolProperty: bDisablePhysicsSimulationInCurrentState
    /// </summary>
    public unsafe bool bDisablePhysicsSimulationInCurrentState
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 780) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 780); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 780); }
    }

    /// <summary>
    /// BoolProperty: bAsyncTickEnabled
    /// </summary>
    public unsafe bool bAsyncTickEnabled
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 780) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 780); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 780); }
    }

    /// <summary>
    /// IntProperty: TeleportFrameCount
    /// </summary>
    public unsafe int TeleportFrameCount
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 784); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 784); }
    }

    /// <summary>
    /// StructProperty: AsyncJob
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT AsyncJob
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 788); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 788); }
    }

    /// <summary>
    /// StructProperty: ForwardToStateData
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT ForwardToStateData
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 796); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 796); }
    }

    /// <summary>
    /// FloatProperty: StateChangeRequestGameTime
    /// </summary>
    public unsafe float StateChangeRequestGameTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 872); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 872); }
    }

    /// <summary>
    /// FloatProperty: StateChangeOverrideScaleHeadDepthBias
    /// </summary>
    public unsafe float StateChangeOverrideScaleHeadDepthBias
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 876); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 876); }
    }

    /// <summary>
    /// FloatProperty: StateChangeOverrideScaleDepthBias
    /// </summary>
    public unsafe float StateChangeOverrideScaleDepthBias
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 880); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 880); }
    }

    /// <summary>
    /// FloatProperty: DepthBiasOverride
    /// </summary>
    public unsafe float DepthBiasOverride
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 884); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 884); }
    }

    /// <summary>
    /// FloatProperty: ReducedDepthBiasClampValue
    /// </summary>
    public unsafe float ReducedDepthBiasClampValue
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 888); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 888); }
    }

    /// <summary>
    /// StructProperty: CapePhysics
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT CapePhysics
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 892); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 892); }
    }

    /// <summary>
    /// ByteProperty: CollisionShapeRBDominanceGroup
    /// </summary>
    public unsafe byte CollisionShapeRBDominanceGroup
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 900); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 900); }
    }

    /// <summary>
    /// StrProperty: CurrOwnerStateName
    /// </summary>
    public unsafe BmSDK.FString CurrOwnerStateName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 904); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 904); }
    }

    /// <summary>
    /// StrProperty: CurrOwnerSpecialMoveConfigName
    /// </summary>
    public unsafe BmSDK.FString CurrOwnerSpecialMoveConfigName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 920); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 920); }
    }

    /// <summary>
    /// FloatProperty: TeleportAutoDetectLinearThreshold
    /// </summary>
    public unsafe float TeleportAutoDetectLinearThreshold
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 936); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 936); }
    }

    /// <summary>
    /// FloatProperty: TeleportAutoDetectAngularThreshold
    /// </summary>
    public unsafe float TeleportAutoDetectAngularThreshold
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 940); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 940); }
    }

    /// <summary>
    /// FloatProperty: MaterialSpeedVariableOverride
    /// </summary>
    public unsafe float MaterialSpeedVariableOverride
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 944); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 944); }
    }

    /// <summary>
    /// FloatProperty: FrozenAmount
    /// </summary>
    public unsafe float FrozenAmount
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 948); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 948); }
    }

    /// <summary>
    /// IntProperty: NumStateChanges
    /// </summary>
    public unsafe int NumStateChanges
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 952); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 952); }
    }
}
