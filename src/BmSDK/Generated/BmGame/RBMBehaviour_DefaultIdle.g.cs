#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RBMBehaviour_DefaultIdle<br/>
/// (flags = 0)
/// </summary>
public partial class RBMBehaviour_DefaultIdle : BmSDK.BmGame.RBMBehaviour_Idle, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RBMBehaviour_DefaultIdle", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RBMBehaviour_DefaultIdle() { }

    /// <summary>
    /// Constructs a new RBMBehaviour_DefaultIdle
    /// </summary>
    public RBMBehaviour_DefaultIdle(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RBMBehaviour_DefaultIdle Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RBMBehaviour_DefaultIdle(nint ptr) : base(ptr) { }

    /// <summary>
    /// BoolProperty: bOldForceNavMeshObstacleUpdate
    /// </summary>
    public unsafe bool bOldForceNavMeshObstacleUpdate
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 628) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 628); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 628); }
    }
}
