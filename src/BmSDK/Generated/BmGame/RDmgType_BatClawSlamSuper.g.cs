#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RDmgType_BatClawSlamSuper<br/>
/// (size = 120)
/// (flags = 18)
/// </summary>
public partial class RDmgType_BatClawSlamSuper : BmSDK.BmGame.RDmgType_BatClawSlam, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RDmgType_BatClawSlamSuper", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RDmgType_BatClawSlamSuper() { }

    /// <summary>
    /// Constructs a new RDmgType_BatClawSlamSuper
    /// </summary>
    public RDmgType_BatClawSlamSuper(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RDmgType_BatClawSlamSuper Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RDmgType_BatClawSlamSuper(nint ptr) : base(ptr) { }

}
