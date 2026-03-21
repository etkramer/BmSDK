#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RGrundyRopeComponent<br/>
/// (size = 512)
/// (flags = 2157969426)
/// </summary>
public partial class RGrundyRopeComponent : BmSDK.BmGame.RRope2Component, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RGrundyRopeComponent", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RGrundyRopeComponent() { }

    /// <summary>
    /// Constructs a new RGrundyRopeComponent
    /// </summary>
    public RGrundyRopeComponent(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RGrundyRopeComponent Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RGrundyRopeComponent(nint ptr) : base(ptr) { }

}
