#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Class: SkelControlLimb<br/>
/// (size = 0)
/// (flags = 0)
/// </summary>
public partial class SkelControlLimb : BmSDK.Engine.SkelControlBase, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Engine.SkelControlLimb", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal SkelControlLimb() { }

    /// <summary>
    /// Constructs a new SkelControlLimb
    /// </summary>
    public SkelControlLimb(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, SkelControlLimb Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected SkelControlLimb(nint ptr) : base(ptr) { }

    /// <summary>
    /// StructProperty: EffectorLocation
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT EffectorLocation
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 248); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 248); }
    }

    /// <summary>
    /// ByteProperty: EffectorLocationSpace
    /// </summary>
    public unsafe byte EffectorLocationSpace
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 260); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 260); }
    }

    /// <summary>
    /// ByteProperty: JointTargetLocationSpace
    /// </summary>
    public unsafe byte JointTargetLocationSpace
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 261); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 261); }
    }

    /// <summary>
    /// ByteProperty: JointOffsetSpace
    /// </summary>
    public unsafe byte JointOffsetSpace
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 262); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 262); }
    }

    /// <summary>
    /// ByteProperty: BoneAxis
    /// </summary>
    public unsafe byte BoneAxis
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 263); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 263); }
    }

    /// <summary>
    /// ByteProperty: JointAxis
    /// </summary>
    public unsafe byte JointAxis
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 264); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 264); }
    }

    /// <summary>
    /// NameProperty: EffectorSpaceBoneName
    /// </summary>
    public unsafe BmSDK.FName EffectorSpaceBoneName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 268); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 268); }
    }

    /// <summary>
    /// StructProperty: JointTargetLocation
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT JointTargetLocation
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 276); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 276); }
    }

    /// <summary>
    /// NameProperty: JointTargetSpaceBoneName
    /// </summary>
    public unsafe BmSDK.FName JointTargetSpaceBoneName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 288); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 288); }
    }

    /// <summary>
    /// StructProperty: JointOffset
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT JointOffset
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 296); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 296); }
    }

    /// <summary>
    /// NameProperty: JointOffsetBoneName
    /// </summary>
    public unsafe BmSDK.FName JointOffsetBoneName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 308); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 308); }
    }

    /// <summary>
    /// BoolProperty: bInvertBoneAxis
    /// </summary>
    public unsafe bool bInvertBoneAxis
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 316) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 316); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 316); }
    }

    /// <summary>
    /// BoolProperty: bInvertJointAxis
    /// </summary>
    public unsafe bool bInvertJointAxis
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 316) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 316); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 316); }
    }

    /// <summary>
    /// BoolProperty: bRotateJoint
    /// </summary>
    public unsafe bool bRotateJoint
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 316) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 316); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 316); }
    }

    /// <summary>
    /// BoolProperty: bMaintainEffectorRelRot
    /// </summary>
    public unsafe bool bMaintainEffectorRelRot
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 316) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 316); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 316); }
    }

    /// <summary>
    /// BoolProperty: bTakeRotationFromEffectorSpace
    /// </summary>
    public unsafe bool bTakeRotationFromEffectorSpace
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 316) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 316); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 316); }
    }

    /// <summary>
    /// BoolProperty: bAllowStretching
    /// </summary>
    public unsafe bool bAllowStretching
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 316) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 316); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 316); }
    }

    /// <summary>
    /// StructProperty: StretchLimits
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT StretchLimits
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 320); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 320); }
    }

    /// <summary>
    /// NameProperty: StretchRollBoneName
    /// </summary>
    public unsafe BmSDK.FName StretchRollBoneName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 328); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 328); }
    }
}
