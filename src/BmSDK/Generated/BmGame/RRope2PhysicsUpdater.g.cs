#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RRope2PhysicsUpdater<br/>
/// (size = 0)
/// (flags = 0)
/// </summary>
public partial class RRope2PhysicsUpdater : BmSDK.GameObject, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RRope2PhysicsUpdater", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RRope2PhysicsUpdater() { }

    /// <summary>
    /// Constructs a new RRope2PhysicsUpdater
    /// </summary>
    public RRope2PhysicsUpdater(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RRope2PhysicsUpdater Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RRope2PhysicsUpdater(nint ptr) : base(ptr) { }

    /// <summary>
    /// BoolProperty: bInitialised
    /// </summary>
    public unsafe bool bInitialised
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 84) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 84); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 84); }
    }

    /// <summary>
    /// BoolProperty: bHasSavedDynamicState
    /// </summary>
    public unsafe bool bHasSavedDynamicState
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 84) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 84); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 84); }
    }

    /// <summary>
    /// BoolProperty: bAllowSplit
    /// </summary>
    public unsafe bool bAllowSplit
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 84) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 84); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 84); }
    }

    /// <summary>
    /// ComponentProperty: RopeOwner
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT RopeOwner
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 88); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 88); }
    }

    /// <summary>
    /// ObjectProperty: PhysicalMaterial
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT PhysicalMaterial
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 96); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 96); }
    }

    /// <summary>
    /// ClassProperty: PreSplitPhysicsSwapUpdaterClass
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT PreSplitPhysicsSwapUpdaterClass
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 104); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 104); }
    }

    /// <summary>
    /// FloatProperty: RopeTwistLimitPerMetre
    /// </summary>
    public unsafe float RopeTwistLimitPerMetre
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 112); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 112); }
    }
}
