#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmScript;

/// <summary>
/// Class: RBMBehaviour_GangPickUpObjectPoint<br/>
/// (size = 0)
/// (flags = 0)
/// </summary>
public partial class RBMBehaviour_GangPickUpObjectPoint : BmSDK.BmScript.RBMBehaviour_GangIdleOrGroupAnimationPoint, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmScript.RBMBehaviour_GangPickUpObjectPoint", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RBMBehaviour_GangPickUpObjectPoint() { }

    /// <summary>
    /// Constructs a new RBMBehaviour_GangPickUpObjectPoint
    /// </summary>
    public RBMBehaviour_GangPickUpObjectPoint(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RBMBehaviour_GangPickUpObjectPoint Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RBMBehaviour_GangPickUpObjectPoint(nint ptr) : base(ptr) { }

    /// <summary>
    /// ObjectProperty: ObjectEndPoint
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT ObjectEndPoint
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 948); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 948); }
    }

    /// <summary>
    /// ObjectProperty: Window
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT Window
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 956); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 956); }
    }

    /// <summary>
    /// ObjectProperty: Breakable
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT Breakable
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 964); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 964); }
    }

    /// <summary>
    /// ObjectProperty: SavedPickupActor
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT SavedPickupActor
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 972); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 972); }
    }

    /// <summary>
    /// BoolProperty: bWasInterrupted
    /// </summary>
    public unsafe bool bWasInterrupted
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 980) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 980); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 980); }
    }

    /// <summary>
    /// BoolProperty: bPickingUpObject
    /// </summary>
    public unsafe bool bPickingUpObject
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 980) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 980); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 980); }
    }

    /// <summary>
    /// BoolProperty: bStartedPickingUpObject
    /// </summary>
    public unsafe bool bStartedPickingUpObject
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 980) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 980); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 980); }
    }

    /// <summary>
    /// BoolProperty: bHasObject
    /// </summary>
    public unsafe bool bHasObject
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 980) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 980); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 980); }
    }

    /// <summary>
    /// BoolProperty: bThrowingObject
    /// </summary>
    public unsafe bool bThrowingObject
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 980) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 980); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 980); }
    }

    /// <summary>
    /// BoolProperty: bHasThrownObject
    /// </summary>
    public unsafe bool bHasThrownObject
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 980) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 980); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 980); }
    }
}
