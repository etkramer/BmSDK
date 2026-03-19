#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Class: SkelControlBase<br/>
/// (size = 0)
/// (flags = 0)
/// </summary>
public partial class SkelControlBase : BmSDK.Engine.AnimObject, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Engine.SkelControlBase", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal SkelControlBase() { }

    /// <summary>
    /// Constructs a new SkelControlBase
    /// </summary>
    public SkelControlBase(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, SkelControlBase Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected SkelControlBase(nint ptr) : base(ptr) { }

    /// <summary>
    /// NameProperty: ControlName
    /// </summary>
    public unsafe BmSDK.FName ControlName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 128); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 128); }
    }

    /// <summary>
    /// FloatProperty: ControlStrength
    /// </summary>
    public unsafe float ControlStrength
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 136); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 136); }
    }

    /// <summary>
    /// FloatProperty: BlendInTime
    /// </summary>
    public unsafe float BlendInTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 140); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 140); }
    }

    /// <summary>
    /// FloatProperty: BlendOutTime
    /// </summary>
    public unsafe float BlendOutTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 144); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 144); }
    }

    /// <summary>
    /// ByteProperty: BlendType
    /// </summary>
    public unsafe byte BlendType
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 148); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 148); }
    }

    /// <summary>
    /// BoolProperty: bPostPhysicsController
    /// </summary>
    public unsafe bool bPostPhysicsController
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 152) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 152); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 152); }
    }

    /// <summary>
    /// BoolProperty: bSetStrengthFromAnimNode
    /// </summary>
    public unsafe bool bSetStrengthFromAnimNode
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 152) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 152); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 152); }
    }

    /// <summary>
    /// BoolProperty: bInitializedCachedNodeList
    /// </summary>
    public unsafe bool bInitializedCachedNodeList
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 152) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 152); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 152); }
    }

    /// <summary>
    /// BoolProperty: bControlledByAnimMetada
    /// </summary>
    public unsafe bool bControlledByAnimMetada
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 152) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 152); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 152); }
    }

    /// <summary>
    /// BoolProperty: bInvertMetadataWeight
    /// </summary>
    public unsafe bool bInvertMetadataWeight
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 152) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 152); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 152); }
    }

    /// <summary>
    /// BoolProperty: bPropagateSetActive
    /// </summary>
    public unsafe bool bPropagateSetActive
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 152) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 152); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 152); }
    }

    /// <summary>
    /// BoolProperty: bIgnoreWhenNotRendered
    /// </summary>
    public unsafe bool bIgnoreWhenNotRendered
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 152) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 152); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 152); }
    }

    /// <summary>
    /// BoolProperty: bShouldTickInScript
    /// </summary>
    public unsafe bool bShouldTickInScript
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 152) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 152); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 152); }
    }

    /// <summary>
    /// BoolProperty: bShouldTickOwner
    /// </summary>
    public unsafe bool bShouldTickOwner
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 152) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 152); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 152); }
    }

    /// <summary>
    /// BoolProperty: bEnableEaseInOut
    /// </summary>
    public unsafe bool bEnableEaseInOut
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 152) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 152); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 152); }
    }

    /// <summary>
    /// BoolProperty: Localspace
    /// </summary>
    public unsafe bool Localspace
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 152) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 152); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 152); }
    }

    /// <summary>
    /// FloatProperty: StrengthTarget
    /// </summary>
    public unsafe float StrengthTarget
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 156); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 156); }
    }

    /// <summary>
    /// FloatProperty: BlendTimeToGo
    /// </summary>
    public unsafe float BlendTimeToGo
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 160); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 160); }
    }

    /// <summary>
    /// ArrayProperty: StrengthAnimNodeNameList
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.TArray<BmSDK.FString>> StrengthAnimNodeNameList
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.TArray<BmSDK.FString>>>(Ptr + 164); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 164); }
    }

    /// <summary>
    /// ArrayProperty: CachedNodeList
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.FString> CachedNodeList
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.FString>>(Ptr + 180); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 180); }
    }

    /// <summary>
    /// FloatProperty: AnimMetadataWeight
    /// </summary>
    public unsafe float AnimMetadataWeight
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 196); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 196); }
    }

    /// <summary>
    /// IntProperty: AnimMetaDataUpdateTag
    /// </summary>
    public unsafe int AnimMetaDataUpdateTag
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 200); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 200); }
    }

    /// <summary>
    /// FloatProperty: BoneScale
    /// </summary>
    public unsafe float BoneScale
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 204); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 204); }
    }

    /// <summary>
    /// IntProperty: ControlTickTag
    /// </summary>
    public unsafe int ControlTickTag
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 208); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 208); }
    }

    /// <summary>
    /// IntProperty: IgnoreAtOrAboveLOD
    /// </summary>
    public unsafe int IgnoreAtOrAboveLOD
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 212); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 212); }
    }

    /// <summary>
    /// ObjectProperty: NextControl
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT NextControl
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 216); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 216); }
    }

    /// <summary>
    /// IntProperty: ControlPosX
    /// </summary>
    public unsafe int ControlPosX
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 224); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 224); }
    }

    /// <summary>
    /// IntProperty: ControlPosY
    /// </summary>
    public unsafe int ControlPosY
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 228); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 228); }
    }

    /// <summary>
    /// StrProperty: InitErrors
    /// </summary>
    public unsafe BmSDK.FString InitErrors
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 232); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 232); }
    }

    /// <summary>
    /// Enum: EBoneControlSpace
    /// </summary>
    public enum EBoneControlSpace
    {
        BCS_WorldSpace = 0,
        BCS_ActorSpace = 1,
        BCS_ComponentSpace = 2,
        BCS_ParentBoneSpace = 3,
        BCS_BoneSpace = 4,
        BCS_BoneSpaceTranslationComponentSpaceRotation = 5,
        BCS_OtherBoneSpace = 6,
        BCS_BaseMeshSpace = 7,
        BCS_MAX = 8,
    }
}
