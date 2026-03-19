#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RBMBehaviour_DoorHandler<br/>
/// (size = 0)
/// (flags = 0)
/// </summary>
public partial class RBMBehaviour_DoorHandler : BmSDK.BmGame.RBMBehaviour_ActionQueue, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RBMBehaviour_DoorHandler", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RBMBehaviour_DoorHandler() { }

    /// <summary>
    /// Constructs a new RBMBehaviour_DoorHandler
    /// </summary>
    public RBMBehaviour_DoorHandler(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RBMBehaviour_DoorHandler Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RBMBehaviour_DoorHandler(nint ptr) : base(ptr) { }

    /// <summary>
    /// ObjectProperty: NavHandle
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT NavHandle
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 588); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 588); }
    }

    /// <summary>
    /// ObjectProperty: firstDoorOnPath
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT firstDoorOnPath
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 596); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 596); }
    }

    /// <summary>
    /// ObjectProperty: doorToOpen
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT doorToOpen
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 604); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 604); }
    }

    /// <summary>
    /// ObjectProperty: doorToWaitFor
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT doorToWaitFor
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 612); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 612); }
    }

    /// <summary>
    /// ObjectProperty: LastDiscoveredDoor
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT LastDiscoveredDoor
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 620); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 620); }
    }

    /// <summary>
    /// StructProperty: cachedDestination
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT cachedDestination
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 628); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 628); }
    }

    /// <summary>
    /// FloatProperty: pathOKTime
    /// </summary>
    public unsafe float pathOKTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 640); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 640); }
    }

    /// <summary>
    /// NameProperty: preTryOpenState
    /// </summary>
    public unsafe BmSDK.FName preTryOpenState
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 644); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 644); }
    }

    /// <summary>
    /// FloatProperty: chatIntervalMin
    /// </summary>
    public unsafe float chatIntervalMin
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 652); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 652); }
    }

    /// <summary>
    /// FloatProperty: chatIntervalMax
    /// </summary>
    public unsafe float chatIntervalMax
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 656); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 656); }
    }

    /// <summary>
    /// StructProperty: CheatChaseSavedLoc
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT CheatChaseSavedLoc
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 660); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 660); }
    }

    /// <summary>
    /// FloatProperty: PauseBeforeTurningBehindTime
    /// </summary>
    public unsafe float PauseBeforeTurningBehindTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 672); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 672); }
    }

    /// <summary>
    /// BoolProperty: bTryingToPathAroundDoor
    /// </summary>
    public unsafe bool bTryingToPathAroundDoor
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 676) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 676); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 676); }
    }
}
