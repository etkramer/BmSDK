#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RGameViewportClient<br/>
/// (size = 460)
/// (flags = 62)
/// </summary>
public partial class RGameViewportClient : BmSDK.Engine.GameViewportClient, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RGameViewportClient", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RGameViewportClient() { }

    /// <summary>
    /// Constructs a new RGameViewportClient
    /// </summary>
    public RGameViewportClient(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RGameViewportClient Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RGameViewportClient(nint ptr) : base(ptr) { }

}
