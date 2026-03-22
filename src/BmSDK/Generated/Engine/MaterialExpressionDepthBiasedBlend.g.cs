#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Class: MaterialExpressionDepthBiasedBlend<br/>
/// (size = 184)
/// (flags = 134226066)
/// </summary>
public partial class MaterialExpressionDepthBiasedBlend : BmSDK.Engine.MaterialExpression, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Engine.MaterialExpressionDepthBiasedBlend", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal MaterialExpressionDepthBiasedBlend() { }

    /// <summary>
    /// Constructs a new MaterialExpressionDepthBiasedBlend
    /// </summary>
    public MaterialExpressionDepthBiasedBlend(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, MaterialExpressionDepthBiasedBlend Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected MaterialExpressionDepthBiasedBlend(nint ptr) : base(ptr) { }

    /// <summary>
    /// BoolProperty: bNormalize
    /// </summary>
    public unsafe bool bNormalize
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 92) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 92); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 92); }
    }

    /// <summary>
    /// FloatProperty: BiasScale
    /// </summary>
    public unsafe float BiasScale
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 96); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 96); }
    }

    /// <summary>
    /// StructProperty: RGB
    /// </summary>
    public unsafe BmSDK.Engine.MaterialExpression.FExpressionInput RGB
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.MaterialExpression.FExpressionInput>(Ptr + 100); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 100); }
    }

    /// <summary>
    /// StructProperty: Alpha
    /// </summary>
    public unsafe BmSDK.Engine.MaterialExpression.FExpressionInput Alpha
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.MaterialExpression.FExpressionInput>(Ptr + 128); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 128); }
    }

    /// <summary>
    /// StructProperty: Bias
    /// </summary>
    public unsafe BmSDK.Engine.MaterialExpression.FExpressionInput Bias
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.MaterialExpression.FExpressionInput>(Ptr + 156); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 156); }
    }
}
