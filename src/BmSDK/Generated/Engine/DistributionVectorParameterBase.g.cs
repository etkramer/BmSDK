#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// ABSTRACT Class: DistributionVectorParameterBase<br/>
/// (size = 143)
/// (flags = 142618771)
/// </summary>
public partial class DistributionVectorParameterBase : BmSDK.Engine.DistributionVectorConstant, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Engine.DistributionVectorParameterBase", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal DistributionVectorParameterBase() { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected DistributionVectorParameterBase(nint ptr) : base(ptr) { }

    /// <summary>
    /// NameProperty: ParameterName
    /// </summary>
    public unsafe BmSDK.FName ParameterName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 84); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 84); }
    }

    /// <summary>
    /// StructProperty: MinInput
    /// </summary>
    public unsafe System.Numerics.Vector3 MinInput
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 92); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 92); }
    }

    /// <summary>
    /// StructProperty: MaxInput
    /// </summary>
    public unsafe System.Numerics.Vector3 MaxInput
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 104); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 104); }
    }

    /// <summary>
    /// StructProperty: MinOutput
    /// </summary>
    public unsafe System.Numerics.Vector3 MinOutput
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 116); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 116); }
    }

    /// <summary>
    /// StructProperty: MaxOutput
    /// </summary>
    public unsafe System.Numerics.Vector3 MaxOutput
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 128); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 128); }
    }

    /// <summary>
    /// ByteProperty: ParamModes
    /// </summary>
    public unsafe BmSDK.Engine.DistributionFloatParameterBase.DistributionParamMode ParamModes_0
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.DistributionFloatParameterBase.DistributionParamMode>(Ptr + 140); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 140); }
    }
    /// <summary>
    /// ByteProperty: ParamModes
    /// </summary>
    public unsafe BmSDK.Engine.DistributionFloatParameterBase.DistributionParamMode ParamModes_1
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.DistributionFloatParameterBase.DistributionParamMode>(Ptr + 141); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 141); }
    }
    /// <summary>
    /// ByteProperty: ParamModes
    /// </summary>
    public unsafe BmSDK.Engine.DistributionFloatParameterBase.DistributionParamMode ParamModes_2
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.DistributionFloatParameterBase.DistributionParamMode>(Ptr + 142); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 142); }
    }
}
