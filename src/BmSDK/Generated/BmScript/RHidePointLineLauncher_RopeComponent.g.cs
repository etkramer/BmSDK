#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmScript;

/// <summary>
/// Class: RHidePointLineLauncher_RopeComponent<br/>
/// (flags = 0)
/// </summary>
public partial class RHidePointLineLauncher_RopeComponent : BmSDK.BmGame.RHidePointRope_RopeComponent, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmScript.RHidePointLineLauncher_RopeComponent", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RHidePointLineLauncher_RopeComponent() { }

    /// <summary>
    /// Constructs a new RHidePointLineLauncher_RopeComponent
    /// </summary>
    public RHidePointLineLauncher_RopeComponent(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RHidePointLineLauncher_RopeComponent Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RHidePointLineLauncher_RopeComponent(nint ptr) : base(ptr) { }

}
