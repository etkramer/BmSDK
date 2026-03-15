#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RHidePointRope_RopeComponent<br/>
/// (size = 512)
/// (flags = 2157969426)
/// </summary>
public partial class RHidePointRope_RopeComponent : BmSDK.BmGame.RRope2Component, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RHidePointRope_RopeComponent", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RHidePointRope_RopeComponent() { }

    /// <summary>
    /// Constructs a new RHidePointRope_RopeComponent
    /// </summary>
    public RHidePointRope_RopeComponent(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RHidePointRope_RopeComponent Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RHidePointRope_RopeComponent(nint ptr) : base(ptr) { }

}
