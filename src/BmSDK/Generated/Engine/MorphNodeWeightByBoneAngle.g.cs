#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Class: MorphNodeWeightByBoneAngle<br/>
/// (size = 0)
/// (flags = 0)
/// </summary>
public partial class MorphNodeWeightByBoneAngle : BmSDK.Engine.MorphNodeWeightBase, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Engine.MorphNodeWeightByBoneAngle", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal MorphNodeWeightByBoneAngle() { }

    /// <summary>
    /// Constructs a new MorphNodeWeightByBoneAngle
    /// </summary>
    public MorphNodeWeightByBoneAngle(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, MorphNodeWeightByBoneAngle Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected MorphNodeWeightByBoneAngle(nint ptr) : base(ptr) { }

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
    /// NameProperty: BaseBoneName
    /// </summary>
    public unsafe BmSDK.FName BaseBoneName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 164); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 164); }
    }

    /// <summary>
    /// ByteProperty: BaseBoneAxis
    /// </summary>
    public unsafe byte BaseBoneAxis
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 172); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 172); }
    }

    /// <summary>
    /// ByteProperty: AngleBoneAxis
    /// </summary>
    public unsafe byte AngleBoneAxis
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 173); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 173); }
    }

    /// <summary>
    /// BoolProperty: bInvertBaseBoneAxis
    /// </summary>
    public unsafe bool bInvertBaseBoneAxis
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 176) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 176); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 176); }
    }

    /// <summary>
    /// BoolProperty: bInvertAngleBoneAxis
    /// </summary>
    public unsafe bool bInvertAngleBoneAxis
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
    /// NameProperty: AngleBoneName
    /// </summary>
    public unsafe BmSDK.FName AngleBoneName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 180); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 180); }
    }

    /// <summary>
    /// IntProperty: MaterialSlotId
    /// </summary>
    public unsafe int MaterialSlotId
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 188); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 188); }
    }

    /// <summary>
    /// NameProperty: ScalarParameterName
    /// </summary>
    public unsafe BmSDK.FName ScalarParameterName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 192); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 192); }
    }

    /// <summary>
    /// ObjectProperty: MaterialInstanceConstant
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT MaterialInstanceConstant
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 200); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 200); }
    }

    /// <summary>
    /// ArrayProperty: WeightArray
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.TArray<BmSDK.FString>> WeightArray
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.TArray<BmSDK.FString>>>(Ptr + 208); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 208); }
    }
}
