#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RDmgType_BeatDownCritical<br/>
/// (size = 236)
/// (flags = 18)
/// </summary>
public partial class RDmgType_BeatDownCritical : BmSDK.BmGame.RDmgType_BeatDown, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RDmgType_BeatDownCritical", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RDmgType_BeatDownCritical() { }

    /// <summary>
    /// Constructs a new RDmgType_BeatDownCritical
    /// </summary>
    public RDmgType_BeatDownCritical(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RDmgType_BeatDownCritical Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RDmgType_BeatDownCritical(nint ptr) : base(ptr) { }

}
