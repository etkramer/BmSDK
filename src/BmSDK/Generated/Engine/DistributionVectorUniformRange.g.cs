#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Class: DistributionVectorUniformRange<br/>
/// (size = 0)
/// (flags = 0)
/// </summary>
public partial class DistributionVectorUniformRange : BmSDK.DistributionVector, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Engine.DistributionVectorUniformRange", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal DistributionVectorUniformRange() { }

    /// <summary>
    /// Constructs a new DistributionVectorUniformRange
    /// </summary>
    public DistributionVectorUniformRange(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, DistributionVectorUniformRange Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected DistributionVectorUniformRange(nint ptr) : base(ptr) { }

    /// <summary>
    /// StructProperty: MaxHigh
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT MaxHigh
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 112); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 112); }
    }

    /// <summary>
    /// StructProperty: MaxLow
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT MaxLow
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 124); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 124); }
    }

    /// <summary>
    /// StructProperty: MinHigh
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT MinHigh
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 136); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 136); }
    }

    /// <summary>
    /// StructProperty: MinLow
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT MinLow
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 148); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 148); }
    }
}
