#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Class: AkActionGlobal_Parameter_Altitude<br/>
/// (size = 0)
/// (flags = 0)
/// </summary>
public partial class AkActionGlobal_Parameter_Altitude : BmSDK.Engine.AkActionGlobal, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Engine.AkActionGlobal_Parameter_Altitude", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal AkActionGlobal_Parameter_Altitude() { }

    /// <summary>
    /// Constructs a new AkActionGlobal_Parameter_Altitude
    /// </summary>
    public AkActionGlobal_Parameter_Altitude(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, AkActionGlobal_Parameter_Altitude Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected AkActionGlobal_Parameter_Altitude(nint ptr) : base(ptr) { }

    /// <summary>
    /// ObjectProperty: AltitudeParameter
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT AltitudeParameter
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 148); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 148); }
    }

    /// <summary>
    /// FloatProperty: InterpolationTime
    /// </summary>
    public unsafe float InterpolationTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 156); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 156); }
    }

    /// <summary>
    /// FloatProperty: Highest
    /// </summary>
    public unsafe float Highest
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 160); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 160); }
    }

    /// <summary>
    /// FloatProperty: Lowest
    /// </summary>
    public unsafe float Lowest
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 164); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 164); }
    }

    /// <summary>
    /// FloatProperty: TargetParamValue
    /// </summary>
    public unsafe float TargetParamValue
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 168); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 168); }
    }

    /// <summary>
    /// FloatProperty: CurrentParamValue
    /// </summary>
    public unsafe float CurrentParamValue
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 172); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 172); }
    }

    /// <summary>
    /// FloatProperty: CurrentParamVelocity
    /// </summary>
    public unsafe float CurrentParamVelocity
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 176); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 176); }
    }

    /// <summary>
    /// StructProperty: ParamUpdateTime
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT ParamUpdateTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 180); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 180); }
    }
}
