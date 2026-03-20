#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Class: ShaderCache<br/>
/// (size = 172)
/// (flags = 268435584)
/// </summary>
public partial class ShaderCache : BmSDK.GameObject, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Engine.ShaderCache", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal ShaderCache() { }

    /// <summary>
    /// Constructs a new ShaderCache
    /// </summary>
    public ShaderCache(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, ShaderCache Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected ShaderCache(nint ptr) : base(ptr) { }

}
