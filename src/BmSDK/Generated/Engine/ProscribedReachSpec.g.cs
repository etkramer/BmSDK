#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Class: ProscribedReachSpec<br/>
/// (size = 0)
/// (flags = 0)
/// </summary>
public partial class ProscribedReachSpec : BmSDK.Engine.ReachSpec, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Engine.ProscribedReachSpec", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal ProscribedReachSpec() { }

    /// <summary>
    /// Constructs a new ProscribedReachSpec
    /// </summary>
    public ProscribedReachSpec(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, ProscribedReachSpec Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected ProscribedReachSpec(nint ptr) : base(ptr) { }

    /// <summary>
    /// StructProperty: NavOctreeObject
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT NavOctreeObject
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 84); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 84); }
    }

    /// <summary>
    /// IntProperty: Distance
    /// </summary>
    public unsafe int Distance
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 92); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 92); }
    }

    /// <summary>
    /// StructProperty: Direction
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT Direction
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 96); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 96); }
    }

    /// <summary>
    /// ObjectProperty: Start
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT Start
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 108); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 108); }
    }

    /// <summary>
    /// ObjectProperty: BlockedBy
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT BlockedBy
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 116); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 116); }
    }

    /// <summary>
    /// StructProperty: End
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT End
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 124); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 124); }
    }

    /// <summary>
    /// IntProperty: CollisionRadius
    /// </summary>
    public unsafe int CollisionRadius
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 148); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 148); }
    }

    /// <summary>
    /// IntProperty: CollisionHeight
    /// </summary>
    public unsafe int CollisionHeight
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 152); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 152); }
    }

    /// <summary>
    /// IntProperty: reachFlags
    /// </summary>
    public unsafe int reachFlags
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 156); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 156); }
    }

    /// <summary>
    /// IntProperty: MaxLandingVelocity
    /// </summary>
    public unsafe int MaxLandingVelocity
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 160); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 160); }
    }

    /// <summary>
    /// ByteProperty: bPruned
    /// </summary>
    public unsafe byte bPruned
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 164); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 164); }
    }

    /// <summary>
    /// ByteProperty: PathColorIndex
    /// </summary>
    public unsafe byte PathColorIndex
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 165); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 165); }
    }

    /// <summary>
    /// BoolProperty: bAddToNavigationOctree
    /// </summary>
    public unsafe bool bAddToNavigationOctree
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 168) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 168); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 168); }
    }

    /// <summary>
    /// BoolProperty: bCanCutCorners
    /// </summary>
    public unsafe bool bCanCutCorners
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 168) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 168); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 168); }
    }

    /// <summary>
    /// BoolProperty: bCheckForObstructions
    /// </summary>
    public unsafe bool bCheckForObstructions
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 168) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 168); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 168); }
    }

    /// <summary>
    /// BoolProperty: bSkipPrune
    /// </summary>
    public unsafe bool bSkipPrune
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 168) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 168); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 168); }
    }

    /// <summary>
    /// BoolProperty: bDisabled
    /// </summary>
    public unsafe bool bDisabled
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 168) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 168); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 168); }
    }

}
