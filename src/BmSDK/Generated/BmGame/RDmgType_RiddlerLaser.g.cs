#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RDmgType_RiddlerLaser<br/>
/// (flags = 0)
/// </summary>
public partial class RDmgType_RiddlerLaser : BmSDK.BmGame.RDmgType_NoXP, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RDmgType_RiddlerLaser", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RDmgType_RiddlerLaser() { }

    /// <summary>
    /// Constructs a new RDmgType_RiddlerLaser
    /// </summary>
    public RDmgType_RiddlerLaser(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RDmgType_RiddlerLaser Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RDmgType_RiddlerLaser(nint ptr) : base(ptr) { }

}
