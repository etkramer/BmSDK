#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Class: SkelControlSingleBone<br/>
/// (size = 0)
/// (flags = 0)
/// </summary>
public partial class SkelControlSingleBone : BmSDK.Engine.SkelControlBase, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Engine.SkelControlSingleBone", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal SkelControlSingleBone() { }

    /// <summary>
    /// Constructs a new SkelControlSingleBone
    /// </summary>
    public SkelControlSingleBone(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, SkelControlSingleBone Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected SkelControlSingleBone(nint ptr) : base(ptr) { }

    /// <summary>
    /// BoolProperty: bApplyTranslation
    /// </summary>
    public unsafe bool bApplyTranslation
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 248) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 248); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 248); }
    }

    /// <summary>
    /// BoolProperty: bApplyRotation
    /// </summary>
    public unsafe bool bApplyRotation
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 248) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 248); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 248); }
    }

    /// <summary>
    /// BoolProperty: bAddTranslation
    /// </summary>
    public unsafe bool bAddTranslation
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 248) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 248); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 248); }
    }

    /// <summary>
    /// BoolProperty: bAddRotation
    /// </summary>
    public unsafe bool bAddRotation
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 248) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 248); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 248); }
    }

    /// <summary>
    /// BoolProperty: bRemoveMeshRotation
    /// </summary>
    public unsafe bool bRemoveMeshRotation
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 248) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 248); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 248); }
    }

    /// <summary>
    /// StructProperty: BoneTranslation
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT BoneTranslation
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 252); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 252); }
    }

    /// <summary>
    /// ByteProperty: BoneTranslationSpace
    /// </summary>
    public unsafe byte BoneTranslationSpace
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 264); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 264); }
    }

    /// <summary>
    /// ByteProperty: BoneRotationSpace
    /// </summary>
    public unsafe byte BoneRotationSpace
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 265); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 265); }
    }

    /// <summary>
    /// NameProperty: TranslationSpaceBoneName
    /// </summary>
    public unsafe BmSDK.FName TranslationSpaceBoneName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 268); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 268); }
    }

    /// <summary>
    /// StructProperty: BoneRotation
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT BoneRotation
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 276); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 276); }
    }

    /// <summary>
    /// NameProperty: RotationSpaceBoneName
    /// </summary>
    public unsafe BmSDK.FName RotationSpaceBoneName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 288); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 288); }
    }
}
