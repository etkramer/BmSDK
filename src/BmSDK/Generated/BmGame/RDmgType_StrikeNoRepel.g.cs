#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RDmgType_StrikeNoRepel<br/>
/// (size = 236)
/// (flags = 0)
/// </summary>
public partial class RDmgType_StrikeNoRepel : BmSDK.BmGame.RDmgType_Strike, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RDmgType_StrikeNoRepel", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RDmgType_StrikeNoRepel() { }

    /// <summary>
    /// Constructs a new RDmgType_StrikeNoRepel
    /// </summary>
    public RDmgType_StrikeNoRepel(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RDmgType_StrikeNoRepel Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RDmgType_StrikeNoRepel(nint ptr) : base(ptr) { }

}
