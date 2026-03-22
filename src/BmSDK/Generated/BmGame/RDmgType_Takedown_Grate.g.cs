#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RDmgType_Takedown_Grate<br/>
/// (size = 120)
/// (flags = 18)
/// </summary>
public partial class RDmgType_Takedown_Grate : BmSDK.BmGame.RDmgType_Takedown, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RDmgType_Takedown_Grate", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RDmgType_Takedown_Grate() { }

    /// <summary>
    /// Constructs a new RDmgType_Takedown_Grate
    /// </summary>
    public RDmgType_Takedown_Grate(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RDmgType_Takedown_Grate Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RDmgType_Takedown_Grate(nint ptr) : base(ptr) { }

}
