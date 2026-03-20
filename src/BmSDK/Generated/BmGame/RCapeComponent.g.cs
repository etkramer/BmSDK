#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RCapeComponent<br/>
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
    public unsafe System.IntPtr VfTable_IRAsyncPhysXSceneInterface
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.IntPtr>(Ptr + 640); }
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
    public unsafe BmSDK.BmGame.RCapeConfig CapeConfig
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RCapeConfig>(Ptr + 652); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 652); }
    }

    /// <summary>
    /// ObjectProperty: CapeAnimNode
    /// </summary>
    public unsafe BmSDK.BmGame.RAnimNode_Cape CapeAnimNode
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RAnimNode_Cape>(Ptr + 660); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 660); }
    }

    /// <summary>
    /// ObjectProperty: CapeStateController
    /// </summary>
    public unsafe BmSDK.BmGame.RCapeStateController CapeStateController
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RCapeStateController>(Ptr + 668); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 668); }
    }

    /// <summary>
    /// ObjectProperty: GenericCapeSound
    /// </summary>
    public unsafe BmSDK.Engine.AkEvent GenericCapeSound
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkEvent>(Ptr + 676); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 676); }
    }

    /// <summary>
    /// ObjectProperty: CapeRainSoundCentre
    /// </summary>
    public unsafe BmSDK.Engine.AkEvent CapeRainSoundCentre
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkEvent>(Ptr + 684); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 684); }
    }

    /// <summary>
    /// ObjectProperty: CapeRainSoundGlide
    /// </summary>
    public unsafe BmSDK.Engine.AkEvent CapeRainSoundGlide
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkEvent>(Ptr + 692); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 692); }
    }

    /// <summary>
    /// ObjectProperty: CapeParam_WindStrength
    /// </summary>
    public unsafe BmSDK.Engine.AkParameterName CapeParam_WindStrength
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkParameterName>(Ptr + 700); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 700); }
    }

    /// <summary>
    /// ObjectProperty: CapeParam_WindBlusteryness
    /// </summary>
    public unsafe BmSDK.Engine.AkParameterName CapeParam_WindBlusteryness
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkParameterName>(Ptr + 708); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 708); }
    }

    /// <summary>
    /// ObjectProperty: PhysDampedMaterialOverride
    /// </summary>
    public unsafe BmSDK.Engine.PhysicalMaterial PhysDampedMaterialOverride
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.PhysicalMaterial>(Ptr + 716); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 716); }
    }

    /// <summary>
    /// ObjectProperty: CapeCollisionShapePhysicalMaterial
    /// </summary>
    public unsafe BmSDK.Engine.PhysicalMaterial CapeCollisionShapePhysicalMaterial
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.PhysicalMaterial>(Ptr + 724); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 724); }
    }

    /// <summary>
    /// ComponentProperty: CapeRenderingComponent
    /// </summary>
    public unsafe BmSDK.BmGame.RCapeRenderingComponent CapeRenderingComponent
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RCapeRenderingComponent>(Ptr + 732); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 732); }
    }

    /// <summary>
    /// ComponentProperty: BatmanSkeletalMesh
    /// </summary>
    public unsafe BmSDK.Engine.SkeletalMeshComponent BatmanSkeletalMesh
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.SkeletalMeshComponent>(Ptr + 740); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 740); }
    }

    /// <summary>
    /// ComponentProperty: AdditionalHeadMesh
    /// </summary>
    public unsafe BmSDK.Engine.SkeletalMeshComponent AdditionalHeadMesh
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.SkeletalMeshComponent>(Ptr + 748); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 748); }
    }

    /// <summary>
    /// ComponentProperty: HeadMesh
    /// </summary>
    public unsafe BmSDK.Engine.SkeletalMeshComponent HeadMesh
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.SkeletalMeshComponent>(Ptr + 756); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 756); }
    }

    /// <summary>
    /// ComponentProperty: AdditionalCapeComponent
    /// </summary>
    public unsafe BmSDK.Engine.SkeletalMeshComponent AdditionalCapeComponent
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.SkeletalMeshComponent>(Ptr + 764); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 764); }
    }

    /// <summary>
    /// ComponentProperty: ClothSkeletalMesh
    /// </summary>
    public unsafe BmSDK.BmGame.RCapeSkeletalMeshComponent ClothSkeletalMesh
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RCapeSkeletalMeshComponent>(Ptr + 772); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 772); }
    }

    /// <summary>
    /// BoolProperty: IsBatmanInitEnabled
    /// </summary>
    public unsafe bool IsBatmanInitEnabled
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 780) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 780); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 780); }
    }

    /// <summary>
    /// BoolProperty: IsPhysInitEnabled
    /// </summary>
    public unsafe bool IsPhysInitEnabled
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 780) & 2) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 780); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 780); }
    }

    /// <summary>
    /// BoolProperty: IsUserInitEnabled
    /// </summary>
    public unsafe bool IsUserInitEnabled
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 780) & 4) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 780); var newMask = value ? (currentMask | 4) : (currentMask & ~4); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 780); }
    }

    /// <summary>
    /// BoolProperty: IsAttemptInit
    /// </summary>
    public unsafe bool IsAttemptInit
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 780) & 8) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 780); var newMask = value ? (currentMask | 8) : (currentMask & ~8); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 780); }
    }

    /// <summary>
    /// BoolProperty: IsCapeFrameRatePaused
    /// </summary>
    public unsafe bool IsCapeFrameRatePaused
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 780) & 16) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 780); var newMask = value ? (currentMask | 16) : (currentMask & ~16); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 780); }
    }

    /// <summary>
    /// BoolProperty: IsPauseRequested
    /// </summary>
    public unsafe bool IsPauseRequested
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 780) & 32) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 780); var newMask = value ? (currentMask | 32) : (currentMask & ~32); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 780); }
    }

    /// <summary>
    /// BoolProperty: bDebugTrackingCapeStateChangers
    /// </summary>
    public unsafe bool bDebugTrackingCapeStateChangers
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 780) & 64) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 780); var newMask = value ? (currentMask | 64) : (currentMask & ~64); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 780); }
    }

    /// <summary>
    /// BoolProperty: bCapeStateDebuggingModeEnabled
    /// </summary>
    public unsafe bool bCapeStateDebuggingModeEnabled
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 780) & 128) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 780); var newMask = value ? (currentMask | 128) : (currentMask & ~128); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 780); }
    }

    /// <summary>
    /// BoolProperty: IsStateChangeRequested
    /// </summary>
    public unsafe bool IsStateChangeRequested
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 780) & 256) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 780); var newMask = value ? (currentMask | 256) : (currentMask & ~256); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 780); }
    }

    /// <summary>
    /// BoolProperty: ForwardToCinematitClearVelocityOnExit
    /// </summary>
    public unsafe bool ForwardToCinematitClearVelocityOnExit
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 780) & 512) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 780); var newMask = value ? (currentMask | 512) : (currentMask & ~512); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 780); }
    }

    /// <summary>
    /// BoolProperty: ForwardToTeleportToInitialPose
    /// </summary>
    public unsafe bool ForwardToTeleportToInitialPose
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 780) & 1024) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 780); var newMask = value ? (currentMask | 1024) : (currentMask & ~1024); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 780); }
    }

    /// <summary>
    /// BoolProperty: IsOverrideDepthBias
    /// </summary>
    public unsafe bool IsOverrideDepthBias
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 780) & 2048) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 780); var newMask = value ? (currentMask | 2048) : (currentMask & ~2048); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 780); }
    }

    /// <summary>
    /// BoolProperty: bDisableDepthBias
    /// </summary>
    public unsafe bool bDisableDepthBias
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 780) & 4096) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 780); var newMask = value ? (currentMask | 4096) : (currentMask & ~4096); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 780); }
    }

    /// <summary>
    /// BoolProperty: bReduceDepthBias
    /// </summary>
    public unsafe bool bReduceDepthBias
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 780) & 8192) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 780); var newMask = value ? (currentMask | 8192) : (currentMask & ~8192); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 780); }
    }

    /// <summary>
    /// BoolProperty: IsCapeHiddenGame
    /// </summary>
    public unsafe bool IsCapeHiddenGame
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 780) & 16384) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 780); var newMask = value ? (currentMask | 16384) : (currentMask & ~16384); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 780); }
    }

    /// <summary>
    /// BoolProperty: IsPhysicsPostProcessEnabled
    /// </summary>
    public unsafe bool IsPhysicsPostProcessEnabled
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 780) & 32768) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 780); var newMask = value ? (currentMask | 32768) : (currentMask & ~32768); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 780); }
    }

    /// <summary>
    /// BoolProperty: bDebugEnableCapeOptions
    /// </summary>
    public unsafe bool bDebugEnableCapeOptions
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 780) & 65536) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 780); var newMask = value ? (currentMask | 65536) : (currentMask & ~65536); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 780); }
    }

    /// <summary>
    /// BoolProperty: bEnableStateChangeDebugOutput
    /// </summary>
    public unsafe bool bEnableStateChangeDebugOutput
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 780) & 131072) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 780); var newMask = value ? (currentMask | 131072) : (currentMask & ~131072); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 780); }
    }

    /// <summary>
    /// BoolProperty: bEnableStateChangeScriptLog
    /// </summary>
    public unsafe bool bEnableStateChangeScriptLog
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 780) & 262144) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 780); var newMask = value ? (currentMask | 262144) : (currentMask & ~262144); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 780); }
    }

    /// <summary>
    /// BoolProperty: bCinematic
    /// </summary>
    public unsafe bool bCinematic
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 780) & 524288) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 780); var newMask = value ? (currentMask | 524288) : (currentMask & ~524288); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 780); }
    }

    /// <summary>
    /// BoolProperty: DisableHeadDepthBias
    /// </summary>
    public unsafe bool DisableHeadDepthBias
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 780) & 1048576) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 780); var newMask = value ? (currentMask | 1048576) : (currentMask & ~1048576); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 780); }
    }

    /// <summary>
    /// BoolProperty: bAutoDetectTeleport
    /// </summary>
    public unsafe bool bAutoDetectTeleport
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 780) & 2097152) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 780); var newMask = value ? (currentMask | 2097152) : (currentMask & ~2097152); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 780); }
    }

    /// <summary>
    /// BoolProperty: bDisablePhysicsSimulationInCurrentState
    /// </summary>
    public unsafe bool bDisablePhysicsSimulationInCurrentState
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 780) & 4194304) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 780); var newMask = value ? (currentMask | 4194304) : (currentMask & ~4194304); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 780); }
    }

    /// <summary>
    /// BoolProperty: bAsyncTickEnabled
    /// </summary>
    public unsafe bool bAsyncTickEnabled
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 780) & 8388608) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 780); var newMask = value ? (currentMask | 8388608) : (currentMask & ~8388608); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 780); }
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
    public unsafe System.IntPtr AsyncJob
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.IntPtr>(Ptr + 788); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 788); }
    }

    /// <summary>
    /// StructProperty: ForwardToStateData
    /// </summary>
    public unsafe BmSDK.BmGame.RPhysUtil.FCapeStateChangeData ForwardToStateData
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPhysUtil.FCapeStateChangeData>(Ptr + 796); }
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
    public unsafe System.IntPtr CapePhysics
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.IntPtr>(Ptr + 892); }
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
