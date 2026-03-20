#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Class: MapInfo<br/>
/// (size = 84)
/// (flags = 0)
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
    /// Constructs a new MapInfo
    /// </summary>
    public MapInfo(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, MapInfo Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected MapInfo(nint ptr) : base(ptr) { }

}
