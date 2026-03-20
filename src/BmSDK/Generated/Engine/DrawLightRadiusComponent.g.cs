#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Class: DrawLightRadiusComponent<br/>
/// (size = 564)
/// (flags = 0)
/// </summary>
public partial class DrawLightRadiusComponent : BmSDK.Engine.DrawSphereComponent, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Engine.DrawLightRadiusComponent", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal DrawLightRadiusComponent() { }

    /// <summary>
    /// Constructs a new DrawLightRadiusComponent
    /// </summary>
    public DrawLightRadiusComponent(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, DrawLightRadiusComponent Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected DrawLightRadiusComponent(nint ptr) : base(ptr) { }

}
