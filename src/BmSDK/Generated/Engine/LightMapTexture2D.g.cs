#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Class: LightMapTexture2D<br/>
/// (size = 332)
/// (flags = 268435584)
/// </summary>
public partial class LightMapTexture2D : BmSDK.Engine.Texture2D, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Engine.LightMapTexture2D", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal LightMapTexture2D() { }

    /// <summary>
    /// Constructs a new LightMapTexture2D
    /// </summary>
    public LightMapTexture2D(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, LightMapTexture2D Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected LightMapTexture2D(nint ptr) : base(ptr) { }

}
