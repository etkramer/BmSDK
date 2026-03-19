#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Class: DistributionVectorRain<br/>
/// (size = 0)
/// (flags = 0)
/// </summary>
public partial class DistributionVectorRain : BmSDK.Engine.DistributionVectorParameterBase, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Engine.DistributionVectorRain", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal DistributionVectorRain() { }

    /// <summary>
    /// Constructs a new DistributionVectorRain
    /// </summary>
    public DistributionVectorRain(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, DistributionVectorRain Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected DistributionVectorRain(nint ptr) : base(ptr) { }

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
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT MinInput
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 140); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 140); }
    }

    /// <summary>
    /// StructProperty: MaxInput
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT MaxInput
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 152); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 152); }
    }

    /// <summary>
    /// StructProperty: MinOutput
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT MinOutput
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 164); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 164); }
    }

    /// <summary>
    /// StructProperty: MaxOutput
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT MaxOutput
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 176); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 176); }
    }

    /// <summary>
    /// ByteProperty: ParamModes
    /// </summary>
    public unsafe byte ParamModes_0
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 188); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 188); }
    }
    /// <summary>
    /// ByteProperty: ParamModes
    /// </summary>
    public unsafe byte ParamModes_1
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 189); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 189); }
    }
    /// <summary>
    /// ByteProperty: ParamModes
    /// </summary>
    public unsafe byte ParamModes_2
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 190); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 190); }
    }
}
