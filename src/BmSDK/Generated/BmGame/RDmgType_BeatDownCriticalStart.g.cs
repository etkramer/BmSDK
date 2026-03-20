#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RDmgType_BeatDownCriticalStart<br/>
/// (size = 236)
/// (flags = 18)
/// </summary>
public partial class RDmgType_BeatDownCriticalStart : BmSDK.BmGame.RDmgType_BeatDownStart, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RDmgType_BeatDownCriticalStart", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    internal RDmgType_BeatDownCriticalStart() { }

    /// <summary>
    /// Constructs a new RDmgType_BeatDownCriticalStart
    /// </summary>
    public RDmgType_BeatDownCriticalStart(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, RDmgType_BeatDownCriticalStart Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RDmgType_BeatDownCriticalStart(nint ptr) : base(ptr) { }

}
