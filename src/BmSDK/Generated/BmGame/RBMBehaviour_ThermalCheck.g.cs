#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RBMBehaviour_ThermalCheck<br/>
/// (size = 0)
/// (flags = 0)
/// </summary>
public partial class RBMBehaviour_ThermalCheck : BmSDK.BmGame.RBMBehaviour_ActionQueue, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RBMBehaviour_ThermalCheck", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RBMBehaviour_ThermalCheck() { }

    /// <summary>
    /// Constructs a new RBMBehaviour_ThermalCheck
    /// </summary>
    public RBMBehaviour_ThermalCheck(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RBMBehaviour_ThermalCheck Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RBMBehaviour_ThermalCheck(nint ptr) : base(ptr) { }

    /// <summary>
    /// ObjectProperty: VantageToCheck
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT VantageToCheck
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 588); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 588); }
    }

    /// <summary>
    /// ObjectProperty: ProxyVantageToCheck
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT ProxyVantageToCheck
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 596); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 596); }
    }

    /// <summary>
    /// StructProperty: VantageCheckStandPoint
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT VantageCheckStandPoint
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 604); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 604); }
    }
}
