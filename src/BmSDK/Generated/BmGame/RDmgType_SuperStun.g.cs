#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RDmgType_SuperStun<br/>
/// (size = 236)
/// (flags = 0)
/// </summary>
public partial class RDmgType_SuperStun : BmSDK.BmGame.RDmgType_BlockBreaker, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RDmgType_SuperStun", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RDmgType_SuperStun() { }

    /// <summary>
    /// Constructs a new RDmgType_SuperStun
    /// </summary>
    public RDmgType_SuperStun(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RDmgType_SuperStun Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RDmgType_SuperStun(nint ptr) : base(ptr) { }

}
