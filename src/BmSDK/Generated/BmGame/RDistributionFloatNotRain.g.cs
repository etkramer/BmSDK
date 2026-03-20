#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RDistributionFloatNotRain<br/>
/// (flags = 0)
/// </summary>
public partial class RDistributionFloatNotRain : BmSDK.BmGame.RDistributionFloatRain, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RDistributionFloatNotRain", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RDistributionFloatNotRain() { }

    /// <summary>
    /// Constructs a new RDistributionFloatNotRain
    /// </summary>
    public RDistributionFloatNotRain(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RDistributionFloatNotRain Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RDistributionFloatNotRain(nint ptr) : base(ptr) { }

    /// <summary>
    /// NameProperty: ParameterName
    /// </summary>
    public unsafe BmSDK.FName ParameterName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 116); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 116); }
    }

    /// <summary>
    /// FloatProperty: MinInput
    /// </summary>
    public unsafe float MinInput
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 124); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 124); }
    }

    /// <summary>
    /// FloatProperty: MaxInput
    /// </summary>
    public unsafe float MaxInput
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 128); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 128); }
    }

    /// <summary>
    /// FloatProperty: MinOutput
    /// </summary>
    public unsafe float MinOutput
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 132); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 132); }
    }

    /// <summary>
    /// FloatProperty: MaxOutput
    /// </summary>
    public unsafe float MaxOutput
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 136); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 136); }
    }

    /// <summary>
    /// ByteProperty: ParamMode
    /// </summary>
    public unsafe BmSDK.Engine.DistributionFloatParameterBase.DistributionParamMode ParamMode
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.DistributionFloatParameterBase.DistributionParamMode>(Ptr + 140); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 140); }
    }
}
