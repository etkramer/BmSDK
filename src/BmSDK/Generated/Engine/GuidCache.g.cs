#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Class: GuidCache<br/>
/// (size = 172)
/// (flags = 268435584)
/// </summary>
public partial class GuidCache : BmSDK.GameObject, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Engine.GuidCache", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal GuidCache() { }

    /// <summary>
    /// Constructs a new GuidCache
    /// </summary>
    public GuidCache(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, GuidCache Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected GuidCache(nint ptr) : base(ptr) { }

}
