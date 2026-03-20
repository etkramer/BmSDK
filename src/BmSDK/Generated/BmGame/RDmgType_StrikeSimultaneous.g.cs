#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RDmgType_StrikeSimultaneous<br/>
/// (flags = 0)
/// </summary>
public partial class RDmgType_StrikeSimultaneous : BmSDK.BmGame.RDmgType_Strike, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RDmgType_StrikeSimultaneous", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RDmgType_StrikeSimultaneous() { }

    /// <summary>
    /// Constructs a new RDmgType_StrikeSimultaneous
    /// </summary>
    public RDmgType_StrikeSimultaneous(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RDmgType_StrikeSimultaneous Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RDmgType_StrikeSimultaneous(nint ptr) : base(ptr) { }

}
