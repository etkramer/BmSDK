#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Class: AdvancedReachSpec<br/>
/// (size = 172)
/// (flags = 134217874)
/// </summary>
public partial class AdvancedReachSpec : BmSDK.Engine.ReachSpec, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Engine.AdvancedReachSpec", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal AdvancedReachSpec() { }

    /// <summary>
    /// Constructs a new AdvancedReachSpec
    /// </summary>
    public AdvancedReachSpec(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, AdvancedReachSpec Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected AdvancedReachSpec(nint ptr) : base(ptr) { }

}
