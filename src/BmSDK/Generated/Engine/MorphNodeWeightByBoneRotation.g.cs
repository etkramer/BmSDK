#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Class: MorphNodeWeightByBoneRotation<br/>
/// (size = 0)
/// (flags = 0)
/// </summary>
public partial class MorphNodeWeightByBoneRotation : BmSDK.Engine.MorphNodeWeightBase, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Engine.MorphNodeWeightByBoneRotation", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal MorphNodeWeightByBoneRotation() { }

    /// <summary>
    /// Constructs a new MorphNodeWeightByBoneRotation
    /// </summary>
    public MorphNodeWeightByBoneRotation(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, MorphNodeWeightByBoneRotation Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected MorphNodeWeightByBoneRotation(nint ptr) : base(ptr) { }

    /// <summary>
    /// FloatProperty: Angle
    /// </summary>
    public unsafe float Angle
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 156); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 156); }
    }

    /// <summary>
    /// FloatProperty: NodeWeight
    /// </summary>
    public unsafe float NodeWeight
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 160); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 160); }
    }

    /// <summary>
    /// NameProperty: BoneName
    /// </summary>
    public unsafe BmSDK.FName BoneName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 164); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 164); }
    }

    /// <summary>
    /// ByteProperty: BoneAxis
    /// </summary>
    public unsafe byte BoneAxis
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 172); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 172); }
    }

    /// <summary>
    /// BoolProperty: bInvertBoneAxis
    /// </summary>
    public unsafe bool bInvertBoneAxis
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 176) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 176); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 176); }
    }

    /// <summary>
    /// BoolProperty: bControlMaterialParameter
    /// </summary>
    public unsafe bool bControlMaterialParameter
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 176) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 176); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 176); }
    }

    /// <summary>
    /// ArrayProperty: WeightArray
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.TArray<BmSDK.FString>> WeightArray
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.TArray<BmSDK.FString>>>(Ptr + 180); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 180); }
    }

    /// <summary>
    /// IntProperty: MaterialSlotId
    /// </summary>
    public unsafe int MaterialSlotId
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 196); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 196); }
    }

    /// <summary>
    /// NameProperty: ScalarParameterName
    /// </summary>
    public unsafe BmSDK.FName ScalarParameterName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 200); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 200); }
    }

    /// <summary>
    /// ObjectProperty: MaterialInstanceConstant
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT MaterialInstanceConstant
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 208); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 208); }
    }
}
