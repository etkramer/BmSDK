#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Class: SplineComponent<br/>
/// (flags = 0)
/// </summary>
public partial class SplineComponent : BmSDK.Engine.PrimitiveComponent, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Engine.SplineComponent", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal SplineComponent() { }

    /// <summary>
    /// Constructs a new SplineComponent
    /// </summary>
    public SplineComponent(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, SplineComponent Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected SplineComponent(nint ptr) : base(ptr) { }

    /// <summary>
    /// StructProperty: SplineInfo
    /// </summary>
    public unsafe BmSDK.GameObject.FInterpCurveVector SplineInfo
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.GameObject.FInterpCurveVector>(Ptr + 540); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 540); }
    }

    /// <summary>
    /// FloatProperty: SplineCurviness
    /// </summary>
    public unsafe float SplineCurviness
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 560); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 560); }
    }

    /// <summary>
    /// StructProperty: SplineColor
    /// </summary>
    public unsafe BmSDK.GameObject.FColor SplineColor
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.GameObject.FColor>(Ptr + 564); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 564); }
    }

    /// <summary>
    /// FloatProperty: SplineDrawRes
    /// </summary>
    public unsafe float SplineDrawRes
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 568); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 568); }
    }

    /// <summary>
    /// FloatProperty: SplineArrowSize
    /// </summary>
    public unsafe float SplineArrowSize
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 572); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 572); }
    }

    /// <summary>
    /// BoolProperty: bSplineDisabled
    /// </summary>
    public unsafe bool bSplineDisabled
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 576) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 576); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 576); }
    }

    /// <summary>
    /// StructProperty: SplineReparamTable
    /// </summary>
    public unsafe BmSDK.GameObject.FInterpCurveFloat SplineReparamTable
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.GameObject.FInterpCurveFloat>(Ptr + 580); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 580); }
    }

    /// <summary>
    /// StructProperty: ParamToAbsDistTable
    /// </summary>
    public unsafe BmSDK.GameObject.FInterpCurveFloat ParamToAbsDistTable
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.GameObject.FInterpCurveFloat>(Ptr + 600); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 600); }
    }
}
