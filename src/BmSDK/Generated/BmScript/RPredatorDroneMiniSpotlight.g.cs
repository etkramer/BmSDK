#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmScript;

/// <summary>
/// Class: RPredatorDroneMiniSpotlight<br/>
/// (size = 820)
/// (flags = 0)
/// </summary>
public partial class RPredatorDroneMiniSpotlight : BmSDK.Engine.SpotLightComponent, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmScript.RPredatorDroneMiniSpotlight", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RPredatorDroneMiniSpotlight() { }

    /// <summary>
    /// Constructs a new RPredatorDroneMiniSpotlight
    /// </summary>
    public RPredatorDroneMiniSpotlight(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RPredatorDroneMiniSpotlight Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RPredatorDroneMiniSpotlight(nint ptr) : base(ptr) { }

}
