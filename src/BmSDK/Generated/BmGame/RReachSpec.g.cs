#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RReachSpec<br/>
/// (flags = 0)
/// </summary>
public partial class RReachSpec : BmSDK.Engine.ReachSpec, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RReachSpec", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RReachSpec() { }

    /// <summary>
    /// Constructs a new RReachSpec
    /// </summary>
    public RReachSpec(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RReachSpec Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RReachSpec(nint ptr) : base(ptr) { }

    /// <summary>
    /// ArrayProperty: PathBlockers
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.GameObject> PathBlockers
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.GameObject>>(Ptr + 172); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 172); }
    }
}
