#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RSeqAct_SpawnDroneBase<br/>
/// (size = 436)
/// (flags = 0)
/// </summary>
public partial class RSeqAct_SpawnDroneBase : BmSDK.Engine.SeqAct_Latent, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RSeqAct_SpawnDroneBase", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RSeqAct_SpawnDroneBase() { }

    /// <summary>
    /// Constructs a new RSeqAct_SpawnDroneBase
    /// </summary>
    public RSeqAct_SpawnDroneBase(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RSeqAct_SpawnDroneBase Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RSeqAct_SpawnDroneBase(nint ptr) : base(ptr) { }

    /// <summary>
    /// ByteProperty: PickedDroneType
    /// </summary>
    public unsafe BmSDK.BmGame.RSeqAct_SpawnDroneBase.DroneTypes PickedDroneType
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSeqAct_SpawnDroneBase.DroneTypes>(Ptr + 376); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 376); }
    }

    /// <summary>
    /// ClassProperty: PickedDroneClass
    /// </summary>
    public unsafe BmSDK.Class PickedDroneClass
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Class>(Ptr + 380); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 380); }
    }

    /// <summary>
    /// ClassProperty: AerialHoverClass
    /// </summary>
    public unsafe BmSDK.Class AerialHoverClass
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Class>(Ptr + 388); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 388); }
    }

    /// <summary>
    /// ClassProperty: AerialRotorClass
    /// </summary>
    public unsafe BmSDK.Class AerialRotorClass
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Class>(Ptr + 396); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 396); }
    }

    /// <summary>
    /// ClassProperty: MiniClass
    /// </summary>
    public unsafe BmSDK.Class MiniClass
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Class>(Ptr + 404); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 404); }
    }

    /// <summary>
    /// ClassProperty: GunshipClass
    /// </summary>
    public unsafe BmSDK.Class GunshipClass
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Class>(Ptr + 412); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 412); }
    }

    /// <summary>
    /// ClassProperty: HelicopterClass
    /// </summary>
    public unsafe BmSDK.Class HelicopterClass
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Class>(Ptr + 420); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 420); }
    }

    /// <summary>
    /// ClassProperty: HelicopterMultiroleClass
    /// </summary>
    public unsafe BmSDK.Class HelicopterMultiroleClass
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Class>(Ptr + 428); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 428); }
    }

    /// <summary>
    /// Enum: DroneTypes
    /// </summary>
    public enum DroneTypes
    {
        DroneTypes_AerialHover = 0,
        DroneTypes_AerialRotor = 1,
        DroneTypes_Mini = 2,
        DroneTypes_Gunship = 3,
        DroneTypes_Helicopter = 4,
        DroneTypes_HelicopterMultirole = 5,
        DroneTypes_MAX = 6,
    }
}
