#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Class: MaterialExpressionAlphaFader<br/>
/// (size = 0)
/// (flags = 0)
/// </summary>
public partial class MaterialExpressionAlphaFader : BmSDK.Engine.MaterialExpression, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Engine.MaterialExpressionAlphaFader", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal MaterialExpressionAlphaFader() { }

    /// <summary>
    /// Constructs a new MaterialExpressionAlphaFader
    /// </summary>
    public MaterialExpressionAlphaFader(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, MaterialExpressionAlphaFader Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected MaterialExpressionAlphaFader(nint ptr) : base(ptr) { }

    /// <summary>
    /// StructProperty: AlphaIn
    /// </summary>
    public unsafe BmSDK.Engine.MaterialExpressionAlphaFader.Bias AlphaIn
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.MaterialExpressionAlphaFader.Bias>(Ptr + 172); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 172); }
    }

    /// <summary>
    /// StructProperty: Bias
    /// </summary>
    public unsafe BmSDK.Engine.MaterialExpression.Desc Bias
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.MaterialExpression.Desc>(Ptr + 224); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 224); }
    }

    /// <summary>
    /// BoolProperty: bNormalize
    /// </summary>
    public unsafe bool bNormalize
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 276) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 276); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 276); }
    }

    /// <summary>
    /// BoolProperty: DistanceFade
    /// </summary>
    public unsafe bool DistanceFade
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 276) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 276); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 276); }
    }

    /// <summary>
    /// BoolProperty: AngularFade
    /// </summary>
    public unsafe bool AngularFade
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 276) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 276); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 276); }
    }

    /// <summary>
    /// BoolProperty: AngularFade_Invert
    /// </summary>
    public unsafe bool AngularFade_Invert
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 276) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 276); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 276); }
    }

    /// <summary>
    /// BoolProperty: DepthCompareFade
    /// </summary>
    public unsafe bool DepthCompareFade
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 276) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 276); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 276); }
    }

    /// <summary>
    /// BoolProperty: DepthCompareFade_Invert
    /// </summary>
    public unsafe bool DepthCompareFade_Invert
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 276) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 276); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 276); }
    }

    /// <summary>
    /// FloatProperty: DistanceFade_Start
    /// </summary>
    public unsafe float DistanceFade_Start
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 280); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 280); }
    }

    /// <summary>
    /// FloatProperty: DistanceFade_End
    /// </summary>
    public unsafe float DistanceFade_End
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 284); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 284); }
    }

    /// <summary>
    /// FloatProperty: AngularFade_Power
    /// </summary>
    public unsafe float AngularFade_Power
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 288); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 288); }
    }

    /// <summary>
    /// FloatProperty: BiasScale
    /// </summary>
    public unsafe float BiasScale
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 292); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 292); }
    }
}
