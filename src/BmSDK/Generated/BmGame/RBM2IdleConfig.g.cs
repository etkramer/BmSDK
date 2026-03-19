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
    public unsafe BmSDK.TArray<BmSDK.BmGame.RBM2IdleConfig.ConversationAnims> AnimSets
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RBM2IdleConfig.ConversationAnims>>(Ptr + 84); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 84); }
    }

    /// <summary>
    /// StructProperty: Anims
    /// </summary>
    public unsafe BmSDK.BmGame.RBM2IdleConfig.ConversationAnims Anims
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RBM2IdleConfig.ConversationAnims>(Ptr + 100); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 100); }
    }

    /// <summary>
    /// StructProperty: BMDialogueAnims
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT BMDialogueAnims
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 196); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 196); }
    }

    /// <summary>
    /// StructProperty: ConversationAnims
    /// </summary>
    public unsafe BmSDK.BmGame.RBM2IdleConfig.IdleAimingConfig ConversationAnims
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RBM2IdleConfig.IdleAimingConfig>(Ptr + 220); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 220); }
    }

    /// <summary>
    /// ByteProperty: IdleRelativeStyle
    /// </summary>
    public unsafe byte IdleRelativeStyle
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 268); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 268); }
    }

    /// <summary>
    /// ByteProperty: EndMovementStance
    /// </summary>
    public unsafe byte EndMovementStance
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 269); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 269); }
    }

    /// <summary>
    /// ObjectProperty: IdleAimingConfig
    /// </summary>
    public unsafe BmSDK.BmGame.RBM2IdleConfig.EndMovementStanceArray IdleAimingConfig
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RBM2IdleConfig.EndMovementStanceArray>(Ptr + 272); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 272); }
    }

    /// <summary>
    /// ObjectProperty: walkVariantAnimSet
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT walkVariantAnimSet
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 280); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 280); }
    }

    /// <summary>
    /// ArrayProperty: EndMovementStanceArray
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.TArray<BmSDK.FString>> EndMovementStanceArray
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.TArray<BmSDK.FString>>>(Ptr + 288); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 288); }
    }

    /// <summary>
    /// ArrayProperty: EndWeaponStanceArray
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.FString> EndWeaponStanceArray
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.FString>>(Ptr + 304); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 304); }
    }

    /// <summary>
    /// BoolProperty: IsAllowedToInstantlyChangeAnimation
    /// </summary>
    public unsafe bool IsAllowedToInstantlyChangeAnimation
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 320) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 320); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 320); }
    }

    /// <summary>
    /// BoolProperty: IsAllowedToInstantlyChangeAnimationEvenInTransition
    /// </summary>
    public unsafe bool IsAllowedToInstantlyChangeAnimationEvenInTransition
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 320) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 320); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 320); }
    }

    /// <summary>
    /// BoolProperty: ThumbnailSetttingsSet
    /// </summary>
    public unsafe bool ThumbnailSetttingsSet
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 320) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 320); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 320); }
    }

    /// <summary>
    /// BoolProperty: bHasInitialisedRandom
    /// </summary>
    public unsafe bool bHasInitialisedRandom
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 320) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 320); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 320); }
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
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT InterrogationOverride
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 332); }
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
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT ThumbnailMeshOffset
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 420); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 420); }
    }

    /// <summary>
    /// StructProperty: ThumbnailMeshRotation
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT ThumbnailMeshRotation
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 432); }
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
