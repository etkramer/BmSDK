#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Class: DistributionFloatUniformRange<br/>
/// (size = 0)
/// (flags = 0)
/// </summary>
public partial class DistributionFloatUniformRange : BmSDK.DistributionFloat, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Engine.DistributionFloatUniformRange", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal DistributionFloatUniformRange() { }

    /// <summary>
    /// Constructs a new DistributionFloatUniformRange
    /// </summary>
    public DistributionFloatUniformRange(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, DistributionFloatUniformRange Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected DistributionFloatUniformRange(nint ptr) : base(ptr) { }

    /// <summary>
    /// FloatProperty: MaxHigh
    /// </summary>
    public unsafe float MaxHigh
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 112); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 112); }
    }

    /// <summary>
    /// FloatProperty: MaxLow
    /// </summary>
    public unsafe float MaxLow
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 116); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 116); }
    }

    /// <summary>
    /// FloatProperty: MinHigh
    /// </summary>
    public unsafe float MinHigh
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 120); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 120); }
    }

    /// <summary>
    /// FloatProperty: MinLow
    /// </summary>
    public unsafe float MinLow
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 124); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 124); }
    }

    /// <summary>
    /// BoolProperty: bMirrorMaxMin
    /// </summary>
    public unsafe bool bMirrorMaxMin
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 128) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 128); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 128); }
    }
}
