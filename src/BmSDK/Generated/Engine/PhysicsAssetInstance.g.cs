#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Class: PhysicsAssetInstance<br/>
/// (size = 168)
/// (flags = 136315026)
/// </summary>
public partial class PhysicsAssetInstance : BmSDK.GameObject, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Engine.PhysicsAssetInstance", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal PhysicsAssetInstance() { }

    /// <summary>
    /// Constructs a new PhysicsAssetInstance
    /// </summary>
    public PhysicsAssetInstance(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, PhysicsAssetInstance Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected PhysicsAssetInstance(nint ptr) : base(ptr) { }

    /// <summary>
    /// Function: SetDampingRampupProportion
    /// </summary>
    public unsafe void SetDampingRampupProportion(float NewDampingRampupProportion)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "Engine.PhysicsAssetInstance.SetDampingRampupProportion", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewDampingRampupProportion, paramsPtr + 0);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return;
    }

    /// <summary>
    /// Function: FindConstraintInstance
    /// </summary>
    public unsafe BmSDK.Engine.RB_ConstraintInstance FindConstraintInstance(BmSDK.FName ConName, BmSDK.Engine.PhysicsAsset InAsset)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "Engine.PhysicsAssetInstance.FindConstraintInstance", true);
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ConName, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(InAsset, paramsPtr + 8);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RB_ConstraintInstance>(paramsPtr + 12);
    }

    /// <summary>
    /// Function: FindBodyInstance
    /// </summary>
    public unsafe BmSDK.Engine.RB_BodyInstance FindBodyInstance(BmSDK.FName BodyName, BmSDK.Engine.PhysicsAsset InAsset)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "Engine.PhysicsAssetInstance.FindBodyInstance", true);
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(BodyName, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(InAsset, paramsPtr + 8);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RB_BodyInstance>(paramsPtr + 12);
    }

    /// <summary>
    /// Function: SetFullAnimWeightBonesFixed
    /// </summary>
    public unsafe void SetFullAnimWeightBonesFixed(bool bNewFixed, BmSDK.Engine.SkeletalMeshComponent SkelMesh)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "Engine.PhysicsAssetInstance.SetFullAnimWeightBonesFixed", true);
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bNewFixed, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SkelMesh, paramsPtr + 4);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return;
    }

    /// <summary>
    /// Function: SetFullAnimWeightBlockRigidBody
    /// </summary>
    public unsafe void SetFullAnimWeightBlockRigidBody(bool bNewBlockRigidBody, BmSDK.Engine.SkeletalMeshComponent SkelMesh)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "Engine.PhysicsAssetInstance.SetFullAnimWeightBlockRigidBody", true);
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bNewBlockRigidBody, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SkelMesh, paramsPtr + 4);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return;
    }

    /// <summary>
    /// Function: SetNamedBodiesBlockRigidBody
    /// </summary>
    public unsafe void SetNamedBodiesBlockRigidBody(bool bNewBlockRigidBody, BmSDK.TArray<BmSDK.FName> BoneNames, BmSDK.Engine.SkeletalMeshComponent SkelMesh)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "Engine.PhysicsAssetInstance.SetNamedBodiesBlockRigidBody", true);
        byte* paramsPtr = stackalloc byte[20];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bNewBlockRigidBody, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(BoneNames, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SkelMesh, paramsPtr + 16);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return;
    }

    /// <summary>
    /// Function: SetNamedRBBoneSprings
    /// </summary>
    public unsafe void SetNamedRBBoneSprings(bool bEnable, BmSDK.TArray<BmSDK.FName> BoneNames, float InBoneLinearSpring, float InBoneAngularSpring, BmSDK.Engine.SkeletalMeshComponent SkelMeshComp, BmSDK.Engine.PhysicsAssetInstance.EBoneSpringUsagePriority BoneSpringUsagePriority)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "Engine.PhysicsAssetInstance.SetNamedRBBoneSprings", true);
        byte* paramsPtr = stackalloc byte[29];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bEnable, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(BoneNames, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(InBoneLinearSpring, paramsPtr + 16);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(InBoneAngularSpring, paramsPtr + 20);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SkelMeshComp, paramsPtr + 24);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(BoneSpringUsagePriority, paramsPtr + 28);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return;
    }

    /// <summary>
    /// Function: SetNamedMotorsAngularVelocityDrive
    /// </summary>
    public unsafe void SetNamedMotorsAngularVelocityDrive(bool bEnableSwingDrive, bool bEnableTwistDrive, BmSDK.TArray<BmSDK.FName> BoneNames, BmSDK.Engine.SkeletalMeshComponent SkelMeshComp, bool bSetOtherBodiesToComplement = default)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "Engine.PhysicsAssetInstance.SetNamedMotorsAngularVelocityDrive", true);
        byte* paramsPtr = stackalloc byte[28];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bEnableSwingDrive, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bEnableTwistDrive, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(BoneNames, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SkelMeshComp, paramsPtr + 20);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bSetOtherBodiesToComplement, paramsPtr + 24);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return;
    }

    /// <summary>
    /// Function: SetNamedMotorsAngularPositionDrive
    /// </summary>
    public unsafe void SetNamedMotorsAngularPositionDrive(bool bEnableSwingDrive, bool bEnableTwistDrive, BmSDK.TArray<BmSDK.FName> BoneNames, BmSDK.Engine.SkeletalMeshComponent SkelMeshComp, bool bSetOtherBodiesToComplement = default)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "Engine.PhysicsAssetInstance.SetNamedMotorsAngularPositionDrive", true);
        byte* paramsPtr = stackalloc byte[28];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bEnableSwingDrive, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bEnableTwistDrive, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(BoneNames, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SkelMeshComp, paramsPtr + 20);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bSetOtherBodiesToComplement, paramsPtr + 24);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return;
    }

    /// <summary>
    /// Function: SetAllMotorsAngularDriveParams
    /// </summary>
    public unsafe void SetAllMotorsAngularDriveParams(float InSpring, float InDamping, float InForceLimit, BmSDK.Engine.SkeletalMeshComponent SkelMesh = default, bool bSkipFullAnimWeightBodies = default)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "Engine.PhysicsAssetInstance.SetAllMotorsAngularDriveParams", true);
        byte* paramsPtr = stackalloc byte[20];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(InSpring, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(InDamping, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(InForceLimit, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SkelMesh, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bSkipFullAnimWeightBodies, paramsPtr + 16);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return;
    }

    /// <summary>
    /// Function: SetAllMotorsAngularVelocityDrive
    /// </summary>
    public unsafe void SetAllMotorsAngularVelocityDrive(bool bEnableSwingDrive, bool bEnableTwistDrive, BmSDK.Engine.SkeletalMeshComponent SkelMeshComp, bool bSkipFullAnimWeightBodies = default)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "Engine.PhysicsAssetInstance.SetAllMotorsAngularVelocityDrive", true);
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bEnableSwingDrive, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bEnableTwistDrive, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SkelMeshComp, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bSkipFullAnimWeightBodies, paramsPtr + 12);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return;
    }

    /// <summary>
    /// Function: SetAllMotorsAngularPositionDrive
    /// </summary>
    public unsafe void SetAllMotorsAngularPositionDrive(bool bEnableSwingDrive, bool bEnableTwistDrive, BmSDK.Engine.SkeletalMeshComponent SkelMesh = default, bool bSkipFullAnimWeightBodies = default)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "Engine.PhysicsAssetInstance.SetAllMotorsAngularPositionDrive", true);
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bEnableSwingDrive, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bEnableTwistDrive, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SkelMesh, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bSkipFullAnimWeightBodies, paramsPtr + 12);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return;
    }

    /// <summary>
    /// Function: ForceAllBodiesBelowUnfixed
    /// </summary>
    public unsafe void ForceAllBodiesBelowUnfixed(out BmSDK.FName InBoneName, BmSDK.Engine.PhysicsAsset InAsset, BmSDK.Engine.SkeletalMeshComponent InSkelMesh, bool InbInstanceAlwaysFullAnimWeight)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "Engine.PhysicsAssetInstance.ForceAllBodiesBelowUnfixed", true);
        byte* paramsPtr = stackalloc byte[20];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(InAsset, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(InSkelMesh, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(InbInstanceAlwaysFullAnimWeight, paramsPtr + 16);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        InBoneName = BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(paramsPtr + 0);
        return;
    }

    /// <summary>
    /// Function: SetGroupBodiesFixed
    /// </summary>
    public unsafe void SetGroupBodiesFixed(bool bNewFixed, BmSDK.FName GroupName, BmSDK.Engine.SkeletalMeshComponent SkelMesh, bool bSetOtherBodiesToComplement = default)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "Engine.PhysicsAssetInstance.SetGroupBodiesFixed", true);
        byte* paramsPtr = stackalloc byte[20];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bNewFixed, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(GroupName, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SkelMesh, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bSetOtherBodiesToComplement, paramsPtr + 16);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return;
    }

    /// <summary>
    /// Function: SetNamedBodiesFixed
    /// </summary>
    public unsafe void SetNamedBodiesFixed(bool bNewFixed, BmSDK.TArray<BmSDK.FName> BoneNames, BmSDK.Engine.SkeletalMeshComponent SkelMesh, bool bSetOtherBodiesToComplement = default, bool bSkipFullAnimWeightBodies = default)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "Engine.PhysicsAssetInstance.SetNamedBodiesFixed", true);
        byte* paramsPtr = stackalloc byte[28];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bNewFixed, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(BoneNames, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SkelMesh, paramsPtr + 16);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bSetOtherBodiesToComplement, paramsPtr + 20);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bSkipFullAnimWeightBodies, paramsPtr + 24);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return;
    }

    /// <summary>
    /// Function: SetAllBodiesFixed
    /// </summary>
    public unsafe void SetAllBodiesFixed(bool bNewFixed)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "Engine.PhysicsAssetInstance.SetAllBodiesFixed", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bNewFixed, paramsPtr + 0);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return;
    }

    /// <summary>
    /// Function: GetTotalMassBelowBone
    /// </summary>
    public unsafe float GetTotalMassBelowBone(BmSDK.FName InBoneName, BmSDK.Engine.PhysicsAsset InAsset, BmSDK.Engine.SkeletalMesh InSkelMesh)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "Engine.PhysicsAssetInstance.GetTotalMassBelowBone", true);
        byte* paramsPtr = stackalloc byte[20];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(InBoneName, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(InAsset, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(InSkelMesh, paramsPtr + 12);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManaged<float>(paramsPtr + 16);
    }

    /// <summary>
    /// Function: SetAngularDriveScale
    /// </summary>
    public unsafe void SetAngularDriveScale(float InAngularSpringScale, float InAngularDampingScale, float InAngularForceLimitScale)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "Engine.PhysicsAssetInstance.SetAngularDriveScale", true);
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(InAngularSpringScale, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(InAngularDampingScale, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(InAngularForceLimitScale, paramsPtr + 8);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return;
    }

    /// <summary>
    /// Function: SetLinearDriveScale
    /// </summary>
    public unsafe void SetLinearDriveScale(float InLinearSpringScale, float InLinearDampingScale, float InLinearForceLimitScale)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "Engine.PhysicsAssetInstance.SetLinearDriveScale", true);
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(InLinearSpringScale, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(InLinearDampingScale, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(InLinearForceLimitScale, paramsPtr + 8);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return;
    }

    /// <summary>
    /// ObjectProperty: Owner
    /// </summary>
    public unsafe BmSDK.Engine.Actor Owner
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.Actor>(Ptr + 44); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 44); }
    }

    /// <summary>
    /// IntProperty: RootBodyIndex
    /// </summary>
    public unsafe int RootBodyIndex
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 48); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 48); }
    }

    /// <summary>
    /// ArrayProperty: Bodies
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.Engine.RB_BodyInstance> Bodies
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.RB_BodyInstance>>(Ptr + 52); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 52); }
    }

    /// <summary>
    /// ArrayProperty: Constraints
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.Engine.RB_ConstraintInstance> Constraints
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.RB_ConstraintInstance>>(Ptr + 64); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 64); }
    }

    /// <summary>
    /// StructProperty: CollisionDisableTable
    /// </summary>
    public unsafe BmSDK.GameObject.FMap_Mirror CollisionDisableTable
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.GameObject.FMap_Mirror>(Ptr + 76); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 76); }
    }

    /// <summary>
    /// FloatProperty: LinearSpringScale
    /// </summary>
    public unsafe float LinearSpringScale
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 136); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 136); }
    }

    /// <summary>
    /// FloatProperty: LinearDampingScale
    /// </summary>
    public unsafe float LinearDampingScale
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 140); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 140); }
    }

    /// <summary>
    /// FloatProperty: LinearForceLimitScale
    /// </summary>
    public unsafe float LinearForceLimitScale
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 144); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 144); }
    }

    /// <summary>
    /// FloatProperty: AngularSpringScale
    /// </summary>
    public unsafe float AngularSpringScale
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 148); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 148); }
    }

    /// <summary>
    /// FloatProperty: AngularDampingScale
    /// </summary>
    public unsafe float AngularDampingScale
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 152); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 152); }
    }

    /// <summary>
    /// FloatProperty: AngularForceLimitScale
    /// </summary>
    public unsafe float AngularForceLimitScale
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 156); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 156); }
    }

    /// <summary>
    /// BoolProperty: bInitBodies
    /// </summary>
    public unsafe bool bInitBodies
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 160) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 160); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 160); }
    }

    /// <summary>
    /// FloatProperty: CachedDampingRampupProportion
    /// </summary>
    public unsafe float CachedDampingRampupProportion
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 164); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 164); }
    }

    /// <summary>
    /// Enum: EBoneSpringUsagePriority
    /// </summary>
    public enum EBoneSpringUsagePriority
    {
        BONESPRINGUSAGEPRIORITY_None = 0,
        BONESPRINGUSAGEPRIORITY_NetDrive = 1,
        BONESPRINGUSAGEPRIORITY_AnimDrive = 2,
        BONESPRINGUSAGEPRIORITY_Highest = 3,
        BONESPRINGUSAGEPRIORITY_MAX = 4,
    }
}
