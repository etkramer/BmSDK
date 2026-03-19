#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmScript;

/// <summary>
/// Class: RSeqAct_ShowVehicleOnHUD<br/>
/// (size = 0)
/// (flags = 0)
/// </summary>
public partial class RSeqAct_ShowVehicleOnHUD : BmSDK.Engine.SequenceAction, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmScript.RSeqAct_ShowVehicleOnHUD", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RSeqAct_ShowVehicleOnHUD() { }

    /// <summary>
    /// Constructs a new RSeqAct_ShowVehicleOnHUD
    /// </summary>
    public RSeqAct_ShowVehicleOnHUD(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RSeqAct_ShowVehicleOnHUD Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RSeqAct_ShowVehicleOnHUD(nint ptr) : base(ptr) { }

    /// <summary>
    /// ObjectProperty: Vehicle
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT Vehicle
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 352); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 352); }
    }

    /// <summary>
    /// BoolProperty: bUseBatmobileTracker
    /// </summary>
    public unsafe bool bUseBatmobileTracker
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 360) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 360); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 360); }
    }

    /// <summary>
    /// BoolProperty: bCanLoseTarget
    /// </summary>
    public unsafe bool bCanLoseTarget
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 360) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 360); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 360); }
    }

    /// <summary>
    /// BoolProperty: bCanUntagTarget
    /// </summary>
    public unsafe bool bCanUntagTarget
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 360) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 360); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 360); }
    }

    /// <summary>
    /// StrProperty: ObjectiveName
    /// </summary>
    public unsafe BmSDK.FString ObjectiveName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 364); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 364); }
    }
}
