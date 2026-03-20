#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RGameSearchCoop<br/>
/// (size = 320)
/// (flags = 50)
/// </summary>
public partial class RGameSearchCoop : BmSDK.Engine.OnlineGameSearch, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RGameSearchCoop", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RGameSearchCoop() { }

    /// <summary>
    /// Constructs a new RGameSearchCoop
    /// </summary>
    public RGameSearchCoop(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RGameSearchCoop Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RGameSearchCoop(nint ptr) : base(ptr) { }

}
