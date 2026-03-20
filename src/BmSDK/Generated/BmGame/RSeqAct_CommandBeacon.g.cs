#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RSeqAct_CommandBeacon<br/>
/// (size = 0)
/// (flags = 0)
/// </summary>
public partial class RSeqAct_CommandBeacon : BmSDK.Engine.SeqAct_Latent, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RSeqAct_CommandBeacon", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RSeqAct_CommandBeacon() { }

    /// <summary>
    /// Constructs a new RSeqAct_CommandBeacon
    /// </summary>
    public RSeqAct_CommandBeacon(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RSeqAct_CommandBeacon Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RSeqAct_CommandBeacon(nint ptr) : base(ptr) { }

    /// <summary>
    /// ObjectProperty: beacon
    /// </summary>
    public unsafe BmSDK.BmGame.RCommandBeaconBase beacon
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RCommandBeaconBase>(Ptr + 376); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 376); }
    }

    /// <summary>
    /// ObjectProperty: VehicleSpawner
    /// </summary>
    public unsafe BmSDK.BmGame.RSeqAct_VehicleEnemySpawner VehicleSpawner
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSeqAct_VehicleEnemySpawner>(Ptr + 384); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 384); }
    }
}
