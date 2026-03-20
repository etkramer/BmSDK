#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: ROutcastWaveController<br/>
/// (size = 412)
/// (flags = 33562642)
/// </summary>
public partial class ROutcastWaveController : BmSDK.BmGame.RBMWaveController, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.ROutcastWaveController", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal ROutcastWaveController() { }

    /// <summary>
    /// Constructs a new ROutcastWaveController
    /// </summary>
    public ROutcastWaveController(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, ROutcastWaveController Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected ROutcastWaveController(nint ptr) : base(ptr) { }

}
