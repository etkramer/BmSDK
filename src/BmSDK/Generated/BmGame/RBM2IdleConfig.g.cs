#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RBM2IdleConfig<br/>
/// (size = 0)
/// (flags = 0)
/// </summary>
public partial class RBM2IdleConfig : BmSDK.BmGame.RConfig, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RBM2IdleConfig", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RBM2IdleConfig() { }

    /// <summary>
    /// Constructs a new RBM2IdleConfig
    /// </summary>
    public RBM2IdleConfig(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RBM2IdleConfig Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RBM2IdleConfig(nint ptr) : base(ptr) { }

    /// <summary>
    /// ArrayProperty: AnimSets
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.Engine.AnimSet> AnimSets
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.AnimSet>>(Ptr + 84); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 84); }
    }

    /// <summary>
    /// StructProperty: Anims
    /// </summary>
    public unsafe BmSDK.BmGame.RBM2IdleConfig.FAnimationSets Anims
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RBM2IdleConfig.FAnimationSets>(Ptr + 100); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 100); }
    }

    /// <summary>
    /// StructProperty: BMDialogueAnims
    /// </summary>
    public unsafe BmSDK.BmGame.RBM2IdleConfig.FBM2IdleSet BMDialogueAnims
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RBM2IdleConfig.FBM2IdleSet>(Ptr + 196); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 196); }
    }

    /// <summary>
    /// StructProperty: ConversationAnims
    /// </summary>
    public unsafe BmSDK.BmGame.RBM2IdleConfig.FDialogueAnimationSets ConversationAnims
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RBM2IdleConfig.FDialogueAnimationSets>(Ptr + 220); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 220); }
    }

    /// <summary>
    /// ByteProperty: IdleRelativeStyle
    /// </summary>
    public unsafe BmSDK.BmGame.RBM2IdleConfig.BM2RelativeTransitionStyle IdleRelativeStyle
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RBM2IdleConfig.BM2RelativeTransitionStyle>(Ptr + 268); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 268); }
    }

    /// <summary>
    /// ByteProperty: EndMovementStance
    /// </summary>
    public unsafe BmSDK.BmGame.RBM2IdleConfig.EMovementStances EndMovementStance
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RBM2IdleConfig.EMovementStances>(Ptr + 269); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 269); }
    }

    /// <summary>
    /// ObjectProperty: IdleAimingConfig
    /// </summary>
    public unsafe BmSDK.Engine.RAimingConfig IdleAimingConfig
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RAimingConfig>(Ptr + 272); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 272); }
    }

    /// <summary>
    /// ObjectProperty: walkVariantAnimSet
    /// </summary>
    public unsafe BmSDK.Engine.AnimSet walkVariantAnimSet
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AnimSet>(Ptr + 280); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 280); }
    }

    /// <summary>
    /// ArrayProperty: EndMovementStanceArray
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.FName> EndMovementStanceArray
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.FName>>(Ptr + 288); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 288); }
    }

    /// <summary>
    /// ArrayProperty: EndWeaponStanceArray
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.FName> EndWeaponStanceArray
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.FName>>(Ptr + 304); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 304); }
    }

    /// <summary>
    /// BoolProperty: IsAllowedToInstantlyChangeAnimation
    /// </summary>
    public unsafe bool IsAllowedToInstantlyChangeAnimation
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 320) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 320); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 320); }
    }

    /// <summary>
    /// BoolProperty: IsAllowedToInstantlyChangeAnimationEvenInTransition
    /// </summary>
    public unsafe bool IsAllowedToInstantlyChangeAnimationEvenInTransition
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 320) & 2) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 320); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 320); }
    }

    /// <summary>
    /// BoolProperty: ThumbnailSetttingsSet
    /// </summary>
    public unsafe bool ThumbnailSetttingsSet
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 320) & 4) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 320); var newMask = value ? (currentMask | 4) : (currentMask & ~4); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 320); }
    }

    /// <summary>
    /// BoolProperty: bHasInitialisedRandom
    /// </summary>
    public unsafe bool bHasInitialisedRandom
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 320) & 8) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 320); var newMask = value ? (currentMask | 8) : (currentMask & ~8); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 320); }
    }

    /// <summary>
    /// FloatProperty: minTimeBetweenWalkVariants
    /// </summary>
    public unsafe float minTimeBetweenWalkVariants
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 324); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 324); }
    }

    /// <summary>
    /// FloatProperty: maxTimeBetweenWalkVariants
    /// </summary>
    public unsafe float maxTimeBetweenWalkVariants
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 328); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 328); }
    }

    /// <summary>
    /// StructProperty: InterrogationOverride
    /// </summary>
    public unsafe BmSDK.BmGame.RBM2IdleConfig.FInterrogationAnimations InterrogationOverride
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RBM2IdleConfig.FInterrogationAnimations>(Ptr + 332); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 332); }
    }

    /// <summary>
    /// FloatProperty: DeviationForMovement
    /// </summary>
    public unsafe float DeviationForMovement
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 368); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 368); }
    }

    /// <summary>
    /// StrProperty: LastEdit
    /// </summary>
    public unsafe BmSDK.FString LastEdit
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 372); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 372); }
    }

    /// <summary>
    /// StrProperty: SecondLastEdit
    /// </summary>
    public unsafe BmSDK.FString SecondLastEdit
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 388); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 388); }
    }

    /// <summary>
    /// StrProperty: ErrorCheck
    /// </summary>
    public unsafe BmSDK.FString ErrorCheck
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 404); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 404); }
    }

    /// <summary>
    /// StructProperty: ThumbnailMeshOffset
    /// </summary>
    public unsafe System.Numerics.Vector3 ThumbnailMeshOffset
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 420); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 420); }
    }

    /// <summary>
    /// StructProperty: ThumbnailMeshRotation
    /// </summary>
    public unsafe BmSDK.Rotator ThumbnailMeshRotation
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Rotator>(Ptr + 432); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 432); }
    }

    /// <summary>
    /// FloatProperty: ThumbnailTimer
    /// </summary>
    public unsafe float ThumbnailTimer
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 444); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 444); }
    }

    /// <summary>
    /// IntProperty: ThumbnailRandomSelected
    /// </summary>
    public unsafe int ThumbnailRandomSelected
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 448); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 448); }
    }
}
