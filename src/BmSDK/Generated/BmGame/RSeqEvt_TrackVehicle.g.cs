#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RSeqEvt_TrackVehicle<br/>
/// (flags = 0)
/// </summary>
public partial class RSeqEvt_TrackVehicle : BmSDK.Engine.SequenceEvent, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RSeqEvt_TrackVehicle", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RSeqEvt_TrackVehicle() { }

    /// <summary>
    /// Constructs a new RSeqEvt_TrackVehicle
    /// </summary>
    public RSeqEvt_TrackVehicle(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RSeqEvt_TrackVehicle Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RSeqEvt_TrackVehicle(nint ptr) : base(ptr) { }

    /// <summary>
    /// Function: GetObjClassVersion
    /// </summary>
    public unsafe static int GetObjClassVersion()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RSeqEvt_TrackVehicle.GetObjClassVersion", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.GameFunctions.ProcessEvent(StaticClass().DefaultObject.Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<int>(paramsPtr + 0);
    }

    /// <summary>
    /// Enum: ETrackVehicleEventOutputLinks
    /// </summary>
    public enum ETrackVehicleEventOutputLinks
    {
        ETVEOL_Tracked = 0,
        ETVEOL_75Percent = 1,
        ETVEOL_50Percent = 2,
        ETVEOL_25Percent = 3,
        ETVEOL_SignalLost = 4,
        ETVEOL_VehicleStationaryBatmanLooking = 5,
        ETVEOL_VehicleUnTagged = 6,
        ETVEOL_VehicleLostUnTagged = 7,
        ETVEOL_MAX = 8,
    }
}
