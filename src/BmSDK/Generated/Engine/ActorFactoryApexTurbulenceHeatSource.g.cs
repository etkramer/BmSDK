#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Class: ActorFactoryApexTurbulenceHeatSource<br/>
/// (size = 0)
/// (flags = 0)
/// </summary>
public partial class ActorFactoryApexTurbulenceHeatSource : BmSDK.Engine.ActorFactory, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Engine.ActorFactoryApexTurbulenceHeatSource", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal ActorFactoryApexTurbulenceHeatSource() { }

    /// <summary>
    /// Constructs a new ActorFactoryApexTurbulenceHeatSource
    /// </summary>
    public ActorFactoryApexTurbulenceHeatSource(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, ActorFactoryApexTurbulenceHeatSource Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected ActorFactoryApexTurbulenceHeatSource(nint ptr) : base(ptr) { }

    /// <summary>
    /// FloatProperty: TemperatureAverage
    /// </summary>
    public unsafe float TemperatureAverage
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 144); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 144); }
    }

    /// <summary>
    /// FloatProperty: TemperatureDeviation
    /// </summary>
    public unsafe float TemperatureDeviation
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 148); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 148); }
    }

    /// <summary>
    /// FloatProperty: Radius
    /// </summary>
    public unsafe float Radius
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 152); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 152); }
    }

    /// <summary>
    /// ByteProperty: GeometryType
    /// </summary>
    public unsafe byte GeometryType
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 156); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 156); }
    }

    /// <summary>
    /// StructProperty: Extents
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT Extents
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 160); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 160); }
    }
}
