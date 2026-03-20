#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RDistributionVectorNotRain<br/>
/// (size = 0)
/// (flags = 0)
/// </summary>
public partial class RDistributionVectorNotRain : BmSDK.BmGame.RDistributionVectorRain, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RDistributionVectorNotRain", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RDistributionVectorNotRain() { }

    /// <summary>
    /// Constructs a new RDistributionVectorNotRain
    /// </summary>
    public RDistributionVectorNotRain(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RDistributionVectorNotRain Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RDistributionVectorNotRain(nint ptr) : base(ptr) { }

    /// <summary>
    /// NameProperty: ParameterName
    /// </summary>
    public unsafe BmSDK.FName ParameterName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 132); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 132); }
    }

    /// <summary>
    /// StructProperty: MinInput
    /// </summary>
    public unsafe System.Numerics.Vector3 MinInput
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 140); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 140); }
    }

    /// <summary>
    /// StructProperty: MaxInput
    /// </summary>
    public unsafe System.Numerics.Vector3 MaxInput
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 152); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 152); }
    }

    /// <summary>
    /// StructProperty: MinOutput
    /// </summary>
    public unsafe System.Numerics.Vector3 MinOutput
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 164); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 164); }
    }

    /// <summary>
    /// StructProperty: MaxOutput
    /// </summary>
    public unsafe System.Numerics.Vector3 MaxOutput
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 176); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 176); }
    }

    /// <summary>
    /// ByteProperty: ParamModes
    /// </summary>
    public unsafe BmSDK.Engine.DistributionFloatParameterBase.DistributionParamMode ParamModes_0
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.DistributionFloatParameterBase.DistributionParamMode>(Ptr + 188); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 188); }
    }
    /// <summary>
    /// ByteProperty: ParamModes
    /// </summary>
    public unsafe BmSDK.Engine.DistributionFloatParameterBase.DistributionParamMode ParamModes_1
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.DistributionFloatParameterBase.DistributionParamMode>(Ptr + 189); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 189); }
    }
    /// <summary>
    /// ByteProperty: ParamModes
    /// </summary>
    public unsafe BmSDK.Engine.DistributionFloatParameterBase.DistributionParamMode ParamModes_2
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.DistributionFloatParameterBase.DistributionParamMode>(Ptr + 190); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 190); }
    }
}
