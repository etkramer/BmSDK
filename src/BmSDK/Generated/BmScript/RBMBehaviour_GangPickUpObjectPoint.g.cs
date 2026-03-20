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
    public unsafe BmSDK.BmGame.RGangInteractPointBase ObjectEndPoint
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RGangInteractPointBase>(Ptr + 948); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 948); }
    }

    /// <summary>
    /// ObjectProperty: Window
    /// </summary>
    public unsafe BmSDK.BmScript.RGangInteractWindow Window
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmScript.RGangInteractWindow>(Ptr + 956); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 956); }
    }

    /// <summary>
    /// ObjectProperty: Breakable
    /// </summary>
    public unsafe BmSDK.BmGame.RGangInteractPointBreakableBase Breakable
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RGangInteractPointBreakableBase>(Ptr + 964); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 964); }
    }

    /// <summary>
    /// ObjectProperty: SavedPickupActor
    /// </summary>
    public unsafe BmSDK.Engine.Actor SavedPickupActor
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.Actor>(Ptr + 972); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 972); }
    }

    /// <summary>
    /// BoolProperty: bWasInterrupted
    /// </summary>
    public unsafe bool bWasInterrupted
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 980) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 980); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 980); }
    }

    /// <summary>
    /// BoolProperty: bPickingUpObject
    /// </summary>
    public unsafe bool bPickingUpObject
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 980) & 2) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 980); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 980); }
    }

    /// <summary>
    /// BoolProperty: bStartedPickingUpObject
    /// </summary>
    public unsafe bool bStartedPickingUpObject
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 980) & 4) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 980); var newMask = value ? (currentMask | 4) : (currentMask & ~4); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 980); }
    }

    /// <summary>
    /// BoolProperty: bHasObject
    /// </summary>
    public unsafe bool bHasObject
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 980) & 8) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 980); var newMask = value ? (currentMask | 8) : (currentMask & ~8); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 980); }
    }

    /// <summary>
    /// BoolProperty: bThrowingObject
    /// </summary>
    public unsafe bool bThrowingObject
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 980) & 16) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 980); var newMask = value ? (currentMask | 16) : (currentMask & ~16); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 980); }
    }

    /// <summary>
    /// BoolProperty: bHasThrownObject
    /// </summary>
    public unsafe bool bHasThrownObject
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 980) & 32) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 980); var newMask = value ? (currentMask | 32) : (currentMask & ~32); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 980); }
    }
}
