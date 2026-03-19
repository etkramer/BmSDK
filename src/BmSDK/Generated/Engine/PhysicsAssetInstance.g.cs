#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Class: PhysicsAssetInstance<br/>
/// (size = 0)
/// (flags = 0)
/// </summary>
public partial class PhysicsAssetInstance : BmSDK.GameObject, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Engine.PhysicsAssetInstance", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal PhysicsAssetInstance() { }

    /// <summary>
    /// Constructs a new PhysicsAssetInstance
    /// </summary>
    public PhysicsAssetInstance(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, PhysicsAssetInstance Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected PhysicsAssetInstance(nint ptr) : base(ptr) { }

    /// <summary>
    /// ObjectProperty: Owner
    /// </summary>
    public unsafe NEED_UPDATE_OBJECTPROPERTY_LAYOUT Owner
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_OBJECTPROPERTY_LAYOUT>(Ptr + 84); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 84); }
    }

    /// <summary>
    /// IntProperty: RootBodyIndex
    /// </summary>
    public unsafe int RootBodyIndex
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 92); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 92); }
    }

    /// <summary>
    /// ArrayProperty: Bodies
    /// </summary>
    public unsafe BmSDK.TArray<NEED_UPDATE_ARRAYPROPERTY_LAYOUT> Bodies
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<NEED_UPDATE_ARRAYPROPERTY_LAYOUT>>(Ptr + 96); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 96); }
    }

    /// <summary>
    /// ArrayProperty: Constraints
    /// </summary>
    public unsafe NEED_UPDATE_ARRAYPROPERTY_LAYOUT Constraints
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_ARRAYPROPERTY_LAYOUT>(Ptr + 112); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 112); }
    }

    /// <summary>
    /// StructProperty: CollisionDisableTable
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT CollisionDisableTable
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 128); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 128); }
    }

    /// <summary>
    /// FloatProperty: LinearSpringScale
    /// </summary>
    public unsafe float LinearSpringScale
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 200); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 200); }
    }

    /// <summary>
    /// FloatProperty: LinearDampingScale
    /// </summary>
    public unsafe float LinearDampingScale
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 204); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 204); }
    }

    /// <summary>
    /// FloatProperty: LinearForceLimitScale
    /// </summary>
    public unsafe float LinearForceLimitScale
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 208); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 208); }
    }

    /// <summary>
    /// FloatProperty: AngularSpringScale
    /// </summary>
    public unsafe float AngularSpringScale
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 212); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 212); }
    }

    /// <summary>
    /// FloatProperty: AngularDampingScale
    /// </summary>
    public unsafe float AngularDampingScale
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 216); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 216); }
    }

    /// <summary>
    /// FloatProperty: AngularForceLimitScale
    /// </summary>
    public unsafe float AngularForceLimitScale
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 220); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 220); }
    }

    /// <summary>
    /// BoolProperty: bInitBodies
    /// </summary>
    public unsafe bool bInitBodies
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 224) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 224); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 224); }
    }

    /// <summary>
    /// BoolProperty: bEnableAggregate
    /// </summary>
    public unsafe bool bEnableAggregate
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 224) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 224); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 224); }
    }

    /// <summary>
    /// FloatProperty: CachedDampingRampupProportion
    /// </summary>
    public unsafe float CachedDampingRampupProportion
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 228); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 228); }
    }
}
