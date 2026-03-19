#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RSeqAct_ExitVehicleWithAnim<br/>
/// (size = 0)
/// (flags = 0)
/// </summary>
public partial class RSeqAct_ExitVehicleWithAnim : BmSDK.Engine.SeqAct_Latent, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RSeqAct_ExitVehicleWithAnim", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RSeqAct_ExitVehicleWithAnim() { }

    /// <summary>
    /// Constructs a new RSeqAct_ExitVehicleWithAnim
    /// </summary>
    public RSeqAct_ExitVehicleWithAnim(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RSeqAct_ExitVehicleWithAnim Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RSeqAct_ExitVehicleWithAnim(nint ptr) : base(ptr) { }

    /// <summary>
    /// IntProperty: PassengerSlotIndex
    /// </summary>
    public unsafe int PassengerSlotIndex
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 376); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 376); }
    }

    /// <summary>
    /// ObjectProperty: ExitAnimset
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT ExitAnimset
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 380); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 380); }
    }

    /// <summary>
    /// ObjectProperty: Vehicle
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT Vehicle
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 388); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 388); }
    }

    /// <summary>
    /// NameProperty: ExitAnim
    /// </summary>
    public unsafe BmSDK.FName ExitAnim
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 396); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 396); }
    }

    /// <summary>
    /// FloatProperty: MaxVehicleVelocity
    /// </summary>
    public unsafe float MaxVehicleVelocity
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 404); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 404); }
    }

    /// <summary>
    /// BoolProperty: BypassNavMeshCheck
    /// </summary>
    public unsafe bool BypassNavMeshCheck
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 408) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 408); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 408); }
    }
}
