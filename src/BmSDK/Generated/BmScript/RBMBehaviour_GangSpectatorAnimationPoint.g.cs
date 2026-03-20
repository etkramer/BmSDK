#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmScript;

/// <summary>
/// Class: RBMBehaviour_GangSpectatorAnimationPoint<br/>
/// (size = 0)
/// (flags = 0)
/// </summary>
public partial class RBMBehaviour_GangSpectatorAnimationPoint : BmSDK.BmScript.RBMBehaviour_GangIdleOrGroupAnimationPoint, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmScript.RBMBehaviour_GangSpectatorAnimationPoint", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RBMBehaviour_GangSpectatorAnimationPoint() { }

    /// <summary>
    /// Constructs a new RBMBehaviour_GangSpectatorAnimationPoint
    /// </summary>
    public RBMBehaviour_GangSpectatorAnimationPoint(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RBMBehaviour_GangSpectatorAnimationPoint Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RBMBehaviour_GangSpectatorAnimationPoint(nint ptr) : base(ptr) { }

    /// <summary>
    /// BoolProperty: bHasFollowed
    /// </summary>
    public unsafe bool bHasFollowed
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 948) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 948); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 948); }
    }
}
