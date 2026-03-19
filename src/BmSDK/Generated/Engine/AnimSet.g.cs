#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Class: AnimSet<br/>
/// (size = 0)
/// (flags = 0)
/// </summary>
public partial class AnimSet : BmSDK.GameObject, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Engine.AnimSet", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal AnimSet() { }

    /// <summary>
    /// Constructs a new AnimSet
    /// </summary>
    public AnimSet(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, AnimSet Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected AnimSet(nint ptr) : base(ptr) { }

    /// <summary>
    /// NameProperty: PreviewSkelMeshName
    /// </summary>
    public unsafe BmSDK.FName PreviewSkelMeshName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 84); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 84); }
    }

    /// <summary>
    /// BoolProperty: bAnimRotationOnly
    /// </summary>
    public unsafe bool bAnimRotationOnly
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 92) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 92); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 92); }
    }

    /// <summary>
    /// BoolProperty: FaceFXBaseExpression_Enabled
    /// </summary>
    public unsafe bool FaceFXBaseExpression_Enabled
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 92) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 92); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 92); }
    }

    /// <summary>
    /// BoolProperty: IsFaceOnlyBoneAnimation
    /// </summary>
    public unsafe bool IsFaceOnlyBoneAnimation
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 92) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 92); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 92); }
    }

    /// <summary>
    /// BoolProperty: bReferenceFullAnimSetInIdleConfigs
    /// </summary>
    public unsafe bool bReferenceFullAnimSetInIdleConfigs
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 92) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 92); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 92); }
    }

    /// <summary>
    /// BoolProperty: AutoDeleteTracks_Face
    /// </summary>
    public unsafe bool AutoDeleteTracks_Face
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 92) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 92); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 92); }
    }

    /// <summary>
    /// BoolProperty: AutoDeleteTracks_NonFace
    /// </summary>
    public unsafe bool AutoDeleteTracks_NonFace
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 92) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 92); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 92); }
    }

    /// <summary>
    /// BoolProperty: AutoDeleteTracks_Nubs
    /// </summary>
    public unsafe bool AutoDeleteTracks_Nubs
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 92) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 92); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 92); }
    }

    /// <summary>
    /// BoolProperty: AutoDeleteTracks_Flappy
    /// </summary>
    public unsafe bool AutoDeleteTracks_Flappy
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 92) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 92); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 92); }
    }

    /// <summary>
    /// BoolProperty: AutoDeleteTracks_Scale
    /// </summary>
    public unsafe bool AutoDeleteTracks_Scale
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 92) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 92); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 92); }
    }

    /// <summary>
    /// BoolProperty: AutoDeleteTracks_Procedural
    /// </summary>
    public unsafe bool AutoDeleteTracks_Procedural
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 92) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 92); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 92); }
    }

    /// <summary>
    /// BoolProperty: AutoDeleteTracks_BipedTranslation
    /// </summary>
    public unsafe bool AutoDeleteTracks_BipedTranslation
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 92) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 92); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 92); }
    }

    /// <summary>
    /// BoolProperty: AutoDeleteTracks_CowlAndMask
    /// </summary>
    public unsafe bool AutoDeleteTracks_CowlAndMask
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 92) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 92); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 92); }
    }

    /// <summary>
    /// BoolProperty: AutoDeleteTracks_FaceMoveHelpers
    /// </summary>
    public unsafe bool AutoDeleteTracks_FaceMoveHelpers
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 92) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 92); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 92); }
    }

    /// <summary>
    /// BoolProperty: Compression_OverrideIndividualAnimSettings
    /// </summary>
    public unsafe bool Compression_OverrideIndividualAnimSettings
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 92) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 92); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 92); }
    }

    /// <summary>
    /// BoolProperty: Compression_RelativeToReferencePose
    /// </summary>
    public unsafe bool Compression_RelativeToReferencePose
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 92) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 92); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 92); }
    }

    /// <summary>
    /// BoolProperty: EnableCombatStatus
    /// </summary>
    public unsafe bool EnableCombatStatus
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 92) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 92); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 92); }
    }

    /// <summary>
    /// ByteProperty: FaceFXBaseExpression
    /// </summary>
    public unsafe byte FaceFXBaseExpression
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 96); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 96); }
    }

    /// <summary>
    /// ByteProperty: Compression_Preset
    /// </summary>
    public unsafe byte Compression_Preset
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 97); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 97); }
    }

    /// <summary>
    /// ObjectProperty: AutomaticTransitions
    /// </summary>
    public unsafe BmSDK.Engine.AnimSet.Skeleton AutomaticTransitions
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AnimSet.Skeleton>(Ptr + 100); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 100); }
    }

    /// <summary>
    /// ObjectProperty: Skeleton
    /// </summary>
    public unsafe BmSDK.Engine.AnimSet.Compression_CustomSettings Skeleton
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AnimSet.Compression_CustomSettings>(Ptr + 108); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 108); }
    }

    /// <summary>
    /// ObjectProperty: Compression_CustomSettings
    /// </summary>
    public unsafe BmSDK.Engine.AnimSet.TrackBoneNames Compression_CustomSettings
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AnimSet.TrackBoneNames>(Ptr + 116); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 116); }
    }

    /// <summary>
    /// ArrayProperty: TrackBoneNames
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.FString>>>>> TrackBoneNames
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.FString>>>>>>(Ptr + 124); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 124); }
    }

    /// <summary>
    /// ArrayProperty: Sequences
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.FString>>>> Sequences
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.FString>>>>>(Ptr + 140); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 140); }
    }

    /// <summary>
    /// MapProperty: SequenceCache
    /// </summary>
    public unsafe BmSDK.TMap<object, object> /* TODO */ SequenceCache
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TMap<object, object> /* TODO */>(Ptr + 156); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 156); }
    }

    /// <summary>
    /// ArrayProperty: LinkupCache
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.FString>>> LinkupCache
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.FString>>>>(Ptr + 228); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 228); }
    }

    /// <summary>
    /// MapProperty: SkelMesh2LinkupCache
    /// </summary>
    public unsafe BmSDK.TMap<object, object> /* TODO */ SkelMesh2LinkupCache
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TMap<object, object> /* TODO */>(Ptr + 244); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 244); }
    }

    /// <summary>
    /// NameProperty: PreviewExtraSkelMesh1Name
    /// </summary>
    public unsafe BmSDK.FName PreviewExtraSkelMesh1Name
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 316); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 316); }
    }

    /// <summary>
    /// NameProperty: PreviewExtraSkelMesh2Name
    /// </summary>
    public unsafe BmSDK.FName PreviewExtraSkelMesh2Name
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 324); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 324); }
    }

    /// <summary>
    /// NameProperty: PreviewExtraSkelMesh3Name
    /// </summary>
    public unsafe BmSDK.FName PreviewExtraSkelMesh3Name
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 332); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 332); }
    }

    /// <summary>
    /// IntProperty: PreviewMeshAutoUpdateVersion
    /// </summary>
    public unsafe int PreviewMeshAutoUpdateVersion
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 340); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 340); }
    }

    /// <summary>
    /// StructProperty: PreviewWeapon
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT PreviewWeapon
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 344); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 344); }
    }

    /// <summary>
    /// ArrayProperty: PreviewAttachments
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.TArray<BmSDK.FString>> PreviewAttachments
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.TArray<BmSDK.FString>>>(Ptr + 364); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 364); }
    }

    /// <summary>
    /// ArrayProperty: PreviewPartners2
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.FString> PreviewPartners2
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.FString>>(Ptr + 380); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 380); }
    }

    /// <summary>
    /// NameProperty: PreviewReferencePointMeshName
    /// </summary>
    public unsafe BmSDK.FName PreviewReferencePointMeshName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 396); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 396); }
    }

    /// <summary>
    /// NameProperty: BestRatioSkelMeshName
    /// </summary>
    public unsafe BmSDK.FName BestRatioSkelMeshName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 404); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 404); }
    }

    /// <summary>
    /// StrProperty: PreCookingPathName
    /// </summary>
    public unsafe BmSDK.FString PreCookingPathName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 412); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 412); }
    }

    /// <summary>
    /// ArrayProperty: AutoDeleteTracks
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.FString> AutoDeleteTracks
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.FString>>(Ptr + 428); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 428); }
    }

    /// <summary>
    /// StrProperty: LastSourceRootBoneName
    /// </summary>
    public unsafe BmSDK.FString LastSourceRootBoneName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 444); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 444); }
    }

    /// <summary>
    /// StructProperty: AnimSetViewerErrors
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT AnimSetViewerErrors
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 460); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 460); }
    }
}
