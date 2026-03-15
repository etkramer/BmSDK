#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// ABSTRACT Class: MapInfo<br/>
/// (size = 44)
/// (flags = 134221971)
/// </summary>
public partial class MapInfo : BmSDK.GameObject, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Engine.MapInfo", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal MapInfo() { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected MapInfo(nint ptr) : base(ptr) { }

}
