#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Class: DistributionFloatConstantCurve<br/>
/// (size = 80)
/// (flags = 134230162)
/// </summary>
public partial class DistributionFloatConstantCurve : BmSDK.DistributionFloat, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Engine.DistributionFloatConstantCurve", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal DistributionFloatConstantCurve() { }

    /// <summary>
    /// Constructs a new DistributionFloatConstantCurve
    /// </summary>
    public DistributionFloatConstantCurve(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, DistributionFloatConstantCurve Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected DistributionFloatConstantCurve(nint ptr) : base(ptr) { }

    /// <summary>
    /// StructProperty: ConstantCurve
    /// </summary>
    public unsafe BmSDK.GameObject.FInterpCurveFloat ConstantCurve
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.GameObject.FInterpCurveFloat>(Ptr + 64); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 64); }
    }
}
