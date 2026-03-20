#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RSeqAct_SetVehicleNPCWeaponScripted<br/>
/// (flags = 0)
/// </summary>
public partial class RSeqAct_SetVehicleNPCWeaponScripted : BmSDK.Engine.SequenceAction, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RSeqAct_SetVehicleNPCWeaponScripted", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RSeqAct_SetVehicleNPCWeaponScripted() { }

    /// <summary>
    /// Constructs a new RSeqAct_SetVehicleNPCWeaponScripted
    /// </summary>
    public RSeqAct_SetVehicleNPCWeaponScripted(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RSeqAct_SetVehicleNPCWeaponScripted Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RSeqAct_SetVehicleNPCWeaponScripted(nint ptr) : base(ptr) { }

    /// <summary>
    /// ObjectProperty: Vehicle
    /// </summary>
    public unsafe BmSDK.BmGame.RVehicleNPC Vehicle
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RVehicleNPC>(Ptr + 352); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 352); }
    }

    /// <summary>
    /// ObjectProperty: OverrideWeaponProjectile
    /// </summary>
    public unsafe BmSDK.BmGame.RProjectile OverrideWeaponProjectile
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RProjectile>(Ptr + 360); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 360); }
    }

    /// <summary>
    /// IntProperty: PassengerSlot
    /// </summary>
    public unsafe int PassengerSlot
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 368); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 368); }
    }

    /// <summary>
    /// BoolProperty: Scripted
    /// </summary>
    public unsafe bool Scripted
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 372) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 372); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 372); }
    }
}
