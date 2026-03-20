#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RBMBehaviour_ThermalCheck<br/>
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
    public unsafe BmSDK.BmGame.RHidePoint VantageToCheck
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RHidePoint>(Ptr + 588); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 588); }
    }

    /// <summary>
    /// ObjectProperty: ProxyVantageToCheck
    /// </summary>
    public unsafe BmSDK.BmGame.RCrossLevelVantageProxy ProxyVantageToCheck
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RCrossLevelVantageProxy>(Ptr + 596); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 596); }
    }

    /// <summary>
    /// StructProperty: VantageCheckStandPoint
    /// </summary>
    public unsafe System.Numerics.Vector3 VantageCheckStandPoint
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 604); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 604); }
    }
}
