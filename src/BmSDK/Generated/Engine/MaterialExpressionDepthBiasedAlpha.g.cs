#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Class: MaterialExpressionDepthBiasedAlpha<br/>
/// (size = 0)
/// (flags = 0)
/// </summary>
public partial class MaterialExpressionDepthBiasedAlpha : BmSDK.Engine.MaterialExpression, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Engine.MaterialExpressionDepthBiasedAlpha", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal MaterialExpressionDepthBiasedAlpha() { }

    /// <summary>
    /// Constructs a new MaterialExpressionDepthBiasedAlpha
    /// </summary>
    public MaterialExpressionDepthBiasedAlpha(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, MaterialExpressionDepthBiasedAlpha Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected MaterialExpressionDepthBiasedAlpha(nint ptr) : base(ptr) { }

    /// <summary>
    /// BoolProperty: bNormalize
    /// </summary>
    public unsafe bool bNormalize
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 172) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 172); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 172); }
    }

    /// <summary>
    /// FloatProperty: BiasScale
    /// </summary>
    public unsafe float BiasScale
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 176); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 176); }
    }

    /// <summary>
    /// StructProperty: Alpha
    /// </summary>
    public unsafe BmSDK.Engine.MaterialExpressionDepthBiasedAlpha.Bias Alpha
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.MaterialExpressionDepthBiasedAlpha.Bias>(Ptr + 180); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 180); }
    }

    /// <summary>
    /// StructProperty: Bias
    /// </summary>
    public unsafe BmSDK.Engine.MaterialExpression.Desc Bias
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.MaterialExpression.Desc>(Ptr + 232); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 232); }
    }
}
