#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Class: MaterialExpressionReliefMapping<br/>
/// (size = 0)
/// (flags = 0)
/// </summary>
public partial class MaterialExpressionReliefMapping : BmSDK.Engine.MaterialExpression, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Engine.MaterialExpressionReliefMapping", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal MaterialExpressionReliefMapping() { }

    /// <summary>
    /// Constructs a new MaterialExpressionReliefMapping
    /// </summary>
    public MaterialExpressionReliefMapping(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, MaterialExpressionReliefMapping Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected MaterialExpressionReliefMapping(nint ptr) : base(ptr) { }

    /// <summary>
    /// StructProperty: UV
    /// </summary>
    public unsafe BmSDK.Engine.MaterialExpressionReliefMapping.HeightMapUV UV
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.MaterialExpressionReliefMapping.HeightMapUV>(Ptr + 172); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 172); }
    }

    /// <summary>
    /// StructProperty: HeightMapUV
    /// </summary>
    public unsafe BmSDK.Engine.MaterialExpressionReliefMapping.HeightMul HeightMapUV
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.MaterialExpressionReliefMapping.HeightMul>(Ptr + 224); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 224); }
    }

    /// <summary>
    /// StructProperty: HeightMul
    /// </summary>
    public unsafe BmSDK.Engine.MaterialExpression.Desc HeightMul
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.MaterialExpression.Desc>(Ptr + 276); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 276); }
    }

    /// <summary>
    /// ObjectProperty: HeightTexture
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT HeightTexture
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 328); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 328); }
    }

    /// <summary>
    /// ByteProperty: HeightTextureChannel
    /// </summary>
    public unsafe byte HeightTextureChannel
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 336); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 336); }
    }

    /// <summary>
    /// FloatProperty: HeightMultiplier
    /// </summary>
    public unsafe float HeightMultiplier
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 340); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 340); }
    }

    /// <summary>
    /// IntProperty: LSteps
    /// </summary>
    public unsafe int LSteps
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 344); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 344); }
    }

    /// <summary>
    /// BoolProperty: bOffsetLimiting
    /// </summary>
    public unsafe bool bOffsetLimiting
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 348) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 348); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 348); }
    }

    /// <summary>
    /// BoolProperty: bOutputOffsetsOnly
    /// </summary>
    public unsafe bool bOutputOffsetsOnly
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 348) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 348); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 348); }
    }
}
