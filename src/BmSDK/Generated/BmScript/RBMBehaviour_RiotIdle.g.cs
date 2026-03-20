#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmScript;

/// <summary>
/// Class: RBMBehaviour_RiotIdle<br/>
/// (size = 0)
/// (flags = 0)
/// </summary>
public partial class RBMBehaviour_RiotIdle : BmSDK.BmGame.RBMBehaviour_GangMovementBaseBase, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmScript.RBMBehaviour_RiotIdle", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RBMBehaviour_RiotIdle() { }

    /// <summary>
    /// Constructs a new RBMBehaviour_RiotIdle
    /// </summary>
    public RBMBehaviour_RiotIdle(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RBMBehaviour_RiotIdle Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RBMBehaviour_RiotIdle(nint ptr) : base(ptr) { }

    /// <summary>
    /// BoolProperty: bRegisteredError
    /// </summary>
    public unsafe bool bRegisteredError
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 772) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 772); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 772); }
    }

    /// <summary>
    /// FloatProperty: ErrorTime
    /// </summary>
    public unsafe float ErrorTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 776); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 776); }
    }
}
