#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// ABSTRACT Class: RRope2Updater<br/>
/// (size = 52)
/// (flags = 142610579)
/// </summary>
public partial class RRope2Updater : BmSDK.GameObject, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RRope2Updater", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RRope2Updater() { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RRope2Updater(nint ptr) : base(ptr) { }

    /// <summary>
    /// ComponentProperty: RopeOwner
    /// </summary>
    public unsafe BmSDK.BmGame.RRope2Component RopeOwner
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RRope2Component>(Ptr + 44); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 44); }
    }

    /// <summary>
    /// BoolProperty: bInitialised
    /// </summary>
    public unsafe bool bInitialised
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 48) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 48); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 48); }
    }

    /// <summary>
    /// BoolProperty: bPendingRemoval
    /// </summary>
    public unsafe bool bPendingRemoval
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 48) & 2) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 48); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 48); }
    }

    /// <summary>
    /// BoolProperty: bKeepOnSplit
    /// </summary>
    public unsafe bool bKeepOnSplit
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 48) & 4) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 48); var newMask = value ? (currentMask | 4) : (currentMask & ~4); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 48); }
    }

    /// <summary>
    /// BoolProperty: bKeepOnJoin
    /// </summary>
    public unsafe bool bKeepOnJoin
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 48) & 8) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 48); var newMask = value ? (currentMask | 8) : (currentMask & ~8); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 48); }
    }
}
