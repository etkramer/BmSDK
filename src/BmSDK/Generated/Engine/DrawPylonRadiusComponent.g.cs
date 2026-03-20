#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Class: DrawPylonRadiusComponent<br/>
/// (size = 564)
/// (flags = 2290102482)
/// </summary>
public partial class DrawPylonRadiusComponent : BmSDK.Engine.DrawSphereComponent, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Engine.DrawPylonRadiusComponent", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal DrawPylonRadiusComponent() { }

    /// <summary>
    /// Constructs a new DrawPylonRadiusComponent
    /// </summary>
    public DrawPylonRadiusComponent(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, DrawPylonRadiusComponent Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected DrawPylonRadiusComponent(nint ptr) : base(ptr) { }

}
