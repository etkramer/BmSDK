#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RBmPawnSpawner_RobotBase<br/>
/// (size = 0)
/// (flags = 0)
/// </summary>
public partial class RBmPawnSpawner_RobotBase : BmSDK.BmGame.RBmPawnSpawner, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RBmPawnSpawner_RobotBase", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RBmPawnSpawner_RobotBase() { }

    /// <summary>
    /// Constructs a new RBmPawnSpawner_RobotBase
    /// </summary>
    public RBmPawnSpawner_RobotBase(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RBmPawnSpawner_RobotBase Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RBmPawnSpawner_RobotBase(nint ptr) : base(ptr) { }

    /// <summary>
    /// FloatProperty: explosionTriggerRadius
    /// </summary>
    public unsafe float explosionTriggerRadius
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 732); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 732); }
    }

    /// <summary>
    /// FloatProperty: explosionDamage
    /// </summary>
    public unsafe float explosionDamage
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 736); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 736); }
    }

    /// <summary>
    /// FloatProperty: explosionImpulse
    /// </summary>
    public unsafe float explosionImpulse
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 740); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 740); }
    }

    /// <summary>
    /// BoolProperty: bSetHidden
    /// </summary>
    public unsafe bool bSetHidden
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 744) & 0) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 744); var newMask = value ? (currentMask | 0) : (currentMask & ~0); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 744); }
    }

    /// <summary>
    /// StructProperty: SpawnLocation
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT SpawnLocation
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 748); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 748); }
    }

    /// <summary>
    /// StructProperty: SpawnRotation
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT SpawnRotation
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 760); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 760); }
    }

    /// <summary>
    /// StructProperty: playerLoc
    /// </summary>
    public unsafe NEED_UPDATE_STRUCTPROPERTY_LAYOUT playerLoc
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_STRUCTPROPERTY_LAYOUT>(Ptr + 772); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 772); }
    }

    /// <summary>
    /// FloatProperty: playerDistThreshold
    /// </summary>
    public unsafe float playerDistThreshold
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 784); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 784); }
    }

    /// <summary>
    /// FloatProperty: robotDistThreshold
    /// </summary>
    public unsafe float robotDistThreshold
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 788); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 788); }
    }
}
