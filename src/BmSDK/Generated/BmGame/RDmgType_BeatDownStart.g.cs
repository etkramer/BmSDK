#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RDmgType_BeatDownStart<br/>
/// (size = 140)
/// (flags = 18)
/// </summary>
public partial class RDmgType_BeatDownStart : BmSDK.BmGame.RDmgType_BeatDown, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RDmgType_BeatDownStart", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RDmgType_BeatDownStart() { }

    /// <summary>
    /// Constructs a new RDmgType_BeatDownStart
    /// </summary>
    public RDmgType_BeatDownStart(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RDmgType_BeatDownStart Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RDmgType_BeatDownStart(nint ptr) : base(ptr) { }

}
