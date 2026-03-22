#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Class: DistributionFloatUniform<br/>
/// (size = 72)
/// (flags = 134230162)
/// </summary>
public partial class DistributionFloatUniform : BmSDK.DistributionFloat, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Engine.DistributionFloatUniform", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal DistributionFloatUniform() { }

    /// <summary>
    /// Constructs a new DistributionFloatUniform
    /// </summary>
    public DistributionFloatUniform(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, DistributionFloatUniform Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected DistributionFloatUniform(nint ptr) : base(ptr) { }

    /// <summary>
    /// FloatProperty: Min
    /// </summary>
    public unsafe float Min
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 64); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 64); }
    }

    /// <summary>
    /// FloatProperty: Max
    /// </summary>
    public unsafe float Max
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 68); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 68); }
    }
}
