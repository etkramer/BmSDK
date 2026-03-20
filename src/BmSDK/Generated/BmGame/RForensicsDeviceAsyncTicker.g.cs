#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RForensicsDeviceAsyncTicker<br/>
/// (size = 124)
/// (flags = 134217874)
/// </summary>
public partial class RForensicsDeviceAsyncTicker : BmSDK.Engine.ActorComponent, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RForensicsDeviceAsyncTicker", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RForensicsDeviceAsyncTicker() { }

    /// <summary>
    /// Constructs a new RForensicsDeviceAsyncTicker
    /// </summary>
    public RForensicsDeviceAsyncTicker(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RForensicsDeviceAsyncTicker Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RForensicsDeviceAsyncTicker(nint ptr) : base(ptr) { }

}
