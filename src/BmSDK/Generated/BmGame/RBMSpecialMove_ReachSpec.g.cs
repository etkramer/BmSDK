#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RBMSpecialMove_ReachSpec<br/>
/// (size = 0)
/// (flags = 0)
/// </summary>
public partial class RBMSpecialMove_ReachSpec : BmSDK.BmGame.RReachSpec, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RBMSpecialMove_ReachSpec", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RBMSpecialMove_ReachSpec() { }

    /// <summary>
    /// Constructs a new RBMSpecialMove_ReachSpec
    /// </summary>
    public RBMSpecialMove_ReachSpec(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RBMSpecialMove_ReachSpec Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RBMSpecialMove_ReachSpec(nint ptr) : base(ptr) { }

    /// <summary>
    /// ArrayProperty: PathBlockers
    /// </summary>
    public unsafe NEED_UPDATE_ARRAYPROPERTY_LAYOUT PathBlockers
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<NEED_UPDATE_ARRAYPROPERTY_LAYOUT>(Ptr + 172); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 172); }
    }
}
