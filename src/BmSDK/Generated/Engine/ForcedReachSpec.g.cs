#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Class: ForcedReachSpec<br/>
/// (size = 172)
/// (flags = 134217874)
/// </summary>
public partial class ForcedReachSpec : BmSDK.Engine.ReachSpec, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Engine.ForcedReachSpec", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal ForcedReachSpec() { }

    /// <summary>
    /// Constructs a new ForcedReachSpec
    /// </summary>
    public ForcedReachSpec(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, ForcedReachSpec Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected ForcedReachSpec(nint ptr) : base(ptr) { }

}
