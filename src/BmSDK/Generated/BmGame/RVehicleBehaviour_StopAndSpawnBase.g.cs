#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RVehicleBehaviour_StopAndSpawnBase<br/>
/// (size = 0)
/// (flags = 0)
/// </summary>
public partial class RVehicleBehaviour_StopAndSpawnBase : BmSDK.BmGame.RVehicleBehaviour, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RVehicleBehaviour_StopAndSpawnBase", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RVehicleBehaviour_StopAndSpawnBase() { }

    /// <summary>
    /// Constructs a new RVehicleBehaviour_StopAndSpawnBase
    /// </summary>
    public RVehicleBehaviour_StopAndSpawnBase(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RVehicleBehaviour_StopAndSpawnBase Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RVehicleBehaviour_StopAndSpawnBase(nint ptr) : base(ptr) { }

    /// <summary>
    /// ObjectProperty: StopNearActor
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT StopNearActor
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 608); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 608); }
    }

    /// <summary>
    /// FloatProperty: StopNearActorDistance
    /// </summary>
    public unsafe float StopNearActorDistance
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 616); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 616); }
    }

    /// <summary>
    /// BoolProperty: DriveAtActor
    /// </summary>
    public unsafe bool DriveAtActor
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 620) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 620); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 620); }
    }

    /// <summary>
    /// BoolProperty: SkidToStop
    /// </summary>
    public unsafe bool SkidToStop
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 620) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 620); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 620); }
    }

    /// <summary>
    /// BoolProperty: DisembarkPassengers
    /// </summary>
    public unsafe bool DisembarkPassengers
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 620) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 620); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 620); }
    }

    /// <summary>
    /// BoolProperty: DisembarkedPassengersRunAway
    /// </summary>
    public unsafe bool DisembarkedPassengersRunAway
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 620) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 620); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 620); }
    }

    /// <summary>
    /// FloatProperty: ThrottleScale
    /// </summary>
    public unsafe float ThrottleScale
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 624); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 624); }
    }
}
