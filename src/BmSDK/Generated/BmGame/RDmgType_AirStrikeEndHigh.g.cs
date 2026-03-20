#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RDmgType_AirStrikeEndHigh<br/>
/// (size = 236)
/// (flags = 18)
/// </summary>
public partial class RDmgType_AirStrikeEndHigh : BmSDK.BmGame.RDmgType_AirStrikeEnd, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RDmgType_AirStrikeEndHigh", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RDmgType_AirStrikeEndHigh() { }

    /// <summary>
    /// Constructs a new RDmgType_AirStrikeEndHigh
    /// </summary>
    public RDmgType_AirStrikeEndHigh(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RDmgType_AirStrikeEndHigh Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RDmgType_AirStrikeEndHigh(nint ptr) : base(ptr) { }

}
