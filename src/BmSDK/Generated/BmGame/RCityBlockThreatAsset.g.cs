#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RCityBlockThreatAsset<br/>
/// (size = 152)
/// (flags = 0)
/// </summary>
public partial class RCityBlockThreatAsset : BmSDK.BmGame.RConfig, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RCityBlockThreatAsset", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RCityBlockThreatAsset() { }

    /// <summary>
    /// Constructs a new RCityBlockThreatAsset
    /// </summary>
    public RCityBlockThreatAsset(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RCityBlockThreatAsset Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RCityBlockThreatAsset(nint ptr) : base(ptr) { }

    /// <summary>
    /// ByteProperty: CityBlock
    /// </summary>
    public unsafe BmSDK.BmGame.RGameInfo.EDistrict CityBlock
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RGameInfo.EDistrict>(Ptr + 84); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 84); }
    }

    /// <summary>
    /// ArrayProperty: CheckpointsInZone
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RCheckpointAsset> CheckpointsInZone
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RCheckpointAsset>>(Ptr + 88); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 88); }
    }

    /// <summary>
    /// ArrayProperty: WatchtowersInZone
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RWatchtowerAsset> WatchtowersInZone
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RWatchtowerAsset>>(Ptr + 104); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 104); }
    }

    /// <summary>
    /// ArrayProperty: DronesInZone
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RAerialDroneAsset> DronesInZone
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RAerialDroneAsset>>(Ptr + 120); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 120); }
    }

    /// <summary>
    /// ArrayProperty: BeaconsInZone
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RBeaconAsset> BeaconsInZone
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RBeaconAsset>>(Ptr + 136); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 136); }
    }
}
