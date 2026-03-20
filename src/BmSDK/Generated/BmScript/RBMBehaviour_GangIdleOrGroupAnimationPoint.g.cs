#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmScript;

/// <summary>
/// Class: RBMBehaviour_GangIdleOrGroupAnimationPoint<br/>
/// (size = 0)
/// (flags = 0)
/// </summary>
public partial class RBMBehaviour_GangIdleOrGroupAnimationPoint : BmSDK.BmScript.RBMBehaviour_GangMovementBase, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmScript.RBMBehaviour_GangIdleOrGroupAnimationPoint", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RBMBehaviour_GangIdleOrGroupAnimationPoint() { }

    /// <summary>
    /// Constructs a new RBMBehaviour_GangIdleOrGroupAnimationPoint
    /// </summary>
    public RBMBehaviour_GangIdleOrGroupAnimationPoint(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RBMBehaviour_GangIdleOrGroupAnimationPoint Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RBMBehaviour_GangIdleOrGroupAnimationPoint(nint ptr) : base(ptr) { }

    /// <summary>
    /// IntProperty: EventIndex
    /// </summary>
    public unsafe int EventIndex
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 924); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 924); }
    }

    /// <summary>
    /// IntProperty: NumEventsLeft
    /// </summary>
    public unsafe int NumEventsLeft
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 928); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 928); }
    }

    /// <summary>
    /// FloatProperty: WaitingTimeOut
    /// </summary>
    public unsafe float WaitingTimeOut
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 932); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 932); }
    }

    /// <summary>
    /// FloatProperty: DefaultWaitingTimeOut
    /// </summary>
    public unsafe float DefaultWaitingTimeOut
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 936); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 936); }
    }

    /// <summary>
    /// BoolProperty: bStartedPaired
    /// </summary>
    public unsafe bool bStartedPaired
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 940) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 940); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 940); }
    }

    /// <summary>
    /// FloatProperty: CustomWaitTime
    /// </summary>
    public unsafe float CustomWaitTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 944); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 944); }
    }
}
