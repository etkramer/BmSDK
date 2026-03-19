#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Class: SkelControl_CCD_IK<br/>
/// (size = 0)
/// (flags = 0)
/// </summary>
public partial class SkelControl_CCD_IK : BmSDK.Engine.SkelControlBase, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Engine.SkelControl_CCD_IK", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal SkelControl_CCD_IK() { }

    /// <summary>
    /// Constructs a new SkelControl_CCD_IK
    /// </summary>
    public SkelControl_CCD_IK(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, SkelControl_CCD_IK Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected SkelControl_CCD_IK(nint ptr) : base(ptr) { }

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
    /// NameProperty: EffectorSpaceBoneName
    /// </summary>
    public unsafe BmSDK.FName EffectorSpaceBoneName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 264); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 264); }
    }

    /// <summary>
    /// StructProperty: EffectorTranslationFromBone
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT EffectorTranslationFromBone
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 272); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 272); }
    }

    /// <summary>
    /// IntProperty: NumBones
    /// </summary>
    public unsafe int NumBones
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 284); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 284); }
    }

    /// <summary>
    /// IntProperty: MaxPerBoneIterations
    /// </summary>
    public unsafe int MaxPerBoneIterations
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 288); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 288); }
    }

    /// <summary>
    /// IntProperty: IterationsCount
    /// </summary>
    public unsafe int IterationsCount
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 292); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 292); }
    }

    /// <summary>
    /// FloatProperty: Precision
    /// </summary>
    public unsafe float Precision
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 296); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 296); }
    }

    /// <summary>
    /// BoolProperty: bStartFromTail
    /// </summary>
    public unsafe bool bStartFromTail
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 300) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 300); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 300); }
    }

    /// <summary>
    /// BoolProperty: bNoTurnOptimization
    /// </summary>
    public unsafe bool bNoTurnOptimization
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 300) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 300); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 300); }
    }

    /// <summary>
    /// BoolProperty: ComponentOffsetEnabled
    /// </summary>
    public unsafe bool ComponentOffsetEnabled
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 300) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 300); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 300); }
    }

    /// <summary>
    /// ArrayProperty: AngleConstraint
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.FString>>> AngleConstraint
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.TArray<BmSDK.TArray<BmSDK.FString>>>>(Ptr + 304); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 304); }
    }

    /// <summary>
    /// FloatProperty: MaxAngleSteps
    /// </summary>
    public unsafe float MaxAngleSteps
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 320); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 320); }
    }

    /// <summary>
    /// IntProperty: IgnoreNumBones
    /// </summary>
    public unsafe int IgnoreNumBones
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 324); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 324); }
    }

    /// <summary>
    /// StructProperty: ComponentOffset
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT ComponentOffset
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 336); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 336); }
    }
}
