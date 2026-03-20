#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RConfig<br/>
/// (size = 84)
/// (flags = 0)
/// </summary>
public partial class RConfig : BmSDK.GameObject, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RConfig", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RConfig() { }

    /// <summary>
    /// Constructs a new RConfig
    /// </summary>
    public RConfig(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RConfig Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RConfig(nint ptr) : base(ptr) { }

}
