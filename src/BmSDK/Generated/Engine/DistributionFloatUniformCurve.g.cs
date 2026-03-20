#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Class: DistributionFloatUniformCurve<br/>
/// (flags = 0)
/// </summary>
public partial class DistributionFloatUniformCurve : BmSDK.DistributionFloat, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Engine.DistributionFloatUniformCurve", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal DistributionFloatUniformCurve() { }

    /// <summary>
    /// Constructs a new DistributionFloatUniformCurve
    /// </summary>
    public DistributionFloatUniformCurve(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, DistributionFloatUniformCurve Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected DistributionFloatUniformCurve(nint ptr) : base(ptr) { }

    /// <summary>
    /// StructProperty: ConstantCurve
    /// </summary>
    public unsafe BmSDK.GameObject.FInterpCurveVector2D ConstantCurve
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.GameObject.FInterpCurveVector2D>(Ptr + 112); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 112); }
    }
}
