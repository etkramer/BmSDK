#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Class: DrawLightConeComponent<br/>
/// (size = 420)
/// (flags = 2290102418)
/// </summary>
public partial class DrawLightConeComponent : BmSDK.Engine.DrawConeComponent, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Engine.DrawLightConeComponent", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal DrawLightConeComponent() { }

    /// <summary>
    /// Constructs a new DrawLightConeComponent
    /// </summary>
    public DrawLightConeComponent(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, DrawLightConeComponent Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected DrawLightConeComponent(nint ptr) : base(ptr) { }

}
