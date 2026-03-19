#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Class: MaterialExpressionReliefMappingParameter<br/>
/// (size = 0)
/// (flags = 0)
/// </summary>
public partial class MaterialExpressionReliefMappingParameter : BmSDK.Engine.MaterialExpressionTextureSampleParameter, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Engine.MaterialExpressionReliefMappingParameter", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal MaterialExpressionReliefMappingParameter() { }

    /// <summary>
    /// Constructs a new MaterialExpressionReliefMappingParameter
    /// </summary>
    public MaterialExpressionReliefMappingParameter(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, MaterialExpressionReliefMappingParameter Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected MaterialExpressionReliefMappingParameter(nint ptr) : base(ptr) { }

    /// <summary>
    /// StructProperty: HeightMapUV
    /// </summary>
    public unsafe BmSDK.Engine.MaterialExpressionReliefMappingParameter.HeightMul HeightMapUV
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.MaterialExpressionReliefMappingParameter.HeightMul>(Ptr + 316); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 316); }
    }

    /// <summary>
    /// StructProperty: HeightMul
    /// </summary>
    public unsafe BmSDK.Engine.MaterialExpressionTextureSample.Coordinates HeightMul
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.MaterialExpressionTextureSample.Coordinates>(Ptr + 368); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 368); }
    }

    /// <summary>
    /// ByteProperty: HeightTextureChannel
    /// </summary>
    public unsafe byte HeightTextureChannel
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 420); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 420); }
    }

    /// <summary>
    /// FloatProperty: HeightMultiplier
    /// </summary>
    public unsafe float HeightMultiplier
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 424); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 424); }
    }

    /// <summary>
    /// IntProperty: LSteps
    /// </summary>
    public unsafe int LSteps
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 428); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 428); }
    }

    /// <summary>
    /// BoolProperty: bOffsetLimiting
    /// </summary>
    public unsafe bool bOffsetLimiting
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 432) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 432); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 432); }
    }

    /// <summary>
    /// BoolProperty: bOutputOffsetsOnly
    /// </summary>
    public unsafe bool bOutputOffsetsOnly
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 432) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 432); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 432); }
    }
}
